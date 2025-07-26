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
    public partial class Frmreceivedproduct : Form
    {
        public Frmreceivedproduct()
        {
            InitializeComponent();
        }
        /*For Settings*/
        bool Sbatch;
        /*****************************/

        public bool Editmode;
        Clsissueproduct _Issueproduct = new Clsissueproduct();
        Clsreceivedproduct _Receivedproduct = new Clsreceivedproduct();
        Clsreceiveddetail _Recedetail = new Clsreceiveddetail();
        ClsItemMaster _Items = new ClsItemMaster();
        ClsInventory _Inventory = new ClsInventory();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        NextGFuntion _Nextg = new NextGFuntion();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsGeneralLedger _generalLedger = new ClsGeneralLedger();

        DBTask _Dbtask = new DBTask();

        DataSet Ds;
        DataSet Ds1;

        public string Bcode;
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
       
        private bool ValidationFu()
        {
            if (Commainproduct.SelectedValue == null)
            {
                MessageBox.Show("Select Item !", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Commainproduct.Focus();
                return false;
            }
            if (Convert.ToDouble(txtmainqty.Text)==0)
            {
                MessageBox.Show("Enter a valid Qty", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmainqty.Focus();
                return false;
            }
            string Finishedid=Commainproduct.SelectedValue.ToString();
            
           // Ds
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                //string tempItemid = gridmain.Rows[i].Cells["clnitem"].Tag.ToString();
                double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);

                if (Sbatch == true)
                {
                    if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0 && gridmain.Rows[i].Cells["clnbatch"].Value !=null)
                    {
                        return true;
                    }
                }
                else
                {
                    if (gridmain.Rows[i].Cells["clnitem"].Tag != null && tempQty > 0)
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show("Select Valid Finished Product", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Commainproduct.Focus();
            return false;
        }
        public void Rowvalidation()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                //string tempItemid = gridmain.Rows[i].Cells["clnitem"].Tag.ToString();
                if (gridmain.Rows[i].Cells["clnqty"].Value != null)
                {
                    double tempQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);

                    if (Sbatch == true)
                    {
                        if (gridmain.Rows[i].Cells["clnitem"].Tag != null && gridmain.Rows[i].Cells["clnbatch"].Value != null)
                        {
                            gridmain.Rows[i].Tag = "1";
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = "-1";
                        }
                    }
                    else
                    {

                        if (gridmain.Rows[i].Cells["clnitem"].Tag != null)
                        {
                            gridmain.Rows[i].Tag = "1";
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = "-1";
                        }
                    }
                }
            }

        }
        public void Delete()
        {
            string Receid=txtreceivedid.Text;
            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vno='" + txtidgeneralledger.Text + "' and vtype='Ireceipt'");
            _Dbtask.ExecuteNonQuery("delete from tblreceivedproduct where id='"+Receid+"'");
            _Dbtask.ExecuteNonQuery("delete from tblreceivedproductdetail where id='"+Receid+"'");

            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where recptcode='" + txtbvno.Tag + "' and vtype='Ireceipt'");
            _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where reptcode='" + txtbvno.Tag + "' and recpttype='Ireceipt'");
            _Dbtask.ExecuteNonQuery("update tblissueproduct set istatus=-1 where vno='"+txtissueid.Text+"'");
        }
        public void Clear()
        {
            Menusettings();
            ShowIssueproduct(" ");
            txtreceivedid.Text = _Receivedproduct.VnoReceivedproduct().ToString();
            _generalLedger.IdGeneralLedger(" where vtype='IReceipt'");
            txtidgeneralledger.Text = _generalLedger.VnoStr;
            _TransactionReceipt.IdTransactionReceiptPurticular("Ireceipt");
            txtbvno.Tag = _TransactionReceipt.RcptCodeLng.ToString();
            txtbvno.Text = _TransactionReceipt.RcptCodeLng.ToString();
            txtmainqty.Text = _Dbtask.SetintoDecimalpointStock(0);
            txtamounttodebited.Text = _Dbtask.SetintoDecimalpoint(0);
            gridmain.Rows.Clear();
            txtissueid.Text = "";
            txtissuedate.Text = "";
            txtemployee.Text = "";
            txtemployee.Tag = null;
            txtremarks.Text = "";
            Editmode = false;
           
            Fiilcombo();
            Commainproduct.Focus();
        }
        public void NextgInitialize()
        {
            long Issueid =Convert.ToInt64(txtissueid.Text);
            long Recid = Convert.ToInt64(txtreceivedid.Text);
            DateTime RecDate = Dtrecdate.Value;
            long MainItemid = Convert.ToInt64(Commainproduct.SelectedValue);
            double MainQty = Convert.ToDouble(txtmainqty.Text);
            double MainRate=0;

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
               if(gridmain.Rows[i].Tag !=null)
               {
                   if (gridmain.Rows[i].Tag.ToString() != "-1")
                   {
                       long Slno = Convert.ToInt64(gridmain.Rows[i].Cells["clnslno"].Value.ToString());
                       long Itemid = Convert.ToInt64(gridmain.Rows[i].Cells["clnitem"].Tag.ToString());
                       double Qty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value.ToString());
                       double Rate = Convert.ToDouble(gridmain.Rows[i].Cells["clnrate"].Value.ToString());
                       double Temprate = Qty * Rate;
                       MainRate = MainRate + Temprate;

                       if (Sbatch == true)
                       {
                           Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();

                           _ReceiptDetails.BatchIdstr = Bcode;
                           _Recedetail.Bcode = Bcode;
                       }

                       _Recedetail.Id = Recid;
                       _Recedetail.Slno = Slno;
                       _Recedetail.Itemid = Itemid;
                       _Recedetail.Qty = Qty;
                       _Recedetail.Rate = Rate;
                       _Recedetail.Insertreceivedproductdetail();

                       /*For Receipt Details*/
                       _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtbvno.Tag);
                       _ReceiptDetails.SlNoLng = Slno;
                       _ReceiptDetails.PCodeStr = Itemid.ToString();
                       _ReceiptDetails.UnitIdLng = 0;
                       _ReceiptDetails.MultiRateIdLng = 0;
                       _ReceiptDetails.QtyDb = Qty;
                       _ReceiptDetails.RateDb = Rate;
                       _ReceiptDetails.NetAmtDb = Temprate;
                       _ReceiptDetails.Vtype = "Ireceipt";
                       _ReceiptDetails.InsertReceiptDetails();

                       /*Update Status of Issue details*/

                       double tempqty = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(qty),0) from tblissueproductdetail where issueid='" + Issueid + "' and item='" + Itemid + "'"));
                       if (Qty == tempqty)
                       {
                           _Dbtask.ExecuteNonQuery("update tblissueproduct set istatus=1 where vno='" + Recid + "'");
                       }
                       else
                       {
                           _Dbtask.ExecuteNonQuery("update tblissueproduct set istatus=-1 where vno='" + Recid + "'");
                       }
                   }
            }    
            }
            /*For Inventory Insert(IReceipt)*/
            _Inventory.DCodeStr = "0";
            _Inventory.InvDateDt = RecDate;
            _Inventory.PcodeStr = MainItemid.ToString();
            _Inventory.Vcode = Convert.ToString(txtbvno.Tag);
            _Inventory.Ireceipt = MainQty;
            _Inventory.Batchcode = Bcode;
            _Inventory.InsertInventory();
            /*********************************************/
            _Receivedproduct.Issueid = Issueid;
            _Receivedproduct.Id = Recid;
            _Receivedproduct.Recdate = RecDate;
            _Receivedproduct.Itemid = MainItemid;
            _Receivedproduct.Qty = MainQty;
            _Receivedproduct.Bvno =Convert.ToInt64(txtbvno.Tag);
            _Receivedproduct.Gvno = Convert.ToInt64(txtidgeneralledger.Text);
            _Receivedproduct.Insertreceivedproduct();
            
           // UpdateStatusofissue();/*For Update Issuedetails Status*/

            _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtbvno.Tag);
            _TransactionReceipt.VNoStr = txtbvno.Text;
            _TransactionReceipt.RCptTypeStr = "Ireceipt";
            _TransactionReceipt.DcodeStr = "0";
            _TransactionReceipt.RcptDateDt =Dtrecdate.Value;
            _TransactionReceipt.AMTDb = MainRate;

            _TransactionReceipt.RemarkStr = "";
            _TransactionReceipt.InsertTransactionReceipt();


            /*For General Ledger*/
            double DbAmt = Convert.ToDouble(txtamounttodebited.Text);
            _generalLedger.VdateDt = Dtrecdate.Value;
            _generalLedger.VTypeStr = "Ireceipt";
            _generalLedger.VnoStr = txtidgeneralledger.Text;
            _generalLedger.SlNoLng = Convert.ToInt64("1");
            _generalLedger.LedCodeStr = "3";
            _generalLedger.PurticularsStr = "Internal Receipt";
            _generalLedger.DbAmtDb = DbAmt;
            _generalLedger.CrAmt = 0;
            _generalLedger.Naration = "";
            _generalLedger.RefnoStr = "3";
            // _GeneralLedger.EmployeeIdStr = txtte;/*F

            _generalLedger.InsertGeneralLedger();

            /*For Credit To Ledger(Party Account)*/
            _generalLedger.LedCodeStr = txtemployee.Tag.ToString();
            _generalLedger.PurticularsStr = "Internal Receipt";
            _generalLedger.DbAmtDb = 0;
            _generalLedger.CrAmt = DbAmt;
            _generalLedger.InsertGeneralLedger();
        }
        public void ShowIssueproduct(string Where)
        {
        Ds=_Issueproduct.Showissueproduct(" where Istatus=-1 "+Where+"");
        Gridlist.Rows.Clear();
        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
        {
            Gridlist.Rows.Add(1);
            string Issueid=Ds.Tables[0].Rows[i]["issueid"].ToString();
            DateTime Issuedate=Convert.ToDateTime(Ds.Tables[0].Rows[i]["date"].ToString());
            string Employeeid=Ds.Tables[0].Rows[i]["Employee"].ToString();
            string Employeename=_Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='"+Employeeid+"'");
            Gridlist.Rows[i].Cells["clnissueid"].Value = Issueid;
            Gridlist.Rows[i].Cells["clnissuedate"].Value = Issuedate.ToString("dd/MM/yyyy");
            Gridlist.Rows[i].Cells["clnemployee"].Tag = Employeeid;
            Gridlist.Rows[i].Cells["clnemployee"].Value = Employeename;

        }
        }
        public void Fiilcombo()
        {
            _Dbtask.fillDatainCombowithQuery(Commainproduct, "itemid", "itemname", "tblitemmaster", "select * from tblitemmaster where status=1 and itemclass='Finished Product'");

        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    Rowvalidation();
                    if (Editmode == true)
                    {
                        Delete();
                        
                    }
                    NextgInitialize();
                    Clear();
                    return true;

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void ListintomainGrid()
        {
        
        }
        private void Gridlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Gridlist.SelectedRows.Count > 0)
            {
                int SelectedRow = Gridlist.SelectedRows[0].Index;
                long Issueid = Convert.ToInt64(Gridlist.Rows[SelectedRow].Cells["clnissueid"].Value);
                string Issuedate = Gridlist.Rows[SelectedRow].Cells["clnissuedate"].Value.ToString();
                long Employeeid = Convert.ToInt64(Gridlist.Rows[SelectedRow].Cells["clnemployee"].Tag);
                string Employeename = Convert.ToString(Gridlist.Rows[SelectedRow].Cells["clnemployee"].Value);
                
                string Remarks; //= Convert.ToString(Gridlist.Rows[SelectedRow].Cells["clnremarks"].Value);

                txtissueid.Text = Issueid.ToString();
                txtissuedate.Text = Issuedate;
                txtemployee.Tag = Employeeid;
                txtemployee.Text = Employeename;
                txtremarks.Text = _Dbtask.ExecuteScalar("select remarks from tblissueproduct where vno='" + Issueid + "'");

                Ds = _Dbtask.ExecuteQuery("select * from tblissueproductdetail where issueid='" + Issueid + "'");
                gridmain.Rows.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);
                    string slno = Ds.Tables[0].Rows[i]["slno"].ToString();
                    string Itemid = Ds.Tables[0].Rows[i]["item"].ToString();
                    string Itemname = _Dbtask.ExecuteScalar("select Itemname from tblitemmaster where itemid='" + Itemid + "'");
                    double Qty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                    double Rate = Convert.ToDouble(Ds.Tables[0].Rows[i]["rate"].ToString());
                    Bcode = Ds.Tables[0].Rows[i]["bcode"].ToString();
                    gridmain.Rows[i].Cells["clnslno"].Value = slno;
                    gridmain.Rows[i].Cells["clnitem"].Value = Itemname;
                    gridmain.Rows[i].Cells["clnitem"].Tag = Itemid;
                    gridmain.Rows[i].Cells["clnbatch"].Value = Bcode;
                    double tempqty;
                   
                   
                    Ds1 = _Dbtask.ExecuteQuery("select * from tblreceivedproduct where issueid='"+Issueid+"'");
                    if (Ds1.Tables[0].Rows.Count > 0)
                    {
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            string Recevedid = Ds1.Tables[0].Rows[ii]["id"].ToString();
                            string temp = _Dbtask.ExecuteScalar("select isnull(sum(qty),0) from tblreceivedproductdetail where id='" + Recevedid + "' and item='" + Itemid + "'");
                            tempqty = Convert.ToDouble(temp);
                            gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(Qty - tempqty);
                        }
                    }
                    else
                    {
                        gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(Qty);
                    }
                        gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Rate);
                }


                Calculation();
            }
        }

        private void Frmreceivedproduct_Load(object sender, EventArgs e)
        {
            Clear();
            _Nextg.FormStylesett(this);

            CommonClass._Nextg.FormIcon(this);
        }

        public void Menusettings()
        {
            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
            {
                Sbatch = true;
                clnbatch.Visible = true;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ShowIssueproduct(" and vno='"+txtsearch.Text+"'");
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmainqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender,e,true);

        }
        public void ShowPrevious(string vno)
        {
            try
            {
                Ds = _Dbtask.ExecuteQuery("select * from tblreceivedproduct where id='" + vno + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Clear();
                    Editmode = true;
                    vno = Ds.Tables[0].Rows[i]["id"].ToString();
                    string Issueid = Ds.Tables[0].Rows[i]["issueid"].ToString();
                    DateTime Recdate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["recdate"]);
                    string Itemid = Ds.Tables[0].Rows[i]["item"].ToString();
                    string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                    double Qty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                    string Bvno = Ds.Tables[0].Rows[i]["bvno"].ToString();
                    string Gvno = Ds.Tables[0].Rows[i]["gvno"].ToString();
                    string EmployeeId = _Dbtask.ExecuteScalar("select employee from tblissueproduct where vno='"+Issueid+"'");
                    string EmployeeName = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid ='"+EmployeeId+"'");

                    txtemployee.Text = EmployeeName;
                    txtemployee.Tag = EmployeeId;

                    txtreceivedid.Text = vno;
                    txtissueid.Text = Issueid;
                    Dtrecdate.Value = Recdate;
                    Commainproduct.SelectedValue = Itemid;
                    txtmainqty.Text = _Dbtask.SetintoDecimalpointStock(Qty);
                    txtbvno.Text = Bvno;
                    txtidgeneralledger.Text = Gvno;

                    Ds1 = _Dbtask.ExecuteQuery("select * from tblreceivedproductdetail where id='" + vno + "'");
                    for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                    {
                        gridmain.Rows.Add(1);
                        string Slno = (ii + 1).ToString();
                        string ttItemid = Ds1.Tables[0].Rows[ii]["item"].ToString();
                        Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + ttItemid + "'");
                        double tQty = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["qty"]);
                        double trate = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["rate"]);
                        gridmain.Rows[ii].Cells["clnslno"].Value = Slno;
                        gridmain.Rows[ii].Cells["clnitem"].Value = Itemname;
                        gridmain.Rows[ii].Cells["clnitem"].Tag = ttItemid;
                        gridmain.Rows[ii].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tQty);
                        gridmain.Rows[ii].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(trate);

                    }

                }
                if (Ds.Tables[0].Rows.Count == 0)
                {
                    long temp = Convert.ToInt64(vno) - 1;
                    ShowPrevious(temp.ToString());
                }
            }
           
            catch
            {
                Clear();
            }

        }
        public void Calculation()
        {
            try
            {
                if (Commainproduct.SelectedValue != null)
                {

                    string Mainproductid = Commainproduct.SelectedValue.ToString();
                    double MainQty = 0;
                    if (txtmainqty.Text != "")
                    {
                        MainQty = Convert.ToDouble(txtmainqty.Text);
                    }
                    string Productsettid = _Dbtask.ExecuteScalar("select id from tblproductsett where item='" + Mainproductid + "'");
                    string Prosettid = txtissueid.Text;
                    double Mrate = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(mrate),0) from tblproductsett where item='" + Mainproductid + "'"));
                    Rowvalidation();
                    for (int i = 0; i < gridmain.Rows.Count; i++)
                    {
                        if (gridmain.Rows[i].Tag != null)
                        {
                            if (gridmain.Rows[i].Tag.ToString() != "-1")
                            {
                                string Rowitemid = gridmain.Rows[i].Cells["clnitem"].Tag.ToString();
                                string temp = _Dbtask.ExecuteScalar("select isnull(sum(qty),0) from tblproductsettdetail where id='" + Productsettid + "' and item='" + Rowitemid + "'");
                                double ActualQty = MainQty * Convert.ToDouble(temp);
                                double CureQty = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(SUM(qty),0) from tblissueproductdetail where issueid='" + Prosettid + "' and item='" + Rowitemid + "'"));
                                if (ActualQty <= CureQty)
                                {
                                    gridmain.Rows[i].Cells["clnqty"].Value = ActualQty;
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid Qty", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtmainqty.Text = _Dbtask.SetintoDecimalpointStock(0);
                                }
                            }
                        }
                        double DebitedAmount = MainQty * Mrate;
                        txtamounttodebited.Text = _Dbtask.SetintoDecimalpoint(DebitedAmount);
                    }
                }
            }
            catch
            {
            }
        }
        private void txtmainqty_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void Frmreceivedproduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdback_Click(object sender, EventArgs e)
        {
            long Vno=Convert.ToInt64(txtreceivedid.Text)-1;
            ShowPrevious(Vno.ToString());
        }

        private void cmdforward_Click(object sender, EventArgs e)
        {
            long Vno = Convert.ToInt64(txtreceivedid.Text) + 1;
            ShowPrevious(Vno.ToString());
        }

        private void Frmreceivedproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to delete the current Record?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                Delete();
                Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Showsetproduct()
        {

            Frmsetmainproduct _Setproduct = new Frmsetmainproduct();
            _Setproduct.ShowDialog();
        }
        public void ShowIssueproduct()
        {
            Frmissuetable _Issueproduct = new Frmissuetable();
            _Issueproduct.ShowDialog();
        }
        private void linksetproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showsetproduct();
        }

        private void linkissueproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowIssueproduct();
        }

        private void Commainproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtamounttodebited_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, true);
        }

        private void txtamounttodebited_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }
    }
}
