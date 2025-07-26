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
    public partial class FrmopeningStock : Form
    {
        public FrmopeningStock()
        {
            InitializeComponent();
        }

        /*Unit*/
        public string SecUnit = "";
        public string FirUnit = "";
        public double Convrt = 0;
        public double Unitamount1 = 0;
        public double UnitAmount2 = 0;
        public string UnitCode = "";
        string Unitid;
        string UnitName;
        UscGridshow _usc2 = new UscGridshow();
        public string Pcode;
        public double Gross = 0;
        public int Munit = 0;
        public double TottalAmount;
        ClsInventory _Inventory = new ClsInventory();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        ClsItemMaster _ItemMaster = new ClsItemMaster();
        ClsDepot _Depot = new ClsDepot();
        ClsInGrid _Ingrid = new ClsInGrid();
        DataSet Ds = new DataSet();
        DataSet DS3 = new DataSet();
        NextGFuntion _Nextg = new NextGFuntion();
        DBTask _Dbtask = new DBTask();
        Clsbatch _Batch = new Clsbatch();
        DataSet Ds2 = new DataSet();

        string ItemCode;
        string ItemName;
                   double Tempqty ;
                   string TempItemid ;
                   double TempPrate ;
                   double TempSrate;
                 //  string Batchcode;
        bool IsinToolimport;
        public string SDepott = "0";
        public int rowindex;
        public int columnindex;
        double NetTottal;
        double NetQty;
        string ColumnName;
        public string Batchcode = "";
        public string ItemId;
        public bool IsEnter;

        public bool EditMode = false;

        public bool SBatatch = false;
        public bool SDepot = false;
        public bool SUnit = false;
        int selectedRow; /*For Get Row Index Of Product Grid */


        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {

                if (this.ActiveControl.Name != "txtvno")
                {
                    if (this.ActiveControl.Name != "dtdate")
                    {
                        if (this.ActiveControl.Name != "TxtRemark")
                        {

                            if (this.ActiveControl.Name != "GridProductShow")
                            {

                                if (this.ActiveControl.Name != "txttqty")
                                {
                                    if (this.ActiveControl.Name != "txttnetamount")
                                    {


                                        if (this.ActiveControl.Name != "txtbillamount")
                                        {


                                            if (this.ActiveControl.Name != "cmdsave")
                                            {
                                                if (this.ActiveControl.Name != "cmdprint")
                                                {
                                                    if (this.ActiveControl.Name != "cmdclose")
                                                    {
                                                        if (this.ActiveControl.Name != "cmdcancel")
                                                        {
                                                            if (this.ActiveControl.Name != "cmdclear")
                                                            {
                                                                if (this.ActiveControl.Name != "ComDepot")
                                                                {
                                                                    if (this.ActiveControl.Name != "txt")
                                                                    {
                                                                        if (this.ActiveControl.Name != "Gripproductlist")
                                                                        {
                                                                            if (msg.WParam.ToInt32() == (int)Keys.Enter)
                                                                            {
                                                                                SendKeys.Send("{Tab}");
                                                                                return true;
                                                                            }
                                                                            if (uscGridshow2.GridProductShow.Visible == true || GridBatch.Visible == true)
                                                                            {
                                                                                if (msg.WParam.ToInt32() == (int)Keys.Down)
                                                                                {
                                                                                    // SendKeys.Send("{Tab}");
                                                                                    return true;
                                                                                }
                                                                                if (msg.WParam.ToInt32() == (int)Keys.Up)
                                                                                {
                                                                                    //SendKeys.Send("{Tab}");
                                                                                    return true;
                                                                                }
                                                                            }
                                                                            if (Gridbatchlist.Visible == true)
                                                                            {
                                                                                if (msg.WParam.ToInt32() == (int)Keys.Down)
                                                                                {
                                                                                    // SendKeys.Send("{Tab}");
                                                                                    return true;
                                                                                }
                                                                                if (msg.WParam.ToInt32() == (int)Keys.Up)
                                                                                {
                                                                                    //SendKeys.Send("{Tab}");
                                                                                    return true;

                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void FrmopeningStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                _Nextg.CloseGriddetail(gridmain, this);
            }
        }

        //public void GetPrevious(long Vno)
        //{
        //    try
        //    {
        //        long PreIssuecode = Vno;
        //        Ds2 = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='SI' and ledcodeCr='" + SalesAccount + "'");
        //        if (Ds2.Tables[0].Rows.Count != 0)
        //        {
        //            gridmain.Rows.Clear();
        //            Mode = 1;
        //            if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
        //            {
        //                txtvno.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString() + Ds2.Tables[0].Rows[0]["vno"].ToString();
        //            }
        //            else
        //            {
        //                txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
        //            }
        //            txtvno.Tag = PreIssuecode.ToString();

        //            _IssueDetails.IssueCodeLng = PreIssuecode;
        //            _BusinessIssue.IssueCodeLng = PreIssuecode;
        //            _Inventory.Vcode = PreIssuecode.ToString();

        //            dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["issuedate"]);
        //            ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
        //            ComAccount.SelectedValue = Ds2.Tables[0].Rows[0]["Ledcodedr"];
        //            ComTax.SelectedValue = Ds2.Tables[0].Rows[0]["taxid"];

        //            ComAgent.SelectedValue = Ds2.Tables[0].Rows[0]["agent"];
        //            TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + ComAgent.SelectedValue + "' and vno ='" + PreIssuecode + "'");
        //            if (TxtAgentAmt.Text == "")
        //                TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);

        //            ComStaff.SelectedValue = Ds2.Tables[0].Rows[0]["Empid"];
        //            TxtStaffAmt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + ComStaff.SelectedValue + "' and vno ='" + PreIssuecode + "'");
        //            if (TxtStaffAmt.Text == "")
        //                TxtStaffAmt.Text = _Dbtask.SetintoDecimalpoint(0);

        //            Txtnaration.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
        //            txtotherexpenses.Text = Ds2.Tables[0].Rows[0]["cooly"].ToString();
        //            txtinvoicediscount.Text = Ds2.Tables[0].Rows[0]["Discamt"].ToString();
        //            Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='SI' order by slno asc");
        //            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
        //            {
        //                gridmain.Rows.Add(1);
        //                string tempSlno = Ds.Tables[0].Rows[i]["slno"].ToString();
        //                string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
        //                double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
        //                double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
        //                double tempsRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
        //                double tempMrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["Mrp"].ToString());
        //                double tempdiscrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
        //                double temptaxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
        //                double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
        //                string tempBatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();

        //                gridmain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
        //                gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
        //                gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
        //                gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
        //                gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
        //                gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);
        //                gridmain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);
        //                gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
        //                gridmain.Rows[i].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");
        //                gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempMrp);
        //                gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(tempdiscrate);
        //                gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);



        //                Templedouble = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value) * Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
        //                gridmain.Rows[i].Cells["clndiscper"].Value = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value) * 100 / Templedouble;
        //                rowindex = i;
        //                CellEnterCalculationPart();
        //                RowValidation();
        //                //gridmain.Rows[i].Cells["clnqty"].Selected = true;
        //            }
        //            TottalAmountCalculate();




        //        }
        //    }
        //    catch
        //    {
        //        Clear();
        //    }
        //}


        private bool Main()
        {
            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        Deletevoucher();
                    }
                    NextgInitialize();
                    //Insert();
                    // MessageBox.Show("Saved Successfully");

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
        private bool ValidationFu()
        {
            try
            {

                if (TxtVno.Text == "")
                {
                    MessageBox.Show("Please Enter the Vno", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtVno.Focus();
                    return false;
                }
                if (EditMode == false)
                {
                    Ds = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where recpttype='OS' and vno='" + TxtVno.Text + "'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Vno is already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            return true;
                        }
                        else
                        {
                            // MessageBox.Show("No Valid Entries", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                WhereCondition = " where  TblItemMaster.itemCode Like N'%" + WhereCondition + "%' OR  TblItemMaster.ItemName Like N'%" + WhereCondition + "%' or Tblbatch.bcode like '%" + WhereCondition + "%'";
                _Ingrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, "0",true,false,"");

                // IsEnter = true;
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height * 2);

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }

        public void ProductGridShow(string WhereCondition)
        {
            if (CHKbatchwise.Checked == true)
            {
              _Ingrid.opbatch  = true;
                    WhereCondition = " where  (TblItemMaster.itemCode Like N'%" + WhereCondition + "%' OR  TblItemMaster.ItemName Like N'%" + WhereCondition + "%' or Tblbatch.bcode like N'%" + WhereCondition + "%' ) ";
                    _Ingrid.BatchGridShowPURCHASE(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, "", false, false, "");
                 
            }
            else
            {


                _Ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, SDepott);
            }
                
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height * 2);

            if (uscGridshow2.GridProductShow.Visible == false)
            {
                uscGridshow2.GridProductShow.Visible = true;
            }
        }

        public void CellEnterCalculationPart()
        {
            try
            {
                double Qty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                double Rate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnrate"].Value);
                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(Qty * Rate); /* For Cell Net Amount*/
                double NetAmount = _Dbtask.znullDouble(gridmain.Rows[rowindex].Cells["clnnettamount"].Value.ToString());
                Gross = NetAmount;
                if (SUnit == true)
                {
                    double UnitAmt = Gross * Convrt;
                    Gross = UnitAmt;
                }
                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = Gross;
            }
            catch
            {
            }
        }
        public void TottalAmountCalculate()
        {
            gridmain.Rows[rowindex].Cells["ClnSlno"].Value = rowindex + 1; /* For SlNo*/
            NetTottal = 0;
            NetQty = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
            {
                if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                {
                    NetTottal = NetTottal + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                    NetQty = NetQty + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                }
            }
            double tempbillamount = Convert.ToDouble(NetTottal);
            double temptqty = Convert.ToDouble(NetQty);

            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(tempbillamount);
            txttqty.Text = _Dbtask.SetintoDecimalpoint(temptqty);

        }

        public void SetGridColumn()
        {
            GetMenusettings();
            if (SDepot == false)
            {
                ComDepot.Visible = false;
                lbldepot.Visible = false;
            }
            if (SBatatch == false)
            {
                clnbatch.Visible = false;
            }
            if (SUnit == false)/*For Unit*/
            {
                ClnUnit.Visible = false;

            }
        }

        public void GetMenusettings()
        {
            string temp;
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=13");
            if (temp == "1")
            {
                SDepot = true;
            }
            /*Batch*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
            if (temp == "1")
            {
                SBatatch = true;
            }
            /*Unit*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=12 ");
            if (temp == "1")
            {
                SUnit = true;
            }
        }

        public void RowValidation()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (SBatatch == true)
                {

                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value) == Convert.ToDouble(0))
                    {

                        gridmain.Rows[i].Tag = -1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        gridmain.Rows[i].Tag = 1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }
                if (SBatatch == false)
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value) == Convert.ToDouble(0))
                    {

                        gridmain.Rows[i].Tag = -1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        gridmain.Rows[i].Tag = 1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }
            }
        }
        public void ProductGridShowLocationSett()
        {
            //  Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            uscGridshow2.GridProductShow.Left = TxtProduct.Left;

            uscGridshow2.GridProductShow.Top = TxtProduct.Top + TxtProduct.Height + 64;
            //+ tempRect.Height;
        }
        public void Deletevoucher()
        {
            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where Recptcode='" + TxtVno.Tag + "'");
            _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode ='" + TxtVno.Tag + "' and os!=0");
            _Dbtask.ExecuteNonQuery("delete from tblbatch where recptcode='" + TxtVno.Tag + "'");
            _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where reptcode='" + TxtVno.Tag + "'");

        }
        public void GetPrevious(long vno)
        {
            try
            {
                if (vno > 0)
                {
                    long PreIssuecode = vno;
                    Ds2 = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='OS' ");
                    if (Ds2.Tables[0].Rows.Count != 0)
                    {
                        gridmain.Rows.Clear();
                        EditMode = true;

                        if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                        {
                            TxtVno.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString() + Ds2.Tables[0].Rows[0]["vno"].ToString();
                        }
                        else
                        {
                            TxtVno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                        }
                        TxtVno.Tag = PreIssuecode.ToString();

                        _ReceiptDetails.RcptCodeLng = PreIssuecode;
                        _TransactionReceipt.RcptCodeLng = PreIssuecode;
                        _Inventory.Vcode = PreIssuecode.ToString();

                        dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["recptdate"]);
                        ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                        TxtRemark.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();

                        Ds = _Dbtask.ExecuteQuery("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='OS' order by slno asc");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            gridmain.Rows.Add(1);

                            string tempSlno = Ds.Tables[0].Rows[i]["slno"].ToString();
                            string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                            double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                            double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                            double temppRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                            string Batchcode = Ds.Tables[0].Rows[i]["batchid"].ToString();
                            double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["sRate"].ToString());
                            double tempdiscrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                            double temptaxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
                            double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
                            Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();

                            if (SBatatch == true)
                            {
                                string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                                string tempbatchidTag = _Dbtask.ExecuteScalar("select bid from tblbatch where Bcode='" + tempbatchid + "'");
                                gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;
                                gridmain.Rows[i].Cells["clnbatch"].Tag = tempbatchidTag;
                            }
                            //double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"].ToString());
                            //double tempcrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["crate"].ToString());
                            //double tempmrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["mrp"].ToString());

                            gridmain.Rows[i].Cells["clnslno"].Value = i + 1;

                            gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                            gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                            gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                            gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                            gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpointStock(temppRate);
                            gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpointStock(tempsrate);
                            //gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpointStock(temptaxrate);
                            rowindex = i;

                            if (SUnit == true)
                            {
                                Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + TxtVno.Text + "' and pcode='" + Pcode + "' and vtype='OS'");
                                string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                                gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                                gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                                ItemId = tempitemid;
                                UnitName = Unit;
                                UnitAmountCalc();
                            }
                            CellEnterCalculationPart();
                        }
                        TottalAmountCalculate();

                    }
                    else
                    {
                        PreIssuecode = PreIssuecode - 1;
                        GetPrevious(PreIssuecode);
                    }
                }
            }
            catch
            {
                Clear();
            }

        }

        public void UnitAmountCalc()
        {
            DS3 = _Dbtask.ExecuteQuery("select * from tblItemmaster where ItemId='" + ItemId + "'");
            //for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            //{
            if (DS3.Tables[0].Rows.Count > 0)
            {
                SecUnit = DS3.Tables[0].Rows[0]["Unit2"].ToString();
                FirUnit = DS3.Tables[0].Rows[0]["Unit"].ToString();
                Unitamount1 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount1"].ToString());
                UnitAmount2 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount2"].ToString());
                if (UnitName == SecUnit)
                {
                    Convrt = Unitamount1;
                }
                if (UnitName == FirUnit)
                {
                    Convrt = Unitamount1 * UnitAmount2;
                }

            }
            //}
        }


        public void NextgInitialize()
        {

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                /*For Inventory */
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {


                        if (SBatatch == true)
                        {
                            Batchcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        }

                        string TempItemid = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        string TempDepocode = SDepott;
                        double Tempqty = Convert.ToDouble(gridmain.Rows[i].Cells["ClnQty"].Value.ToString());

                        //string TempDepocode = ComDepot.SelectedValue.ToString();
                        double TempPrate = Convert.ToDouble(gridmain.Rows[i].Cells["clnrate"].Value.ToString());
                        double TempSrate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value.ToString());
                        if (SUnit == true)
                        {
                            Munit = Convert.ToInt16(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnunit"].Tag));
                        }

                        _Inventory.Vcode = TxtVno.Tag.ToString();
                        _Inventory.DCodeStr = TempDepocode;
                        _Inventory.InvDateDt = dtdate.Value;
                        _Inventory.PcodeStr = TempItemid;
                        _Inventory.Os = Tempqty;
                        _Inventory.Batchcode = Batchcode;


                        _Inventory.InsertInventory();

                        if (SBatatch == true)
                        {
                            DS3 = CommonClass._Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Batchcode + "'");

                            if (DS3.Tables[0].Rows.Count == 0)
                            {
                                _Batch.Bcode = Batchcode;
                                _Batch.Itemid = TempItemid; ;
                                _Batch.Costcenter = "0";
                                _Batch.Depo = SDepott;
                                _Batch.Bid = "";
                                _Batch.Recptcode = TxtVno.Text;
                                _Batch.Ledcode = "OS";
                                _Batch.Mrp = 0;
                                _Batch.Srate = TempSrate;
                                _Batch.Prate = TempPrate;
                                //_Batch.Recptcode=
                                _Batch.InsertBatch();
                            }
                        }

                        //  _ItemMaster.UpdateBalance("+", _Inventory.PcodeStr, _Inventory.Os);
                        /*For Receipt Details*/
                        _ReceiptDetails.RcptCodeLng = Convert.ToInt64(TxtVno.Tag);
                        _ReceiptDetails.SlNoLng = Convert.ToInt64(gridmain.Rows[i].Cells["Clnslno"].Value);
                        _ReceiptDetails.PCodeStr = TempItemid;
                        _ReceiptDetails.UnitIdLng = Munit;
                        _ReceiptDetails.MultiRateIdLng = 0;
                        _ReceiptDetails.QtyDb = Tempqty;
                        _ReceiptDetails.SRate = TempSrate;
                        _ReceiptDetails.RateDb = TempPrate;
                        _ReceiptDetails.BatchIdstr = Batchcode;
                        _ReceiptDetails.NetAmtDb = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        _ReceiptDetails.Vtype = "OS";


                        _ItemMaster.UpdateField(TempItemid, TempSrate, "srate");


                        _ItemMaster.UpdateField(TempItemid, TempPrate, "prate");

                        //_ReceiptDetails.QtyFreeDb = Convert.ToDouble(gridmain.Rows[i].Cells["Clnfree"].Value);
                        //_ReceiptDetails.DiscDb = Convert.ToDouble(gridmain.Rows[i].Cells["Clndiscount"].Value);
                        // _ReceiptDetails.TaxRateDb = Convert.ToDouble(gridmain.Rows[i].Cells["Clntax"].Value);

                        _ReceiptDetails.InsertReceiptDetails();
                    }
                }
            }
            /*For Transaction Receipt */
            if (Convert.ToDouble(txtbillamount.Text) != null)
            {

                _TransactionReceipt.RcptCodeLng = Convert.ToInt64(TxtVno.Tag);
                // _TransactionReceipt.IdOpeningStockFu();
                _TransactionReceipt.VNoStr = TxtVno.Text;
                _TransactionReceipt.RCptTypeStr = "OS";
                _TransactionReceipt.DcodeStr = SDepott;
                _TransactionReceipt.RcptDateDt = dtdate.Value;
                _TransactionReceipt.AMTDb = Convert.ToDouble(txtbillamount.Text);
                _TransactionReceipt.RemarkStr = TxtRemark.Text;
                _TransactionReceipt.LedCodeCr = Convert.ToString(0);
                _TransactionReceipt.LedCodeDr = Convert.ToString(0);
                _TransactionReceipt.EmpId = Convert.ToString(0);

                _TransactionReceipt.InsertTransactionReceipt();
            }
        }

        public void Clear()
        {
            lbldepot.Text = NextGFuntion.StockAreaName;
            EditMode = false;
            gridmain.Rows.Clear();
            _Nextg.ClearControles(this);
            _Nextg.SetControlesBehave(this);

            SetGridColumn();
            GetVno();
            FillCombo();
            TxtVno.Focus();
            //TxtVno.Select();
            TxtRemark.Text = "";
            txtnterprevno.Text = "";
            dtdate.Value = DateTime.Now;
            txttqty.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            TxtVno.Focus();
            CHKbatchwise.Checked = true;
        }
        public void Textalignsett()
        {
            gridmain.Columns["clnqty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridmain.Columns["clnsrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridmain.Columns["clnnettamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridmain.Columns["clnrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }
        public void FillCombo()
        {

            _Depot.FillCombo(ComDepot);
            ComDepot.SelectedIndex = 0;
        }
        public void GetVno()
        {
            _TransactionReceipt.IdOpeningStockFu();
            TxtVno.Tag = Convert.ToString(_TransactionReceipt.RcptCodeLng);
            TxtVno.Text = Convert.ToString(_TransactionReceipt.RcptCodeLng);
        }
        public void Insert()
        {

        }

        private void FrmopeningStock_Load(object sender, EventArgs e)
        {
            Textalignsett();
            gridmain.Controls.Add(TxtProduct);
            Clear();
            CommonClass._Nextg.FormIcon(this);
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {
                CHKbatchwise.Checked = true;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        public void ControleSettEnter(Control Cnt)
        {
            _Ingrid.ControleSettEnter(Cnt, gridmain);
        }


        public void ProductIntoMainGrid()
        {
            _Ingrid.ProductIntoMainGrid(gridmain, uscGridshow2.GridProductShow, selectedRow, rowindex, "Clnrate", "Clnprates");
            double tempprate = Convert.ToDouble(uscGridshow2.GridProductShow.Rows[selectedRow].Cells["clnprates"].Value);
            double tempsrate = Convert.ToDouble(uscGridshow2.GridProductShow.Rows[selectedRow].Cells["clnsrates"].Value);

            gridmain.Rows[rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(tempprate);
            gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsrate);
        }

        private void TxtProduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                if (TxtProduct.Text == "")
                {
                    this.Close();
                }
                else
                {
                    TxtProduct.Text = "";
                }
            }

            try
            {
                selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                if (e.KeyValue == 40 && uscGridshow2.GridProductShow.Rows[selectedRow].Cells[0].Value != null)
                {

                    if (uscGridshow2.GridProductShow.Rows[selectedRow + 1].Cells[0].Value != null)
                    {
                        uscGridshow2.GridProductShow.Rows[selectedRow + 1].Selected = true;
                        uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                    }
                }

                if (e.KeyValue == 38 && selectedRow != 0)
                {
                    uscGridshow2.GridProductShow.Rows[selectedRow - 1].Selected = true;
                    uscGridshow2.GridProductShow.Rows[selectedRow].Selected = false;
                }

                if (e.KeyValue == 13)
                {
                    ProductIntoMainGrid();
                }
            }
            catch
            {
            }
        }

       



        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            try
            {
                int NowselectedRow;
                string TempBathcode;

                if (ColumnName == "ClnUnit")
                {




                    Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");
                    CommonClass._commenevent.UpDowninGridList(Gridbatchlist, e.KeyValue, gridmain);
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {

                        if (e.KeyValue == 13 && Gridbatchlist.SelectedRows.Count > 0)
                        {

                            int select = Gridbatchlist.SelectedRows[0].Index;
                            UnitName = Gridbatchlist.Rows[select].Cells[0].Value.ToString();
                            Unitid = Gridbatchlist.Rows[select].Cells[0].Tag.ToString();
                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                SecUnit = Ds.Tables[0].Rows[i]["Unit2"].ToString();
                                FirUnit = Ds.Tables[0].Rows[i]["Unit"].ToString();
                                Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount1"].ToString());
                                UnitAmount2 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount2"].ToString());
                                if (UnitName == SecUnit)
                                {
                                    Convrt = Unitamount1;
                                }
                                if (UnitName == FirUnit)
                                {
                                    Convrt = Unitamount1 * UnitAmount2;
                                }

                            }
                            Gridbatchlist.Visible = false;
                        }
                        CellEnterCalculationPart();

                    }
                    TottalAmountCalculate();

                }
                if (ColumnName == "clnitemcode")
                    {
                  
                    if (SUnit == true)
                    {

                        Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            SecUnit = Ds.Tables[0].Rows[0]["Unit2"].ToString();
                            Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["UnitAmount1"].ToString());
                            gridmain.Rows[rowindex].Cells["ClnUnit"].Value = SecUnit;
                            Convrt = Unitamount1;
                        }

                    }
                    if (e.KeyValue == 13 && SBatatch == true && uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    {
                        {
                            //NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                            //TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                            //gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBathcode;
                        }
                    }

                    //_Ingrid.PreviewKeyDownInGrid(e.KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, IsEnter, (sender as TextBox).Text, Convert.ToInt64(ItemId), rowindex, columnindex, "Clnprate", "prate", "0");
                    (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["clnitemcode"].Value.ToString();
                        

                    _Ingrid.PreviewKeyDownInGrid(e.KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, IsEnter, (sender as TextBox).Text, Convert.ToInt64(ItemId), rowindex, columnindex, "Clnsrate", "srate", SDepott);
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                    if (e.KeyValue == 13)
                    {
                        
                        ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                        IsEnter = false;
                        (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["clnitemcode"].Value.ToString();
                        
                        if (SBatatch == false)
                        {
                            gridmain.Rows[rowindex].Cells["clnrate"].Value =_Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId,"prate"));
                            gridmain.Rows[rowindex].Cells["clnsrate"].Value =_Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "srate"));
                        }

                        uscGridshow2.Visible = false;
                    }
                }
                //if (ColumnName == "clnbatch")
                //{

                //    selectedRow = GridBatch.SelectedRows[0].Index;
                //    if (e.KeyValue == 40 && GridBatch.Rows[selectedRow].Cells[0].Value != null)
                //    {

                //        if (GridBatch.Rows[selectedRow + 1].Cells[0].Value != null)
                //        {
                //            GridBatch.Rows[selectedRow + 1].Selected = true;
                //            GridBatch.Rows[selectedRow].Selected = false;
                //        }
                //    }

                //    if (e.KeyValue == 38 && selectedRow != 0)
                //    {


                //        GridBatch.Rows[selectedRow - 1].Selected = true;
                //        GridBatch.Rows[selectedRow].Selected = false;
                //    }

                //    if (e.KeyValue == 13)
                //    {
                //        if (GridBatch.Rows[selectedRow].Cells[0].Value != null)
                //        {
                //            gridmain.Rows[rowindex].Cells["clnbatch"].Value = GridBatch.Rows[selectedRow].Cells[0].Value;
                //            GridBatch.Visible = false;
                //        }
                //    }
                //}
            }
            catch
            {
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
                            {
            try
            {
                gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
                string Temp = gridmain.Rows[rowindex].Cells[columnindex].Value.ToString();
                if (ColumnName == "clnitemcode")
                {
                    
                    _usc2.Passingusercontrole(gridmain, "Clnrate", "prate", rowindex, columnindex, uscGridshow2, false);
                    Temp = (sender as TextBox).Text;

                    
                    ProductGridShow(Temp);
                    //if (SBatatch == true)
                    //{
                    //    ProductGridShowWithBatch(Temp);
                    //}
                    //else
                    //{
                    //    ProductGridShow(Temp);
                    //}
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                }
                if (ColumnName == "ClnUnit")
                {
                    //LoadUnits((sender as TextBox).Text);
                    Gridbatchlist.Visible = true;
                    LoadUnits();
                }

                CellEnterCalculationPart();
                TottalAmountCalculate();
            }
            catch
            {
            }
            //RowValidation();
        }

        public void LoadUnits()
        {
            //Gridbatchlist.Location = new System.Drawing.Point(533,0);
            Gridbatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // CommonClass._Itemmaster.BatchlistshowBaseonItem(ItemId, Gridbatchlist, Search);
            Ds2 = _Dbtask.ExecuteQuery("select * from tblUnitcreation");
            for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            {
                Gridbatchlist.Rows.Add(1);

                Gridbatchlist.Rows[i].Cells[0].Value = Ds2.Tables[0].Rows[i]["Name"].ToString();
                Gridbatchlist.Rows[i].Cells[0].Tag = Ds2.Tables[0].Rows[i]["Id"].ToString();
            }
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSettGrid(Gridbatchlist, tempRect.Left, tempRect.Top + tempRect.Height + 24);
            Gridbatchlist.Columns[0].Width = Gridbatchlist.Width - 10;
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ColumnName = gridmain.Columns[columnindex].Name;
            if (ColumnName == "clnqty")
            {
                Generalfunction.allowNumeric(sender, e, true);
            }
            if (ColumnName == "clnrate" || ColumnName == "clnprate")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
        }

        private void gridmain_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridProductShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                ProductIntoMainGrid();
            }
            catch
            {
            }
        }

        private void gridmain_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (gridmain.Columns[columnindex].Name == "clnrate")
            {
                string TempString = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnrate"].Value));
                gridmain.Rows[rowindex].Cells["clnrate"].Value = TempString;
            }

        }

        private void TxtVno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyValue == 13)
            //{
            //    long Temvno = Convert.ToInt64(TxtVno.Text);
            //    GetPrevious(Temvno);
            //    if (SDepot == true)
            //    {
            //        ComDepot.Focus();
            //    }
            //    else
            //    {
            //        TxtRemark.Focus();
            //    }
            //}
        }

        private void ComDepot_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtRemark.Focus();
            }
        }

        private void TxtRemark_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                dtdate.Focus();
            }
        }

        private void dtdate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Focus();
            }
        }
        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdsave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            try
            {
                long Temvno = Convert.ToInt64(TxtVno.Tag) - 1;
                if (Temvno != 0)
                {
                    GetPrevious(Temvno);
                }
            }
            catch
            {
                Clear();
            }
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure to Delete this entry?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                Deletevoucher();
                Clear();
            }

        }

        private void TxtRemark_TextChanged(object sender, EventArgs e)
        {


        }

        private void ComDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SDepott = ComDepot.SelectedValue.ToString();
        }

        private void FrmopeningStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 121)
            {
                //if (pnlenetervno.Visible == true)
                //{
                //    pnlenetervno.Visible = false;
                //}
                //else
                //{
                //    pnlenetervno.Visible = true;
                //}
            }
        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (gridmain.SelectedCells.Count > 0)
                {
                    columnindex = gridmain.SelectedCells[0].ColumnIndex;
                    rowindex = gridmain.SelectedCells[0].RowIndex;
                    ColumnName = gridmain.Columns[columnindex].Name.ToString();
                    if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                    {
                        SendKeys.Send("{Tab}");
                        // return true;
                    }
                    if (ColumnName == "clnqty" || ColumnName == "clnrate" || ColumnName == "clnbatch" || ColumnName == "clnprate")
                    {

                        gridmain.BeginEdit(true);
                        //gridmain.Columns[columnindex].be
                    }
                    if (ColumnName == "clnitemcode")
                    {
                        IsEnter = true;
                    }
                    //if (ColumnName == "clnbatch")
                    //{
                    //    GridBatch.Rows.Clear();
                    //    Ds = _Dbtask.ExecuteQuery("select bcode from tblbatch where itemid='" + ItemId + "'");

                    //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    //    {
                    //        GridBatch.Rows.Add(1);
                    //        GridBatch.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i][0];
                    //    }
                    //    GridBatch.Visible = true;
                    //    if (GridBatch.Rows.Count > 1)
                    //    {
                    //      //  gridmain.Rows[rowindex].Cells["clnbatch"].Value = GridBatch.Rows[0].Cells[0].Value;
                    //    }
                    //    Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                    //    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height * 2);
                    //}
                }
            }
            catch
            {
            }
        }

        private void Cmdforward_Click(object sender, EventArgs e)
        {
            long Temvno = Convert.ToInt64(TxtVno.Text) + 1;
            GetPrevious(Temvno);
        }

        
        public void GridCellLeave()
        {
            try
            {
                if (ColumnName == "clnqty" || ColumnName == "clnrate" || ColumnName == "clnsrate" || ColumnName == "clnnettamount")
                {
                    double tempqty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                    double tempprate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnrate"].Value);
                    double tempsrate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                    double tempNettamt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnnettamount"].Value);

                    gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(tempqty);
                    gridmain.Rows[rowindex].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(tempprate);
                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsrate);
                    gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(tempNettamt);
                }

                if (ColumnName == "clnbatch"&&SBatatch==true)
                {
                    Batchcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                     Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Batchcode + "'");
                     if (Ds.Tables[0].Rows.Count > 0)
                     {
                         TempItemid = CommonClass._Batch.GetSpecificFieldofBatch(Batchcode, "itemid");
                         TempPrate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Batchcode, "prate"));
                         TempSrate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Batchcode, "srate"));
                         ItemCode = CommonClass._Itemmaster.SpecificField(TempItemid, "itemcode");
                         ItemName = CommonClass._Itemmaster.SpecificField(TempItemid, "itemname");

                         gridmain.Rows[rowindex].Cells["CLNITEMCODE"].Value = ItemCode;
                         gridmain.Rows[rowindex].Cells["clnitemname"].Value = ItemName;
                         gridmain.Rows[rowindex].Cells["clnitemname"].Tag = TempItemid;

                         gridmain.Rows[rowindex].Cells["clnrate"].Value = TempPrate;
                         gridmain.Rows[rowindex].Cells["clnsrate"].Value = TempSrate;
                         TottalAmountCalculate();
                     }
                     else
                     {
                         gridmain.Rows[rowindex].Cells["CLNITEMCODE"].Value = "";
                         gridmain.Rows[rowindex].Cells["clnitemname"].Value = "";
                         gridmain.Rows[rowindex].Cells["clnitemname"].Tag = "";

                         gridmain.Rows[rowindex].Cells["clnrate"].Value = "0";
                         gridmain.Rows[rowindex].Cells["clnsrate"].Value = "0";
                     }
                }
                if (gridmain.Columns[columnindex].Name.ToString().ToLower() == "clnunit")
                {
                    if (SUnit == true)
                    {
                        if (UnitName == FirUnit)
                        {
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName + " " + "(" + Unitamount1 + FirUnit + "=" + UnitAmount2 + SecUnit + ")";
                        }
                        else
                        {
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName;
                        }
                        gridmain.Rows[rowindex].Cells["clnunit"].Tag = Unitid;
                        gridmain.NotifyCurrentCellDirty(false);

                    }
                }
                
            }
            catch
            {
            }
        }

        private void lblprateautofilling_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure Filling Purchase Rate?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                AutofillingPrate();
            }
        }

        public void AutofillingPrate()
        {
            string Bcode;
            double Prate;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (SBatatch == true)
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag != null || _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value) != "")
                    {
                        ItemId = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        Prate = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Bcode, "prate", ItemId));
                        gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Prate);
                    }
                }
                else
                {
                    if (SBatatch == false)
                        if (gridmain.Rows[i].Cells["clnitemname"].Tag != null)
                        {
                            ItemId = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                            Prate = Convert.ToDouble(CommonClass._Itemmaster.SpecificField(ItemId, "prate"));
                            gridmain.Rows[i].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Prate);
                        }
                }
            }
        }

        private void txtnterprevno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    long Temvno = Convert.ToInt64(txtnterprevno.Text);
                    if (Temvno != 0)
                    {
                        GetPrevious(Temvno);
                    }
                }
                catch
                {
                    Clear();
                }
            }
        }

        private void Linkimportfromtool_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Import Qplex Barcode Tool";
            theDialog.Filter = "Qplex Barcode Tool|*.ZBT";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() ==DialogResult.OK)
            {
                IsinToolimport = true;
                string Filepath = theDialog.FileName;
                //Ds.WriteXml("e:\\results.xml", System.Data.XmlWriteMode.IgnoreSchema);
                Ds.ReadXml(Filepath);
                //string Bcode = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                //string Itemid = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();

                gridmain.Rows.Clear();


                //  Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Bcode + "' and itemid ='" + Itemid + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {


                    if (Ds.Tables[0].Rows[i][0] != null)
                    {
                        gridmain.Rows.Add(1);
                        string ItemCode;
                        string ItemName;

                        Batchcode = Ds.Tables[0].Rows[i][0].ToString();
                        Tempqty = _Dbtask.znullDouble(Ds.Tables[0].Rows[i][1].ToString());
                        TempItemid = _Batch.GetSpecificFieldofBatch(Batchcode, "itemid");
                        TempPrate = _Dbtask.znullDouble(_Batch.GetSpecificFieldofBatch(Batchcode, "prate"));
                        TempSrate = _Dbtask.znullDouble(_Batch.GetSpecificFieldofBatch(Batchcode, "srate"));

                        ItemCode = _ItemMaster.SpecificField(TempItemid, "itemcode");
                        ItemName = _ItemMaster.SpecificField(TempItemid, "itemname");
                        gridmain.Rows[i].Cells["clnitemcode"].Value = ItemCode;
                        gridmain.Rows[i].Cells["clnitemname"].Value = ItemName;
                        gridmain.Rows[i].Cells["clnitemname"].Tag = TempItemid;

                        gridmain.Rows[i].Cells["clnbatch"].Value = Batchcode;
                        gridmain.Rows[i].Cells["clnqty"].Value = Tempqty;
                        gridmain.Rows[i].Cells["clnrate"].Value = TempPrate;
                        gridmain.Rows[i].Cells["clnsrate"].Value = TempSrate;
                        rowindex = i;

                        CellEnterCalculationPart();
                        TottalAmountCalculate();

                    }


                }
            }


        }

        private void FrmopeningStock_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                _Nextg.CloseGriddetail(gridmain, this);
            }
        }

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            GridCellLeave();
        }

        private void CHKbatchwise_CheckedChanged(object sender, EventArgs e)
        {
            

        }
       
    }
}