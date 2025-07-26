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
    public partial class Frmpurchase : Form
    {
        public Frmpurchase()
        {
            InitializeComponent();
        }

        public string minivalbillnum = "";
        public byte[] content = null;
        public static bool pritwhile = true;
        public string vnoname = "";
        /*For Printing*/
        LPrinter MyPrinter = new LPrinter();
        Clsinvlaser _Laser = new Clsinvlaser();
        ClsinvlasersevenPURCHS _purprefour = new ClsinvlasersevenPURCHS();
        ClsinvlaserSixpurch _purlasersix = new ClsinvlaserSixpurch();
        ClsInvThermal _Thermal = new ClsInvThermal();
        ClsInvThermalpurchs _thermlpurch = new ClsInvThermalpurchs();

        ClsInvThermalpurchsNoTax _thermlpurchnotax = new ClsInvThermalpurchsNoTax();
        ClsInvThermalarabPurch _arabpurch = new ClsInvThermalarabPurch();
        ClsInvThermalarabPurchNOTAX _arabpurchNOTAX = new ClsInvThermalarabPurchNOTAX();


        ClsinvlaserFivePURCHS _Lasfive = new ClsinvlaserFivePURCHS();
        ClsinvlaserhalfPurch _halfpurch = new ClsinvlaserhalfPurch();
        ClsTwoinchThermalPurch _twoinch = new ClsTwoinchThermalPurch();
        
        bool SEditItemCode = false;
        public static bool Purprint = false;
        string TTTaxamount;
        /****************************************/

        /*Unit*/
        public string SlTracking;
        public string SecUnit = "";
        public string FirUnit = "";
        public double Convrt = 0;
        public double Unitamount1 = 0;
        public double UnitAmount2 = 0;
        public string UnitCode = "";
        string Unitid;
        string UnitName;
        public double taxperc = 0;
        public double saleratee = 0;
        public double real = 0;
        public string Pcode;
        public long MunitId = 0;
        public bool comText = false;

        /*for Roundoff&Invoicedisct*/
        public double invdiscunt = 0;
        public double Billdiscinv = 0;
        public double TempBillDisc = 0;
        public double invdisc = 0;
        public double totlamt = 0;
        public double invdiscper = 0;
        public double invdiscount = 0;
        public double Wrate = 0;
        public double Advancepay = 0;
        string StrTemp;
        string SampleVtype;
        bool IsinBatchList;
        bool Ennteringridcell = true;
        public bool SSlnotracking;
        public string NewData;
        public string OldData;
        public string StrVtyp;
        /*For Common Printing*/
        string Passing;


        public int frstivalP = 0;
        public bool frstiboolP = false;

        string pno;
        string TPaidAmount;
        string PrintingInvoiceName;
        string Printerselect;
        public string AmountinWords;
        
        /***********************************/
        string StrPurticulars;
        string StrPurticularsForLedger;
        /*************SiZE Ini Temp*********************/
        public bool ShowSubpanel;
        public bool SearchBarcode;
        public bool PrintNextpage;
        public int OverLimit;
        public int k;
        public bool IsEnterSize;
        //public bool ShowSubpanel = true;
        public long TRowCounting;
        public bool NextIteminsize;
        public string BackSizelessName;
        public string SizelessName;
        public string SizeQty;
        public string SizeRate;
        public string SizeAmount;
        public string SizeItemName;
        public string SizeNaration;
       // public int BatchTagValue;
        public DialogResult Result;
        string TempPreId;
        string TemppreName;

        int M = 0;
        /*************************************/

        /*For Size*/
        public int rowindexSize;
        public int columnindexSize;

        /**************************/

        public  string Vtype;
        public int rowindex;
        public int columnindex;
        public string Columnname;
        public int Countrow;
        public string Batchyear;
        public string Batchmonth;
        public int Retrivemode = 0;
        public static string Itemcode;
        public static string ItemName;
        public static string Itemcodetemp;
        public bool Isinotherwindow = false;
        public bool Registration = false;

        UscGridshow _usc2 = new UscGridshow();
       // MDIParent1 _Mdi = new MDIParent1();
        ClsBusinessIssue _BusinessIssue = new ClsBusinessIssue();
        ClsIssueDetails _IssueDetails = new ClsIssueDetails();
        ClsInventory _Inventory = new ClsInventory();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsDepot _Depot = new ClsDepot();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        ClsItemMaster _ItemMaster = new ClsItemMaster();
        ClsMultiRates _MultiRates = new ClsMultiRates();
        ClsMultiUnits _MultiUnits = new ClsMultiUnits();
        Clsbatch _Batch = new Clsbatch();
        ClsInGrid _Ingrid = new ClsInGrid();
        ClsAgent _Agent = new ClsAgent();
        ClsproductRate _Productrate = new ClsproductRate();
        NextGFuntion _Nextg = new NextGFuntion();
        Generalfunction _Gen = new Generalfunction();
        Clssizes _Size = new Clssizes();
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable();
        DataSet Ds2 = new DataSet();
        DataSet DS3 = new DataSet();
        Clsforms _Forms = new Clsforms();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        Clssettings _Settings = new Clssettings();
        Clspurchase _Purchase = new Clspurchase();
        Clsselectreport _Selectreport = new Clsselectreport();
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        RichTextBox RichTextBox1 = new RichTextBox();
        Clsdotmetrixprintsettings _Dotmetrix = new Clsdotmetrixprintsettings();
        // NextGFuntion _Nextg = new NextGFuntion();
        public string temptax;
        public bool P1by1;
        public string we = "";
        public int Upanddown;
        public Color PnlHeadingColor;
        bool IsEnter = false;
        public string StringTemp;
        public string Stringbillingdate;
        public double TottalAmount;
        public string CreditedLedcode;
        public string DebitedLedCode;
        public string PurticularsDr;
        public string PurticularsCr;
        public string PurchaseAccount;
        public string Heading;
        public string ItemId;
        public string Batch;
        public string Batchcode = "";
        double NetAmount;
        double NetTottal;
        double NetItemdiscount;
        double NetQty;
        double NetDiscou;
        double NetFree;
        double NetTax;
        double NetGross;
        double Templedouble;
        double TaxAmt;
        double TaxPerc;
        double AgentAmt;
        double StaffAmt;
        double TottalDiscount;
        double CRate;
        double NetCRate;
        double Stock;
        double NetitemDiscou;
        double roundof;
        public double TottalTax;
        int selectedRow;
        string StaffId = "0";
        string agentid = "0";
        string Stockareaid = "0";
        string temp;

        public bool EditMode;
        public bool Taxchangemode = false;
        public int SearchDebtors = 0;


        DataGridViewCellStyle dataGridViewCellStyleNew = new DataGridViewCellStyle();
        /*Barcode Printing*/
        public int CRow;



        /*NextgIniti*/

        public double NQty = 0;
        public double NRate = 0;
        public double NMrp = 0;
        public double NDiscper = 0;
        public double NDiscamt = 0;
        public double NGross = 0;
        public double NNetamout = 0;
        public double NFree = 0;
        public double NTaxperc = 0;
        public double NTaxamount = 0;

        /*For Printing*/
        string Taxruletext;
        public double currentbalance;
        public double OldBalance;
        public string SavedAmount;

        /*Settings*/
        public bool Supdatesrate = false;
        public bool Supdateprate = false;
        public bool SupdateMRP = false;
        public bool Sitemwiseagentcommision = false;
        public bool SBatch = false;
        public bool SPitemDiscount = false;
        public bool SPfree = false;
        public bool Seditprate = false;
        public bool STax = false;
        public bool SDepo = false;
        public bool Isitemedit = false;
        public bool Smrate = false;
        public bool SExsiceDutty = false;
        public bool EditgrossAmt = false;
        public bool Semployee = false;
        public bool Sagent = false;
        public bool SSsizes = false;
        public bool SUnit = false;
        public bool Sinvoicediscount = false;
        public bool Spharmacy = false;
        public bool VisiblePrate = false;
        public bool SSaveZeroRate = false;
        public bool Sbillingdate = false;
        public bool Singlebarcode = false;
        // public bool EditgrossAmt = false;

        /*For Barcode Printing*/


    public static string    MINofPI="";
 public static string MINofPR="";
 public static string MINofPO = "";



        public string Strprate;
        public string StrSrate;

        /*Product Into Main Grid Calculation*/

        public double Sratesecondery;

        /*Tottal Amount Calculation */

        double NetAmt;
        // double GrossAmt;
        double Gross;
        double DiscAmt;
        double ExciseDuty;

        /*For BatchCode Validation*/

        public bool IsInvalidbatch;
        //For Language Updation
        public bool IsArabic;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {

                if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "txttypeslno")
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (uscGridshow2.Visible == true)
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
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmpurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (pnlbill.Visible == true)
                {
                    pnlbill.Visible = false;
                }
               else if (uscGridshow2.Visible == true)
                {
                    uscGridshow2.Visible = false;
                }
               else if (Pnlsizes.Visible == true)
                {
                    Pnlsizes.Visible = false;
                }
              else  if (Gridbatchlist.Visible == true)
                {
                    Gridbatchlist.Visible = false;
                }
                else
                {
                    _Nextg.CloseGriddetail(gridmain, this);
                }
            }
        }

        public void TempClear()
        {
            txttqty.Text = "0.00";
            TxtTFree.Text = "0.00";
            TxtTAmount.Text = "0.00";
            txtttax.Text = "0.00";

            TxttItemDiscount.Text = "0.00";
            TxtTDiscount.Text = "0.00";
            Txttcrate.Text = "0.00";
            TxtTGross.Text = "0.00";

            Txtcashdiscount.textBox1.Text = "0.00";
            txtotherexpenses.textBox1.Text = "0.00";
            TxtNaration.textBox1.Text = "";
            txtinvoicediscperc.textBox1.Text = "0.00";
            txtinvoicediscount.textBox1.Text = "0.00";
            txtroundoff.textBox1.Text = "0.00";

            lblledgertext.Text = "Supplier(F3 New)";
            Lblpartybalance.Text = "0";
        }

        private bool Main()
                            {
            GetVnoOnlyissuecode();
            
            if (RowValidation()&&ValidationFu())
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
                    _thermlpurch.OLDBBLNC = 0;
                    _thermlpurch.NOWBBLNC = 0;
                    if(commodeofpayment.SelectedIndex==1)
                    {
                        _thermlpurch.OLDBBLNC = _AccountLedger.Balanceofledger(_Dbtask.znllString(TxtAccount.textBox1.Tag));
                    }
                    NextgInitialize();

                    if (commodeofpayment.SelectedIndex == 1)
                    {
                        _thermlpurch.NOWBBLNC = _AccountLedger.Balanceofledger(_Dbtask.znllString(TxtAccount.textBox1.Tag));
                    }

                    if (EditMode == false)
                    {
                        _Nextg.Registrationinsert(1);
                    }
                    if (ChkPrintWileSaving.Checked == true)
                    {
                        if (chkprintconfirmation.Checked == true)
                        {
                            Result = MessageBox.Show("Do You want to Print?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                            if (Result.ToString() == "Yes")
                            {
                                Mainprint();
                                directprint();
                            }
                        }
                        else
                        {
                            Mainprint();
                            directprint();
                        }
                    }
                    ExternelSaving();
                    TempClear();
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
        public void ExternelSaving()
        {
            if (Vtype == "PI")
                _Gen.ExportToWieghtMechine();
        }

        public void Insert()
        {
            _GeneralLedger.InsertGeneralLedger();
        }
        public void ClearTemp()
        {

            gridmain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            gridmain.AllowUserToResizeRows = false;
            FillCombo();
            SetcontrolePosition();
            TxtProduct.Visible = false;

            TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtAccount.textBox1.Text = "CashAccount";
            TxtAccount.textBox1.Tag = "1";
            txtvno.Focus();
        }
        public void Settcontroletext()
        {
            Lblstockarea.Text = NextGFuntion.StockAreaName;
        }
        public void DetectLanguage()
        {
            string lng = CommonClass._Paramlist.GetParamvalue("Language");
            if (lng == "Arabic")
            {
                IsArabic = true;
            }
            else
            {
                IsArabic = false;
            }
        }
        public void ChangeLanguage()
        {
            DetectLanguage();
            if (IsArabic == true)
            {
                CommonClass._Language.PanelBasedConversion(PnlGeneral);
                //CommonClass._Language.PanelBasedConversion(pnlcommon);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.PanelBasedConversion(panel5);
                CommonClass._Language.PanelBasedConversion(PnlPrintOptions);
            }
        }
        public void Clear()
        {
            try
            {
                ChangeLanguage();
                uscGridshow2.Visible = false;
               
                Retrivemode = 1;
                TxtAccount.textBox1.Text = "";
                TxtAccount.textBox1.Tag = "";
                IsEnter = true;
                Retrivemode = 0;
                roundof = 0;
                txtroundoff.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
                txtinvoicediscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
                txtinvoicediscperc.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
                SetGridColumn();

                
                dtdate.Value = DateTime.Now;
                dtbilldate.Value = DateTime.Now;
               
               
                ChkPrintWileSaving.Checked=pritwhile;
               
          


                FillCombo();
                GetVno();

                gridmain.Rows.Clear();
               
                TxtProduct.Visible = false;

                EditMode = false;
                ConvertNullToZero();
                TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);
                Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);
                txtvno.Focus();
                TxtAccount.textBox1.Text = "";
                txtstockbyid.Text = "";
                txtttax.Text="";
               TxtTAmount.Text="";
              txttqty.Text="";
              TxtTGross.Text="";
               Txttcrate.Text="";
              TxtTDiscount.Text = "";
               TxtTFree.Text = "";
                Retrivemode = 0;
                txtbillamount.Text = "0.00";
                TottalAmountCalculate();
                Gridcustomerlist.Visible = false;
                CommonClass._Gen.FillActivePrinter(comprint);
               frstivalP = 0;
        frstiboolP = false;
        txtreceivedamt.Text = "";
        txtreceivedamt.Visible = true;
        lblreceivedamount.Visible = true;

        ComPrintSheme.SelectedIndex = 1;

            }
            catch
            {
            }
        }
        
        public void SetGridColumn()
        {
            GetMenusettings();
            this.Text = Heading;

            //if (SEditItemCode == false)
            //{
            //    clnitemcode.Visible = false;
            //}

            if (SSlnotracking == false)
            {
                clnserialno.Visible = false;
            }

            if (SBatch == false)/*For Batch Enabled*/
            {
                clnbatch.Visible = false;
                cmdbarcodeTool.Visible = false;
            }
            if (SUnit == false)/*For Unit*/
            {
                ClnUnit.Visible = false;

            }

            if (SPitemDiscount == false)/*For Item Discount*/
            {
                clndiscount.Visible = false;
                ClnDiscPer.Visible = false;
            }
            if (SPfree == false)
            {
                clnfree.Visible = false;
            }
            if (Seditprate == false)
            {
                clnprate.ReadOnly = true;
            }
            if (STax == false)
            {
                clntax.Visible = false;
                ClntaxPer.Visible = false;
                ComTax.Visible = false;
                LblTax.Visible = false;
            }
            if (SDepo == false)
            {
                ComDepot.Visible = false;
                Lblstockarea.Visible = false;
            }

            //if (Smrate == false)
            //{
                clnwholesale.Visible = false;
                ComMultiRate.Visible = false;
                lblratetype.Visible = false;
                lblratetype1.Visible = false;
                comratetype.Visible = false;
           // }
            if (SExsiceDutty == false)
            {
                clnexciseduty.Visible = false;
                clnexperc.Visible = false;
            }
            if (EditgrossAmt == true)
            {
                ClnGross.ReadOnly = false;
                clnprate.ReadOnly = false;
            }
            //if (Semployee == false)
            //{
                Comemployee.Visible = false;
                lblemployee.Visible = false;
                lblemployee1.Visible = false;
                Txtemployeeamt.Visible = false;
           // }

            if (_Settings.FunSettings1("Pitemnote1") == false)
            {
                clnitemnote.Visible = false;
            }

            if (_Settings.FunSettings1("Pitemnote2") == false)
            {
                clnitemnote2.Visible = false;
            }

            if (Sinvoicediscount == false)
            {
                clnbilldiscount.Visible = false;
                lblinvoicediscount.Visible = false;
                txtinvoicediscperc.Visible = false;
                txtinvoicediscount.Visible = false;
            }

            if (Spharmacy == false)
            {
              //  clnexdate.Visible = false;
                clnmandate.Visible = false;
                

            }

            if (VisiblePrate == false)
            {
                clnprate.Visible = false;
            }

            if (Sbillingdate == false)
            {
                lblbilldate.Visible = false;
                dtbilldate.Visible = false;
            }
            if (Sagent == true)
            {
                lblagent.Visible = true;
                ComAgent.Visible = true;
                lblagent1.Visible = true;
            }
        }

        public void GetMenusettings()
        {
            string temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=1007");
            if (temp == "1")
            {
                SEditItemCode = true;
            }
            /*Update Srate*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=100");
            if (temp == "1")
            {
                Supdatesrate = true;
            }
            /*Unit*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=12 ");
            if (temp == "1")
            {
                SUnit = true;
            }
            /*Update Prate*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=101");
            if (temp == "1")
            {
                Supdateprate = true;
            }
            /*Itemwise Commision*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=102");
            if (temp == "1")
            {
                Sitemwiseagentcommision = true;
            }
            /*Batch*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
            if (temp == "1")
            {
                SBatch = true;
            }
            /*Purchase Item Discount*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=109");
            if (temp == "1")
            {
                SPitemDiscount = true;
            }
            /*Purchase Item Free*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=111");
            if (temp == "1")
            {
                SPfree = true;
            }
            /*Edit PurchaseRate*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=113");
            if (temp == "1")
            {
                Seditprate = true;
            }

            /*Update MRP*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=114");
            if (temp == "1")
            {
                SupdateMRP = true;
            }
            /*Slnotracking*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=141");
            if (temp == "1")
            {
                SSlnotracking = true;
            }
            /*Tax */
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=14");
            if (temp == "1")
            {
                STax = true;
            }

            /*Stock Area*/

            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=13");
            if (temp == "1")
            {
                SDepo = true;
            }


            /*Multi Rate*/

            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=11");
            if (temp == "1")
            {
                Smrate = true;
            }

            /*Excise Duty*/
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=119");
            if (temp == "1")
            {
                SExsiceDutty = true;
            }

            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=120");
            if (temp == "1")
            {
                EditgrossAmt = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=14");
            if (temp == "1")
            {
                STax = true;
            }

            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=118");
            if (temp == "1")
            {
                Semployee = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=117");
            if (temp == "1")
            {
                Sagent = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=11");
            if (temp == "1")
            {
                Smrate = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=123");
            if (temp == "1")
            {
                SSsizes = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=143");
            if (temp == "1")
            {
                Sinvoicediscount = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=145");
            if (temp == "1")
            {
                Spharmacy = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=146");
            if (temp == "1")
            {
                VisiblePrate = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=152");
            if (temp == "1")
            {
                SSaveZeroRate = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=165");
            if (temp == "1")
            {
                Sbillingdate = true;
            }
            temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=166");
            if (temp == "1")
            {
                Singlebarcode = true;
            }

          commodeofpayment.SelectedIndex= Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("PMpayment"));
          if (commodeofpayment.SelectedIndex == 0)
          {
              TxtAccount.textBox1.Tag = "1";
          }
                
        
        
        
        }
        public void SetcontrolePosition()
        {
            PnlGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            PnlAdvance.Visible = false;

        }
        public void PrePurchaseInvoice(long vno, bool Isinenter, string TempVtype, bool Refilling)
                {
            try
            {
                SetGridColumn();
                long PreIssuecode = vno;
                string AddQuery;
                string Addquery2;

                if (Refilling == true)
                {
                    AddQuery = "";
                }
                else
                {
                    AddQuery = " and ledcodeDr='" + PurchaseAccount + "'";
                }

                Ds2 = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' " + AddQuery + "");
                if (Ds2.Tables[0].Rows.Count >0)
                {
                    gridmain.Rows.Clear();
                    //EditMode = true;
                    Retrivemode = 1;
                    if (Refilling == true)
                    {
                        Addquery2 = "";
                    }
                    else
                    {
                        if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                        {
                            txtvno.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString() + Ds2.Tables[0].Rows[0]["vno"].ToString();
                        }
                        else
                        {
                            txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                        }

                        EditMode = true;
                        Addquery2 = " and ledcode ='" + PurchaseAccount + "'";
                    }
                    txtvno.Tag = PreIssuecode.ToString();
                    lblledgertext.Text = "";
                    _ReceiptDetails.RcptCodeLng = PreIssuecode;
                    _TransactionReceipt.RcptCodeLng = PreIssuecode;
                    _Inventory.Vcode = PreIssuecode.ToString();
                    lblledgertext.Text = "";
                    dtdate.Value = _Dbtask.ZnullDatetime(Ds2.Tables[0].Rows[0]["recptdate"]);
                    dtbilldate.Value = _Dbtask.ZnullDatetime(Ds2.Tables[0].Rows[0]["Bdate"]);
                    txtstockbyid.Text = "";
                    ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                    TxtAccount.textBox1.Tag = Ds2.Tables[0].Rows[0]["Ledcodecr"];
                    TxtAccount.textBox1.Text = Ds2.Tables[0].Rows[0]["Tename"].ToString();
                    temptax = Ds2.Tables[0].Rows[0]["taxid"].ToString();
                    txtroundoff.textBox1.Text = _Dbtask.ExecuteScalar("select cramt from tblgeneralledger where ledcode='11' and vno='" + PreIssuecode + "' and vtype='" + Vtype + "'");
                    string MoPayment = "";
                    MoPayment = Ds2.Tables[0].Rows[0]["Mpayment"].ToString();

                    if (MoPayment=="")
                    {
                        commodeofpayment.SelectedIndex = 0;
                        TxtAccount.textBox1.Tag = "1";
                    }
                    else
                    {
                        commodeofpayment.SelectedIndex = Convert.ToInt16(Ds2.Tables[0].Rows[0]["mpayment"].ToString());
                    }

                    txtreceivedamt.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["adamount"].ToString()));


                    //if (TxtAccount.textBox1.Tag.ToString() == "1")
                    //{
                    //    commodeofpayment.Text = "CASH";
                    //}
                    //else if(_Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lid ="+_Dbtask.znllString(TxtAccount.textBox1.Tag)+"")=="24")
                    //{
                    //    commodeofpayment.SelectedIndex = 2;
                     
                    //}
                    // else 
                    //{
                    //    commodeofpayment.Text = "CREDIT";
                    //    lblreceivedamount.Visible = true;
                    //    txtreceivedamt.Visible = true;
                    //}
                    ComTax.SelectedValue = Ds2.Tables[0].Rows[0]["taxid"];

                    ComAgent.SelectedValue = Ds2.Tables[0].Rows[0]["agent"];
                    TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select cramt from tblgeneralledger where ledcode='" + ComAgent.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                    if (TxtAgentAmt.Text == "")
                        TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);

                    Comemployee.SelectedValue = Ds2.Tables[0].Rows[0]["Empid"];
                    Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select cramt from tblgeneralledger where ledcode='" + Comemployee.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                    if (Txtemployeeamt.Text == "")
                        Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);

                    TxtNaration.textBox1.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
                    txtreceivedamt.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["adamount"].ToString()));
                    
                    TxtRefName.Text = Ds2.Tables[0].Rows[0]["Refno"].ToString();

                  // if(_Dbtask.znllString(Ds2.Tables[0].Rows[0]["Refno"])=="")
                  //{
                  //  TxtRefName.Text = txtvno.Text;
                  // }


                   lblledgertext.Text = _Dbtask.znllString( CommonClass._Ledger.GetspecifField("mobile", _Dbtask.znllString(TxtAccount.textBox1.Tag)));


                    Ds = _Dbtask.ExecuteQuery("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='" + TempVtype + "' and ledcode='" + PurchaseAccount + "' order by slno asc");

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        gridmain.Rows.Add(1);

                            string tempSlno = (i + 1).ToString();
                        string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                        string tempitemnote = Ds.Tables[0].Rows[i]["itemnote"].ToString();
                        string tempitemnote2 = Ds.Tables[0].Rows[i]["itemnote1"].ToString();
                        double tempQty = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"].ToString());
                        double tempfree = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                        double temppRate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Rate"].ToString());
                        double tempdiscrate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                        double temptaxrate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
                        double tempNetAmt = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
                        double temptaxperc = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["taxper"].ToString());

                        double tempprofit = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["profit"].ToString());


                        double tempexciseduty = _Dbtask.znlldoubletoobject(_Gen.avoidnullDecimal(Ds.Tables[0].Rows[i]["exciseduty"].ToString()));
                        if (SSlnotracking == true)
                        if (CommonClass._Slno.ShowSlno(" where vtype='" + Vtype + "' and vno='" + vno + "' and itemid='" + tempitemid + "'").Tables[0].Rows.Count>0)
                        {
                            gridmain.Rows[i].Cells["clnserialno"].Value = CommonClass._SelectReport.Showindataset(" select slno from tblslnotracking where vtype='" + Vtype + "' and vno='" + vno + "' and itemid='" + tempitemid + "'");
                        }

                        Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();
                        if (Ds.Tables[0].Rows[i]["mandate"].ToString() == "")
                            Ds.Tables[0].Rows[i]["mandate"] = "01-01-1900";
                        if (Ds.Tables[0].Rows[i]["exdate"].ToString() == "")
                            Ds.Tables[0].Rows[i]["exdate"] = "01-01-1900";
                        DateTime DtMandate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["mandate"].ToString());
                        DateTime DtExdate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["exdate"].ToString());

                            if (SBatch == true)
                        {
                            string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                            gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;
                            gridmain.Rows[i].Cells["clnbatch"].Tag = null;
                        }
                        double tempsrate = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["srate"].ToString());
                        double tempwrate = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["wrate"].ToString());
                        double tempcrate = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["crate"].ToString());



                        double tempmrp = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["mrp"].ToString());

                        gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;

                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                        gridmain.Rows[i].Cells["clnitemnote"].Value = tempitemnote;
                        gridmain.Rows[i].Cells["clnitemnote2"].Value = tempitemnote2;
                        gridmain.Rows[i].Cells["clnmandate"].Value = DtMandate;
                        gridmain.Rows[i].Cells["clnexdate"].Value = DtExdate;
                        gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);
                        gridmain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);
                        gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsrate);
                        gridmain.Rows[i].Cells["clnwholesale"].Value = _Dbtask.SetintoDecimalpoint(tempwrate);
                        gridmain.Rows[i].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(temppRate);
                        gridmain.Rows[i].Cells["clnsrateperc"].Value = _Dbtask.SetintoDecimalpointStock(tempprofit);

                        gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempmrp);
                        gridmain.Rows[i].Cells["clnmrp"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpointStock(tempdiscrate);

                        gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);
                        gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);
                        Templedouble = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnprate"].Value) * _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                            gridmain.Rows[i].Cells["clndiscper"].Value = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value) * 100 / Templedouble;
                        gridmain.Rows[i].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(tempcrate);
                        gridmain.Rows[i].Cells["clnexciseduty"].Value = tempexciseduty;

                        rowindex = i;
                        if (SUnit == true)
                        {
                            Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                            string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                            gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                            gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                            ItemId = tempitemid;
                            UnitName = Unit;
                            UnitAmountCalc();
                            comText = true;
                        }
                        else
                        {
                            Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");

                            if (Unitid=="0"|| Unitid=="")
                            {
                                Unitid = "1";
                            }
                            
                            string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                            
                            
                            
                            gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                            gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                        }

                        CellEnterCalculationPart();

                    }
                    if (Sinvoicediscount == true)
                    {
                        string invAmunt = _Dbtask.ExecuteScalar("select Billdisc from TblReceiptDetails where RecptCode='" + txtvno.Text + "'");
                        //;
                        txtinvoicediscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(invAmunt));
                        invdiscountAmnt();
                    }

                    /*Multi Rate*/
                    TottalAmountCalculate();
                    double Titemdiscount = _Dbtask.znlldoubletoobject(TxttItemDiscount.Text);
                    double TDisc = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["discamt"].ToString());
                    Txtcashdiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(TDisc - Titemdiscount);
                    txtotherexpenses.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["cooly"].ToString()));
                    TxtTDiscount.Text = _Dbtask.SetintoDecimalpoint(TDisc);
                    if (Smrate == true)
                    {
                    }


                    TottalAmountCalculate();
                    Isinotherwindow = false;
                }
                else
                {




                    if (Isinenter == false)
                    {
                        Clear();
                        if (Vtype == "PI" || Vtype == "PO"  && PurchaseAccount == "3")
                        {
                            if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("Reptcode", "Tbltransactionreceipt", " where ledcodeDr='3' And RECPTtype='" + Vtype + "'")))
                            {
                                string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                                txtvno.Text = prefx + PreIssuecode.ToString();
                                txtvno.Tag = PreIssuecode.ToString();
                                TxtRefName.Text = PreIssuecode.ToString();
                                TxtRefName.Tag = _Dbtask.znllString(txtvno.Text);
                                _ReceiptDetails.RcptCodeLng = PreIssuecode;
                                _TransactionReceipt.RcptCodeLng = PreIssuecode;
                                 EditMode = true;
                                if (Vtype == "PI")
                                {
                                    _Inventory.Vcode = PreIssuecode.ToString();
                                }
                            }
                            
                        }
                       // GetPrevious(Convert.ToInt64(PreIssuecode) - 1, false);
                    }
                }

                Retrivemode = 0;

                if (temptax == "0")
                {
                    ComTax.Text = "None";
                }
                if (temptax == "8")
                {
                    ComTax.Text = "VAT";
                }
                if (temptax == "25")
                {
                    ComTax.Text = "CST";
                }
                ComTextChange();
                RoundoffCalc();

            }
            catch
            {
                Clear();
            }

        }
        public void GetPrevious(long vno, bool Isinenter)
                        {


                MINVALSET();

            if (vno >= 0&&vno >= Convert.ToInt64(minivalbillnum))
            {
                if (Vtype == "PI" || Vtype == "PO")
                {
                    PrePurchaseInvoice(vno, Isinenter, Vtype, false);
                }
                else if (Vtype == "PR")
                {
                    PreIssueTransactions(vno, Isinenter, Vtype, false);
                }


                OldData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.textBox1.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;

                
            
            }

        }
        public void ForLogindetails(string Mode)
        {
            try
            {
                StrVtyp = CommonClass._Nextg.VtypeDescription(Vtype);
                if (Mode == "NEW")
                {
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.textBox1.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    OldData = "";
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "NEW", "", StrVtyp, OldData, NewData);
                }
                else if (Mode == "UPDATE")
                {
                    // OldData = "";
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.textBox1.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "UPDATE", "", StrVtyp, OldData, NewData);
                }
                else if (Mode == "DELETE")
                {
                    // OldData = "";
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.textBox1.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", StrVtyp, OldData, NewData);
                }
            }
            catch
            {
            }
        }
        public void PreIssueTransactions(long vno, bool Isinenter, string TempVtype, bool Refilling)
        {
            SetGridColumn();
            long PreIssuecode = vno;
            string AddQuery;
            string Addquery2;

            if (Refilling == true)
            {
                AddQuery = "";
            }
            else
            {
                AddQuery = " and ledcodeCr='" + PurchaseAccount + "'";
            }

            Ds2 = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='" + TempVtype + "' " + AddQuery + "");
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                if (Refilling == true)
                {
                    Addquery2 = "";
                }
                else
                {
                    if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                    {
                        txtvno.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString() + Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }
                    else
                    {
                        txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }

                    EditMode = true;
                    Addquery2 = " and ledcode ='" + PurchaseAccount + "'";
                }

                gridmain.Rows.Clear();



                PreIssuecode = Convert.ToInt64(Ds2.Tables[0].Rows[0]["issuecode"].ToString());
                txtvno.Tag = PreIssuecode.ToString();
                TxtRefName.Text = PreIssuecode.ToString();
                //TxtRefName.Text = txtvno.Text;
                
                _IssueDetails.IssueCodeLng = PreIssuecode;
                _BusinessIssue.IssueCodeLng = PreIssuecode;
                _Inventory.Vcode = PreIssuecode.ToString();
                dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["issuedate"]);
                ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                TxtAccount.textBox1.Tag = Ds2.Tables[0].Rows[0]["Ledcodedr"];
                TxtAccount.textBox1.Text = Ds2.Tables[0].Rows[0]["Tename"].ToString();
                txtroundoff.Text = _Dbtask.ExecuteScalar("select DbAmt from tblgeneralledger where ledcode='11' and vno='" + PreIssuecode + "' and vtype='" + Vtype + "'");
                lblledgertext.Text = "";
                //TxtRefName.Text = Ds2.Tables[0].Rows[0]["Refno"].ToString();

                //if (_Dbtask.znllString(Ds2.Tables[0].Rows[0]["Refno"]) == "")
                //{
                    TxtRefName.Text = txtvno.Text;
                //}

                if (TxtAccount.textBox1.Tag.ToString() == "1")
                {
                    commodeofpayment.Text = "CASH";
                }
                else
                {
                    commodeofpayment.Text = "CREDIT";
                }
                string temptax = Ds2.Tables[0].Rows[0]["taxid"].ToString();
                temptax = temptax.Replace(" ", "");


                ComAgent.SelectedValue = Ds2.Tables[0].Rows[0]["agent"];
                TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + ComAgent.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                if (TxtAgentAmt.Text == "")
                    TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);

                Comemployee.SelectedValue = Ds2.Tables[0].Rows[0]["Empid"];
                Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + Comemployee.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                if (Txtemployeeamt.Text == "")
                    Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);

                TxtNaration.textBox1.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
                txtotherexpenses.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["cooly"].ToString()));
                Txtcashdiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["Discamt"].ToString()));
                Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + TempVtype + "' " + Addquery2 + " order by slno asc");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);
                    string tempSlno = (i + 1).ToString();
                    string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                    double tempQty = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"].ToString());
                    double tempfree = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                    double tempsRate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Rate"].ToString());
                    double tempMrp = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Mrp"].ToString());
                    //double tempprofit = Convert.ToDouble(Ds.Tables[0].Rows[i]["profit"].ToString());
                    double tempprofit=0;
                    double tempdiscrate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                    double temptaxrate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
                    double tempNetAmt = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
                    double temptaxperc = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["taxper"].ToString());
                    string tempBatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                    Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();

                    gridmain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                    gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
                    gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                    gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempitemid + "'");
                    gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;

                    // NQty = tempQty;
                    gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                    // NFree = tempfree;
                    gridmain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);

                    // NRate = tempsRate;
                    gridmain.Rows[i].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
                    gridmain.Rows[i].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                    // NMrp = tempMrp;
                    gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempMrp);
                    gridmain.Rows[i].Cells["clnmrp"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempitemid + "'");

                    //NDiscamt = tempdiscrate;
                    gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(tempdiscrate);

                    gridmain.Rows[i].Cells["clnsrateperc"].Value = _Dbtask.SetintoDecimalpoint(tempprofit);


                    //NTaxamount = temptaxrate;
                    gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);

                    //NTaxperc = temptaxperc;
                    gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);



                    Templedouble = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnprate"].Value) * _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                    gridmain.Rows[i].Cells["clndiscper"].Value = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value) * 100 / Templedouble;
                    //NDiscper = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscper"].Value);
                    rowindex = i;

                    if (SUnit == true)
                    {
                        Unitid = _Dbtask.ExecuteScalar("select UnitId from TblIssuedetails where IssueCode='" + txtvno.Text + "' and Pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                        string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                        gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                        gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                        ItemId = tempitemid;
                        UnitName = Unit;
                        UnitAmountCalc();
                        comText = true;
                    }

                    if (Smrate == true)
                    {
                        comratetype.SelectedValue = Convert.ToInt32(Ds.Tables[0].Rows[i]["MultiRateId"]);
                    }

                    if (temptax == "0")
                    {
                        ComTax.Text = "None";
                    }
                    if (temptax == "9")
                    {
                        ComTax.Text = "VAT";
                    }
                    if (temptax == "24")
                    {
                        ComTax.Text = "CST";
                    }
                    ItemId = tempitemid;
                    CellEnterCalculationPart();
                    RowValidation();
                }
                
                TottalAmountCalculate();
                Isinotherwindow = false;
                Gridcustomerlist.Visible = false;
                Retrivemode = 0;
                if (temptax == "0")
                {
                    ComTax.Text = "None";
                }
                if (temptax == "9")
                {
                    ComTax.Text = "VAT";
                }
                if (temptax == "24")
                {
                    ComTax.Text = "CST";
                }
            }
            else
            {
                if (Isinenter == false)
                {
                    Clear();
                    if (Vtype == "PR" && PurchaseAccount == "3")
                    {
                        if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("ISSUECode", "Tblbusinessissue", " where ledcodecr='3' ")))
                        {
                            string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                            txtvno.Text = prefx + PreIssuecode.ToString();
                            txtvno.Tag = PreIssuecode.ToString();
                            TxtRefName.Text = _Dbtask.znllString(txtvno.Text);
                            TxtRefName.Tag = _Dbtask.znllString(txtvno.Text);
                            _Inventory.Vcode = Convert.ToInt64(PreIssuecode).ToString();

                           _IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                          _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                          EditMode = true;
                        
                        }
                        
                    }
                    //GetPrevious(Convert.ToInt64(PreIssuecode) - 1, false);
                }
            }
        }


        public void GetVnoOnlyissuecode()
        {
            if (EditMode == false)
            {
                if (Vtype == "PI" || Vtype == "PO")
                {
                    _TransactionReceipt.PVno(PurchaseAccount.ToString(), Vtype);
                    if (_TransactionReceipt.pvno != "")
                    {

                    }
                    else
                    {

                    }
                    txtvno.Tag = _TransactionReceipt.IdPurchaseFu(PurchaseAccount, Vtype);
                    _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                    _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                    _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
                    _Inventory.Vcode = txtvno.Tag.ToString();
                }
                else if (Vtype == "PR")
                {
                    _BusinessIssue.PVno2(PurchaseAccount.ToString(), "PR");

                    if (_BusinessIssue.Pvno != "")
                    {

                    }
                    else
                    {

                    }
                    txtvno.Tag = _BusinessIssue.IdSalesFu(PurchaseAccount, "PR");

                    _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                    _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                    _Inventory.Vcode = txtvno.Tag.ToString();
                }
            }
        }

        public void GetVno()
        {
            if (Vtype == "PI" || Vtype == "PO")
            {
                _TransactionReceipt.PVno(PurchaseAccount.ToString(), Vtype);
                if (_TransactionReceipt.pvno != "")
                {
                    txtvno.Text = Convert.ToString(_TransactionReceipt.pvno);
                    txtvno.Text = txtvno.Text + Convert.ToString(_TransactionReceipt.VNoStr);
                }
                else
                {
                    txtvno.Text = Convert.ToString(_TransactionReceipt.VNoStr);
                }
                txtvno.Tag = _TransactionReceipt.IdPurchaseFu(PurchaseAccount, Vtype);
                _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
                _Inventory.Vcode = txtvno.Tag.ToString();

                TxtRefName.Text = txtvno.Tag.ToString();
            }
            else if (Vtype == "PR")
            {
                _BusinessIssue.PVno2(PurchaseAccount.ToString(), "PR");
                if (_BusinessIssue.Pvno != "")
                {
                    txtvno.Text = Convert.ToString(_BusinessIssue.Pvno);
                    txtvno.Text = txtvno.Text + Convert.ToString(_BusinessIssue.VnoStr);
                }
                else
                {
                    txtvno.Text = Convert.ToString(_BusinessIssue.VnoStr);
                }
                txtvno.Tag = _BusinessIssue.IdSalesFu(PurchaseAccount, "PR");
                TxtRefName.Text = txtvno.Tag.ToString();
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();

            }
        }
        public bool IsDivisble(int x, int n)
        {
            return (x % n) == 0;
        }
        public void BarcodePrintsettings()
        {
            if (_Settings.FunSettings1("MdateBPrint") == true)
            {
                this.barCodeCtrl1.LeftMargin = 20;
                this.barCodeCtrl1.PrintManDate = true;
            }

            if (_Settings.FunSettings1("SuppliercodeBPrint") == true)
            {
                this.barCodeCtrl1.ShowSupplierCode = true;
            }

            if (_Settings.FunSettings1("Pitemnote1") == true)
            {
                this.barCodeCtrl1.Showitemnote1 = true;
            }
            this.barCodeCtrl1.Barcodeprintingin = CommonClass._Paramlist.GetParamvalue("printbarcodein");
            this.barCodeCtrl1.ThemalTopmargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
            this.barCodeCtrl1.LeftMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LeftBarcode"));
           
        }
        public void PrintBarcode()
        {
            if (SBatch == true)
            {
                RowValidation();
                BarcodePrintsettings();
                P1by1 = false;
                if (chkprint1by1.Checked == true)
                    P1by1 = true;

                if (_Settings.ReturnStatus("130") == "1")
                {
                    this.barCodeCtrl1.yTop = 0;
                    this.barCodeCtrl1.RupeeImgaeFu = Picrupee.BackgroundImage;
                    this.barCodeCtrl1.StrDate = DateTime.Now.ToString("dd/MM/yy");
                    this.barCodeCtrl1.IfInnextpage = false;
                    this.barCodeCtrl1.SRows = 0;
                    this.barCodeCtrl1.CurrentRecord = 0;
                    this.barCodeCtrl1.k = 0;
                    this.barCodeCtrl1.yTop = 0;
                    this.barCodeCtrl1.PageSettings();
                    //this.barCodeCtrl1.Print(gridmain,
                   // this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Laser", P1by1);
                   // this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Laser", P1by1);
              //     this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Laser", P1by1,comprint.Text);
                }
                else
                {
                    for (int i = 0; i < gridmain.Rows.Count; i++)
                    {
                        if (gridmain.Rows[i].Tag != null)
                        {
                            if (gridmain.Rows[i].Tag.ToString() == "1")
                            {
                                this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;

                                this.barCodeCtrl1.BarCodeHeight = 30;
       


                                string StrHeader;
                                ItemId =_Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Tag);
                                /*************For Get Heading Barcode***********/

                                
                                double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
                                if (Dbtemp == 1)
                                {
                                    StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                                }
                                else
                                {
                                    StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
                                }
                                /*******************************************************/

                                string Strpname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                                if (_Settings.ReturnStatus("169") == "1")
                                {
                                    Strpname = CommonClass._Itemmaster.SpecificField(ItemId, "llang");
                                }
                                //Strpname = CommonClass._Itemmaster.SpecificField(gridmain.Rows[i].Cells["clnitemname"].Tag.ToString(), "categoryid");
                                //Strpname = CommonClass._ItemCategory.SpecificField(Strpname, "category");
                                
                                if (this.barCodeCtrl1.Barcodeprintingin == "Srate")
                                {
                                   
                                    StrSrate = gridmain.Rows[i].Cells["clnsrate"].Value.ToString();
                                    if (CommonClass._Paramlist.GetParamvalue("PrintTaxpurchase") == "-1")
                                    {
                                        StrSrate = (_Dbtask.znullDouble(StrSrate) + (_Dbtask.znullDouble(StrSrate) *_Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(ItemId, "vat"))/ 100)).ToString("0.00");
                                    }
                                   
                                }
                                else if (this.barCodeCtrl1.Barcodeprintingin == "MRP")
                                {
                                    StrSrate = gridmain.Rows[i].Cells["ClnMRP"].Value.ToString();
                                }
                                Strprate = gridmain.Rows[i].Cells["clnprate"].Value.ToString();
                                string inorout = "";
                                inorout = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='Staxinclusive'").ToString();
                                //if (inorout == "Yes")
                                //{
                                //    StrSrate = gridmain.Rows[i].Cells["clnsrate"].Value.ToString();
                                //}
                                //else
                                //{
                                //    saleratee =_Dbtask.znlldoubletoobject( gridmain.Rows[i].Cells["clnsrate"].Value);
                                //  taxperc =_Dbtask.znlldoubletoobject( CommonClass._Itemmaster.SpecificField(ItemId, "vat"));
                                //  real = (saleratee * taxperc) / 100;
                                //  saleratee = saleratee + real;
                                //  StrSrate = _Dbtask.SetintoDecimalpoint(saleratee).ToString();


                                //}
                                string StrBarcode =gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                                double temp = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value.ToString());
                                //if (temp % 2 != 0)
                                //{
                                //    temp = temp + 1;
                                //}
                               // this.barCodeCtrl1.Strprate =(_Dbtask.znllString(gridmain.Rows[i].Cells["clnprate"].Value)).ToString("");

                                if (chkbcdpic.Checked == true)
                                {
                                    this.barCodeCtrl1.bcdpic = true;
                                }
                                else
                                {
                                    this.barCodeCtrl1.bcdpic = false;
                                }

                                StrSrate = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(StrSrate));
                                Strprate = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Strprate));
                                this.barCodeCtrl1.Strprate =_Dbtask.ZnullRemovepoint(Strprate);
                                this.barCodeCtrl1.StrMrp = _Dbtask.ZnullRemovepoint(Strprate);
                               // int InNoofcpies = Convert.ToInt16(temp) / 2;
                               int InNoofcpies = Convert.ToInt16(temp) ;
                                this.barCodeCtrl1.StrMrp = _Dbtask.znllString(gridmain.Rows[i].Cells["ClnMRP"].Value);
                                this.barCodeCtrl1.StrWhoRate = gridmain.Rows[i].Cells["clnwholesale"].Value.ToString();
                                this.barCodeCtrl1.ThemalTopmargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
                                this.barCodeCtrl1.LeftMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LeftBarcode"));
                                this.barCodeCtrl1.DistanceBysticker = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Dissticker"));
                                this.barCodeCtrl1.TopMargin = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("LaserTop"));
                                this.barCodeCtrl1.ShowHeader = true;
                               // this.barCodeCtrl1.StrItemnote2 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote2"].Value);
                               // this.barCodeCtrl1.StrBatchNo = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote"].Value);
                                if (_Settings.ReturnStatus("130") == "2")
                                {
                                    this.barCodeCtrl1.LeftMargin = 8;
                                    this.barCodeCtrl1.DistanceBysticker = 200;
                                    this.barCodeCtrl1.TopMargin = 2;
                                    this.barCodeCtrl1.ShowHeader = false;
                                }

                                this.barCodeCtrl1.PrintLogo = CommonClass._Menusettings.GetMnustatus("157");
                                this.barCodeCtrl1.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
                                this.barCodeCtrl1.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
                                this.barCodeCtrl1.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
                                this.barCodeCtrl1.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
                                this.barCodeCtrl1.HeaderText = StrHeader;
                                this.barCodeCtrl1.RupeeImgaeFu = Picrupee.BackgroundImage;
                                this.barCodeCtrl1.PInfo = Strpname;
                                this.barCodeCtrl1.PInfo1 = ": " + StrSrate;
                                this.barCodeCtrl1.BarCode = StrBarcode;
                                this.barCodeCtrl1.ShowFooter = true;
                                this.barCodeCtrl1.Noofcpies = InNoofcpies;
                                this.barCodeCtrl1.itemcodee = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemcode"].Value);
                                if (this.barCodeCtrl1.PrintManDate == true)
                                {
                                    //this.barCodeCtrl1.LeftMargin = 20;
                                }

                                if (this.barCodeCtrl1.ShowSupplierCode == true)
                                {
                                   // this.barCodeCtrl1.LeftMargin = this.barCodeCtrl1.LeftMargin + 10;
                                    string Accid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
                                    this.barCodeCtrl1.SuppCode = _AccountLedger.GetspecifField("laliasname", Accid);
                                }

                                 StrTemp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
                                 this.barCodeCtrl1.SuppCode = _AccountLedger.GetspecifField("laliasname", StrTemp);

                                if (this.barCodeCtrl1.Showitemnote1 == true)
                                {
                                    this.barCodeCtrl1.LeftMargin = this.barCodeCtrl1.LeftMargin + 10;
                                    string StrNOte1 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote"].Value);
                                    this.barCodeCtrl1.Itemnote1Str = StrNOte1;
                                }

                               // this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Roll", P1by1,comprint.Text);
                                this.barCodeCtrl1.Print(gridmain, this.barCodeCtrl1.Barcodeprintingin, "Roll", P1by1,comprint.Text);

                            }
                        }
                    }
                }
            }
        }
        public void FillCombo()
        {
            _Depot.FillCombo(ComDepot);
            ComDepot.SelectedIndex = 0;
            _EmployeeMaster.FillCombo(Comemployee);
            _MultiUnits.FillCombo(ComMultiUnit);
            _MultiRates.FillCombo(ComMultiRate);
            _AccountLedger.FillComboWhere(ComAgent, " Where Agroupid=29");/*For Agent*/
            string temp = _Dbtask.ExecuteScalar("select paramvalue from Tblparamlist where paramname='TaxDef'");
            ComTax.Text = temp;
           // commodeofpayment.SelectedIndex = 0;
            ComPrintSheme.SelectedIndex = 0;
        }
        public void Textalignsett()
        {
            gridmain.Columns["clnqty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnmrp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnfree"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnsrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clndiscper"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clndiscount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clngross"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clntaxper"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clntax"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnnettamount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridmain.Columns["clnprate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clncrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnwholesale"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridmain.Columns["clnsrateperc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        public bool maxvoucherexistcheck(string vtype, string account, string vno)
        {


            string exi = "";

            if (vtype == "PI" || vtype == "PO" )
            {
    

                exi = _Dbtask.znllString(_Dbtask.ExecuteScalar("select vno from tblTRANSACTIONRECEIPT where recpttype='" + vtype + "' and ledcodedr='" + account + "'  and Reptcode='" + vno + "'"));
            
            }

            if (vtype == "PR")
            {
                exi = _Dbtask.znllString(_Dbtask.ExecuteScalar("select vno from tblbusinessissue where issuetype='" + vtype + "' and ledcodecr='" + account + "'  and vno='" + vno + "'"));   
            }

            if (exi != "")
            {
                return true;
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
            if (txtvno.Text == "")
            {
                MessageBox.Show("Type Vno");
                txtvno.Focus();
                return false;
            }
            string CustomerID = _Dbtask.znllString(TxtAccount.textBox1.Tag);
            if (commodeofpayment.SelectedIndex == 1 && CustomerID == "" || CustomerID ==null)
            {
                MessageBox.Show("Select Supplier", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                TxtAccount.textBox1.Focus();
                return false;
            }

            if(_Dbtask.znlldoubletoobject(  txtbillamount.Text) <=0)
            {
                MessageBox.Show("Check BILL AMOUNT ... !!!Something wrong");
                return false;
            
            
            }

            //if (EditMode == false)
            //{
            //    if (maxvoucherexistcheck(Vtype, PurchaseAccount, _Dbtask.znllString(txtvno.Text)) == true)
            //    {
            //        MessageBox.Show("DATA ALREADY EXIST - VOUCHER NO(" + _Dbtask.znllString(txtvno.Text) + ")", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        return false;
            //    }

            //}
            //Result = MessageBox.Show("Do You want to Print?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //}
            
            //if (Result.ToString() == "Yes" || chkprintconfirmation.Checked == false)
            //{





            if (EditMode == false)
            {
                if (Vtype == "PI" || Vtype == "PO")
                {
                    Ds = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where Recpttype='" + Vtype + "' and ledcodedr='" + PurchaseAccount + "' and vno='" + txtvno.Text + "'");
                }
                else if (Vtype == "PR")
                {
                    Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuetype='PR' and ledcodecr='" + PurchaseAccount + "' and vno='" + txtvno.Text + "'");
                }
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    GetVno();
                }
            }
            if (EditMode == true)
            {
                if (_UserDetails.Permited() == false)
                {
                    return false;
                }
            }
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {

                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        if (txtvno.Text != "")
                        {

                            if (TxtAccount.textBox1.Tag != null)
                            {
                                return true;
                            }

                        }
                    }
                }
            }
            return false;
        }

        public void CheckandMaximumBarcode()
        {

        }

        public void UnitAmountCalc()
        {
            //DS3 = _Dbtask.ExecuteQuery("select * from tblItemmaster where ItemId='" + ItemId + "'");

            //if (DS3.Tables[0].Rows.Count > 0)
            //{
            //    SecUnit = DS3.Tables[0].Rows[0]["Unit2"].ToString();
            //    FirUnit = DS3.Tables[0].Rows[0]["Unit"].ToString();
            //    UnitName = DS3.Tables[0].Rows[0]["Unit"].ToString();
            //    Unitamount1 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount1"].ToString());
            //    UnitAmount2 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount2"].ToString());
            //    if (UnitName == SecUnit)
            //    {
            //        Convrt = Unitamount1;
            //    }
            //    if (UnitName == FirUnit)
            //    {
            //        Convrt = Unitamount1 * UnitAmount2;
            //    }
            //}

            Convrt =_Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", Unitid));
        }
        public int ModeOFpaymentFu()
        {
            
            return  commodeofpayment.SelectedIndex;
        }
        public void getmaxvnonumber()
        {
            vnoname = "";
            if (Vtype == "PI")
            {
                vnoname = "MaxofPI";

                CommonClass._GenF.checkmaxtableandparamval(CommonClass._Paramlist.GetParamvalue("MaxofPI"), vnoname);


                txtvno.Tag = CommonClass._Paramlist.GetParamvalue("MaxofPI");
                txtvno.Text = CommonClass._Paramlist.GetParamvalue("MaxofPI");

                _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
                _Inventory.Vcode = txtvno.Tag.ToString();

                //TxtRefName.Text = txtvno.Tag.ToString();
                //TxtRefName.Tag = txtvno.Tag.ToString();
                CommonClass._Paramlist.updateparamvalueVNO(vnoname, Convert.ToInt32(txtvno.Tag));

            }
            if (Vtype == "PR")
            {
                vnoname = "MaxofPR";
                CommonClass._GenF.checkmaxtableandparamval(CommonClass._Paramlist.GetParamvalue("MaxofPR"), vnoname);
                txtvno.Tag = CommonClass._Paramlist.GetParamvalue("MaxofPR");
                txtvno.Text = CommonClass._Paramlist.GetParamvalue("MaxofPR");

                //TxtRefName.Tag = txtvno.Tag.ToString();
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
                //TxtRefName.Text = txtvno.Tag.ToString();
                CommonClass._Paramlist.updateparamvalueVNO(vnoname, Convert.ToInt32(txtvno.Tag));

            }
        }
        public void NextgInitialize()
        {
            double NExcisedutty = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)

                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        try
                        {
                            StrPurticulars = _GeneralLedger.PurticularsCreate(TxtAccount.textBox1, txtvno);
                            StrPurticularsForLedger = _GeneralLedger.PurticularsCreateForLedger(this.Text, txtvno);
                            /* Inventory */
                            double Unitqty = 0;


                            //PR
                      
                            double Length = 0;
                            double Width = 0;
                            //double Crate = 0;
                            DateTime Exdate;
                            string Depocode = Stockareaid;
                            DateTime Date = dtdate.Value;
                            long Slno = Convert.ToInt64(gridmain.Rows[i].Cells["Clnslno"].Value);
                            string Pid = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                            

                            DateTime DtMdate = _Dbtask.ZnullDatetime(gridmain.Rows[i].Cells["clnmandate"].Value);
                            DateTime DtEdate = _Dbtask.ZnullDatetime(gridmain.Rows[i].Cells["clnexdate"].Value);



                            string Itemnote = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote"].Value);
                            string Itemnote2 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote2"].Value);
                            double qty = _Dbtask.gridnul(gridmain.Rows[i].Cells["Clnqty"].Value);
                            double Srate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnsrate"].Value);
                            double Wrate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnwholesale"].Value);
                            double Prate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnprate"].Value);
                            double Crate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clncrate"].Value);
                            double profits = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnsrateperc"].Value);


                            if (_Dbtask.znllString(profits) == "∞")
                            {
                                profits = 0;
                            }
                            


                            double NetAmt = _Dbtask.gridnul(gridmain.Rows[i].Cells["Clnnettamount"].Value);
                            double Discrate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clndiscount"].Value);
                            double Mrp = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnmrp"].Value);
                            double TaxRate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clntax"].Value);
                            double Taxper = _Dbtask.gridnul(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                            double free = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnfree"].Value);
                            Wrate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnwholesale"].Value);
                            double ExciseDuty = 0;
                            string StrSlno=_Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);
                           if(StrSlno !="")
                            CommonClass._Slno.InsertSlnopara(Pid, StrSlno, Vtype, txtvno.Text, -1);
                            
                            if (SUnit == true)
                            {
                                MunitId = Convert.ToInt64(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnunit"].Tag));
                                Unitid = MunitId.ToString();
                                UnitName = CommonClass._Unitcreation.Getspesificfield("name", MunitId.ToString());
                                ItemId = Pid;
                                UnitAmountCalc();

                                Unitqty = Convrt * qty;
                            }
                            long MRateid = Convert.ToInt64(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnmrate"].Tag));

                            if (SExsiceDutty == true)
                            {
                                ExciseDuty = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnexciseduty"].Value);
                                NExcisedutty = NExcisedutty + ExciseDuty;
                            }
                            if (SBatch == true)
                            {
                                Batchcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                            }
                            if (Sinvoicediscount == true)
                            {
                                invdiscount = _Dbtask.znullDouble(txtinvoicediscount.textBox1.Text);
                                _ReceiptDetails.BillDisc = invdiscount;
                            }

                            /*Batch*/
                            if (SBatch == true)
                            {
                                _Batch.CheckbarcodeandreturnMax(gridmain, i);
                                if (CommonClass.temp == "" || CommonClass.temp == null)
                                {
                                    CommonClass.temp = "0";
                                }

                                if (CommonClass._Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Tag) == "")
                                {
                                    gridmain.Rows[i].Cells["clnbatch"].Tag = CommonClass.temp;
                                }
                                Batchcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                            }

                            _Inventory.Ledcode = PurchaseAccount;
                            _Inventory.DCodeStr = Depocode;
                            _Inventory.InvDateDt = Date;
                            _Inventory.PcodeStr = Pid;
                            _Inventory.freepre = free;
                            _Inventory.Vtype = Vtype;
                            _Inventory.UC = Convrt;
                            _Inventory.Exdate = DtEdate;

                            if (Vtype == "PI" || Vtype == "PR")
                            {
                                if (Vtype == "PI")
                                {
                                    if (SUnit == true)
                                    {
                                        _Inventory.Purchase = Unitqty;
                                    }
                                    else
                                    {
                                        _Inventory.Purchase = qty;
                                    }
                                    _Inventory.Pr = 0;
                                }
                                else if (Vtype == "PR")
                                {
                                   
                                    if (SUnit == true)
                                    {
                                        _Inventory.Pr = Unitqty;
                                    }
                                    else
                                    {
                                        _Inventory.Pr = qty;
                                    }
                                    _Inventory.Purchase = 0;
                                }

                                _Inventory.Costcenter = "0";
                                _Inventory.Batchcode = Batchcode;

                                if (i == frstivalP && EditMode == false)
                                {
                                    getmaxvnonumber();
                                    
                                }
                                
                                _Inventory.InsertInventory();


                                /*Update MRP*/
                                bool DsTemp = _ReceiptDetails.ItemexstinginPurchase(Pid);
                                if (SupdateMRP == true || DsTemp == false)
                                {
                                    if (SBatch == false)
                                    {
                                        _ItemMaster.UpdateField(Pid, Mrp, "mrp");
                                    }
                                    else
                                    {
                                        _Batch.UpdateField(Pid, Mrp, "mrp",Batchcode, "");
                                    }
                                }
                                /*Update Srate*/
                                if (Srate > 0)
                                {
                                    if (Supdatesrate == true || DsTemp == false)
                                    {
                                        if (SBatch == false)
                                        {
                                            _ItemMaster.UpdateField(Pid, Srate, "srate");
                                        }
                                        else
                                        {
                                            _Batch.UpdateField(Pid, Srate, "srate", Batchcode, "");
                                        }
                                    }
                                }

                                /*Update PRate*/
                                if (Prate > 0)
                                {
                                    if (Supdateprate == true || DsTemp == false)
                                    {
                                        if (SBatch == false)
                                        {
                                            _ItemMaster.UpdateField(Pid, Prate, "prate");
                                        }
                                        else
                                        {
                                            _Batch.UpdateField(Pid, Prate, "prate", Batchcode, "");
                                        }
                                    }
                                }

                                /*Update Crate*/
                                if (Supdateprate == true || DsTemp == false)
                                {
                                    _ItemMaster.UpdateField(Pid, Crate, "crate");
                                    /*Update Wholesalerate*/

                                    if (SBatch == false)
                                    {
                                        if (EditMode == true)
                                        {
                                            _Dbtask.ExecuteNonQuery("delete from tblproductrate where pcode='" + Pid + "'");
                                        }
                                        _Productrate.UpdateField(Pid, Wrate, "rate", false, "",0);
                                    }
                                    else
                                    {
                                        if (EditMode == true)
                                        {
                                            _Dbtask.ExecuteNonQuery("delete from tblproductrate where pcode='" + Pid + "' and batchid='" + Batchcode + "'");
                                        }
                                        _Productrate.UpdateField(Pid, Wrate, "rate", true, Batchcode,0);
                                    }
                                }

                                //if (Smrate == true)
                                //{
                                //    _Productrate.PCode = Pid;
                                //    _Productrate.RateId = 1;
                                //    _Productrate.UnitId = 0;
                                //    _Productrate.Ratedb = Convert.ToDouble(gridmain.Rows[i].Cells["clnwholesale"].Value);
                                //    _Productrate.Batchid = Batchcode;
                                //    _Productrate.InsertProductRate();
                                //}

                            }
                            ////////////////////////////////////////////
                            /*update in Product rate table*/



                            if (SBatch == true && Vtype == "PI")
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblbatch where bcode='" + Batchcode + "' ");
                                _Batch.Bcode = Batchcode;
                                _Batch.Itemid = Pid;
                                _Batch.Costcenter = "0";
                                _Batch.Depo = Depocode;
                                _Batch.ManDate = DtMdate;
                                _Batch.ExDate = DtEdate;
                                _Batch.Depo = Depocode;
                                _Batch.Bid = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Tag);

                                if (_Batch.Bid != null)
                                {
                                    if (_Batch.Bid != "")
                                    {
                                        string PreBatch = CommonClass._Paramlist.GetParamvalue("Prebarcode");
                                        int PreLength = PreBatch.Length;
                                        string PreBatch2 = Batchcode.Substring(0, PreLength);
                                        string tempBatch = CommonClass._Paramlist.GetParamvalue("MaxBcode");
                                        try
                                        {
                                            if (Convert.ToDouble(_Batch.Bid) > Convert.ToDouble(tempBatch) && PreBatch2 == PreBatch)
                                                CommonClass._Paramlist.UpdateParamlist("MaxBcode", "1", _Batch.Bid.ToString());
                                        }
                                        catch
                                        {
                                        }
                                    }
                                }
                                if (SUnit == true)
                                    _Batch.Unconv = Convrt;
                                _Batch.Recptcode = txtvno.Tag.ToString();
                                _Batch.Ledcode = PurchaseAccount;
                                _Batch.Mrp = Mrp;
                                _Batch.Srate = Srate;
                                _Batch.Prate = Prate;
                                _Batch.InsertBatch();
                            }

                            if (Vtype == "PI" || Vtype == "PO")
                            {
                                _ReceiptDetails.SlNoLng = Slno;
                                _ReceiptDetails.PCodeStr = Pid;
                                _ReceiptDetails.ItemNoteStr = Itemnote;
                                _ReceiptDetails.ItemNoteStr2 = Itemnote2;
                                _ReceiptDetails.UnitIdLng = MunitId;
                                _ReceiptDetails.MultiRateIdLng = MRateid;
                                _ReceiptDetails.QtyDb = qty;
                                _ReceiptDetails.RateDb = Prate;
                                _ReceiptDetails.SRate = Srate;
                                _ReceiptDetails.CRate = Crate;
                                _ReceiptDetails.profit = profits;
                                _ReceiptDetails.QtyFreeDb = free;
                                _ReceiptDetails.NetAmtDb = NetAmt;
                                _ReceiptDetails.BatchIdstr = Batchcode;
                                _ReceiptDetails.DiscDb = Discrate;
                                _ReceiptDetails.Ledcode = PurchaseAccount;
                                _ReceiptDetails.Mrp = Mrp;
                                _ReceiptDetails.TaxRateDb = TaxRate;
                                _ReceiptDetails.Dtmandate = DtMdate;
                                _ReceiptDetails.DtExdate = DtEdate;
                                _ReceiptDetails.Vtype = Vtype;
                                _ReceiptDetails.Taxper = Taxper;
                                _ReceiptDetails.ExciseDuty = ExciseDuty;

                                _ReceiptDetails.billtot = _Dbtask.znullDouble(txtbillamount.Text);
                                _ReceiptDetails.Wrate=Wrate;
                                _ReceiptDetails.InsertReceiptDetails();
                            }
                            if (Vtype == "PR")
                            {
                                _IssueDetails.SlNoLng = Slno;
                                _IssueDetails.PCodeStr = Pid;
                                _IssueDetails.UnitIdLng = MunitId;
                                _IssueDetails.MultiRateIdLng = Convert.ToInt16(MRateid);
                                _IssueDetails.QtyDb = qty;
                                _IssueDetails.RateDb = Prate;
                                _IssueDetails.Mrp = Mrp;
                                _IssueDetails.NetAmtDb = NetAmt;
                                _IssueDetails.BatchIdStr = Batchcode;
                                _IssueDetails.Ledcode = PurchaseAccount;
                                _IssueDetails.DiscDb = Discrate;
                                _IssueDetails.TaxRateDb = TaxRate;
                                _IssueDetails.QtyFreeDb = free;
                                _IssueDetails.Vtype = Vtype;
                                _IssueDetails.Taxper = Taxper;
                                _IssueDetails.billtot = Convert.ToDouble(txtbillamount.Text);
                                _IssueDetails.billtime = "";

                                SlTracking = "";
                                _IssueDetails.SlnoTracking = SlTracking;
                                _IssueDetails.Length = Length;
                                _IssueDetails.width = Width;
                                _IssueDetails.CRate = Crate;
                                _IssueDetails.ExDate = DtEdate;


                                _IssueDetails.InsertIssueDetails();
                            }
                        }
                        catch
                        {
                        }
                    }

            }


            double AdvancePay = new double();


            //cash withcustmoer
            if(_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("221"))=="1")
            {
            if (commodeofpayment.SelectedIndex == 0 && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "1")
            {
                if (_Dbtask.znllString(TxtAccount.textBox1.Tag) != "" && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "28")
                {

                    string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
                    if (_Dbtask.znllString(TxtAccount.textBox1.Tag) != temp)
                    {
                        txtreceivedamt.Text = _Dbtask.znllString(txtbillamount.Text);
                        AdvancePay = _Dbtask.znullDouble(txtreceivedamt.Text);

                    }

                }
            }

            if (commodeofpayment.SelectedIndex == 2 && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "1")
            {
                if (_Dbtask.znllString(TxtAccount.textBox1.Tag) != "" && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "28")
                {

                    string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
                    if (_Dbtask.znllString(TxtAccount.textBox1.Tag) != temp)
                    {
                        txtreceivedamt.Text = _Dbtask.znllString(txtbillamount.Text);
                        AdvancePay = _Dbtask.znullDouble(txtreceivedamt.Text);

                    }

                }
            }

            }





            StringTemp = dtdate.Value.ToString("dd/MMM/yyyy");
            Stringbillingdate = dtbilldate.Value.ToString("dd/MMM/yyyy");

            if (Vtype == "PI" || Vtype == "PO")
            {
                _TransactionReceipt.RcptDateDt = Convert.ToDateTime(dtdate.Value);
                _TransactionReceipt.Rcptdatebilling = Convert.ToDateTime(dtbilldate.Value);
                _Nextg.SetVno(txtvno.Text);
                _TransactionReceipt.Uid = ClsUserDetails.MUserName;
                _TransactionReceipt.VNoStr = _Nextg.vno;
                _TransactionReceipt.pvno = _Nextg.pvno;
                _TransactionReceipt.Tename = TxtAccount.textBox1.Text;
               
                _TransactionReceipt.RefNo =_Dbtask.znllString( TxtRefName.Text);
                
                _TransactionReceipt.RCptTypeStr = Vtype;
                _TransactionReceipt.DcodeStr = Stockareaid;
                _TransactionReceipt.RcptDateDt = dtdate.Value;
                _TransactionReceipt.LedCodeCr = TxtAccount.textBox1.Tag.ToString();
                _TransactionReceipt.Ramount = _Dbtask.znullDouble(txtreceivedamt.Text) ;
                 
                _TransactionReceipt.LedCodeDr = PurchaseAccount;
                _TransactionReceipt.AMTDb = _Dbtask.znullDouble(txtbillamount.Text);
                _TransactionReceipt.RemarkStr = TxtNaration.textBox1.Text;
                _TransactionReceipt.DiscAmtDb = _Dbtask.znullDouble(TxtTDiscount.Text);
                _TransactionReceipt.TaxAMTDb = _Dbtask.znullDouble(txtttax.Text);
                _TransactionReceipt.CoolyDb = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
                _TransactionReceipt.EmpId = StaffId.ToString();
                _TransactionReceipt.Agent = agentid.ToString();
                _TransactionReceipt.Modeofpayment = ModeOFpaymentFu();
                if(cmdbrowsebill.Tag ==null)
                cmdbrowsebill.Tag = "";

                _TransactionReceipt.Billimg = CommonClass._Nextg.ImageToStream(cmdbrowsebill.Tag.ToString());

               // _TransactionReceipt.Billimg = DBNull.Value;
            }
            else if (Vtype == "PR")
            {
                _Nextg.SetVno(txtvno.Text);
                _BusinessIssue.Uid = ClsUserDetails.MUserName;
                _BusinessIssue.VnoStr = _Nextg.vno;
                _BusinessIssue.Pvno = _Nextg.pvno;
                _BusinessIssue.Tename = TxtAccount.textBox1.Text;
                _BusinessIssue.IssueTypeStr = Vtype;
                _BusinessIssue.DCode = Stockareaid;
                _BusinessIssue.IssueDateDt = dtdate.Value;
                _BusinessIssue.LedCodeCr = PurchaseAccount.ToString();
                _BusinessIssue.LedCodeDr = TxtAccount.textBox1.Tag.ToString();
                _BusinessIssue.AMTDb = Convert.ToDouble(txtbillamount.Text);
                _BusinessIssue.RemarkStr = TxtNaration.textBox1.Text;
                _BusinessIssue.DiscAmtDb = _Dbtask.znullDouble(Txtcashdiscount.textBox1.Text);
                _BusinessIssue.TaxAMTDb = _Dbtask.znullDouble(txtttax.Text);
                _BusinessIssue.CoolyDb = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
                _BusinessIssue.Agent = agentid;
                _BusinessIssue.EmpId = StaffId;
                _BusinessIssue.ModeOfpayment = ModeOFpaymentFu();


            }

            if (Vtype == "PI")
            {
                CommonClass._purbill.InsertpurchaseBillsettlement(_Dbtask.znllString(txtvno.Text), Vtype, Convert.ToInt64(TxtAccount.textBox1.Tag), _Dbtask.znlldoubletoobject(txtbillamount.Text), 0, "", dtdate.Value, 0);

            }

            if (Vtype == "PR")
            {
                CommonClass._PRbill.InsertBillsettlementPR(_Dbtask.znllString(txtvno.Text), Vtype, Convert.ToInt64(TxtAccount.textBox1.Tag), 0, _Dbtask.znlldoubletoobject(txtbillamount.Text), "", dtdate.Value, 0);

            }





            if (Vtype == "PI" || Vtype == "PO")
            {
                if (ComTax.SelectedIndex == 0)
                {
                    _TransactionReceipt.Taxid = "0";
                }
                if (ComTax.SelectedIndex == 1 || ComTax.SelectedIndex == 3)
                {
                    _TransactionReceipt.Taxid = "8";
                }
                if (ComTax.SelectedIndex == 2)
                {
                    _TransactionReceipt.Taxid = "25";
                }
                _TransactionReceipt.InsertTransactionReceipt();
            }
            if (Vtype == "PR")
            {
                _BusinessIssue.IssueDateDt = Convert.ToDateTime(dtdate.Value);
                if (ComTax.SelectedIndex == 0)
                {
                    _BusinessIssue.TaxId = "0";
                }
                if (ComTax.SelectedIndex == 1 || ComTax.SelectedIndex == 3)
                {
                    _BusinessIssue.TaxId = "9";
                }
                if (ComTax.SelectedIndex == 2)
                {
                    _BusinessIssue.TaxId = "24";
                }
                _BusinessIssue.InsertBusinessIssue();
            }

            if (Vtype == "PI" )
            {
                /*Advance Paid*/
                _GeneralLedger.Uid = ClsUserDetails.MUserName;
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                _GeneralLedger.RefnoStr = PurchaseAccount;

                if (_Dbtask.znullDouble(txtreceivedamt.Text) > 0)
                {

                    if(commodeofpayment.SelectedIndex==0)
                    {
                    _GeneralLedger.VTypeStr = "P";
                    _GeneralLedger.IdGeneralLedger(" where vtype='P'");
                    _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Text);
                    _GeneralLedger.LedCodeStr = "1";
                    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                    _GeneralLedger.DbAmtDb = 0;
                    _GeneralLedger.CrAmt = _Dbtask.znullDouble(txtreceivedamt.Text);
                    Insert();
                    _GeneralLedger.LedCodeStr = TxtAccount.textBox1.Tag.ToString();
                    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                    _GeneralLedger.DbAmtDb = _Dbtask.znullDouble(txtreceivedamt.Text);
                    _GeneralLedger.CrAmt = 0;
                    Insert();
                    }
                    if (commodeofpayment.SelectedIndex == 2)
                    {
                        _GeneralLedger.VTypeStr = "P";
                        _GeneralLedger.IdGeneralLedger(" where vtype='P'");
                        _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Text);
                        _GeneralLedger.LedCodeStr = "28";
                        _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                        _GeneralLedger.DbAmtDb = 0;
                        _GeneralLedger.CrAmt = _Dbtask.znullDouble(txtreceivedamt.Text);
                        Insert();
                        _GeneralLedger.LedCodeStr = TxtAccount.textBox1.Tag.ToString();
                        _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                        _GeneralLedger.DbAmtDb = _Dbtask.znullDouble(txtreceivedamt.Text);
                        _GeneralLedger.CrAmt = 0;
                        Insert();
                    }


                }

            }

            _GeneralLedger.Uid = ClsUserDetails.MUserName;

            if (Vtype == "PI" && _Dbtask.znullDouble(TxtTGross.Text)>0)
            {
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.VTypeStr = "PI";
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr = PurchaseAccount;
                _GeneralLedger.PurticularsStr = StrPurticulars;


                _GeneralLedger.DbAmtDb = _Dbtask.znullDouble(TxtTGross.Text);
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                _GeneralLedger.RefnoStr = PurchaseAccount;

                Insert();

                _GeneralLedger.LedCodeStr = TxtAccount.textBox1.Tag.ToString();
                _GeneralLedger.PurticularsStr = StrPurticularsForLedger;
                _GeneralLedger.DbAmtDb = 0;
                _GeneralLedger.CrAmt = _Dbtask.znullDouble(txtbillamount.Text);
                Insert();
            }



            

            else if (Vtype == "PR" && _Dbtask.znullDouble(TxtTGross.Text)>0)
            {
                /*For Debit*/
                _GeneralLedger.VdateDt = Convert.ToDateTime(dtdate.Value);
                _GeneralLedger.VTypeStr = Vtype;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr = TxtAccount.textBox1.Tag.ToString();
                _GeneralLedger.PurticularsStr = StrPurticularsForLedger;
                _GeneralLedger.DbAmtDb = _Dbtask.znullDouble(txtbillamount.Text);
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                _GeneralLedger.RefnoStr = PurchaseAccount;

                Insert();

                /*For Credit */
                _GeneralLedger.LedCodeStr = PurchaseAccount.ToString();
                _GeneralLedger.PurticularsStr = StrPurticulars;
                _GeneralLedger.DbAmtDb = 0;
                double TTCooly = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
                double TTInvoiceDiscount = _Dbtask.znullDouble(Txtcashdiscount.textBox1.Text);
                double TTItemdiscou = _Dbtask.znullDouble(TxttItemDiscount.Text);
                double TTdis = TTInvoiceDiscount + TTItemdiscou;
                double TTTax = _Dbtask.znullDouble(txtttax.Text);
                double Cr = TTCooly + TTTax;
                double TTNet = _Dbtask.znullDouble(txtbillamount.Text) - Cr;
                _GeneralLedger.CrAmt = TTNet + TTdis;
                Insert();
            }
            if (NExcisedutty > 0)
            {
                /*For Credit To Ledger(Party Account)*/
                _GeneralLedger.LedCodeStr = "10";
                _GeneralLedger.PurticularsStr = StrPurticulars;
                _GeneralLedger.DbAmtDb = NExcisedutty;
                _GeneralLedger.CrAmt = 0;
                Insert();
            }


            /*CoolY*/
            double CoolyAmt = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
            string CoolyAccount = "27";
            if (CoolyAmt > 0)
            {
                if(Vtype == "PI")
                {
                _GeneralLedger.InsertAccountsCrPurchase(CoolyAccount, StrPurticulars, CoolyAmt, 0, PurchaseAccount);
            
                }
                if (Vtype == "PR")
                {
                    _GeneralLedger.InsertAccountsCrPurchase(CoolyAccount, StrPurticulars,  0,CoolyAmt, PurchaseAccount);

                }
                
                }
            /*For Agent */
            AgentAmt = _Dbtask.znullDouble(TxtAgentAmt.Text);
            if (agentid != "0" && AgentAmt > 0)
            {
                _GeneralLedger.InsertAccountsCrPurchase(agentid, StrPurticulars, 0, AgentAmt, PurchaseAccount);
            }
            ///* For Staff*/
            StaffAmt = _Dbtask.znullDouble(Txtemployeeamt.Text);
            if (StaffId != "0" && StaffAmt > 0)
            {
                _GeneralLedger.InsertAccountsCrPurchase(StaffId, StrPurticulars, 0, StaffAmt, PurchaseAccount);
            }
            /*For Discount Pay */
            TottalDiscount = _Dbtask.znullDouble(TxtTDiscount.Text);
            if (TottalDiscount > 0 && Vtype == "PI")
            {
                _GeneralLedger.InsertAccountsCrPurchase("6", StrPurticulars, 0, TottalDiscount, PurchaseAccount);
            }
            else if (TottalDiscount > 0 && Vtype == "PR")
            {
                _GeneralLedger.InsertAccountsCrPurchase("6", StrPurticulars, TottalDiscount, 0, PurchaseAccount);
            }

            /*For Roundoff */
            roundof = _Dbtask.gridnul(txtroundoff.textBox1.Text);
            if ((roundof > 0 || roundof < 0) && Vtype == "PI")
            {
                _GeneralLedger.InsertAccountsCrPurchase("11", StrPurticulars, 0, roundof, PurchaseAccount);
            }
            else if ((roundof > 0 || roundof < 0) && Vtype == "PR")
            {
                _GeneralLedger.InsertAccountsCrPurchase("11", StrPurticulars, roundof, 0, PurchaseAccount);
            }
            /*For Tax*/
            TottalTax = _Dbtask.znullDouble(txtttax.Text);
            if (ComTax.Text == "VAT" && TottalTax > 0 && Vtype == "PI")
            {
                _GeneralLedger.InsertAccountsCrPurchase("8", StrPurticulars, TottalTax, 0, PurchaseAccount);
            }
            if (ComTax.Text == "CST" && TottalTax > 0 && Vtype == "PI")
            {
                _GeneralLedger.InsertAccountsCrPurchase("25", StrPurticulars, TottalTax, 0, PurchaseAccount);
            }

            if (ComTax.Text == "VAT" && TottalTax > 0 && Vtype == "PR")
            {
                _GeneralLedger.InsertAccountsCrPurchase("8", StrPurticulars, 0, TottalTax, PurchaseAccount);
            }
            if (ComTax.Text == "CST" && TottalTax > 0 && Vtype == "PR")
            {
                _GeneralLedger.InsertAccountsCrPurchase("25", StrPurticulars, 0, TottalTax, PurchaseAccount);
            }
        }

        public void Controlesett()
        {
            int Left = PnlHeading.Width / 2;
        }
        public void RegistrationCheck()
        {
            Registration = _Nextg.NextgRegistration();
            if (Registration == false)
            {
                MessageBox.Show("Product Expired");
                _Nextg.CloseGriddetail(gridmain, this);
            }

        }

        public void RemoveSortable()
        {
            foreach (DataGridViewColumn column in gridmain.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public double Checkinvalid(string val,string column,string bbcode)
        
        {
            double invalid = 0;
            invalid = _Dbtask.znlldoubletoobject(val);
            if (val.Length > 20)
            {

                if (column == "clnqty" || column == "ClnDiscPer" || column == "clndiscount" || column == "clnfree")
                {

                    invalid = 0;
                }
                else
                {
                    if (_Batch.SameNamealreadyexistNew(bbcode) == true)
                    {
                        if (column == "clnprate")
                        {

                            invalid = _Dbtask.znlldoubletoobject(_Batch.GetSpecificFieldofBatch(bbcode, "prate"));

                        }
                        if (column == "clnsrate")
                        {

                            invalid = _Dbtask.znlldoubletoobject(_Batch.GetSpecificFieldofBatch(bbcode, "srate"));

                        }
                    }
                    else
                    {
                        invalid = 0;
                    }
                }



            }
            else
            {
                invalid = _Dbtask.znlldoubletoobject(val);
            }
            return invalid;

        }
        public void MINVALSET()
        {

            if (Vtype == "PI" && PurchaseAccount == "3")
            {
                minivalbillnum = MINofPI;

            }

            if (Vtype == "PR")
            {
                minivalbillnum = MINofPR;

            }
            if (Vtype == "PO")
            {
                minivalbillnum = MINofPO;

            }


            if (minivalbillnum=="")
            {
                minivalbillnum = "1";

            }
        }
        private void Frmpurchase_Load(object sender, EventArgs e)
            {
            FrmbarcodePrinting.prnt = false;
            Purprint = true;
            Textalignsett();
            Controlesett();
            gridmain.Controls.Add(ComMultiRate);
            gridmain.Controls.Add(ComMultiUnit);
            RemoveSortable();
            ShowSubpanel = true;

            RegistrationCheck();
            Settcontroletext();
            _Nextg.ClearControles(PnlGeneral);
            _Nextg.ClearControles(PnlBottom);
            gridmain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridmain.AllowUserToResizeRows = false;
            SetcontrolePosition();
            Gridcustomerlist.Visible = false;

            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                    PurchaseAccount = FrmReport.MainAccount;
                    string reptcode = FrmReport.ClickCode;
                    GetPrevious(Convert.ToInt64(reptcode) , true);
            }
            if (Vtype == "PR")
            {
                PnlHeading.BackColor = Color.MistyRose;
            }
            if (Vtype == "PO")
            {
                PnlHeading.BackColor = Color.PaleGoldenrod;
            }
            TxtAccount.Tag = "";
           
            BarcodeEditing();
            TxtAccount.Select();
            TxtAccount.Focus();
            CommonClass._Nextg.FormIcon(this);

             frstivalP = 0;
        frstiboolP = false;
        MINVALSET();
        stratsett();
        ComPrintSheme.SelectedIndex = 1;

        }
        public void stratsett()
        {
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("218")) == "1")
            {
                pritwhile = true;
            }
            else
            {
                pritwhile = false;
            }

            ClsInGrid.WGmitemcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

            ClsInGrid.WGmitemname = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
            ClsInGrid.WGmsrate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
            ClsInGrid.WGmmrp = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
            ClsInGrid.WGmrack = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
            ClsInGrid.WGmprate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            ClsInGrid.WGmbcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));
            ClsInGrid.stocksetting = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("219"));


            if (Vtype == "PI" && PurchaseAccount == "3")
            {
                MINofPI = CommonClass._Paramlist.GetParamvalue("MINofPI");

            }

            if (Vtype == "PR")
            {
                MINofPR = CommonClass._Paramlist.GetParamvalue("MINofPR");

            }
            if (Vtype == "PO")
            {
                MINofPO = CommonClass._Paramlist.GetParamvalue("MINofPO");

            }


            //if (minivalbillnum == "")
            //{
            //    minivalbillnum = "1";

            //}


            int codeW =116;
            codeW = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("batchwidthinpurchase"));
            gridmain.Columns["clnbatch"].Width = codeW; 





        }
        public void GridSelect()
        {
            gridmain.Focus();
            gridmain.Rows[0].Cells[1].Selected = true;
            gridmain.CurrentCell = gridmain.Rows[0].Cells[1];
        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            try
            {
                if (uscGridshow2.chkshowprate.Checked == true)
                {
                    _Ingrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, Stockareaid, true,true,"");
                }
                else
                {
                    _Ingrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, Stockareaid, false,true,"");
                }

                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 6 * 3);
                else
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 34 * 3);

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

            if (SBatch == true)
            {
                WhereCondition = " where  (TblItemMaster.itemCode Like N'%" + WhereCondition + "%' OR  TblItemMaster.ItemName Like N'%" + WhereCondition + "%' or Tblbatch.bcode like N'%" + WhereCondition + "%' ) ";
                _Ingrid.BatchGridShowPURCHASE(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, "", false, false, "");
            }
            else
            {
                //WhereCondition = " where  (TblItemMaster.itemCode Like N'%" + WhereCondition + "%' OR  TblItemMaster.ItemName Like N'%" + WhereCondition + "%'  ) ";
                _Ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, Stockareaid);
            }
                
                IsEnter = true;
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

            //if (tempRect.Top > 426)
            //    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height + 12 * 3);
            //else
                _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 39 * 3);
        }
        public void InsertZeroValue()
        {
            if (gridmain.Rows[rowindex].Cells["clnqty"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clnqty"].Value = 0;
            }
            if (gridmain.Rows[rowindex].Cells["clnfree"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clnfree"].Value = 0;
            }
            if (gridmain.Rows[rowindex].Cells["clndiscount"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clndiscount"].Value = 0;
            }
            if (gridmain.Rows[rowindex].Cells["clndiscper"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clndiscper"].Value = 0;
            }
            if (gridmain.Rows[rowindex].Cells["clnsrate"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clnsrate"].Value = 0;
            }
            if (gridmain.Rows[rowindex].Cells["clntax"].Value == null)
            {
                gridmain.Rows[rowindex].Cells["clntax"].Value = 0;
            }
        }


        public void CalculateSrate()
        {
            try
            {
                if (Columnname == "clnsrateperc")
                {
                    double Sperc = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrateperc"].Value);
                    if (clnsrateperc.Visible == true && Sperc > 0)
                    {
                        double Prate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clncrate"].Value);
                        double Tamt = new double();
                        double ttAmt = new double();
                        Tamt = 0;
                        ttAmt = 0;
                        if (CommonClass._Menusettings.GetMnustatus("163") == "1")
                        {
                            Tamt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clntax"].Value) / _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        }
                        ttAmt = Prate + Tamt;
                        double Srate = ttAmt * Sperc / 100;
                        Srate = Srate + ttAmt;
                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(Srate);
                    }
                    else
                    {

                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = "";
                    }
                }


                 //gridmain.Rows[rowindex].Cells["clnsrate"].Value ="";
                     

                else if (Columnname == "clnsrate")
                {
                    double TPrate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clncrate"].Value);
                    double TSrate =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                    double Amt = TSrate - TPrate;

                    if (clnsrateperc.Visible == true)
                    {
                        double TPerc = Amt * 100 / TPrate;
                        gridmain.Rows[rowindex].Cells["clnsrateperc"].Value = _Dbtask.SetintoDecimalpoint(TPerc);
                    }
                }
            }
            catch
            {
            }
        }

        public void CalculateMrp()
        {
            try
            {
                if (Columnname == "clnsrateperc1")
                {
                    double Sperc =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrateperc1"].Value);
                    if (clnsrateperc1.Visible == true && Sperc > 0)
                    {
                        double Prate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnprate"].Value);

                        double Srate = Prate * Sperc / 100;
                        Srate = Srate + Prate;
                        gridmain.Rows[rowindex].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(Srate);
                    }
                }
                else if (Columnname == "ClnMRP")
                {
                    double TPrate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnprate"].Value);
                    double TSrate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnmrp"].Value);
                    double Amt = TSrate - TPrate;

                    if (clnsrateperc1.Visible == true)
                    {
                        double TPerc = Amt * 100 / TPrate;
                        gridmain.Rows[rowindex].Cells["clnsrateperc1"].Value = _Dbtask.SetintoDecimalpoint(TPerc);
                    }
                }
            }
            catch
            {
            }
        }


        public void salerate()
        {
            double crate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clncrate"].Value);

            //gridmain.Rows[rowindex].Cells["clncrate"].Value = crate;

            double profit = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrateperc"].Value);


            gridmain.Rows[rowindex].Cells["clnsrateperc"].Value = profit;

            double ansr = (crate * profit) / 100;
            double srate = crate + ansr;
            gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.znlldoubletoobject(srate);






        }








        public void CellEnterCalculationPart()
                            {
            try
            {
                InsertZeroValue();
                gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnqty"].Value);
                gridmain.Rows[rowindex].Cells["clnfree"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnfree"].Value);
               // gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                gridmain.Rows[rowindex].Cells["clntax"].Value =_Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clntax"].Value);
                gridmain.Rows[rowindex].Cells["clnprate"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnprate"].Value);
                gridmain.Rows[rowindex].Cells["clnwholesale"].Value =_Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnwholesale"].Value);
               //gridmain.Rows[rowindex].Cells["clncrate"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clncrate"].Value);



                //gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
               // gridmain.Rows[rowindex].Cells["clnsrateperc"].Value = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrateperc"].Value);



                //double crate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clncrate"].Value);

                ////gridmain.Rows[rowindex].Cells["clncrate"].Value = crate;

                //double profit = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrateperc"].Value);


                //gridmain.Rows[rowindex].Cells["clnsrateperc"].Value = profit; 

                //double ansr = (crate * profit) / 100;
                //double srate = crate + ansr;
                //gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.znlldoubletoobject(srate);





               //salerate();

               //gridmain.Rows[rowindex].Cells["clnsrateperc"].Value = _Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnsrateperc"].Value);
                CalculateSrate();
                CalculateMrp();
                gridmain.Rows[rowindex].Cells["clnexciseduty"].Value =_Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnexciseduty"].Value);

                double Free = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                double Qty = Convert.ToDouble(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value));
                ExciseDuty = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnexciseduty"].Value);
                double TQtyAdd = Qty + Free;
                double TQtyLess = Qty - Free;
                double Rate = Convert.ToDouble(_Dbtask.SetintoDecimalpoint(Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnprate"].Value)));
                DiscAmt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                Billdiscinv = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnbilldiscount"].Value);
                double AddRate;
                //if (SUnit == true)
                //{
                //    AddRate = Rate * (Convrt * Qty);
                //}
                //else
                //{
                    AddRate = Rate * Qty;
                //}
                Gross = AddRate - DiscAmt - Billdiscinv;
                Gross = Gross + ExciseDuty;
                NetAmount = Gross;
                gridmain.Rows[rowindex].Cells["Clngross"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Gross));
                TaxCalcPart();
                //CRate = Gross / TQtyAdd;
                //double taxamts = 0;
                //taxamts = _Dbtask.znlldoubletoobject(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clntax"].Value)));
                //CRate = 0;
                //CRate = (Rate + (taxamts / Qty));
                //gridmain.Rows[rowindex].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(CRate));

                double taxamts = 0;
                taxamts = _Dbtask.znlldoubletoobject(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clntax"].Value)));
                CRate = 0;
                if (_Dbtask.znllString(CommonClass._Itemmaster.SpecificField(ItemId, "incp")) == "-1")
                {
                    CRate = (Rate + (taxamts / Qty));
                }
                else
                {
                    CRate = Rate;
                }

                gridmain.Rows[rowindex].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(CRate));



                //gridmain.Rows[rowindex].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(CRate);
                gridmain.Rows[rowindex].Cells["Clngross"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Gross));
                if (SBatch == true)
                {

                    string Bcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                    object Bid = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Tag);
                    //if (Bcode == "" || Bid == null)
                    //{
                    //}
                        //NetAmount = 0;
                }
                gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetAmount)); /* For Cell Net Amount*/
            }
            catch
            {
                gridmain.Rows[rowindex].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(0);
            }
        }

        public void TaxCalcPart()
        {

            TaxAmt = 0;
            TaxPerc = 0;
            try
            {
                if (STax == true)
                {
                    if (Retrivemode == 0)
                    {
                        if (ComTax.Text != "None")
                        {
                            if (ComTax.Text == "VAT")
                            {
                                if (ItemId != null && ItemId != "" && ItemId != "0")
                                {
                                    TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select PurTax from tblitemmaster where itemid='" + ItemId + "'"));
                                }
                                TaxAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clngross"].Value) * TaxPerc / 100;
                            }
                            if (ComTax.Text == "CST")
                            {
                                TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select CST from tblitemmaster where itemid='" + ItemId + "'"));
                                TaxAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clngross"].Value) * TaxPerc / 100;
                            }
                            if (ComTax.Text == "Tax on MRP")
                            {
                                TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select PurTax from tblitemmaster where itemid='" + ItemId + "'"));
                                TaxAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnmrp"].Value) * Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value) * TaxPerc / 100;
                            }
                            if (_Dbtask.znllString(CommonClass._Itemmaster.SpecificField(ItemId, "incp")) == "1")
                            {
                                
                                    double tempTaxPerc = 100 + TaxPerc;
                                    TaxAmt = NetAmount * TaxPerc / tempTaxPerc;
                                    Gross = NetAmount - TaxAmt;
                             
                            }
                            else
                            {
                                NetAmount = NetAmount + TaxAmt;
                            }

                        }

                        gridmain.Rows[rowindex].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(TaxPerc);
                        gridmain.Rows[rowindex].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(TaxAmt);

                    }
                }
            }
            catch
            {
            }
        }
        public void ProductGridShowLocationSett()
        {
            uscGridshow2.Left = TxtProduct.Left;

            uscGridshow2.Top = TxtProduct.Top + TxtProduct.Height + 32;
        }
        public void ConvertNullToZero()
        {
            Txtemployeeamt.Text = (_Dbtask.znullDouble(Txtemployeeamt.Text)).ToString();
            TxtAgentAmt.Text = (_Dbtask.znullDouble(TxtAgentAmt.Text)).ToString();
        }
        public void ItemCrateCalculate()
        {
            double x;
            double xInvoiceDiscount = _Dbtask.znullDouble(Txtcashdiscount.textBox1.Text);
            double xCooly = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
            double xx = xCooly - xInvoiceDiscount;
            double xnetAmt = _Dbtask.znullDouble(txtbillamount.Text) - xx;


            for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
            {
                if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                {
                    double TNetAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                    double xPerc = TNetAmt * 100 / xnetAmt;
                    double xGross = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value);
                    double xQty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                    double xfree = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnfree"].Value);
                    double xTqty = xQty + xfree;
                    double XtCrate = TNetAmt / xTqty;
                    double PercAmt = XtCrate * xPerc / 100;
                    double XPerAmt = xx * xPerc / 100;
                    double XxtCrate = XPerAmt / xTqty;
                    double Xcrate = XtCrate + XxtCrate;
                    gridmain.Rows[i].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(Xcrate);
                }
            }

        }
        public void TottalAmountCalculate()
        {
            try
            {
                ConvertNullToZero();
                if (gridmain.Rows.Count > 1)
                {
                    gridmain.Rows[rowindex].Cells["ClnSlno"].Value = rowindex + 1; /* For SlNo*/
                    NetTottal = 0;
                    NetQty = 0;
                    NetitemDiscou = 0;
                    NetFree = 0;
                    NetTax = 0;
                    NetGross = 0;
                    NetCRate = 0;
                    NetAmount = 0;
                    NetItemdiscount = 0;
                    for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                        {
                            double TNetAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                            double TQty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                            double TPrate = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnprate"].Value);
                            double Tcrate;
                            double ItemDiscount = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value);
                            double GRSSMT = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value);
                            NetTottal = _Dbtask.znlldoubletoobject(NetTottal) + TNetAmt;
                            NetAmount = NetAmount + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value);
                            NetGross = NetGross + TPrate * TQty;
                            NetQty = NetQty + TQty;
                            NetitemDiscou = NetitemDiscou + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value);
                            NetFree = NetFree + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnfree"].Value);

                            NetTax = NetTax + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnTax"].Value);
                            Tcrate = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clncrate"].Value);
                            NetItemdiscount = NetItemdiscount + ItemDiscount;
                            //gridmain.Rows[i].Cells["clncrate"].Value = _Dbtask.SetintoDecimalpoint(Tcrate);
                            NetCRate = NetCRate + Tcrate;

                        }
                    }

                    double InvoiceDisc = _Dbtask.znullDouble(Txtcashdiscount.textBox1.Text);
                    double discpercntging = 0;
                    if (InvoiceDisc>0)
                    {

                        discpercntging = (InvoiceDisc * 100) / (_Dbtask.znlldoubletoobject(NetTottal));

                        discpercntging = _Dbtask.znlldoubletoobject(_Dbtask.SetintoDecimalpoint(discpercntging));
                    }
                    TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(discpercntging);


                    double CoolyAmt = _Dbtask.znullDouble(txtotherexpenses.textBox1.Text);
                    double TNetdiscou = NetitemDiscou + InvoiceDisc;
                    TxttItemDiscount.Text = _Dbtask.SetintoDecimalpoint(NetitemDiscou);
                    NetTottal = NetTottal + CoolyAmt;
                    NetTottal = NetTottal - InvoiceDisc;
                    if (roundof != 0)
                    {
                        txtbillamount.Text = _Dbtask.SetintoDecimalpoint(roundof);
                    }
                    else
                    {
                        txtbillamount.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetTottal));
                    }
                    txttqty.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetQty));

                    TxtTAmount.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetTottal));

                    TxtTGross.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetAmount));

                    TxtTFree.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetFree));
                    TxtTDiscount.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(TNetdiscou));
                    txtttax.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetTax));
                    Txttcrate.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(NetCRate));
                    TxtAgentAmt.Text = (_Dbtask.znullDouble(TxtAgentAmt.Text)).ToString();
                    Txtemployeeamt.Text = (_Dbtask.znullDouble(Txtemployeeamt.Text)).ToString();
                    TxttItemDiscount.Text = _Dbtask.SetintoDecimalpoint(NetItemdiscount);

                   // TxtTGross.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(NetAmount) - Convert.ToDouble(NetTax));
                    if (ComAgent.Text != "" && EditMode == false)
                    {
                        TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select commision from tblaccountledger where lid='" + TxtAccount.textBox1.Tag + "'");
                        if (Convert.ToDouble(TxtAgentAmt.Text) == 0)
                        {
                            TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select AgentCommision from tblitemmaster where itemid='" + ItemId + "'");
                        }
                        AgentAmt = NetTottal * _Dbtask.znullDouble(TxtAgentAmt.Text) / Convert.ToDouble(100);
                        TxtAgentAmt.Text = AgentAmt.ToString();
                    }
                    if (Comemployee.Text != "" && EditMode == false)
                    {
                        Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select commi from Tblemployeemaster where Empid='" + Comemployee.SelectedValue + "'");
                        StaffAmt = NetTottal * _Dbtask.znullDouble(Txtemployeeamt.Text) / Convert.ToDouble(100);
                        Txtemployeeamt.Text = StaffAmt.ToString();
                    }
                    //ItemCrateCalculate();
                }
            }
            catch
            {
            }
        }
        public void ProductIntoMainGrid()
        {
            selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
            _Ingrid.ProductIntoMainGrid(gridmain, uscGridshow2.GridProductShow, selectedRow, rowindex, "Clnprate", "Clnprates");
            ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
            if (Smrate == true)
            {
                try
                {

                    if (SBatch == false)
                    {
                        Sratesecondery = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select  isnull(sum(rate),0) from tblproductrate where pcode='" + ItemId + "'"));
                    }
                    else
                    {

                    }
                    gridmain.Rows[rowindex].Cells["clnwholesale"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);

                }
                catch
                {
                }
            }
        }
        public void ControleSettEnter(Control Cnt)
        {
            _Ingrid.ControleSettEnter(Cnt, gridmain);
        }

        private bool RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (SSaveZeroRate == false)
                    {
                       
                        if (_Dbtask.znllString( gridmain.Rows[i].Cells["clnitemname"].Tag )!= "" && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value)> 0)
                            {

                                if (frstiboolP == false)
                                {
                                    frstivalP = i;
                                    frstiboolP = true;
                                }
                                gridmain.Rows[i].Tag = 1;

                                if (SBatch == true)
                                {
                                    if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value) == "")
                                    {
                                        MessageBox.Show("Barcode is empty .Line number = " + (i + 1).ToString());
                                        return false;


                                    }
                                    if (_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value)<= 0 )
                                    {
                                        MessageBox.Show("Check Amount Line number = " + (i + 1).ToString());
                                        return false;

                                    }
                                }


                            }
                            else
                            {

                                if (_Dbtask.znllString( gridmain.Rows[i].Cells["clnitemname"].Tag) != ""&& _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) <= 0)
                                {
                                    //gridmain.Rows[i].Tag = -1;
                                    MessageBox.Show("Check Amount Line number = " + (i + 1).ToString());
                                    return false;

                                }
                                if (_Dbtask.znllString(  gridmain.Rows[i].Cells["clnitemname"].Tag) != "" && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) > 10000000)
                                {

                                   // gridmain.Rows[i].Tag = -1;
                                    MessageBox.Show("Check Amount Line number = " + (i + 1).ToString());
                                    return false;

                                }
                                if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Tag) == "" && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) >0)
                                {
                                    MessageBox.Show("This barcode not existing .Line number = " + (i + 1).ToString());

                                    gridmain.Rows[i].Tag = -1;

                                }


                                gridmain.Rows[i].Tag = -1;

                                
                            }
                        
                    }
                    else
                    {
                        

                        if (gridmain.Rows[i].Cells["clnitemname"].Tag != null)
                        {

                            if (frstiboolP == false)
                            {
                                frstivalP = i;
                                frstiboolP = true;
                            }


                            gridmain.Rows[i].Tag = 1;
                        }
                        else
                        {
                            gridmain.Rows[i].Tag = -1;
                        }
                        
                    }
                }

                frstiboolP = false;
                
                //Registration = _Nextg.NextgRegistration();
            }
            catch
            {
            }
            return true;
        }


        private void ComMultiUnit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Rows[rowindex].Cells["clnunit"].Tag = ComMultiUnit.SelectedValue;
                gridmain.Rows[rowindex].Cells["clnunit"].Value = ComMultiUnit.SelectedText;

            }
        }

        private void ComMultiRate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                gridmain.Rows[rowindex].Cells["ClnMRate"].Tag = ComMultiRate.SelectedValue;
                gridmain.Rows[rowindex].Cells["ClnMRate"].Value = ComMultiRate.SelectedText;
            }
        }

        private void TxtProduct_Click(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ColumnName = gridmain.Columns[columnindex].Name;
            if (ColumnName == "ClnMRP" || ColumnName == "clnsrate" || ColumnName == "clndiscount" || ColumnName == "ClnDiscPer" || ColumnName == "clnTax" || ColumnName == "clnprate")
            {
                Generalfunction.allowNumeric(sender, e, false);
            }
            if (ColumnName == "clnqty" || ColumnName == "clnfree")
            {
                Generalfunction.allowNumeric(sender, e, true);
            }
            if (gridmain.Rows[rowindex].Cells[columnindex].Value == null)
            {
                gridmain.Rows[rowindex].Cells[columnindex].Value = "0";
            }
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
                                                        {

           gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
           if (e.KeyValue == 113 && ItemId != null) /*For F2  Delete Rows */
           {
               try
               {
                   int selectedIndex = gridmain.CurrentCell.RowIndex;
                   if (selectedIndex > -1)
                   {
                       gridmain.Rows.RemoveAt(selectedIndex);
                       TottalAmountCalculate();
                   }
               }
               catch (InvalidOperationException ex)
               {
                   MessageBox.Show("Unable to remove selected row at this time");
               }
           }

           if (Columnname == "clnqty" || Columnname == "clnprate" || Columnname == "clnsrate" || Columnname == "ClnDiscPer" || Columnname == "clndiscount" || Columnname == "clnfree" || Columnname == "clnsrate")
           {

               string bbatch = ""; double values = 0;
               bbatch = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);

               if (_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells[Columnname].Value) > 1000000)
               {
                   //values = _Dbtask.znlldoubletoobject(Checkinvalid(_Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value), Columnname, bbatch));
                   gridmain.Rows[rowindex].Cells[Columnname].Value = 0;
                   gridmain.Rows[rowindex].Cells["ClnDiscPer"].Value = 0;
                   gridmain.Rows[rowindex].Cells["clnnettamount"].Value = 0;
                   gridmain.Rows[rowindex].Cells["clntax"].Value = 0;
                   gridmain.Rows[rowindex].Cells["ClnGross"].Value = 0;
                   gridmain.Rows[rowindex].Cells["clncrate"].Value = 0;
               }

              // gridmain.NotifyCurrentCellDirty(false);



           }




           if (e.KeyValue == 114 && ItemId != null) /*For F3  Insert Rows */
           {
               gridmain.Rows.Insert(rowindex, 1);
               _Gen.SlSetfunction(gridmain, "clnslno");
           }

           if (Columnname == "ClnUnit")
           {
               //Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");
               CommonClass._commenevent.UpDowninGridList(Gridbatchlist, e.KeyValue, gridmain);
               //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
               //{
               //    if (e.KeyValue == 13 && Gridbatchlist.SelectedRows.Count > 0)
               //    {
               int select = Gridbatchlist.SelectedRows[0].Index;
               UnitName = Gridbatchlist.Rows[select].Cells[0].Value.ToString();

               Unitid = Gridbatchlist.Rows[select].Cells[0].Tag.ToString();
               gridmain.Rows[rowindex].Cells["clnprate"].Value = _Dbtask.ExecuteScalar("select prate from tblunitsrates where uid='" + Unitid + "' and itemid='" + ItemId + "'");
               gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.ExecuteScalar("select srate from tblunitsrates where uid='" + Unitid + "' and itemid='" + ItemId + "'");
               gridmain.Rows[rowindex].Cells["clnmrp"].Value = _Dbtask.ExecuteScalar("select mrp from tblunitsrates where uid='" + Unitid + "' and itemid='" + ItemId + "'");

               //        if (Ds.Tables[0].Rows.Count > 0)
               //        {
               //            SecUnit = Ds.Tables[0].Rows[i]["Unit2"].ToString();
               //            FirUnit = Ds.Tables[0].Rows[i]["Unit"].ToString();
               //            Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount1"].ToString());
               //            UnitAmount2 = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["UnitAmount2"].ToString());
               //            if (UnitName == SecUnit)
               //            {
               //                Convrt = Unitamount1;
               //            }
               //            if (UnitName == FirUnit)
               //            {
               //                Convrt = Unitamount1 * UnitAmount2;
               //            }

               //        }
               //        Gridbatchlist.Visible = false;
               //    }
               //    
               //}
               UnitAmountCalc();
               CellEnterCalculationPart();
               TottalAmountCalculate();
           }

           if (Columnname == "clnbatch")
           {
               CommonClass._commenevent.UpDowninGridList(Gridbatchlist, e.KeyValue, gridmain);
               if (e.KeyValue == 13 && Gridbatchlist.SelectedRows.Count > 0)
               {
                   Batchcode = Gridbatchlist.Rows[Gridbatchlist.SelectedRows[0].Index].Cells[0].Value.ToString();
                   IsinBatchList = true;
                   temp = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                   if (Batchcode == "(Auto Batch)" && temp == "")
                   {
                       gridmain.Rows[rowindex].Cells["clnbatch"].Value = "";
                       Getbatchcode();
                   }
                   else if (Batchcode == "(Auto Batch)")
                   {
                       //Batchcode=Batchcode
                   }
                   else
                   {
                       gridmain.Rows[rowindex].Cells["clnbatch"].Value = "";
                       Getbatchcode();
                       gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batchcode;

                   }
                   Batchcode = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                   Gridbatchlist.Visible = false;
               }
           }
           if (e.KeyValue == 114)
           {

               if (clnsrateperc.Visible == false)
               {
                   clnsrateperc.Visible = true;
                   clnsrateperc1.Visible = true;
               }

               else
               {
                   clnsrateperc.Visible = false;
                   clnsrateperc1.Visible = false;
               }
           }

           if (Columnname == "clnitemcode")
           {
               gridmain.Rows[rowindex].Cells["clnitemcode"].Value = (sender as TextBox).Text;
               if (ItemId == "")
                   ItemId = "0";

               _Ingrid.PreviewKeyDownInGrid(e.KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, IsEnter, (sender as TextBox).Text, Convert.ToInt64(ItemId), rowindex, columnindex, "Clnprate", "prate", Stockareaid);
               uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

               if (SUnit == true)
               {
                   Unitid = CommonClass._Unitcreation.Getunitofitem(ItemId);
                   gridmain.Rows[rowindex].Cells["ClnUnit"].Tag = Unitid;
                   gridmain.Rows[rowindex].Cells["ClnUnit"].Value = CommonClass._Unitcreation.Getspesificfield("name", Unitid.ToString());
                   Convrt = _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", ItemId));
                   //Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");

                   //if (Ds.Tables[0].Rows.Count > 0)
                   //{
                   //    SecUnit = Ds.Tables[0].Rows[0]["Unit2"].ToString();
                   //    Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["UnitAmount1"].ToString());
                   //    gridmain.Rows[rowindex].Cells["ClnUnit"].Value = SecUnit;
                   //    Convrt = Unitamount1;
                   //}

               }
               else
               {
                   Unitid = CommonClass._Unitcreation.Getunitofitem(ItemId);

                   if (Unitid == "" || Unitid == "0")
                   {
                       Unitid = "1";
                   }
                   gridmain.Rows[rowindex].Cells["ClnUnit"].Tag = Unitid;
                   gridmain.Rows[rowindex].Cells["ClnUnit"].Value = CommonClass._Unitcreation.Getspesificfield("name", Unitid.ToString());
               }

               if (e.KeyValue == 13)
               {
                   if (gridmain.Rows[rowindex].Cells["ClnItemName"].Tag != null)
                   {

                       ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                       IsEnter = false;
                       (sender as TextBox).Text = gridmain.Rows[rowindex].Cells["clnitemcode"].Value.ToString();

                       uscGridshow2.Visible = false;
                       if (Smrate == true)
                       {
                           Ds2 = _Dbtask.ExecuteQuery("select rate from tblproductrate where pcode='" + ItemId + "' ");
                           if (Ds2.Tables[0].Rows.Count > 0)
                           {
                               int TblCount = Ds2.Tables[0].Rows.Count;
                               double TWrate = _Dbtask.znullDouble(Ds2.Tables[0].Rows[TblCount - 1]["rate"].ToString());
                               gridmain.Rows[rowindex].Cells["clnwholesale"].Value = _Dbtask.SetintoDecimalpoint(TWrate);
                           }
                       }
                       if (SearchBarcode == true)
                       {
                           int NowselectedRow;
                           string TempBathcode;
                           NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                       }
                       txtstockbyid.Text = "";
                     txtstockbyid.Text =_Dbtask.znllString(_Dbtask.znlldoubletoobject(_Inventory.GetStock(" where pcode='" + ItemId + "' ")));



                   }
                   gridmain.Rows.Add(1);
               }


               if (e.KeyValue == 27)
               {
                   if (uscGridshow2.Visible == true)
                   {
                       uscGridshow2.Visible = false;
                   }
                   if (Pnlsizes.Visible == true)
                   {
                       Pnlsizes.Visible = false;
                   }
               }
               if (e.KeyValue == 113 && ItemId != null) /*For F2  Delete Rows */
               {
                   try
                   {
                       int selectedIndex = gridmain.CurrentCell.RowIndex;
                       if (selectedIndex > -1)
                       {
                           gridmain.Rows.RemoveAt(selectedIndex);
                       }
                   }
                   catch (InvalidOperationException ex)
                   {
                       MessageBox.Show("Unable to remove selected row at this time");
                   }
               }


               if (e.KeyValue == 117 && ItemId != null) /*For F6*/
               {
                   StringTemp = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
                   Ds = _ReceiptDetails.ShowAccountsSales(" where issuetype='PI' and ledcodeCr= " + TxtAccount.textBox1.Tag.ToString() + "", StringTemp, TxtAccount.textBox1.Tag.ToString());
                   DatagridSalesHistory.Rows.Clear();
                   for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                   {
                       DatagridSalesHistory.Rows.Add(1);
                       DatagridSalesHistory.Rows[i].Cells["clnvnoh"].Value = _Dbtask.ExecuteScalar("select vno from Tblbusinessissue where issuetype='Si' and IssueCode='" + Ds.Tables[0].Rows[i]["IssueCode"] + "'");
                       DatagridSalesHistory.Rows[i].Cells["clndateh"].Value = _Dbtask.ExecuteScalar("select IssueDate from Tblbusinessissue where issuetype='Si' and IssueCode='" + Ds.Tables[0].Rows[i]["IssueCode"] + "'");
                       DatagridSalesHistory.Rows[i].Cells["clnqtyh"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"]));
                       DatagridSalesHistory.Rows[i].Cells["clnfreeh"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(Ds.Tables[0].Rows[i]["freeQty"]));
                       DatagridSalesHistory.Rows[i].Cells["clnrateh"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"]));
                       DatagridSalesHistory.Rows[i].Cells["clndisch"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"]));
                       DatagridSalesHistory.Rows[i].Cells["clnnetH"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"]));
                   }
                   PnlSalesHistory.Visible = true;
                   DatagridSalesHistory.Rows[0].Selected = false;
               }
               else
               {
                   PnlSalesHistory.Visible = false;
               }
           }
        }

        private void CompurchaseAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Comemployee.Focus();
            }
        }

  

        private void TxtRefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GridSelect();
            }
        }

        public void WrateCalculateinBatch()
        {
            if (Smrate == true)
            {
                string tempbatch = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                double Sratesecondery = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select  isnull(sum(rate),0) from tblproductrate where pcode='" + ItemId + "' and batchid='" + Batch + "'"));
                gridmain.Rows[rowindex].Cells["clnwholesale"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);
            }
        }

        public string BarcodeBackValue(string Value)
        {
            if (Value.Length == 1)
                Value = "00" + Value;
            else if (Value.Length == 2)
                Value = "0" + Value;
            return Value;
        }

        //public void Getbatchcode()
        //{
        //    try
        //    {
        //        if (SBatch == true && SearchBarcode == false)
        //        {
        //            if (Retrivemode == 0)
        //            {
        //                if (_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) == "")
        //                {
        //                    if (rowindex == 0 || EditMode == true)
        //                    {
        //                        if (rowindex != 0)
        //                        {
        //                            if (EditMode == true && gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag != null && gridmain.Rows[rowindex].Cells["clnbatch"].Tag == null)
        //                            {
        //                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();
        //                                gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
        //                                gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
        //                            }
        //                            else
        //                            {
        //                                if (Convert.ToDouble(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) != 0)
        //                                {
        //                                    gridmain.Rows[rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) + 1;
                                            
        //                                    string BackValue = BarcodeBackValue(gridmain.Rows[rowindex].Cells["clnbatch"].Tag.ToString());

        //                                    Batch = _Batch.Batchstring + BackValue;
        //                                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batch;
        //                                    gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
        //                                }
        //                                else
        //                                {
        //                                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();
        //                                    gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
        //                                    gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();
        //                            gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
                                  
        //                            gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        gridmain.Rows[rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) + 1;

        //                        Batch = (gridmain.Rows[rowindex].Cells["clnbatch"].Tag).ToString();
        //                        Batch = _Batch.Batchstring + _Batch.BatchcodeSpecified(Batch);
        //                        gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batch;
                                
        //                        //if(gridmain.Rows[rowindex + 1].
        //                        gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;

        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}
        public void Getbatchcode()
        {
            try
            {
                if (SBatch == true && SearchBarcode == false)
                {
                    if (Retrivemode == 0)
                    {

                        if (_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) == "")
                        {
                            if (rowindex == 0 || EditMode == true)
                            {
                                if (rowindex != 0)
                                {
                                    if (EditMode == true && gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag != null && gridmain.Rows[rowindex].Cells["clnbatch"].Tag == null)
                                    {
                                        gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();

                                        if (_Batch.BarcodeShowSingle(ItemId) != "" && Singlebarcode == true)
                                        {
                                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BarcodeShowSingle(ItemId);
                                        }

                                        gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
                                        gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
                                    }
                                    else
                                    {
                                        if (_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) != 0)
                                        {
                                            gridmain.Rows[rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) + 1;

                                            string BackValue = BarcodeBackValue(gridmain.Rows[rowindex].Cells["clnbatch"].Tag.ToString());

                                            Batch = _Batch.Batchstring + BackValue;
                                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batch;

                                            if (_Batch.BarcodeShowSingle(ItemId) != "" && Singlebarcode == true)
                                            {
                                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BarcodeShowSingle(ItemId);
                                            }

                                            gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
                                        }
                                        else
                                        {
                                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();

                                            if (_Batch.BarcodeShowSingle(ItemId) != "" && Singlebarcode == true)
                                            {
                                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BarcodeShowSingle(ItemId);
                                            }

                                            gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
                                            gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
                                        }
                                    }
                                }
                                else
                                {
                                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BatchMax();

                                    if (_Batch.BarcodeShowSingle(ItemId) != "" && Singlebarcode == true)
                                    {
                                        gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BarcodeShowSingle(ItemId);
                                    }

                                    gridmain.Rows[rowindex].Cells["clnbatch"].Tag = _Batch.MaxBatchcode;
                                    gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;
                                }
                            }
                            else
                            {
                                gridmain.Rows[rowindex].Cells["clnbatch"].Tag = Convert.ToDouble(gridmain.Rows[rowindex - 1].Cells["clnbatch"].Tag) + 1;

                                Batch = (gridmain.Rows[rowindex].Cells["clnbatch"].Tag).ToString();
                                Batch = _Batch.Batchstring + _Batch.BatchcodeSpecified(Batch);



                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batch;

                                if (_Batch.BarcodeShowSingle(ItemId) != "" && Singlebarcode == true)
                                {
                                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = _Batch.BarcodeShowSingle(ItemId);
                                }

                                //if(gridmain.Rows[rowindex + 1].
                                gridmain.Rows[rowindex + 1].Cells["clnbatch"].Tag = 1;

                            }

                        }

                    }
                }
            }
            catch
            {
            }
        }



        void txt_TextChanged(object sender, EventArgs e)
                {
            {
                try
                {


                    gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;
                    string Temp = gridmain.Rows[rowindex].Cells[columnindex].Value.ToString();


                    //if (Columnname == "clnqty" || Columnname == "clnprate" || Columnname == "clnsrate" || Columnname == "ClnDiscPer" || Columnname == "clndiscount" || Columnname == "clnfree" || Columnname == "clnsrate")
                    //{

                    //    string bbatch = ""; double values = 0;
                    //    bbatch = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);

                    //    if (_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells[Columnname].Value) > 1000000)
                    //    {
                    //        //values = _Dbtask.znlldoubletoobject(Checkinvalid(_Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value), Columnname, bbatch));
                    //        gridmain.Rows[rowindex].Cells[Columnname].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["ClnDiscPer"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["clnnettamount"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["clntax"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["ClnGross"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["clncrate"].Value = 0;
                    //    }

                    //    gridmain.NotifyCurrentCellDirty(false);



                    //}


                    if (Columnname == "ClnGross" && EditgrossAmt == true)
                    {
                        double tempgross = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["ClnGross"].Value);
                        double tempqty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        double tempdiscamt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                        double temprate = tempgross / tempqty;
                        temprate = temprate - tempdiscamt;
                        gridmain.Rows[rowindex].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(temprate);
                    }

                    if (gridmain.Columns[columnindex].Name == "clnitemcode" && IsEnter == true)
                    {
                        _usc2.Passingusercontrole(gridmain, "Clnprate", "prate", rowindex, columnindex, uscGridshow2, false);
                        temp = (sender as TextBox).Text;

                        //if(SBatch==true)
                        // ProductGridShowWithBatch("where  TblItemMaster.itemCode Like '%" + Temp + "%' OR  TblItemMaster.ItemName Like '%" + Temp + "%' or Tblbatch.bcode like '%" + Temp + "%'"); 
                        //else
                        ProductGridShow(temp);
                        uscGridshow2.lblstock.Visible = true;
                        uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

                    }

                    if (gridmain.Columns[columnindex].Name == "clndiscount")
                    {
                        Templedouble = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnprate"].Value) * Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        gridmain.Rows[rowindex].Cells["clndiscper"].Value = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clndiscount"].Value) * 100 / Templedouble;
                        if (gridmain.Rows[rowindex].Cells["clndiscper"].Value == null)
                        {
                            gridmain.Rows[rowindex].Cells["clndiscper"].Value = 0;
                        }
                    }

                    if (gridmain.Columns[columnindex].Name == "clnexperc")
                    {
                        Templedouble = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnprate"].Value) * Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        gridmain.Rows[rowindex].Cells["clnexciseduty"].Value = _Dbtask.SetintoDecimalpoint(Templedouble * _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnexperc"].Value) / 100);
                        if (gridmain.Rows[rowindex].Cells["clnexciseduty"].Value == null)
                        {
                            gridmain.Rows[rowindex].Cells["clnexciseduty"].Value = 0;
                        }
                        ComTextChange();
                    }

                    if (gridmain.Columns[columnindex].Name == "ClnDiscPer")
                    {
                        Templedouble = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnprate"].Value) * Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);

                        gridmain.Rows[rowindex].Cells["clndiscount"].Value = Templedouble * Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value) / Convert.ToDouble(100);
                        if (gridmain.Rows[rowindex].Cells["clndiscount"].Value == null)
                        {
                            gridmain.Rows[rowindex].Cells["clndiscount"].Value = 0;
                        }
                    }

                    if (Columnname == "clnqty")
                    {
                        if (ShowSubpanel == true)
                        {
                            if (SSsizes == true)
                            {
                                LoadColumn();
                            }
                        }
                    }

                    if (Columnname == "clnbatch")
                    {
                        if (clnbatch.ReadOnly == false)
                        {
                            LoadBatches((sender as TextBox).Text);
                        }
                    }
                    if (Columnname == "ClnUnit")
                    {
                        Gridbatchlist.Visible = true;
                        LoadUnits();
                    }


                    







                }

                catch
                {

                }
                CellEnterCalculationPart();
                TottalAmountCalculate();
            }
        }

        public void LoadUnits()
        {
            Gridbatchlist.Location = new System.Drawing.Point(599, 155);
            Gridbatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Ds2 = CommonClass._Unitcreation.LoadUnit("");
            for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            {
                Gridbatchlist.Rows.Add(1);

                Gridbatchlist.Rows[i].Cells[0].Value = Ds2.Tables[0].Rows[i]["Name"].ToString();
                Gridbatchlist.Rows[i].Cells[0].Tag = Ds2.Tables[0].Rows[i]["Id"].ToString();
            }
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSettGrid(Gridbatchlist, tempRect.Left, tempRect.Top + tempRect.Height + 40 * 3);
            Gridbatchlist.Columns[0].Width = Gridbatchlist.Width - 10;
        }

        public void LoadBatches(string Search)
        {
            Gridbatchlist.CellBorderStyle = DataGridViewCellBorderStyle.None;
            CommonClass._Batch.BatchlistshowBaseonItem(ItemId, Gridbatchlist, Search);
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSettGrid(Gridbatchlist, tempRect.Left, tempRect.Top + tempRect.Height + 29 * 4);
            Gridbatchlist.Columns[0].Width = Gridbatchlist.Width - 10;
        }
        private void CmdGeneral_Click(object sender, EventArgs e)
        {
            PnlGeneral.Visible = true;
            PnlAdvance.Visible = false;
            PnlGeneral.Dock = System.Windows.Forms.DockStyle.Top;
        }

        private void CmdAdvance_Click(object sender, EventArgs e)
        {
            PnlAdvance.Visible = true;
            PnlGeneral.Visible = false;
            PnlAdvance.Dock = System.Windows.Forms.DockStyle.Top;

        }

        private void CmdPrintOption_Click(object sender, EventArgs e)
        {
            PnlAdvance.Visible = false;
            PnlGeneral.Visible = false;
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
            if (Vtype == "PI" || Vtype == "PO")
            {
                _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where RecptCode='" + txtvno.Tag + "' and Ledcode='" + PurchaseAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where Reptcode='" + txtvno.Tag + "' and vno='" + txtvno.Text + "' and Recpttype='" + Vtype + "' and LedcodeDr='" + PurchaseAccount + "' ");

                if (Vtype == "PI")
                {
                    if (SSlnotracking == true)
                    {
                        _Dbtask.ExecuteNonQuery("delete from tblslnotracking where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");

                    }

                    _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Tag + "' and Ledcode='" + PurchaseAccount + "' and Purchase !=0");
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and refno='" + PurchaseAccount.ToString() + "'");
                    /*For Batch */
                    /*For Agent*/
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='" + agentid + "' and Refno='" + PurchaseAccount + "'");
                    /*For Employee*/
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='" + StaffId + "' and Refno='" + PurchaseAccount + "'");

                    /*For Discount*/
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='6' and Refno='" + PurchaseAccount + "'");
                    /*For VAT*/
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='8' and Refno='" + PurchaseAccount + "'");
                    /*For CST*/
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='25' and Refno='" + PurchaseAccount + "'");

                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='PI' and vno='" + txtvno.Text + "' and Ledcode='10' and Refno='" + PurchaseAccount + "'");


                    _Dbtask.ExecuteNonQuery("delete from tblpurchasebillsett where vtype='PI' and vno='" + txtvno.Text + "' ");


                    
                    Ds = _Dbtask.ExecuteQuery("select * FROM TBLGENERALLEDGER where vtype='P' and slno='" + txtvno.Text + "'  and refno='" + PurchaseAccount + "' ");

                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        _Dbtask.ExecuteNonQuery("delete FROM TBLGENERALLEDGER where vtype='P' and slno=" + txtvno.Text + " " +
                        " and refno='" + PurchaseAccount + "' ");

                       txtreceivedamt.Text = "";

                    }





                }
            }
            else if (Vtype == "PR")
            {
                string tempinvvty = "PR";

                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Tag + "' and " + tempinvvty + " !=0 and ledcode='" + PurchaseAccount + "'");
                _Dbtask.ExecuteNonQuery("delete from tblissuedetails where issuecode='" + txtvno.Tag + "' and Ledcode='" + PurchaseAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Refno='" + PurchaseAccount + "'");

                _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where issuecode='" + txtvno.Tag + "' and vno='" + txtvno.Text + "' and issuetype='" + Vtype + "' and Ledcodecr='" + PurchaseAccount + "'");

                /*For Agent*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + agentid + "' and Refno='" + PurchaseAccount + "'");
                /*For Employee*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + StaffId + "' and Refno='" + PurchaseAccount + "'");

                /*For Other Expense*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='26' and Refno='" + PurchaseAccount + "'");
                /*For Discount*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='7' and Refno='" + PurchaseAccount + "'");
                /*For Tax*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='9' and Refno='" + PurchaseAccount + "'");
                /*For CST*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='24' and Refno='" + PurchaseAccount + "'");

                _Dbtask.ExecuteNonQuery("delete from tblPRbillsett where vtype='PR' and vno='" + txtvno.Text + "' ");


            
            
            
            }
        }
        private void txtvno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtRefName.Focus();
            }
        }

        private void TxtRefName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtdate.Focus();
            }
        }


        private void ComAccount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComTax.Focus();
            }
        }



        private void ComDepot_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                try
                {
                    gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
                }
                catch
                {
                }
            }

        }

        private void ComDepot_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtAccount.textBox1.Focus();
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            TempClear();
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnindex = gridmain.CurrentCell.ColumnIndex;
                rowindex = gridmain.CurrentCell.RowIndex;
                Columnname = gridmain.Columns[columnindex].Name.ToString();

                if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                }
                //if (Columnname == "clnitemname" && Isitemedit == false)
                //{
                //    SendKeys.Send("{Tab}");
                //}


                ItemId = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Tag);



                if (Columnname == "ClnMRate")
                {
                    ControleSettEnter(ComMultiRate);
                    ComMultiRate.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }

                if (Columnname == "ClnUnit")
                {
                    //ControleSettEnter(ComMultiUnit);
                    //ComMultiUnit.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                }


                if (Columnname == "clnqty" || Columnname == "clnfree")
                {

                }


                if (Columnname == "clnbatch")
                {
                    //if (clnbatch.ReadOnly == true)
                    //{
                    //Getbatchcode();
                    // }

                }

                if (EditgrossAmt == true)
                {
                    if (Columnname == "ClnGross")
                    {
                        gridmain.BeginEdit(true);
                    }
                }
                if (Columnname == "clndiscount" || Columnname == "clnsrate" || Columnname == "ClnDiscPer" || Columnname == "clnprate" || Columnname == "clncrate" || Columnname == "clnbatch" || Columnname == "ClnMRP" || Columnname == "clnfree" || Columnname == "clnqty" || Columnname == "clnwholesale")
                {
                    gridmain.BeginEdit(true);

                }
                if (Columnname == "clnitemcode")
                {
                    IsEnter = true;
                }
                gridmain.NotifyCurrentCellDirty(false);
            }


            catch
            {
            }
        }

        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
                {
                if (gridmain.SelectedCells.Count > 0)
                {
                    columnindex = gridmain.SelectedCells[0].ColumnIndex;
                    rowindex = gridmain.SelectedCells[0].RowIndex;
                    ItemId = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Tag);

                    if (gridmain.Columns[columnindex].Name.ToString() == "clnitemname")
                    {
                        Isitemedit = true;
                    }
                    if (gridmain.Columns[columnindex].Name.ToString() == "clnitemcode")
                    {
                        Isitemedit = false;
                    }

                    if (gridmain.Columns[columnindex].Name.ToString().ToLower() == "clnunit")
                    {
                        if (SUnit == true)
                        {
                            //if (UnitName == FirUnit)
                            //{
                            //    gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName + " " + "(" + Unitamount1 + FirUnit + "=" + UnitAmount2 + SecUnit + ")";
                            //}
                            //else
                            //{
                            //    gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName;
                            //}
                            Gridbatchlist.Visible = false;
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName + "(" + (CommonClass._Unitcreation.Getspesificfield("ucount", Unitid)).ToString() + ")";
                            gridmain.Rows[rowindex].Cells["clnunit"].Tag = Unitid;
                            gridmain.NotifyCurrentCellDirty(false);
                        }
                    }

                    if (gridmain.Columns[columnindex].Name.ToString() == "clnbatch")
                    {

                        if (_Batch.SameNamealreadyexist(Batchcode) == false)
                        {
                            ItemId = "";
                            gridmain.Rows[rowindex].Cells["clnitemname"].Tag = "";

                        }




                        Gridbatchlist.Visible = false;
                        if (IsinBatchList == true)
                        {
                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batchcode;
                            gridmain.NotifyCurrentCellDirty(false);
                            IsinBatchList = false;
                        }
                        WrateCalculateinBatch();
                        Batch = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                        string TempBatch = _Dbtask.ExecuteScalar("select distinct bcode from tblbatch where bcode='" + Batch + "'");
                        string TempItemName = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Value);
                        if (TempBatch != "" || TempItemName == "")
                        {
                            ItemId = _Dbtask.ExecuteScalar("select distinct itemid from tblbatch where bcode='" + Batch + "'");

                            if (_Dbtask.znllString(ItemId) == "")
                            {
                                CommonClass._Forms.ShowSimpleitem(Batch);
                            }
                            if (ItemId != "")
                            {
                                _Purchase.RefillingRow(gridmain, ItemId, rowindex, TempBatch);
                            }
                            CellEnterCalculationPart();
                            gridmain.NotifyCurrentCellDirty(false);
                        }
                        else if (Batch == "")
                        {
                            Getbatchcode();
                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = Batch;
                            gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(0);
                        }
                        else
                        {
                            TempBatch = Batch;
                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = "";
                            Getbatchcode();
                            gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBatch;
                            gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(0);
                        }

                    }

                        //invalid
                        //if (Columnname == "clnqty" || Columnname == "clnprate" || Columnname == "clnsrate")
                        
                        //{

                        //    string bbatch = ""; double values = 0;
                        //     bbatch =_Dbtask.znllString( gridmain.Rows[rowindex].Cells["clnbatch"].Value);

                        //     //
                        //     values =_Dbtask.znlldoubletoobject(Checkinvalid(_Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value),Columnname,bbatch));
                        //     gridmain.Rows[rowindex].Cells[Columnname].Value = 0;
                            
                        //    gridmain.Rows[rowindex].Cells[Columnname].Value = values;
                           
                        //}



                }

                if (Columnname == "clnqty" || Columnname == "clnprate" || Columnname == "clnsrate" || Columnname == "ClnDiscPer" || Columnname == "clndiscount" || Columnname == "clnfree")
                {

                    string bbatch = ""; double values = 0;
                    bbatch = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);

                    //
                    values = _Dbtask.znlldoubletoobject(Checkinvalid(_Dbtask.znllString(gridmain.Rows[rowindex].Cells[Columnname].Value), Columnname, bbatch));
                    gridmain.Rows[rowindex].Cells[Columnname].Value = 0;
                    gridmain.Rows[rowindex].Cells[Columnname].Value = "";
                    gridmain.Rows[rowindex].Cells[Columnname].Value = values;


                    gridmain.NotifyCurrentCellDirty(false);


                
                }



            }
            catch
            {
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

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                if (_UserDetails.Permited() == true)
                {
                    DialogResult Result = MessageBox.Show("Delete ?", "Are you sure want to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {
                        DeleteVoucher();
                        ForLogindetails("DELETE");
                        Clear();
                    }
                }
            }

        }

        private void txtvno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    GetPrevious(Convert.ToInt64(txtvno.Text), true);
                }
            }
            catch
            {
            }
        }

        private void TxtAgentAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
            _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void Txtemployeeamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
            _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void TxtAgentAmt_TextChanged(object sender, EventArgs e)
        {
            TxtAgentAmt.Text = _Gen.avoidnullDecimal(TxtAgentAmt.Text);
        }

        private void Txtemployeeamt_TextChanged(object sender, EventArgs e)
        {
            Txtemployeeamt.Text = _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void Frmpurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F10)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 115)
            {
                FudeleteRow();
            }
        }
        private void TxtcashReceived_TextChanged(object sender, EventArgs e)
        {
            Txtcashpaid.Text = _Gen.avoidnullDecimal(Txtcashpaid.Text);
        }
        private void gridmain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Columnname == "clnitemname")
            {
                if (gridmain.Rows[rowindex].Cells["clnitemname"].Tag != null)
                {
                    //Frmitems _Items = new Frmitems();
                    //Frmitems.Itemid = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
                    //Frmitems.Isinotherwindow = true;
                    //Frmitems.EditMode = true;
                    //_Items.ShowDialog();
                }
                else
                {
                    //Frmitems _Items = new Frmitems();
                    //_Items.ShowDialog();
                }
            }
        }

        private void Frmpurchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Hide();
                this.Parent = null;
                e.Cancel = true;
            }
            catch
            {
            }
        }

        private void dtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                commodeofpayment.Focus();
            }

        }

        private void TxtRefName_Click(object sender, EventArgs e)
        {
            TxtRefName.Focus();
            TxtRefName.Select();
        }

        private void txtvno_Click(object sender, EventArgs e)
        {
            txtvno.Focus();
            txtvno.Select();
        }






        private void TxtAgentAmt_Click(object sender, EventArgs e)
        {
            TxtAgentAmt.Focus();
            TxtAgentAmt.Select();
        }

        private void Txtemployeeamt_Click(object sender, EventArgs e)
        {
            Txtemployeeamt.Focus();
            Txtemployeeamt.Select();
        }



        private void ComTax_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (SDepo == true)
                {
                    ComDepot.Focus();
                }

                else if (STax == false && SDepo == false)
                {
                    try
                    {
                        gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void ComTax_Click(object sender, EventArgs e)
        {
            ComTax.Focus();
            ComTax.Select();
        }

        private void ComDepot_Click(object sender, EventArgs e)
        {
            ComDepot.Focus();
            ComDepot.Select();
        }



        private void commodeofpayment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (STax == true)
                {
                    ComTax.Focus();
                }
                else if (SDepo == true)
                {
                    ComDepot.Focus();
                }
                else
                {
                    TxtAccount.textBox1.Focus();
                }
            }
        }

        private void ComTax_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (SDepo == true)
                {
                    ComDepot.Focus();
                }
                else
                {
                    TxtAccount.textBox1.Focus();
                }
            }
        }

        private void TxtRefName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                dtdate.Focus();
            }
        }

        private void gridmain_Enter(object sender, EventArgs e)
        {
          //  gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
        }
        public void ClearSizeInisilise()
        {
            SizeQty = "0";
            SizeRate = "0";
            SizeNaration = "";
        }
        private void commodeofpayment_Click(object sender, EventArgs e)
        {
            commodeofpayment.Focus();
        }

        private void cmdquickpayment_Click(object sender, EventArgs e)
        {
            showCashpayment();
        }
        public void showCashpayment()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 1;
            // _Cash.MdiParent = this;
            _Cash.ShowDialog();
        }

        public void SizeInitilizePrinting(int ZRowIndex)
        {
            try
            {
                double Rate;
                double Qty;
                string SizeName;
                string ZItemId;
                string Zitemname;
                string TempNextid;
                string TempNextName;



                ZItemId = gridmain.Rows[ZRowIndex].Cells["clnitemname"].Tag.ToString();
                Zitemname = gridmain.Rows[ZRowIndex].Cells["clnitemname"].Value.ToString();
                Qty = _Dbtask.znullDouble(gridmain.Rows[ZRowIndex].Cells["clnqty"].Value.ToString());
                Rate = _Dbtask.znullDouble(gridmain.Rows[ZRowIndex].Cells["clnprate"].Value.ToString());
                SizelessName = _Dbtask.ExecuteScalar("select sizelessname from tblitemmaster where itemid='" + ZItemId + "'");


                SizeName = Zitemname.Replace(SizelessName, "");
                TempNextid = _Dbtask.znllString(gridmain.Rows[ZRowIndex + 1].Cells["clnitemname"].Tag);
                TempNextName = _Dbtask.ExecuteScalar("select sizelessname from tblitemmaster where itemid='" + TempNextid + "'");


                if (TempNextName != "")
                {
                    if (TempNextName != SizelessName)
                    {
                        NextIteminsize = false;
                    }
                    else
                    {
                        NextIteminsize = true;
                    }
                }

                if (NextIteminsize == false)
                {  
                    BackSizelessName = SizelessName;
                }
                if (NextIteminsize == true)
                {
                    SizeRate = Rate.ToString();

                    SizeQty = (Convert.ToDouble(SizeQty) + Convert.ToDouble(Qty)).ToString();
                    SizeItemName = SizelessName;
                    SizeNaration = SizeNaration + "," + SizeName.Replace(" ", "") + "=" + Qty;

                    BackSizelessName = SizelessName;
                    NextIteminsize = true;
                }
                else
                {
                    SizeRate = Rate.ToString();

                    SizeQty = (Convert.ToDouble(SizeQty) + Convert.ToDouble(Qty)).ToString();
                    SizeItemName = SizelessName;
                    SizeNaration = SizeNaration + "," + SizeName.Replace(" ", "") + "=" + Qty;

                    BackSizelessName = SizelessName;

                }
            }
            catch
            {
            }
        }

        public void SettintogapDotmetrix(RichTextBox Rch, string Str, long CRow, int Maxrow)
        {
            for (int i = Convert.ToInt32(CRow); i < Maxrow; i++)
            {
                Rch.Text = Rch.Text + "\n";
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
                    Frmpurchase Frms = new Frmpurchase();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " and " +
                            convert(amount_dec) + " " + Frms._Gen.Getminerymbol();
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
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
        public void PrintSizes(string Invoicename)
        {
            Clssizes _Size = new Clssizes();
            Ds = _Size.ShowSizes();

            string StrVno = txtvno.Text;


            if (Vtype == "PR")
            {
                Taxruletext = ("           THE KERALA VALUE ADDED TAX RULES, 2005FORM 9, [See rule 58(10)]").PadLeft(40, ' ');

            }
            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");

            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.textBox1.Text.Replace("\r\n", " ");

            string Datestr = "Date   : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                               " + Datestr;
            StrVno = "                                                               Inv No :" + txtvno.Text;
            string LineHeading = "=".PadRight(80, '=');
            string LineAbowAmount = "-".PadRight(80, '-');
            string LineFooter = "=".PadRight(80, '=');
            string Slno = "Sl".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(40, ' ');
            string SizesNarration = "            Narration";

            string TsQty = "Qty".PadLeft(9, ' ');
            string TsRate = "Rate".PadLeft(11, ' ');
            string TsAmount = "Amount".PadLeft(15, ' ');

            string TAmountstr = "Amount".PadLeft(15, ' ');
            string TTQty;
            string TTAmount;

            string Custname = TxtAccount.textBox1.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            string CusMob = _Dbtask.ExecuteScalar("select mobile from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");

            RichTextBox1.Text = "" + TIN + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\n" + PInvoiceName + "\n\n" + Datestr + "\n" + StrVno + "\n" + "Customer  :" + Custname + "\nAddress   :" + CusAddress + "\n" + "Mobile    :" + CusMob + "\n" + "TIN       :" + CusTinno + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";

            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            ClearSizeInisilise();
            for (int i = M; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null && TRowCounting < 24)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        string Itemcode = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();

                        SizeInitilizePrinting(i);

                        /*For Get Size Less Id*/
                        string TempSizelessName;
                        string TempSizeName;
                        string TempSizeId;
              

                        if (gridmain.Rows[i + 1].Tag.ToString() == "-1")
                        {
                            NextIteminsize = false;
                        }
                        if (NextIteminsize == false)
                        {
                            k = k + 1;
                            Slno = k.ToString();
                            Slno = Slno.PadRight(4, ' ');

                            Pname = BackSizelessName;

                            Pname = Pname.PadRight(40, ' ');
                            if (Pname.Length > 40)
                                Pname = Pname.Substring(0, 40);

                            double sQty = Convert.ToDouble(SizeQty);
                            TsQty = _Dbtask.SetintoDecimalpointStock(sQty);

                            TsQty = TsQty.PadLeft(9, ' ');

                            double sRate = Convert.ToDouble(SizeRate);
                            TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                            TsRate = TsRate.PadLeft(11, ' ');

                            double sAmount = sRate * sQty;
                            TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                            TsAmount = TsAmount.PadLeft(15, ' ');


                            string Naration = SizeNaration;
                            if (Naration.Length > 0)
                                Naration = Naration.Substring(1, Naration.Length - 1);
                            Naration = "Sizes: " + Naration;
                            string ExtraNaration;


                            TQty = TQty + sQty;
                            TRate = TRate + sRate;
                            TAmount = TAmount + sAmount;

                            string TSamount = TAmount.ToString();

                            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n" + Slno + Pname + TsQty + TsRate + TsAmount + "\n\n" + Naration;

                            ClearSizeInisilise();
                            SizeInitilizePrinting(i);
                            TRowCounting = TRowCounting + 3;
                            M = i;
                            ClearSizeInisilise();
                        }
                    }
                }
                if (gridmain.Rows[i].Tag == null)
                    gridmain.Rows.RemoveAt(i);
            }
            if (M == gridmain.Rows.Count - 2)
            {
                PrintNextpage = false;
            }
            else
            {
                PrintNextpage = true;
                M = M + 1;
            }
            SettintogapDotmetrix(RichTextBox1, " ", TRowCounting, 22);
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(53, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(26, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string OtherizedSignature = "Authorized Signatory".PadLeft(80, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.textBox1.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = Convert.ToDouble(txtbillamount.Text);

                OldBalance = OldBalance - BillAmt;


                currentbalance = OldBalance + BillAmt;

            }
            else if (TxtAccount.textBox1.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.textBox1.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.textBox1.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = Convert.ToDouble(txtbillamount.Text);
                    currentbalance = OldBalance;
                }
            }
            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string TaxAmt = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtttax.Text));
            string TaxableAmt = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxtTGross.Text));
            string Declaration = "Declaration:\n\n" +
                                 "To be furnished by the seller)Certified that all the  particulars shown In the\n" +
                                 "above Tax Invoice are true and correct in all respects and the goods on which the\n " +
                                 "tax charged and collected are in accordance with the provisions of the KERALA ACT\n" +
                                 "2003 and the rules made thereunder.It is also certified that my/our Registration \n" +
                                 "under KERALA Act 2003 is not subject to any suspension/cancellation and it is \n" +
                                 "valid as on the date of this Bill.";

            string BiilDiscount = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Txtcashdiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineAbowAmount +
                "\n" + TTQty + TTAmount + "\n" +
               LineFooter + "\nIn Words: " + AmountinWords + "\n\n                                                     Bill Discount :" + BiilDiscount.PadLeft(12, ' ') + "\n                                                     Taxable Amount:" + TaxableAmt.PadLeft(12, ' ') + "\n                                                     Tax Amount    :" + TaxAmt.PadLeft(12, ' ') + "\n                                                     Total Amount  :" + txtbillamount.Text.PadLeft(12, ' ') + "\n\n\n" + Declaration + "\n\n\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n";

           
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
        }

        public void PrintDotMetrix(bool Isconsole)
        {
            if (ChkShowPreview.Checked == false)
            {
                MyPrinter.Close();
                if (ChkShowPreview.Checked == false)
                {
                    if (Isconsole == true)
                    {
                        if (!MyPrinter.Open("Qplex Print")) return;
                        MyPrinter.Print(Convert.ToChar(15).ToString());
                        MyPrinter.Print(RichTextBox1.Text);
                        MyPrinter.Print(Convert.ToChar(18).ToString());
                    }
                    else
                    {
                        if (!MyPrinter.Open("Qplex Print")) return;
                        MyPrinter.Print(RichTextBox1.Text);
                    }
                }
                MyPrinter.Close();
            }
        }

        public void vouchertyperetailDotmetrix10BrandRoot(string Invoicename)
        {
            MyPrinter.PrinterName = CommonClass._Paramlist.GetParamvalue("SPrintSelect");
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string TelePhone = _Dbtask.ExecuteScalar("select telephone from TblCompanyMaster");
            string AddressTemp = "                                          BAG WORLD&TOYS GALLERY" + "                PH:" + TelePhone;
            //string Bcode=
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string City = "MANJERI";
            string Address = temp;
            string Mobile = "                                               MOBILE :" + _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string CustomerMobile = CommonClass._Ledger.GetSpecificfieldBaseonName(Cusnam, "Mobile");
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string TimeStr = "                                                                       Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                                                                     " + Datestr;
            string LineHeading = "=".PadRight(105, '=');
            string LineAbowAmount = "-".PadRight(105, '-');
            string LineFooter = "=".PadRight(105, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Bcode = "Bcode".PadRight(12);
            string Pname = "Product Name".PadRight(54, ' ');
         
            string TsQty = "Qty".PadLeft(9, ' ');
            string TsRate = "BRP".PadLeft(11, ' ');

            string TsMrp = "MRP".PadLeft(11, ' ');
            //string TsAmount = "Amount".PadLeft(12, ' ');
            //string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;
            City = "                                                  " + City;

            RichTextBox1.Text = "\n" + AddressTemp + "\n" + Address + "\n" + City + "\nNo :" + StrVno + "\nSupplier:" + Cusnam + Datestr + "\nMobile:" + CustomerMobile + TimeStr + " \n\n" + Slno +Bcode +Pname + TsQty + TsRate + TsMrp  + "\n" + LineHeading + "";

            double TRate = 0;
            double TMrp = 0;
            double TQty = 0;
            double TAmount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(7, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(54, ' ');

                        Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        Bcode = Bcode.PadRight(12, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(9, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(12, ' ');

                        double sMrp = Convert.ToDouble(gridmain.Rows[i].Cells["clnmrp"].Value);
                        TsMrp = _Dbtask.SetintoDecimalpoint(sMrp);
                        TsMrp = TsMrp.PadLeft(12, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        //TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        //TsAmount = TsAmount.PadLeft(10, ' ');



                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TMrp = TMrp + sMrp;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Bcode+Pname + TsQty + TsRate + TsMrp ;

                    }
                }
            }
            TTQty = TQty.ToString("0.00");
            TTQty = TTQty.PadLeft(70, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(34, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string OtherizedSignature = "Authorized Signatory".PadLeft(80, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = Convert.ToDouble(txtbillamount.Text);

                OldBalance = OldBalance - BillAmt;


                currentbalance = OldBalance + BillAmt;

            }
            else if (TxtAccount.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = Convert.ToDouble(txtbillamount.Text);

                    currentbalance = OldBalance;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);


            string BiilDiscount = Txtcashdiscount.textBox1.Text.ToString();

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty +  "\n" +
              LineFooter + "\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

            RichTextBox1.Text = RichTextBox1.Text;
            TMrp = TMrp + _Dbtask.znullDouble(BiilDiscount);
            SavedAmount = _Dbtask.SetintoDecimalpoint(TMrp - TRate);
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                PrintBold("                      BRAND ROOT", true);
                PrintDotMetrix(true);
               // PrintBold("You Saved   :" + SavedAmount + "                 Total    :" + txtbillamount.Text, true);

                //  RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
              //  RichTextBox1.Text = "\n\nCash Received: " + FrmCashDesk.TCash + "\nBalance:" + FrmCashDesk.Balance;

                Fscroll();
               
                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }
        }

        public void vouchertyperetailDotmetrix10(string Invoicename)
        {
            MyPrinter.PrinterName = CommonClass._Paramlist.GetParamvalue("SPrintSelect");
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string TelePhone = _Dbtask.ExecuteScalar("select telephone from TblCompanyMaster");
            string AddressTemp = "                                          BAG WORLD&TOYS GALLERY" + "                PH:" + TelePhone;
            //string Bcode=
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string City = "MANJERI";
            string Address = temp;
            string Mobile = "                                               MOBILE :" + _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string CustomerMobile = CommonClass._Ledger.GetSpecificfieldBaseonName(Cusnam, "Mobile");
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string TimeStr = "                                                                                                                                  Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                                                                                                                                " + Datestr;
            string LineHeading = "=".PadRight(152, '=');
            string LineAbowAmount = "-".PadRight(152 ,'-');
            string LineFooter = "=".PadRight(152, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Bcode = "Bcode".PadRight(12);
            string Pname = "Product Name".PadRight(54, ' ');

            string TsQty = "Qty".PadLeft(9, ' ');
            string TsRate = "Prate".PadLeft(11, ' ');
            string TsNetamt = "Net Amt".PadLeft(15, ' ');
            string TsTaxamt = "TaxAmt".PadLeft(15, ' ');
            string Tstaxperc = "TaxPerc".PadLeft(11, ' ');
            string TsTotamt = "Total Amt".PadLeft(18, ' ');
            string TsMrp = "MRP".PadLeft(11, ' ');
           // string Tsprate="Prate"
            //string TsAmount = "Amount".PadLeft(12, ' ');
            //string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
           
            string TTNetAmount;
            //string TTTaxamount;
            string TTtotalamount;
           

            City = "                                                  " + City;

            RichTextBox1.Text = "\n" +  "\n" + Address + "\n" + City + "\nNo :" + StrVno + "\nSupplier:" + Cusnam + Datestr + "\nMobile:" + CustomerMobile + TimeStr + " \n\n" + Slno + Bcode + Pname + TsQty + TsRate + TsNetamt+TsTaxamt+Tstaxperc+TsTotamt + "\n" + LineHeading + "";

            double TRate = 0;
            double TMrp = 0;
            double TQty = 0;
            double Tnetamt = 0;
            double Ttaxamt = 0;
            double TAmount=0;
            // TAmount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(7, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(54, ' ');

                        Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        Bcode = Bcode.PadRight(12, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(9, ' ');





                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnprate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(12, ' ');


                        double sNetamt = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                        TsNetamt = _Dbtask.SetintoDecimalpoint(sNetamt);
                        TsNetamt = TsNetamt.PadLeft(15, ' ');

                        double sTaxamt = Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                        TsTaxamt = _Dbtask.SetintoDecimalpoint(sTaxamt);
                        TsTaxamt = TsTaxamt.PadLeft(15, ' ');

                        double sTaxperc = Convert.ToDouble(gridmain.Rows[i].Cells["clntaxper"].Value);
                        Tstaxperc = _Dbtask.SetintoDecimalpoint(sTaxperc);
                        Tstaxperc = Tstaxperc.PadLeft(11, ' ');

                        double sTotamt = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsTotamt = _Dbtask.SetintoDecimalpoint(sTotamt);
                        TsTotamt = TsTotamt.PadLeft(18, ' ');


                        
                        
                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sTotamt;
                        Tnetamt = Tnetamt + sNetamt;
                        Ttaxamt = Ttaxamt + sTaxamt;
                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Bcode + Pname + TsQty + TsRate + TsNetamt + TsTaxamt + Tstaxperc + TsTotamt;

                    }
                }
            }
            TTQty = TQty.ToString("0.000");
            TTQty = TTQty.PadLeft(81, ' ');

            TTNetAmount = Tnetamt.ToString("0.000");
            TTNetAmount = TTNetAmount.PadLeft(28, ' ');

            TTtotalamount = TAmount.ToString("0.000");
            TTtotalamount = TTtotalamount.PadLeft(29, ' ');

            TTTaxamount = Ttaxamt.ToString("0.000");
            TTTaxamount = TTTaxamount.PadLeft(15, ' ');

           // TAmount = _Dbtask.SetintoDecimalpoint(TAmount);
           // TAmount = TTAmount.PadLeft(18, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string OtherizedSignature = "Authorized Signatory".PadLeft(80, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {
                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = Convert.ToDouble(txtbillamount.Text);

                OldBalance = OldBalance - BillAmt;


                currentbalance = OldBalance + BillAmt;

            }
            else if (TxtAccount.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = Convert.ToDouble(txtbillamount.Text);

                    currentbalance = OldBalance;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);


            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txtcashdiscount.textBox1.Text));

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTNetAmount+TTTaxamount+TTtotalamount+"\n" +
              LineFooter + "\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

            RichTextBox1.Text = RichTextBox1.Text;
            TMrp = TMrp + _Dbtask.znullDouble(BiilDiscount);
            SavedAmount = _Dbtask.SetintoDecimalpoint(TMrp - TRate);

            Frmprintmain _PrintMain = new Frmprintmain();

            _PrintMain.Richtext = RichTextBox1.Text;
            _PrintMain.ShowDialog();
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                PrintBold("                      BRAND ROOT", true);
                PrintDotMetrix(true);
                // PrintBold("You Saved   :" + SavedAmount + "                 Total    :" + txtbillamount.Text, true);

                //  RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
                //  RichTextBox1.Text = "\n\nCash Received: " + FrmCashDesk.TCash + "\nBalance:" + FrmCashDesk.Balance;

                Fscroll();

                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }
        }

        public void PrintRollBack(int Count)
        {
            if (ChkShowPreview.Checked == false)
            {
                MyPrinter.Close();
                if (!MyPrinter.Open("Qplex Print")) return;

                for (int i = 0; i <= Count; i++)
                {
                    MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                }
                MyPrinter.Close();
            }
        }

        public void PrintBold(string Str, bool isConsoled)
        {
            if (ChkShowPreview.Checked == false)
            {
                if (isConsoled == true)
                {
                    if (!MyPrinter.Open("Qplex Print")) return;
                    MyPrinter.Print(Convert.ToChar(15).ToString());
                    MyPrinter.Print(Convert.ToChar(14).ToString());
                    MyPrinter.Print(Str);
                    MyPrinter.Print(Convert.ToChar(20).ToString());
                    MyPrinter.Print(Convert.ToChar(18).ToString());
                    MyPrinter.Close();
                }
                else
                {
                    if (!MyPrinter.Open("Qplex Print")) return;
                    MyPrinter.Print(Convert.ToChar(14).ToString());
                    MyPrinter.Print(Str);
                    MyPrinter.Print(Convert.ToChar(20).ToString());
                    MyPrinter.Close();
                }
            }
        }

        public void Fscroll()
        {
            if (ChkShowPreview.Checked == false)
            {
                int Fscroll = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Fscroll"));

                for (int i = 0; i <= Fscroll; i++)
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n";
                }
            }
        }

        public void PrintInvoice()
         {
            //Printerselect = CommonClass._Paramlist.GetParamvalue("Pselect");
             Printerselect = CommonClass._Dbtask.GetPrinterSelectpurchaseseting();
            
            PrintingInvoiceName = _Dotmetrix.PrintInvoiceHead(Vtype);
            if (SSsizes == true)
            {
                PrintSizes(PrintingInvoiceName);
                vouchertypewholesalesother();
            }
            else
            {
                if (Printerselect == "4")
                {
                  //vouchertyperetailDotmetrix10BrandRoot("Purchase Invoice");
                       
                  Normal3PointLaser(Printerselect);

                }
                if (Printerselect == "ThermalenglishNotax")
                {
                    //vouchertyperetailDotmetrix10BrandRoot("Purchase Invoice");

                    Normal3PointLaserpurchnotax(Printerselect);

                }




                if (Printerselect == "ThermalarabNotax")
                {
                    //vouchertyperetailDotmetrix10BrandRoot("Purchase Invoice");

                    Normal3PointarabicPURCHNOTAX(Printerselect);

                }




                if (Printerselect == "3pointArabic")
                {
                    Normal3Pointarabic(Printerselect);
                }

               


                if (Printerselect == "mode7")
                {
                    TWOinch(Printerselect);
                }


                else if (Printerselect == "mode3" || Printerselect == "mode4" || Printerselect == "A4Preprint2" || Printerselect == "9")
                {


                    if (Printerselect == "mode4")
                    {
                        if (this.Text == "Purchase Return")
                        {

                            AFourpreprintmode4("Purchase Return", Printerselect);

                            //PrintLaser("Purchase Return", Printerselect);
                        }
                        else if (this.Text == "Purchase")
                        {

                            AFourpreprintmode4("Purchase", Printerselect);

                            //PrintLaser("Purchase", Printerselect);
                        }
                        else if (this.Text == "Purchase Order")
                        {

                            AFourpreprintmode4("Purchase Order", Printerselect);
                            //PrintLaser("Purchase Order", Printerselect);
                        }
                    }
                    if (Printerselect == "mode3")
                    {
                        if (this.Text == "Purchase Return")
                        {
                            AFourpreprinttwo("Purchase Return", Printerselect);
                        }
                        else if (this.Text == "Purchase")
                        {
                            AFourpreprinttwo("Purchase", Printerselect);
                        }
                        else if (this.Text == "Purchase Order")
                        {
                            AFourpreprinttwo("Purchase Order", Printerselect);
                        }
                    }
                    if (Printerselect == "A4Preprint2")
                    {
                        if (this.Text == "Purchase Return")
                        {
                            AFourLASERFIVE("Purchase Return", Printerselect);
                        }
                        else if (this.Text == "Purchase")
                        {
                            AFourLASERFIVE("Purchase", Printerselect);
                        }
                        else if (this.Text == "Purchase Order")
                        {
                            AFourLASERFIVE("Purchase Order", Printerselect);
                        }
                    }

                    if (Printerselect == "9")
                    {
                        if (this.Text == "Purchase Return")
                        {
                            AFourhalfpurchase("Purchase Return", Printerselect);
                        }
                        else if (this.Text == "Purchase")
                        {
                            AFourhalfpurchase("Purchase", Printerselect);
                        }
                        else if (this.Text == "Purchase Order")
                        {
                            AFourhalfpurchase("Purchase Order", Printerselect);
                        }
                    }


                }
            }
        }
        //***************
        public void AFourhalfpurchase(string FormType, string Pselect)
        {

            _Lasfive.PTYpe = FormType;

            _halfpurch.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _halfpurch.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _halfpurch.TDiscount = (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) + _Dbtask.znlldoubletoobject(TxttItemDiscount.Text)).ToString();
            _halfpurch.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _halfpurch.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _halfpurch.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            // _Laser.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            _halfpurch.TempCust = TxtAccount.textBox1.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _halfpurch.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _halfpurch.BillDate = dtdate.Value;
            _halfpurch.Billno = txtvno.Text;
            _halfpurch.TgrossAmt = TxtTAmount.Text;
            _halfpurch.Totherexpense = txtotherexpenses.textBox1.Text;
            _halfpurch.BillAmount = txtbillamount.Text;
            _halfpurch.TotalNetamount = NetTottal + (Convert.ToDouble(Txtcashdiscount.textBox1.Text));
            _halfpurch.FormType = FormType;
            _halfpurch.Ttaxamount = txtttax.Text;
            _halfpurch.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _halfpurch.ModeofPayment = "CASH";
            else
                _halfpurch.ModeofPayment = "CREDIT";

            _halfpurch.StrNaration = TxtNaration.textBox1.Text;

               ClsinvlaserhalfPurch.SelPrint = comprint.Text;

            _halfpurch.PrintInvoice(gridmain);


        }


        public void AFourLASERFIVE(string FormType, string Pselect)
        {

            _Lasfive.PTYpe = FormType;

            _Lasfive.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Lasfive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Lasfive.TDiscount = (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) + _Dbtask.znlldoubletoobject(TxttItemDiscount.Text)).ToString();
            _Lasfive.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Lasfive.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Lasfive.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            // _Laser.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            _Lasfive.TempCust = TxtAccount.textBox1.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Lasfive.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _Lasfive.BillDate = dtdate.Value;
            _Lasfive.Billno = txtvno.Text;
            _Lasfive.TgrossAmt = TxtTAmount.Text;
            _Lasfive.Totherexpense = txtotherexpenses.textBox1.Text;
            _Lasfive.BillAmount = txtbillamount.Text;
            _Lasfive.TotalNetamount = NetTottal + (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text));
            _Lasfive.FormType = FormType;
            _Lasfive.Ttaxamount = txtttax.Text;
            _Lasfive.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _Lasfive.ModeofPayment = "CASH";
            else
                _Lasfive.ModeofPayment = "CREDIT";

            _Lasfive.StrNaration = TxtNaration.textBox1.Text;


            _Lasfive.SelPrint = comprint.Text;

            _Lasfive.PrintInvoice(gridmain);


        }



        public void AFourpreprinttwo(string FormType, string Pselect)
        {

            _purlasersix.PTYpe = FormType;

            _purlasersix.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _purlasersix.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _purlasersix.TDiscount = (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) + _Dbtask.znlldoubletoobject(TxttItemDiscount.Text)).ToString();
            _purlasersix.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _purlasersix.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _purlasersix.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            // _Laser.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            _purlasersix.TempCust = TxtAccount.textBox1.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _purlasersix.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _purlasersix.BillDate = dtdate.Value;
            _purlasersix.Billno = txtvno.Text;
            _purlasersix.TgrossAmt = TxtTAmount.Text;
            _purlasersix.Totherexpense = txtotherexpenses.textBox1.Text;
            _purlasersix.BillAmount = txtbillamount.Text;
            _purlasersix.TotalNetamount = NetTottal + (Convert.ToDouble(Txtcashdiscount.textBox1.Text));
            _purlasersix.FormType = FormType;
            _purlasersix.Ttaxamount = txtttax.Text;
            _purlasersix.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _purlasersix.ModeofPayment = "CASH";
            else
                _purlasersix.ModeofPayment = "CREDIT";

            _purlasersix.StrNaration = TxtNaration.textBox1.Text;


            _purlasersix.SelPrint = comprint.Text;

            _purlasersix.PrintInvoice(gridmain);


        }
        public void AFourpreprintmode4(string FormType, string Pselect)
        {

            _purprefour.PTYpe = FormType;

            _purprefour.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _purprefour.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _purprefour.TDiscount = (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) + _Dbtask.znlldoubletoobject(TxttItemDiscount.Text)).ToString();
            _purprefour.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _purprefour.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _purprefour.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            // _Laser.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            _purprefour.TempCust = TxtAccount.textBox1.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _purprefour.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _purprefour.BillDate = dtdate.Value;
            _purprefour.Billno = txtvno.Text;
            _purprefour.TgrossAmt = TxtTAmount.Text;
            _purprefour.Totherexpense = txtotherexpenses.textBox1.Text;
            _purprefour.BillAmount = txtbillamount.Text;
            _purprefour.TotalNetamount = NetTottal+(Convert.ToDouble(Txtcashdiscount.textBox1.Text)); //NetTottal;
            _purprefour.FormType = FormType;
            _purprefour.Ttaxamount = txtttax.Text;
            _purprefour.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _purprefour.ModeofPayment = "CASH";
            else
                _purprefour.ModeofPayment = "CREDIT";

            _purprefour.StrNaration = TxtNaration.textBox1.Text;


            _purprefour.SelPrint = comprint.Text;

            _purprefour.PrintInvoice(gridmain);


        }

        public void PrintLaser(string FormType, string Pselect)
        {
            Laserprintspecification(FormType);
            _Laser.PSelect = Pselect;

            _Laser.PrintInvoice(gridmain);
        }
        public void Laserprintspecification(string FormType)
        {
            _Laser.PTYpe = FormType;

            _Laser.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Laser.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Laser.TDiscount = (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) + _Dbtask.znlldoubletoobject(TxttItemDiscount.Text)).ToString();
            _Laser.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Laser.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Laser.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
           // _Laser.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.textBox1.Text + "'");
            _Laser.TempCust = TxtAccount.textBox1.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Laser.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _Laser.BillDate = dtdate.Value;
            _Laser.Billno = txtvno.Text;
            _Laser.TgrossAmt = TxtTAmount.Text;
            _Laser.Totherexpense = txtotherexpenses.textBox1.Text;
            _Laser.BillAmount = txtbillamount.Text;
            _Laser.TotalNetamount = NetTottal + (Convert.ToDouble(Txtcashdiscount.textBox1.Text));
            _Laser.FormType = FormType;
            _Laser.Ttaxamount = txtttax.Text;
            _Laser.TotalQty = txttqty.Text;
            
            if (commodeofpayment.SelectedIndex == 0)
                _Laser.ModeofPayment = "CASH";
            else
                _Laser.ModeofPayment = "CREDIT";

            _Laser.StrNaration = TxtNaration.textBox1.Text;

        }
        public void vouchertypewholesalesother()
        {
            if (ChkShowPreview.Checked == true)
            {
                printPreviewDialog1.Document = printDocument1;
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                printDocument1.Print();
            }
        }
        public void Mainprint()
        {
            if (ComPrintSheme.SelectedIndex == 0)
            {
                //if (pnlprintsettings.Visible == true)
                //{
                //    //pnlprintsettings.Visible = false;
                   
                //}
                //else
                //{
                    //pnlprintsettings.Visible = true;
                    CommonClass._Gen.FillActivePrinter(comprint);
                   
                //}

            }
            else
            {
               // pnlprintsettings.Visible = true;
                CommonClass._Gen.FillActivePrinter(comprint);
                //PrintInvoice();
            }
        }

        private void cmdprint_Click(object sender, EventArgs e)
            {
            Purprint = true;

            if (chkprintconfirmation.Checked == true)
            {
                Result = MessageBox.Show("Do You want to Print?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                if (Result.ToString() == "Yes")
                {
                    Mainprint();
                    directprint();
                }
            }
            else
            {
                Mainprint();
                directprint();
            }
            Purprint = false;
        }

        public void ComTextChange()
        {
            RowValidation();

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {

                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        rowindex = i;
                        ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
                        TaxCalcPart();
                        if (SUnit == true)
                        {
                            if (comText == true)
                            {
                                Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();
                                if (Vtype == "PI" || Vtype == "PO")
                                {
                                    Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                                }
                                if (Vtype == "PR")
                                {
                                    Unitid = _Dbtask.ExecuteScalar("select UnitId from TblIssuedetails where IssueCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                                }
                                string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                                gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                                gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                                UnitName = Unit;
                                UnitAmountCalc();
                            }
                            else
                            {
                                string unitid = gridmain.Rows[i].Cells["ClnUnit"].Tag.ToString();
                                UnitName = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where id='" + unitid + "'");
                                ItemId = gridmain.Rows[i].Cells["clnItemName"].Tag.ToString();
                                UnitAmountCalc();

                            }
                        }
                        CellEnterCalculationPart();
                        TaxCalcPart();

                    }
                }
            }
            TottalAmountCalculate();
        }
        private void ComTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComTextChange();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            GetPrevious(Convert.ToInt64(txtvno.Tag) - 1, false);
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            GetPrevious(Convert.ToInt64(txtvno.Tag) + 1, false);
        }

        private void commodeofpayment_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Retrivemode == 0)
            {
                //if (commodeofpayment.Text == "CASH")
                //{
                //    TxtAccount.textBox1.Tag = 1;
                //    lblreceivedamount.Visible = false;
                //    txtreceivedamt.Visible = false;
                //}
                 if (commodeofpayment.SelectedIndex == 0 && _Dbtask.znllString(TxtAccount.textBox1.Tag) == "")
                {
                    TxtAccount.textBox1.Tag = "1";
                    //lblreceivedamount.Visible = false;
                    //txtreceivedamt.Visible = false;
                }
                 if (commodeofpayment.SelectedIndex == 0 && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "")
                 {
                     if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("221")) == "1")
                     {
                         TxtAccount.textBox1.Tag = _Dbtask.znllString(TxtAccount.textBox1.Tag);
                         
                     }
                     else
                     {
                         TxtAccount.textBox1.Tag = "1";
                       
                     }
                     
                 }

                 else if (commodeofpayment.SelectedIndex == 2 && _Dbtask.znllString(TxtAccount.textBox1.Tag) != "")
                {
                    string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
                    if (temp == "" && _Dbtask.znllString(TxtAccount.textBox1.Tag) != temp)
                    {
                        if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("221")) == "1")
                        {
                            TxtAccount.textBox1.Tag = _Dbtask.znllString(TxtAccount.textBox1.Tag);

                        }
                        else
                        {
                            if (temp == "")
                            {

                                TxtAccount.textBox1.Tag = "28";
                                TxtAccount.textBox1.Text = "BANK";
                            }
                            else
                            {
                                TxtAccount.textBox1.Tag = temp;
                                TxtAccount.textBox1.Text = CommonClass._Ledger.GetspecifField("lname", temp);
                            }
                        }


                        //TxtAccount.textBox1.Tag = "28";
                        //TxtAccount.textBox1.Text = "BANK";
                        // txtCustomer.Text = _Dbtask.ExecuteScalar("select LName from tblaccountledger where AGroupId='24'");
                    }
                    //else
                    //{
                    //    TxtAccount.textBox1.Tag = temp;
                    //    TxtAccount.textBox1.Text = CommonClass._Ledger.GetspecifField("lname", temp);
                    //}
                    Gridcustomerlist.Visible = false;
                }
                //else
                //{
                //    if (TxtAccount.textBox1.Text == "")
                //    {
                //        TxtAccount.textBox1.Tag = null;

                //        lblreceivedamount.Visible = true;
                //        txtreceivedamt.Visible = true;
                //    }
                //    else
                //    {
                //        string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname=N'" + TxtAccount.textBox1.Text + "'");
                //        TxtAccount.textBox1.Tag = temp;
                //        //lblreceivedamount.Visible = true;
                //        //txtreceivedamt.Visible = true;
                //    }
                //}
            }
        }

        private void ComDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stockareaid = ComDepot.SelectedValue.ToString();
        }
        private void Comemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comemployee.SelectedValue != null)
            {
                StaffId = Comemployee.SelectedValue.ToString();
            }
            else
            {
                StaffId = "0";
            }
        }

        private void ComAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComAgent.SelectedValue != null)
            {
                agentid = ComAgent.SelectedValue.ToString();
            }
            else
            {
                agentid = "0";
            }
        }

        private void cmdquickpayment_Click_1(object sender, EventArgs e)
        {
            showCashpayment();
        }

        private void TxtRefName_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(TxtRefName);
        }

        private void commodeofpayment_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(commodeofpayment);
        }

        private void ComTax_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(ComTax);
        }

        private void ComDepot_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(ComDepot);
        }

        private void Comemployee_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(Comemployee);
        }
        /*Sizes function Following********************************************************************8*/
        public void SizeItemsinMainGrid()
        {
            try
            {
                int Columnindexgridsizes = Datagridsizes.CurrentCell.ColumnIndex;
                int Cout = Datagridsizes.Columns.Count - 1;
                int SizeCurentrow = Datagridsizes.CurrentCell.ColumnIndex;
                double TtQty = new double();
                if (Cout == SizeCurentrow && IsEnterSize == false)
                {
                    for (int i = 1; i < Datagridsizes.Columns.Count; i++)
                    {
                        string Columnname = Datagridsizes.Columns[i].Name;
                        string qty = _Dbtask.znllString(Datagridsizes.Rows[0].Cells[i].Value);
                        double DQty = Convert.ToDouble(qty);
                        string SizeSrate = _Dbtask.znllString(Datagridsizes.Rows[0].Cells["clnsizerate"].Value);
                        if (DQty > 0)
                        {
                            if (_Dbtask.znllString(Datagridsizes.Rows[0].Cells[Columnname].Tag) != "")
                            {
                                int CCount = gridmain.Rows.Add(1);
                                string tempid = Datagridsizes.Rows[0].Cells[Columnname].Tag.ToString();
                                string SizeName = Datagridsizes.Rows[0].Cells[Columnname].Value.ToString();
                                rowindex = CCount - 1;
                                gridmain.Rows[rowindex].Cells["clnslno"].Value = rowindex + 1;
                                gridmain.Rows[rowindex].Cells["clnslno"].Tag = SizeName;
                                gridmain.Rows[rowindex].Cells["clnitemname"].Tag = tempid;
                                gridmain.Rows[rowindex].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + tempid + "'");
                                gridmain.Rows[rowindex].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempid + "'");
                                gridmain.Rows[rowindex].Cells["Clnprate"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempid + "'");
                                gridmain.Rows[rowindex].Cells["ClnMRP"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempid + "'");
                                NMrp = Convert.ToDouble(_Dbtask.ExecuteScalar("select mrp from tblitemmaster where itemid='" + tempid + "'"));
                                gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(DQty);
                                gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.ExecuteScalar("select srate from tblitemmaster where itemid='" + tempid + "'");
                                gridmain.Rows[rowindex].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(SizeSrate));

                                CellEnterCalculationPart();
                                TottalAmountCalculate();
                            }
                        }
                    }
                    IsEnterSize = true;
                    Pnlsizes.Visible = false;
                    gridmain.CurrentCell = gridmain.Rows[rowindex + 1].Cells["clnitemcode"];
                    gridmain.Focus();
                    gridmain.CurrentCell = gridmain.Rows[rowindex + 1].Cells["clnitemcode"];
                }
            }
            catch
            {
            }
        }
        public void LoadColumn()
        {
            Ennteringridcell = true;
            IsEnterSize = false;
            Pnlsizes.Visible = true;
            string ItemlessName = _Dbtask.ExecuteScalar("select sizelessname from tblitemmaster where itemid='" + ItemId + "'");

            Datagridsizes.Rows.Clear();
            Datagridsizes.Columns.Clear();
            Datagridsizes.Columns.Add("clnfirst", "");
            Datagridsizes.Columns[0].ReadOnly = true;
            Datagridsizes.Rows.Add();
            Ds = _Size.ShowSizes();
            if (Ennteringridcell == true)
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string SizeName = Ds.Tables[0].Rows[i]["sname"].ToString();
                    string TColumnname = "cln" + SizeName + "";
                    Datagridsizes.Columns.Add(TColumnname, SizeName);
                    Datagridsizes.Rows[0].Cells[TColumnname].Value = _Dbtask.SetintoDecimalpointStock(0);
                    string ActualItemname = ItemlessName + " " + SizeName;
                    string TTItemid = _Dbtask.ExecuteScalar("select Itemid from tblitemmaster where itemname='" + ActualItemname + "'");
                    Datagridsizes.Rows[0].Cells[TColumnname].Tag = TTItemid;
                    if (TTItemid == "")
                    {
                        Datagridsizes.Columns[TColumnname].ReadOnly = true;
                    }
                    else
                    {
                    }
                }

            for (int i = 0; i < Datagridsizes.Columns.Count; i++)
            {
                if (_Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells[i].Tag) != 0)
                {
                    string TTItemid = Datagridsizes.Rows[0].Cells[i].Tag.ToString();
                    Datagridsizes.Rows[1].Cells[i].Value = _Inventory.GetStock(" where pcode= '" + TTItemid + "'");
                }
            }
            /*************************************/
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Datagridsizes.Columns.Add("clnsizerate", "Prate");
                Datagridsizes.Rows[0].Cells["clnsizerate"].Value = _ItemMaster.SpecificField(ItemId, "Prate");
                Pnlsizes.Focus();
                Datagridsizes.CurrentCell = Datagridsizes.Rows[0].Cells[0];
            }
        }

        public void FuFillingLoadotherVoucher()
        {
            if (Vtype == "PO")
            {
                comfillingselectvoucher.Items.AddRange(new object[] {
                    "Enquiry",
                    "Sales Order",
                    "ReOrder"
                });
            }
            if (Vtype == "PI")
            {
                comfillingselectvoucher.Items.AddRange(new object[] {
                    "Enquiry",
                    "Sales Order","Purchase Order",
                    "ReOrder"
                });
            }
            if (Vtype == "SO")
            {
                comfillingselectvoucher.Items.AddRange(new object[] {
                     "Enquiry",
                     "ReOrder"
                });
            }
            if (Vtype == "SI")
            {
                comfillingselectvoucher.Items.AddRange(new object[] {
                    "Enquiry",

                    "Sales Order","Purchase Order","Purchase","ReOrder"});
            }
        }
        /*********************************************************************/

        public void DoubleClickSupplier()
        {
            try
            {

                if (Gridcustomerlist.SelectedRows.Count > 0 || commodeofpayment.Text != "CASH")
                {
                    IsEnter = false;
                    selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                    TxtAccount.textBox1.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();

                    if (commodeofpayment.Text != "CASH")
                    {
                        TxtAccount.textBox1.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                    }
                    Gridcustomerlist.Visible = false;
                    Lblpartybalance.Visible = true;
                    Lblpartybalance.Text = Convert.ToString(_AccountLedger.Balanceofledger(TxtAccount.textBox1.Tag.ToString()));

                }

                else
                {
                    Gridcustomerlist.Visible = false;
                    gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
                }
                TxtAccount.textBox1.Focus();
            }

            catch
            {

            }
        }
        private void Gridcustomerlist_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickSupplier();
        }

        private void Datagridsizes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;
            SizeItemsinMainGrid();
        }

        private void Datagridsizes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt1 = e.Control as TextBox;

            txt1.TextChanged -= new EventHandler(txt1_TextChanged);
            txt1.TextChanged += new EventHandler(txt1_TextChanged);

            txt1.Leave -= new EventHandler(txt1_Leave);
            txt1.Leave += new EventHandler(txt1_Leave);

            txt1.KeyPress -= new KeyPressEventHandler(txt1_KeyPress);
            txt1.KeyPress += new KeyPressEventHandler(txt1_KeyPress);
        }

        void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
        }

        void txt1_Leave(object sender, EventArgs e)
        {
            int columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;
            Datagridsizes.Rows[0].Cells[columnindexSize].Value = (sender as TextBox).Text;
        }

        void txt1_TextChanged(object sender, EventArgs e)
        {
            int columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;

            Datagridsizes.Rows[0].Cells[columnindexSize].Value = (sender as TextBox).Text;
        }

        private void Frmpurchase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
            {
                ShowPanelPreBill();
            }
            if (e.KeyValue == 16)/*For Shift Click*/
            {
                if (SSsizes == true)
                {
                    if (ShowSubpanel == true)
                    {
                        ShowSubpanel = false;
                    }
                    else
                    {
                        ShowSubpanel = true;
                    }
                }
            }
            if (e.KeyValue == 27)
            {
                if (Gridbatchlist.Visible == true)
                {
                    Gridbatchlist.Visible = false;
                }
            }

            if (e.KeyValue == 122)/*For F11 Barcode*/
            {
                BarcodeEditing();
            }
        }

        public void BarcodeEditing()
        {
            if (SBatch == true)
            {
                if (clnbatch.ReadOnly == true)
                {
                    clnbatch.ReadOnly = false;
                    //clnitemcode.ReadOnly = true;
                    //clnitemname.ReadOnly = true;
                    dataGridViewCellStyleNew.BackColor = System.Drawing.Color.Gainsboro;

                    gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                }
                else
                {
                    clnbatch.ReadOnly = true;
                    clnitemcode.ReadOnly = false;
                    clnitemname.ReadOnly = false;
                    dataGridViewCellStyleNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

                    gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                }
            }
        }

        public void ShowPanelPreBill()
        {
            try
            {
                if (pnlbill.Visible == false)
                {
                    pnlbill.Visible = true;
                    txtnofilling.textBox1.Text = "0";
                    //pnlbill.Size = new System.Drawing.Size(510, 357);
                    //FuFillingLoadotherVoucher();
                   // CommonClass._Itemmaster.FillCombo(comfillitem);
                    //comfillitem.SelectedIndex = 1;
                    //txtnofilling.textBox1.Text = "0";
                    txtentervno.Focus();
                    txtentervno.Select();
                }
                else
                {
                    pnlbill.Visible = false;
                }
            }
            catch
            {
            }
        }
        private void txtentervno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string GetVno = txtentervno.Text;
                GetPrevious(Convert.ToInt64(GetVno), false);
                pnlbill.Visible = false;
            }
        }

        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {
            _Forms.ShowItemcreate();
        }

        private void Datagridsizes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindexSize = Datagridsizes.CurrentCell.RowIndex;
                columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;
                if (Ennteringridcell == true)
                    if (Datagridsizes.Rows[rowindexSize].Cells[columnindexSize].ReadOnly == true)
                    {
                        SendKeys.Send("{Tab}");
                    }
            }
            catch
            {
            }
        }

        private void cmdreport_Click(object sender, EventArgs e)
        {
            Frmselectpurchasereportnew _SelePurchase = new Frmselectpurchasereportnew();
            _SelePurchase.ShowDialog();
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            _Forms.Showpurchase();
        }

        private void barcodeToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Forms.ShowbarcodeTools();
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.SalesAccount = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='Sales'");
            _Sales.Heading = "Sales";
            _Sales.Vtype = "SI";
            _Sales.ShowDialog();
        }

        private void cmdbarcodeTool_Click(object sender, EventArgs e)
        {
            _Forms.ShowbarcodeTools();
        }
        private void cmdclosesysmbol_Click(object sender, EventArgs e)
        {
            _Nextg.CloseGriddetail(gridmain, this);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                if (SSsizes == true && TRowCounting > 0)
                {
                    pictureBox1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
                }
                if (PrintNextpage == true)
                {
                    TRowCounting = 0;

                    PrintSizes("Sales Invoice");

                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }
            catch
            {
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (RichTextBox1.Text != "")
            {
                int XX = 75;
                int YY = 25;
                Font headerFont;
                Font mainheaderFont;
                headerFont = new System.Drawing.Font("Lucida Console", 10F);
                mainheaderFont = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                YY = 50;
                e.Graphics.DrawString(RichTextBox1.Text, headerFont, Brushes.Black, XX, YY);
            }
        }

        private void ComPrintSheme_Click(object sender, EventArgs e)
        {
            ComPrintSheme.Focus();
            ComPrintSheme.Select();
        }

        private void Gridcustomerlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                DoubleClickSupplier();
            }
        }

        private void comfillingselectvoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = comfillingselectvoucher.Text;
            SampleVtype = "";
            lbltotbill.Text = "";


            if (comfillingselectvoucher.SelectedIndex == 0)
            {
                SampleVtype = "PO";

                lbltotbill.Text =" Total Bill  : "+   CommonClass._Gen.returnmaxvnonumber("tbltransactionreceipt", SampleVtype) + "  " + "]";


            }
            if (comfillingselectvoucher.SelectedIndex == 1)
            {
                SampleVtype = "SO";
                lbltotbill.Text = " Total Bill : " + CommonClass._Gen.returnmaxvnonumber("tblbusinessissue", SampleVtype) + "  " + "]";

            }
            if (comfillingselectvoucher.SelectedIndex == 2)
            {
                SampleVtype = "DN";
                lbltotbill.Text = " Total Bill : " + CommonClass._Gen.returnmaxvnonumber("tblbusinessissue", SampleVtype) + "  " + "]";
            }


            //if (temp == "Enquiry" || temp == "Sales Order" || temp == "Sales")
            //{
            //    if (temp == "Enquiry")
            //        SampleVtype = "CRM";
            //    else if (temp == "Sales Order")
            //        SampleVtype = "SO";
            //    else if (temp == "Sales")
            //        SampleVtype = "SI";
            //    _Dbtask.fillDatainCombowithQuery(comfillingvno, "vno", "vno", "tblbusinessissue", "select * from tblbusinessissue where issuetype='" + SampleVtype + "'");
            //}
            //else if (temp != "ReOrder")
            //{
            //    if (temp == "Purchase Order" || temp == "Purchase" || temp == "Reorder")
            //    {
            //        if (temp == "Purchase Order")
            //        {
            //            SampleVtype = "PO";
            //        }
            //        else if (temp == "Purchase")
            //            SampleVtype = "PI";
            //        _Dbtask.fillDatainCombowithQuery(comfillingvno, "VNo", "VNo", "tbltransactionreceipt", "select * from tbltransactionreceipt where recpttype='" + SampleVtype + "'");
            //    }
            //}
            //else if (temp == "ReOrder")
            //{
            //    reordershow();
            //}
        }
        public void reordershow()
        {

            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where  Reorder!=0");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {

                gridmain.Rows.Add(1);
                string ItemId = Ds.Tables[0].Rows[i]["itemid"].ToString();
                gridmain.Rows[i].Cells["clnitemcode"].Value = Ds.Tables[0].Rows[i]["itemcode"];
                gridmain.Rows[i].Cells["clnitemname"].Value = Ds.Tables[0].Rows[i]["itemname"];
                gridmain.Rows[i].Cells["clnitemname"].Tag = ItemId;

                gridmain.Rows[i].Cells["Clnsrate"].Value = Ds.Tables[0].Rows[i]["srate"];
                gridmain.Rows[i].Cells["Clnprate"].Value = Ds.Tables[0].Rows[i]["prate"];

            }
            pnlbill.Visible = false;
        }

        private void comfillingothervoucher_Click(object sender, EventArgs e)
        {
            string FVno = _Dbtask.znllString(txtentervno.Text); //comfillingvno.Text;
            if (SampleVtype == "CRM" || SampleVtype == "SO" || SampleVtype == "SI" || SampleVtype == "SO" || SampleVtype == "DN")
            {
                PreIssueTransactions(Convert.ToInt64(FVno), false, SampleVtype, true);
            }
            else
            {
                PrePurchaseInvoice(Convert.ToInt64(FVno), false, SampleVtype, true);
            }
            GetVno();
            pnlbill.Visible = false;
        }

        private void Txtcashdiscount_TextChanged(object Sender, EventArgs e)
        {
            TottalAmountCalculate();
        }

        private void Txtcashdiscount_TextChanged_1(object Sender, EventArgs e)
        {
            TottalAmountCalculate();

            if (_Dbtask.znlldoubletoobject( Txtcashdiscount.textBox1.Text)>1000000)
            {
                MessageBox.Show("Please check Discount !!!!!");
            }
        }

        private void txtotherexpenses_TextChanged(object Sender, EventArgs e)
        {
            TottalAmountCalculate();

            if (_Dbtask.znlldoubletoobject(txtotherexpenses.textBox1.Text) > 1000000)
            {
                MessageBox.Show("Please check Expense !!!!!");
            }

        }

        private void txtroundoff_Leave(object sender, EventArgs e)
        {
            RoundoffCalc();
        }


        public void RoundoffCalc()
        {
            double rondvalue = _Dbtask.znullDouble(txtroundoff.textBox1.Text);
            double totalbill = _Dbtask.znullDouble(txtbillamount.Text);
            double billtot = totalbill;
            if (rondvalue < 0)
            {
                roundof = Convert.ToDouble(totalbill - (-rondvalue));
                TottalAmountCalculate();

            }
            else if (rondvalue > 0)
            {
                roundof = Convert.ToDouble(totalbill + rondvalue);
                TottalAmountCalculate();
            }
            else
            {
                roundof = 0;
                TottalAmountCalculate();
            }
        }

        public void Showsupplierwiseitems(string TLid)
        {
            Ds = _ItemMaster.ShowSupplierwiseitem(TLid);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Countrow = gridmain.Rows.Add(1);
                gridmain.Rows[Countrow].Cells["ClnItemCode"].Value = Ds.Tables[0].Rows[i]["itemcode"].ToString();
                gridmain.Rows[Countrow].Cells["ClnItemName"].Tag = Ds.Tables[0].Rows[i]["itemid"].ToString();
                gridmain.Rows[Countrow].Cells["ClnItemName"].Value = Ds.Tables[0].Rows[i]["itemname"].ToString();
                gridmain.Rows[Countrow].Cells["ClnMRP"].Value = Ds.Tables[0].Rows[i]["mrp"].ToString();
                gridmain.Rows[rowindex].Cells["Clnprate"].Value = Ds.Tables[0].Rows[i]["prate"].ToString();
                gridmain.Rows[rowindex].Cells["clnsrate"].Value = Ds.Tables[0].Rows[i]["srate"].ToString();
                gridmain.Rows[rowindex].Cells["Clnprate"].Tag = Ds.Tables[0].Rows[i]["incs"].ToString();
                gridmain.Rows[rowindex].Cells["ClnMRP"].Tag = Ds.Tables[0].Rows[i]["incp"].ToString();

            }
        }

        private void uscnormaltextbox1_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        private void uscnormaltextbox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
                if (e.KeyValue == 114 && e.Modifiers == Keys.Alt)/*For F3*/
            {
                (this.MdiParent as MDIParent2).mnusuppliercreate.PerformClick();
            }

            try
            {
                if (e.KeyValue == 123)/*For F12*/
                {
                    if (SearchDebtors == 1)
                    {
                        SearchDebtors = 0;
                    }
                    else
                    {
                        SearchDebtors = 1;
                    }
                }

                if (Gridcustomerlist.SelectedRows.Count > 0)
                {
                    selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                }

                if (Gridcustomerlist.Visible == true)
                {
                    if (e.KeyValue == 40 && Gridcustomerlist.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridcustomerlist.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridcustomerlist.Rows[selectedRow + 1].Selected = true;
                            Gridcustomerlist.Rows[selectedRow].Selected = false;
                            Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridcustomerlist.Rows[selectedRow - 1].Selected = true;
                        Gridcustomerlist.Rows[selectedRow].Selected = false;
                        Gridcustomerlist.CurrentCell = Gridcustomerlist.SelectedRows[0].Cells[0];
                    }
                }


                if (e.KeyValue == 13)
                {
                    try
                    {
                        if (Gridcustomerlist.Visible == true)
                        {
                            if (Gridcustomerlist.SelectedRows.Count > 0 || commodeofpayment.Text != "CASH")
                            {
                                IsEnter = false;
                                TxtAccount.textBox1.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                               
                                    TxtAccount.textBox1.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                           
                                     
                                   Gridcustomerlist.Visible = false;
                                
                                string Mob = CommonClass._Ledger.GetspecifField("mobile", TxtAccount.textBox1.Tag.ToString());
                                if (Mob != "")
                                {
                                    lblledgertext.Text = lblledgertext.Text + " " + Mob;
                                }
                                IsEnter = true;

                                if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("221")) == "1")
                                {
                                    if (TxtAccount.textBox1.Tag.ToString() != "")
                                    {
                                        commodeofpayment.SelectedIndex = 0;
                                    }
                                }
                                else
                                {
                                    if (TxtAccount.textBox1.Tag.ToString() != "")
                                    {
                                        commodeofpayment.SelectedIndex = 1;
                                    }
                                }
                                


                                // commodeofpayment.SelectedIndex = 1;
                                //if (commodeofpayment.SelectedIndex == 1)
                                //{
                               // Showsupplierwiseitems(TxtAccount.textBox1.Tag.ToString());

                                //Lblpartybalance.Visible = true;
                                // Lblpartybalance.Text = Convert.ToString(_AccountLedger.Balanceofledger(TxtAccount.textBox1.Tag.ToString()));
                                //string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.textBox1.Text.ToString() + "'");
                            
                            
                            }
                            else
                            {
                                Gridcustomerlist.Visible = false;
                                gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
                                IsEnter = true;
                            }
                        }
                    }
                    catch
                    {
                    }
                }

            }

            catch
            {
            }

        }

        private void uscnormaltextbox1_TextChanged(object Sender, EventArgs e)
        {
            if (IsEnter == true && Isinotherwindow == false && Retrivemode == 0)
            {
                Gridcustomerlist.Visible = true;
                Gridcustomerlist.Rows.Clear();
                if (SearchDebtors == 0)/*Not Iclude Debtors*/
                {
                    temp = _AccountGroup.ShowSupplierAccount("");
                    Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + TxtAccount.textBox1.Text + "%'  and Agroupid in(" + temp + ") ");
                }
                if (SearchDebtors == 1)/* Iclude Debtor*/
                {
                    temp = _AccountGroup.ShowSupplierAndCustomerAccount("");
                    Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + TxtAccount.textBox1.Text + "%'  and Agroupid in(" + temp + ") ");

                }
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridcustomerlist.Rows.Add(1);
                    Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["lname"];
                    Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["lid"];
                }
            }
        }

        private void txtinvoicediscperc_Leave(object sender, EventArgs e)
        {
            double Total = 0;
            TempBillDisc = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                Total = Total + Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                TempBillDisc = TempBillDisc + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnbilldiscount"].Value);
            }
            invdisc = _Dbtask.znullDouble("0");
            totlamt = Total;
            invdiscper = totlamt * invdisc / 100;
            if (Retrivemode == 0)
            {
                Total = 0;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    Total = Total + Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                }
                invdisc = _Dbtask.znullDouble(txtinvoicediscperc.textBox1.Text);
                totlamt = Total;
                invdiscper = totlamt * invdisc / 100;
                txtinvoicediscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(invdiscper);
            }
        }

        private void txtinvoicediscount_Leave(object sender, EventArgs e)
        {
            if (Retrivemode == 0)
            {
                invdiscountAmnt();
            }
            TottalAmountCalculate();
            ComTextChange();
        }

        public void discntcalc()
        {
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        double clnamnt = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                        double clnbill = clnamnt * invdiscunt / 100;
                        gridmain.Rows[i].Cells["clnbilldiscount"].Value = _Dbtask.SetintoDecimalpoint(clnbill);
                        rowindex = i;
                        if (SUnit == true)
                        {
                            string unitid = gridmain.Rows[i].Cells["ClnUnit"].Tag.ToString();
                            UnitName = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where id='" + unitid + "'");
                            ItemId = gridmain.Rows[i].Cells["clnItemName"].Tag.ToString();
                            UnitAmountCalc();
                        }
                        CellEnterCalculationPart();
                    }
                }
            }
            TottalAmountCalculate();
        }

        public void invdiscountAmnt()
        {

            double total = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                total = total + Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
            }
            invdisc = _Dbtask.znullDouble(txtinvoicediscount.textBox1.Text);
            totlamt = total;
            invdiscunt = invdisc * 100 / totlamt;
            txtinvoicediscperc.textBox1.Text = _Dbtask.SetintoDecimalpoint(invdiscunt);
            discntcalc();
        }

        public void RetriveAutoSave()
        {
            string Filepath = @"D:\ztPurchase.tmp";
            Ds.ReadXml(Filepath);
            gridmain.Rows.Clear();
            string tempprate;
            string tempcrate;
            string tempSrate;
            string TempMrp;
            string disper;
            string discount;
            string temptax;
            string tempTaxPerc;
            string tempqty;
            string free;
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (Ds.Tables[0].Rows[i][0] != null)
                {

                    gridmain.Rows.Add(1);
                    ItemId = Ds.Tables[0].Rows[i]["Column1"].ToString();

                    Itemcode = Ds.Tables[0].Rows[i]["Column2"].ToString();
                    ItemName = Ds.Tables[0].Rows[i]["Column3"].ToString();
                    Batchcode = Ds.Tables[0].Rows[i]["Column4"].ToString();
                    string tempitemnote = Ds.Tables[0].Rows[i]["Column7"].ToString();
                    string tempitemnote2 = Ds.Tables[0].Rows[i]["Column8"].ToString();
                    string tempprofit = Ds.Tables[0].Rows[i]["Column12"].ToString();
                    tempqty = Ds.Tables[0].Rows[i]["Column9"].ToString();
                    free = Ds.Tables[0].Rows[i]["Column10"].ToString();
                    tempprate = Ds.Tables[0].Rows[i]["Column11"].ToString();
                    tempcrate = Ds.Tables[0].Rows[i]["Column13"].ToString();
                    tempSrate = Ds.Tables[0].Rows[i]["column14"].ToString();
                    TempMrp = Ds.Tables[0].Rows[i]["column16"].ToString();
                    disper = Ds.Tables[0].Rows[i]["Column19"].ToString();
                    discount = Ds.Tables[0].Rows[i]["Column20"].ToString();
                    temptax = Ds.Tables[0].Rows[i]["Column25"].ToString();
                    tempTaxPerc = Ds.Tables[0].Rows[i]["Column24"].ToString();
                    string Billdis = Ds.Tables[0].Rows[i]["Column21"].ToString();

                    gridmain.Rows[i].Cells["clnitemcode"].Value = Itemcode;
                    gridmain.Rows[i].Cells["clnitemname"].Value = ItemName;
                    gridmain.Rows[i].Cells["clnitemname"].Tag = ItemId;
                    gridmain.Rows[i].Cells["clnqty"].Value = tempqty;
                    gridmain.Rows[i].Cells["clnbatch"].Value = Batchcode;
                    gridmain.Rows[i].Cells["clnitemnote2"].Value = tempitemnote2;
                    gridmain.Rows[i].Cells["clnitemnote"].Value = tempitemnote;
                    gridmain.Rows[i].Cells["clnprate"].Value = tempprate;
                    gridmain.Rows[i].Cells["clnsrate"].Value = tempSrate;
                    gridmain.Rows[i].Cells["clnsrateperc"].Value = tempprofit;
                    gridmain.Rows[i].Cells["clnmrp"].Value = TempMrp;
                    gridmain.Rows[i].Cells["clntax"].Value = temptax;
                    gridmain.Rows[i].Cells["ClntaxPer"].Value = tempTaxPerc;
                    gridmain.Rows[i].Cells["clndiscount"].Value = discount;
                    gridmain.Rows[i].Cells["clndiscper"].Value = disper;
                    gridmain.Rows[i].Cells["clnfree"].Value = free;
                    gridmain.Rows[i].Cells["clncrate"].Value = tempcrate;
                    gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                    gridmain.Rows[i].Cells["clnbilldiscount"].Value = Billdis;
                    rowindex = i;
                    CellEnterCalculationPart();
                }

            }

        }

        public DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            dt.Columns.Clear();
            dt.Rows.Clear();
            foreach (DataGridViewColumn column in dgv.Columns)
            {

                dt.Columns.Add();
              
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            int k;
          
            return dt;
        }

        public void autosave()
        {
            RowValidation();

            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag.ToString() == "1")
                {
                    string ItemId = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                    string tempItemName = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Value);
                    string tempItemCode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemcode"].Value);
                    string tempbarcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                    string tempqty = _Dbtask.znllString(gridmain.Rows[i].Cells["clnqty"].Value);
                    string tempprate = _Dbtask.znllString(gridmain.Rows[i].Cells["clnprate"].Value);
                    string tempprofit = _Dbtask.znllString(gridmain.Rows[i].Cells["clnsrateperc"].Value);
                    string tempSrate = _Dbtask.znllString(gridmain.Rows[i].Cells["clnsrate"].Value);
                    string tempfree = _Dbtask.znllString(gridmain.Rows[i].Cells["clnfree"].Value);
                }
                string Filepath = @"D:\ztPurchase.tmp";

                for (i = 0; i < gridmain.Columns.Count; i++)
                {
                    if (gridmain.Rows[0].Cells[i].Value == null)
                    {
                        gridmain.Rows[0].Cells[i].Value = 0;
                    }
                }
                Dt = GetDataTableFromDGV(gridmain);
                Ds.Clear();
                Ds.Tables.Add(Dt);
                Ds.WriteXml(Filepath, System.Data.XmlWriteMode.IgnoreSchema);

            }
        }

        private void cmdautosave_Click(object sender, EventArgs e)
        {
            RetriveAutoSave();
        }

        private void lblexporttoexcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommonClass._report.LblHeading.Text = this.Text + " Invoice Vno ("+txtvno.Text+")";
            CommonClass._report.Exporttoexcel(gridmain);
        }

        private void cmdfillok_Click(object sender, EventArgs e)
        {
            int k=Convert.ToInt16(txtnofilling.textBox1.Text);

            ItemId = comfillitem.SelectedValue.ToString();
            for(int i=0;i<k;i++)
            {
                Countrow = gridmain.Rows.Add(1);
                rowindex = Countrow;
                gridmain.Rows[Countrow].Cells["clnslno"].Value = rowindex + 1;
                gridmain.Rows[Countrow].Cells["ClnItemCode"].Value = CommonClass._Itemmaster.SpecificField(ItemId, "itemcode");
                gridmain.Rows[Countrow].Cells["ClnItemName"].Value = CommonClass._Itemmaster.SpecificField(ItemId, "itemname");
                gridmain.Rows[Countrow].Cells["ClnItemName"].Tag = ItemId;
                gridmain.Rows[Countrow].Cells["clnprate"].Tag = CommonClass._Itemmaster.SpecificField(ItemId, "incs");
                gridmain.Rows[Countrow].Cells["ClnMRP"].Tag = CommonClass._Itemmaster.SpecificField(ItemId, "incp");

                gridmain.Rows[Countrow].Cells["clnprate"].Value = _Dbtask.znull(txtpratefilling.textBox1.Text);
                gridmain.Rows[Countrow].Cells["clnsrate"].Value = _Dbtask.znull(txtsratefilling.textBox1.Text);
                gridmain.Rows[Countrow].Cells["ClnMRP"].Value = _Dbtask.znull(txtmrpfilling.textBox1.Text);
                Getbatchcode();
            }
            BarcodeEditing();
            pnlbill.Visible = false;
        }

        public void directprint()
        {
            if (ComPrintSheme.SelectedIndex == 0)
                PrintBarcode();
            if (ComPrintSheme.SelectedIndex == 1)
                PrintInvoice();
        }

        private void cmdadprint_Click(object sender, EventArgs e)
        {
            if(ComPrintSheme.SelectedIndex==0)
            PrintBarcode();
            if (ComPrintSheme.SelectedIndex == 1)
                PrintInvoice();
        }

        private void cmdpnlsettingsclose_Click(object sender, EventArgs e)
        {
            pnlprintsettings.Visible = false;
        }

        private void cmdbrowsebill_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Images";
            theDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|GIF Files (*.bmp)|*.bmp";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                cmdbrowsebill.Tag = theDialog.FileName;
            }
        }

        private void cmdshowbill_Click(object sender, EventArgs e)
        {
            Frmimage _image = new Frmimage();
            _image.Id = txtvno.Text;
            _image.fromform = "PI";
            _image.ShowDialog();
        }

        private void gridmain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Columnname == "clnserialno")
                {
                    pnlslno.Visible = true;
                    if (gridmain.Rows[rowindex].Cells["clnserialno"].Value != null)
                        CommonClass._SelectReport.Fillinlist(Lstslno, gridmain.Rows[rowindex].Cells["clnserialno"].Value.ToString());
                    else
                        Lstslno.Items.Clear();
                }
                else if (Columnname == "clnqty")
                {
                    if (_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) != ""&&_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Tag) !="")
                    {
                        Frmquickadditems _Form = new Frmquickadditems();
                        _Form.EditMode = true;
                        _Form.Barcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                        _Form.Id = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + _Form.Barcode + "'").ToString();
                        _Form.ShowDialog();
                    }
                }
            }
            catch
            {
            }


        }

        private void cmdslnook_Click(object sender, EventArgs e)
        {
            if (txttypeslno.textBox1.Text != "")
            {
                if (CommonClass._Slno.ShowSlno(" where itemid !='" + ItemId + "' and slno='" + txttypeslno.textBox1.Text + "'").Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Slno already used in other item", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               //else if (CommonClass._Slno.ShowSlno(" where itemid ='" + ItemId + "' and slno='" + txttypeslno.textBox1.Text + "'").Tables[0].Rows.Count <= 0)
               // {
               //     MessageBox.Show("Slno Not exsting this item", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // }
                else
                {
                    Lstslno.Items.Add(txttypeslno.textBox1.Text);
                }
            }
            txttypeslno.textBox1.Text = "";
            txttypeslno.textBox1.Focus();
        }

        private void cmdslnofill_Click(object sender, EventArgs e)
        {
            gridmain.Rows[rowindex].Cells["clnserialno"].Value = CommonClass._SelectReport.ShowSelectedinList(Lstslno);
            gridmain.Rows[rowindex].Cells["clnqty"].Value = Lstslno.Items.Count;
            pnlslno.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlslno.Visible = false;
        }

        private void cmdslnodelete_Click(object sender, EventArgs e)
        {
            if (Lstslno.SelectedItems.Count > 0)
                Lstslno.Items.Remove(Lstslno.SelectedItem);

          //  Lstslno.Refresh();
        }

        private void txttypeslno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txttypeslno.textBox1.Text != "")
                {
                    if (CommonClass._Slno.ShowSlno("select * from tblslnotracking where itemid !='" + ItemId + "'").Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Slno already used in other item", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Lstslno.Items.Add(txttypeslno.textBox1.Text);
                    }
                }
                txttypeslno.textBox1.Text = "";
                txttypeslno.textBox1.Focus();
            }
        }

        private void txttypeslno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
            }
        }

        private void gridmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FudeleteRow()
        {
            int selectedIndex = gridmain.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                gridmain.Rows.RemoveAt(selectedIndex);
                TottalAmountCalculate();
            }
        }

        private void Cmddeleterow_Click(object sender, EventArgs e)
        {
            FudeleteRow(); 
        }

        public void TWOinch(string Pselect)
        {



            _twoinch.PTYpe = this.Text;
            _twoinch.TempCust = TxtAccount.Text;

            // _Thermal.TDiscount = (Convert.ToDouble(txtinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _twoinch.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _twoinch.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _twoinch.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            //_Thermal.SSlnotracking = SSerialnotracking;
            //_Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _twoinch.saleNarration = TxtNaration.textBox1.Text.ToString();
            _twoinch.TDiscount = Txtcashdiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _twoinch.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _twoinch.BillDate = dtdate.Value;
            _twoinch.Billno = txtvno.Text;
            _twoinch.TgrossAmt = TxtTGross.Text;
            _twoinch.Totherexpense = txtotherexpenses.Text;
            _twoinch.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _twoinch.TotalNetamount = NetTottal;
            _twoinch.FormType = this.Text;
            _twoinch.Ttaxamount = txtttax.Text;
            _twoinch.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _twoinch.ModeofPayment = "CASH";
            else
                _twoinch.ModeofPayment = "CREDIT";

            _twoinch.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _twoinch.PSelect = comprint.Text;
            _twoinch.Lid = _Dbtask.znllString(TxtAccount.textBox1.Tag);

            // _Laser.STax = STax;
            _twoinch.PrintInvoice(gridmain);
        }


        public void Normal3PointarabicPURCHNOTAX(string Pselect)
        {



            _arabpurchNOTAX.PTYpe = this.Text;
            _arabpurchNOTAX.TempCust = TxtAccount.Text;

            // _Thermal.TDiscount = (Convert.ToDouble(txtinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _arabpurchNOTAX.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _arabpurchNOTAX.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _arabpurchNOTAX.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            //_Thermal.SSlnotracking = SSerialnotracking;
            //_Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _arabpurchNOTAX.saleNarration = TxtNaration.textBox1.Text.ToString();
            _arabpurchNOTAX.TDiscount = Txtcashdiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _arabpurchNOTAX.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _arabpurchNOTAX.BillDate = dtdate.Value;
            _arabpurchNOTAX.Billno = txtvno.Text;
            _arabpurchNOTAX.TgrossAmt = TxtTGross.Text;
            _arabpurchNOTAX.Totherexpense = txtotherexpenses.Text;
            _arabpurchNOTAX.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _arabpurchNOTAX.TotalNetamount = NetTottal;
            _arabpurchNOTAX.FormType = this.Text;
            _arabpurchNOTAX.Ttaxamount = txtttax.Text;
            _arabpurchNOTAX.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _arabpurchNOTAX.ModeofPayment = "CASH";
            else
                _arabpurchNOTAX.ModeofPayment = "CREDIT";

            _arabpurchNOTAX.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _arabpurchNOTAX.PSelect = comprint.Text;
            _arabpurchNOTAX.Lid = _Dbtask.znllString(TxtAccount.textBox1.Tag);

            // _Laser.STax = STax;
            _arabpurchNOTAX.PrintInvoice(gridmain);
        }

        public void Normal3Pointarabic(string Pselect)
        {



            _arabpurch.PTYpe = this.Text;
            _arabpurch.TempCust = TxtAccount.Text;

            // _Thermal.TDiscount = (Convert.ToDouble(txtinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _arabpurch.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _arabpurch.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _arabpurch.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            //_Thermal.SSlnotracking = SSerialnotracking;
            //_Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _arabpurch.saleNarration = TxtNaration.textBox1.Text.ToString();
            _arabpurch.TDiscount = Txtcashdiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _arabpurch.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _arabpurch.BillDate = dtdate.Value;
            _arabpurch.Billno = txtvno.Text;
            _arabpurch.TgrossAmt = TxtTGross.Text;
            _arabpurch.Totherexpense = txtotherexpenses.Text;
            _arabpurch.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _arabpurch.TotalNetamount = NetTottal;
            _arabpurch.FormType = this.Text;
            _arabpurch.Ttaxamount = txtttax.Text;
            _arabpurch.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _arabpurch.ModeofPayment = "CASH";
            else
                _arabpurch.ModeofPayment = "CREDIT";

            _arabpurch.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _arabpurch.PSelect = comprint.Text;
            _arabpurch.Lid = _Dbtask.znllString(TxtAccount.textBox1.Tag);

            // _Laser.STax = STax;
            _arabpurch.PrintInvoice(gridmain);
        }

        public void Normal3PointLaserpurchnotax(string Pselect)
        {



            _thermlpurchnotax.PTYpe = this.Text;
            _thermlpurchnotax.TempCust = TxtAccount.Text;

            // _Thermal.TDiscount = (Convert.ToDouble(txtinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _thermlpurchnotax.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _thermlpurchnotax.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _thermlpurchnotax.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            //_Thermal.SSlnotracking = SSerialnotracking;
            //_Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _thermlpurchnotax.saleNarration = TxtNaration.textBox1.Text.ToString();
            _thermlpurchnotax.TDiscount = Txtcashdiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _thermlpurchnotax.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _thermlpurchnotax.BillDate = dtdate.Value;
            _thermlpurchnotax.Billno = txtvno.Text;
            _thermlpurchnotax.TgrossAmt = TxtTGross.Text;
            _thermlpurchnotax.Totherexpense = txtotherexpenses.Text;
            _thermlpurchnotax.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _thermlpurchnotax.TotalNetamount = NetTottal;
            _thermlpurchnotax.FormType = this.Text;
            _thermlpurchnotax.Ttaxamount = txtttax.Text;
            _thermlpurchnotax.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _thermlpurchnotax.ModeofPayment = "CASH";
            else
                _thermlpurchnotax.ModeofPayment = "CREDIT";

            _thermlpurchnotax.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _thermlpurchnotax.PSelect = comprint.Text;
            _thermlpurchnotax.Lid = _Dbtask.znllString(TxtAccount.textBox1.Tag);

            // _Laser.STax = STax;
            _thermlpurchnotax.PrintInvoice(gridmain);
        }



        public void Normal3PointLaser(string Pselect)
        {



            _thermlpurch.PTYpe = this.Text;
            _thermlpurch.TempCust = TxtAccount.Text;

           // _Thermal.TDiscount = (Convert.ToDouble(txtinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _thermlpurch.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _thermlpurch.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _thermlpurch.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            //_Thermal.SSlnotracking = SSerialnotracking;
            //_Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _thermlpurch.saleNarration = TxtNaration.textBox1.Text.ToString();
            _thermlpurch.TDiscount = Txtcashdiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _thermlpurch.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _thermlpurch.BillDate = dtdate.Value;
            _thermlpurch.Billno = txtvno.Text;
            _thermlpurch.TgrossAmt = TxtTGross.Text;
            _thermlpurch.Totherexpense = txtotherexpenses.Text;
            _thermlpurch.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _thermlpurch.TotalNetamount = NetTottal;
            _thermlpurch.FormType = this.Text;
            _thermlpurch.Ttaxamount = txtttax.Text;
            _thermlpurch.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _thermlpurch.ModeofPayment = "CASH";
            else
                _thermlpurch.ModeofPayment = "CREDIT";

            _thermlpurch.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _thermlpurch.PSelect = comprint.Text;
            _thermlpurch.Lid = _Dbtask.znllString(TxtAccount.textBox1.Tag);

            // _Laser.STax = STax;
            _thermlpurch.PrintInvoice(gridmain);
        }
        public void SaveSettings()
        {
            /*For Default Printer*/
            //CommonClass.temp = comprint.SelectedIndex.ToString();
            //// CommonClass._Paramlist.UpdateParamlist("SPrintSelect", "1", CommonClass.temp);

            //CommonClass._Dbtask.SetPrinterSelectbcode(CommonClass.temp);
            CommonClass.temp = comprint.Text;
            CommonClass._Dbtask.SetPrinterpurchase(CommonClass.temp);

        }
        private void comprint_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void PnlGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtcashdiscount_Leave(object sender, EventArgs e)
        {
            Txtcashdiscount.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(Txtcashdiscount.textBox1.Text)));
            if (_Dbtask.znlldoubletoobject(Txtcashdiscount.textBox1.Text) == 0)
            {
                TxttypebilldiscountPerc.textBox1.Text = "";
                //txtbillamount.Text = _Dbtask.znllString(NetAmount);
            }
        }

        private void TxttypebilldiscountPerc_Leave(object sender, EventArgs e)
        {
            TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(TxttypebilldiscountPerc.textBox1.Text)));
            if (_Dbtask.znlldoubletoobject(TxttypebilldiscountPerc.textBox1.Text) == 0)
            {
                Txtcashdiscount.textBox1.Text = "";
               // txtbillamount.Text = _Dbtask.znllString(NetAmount);
            }
        }

        private void txtotherexpenses_Leave(object sender, EventArgs e)
        {
            txtotherexpenses.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(txtotherexpenses.textBox1.Text)));
        }

        private void TxtNaration_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Remarks", "TbltransactionReceipt", TxtNaration.textBox1);

        }

        private void chkprintconfirmation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkPrintWileSaving_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPrintWileSaving.Checked == true)
            {
                pritwhile = true; 
               CommonClass._Menusettings.UpdateMenusettings("218", "1");

            }
            else
            {
                pritwhile = false;
                CommonClass._Menusettings.UpdateMenusettings("218", "-1");
            }
            
            }

        private void cmdaddcustomer_Click(object sender, EventArgs e)
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.WheregroupeQuerye = " WHERE AUnder=19 or AGroupId=19";
            Generalfunction.Comeform = "MDISUPPLIER";
            _Form.ShowDialog();
        }

        

        

        


    }
}
