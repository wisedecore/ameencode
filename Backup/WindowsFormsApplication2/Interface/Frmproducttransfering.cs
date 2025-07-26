using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmproducttransfering : Form
    {
        public Frmproducttransfering()
        {
            InitializeComponent();
        }
        string Batch;
        string TCode;
        string ID;
        Double Balance;
        bool RemoveMinusStock;
        double Srate;
        double Prate;
        double qty;


        string Sql;
        bool SBatch;

        public string FromCompany;
        public string Tocompany;
        public double TAmount;

        string Temp;
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen = new Generalfunction();
        public DataSet Ds;
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        ClsCompanyCreate _ComCreate = new ClsCompanyCreate();
        NextGFuntion _Nextg = new NextGFuntion();
        clsitemCategory _ItemCategory = new clsitemCategory();
        ClsManufacturer _Manufacturer = new ClsManufacturer();

        public string TableFields(string TableName)
        {
            if (TableName == "tblinventory")
            {
                Temp = "Dcode,InvDate,Pcode,Os,Purchase,Mr,Sr,Ireceipt,bmr,Sales,dn,dnr,pr,iissue,Sh,dmg,bmi,vcode,ledcode,costcenter,batchcode,freepre,freeiss,Slno";
            }

            if (TableName == "tblbatch")
            {
                Temp = "bcode,itemid,costcenter,depo,bid,ledcode,Recptcode,mrp,srate,prate";
            }

            if (TableName == "tblreceiptdetails")
            {
                Temp = "RecptCode,Slno,Pcode,Unitid,BatchId,MultirateId,Qty,FreeQty,Rate,DiscRate,billdisc,Taxrate,NetAmt,ItemNote,ItemNote1,srate,crate,ledcode,Mrp,vtype,Taxper,exciseduty";
            }

            if (TableName == "tbltransactionreceipt")
            {
                Temp = "ReptCode,Vno,RecptType,Dcode,RecptDate,LedcodeCr,LedcodeDr,Amt,Remarks,Empid,DiscAmt,invdisc,TaxAmt,Cooly,adamount,agent,pvno,srate,crate,taxid,Refno,Tename";
            }
            return Temp;
        }
        public void TableDataTransfering(string TableName)
        {
            Temp = TableFields(TableName.ToLower());
             _Dbtask.ExecuteNonQuery("INSERT INTO " + Tocompany + ".."+TableName +" ("+Temp+") "+
                                " SELECT "+ Temp +" FROM  " + FromCompany + ".." + TableName + "");
        }
        public void InsertClosingStock()
        {
            SetCompany();
            TransferingStockBalance();
        }
        public void InsertAllBatches()
        {
            if (SBatch == true)
            {
                string sql2;
                string Batchcode;
                string Pcode;
                sql2 = "  SELECT         TblInventory.batchcode, TblInventory.pcode,0,0,0,0,0,0,0,0 FROM  " + FromCompany + ".. " +
                " TblInventory LEFT OUTER JOIN " +
                       " Tblbatch ON  TblInventory.batchcode=Tblbatch.Bcode GROUP BY  TBLBATCH.BCODE ,TBLINVENTORY.BATCHCODE,TblInventory.PCode " +
                       " having   TBLBATCH.BCODE IS NULL AND TblInventory.batchcode NOT IN('','0')";
                Ds = CommonClass._Dbtask.ExecuteQuery(sql2);
                for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                {
                    Batchcode = Ds.Tables[0].Rows[k]["batchcode"].ToString();
                    Pcode = Ds.Tables[0].Rows[k]["pcode"].ToString();

                    Sql = "insert into " + Tocompany + "..tblbatch(bcode,itemid,costcenter,depo,bid,ledcode,mrp,srate,prate,recptcode)  values" +
            "('" + Batchcode + "'," + Pcode + ",0,0,'0','0',0,0,0,0) ";
                    CommonClass._Dbtask.ExecuteNonQuery(Sql);
                }
            }
        }
        public void TransferingStockBalance()
        {
            Generalfunction.OpCompany = FromCompany;
            Generalfunction.TempCompanyname = "";
            TAmount = 0;
            if(chkwithbatch.Checked==true)
            InsertAllBatches();
            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
            {
                SBatch = true;
            }

            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblitemmaster");
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                Generalfunction.OpCompany = Tocompany;
                CommonClass._Transactionreceipt.IdOpeningStockFu();
                TCode = CommonClass._Transactionreceipt.RcptCodeLng.ToString();

                ID = CommonClass.Ds.Tables[0].Rows[i]["itemid"].ToString();
                if (SBatch == true)
                {

                    Generalfunction.OpCompany = FromCompany;
                    Sql = "select * from tblbatch where itemid='" + ID + "'";
                    CommonClass.Ds1 = CommonClass._Dbtask.ExecuteQuery(Sql);
                    for (int k = 0; k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                    {
                        Generalfunction.OpCompany = FromCompany;
                        
                        Batch = CommonClass.Ds1.Tables[0].Rows[k]["bcode"].ToString();
                        if (Batch == "3722")
                        {
                        }
                        Balance = Convert.ToDouble(CommonClass._Inventory.GetStock(" where pcode='" + ID + "' and batchcode='" + Batch + "'"));


                        if (Balance != 0)
                        {
                            if (RemoveMinusStock == true)
                            {
                                if (Balance > 0)
                                {
                                    Generalfunction.OpCompany = Tocompany;
                                    CommonClass._Inventory.Vcode = TCode.ToString();
                                    CommonClass._Inventory.DCodeStr = "0";
                                    CommonClass._Inventory.InvDateDt = DateTime.Now;
                                    CommonClass._Inventory.PcodeStr = ID;
                                    CommonClass._Inventory.Os = Balance;
                                    CommonClass._Inventory.Batchcode = Batch;
                                    CommonClass._Inventory.InsertInventory();

                                    /*For Receipt Details*/
                                    CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                    CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                    CommonClass._ReceiptDetails.PCodeStr = ID;
                                    CommonClass._ReceiptDetails.UnitIdLng = 0;
                                    CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                    CommonClass._ReceiptDetails.QtyDb = Balance;
                                    CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                    CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                    CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                    CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                    CommonClass._ReceiptDetails.Vtype = "OS";
                                    CommonClass._ReceiptDetails.InsertReceiptDetails();
                                }
                            }
                            else
                            {
                                Generalfunction.OpCompany = Tocompany;
                                CommonClass._Inventory.Vcode = TCode.ToString();
                                CommonClass._Inventory.DCodeStr = "0";
                                CommonClass._Inventory.InvDateDt = DateTime.Now;
                                CommonClass._Inventory.PcodeStr = ID;
                                CommonClass._Inventory.Os = Balance;
                                CommonClass._Inventory.Batchcode = Batch;
                                CommonClass._Inventory.InsertInventory();

                                /*For Receipt Details*/
                                CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                CommonClass._ReceiptDetails.PCodeStr = ID;
                                CommonClass._ReceiptDetails.UnitIdLng = 0;
                                CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                CommonClass._ReceiptDetails.QtyDb = Balance;
                                CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                CommonClass._ReceiptDetails.BatchIdstr = Batch;
                                CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                CommonClass._ReceiptDetails.Vtype = "OS";
                                CommonClass._ReceiptDetails.InsertReceiptDetails();
                            }
                        }
                    }
                }
                else
                {
                    Generalfunction.OpCompany = FromCompany;
                    Balance = Convert.ToDouble(CommonClass._Inventory.GetStock(" where pcode='" + ID + "' "));
                    if (Balance != 0)
                    {
                        if (RemoveMinusStock == true)
                        {
                            if (Balance > 0)
                            {
                                Generalfunction.OpCompany = Tocompany;
                                CommonClass._Inventory.Vcode = TCode.ToString();
                                CommonClass._Inventory.DCodeStr = "0";
                                CommonClass._Inventory.InvDateDt = DateTime.Now;
                                CommonClass._Inventory.PcodeStr = ID;
                                CommonClass._Inventory.Os = Balance;
                                CommonClass._Inventory.Batchcode = "";
                                CommonClass._Inventory.InsertInventory();

                                /*For Receipt Details*/
                                CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                                CommonClass._ReceiptDetails.SlNoLng = i + 1;
                                CommonClass._ReceiptDetails.PCodeStr = ID;
                                CommonClass._ReceiptDetails.UnitIdLng = 0;
                                CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                                CommonClass._ReceiptDetails.QtyDb = Balance;
                                CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                                CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                                CommonClass._ReceiptDetails.BatchIdstr = "";
                                CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                                CommonClass._ReceiptDetails.Vtype = "OS";
                                CommonClass._ReceiptDetails.InsertReceiptDetails();
                                TAmount = TAmount + qty * Prate;
                            }
                        }
                        else
                        {
                            Generalfunction.OpCompany = Tocompany;
                            CommonClass._Inventory.Vcode = TCode.ToString();
                            CommonClass._Inventory.DCodeStr = "0";
                            CommonClass._Inventory.InvDateDt = DateTime.Now;
                            CommonClass._Inventory.PcodeStr = ID;
                            CommonClass._Inventory.Os = Balance;
                            CommonClass._Inventory.Batchcode = "";
                            CommonClass._Inventory.InsertInventory();

                            /*For Receipt Details*/
                            CommonClass._ReceiptDetails.RcptCodeLng = Convert.ToInt64(TCode);
                            CommonClass._ReceiptDetails.SlNoLng = i + 1;
                            CommonClass._ReceiptDetails.PCodeStr = ID;
                            CommonClass._ReceiptDetails.UnitIdLng = 0;
                            CommonClass._ReceiptDetails.MultiRateIdLng = 0;
                            CommonClass._ReceiptDetails.QtyDb = Balance;
                            CommonClass._ReceiptDetails.SRate = Convert.ToDouble(Srate);
                            CommonClass._ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                            CommonClass._ReceiptDetails.BatchIdstr = "";
                            CommonClass._ReceiptDetails.NetAmtDb = qty * Prate;
                            CommonClass._ReceiptDetails.Vtype = "OS";
                            CommonClass._ReceiptDetails.InsertReceiptDetails();
                            TAmount = TAmount + qty * Prate;
                        }
                    }
                }
            }
            if (TAmount > 0)
            {
                Generalfunction.OpCompany = Tocompany;
                CommonClass._Transactionreceipt.RcptCodeLng =Convert.ToInt64(TCode);
                CommonClass._Transactionreceipt.VNoStr = TCode.ToString();
                CommonClass._Transactionreceipt.RCptTypeStr = "OS";
                CommonClass._Transactionreceipt.DcodeStr = "0";
                CommonClass._Transactionreceipt.RcptDateDt = DateTime.Now;
                CommonClass._Transactionreceipt.AMTDb = TAmount;
                CommonClass._Transactionreceipt.RemarkStr = "";
                CommonClass._Transactionreceipt.LedCodeCr = Convert.ToString(0);
                CommonClass._Transactionreceipt.LedCodeDr = Convert.ToString(0);
                CommonClass._Transactionreceipt.EmpId = Convert.ToString(0);
                CommonClass._Transactionreceipt.InsertTransactionReceipt();

            }

        }
        public void InsertOpeningStock()
        {
            SetCompany();
            TableDataTransfering("TblInventory");
            TableDataTransfering("tbltransactionreceipt");
            TableDataTransfering("tblreceiptdetails");
            TableDataTransfering("tblbatch");
        }

        public void SetCompany()
        {
            FromCompany = comfromdb.Text;
            Tocompany = comtodb.Text;
        }
        public void SetFromCompany()
        {
            Generalfunction.TempCompanyname = comfromdb.Text;
        }

        public void SetTocompany()
        {
            Generalfunction.TempCompanyname = comtodb.Text;
        }

        public void ProductTRansfering()
        {
            /*For Item Category*/
            SetFromCompany();
            Ds = _Dbtask.ExecuteQuery("select * from tblitemcategory");
            SetTocompany();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (Ds.Tables[0].Rows[i]["categoryid"].ToString() != "0")
                {
                    _ItemCategory.CategoryIdLng = Convert.ToInt64(Ds.Tables[0].Rows[i]["categoryid"]);
                    _ItemCategory.CategoryNameStr = Ds.Tables[0].Rows[i]["category"].ToString();
                    _ItemCategory.RemarkStr = Ds.Tables[0].Rows[i]["remarks"].ToString();
                }
            }

            /*For Manfacture*/
            Generalfunction.TempCompanyname = comfromdb.Text;

            Ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer");

            Generalfunction.TempCompanyname = comtodb.Text;

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (Ds.Tables[0].Rows[i]["Mid"].ToString() != "0")
                {
                    _Manufacturer.Mid = Convert.ToInt64(Ds.Tables[0].Rows[i]["Mid"]);
                    _Manufacturer.Mname = Ds.Tables[0].Rows[i]["mname"].ToString();

                }
            }


            /*For Item Master*/
            Generalfunction.TempCompanyname = comfromdb.Text;

            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster");

            Generalfunction.TempCompanyname = comtodb.Text;

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {


                _Itemmaster.ItemIdLng = Convert.ToInt64(Ds.Tables[0].Rows[i]["itemid"]);
                _Itemmaster.ItemCodeStr = Ds.Tables[0].Rows[i]["itemcode"].ToString();
                _Itemmaster.ItemNameStr = Ds.Tables[0].Rows[i]["itemname"].ToString();
                _Itemmaster.CategoryIdLng = Convert.ToInt64(Ds.Tables[0].Rows[i]["categoryid"]);
                _Itemmaster.DescriptionStr = Ds.Tables[0].Rows[i]["Description"].ToString();
                _Itemmaster.MRPDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["mrp"]);
                _Itemmaster.SRateDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"]);
                _Itemmaster.PRateDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["prate"]);
                _Itemmaster.ManufacturerLng = Convert.ToInt64(Ds.Tables[0].Rows[i]["manufacturer"]);
                _Itemmaster.StatusInt = Convert.ToInt16(Ds.Tables[0].Rows[i]["status"]);
                _Itemmaster.AgentCommisionDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["agentcommision"]);
                _Itemmaster.CoolyDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["cooly"]);
                _Itemmaster.MinStockDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["minstock"]);
                _Itemmaster.ReorderStockDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["reorder"]);
                _Itemmaster.MaximumDb = Convert.ToDouble(Ds.Tables[0].Rows[i]["maximum"]);
                _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                _Itemmaster.Unit = Ds.Tables[0].Rows[i]["maximum"].ToString();
                _Itemmaster.VAT = Convert.ToDouble(Ds.Tables[0].Rows[i]["vat"]);
                _Itemmaster.CST = Convert.ToDouble(Ds.Tables[0].Rows[i]["cst"]);
                _Itemmaster.Purtax = Convert.ToDouble(Ds.Tables[0].Rows[i]["purtax"]);
                _Itemmaster.Incp = Convert.ToInt16(Ds.Tables[0].Rows[i]["incp"]);
                _Itemmaster.Incs = Convert.ToInt16(Ds.Tables[0].Rows[i]["incp"]);
                _Itemmaster.InsertItems();
            }
        }

        private void comproductmastertransfering_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Transfer Processing Completed", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frmproducttransfering_Load(object sender, EventArgs e)
        {
            _Nextg.FormStylesett(this);
            //_Nextg.FormImage(pnlImage);
            _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            CompanyList();
            CommonClass._Nextg.FormIcon(this);
        }
        public void CompanyList()
        {
            Ds = _ComCreate.LoadCompany();
            comfromdb.Items.Clear();
            comtodb.Items.Clear();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    string TempLoadingCompany = Ds.Tables[0].Rows[i]["name"].ToString();
                    Generalfunction.TempCompanyname = TempLoadingCompany;
                    string Temp = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");

                    //if (Temp == "1")
                    //{
                        comfromdb.Items.Add(TempLoadingCompany);
                        comtodb.Items.Add(TempLoadingCompany);
                    //}
                }
                catch
                {
                }
            }
        }

        private bool ValidateFu()
        {
            if (chkopeningstock.Checked == false || chkproductmaster.Checked == false)
            {
                MessageBox.Show("Select Option", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool Main()
        {
            if (chkproductmaster.Checked == true)
            {
                ProductTRansfering();
            }
            if (chkopeningstock.Checked == true)
            {
                InsertOpeningStock();
            }
            if (chkclosingstock.Checked == true)
            {
                InsertClosingStock();
            }

            MessageBox.Show("Transfer Processing Completed", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void Cmdtransfering_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
