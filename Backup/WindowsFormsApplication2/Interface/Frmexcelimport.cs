using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmexcelimport : Form
    {
        public Frmexcelimport()
        {
            InitializeComponent();
        }
        int k;
        public string kk;
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        Clsbatch _Batch = new Clsbatch();
        ClsInventory _Inventory = new ClsInventory();
        Clssettings _Settings = new Clssettings();
        /*For Ledger Insert*/
        string Ledname;
        string LedaliasName;
        string Groupid;
        string Phone = "";
        string Address = "";
        string MObile = "";
        string Disc;
        string TaxregNo = "";
        string Email = "";
        string Area = "";
        string CreditDays;
        string CreditLimit;
        string Other = "";
        string commision;
        string CustomercardPlan;
        DateTime VDate;
        string GeneralVno;
        double Amount;
        string VType;
        double DBAmt;
        double CRAmt;
        string LedgerCode;

        /********************/
        double a;
        string Bcode;
        double Qty;
        double Prate;
        double Stax;
        double Cst;
        double Ptax;
        string Itemid;
        string Categoryid;
        string Manufactorid;
        public string ConnectionString;
        DataSet ds = new DataSet();
        DBTask _Dbtask = new DBTask();
        public Double TopeningstockAmount;
        private void Cmdopenexcel_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofImport = new OpenFileDialog();
            ofImport.Title = "Select file";
            ofImport.InitialDirectory = @"c:\";
            ofImport.FileName = txtFileName.Text;
            ofImport.Filter = "Excel Sheet(*.xlsx,*.xls)|*.xlsx|All Files(*.*)|*.*";
            ofImport.FilterIndex = 1;
            ofImport.RestoreDirectory = true;


            if (ofImport.ShowDialog() == DialogResult.OK)
            {

                string path = System.IO.Path.GetFullPath(ofImport.FileName);

                if (path.Trim().EndsWith(".xlsx"))
                {
                    ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", path);
                }
                else if (path.Trim().EndsWith(".xls"))
                {
                    ConnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", path);
                }
                listsheet();
                panel1.Visible = true;

            }
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(pnlphysicalstock);
                //CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        public void listsheet()
        {
            DataTable dt = new DataTable();
            dt = null;
            using (OleDbConnection oleDB = new OleDbConnection(ConnectionString))
            {
                oleDB.Open();
                dt = oleDB.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //if (dt == null)
                //    return null;


                int i = 0;

                //if (dt.Rows.Count > 1)
                //return null;  
                treeView1.Nodes.Clear();
                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {
                    string excelSheetName;
                    string lastCharacter = "";

                    excelSheetName = dt.Rows[rowIndex]["TABLE_NAME"].ToString();
                    excelSheetName = excelSheetName.Replace("'", "");
                    lastCharacter = excelSheetName.Substring(excelSheetName.Length - 1, 1);

                    // items.Items.Clear();
                    if (lastCharacter == "$")
                    {
                        //items.Add(dt.Rows[rowIndex]["TABLE_NAME"].ToString());

                        string a = dt.Rows[rowIndex]["TABLE_NAME"].ToString();
                        treeView1.Nodes.Add(a);
                        //items.Items.Add(a);


                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sName;
            string query;

            sName = treeView1.SelectedNode.Text;
            sName = sName.Replace("'", "");
            sName = sName.Replace("$", "");

            query = "";
            query = String.Format("select * from [{0}$]", sName);
            OleDbDataAdapter da = new OleDbDataAdapter(query, ConnectionString);

            if (ds.Tables.Count > 0)
            {
                ds.Tables[0].Clear();
            }
            da.Fill(ds);

            Gridmain.DataSource = null;
            Gridmain.DataSource = ds.Tables[0];
            panel1.Visible = false;
        }

        public void InsertTransactionReceipt()
        {
            _TransactionReceipt.VNoStr = Generalfunction.getnextidCondition("vno", "tbltransactionreceipt", " where recpttype='OS'");
            _TransactionReceipt.RCptTypeStr = "OS";
            _TransactionReceipt.DcodeStr = "0";
            _TransactionReceipt.RcptDateDt = DateTime.Now;
            _TransactionReceipt.RemarkStr = "IC";
            double Temp = Convert.ToDouble(_Dbtask.ExecuteScalar("select sum(netamt) from tblreceiptdetails"));
            _TransactionReceipt.AMTDb = TopeningstockAmount;
            _TransactionReceipt.InsertTransactionReceipt();
        }

        public void InsertLedger()
        {
            try
            {
                /*Account Ledger */
                _AccountLedger.IdAccountLedger();
                LedgerCode = Convert.ToString(_AccountLedger.LidLng);
                _AccountLedger.LNameStr = Ledname;
                _AccountLedger.LAliasNameStr = LedaliasName;
                _AccountLedger.GidLng = Convert.ToInt64(Groupid);
                _AccountLedger.AddressStr = Address;
                _AccountLedger.PhoneStr = Phone;
                _AccountLedger.MobileStr = MObile;
                _AccountLedger.DiscDb = Convert.ToDouble(Disc);
                _AccountLedger.TaxRegNoStr = TaxregNo;
                _AccountLedger.EmailStr = Email;

                _AccountLedger.AreaStr = Area;
                _AccountLedger.CreditDaysInt = Convert.ToDouble(CreditDays);
                _AccountLedger.CreditLimitDb = Convert.ToDouble(CreditLimit);
                _AccountLedger.OtherStr = Other;
                _AccountLedger.Commision = Convert.ToDouble(commision);
                _AccountLedger.Cplan = Convert.ToInt64(CustomercardPlan);
                _AccountLedger.InsertLedger();

                /*General Ledger */
                if (DBAmt != 0.0 || CRAmt != 0.0)
                {
                    _GeneralLedger.IdGeneralLedger(" where vtype='OB'");
                    _GeneralLedger.VdateDt = VDate;
                    _GeneralLedger.VTypeStr = "OB";
                    GeneralVno = _GeneralLedger.VnoStr;
                    _GeneralLedger.VnoStr = GeneralVno;
                    _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                    _GeneralLedger.LedCodeStr = LedgerCode;
                    _GeneralLedger.PurticularsStr = "Opening Balance";
                    _GeneralLedger.RefnoStr = "1001";
                    _GeneralLedger.DbAmtDb = DBAmt;
                    _GeneralLedger.CrAmt = CRAmt;
                    _GeneralLedger.InsertGeneralLedger();
                }
            }
            catch
            {
            }
        }

        public void InsertOpeningstock(string StrBcode)
        {
            double OpeningStockAmount = 0;// Convert.ToDouble(Qty) * Convert.ToDouble(Prate);

           string vnnn  = CommonClass._Transactionreceipt.getosvno();
               //_Dbtask.znllString(_Dbtask.ExecuteScalar("SELECT     cast( MAX(  ReptCode) as int   )+1  " +
                                             // " FRom TblTransactionReceipt where RecptType='OS' "));

          //int vhh = Convert.ToInt32(_Dbtask.ExecuteScalar("SELECT     cast( MAX(  ReptCode) as int   )+1  " +
                                            //" FRom TblTransactionReceipt where RecptType='OS' "));


           _ReceiptDetails.RcptCodeLng = Convert.ToInt64(vnnn);
            _ReceiptDetails.SlNoLng = Convert.ToInt64(1);
            _ReceiptDetails.PCodeStr = Itemid;
            _ReceiptDetails.UnitIdLng = Convert.ToInt64(0);
            _ReceiptDetails.MultiRateIdLng = Convert.ToInt64(0);
            _ReceiptDetails.QtyDb = Qty;
            _ReceiptDetails.RateDb = Convert.ToDouble(Prate);
            _ReceiptDetails.SRate = Convert.ToDouble(0);
            _ReceiptDetails.CRate = Convert.ToDouble(0);
            _ReceiptDetails.QtyFreeDb = Convert.ToDouble(0);
            _ReceiptDetails.NetAmtDb = OpeningStockAmount;
            _ReceiptDetails.BatchIdstr = StrBcode;
            _ReceiptDetails.DiscDb = Convert.ToDouble(0); ;
            _ReceiptDetails.Ledcode = "";
            _ReceiptDetails.Mrp = Convert.ToDouble(0);
            _ReceiptDetails.TaxRateDb = Convert.ToDouble(0);
            _ReceiptDetails.Vtype = "OS";
            _ReceiptDetails.billtot = 0;
            _ReceiptDetails.InsertReceiptDetails();

            _Inventory.DCodeStr = "0";
            _Inventory.Os = Qty;
            _Inventory.Vcode = _TransactionReceipt.RcptCodeLng.ToString();
            _Inventory.InvDateDt = DateTime.Now;
            _Inventory.PcodeStr = Itemid;
            _Inventory.Batchcode = StrBcode;
            _Inventory.InsertInventory();
            TopeningstockAmount = TopeningstockAmount + OpeningStockAmount;
        }
        private void Cmdinsertproduct_Click(object sender, EventArgs e)
        {

            if (chkincludebatch.Checked == true)
                ProductInsertWithBatch();
            else
                ProductInsert();
        }
        public void OpeningStockInsert()
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                        //if (i == 189)
                        //{

                        //}

                        bool isNumeric;
                        string Itemname = Gridmain.Rows[i].Cells[5].Value.ToString();
                        Itemname = Itemname.Replace("'", "");
                        //Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname ='" + Itemname + "'");

                        Itemid =_Dbtask.znllString( Gridmain.Rows[i].Cells[5].Value);
                        
                        int n;
                        double x;
                       // isNumeric = double.TryParse(Gridmain.Rows[i].Cells[7].Value.ToString(), out x);
                        Bcode = _Dbtask.znllString( Gridmain.Rows[i].Cells[6].Value);
                       
                        //if (isNumeric == true)
                        //{
                            Qty = Convert.ToDouble(Gridmain.Rows[i].Cells[7].Value.ToString());
                        //}
                        //else
                        //{
                        //    Qty = 0;
                        //}

                            if (Qty>0)
                        {
                        InsertOpeningstock(Bcode);
                        }
                    }
                    else
                    {

                    }

                }
                if (TopeningstockAmount > 0)
                {
                    InsertTransactionReceipt();
                }
                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error !!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertTransactionReceipt();
        }
        public void InsertBatchTable(string Itemid, string Bcode, string costcenter, string Depo, string Ledcode, string MRP, string Srate, string SPrate, string Bid, string OpQty)
        {
            _Batch.Itemid = Itemid;
            _Batch.Bcode = Bcode;
            _Batch.Costcenter = costcenter;
            _Batch.Depo = Depo;
            _Batch.Ledcode = Ledcode;
            _Batch.Mrp = _Dbtask.znullDouble(MRP);
            _Batch.Prate = _Dbtask.znullDouble(SPrate);
            _Batch.Srate = _Dbtask.znullDouble(Srate);
            _Batch.Bid = Bid;
            _Batch.Recptcode = "0";
            _Batch.InsertBatch();

        }
        public void ProductInsertwithBatchNotepad()
        {
            try
            {
                for (int i = 1; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    // if (_Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value).Length > 2)
                    if (_Dbtask.znllString(Gridmain.Rows[i].Cells[1].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[9].Value) != "")
                    {
                        //if(_Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value).Substring(1,1)!=".")
                        //{
                        double DMRP;
                        double DSrate;
                        if (i > 10)
                        {
                        }
                        Double.TryParse(Gridmain.Rows[i].Cells[3].Value.ToString(), out DMRP);
                        Double.TryParse(Gridmain.Rows[i].Cells[4].Value.ToString(), out DSrate);
                        Double.TryParse(Gridmain.Rows[i].Cells[5].Value.ToString(), out Prate);
                        Double.TryParse(Gridmain.Rows[i].Cells[12].Value.ToString(), out Qty);


                        string Llangage = Gridmain.Rows[i].Cells[11].Value.ToString().Replace("'", "");
                        string ItemCode = Gridmain.Rows[i].Cells[1].Value.ToString().Replace("'", "");
                        string ItemName = Gridmain.Rows[i].Cells[2].Value.ToString().Replace("'", "");
                        Bcode = Gridmain.Rows[i].Cells[9].Value.ToString().Replace(".00", "");
                        string Bid = "0";

                        if (i == 9753)
                        {
                        }

                        if (Bcode == "A115U")
                        {
                        }


                        //if (Bcode == "")
                        //{
                        //    Bcode = "HA2506";
                        //    kk =kk+"\n"+ (i + 2).ToString();
                        //}
                        if (i == 2090)
                        {
                        }
                        if (_Batch.SameNamealreadyexist(Bcode) == false)
                        {
                            _Itemmaster.IdItemName();
                            Itemid = _Itemmaster.ItemIdLng.ToString();
                            if (_Itemmaster.SameCodealreadyexist(ItemCode) == false)
                            {
                                /*For Category Describe*/

                                string Categoryid;
                                if (Gridmain.Rows[i].Cells[0].Value.ToString() == "None" || Gridmain.Rows[i].Cells[0].Value.ToString() == "")
                                {
                                    Categoryid = "0";
                                }
                                else
                                {
                                    ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where category='" + Gridmain.Rows[i].Cells[0].Value.ToString().Replace("'", "") + "'");
                                    if (ds.Tables[0].Rows.Count == 0)
                                    {
                                        clsitemCategory _Itemcategory = new clsitemCategory();
                                        _Itemcategory.IdCategory();
                                        _Itemcategory.CategoryNameStr = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                                        _Itemcategory.RemarkStr = "";
                                        _Itemcategory.InsertItemCategory();
                                    }
                                    Categoryid = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + Gridmain.Rows[i].Cells[0].Value.ToString().Replace("'", "") + "'");
                                }

                                /************************/

                                /*For Manufacture Describe*/
                                if (Gridmain.Rows[i].Cells[10].Value.ToString() == "<NONE>" || Gridmain.Rows[i].Cells[10].Value.ToString() == "")
                                {
                                    Manufactorid = "0";
                                }
                                else
                                {
                                    ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[10].Value.ToString().Replace("'", "") + "'");
                                    ClsManufacturer _manufacturer = new ClsManufacturer();
                                    if (ds.Tables[0].Rows.Count == 0)
                                    {

                                        _manufacturer.IdManufacturer();
                                        _manufacturer.Mname = Gridmain.Rows[i].Cells[10].Value.ToString().Replace("'", "");
                                        _manufacturer.Address = "";
                                        _manufacturer.Phone = "";
                                        _manufacturer.InsertManufacturer();

                                    }
                                    Manufactorid = _Dbtask.ExecuteScalar("select mid from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[10].Value.ToString().Replace("'", "") + "'");
                                }
                                /****************************************/


                                bool isNumeric;
                                _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                                _Itemmaster.ItemCodeStr = ItemCode;
                                _Itemmaster.ItemNameStr = ItemName;



                                _Itemmaster.MRPDb = DMRP;
                                _Itemmaster.SRateDb = DSrate;
                                _Itemmaster.PRateDb = Prate;

                                Double.TryParse(Gridmain.Rows[i].Cells[6].Value.ToString(), out Stax);
                                _Itemmaster.VAT = Stax;

                                Double.TryParse(Gridmain.Rows[i].Cells[7].Value.ToString(), out Cst);
                                _Itemmaster.CST = Cst;

                                Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out Ptax);
                                _Itemmaster.Purtax = Ptax;

                                _Itemmaster.Unit = "";

                                //_Itemmaster.ItemNameStr = TxtItemname.Text;
                                //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                                _Itemmaster.DescriptionStr = "";
                                //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                                //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                                //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                                _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);
                                _Itemmaster.ItemClass = "Stock Item";
                                _Itemmaster.Localaungage = Llangage;
                                _Itemmaster.StatusInt = 1;
                                _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                                _Itemmaster.CoolyDb = Convert.ToDouble(0);
                                _Itemmaster.MinStockDb = Convert.ToDouble(0);
                                _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                                _Itemmaster.MaximumDb = Convert.ToDouble(0);
                                _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                                //_Itemmaster.Unit = TxtUnit.Text;

                                _Itemmaster.Incp = -1;
                                _Itemmaster.Incs = 1;
                                _Itemmaster.InsertItems();


                                InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");
                                if (Qty != 0)
                                    InsertOpeningstock(Bcode);
                            }
                            else
                            {
                                Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname=N'" + ItemName + "'");
                                InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");
                                if (Qty > 0)
                                    InsertOpeningstock(Bcode);
                            }


                        }
                        else
                        {
                        }
                        //}
                    }
                    else
                    {
                    }
                }
                if (TopeningstockAmount > 0)
                {
                    InsertTransactionReceipt();
                }

                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }

        }

        public void ProductInsertWithBatch()
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    // if (_Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value).Length > 2)
                    if (_Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value) != "" && _Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value) != "")
                    {
                        //if(_Dbtask.znllString(Gridmain.Rows[i].Cells[14].Value).Substring(1,1)!=".")
                        //{
                        double DMRP;
                        double DSrate;
                        if (i > 10)
                        {
                        }
                        Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out DMRP);
                        Double.TryParse(Gridmain.Rows[i].Cells[9].Value.ToString(), out DSrate);
                        Double.TryParse(Gridmain.Rows[i].Cells[10].Value.ToString(), out Prate);
                        Double.TryParse(Gridmain.Rows[i].Cells[17].Value.ToString(), out Qty);


                        string Llangage = Gridmain.Rows[i].Cells[16].Value.ToString().Replace("'", "");
                        string ItemCode = Gridmain.Rows[i].Cells[6].Value.ToString().Replace("'", "");
                        string ItemName = Gridmain.Rows[i].Cells[7].Value.ToString().Replace("'", "");
                        Bcode = Gridmain.Rows[i].Cells[14].Value.ToString().Replace(".00", "");
                        string Bid = "0";

                        if (ItemCode.Length >50)
                        {
                            ItemCode = ItemCode.Substring(0, 49);
                        }

                        if (Bcode == "A115U")
                        {
                        }


                        //if (Bcode == "")
                        //{
                        //    Bcode = "HA2506";
                        //    kk =kk+"\n"+ (i + 2).ToString();
                        //}
                        if (i == 2090)
                        {
                        }
                        if (_Batch.SameNamealreadyexist(Bcode) == false)
                        {
                            _Itemmaster.IdItemName();
                            Itemid = _Itemmaster.ItemIdLng.ToString();
                            if (_Itemmaster.SameCodealreadyexist(ItemCode) == true)
                            {
                                for (int k = 1; k < 100; k++)
                                {
                                    ItemCode = ItemCode + k;
                                    if (_Itemmaster.SameCodealreadyexist(ItemCode) == false)
                                    {
                                        k = 100;
                                    }
                                }
                            }

                            if (_Itemmaster.SameCodealreadyexist(ItemCode) == false)
                            {
                                /*For Category Describe*/

                                string Categoryid;
                                if (Gridmain.Rows[i].Cells[5].Value.ToString() == "None" || Gridmain.Rows[i].Cells[5].Value.ToString() == "")
                                {
                                    Categoryid = "0";
                                }
                                else
                                {
                                    ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where category=N'" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                                    if (ds.Tables[0].Rows.Count == 0)
                                    {
                                        clsitemCategory _Itemcategory = new clsitemCategory();
                                        _Itemcategory.IdCategory();
                                        _Itemcategory.CategoryNameStr = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                                        _Itemcategory.RemarkStr = "";
                                        _Itemcategory.InsertItemCategory();
                                    }
                                    Categoryid = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category=N'" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                                }

                                /************************/

                                /*For Manufacture Describe*/
                                if (Gridmain.Rows[i].Cells[15].Value.ToString() == "<NONE>" || Gridmain.Rows[i].Cells[15].Value.ToString() == "")
                                {
                                    Manufactorid = "0";
                                }
                                else
                                {
                                    ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "") + "'");
                                    ClsManufacturer _manufacturer = new ClsManufacturer();
                                    if (ds.Tables[0].Rows.Count == 0)
                                    {

                                        _manufacturer.IdManufacturer();
                                        _manufacturer.Mname = Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "");
                                        _manufacturer.Address = "";
                                        _manufacturer.Phone = "";
                                        _manufacturer.InsertManufacturer();

                                    }
                                    Manufactorid = _Dbtask.ExecuteScalar("select mid from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "") + "'");
                                }
                                /****************************************/


                                bool isNumeric;
                                _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                                _Itemmaster.ItemCodeStr = ItemCode;
                                _Itemmaster.ItemNameStr = ItemName;



                                _Itemmaster.MRPDb = DMRP;
                                _Itemmaster.SRateDb = DSrate;
                                _Itemmaster.PRateDb = Prate;

                                Double.TryParse(Gridmain.Rows[i].Cells[11].Value.ToString(), out Stax);
                                _Itemmaster.VAT = Stax;

                                Double.TryParse(Gridmain.Rows[i].Cells[12].Value.ToString(), out Cst);
                                _Itemmaster.CST = Cst;

                                Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out Ptax);
                                _Itemmaster.Purtax = Ptax;

                                _Itemmaster.Unit = "";

                                //_Itemmaster.ItemNameStr = TxtItemname.Text;
                                //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                                _Itemmaster.DescriptionStr = "";
                                //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                                //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                                //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                                _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);
                                _Itemmaster.ItemClass = "Stock Item";
                                _Itemmaster.Localaungage = Llangage;
                                _Itemmaster.StatusInt = 1;
                                _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                                _Itemmaster.CoolyDb = Convert.ToDouble(0);
                                _Itemmaster.MinStockDb = Convert.ToDouble(0);
                                _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                                _Itemmaster.MaximumDb = Convert.ToDouble(0);
                                _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                                _Itemmaster.Bunit = "0";
                                _Itemmaster.Usingmechine = 1;
                                _Itemmaster.Incp = -1;
                                _Itemmaster.Incs = 1;
                                _Itemmaster.InsertItems();


                                InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");
                                if (Qty != 0)
                                    InsertOpeningstock(Bcode);
                            }
                            else
                            {
                                Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname=N'" + ItemName + "'");
                                InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");
                                if (Qty > 0)
                                    InsertOpeningstock(Bcode);
                            }


                        }
                        else
                        {
                        }
                        //}
                    }
                    else
                    {
                    }
                }
                if (TopeningstockAmount > 0)
                {
                    InsertTransactionReceipt();
                }

                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }

        }

        public void ProductInsertWithBatchUpdate()
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    // i = 31;  
                    if (_Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value) != "")
                    {

                        double DMRP;
                        double DSrate;
                        if (i > 10)
                        {
                        }
                        Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out DMRP);
                        Double.TryParse(Gridmain.Rows[i].Cells[9].Value.ToString(), out DSrate);
                        Double.TryParse(Gridmain.Rows[i].Cells[10].Value.ToString(), out Prate);
                        Double.TryParse(Gridmain.Rows[i].Cells[17].Value.ToString(), out Qty);


                        string Llangage = Gridmain.Rows[i].Cells[16].Value.ToString().Replace("'", "");
                        string ItemCode = Gridmain.Rows[i].Cells[6].Value.ToString().Replace("'", "");
                        string ItemName = Gridmain.Rows[i].Cells[7].Value.ToString().Replace("'", "");
                        Bcode = Gridmain.Rows[i].Cells[14].Value.ToString().Replace(".00", "");
                        string Bid = "0";



                        if (_Batch.SameNamealreadyexist(Bcode) == false)
                        {
                            _Itemmaster.IdItemName();
                            Itemid = _Itemmaster.ItemIdLng.ToString();

                            /*For Category Describe*/

                            string Categoryid;
                            if (Gridmain.Rows[i].Cells[5].Value.ToString() == "None" || Gridmain.Rows[i].Cells[5].Value.ToString() == "")
                            {
                                Categoryid = "0";
                            }
                            else
                            {
                                ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                                if (ds.Tables[0].Rows.Count == 0)
                                {
                                    clsitemCategory _Itemcategory = new clsitemCategory();
                                    _Itemcategory.IdCategory();
                                    _Itemcategory.CategoryNameStr = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                                    _Itemcategory.RemarkStr = "";
                                    _Itemcategory.InsertItemCategory();
                                }
                                Categoryid = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                            }

                            /************************/

                            /*For Manufacture Describe*/
                            if (Gridmain.Rows[i].Cells[15].Value.ToString() == "<NONE>" || Gridmain.Rows[i].Cells[15].Value.ToString() == "")
                            {
                                Manufactorid = "0";
                            }
                            else
                            {
                                ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "") + "'");
                                ClsManufacturer _manufacturer = new ClsManufacturer();
                                if (ds.Tables[0].Rows.Count == 0)
                                {

                                    _manufacturer.IdManufacturer();
                                    _manufacturer.Mname = Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "");
                                    _manufacturer.Address = "";
                                    _manufacturer.Phone = "";
                                    _manufacturer.InsertManufacturer();

                                }
                                Manufactorid = _Dbtask.ExecuteScalar("select mid from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[15].Value.ToString().Replace("'", "") + "'");
                            }
                            /****************************************/


                            bool isNumeric;
                            _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                            _Itemmaster.ItemCodeStr = ItemCode;
                            _Itemmaster.ItemNameStr = ItemName;



                            _Itemmaster.MRPDb = DMRP;
                            _Itemmaster.SRateDb = DSrate;
                            _Itemmaster.PRateDb = Prate;

                            Double.TryParse(Gridmain.Rows[i].Cells[11].Value.ToString(), out Stax);
                            _Itemmaster.VAT = Stax;

                            Double.TryParse(Gridmain.Rows[i].Cells[12].Value.ToString(), out Cst);
                            _Itemmaster.CST = Cst;

                            Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out Ptax);
                            _Itemmaster.Purtax = Ptax;

                            _Itemmaster.Unit = "";

                            //_Itemmaster.ItemNameStr = TxtItemname.Text;
                            //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                            _Itemmaster.DescriptionStr = "";
                            //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                            //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                            //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                            _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);
                            _Itemmaster.ItemClass = "Stock Item";
                            _Itemmaster.Localaungage = Llangage;
                            _Itemmaster.StatusInt = 1;
                            _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                            _Itemmaster.CoolyDb = Convert.ToDouble(0);
                            _Itemmaster.MinStockDb = Convert.ToDouble(0);
                            _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                            _Itemmaster.MaximumDb = Convert.ToDouble(0);
                            _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                            _Itemmaster.PRateDb = 0;
                            Prate = 0;
                            _Itemmaster.Incp = -1;
                            _Itemmaster.PRateDb = 0;
                            _Itemmaster.Incs = 1;
                            _Itemmaster.InsertItems();

                            if (Bcode == "")
                            {
                                Bcode = i.ToString("000");
                            }
                            InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");
                            if (Qty != 0)
                                InsertOpeningstock(Bcode);






                        }
                        else
                        {
                            // _Itemmaster.IdItemName();
                            Itemid = _Batch.GetSpecificFieldByBarcode("itemid", Bcode);

                            /*For Category Describe*/


                            Categoryid = _Itemmaster.SpecificField(Itemid, "categoryid");

                            Manufactorid = _Itemmaster.SpecificField(Itemid, "manufacturer");
                            Llangage = _Itemmaster.SpecificField(Itemid, "llang");

                            /****************************************/


                            bool isNumeric;
                            _Itemmaster.ItemCodeStr = ItemCode;
                            _Itemmaster.ItemNameStr = ItemName;



                            _Itemmaster.MRPDb = DMRP;
                            _Itemmaster.SRateDb = DSrate;
                            _Itemmaster.PRateDb = Prate;

                            Double.TryParse(Gridmain.Rows[i].Cells[11].Value.ToString(), out Stax);
                            _Itemmaster.VAT = Stax;

                            Double.TryParse(Gridmain.Rows[i].Cells[12].Value.ToString(), out Cst);
                            _Itemmaster.CST = Cst;

                            Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out Ptax);
                            _Itemmaster.Purtax = Ptax;

                            _Itemmaster.Unit = "";

                            //_Itemmaster.ItemNameStr = TxtItemname.Text;
                            //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                            _Itemmaster.DescriptionStr = "";
                            //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                            //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                            //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                            _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);
                            _Itemmaster.ItemClass = "Stock Item";
                            _Itemmaster.Localaungage = Llangage;
                            _Itemmaster.StatusInt = 1;
                            _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                            _Itemmaster.CoolyDb = Convert.ToDouble(0);
                            _Itemmaster.MinStockDb = Convert.ToDouble(0);
                            _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                            _Itemmaster.MaximumDb = Convert.ToDouble(0);
                            _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                            //_Itemmaster.Unit = TxtUnit.Text;

                            _Itemmaster.Incp = -1;
                            _Itemmaster.Incs = 1;
                            //_Itemmaster.InsertItems();

                            _Dbtask.ExecuteNonQuery("delete from tblbatch where bcode='" + Bcode + "'");
                            if (Bcode == "")
                            {
                                Bcode = i.ToString("000");
                            }

                            InsertBatchTable(Itemid, Bcode, "0", "0", "0", DMRP.ToString(), DSrate.ToString(), Prate.ToString(), Bid, "0");

                            if (Qty != 0)
                                InsertOpeningstock(Bcode);

                        }
                    }
                }
                if (TopeningstockAmount > 0)
                {
                    InsertTransactionReceipt();
                }

                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }

        }
        public void ProductUpdate()
        {
            try
            {


                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {

                        string StrItemCode = Gridmain.Rows[i].Cells[6].Value.ToString().Replace("'", "");
                        string StrItemName = Gridmain.Rows[i].Cells[7].Value.ToString().Replace("'", "");

                        _Itemmaster.IdItemName();
                        Itemid = _Itemmaster.ItemIdLng.ToString();


                        /***********************************/

                        /*Category*/
                        if (Gridmain.Rows[i].Cells[5].Value.ToString() == "<NONE>" || Gridmain.Rows[i].Cells[5].Value.ToString() == "")
                        {
                            Categoryid = "0";
                        }
                        else
                        {
                            ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                clsitemCategory _Itemcategory = new clsitemCategory();
                                _Itemcategory.IdCategory();
                                _Itemcategory.CategoryNameStr = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                                _Itemcategory.RemarkStr = "";
                                _Itemcategory.InsertItemCategory();
                            }
                            Categoryid = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                        }
                        /*Manufacturer*/
                        if (Gridmain.Rows[i].Cells[16].Value.ToString() == "<NONE>" || Gridmain.Rows[i].Cells[16].Value.ToString() == "")
                        {
                            Manufactorid = "0";
                        }
                        else
                        {
                            ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[16].Value.ToString().Replace("'", "") + "'");
                            ClsManufacturer _manufacturer = new ClsManufacturer();
                            if (ds.Tables[0].Rows.Count == 0)
                            {

                                _manufacturer.IdManufacturer();
                                _manufacturer.Mname = Gridmain.Rows[i].Cells[16].Value.ToString().Replace("'", "");
                                _manufacturer.Address = "";
                                _manufacturer.Phone = "";
                                _manufacturer.InsertManufacturer();

                            }
                            Manufactorid = _Dbtask.ExecuteScalar("select mid from tblmanufacturer where mname='" + Gridmain.Rows[i].Cells[16].Value.ToString().Replace("'", "") + "'");
                        }
                        /**************************************/


                        if (_Itemmaster.SameCodealreadyexist(StrItemCode) == false)
                        {
                            bool isNumeric;
                            _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                            _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);/*For Category id =0*/
                            _Itemmaster.ItemCodeStr = StrItemCode;
                            _Itemmaster.ItemNameStr = StrItemName;

                            double a;
                            Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out a);
                            _Itemmaster.MRPDb = a;

                            Double.TryParse(Gridmain.Rows[i].Cells[9].Value.ToString(), out a);
                            _Itemmaster.SRateDb = a;


                            Double.TryParse(Gridmain.Rows[i].Cells[10].Value.ToString(), out a);
                            _Itemmaster.PRateDb = a;

                            Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out a);
                            _Itemmaster.VAT = a;


                            Double.TryParse(Gridmain.Rows[i].Cells[14].Value.ToString(), out a);
                            _Itemmaster.CST = a;


                            Double.TryParse(Gridmain.Rows[i].Cells[15].Value.ToString(), out a);
                            _Itemmaster.Purtax = a;



                            _Itemmaster.Unit = Gridmain.Rows[i].Cells[11].Value.ToString();/*For Unit =6*/

                            //_Itemmaster.ItemNameStr = TxtItemname.Text;
                            //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                            _Itemmaster.DescriptionStr = "";
                            //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                            //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                            //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                            _Itemmaster.ManufacturerLng = 0;
                            _Itemmaster.StatusInt = 1;
                            _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                            _Itemmaster.CoolyDb = Convert.ToDouble(0);
                            _Itemmaster.MinStockDb = Convert.ToDouble(0);
                            _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                            _Itemmaster.MaximumDb = Convert.ToDouble(0);
                            _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                            //_Itemmaster.Unit = TxtUnit.Text;

                            _Itemmaster.Incp = -1;
                            _Itemmaster.Incs = 1;
                            _Itemmaster.InsertItems();

                            Prate = _Itemmaster.PRateDb;
                        }
                        else
                        {
                            bool isNumeric;
                            _Itemmaster.ManufacturerLng = Convert.ToInt64(Manufactorid);/*For Category id =0*/
                            _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                            Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname='" + StrItemName + "'");

                            double Dbvat;
                            double DbCst;
                            double DbPTax;

                            Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out Dbvat);
                            _Itemmaster.VAT = Dbvat;


                            Double.TryParse(Gridmain.Rows[i].Cells[14].Value.ToString(), out DbCst);
                            _Itemmaster.CST = DbCst;


                            Double.TryParse(Gridmain.Rows[i].Cells[15].Value.ToString(), out DbPTax);
                            _Itemmaster.Purtax = DbPTax;

                            _Dbtask.ExecuteNonQuery("update tblitemmaster set vat='" + Dbvat + "' , cst='" + DbCst + "' , purtax='" + DbPTax + "' , categoryid='" + Categoryid + "', manufacturer='" + Manufactorid + "' where itemid='" + Itemid + "'");
                        }
                    }

                }

                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }
        }
        public void ProductInsert()
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                        if (i > 765)
                        {
                            //  MessageBox.Show("ii");
                        }
                        _Itemmaster.IdItemName();
                        Itemid = _Itemmaster.ItemIdLng.ToString();

                        string Categoryid;
                        if (Gridmain.Rows[i].Cells[5].Value.ToString() == "None")
                        {
                            Categoryid = "0";
                        }
                        else
                        {
                            ds = _Dbtask.ExecuteQuery("select * from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                            if (ds.Tables[0].Rows.Count == 0)
                            {
                                clsitemCategory _Itemcategory = new clsitemCategory();
                                _Itemcategory.IdCategory();
                                _Itemcategory.CategoryNameStr = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                                _Itemcategory.RemarkStr = "";
                                _Itemcategory.InsertItemCategory();
                            }
                            Categoryid = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "") + "'");
                        }

                        /***********For Manufacturer******************/
                        //if (Gridmain.Rows[i].Cells[17].Value.ToString() == "None" || _Dbtask.znllString(Gridmain.Rows[i].Cells[17].Value)=="")
                        //{
                        Manufactorid = "0";
                        ////}
                        //else
                        //{
                        //    string temp;
                        //    temp = Gridmain.Rows[i].Cells[17].Value.ToString().Replace("'", "");
                        //    ds = _Dbtask.ExecuteQuery("select * from tblmanufacturer where mname='" + temp+ "'");
                        //    if (ds.Tables[0].Rows.Count == 0)
                        //    {
                        //        ClsManufacturer _ItemManufacturer = new ClsManufacturer();
                        //        _ItemManufacturer.IdManufacturer();
                        //        _ItemManufacturer.Mname = temp;
                        //        _ItemManufacturer.Phone = "";
                        //        _ItemManufacturer.Address = "";
                        //        _ItemManufacturer.InsertManufacturer();
                        //    }
                        //    Manufactorid = _Dbtask.ExecuteScalar("select MID from tblmanufacturer where MNAME='" + temp + "'");
                        //}
                        /***********************************************/


                        bool isNumeric;
                        _Itemmaster.CategoryIdLng = Convert.ToInt64(Categoryid);/*For Category id =0*/
                        _Itemmaster.ItemCodeStr = Gridmain.Rows[i].Cells[6].Value.ToString().Replace("'", "");
                        _Itemmaster.ItemNameStr = Gridmain.Rows[i].Cells[7].Value.ToString().Replace("'", "");


                        double a;
                        Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out a);
                        _Itemmaster.MRPDb = a;

                        Double.TryParse(Gridmain.Rows[i].Cells[9].Value.ToString(), out a);
                        _Itemmaster.SRateDb = a;

                        //  _Itemmaster.ItemCodeStr = _Itemmaster.ItemCodeStr + " "+_Itemmaster.SRateDb.ToString();

                        Double.TryParse(Gridmain.Rows[i].Cells[10].Value.ToString(), out a);
                        _Itemmaster.PRateDb = a;

                        //Double.TryParse(Gridmain.Rows[i].Cells[13].Value.ToString(), out a);
                        _Itemmaster.VAT = 0;


                        // Double.TryParse(Gridmain.Rows[i].Cells[14].Value.ToString(), out a);
                        _Itemmaster.CST = 0;


                        // Double.TryParse(Gridmain.Rows[i].Cells[15].Value.ToString(), out a);
                        _Itemmaster.Purtax = 0;



                        //_Itemmaster.Unit = Gridmain.Rows[i].Cells[11].Value.ToString();/*For Unit =6*/
                        _Itemmaster.Unit = "";/*For Unit =6*/

                        //_Itemmaster.ItemNameStr = TxtItemname.Text;
                        //_Itemmaster.CategoryIdLng = Convert.ToInt64(Txtitemcategory.Tag);
                        _Itemmaster.DescriptionStr = "";
                        //_Itemmaster.MRPDb = Convert.ToDouble(TxtMRP.Text);
                        //_Itemmaster.SRateDb = Convert.ToDouble(TxtSrate.Text);
                        //_Itemmaster.PRateDb = Convert.ToDouble(TxtPrate.Text);
                        _Itemmaster.ManufacturerLng = Convert.ToInt64(_Dbtask.znullDouble(Manufactorid));
                        _Itemmaster.StatusInt = 1;
                        _Itemmaster.AgentCommisionDb = Convert.ToDouble(0);
                        _Itemmaster.CoolyDb = Convert.ToDouble(0);
                        _Itemmaster.MinStockDb = Convert.ToDouble(0);
                        _Itemmaster.ReorderStockDb = Convert.ToDouble(0);
                        _Itemmaster.MaximumDb = Convert.ToDouble(0);
                        _Itemmaster.TaxSlabIdLng = Convert.ToInt64(0);
                        //_Itemmaster.Unit = TxtUnit.Text;

                        _Itemmaster.Incp = -1;


                        _Itemmaster.Incs = 1;


                        Prate = _Itemmaster.PRateDb;

                        Double.TryParse(Gridmain.Rows[i].Cells[16].Value.ToString(), out a);
                        _Itemmaster.Rack = _Dbtask.znllString(Gridmain.Rows[i].Cells[15].Value);


                        _Itemmaster.StatusInt = Convert.ToInt16(_Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells[18].Value));
                        _Itemmaster.Incs = Convert.ToInt16(_Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells[19].Value));

                        _Itemmaster.VAT = Convert.ToInt16(_Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells[20].Value));
                        _Itemmaster.Localaungage = _Dbtask.znllString(Gridmain.Rows[i].Cells[21].Value);
                        //_Itemmaster.CST = a;
                        Qty = a;
                        // Qty = 0;
                        Bcode = "";
                        if (_Itemmaster.SameCodealreadyexist(_Itemmaster.ItemCodeStr) == false)
                        {
                            _Itemmaster.InsertItems();
                        }
                        else
                        {
                            Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname='" + _Itemmaster.ItemNameStr + "'");
                        }
                        if (Qty > 0)
                        {
                            InsertOpeningstock(Bcode);
                        }


                    }

                }
                if (TopeningstockAmount > 0)
                {
                    InsertTransactionReceipt();
                }
                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }
        }

        private void cmdinsertopstock_Click(object sender, EventArgs e)
        {
            OpeningStockInsert();
        }
        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdproductupdating_Click(object sender, EventArgs e)
        {
            ProductUpdate();
        }
        public void UpdateOpeningStockBarcode()
        {
            double a;
            for (int i = 0; i < Gridmain.Rows.Count; i++)
            {
                if (Gridmain.Rows[i].Cells[6].Value != null)
                {
                    string ItemCode = Gridmain.Rows[i].Cells[5].Value.ToString().Replace("'", "");
                    if (ItemCode == "")
                    {
                        ItemCode = Gridmain.Rows[i - 1].Cells[5].Value.ToString().Replace("'", "");
                    }
                    Itemid = CommonClass._Itemmaster.Getitemid(ItemCode);
                    Prate = _Dbtask.znullDouble(Gridmain.Rows[i].Cells[6].Value.ToString());
                    Bcode = Gridmain.Rows[i].Cells[7].Value.ToString();
                    if (Bcode.Length < 3)
                    {
                        if (Bcode.Length == 1)
                        {
                            Bcode = "00" + Bcode;
                        }
                        if (Bcode.Length == 2)
                        {
                            Bcode = "0" + Bcode;
                        }
                    }
                    Double.TryParse(Gridmain.Rows[i].Cells[8].Value.ToString(), out a);
                    Qty = a;
                    if (Qty != 0)
                    {
                        double OpeningStockAmount = Convert.ToDouble(Qty) * Convert.ToDouble(Prate);
                        _TransactionReceipt.IdOpeningStockFu();
                        _ReceiptDetails.RcptCodeLng = _TransactionReceipt.RcptCodeLng;
                        _ReceiptDetails.SlNoLng = Convert.ToInt64(1);
                        _ReceiptDetails.PCodeStr = Itemid;
                        _ReceiptDetails.UnitIdLng = Convert.ToInt64(0);
                        _ReceiptDetails.MultiRateIdLng = Convert.ToInt64(0);
                        _ReceiptDetails.QtyDb = Qty;
                        _ReceiptDetails.RateDb = Convert.ToDouble(Prate);
                        _ReceiptDetails.SRate = Convert.ToDouble(0);
                        _ReceiptDetails.CRate = Convert.ToDouble(0);
                        _ReceiptDetails.QtyFreeDb = Convert.ToDouble(0);
                        _ReceiptDetails.NetAmtDb = OpeningStockAmount;
                        _ReceiptDetails.BatchIdstr = "";
                        _ReceiptDetails.DiscDb = Convert.ToDouble(0); ;
                        _ReceiptDetails.Ledcode = "";
                        _ReceiptDetails.Mrp = Convert.ToDouble(0);
                        _ReceiptDetails.TaxRateDb = Convert.ToDouble(0);
                        _ReceiptDetails.Vtype = "OS";
                        _ReceiptDetails.InsertReceiptDetails();

                        // _TransactionReceipt.RcptCodeLng=_ReceiptDetails.RcptCodeLng;
                        //_TransactionReceipt.IdOpeningStockFu();


                        _Inventory.DCodeStr = "0";
                        _Inventory.Os = Qty;
                        _Inventory.Vcode = _TransactionReceipt.RcptCodeLng.ToString();
                        _Inventory.InvDateDt = DateTime.Now;
                        _Inventory.PcodeStr = Itemid;
                        _Inventory.Batchcode = Bcode;
                        _Inventory.InsertInventory();
                        TopeningstockAmount = TopeningstockAmount + OpeningStockAmount;
                    }
                    else
                    {

                    }
                }
            }
            InsertTransactionReceipt();
            MessageBox.Show("Completed");

        }

        private void cmduopbarccode_Click(object sender, EventArgs e)
        {
            UpdateOpeningStockBarcode();
        }

        private void cmdinsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)
                {

                    if (_Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value) != "")
                    {
                        Ledname = _Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value);
                        LedaliasName = _Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value);

                        Groupid = _Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value);
                        Groupid = Groupid.ToLower();

                        if (Groupid == "customer")
                        {
                            Groupid = "18";
                        }
                        else if (Groupid == "supplier")
                        {
                            Groupid = "19";
                        }

                        else
                        {
                            Groupid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + Groupid + "'");
                        }
                        // Groupid = _Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value);
                        Amount = _Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells[8].Value);
                        VType = _Dbtask.znllString(Gridmain.Rows[i].Cells[9].Value);

                        if (VType == "Dr")
                        {
                            DBAmt = Amount;
                            CRAmt = 0;
                        }
                        else
                        {
                            DBAmt = 0;
                            CRAmt = Amount;
                        }
                        VDate = DateTime.Now;
                        InsertLedger();
                    }
                }
                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }



        private void Frmexcelimport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cmdupdaterate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                        if (i > 765)
                        {
                            //  MessageBox.Show("ii");
                        }
                        string Itemname;
                        string Rate;
                        string Itemid;

                        Itemname = Gridmain.Rows[i].Cells[5].Value.ToString();
                        Rate = Gridmain.Rows[i].Cells[6].Value.ToString();
                        Itemid = CommonClass._Item.Getitemid(Itemname);
                        CommonClass._Item.UpdateField(Itemid, _Dbtask.znullDouble(Rate), "srate");
                    }
                }
                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }
        }

        private void cmdprate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                        if (i > 765)
                        {
                            //  MessageBox.Show("ii");
                        }
                        string Itemname;
                        string Rate;
                        string Itemid;

                        Itemname = Gridmain.Rows[i].Cells[5].Value.ToString();
                        Rate = Gridmain.Rows[i].Cells[6].Value.ToString();
                        Itemid = CommonClass._Item.Getitemid(Itemname);
                        CommonClass._Item.UpdateField(Itemid, _Dbtask.znullDouble(Rate), "prate");
                    }
                }
                MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Completed !!");
            }
        }
        public void UpdateFiled(string Field)
        {
            for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
            {
                if (Gridmain.Rows[i].Cells[5].Value != null)
                {

                    if (_Settings.ReturnStatus("103") == "-1")
                    {

                        Itemid = _Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value);
                        string Value;

                        Value = _Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value);
                        _Itemmaster.UpdateFieldSp(Itemid, Value, Field);
                    }
                    else
                    {
                        string batch = "";
                        batch = _Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value);
                        string Value;
                        Value = _Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value);
                        string itemid = "";
                        itemid  = _Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value);
                        _Itemmaster.UpdateFieldSp(Itemid, Value, Field);

                       
                        _Batch.UpdateFieldbybatch(batch, Field, _Dbtask.znlldoubletoobject(Value));

                    }
                
                
                
                }
            }


            MessageBox.Show("compleated.....");


        }

        private void cmdupdatefield_Click(object sender, EventArgs e)
        {
            UpdateFiled(comfield.Text);
        }

        private void cmdinsertsuppllier_Click(object sender, EventArgs e)
        {

        }

        public void EraceAllstock()
        {
            _Dbtask.ExecuteNonQuery("delete from tblinventory");
        }

        private void cmdsetphysicalstock_Click(object sender, EventArgs e)
        {
            if (chkerasestock.Checked == true)
                EraceAllstock();
            Getphysicalstock();

        }

        public void Getphysicalstock()
        {
            string Bcode;
            double Qty;
            string Pcode;
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
                {
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                        Bcode = Gridmain.Rows[i].Cells[7].Value.ToString().Replace("'", "");
                        Qty = _Dbtask.znullDouble(Gridmain.Rows[i].Cells[10].Value.ToString().Replace("'", ""));
                        Pcode = CommonClass._Batch.GetSpecificFieldofBatchBaseonitemid(Bcode);

                        if (Pcode != null && Qty > 0)
                        {
                            CommonClass._Inventory.Ledcode = "2";
                            CommonClass._Inventory.DCodeStr = "0";
                            CommonClass._Inventory.InvDateDt = DateTime.Now;
                            CommonClass._Inventory.PcodeStr = Pcode;
                            CommonClass._Inventory.Vcode = "0";
                            CommonClass._Inventory.Batchcode = Bcode;
                            CommonClass._Inventory.Os = Qty;
                            CommonClass._Inventory.InsertInventory();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error imported", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("Excel Import Successfully done", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void CompanyList()
        {
            CommonClass.Ds = CommonClass._ComCreate.LoadCompany();
            comtocompany.Items.Clear();
            combfromdb.Items.Clear();
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    string TempLoadingCompany = CommonClass.Ds.Tables[0].Rows[i]["name"].ToString();
                    comtocompany.Items.Add(TempLoadingCompany);
                    combfromdb.Items.Add(TempLoadingCompany);
                }
                catch
                {

                }
            }
        }
        private void Frmexcelimport_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            //CompanyList();
            CommonClass._Nextg.FormIcon(this);
        }

        private void cmdupdatebarcode_Click(object sender, EventArgs e)
        {
            ProductInsertWithBatchUpdate();
        }

        private void CmdupdateCode_Click(object sender, EventArgs e)
        {
            string Itemname;
            string Itemid;
            string Itemcode;

            for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
            {
                if (_Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value) != "")
                {
                    Itemname = _Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value);
                    Itemcode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemname =N'" + Itemname + "'");
                    if (Itemcode == "")
                    {
                        Itemid = _Dbtask.ExecuteScalar("select itemid from tblitemmaster where itemname=N'" + Itemname + "'");
                        Itemcode = _Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value);
                        _Dbtask.ExecuteNonQuery("update tblitemmaster set itemcode='" + Itemcode + "'");
                    }
                }
            }
        }
        public void FuInsertFirstCategory(int Colindex,string ColName)
        {
            
            Gridmain.Rows.Clear();
            DataTable dt = new DataTable();
            k = 0;
            if (Gridmain.Columns.Count < 3) 
            {
                Gridmain.Columns.Add("cln" + Colindex, ColName);
            }

            using (System.IO.TextReader tr = File.OpenText((@"C:\Users\Sun\Desktop\New folder\Notepad\"+ColName+".txt")))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {

                    string[] items = line.Trim().Split(' ');
                    Gridmain.Rows.Add(1);
                    Gridmain.Rows[k].Cells[Colindex].Value = line;
                    k = k + 1;
                }
            }

        }


        public void FuInsertOtherCategory(int Colindex, string ColName)
        {
          
            DataTable dt = new DataTable();
            k = 0;
            if (Gridmain.Columns.Count >= Colindex)
            {
                Gridmain.Columns.Add("cln" + Colindex, ColName);
            }

            using (System.IO.TextReader tr = File.OpenText((@"C:\Users\Sun\Desktop\New folder\Notepad\" + ColName + ".txt")))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {

                    string[] items = line.Trim().Split(' ');

                    Gridmain.Rows[k].Cells[Colindex].Value = line;
                    k = k + 1;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            FuInsertFirstCategory(0, "Category");
            FuInsertOtherCategory(1, "Itemcode");
            FuInsertOtherCategory(2, "Itemname");
            FuInsertOtherCategory(3, "MRP");
            FuInsertOtherCategory(4, "Srate");

            FuInsertOtherCategory(5, "Prate");
            FuInsertOtherCategory(6, "Stax");
            FuInsertOtherCategory(7, "CST");
            FuInsertOtherCategory(8, "Ptax");

            FuInsertOtherCategory(9, "Barcode");
            FuInsertOtherCategory(10, "Manufacturer");
            FuInsertOtherCategory(11, "Itemname");

            FuInsertOtherCategory(12, "OP Qty");
            FuInsertOtherCategory(13, "Rack");
            MessageBox.Show("Done");
            ProductInsertwithBatchNotepad();

        }
        public void Updateopeningbalance()
        {
            for (int i = 0; i < Gridmain.Rows.Count; i++)/*For Item Insert*/
            {
                if (Gridmain.Rows[i].Cells[5].Value != null)
                {
                    string Value = ""; string Value1 = ""; string Value2 = ""; double Value3 = 0;

                    Value = _Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value);//lid


                    Value1 = _Dbtask.znllString(Gridmain.Rows[i].Cells[6].Value);//name
                    Value2 = _Dbtask.znllString(Gridmain.Rows[i].Cells[7].Value);//grpid
                    Value3 = _Dbtask.znlldoubletoobject(Gridmain.Rows[i].Cells[8].Value);//amt
                    CommonClass._Ledger.updatefeildopening(Value, Value2, Value3);
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Updateopeningbalance();
        }

        public void transfercompany(string ToDB,string FromDB ,string vno)
        {
            string TableName = "tblbusinessissue"; string TableNameGEN = "tblgeneralledger";
            string TableNametwo = "tblissuedetails";
            CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDB + ".." + TableName + "" + " where vno='" + vno + "' ");


            CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDB + ".." + TableNameGEN + "" + " where vno='" + vno + "' AND VTYPE='SI' ");


            CommonClass._Dbtask.ExecuteNonQuery("delete from " + ToDB + ".." + TableNametwo + "" + " where issuecode='" + vno + "' ");



            string Sql = "select column_name from INFORMATION_SCHEMA.COLUMNS " +
                         " where TABLE_NAME='" + TableName + "'";


           string Temp = CommonClass._SelectReport.Showindataset(Sql);
            CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDB + ".." + TableName + " (" + Temp + ") " +
                
               " SELECT " + Temp + " FROM  " + FromDB + ".." + TableName + "" + "   where vno='"+vno+"'");


            string Sqltw = "select column_name from INFORMATION_SCHEMA.COLUMNS " +
                            " where TABLE_NAME='" + TableNametwo + "'";


            string Temptw = CommonClass._SelectReport.Showindataset(Sqltw);
            CommonClass._Dbtask.ExecuteNonQuery("INSERT INTO " + ToDB + ".." + TableNametwo + " (" + Temptw + ") " +

               " SELECT " + Temptw + " FROM  " + FromDB + ".." + TableNametwo + "" + "   where issuecode='" + vno + "'");
       
        
        
        
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Gridmain.Rows.Count; i++)
                {
                    string vno = ""; Generalfunction.TempCompanyname = "";
                    if (Gridmain.Rows[i].Cells[5].Value != null)
                    {
                     vno = _Dbtask.znllString(Gridmain.Rows[i].Cells[5].Value);

                     transfercompany(_Dbtask.znllString(comtocompany.Text), _Dbtask.znllString(combfromdb.Text), vno);


                    }
                }

                MessageBox.Show("sucessfully completed");



            }
            catch
            {
            }
        }
    }
}