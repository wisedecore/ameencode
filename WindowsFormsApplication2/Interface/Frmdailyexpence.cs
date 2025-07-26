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
    public partial class Frmdailyexpence : Form
    {
        public Frmdailyexpence()
        {
            InitializeComponent();
        }

        DBTask _Dbtask = new DBTask();
        DataSet Ds;

        double DbAmt;
        double CrAmt;
        public  static bool Isinotherwindow;
        public bool EditMode;
        public int mode;
        public string Vtype;
        string Columnname;
        int selectedRow;
        int rowindex;
        int columnindex;
        double TotalDebit;
        double TotalCredit;
        double TottalAmount;
    
        string Naration2;
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "pnlbill")
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (uscLedgershow1.Visible == true )
                    {
                        if (msg.WParam.ToInt32() == (int)Keys.Down)
                        {
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            return true;

                        }
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);


            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Columnname == "clnledger")
            {
                if (e.KeyValue != 13)
                {
                    CommonClass._Ingrid.RowUpDownSelect(e.KeyValue, uscLedgershow1.GridProductShow, selectedRow, uscLedgershow1, gridmain);
                }

                if (e.KeyValue == 27)
                {
                    if (gridmain.Visible == false)
                    {
                        this.Close();
                    }
                    else
                    {
                        gridmain.Visible = true;
                    }
                }

                if (e.KeyValue == 13)
                {
                    LedgerIntoMainGrid();
                }

            }
           

        }

       
        public void LedgerIntoMainGrid()
        {
            if (uscLedgershow1.GridProductShow.SelectedRows.Count > 0)
            {
                int SubSelectRow = uscLedgershow1.GridProductShow.SelectedRows[0].Index;
                if (uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells[0].Value != null && uscLedgershow1.Visible == true)
                {
                    gridmain.Rows[rowindex].Cells["Clnledger"].Value = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["name"].Value;
                    gridmain.Rows[rowindex].Cells["Clnledger"].Tag = uscLedgershow1.GridProductShow.Rows[SubSelectRow].Cells["lid"].Value;
                    uscLedgershow1.Visible = false;
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            gridmain.Rows[rowindex].Cells[Columnname].Value = (sender as TextBox).Text;
            CommonClass.temp = _Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value);
            if (Columnname == "clnledger")
            {
                if (Isinotherwindow == false)
                {
                    CommonClass._Ingrid.LedgerGridShow(uscLedgershow1, " where lname like '%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow, "0", 0);

                    Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                    if (tempRect.Top > 180)
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, 0);
                    }
                    else
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, tempRect.Top + tempRect.Height+55);
                    }
                }
            }

            CalcTottal();    
        }

        public void CalcTottal()
        {
            try
            {
                TottalAmount = 0;
                TotalDebit = 0;
                TotalCredit = 0;
                double Amount=0;
                
               
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnledger"].Tag != null)
                    {
                        if (gridmain.Rows[i].Cells["clndebit"].Value == null)
                        {
                            gridmain.Rows[i].Cells["clndebit"].Value = 0;
                        }
                        if (gridmain.Rows[i].Cells["clncredit"].Value == null)
                        {
                            gridmain.Rows[i].Cells["clncredit"].Value = 0;
                        }

                        TotalDebit =TotalDebit+ _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndebit"].Value);
                        TotalCredit =TotalCredit+ _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clncredit"].Value);
                       
                       
                    }
                }
                TottalAmount = TotalDebit - TotalCredit;
                txttotaldebit.Text = _Dbtask.SetintoDecimalpoint(TotalDebit);
                txttotalcredit.Text = _Dbtask.SetintoDecimalpoint(TotalCredit);
                txtbillamount.Text = _Dbtask.SetintoDecimalpoint(TottalAmount);
            }
            catch
            {

            }
        }


        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnledger"].Tag == null )
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {
                        if (Convert.ToDouble(gridmain.Rows[i].Cells["clndebit"].Value) == Convert.ToDouble(0) && Convert.ToDouble(gridmain.Rows[i].Cells["clncredit"].Value) == Convert.ToDouble(0))
                            gridmain.Rows[i].Tag = -1;
                        else
                        gridmain.Rows[i].Tag = 1;
                    }
                }
            }
            catch
            {

            }
        }

        public void Getvno()
        {
                CommonClass._GenLedger.IdGeneralLedger(" where vtype='DE'");
                txtvno.Text = CommonClass._GenLedger.VnoStr;
        }

        private bool ValidationFu()
        {
            if (ComLedger.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cash Account", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComLedger.Focus();
                return false;
            }
            try
            {
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
                            MessageBox.Show("No Valid Entries", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void DeleteVoucher()
        {
            _Dbtask.ExecuteNonQuery("Delete from tblgeneralledger where vtype='DE' and vno='" + txtvno.Text + "'");
        }

        public void NextgInitialize()
        {
           
              CommonClass._GenLedger.VdateDt = dtdate.Value;
              CommonClass._GenLedger.VTypeStr = Vtype;
              CommonClass._GenLedger.VnoStr = txtvno.Text;
              CommonClass._GenLedger.SlNoLng = 1;
              CommonClass._GenLedger.Naration = TxtNarration.Text;
              CommonClass._GenLedger.RefnoStr = TxtRefNo.Text;
              CommonClass._GenLedger.Uid = ClsUserDetails.MUserName;

                if (ComStaff.SelectedValue != null)
                    CommonClass._GenLedger.EmployeeIdStr = ComStaff.SelectedValue.ToString();
                else
                    CommonClass._GenLedger.EmployeeIdStr = "1";

                string Selectedledger = ComLedger.SelectedValue.ToString();
                string MainGroupid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lid='" + Selectedledger + "'");

               
                string VtypeString;


                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            string Ledcode = Convert.ToString(gridmain.Rows[i].Cells["clnledger"].Tag);
                            string Purticulars = CommonClass._GenLedger.PurticularsStr;
                            Naration2 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnnote"].Value);
                            CommonClass._GenLedger.SlNoLng = i + 1; ;
                            CommonClass._GenLedger.LedCodeStr = Ledcode;
                            CommonClass._GenLedger.PurticularsStr =_Dbtask.znllString(gridmain.Rows[i].Cells["clnledger"].Value);
                            CommonClass._GenLedger.Naration2 = Naration2;
                            CommonClass._GenLedger.Pproject = 0;

                            TotalDebit = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndebit"].Value);
                            TotalCredit = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clncredit"].Value);

                            if (TotalDebit>0)
                            {
                                DbAmt = 0;
                                CrAmt = TotalDebit;
                                CommonClass._GenLedger.DbAmtDb = DbAmt;
                                CommonClass._GenLedger.CrAmt = CrAmt;
                                if (Ledcode != "" )
                                {
                                    if (DbAmt != 0 || CrAmt != 0)
                                    {
                                        CommonClass._GenLedger.InsertGeneralLedger();
                                        
                                        CommonClass._GenLedger.LedCodeStr = Selectedledger;
                                        CommonClass._GenLedger.DbAmtDb = CrAmt;
                                        CommonClass._GenLedger.CrAmt = DbAmt;
                                        CommonClass._GenLedger.InsertGeneralLedger();
                                    }
                                }
                            }

                            if (TotalCredit > 0)
                            {
                                DbAmt = TotalCredit;
                                CrAmt = 0;
                                CommonClass._GenLedger.DbAmtDb = DbAmt;
                                CommonClass._GenLedger.CrAmt = CrAmt;
                                if (Ledcode != "" )
                                {
                                    if (DbAmt != 0 || CrAmt != 0)
                                    {
                                        CommonClass._GenLedger.InsertGeneralLedger();

                                        CommonClass._GenLedger.LedCodeStr = Selectedledger;
                                        CommonClass._GenLedger.DbAmtDb = CrAmt;
                                        CommonClass._GenLedger.CrAmt = DbAmt;
                                        CommonClass._GenLedger.InsertGeneralLedger();
                                    }
                                }
                            }
                        }
                    }
                } 
        }

        public void FilCombo()
        {
           CommonClass._Ledger.FillComboWhereNormal(ComLedger, " where AGroupId=25 or  AGroupId=24 ");
          CommonClass._Employee.FillCombo(ComStaff);
        }


         public void GetPrevious(string Prevno)
        {
            try
            {
                if (Convert.ToInt64(Prevno) >= 1)
                {
                        string TempPrevno = Prevno;
                        Isinotherwindow = true;
                        Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1' order by slno asc");
                        if (Ds.Tables[0].Rows.Count == 0)
                        {
                            GetPrevious((Convert.ToInt64(Prevno) - 1).ToString());
                            TempPrevno = (Convert.ToInt16(Prevno) - 1).ToString();
                        }
                        else
                        {
                            dtdate.Value = Convert.ToDateTime(_Dbtask.ExecuteScalar("select vdate from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1'"));
                            ComLedger.SelectedValue = _Dbtask.ExecuteScalar("select ledcode from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1'");

                            string Emp = _Dbtask.ExecuteScalar("select employee from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1'");
                            string RefNo = _Dbtask.ExecuteScalar("select refno from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1'");
                            string Naration = _Dbtask.ExecuteScalar("select naration from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1'");
                            string DiscAmt = _Dbtask.ExecuteScalar("select dbamt from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and ledcode !='1' and Ledcode='7'");
                            if (Emp != "")
                                ComStaff.SelectedValue = Emp;
                            TxtRefNo.Text = RefNo;
                            TxtNarration.Text = Naration;
                        }
                    
                    gridmain.Rows.Clear();
                    txtvno.Text = TempPrevno;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        EditMode = true;
                        gridmain.Rows.Add(1);
                        rowindex = i;
                        gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                        gridmain.Rows[i].Cells["clnledger"].Tag = Ds.Tables[0].Rows[i]["ledcode"];
                        gridmain.Rows[i].Cells["clnnote"].Value = Ds.Tables[0].Rows[i]["naration2"];
                        gridmain.Rows[i].Cells["clnledger"].Value = CommonClass._Ledger.GetspecifField("lname", Ds.Tables[0].Rows[i]["ledcode"].ToString());

                        _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");

                        gridmain.Rows[i].Cells["clndebit"].Value = Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                        gridmain.Rows[i].Cells["clncredit"].Value = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]);

                        CalcTottal();
                    }
                }
                Isinotherwindow = false;
            }
            catch
            {
                Clear();
            }
            uscLedgershow1.Visible = false;
        }


        public void Clear()
        {
            Isinotherwindow = false;
            uscLedgershow1.Visible = false;
            dtdate.Value = DateTime.Now;
            gridmain.Rows.Clear();
            Getvno();
            FilCombo();
            EditMode = false;
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtRefNo.Text = "";
            TxtNarration.Text = "";
            dtdate.Focus();

            CommonClass._Nextg.FormIcon(this);
        }

        private bool Main()
        {
            if (EditMode == false)
            {
                Getvno();
            }

            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteVoucher();
                    }

                    NextgInitialize();
                    //if (EditMode == false)
                    //{
                    //    _NextgFunction.Registrationinsert(1);
                    //}
                    //if (ChkPrintWileSaving.Checked == true)
                    //    Print();
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

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = gridmain.CurrentCell.RowIndex;
                columnindex = gridmain.CurrentCell.ColumnIndex;
                Columnname = gridmain.Columns[columnindex].Name.ToString();
                gridmain.Rows[rowindex].Cells["clnslno"].Value = rowindex + 1;
                if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                }
                if (Columnname == "clnamount")
                {
                    gridmain.BeginEdit(true);
                }

            }
            catch
            {
            }
        }

        private void Frmdailyexpence_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            DeleteVoucher();
            Clear();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Text) - 1).ToString());
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Text) + 1).ToString());
        }
    }
}
