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
    public partial class Frmcash : Form
    {
        public Frmcash()
        {
            InitializeComponent();
        }
        public bool Registration = false;
        ClsReceiptandPayment _ReceiptPayment = new ClsReceiptandPayment();
        /*Settings*/

        bool Spartyproject;

        public double taxperc = 0;
        /******************************/
        public string Selledcode;
        public string NewData = ""; public string resultt = "";
        public string OldData="";
        public string StrVtyp="";
        public string Naration="";
        public string Naration2 = "";
        public string CompanyNameStr;
        public long PProject;
        public bool rptax = false;
        public static bool Isinotherwindow ;
        public string Voucher; 
        public int mode;
        public string Vtype;
        public int rowindex;
        public int columnindex;
        public string Columnname;
        public int Countrow;
        public string rpprint = "";
        public int selectedRow;
        bool IsEnter;
        public bool EditMode =false;
        public double TottalAmount;
        double DbAmt;
        double CrAmt;
        double Discount;
        string AmountinWords;
        string temp;
        string Selectedprint;
        string PrintSelect;
        string id;
        string Name;
        string Billwiseno;

        ClsInvThermalSummury _ThermalThermal = new ClsInvThermalSummury();
        bool Printwhilesavings;
        LPrinter MyPrinter=new LPrinter();
        ClsGeneralLedger _generalLedger = new ClsGeneralLedger();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsEmployeeMaster _ClsEmployeeMaster = new ClsEmployeeMaster();
        NextGFuntion _NextgFunction = new NextGFuntion();
        DBTask _Dbtask = new DBTask();
        ClsInGrid _InGrid = new ClsInGrid();
        DataSet Ds = new DataSet();
        Generalfunction _Gen = new Generalfunction();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        Clsforms _Forms = new Clsforms();
        public static bool lbool = false;
        RichTextBox RichTextBox1 = new RichTextBox();

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
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
                    if (uscLedgershow1.Visible == true||Gridpartyproject.Visible==true)
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

        private void Frmcash_Load(object sender, EventArgs e)
        {
            lbool = true; rptax = true;
            _NextgFunction.FormStylesett(this);
            SetGridColumn();
            Textalignsett();
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                uscLedgershow1.Visible = false;
                Lblpartybalance.Visible = false;
                SetHeading();
                FilCombo();
                SetDecimal();
                EditMode = true;
                GetPreOnload();
            }
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        public void GetPreOnload()
        {
            if (Isinotherwindow == true && txtvno.Text != "")
            {
                GetPrevious(txtvno.Text);
            }
        }
        public void Clear()
        {
            GetMenusettings();
            Registration =CommonClass._Nextg.NextgRegistration();
            rptax = false;
            Isinotherwindow = false;
            uscLedgershow1.Visible = false;
            Lblpartybalance.Visible = false;
            dtdate.Value = DateTime.Now;
            _NextgFunction.ClearControles(this);
            _NextgFunction.SetControlesBehave(this);

            try
            {
                if (gridmain.Rows.Count != 0)
                {
                    gridmain.Rows.Clear();
                }
            }
            catch
            {
            }
             SetHeading();
            GetVno();
            FilCombo();
            SetDecimal();
            EditMode= false;
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(0);
            txtdiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtRefNo.Text = "";
            TxtNarration.Text = "";
            dtdate.Focus();
            cmdprint.Enabled = true;
            rptax = true;
            setprinttype();

            if (CommonClass._settings.ReturnStatus("229") == "1")
            {
                chkReceiptbalance.Checked = true;
            }
            else
            {
                chkReceiptbalance.Checked = false;
            }


        }
        public void SetDecimal()
        {
            gridmain.Columns["Clnamount"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            txtbillamount.Text=_Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtbillamount.Text));
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void GetVno()
        {
            if (mode == 0)
            {    
                Vtype = "R";
            }
            if (mode == 1)
            {
                
                Vtype = "P";
            }
            if (mode == 2)
            {
                Vtype = "DBN";
            }
            if (mode == 3)
            {
                Vtype = "CRN";
            }
            if (mode == 4)
            {
                Vtype = "JNR";
            }
            if (mode == 5)
            {
                Vtype = "JNP";
            }
            if (mode == 6)
            {
                Vtype = "CNR";
            }
            _generalLedger.IdGeneralLedger(" where vtype='"+Vtype+"'");
            txtvno.Text = _generalLedger.VnoStr;
        }

        public void FilCombo()
        {
            if (mode == 0 || mode == 1)
                 _AccountLedger.FillComboWhereNormal(ComLedger, " where AGroupId=25 or  AGroupId=24 ");
            else if(mode==6)
                _AccountLedger.FillComboWhereNormal(ComLedger, " where AGroupId=25 or  AGroupId=24 ");
            else
                CommonClass._Ledger.FillComboWhere(ComLedger, "");
           
            _ClsEmployeeMaster.FillCombo(ComStaff);
            CommonClass._Gen.FillActivePrinter(ComPrintSheme);

        }
        public void SetHeading()
        {
            if (mode == 0)
            {
                this.Text = "Receipt";
                lblledger.Text = "Debit Ledger";
            }
            if (mode == 1)
            {
                this.Text = "Payment";
                lblledger.Text = "Credit Ledger";
            }
            if (mode == 2)
            {
                this.Text = "Debit Note";
                lblledger.Text = "Debit Ledger ";
            }
            if (mode == 3)
            {
                this.Text = "Credit Note";
                lblledger.Text = "Credit Ledger";
            }
            if (mode == 4)
            {
                this.Text = "JOURNAL RECEIPT";
                lblledger.Text = "Debit Ledger";
            }
            if (mode == 5)
            {
                this.Text = "JOURNAL PAYMENT";
                lblledger.Text = "Credit Ledger";
            }
            if (mode == 6)
            {
                this.Text = "CONTRA ENTRY";
                lblledger.Text = "Debit Ledger";
            } 
        }
 
        public void GetPrevious(string Prevno)
        {
            try
                        {
                if (Convert.ToInt64(Prevno) >= 1)
                {
                    rptax = true;
                    string TempPrevno = Prevno;
                    if (Vtype == "P"||Vtype=="CRN"||Vtype=="JNP")
                    {
                        Isinotherwindow = true;
                        Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0' order by slno asc");

                        if (Ds.Tables[0].Rows.Count == 0 && Convert.ToInt32(Prevno) > 0)
                        {
                            Clear();
                            if (Convert.ToInt32(TempPrevno) < Convert.ToInt32(Generalfunction.getnextid("vno", "tblgeneralledger where vtype='P'")))
                            {
                                txtvno.Text = TempPrevno;
                                EditMode = true;

                            }
                            //GetPrevious((Convert.ToInt64(Prevno) - 1).ToString());
                            //TempPrevno = (Convert.ToInt16(Prevno) - 1).ToString();
                        }
                        else
                        {
                            dtdate.Value = Convert.ToDateTime(_Dbtask.ExecuteScalar("select vdate from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0' and ledcode !=7"));
                            ComLedger.SelectedValue = _Dbtask.ExecuteScalar("select ledcode from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0'");
                            txtvno.Text = TempPrevno;
                            string Emp = _Dbtask.ExecuteScalar("select employee from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0'");
                            string RefNo = _Dbtask.ExecuteScalar("select refno from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0'");
                            string Naration = _Dbtask.ExecuteScalar("select naration from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0'");
                            string DiscAmt = _Dbtask.ExecuteScalar("select cramt from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and dbamt='0' and Ledcode='6'");

                            if (Emp != "")
                                ComStaff.SelectedValue = Emp;
                            TxtRefNo.Text = RefNo;
                            TxtNarration.Text = Naration;
                            txtdiscount.textBox1.Text = DiscAmt;
                        }
                    }

                    if (Vtype == "R"||Vtype=="DBN"||Vtype=="JNR"||Vtype=="CNR")
                    {
                        Isinotherwindow = true;
                        Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and Dbamt='0' order by slno asc");
                        if (Ds.Tables[0].Rows.Count == 0)
                        {
                            Clear();
                            if (Convert.ToInt32(TempPrevno) < Convert.ToInt32(Generalfunction.getnextid("vno", "tblgeneralledger where vtype='R'")))
                            {
                                txtvno.Text = TempPrevno;
                                EditMode = true;

                            }

                            //GetPrevious((Convert.ToInt64(Prevno) - 1).ToString());
                            //TempPrevno = (Convert.ToInt16(Prevno) - 1).ToString();
                        }
                        else
                        {
                            dtdate.Value = Convert.ToDateTime(_Dbtask.ExecuteScalar("select vdate from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0'"));
                            ComLedger.SelectedValue = _Dbtask.ExecuteScalar("select ledcode from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0' and ledcode !=7");
                            txtvno.Text = TempPrevno;
                            string Emp = _Dbtask.ExecuteScalar("select employee from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0'");
                            string RefNo = _Dbtask.ExecuteScalar("select refno from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0'");
                            string Naration = _Dbtask.ExecuteScalar("select naration from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0'");
                            string DiscAmt = _Dbtask.ExecuteScalar("select dbamt from  tblgeneralledger where vno='" + TempPrevno + "' and vtype='" + Vtype + "' and cramt='0' and Ledcode='7'");
                            if (Emp != "")
                                ComStaff.SelectedValue = Emp;
                            TxtRefNo.Text = RefNo;
                            TxtNarration.Text = Naration;
                            txtdiscount.textBox1.Text = DiscAmt;
                        }
                    }
                    if (gridmain.Rows.Count != 0)
                    {
                        gridmain.Rows.Clear();
                    }
                    //txtvno.Text = TempPrevno;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        EditMode = true;
                        gridmain.Rows.Add(1);
                                    rowindex = i;
                        gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                        gridmain.Rows[i].Cells["clnledger"].Tag = Ds.Tables[0].Rows[i]["ledcode"];
                        gridmain.Rows[i].Cells["clnnote"].Value = Ds.Tables[0].Rows[i]["naration2"];
                        gridmain.Rows[i].Cells["clnnote"].Tag= Ds.Tables[0].Rows[i]["Agvno"];
                        gridmain.Rows[i].Cells["clnledger"].Value = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");

                        if (Spartyproject == true)
                        {
                            PProject =Convert.ToInt64(_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["pproject"]));
                            gridmain.Rows[i].Cells["clnpartyproject"].Tag = PProject;
                            gridmain.Rows[i].Cells["clnpartyproject"].Value = CommonClass._Partyproject.GetspecifField("pname", PProject.ToString());
                        }

                        gridmain.Rows[i].Cells["ClnTaxperc"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["RPtaxperc"]);
                        gridmain.Rows[i].Cells["clnamount"].Value = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]) + Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                        CalcTottal(_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnamount"].Value),true);
                    }

                    
                   
                    pnlbill.Visible = false;
                }
                OldData = "VchNo:" + txtvno.Text + ",Party :" + ComLedger.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;

                Isinotherwindow = false;
            }
            catch
            {
                Clear();
            }
            uscLedgershow1.Visible = false;
        }

        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnledger"].Tag == null || Convert.ToDouble(gridmain.Rows[i].Cells["clnamount"].Value) == Convert.ToDouble(0))
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {
                        gridmain.Rows[i].Tag = 1;
                        gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }
            }
            catch
            {

            }
        }

        public void ForLogindetails(string Mode)
        {
            StrVtyp = CommonClass._Nextg.VtypeDescription(Vtype);
            if (Mode == "NEW")
            {
                NewData = "VchNo:" + txtvno.Text + ",Party :" + ComLedger.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                OldData = "";
                CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "NEW", "", StrVtyp, OldData, NewData);
            }
            else if (Mode == "UPDATE")
            {
                NewData = "VchNo:" + txtvno.Text + ",Party :" + ComLedger.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "UPDATE", "", StrVtyp, OldData, NewData);
            }
            else if (Mode == "DELETE")
            {
                NewData = "VchNo:" + txtvno.Text + ",Party :" + ComLedger.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", StrVtyp, OldData, NewData);
            }
        }
        public double partybalance()
        {
            double balances = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        string Ledcode = Convert.ToString(gridmain.Rows[i].Cells["clnledger"].Tag);



                        balances = _Dbtask.znlldoubletoobject(_AccountLedger.Balanceofledger(Ledcode));
                        i = gridmain.Rows.Count;

                    }
                }
            }
            return balances;
        }
        private bool Main()
        {
            if (EditMode == false)
            {
                GetVno();
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

                    if (EditMode == true)
                    {
                        ForLogindetails("UPDATE");
                    }
                    else
                    {
                        ForLogindetails("NEW");
                    }
                    _ReceiptPayment.oldparyamt = _Dbtask.znllString(oldbalance());
                    NextgInitialize();

                    _ReceiptPayment.partybalance = _Dbtask.znllString(partybalance());
                    if (EditMode == false)
                    {
                        _NextgFunction.Registrationinsert(1);
                    }
                    if (ChkPrintWileSaving.Checked == true)
                        Print();
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

            if (EditMode == true)
            {
                if (_UserDetails.Permited() == false)
                {
                    return false;
                }
            }

            if (ComLedger.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cash Account", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("No Valid Entries", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
            //if (EditMode == true)
            //{
            //    if (_UserDetails.Permited() == false)
            //    {
            //        return false;
            //    }
            //}
        }
        
        public void Insert()
        {
            _generalLedger.InsertGeneralLedger();
        }
        
        public void DiscountInsertFu(string Lid)
        {
            Discount = _Dbtask.znullDouble(txtdiscount.textBox1.Text);
            if (Discount > 0)
            {
                if (Lid == "7")
                {
                    _generalLedger.LedCodeStr = Lid;
                    _generalLedger.DbAmtDb = Discount;
                    _generalLedger.CrAmt = 0;
                    Insert();

                    //_generalLedger.LedCodeStr = ComLedger.SelectedValue.ToString();
                    //_generalLedger.DbAmtDb =0 ;
                    //_generalLedger.CrAmt = Discount;
                    //Insert();
                }
                else
                {
                    _generalLedger.LedCodeStr = Lid;
                    _generalLedger.DbAmtDb = 0;
                    _generalLedger.CrAmt = Discount;
                    Insert();

                    //_generalLedger.LedCodeStr = ComLedger.SelectedValue.ToString();
                    //_generalLedger.DbAmtDb = Discount;
                    //_generalLedger.CrAmt = 0;
                    //Insert();
                }
            }
        }

        public void NextgInitialize()
            {
            Discount = _Dbtask.znullDouble(txtdiscount.textBox1.Text);
            double TAmt = Convert.ToDouble(txtbillamount.Text) ;
            

            if (TAmt > 0)
            {
                _generalLedger.VdateDt = dtdate.Value;
                _generalLedger.VTypeStr = Vtype;
                _generalLedger.VnoStr = txtvno.Text;
                _generalLedger.SlNoLng = 1;
                _generalLedger.Naration = TxtNarration.Text;
                _generalLedger.RefnoStr = TxtRefNo.Text;
                _generalLedger.Uid = ClsUserDetails.MUserName;

                if (ComStaff.SelectedValue != null)
                    _generalLedger.EmployeeIdStr = ComStaff.SelectedValue.ToString();
                else
                    _generalLedger.EmployeeIdStr = "1";

                string Selectedledger = ComLedger.SelectedValue.ToString();
                string MainGroupid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lid='" + Selectedledger + "'");

                if (MainGroupid == "25")
                {
                    Voucher = "Cash ";
                }
                if (MainGroupid == "24")
                {
                    Voucher = "Bank ";
                }
                string VtypeString;

                if (Vtype == "CRN")
                {
                    VtypeString = "Credit Note";
                }
                if (Vtype == "DBN")
                {
                    VtypeString = "Debit Note";
                }

                if (Vtype == "JNR" || Vtype == "JNP")
                {
                    VtypeString = "Journel";
                }

                else
                {
                    VtypeString = Vtype;
                }

                if (Vtype == "P" || Vtype == "CRN" || Vtype == "JNP")
                {
                    _generalLedger.LedCodeStr = Selectedledger;

                    _generalLedger.PurticularsStr = Voucher + VtypeString;
                    _generalLedger.DbAmtDb = 0;
                    
                    _generalLedger.CrAmt = TAmt;
                    Insert();
                    DiscountInsertFu("6");
                    
                }
                if (Vtype == "R" || Vtype == "DBN" || Vtype == "JNR"||Vtype=="CNR")
                {
                    _generalLedger.LedCodeStr = Selectedledger;
                    _generalLedger.PurticularsStr = Voucher + VtypeString;
                    _generalLedger.DbAmtDb = TAmt;
                    _generalLedger.CrAmt = 0;
                    Insert();
                    DiscountInsertFu("7");
                }
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            string Ledcode = Convert.ToString(gridmain.Rows[i].Cells["clnledger"].Tag);

                            Selledcode = Ledcode;
                            
                            
                            string Purticulars = _generalLedger.PurticularsStr;
                            Naration2 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnnote"].Value);
                            _generalLedger.SlNoLng = Convert.ToInt64(gridmain.Rows[i].Cells["clnslno"].Value);
                           

                            if (Spartyproject == true)
                            {
                                PProject =Convert.ToInt64(_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnpartyproject"].Tag));
                            }



                            _generalLedger.LedCodeStr = Ledcode;
                            _generalLedger.PurticularsStr = Purticulars;
                            _generalLedger.Naration2 = Naration2;
                            _generalLedger.Pproject = PProject;
                            _generalLedger.RPtaxperc = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnTaxperc"].Value);
                            _generalLedger.RPtaxamt = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnTaxamt"].Value);

                            _generalLedger.Agvno = _Dbtask.znllString(gridmain.Rows[i].Cells["clnnote"].Tag);

                            if (Vtype == "P" || Vtype == "CRN" || Vtype == "JNP")
                            {
                                DbAmt = Convert.ToDouble(gridmain.Rows[i].Cells["clnamount"].Value);
                                CrAmt = 0;
                                Billwiseno = "";
                                Billwiseno = _Dbtask.znllString(gridmain.Rows[i].Cells["clnnote"].Tag);


                                _generalLedger.DbAmtDb=DbAmt;
                                _generalLedger.CrAmt = CrAmt;
                                _generalLedger.Agvno = Billwiseno;
                                if (Ledcode != "" && Purticulars != "")
                                {
                                    if (DbAmt != 0 || CrAmt != 0)
                                    {
                                        Insert();
                                    }
                                }



                                if (Billwiseno != "")
                                {
                                    if (_AccountLedger.GetspecifField("Agroupid", Selledcode) == "19")
                                    {
                                        CommonClass._purbill.InsertpurchaseBillsettlement(_Dbtask.znllString(txtvno.Text), Vtype, Convert.ToInt64(Ledcode), 0, DbAmt, Billwiseno, dtdate.Value, 0);
                                    }
                                    else
                                    {
                                        CommonClass._SRbill.InsertSRBillsettlement(_Dbtask.znllString(txtvno.Text), Vtype, Convert.ToInt64(Ledcode), 0, DbAmt, Billwiseno, dtdate.Value, 0);
                                    }
                                    
                                }




                            }

                            if (Vtype == "R" || Vtype == "DBN" || Vtype == "JNR"||Vtype=="CNR")
                            {
                                CrAmt = Convert.ToDouble(gridmain.Rows[i].Cells["clnamount"].Value);
                                DbAmt = 0;
                                Billwiseno = "";
                                Billwiseno = _Dbtask.znllString(gridmain.Rows[i].Cells["clnnote"].Tag);
                                
                                
                                _generalLedger.CrAmt = CrAmt;
                                _generalLedger.DbAmtDb = DbAmt;
                                _generalLedger.Agvno = Billwiseno;
                                /*Insert*/
                                if (Ledcode != "" && Purticulars != "")
                                {
                                    if (DbAmt != 0 || CrAmt != 0)
                                    {
                                      Insert();  
                                    }
                                }

                                if (Billwiseno != "")
                                {
                                    if (_AccountLedger.GetspecifField("Agroupid", Selledcode) == "18")
                                    {
                                        CommonClass._BillSett.InsertBillsettlement(txtvno.Text, Vtype, Convert.ToInt64(Ledcode), CrAmt, 0, Billwiseno, dtdate.Value, 0,"");
                                    }
                                    else
                                    {
                                        CommonClass._PRbill.InsertBillsettlementPR(txtvno.Text, Vtype, Convert.ToInt64(Ledcode), CrAmt, 0, Billwiseno, dtdate.Value, 0);
                                    }

                                }
                            }


                        }
                    }
                }
            }
        }

        public void PartyprojectinGrid()
        {
            if (Gridpartyproject.SelectedRows.Count > 0)
            {
                int SubSelectRow = Gridpartyproject.SelectedRows[0].Index;
                if (Gridpartyproject.Rows[SubSelectRow].Cells[0].Value != null && Gridpartyproject.Visible == true)
                {
                    gridmain.Rows[rowindex].Cells["clnpartyproject"].Value = Gridpartyproject.Rows[SubSelectRow].Cells[0].Value;
                    gridmain.Rows[rowindex].Cells["clnpartyproject"].Tag = Gridpartyproject.Rows[SubSelectRow].Cells[0].Tag;
                    Gridpartyproject.Visible = false;
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
        }

        public void LedgerIntoMainGrid()
        {
            if(uscLedgershow1.GridProductShow.SelectedRows.Count>0)
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

        private void Frmcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (pnlbill.Visible == true)
                {
                    pnlbill.Visible = false;
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void ShowPanelPreBill()
        {

            try
            {

                pnlbill.Visible = true;
                Selledcode = gridmain.Rows[rowindex].Cells["Clnledger"].Tag.ToString();
                if (Selledcode != "")
                {
                    if (Vtype == "R")
                    {
                        if (_AccountLedger.GetspecifField("Agroupid", Selledcode) == "18")
                        {
                            CommonClass._BillSett.ShowbillBaseonledger(Gridbillwisesettlement, Selledcode, dtdate.Value);
                        }
                        else
                        {
                            CommonClass._PRbill.ShowbillBaseonledger(Gridbillwisesettlement, Selledcode, dtdate.Value);
                        }

                    }
                    if (Vtype == "P")
                    {
                        if (_AccountLedger.GetspecifField("Agroupid", Selledcode) == "19")
                        {
                            CommonClass._purbill.ShowbillBaseonledger(Gridbillwisesettlement, Selledcode, dtdate.Value);
                        }
                        else
                        {
                            CommonClass._SRbill.ShowbillBaseonledger(Gridbillwisesettlement, Selledcode, dtdate.Value);

                        }


                    }



                    Gridbillwisesettlement.Visible = true;

                    Gridbillwisesettlement.CurrentCell = Gridbillwisesettlement.SelectedRows[0].Cells[2];

                    this.txtentervno.Focus();
                }
                else
                {
                    pnlbill.Visible = false;
                    Gridbillwisesettlement.Visible = false;
                    this.txtentervno.Focus();
                }


            }
            catch
            {
            }




            //pnlbill.Visible = true;
            ////Selledcode = gridmain.Rows[rowindex].Cells["Clnledger"].Tag.ToString();
           // CommonClass._BillSett.ShowbillBaseonledger(Gridbillwisesettlement, Selledcode,dtdate.Value);
          //  Gridbillwisesettlement.Visible = true;
            //this.txtentervno.Focus();
        }

        public void ProductGridShow()
        {
            try
            {
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            }
            catch
            {
            }
        }
        public double oldbalance()
        {
            double oldamount = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        string Ledcode = Convert.ToString(gridmain.Rows[i].Cells["clnledger"].Tag);


                        if (EditMode == false)
                        {
                            oldamount = _Dbtask.znlldoubletoobject(_AccountLedger.Balanceofledger(Ledcode));
                        }
                        else
                        {
                            oldamount = _Dbtask.znlldoubletoobject(_AccountLedger.Balanceofledgerwhere(Ledcode, "vdate < '" + dtdate.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "  '   "));
                        }
                        i = gridmain.Rows.Count;


                    }
                }
            }
            return oldamount;
        }
      
        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
            if (CommonClass._Gen.chkother() == true)
            {
                this.Close();
            }
        }
        public void DeleteVoucher()
        {
            if (EditMode == true)
            {
                if (CommonClass._UserDetails.Permited() == true)
                {


                    _Dbtask.ExecuteNonQuery("Delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "'");
                    _Dbtask.ExecuteNonQuery("Delete from tblbillsett where vtype='" + Vtype + "' and vno='" + txtvno.Text + "'");
                    _Dbtask.ExecuteNonQuery("Delete from tblSRbillsett where vtype='" + Vtype + "' and vno='" + txtvno.Text + "'");

                    _Dbtask.ExecuteNonQuery("Delete from tblPRbillsett where vtype='" + Vtype + "' and vno='" + txtvno.Text + "'");
                    _Dbtask.ExecuteNonQuery("Delete from tblpurchasebillsett where vtype='" + Vtype + "' and vno='" + txtvno.Text + "'");
        
                
                
                }


            }

        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {


            if (Columnname == "clnamount" || Columnname == "ClnTaxperc")
            {
                if (_Dbtask.znlldoubletoobject(gridmain.Rows[selectedRow].Cells[Columnname].Value) > 10000000)
                {
                    gridmain.Rows[selectedRow].Cells["ClnTaxperc"].Value = 0;
                    gridmain.Rows[selectedRow].Cells["clnamount"].Value = 0;
                    gridmain.Rows[selectedRow].Cells["ClnTaxamt"].Value = 0;

                    gridmain.NotifyCurrentCellDirty(false);
                }
            }

            if (Columnname == "clnledger")
            {
                if (e.KeyValue != 13)
                {
                    CommonClass._Ingrid.RowUpDownSelect(e.KeyValue, uscLedgershow1.GridProductShow, selectedRow, uscLedgershow1, gridmain);
                }

                if (e.KeyValue == 27)
                {
                    if (gridmain.Visible ==false)
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
            if (e.KeyValue == 114) /*For F3  Insert Rows */
            {
                gridmain.Rows.Insert(rowindex, 1);
                _Gen.SlSetfunction(gridmain, "clnslno");
            }
            if (Columnname == "clnpartyproject")
            {
                if (e.KeyValue != 13)
                {
                    //CommonClass._Ingrid.KeyMoveinTextbox(Gridpartyproject, "", e.KeyValue, true);
                   // (e.KeyValue, Gridpartyproject, selectedRow, uscLedgershow1, gridmain);
                    CommonClass._Ingrid.RowUpDownSelectWithoutusercontrole(e.KeyValue, Gridpartyproject, selectedRow, gridmain);
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
                    PartyprojectinGrid();
                }

               
            }

        }

        public void Taxcalculation()
          {

            if(rptax ==true)
            {
            double taxamount = 0;
            double amt = 0;
            double taxperc=0;
            taxperc= _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["ClnTaxperc"].Value);
            amt =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnamount"].Value);
            taxamount = (amt * taxperc) / (100+taxperc);
            gridmain.Rows[rowindex].Cells["ClnTaxamt"].Value =_Dbtask.SetintoDecimalpoint( taxamount);
            }
       
         }

        void txt_TextChanged(object sender, EventArgs e)
        {

            uscLedgershow1.Passingusercontrole(gridmain, "Clnamount", rowindex, columnindex, uscLedgershow1);
            gridmain.Rows[rowindex].Cells[Columnname].Value = (sender as TextBox).Text;

            //if (Columnname == "clnamount" || Columnname == "ClnTaxperc")
            //{
            //    if (_Dbtask.znlldoubletoobject(gridmain.Rows[selectedRow].Cells[Columnname].Value) > 10000000)
            //    {
            //        gridmain.Rows[selectedRow].Cells["ClnTaxperc"].Value = "";
            //        gridmain.Rows[selectedRow].Cells["clnamount"].Value = "";
            //        gridmain.Rows[selectedRow].Cells["ClnTaxamt"].Value ="";

            //        gridmain.Rows[selectedRow].Cells["ClnTaxperc"].Value = 0;
            //        gridmain.Rows[selectedRow].Cells["clnamount"].Value = 0;
            //        gridmain.Rows[selectedRow].Cells["ClnTaxamt"].Value = 0;

            //        gridmain.NotifyCurrentCellDirty(false);
            //    }
            //}
            
            
            CommonClass.temp =_Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value);


           
            
            
            if (Columnname == "clnledger")
            {
                if (Isinotherwindow == false)
                {
                    if (mode == 6)
                    {
                        CommonClass._Ingrid.LedgerGridShow(uscLedgershow1, " where lname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow, "0", 3);
                    }
                    else
                    {
                        CommonClass._Ingrid.LedgerGridShow(uscLedgershow1, " where lname like N'%" + CommonClass.temp + "%'", uscLedgershow1.GridProductShow, "0", 0);
                    }
                        Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
                    if (tempRect.Top > 180)
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left,0);
                    }
                    else
                    {
                        CommonClass._Ingrid.ProductGridShowLocationSett(uscLedgershow1, tempRect.Left, tempRect.Top + tempRect.Height-9 );
                    }
                    uscLedgershow1.GetAccountBalance();
                }
            }

            if (Columnname == "ClnTaxperc")
            {
                taxperc = 0;
                taxperc = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["ClnTaxperc"].Value);
                Taxcalculation();
            
            
            }

            if (Columnname == "clnpartyproject")
            {
                Gridpartyproject.Visible = true;
                Ds = CommonClass._Partyproject.Showpartyproject(false, gridmain.Rows[rowindex].Cells["Clnledger"].Tag.ToString());
                Gridpartyproject.Rows.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Countrow = Gridpartyproject.Rows.Add(1);
                    id = Ds.Tables[0].Rows[i]["pid"].ToString();
                    Name = Ds.Tables[0].Rows[i]["pname"].ToString();
                    Gridpartyproject.Rows[Countrow].Cells[0].Value = Name;
                    Gridpartyproject.Rows[Countrow].Cells[0].Tag = id;
                }
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 180)
                {
                    CommonClass._Ingrid.ProductGridShowLocationSettGrid(Gridpartyproject, tempRect.Left, 0);
                }
                else
                {
                    CommonClass._Ingrid.ProductGridShowLocationSettGrid(Gridpartyproject, tempRect.Left, tempRect.Top + tempRect.Height - 9);
                }
            }

            CalcTottal(_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnamount"].Value),true);
        }

        public void CalcTottal(double Amt,bool IsValue)
        {
            try
            {
                TottalAmount = 0;
                 
                if(IsValue==true)
                gridmain.Rows[rowindex].Cells["clnamount"].Value =_Dbtask.SetintoDecimalpoint(Amt);
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnledger"].Tag != null)
                    {
                        if (gridmain.Rows[i].Cells["clnamount"].Value == null)
                        {
                            gridmain.Rows[i].Cells["clnamount"].Value = 0;
                        }
                        double CellAmt = Convert.ToDouble(_Gen.SettNulltoZerogrid(gridmain.Rows[i].Cells["clnamount"].Value.ToString(), true));
                        TottalAmount = TottalAmount + CellAmt;
                    }

                    Taxcalculation();

                }
                Discount = _Dbtask.znullDouble(txtdiscount.textBox1.Text);
                txtbillamount.Text = _Dbtask.SetintoDecimalpoint(TottalAmount-Discount);
            }
            catch
            {
            
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void GetMenusettings()
        {
            try
            {
                SetHeading();

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=151");
                if (temp == "1")
                {
                    Printwhilesavings = true;
                    ChkPrintWileSaving.Checked = true;
                }

                if (CommonClass._settings.ReturnStatus("156") == "1")
                {
                    Spartyproject = true;
                }
            }
            catch
            {
            }
        }

        public void SetGridColumn()
        {
            try
            {
                GetMenusettings();
                if (Printwhilesavings == true)
                    ChkPrintWileSaving.Checked = true;
                if (Spartyproject == true)
                {
                    clnpartyproject.Visible = true;
                }
            }
            catch
            {
            
            }
        }

        public void Textalignsett()
        {
            gridmain.Columns["clnamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdBack_Click(object sender, EventArgs e)
                    {
            GetPrevious((Convert.ToInt64(txtvno.Text) - 1).ToString());
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Text) + 1).ToString());
        }

        private void Frmcash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 114)/*For F4*/
            {
                (this.MdiParent as MDIParent2).mnuledgerreport.PerformClick();
            }
            if (e.KeyValue == 121)
            {
                ShowPanelPreBill();
            }
        }

        private void txtvno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComLedger.Focus();
            }
        }

        private void ComLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtdate.Focus();
            }
        }

        private void dtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                gridmain.Focus();
              gridmain.CurrentCell=  gridmain.Rows[0].Cells["clnledger"];
            }
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                DialogResult Result = MessageBox.Show("Do you want to Delete this Record?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "Yes")
                {
                    DeleteVoucher();
                    ForLogindetails("DELETE");
                    Clear();
                }
            }

        }
       

        private void txtentervno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                    {
                    GetPrevious(txtentervno.Text);
                    }
            }
            catch
            {
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

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
                            {

            
             //0
            
            if (Columnname == "clnamount" || Columnname == "ClnTaxperc")
            {
                if (_Dbtask.znlldoubletoobject(gridmain.Rows[selectedRow].Cells[Columnname].Value) > 100000000)
                {
                    gridmain.Rows[selectedRow].Cells["ClnTaxperc"].Value = 0;
                    gridmain.Rows[selectedRow].Cells["clnamount"].Value = 0;
                    gridmain.Rows[selectedRow].Cells["ClnTaxamt"].Value = 0;

                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
            
            
            
            
            
            if (Columnname == "clnamount")
            {
              double Amt  = Convert.ToDouble(gridmain.Rows[selectedRow].Cells["clnamount"].Value);
                gridmain.Rows[selectedRow].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(Amt);
          
            
            }
            




        }

        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);

            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Columnname == "clnamount")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
        }

        class AmountInWords
        {

            private static String[] units = { "Zero", "One", "Two", "Three",
           "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
           "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
           "Seventeen", "Eighteen", "Nineteen" };
            private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
           "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


            public String ConvertAmount(double amount)
            {
                try
                {
                    frmsalesinvoice Frms = new frmsalesinvoice();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " and " +
                            convert(amount_dec) + " " + CommonClass._Gen.Getminerymbol();
                }
                catch (Exception e)
                {
                }
                return "";
            }

            public String convert(int i)
            {
                //
                if (i < 20)
                    return units[i];
                if (i < 100)
                    return tens[i / 10] + ((i % 10 > 0) ? " " + convert(i % 10) : "");
                if (i < 1000)
                    return units[i / 100] + " Hundred"
                            + ((i % 100 > 0) ? " and " + convert(i % 100) : "");
                if (i < 100000)
                    return convert(i / 1000) + " Thousand "
                            + ((i % 1000 > 0) ? " " + convert(i % 1000) : "");
                if (i < 10000000)
                    return convert(i / 100000) + " Lakh "
                            + ((i % 100000 > 0) ? " " + convert(i % 100000) : "");
                return convert(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + convert(i % 10000000) : "");
            }

        }
        public void VoucherPrintWholesale(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string TIN = "                      " + "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string temp = "            " + _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string Address = temp;
            string Mobile = "                      " + _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Invoicename = "                           " + Invoicename;
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                                                               " + Datestr;
            StrTime = "                                                               " + StrTime;
            string LineHeading = "=".PadRight(80, '=');
            string LineAbowAmount = "-".PadRight(80, '-');
            string LineFooter = "=".PadRight(80, '=');
            string Slno = "Sl ".PadRight(8, ' ');
            string Pname = "Ledger Name".PadRight(30, ' ');
            string TsAmount = "Amount".PadLeft(40, ' ');
            string TAmountstr = "Amount".PadLeft(40, ' ');
            string TTAmount;
            if (TIN == "TIN:")
                RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n" + "\nNo :" + StrVno + "" + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TAmountstr + "\n" + LineHeading + "";
            else
                RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n" + TIN + "\n" + Invoicename + "\n" + "No :" + StrVno + "" + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TAmountstr + "\n" + LineHeading + "";
            double TAmount = 0;
            RowValidation();
            int TRowCounting = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(8, ' ');

                        Pname = gridmain.Rows[i].Cells["clnledger"].Value.ToString();
                        Pname = Pname.PadRight(60, ' ');
                        if (Pname.Length > 60)
                            Pname = Pname.Substring(0, 60);

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');

                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        TRowCounting = TRowCounting + 1;
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsAmount;

                    }
                }
            }

            for (int k = TRowCounting; k < 40; k++)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n";
            }

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(80, ' ');
            AmountinWords = "";
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            if (AmountinWords.Length > 60)
                AmountinWords = AmountinWords.Substring(0, 60) + "\n" + AmountinWords.Substring(60, AmountinWords.Length - 60);
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTAmount + "\n" + LineFooter;
            RichTextBox1.Text = RichTextBox1.Text + "\n\nIn Words:" + AmountinWords + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
        }

        public void VoucherPrintDotmetrix(string Invoicename)
        {
            string StrVno = txtvno.Text;
             CompanyNameStr=_Dbtask.ExecuteScalar("select cname from tblcompanymaster");
            string TIN =  "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string Address = temp;
            string Mobile = "    " + _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Invoicename = "         " + Invoicename;
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                                 " + Datestr;
            StrTime = "                                 " + StrTime;
            string LineHeading = "=".PadRight(50, '=');
            string LineAbowAmount = "-".PadRight(50, '-');
            string LineFooter = "=".PadRight(50, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Ledger Name".PadRight(30, ' ');
            string TsAmount = "Amount".PadLeft(12, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTAmount;
            MyPrinter.PrinterName = Selectedprint;
            if (TIN == "TIN:")
                RichTextBox1.Text =  "\n\n" + Address + "\n" + "" + Mobile + "\n" + "\nNo :" + StrVno + "" + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TAmountstr + "\n" + LineHeading + "";
            else
                RichTextBox1.Text =  "\n\n" + Address + "\n" + "" + Mobile + "\n" + TIN + "\n" + Invoicename + "\n" + "No :" + StrVno + "" + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TAmountstr + "\n" + LineHeading + "";

            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            RowValidation();
            int TRowCounting = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = gridmain.Rows[i].Cells["clnledger"].Value.ToString();
                        Pname = Pname.PadRight(30, ' ');
                        if (Pname.Length > 30)
                            Pname = Pname.Substring(0, 30);

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');

                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        TRowCounting = TRowCounting + 1;
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsAmount;

                    }
                }
            }

            for (int k = TRowCounting; k < 5; k++)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n";
            }

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(46, ' ');
            AmountinWords = "";
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            if (AmountinWords.Length > 30)
                AmountinWords = AmountinWords.Substring(0, 30) + "\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);
            string AutherisedSignature = "                              Authorized Signatory";
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + txtbillamount.Text + "\n" + LineFooter;
            RichTextBox1.Text = RichTextBox1.Text + "\n\nIn Words:" + AmountinWords + "\n\n" + AutherisedSignature + "\n";

            if (gridmain.Rows.Count == 2)
            {
                string CurrentBalance = (CommonClass._Ledger.Balanceofledger(gridmain.Rows[0].Cells["clnledger"].Tag.ToString())).ToString();
                RichTextBox1.Text = RichTextBox1.Text + "Current Balance  :" + CurrentBalance + "\n\n\n\n\n\n\n\n\n\n\n";
            }
            else
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n\n\n\n\n\n\n\n";
            }

            DotMetrixPrint();
        }

        public void DotMetrixPrint()
        {
            if (PrintSelect == "2" || PrintSelect == "3")
            {
                MyPrinter.Close();
                PrintBold(CompanyNameStr);

                if (!MyPrinter.Open("Qplex Print")) return;
                MyPrinter.Print(Convert.ToChar(15).ToString());
                MyPrinter.Print(RichTextBox1.Text);
                MyPrinter.Print(Convert.ToChar(18).ToString());
                        
                   
               
            }
        }

        public void PrintBold(string Str)
        {
            MyPrinter.Close();
            if (!MyPrinter.Open("Qplex Print")) return;
            MyPrinter.Print(Convert.ToChar(14).ToString());
            MyPrinter.Print(Str);
            MyPrinter.Print(Convert.ToChar(20).ToString());
            MyPrinter.Close();
        }
        



        public void PrintWholeSales()
        {
            if (PrintSelect != "2" && PrintSelect != "3")
            {
                frmsalesinvoice _Sales = new frmsalesinvoice();
                _Sales.RichTextBox1.Text = RichTextBox1.Text;
                _Sales.XX = 80;
                _Sales.vouchertypewholesalesother();
            }
        }
        public void Thermalprint()
        {
            Selectedprint = ComPrintSheme.Text;
            PrintSelect = CommonClass._Paramlist.GetParamvalue("Pselect");
            if (Vtype == "R")
            {
                _ThermalThermal.FormType = "Receipt";
            }
            else
            {
                _ThermalThermal.FormType = "Payment";
            }
                _ThermalThermal.RVNO = txtvno.Text.ToString();
            _ThermalThermal.RorPamt = txtbillamount.Text.ToString();
            _ThermalThermal.DateStr = dtdate.Value.ToString("dd/MM/yyyy");
            _ThermalThermal.TimeStr = dtdate.Value.ToString("hh:mm:ss tt");
                _ThermalThermal.PrintInvoice(gridmain);
        }
        public void PrintLaserA4()
        {
            _ReceiptPayment.StrInvoiceheading = this.Text;
            _ReceiptPayment.TDiscount = txtdiscount.textBox1.Text;

            _ReceiptPayment.Lid = _Dbtask.znllString(gridmain.Rows[0].Cells["clnledger"].Tag);



            _ReceiptPayment.BillDate = dtdate.Value;
            _ReceiptPayment.Billno = txtvno.Text;

            _ReceiptPayment.BillAmount = txtbillamount.Text;


            _ReceiptPayment.StrNaration = TxtNarration.Text;
            _ReceiptPayment.SelPrint = ComPrintSheme.Text;
            _ReceiptPayment.PrintInvoice(gridmain);
        }
        public void Print()
        {
            RowValidation();
            _ReceiptPayment.oldparyamt = _Dbtask.znllString(oldbalance());
            _ReceiptPayment.partybalance = _Dbtask.znllString(partybalance());
                    

            Selectedprint = ComPrintSheme.Text;
            PrintSelect = CommonClass._Paramlist.GetParamvalue("Pselect");
            if (combptype.SelectedIndex == 0)
            {
                PrintLaserA4();
            }
            else
            {
                Thermalprint();
            }
            
            //PrintLaserA4();
            //Thermalprint();
          //  VoucherPrintDotmetrix(this.Text);
           // PrintWholeSales();
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            Print();
            //Thermalprint();
        }

        private void ChkPrintWileSaving_CheckedChanged(object sender, EventArgs e)
        {
            string TempStatus;
            if (ChkPrintWileSaving.Checked == true)
            {
                TempStatus = "1";
            }
            else
            {
                TempStatus = "-1";
            }

            _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='" + TempStatus + "'  where menuid='151'");
        }

        private void txtdiscount_TextChanged(object Sender, EventArgs e)
        {
            CalcTottal(0, false);


            if (_Dbtask.znlldoubletoobject(txtdiscount.textBox1.Text) > 100000000)
            {
                resultt =_Dbtask.znllString( MessageBox.Show("Allow This DISCOUNT !!!!?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                if (resultt == "No")
                {
                    txtdiscount.textBox1.Text = "";
                    txtdiscount.textBox1.Focus();
                }
                
            }
        }

        private void Gridbillwisesettlement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Svno;
            string SsalesAmt;

            int Brow=new int();
            Brow = Gridbillwisesettlement.SelectedRows[0].Index;
            if (Gridbillwisesettlement.SelectedRows.Count > 0)
            {
                if (_Dbtask.znlldoubletoobject(Gridbillwisesettlement.Rows[Brow].Cells["clnvno"].Value) > 0)
                {
                    gridmain.Rows[rowindex].Cells["clnnote"].Tag = Gridbillwisesettlement.Rows[Brow].Cells["clnvno"].Value;
                    Svno=Gridbillwisesettlement.Rows[Brow].Cells["clnvno"].Value.ToString();
                    SsalesAmt= Gridbillwisesettlement.Rows[Brow].Cells["clnsalesamt"].Value.ToString();
                    gridmain.Rows[rowindex].Cells["clnnote"].Value=" Bill Against on Vno ="+Svno+" ("+SsalesAmt+")";
                    pnlbill.Visible = false;
                }
            }
        }
        public void setprinttype()
        {
            rpprint = CommonClass._Paramlist.GetParamvalue("R&Pprint").ToString();
            combptype.SelectedIndex = Convert.ToInt32(rpprint);
        }

        private void combptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonClass._Paramlist.UpdateParamlist("R&Pprint", "0",_Dbtask.znllString( combptype.SelectedIndex));
        }

        private void TxtNarration_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("naration", "tblgeneralledger", TxtNarration);

        }

        private void TxtRefNo_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("RefnoStr", "tblgeneralledger", TxtRefNo);

        }

        private void chkReceiptbalance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReceiptbalance.Checked == true)
            {
                chkReceiptbalance.Checked = true;
                _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='1' where menuid='229' ");
            }
            else
            {

                chkReceiptbalance.Checked = false;
                _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='-1' where menuid='229' ");
            }
        }

    }
}
