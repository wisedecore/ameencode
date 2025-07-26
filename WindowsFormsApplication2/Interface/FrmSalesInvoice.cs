using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace WindowsFormsApplication2
{
    public partial class frmsalesinvoice : Form
    {
        public frmsalesinvoice()
        {
            InitializeComponent();
        }

        public string minivalbillnum = "";
        ClsMostmoving _mostmove = new ClsMostmoving();
        Clsinvlaserhalf _afive = new Clsinvlaserhalf();
        public string vnoname = ""; public static string DIRECTSRVNO = "";
        ClsinvlaserSix _lasersix = new ClsinvlaserSix();
        ClsinvlaserNewafour _Afournew = new ClsinvlaserNewafour();
        public double olBLC = 0; public double NOWBLC = 0;
        ClsinvlaserQatar _qatar = new ClsinvlaserQatar();
        ClsinvlaserQatarEST _Qatarest = new ClsinvlaserQatarEST();
        ClsinvlaserQatarDN _Qtrdn = new ClsinvlaserQatarDN();
        ClsinvlaserFive _laserfive = new ClsinvlaserFive();
        ClsinvlaserFour _laserfour = new ClsinvlaserFour();
        Clsinvlaserseven _lasewrseven = new Clsinvlaserseven();
        Clsinvlasereight _lasreight = new Clsinvlasereight();
        ClsinvlaserNine _lasernine = new ClsinvlaserNine();
        ClsTwoinchThermal _ThermalTwoInch = new ClsTwoinchThermal();
        ClsinvlaserSixitemNOTAX _namenotax = new ClsinvlaserSixitemNOTAX();

        ClsinvlaserNineNoTAX _Notaxnine = new ClsinvlaserNineNoTAX();
        ClsinvlaserSixWorkshop _workshoplaser = new ClsinvlaserSixWorkshop();
        ClsinvlaserSixWorkshopNOTAX _Notaxworkshop = new ClsinvlaserSixWorkshopNOTAX();
        public bool Tdetail = false; public bool empl = false;
        public bool PrintSecondprint;
        public bool Activewindow;
        public bool IfPrintPreview;
        public string ReportPrint;
        public string userNo = "";
        public static string svno="";
        public static string stocksetting = "-1'";
        public static string stockbottom = "-1'";

      public static string  MINofSI="";
public static string MINofSO="";
public static string MINofSQ="";
public static string MINofSR="";
public static string MINofSIwh = "";

public static string MTReadf = "";
public static string vehiclesf = "";

public static int itemcodewid = 200;
public static int batchwidth = 200;
public static int itemwid = 200;
public static int langwidth = 200;

public static string Pvnoval = "";
public static string PvnovalSR = "";

        public static bool DIRECTSR = false;
        public string Secndpayactive = "";
        public bool Secndnow = false;
                ClsParamlist _param = new ClsParamlist();
        //bcoderefill
                public static string userwisedisc = "";
                public static string userwisediscallow = "";
                public static string Stgbcodeprefx = "";
                public static string stgweigndigit = "";

                public static string stgweignbcodeSrt = "";
                public static string stgweignbcodeEnd = "";

        public static string stgweignqtyMNU = "";
        public static string stgweignqtySrt = "";
        public static  string stgweignqtyEnd = "";
        public static string stgweignqtyDiv = "";

        public static string stgweignrateMNU = "";
        public static string stgweignrateSrt = "";
        public static string stgweignrateEnd = "";
        public static string stgweignrateDiv = "";
        public static string stgweignrateRound = "";

        
        public string CreditLimit = "";
        public static string SalerateLessLastrate = "";
       public  string SecondprinterVALUE = "";

       public static string WGmitemcode = "";

       public static string WGmitemname = "";
       public static  string WGmsrate = "";
       public static string WGmrack = "";
       public static string WGmmrp = "";
       public static string WGmbcode = "";
       public static string WGmprate = "";


        public int frstival = 0;
        public bool frstibool = false;

        public static bool twotypepaymnt = false;
        public bool BUNIT = false;
        public bool isitbcode = false;
        public static int mrowindx = 0;
        public bool IsEnterGrid = false; ClsinvlaserThree _laserthree = new ClsinvlaserThree();
        ClsInvThermal _Thermal = new ClsInvThermal();

        ClsInvThermalNOTax _ThermalNOTAX = new ClsInvThermalNOTax();
        ClsInvThermalarab _arabthermal = new ClsInvThermalarab();
        ClsInvThermalarabNoTax _arabthermalnotax = new ClsInvThermalarabNoTax();
        ClsPHASEtwocompanyprofile _PhaseTwocompanyprof = new ClsPHASEtwocompanyprofile();

        public bool nocustmr = false;
        /*For Print*/
        private string InvImage;
        RichTextBox Chktemp = new RichTextBox();
        public string text;
        public string VNo;
        public string Space;
        public int position;
        public int positn1 = 0;
        public int positionAfter;
        public string CustomerTag;
        public int PrintRowIndex;
        public string maxledid = "";
        public string Tnamee = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";
        public string VEHICLE = "";
        public string MTRREAD = "";
        public double TBillAmount;
        /*Unit*/
        public string SecUnit = "";
        public string FirUnit = "";
        public double Convrt = 0;
        public double Unitamount1 = 0;
        public double UnitAmount2 = 0;
        public string UnitCode = "";
        string Unitid;
        string UnitName;
        public double unitGross = 0;
        public string Pcode;
        public bool ComText = false;
        public string PrintBalance;

        DataGridViewCellStyle dataGridViewCellStyleNew = new DataGridViewCellStyle();
        /*For Op Use */
        public string OpId;
        /*For Using Service*/

        public string jobcardId;
        bool Ennteringridcell;
       public double InvoiceDiscount;
    

       public string NewData;
       public string OldData;
       public string StrVtyp;
        /*For Common Printing*/
         string Passing;
         string pno;
         string TPaidAmount;
         string PrintingInvoiceName;
         PrinterSettings PrSettings;
         PrintDocument pd = new PrintDocument();
        /***********************************/
        string StrPurticulars;
        string StrPurticularsForLedger;
        /*************SiZE Ini Temp*********************/
        public bool ShowSubpanel=true;
        public bool SearchBarcode;
        public bool PrintNextpage;
        public int OverLimit;
        public int k;
        public bool IsEnterSize;
        public long TRowCounting;
        public bool NextIteminsize;
        public string BackSizelessName;
        public string SizelessName;
        public string SizeQty;
        public string SizeRate;
        public string SizeAmount;
        public string SizeItemName;
        public string SizeNaration;
        public int NoofCopies;
        public DialogResult Result;
        string TempPreId;
        string TemppreName;

        int M = 0;
        /****************************************/

        /*For Nowing Settings*/

        public string NSstatus;
        public bool Bmode;
        public bool SSlnotracking;
        /**********************************/
        public static DataGridView Grd1;
        private Font InvTitleFont = new Font("Arial", 7, FontStyle.Regular);
        /*For Printing*/

        string PInvoiceName = "";
        string FormType;

        string tempinvvty;
        public int Retrivemode = 0;
        public int rowindex;
        public int rowindexSize;
        public int columnindex;
        public int columnindexSize;
        public int Countrow;
        public string ColumnName;
        public bool Isinotherwindow = false;
        public bool Registration = false;

        UscGridshow _usc2 = new UscGridshow();
        /*For Printing*/
        Clsdotmetrixprintsettings _Dotmetrix = new Clsdotmetrixprintsettings();

        /********************************/
        Clssales _sales = new Clssales();
        LPrinter MyPrinter=new LPrinter();
        Clssettings _Settings = new Clssettings();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
        AmountInWords _word = new AmountInWords();
       // MDIParent1 _Mdi = new MDIParent1();
        ClsInventory _Inventory = new ClsInventory();
        ClsBusinessIssue _BusinessIssue = new ClsBusinessIssue();
        ClsIssueDetails _IssueDetails = new ClsIssueDetails();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsDepot _Depot = new ClsDepot();
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsMultiRates _MultiRates = new ClsMultiRates();
        ClsMultiUnits _MultiUnits = new ClsMultiUnits();
        ClsItemMaster _ItemMaster = new ClsItemMaster();
        ClsVoucherType _VouchrType = new ClsVoucherType();
        ClsInGrid _Ingrid = new ClsInGrid();
        Clsbatch _Batch = new Clsbatch();
        ClsAgent _Agent = new ClsAgent();
        Clssizes _Size = new Clssizes();
        Clsforms _Forms = new Clsforms();
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        DataSet DS3 = new DataSet();
        DataSet DSSalesreturn = new DataSet();
       public static DataSet DSSalesreturnRetrive = new DataSet();

        DataTable Dt = new DataTable();
        DataSet Ds2 = new DataSet();
        ClsproductRate _Productrate = new ClsproductRate();
        Clsinvlaser _Laser = new Clsinvlaser();
        Clsinvlaser1 _Laser1 = new Clsinvlaser1();
        ClsinvlaserSimple _LaserSimple = new ClsinvlaserSimple();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        Clsselectreport _SelectReport = new Clsselectreport();
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        Clstax _Tax = new Clstax();
        Generalfunction _Gen = new Generalfunction();
        public  RichTextBox RichTextBox1 = new RichTextBox();
        public RichTextBox RichTextBox2 = new RichTextBox();


      public long vnum1;
        public string Majorsymbol;
        public string Minersymbol;
        public string AmountinWords;
        DateTime DtTemp;
       public string ItemId;
        string StringTemp;
        bool IsEnter;
        public string Vtype;
        NextGFuntion _Nextg = new NextGFuntion();
        public bool Isitemedit = false;
        public bool Itemnameclick = false;
        public double TottalAmount;
        public string CreditedLedcode;
        public string Ledid;
        public string DebitedLedCode;
        public string PurticularsDr;
        public string PurticularsCr;
        public string SalesAccount;
        public string Heading;
        public string Batchcode = "";
        public Color PnlHeadingColor;
        double Netitemdiscount;
        double NetTottal;
        double NetMrp;
        double NetSrate;
        double NetQty;
        double NetDiscou;
        double NetFree;
        double NetTax;
        double NetGross;
        double NetAmount;
        double BillAmount;
        double AgentAmt;
        double StaffAmt;
        double Templedouble;
        double TaxAmt;
        double TaxPerc;
        double TottalDiscount;
        double NetinvoiceDiscount;
        double TottalTax;
        string CashReceivedTxt="";
        string SalesReturnText="";
        string SRvno;
        double Stock;
        double roundof=0;
        bool EditMode = false;
        string SampleVtype;
        long PProject;
        string staffid = "0";
        string agentid = "0";
        public string StockareaId = "0";

        public int Mrate;
        public int Munit = 0;
        public int Stax;
        public int Sfree;
        
        public int SDiscount;
        public int Sbarcode;
        public string temp;

        public int SearchCreditor = 0;



        int selectedRow; /*For Get Row Index Of Product Grid */


        /*Settings*/
        public string Printerselect;
        public bool Salesarea = false;
        public bool Zerotaxsave = false;
        public bool Sitemwiseagentcommision = false;
        public bool SBatch = false;
        public bool SSitemDiscount = false;
        public bool SSfree = false;
        public bool SSWmachine;
        public bool Seditsrate = false;
        public bool STax = false;
        public bool SDepo = false;
        public bool Smrate = false;
        public bool Smunit = false;
        public bool Sagent = false;
        public bool Semployee = false;
        public bool Supdatesrate = false;
        public bool Useasbarcode = false;
        public bool SSsizes = false;
        public bool Sprintwhilesaving = false;
        public bool Spconfirmation = false;
        public bool SprintPreview = false;
        public bool SUnit = false;
        public bool SFlex;
        public bool SCashDesk;
        public bool SSerialnotracking;
        public bool Sinvoicediscount;
        public bool Spharmacy;
        public bool EditGross;
        public bool VisibleSrate;
        public bool RemoveDublicate;
        public bool SRoundoff;
        public bool Spartyproject;
        public bool SSaveZeroRate = false;
        public bool Searchingmode;
        public bool Enableprinterselection;
        public bool Enableitemnote;
        /*For Simple itemmaster Insert*/


        public string Tempiname;
        public string Tempiid;
        public string Tempicode;
        public string TempSrate;
        public string TempPrate;
        public string TempCrate;
        public string TempMrp;

        /*NextgIniti*/

        public double NQty = 0;
        public double NRate = 0;
        public double NMrp = 0;
        public double NDiscper = 0;
        public double NBillDisc = 0;
        public double NDiscamt = 0;
        public double NGross = 0;
        public double NNetamout = 0;
        public double NFree = 0;
        public double NTaxperc = 0;
        public double NTaxamount = 0;
        public double Nlength = 0;
        public double Nwidth = 0;
        public double Nsqfeat = 0;
        /***********************/

        /*For Printing*/

        public double currentbalance;
        public double OldBalance;
        public string SavedAmount;
        public string Selectedprint;
        public int XX = 75;
        public int YY = 25;
        public int YY1;

        //For Barcode Updations
        public int BatchFoundIndex;
        public int PrevRowIndex;

        //For Language Updation
        public bool IsArabic;

      
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null )//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "pnlbill" )
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
                            return true;
                        }
                        if (msg.WParam.ToInt32() == (int)Keys.Up)
                        {
                            return true;

                        }
                    }
                    if (Gridbatchlist.Visible == true)
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
                    if (GridUnitList.Visible == true)
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

        public bool IsBatchFound(string BarCode)
        {
            //bool IsFound = false;

            int count = 0;

            if (gridmain.Rows.Count > 1)
            {

                for (int a = 0; a < gridmain.Rows.Count; a++)
                {
                    if (_Dbtask.znlldoubletoobject(gridmain.Rows[a].Cells["clnnettamount"].Value) != 0)
                    {
                        
                        if (_Dbtask.znllString(gridmain.Rows[a].Cells["clnbatch"].Value) == BarCode&&a!=rowindex)
                        {
                            BatchFoundIndex = a;
                            count = count + 1;
                            break;
                        }
                    }
                }
            }
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CalcInvoiceprofit()
        {
            RowValidation();
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {

                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            if (txtvno.Text != "")
                            {
                                if (TxtAccount.Tag != null)
                                {
                                    
                                }
                            }
                        }
                    }

                }

            }
            catch
            {

            }
        }

        public void MINVALSET()
        {

            if (Vtype == "SI" && SalesAccount == "2")
            {
                minivalbillnum = MINofSI;

            }
            if (Vtype == "SO")
            {
                minivalbillnum = MINofSO;

            }
            if (Vtype == "SQ")
            {
                minivalbillnum = MINofSQ;

            }
            if (Vtype == "SR")
            {
                minivalbillnum = MINofSR;

            }
            if (Vtype == "SI" && SalesAccount != "2")
            {
                minivalbillnum = MINofSIwh;

            }
        }


        public void directtosalereturn(string fvnonew, string VOUCHER)
        {
            string TempSalesAccount = "2";
            string FVno = fvnonew;
            string vouchername = "";
            vouchername = VOUCHER;
            if (vouchername == "Sales" || vouchername == "Estimate" || vouchername == "SI")
            {
                SampleVtype = "SI";
            }
            if (vouchername == "Sales Order")
            {
                SampleVtype = "SO";
            }
            if (vouchername == "Sales Quatation")
            {
                SampleVtype = "SQ";
            }
            if (vouchername == "Sales Return")
            {
                SampleVtype = "SR";
            }
            if (vouchername == "Purchase")
            {
                SampleVtype = "PI";
            }
            if (vouchername == "Purchase Order")
            {
                SampleVtype = "PO";
            }

            if (vouchername == "Delevery note")
            {
                SampleVtype = "DN";
            }
            if (SampleVtype == "CRM" || SampleVtype == "DN" || SampleVtype == "SO" || SampleVtype == "SQ" || SampleVtype == "SI" || comfillingselectvoucher.Text == "Estimate")
            {
                if (comfillingselectvoucher.Text != "Estimate")
                    SalesAccount = "2";
                else
                    SalesAccount = CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate", "lid");

                PreIssueTransaction(FVno, false, SampleVtype, true);
            }
            if (SampleVtype == "PI" || SampleVtype == "PO" || SampleVtype == "SR")
            {
                SalesAccount = "3";
                PreReceiptTransaction(FVno, false, SampleVtype, true);
            }
            SalesAccount = TempSalesAccount;
            GetVno();
            pnlbill.Visible = false;
        }
        public void TempCellEnterCalculationPart(int TempRowIndex)
        {
            try
            {
                //InsertZeroValue();
                gridmain.Rows[TempRowIndex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(NQty);
                gridmain.Rows[TempRowIndex].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(NFree);
                gridmain.Rows[TempRowIndex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(NRate);

                gridmain.Rows[TempRowIndex].Cells["clnlength"].Value = _Dbtask.SetintoDecimalpointStock(Nlength);
                gridmain.Rows[TempRowIndex].Cells["clnwidth"].Value = _Dbtask.SetintoDecimalpointStock(Nwidth);
                gridmain.Rows[TempRowIndex].Cells["clnsqfl"].Value = _Dbtask.SetintoDecimalpoint(Nsqfeat);

                gridmain.Rows[TempRowIndex].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(NTaxamount);
                gridmain.Rows[TempRowIndex].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(NDiscamt);
                gridmain.Rows[TempRowIndex].Cells["clnbilldiscount"].Value = _Dbtask.SetintoDecimalpoint(NBillDisc);
                gridmain.Rows[TempRowIndex].Cells["clndiscper"].Value = _Dbtask.SetintoDecimalpoint(NDiscper);
                gridmain.Rows[TempRowIndex].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(NMrp);

                //gridmain.Rows[TempRowIndex].Cells["clnsgst"].Value = _Dbtask.SetintoDecimalpoint(NSgstTaxamount);
                //gridmain.Rows[TempRowIndex].Cells["clnsgstPerc"].Value = _Dbtask.SetintoDecimalpoint(NSgstTaxperc);
                //gridmain.Rows[TempRowIndex].Cells["clncgst"].Value = _Dbtask.SetintoDecimalpoint(NCgstTaxamount);
                //gridmain.Rows[TempRowIndex].Cells["clncgstPerc"].Value = _Dbtask.SetintoDecimalpoint(NCgstTaxperc);
                //gridmain.Rows[TempRowIndex].Cells["clnigst"].Value = _Dbtask.SetintoDecimalpoint(NIgstTaxamount);
                //gridmain.Rows[TempRowIndex].Cells["clnsgstPerc"].Value = _Dbtask.SetintoDecimalpoint(NIgstTaxperc);

                //if (SUnit == true)
                //{
                //    NGross = NRate * (Convrt * NQty);
                //}
                //else
                //{
                NGross = NQty * NRate;

                if (Nsqfeat != 0)
                    NGross = NGross * Nsqfeat;
                //}
                NGross = NGross - NDiscamt;
                NNetamout = NGross;
                int tRowintex;
                tRowintex = rowindex;
                rowindex = TempRowIndex;
                if (Retrivemode == 0)
                {
                    TaxCalcPart();
                }
                rowindex = tRowintex;
                gridmain.Rows[TempRowIndex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(NNetamout); /* For Cell Net Amount*/
                gridmain.Rows[TempRowIndex].Cells["Clngross"].Value = _Dbtask.SetintoDecimalpoint(NGross);
            }
            catch
            {
            }
        }

        public void FuPasingEnetr()
        {
            
                    if(_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) !=""||uscGridshow2.Visible==true)
                    {
                        int NowselectedRow=new int();
                        string TempBathcode;
                        if (uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count>0)
                        {
                            NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                            TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                        }
                        else
                        {
                            TempBathcode =_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                        }


                        _sales.BarcodeRefilling(TempBathcode);
                            TempBathcode = _sales.Bcode;
                            if (SearchBarcode == true)
                            {
                                gridmain.Rows[rowindex].Cells["clnexpiry"].Value = _Dbtask.ZnullDatetime(uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["ex Date"].Value);
                            }
                        string ITENIDD="";
                            //string bunit = "";
                            //bunit = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='302010'").ToString();
                            if (BUNIT==true)
                            {
                                ////gridmain.Columns["clnbaseu"].Visible = true;
                                ITENIDD = _Batch.GetSpecificFieldByBarcode("ITEMID", TempBathcode);

                                gridmain.Rows[rowindex].Cells["clnBaseU"].Tag = _Batch.GetSpecificFieldofBatch(TempBathcode, "baseU");
                                string BU = "";
                                BU = gridmain.Rows[rowindex].Cells["clnBaseU"].Tag.ToString();
                                gridmain.Rows[rowindex].Cells["clnBaseU"].Value =_Dbtask.znllString( _Dbtask.ExecuteScalar("select name from tblbaseunit where id='" + BU + "'"));

                            }
                            else
                            {
                                //ridmain.Rows[rowindex].Cells["ClnbaseU"].Visible = false;
                            }
                        //bool PnlExpire = true;

                        //Expiry Barcode*/
                        //    DS3 = _Dbtask.ExecuteQuery(" select exdate,srate from tblbatch where Bcode = '" + gridmain.Rows[rowindex].Cells["clnbatch"].Value + "'");

                        //if (DS3.Tables[0].Rows.Count > 1)
                        //{
                        //    FrmExpirysales _Exp = new FrmExpirysales();
                        //    _Exp.Ds = DS3;
                        //    _Exp.BatchCode = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                        //    _Exp.ShowDialog();

                        //}
                        //else
                        //{
                        //    Clssales.PassExpiryDate = "";
                        //    Clssales.PassExpiryRate = "";
                        //}
                        /**********************************************************/
                        //NowselectedRow = GridExDate.SelectedRows[0].Index;
                      //  TempBathcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);



                            Clssales.PassExpiryDate = "";
                            Clssales.PassExpiryRate = "";

                            PrevRowIndex = gridmain.CurrentRow.Index;
                            

                        if (IsBatchFound(TempBathcode) == false || Clssales.PassExpiryRate!=""||_sales.Nrate!=0)
                        {

                            NQty = _sales.NQty;
                            


                            if (Vtype == "SV")
                                Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "' and itemid in (select itemid from tblitemmaster where itemclass ='Services')");
                            else

                                Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "' and itemid in (select itemid from tblitemmaster where itemclass !='Services')");

                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                string Tempitemid = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                                ItemId = Tempitemid;
                                gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
                                gridmain.Rows[rowindex].Cells["clnlang"].Value = _Dbtask.ExecuteScalar("select llang from tblitemmaster where itemid='" + Tempitemid + "'");
                                gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = Tempitemid;

                                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
                                ShowStockinLabel(TempBathcode, Tempitemid, StockareaId);
                                gridmain.Rows[rowindex].Cells["clnqty"].Value = NQty;


                                double TempSrate;
                                if (Clssales.PassExpiryDate == "")
                                {
                                    TempSrate = Convert.ToDouble(_Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
                                    gridmain.Rows[rowindex].Cells["clnexpiry"].Value =(_Dbtask.ZnullDatetime(_Batch.GetSpecificFieldofBatch(TempBathcode, "exdate"))).ToString("dd-MM-yyyy");
                                }
                                else
                                {
                                    TempSrate = _Dbtask.znullDouble(Clssales.PassExpiryRate);
                                    gridmain.Rows[rowindex].Cells["clnexpiry"].Value =_Dbtask.ZnullDatetime(Clssales.PassExpiryDate).ToString("dd-MM-yyyy");
                                }

                                double TempMrp = Convert.ToDouble(_Batch.GetSpecificFieldofBatch(TempBathcode, "mrp"));
                                if (_sales.Nrate == 0)/*Checking for Wieght mechine*/
                                {
                                    if (Smrate == true && comratetype.SelectedIndex == 1)
                                    {
                                        TempSrate = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(rate),0) from tblproductrate where pcode ='" + Tempitemid + "' and batchid='" + TempBathcode + "'"));
                                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);
                                    }
                                    else
                                    {
                                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);
                                    }
                                }
                                else
                                {
                                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _sales.Nrate;
                                }

                                gridmain.Rows[rowindex].Cells["ClnMRP"].Value = _Dbtask.SetintoDecimalpoint(TempMrp);
                                gridmain.Rows[rowindex].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + Tempitemid + "'");

                                gridmain.Rows[rowindex].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(0);
                                gridmain.Rows[rowindex].Cells["clndiscper"].Value = _Dbtask.SetintoDecimalpoint(0);
                                gridmain.Rows[rowindex].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(0);


                                NQty = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                                NFree = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                                NRate = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                                NTaxamount = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clntax"].Value);
                                NDiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                                NDiscper = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
                                NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);

                                /*For MultiUnit*/
                                if (SUnit == true)
                                {
                                    Unitid = CommonClass._Unitcreation.Getunitofitem(ItemId);
                                    gridmain.Rows[rowindex].Cells["ClnUnit"].Tag = Unitid;
                                    gridmain.Rows[rowindex].Cells["ClnUnit"].Value = CommonClass._Unitcreation.Getspesificfield("name", Unitid.ToString());
                                    Convrt = _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", ItemId));
                                    NRate = NRate * Convrt;
                                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = NRate;
                                }

                                uscGridshow2.Visible = false;
                                CellEnterCalculationPart();
                                TottalAmountCalculate(true);

                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBathcode;
                                gridmain.NotifyCurrentCellDirty(false);

                               
                                gridmain.Select();
                                gridmain.CurrentCell = gridmain.Rows[rowindex ].Cells["clnqty"];
                                gridmain.Rows.Add(1);
                            }
                            else
                            {
                                MessageBox.Show("Batchcode Not exsting");
                                CommonClass._Forms.ShowSimpleitem(TempBathcode);

                                //    if (Useasbarcode == true)
                                //{
                                    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[0];
                                //}
                            }
                        }
                        else
                        {
                            gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value) + 1);

                            NQty = _Dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value);
                            NFree = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnfree"].Value);
                            NRate = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsrate"].Value);
                            NTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clntax"].Value);
                            NDiscamt = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clndiscount"].Value);
                            NDiscper = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clndiscper"].Value);
                            NMrp = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnmrp"].Value);

                            //NSgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgst"].Value);
                            //NSgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgstPerc"].Value);

                            //NCgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clncgst"].Value);
                            //NCgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clncgstPerc"].Value);

                            //NIgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnigst"].Value);
                            //NIgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgstPerc"].Value);
                            string Tempitemid = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                            ItemId = Tempitemid;
                            TempCellEnterCalculationPart(BatchFoundIndex);
                            
                                TempDeleteRow(PrevRowIndex);
                            TottalAmountCalculate(true);
                            gridmain.Rows.Add(1);
                            gridmain.Select();
                            gridmain.CurrentCell = gridmain.Rows[PrevRowIndex].Cells[0];
                        }
                    }
                    if (PrevRowIndex != 0)
                    {
                        RowBackgroundChangeFu(1, PrevRowIndex - 1);
                    }
                    RowBackgroundChangeFu(0,PrevRowIndex);
                    uscGridshow2.Visible = false;
        }
        public void CellEnterCalculationPart()
        
        {
            try
            {
              ItemId = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Tag);

             


              if (ItemId != "")
              {
                  gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(NQty);
                  gridmain.Rows[rowindex].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(NFree);
                  gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(NRate);

                  gridmain.Rows[rowindex].Cells["clnlength"].Value = _Dbtask.SetintoDecimalpointStock(Nlength);
                  gridmain.Rows[rowindex].Cells["clnwidth"].Value = _Dbtask.SetintoDecimalpointStock(Nwidth);
                  gridmain.Rows[rowindex].Cells["clnsqfl"].Value = _Dbtask.SetintoDecimalpoint(Nsqfeat);

                  gridmain.Rows[rowindex].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(NTaxamount);
                  gridmain.Rows[rowindex].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(NDiscamt);
                  gridmain.Rows[rowindex].Cells["clnbilldiscount"].Value = _Dbtask.SetintoDecimalpoint(NBillDisc);
                  gridmain.Rows[rowindex].Cells["clndiscper"].Value = _Dbtask.SetintoDecimalpoint(NDiscper);
                  gridmain.Rows[rowindex].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(NMrp);

                  //if (SUnit == true)
                  //{
                  //    NGross = NRate * (Convrt * NQty);
                  //}
                  //else
                  //{
                  NGross = NQty * NRate;

                  if (Nsqfeat != 0)
                      NGross = NGross * Nsqfeat;
                  //}
                  NGross = NGross - NDiscamt;
                  NNetamout = NGross;
                  if (Retrivemode == 0)
                  {
                      TaxCalcPart();
                  }
                  gridmain.Rows[rowindex].Cells["clnnettamount"].Value = _Dbtask.SetintoDecimalpoint(NNetamout); /* For Cell Net Amount*/
                  gridmain.Rows[rowindex].Cells["Clngross"].Value = _Dbtask.SetintoDecimalpoint(NGross);
              }
            }
            catch
            {
            }
        }
        public void ShowPanelPreBill()
            {
            pnlbill.Visible = true;
            pnlbill.Focus();

            pnlbill.Size = new System.Drawing.Size(350, 280);
            FuFillingLoadotherVoucher();
            this.ActiveControl = pnlbill;
           // txtentervno.Select();
            txtentervno.Focus();
            this.ActiveControl = txtentervno;
           // this.txtentervno.DeselectAll();
        }
        public void FuFillingLoadotherVoucher()
            {
            //if (Vtype == "SI")
            //{
            //    comfillingselectvoucher.Items.Clear();
            //    comfillingselectvoucher.Items.AddRange(new object[] {
            //        "Enquiry",
            //        "Sales Order",
            //        "Purchase Order",
            //        "Purchase",
            //        "Sales Quatation",
            //        "Estimate",
            //    });
            //}

            //if (Vtype == "SR")
            //{
            //    comfillingselectvoucher.Items.Clear();
            //    comfillingselectvoucher.Items.AddRange(new object[] {
                   
            //        "Sales Return",
            //        "Sales",
            //    });
            //    comfillingselectvoucher.SelectedIndex = 1;
            //}
            //if (Vtype == "SO")
            //{
            //    comfillingselectvoucher.Items.AddRange(new object[] {
            //        "Enquiry"});
            //}
            
        }
        public void TaxCalcPart()
            {

            try
            {
                TaxAmt = 0;
                TaxPerc = 0;
                if (STax == true && ItemId != null)
                {
                    if (ComTax.Text != "None")
                    {
                        double Gross;
                        double Qty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        double Rate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                        double DiscAmt = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clndiscount"].Value);

                        Gross = Qty * Rate;

                        if (Nsqfeat != 0)
                            Gross = Gross * Nsqfeat;
                        //if (SUnit == true)
                        //{
                        //    Gross = Rate * (Qty * Convrt);
                        //}
                        //else
                        //{
                        //    Gross = Qty * Rate;

                        //    if (Nsqfeat!= 0)
                        //    Gross = Gross * Nsqfeat;

                        //}
                        Gross = Gross - DiscAmt;
                        if (ComTax.Text == "VAT")
                        {
                            TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select VAT from tblitemmaster where itemid='" + ItemId + "'"));
                        }
                        if (ComTax.Text == "CST")
                        {
                            TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select CST from tblitemmaster where itemid='" + ItemId + "'"));

                        }
                        if (ComTax.Text == "Tax on MRP")
                        {
                            TaxPerc = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select VAT from tblitemmaster where itemid='" + ItemId + "'"));


                        }
                        /*For Tax Calc **********************/
                        string Incs =  _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + ItemId + "'");
                        NBillDisc = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnbilldiscount"].Value);
                        NNetamout = NNetamout - NBillDisc;

                        if (Zerotaxsave == false)
                        {
                            if (Incs == "1")
                            {
                                double tempTaxPerc =100+  TaxPerc;
                                //tempTaxPerc = 100;
                                TaxAmt = NNetamout * TaxPerc / tempTaxPerc;
                                NGross = Gross - TaxAmt;
                                NNetamout = NGross + TaxAmt;

                            }
                            else
                            {
                                double tempTaxPerc = 100;
                                TaxAmt = NNetamout * TaxPerc / tempTaxPerc;

                                NNetamout = NGross + TaxAmt;
                            }
                        }
                        
                        /*********************************/

                    }

                  
                    NNetamout = NNetamout - NBillDisc;
                    gridmain.Rows[rowindex].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(TaxPerc);
                    NTaxamount = TaxAmt;
                    gridmain.Rows[rowindex].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(NTaxamount);
                }
            }
            catch
            {
            }
        }   

        public void TottalAmountCalculate(bool BDiscAmt)
                            {
            try
            {
                if (rowindex <gridmain.Rows.Count)
                {
                    gridmain.Rows[rowindex].Cells["clnslno"].Value = rowindex + 1; /* For SlNo*/
                    NetTottal = 0;
                    NetQty = 0;
                    Netitemdiscount = 0;
                    NetFree = 0;
                    NetTax = 0;
                    NetGross = 0;
                    NetAmount = 0;
                    NetMrp = 0;
                    NetSrate = 0;
                    NetinvoiceDiscount = 0;
                    double NetFirstAmount = 0;

                    for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                        {
                            if (clntax.Visible == true)
                            {
                                _Tax.TaxDeclare(gridmain, clntax);
                            }

                            NetTottal = Convert.ToDouble(NetTottal) + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                            NetAmount = NetAmount + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                            NetQty = NetQty + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                            NetGross = NetGross + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clngross"].Value);
                            Netitemdiscount = Netitemdiscount + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value);
                            NetFree = NetFree + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnfree"].Value);
                            NetFirstAmount = NetFirstAmount + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsrate"].Value) * _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                            NetTax = NetTax + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnTax"].Value);
                            NetMrp = NetMrp + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnmrp"].Value);
                            NetSrate = NetSrate + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsrate"].Value);
                        }
                    }

                        TxtTGross.Text = _Dbtask.SetintoDecimalpoint(NetGross);
                        DevideToBillDiscount();
                        txttqty.Text = _Dbtask.SetintoDecimalpoint(NetQty);
                        TxttAmount.Text = _Dbtask.SetintoDecimalpoint(NetFirstAmount);
                        TxtTFree.Text = _Dbtask.SetintoDecimalpoint(NetFree);

                        txtttax.Text = _Dbtask.SetintoDecimalpoint(NetTax);
                        TxttItemDiscount.Text = _Dbtask.SetintoDecimalpoint(Netitemdiscount);
                        double TTDiscount = Netitemdiscount + _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);
                        TxtTDiscount.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(TTDiscount));
                        txttinvoicediscount.Text =_Dbtask.znllString( TxtTDiscount.Text);

                        if (ComAgent.Text != "None")
                        {
                           // TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select commision from tblaccountledger where lid='" + TxtAccount.Tag + "'");
                            TxtAgentAmt.Text = CommonClass._commision.RetriveCommisionperc(NetTottal.ToString(), "Agent");
                            TxtAgentAmt.Text = _Gen.avoidnullDecimal(TxtAgentAmt.Text);
                            if (_Dbtask.znlldoubletoobject(TxtAgentAmt.Text) == 0)
                            {
                                TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select AgentCommision from tblitemmaster where itemid='" + ItemId + "'");
                            }
                            AgentAmt = NetTottal * _Dbtask.znullDouble(TxtAgentAmt.Text) / _Dbtask.znlldoubletoobject(100);
                            TxtAgentAmt.Text = AgentAmt.ToString();
                        }

                        if (Comemployee.Text != "None" )
                        {
                           // Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select commi from Tblemployeemaster where Empid='" + Comemployee.SelectedValue + "'");
                            Txtemployeeamt.Text = CommonClass._commision.RetriveCommisionperc(NetTottal.ToString(), "Employees");
                            Txtemployeeamt.Text = _Gen.avoidnullDecimal(Txtemployeeamt.Text);
                            StaffAmt = NetTottal * _Dbtask.znullDouble(Txtemployeeamt.Text) / Convert.ToDouble(100);
                            Txtemployeeamt.Text = StaffAmt.ToString();
                        }

                        double Tcooly = _Dbtask.znullDouble(Txttypecooly.textBox1.Text);

                        double TempCashDiscount;
                        double TempPerc;
                        double tempAmt;

                        if (BDiscAmt == true)
                        {
                            TempCashDiscount = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);
                            TempPerc = TempCashDiscount * 100 / NetAmount;
                            TxttypebilldiscountPerc.textBox1.Text = _Dbtask.SetintoDecimalpoint(TempPerc);
                            //if (_Dbtask.znlldoubletoobject(TempPerc) <= 0 ||_Dbtask.znllString(TempPerc) =="NaN")
                            //{
                            if (_Dbtask.znlldoubletoobject( CommonClass._Paramlist.GetParamvalue("defSaleDiscAMT "))>0)
                                {
                                    TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("defSaleDiscAMT "));
                                    TempPerc = _Dbtask.znullDouble(TxttypebilldiscountPerc.textBox1.Text);
                                    TempCashDiscount = NetAmount * TempPerc / 100;
                                    Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(TempCashDiscount);
                            
                            
                            }
                           // }
                        
                        }
                        else 
                        {
                            TempPerc = _Dbtask.znullDouble(TxttypebilldiscountPerc.textBox1.Text);
                            TempCashDiscount = NetAmount * TempPerc / 100;
                            Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Math.Round(TempCashDiscount)));
                        }
                         tempAmt = NetAmount - TempCashDiscount;
                       
                       double PaidAmt = _Dbtask.znullDouble(txtpaid.textBox1.Text);
                        double BiilAmt = tempAmt + Tcooly;
                        
                        //if (SRoundoff == true)
                        //    roundof = Math.Round(BiilAmt);
                        //else
                        //    roundof = BiilAmt;


                        if (SRoundoff == true)
                        {
                            //|| _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("206"))=="1"
                            double round = 0;
                            round = Math.Round(BiilAmt) - BiilAmt;
                            //round = roundof - Convert.ToDouble(BiilAmt);
                            // round = round + NextGFuntion.SalesReturnAmount;

                            roundof = roundof + round;
                            txtRoundOff.Text = _Dbtask.SetintoDecimalpoint(roundof);
                            BiilAmt = Math.Round(BiilAmt);
                            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(BiilAmt);


                        }
                        else
                        {
                            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(BiilAmt);

                        }
                       
                }
            }
            catch
            {
            }
        }
        public void lastrow()
                {
            int rwC = 0;
            rwC = gridmain.Rows.Count;
            try
            {
                //for (int i = 0; i < gridmain.Rows.Count; i++)
                //{
                //    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null)
                //    {
                //        rwC = rwC - 1;

                //    }
                   
                //    gridmain.Rows[i].DefaultCellStyle.BackColor = Color.Empty;
                //}
               

                if (rwC == 0)
                {
                    gridmain.Rows[rwC].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    gridmain.Rows[rwC - 1].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
            }
           
        }
        public void RegistrationCheck()
        {
            Registration = _Nextg.NextgRegistration();
           

        }
        public void Controlebehaviour(bool Result)
        {
            cmdprint.Enabled = Result;
        }
        private void frmsalesinvoice_Load(object sender, EventArgs e)
                        {

            comapnydetailssecondphase();
            ChangeLanguage();
                RegistrationCheck();
                //if (CommonClass._UserDetails.GetSpecificfieldbyname(ClsUserDetails.MUserName, "ugroup") != "0")
                //{
                //    TxttypebilldiscountPerc.Enabled = false;
                //}
                //else
                //{
                //    TxttypebilldiscountPerc.Enabled = true;
                //}

            if (Registration == true)
            {
                gridmain.Controls.Add(TxtProduct);
                gridmain.Controls.Add(ComMultiRate);
                gridmain.Controls.Add(ComMultiUnit);
                gridmain.Controls.Add(Txtqty);
                gridmain.Controls.Add(TxtAmt);
                FrmbarcodePrinting.prnt = false;
                Frmpurchase.Purprint = false;
                frmsalesinvoice.twotypepaymnt = false;   
                ShowSubpanel = true;
                if (Vtype == "SV")
                {
                    label23.Visible = false;
                    Txtstock.Visible = false;
                }
                uscGridshow2.Visible = false;

                NextGFuntion.SalesReturnAmount = 0;
                SettControleTextSett();
                _Nextg.ClearControles(PnlGeneral);
                _Nextg.ClearControles(PnlBottom);
                gridmain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                gridmain.AllowUserToResizeRows = false;

                frmsalesinvoice.twotypepaymnt = false;

                if (Isinotherwindow == false)
                {
                    Clear();
                }
                else
                {
                    if (txtvno.Text != "")
                    {
                        SalesAccount = FrmReport.MainAccount;
                        string Issuecode = FrmReport.ClickCode;
                            GetPrevious((Convert.ToInt64(Issuecode)).ToString(), false);
                    }
                }
                    gridmain.Select();
                                FuFocusing();
                
                if (Vtype == "SI" || Vtype == "SR")
                {
                    if (_Dbtask.znllString( _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='2026' and menuname='warrantyEnbl'")) == "1")
                    {
                        txtwarrantyy.Visible = true;
                        lablwarrnty.Visible = true;
                    }
                    else
                    {
                        txtwarrantyy.Visible = false;
                        lablwarrnty.Visible = false;

                    }
                 
                }
                if (Vtype == "SR")
                {
                    PnlHeading.BackColor = Color.MistyRose;
                }
                if (Vtype == "SQ")
                {
                    PnlHeading.BackColor = Color.PowderBlue;
                }
                if (Vtype == "SO")
                {
                    PnlHeading.BackColor = Color.Thistle;
                }

                visibleflse();
            }
            else
            {
                Application.Exit();
            }
            if (Vtype == "SR" && DIRECTSR == true)
            {

                if (DIRECTSRVNO != "")
                {
                    directtosalereturn(DIRECTSRVNO, "SI");
                        TxtNaration.textBox1.Text = DIRECTSRVNO;

                    DIRECTSR = false; DIRECTSRVNO = "";
                }

            }

            if (Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("printstyletype")) < 0)
            {
                combtypeline.SelectedIndex = 0;
            }
            else
            {


                combtypeline.SelectedIndex = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("printstyletype"));
            }
                
                CommonClass._Nextg.FormIcon(this);

                        MINVALSET();
                        ComTaxinvoice.SelectedIndex = 1;

                        PARAMLISTVALSSET();
                        lBLCOUNTSALETODAY.Text = "";
                        lBLCOUNTSALETODAY.Text = _Dbtask.znllString(_BusinessIssue.countofsale());



                    
        
        
        }

        public void PARAMLISTVALSSET()
                            {
        Stgbcodeprefx = _Dbtask.znllString(_param.GetParamvalue("bcodeprefix"));
        stgweigndigit = _Dbtask.znllString(_param.GetParamvalue("bcodedigit"));

       stgweignbcodeSrt = _Dbtask.znllString( _param.GetParamvalue("weignbcodestrt"));
      stgweignbcodeEnd =_Dbtask.znllString( _param.GetParamvalue("weignbcodeend"));

       stgweignqtyMNU = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("209"));
         stgweignqtySrt = _Dbtask.znllString(_param.GetParamvalue("weignQtystrt"));
        stgweignqtyEnd = _Dbtask.znllString(_param.GetParamvalue("weignQtyend"));
         stgweignqtyDiv = _Dbtask.znllString(_param.GetParamvalue("weignQtyDIVI"));

        stgweignrateMNU = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("208"));
       stgweignrateSrt = _Dbtask.znllString(_param.GetParamvalue("weignratestrt"));
        stgweignrateEnd = _Dbtask.znllString(_param.GetParamvalue("weignrateend"));
       stgweignrateDiv = _Dbtask.znllString(_param.GetParamvalue("weignRateDIVI"));
       stgweignrateRound = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("216"));

       CreditLimit = CommonClass._Paramlist.GetParamvalue("WNstock");
       SalerateLessLastrate = CommonClass._Paramlist.GetParamvalue("LR<SR");
       SecondprinterVALUE = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("181"));

       ClsInGrid.WGmitemcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));

       ClsInGrid.WGmitemname = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmitemname"));
       ClsInGrid.WGmsrate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmsrate"));
       ClsInGrid.WGmmrp = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmmrp"));
       ClsInGrid.WGmrack = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmrack"));
       ClsInGrid.WGmprate = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmprate"));
       ClsInGrid.WGmbcode = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Gmbcode"));


       userwisedisc = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("userdiscvalue"));
       userwisediscallow = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("217"));
       stocksetting = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("219"));
       stockbottom =_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("220"));
       ClsInGrid.stocksetting = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("219"));


         MTReadf=_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("200"));
         vehiclesf = _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("199")); 


       if (Vtype == "SI" && SalesAccount == "2")
       {
           MINofSI = CommonClass._Paramlist.GetParamvalue("MINofSI");

       }
       if (Vtype == "SO")
       {
           MINofSO = CommonClass._Paramlist.GetParamvalue("MINofSO");

       }
       if (Vtype == "SQ")
       {
           MINofSQ = CommonClass._Paramlist.GetParamvalue("MINofSQ");

       }
       if (Vtype == "SR")
       {
           MINofSR = CommonClass._Paramlist.GetParamvalue("MINofSR");

       }
       if (Vtype == "SI" && SalesAccount != "2")
       {
           MINofSIwh = CommonClass._Paramlist.GetParamvalue("MINofSIwh");

       }

       itemcodewid = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("codewidthSI"));
       batchwidth = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Batchwidthsale"));
       itemwid = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Itemwidthinsale"));
       
       langwidth = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("seclangwidthinsale"));
         
            
            if (Vtype == "SI" && SalesAccount == "2")
           {
               Pvnoval =_Dbtask.znllString(  CommonClass._Paramlist.GetParamvalue("Sprefix"));
               txtPVNO.Text = Pvnoval;
           }
         if (Vtype == "SR" && _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("227")) == "1")
         {
             PvnovalSR = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("Sprefix"));
             txtPVNO.Text = PvnovalSR;
         }
         if (Vtype == "SR" && _Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("227")) == "-1")
         {
             PvnovalSR = "";
         }
         //else
         //{
             
         //}



        }
        public void FuFocusing()
                            {
            try
            {
                if (Clssales.Focusfirstrow == true)
                {
                    //TxtAccount.Select();
                    //TxtAccount.Focus();
                    gridmain.Select();
                   // gridmain.Focus();
                   gridmain.CurrentCell = gridmain.Rows[0].Cells[0];
                    //  SendKeys.Send("{Tab}");

                }
                else
                {
                    dtdate.Select();
                    dtdate.Focus();
                }
            }
            catch
            {
            }
            
        }
        public void Controlesett()
        {
            int Left = PnlHeading.Width / 2;
        }
        public void SetDecimal()
        {
            /*For Grid */
            /*Stock*/
            gridmain.Columns["ClnQty"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));
            gridmain.Columns["Clnfree"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));


            /*For Grid */
            /*Rate*/
            gridmain.Columns["clnsrate"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            gridmain.Columns["clndiscount"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));

            gridmain.Columns["clntax"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            gridmain.Columns["clnnettamount"].DefaultCellStyle.NullValue = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));

            /*Stock*/

            txttqty.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));

            Txtqty.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));

            /*Amount*/

            TxttAmount.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            txtttax.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            TxtTFree.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            txtotherexpenses.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            txttinvoicediscount.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(0));

            TxtAmt.Text = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(0));

        }
        public void GridSelect()
        {
            gridmain.Focus();
            gridmain.Rows[0].Cells[1].Selected = true;
            gridmain.CurrentCell = gridmain.Rows[0].Cells[1];

        }


        private void frmsalesinvoice_KeyPress(object sender, KeyPressEventArgs e)
                {
            if (e.KeyChar == 16)
            { 
            }

            if (e.KeyChar == 27)
            {
                if (uscPopup1.Visible == true)
                {
                    uscPopup1.Visible = false;
                }
               else if (pnloption.Visible == true)
                {
                    pnloption.Visible = false;
                }
                else if (Pnlsizes.Visible == true)
                {
                    Pnlsizes.Visible = false;
                }
                else if (pnlbill.Visible == true)
                {
                    pnlbill.Visible = false;
                }
                else if (Gridcustomerlist.Visible == true)
                {
                    Gridcustomerlist.Visible = false;
                }
                else if (pnlbill.Visible == true)
                {
                    pnlbill.Visible = false;
                }
                else if (uscGridshow2.Visible == true)
                {
                    uscGridshow2.Visible = false;
                }
                else if (GridRate.Visible == true || PNLCOSTINVCE.Visible == true)
                {
                    GridRate.Visible = false;
                    PNLCOSTINVCE.Visible = false;
                }
                else
                {
                    _Nextg.CloseGriddetail(gridmain, this);
                }
            }
            CommonClass.temp = CommonClass.temp + e.KeyChar.ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtdate.Focus();
            }
        }
        private void gridmain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;

            txt.PreviewKeyDown -= new PreviewKeyDownEventHandler(txt_PreviewKeyDown);
            txt.PreviewKeyDown += new PreviewKeyDownEventHandler(txt_PreviewKeyDown);


            txt.TextChanged -= new EventHandler(txt_TextChanged);
            txt.TextChanged += new EventHandler(txt_TextChanged);

            txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
            txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }
        public void TempDeleteRow(int TempRowIndex)
        {
            try
            {
                int selectedIndex = TempRowIndex;
                if (selectedIndex > -1)
                {
                    gridmain.Rows.RemoveAt(selectedIndex);
                    TottalAmountCalculate(true);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }
        public bool Fufocuscolumn(string Colname)
        {
            try
            {
                int selectedIndex = gridmain.CurrentCell.RowIndex;
                if (Colname == "clnbatch")
                {
                    gridmain.Select();
                    for (int a = 0; a < gridmain.Rows.Count; a++)
                    {
                        if (_Dbtask.znllString(gridmain.Rows[a].Cells[Colname].Value) == "")
                        {
                            selectedIndex = a;
                            gridmain.CurrentCell = gridmain.Rows[selectedIndex].Cells[Colname];
                            //gridmain.CurrentCell = gridmain.Rows[selectedIndex].Cells[Colname];
                            return true;
                        }
                    }
                }
                else
                {
                    if (selectedIndex > -1)
                    {
                        if (_Dbtask.znllString(gridmain.Rows[selectedIndex].Cells["clnbatch"].Value) != "")
                        {
                            gridmain.CurrentCell = gridmain.Rows[selectedIndex].Cells[Colname];
                            return true;
                        }
                        else
                        {
                            gridmain.CurrentCell = gridmain.Rows[selectedIndex - 1].Cells[Colname];
                            return true;
                        }

                    }
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
        }
        public void DeleteRow()
        {
            try
            {
                int selectedIndex = gridmain.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    gridmain.Rows.RemoveAt(selectedIndex);
                    TottalAmountCalculate(true);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
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
        }

        void txt_TextChanged(object sender, EventArgs e)
                                        {
            try
                {

                    if ((sender as TextBox).Text == "")
                {
                    if (ColumnName != "clnitemcode" && ColumnName != "clnitemname" && ColumnName != "clnslno" && ColumnName != "clnbatch")
                    {
                        (sender as TextBox).Text = "0";

                    }
                }

                    gridmain.Rows[rowindex].Cells[columnindex].Value = (sender as TextBox).Text;


                    //if (gridmain.Columns[columnindex].Name.ToString() == "clnqty" || gridmain.Columns[columnindex].Name.ToString() == "clnsrate" || gridmain.Columns[columnindex].Name.ToString() == "clnfree")
                    //{
                    //    if (_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value) > 10000000 || _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value) > 10000000 || _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnfree"].Value) > 10000000)
                    //    {
                    //        gridmain.Rows[rowindex].Cells[columnindex].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["ClnGross"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["clnnettamount"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells["clntax"].Value = 0;
                    //        gridmain.Rows[rowindex].Cells[ColumnName].Value = 0;
                    //        gridmain.NotifyCurrentCellDirty(false);
                    //    }
                    //}

                /*For Value Insert*/
                NQty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value); 

                Nlength = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnlength"].Value);
                Nwidth = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnwidth"].Value);
                Nsqfeat = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsqfl"].Value);

                NFree =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                NRate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                NMrp =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnmrp"].Value);
                NDiscamt =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                NDiscper =_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
                NBillDisc = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnbilldiscount"].Value);
                string Temp = _Dbtask.znllString(gridmain.Rows[rowindex].Cells[columnindex].Value);

                if (gridmain.Columns[columnindex].Name == "clnitemcode" && IsEnter == true)
                {
                    UscGridshow.ActiveControle = (sender as TextBox);
                    _usc2.Passingusercontrole(gridmain, "Clnsrate", "srate", rowindex, columnindex, uscGridshow2,false);

                    ProductGridShow(Temp);
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

                }

                if (ColumnName == "ClnGross")
                {
                    double tempgross = Convert.ToDouble(gridmain.Rows[rowindex].Cells["ClnGross"].Value);
                    double tempqty = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                    double tempdiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                    double temprate = tempgross / tempqty;
                    temprate = temprate - tempdiscamt;
                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(temprate);
                    NQty = tempqty;
                    NRate = temprate;
                    CellEnterCalculationPart();
                }
                if (ColumnName == "ClnUnit")
                {
                    GridUnitList.Visible = true;
                    LoadUnits();
                }


                if (ColumnName == "clnbatch")
                {
                    if (SearchBarcode == true)
                    {

                        ProductGridShowWithBatch(" where  (TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' OR  TblItemMaster.llang Like N'%" + Temp + "%' or Tblbatch.bcode like N'%" + Temp + "%' ) ");
                        if (Vtype == "SV")
                            ProductGridShowWithBatch(" where  (TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' or Tblbatch.bcode like N'%" + Temp + "' ) and itemclass='Services'");

                        uscGridshow2.GridProductShow.MouseDoubleClick -= new MouseEventHandler(GridProductShow_MouseDoubleClick);
                        uscGridshow2.GridProductShow.MouseDoubleClick += new MouseEventHandler(GridProductShow_MouseDoubleClick);
                    //Shafi   ProductGridShowWithBatch(" where  ( Tblbatch.bcode like '" + Temp + "%')");

                       // ProductGridShowWithBatch(" where  (TblItemMaster.itemCode Like '%" + Temp + "%' OR  TblItemMaster.ItemName Like '%" + Temp + "%' or Tblbatch.bcode like '%" + Temp + "')");

                        ////if (comitemcategory.SelectedIndex == 0)
                        ////{
                        ////    _usc2.Passingusercontrole(gridmain, "Clnsrate", "srate", rowindex, columnindex, uscGridshow2, false);
                        ////}
                        ////else
                        ////{
                        ////    _usc2.Passingusercontrole(gridmain, "Clnsrate", "srate", rowindex, columnindex, uscGridshow2, true);
                        ////}

                        //if (Txtitemcategory.textBox1.Text == "")
                        //{
                        //    _usc2.Passingusercontrole(gridmain, "Clnsrate", "srate", rowindex, columnindex, uscGridshow2, false);
                        //}
                        //else
                        //{
                        //    _usc2.Passingusercontrole(gridmain, "Clnsrate", "srate", rowindex, columnindex, uscGridshow2, true);
                        //}
                            uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                    }
                   
                }

                if (ColumnName == "clnwidth" || ColumnName == "clnlength")
                {
                    CalcSquerfeet();
                }

                if (gridmain.Columns[columnindex].Name == "clndiscount")
                {
                    NDiscper = NRate * NQty;
                    NDiscper = NDiscamt * 100 / NDiscper;
                    gridmain.Rows[rowindex].Cells["clndiscper"].Value = NDiscper;
                }
                if (gridmain.Columns[columnindex].Name == "ClnDiscPer")
                {

                    NDiscamt = NQty * NRate;
                    NDiscamt = NDiscamt * NDiscper / Convert.ToDouble(100);
                    gridmain.Rows[rowindex].Cells["clndiscount"].Value = NDiscamt;
                }

                

                if (ColumnName == "clnqty")
                {
                  if(ShowSubpanel==true)
                 {
                    if (SSsizes == true)
                    {
                        LoadColumnInSize();
                    }
                    if (SFlex == true)
                    {
                        LoadColumnInFlex();
                    }
                 }
                }


               




            }

            catch
            {
            }

            CellEnterCalculationPart();
            TottalAmountCalculate(true);

        }

        void GridProductShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        //    mclik = true;
            //string TempBathcode = "";
            //string TempExpiryDate = "";
            //string ITENIDD = "";
            //int NowselectedRow = new int();
            //if (uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count > 0)
            //{
            //    NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;

            //    // selected = NowselectedRow;
            //    TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
            //    TempExpiryDate = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["ex Date"].Value.ToString();
            //    //batchcode = TempBathcode;




            //}
            //FuPasingEnetr(NowselectedRow, TempBathcode, TempExpiryDate);
            FuPasingEnetr();
            
        }

        public void LoadUnits()
        {
            GridUnitList.Location = new System.Drawing.Point(599, 155);
            GridUnitList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Ds2 = CommonClass._Unitcreation.LoadUnit(" where id in (select uid from tblunitsrates where itemid='"+gridmain.Rows[rowindex].Cells["clnitemname"].Tag+"')");
            for (int i = 0; i < Ds2.Tables[0].Rows.Count; i++)
            {
                GridUnitList.Rows.Add(1);

                GridUnitList.Rows[i].Cells[0].Value = Ds2.Tables[0].Rows[i]["Name"].ToString();
                GridUnitList.Rows[i].Cells[0].Tag = Ds2.Tables[0].Rows[i]["Id"].ToString();
            }
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            _Ingrid.ProductGridShowLocationSettGrid(GridUnitList, tempRect.Left, tempRect.Top + tempRect.Height + 40 * 3);
            GridUnitList.Columns[0].Width = GridUnitList.Width - 10;
        }

        void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
                        {


               

            if (ColumnName == "clnbatch"&&SBatch==true)
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
                if (SearchBarcode == false)
                {
                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = (sender as TextBox).Text;

                
                }

                if (e.KeyValue == 27)
                {
                    if (Gridbatchlist.Visible == true)
                    {
                        Gridbatchlist.Visible = false;
                    }
                }

                try
                {
                    if (Gridbatchlist.SelectedRows.Count > 0)
                    {
                        selectedRow = Gridbatchlist.SelectedRows[0].Index;
                        int gridmainSelect = Gridbatchlist.CurrentCell.RowIndex;
                        if (Gridbatchlist.Visible == true)
                        {

                        }
                    }
                }
                catch
                {
                }
            }
            //chkrateqty
           
            if (ColumnName == "ClnUnit")
            {
                //Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");
                CommonClass._commenevent.UpDowninGridList(GridUnitList, e.KeyValue, gridmain);
                //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                //{

                if (e.KeyValue == 13 && GridUnitList.SelectedRows.Count > 0)
                {
                    int select = GridUnitList.SelectedRows[0].Index;
                    UnitName = GridUnitList.Rows[select].Cells[0].Value.ToString();
                    Unitid = GridUnitList.Rows[select].Cells[0].Tag.ToString();

                    if (Convert.ToInt64(comratetype.SelectedValue) == 0)
                    {
                        gridmain.Rows[rowindex].Cells["clnsrate"].Value =_Dbtask.znlldoubletoobject(CommonClass._Unitsrates.SpecificField(ItemId, "srate", Unitid));
                        gridmain.Rows[rowindex].Cells["clnmrp"].Value = _Dbtask.znlldoubletoobject(CommonClass._Unitsrates.SpecificField(ItemId, "mrp", Unitid));

                    }
                    else // if (Convert.ToInt64(ComMultiRate.SelectedValue) == Convert.ToInt64(1))
                    {
                        gridmain.Rows[rowindex].Cells["clnsrate"].Value =_Dbtask.znlldoubletoobject(CommonClass._Unitsrates.SpecificField(ItemId, "Wrate", Unitid));
                        gridmain.Rows[rowindex].Cells["clnmrp"].Value = _Dbtask.znlldoubletoobject(CommonClass._Unitsrates.SpecificField(ItemId, "mrp", Unitid));

                    }
                }
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
                //        GridUnitList.Visible = false;
                //    }
                //    CellEnterCalculationPart();

                //}
                UnitAmountCalc();
                TottalAmountCalculate(true);

            }
            if (ColumnName == "clnitemcode")
            {
                if (SUnit == true)
                {

                    //Ds = _Dbtask.ExecuteQuery("select * from TblItemMaster where ItemId='" + ItemId + "'");

                    //if (Ds.Tables[0].Rows.Count > 0)
                    //{
                    //    SecUnit = Ds.Tables[0].Rows[0]["Unit2"].ToString();
                    //    Unitamount1 = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["UnitAmount1"].ToString());
                    //    gridmain.Rows[rowindex].Cells["ClnUnit"].Value = SecUnit;
                    //    Convrt = Unitamount1;
                    //}
                    gridmain.Rows[rowindex].Cells["ClnUnit"].Value = CommonClass._Unitcreation.Getunitofitem(ItemId);
                    Convrt =_Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", ItemId));
                }
                
                if (e.KeyValue == 13)
                {
                    RowClick((sender as TextBox).Text, e.KeyValue);
                    (sender as TextBox).Text = _Dbtask.znllString(gridmain.Rows[rowindex].Cells[ColumnName].Value);

                    if (CommonClass._Item.SpecificField(ItemId, "itemclass") == "Direct")
                    {
                        gridmain.Rows[rowindex].Cells["clnlength"].ReadOnly = true;
                        gridmain.Rows[rowindex].Cells["CLNWIDTH"].ReadOnly = true;
                    }

                    gridmain.Rows.Add(1);
                }
            }

            if (e.KeyValue == 115 && ItemId != null) /*For F2  Delete Rows */
            {
                DeleteRow();
            }
            if (e.KeyValue == 114 && ItemId != null) /*For F3  Insert Rows */
            {
                gridmain.Rows.Insert(rowindex, 1);
                _Gen.SlSetfunction(gridmain, "clnslno");
            }
            if (e.KeyValue == 117 && ItemId != null) /*For F6*/
            {
                SalesHistory((sender as TextBox));
            }
            else
            {
                PnlSalesHistory.Visible = false;
            }

            if (e.KeyValue == 118 && ItemId != null) /*For F7*/
            {
                RatePanelShow((sender as TextBox));
            }
                else
            {
                GridRate.Visible = false;
                PNLCOSTINVCE.Visible = false;
            }
            //else
            //{
            //    GridRate.Visible = false;
            //}

            if (e.KeyValue == 120 && ItemId != null) /*For F9 Focus Qty*/
            {
                Fufocuscolumn("clnqty");
            }
            if (e.KeyValue == 122 && ItemId != null) /*For F11 Focus Rate*/
            {
                //if (CommonClass._Menusettings.GetMnustatus("181") == "-1")
                //{
                    Fufocuscolumn("clnsrate");
               // }
            }
            if (e.KeyValue == 112 && ItemId != null) /*For F1 Focus Barcode*/
            {
                if (SecondprinterVALUE == "-1")
                   {
                     
                Fufocuscolumn("clnbatch");
                    }
                if (SecondprinterVALUE == "1")
                {
                    PrintSecondprint = true;
                    if (PrintSecondprint == true)
                    {
                        Secndnow = true;
                        Printerselect = "mode3";
                        Selectedprint = _Dbtask.GetPrinterName2();
                        _lasersix.SelPrint = Selectedprint;
                    }
                }

            }
            if (gridmain.Columns[columnindex].Name == "clnbatch")
            {
                //if (Vtype == "SI")
                //{
                //    _mostmove.loaditems(gridmain);
                //}


               if (e.KeyValue == 13 && SBatch == true )
                            {
                        if(_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) !=""||uscGridshow2.Visible==true)
                        {
                        int NowselectedRow=new int();
                        string TempBathcode;
                        if (uscGridshow2.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count>0)
                        {
                            NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
                            TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                        }
                        else
                        {
                            TempBathcode =_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                        }


                        //_sales.BarcodeRefilling(TempBathcode);
                        _sales.BarcodeRefillingBYSETTING(TempBathcode);

                        //if (CommonClass._Batch.SameNamealreadyexistNew(TempBathcode) == false)
                        //{

                        //    //MessageBox.Show("barcode note existing");
                        //}
                            
                            string realbatch = TempBathcode;
                            
                            TempBathcode = _sales.Bcode;
                            if (SearchBarcode == true)
                            {
                                gridmain.Rows[rowindex].Cells["clnexpiry"].Value = _Dbtask.ZnullDatetime(uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["ex Date"].Value);
                            }
                        string ITENIDD="";
                            //string bunit = "";
                            //bunit = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='302010'").ToString();
                            if (BUNIT==true)
                            {
                                ////gridmain.Columns["clnbaseu"].Visible = true;
                                ITENIDD = _Batch.GetSpecificFieldByBarcode("ITEMID", TempBathcode);
                             
                                gridmain.Rows[rowindex].Cells["clnBaseU"].Tag = _ItemMaster.SpecificField(ITENIDD, "Bunit").ToString();
                                string BU = "";
                                BU = gridmain.Rows[rowindex].Cells["clnBaseU"].Tag.ToString();
                                gridmain.Rows[rowindex].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalar("select name from tblbaseunit where id='" + BU + "'").ToString();
                             if( BU=="")
                                  {

                                      gridmain.Rows[rowindex].Cells["clnBaseU"].Tag = "1";

                                      gridmain.Rows[rowindex].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalar("select name from tblbaseunit where id='1'").ToString();
                                  }
                            
                            
                            }
                            else
                            {
                                //ridmain.Rows[rowindex].Cells["ClnbaseU"].Visible = false;
                            }
                        //bool PnlExpire = true;

                        //Expiry Barcode*/
                        //    DS3 = _Dbtask.ExecuteQuery(" select exdate,srate from tblbatch where Bcode = '" + gridmain.Rows[rowindex].Cells["clnbatch"].Value + "'");

                        //if (DS3.Tables[0].Rows.Count > 1)
                        //{
                        //    FrmExpirysales _Exp = new FrmExpirysales();
                        //    _Exp.Ds = DS3;
                        //    _Exp.BatchCode = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
                        //    _Exp.ShowDialog();

                        //}
                        //else
                        //{
                        //    Clssales.PassExpiryDate = "";
                        //    Clssales.PassExpiryRate = "";
                        //}
                        /**********************************************************/
                        //NowselectedRow = GridExDate.SelectedRows[0].Index;
                      //  TempBathcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);



                            Clssales.PassExpiryDate = "";
                            Clssales.PassExpiryRate = "";



                           

                            PrevRowIndex = gridmain.CurrentRow.Index;

                           // TempBathcode = realbatch;
                        if (IsBatchFound(TempBathcode) == false || Clssales.PassExpiryRate!=""||_sales.Nrate!=0)
                        {

                            NQty = _sales.NQty;
                            


                            if (Vtype == "SV")
                                Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "' and itemid in (select itemid from tblitemmaster where itemclass ='Services')");
                            else

                                Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "' and itemid in (select itemid from tblitemmaster where itemclass !='Services')");

                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                string Tempitemid = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                                ItemId = Tempitemid;
                                gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
                                gridmain.Rows[rowindex].Cells["clnlang"].Value = _Dbtask.ExecuteScalar("select llang from tblitemmaster where itemid='" + Tempitemid + "'");
                                gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = Tempitemid;

                                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
                                ShowStockinLabel(TempBathcode, Tempitemid, StockareaId);
                                gridmain.Rows[rowindex].Cells["clnqty"].Value = NQty;


                                double TempSrate;
                                if (Clssales.PassExpiryDate == "")
                                {
                                    TempSrate = Convert.ToDouble(_Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
                                    gridmain.Rows[rowindex].Cells["clnexpiry"].Value =(_Dbtask.ZnullDatetime(_Batch.GetSpecificFieldofBatch(TempBathcode, "exdate"))).ToString("dd-MM-yyyy");
                                }
                                else
                                {
                                    TempSrate = _Dbtask.znullDouble(Clssales.PassExpiryRate);
                                    gridmain.Rows[rowindex].Cells["clnexpiry"].Value =_Dbtask.ZnullDatetime(Clssales.PassExpiryDate).ToString("dd-MM-yyyy");
                                }

                                double TempMrp = Convert.ToDouble(_Batch.GetSpecificFieldofBatch(TempBathcode, "mrp"));
                                if (_sales.Nrate == 0)/*Checking for Wieght mechine*/
                                {
                                    if (Smrate == true && comratetype.SelectedIndex == 1)
                                    {
                                        TempSrate = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(rate),0) from tblproductrate where pcode ='" + Tempitemid + "' and batchid='" + TempBathcode + "'"));
                                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);
                                    }
                                    else
                                    {
                                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);
                                    }
                                }
                                else
                                {
                                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _sales.Nrate;
                                }

                                gridmain.Rows[rowindex].Cells["ClnMRP"].Value = _Dbtask.SetintoDecimalpoint(TempMrp);
                                gridmain.Rows[rowindex].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + Tempitemid + "'");

                                gridmain.Rows[rowindex].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(0);
                                gridmain.Rows[rowindex].Cells["clndiscper"].Value = _Dbtask.SetintoDecimalpoint(0);
                                gridmain.Rows[rowindex].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(0);


                                NQty = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                                NFree = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                                NRate = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                                NTaxamount = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clntax"].Value);
                                NDiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                                NDiscper = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
                                NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);

                                /*For MultiUnit*/
                                if (SUnit == true)
                                {
                                    Unitid = CommonClass._Unitcreation.Getunitofitem(ItemId);
                                    gridmain.Rows[rowindex].Cells["ClnUnit"].Tag = Unitid;
                                    gridmain.Rows[rowindex].Cells["ClnUnit"].Value = CommonClass._Unitcreation.Getspesificfield("name", Unitid.ToString());
                                    
                                    Convrt = _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", ItemId));
                                    if (_sales.Nounit == true)
                                    {
                                        Convrt = 1;
                                    }

                                     NRate = NRate * Convrt;
                                   
                                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = NRate;
                                }

                                if (ColumnName == "clnitemcode" || ColumnName == "clnitemname" || ColumnName == "clnbatch")
                                {
                                    //if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("206")) == "1")
                                    //{
                                    //    double itemround = 0;
                                    //    double SRATEACTUAL = 0;
                                    //    // round = round + NextGFuntion.SalesReturnAmount;
                                    //    SRATEACTUAL = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                                    //    gridmain.Rows[rowindex].Cells["clnsrate"].Value = Math.Round(_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value));
                                    //    NRate =_Dbtask.znlldoubletoobject( gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                                    //    itemround = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value) - _Dbtask.znlldoubletoobject(SRATEACTUAL);

                                    //    roundof = roundof + itemround;

                                    //    txtRoundOff.Text = _Dbtask.znllString(roundof);



                                    //}

                                }
                                //}



                                if (stockbottom == "1")
                                {

                                    string pcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["ClnItemName"].Tag);
                                    label23.Visible = true;
                                    Txtstock.Visible = true;
                                    if(SBatch==true)
                                    {

                                        Txtstock.Text =_Dbtask.znllString( Convert.ToDouble(_Inventory.GetStock(" where pcode='" + pcode + "'  and batchcode='" + TempBathcode + "' ")));
                                    }
                                    else
                                    {

                                        Txtstock.Text =_Dbtask.znllString( Convert.ToDouble(_Inventory.GetStock(" where pcode='" + pcode + "' ")));
                                    }
                                }


                                else
                                {
                                    Txtstock.Visible = false;
                                    label23.Visible = false;
                                }








                                uscGridshow2.Visible = false;
                                CellEnterCalculationPart();
                                TottalAmountCalculate(true);
                                TempBathcode = _sales.Bcode;
                                gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBathcode;
                                gridmain.NotifyCurrentCellDirty(false);

                                
                               // TempBathcode = realbatch;
                                if (SearchBarcode == false)
                                {
                                    gridmain.Rows.Add(1);
                                        gridmain.CurrentCell = gridmain.Rows[rowindex + 1].Cells[0];
                                                }
                                gridmain.Rows.Add(1);
                            }
                            else
                            {
                                MessageBox.Show("Batchcode Not exsting");
                                CommonClass._Forms.ShowSimpleitem(TempBathcode);

                                //    if (Useasbarcode == true)
                                //{
                                    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[0];
                                //}
                                }
                        }
                        else
                        {
                            gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value) + 1);

                            NQty = _Dbtask.znlldoubletoobject(gridmain.Rows[BatchFoundIndex].Cells["clnqty"].Value);
                            NFree = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnfree"].Value);
                            NRate = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsrate"].Value);
                            NTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clntax"].Value);
                            NDiscamt = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clndiscount"].Value);
                            NDiscper = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clndiscper"].Value);
                            NMrp = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnmrp"].Value);

                            //NSgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgst"].Value);
                            //NSgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgstPerc"].Value);

                            //NCgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clncgst"].Value);
                            //NCgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clncgstPerc"].Value);

                            //NIgstTaxamount = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnigst"].Value);
                            //NIgstTaxperc = Convert.ToDouble(gridmain.Rows[BatchFoundIndex].Cells["clnsgstPerc"].Value);
                            string Tempitemid = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
                            ItemId = Tempitemid;
                            TempCellEnterCalculationPart(BatchFoundIndex);
                            
                                TempDeleteRow(PrevRowIndex);
                            TottalAmountCalculate(true);
                            gridmain.Rows.Add(1);
                            gridmain.CurrentCell = gridmain.Rows[PrevRowIndex].Cells[0];
                        }
                        }
                    //if (PrevRowIndex != 0)
                    //{
                    //    RowBackgroundChangeFu(1, PrevRowIndex - 1);
                    //}
                    //RowBackgroundChangeFu(0,PrevRowIndex);
                }

            }
            if (ColumnName == "clnitemcode" || ColumnName == "clnitemname"||ColumnName == "clnbatch")
            {
                //if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("206")) == "1")
                //{
                //    //double itemround = 0;
                //    //double SRATEACTUAL = 0;
                //    //// round = round + NextGFuntion.SalesReturnAmount;
                //    //SRATEACTUAL = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                //    //gridmain.Rows[rowindex].Cells["clnsrate"].Value = Math.Round(_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value));

                //    //itemround = _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value) - _Dbtask.znlldoubletoobject(SRATEACTUAL);

                //    //roundof = roundof + itemround;

                //    //txtRoundOff.Text = _Dbtask.znllString(roundof);
                                
                                

                //}
            }

            if (e.KeyValue != 13)
            {
                _Ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, gridmain);
              //  _Ingrid.RowUpDownSelect(e.KeyValue, uscGridshow2.GridProductShow, selectedRow, uscGridshow2, gridmain);

                if (stocksetting == "1")
                {
                    uscGridshow2.lblstock.Visible = true;
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                    uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                }
                else
                {

                    uscGridshow2.lblstock.Visible = false;
                }
            }
            
        }
        public void RowBackgroundChangeFu(int FMode, int PRowindex)
        {
            try
            {
                if (FMode == 0)
                {
                   // gridmain.Rows[PRowindex].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                    gridmain.Rows[PRowindex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
                else if (FMode == 1)
                {
                    gridmain.Rows[PRowindex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch
            {
            }
        }

        public void RowClick(string Value, int KeyValue)
        {
            try
            {
                
                //rowindex = mrowindx;
                //gridmain.CurrentCell = gridmain.Rows[mrowindx].Cells[1];
              
                columnindex = 1;
                //gridmain.Rows[rowindex].Cells["clnbatch"].Value = Value;

               // gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[1];
                    _Ingrid.PreviewKeyDownInGrid(KeyValue, uscGridshow2, uscGridshow2.GridProductShow, gridmain, IsEnter, Value,Convert.ToInt16 (_Dbtask.znullDouble(ItemId)), rowindex, columnindex, "Clnsrate", "srate", StockareaId);
                uscGridshow2.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);

                

                if (KeyValue == 13&&SBatch==true)
                {
                    string ITENIDD = ""; string batch = ""; batch = Value;
                    gridmain.Rows[rowindex].Cells["clnbatch"].Value = batch;
                    ITENIDD = CommonClass._Batch.GetSpecificFieldByBarcode("ITEMID", Value);
                    gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = ITENIDD.ToString();
                    gridmain.Rows[rowindex].Cells["ClnItemName"].Value = _ItemMaster.SpecificField(ITENIDD, "itemname").ToString();
                    ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                    IsEnter = false;
                    gridmain.Rows[rowindex].Cells["clnitemcode"].Value = _ItemMaster.SpecificField(ITENIDD, "itemcode").ToString();
                    gridmain.Rows[rowindex].Cells["clnlang"].Value = _ItemMaster.SpecificField(ITENIDD, "llang").ToString();
                    //Value = gridmain.Rows[rowindex].Cells["clnitemcode"].Value.ToString();

                    
                    uscGridshow2.Visible = false;
                    if (_Settings.ReturnStatus("160") == "-1")
                    {
                        gridmain.Rows[rowindex].Cells["clnqty"].Value = 1;
                    }
                {
                    
                }
                    if (comratetype.SelectedValue != null)
                    {
                        if (comratetype.SelectedValue.ToString() != "0")
                        {
                            try
                            {
                                double Sratesecondery = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(rate,0) from tblproductrate where pcode='" + ItemId + "'"));
                                gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);
                            }
                            catch
                            {
                            }
                        }
                    }
                    if (SBatch == true)
                    {
                        gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[1];
                    }
                    gridmain.NotifyCurrentCellDirty(false);
                }
            }
            catch
            {
            }
        }
        public void InvoiceProfitCalculation()
        {
            double NCrate = 0;
            double NPrate = 0;
            double NSrate = 0;

            if (uscPopup1.Visible == false)
            {
                RowValidation();

                for (int i = 0; i < gridmain.Rows.Count; i++)
                {

                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            string Tempitemid = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                            double tempcrate1=0;
                            double tempPrate1;
                            double tempsrate1; double stax=0;
                            if (SBatch == true)
                            {
                                string StempBcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                                tempPrate1 = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0)  from tblbatch where itemid='" + Tempitemid + "' and bcode='" + StempBcode + "'"));
                                //tempcrate1 = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(crate,0)  from tblitemmaster where itemid='" + Tempitemid + "'"));
                               
                                
                                tempcrate1 = ((tempPrate1 * 15) / 100) + tempPrate1;
                            
                            
                            }
                            else
                            {
                                tempPrate1 = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0)  from tblitemmaster where itemid='" + Tempitemid + "'"));
                                tempcrate1 = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(crate,0)  from tblitemmaster where itemid='" + Tempitemid + "'"));

                            }
                            tempsrate1 =_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsrate"].Value);
                            stax = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntax"].Value);
                            
                            double tempqty1 = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);

                            tempcrate1 = tempcrate1 * tempqty1;

                            if (CommonClass._Itemmaster.SpecificField(Tempitemid, "incs")=="1")
                            {
                            tempsrate1 = tempsrate1 * tempqty1;
                            }
                            else
                            {
                                tempsrate1 = tempsrate1 + stax;
                            }


                            tempPrate1 = tempPrate1 * tempqty1;

                            NCrate = NCrate + tempcrate1;
                            NPrate = NPrate + tempPrate1;
                            NSrate = NSrate + tempsrate1;
                        }
                    }
                }

                double ProfitPerc;
                double CrateCalc = NSrate - NCrate;
                double PrateCalc = NSrate - NPrate;

                double CprofitPerc;
                double PProfitPerc;

                CrateCalc = CrateCalc - Convert.ToDouble(TxtTDiscount.Text);
                PrateCalc = PrateCalc - Convert.ToDouble(TxtTDiscount.Text);
                CprofitPerc = 100 * CrateCalc / NCrate;
                PProfitPerc = 100 * PrateCalc / NPrate;

             
                uscPopup1.lblTopic.Text = "INVOICE PROFIT";
                uscPopup1.lbl1.Text = "Profit Amount (Cost.Rate)=" +CrateCalc.ToString("") + "  (" + _Dbtask.SetintoDecimalpoint( CprofitPerc).ToString() + "%)";
                uscPopup1.lbl2.Text = "Profit Amount (P.Rate)=" +  PrateCalc.ToString("0.000") + "  (" + _Dbtask.SetintoDecimalpoint( PProfitPerc).ToString() + "%)";
                Rectangle workingArea = Screen.GetWorkingArea(this);

                uscPopup1.Location = new Point(workingArea.Right - uscPopup1.Width, 0
                                          );
                uscPopup1.Visible = true;
            }
            else
            {
                uscPopup1.Visible = false;
            }
        }
        public void RatePanelShow(TextBox txt)
                {


            double Prdctcost = 0; double TotPrdctcost = 0;
            double totalamtSI = 0; double totalamtPI = 0;
            double totprofitperc = 0;
            try
            {
                if (_UserDetails.Permited() == true)
                {
                    if (SBatch == true)
                    {
                        GridRate.Rows.Clear();
                        // GridRate.Columns.Clear();
                        for (int i = 0; i < gridmain.Rows.Count; i++)
                        {
                            int cc = GridRate.Rows.Add(1);
                            GridRate.Rows[cc].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                            GridRate.Rows[cc].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                            if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) > 0)
                            {

                                double Netamt = 0; double pamt = 0; double proftamt = 0; double profitperc = 0;
                                double qty = 0;
                                Prdctcost = 0; string itemnamess = ""; double stk = 0; double srate = 0;
                                double profit = 0; string ID = "";
                                Batchcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                                itemnamess = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Value);
                                srate = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnsrate"].Value);
                                ID = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Tag);

                                Netamt = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value);
                                totalamtSI = totalamtSI + Netamt;

                                qty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                            




                                Prdctcost = _ItemMaster.getcostrate(Batchcode, ID);

                                profit = srate - Prdctcost;

                                pamt = qty * Prdctcost;
                                totalamtPI = totalamtPI + pamt;

                                proftamt = Netamt - pamt;
                                profitperc = _Dbtask.znlldoubletoobject(_Dbtask.SetintoDecimalpoint((proftamt * 100) / pamt));



                                stk = CommonClass._Inventory.GETSTOCKBYUNIT(Batchcode);
                                TotPrdctcost = TotPrdctcost + Prdctcost;
                                for (int k = 0; k < GridRate.Rows.Count; k++)
                                {
                                    GridRate.Rows[cc].Cells["Clnproduct"].Value = itemnamess;
                                    GridRate.Rows[cc].Cells["ClnBarcodes"].Value = Batchcode;
                                    GridRate.Rows[cc].Cells["clnCrateShort"].Value = Prdctcost;
                                    GridRate.Rows[cc].Cells["Clnstock"].Value = stk;
                                    GridRate.Rows[cc].Cells["Clnprofit"].Value = profitperc.ToString() + "% ." + "  ( " + proftamt.ToString() + " )";
                                        //_Dbtask.SetintoDecimalpoint(profit);

                                }
                            }
                        }


                        int vv = GridRate.Rows.Add(1);
                        GridRate.Rows[vv].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                        GridRate.Rows[vv].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                        totprofitperc = _Dbtask.znlldoubletoobject(_Dbtask.SetintoDecimalpoint(((totalamtSI - totalamtPI) * 100) / totalamtPI));
                        
                        GridRate.Rows[vv].Cells["ClnBarcodes"].Value = "Total Cost";
                        GridRate.Rows[vv].Cells["clnCrateShort"].Value = TotPrdctcost;
                        GridRate.Rows[vv].Cells["Clnprofit"].Value = totprofitperc.ToString() + "% ." + "  ( " + (totalamtSI - totalamtPI).ToString() + " )";
 


                    }
                    else
                    {
                        ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
                        Ds = _Dbtask.ExecuteQuery("select isnull(crate,0) as crate,isnull(prate,0) as prate from  tblitemmaster where itemid='" + ItemId + "'");
                        GridRate.Rows[0].Cells["clncrateshort"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[0]["crate"]));
                        GridRate.Rows[0].Cells["clnprateshort"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[0]["prate"]));
                    }
                    PNLCOSTINVCE.Visible = true;
                    GridRate.Visible = true;
                }

            }
            catch
            {
            }

            //try
            //{
            //    if (SBatch == true)
            //    {
            //        Batchcode = gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString();
            //        Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Batchcode + "'");
            //        if (Ds.Tables[0].Rows.Count > 0)
            //        {
            //           GridRate.Rows[0].Cells["clnprateshort"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[0]["prate"]));
            //        }
            //    }
            //    else
            //    {
            //        ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
            //        Ds = _Dbtask.ExecuteQuery("select isnull(crate,0) as crate,isnull(prate,0) as prate from  tblitemmaster where itemid='" + ItemId + "'");
            //        GridRate.Rows[0].Cells["clncrateshort"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[0]["crate"]));
            //        GridRate.Rows[0].Cells["clnprateshort"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[0]["prate"]));
            //    }

            //    GridRate.Visible = true;

            //}
            //catch
            //{
            //}
        }
        public void SalesHistory(TextBox txt)
        {
            try
            {
                if (gridmain.Rows[rowindex].Cells["clnitemname"].Tag != null)
                {
                    StringTemp = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
                    temp = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);


                    Ds = _IssueDetails.ShowAccountsSales(" where issuetype='SI' and ledcodeDr= '" + TxtAccount.Tag.ToString() + "'", StringTemp, TxtAccount.Tag.ToString(),temp);
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
            }
            catch
            {
            }
        }
        public void Cellitemcode()
        {
            if (rowindex == 0 && ItemId == null)
            {
                gridmain.Rows[rowindex].Cells["clnitemcode"].Selected = true;
                gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
                gridmain.Rows[rowindex].Cells["clnitemcode"].Selected = true;
                gridmain.CurrentCell = gridmain.Rows[0].Cells["clnitemcode"];
            }
        }
        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
                    {

            try
            {
                if (IsEnterGrid == false)
                {
                    columnindex = gridmain.CurrentCell.ColumnIndex;
                    rowindex = gridmain.CurrentCell.RowIndex;
                    mrowindx = rowindex;
                    ColumnName = gridmain.Columns[columnindex].Name.ToString();
                    _sales.GridCellenter(gridmain, rowindex, columnindex);

                    

                    if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true && ColumnName != "clnitemname" && ColumnName != "clnserialno")
                    {
                        SendKeys.Send("{Tab}");
                                                }
                    if (ColumnName == "clnitemname")
                    {
                        SendKeys.Send("{Tab}");
                    }
                    //if (ColumnName == "clnitemname" && Isitemedit == false)
                    //{
                    //    SendKeys.Send("{Tab}");
                    //}
                    if (ColumnName == "ClnMRate")
                    {
                        ControleSettEnter(ComMultiRate);
                        ComMultiRate.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                    }
                    if (ColumnName == "ClnUnit")
                    {
                        //ControleSettEnter(ComMultiUnit);
                        //ComMultiUnit.SelectedValue = gridmain.Rows[rowindex].Cells[columnindex].Tag;
                    }

                    if (ColumnName == "clnitemcode")
                    {
                        IsEnter = true;
                    }

                    if (ColumnName == "clnqty")
                    {

                        gridmain.BeginEdit(true);
                        if (SBatch == true)
                        {
                            string TBatchCode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                            //ShowStockinLabel(TBatchCode, ItemId, StockareaId);
                        }
                        //Fufocuscolumn("clnbatch");
                        
                    }

                    if (ColumnName == "clndiscount" || ColumnName == "clnsrate" || ColumnName == "ClnDiscPer" || ColumnName == "clnprate" || ColumnName == "clncrate" || ColumnName == "ClnMRP" || ColumnName == "clnfree" || ColumnName == "clnqty" || ColumnName == "clnbatch" || ColumnName == "ClnGross")
                    {
                        gridmain.BeginEdit(true);

                    }

                    




                }
            }
            catch
            {

            }
        }
        public void ShowStockinLabel(string TBatchcode, string TItemid, string TDcode)
        {

            if (SBatch == true)
            {
               
                Txtstock.Text =_Dbtask.SetintoDecimalpointStock(_Inventory.GetStock(" where pcode='" + TItemid + "' and dcode='" + TDcode + "' and batchcode='" + TBatchcode + "' "));
            }
            else
            {
                Txtstock.Text =_Dbtask.SetintoDecimalpointStock(_Inventory.GetStock(" where pcode='" + TItemid + "' and dcode='" + TDcode + "'"));
            }
            Txtstock.Text = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txtstock.Text));
        }

        public void ControleSettEnter(Control Cnt)
        {
            _Ingrid.ControleSettEnter(Cnt, gridmain);
        }

        public string chkqtyandrate(string column)
        {
            string resultvalue="";
            if(column=="clnqty")
             {
             resultvalue = "1";
             }
            if(column=="clnsrate")
            {
                resultvalue="Msg";
            }
            return resultvalue;
        }
        


        private void gridmain_CellLeave(object sender, DataGridViewCellEventArgs e)
                                                        {

            try
            {




                if (gridmain.SelectedCells.Count > 0)
                {
                    columnindex = gridmain.SelectedCells[0].ColumnIndex;
                    rowindex = gridmain.SelectedCells[0].RowIndex;
                    if (gridmain.Columns[columnindex].Name.ToString() == "clnitemcode")
                    {
                        if (ItemId == null)
                        {
                            //gridmain.CurrentCell = gridmain.Rows[rowindex].Cells["clnitemcode"];
                        }
                       
                    }
                    if (gridmain.Columns[columnindex].Name.ToString() == "clnqty" || gridmain.Columns[columnindex].Name.ToString() == "clnsrate" || gridmain.Columns[columnindex].Name.ToString() == "clnfree")
                    {


                        if (_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value) > 10000000 || _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value) > 10000000 || _Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnfree"].Value) > 10000000)
                        {
                            gridmain.Rows[rowindex].Cells[columnindex].Value = 0;
                            gridmain.Rows[rowindex].Cells["ClnGross"].Value = 0;
                            gridmain.Rows[rowindex].Cells["clnnettamount"].Value = 0;
                            gridmain.Rows[rowindex].Cells["clntax"].Value = 0;
                            gridmain.Rows[rowindex].Cells[ColumnName].Value = 0;
                            gridmain.NotifyCurrentCellDirty(false);
                        }
                    }
                    //if(uscGridshow2.GridProductShow.Visible==true)
                    //{
                    //    if(uscGridshow2.mclik==true)
                    //    {
                    //        string TempBathcode = ""; string ITENIDD = "";
                    //        int NowselectedRow = new int();
                    //        int selectedIndex = frmsalesinvoice.mrowindx;

                    //        if (uscGridshow2.GridProductShow.Visible == true && uscGridshow2.GridProductShow.SelectedRows.Count > 0)
                    //        {
                    //            NowselectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;

                               
                    //            TempBathcode = uscGridshow2.GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();

                    //        }

                    //        gridmain.Rows[rowindex].Cells["clnbatch"].Value = TempBathcode;
                    //        ITENIDD = CommonClass._Batch.GetSpecificFieldByBarcode("ITEMID", TempBathcode);
                    //        gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = ITENIDD.ToString();
                    //        gridmain.Rows[rowindex].Cells["ClnItemName"].Value = _ItemMaster.SpecificField(ITENIDD, "itemname").ToString();
                    //        ItemId = gridmain.Rows[rowindex].Cells["ClnItemName"].Tag.ToString();
                    //        IsEnter = false;
                    //        gridmain.Rows[rowindex].Cells["clnitemcode"].Value = _ItemMaster.SpecificField(ITENIDD, "itemcode").ToString();

                    //    }

                    //    uscGridshow2.mclik = false;
                    //}







                    if (gridmain.Columns[columnindex].Name.ToString() == "clnitemname")
                    {
                        Isitemedit = true;
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
                            //gridmain.Rows[rowindex].Cells["clnunit"].Tag = Unitid;
                            //gridmain.NotifyCurrentCellDirty(false);
                            GridUnitList.Visible = false;
                            gridmain.Rows[rowindex].Cells["clnunit"].Value = UnitName + "(" + CommonClass._Unitcreation.Getspesificfield("ucount", Unitid) + ")";
                            gridmain.Rows[rowindex].Cells["clnunit"].Tag = Unitid;
                            gridmain.NotifyCurrentCellDirty(false);
                        }
                    }

                    /***************Warnings*****************/

                    



                        double SQty;
                        double LeaveSrate;
                        ItemId=_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnitemname"].Tag);
                        Batchcode=_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);

                        SQty=_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnqty"].Value)+_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                        LeaveSrate=_Dbtask.znlldoubletoobject(gridmain.Rows[rowindex].Cells["clnsrate"].Value);    
                    /*For Warning*/
                        if (SBatch == true && Batchcode != "" && ItemId!="")
                        {
                            if (ColumnName == "clnsrate")
                            {
                                //if (_Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("LR<SR")) != "Allow")
                                //{
                                    if (CommonClass._Warnings.CheckSrateLessthanLastrate(Batchcode, LeaveSrate) == false)
                                    {

                                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = 0;
                                      
                                        gridmain.CurrentCell = gridmain.Rows[rowindex].Cells["clnsrate"];
                                    }
                                //}
                            }
                            if (ColumnName == "clnqty")
                                {
                                if (CommonClass._Warnings.CheckMinusStock(ItemId, _Dbtask.znlldoubletoobject(SQty), " ") == false)
                                {
                                    if (ColumnName == "clnqty")
                                        gridmain.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                                    else
                                        gridmain.Rows[rowindex].Cells["clnfree"].Value = 0;
                                    gridmain.NotifyCurrentCellDirty(false);
                                }
                            }
                            
                        }
                        
               /***************************************************/     

                    if (gridmain.Columns[columnindex].Name.ToString() == "clnbatch")
                    {
                        if(gridmain.Rows[rowindex].Cells["clnbatch"].Value !=null)
                        GetExpiryDateonBatch(gridmain.Rows[rowindex].Cells["clnbatch"].Value.ToString(), ItemId);
                    }

                   

                    if (ColumnName == "clnsrate")
                       // Falsesearchbarcode();

                    IsEnter = false;

                }

            }

           
            catch
            {
            }
          lastrow();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (ColumnName == "ClnDiscPer" || ColumnName == "clnqty" || ColumnName == "clnsrate" || ColumnName == "clnfree" || ColumnName == "clndiscount" || ColumnName == "clnTax")
            {
                Generalfunction.allowNumeric(sender, e, false);
                if (gridmain.Rows[rowindex].Cells[columnindex].Value == null)
                {
                    gridmain.Rows[rowindex].Cells[columnindex].Value = "0";
                }
            }
            if (ColumnName == "clnqty" || ColumnName == "clnfree")
            {
                Generalfunction.allowNumeric(sender, e, true);
            }
        }
        private void frmsalesinvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    this.Hide();
            //    this.Parent = null;
            //    e.Cancel = true;
            //}
            //catch
            //{
            //}
        }
       
        public void ProductIntoMainGrid()
        {
            selectedRow = uscGridshow2.GridProductShow.SelectedRows[0].Index;
            _Ingrid.ProductIntoMainGrid(gridmain, uscGridshow2.GridProductShow, selectedRow, rowindex, "Clnsrate", "ClnsrateS");

            ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();
            if (comratetype.SelectedValue.ToString() != "0")
            {
                try
                {
                    double Sratesecondery = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(rate,0) from tblproductrate where pcode='" + ItemId + "'"));
                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);
                }
                catch
                {
                }
            }
        }
        public void SettControleTextSett()
        {
            Lblstockarea.Text = NextGFuntion.StockAreaName;
        }
        public void Clearinfocusgrid()
                {

            txtPVNO.Text = "";
            CashReceivedTxt = "";
            SalesReturnText = "";
            EditMode = false;
            if (Vtype != "SR")
            {
               
                NextGFuntion.IsinSalesReturn = false;
                NextGFuntion.Salesreturnstring = "";
                NextGFuntion.SalesReturnAmount = 0;
                NextGFuntion.SalesReturnVno = "";
                if (DSSalesreturn.Tables.Count > 0)
                {
                    DSSalesreturn.Tables[0].Rows.Clear();
                }

                if (DSSalesreturnRetrive.Tables.Count > 0)
                {
                    DSSalesreturnRetrive.Tables[0].Rows.Clear();
                }
            }
            RegistrationCheck();
            Retrivemode = 0;
            //this.txtbillamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            SettControleTextSett();
            _Nextg.ClearControles(PnlGeneral);
            _Nextg.ClearControles(PnlBottom);
            Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            Txttypecooly.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtNaration.textBox1.Text = "";
            txtpaid.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            dtdate.Value = DateTime.Now;
            gridmain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridmain.AllowUserToResizeRows = false;
            SetGridColumn(); /*For Settings*/
            FillCombo();


            GetVno();

            IsEnterGrid = true;
            if (gridmain.Rows.Count > 0)
                gridmain.Rows.Clear();

            IsEnterGrid = false;

            SetcontrolePosition();
            TxtProduct.Visible = false;
            txttempNames.Text = "";
            //EditMode 
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(0);
            txttqty.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTFree.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTDiscount.Text = _Dbtask.SetintoDecimalpoint(0);
            txttqty.Text = _Dbtask.SetintoDecimalpointStock(0);
            txtotherexpenses.Text = _Dbtask.SetintoDecimalpoint(0);
            TxttAmount.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTGross.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);
            IsEnter = true;
            TxtAccount.Text = "";
            txtvehiname.Text = "";

            TxtTcustmr.Text = "";
            TXTtMOB.textBox1.Text = "";
            TxtxTvat.Text = ""; txtmtrread.Text = "";
            txtxvehiclenum.Text = "";
            txtTaddrss.textBox1.Text = "";
            TxtAccount.Tag = 1;
            Lblpartybalance.Visible = false;
            txtbillamount.Text = "0.00";
            comcustomerproject.DataSource = null;
            gridmain.Focus();
                            gridmain.CurrentCell = gridmain.Rows[0].Cells[0];
            Controlebehaviour(false);
            TottalAmountCalculate(true);
            txtwarrantyy.Text = "";
            txtRoundOff.Text = "";
            roundof = 0;
            txtmobilee.textBox1.Text = "";
            //txtpaid.textBox1.Text = "0.00";
            Txtstock.Text = "0.00";
            visibleflse();
            //frmsalesinvoice.twotypepaymnt = false;
            FrmCashDesk.Otherpayamt = 0;
                        TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("defSaleDiscAMT"));

            PNLCOSTINVCE.Visible = false;
            GridRate.Visible = false;

            frstival = 0;
            frstibool = false;
                                        Lbltemporarydetails.Tag = "";
            Lblpartybalance.Text = "";
            if (Vtype == "SI")
            {
                txtPVNO.Text = Pvnoval;
                movingitems();

            }
            if (Vtype == "SR")
            {
                txtPVNO.Text = PvnovalSR;
            }




            TxtTcustmr.Text = "";
            TXTtMOB.textBox1.Text = "";
            txtTaddrss.textBox1.Text = "";
            TxtxTvat.Text = "";

            txtponum.Text = "";

            txtdeliverinot.Text = "";

            txtattention.Text = "";

            txtmrfprno.Text = "";

            txtproject.Text = "";
            lblledgertext.Text = "Customer(Alt+F3 New) زبون";

            dtdue.Value = DateTime.Now; ;
            getmodeofpayment();
            lBLCOUNTSALETODAY.Text = "";
            lBLCOUNTSALETODAY.Text = _Dbtask.znllString(_BusinessIssue.countofsale());


            dtdue.Value = DateTime.Now; ;
            
            
            //twotypepaymnt = false;
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
                commodeofpayment.Items.Clear();
                commodeofpayment.Items.Add("السيولة النقدية");
                commodeofpayment.Items.Add("الآجل");
                commodeofpayment.Items.Add("بطاقة");
                commodeofpayment.SelectedIndex = 0;
                CommonClass._Language.PanelBasedConversion(PnlGeneral);
                CommonClass._Language.PanelBasedConversion(pnlcommon);
                CommonClass._Language.PanelBasedConversion(PnltotalAmount);
                CommonClass._Language.PanelBasedConversion(panel5);
                CommonClass._Language.PanelBasedConversion(pnlprintoptions);
                CommonClass._Language.PanelBasedConversion(PnlBottom);
            }
        }
        public void visibleflse()
        {
            if(_Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("199"))=="1")
            {
                lblvehicle.Visible = true; txtxvehiclenum.Visible = true;
                lblvehiclname.Visible = true; txtvehiname.Visible = true;
            }
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("200")) == "1")
            {
                txtmtrread.Visible = true; lblmtrread.Visible = true;

            }
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("201")) == "1")
            {
                Semployee = true;
                Comemployee.Visible = true; lblemployee1.Visible = true;
            }
            else
            {
                Semployee = false;
            }

        }
        public void Clear()
                                    {
            if(Vtype=="SR")
            {
                txtPVNO.Text = PvnovalSR;
                cmdTemset.BackColor = Color.Aquamarine;
            }
            TxtTcustmr.Text = "";
            TXTtMOB.textBox1.Text = "";
            TxtxTvat.Text = "";
            txtTaddrss.textBox1.Text = "";
            EditMode = false;
           
            Retrivemode = 0;
            txttempNames.Text = "";
            Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            Txttypecooly.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTGross.Text = _Dbtask.SetintoDecimalpoint(0);
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(0);
            txttqty.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTFree.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTDiscount.Text = _Dbtask.SetintoDecimalpoint(0);
            txttqty.Text = _Dbtask.SetintoDecimalpointStock(0);
            txtotherexpenses.Text = _Dbtask.SetintoDecimalpoint(0);
            TxttAmount.Text = _Dbtask.SetintoDecimalpoint(0);
            TxtTGross.Text = _Dbtask.SetintoDecimalpoint(0);
            txtbillamount.Text = _Dbtask.SetintoDecimalpoint(0);
            txtinvoicediscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            txtinvoicediscperc.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
            txtRoundOff.Text = _Dbtask.SetintoDecimalpoint(0);
            dtdate.Value = DateTime.Now;
           
            txtpaid.textBox1.Text = _Dbtask.SetintoDecimalpointStock(0);
            if (Vtype != "SR")
            {
               
                NextGFuntion.IsinSalesReturn = false;
                NextGFuntion.Salesreturnstring = "";
                NextGFuntion.SalesReturnAmount = 0;
            }
            SetGridColumn(); /*For Settings*/
            FillCombo();
            GetVno();
            // GridSelect();
            // SetDecimal();
            // SetHeading();
            // txtvno.Focus();

            if(gridmain.Rows.Count>0)
            gridmain.Rows.Clear();

            SetcontrolePosition();
            TxtProduct.Visible = false;
            if (Searchingmode == true)
            {
                Truesearchbarcode();
            }
            //EditMode 
            TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);
            IsEnter = true;
            TxtAccount.Text = "";
            TxtAccount.Tag = 1;
            Retrivemode = 0;
            Lblpartybalance.Visible = false;
            txtbillamount.Text = "0.00";
            lblledgertext.Text = "Customer(Alt+F3 New) زبون";
            Lblpartybalance.Text = "0";
            Controlebehaviour(false);
            TottalAmountCalculate(true);
            comcustomerproject.DataSource = null;
            SalesReturnText = "";
            txtmobilee.textBox1.Text = "";
            txtwarrantyy.Text = "";
                    PnlTdetails.Visible = false;
           TXTtMOB.textBox1.Text="";
          txtTaddrss.textBox1.Text="";
           TxtxTvat.Text="";
           TxtTcustmr.Text = "";
           tempCclear();
           txtmtrread.Text = "";
           txtxvehiclenum.Text = "";
           FrmCashDesk.Otherpayamt = 0;
           visibleflse();
           txtRoundOff.Text = "";
           roundof = 0;
           txtvehiname.Text = "";
           TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("defSaleDiscAMT"));
           PNLCOSTINVCE.Visible = false;
           GridRate.Visible = false;
           frstibool = false;
           frstival = 0;

           Lbltemporarydetails.Tag = "";

           txtponum.Text = "";

           txtdeliverinot.Text = "";

           txtattention.Text = "";

           txtmrfprno.Text = "";

           txtproject.Text = "";
                        


           TxtTcustmr.Text = "";
           TXTtMOB.textBox1.Text = "";
           txtTaddrss.textBox1.Text = "";
           TxtxTvat.Text = "";

            TxtNaration.textBox1.Text = "";



            getmodeofpayment();

           if (Vtype == "SI")
           {
               txtPVNO.Text = Pvnoval;
               cmdlastbillcopy.Visible = true;
               movingitems();

           }
        }
        public void tempCclear()
        {
          Tnamee = "";
          Tmob = "";
          Tvat = "";
          Taddres = "";
          PnlTdetails.Visible = false;
          TXTtMOB.textBox1.Text = "";
          txtTaddrss.textBox1.Text = "";
          TxtxTvat.Text = "";
          TxtTcustmr.Text = "";
           
        }


        public void ClearTemp()
        {
            gridmain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridmain.AllowUserToResizeRows = false;
            FillCombo();
            TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);
            Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);
            IsEnter = true;
            TxtAccount.Text = "Cash Account";
            TxtAccount.Tag = "1";   
            lblledgertext.Text = "Customer(Alt+F3 New) زبون";
            Lblpartybalance.Text = "0";
            txtvno.Focus();
        }
        public void SetGridColumn()
        {
            try
            {
                GetMenusettings();

                Generalfunction.ActiveForm = this.Name.ToString();
                Retrivemode = 0;
                Textalignsett();
                this.Text = Heading;                
                MyPrinter = new LPrinter();
                Controlesett();

                Bmode = false;
                if (Salesarea == false)
                {
                    Lblsalesarea.Visible = false;
                    comsalesarea.Visible = false;
                    Lblsalesarea1.Visible = false;
                }

                if (Sprintwhilesaving == false)
                {
                    ChkPrintWileSaving.Checked = false;
                }
                if (Spconfirmation == false)
                {
                    chkprintconfirmation.Checked = false;
                }
                if (SprintPreview== false)
                {
                    ChkShowPreview.Checked = false;
                }
                Bmode = true;
                if (Smrate == false)
                {
                    comratetype.Visible = false;
                    lblratetype.Visible = false;
                    lblratetype1.Visible = false;
                }
                if (SBatch == false)/*For Batch Enabled*/
                {
                    clnbatch.Visible = false;
                    clnitemcode.ReadOnly = false;
                }
                if (SUnit == false)/*For Unit*/
                {
                    ClnUnit.Visible = false;

                }
                if (SSitemDiscount == false)/*For Item Discount*/
                {
                    clndiscount.Visible = false;
                    ClnDiscPer.Visible = false;
                }
                if (SRoundoff == false)/*For Item Discount*/
                {
                    txtRoundOff.Enabled = false;
                }
                if (SSfree == false)
                {
                    clnfree.Visible = false;
                }
                if (Seditsrate == false)
                {
                    clnsrate.ReadOnly = true;
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
                    Lblstockarea1.Visible = false;
                }

                if (Sagent == false)
                {
                    ComAgent.Visible = false;
                    lblagent.Visible = false;
                    TxtAgentAmt.Visible = false;
                    lblagent1.Visible = false;
                }

                if (Semployee == false)
                {
                    lblemployee.Visible = false;
                    lblemployee1.Visible = false;
                    Comemployee.Visible = false;
                    Txtemployeeamt.Visible = false;
                }

                if (SSerialnotracking == false)
                {
                    clnserialno.Visible = false;
                }
                if (Sinvoicediscount == false)
                {
                    clnbilldiscount.Visible = false;
                    lblinvoicediscount.Visible = false;
                    lblinvoicediscountdot.Visible = false;
                    txtinvoicediscperc.Visible = false;
                    txtinvoicediscount.Visible = false;
                }
               // if (Spharmacy == false)
               // {
                 //   clnexpiry.Visible = false;
               // }
                if (VisibleSrate == false)
                {
                    clnsrate.Visible = false;
                }
                if (EditGross == false)
                {
                    ClnGross.ReadOnly = true;
                }
                if (Spartyproject == false)
                {
                    comcustomerproject.Visible = false;
                }
                
                //clnitemcode.Visible = false;

                CommonClass._Gen.FillActivePrinter(ComPrintSheme);

                string bunit = "";
                bunit = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='302010'").ToString();
                if (bunit == "1")
                {
                gridmain.Columns["clnBaseU"].Visible = true;
                BUNIT = true;
                gridmain.Columns["clnunit"].Visible = false;

                }
                else
                {
                gridmain.Columns["clnBaseU"].Visible = false;
                BUNIT = false;
                //gridmain.Columns["clnunit"].Visible = true;
                }


                if (Enableprinterselection == false)
                {
                    ComPrintSheme.Enabled = false;
                }
                if (Enableitemnote == true)
                {
                    clnitemnote.Visible = true;
                }
                if(Vtype=="SI")
                {
                //int codeW=46;
                //codeW=Convert.ToInt32( CommonClass._Paramlist.GetParamvalue("codewidthSI"));
                gridmain.Columns["clnitemcode"].Width =itemcodewid;

                gridmain.Columns["clnitemname"].Width = itemwid;
                gridmain.Columns["clnbatch"].Width = batchwidth;
                gridmain.Columns["clnlang"].Width = langwidth; 

                }



            }
            catch
            {
            }
        }

        public void DevideToBillDiscount()
        {
            if (Sinvoicediscount == true)
            {
                double Perc;
                double SinglePerc=0;
                double TGross=0;
                InvoiceDiscount = _Dbtask.znullDouble(txtinvoicediscount.textBox1.Text);
                NetGross = _Dbtask.znullDouble(TxtTGross.Text);
                Perc =Math.Round(InvoiceDiscount* 100/NetGross,2) ;

                if (rowindex < gridmain.Rows.Count)
                {
                    for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
                    {
                        if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                        {
                            TGross = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clngross"].Value);
                            SinglePerc =Math.Round(TGross * 100 / NetGross,2);
                            gridmain.Rows[i].Cells["clnbilldiscount"].Value =Math.Round(InvoiceDiscount * SinglePerc / 100,2);
                        }
                    }
                }

                if (Perc.ToString() == "NaN")
                    Perc = 0;
                txtinvoicediscperc.textBox1.Text = Perc.ToString();
            }
        }

        public void GetMenusettings()
                {
            try
            {
                SetHeading();
                _sales.FuFocusfirstRow();

                if (_Settings.ReturnStatus("173") == "1")
                {
                    Searchingmode = true;
                }
                if (_Settings.ReturnStatus("144") == "1")
                {
                    SSWmachine = true;
                }

                if (_Settings.ReturnStatus("102")=="1")
                {
                    Sitemwiseagentcommision = true;
                }


                if (_Settings.ReturnStatus("12") == "1")
                {
                    SUnit = true;
                }
                /*Batch*/

                if (_Settings.ReturnStatus("103") == "1")
                {
                    SBatch = true;
                }
                /*Sales Item Discount*/
                if (_Settings.ReturnStatus("108") == "1")
                {
                    SSitemDiscount = true;
                }

                /*Roundoff*/
                if (_Settings.ReturnStatus("107") == "1")
                {
                    SRoundoff = true;
                }
                /*Sales Item Free*/
                if (_Settings.ReturnStatus("110") == "1")
                {
                    SSfree = true;
                }
                /*Edit SalesRate*/
                if (_Settings.ReturnStatus("112") == "1")
                {
                    Seditsrate = true;
                }

                /*Multi Rate */
                if (_Settings.ReturnStatus("11") == "1")
                {
                    Smrate = true;
                }
                /*Tax */
                if (_Settings.ReturnStatus("14") == "1")
                {
                    STax = true;
                }

                /*Stock Area*/

                if (_Settings.ReturnStatus("13") == "1")
                {
                    SDepo = true;
                }

                /*For Batch is Second*/


                if (_Settings.ReturnStatus("121") == "1")
                {
                    Useasbarcode = true;
                }

                if (_Settings.ReturnStatus("116") == "1")
                {
                    Semployee = true;
                }

                if (_Settings.ReturnStatus("115") == "1")
                {
                    Sagent = true;
                }

                if (_Settings.ReturnStatus("123") == "1")
                {
                    SSsizes = true;
                }

                if (_Settings.ReturnStatus("124") == "1")
                {
                    Supdatesrate = true;
                }

                if (_Settings.ReturnStatus("125") == "1")
                {
                    SFlex = true;
                }

                if (_Settings.ReturnStatus("135") == "1")
                {
                    Sprintwhilesaving = true;
                }

                if (_Settings.ReturnStatus("136") == "1")
                {
                    Spconfirmation = true;
                }
               

                if (_Settings.ReturnStatus("138") == "1")
                {
                    SprintPreview = true;
                }

                if (_Settings.ReturnStatus("139") == "1")
                {
                    SCashDesk = true;
                }

                if (_Settings.ReturnStatus("141") == "1")
                {
                    SSerialnotracking = true;
                }

                if (_Settings.ReturnStatus("143") == "1")
                {
                    Sinvoicediscount = true;
                }

                temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=145");
                if (_Settings.ReturnStatus("145") == "1")
                {
                    Spharmacy = true;
                }

                if (_Settings.ReturnStatus("147") == "1")
                {
                    EditGross = true;
                }

                if (_Settings.ReturnStatus("148") == "1")
                {
                    VisibleSrate = true;
                }

                if (_Settings.ReturnStatus("153") == "1")
                {
                    RemoveDublicate = true;
                }
                if (_Settings.ReturnStatus("156") == "1")
                {
                    Spartyproject = true;
                }
                if (_Settings.ReturnStatus("160") == "-1")
                {
                    clnqty.ReadOnly = true;
                }
                if (_Settings.ReturnStatus("164") == "1")
                {
                    Zerotaxsave = true;
                }
                if (_Settings.ReturnStatus("167") == "1")
                {
                    Salesarea = true;
                }
                if (_Settings.ReturnStatus("168") == "1")
                {
                    SSaveZeroRate= true;
                }
                if (_Settings.ReturnStatus("175") == "1")
                {
                    Enableprinterselection = true;
                }

                if (_Settings.ReturnStatus("193") == "1")
                {
                    Enableitemnote = true;
                }
            }
            catch
            {
            }
        }
        public void SetHeading()
        {
            if (Vtype == "SI")
            {
            }
            else
            {
            }
        }
        public void SetcontrolePosition()
        {
            PnlGeneral.Dock = System.Windows.Forms.DockStyle.Top;

        }

        public void GetVno()
             {
            if (Vtype == "SI"||Vtype=="DN"||Vtype=="SO"||Vtype=="SQ"||Vtype=="SV")
            
            {
                    lbltodaysale.Text = _Dbtask.ExecuteScalar("select count(*) from tblbusinessissue where issuetype='" + Vtype + "' and issuedate between'" + DateTime.Now.ToString("MM-dd-yyyy") + " 00:00:00' and '" +
                    DateTime.Now.ToString("MM-dd-yyyy") + " 23:59:59'");
                _BusinessIssue.PVno2Server(SalesAccount.ToString(), Vtype);
                if (_BusinessIssue.Pvno != "" )
                {
                        //txtvno.Text = Convert.ToString(_BusinessIssue.Pvno);
                    txtvno.Text =  Convert.ToString(_BusinessIssue.VnoStr);
                  //txtvno.Text + Convert.ToString(_BusinessIssue.VnoStr);
                }
                else    if (SalesAccount == "2" || CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToLower() == "wholesale" || CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToLower() == "estimate")
                {
                    txtvno.Text = Convert.ToString(_BusinessIssue.VnoStr);
                }
                else if (CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToLower() == "service account")
                {
                    txtvno.Text = Convert.ToString(_BusinessIssue.VnoStr);
                }
                else 
                {
                    txtvno.Text =CommonClass._Ledger.GetspecifField("lname",SalesAccount)+ Convert.ToString(_BusinessIssue.VnoStr);
                }

                txtvno.Tag = _BusinessIssue.IdSalesFuAzure(SalesAccount, Vtype);

                    _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                    _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }

            if (Vtype == "SR")
            {
                lbltodaysale.Text = _Dbtask.ExecuteScalar("select count(*) from tbltransactionreceipt where recpttype='"+Vtype+"' and recptdate between'" + DateTime.Now.ToString("MM-dd-yyyy") + " 00:00:00' and '" +
                     DateTime.Now.ToString("MM-dd-yyyy") + " 23:59:59'");
                _TransactionReceipt.SRVnoAzure(SalesAccount.ToString());
                if (_TransactionReceipt.pvno != "")
                {
                   // txtvno.Text = Convert.ToString(_TransactionReceipt.pvno);
                    txtvno.Text = Convert.ToString(_TransactionReceipt.VNoStr); 
                        //txtvno.Text; //+Convert.ToString(_TransactionReceipt.VNoStr);
                }
                else
                {
                    txtvno.Text = Convert.ToString(_TransactionReceipt.VNoStr);
                }
                txtvno.Tag = _TransactionReceipt.IdSRFuAzure(SalesAccount);
                _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
                _Inventory.Vcode = txtvno.Tag.ToString();
            }


            if (EditMode == false)
            {
                getmaxvnonumber();
            }
            
        }

     
        //public void GetVnoOnlyIssuecode()
        //{
        //    if (EditMode == false)
        //    {
        //        if (Vtype == "SI" || Vtype == "DN")
        //        {
        //            _BusinessIssue.PVno2(SalesAccount.ToString(), Vtype);
        //            if (_BusinessIssue.Pvno != "")
        //            {
        //            }
        //            else
        //            {
        //            }

        //            txtvno.Tag = _BusinessIssue.IdSalesFu(SalesAccount, Vtype);

        //            _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
        //            _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
        //            _Inventory.Vcode = txtvno.Tag.ToString();
        //        }


        //        if (Vtype == "SR")
        //        {

        //            _TransactionReceipt.SRVno(SalesAccount.ToString());
        //            if (_TransactionReceipt.pvno != "")
        //            {
        //            }
        //            else
        //            {
        //            }
        //            txtvno.Tag = _TransactionReceipt.IdSRFu(SalesAccount);
        //            _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
        //            _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
        //            _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
        //            _Inventory.Vcode = txtvno.Tag.ToString();
        //        }
        //    }
        //}

        public void FillCombo()
        {
            _Depot.FillCombo(ComDepot);
            if (Vtype == "SR")
            {
                SalesAccount = "2";
            }
            ComDepot.SelectedIndex = 0;
            _EmployeeMaster.FillCombo(Comemployee);
            _MultiRates.FillCombo(comratetype);
            _AccountLedger.FillAgent(ComAgent, " Where Agroupid=29");
            CommonClass._Area.FillArea(comsalesarea);
            /*For Tax*/
            if (this.Heading.ToLower() != "estimate")
            {
                string temp = _Dbtask.ExecuteScalar("select paramvalue from Tblparamlist where paramname='TaxDef'");
                ComTax.Text = temp;
            }
            else
            {
                ComTax.Text = "None";
            }

           // commodeofpayment.SelectedIndex = 0;

            /*Item Category*/

            CommonClass._ItemCategory.FillCombo(comitemcategory,true);
            /*Defalt Settings*/
            commodeofpayment.SelectedIndex = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("PSpayment"));
            Comemployee.SelectedValue = Convert.ToInt16(_Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("SalesmanDef")));
            ComDepot.SelectedValue = Convert.ToInt16(_Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("DepotDef")));
            ComTaxinvoice.Text = _Dbtask.GetInvoiceHeaderinprint();
        }
       
        public void IsinBrandroot()
        {
            if(Vtype=="SR"&&NextGFuntion.IsinSalesReturn==true)
            NextGFuntion.SalesReturnAmount = Convert.ToDouble(txtbillamount.Text);
        }

        private bool Main()
         {

                                                
            if (EditMode == false)
                GetVno();
            if (nocustmr == true &&_Dbtask.znllString(txtmobilee.textBox1.Text) != "")
            {
                if(EditMode==false)
                {
                   
                createacustmr();
                    
                }

            }
            if ( RowValidation()&&ValidationFu()&&ValidationSecondPhase())
                {
                try
                {
                    if (TxtAccount.Tag.ToString() != "1")
                        _Laser.OldBalance = _AccountLedger.Balanceofledger(TxtAccount.Tag.ToString());
                    _Thermal.OLDBBLNC = _AccountLedger.Balanceofledger(TxtAccount.Tag.ToString());
                        if (EditMode == true)
                    {
                        DeleteVoucher();
                        DeleteVoucherAzure();
                    }

                    if (EditMode == true)
                    {
                        ForLogindetails("UPDATE");
                    }
                    else
                    {
                        ForLogindetails("NEW");
                    }
                    IsinBrandroot();
                    recvdamt(_Dbtask.znllString(commodeofpayment.SelectedIndex));
                    NextgInitialize();
                    _Thermal.NOWBBLNC = _AccountLedger.Balanceofledger(TxtAccount.Tag.ToString());

                    _sales.Nounit = false;
                    ExternelSaving();
                     if (ChkPrintWileSaving.Checked == true)
                    {

                        Nocopies();
                        //  DefinePrint();
                    }
                    /*For Registration*/
                    if (EditMode == false)
                    {
                        _Nextg.Registrationinsert(1);
                    }

                        Clearinfocusgrid();


                            FuFocusing();
                            if (NextGFuntion.IsinSalesReturn  == true)
                        this.Close();

                    if (CommonClass._Gen.chkother() == true)
                    {
                        Generalfunction.Newformsales = true;
                        this.Close();
                    }
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
           /**Immediate Close***/
           
        }
        public string FuSinaration(string Pvtype)
        {
            if (Pvtype == "SR")
            {
                return TxtNaration.textBox1.Text;
            }
            else
            {
                return "";
            }
        }
        private bool ValidationSecondPhase()
        {
            try
            {
                if (Vtype == "SI" || Vtype == "SR")
                {
                    CommonClass._SecondPhaseTran.FuSend(txtvno.Text, dtdate, TxttItemDiscount.Text, txtbillamount.Text, gridmain, 0, _Dbtask.znllString(TxtAccount.Tag), Vtype, _Dbtask.znllString(commodeofpayment.Text), txtvno.Text, FuSinaration(Vtype));
                    if (Clssecondphase.StrInvstatus == "REPORTED" || Clssecondphase.StrInvstatus == "CLEARED")
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public void ExternelSaving()
        {
            if (Generalfunction.EWmachine == true)/*For WMachine Enable*/
                _Gen.ExportToWieghtMechine();
        }
        public void ForLogindetails(string Mode)
        {

            try
            {
                StrVtyp = CommonClass._Nextg.VtypeDescription(Vtype);
                if (Mode == "NEW")
                {
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    OldData = "";
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "NEW", "", StrVtyp, OldData, NewData);
                }
                else if (Mode == "UPDATE")
                {
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    // CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "UPDATE", "", StrVtyp, "", NewData);
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "UPDATE", "", StrVtyp, OldData, NewData);
                }
                else if (Mode == "DELETE")
                {
                    NewData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", StrVtyp, OldData, NewData);
                }

            }
            catch
            { 
            }
        }

        public void CRanddateLimit(string lidd)
        {
            if (_Dbtask.znllString( commodeofpayment.SelectedIndex) != "0" &&_Dbtask.znllString(commodeofpayment.SelectedIndex) != "2")
            {
                if(_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("198"))=="1")
                {
                string cus=""; double dayss=0;
                double oldbalnce = 0; double crlimi = 0; double crdate = 0;
                double finalamt = 0; double bill=0;
                double crdays = 0;
                bill=_Dbtask.znlldoubletoobject( txtbillamount.Text);
                oldbalnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + lidd + "' "));
                if (EditMode == false)
                {
                    finalamt = (oldbalnce + bill);
                }
                else
                {
                    finalamt = oldbalnce;
                }
                
                crlimi = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select creditlimit from tblaccountledger where lid='"+lidd+"'"));
               crdays = _Dbtask.znlldoubletoobject((_Dbtask.ExecuteScalar("select creditdays from tblaccountledger where lid='" + lidd + "'")));
                
                cus =TxtAccount.Text.ToString();
                if (crlimi>0)
                 {
                if (finalamt > crlimi)
                {
                    MessageBox.Show(cus + "  Credit limit is over. Old Balance is  = " + _Dbtask.znllString(oldbalnce) + ".  Current Balance is = " +_Dbtask.znllString( finalamt ) + "  /- ");
                }
                }
                //dayss = _Dbtask.znlldoubletoobject(_GeneralLedger.creditdaysstatus(lidd));
                //dayss =_Dbtask.znlldoubletoobject( _Dbtask.SetintoDecimalpoint(dayss));
                if (oldbalnce>0)
                  {
                if (_Dbtask.znllString(_GeneralLedger.creditdayschekbylastbill(lidd, Convert.ToInt32(crdays))) == "OVER")
                  {
                  MessageBox.Show(cus + "  Credit Days is Over  ! " + "Allowed no.of days is  " + _Dbtask.znllString(  crdays));
                   }
                 }
             }
            
            }
        }
        public void recvdamt(string modepay)
        {

            if (modepay=="0")
             {
                CashReceivedTxt =_Dbtask.znllString( FrmCashDesk.TCash);
                if (FrmCashDesk.TCash==0)
                {
                 CashReceivedTxt =_Dbtask.znllString(  txtbillamount.Text);
                }
             }
            if (modepay == "1")
            {
                CashReceivedTxt = _Dbtask.znllString(FrmCashDesk.TCash);
            }
            if (modepay == "2")
            {
                CashReceivedTxt = _Dbtask.znllString(FrmCashDesk.TCash);
                if (FrmCashDesk.TCash == 0)
                {
                    CashReceivedTxt = _Dbtask.znllString(txtbillamount.Text);
                }
            }



        }

        public bool maxvoucherexistcheck(string vtype, string account, string vno)
        {


            string exi = "";

            if (vtype == "SI" || vtype == "SO" || vtype == "SQ" )
            {
            exi = _Dbtask.znllString( _Dbtask.ExecuteScalar("select vno from tblbusinessissue where issuetype='" + vtype + "' and ledcodecr='" + account + "'  and vno='" + vno + "'"));
            }

            if (vtype == "SR")
            {
                exi = _Dbtask.znllString(_Dbtask.ExecuteScalar("select vno from tblTRANSACTIONRECEIPT where recpttype='" + vtype + "' and ledcodedr='" + account + "'  and Reptcode='" + vno + "'"));
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
            try
            {

                string enabling = "";
                enabling = CommonClass._Menusettings.GetMnustatus("179").ToString();
                TBillAmount = _Dbtask.znullDouble(txtbillamount.Text);

                CRanddateLimit(_Dbtask.znllString(TxtAccount.Tag));
                
                if(commodeofpayment.SelectedIndex==1)
                {
                    if(_Dbtask.znllString( TxtAccount.Tag)!="")
                    {
                        TxtAccount.Text = CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(TxtAccount.Tag));
                    }
                }
                
                if (txtvno.Text == "")
                {
                 //   MessageBox.Show("Type Vno");
                    MessageBox.Show("Type Vno", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtvno.Focus();
                    return false;
                }
                if (_Dbtask.znullDouble(Txttypecooly.textBox1.Text) > 100000)
                {
                    MessageBox.Show("Check Other expense", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtvno.Focus();
                    return false;
                }
                if (TBillAmount<= 0)
                {
                    MessageBox.Show("Check Bill Amount", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtvno.Focus();
                    return false;
                }
                string CustomerID = _Dbtask.znllString(TxtAccount.Tag);
                if (commodeofpayment.SelectedIndex == 1 && CustomerID == "")
                {
                    MessageBox.Show("Select Customer", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtAccount.Focus();
                    return false;
                }
                if (ComPrintSheme.Text == ""&&ChkPrintWileSaving.Checked==true)
                {
                    MessageBox.Show("Select Printer", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ComPrintSheme.Focus();
                    return false;
                }

                //if(EditMode==false)
                //{
                //if(maxvoucherexistcheck(Vtype ,SalesAccount, _Dbtask.znllString(txtvno.Text))==true)
                //{
                //    MessageBox.Show("DATA ALREADY EXIST - VOUCHER NO(" + _Dbtask.znllString(txtvno.Text) + ")", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                //    return false;
                //}

                //}




               
                if (EditMode == false)
                {
                    if (Vtype == "SI")
                    {
                            if(commodeofpayment.SelectedIndex==1)
                        {
                               if(!CommonClass._Warnings.CheckCreditLimit(TxtAccount.Tag.ToString(),_Dbtask.znullDouble(txtbillamount.Text)))
                               {
                                return false;
                               }
                        }
                        Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuetype='SI' and ledcodecr='" + SalesAccount + "' and vno='" + txtvno.Text + "'");
                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            GetVno();
                        }
                    }
                    if (Vtype == "SR")
                    {
                        Ds = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where Recpttype='SR' and ledcodedr='" + SalesAccount + "' and vno='" + txtvno.Text + "'");
                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            GetVno();
                        }
                    }

                }


                if (EditMode == true&&enabling=="-1")
                {
                    MessageBox.Show("Not Permited");
                    return false;
                }

                if (EditMode == true)
                {
                    if (_UserDetails.Permited() == false)
                    {
                        return false;
                    }
                }
                /*For Cash Desk****************************/
                if (SCashDesk == true && Vtype == "SI")
                {
                    svno = txtvno.Text.ToString();
                    CommonClass._Forms.Showcashdesk(_Dbtask.znullDouble(txtbillamount.Text) + _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text), _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text), commodeofpayment.SelectedIndex, _Dbtask.znllString(TxtAccount.Tag));
                    Txttypebilldiscount.textBox1.Text = FrmCashDesk.TCashdiscount.ToString();
                    commodeofpayment.SelectedIndex = FrmCashDesk.Modepayment;
                    TottalAmountCalculate(true);
                
                }

                if (CommonClass.CashDeskValidate == false && Vtype == "SI" && SCashDesk == true)
                {
                    return false;
                }
                /********************************************/
                //CashReceivedTxt = CommonClass.CashDesk;

                for (int i = 0; i < gridmain.Rows.Count; i++)
                {

                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            if (txtvno.Text != "")
                            {
                                if (TxtAccount.Tag != null)
                                {
                                    return true;
                                }
                            }
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

        public void UnitAmountCalc()
        {
            //DS3 = _Dbtask.ExecuteQuery("select * from tblItemmaster where ItemId='" + ItemId + "'");

            //if (DS3.Tables[0].Rows.Count > 0)
            //{
            //    SecUnit = DS3.Tables[0].Rows[0]["Unit2"].ToString();
            //    FirUnit = DS3.Tables[0].Rows[0]["Unit"].ToString();
            //    Unitamount1 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount1"].ToString());
            //    UnitAmount2 = _Dbtask.znullDouble(DS3.Tables[0].Rows[0]["UnitAmount2"].ToString());
            //    if (UnitName == FirUnit)
            //    {
            //        Convrt = Unitamount1;
            //    }
            //    if (UnitName == SecUnit)
            //    {
            //        Convrt = Unitamount1 * UnitAmount2;
            //    }
            //}

            Convrt =_Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", Unitid));
        }
        public void twotypepayment()
       {
         //if(frmsalesinvoice.twotypepaymnt == true)
         //{
             if (FrmCashDesk.Otherpayamt > 0)
             {
                 string Accountidd = ""; string secndpayaccount = "";
                 string secndaccount = "";
                 if (commodeofpayment.Text.ToString() == "CREDIT")
                 {
                     Accountidd = _Dbtask.znllString(TxtAccount.Tag);


                     //if (commodeofpayment.Text.ToString() == "CASH" || commodeofpayment.Text.ToString() == "CARD")
                     //{
                     //    Accountidd = _Dbtask.znllString(SalesAccount);

                     //}
                     _GeneralLedger.VTypeStr = "R";
                     _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                     _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Tag);
                     _GeneralLedger.LedCodeStr = _Dbtask.znllString(Accountidd);
                     _GeneralLedger.PurticularsStr = "Two type payment" + Heading;
                     _GeneralLedger.DbAmtDb = 0;
                     _GeneralLedger.CrAmt = FrmCashDesk.Otherpayamt;
                     Insert();

                     // _Dbtask.znllString(FrmCashDesk.secndpaymode);
                     secndpayaccount = _Dbtask.znllString(TxtAccount.Tag);
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 0)
                     {
                         secndaccount = "1";
                     }
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 2)
                     {
                         secndaccount = "28";

                     }
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 1)
                     {
                         secndaccount = _Dbtask.znllString(TxtAccount.Tag);
                     }
                     

                     _GeneralLedger.LedCodeStr = _Dbtask.znllString(secndaccount);  //GetCreditLedCode();
                     _GeneralLedger.PurticularsStr = "Two type payment" + Heading;
                     _GeneralLedger.DbAmtDb = _Dbtask.znlldoubletoobject(FrmCashDesk.Otherpayamt);
                     _GeneralLedger.CrAmt = 0;
                     Insert();
                 }
                 else
                 {

                     secndpayaccount = _Dbtask.znllString(TxtAccount.Tag);
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 0)
                     {
                         secndaccount = "1";
                     }
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 2)
                     {
                         secndaccount = "28";

                     }
                     if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 1)
                     {
                         secndaccount = _Dbtask.znllString(TxtAccount.Tag);
                     }

                     _GeneralLedger.VTypeStr = "R";
                     _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                     _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Tag);
                     _GeneralLedger.LedCodeStr = _Dbtask.znllString(secndaccount);  //GetCreditLedCode();
                     _GeneralLedger.PurticularsStr = "Two type payment" + Heading;
                     _GeneralLedger.DbAmtDb = _Dbtask.znlldoubletoobject(FrmCashDesk.Otherpayamt);
                     _GeneralLedger.CrAmt = 0;
                     Insert();
                 }
                 if (Convert.ToInt32(FrmCashDesk.secndpaymode) == 2 || Convert.ToInt32(FrmCashDesk.secndpaymode) == 0 )
                  {

                      if (commodeofpayment.Text.ToString() != "CREDIT")
                     {
                     TBillAmount = (TBillAmount - FrmCashDesk.Otherpayamt);
                     }
                     
                     }
                 
             }

         //}
       }

        public void getmaxvnonumber()
                {
            vnoname = "";
            EditMode = false;
            if (Vtype == "SI" && SalesAccount == "2")
            {
                vnoname = "MaxofSI";
            CommonClass._GenF.checkmaxtableandparamvalAzure(CommonClass._Paramlist.GetParamvalueazure("MaxofSI"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalueazure("MaxofSI");
                    txtvno.Text = CommonClass._Paramlist.GetParamvalueazure("MaxofSI");
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();

                txtPVNO.Text = Pvnoval;

            }
            if (Vtype == "SI" && SalesAccount != "2")
            {
                vnoname = "MaxofSIwh";

                CommonClass._GenF.checkmaxtableandparamvalAzure(CommonClass._Paramlist.GetParamvalueazure("MaxofSIwh"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalueazure("MaxofSIwh");
                txtvno.Text = CommonClass._Paramlist.GetParamvalueazure("MaxofSIwh");
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }
            if (Vtype == "SO")
            {
                vnoname = "MaxofSO";

                CommonClass._GenF.checkmaxtableandparamvalAzure(CommonClass._Paramlist.GetParamvalueazure("MaxofSO"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalueazure("MaxofSO");
                    txtvno.Text = CommonClass._Paramlist.GetParamvalueazure("MaxofSO");
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }
            if (Vtype == "SQ")
            {
                vnoname = "MaxofSQ";


                CommonClass._GenF.checkmaxtableandparamvalAzure(CommonClass._Paramlist.GetParamvalueazure("MaxofSQ"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalueazure("MaxofSQ");
                txtvno.Text = CommonClass._Paramlist.GetParamvalueazure("MaxofSQ");
                _IssueDetails.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _BusinessIssue.IssueCodeLng = Convert.ToInt64(txtvno.Tag);
                _Inventory.Vcode = txtvno.Tag.ToString();
            }

             if (Vtype == "SR")
            {
                vnoname = "MaxofSR";

                CommonClass._GenF.checkmaxtableandparamvalAzure(CommonClass._Paramlist.GetParamvalueazure("MaxofSR"), vnoname);

                txtvno.Tag = CommonClass._Paramlist.GetParamvalueazure("MaxofSR");
                txtvno.Text = CommonClass._Paramlist.GetParamvalueazure("MaxofSR");
                _ReceiptDetails.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _TransactionReceipt.RcptCodeLng = Convert.ToInt64(txtvno.Tag);
                _Batch.Recptcode = Convert.ToString(txtvno.Tag); ;
                _Inventory.Vcode = txtvno.Tag.ToString();
                txtPVNO.Text = PvnovalSR;
            }





        }


        public void comapnydetailssecondphase()
        {

            ClsPHASEtwocompanyprofile.PHcrn = _PhaseTwocompanyprof.GetspecifField("CRN");
            ClsPHASEtwocompanyprofile.PHschemeID = _PhaseTwocompanyprof.GetspecifField("CRN");
            ClsPHASEtwocompanyprofile.PHStreetName = _PhaseTwocompanyprof.GetspecifField("PostelCode");
            ClsPHASEtwocompanyprofile.PHBuildingNumber = _PhaseTwocompanyprof.GetspecifField("BuildingNo");
            ClsPHASEtwocompanyprofile.PHCityName = _PhaseTwocompanyprof.GetspecifField("City");
            ClsPHASEtwocompanyprofile.PHPostalZone = _PhaseTwocompanyprof.GetspecifField("PostelCode");
            ClsPHASEtwocompanyprofile.PHCitySubdivisionName = _PhaseTwocompanyprof.GetspecifField("SubDivision");

            ClsPHASEtwocompanyprofile.PHRegistrationName = _PhaseTwocompanyprof.GetspecifField("firmname");
            ClsPHASEtwocompanyprofile.PHCompanyID = _PhaseTwocompanyprof.GetspecifField("vatnumber");
        }




        public void NextgInitialize()
            {

             TBillAmount = _Dbtask.znullDouble(txtbillamount.Text);

            string usernamee = "";
            userNo = "";
            usernamee = ClsUserDetails.MUserName;
            userNo = CommonClass._UserDetails.GetSpecificfieldbyname(usernamee, "userid");

            DataTable dtBulk = _IssueDetails.GetIssueDetailsDataTable();
            DataTable dtInventory = _Inventory.GetInventoryDataTable();
            DataTable dtBulkReceipt = _ReceiptDetails.ReceiptdetailDataBulk();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                /* Inventory */
                double Unitqty = 0;
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        StrPurticulars = _GeneralLedger.PurticularsCreate(TxtAccount, txtvno);
                        StrPurticularsForLedger = _GeneralLedger.PurticularsCreateForLedger(this.Text, txtvno);

                        long Slno = Convert.ToInt64 (_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["Clnslno"].Value));
                        string SlTracking = _Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);
                        string Pid = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Tag);

                        double qty = _Dbtask.gridnul(gridmain.Rows[i].Cells["Clnqty"].Value);
                        double Srate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnsrate"].Value);
                        double Crate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clncost"].Value);
                        double NetAmt = _Dbtask.gridnul(gridmain.Rows[i].Cells["Clnnettamount"].Value);
                        double Mrp = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnmrp"].Value);
                        double TaxRate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clntax"].Value);
                        double Taxper = _Dbtask.gridnul(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                        double Discrate = _Dbtask.gridnul(gridmain.Rows[i].Cells["clndiscount"].Value);
                        double free = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnfree"].Value);
                        double Length = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnlength"].Value);
                        double Width = _Dbtask.gridnul(gridmain.Rows[i].Cells["clnwidth"].Value);
                                string StrSlno = _Dbtask.znllString(gridmain.Rows[i].Cells["clnserialno"].Value);
                        string Itemnote2 = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemnote"].Value);
                            DateTime Exdate = _Dbtask.ZnullDatetime(gridmain.Rows[i].Cells["clnexpiry"].Value);
                            VEHICLE = _Dbtask.znllString(txtxvehiclenum.Text);
                            MTRREAD = _Dbtask.znllString(txtmtrread.Text);



                        //if(Tdetail==true)
                        //{
                        if(Semployee == true)
                        {
                         staffid=   _Dbtask.znllString(Comemployee.SelectedValue);
                        }
                            Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);
                            Tvat = _Dbtask.znllString(TxtxTvat.Text);
                            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);
                            if (txttempNames.Text != ""&&Lbltemporarydetails.Tag=="")
                            {
                                Tnamee = _Dbtask.znllString(txttempNames.Text);
                            }


                            if (Tnamee=="" &&_Dbtask.znllString( TxtAccount.Text)!="")
                            {
                                Tnamee = _Dbtask.znllString(TxtAccount.Text);

                            }


                            //Tmob = Tmob;
                            //Tvat = Tvat;
                            //Taddres = Taddres;
                            //Tnamee = Tnamee;
                        //}


                       if(StrSlno!="")
                        CommonClass._Slno.InsertSlnopara(Pid, StrSlno, Vtype, txtvno.Text, -1);
                        if (SUnit == true)
                        {
                            Munit = Convert.ToInt16(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnunit"].Tag));
                            Unitid = Munit.ToString();
                            UnitName = CommonClass._Unitcreation.Getspesificfield("name", Munit.ToString());
                            ItemId = Pid;
                            UnitAmountCalc();
                            Unitqty = Convrt * qty;
                        }
                         
                        if (Smrate == true)
                        {
                            Mrate = Convert.ToInt32(comratetype.SelectedValue);
                        }

                        if (SBatch == true)
                        {
                            Batchcode =_Dbtask.znllString( gridmain.Rows[i].Cells["clnbatch"].Value);

                        }
                        _Inventory.Ledcode = SalesAccount;
                        _Inventory.DCodeStr = StockareaId;
                        _Inventory.InvDateDt = dtdate.Value;
                        _Inventory.PcodeStr = Pid;
                        _Inventory.Slno = SlTracking;
                        _Inventory.Vtype = Vtype;


                        _Inventory.UC = Convrt;
                        _Inventory.Exdate = Exdate;


                        DataRow drInv = dtInventory.NewRow();

                        drInv["Dcode"] = StockareaId;
                        drInv["InvDate"] = dtdate.Value;
                        drInv["PCode"] = Pid;
                        drInv["Os"] = 0;
                        drInv["Purchase"] = 0;
                        drInv["Mr"] = 0;
                        drInv["Ireceipt"] = 0;
                        drInv["bmr"] = 0;
                        drInv["iissue"] = 0;
                        drInv["sh"] = 0;
                        drInv["dmg"] = 0;
                        drInv["bmi"] = 0;

                        drInv["Ledcode"] = SalesAccount;
                        
                        
                        drInv["Slno"] = Slno;
                        drInv["UC"] = Convrt;
                        drInv["Exdate"] = Exdate;
                        drInv["Vtype"] = Vtype;

                        
                        /****************************************/
                        /*Update SaleRate*/
                        if (Vtype == "SI" || Vtype == "DN" || Vtype == "SR"||Vtype=="SV")
                        {
                            if (comratetype.SelectedIndex == 0)
                            {
                                if (Supdatesrate == true)
                                {
                                    if (SBatch == false)
                                    {
                                        _ItemMaster.UpdateField(Pid, Srate, "srate");
                                    }
                                    else
                                    {
                                        _Batch.UpdateField(Pid, Srate, "srate", Batchcode,Exdate.ToString("dd/MMM/yyyy"));
                                    }
                                }
                            }
                            if (comratetype.SelectedIndex == 1)
                            {
                                if (Supdatesrate == true)
                                {

                                    if (SBatch == false)
                                    {
                                        _Productrate.UpdateField(Pid, Srate, "rate", false, "",0);
                                    }
                                    else
                                    {
                                        _Productrate.UpdateField(Pid, Srate, "rate", true, Batchcode,0);
                                    }

                                }

                            }

                            /***********************************/
                            if (Vtype == "SI")
                            {
                                if (SUnit == true)
                                {
                                    _Inventory.Sales = Unitqty;
                                    drInv["Sales"] = Unitqty;
                                }
                                else
                                {
                                    _Inventory.Sales = qty;
                                    drInv["Sales"] = qty;
                                }
                                _Inventory.Sr = 0;
                                _Inventory.Dn = 0;
                                drInv["Sr"] = 0;
                                drInv["dn"] = 0;
                            }
                            if (Vtype == "DN")
                            {
                                if (SUnit == true)
                                {
                                    _Inventory.Dn = Unitqty;
                                    drInv["dn"] = Unitqty;
                                }
                                else
                                {
                                    _Inventory.Dn = qty;
                                    drInv["dn"] = qty;
                                }
                                _Inventory.Sr = 0;
                                _Inventory.Sales = 0;
                                drInv["Sr"] = 0;
                                drInv["Sales"] = 0;
                            }

                            if (Vtype == "SR")
                            {
                                if (SUnit == true)
                                {
                                    _Inventory.Sr = Unitqty;
                                    drInv["Sr"] = Unitqty;
                                }
                                else
                                {
                                    _Inventory.Sr = qty;
                                    drInv["Sr"] = qty;
                                }
                                _Inventory.Sales = 0;
                                _Inventory.Dn = 0;
                                drInv["Sales"] = 0;
                                drInv["dn"] = 0;
                                //if (SBatch == true)
                                //{
                                //    _Batch.Bcode = Batchcode;
                                //    _Batch.Itemid = Pid;
                                //    _Batch.Costcenter = "0";
                                //    _Batch.Depo = StockareaId;
                                //    _Batch.Bid = (_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnbatch"].Tag)).ToString();
                                //    _Batch.Recptcode = txtvno.Tag.ToString();
                                //    _Batch.Ledcode = SalesAccount;
                                //    _Batch.Mrp = Mrp;
                                //    _Batch.Srate = Srate;
                                //    _Batch.Prate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select prate from tblitemmaster where itemid='" + ItemId + "'"));
                                //    _Batch.InsertBatch();
                                //}
                            }

                            _Inventory.freeiss = free;
                            _Inventory.Costcenter = "0";
                            _Inventory.Batchcode = Batchcode;
                            drInv["freeiss"] = free;
                            drInv["costcenter"] = "0";
                            drInv["batchcode"] = Batchcode;
                            drInv["ps"] = 0;
                            drInv["pr"] = 0;
                            drInv["Dnr"] = 0;
                            drInv["freepre"] = 0;

                            if (i == frstival&&EditMode==false)
                            {
                                    getmaxvnonumber();
                                //txtvno.Text = _Dbtask.ExecuteScalarAzureServer("select max(issuecode) from  tblbusinessissue where issuetype='"+Vtype+"'");

                                //txtvno.Tag = txtvno.Text;

                                // MessageBox.Show(txtvno.Tag.ToString());
                                CommonClass._Paramlist.updateparamvalueVNO(vnoname, Convert.ToInt32(txtvno.Tag));
                /*for server*/  CommonClass._Paramlist.updateparamvalueVNOAzure(vnoname, Convert.ToInt32(txtvno.Tag));
                            }
                            drInv["Vcode"] = Convert.ToInt64(txtvno.Tag);
                            dtInventory.Rows.Add(drInv);
                            _Inventory.InsertInventory();
                           // _Inventory.InsertInventoryAzureServer();
                        }
                        if (Vtype == "SI"||Vtype=="DN"||Vtype=="SO"||Vtype=="SQ"||Vtype=="SV")
                        {
                            _IssueDetails.SlNoLng = Slno;
                            _IssueDetails.PCodeStr = Pid;
                            _IssueDetails.UnitIdLng = Munit;
                            _IssueDetails.MultiRateIdLng = Mrate;
                            _IssueDetails.QtyDb = qty;
                            _IssueDetails.RateDb = Srate;
                            _IssueDetails.Mrp = Mrp;
                            _IssueDetails.NetAmtDb = NetAmt;
                            _IssueDetails.BatchIdStr = Batchcode;
                            _IssueDetails.Ledcode = SalesAccount;
                            _IssueDetails.DiscDb = Discrate;
                            _IssueDetails.TaxRateDb = TaxRate;
                            _IssueDetails.QtyFreeDb = free;
                            _IssueDetails.Vtype = Vtype;
                            _IssueDetails.Taxper = Taxper;

                            _IssueDetails.SlnoTracking = SlTracking;
                            _IssueDetails.Length = Length;
                            _IssueDetails.width = Width;
                            _IssueDetails.CRate = Crate;
                            _IssueDetails.ExDate = Exdate;
                            _IssueDetails.Itemnote2 = Itemnote2;
                            _IssueDetails.billtot = TBillAmount;
                            _IssueDetails.billtime = "";



                            DataRow dr = dtBulk.NewRow();

                             dr["issueCode"] = Convert.ToInt64(txtvno.Tag);
                            dr["Slno"] = Slno;
                            dr["Pcode"] = Pid;
                            dr["UnitId"] = Munit;
                            dr["BatchId"] = Batchcode;
                            dr["MultirateId"] = Mrate;
                            dr["Qty"] = qty;
                            dr["Qty1"] = 0;         // If available
                            dr["Qty2"] = 0;
                            dr["pnum"] = 0;        // If available
                            dr["freeQty"] = free;
                            dr["Rate"] = Srate;
                            
                            dr["Crate"] = Crate;
                           
                            dr["DiscRate"] = Discrate;
                            dr["Billdisc"] = 0;
                            dr["Taxrate"] = TaxRate;
                            dr["mrp"] = Mrp;
                            dr["Taxper"] = Taxper;
                            dr["NetAmt"] = NetAmt;
                            dr["Itemnote"] = "";
                            dr["Ledcode"] = SalesAccount;
                            dr["vtype"] = Vtype;
                            
                            dr["lth"] = Length;
                            dr["wth"] = Width;
                            dr["Slnotracking"] = "";
                            dr["Exdate"] = Exdate;
                            dr["Itemnote2"] = "";
                            dr["billtot"] = TBillAmount;
                           
                            dr["billtime"] = "";
                           

                            dtBulk.Rows.Add(dr);
                            string jh;
                              // jh= newfu.FuSend(txtvno.Text, dtdate, TxttItemDiscount.Text, txtbillamount.Text, gridmain, 0);
                           
                            _IssueDetails.InsertIssueDetails();
                        }
                        if (Vtype == "SR")
                        {
                            _ReceiptDetails.SlNoLng = Slno;
                            _ReceiptDetails.ItemNoteStr = SlTracking;
                            _ReceiptDetails.PCodeStr = Pid;
                            _ReceiptDetails.UnitIdLng = Munit;
                            _ReceiptDetails.MultiRateIdLng = 0;
                            _ReceiptDetails.QtyDb = qty;
                            _ReceiptDetails.RateDb = Srate;
                            _ReceiptDetails.SRate = Srate;
                            _ReceiptDetails.CRate = Srate;
                            _ReceiptDetails.QtyFreeDb = free;
                            _ReceiptDetails.NetAmtDb = NetAmt;
                            _ReceiptDetails.BatchIdstr = Batchcode;
                            _ReceiptDetails.DiscDb = Discrate;
                            _ReceiptDetails.Ledcode = SalesAccount;
                            _ReceiptDetails.Mrp = Mrp;
                            _ReceiptDetails.TaxRateDb = TaxRate;
                            _ReceiptDetails.Vtype = Vtype;
                            _ReceiptDetails.Taxper = Taxper;
                            _ReceiptDetails.billtot = TBillAmount;

                            _ReceiptDetails.ExciseDuty = 0;

                            DataRow drR = dtBulkReceipt.NewRow();

                            drR["RecptCode"] = Convert.ToInt64(txtvno.Tag);
                            drR["Slno"] = Slno;
                            drR["Pcode"] = Pid;
                            drR["UnitId"] = Munit;
                            drR["BatchId"] = Batchcode;
                            drR["MultirateId"] = 0;
                            drR["Qty"] = qty;
                            // If available
                            drR["freeQty"] = free;

                            drR["Rate"] = Srate;
                            drR["DiscRate"] = Discrate;
                            drR["Billdisc"] = 0;
                            drR["Profit"] = 0;
                            drR["TaxRate"] = TaxRate;
                            drR["NetAMT"] = NetAmt;
                            drR["ItemNote"] = SlTracking;
                            drR["ItemNote1"] = "";
                            drR["mandate"] = DateTime.Now;
                            drR["exdate"] = DateTime.Now;
                            drR["srate"] = Srate;
                            drR["crate"] = Srate;

                            drR["mrp"] = Mrp;
                            drR["Ledcode"] = SalesAccount;
                            drR["vtype"] = Vtype;

                            drR["Taxper"] = Taxper;
                            drR["exciseduty"] = 0;
                            drR["wrate"] = 0;


                            drR["billtot"] = TBillAmount;
                           

                            dtBulkReceipt.Rows.Add(drR);



                            _ReceiptDetails.InsertReceiptDetails();
                        }
                    }
                }
            }
            BulkInsertIssueDetailsToAzure(dtInventory, "tblinventory");

            //int count = dtBulk.Rows.Count;
            if (Vtype == "SI" || Vtype == "DN" || Vtype == "SO" || Vtype == "SQ" || Vtype == "SV")
            {
                BulkInsertIssueDetailsToAzure(dtBulk, "tblissuedetails");
            }
            if (Vtype == "SR")
            {
                BulkInsertIssueDetailsToAzure(dtBulkReceipt, "tblreceiptdetails");
            }
            

            _Nextg.SetVno(txtvno.Text);

             double AdvancePay=new double();

            //if(commodeofpayment.SelectedIndex==0)
            //     AdvancePay = _Dbtask.znullDouble(txtbillamount.Text);
            //else
            //    AdvancePay = _Dbtask.znullDouble(txtpaid.textBox1.Text);

               if (commodeofpayment.SelectedIndex == 1)
             {
                 AdvancePay = _Dbtask.znullDouble(txtpaid.textBox1.Text);

             }
             if (commodeofpayment.SelectedIndex == 0 && _Dbtask.znllString(TxtAccount.Tag) != "1")
             {
                 if (_Dbtask.znllString(TxtAccount.Tag) != "" && _Dbtask.znllString(TxtAccount.Tag) != "28")
                 {

                     string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
                     if (_Dbtask.znllString(TxtAccount.Tag) != temp)
                     {
                         txtpaid.textBox1.Text = _Dbtask.znllString(txtbillamount.Text);
                         AdvancePay = _Dbtask.znullDouble(txtpaid.textBox1.Text);

                     }

                 }
             }


             if (Spartyproject == true)
                PProject=Convert.ToInt64(comcustomerproject.SelectedValue);

                    if (Vtype == "SI"||Vtype=="DN"||Vtype=="SO"||Vtype=="SQ"||Vtype=="SV")
            {
                //Second Phase Saving//
                //CommonClass._SecondPhaseTran.0(txtvno.Text, dtdate, TxttItemDiscount.Text, txtbillamount.Text, gridmain, 0);
                _BusinessIssue.VnoStr = _Nextg.vno;
                    _BusinessIssue.Pvno = Pvnoval;//_Nextg.pvno;
             
                _BusinessIssue.IssueTypeStr = Vtype;
                _BusinessIssue.DCode = StockareaId;
                _BusinessIssue.IssueDateDt = dtdate.Value;
                _BusinessIssue.LedCodeCr = SalesAccount.ToString();
                _BusinessIssue.LedCodeDr = TxtAccount.Tag.ToString();
                _BusinessIssue.AMTDb = TBillAmount;
                _BusinessIssue.RemarkStr = TxtNaration.textBox1.Text;
                _BusinessIssue.DiscAmtDb = _Dbtask.gridnul(Txttypebilldiscount.textBox1.Text);
                _BusinessIssue.TaxAMTDb = _Dbtask.gridnul(txtttax.Text);
                _BusinessIssue.CoolyDb = _Dbtask.gridnul(Txttypecooly.textBox1.Text);
                _BusinessIssue.Agent = agentid;
                _BusinessIssue.EmpId = staffid;
                _BusinessIssue.AdvanceAmount = AdvancePay;
                _BusinessIssue.CashReceived = CashReceivedTxt;
                _BusinessIssue.SR = NextGFuntion.SalesReturnVno;
                _BusinessIssue.Pproject = PProject;
                _BusinessIssue.warrantyy = txtwarrantyy.Text.ToString();
                _BusinessIssue.Uid = ClsUserDetails.MUserName;
                _BusinessIssue.vehicle = VEHICLE;
                _BusinessIssue.mtrread = MTRREAD;
                _BusinessIssue.Tmob = Tmob;
                _BusinessIssue.Tvat = Tvat;
                _BusinessIssue.Taddres = Taddres;
                _BusinessIssue.Tename = Tnamee;
                _BusinessIssue.twopaymode =_Dbtask.znllString( FrmCashDesk.secndpaymode);
                _BusinessIssue.vehiclename = _Dbtask.znllString(txtvehiname.Text);
                _BusinessIssue.twopayAmt = FrmCashDesk.Otherpayamt;
                _BusinessIssue.LBLaccnt = _Dbtask.znllString(Lbltemporarydetails.Tag);
                _BusinessIssue.ModeOfpayment = ModeOFpaymentFu();
               _BusinessIssue.POnum=       _Dbtask.znllString( txtponum.Text);
                _BusinessIssue.Deliverynote      =_Dbtask.znllString(txtdeliverinot.Text );
               _BusinessIssue.Attention     =_Dbtask.znllString( txtattention.Text);
               _BusinessIssue.MRFPRnum    =_Dbtask.znllString(txtmrfprno.Text );
                _BusinessIssue.Projcts   =_Dbtask.znllString( txtproject.Text);

                _BusinessIssue.Due = _Dbtask.znllString(dtdue.Value);


                //_BusinessIssue.Tename = TxtAccount.Text;


            }
            if (Vtype == "SR")
            {
                StringTemp = dtdate.Value.ToString("dd/MMM/yyyy");
                _TransactionReceipt.RcptDateDt = Convert.ToDateTime(StringTemp);
                _TransactionReceipt.Rcptdatebilling = Convert.ToDateTime(StringTemp);
                _Nextg.SetVno(txtvno.Text);
                _TransactionReceipt.Uid = ClsUserDetails.MUserName;
                _TransactionReceipt.VNoStr = _Nextg.vno;
                _TransactionReceipt.pvno = PvnovalSR; //_Nextg.pvno;
              
                _TransactionReceipt.RefNo = "";
                _TransactionReceipt.RCptTypeStr = Vtype;
                _TransactionReceipt.DcodeStr = StockareaId;
                _TransactionReceipt.RcptDateDt = dtdate.Value;
                _TransactionReceipt.LedCodeCr = TxtAccount.Tag.ToString();
                _TransactionReceipt.LedCodeDr = SalesAccount;
                _TransactionReceipt.AMTDb = _Dbtask.gridnul(txtbillamount.Text);
                _TransactionReceipt.RemarkStr = TxtNaration.textBox1.Text;
                _TransactionReceipt.DiscAmtDb = _Dbtask.gridnul(Txttypebilldiscount.textBox1.Text);
                _TransactionReceipt.TaxAMTDb = _Dbtask.gridnul(txtttax.Text);
                _TransactionReceipt.CoolyDb = _Dbtask.gridnul(Txttypecooly.textBox1.Text);
                _TransactionReceipt.EmpId = staffid.ToString();
                _TransactionReceipt.Agent = agentid.ToString();
                _TransactionReceipt.Pproject = PProject;
                _TransactionReceipt.Tmob = Tmob;
                _TransactionReceipt.Tvat = Tvat;
                _TransactionReceipt.Taddres = Taddres;
                _TransactionReceipt.Tename = Tnamee;
                _TransactionReceipt.LBLaccnt = _Dbtask.znllString(Lbltemporarydetails.Tag);
                _TransactionReceipt.Modeofpayment = ModeOFpaymentFu();

               // _TransactionReceipt.Tename = TxtAccount.Text;
            
            
            }

                if (Vtype == "SI")
            {
                CommonClass._BillSett.InsertBillsettlement(txtvno.Text, Vtype, Convert.ToInt64(TxtAccount.Tag), 0, TBillAmount, "", dtdate.Value, 0,_Dbtask.znllString(dtdue.Value));

            }
            if (Vtype == "SR")
            {
                CommonClass._SRbill.InsertSRBillsettlement(_Dbtask.znllString(txtvno.Text), Vtype, Convert.ToInt64(TxtAccount.Tag), _Dbtask.znlldoubletoobject(TBillAmount), 0, "", dtdate.Value, 0);

            }


            StringTemp = Convert.ToString(dtdate.Value);

            if (Vtype == "SI" || Vtype == "DN"||Vtype=="SO"||Vtype=="SQ"||Vtype=="SV")
            {
                _BusinessIssue.IssueDateDt = Convert.ToDateTime(StringTemp);
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
            if (Vtype == "SR")
            {
                _TransactionReceipt.RcptDateDt = Convert.ToDateTime(StringTemp);
                if (ComTax.SelectedIndex == 0)
                {
                    _TransactionReceipt.Taxid = "0";
                }
                if (ComTax.SelectedIndex == 1 || ComTax.SelectedIndex == 3)
                {
                    _TransactionReceipt.Taxid = "9";
                }
                if (ComTax.SelectedIndex == 2)
                {
                    _TransactionReceipt.Taxid = "24";
                }
                _TransactionReceipt.InsertTransactionReceipt();
            }
            
            /*For General Ledger */

            _GeneralLedger.Pproject = PProject;
            if (Vtype == "SI" || Vtype == "SV")
            {
                /*Advance Paid*/
                _GeneralLedger.Uid = ClsUserDetails.MUserName;
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                //_GeneralLedger.Naration2 = txtwarrantyy.Text.ToString();
                _GeneralLedger.RefnoStr = SalesAccount;


               


                twotypepayment();

                //if (Vtype == "SI")
                //{
                //    if (AdvancePay > 0)
                //    {
                //        _GeneralLedger.VTypeStr = "R";
                //        _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                //        string prfx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='sprefix'");
                //        if (prfx != "")
                //        {
                //            int vnL = Convert.ToInt32(prfx.Length);
                //            VNo = VNo.Substring(vnL);
                //        }
                //        else
                //        {
                //            VNo = _Dbtask.znllString(txtvno.Text);
                //        }

                //        _GeneralLedger.SlNoLng = Convert.ToInt64(VNo);
                //        _GeneralLedger.LedCodeStr = "1";
                //        _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //        _GeneralLedger.DbAmtDb = AdvancePay;
                //        _GeneralLedger.CrAmt = 0;
                //        Insert();
                //        _GeneralLedger.LedCodeStr = TxtAccount.Tag.ToString();
                //        _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //        _GeneralLedger.DbAmtDb = 0;
                //        _GeneralLedger.CrAmt = AdvancePay;
                //        Insert();
                //    }
                //}
                
                //if (AdvancePay > 0)
                //{
                //    _GeneralLedger.VTypeStr = "R";
                //    _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                //    _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Tag);
                //    _GeneralLedger.LedCodeStr = "1";
                //    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //    _GeneralLedger.DbAmtDb = AdvancePay;
                //    _GeneralLedger.CrAmt = 0;
                //    Insert();
                //    _GeneralLedger.LedCodeStr =_Dbtask.znllString( TxtAccount.Tag);  //GetCreditLedCode();
                //    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //    _GeneralLedger.DbAmtDb = 0;
                //    _GeneralLedger.CrAmt = AdvancePay;
                //    Insert();
                //}
                //if (AdvancePay > 0)
                //{
                //    _GeneralLedger.VTypeStr = "R";
                //    _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                //    _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Text);
                //    _GeneralLedger.LedCodeStr = "1";
                //    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //    _GeneralLedger.DbAmtDb = AdvancePay;
                //    _GeneralLedger.CrAmt = 0;
                //    Insert();
                //    _GeneralLedger.LedCodeStr = TxtAccount.Tag.ToString();
                //    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading;
                //    _GeneralLedger.DbAmtDb = 0;
                //    _GeneralLedger.CrAmt = AdvancePay;
                //    Insert();
                //}
                /*****************************/
                /*For Debit*/
                
                _GeneralLedger.VTypeStr = Vtype;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr = TxtAccount.Tag.ToString();
                _GeneralLedger.PurticularsStr = StrPurticularsForLedger;
                _GeneralLedger.DbAmtDb =TBillAmount;
                _GeneralLedger.CrAmt = 0;
                _GeneralLedger.cashdskRcvamt =Convert.ToDouble( FrmCashDesk.TCash);

                //CommonClass._BillSett.InsertBillsettlement(txtvno.Text, Vtype, Convert.ToInt64(TxtAccount.Tag), 0, TBillAmount, "", dtdate.Value, Convert.ToInt16(Comemployee.SelectedValue));
              
                Insert();
                
                
                
                TBillAmount = _Dbtask.znlldoubletoobject(txtbillamount.Text);
                /*For Credit */
                _GeneralLedger.LedCodeStr = SalesAccount.ToString();
                _GeneralLedger.PurticularsStr = StrPurticulars;
                _GeneralLedger.DbAmtDb = 0;

                _GeneralLedger.cashdskRcvamt = Convert.ToDouble(FrmCashDesk.TCash);
                double TTCooly = _Dbtask.znullDouble(Txttypecooly.textBox1.Text);
                double TTInvoiceDiscount = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);
                double TTItemdiscou = _Dbtask.znullDouble(TxttItemDiscount.Text);
                double TTdis = TTInvoiceDiscount + TTItemdiscou;
                double TTTax = _Dbtask.znullDouble(txtttax.Text);
                double Cr = TTCooly + TTTax;
                double TTNet = TBillAmount ;//TBillAmount - Cr;
                _GeneralLedger.CrAmt = TTNet + TTdis;
                Insert();
            }

            if (Vtype == "SR")
            {
                /*For Debit For Account Ledger*/
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.VTypeStr = Vtype;
                _GeneralLedger.VnoStr = txtvno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr = TxtAccount.Tag.ToString();
                _GeneralLedger.PurticularsStr = StrPurticularsForLedger;
                _GeneralLedger.DbAmtDb = 0;
                _GeneralLedger.CrAmt = TBillAmount;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                _GeneralLedger.RefnoStr = SalesAccount;
                _GeneralLedger.Naration2 = txtwarrantyy.Text.ToString();
                Insert();

                /*For Credit */
                _GeneralLedger.LedCodeStr = SalesAccount.ToString();
                _GeneralLedger.PurticularsStr = StrPurticulars;

                double TTCooly = _Dbtask.znullDouble(txtotherexpenses.Text);
                double TTInvoiceDiscount = _Dbtask.znullDouble(txttinvoicediscount.Text);
                double TTItemdiscou = _Dbtask.znullDouble(TxttItemDiscount.Text);
                double TTdis = TTInvoiceDiscount + TTItemdiscou;
                double TTtypedisc = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);

                _GeneralLedger.DbAmtDb = TBillAmount +(TTdis + TTtypedisc);
                //_GeneralLedger.DbAmtDb = TBillAmount - (TTdis+TTtypedisc);
              
                _GeneralLedger.CrAmt = 0;
                Insert();

            }
            /*For Other Expense*/
            double OtherExpAmt = _Dbtask.gridnul(Txttypecooly.textBox1.Text);
            string OtherExpAccount = "26";
            if (OtherExpAmt > 0)
            {
                if (Vtype == "SI")
                {
                    _GeneralLedger.InsertAccountsCrPurchase(OtherExpAccount, StrPurticulars, 0, OtherExpAmt, SalesAccount);
                }
                if (Vtype == "SR")
                {
                    _GeneralLedger.InsertAccountsDrSales(OtherExpAccount, StrPurticulars, OtherExpAmt, 0, SalesAccount);
                }
            }
            /*For Agent */
              if (Vtype == "SI"|| Vtype=="SR")
                {
                    AgentAmt = _Dbtask.gridnul(TxtAgentAmt.Text);
                    if (agentid != "0" && AgentAmt > 0&&Sagent==true)
                    {
                        _GeneralLedger.InsertAccountsCrPurchase(agentid, StrPurticulars, AgentAmt, 0, SalesAccount);
                        _GeneralLedger.InsertAccountsDrSales(SalesAccount, StrPurticulars, 0, AgentAmt, SalesAccount);

                    }
                    ///* For Staff*/
                    StaffAmt = _Dbtask.gridnul(Txtemployeeamt.Text);
                    if (staffid != "0" && StaffAmt > 0&&Semployee==true)
                    {
                        _GeneralLedger.InsertAccountsDrSales(staffid, StrPurticulars, StaffAmt, 0, SalesAccount);
                        _GeneralLedger.InsertAccountsDrSales(SalesAccount, StrPurticulars, 0, StaffAmt, SalesAccount);
                    }
                }
            /*For Discount Pay */
            TottalDiscount = _Dbtask.gridnul(Txttypebilldiscount.textBox1.Text);
            if (TottalDiscount >0)
            {
                if (Vtype == "SI"||Vtype=="SV")
                {
                    _GeneralLedger.InsertAccountsDrSales("7", StrPurticulars, TottalDiscount, 0, SalesAccount);
                }
                else if (Vtype == "SR")
                {
                    _GeneralLedger.InsertAccountsCrPurchase("7", StrPurticulars, 0, TottalDiscount, SalesAccount);
                }
            }


            /*For Roundoff*/
           //roundof = _Dbtask.gridnul(txtRoundOff.Text);
           //string fff = "";
           //fff = _Dbtask.znllString (txtRoundOff.Text);
          // roundof = Convert.ToDouble(fff);
            //roundof = Convert.ToDouble(  txtRoundOff.Text);
            if ((roundof > 0 ||roundof < 0) )
            {
                if( Vtype == "SI")
                {
                _GeneralLedger.InsertAccountsDrSales("12", StrPurticulars, roundof, 0, SalesAccount);
                }
                }
            else if ((roundof > 0 || roundof < 0) && Vtype == "SR")
            {
                _GeneralLedger.InsertAccountsCrPurchase("12", StrPurticulars, 0, roundof, SalesAccount);
            }


            /*For Tax */
            TottalTax = _Dbtask.gridnul(txtttax.Text);
            if (Vtype == "SI")
            {
                if (ComTax.Text == "VAT" && TottalTax > 0)
                {
                    _GeneralLedger.InsertAccountsCrPurchase("9", StrPurticulars, 0, TottalTax, SalesAccount);
                }
                if (ComTax.Text == "CST" && TottalTax > 0)
                {
                    _GeneralLedger.InsertAccountsCrPurchase("24", StrPurticulars, 0, TottalTax, SalesAccount);
                }
            }
            if (Vtype == "SR")
            {
                if (NextGFuntion.IsinSalesReturn == true)
                {
                    NextGFuntion.SalesReturnVno = txtvno.Text;
                }
                if (ComTax.Text == "VAT" && TottalTax > 0)
                {
                    _GeneralLedger.InsertAccountsDrSales("9", StrPurticulars, TottalTax, 0, SalesAccount);
                }
                if (ComTax.Text == "CST" && TottalTax > 0)
                {
                    _GeneralLedger.InsertAccountsDrSales("24", StrPurticulars, TottalTax, 0, SalesAccount);
                }
            }




            if (Vtype == "SI" || Vtype == "SV")
            {
                /*Advance Paid*/
                _GeneralLedger.Uid = ClsUserDetails.MUserName;
                _GeneralLedger.VdateDt = dtdate.Value;
                _GeneralLedger.Naration = TxtNaration.textBox1.Text;
                //_GeneralLedger.Naration2 = txtwarrantyy.Text.ToString();
                _GeneralLedger.RefnoStr = SalesAccount;

                 if (AdvancePay > 0)
                {
                    _GeneralLedger.VTypeStr = "R";
                    _GeneralLedger.IdGeneralLedger(" where vtype='R'");
                    _GeneralLedger.SlNoLng = Convert.ToInt64(txtvno.Text);
                    _GeneralLedger.LedCodeStr = "1";
                    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading + " =>" + _Dbtask.znllString(txtvno.Text);
                    _GeneralLedger.DbAmtDb = AdvancePay;
                    _GeneralLedger.CrAmt = 0;
                    Insert();
                    _GeneralLedger.LedCodeStr = TxtAccount.Tag.ToString();
                    _GeneralLedger.PurticularsStr = "Advance Received In " + Heading + " =>" + _Dbtask.znllString(txtvno.Text);
                    _GeneralLedger.DbAmtDb = 0;
                    _GeneralLedger.CrAmt = AdvancePay;
                    Insert();
                }
            }



        }
        public void BulkInsertIssueDetailsToAzure(DataTable dt,string table)
        {
            _Dbtask.setconstr();
            using (SqlConnection conn = new SqlConnection(_Dbtask._ConnectionStringServer))
            {
                conn.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    

                    foreach (DataColumn col in dt.Columns)
                    {
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                    }

                    
                    bulkCopy.DestinationTableName =table;
                  


                    bulkCopy.WriteToServer(dt);
                    }
            }
        }
        public int ModeOFpaymentFu()
        {
            return commodeofpayment.SelectedIndex;
        }

        public void Insert()
        {
            _GeneralLedger.InsertGeneralLedger();
         // _GeneralLedger.InsertGeneralLedgerAzureServer();
        }

        //public string GetCreditLedCode()
        //{
        //    //if (commodeofpayment.SelectedValue.ToString() == "1")
        //    //{
        //    //    return _Dbtask.znllString(TxtAccount.Tag);
        //    //}
        //    //return CommonClass._PayMethode.GetSpecificField(commodeofpayment.SelectedValue.ToString(), "CrLed");

        //}
        public void PreIssueTransaction(string Vno, bool Isinenter,string TempVtype,bool Refilling)
                        {
            string PreIssuecode = Vno;    
            string AddQuery;
            string Addquery2;

            if (Refilling == true)
            {
                AddQuery = "";
            }
            else
            {
                AddQuery=" and ledcodeCr='" + SalesAccount + "'";
            }
                string ds= _Dbtask.ExecuteScalarAzureServer("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='" + TempVtype + "' " + AddQuery + "");
                if (ds == "")
            {
                    Ds2 = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='" + TempVtype + "' " + AddQuery + "");
            }
            else
            {
                    Ds2 = _Dbtask.ExecuteQueryAzureServer("select * from TblBusinessIssue where issuecode='" + PreIssuecode + "' and issuetype='" + TempVtype + "' " + AddQuery + "");

            }
            txtPVNO.Text = "";
            if (Ds2.Tables[0].Rows.Count != 0)
            {
                if (Refilling == true)
                {
                    Addquery2 = "";
                }
                else
                {
                    if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                    {
                        txtPVNO.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString(); //+ Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }
                    //else
                    //{
                        txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                    //}


                    EditMode = true;
                    Addquery2 = " and ledcode ='" + SalesAccount + "'";
                }
                    if(gridmain.Rows.Count>0)
                    gridmain.Rows.Clear();

                    if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                    {
                        txtPVNO.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString();// +Ds2.Tables[0].Rows[0]["vno"].ToString();
                    }
                    //else
                    //{
                        txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                    //}
                    PreIssuecode = Ds2.Tables[0].Rows[0]["issuecode"].ToString();
                    txtvno.Tag = PreIssuecode.ToString();

                    _IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                    _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                    _Inventory.Vcode = PreIssuecode.ToString();




                    
                
                dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["issuedate"]);
                    ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                    TxtAccount.Tag = Ds2.Tables[0].Rows[0]["Ledcodedr"];


                    txtponum.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["POnum"]);
                        
                   txtdeliverinot.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Deliverynote"]);
                       
                    txtattention.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Attention"]);
                        
                    txtmrfprno.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["MRFPRnum"]);
                        
                   txtproject.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Projcts"]);
                        











                  if (_Dbtask.znllString(TxtAccount.Tag )!="")
                   {
                       TxtAccount.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(TxtAccount.Tag));
                   }

                  Lblpartybalance.Text = "";

                        //Ds2.Tables[0].Rows[0]["Tename"].ToString();
                    Tnamee = _Dbtask.znllString( Ds2.Tables[0].Rows[0]["Tename"]);
                    Tmob = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tmobile"]);
                    Taddres = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Taddres"]);
                    Tvat = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tvat"]);
                    TxtTcustmr.Text =_Dbtask.znllString( Ds2.Tables[0].Rows[0]["Tename"]);
                    TXTtMOB.textBox1.Text =_Dbtask.znllString( Ds2.Tables[0].Rows[0]["Tmobile"]);
                    txtTaddrss.textBox1.Text =_Dbtask.znllString( Ds2.Tables[0].Rows[0]["Taddres"]);
                    TxtxTvat.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tvat"]);
                    if (MTReadf == "1")
                    {
                        txtmtrread.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Mtrread"]);
                    }
                        
                    if (vehiclesf == "1")
                   {

                     txtvehiname.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["vehiclename"]);
                       txtxvehiclenum.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["vehiclenum"]);
                   }
                    FrmCashDesk.Otherpayamt = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["twopayamt"]);

                    Secndpayactive = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["twopayment"]);
                    if ( FrmCashDesk.Otherpayamt>0)
                     {
                         frmsalesinvoice.twotypepaymnt = true;
                         FrmCashDesk.twotypepaymnt = true;

                         FrmCashDesk.Otherpayamt = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["twopayamt"]);
                         FrmCashDesk.secndpaymode = Secndpayactive;

                     }
                    if ( FrmCashDesk.Otherpayamt<=0)
                    {
                        //frmsalesinvoice.twotypepaymnt = false;
                        //FrmCashDesk.twotypepaymnt = false;
                        frmsalesinvoice.twotypepaymnt = true;
                        FrmCashDesk.twotypepaymnt = true;
                        FrmCashDesk.Otherpayamt = _Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["twopayamt"]);
                        FrmCashDesk.secndpaymode = Secndpayactive;

                    }
                  
                    if (Salesarea == true)
                    {
                        if (_Dbtask.znllString(Ds2.Tables[0].Rows[0]["Ledcodedr"]) != "1" && _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Ledcodedr"]) != "28")
                            comsalesarea.SelectedValue = CommonClass._Ledger.GetspecifField("Area", Ds2.Tables[0].Rows[0]["Ledcodedr"].ToString());
                    }

                    CashReceivedTxt = Ds2.Tables[0].Rows[0]["CashReceived"].ToString();
                    SalesReturnText = Ds2.Tables[0].Rows[0]["SR"].ToString();
                    roundof = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select DbAmt from tblgeneralledger where ledcode='12' and vno='" + txtvno.Text + "' and vtype='" + Vtype + "'"));
                       txtRoundOff.Text =_Dbtask.znllString( _Dbtask.ExecuteScalar("select DbAmt from tblgeneralledger where ledcode='12' and vno='" + txtvno.Text + "' and vtype='" + Vtype + "'"));
                   
                string MoPayment=_Dbtask.znllString(  Ds2.Tables[0].Rows[0]["Mpayment"]);

                    if (Spartyproject == true)
                    {
                        PProject =Convert.ToInt64(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["pproject"]));

                        CommonClass._Partyproject.FillComboPartyproject(false,TxtAccount.Tag.ToString(), comcustomerproject);

                        comcustomerproject.SelectedValue = PProject;
                    }

                    if (MoPayment == "")
                    {
                        if (TxtAccount.Tag.ToString() == "1")
                        {
                            commodeofpayment.SelectedIndex = 0;
                        }
                        else
                        {
                            commodeofpayment.SelectedIndex = 1;
                        }
                    }
                    else
                    {
                        commodeofpayment.SelectedIndex = Convert.ToInt16(Ds2.Tables[0].Rows[0]["mpayment"].ToString());
                    }


                    string temptax = Ds2.Tables[0].Rows[0]["taxid"].ToString();
                    temptax = temptax.Replace(" ", "");
                  
                    Comemployee.SelectedValue =Convert.ToInt64(Ds2.Tables[0].Rows[0]["empid"]);
                    ComAgent.SelectedValue = Ds2.Tables[0].Rows[0]["agent"];
                    TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + ComAgent.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                    if (TxtAgentAmt.Text == "")
                        TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);

                        Comemployee.SelectedValue =_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["Empid"]);
                    Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select dbamt from tblgeneralledger where ledcode='" + Comemployee.SelectedValue + "' and vno ='" + PreIssuecode + "'");
                    if (Txtemployeeamt.Text == "")
                        Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);

                    TxtNaration.textBox1.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
                //txtwarrantyy.Text = _Dbtask.ExecuteScalar("select warranty from tblbusinessissue where issuecode='"+txtvno.Text.ToString()+"' and issuetype='"+Vtype+"' and warranty!='0'");
                    txtotherexpenses.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["cooly"].ToString()));
                    Txttypecooly.textBox1.Text = txtotherexpenses.Text;
                    txttinvoicediscount.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["Discamt"].ToString()));
                    Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["Discamt"].ToString()));
                    txtpaid.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["adamount"].ToString()));

                    txtmobilee.textBox1.Text = _AccountLedger.GetSpecificfieldBaseonName(TxtAccount.Text, "mobile").ToString();

                    Lbltemporarydetails.Tag = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["LBLaccnt"]);
                    txttempNames.Text = "";
                if (_Dbtask.znllString(Lbltemporarydetails.Tag)!="")
                   {
                txttempNames.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(Lbltemporarydetails.Tag));
                   } 
                NextGFuntion.SalesReturnVno = Ds2.Tables[0].Rows[0]["sr"].ToString();
                    
                    if(NextGFuntion.SalesReturnVno!="")
                    {
                        DSSalesreturnRetrive = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" +   NextGFuntion.SalesReturnVno + "'and vtype='SR' and ledcode ='" + SalesAccount + "'order by slno asc");
                    }



                    if (_Dbtask.znllString(Ds2.Tables[0].Rows[0]["due"]) == "")
                    {
                        dtdue.Value = DateTime.Now; ;
                    }
                    else
                    {
                        dtdue.Value = _Dbtask.ZnullDatetime(Ds2.Tables[0].Rows[0]["due"]);
                    }




                //    string dsissue = _Dbtask.ExecuteScalarAzureServer("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + TempVtype + "' and ledcode ='" + SalesAccount + "'order by slno asc");
                //if (dsissue != "")
                //{
                    Ds = _Dbtask.ExecuteQueryAzureServer("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + TempVtype + "' and ledcode ='" + SalesAccount + "'order by slno asc");

                //}
                //else
                //{


                //    Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + PreIssuecode + "'and vtype='" + TempVtype + "' and ledcode ='" + SalesAccount + "'order by slno asc");
                //}
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        gridmain.Rows.Add(1);
                         string tempSlno = (i + 1).ToString();
                        string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                            double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                        double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                        double tempsRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                        double tempCRate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Crate"]);
                        double tempMrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["Mrp"].ToString());
                        double tempdiscrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                        double temptaxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Taxrate"].ToString());

                        double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
                        double temptaxperc = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxper"].ToString());

                        double templength = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["lth"]);
                        double tempwidth = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["wth"]);

                        string tempBatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                        string Slnotracking = Ds.Tables[0].Rows[i]["slnotracking"].ToString();
                        string tempItemnote2 = _Dbtask.znllString(Ds.Tables[0].Rows[i]["itemnote2"]);
                      //  GetExpiryDateonBatch(tempBatchid, tempitemid);
                        string tempexpiry = _Dbtask.ZnullDatetime(Ds.Tables[0].Rows[i]["Exdate"]).ToString("dd-MM-yyyy");
                        
                        Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();

                      if(clnserialno.Visible==true)
                        if (CommonClass._Slno.ShowSlno(" where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and itemid='" + tempitemid + "'").Tables[0].Rows.Count > 0)
                        {
                            gridmain.Rows[i].Cells["clnserialno"].Value = CommonClass._SelectReport.Showindataset(" select slno from tblslnotracking where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and itemid='" + tempitemid + "'");
                        }
                       
                        gridmain.Rows[i].Cells["clnbatch"].Value = tempBatchid;
                        gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
                            gridmain.Rows[i].Cells["clnserialno"].Value = Slnotracking;
                    if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnBaseU"].Tag) == "")
                    {
                        gridmain.Rows[i].Cells["clnBaseU"].Tag = "1";
                    }
                    //if (dsissue != "")
                    //{
                        gridmain.Rows[i].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalar("select name from tblbaseunit where id ='" + gridmain.Rows[i].Cells["clnBaseU"].Tag.ToString() + "'").ToString();

                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnlang"].Value = _Dbtask.ExecuteScalar("select llang from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemNAME from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnBaseU"].Tag = _Batch.GetSpecificFieldofBatch(tempBatchid, "baseU");

                    //}
                    //else
                    //{
                    //    gridmain.Rows[i].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalar("select name from tblbaseunit where id ='" + gridmain.Rows[i].Cells["clnBaseU"].Tag.ToString() + "'").ToString();

                    //    gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                    //    gridmain.Rows[i].Cells["clnlang"].Value = _Dbtask.ExecuteScalar("select llang from tblitemmaster where itemid='" + tempitemid + "'");
                    //    gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemNAME from tblitemmaster where itemid='" + tempitemid + "'");
                    //    gridmain.Rows[i].Cells["clnBaseU"].Tag = _Batch.GetSpecificFieldofBatch(tempBatchid, "baseU");

                    //}
                    gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                        gridmain.Rows[i].Cells["clnitemnote"].Value = tempItemnote2;
                         gridmain.Rows[i].Cells["clnexpiry"].Value = tempexpiry;
                        NQty = tempQty;
                        gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);

                        Nlength = templength;
                        gridmain.Rows[i].Cells["clnlength"].Value = _Dbtask.SetintoDecimalpoint(templength);

                        Nwidth = tempwidth;
                        gridmain.Rows[i].Cells["clnwidth"].Value = _Dbtask.SetintoDecimalpoint(tempwidth);

                        NFree = tempfree;
                        gridmain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);

                        NRate = tempsRate;
                      
                        gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsRate);
                        gridmain.Rows[i].Cells["clncost"].Value = _Dbtask.SetintoDecimalpoint(tempCRate);

                    //if (dsissue != "")
                    //{
                        gridmain.Rows[i].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");
                    //}
                    //else
                    //{
                    //    gridmain.Rows[i].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempitemid + "'");

                    //}
                    NMrp = tempMrp;
                        gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempMrp);

                        NDiscamt = tempdiscrate;
                        gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(tempdiscrate);

                        NTaxamount = temptaxrate;
                        gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);

                        NTaxperc = temptaxperc;
                        gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);



                        Templedouble = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value) * Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        gridmain.Rows[i].Cells["clndiscper"].Value = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value) * 100 / Templedouble;
                        NDiscper = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscper"].Value);
                        rowindex = i;
                        if (SUnit == true)
                        {
                            Unitid = Ds.Tables[0].Rows[i]["unitid"].ToString();
                            string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                            gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                            gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                            ItemId = tempitemid;
                            UnitName = Unit;
                            
                            ComText = true;
                        }



                        if (Smrate == true)
                        {
                            comratetype.SelectedValue = Convert.ToInt32(Ds.Tables[0].Rows[i]["MultiRateId"]);
                        }

                        CellEnterCalculationPart();
                        //RowValidation();
                    }
                    TottalAmountCalculate(true);
                    Isinotherwindow = false;

                    Retrivemode = 0;

                    if (temptax == "0")
                    {
                        ComTax.SelectedIndex = 0;
                    }
                    if (temptax == "9")
                    {
                        ComTax.SelectedIndex = 1;
                    }
                    if (temptax == "24")
                    {
                        ComTax.SelectedIndex = 2;
                    }
                    ComTextChange();

   }
                else
                {


                    if (Isinenter == false)
                        {

                        Clear();
                        if (Vtype == "SI" || Vtype == "SO" || Vtype == "SQ" && SalesAccount == "2")
                        {
                            if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("issuecode", "TblBusinessIssue", " where ledcodecr='2' And issuetype='" + Vtype + "'")))
                            {
                                string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                                txtvno.Text = prefx + PreIssuecode.ToString();
                                txtvno.Tag = PreIssuecode.ToString();
                                _IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                if (Vtype == "SI")
                                {
                                    _Inventory.Vcode = Convert.ToInt64(PreIssuecode).ToString();
                                }

                                EditMode = true;


                            }
                           

                        }
                        else
                        {
                            if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("issuecode", "TblBusinessIssue", " where ledcodecr!='2'")))
                            {
                                string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                                txtvno.Text = prefx + PreIssuecode.ToString();
                                txtvno.Tag = PreIssuecode.ToString();
                                _IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);

                                EditMode = true;
                            
                            }

                           

                        }



                    }

                    
                }
            
        }
        public void PreReceiptTransaction(string vno, bool Isinenter, string TempVtype, bool Refilling)
                        {
            string PreIssuecode = vno;
            if (Refilling == false)
            {
                string ds = _Dbtask.ExecuteScalarAzureServer("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' and ledcodeDr='" + SalesAccount + "'");
                if (ds != "")
                {
                    Ds2 = _Dbtask.ExecuteQueryAzureServer("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' and ledcodeDr='" + SalesAccount + "'");

                }
                else
                {

                    Ds2 = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' and ledcodeDr='" + SalesAccount + "'");
                }
            }
            else
            {


               string ds = _Dbtask.ExecuteScalarAzureServer("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' ");
                if (ds == "0")
                {
                    Ds2 = _Dbtask.ExecuteQueryAzureServer("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' ");

                }
                else
                {
                    Ds2 = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where ReptCode='" + PreIssuecode + "' and RecptType='" + TempVtype + "' ");
                }
             }
                        if (Ds2.Tables[0].Rows.Count != 0)
                        {
                            if(gridmain.Rows.Count>0)
                            gridmain.Rows.Clear();

                            EditMode = true;
                            Retrivemode = 1;
                            txtPVNO.Text = "";
                            if (Ds2.Tables[0].Rows[0]["pvno"].ToString() != "")
                            {
                               txtPVNO.Text = Ds2.Tables[0].Rows[0]["pvno"].ToString();// + Ds2.Tables[0].Rows[0]["vno"].ToString();
                            }
                            
                            //else
                            //{
                                txtvno.Text = Ds2.Tables[0].Rows[0]["vno"].ToString();
                            //}
                            txtvno.Tag = PreIssuecode.ToString();

                            _ReceiptDetails.RcptCodeLng = Convert.ToInt64(PreIssuecode);
                            _TransactionReceipt.RcptCodeLng = Convert.ToInt64(PreIssuecode);
                            _Inventory.Vcode = PreIssuecode.ToString();

                            dtdate.Value = Convert.ToDateTime(Ds2.Tables[0].Rows[0]["recptdate"]);
                            ComDepot.SelectedValue = Ds2.Tables[0].Rows[0]["Dcode"];
                            TxtAccount.Tag = Ds2.Tables[0].Rows[0]["Ledcodecr"];
                            TxtAccount.Text = Ds2.Tables[0].Rows[0]["Tename"].ToString();
                            Tnamee = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tename"]);
                            Tmob = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tmobile"]);
                            Tvat = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Taddres"]);
                            Taddres = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tvat"]);
                            TxtTcustmr.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tename"]);
                            TXTtMOB.textBox1.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tmobile"]);
                            txtTaddrss.textBox1.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Taddres"]);
                            TxtxTvat.Text = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["Tvat"]);

                            if (Spartyproject == true)
                            {
                                PProject = Convert.ToInt64(_Dbtask.znlldoubletoobject(Ds2.Tables[0].Rows[0]["pproject"]));

                                CommonClass._Partyproject.FillComboPartyproject(false, TxtAccount.Tag.ToString(), comcustomerproject);

                                comcustomerproject.SelectedValue = PProject;
                            }

                            string temptax = Ds2.Tables[0].Rows[0]["taxid"].ToString();

                            txtRoundOff.Text = _Dbtask.ExecuteScalar("select CrAmt from tblgeneralledger where ledcode='12' and vno='" + PreIssuecode + "' and vtype='" + Vtype + "'");

                            string MoPayment = Ds2.Tables[0].Rows[0]["Mpayment"].ToString();

                            if (MoPayment == "")
                            {
                                if (TxtAccount.Tag.ToString() == "1")
                                {
                                    commodeofpayment.SelectedIndex = 0;
                                }
                                else
                                {
                                    commodeofpayment.SelectedIndex = 1;
                                }
                            }
                            else
                            {
                                commodeofpayment.SelectedIndex = Convert.ToInt16(Ds2.Tables[0].Rows[0]["mpayment"].ToString());
                            }

                            ComTax.SelectedValue = Ds2.Tables[0].Rows[0]["taxid"];

                            txtmobilee.textBox1.Text = _AccountLedger.GetspecifField("mobile", TxtAccount.Tag.ToString()).ToString();

                            Lbltemporarydetails.Tag = _Dbtask.znllString(Ds2.Tables[0].Rows[0]["LBLaccnt"]);



                            TxtNaration.textBox1.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
                            txtwarrantyy.Text = _Dbtask.ExecuteScalar("select naration2 from tblgeneralledger where vtype='" + Vtype + "' and vno ='" + txtvno.Tag.ToString() + "'");

                            ComAgent.SelectedValue = Ds2.Tables[0].Rows[0]["agent"];
                            TxtAgentAmt.Text = _Dbtask.ExecuteScalar("select cramt from tblgeneralledger where ledcode='" + ComAgent.SelectedValue + "' and vno ='" + PreIssuecode + "' and vtype='"+TempVtype+"'");
                            if (TxtAgentAmt.Text == "")
                                TxtAgentAmt.Text = _Dbtask.SetintoDecimalpoint(0);

                            Comemployee.SelectedValue = Ds2.Tables[0].Rows[0]["Empid"];
                            Txtemployeeamt.Text = _Dbtask.ExecuteScalar("select cramt from tblgeneralledger where ledcode='" + Comemployee.SelectedValue + "' and vno ='" + PreIssuecode + "' and vtype='" + TempVtype + "'");
                            if (Txtemployeeamt.Text == "")
                                Txtemployeeamt.Text = _Dbtask.SetintoDecimalpoint(0);

                            TxtNaration.textBox1.Text = Ds2.Tables[0].Rows[0]["Remarks"].ToString();
                            Txttypecooly.textBox1.Text = Ds2.Tables[0].Rows[0]["cooly"].ToString();
                            Txttypebilldiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(Ds2.Tables[0].Rows[0]["Discamt"].ToString()));


                string dsrecpt = _Dbtask.ExecuteScalarAzureServer("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='" + TempVtype + "' order by slno asc");

                if (dsrecpt != "")
                {
                    Ds = _Dbtask.ExecuteQueryAzureServer("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='" + TempVtype + "' order by slno asc");

                }
                else
                {
                    Ds = _Dbtask.ExecuteQuery("select * from TblReceiptDetails where RecptCode='" + PreIssuecode + "'and vtype='" + TempVtype + "' order by slno asc");
                }



                            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                                {
                                gridmain.Rows.Add(1);

                                    string tempSlno = (i + 1).ToString();
                                string tempitemid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                                double tempQty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                                double tempfree = Convert.ToDouble(Ds.Tables[0].Rows[i]["freeqty"].ToString());
                                double temppRate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Rate"].ToString());
                                double tempdiscrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscRate"].ToString());
                                double temptaxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["Taxrate"].ToString());
                                double tempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["NetAMT"].ToString());
                                double temptaxperc = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxper"].ToString());
                                double tempexciseduty = Convert.ToDouble(Ds.Tables[0].Rows[i]["exciseduty"].ToString());
                                if (SBatch == true)
                                {
                                    if (dsrecpt != "")
                                    {
                                        string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                                        string tempbatchidTag = _Dbtask.ExecuteScalarAzureServer("select bid from tblbatch where Bcode='" + tempbatchid + "'");
                                        gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;
                                        gridmain.Rows[i].Cells["clnbatch"].Tag = tempbatchidTag;
                                        gridmain.Rows[i].Cells["clnBaseU"].Tag = _Batch.GetSpecificFieldofBatchAzure(tempbatchid, "baseU");
                                        if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnBaseU"].Tag) == "")
                                        {
                                            gridmain.Rows[i].Cells["clnBaseU"].Tag = "1";
                                        }

                                        gridmain.Rows[i].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalarAzureServer("select name from tblbaseunit where id ='" + gridmain.Rows[i].Cells["clnBaseU"].Tag.ToString() + "'").ToString();

                                    }
                                    else
                                    {
                                        string tempbatchid = Ds.Tables[0].Rows[i]["batchid"].ToString();
                                        string tempbatchidTag = _Dbtask.ExecuteScalar("select bid from tblbatch where Bcode='" + tempbatchid + "'");
                                        gridmain.Rows[i].Cells["clnbatch"].Value = tempbatchid;
                                        gridmain.Rows[i].Cells["clnbatch"].Tag = tempbatchidTag;
                                        gridmain.Rows[i].Cells["clnBaseU"].Tag = _Batch.GetSpecificFieldofBatch(tempbatchid, "baseU");
                                        if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnBaseU"].Tag) == "")
                                        {
                                            gridmain.Rows[i].Cells["clnBaseU"].Tag = "1";
                                        }

                                        gridmain.Rows[i].Cells["clnBaseU"].Value = _Dbtask.ExecuteScalar("select name from tblbaseunit where id ='" + gridmain.Rows[i].Cells["clnBaseU"].Tag.ToString() + "'").ToString();

                                    }

                                }
                                double tempsrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["srate"].ToString());
                                double tempcrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["crate"].ToString());
                                double tempmrp = Convert.ToDouble(Ds.Tables[0].Rows[i]["mrp"].ToString());
                                Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();

                                gridmain.Rows[i].Cells["clnslno"].Value = tempSlno;
                                if (SBatch == true)
                                {

                                }
                    if (dsrecpt != "")
                    {
                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalarAzureServer("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnlang"].Value = _Dbtask.ExecuteScalarAzureServer("select llang from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalarAzureServer("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                    }
                    else
                    {
                        gridmain.Rows[i].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnlang"].Value = _Dbtask.ExecuteScalar("select llang from tblitemmaster where itemid='" + tempitemid + "'");
                        gridmain.Rows[i].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + tempitemid + "'");

                    }
                    gridmain.Rows[i].Cells["clnitemname"].Tag = tempitemid;
                                NQty = tempQty;
                                gridmain.Rows[i].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(tempQty);
                                NFree = tempfree;
                                gridmain.Rows[i].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpointStock(tempfree);
                                NRate = tempsrate;
                                gridmain.Rows[i].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(tempsrate);
                                NMrp = tempmrp;
                                gridmain.Rows[i].Cells["clnmrp"].Value = _Dbtask.SetintoDecimalpoint(tempmrp);
                    if (dsrecpt != "")
                    {
                        gridmain.Rows[i].Cells["clnmrp"].Tag = _Dbtask.ExecuteScalarAzureServer("select incp from tblitemmaster where itemid='" + tempitemid + "'");

                    }
                    else
                    {
                        gridmain.Rows[i].Cells["clnmrp"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempitemid + "'");


                    }

                    NetDiscou = tempdiscrate;
                                gridmain.Rows[i].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpointStock(tempdiscrate);

                                NTaxamount = temptaxrate;
                                gridmain.Rows[i].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(temptaxrate);
                                
                                NTaxperc = temptaxperc;
                                gridmain.Rows[i].Cells["ClntaxPer"].Value = _Dbtask.SetintoDecimalpoint(temptaxperc);

                                Templedouble = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value) * Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                                gridmain.Rows[i].Cells["clndiscper"].Value = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value) * 100 / Templedouble;
                                NDiscper = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscper"].Value);
                               

                                rowindex = i;
                                

                                if (SUnit == true)
                                {
                                    Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + txtvno.Text + "'and Pcode='" + Pcode + "'and vtype='" + Vtype + "'");
                                    string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                                    gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                                    gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                                    ItemId = tempitemid;
                                    UnitName = Unit;
                                    UnitAmountCalc();
                                    ComText = true;

                                    

                                }
                               
                                CellEnterCalculationPart();
                                ComTextChange();

                            }

                                                    TottalAmountCalculate(true);
                            Isinotherwindow = false;

                            Retrivemode = 0;

                            if (temptax == "0")
                            {
                                ComTax.SelectedIndex = 0;
                            }
                          
                            if (temptax == "24")
                            {
                                ComTax.SelectedIndex = 2;
                            }
                            ComTextChange();
                        }
                        else
                        {


                            Clear();
                            if (Vtype == "SR" && SalesAccount == "2")
                            {
                                if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "Tbltransactionreceipt", " where ledcodedr='2' ")))
                                {
                                    string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                                    txtvno.Text = prefx + PreIssuecode.ToString();
                                    txtvno.Tag = PreIssuecode.ToString();
                                    _ReceiptDetails.RcptCodeLng = Convert.ToInt64(PreIssuecode);
                                    _TransactionReceipt.RcptCodeLng = Convert.ToInt64(PreIssuecode);
                                    _Inventory.Vcode = Convert.ToInt64(PreIssuecode).ToString();
                                    EditMode = true;
                                    //_IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                    //_BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                }
                            }
                            else
                            {
                                if (Convert.ToInt64(PreIssuecode) < Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "Tbltransactionreceipt", " where ledcodedr!='2'")))
                                {
                                    string prefx = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='sprefix'").ToString();
                                    txtvno.Text = prefx + PreIssuecode.ToString();
                                    txtvno.Tag = PreIssuecode.ToString();
                                    _IssueDetails.IssueCodeLng = Convert.ToInt64(PreIssuecode);
                                    _BusinessIssue.IssueCodeLng = Convert.ToInt64(PreIssuecode);

                                    EditMode = true;
                                }
                            }

                           
                            //GetPrevious((Convert.ToInt64(PreIssuecode) - 1).ToString(), false);
                        }
                        Retrivemode = 0;
        }
        public void GetPrevious(string Vno, bool Isinenter)
                        {
            try
            {

                MINVALSET();

                if (Convert.ToInt64(Vno) > 0 && Convert.ToInt64(Vno) >= Convert.ToInt64(minivalbillnum))
                {
                    string PreIssuecode = Vno;
                    SetGridColumn();
                    Retrivemode = 1;
                    FillCombo();

                    if (Vtype == "SI" || Vtype == "DN" || Vtype == "SO" || Vtype == "CRM"||Vtype=="SQ"||Vtype=="SV")
                    {
                        PreIssueTransaction(PreIssuecode,Isinenter,Vtype,false);
                                            Tempretreive(_Dbtask.znllString(txtvno.Text));
                    
                    }
                    if (Vtype == "SR")
                            {
                        PreReceiptTransaction(Vno, Isinenter, Vtype, false);
                            Tempretreive(_Dbtask.znllString(txtvno.Text));
                    
                    }
                    OldData = "VchNo:" + txtvno.Text + ",Party :" + TxtAccount.Text + ",Date:" + dtdate.Value.ToString("dd/MM/yyyy") + "Bill Amt :" + txtbillamount.Text;
                    Controlebehaviour(true);
                }
                        PNLCOSTINVCE.Visible = false;
            }
            catch
            {
                Clear();
            }
        }
        private void TxtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        public void ProductGridShowWithBatch(string WhereCondition)
        {
            int leftval = 0;

            if (ColumnName == "clnbatch")
            {
                leftval = 5; 
            }
            if (ColumnName == "clnitemcode")
            {

                leftval = 100; 
            }

            try
            {
               _Ingrid.BatchGridShow(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, StockareaId,false,false,comitemcategory.SelectedValue.ToString());
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left+200, tempRect.Top - tempRect.Height+6 * 3);
                else
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left + leftval, tempRect.Top + tempRect.Height + 40 * 3);

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
            try
            {
                _Ingrid.ProductGridShowFixed(uscGridshow2, WhereCondition, uscGridshow2.GridProductShow, StockareaId);
                Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);

                if (tempRect.Top > 400)
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top - tempRect.Height+6*3 );
                else
                    _Ingrid.ProductGridShowLocationSett(uscGridshow2, tempRect.Left, tempRect.Top + tempRect.Height + 40*3 );

                if (uscGridshow2.Visible == false)
                {
                    uscGridshow2.Visible = true;
                }
            }
            catch
            {
            }
        }
        public void ProductGridShowLocationSett(UserControl UserControleName, int Left, int Top)
        {
            UserControleName.Left = Left;

            UserControleName.Top = Top + 10;
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
            IsEnter = false;
        }

        private void TxtRefNo_KeyPress(object sender, KeyPressEventArgs e)
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
       
        private void TxtAmt_TextChanged(object sender, EventArgs e)
        {

            gridmain.Rows[rowindex].Cells[columnindex].Value = TxtAmt.Text;

            CellEnterCalculationPart();
            TottalAmountCalculate(true);
            RowValidation();
        }

        private void Txtqty_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Txtqty.Visible = false;
                Txtqty.Text = "";
            }
        }

        private void TxtAmt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TxtAmt.Visible = false;
                TxtAmt.Text = "";
            }
        }

        private void ComStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComTax.Focus();
            }
        }

        public void DeleteVoucherAzure()
        {

            if (Vtype == "SI" || Vtype == "DN" || Vtype == "SO" || Vtype == "SQ" || Vtype == "SV")
            {
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblissuedetails where issuecode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblbusinessissue where  issuecode='" + txtvno.Tag + "' and issuetype='" + Vtype + "' and Ledcodecr='" + SalesAccount + "'");
              //  _Dbtask.ExecuteNonQuery("delete from tblbillsett where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");
                

                if (Vtype == "SI" || Vtype == "DN" || Vtype == "SV")
                {
                    if (Vtype == "SI")
                        tempinvvty = "Sales";
                    else
                        tempinvvty = "dn";

                    _Dbtask.ExecuteNonQueryAzureServer("delete from tblinventory where vcode='" + txtvno.Tag + "' and " + tempinvvty + " !=0 and ledcode='" + SalesAccount + "'");
                    _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Refno='" + SalesAccount + "'");
                    /*For Agent*/
                    string Sql;
                    Sql = "delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode in(" + agentid + "," + staffid + " ,26,7,9,24) and Refno='" + SalesAccount + "'";
                    _Dbtask.ExecuteNonQueryAzureServer(Sql);

                    /*For Advance Paid*/
                    if (Vtype == "SI" || Vtype == "SV")
                    {
                        // _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='R' and Refno='" + SalesAccount + "' and purticulars='Advance Received In "+Heading+"' and slno='" + txtvno.Tag + "'");

                        /*Bill for Advance*/
                        if (_GeneralLedger.CountLedgerTRansactionAzure("where vtype='R' and slno='" + txtvno.Tag + "'") == true || _GeneralLedger.CountLedgerTRansaction("where vtype='R' and slno='" + txtvno.Tag + "' and refno='" + SalesAccount + "'  ") == true)
                        {
                            _Dbtask.ExecuteNonQueryAzureServer("delete FROM TBLGENERALLEDGER where vtype='R' and slno=" + txtvno.Text + " " +
                            " and refno='" + SalesAccount + "' ");

                            txtpaid.textBox1.Text = "";


                        }


                    }


                }
            }
            if (Vtype == "SR")
            {
                tempinvvty = "Sr";

                _Dbtask.ExecuteNonQueryAzureServer("delete from tblinventory where vcode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and " + Vtype + " !=0");
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblreceiptdetails where RecptCode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and refno='" + SalesAccount.ToString() + "'");
                _Dbtask.ExecuteNonQueryAzureServer("delete from tbltransactionreceipt where Reptcode='" + txtvno.Tag + "' and vno='" + txtvno.Text + "' and Recpttype='" + Vtype + "' and LedcodeDr='" + SalesAccount + "' ");

               
                /*For Batch */
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblbatch where Ledcode='" + SalesAccount + "' and recptcode='" + txtvno.Tag + "'");
                /*For Agent*/
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + agentid + "' and Refno='" + SalesAccount + "'");
                /*For Employee*/
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + staffid + "' and Refno='" + SalesAccount + "'");

                /*For Discount*/
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='6' and Refno='" + SalesAccount + "'");
                /*For VAT*/
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='8' and Refno='" + SalesAccount + "'");
                /*For CST*/
                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='25' and Refno='" + SalesAccount + "'");

                _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='10' and Refno='" + SalesAccount + "'");

               


            }

        }



        public void DeleteVoucher()
                {

            if (Vtype == "SI" || Vtype == "DN" || Vtype == "SO" || Vtype == "SQ"||Vtype=="SV")
            {
                _Dbtask.ExecuteNonQuery("delete from tblissuedetails where issuecode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where  issuecode='" + txtvno.Tag + "' and issuetype='" + Vtype + "' and Ledcodecr='" + SalesAccount + "'");
                _Dbtask.ExecuteNonQuery("delete from tblbillsett where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");
               if(SSlnotracking==true)
                _Dbtask.ExecuteNonQuery("delete from tblslnotracking where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");


                if (Vtype == "SI" || Vtype == "DN"||Vtype=="SV")
                {
                    if (Vtype == "SI")
                        tempinvvty = "Sales";
                    else
                        tempinvvty = "dn";

                    _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Tag + "' and " + tempinvvty + " !=0 and ledcode='" + SalesAccount + "'");
                    _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Refno='" + SalesAccount + "'");
                    /*For Agent*/
                    string Sql;
                    Sql="delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode in(" + agentid + ","+staffid+" ,26,7,9,24) and Refno='" + SalesAccount + "'";
                    _Dbtask.ExecuteNonQuery(Sql);
               
                    /*For Advance Paid*/
                    if (Vtype == "SI"||Vtype=="SV")
                    {
                       // _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='R' and Refno='" + SalesAccount + "' and purticulars='Advance Received In "+Heading+"' and slno='" + txtvno.Tag + "'");

                        /*Bill for Advance*/
                        if (_GeneralLedger.CountLedgerTRansaction("where vtype='R' and slno='" + txtvno.Tag + "'") == true || _GeneralLedger.CountLedgerTRansaction("where vtype='R' and slno='" + txtvno.Tag + "' and refno='" + SalesAccount + "'  ") == true)
                        {
                        _Dbtask.ExecuteNonQuery("delete FROM TBLGENERALLEDGER where vtype='R' and slno=" + txtvno.Text + " " +
                        " and refno='" + SalesAccount + "' ");

                        txtpaid.textBox1.Text = "";


                        }


                        }


                }
            }
            if (Vtype == "SR")
            {
                tempinvvty = "Sr";

                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and " + Vtype + " !=0");
                _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where RecptCode='" + txtvno.Tag + "' and Ledcode='" + SalesAccount + "' and vtype='" + Vtype + "'");
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and refno='" + SalesAccount.ToString() + "'");
                _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where Reptcode='" + txtvno.Tag + "' and vno='" + txtvno.Text + "' and Recpttype='" + Vtype + "' and LedcodeDr='" + SalesAccount + "' ");
                
                if (SSlnotracking == true)
                _Dbtask.ExecuteNonQuery("delete from tblslnotracking where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");

                /*For Batch */
                _Dbtask.ExecuteNonQuery("delete from tblbatch where Ledcode='" + SalesAccount + "' and recptcode='" + txtvno.Tag + "'");
                /*For Agent*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + agentid + "' and Refno='" + SalesAccount + "'");
                /*For Employee*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='" + staffid + "' and Refno='" + SalesAccount + "'");

                /*For Discount*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='6' and Refno='" + SalesAccount + "'");
                /*For VAT*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='8' and Refno='" + SalesAccount + "'");
                /*For CST*/
                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='25' and Refno='" + SalesAccount + "'");

                _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + txtvno.Text + "' and Ledcode='10' and Refno='" + SalesAccount + "'");

                _Dbtask.ExecuteNonQuery("delete from tblSRbillsett where  vno='" + txtvno.Text + "' and vtype='" + Vtype + "' ");
            
            
            
            }

        }
        private void PnlSalesHistory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                PnlSalesHistory.Visible = false;
                gridmain.Focus();
                gridmain.Select();
            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            
           Clear();

           dtdue.Value = DateTime.Now; ;
        }

        public void vouchertypewholesalesother2()
        {
            try
            {
                if (IfPrintPreview == true)
                {
                    printPreviewDialog1.Document = printDocument1;
                    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    PrinterSettings();
                    pd.Print();
                }
            }
            catch
            {
            }
        }

        public void Termalprint()
        {
            string StrVno = txtvno.Text;
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                               " + Datestr;
            string LineHeading = "=".PadRight(30, '=');
            string LineAbowAmount = "-".PadRight(30, '-');
            string LineFooter = "=".PadRight(30, '=');
            string Slno = "Slno".PadRight(2, ' ');
            string Pname = "Product Name".PadRight(10, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(5, ' ');
            string TsAmount = "Amount".PadLeft(5, ' ');
            string TAmountstr = "Amount".PadLeft(5, ' ');
            string TTQty;
            string TTAmount;
            RichTextBox1.Text = "No :" + StrVno + "" + PInvoiceName + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(2, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(5, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(5, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(5, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = TQty.ToString();
            TTQty = TTQty.PadLeft(10, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(27, ' ');

            AmountInWords _word = new AmountInWords();

            string AmountinWords = _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "Authorized Signatory".PadLeft(30, ' ');
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
            if (commodeofpayment.SelectedIndex == 1)
            {
                double tempyourbalance = Convert.ToDouble(YourBalance);
                tempyourbalance = tempyourbalance + BillAmount;

                YourBalance = tempyourbalance.ToString();
            }
           
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter + "\n                                                     Bill Discount :" + BiilDiscount.PadLeft(12, ' ') + "\n                                                     Total         :" + txtbillamount.Text.PadLeft(12, ' ') + "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + Lblpartybalance.Text.PadLeft(12, ' ') + "\n                                                     Current Balance:" + YourBalance.PadLeft(11, ' ') + "\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());

                MyPrinter.Print(RichTextBox1.Text);
                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }

        }

        public void vouchertyperetailDotmetrix6Temp(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = " " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(25, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                   " + Datestr;
            string LineHeading = "=".PadRight(50, '=');
            string LineAbowAmount = "-".PadRight(50, '-');
            string LineFooter = "=".PadRight(50, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(8, ' ');
            string TsRate = "Rate".PadLeft(10, ' ');
            string TsAmount = "Amount".PadLeft(12, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;


            if (PInvoiceName == "                           Sales Invoice")
            {
                RichTextBox1.Text = "" + CompanyName + "\n\n" + Address + "\n" + Mobile + "\nNo :" + StrVno + "" + PInvoiceName + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = PInvoiceName + "\n" + "No :" + StrVno + "\n\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        TRowCounting = TRowCounting + 1;
                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(15, ' ');
                        if (Pname.Length > 15)
                            Pname = Pname.Substring(0, 15);
                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(10, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(10, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            SettintogapDotmetrix(RichTextBox1, " ", TRowCounting, 20);

            TTQty = _Dbtask.SetintoDecimalpointStock(TQty);
            TTQty = "Total                   " + TTQty;

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(30 - TTAmount.Length, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "                              Authorized Signatory";
            currentbalance = 0;
            OldBalance = 0;
            if (AmountinWords.Length > 40)
            {
                AmountinWords = AmountinWords.Substring(0, 40) + "\n" + AmountinWords.Substring(40, AmountinWords.Length - 40);
            }

            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = TBillAmount;

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
                    double BillAmt = TBillAmount;
                    currentbalance = OldBalance;
                }
            }
            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter + "\n                        Bill Discount :" + BiilDiscount.PadLeft(12, ' ') + "\n                        Total         :" + txtbillamount.Text.PadLeft(12, ' ') + "\n\nIn Words: " + AmountinWords + "\n                        Old Balance   :" + tempoldbalance.PadLeft(12, ' ') + "\n                        Current Balance:" + tempcurrentbalance.PadLeft(11, ' ') + "\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
        }

        public void vouchertyperetailDotmetrix6TempFlex(string Invoicename,string Vno)
        {
            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            Label lb = new Label();
            lb.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Text = CompanyName;
            CompanyName = "                      " + CompanyName;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = ("                          PH: " + Mobile + "");
            string Taxruletext = ("     THE KERALA VALUE ADDED TAX RULES, 2005FORM " + Vno + ", [See rule 58(10)]").PadLeft(40, ' ');
            string PInvoiceName = "                                     " + Invoicename; ;
            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string StrVno = txtvno.Text;
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                             " + Datestr;
            string LineHeading = "=".PadRight(88, '=');
            string LineAbowAmount = "-".PadRight(88, '-');
            string LineFooter = "=".PadRight(88, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(22, ' ');
            string TsQty = "Qty".PadLeft(10, ' ');
            string TWidth = "Width".PadLeft(10, ' ');
            string THieght = "Hieght".PadLeft(10, ' ');
            string TsSqureFeet = "S.Feet".PadLeft(10, ' ');
            string TsRate = "Rate".PadLeft(10, ' ');
            string TsAmount = "Amount".PadLeft(12, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;

            if (Vno !="")
            {
                RichTextBox1.Text = "" + TIN + "\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\nCustomer :" + Custname + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr +  " \n\n" + Slno + Pname + TWidth + THieght +TsQty+ TsSqureFeet + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "\n"+ Address + "\n" + Mobile +  "\n\n\n\nCustomer :" + Custname + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname + TWidth + THieght + TsQty + TsSqureFeet + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            
            RowValidation();
            TRowCounting = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        TRowCounting = TRowCounting + 1;
                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(22, ' ');
                        if (Pname.Length > 22)
                            Pname = Pname.Substring(0, 22);
                       

                        double sWidth= _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Tag);
                        TWidth = _Dbtask.SetintoDecimalpointStock(sWidth);
                        TWidth = TWidth.PadLeft(10, ' ');

                        double sHieght = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Tag);
                        THieght = _Dbtask.SetintoDecimalpointStock(sHieght);
                        THieght = THieght.PadLeft(10, ' ');

                        double sQty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clngross"].Tag);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(10, ' ');

                        double SFeet = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnslno"].Tag);
                        TsSqureFeet = _Dbtask.SetintoDecimalpoint(SFeet);
                        TsSqureFeet = TsSqureFeet.PadLeft(10, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(10, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TWidth + THieght + TsQty+TsSqureFeet + TsRate + TsAmount;
                        TRowCounting = TRowCounting + 1;
                    }
                }
            }
            SettintogapDotmetrix(RichTextBox1, " ", TRowCounting, 8);

            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(60 - TTQty.Length, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(38 - TTAmount.Length, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "                                                     Authorized Signatory";
            currentbalance = 0;
            OldBalance = 0;
            if (AmountinWords.Length > 40)
            {
                AmountinWords = AmountinWords.Substring(0, 40) + "\n" + AmountinWords.Substring(40, AmountinWords.Length - 40);
            }

            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = BillAmount;
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
                    double BillAmt = BillAmount;
                    currentbalance = OldBalance;
                }
            }
            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            string TTaxAmount= _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtttax.Text));
            string TTaxableAmount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxtTGross.Text));
            string TTRAmount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtpaid.textBox1.Text));
            string TOtherExpence = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtotherexpenses.Text));
             TPaidAmount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtpaid.textBox1.Text));
             string Footer = CommonClass._Paramlist.GetParamvalue("Pfooter");
             string Naration = TxtNaration.textBox1.Text;
            if (Vno != "")
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                LineAbowAmount +
                 "\n" + TTQty + TTAmount + "\n" + LineFooter +
                 "\n                                                             Taxable Amount:" + TTaxableAmount.PadLeft(12, ' ') +
                 "\n                                                             Tax Amount    :" + TTaxAmount.PadLeft(12, ' ') +
                 "\n                                                             Bill Discount :" + BiilDiscount.PadLeft(12, ' ') +
                 "\n                                                             Other Expence :" + TOtherExpence.PadLeft(12, ' ') +
                 "\n                                                             Total         :" + txtbillamount.Text.PadLeft(12, ' ') +
                 "\n                                                             Paid Amount   :" + TPaidAmount.PadLeft(12, ' ') +
                 "\n\nIn Words: " + AmountinWords +
                "\n                                                             Current Balance:" + tempcurrentbalance.PadLeft(11, ' ') + "\n\n" + OtherizedSignature + "\n" +
                "Delivery Date : "+Naration+"\n"+
                "" + Footer + "\n" +
                 "\n\n\n\n\n\n\n\n\n\n";
            }
            else
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                  LineAbowAmount +
                   "\n" + TTQty + TTAmount + "\n" +
                  LineFooter + "\n                                                             Bill Discount :" + BiilDiscount.PadLeft(12, ' ') +
                               "\n                                                             Other Expence :" + TOtherExpence.PadLeft(12, ' ') +
                               "\n                                                             Total         :" + txtbillamount.Text.PadLeft(12, ' ') +
                               "\n                                                             Paid Amount   :" + TPaidAmount.PadLeft(12, ' ') +
                               "\n\nIn Words: " + AmountinWords +
                               "\n                                                            Current Balance:" + tempcurrentbalance.PadLeft(11, ' ') + "\n\n" + OtherizedSignature + "\n" +
                "Delivery Date : " + Naration + "\n" +
                "" + Footer + "\n" +
                 "\n\n\n\n\n\n\n\n\n\n"; 


            }
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

        }

        public void vouchertyperetailDotmetrix4(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = " " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(25, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                      " + Datestr;
            string LineHeading = "=".PadRight(45, '=');
            string LineAbowAmount = "-".PadRight(45, '-');
            string LineFooter = "=".PadRight(45, '=');
            string Slno = "Sl ".PadRight(2, ' ');
            string Bcode = "Bcode ".PadRight(7, ' ');
            string Pname = "Item ".PadRight(14, ' ');
            string TsQty = "Qty".PadLeft(3, ' ');
            string TMrp = "Mrp".PadLeft(6, ' ');
            string TsRate = "Rate".PadLeft(6, ' ');
            string TsAmount = "Amount".PadLeft(9, ' ');
            string TAmountstr = "Amount".PadLeft(9, ' ');
            string TTQty;
            string TTAmount;


            RichTextBox1.Text ="       "+Invoicename+"\n"+ Address + "\n" + Mobile + "\nNo :" + StrVno + "" + "\n" + Datestr + " \n\n"  + Pname +Bcode+ TsQty +TMrp+ TsRate + TAmountstr + "\n" + LineHeading + "";

            double DBTRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double MRP = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(2, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();

                        Bcode = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();

                        Bcode = Bcode.PadRight(7, ' ');

                        Pname = Pname.PadRight(12, ' ');
                        if (Pname.Length > 12)
                            Pname = Pname.Substring(0, 12);
                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sMRP = Convert.ToDouble(gridmain.Rows[i].Cells["clnmrp"].Value);
                        TMrp = _Dbtask.SetintoDecimalpointStock(sMRP);
                        TMrp = TMrp.PadLeft(6, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpointStock(sRate);
                        TsRate = TsRate.PadLeft(7, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpointStock(sAmount);
                        TsAmount = TsAmount.PadLeft(8, ' ');

                        TQty = TQty + sQty;
                        DBTRate = DBTRate + sRate;
                        MRP = MRP + sMRP;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n"  + Pname + Bcode + TsQty +TMrp+ TsRate + TsAmount;
                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpointStock(TQty);
            TTQty = TTQty.PadLeft(24, ' ');

            TTAmount = _Dbtask.SetintoDecimalpointStock(TAmount);
            TTAmount = TTAmount.PadLeft(21 , ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(BillAmount);
            string OtherizedSignature = "                  Authorized Signatory";
            currentbalance = 0;
            OldBalance = 0;
            if (AmountinWords.Length > 30)
            {
                AmountinWords = AmountinWords.Substring(0, 30) + "\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);
            }

            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = TBillAmount;

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
                    double BillAmt = TBillAmount;



                    currentbalance = OldBalance;
                }
            }
            double DBSavedAmount = MRP - DBTRate;
            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            string Cooly = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(txtotherexpenses.Text));
            string TaxAmount = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(txtttax.Text));
            string STotal = _Dbtask.SetintoDecimalpointStock(TBillAmount);
            string SavedAmount=_Dbtask.SetintoDecimalpointStock(DBSavedAmount);
            RichTextBox1.Text = RichTextBox1.Text + "\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter ;
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
            string Total = "        Total:" + txtbillamount.Text;
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                for (int k = 0; k < _Dotmetrix.WorkBackscroll(); k++)/*For Back Scroll*/
                {
                    MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                }
                MyPrinter.Print(Convert.ToChar(14).ToString());
                MyPrinter.Print(CompanyName + "\n");
                MyPrinter.Print(Convert.ToChar(20).ToString());
                MyPrinter.Print(RichTextBox1.Text);
                MyPrinter.Print("\n");
                MyPrinter.Print(Convert.ToChar(14).ToString());
                MyPrinter.Print(Total);
                MyPrinter.Print(Convert.ToChar(20).ToString());
                MyPrinter.Print(_Dotmetrix.WorkFrontScroll());/*For Front Scroll*/
                MyPrinter.Close();
            }
        }

        public void vouchertyperetailDotmetrix6(string Invoicename)
        {
            PrintBalance = CommonClass._Menusettings.GetMnustatus("150");
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string CompanyName2 = "                    LADIES,KIDS WEAR & GIFTS";

            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = " " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(25, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string TinNo = _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            TinNo = "                                TIN:" + TinNo;
            Address = temp;
            string RuleSeco;
            RuleSeco = "                           FORM 8B under KVAT Rules 2005";

            if (Invoicename == "WHOLESALE Invoice")
            {
                RuleSeco = "                             FORM 8 under KVAT Rules 2005";
            }

            string Taxruletext = "                         THE KERALA VALUE ADDED TAX RULES,";

            Address = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            if (PInvoiceName == "                 ESTIMATE")
            {
                PInvoiceName = "                     " + PInvoiceName;
                Datestr = "                                             " + Datestr;
            }
            else
            {
                Datestr = "                             " + Datestr;
            }

            Datestr = "            " + Datestr;
            string LineHeading = "=".PadRight(84, '=');
            string LineAbowAmount = "-".PadRight(84, '-');
            string LineFooter = "=".PadRight(84, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(35, ' ');
            string Unit = "Unit".PadRight(13, ' ');
            string MRP = "MRP".PadRight(7, ' ');
            string Bcode = "Bcode".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(7, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;
            double ReceivedAmt =new double();

            string CusAddress = CommonClass._Ledger.GetspecifField("address", TxtAccount.Tag.ToString());
            string CusTin = CommonClass._Ledger.GetspecifField("Taxregno", TxtAccount.Tag.ToString());


            if (PInvoiceName == "           Retail Invoice" || PInvoiceName == "        WHOLESALE Invoice")
            {
                RichTextBox1.Text = "\n\n         " + Address + "\n" + TinNo + "\n" + Mobile + "\n" + Taxruletext + "\n" + RuleSeco + "\n\nCustomer :" + Cusnam + "\n" +"Tin:"+ CusTin + "\n" +"Address :" +CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname + MRP + Unit + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "\n\n" + PInvoiceName + "\n         " + Address + "\n" + Mobile + "\n" + "\n\nCustomer :" + Cusnam + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname +MRP +Unit+ TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";

                //RichTextBox1.Text = "No :" + StrVno + "" + PInvoiceName + "\n\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
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
                        Slno = Slno.PadRight(4, ' ');

                     
                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();


                       // Pname = _ItemMaster.SpecificField(gridmain.Rows[i].Cells["clnitemname"].Tag.ToString(), "llang");
                        Pname = Pname.PadRight(35, ' ');
                        if (Pname.Length > 35)
                            Pname = Pname.Substring(0, 35);

                        MRP = gridmain.Rows[i].Cells["clnmrp"].Value.ToString();
                        MRP = MRP.PadRight(7, ' ');

                        Unit = gridmain.Rows[i].Cells["clnunit"].Value.ToString();
                        Unit = Unit.PadRight(13, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(7, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                      //  RichTextBox1.Text = RichTextBox1.Text + "\n\n" + Slno + Pname +Bcode+ TsQty + TsRate + TsAmount;
                         RichTextBox1.Text = RichTextBox1.Text + "\n\n" + Slno + Pname + MRP+Unit+TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(64, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(24 - TTAmount.Length, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "                                             Authorized Signatory";
            currentbalance = 0;
            OldBalance = 0;
            if (AmountinWords.Length > 40)
            {
                AmountinWords = AmountinWords.Substring(0, 40) + "\n" + AmountinWords.Substring(40, AmountinWords.Length - 40);
            }

            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                ReceivedAmt = _Dbtask.znullDouble(txtpaid.textBox1.Text);
                if (EditMode == true)
                {
                    tempp = (_Dbtask.znullDouble(tempp) - (_Dbtask.znullDouble(txtbillamount.Text) - ReceivedAmt)).ToString();
                    OldBalance = Convert.ToDouble(tempp);
                }
                else
                {
                    OldBalance = _Laser.OldBalance;

                }
                    //  OldBalance = Convert.ToDouble(tempp) - BillAmount + Convert.ToDouble(txtpaid.textBox1.Text);
                double BillAmt = TBillAmount;

                if (EditMode == true)
                {
                    currentbalance = _Dbtask.znullDouble(tempp) + ReceivedAmt + _Dbtask.znullDouble(txtbillamount.Text);
                }
                else
                {
                    currentbalance = _Dbtask.znullDouble(tempp) + ReceivedAmt;
                }
            }
            else if (TxtAccount.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = TBillAmount;
                    currentbalance = OldBalance;
                }
                ReceivedAmt = _Dbtask.znullDouble(txtpaid.textBox1.Text) +TBillAmount;

            }

            string tempoldbalance = temp;
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);

            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            string Cooly = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtotherexpenses.Text));

            string TotalTaxableAmount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxtTGross.Text));
            string TotalTaxAmt = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtttax.Text));
          

            if (PInvoiceName == "           Retail Invoice")
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                LineAbowAmount +
                 "\n" + TTQty + TTAmount + "\n" +LineFooter;
                 if(ComTax.SelectedIndex==1)
                 {
                     RichTextBox1.Text = RichTextBox1.Text + "\n                       Total Taxable  :" + TotalTaxableAmount.PadLeft(13, ' ') +
                        "\n                       Total Tax      :" + TotalTaxAmt.PadLeft(13, ' ');
                  }
                 RichTextBox1.Text = RichTextBox1.Text + "\n                                      Bill Discount  :" + BiilDiscount.PadLeft(13, ' ');


                    PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                  //  RichTextBox1.Text = CompanyName+"\n  " + RichTextBox1.Text;
                PrintBold(CompanyName,false);
                
                    

                    PrintDotMetrix(false);

                    PrintBold("\nBill Amount:" + txtbillamount.Text,false);
                   

                    //AmountinWords = AmountinWords + " " + _word.ConvertAmount(_Dbtask.znullDouble(txtbillamount.Text));
                    RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
                    PrintDotMetrix(false);
            }
            else
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineAbowAmount +
                "\n" + TTQty + TTAmount + "\n"+LineFooter;
                if (ComTax.SelectedIndex == 1)
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n                       Total Taxable  :" + TotalTaxableAmount.PadLeft(13, ' ') +
                                                        "\n                       Total Tax      :" + TotalTaxAmt.PadLeft(13, ' ');
                }
                if (_Dbtask.znullDouble(BiilDiscount) == 0)
                {
                    //RichTextBox1.Text = RichTextBox1.Text +
                    //    "\n                       Bill Amount    :" + txtbillamount.Text.PadLeft(28, ' ');

                }
                else
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n                       Bill Discount  :" + BiilDiscount.PadLeft(28, ' ') +
                    "\n                       Bill Amount    :" + txtbillamount.Text.PadLeft(28, ' ');
                }

                PrintRollBack(5);

                RichTextBox2.Text = RichTextBox1.Text;
                PrintBold(CompanyName, false);
                PrintDotMetrix(false);
               // PrintDotMetrix(true);

                string Rec = ReceivedAmt.ToString("0.00");
                string CurrentBalance = currentbalance.ToString();

                if (PrintBalance == "1")
                {
                    if (commodeofpayment.SelectedIndex == 0)
                        CurrentBalance = "0.00";
                    RichTextBox1.Text = "\n\nOld Balance     :" + OldBalance.ToString().PadLeft(13, ' ') +
                                          "\nTotal Balance   :" + CurrentBalance.PadLeft(13, ' ') + "\n" +
                                            "Received Amount :" + Rec.PadLeft(13, ' ') + "\n";
                }
                RichTextBox2.Text = RichTextBox2.Text + RichTextBox1.Text;
                PrintDotMetrix(false);

                double GrandTotal=_Dbtask.znullDouble(CurrentBalance)-_Dbtask.znullDouble(Rec);
                if (PrintBalance != "1")
                {
                    GrandTotal =_Dbtask.znullDouble(txtbillamount.Text);
                }

                TBillAmount = _Dbtask.znullDouble(txtbillamount.Text);

                if (commodeofpayment.SelectedIndex == 0)
                    GrandTotal =TBillAmount;
                
                PrintBold("          Grand Total:" +GrandTotal,false );
                RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";

                RichTextBox2.Text = RichTextBox2.Text + RichTextBox1.Text;
                PrintDotMetrix(false);

            }

            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

           // RichTextBox1.Text = RichTextBox2.Text;
            if (ChkShowPreview.Checked == false)
            {
               
            }
        }

        public void PrintCondident(string Str)
        {
            
        }
        

        public void PrintBold(string Str,bool isConsoled)
        {
            
            temp = CommonClass._Menusettings.GetMnustatus("162");
            if (temp == "1")
                isConsoled = true;
            else
                isConsoled = false;

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
        public void PrintRollBack(int Count)
        {
            if(ChkShowPreview.Checked==false) 
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

        public void PrintDotMetrix(bool Isconsole)
        {
            string Str;
            Str=CommonClass._Menusettings.GetMnustatus("162");
            if(Str=="1")
                Isconsole=true;
            else
                Isconsole=false;


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
                        
                           //  MyPrinter.Print("മയൂരി അര ");
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

        public void vouchertyperetailDotmetrix6ThermalMarrymatha(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string TinNo = _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            TinNo = "          " + "TIN:" + TinNo;
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string RuleSeco = "     FORM 8B under KVAT Rules 2005";
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                      " + Datestr;
            StrTime = "                      " + StrTime;
            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(2, ' ');
            string Pname = "Items";
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsMrp = "MRP".PadLeft(8, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(10, ' ');
            string TAmountstr = "Amount".PadLeft(10, ' ');

            string TTQty;
            string TTAmount;
            string TTMRP;

            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            if (TinNo == "          TIN:")
            {
                RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n"  + "\n\nNo :" + StrVno + "" +
                    "\nCustomer:" + Cusnam + "\n" + Datestr + "\n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate +
                    TsMrp + TsAmount + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n"+TinNo+"\n"+ RuleSeco + "\n\nNo :" + StrVno + "" +
                       "\nCustomer:" + Cusnam + "\n" + Datestr + "\n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate +
                       TsMrp + TsAmount + "\n" + LineHeading + "";
            }
            if(Invoicename=="ESTIMATE")
            {
                RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n" + TinNo + "\n" + RuleSeco + "\n" +
                       "\nCustomer:" + Cusnam + "\n" + Datestr + "\n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate +
                       TsMrp + TsAmount + "\n" + LineHeading + "";
            }

            double TRate = 0;
            double TMrp = 0;
            double TQty = 0;
            double TAmount = 0;
            NetMrp = 0;
            NetSrate = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(2, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(13, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');

                        double sMrp = Convert.ToDouble(gridmain.Rows[i].Cells["clnmrp"].Value);
                        TsMrp = _Dbtask.SetintoDecimalpoint(sMrp);
                        TsMrp = TsMrp.PadLeft(8, ' ');

                        double ItemDisc = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clndiscount"].Value);


                        double sAmount = sQty * sRate;
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(11, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate * sQty;
                        TMrp = TMrp + sMrp * sQty;

                       
                        TAmount = TAmount + sAmount;
                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + "\n" + TsQty +  TsRate +TsMrp+ TsAmount;

                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(13, ' ');

            TTMRP= _Dbtask.SetintoDecimalpoint(TMrp);
            TTMRP = TTMRP.PadLeft(16, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(27, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(BillAmount);
            if (AmountinWords.Length > 30)
                AmountinWords = AmountinWords.Substring(0, 30) + "\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);
            string OtherizedSignature = "                  Authorized Signatory";
            currentbalance = 0;
            OldBalance = 0;
            string Visitagain = "        ***THANK YOU, VISIT AGAIN***";
           
            double DbSavedAmt = TMrp - TRate;
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txttypebilldiscount.textBox1.Text));

            string strTaxamt = txtttax.Text;
            
            SavedAmount = _Dbtask.SetintoDecimalpoint(DbSavedAmt);
          
            string ItemDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxttItemDiscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter;


            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {
                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = TBillAmount;
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
                    double BillAmt = TBillAmount;
                    currentbalance = OldBalance;
                }
            }
            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);

            if (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) > 0)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n            Bill Discount  :" + BiilDiscount.PadLeft(12, ' ');
            }

            if (Convert.ToDouble(TxttItemDiscount.Text) > 0)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n         Item Discount :" + ItemDiscount.PadLeft(12, ' ');
            }

            if (STax==true)
            {
              RichTextBox1.Text = RichTextBox1.Text + "\n            Tax Amount     :" + strTaxamt.PadLeft(12, ' ');
            }
            PrintBalance = CommonClass._Menusettings.GetMnustatus("150");
            if(PrintBalance=="1")
            RichTextBox1.Text = RichTextBox1.Text + "\n            Old Balance    :" + tempoldbalance.PadLeft(12,' ');
            string Cooly = Txttypecooly.textBox1.Text;
            TottalAmount = Convert.ToDouble(tempoldbalance) + TBillAmount;
            TottalAmount =_Dbtask.znullDouble(TTAmount) - Convert.ToDouble(Cooly);
            RichTextBox1.Text = RichTextBox1.Text + "\n            Other Expense  :" + Cooly.PadLeft(12, ' ') + " \n\n             Total         :" + TottalAmount.ToString("0.00").PadLeft(12, ' ') + "\n\nYour Saved Amount :" + SavedAmount + "\n\n";

            if (PrintBalance == "1")
                RichTextBox1.Text = RichTextBox1.Text + "\n\nCurrent Balance :" + tempcurrentbalance + "\n\n" + CommonClass.CashDesk + "\n\n";
            RichTextBox1.Text = RichTextBox1.Text + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            CommonClass.CashDesk = "";
        }

        public void vouchertyperetailDotmetrix10(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                                                                                " + Datestr;
            string LineHeading = "=".PadRight(129, '=');
            string LineAbowAmount = "-".PadRight(129, '-');
            string LineFooter = "=".PadRight(129, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Pname = "Product Name".PadRight(53, ' ');
            string TsQty = "Qty".PadLeft(13, ' ');
            string Tsfree = "Free".PadLeft(10, ' ');
            string TsRate = "Rate".PadLeft(23, ' ');
            string TsAmount = "Amount".PadLeft(23, ' ');
            string TAmountstr = "Amount".PadLeft(23, ' ');
            string TTQty;
            string TTAmount;
            
            if (PInvoiceName == "                           Sales Invoice")
            {
                RichTextBox1.Text = "" + CompanyName + "\n\n" + Address + "\n" + Mobile + "\nNo :" + StrVno + "" + PInvoiceName + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text ="" + CompanyName + "\n\n" + Address + "\n" + Mobile + "\n"+ "No :" + StrVno + "" + PInvoiceName + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double Tfree = 0;
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
                        Pname = Pname.PadRight(53, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(23, ' ');
                        
                        double sfree = Convert.ToDouble(gridmain.Rows[i].Cells["clnfree"].Value);
                        Tsfree = _Dbtask.SetintoDecimalpointStock(sfree);
                        Tsfree = Tsfree.PadLeft(23, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(23, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(23, ' ');



                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(83, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(46, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "Authorized Signatory".PadLeft(130, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt =_Dbtask.znullDouble(txtbillamount.Text);

                OldBalance = OldBalance - BillAmt;

                OldBalance = OldBalance + _Dbtask.znullDouble(txtpaid.textBox1.Text);
                currentbalance = OldBalance + BillAmt;
                currentbalance = currentbalance - _Dbtask.znullDouble(txtpaid.textBox1.Text);
            }
            else if (TxtAccount.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = TBillAmount;

                   // currentbalance = OldBalance;
                    currentbalance = OldBalance + BillAmt;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);

           
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter + "\n\n";                                                    
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                PrintDotMetrix(true);
                PrintBold("                  Total    :" + txtbillamount.Text,true);

                string PaidAmount;
                if(commodeofpayment.SelectedIndex==0)
                    PrintBold("\n                  Paid Amount    :" + txtbillamount.Text, true);
                else
                    PrintBold("\n                  Paid Amount    :" + txtpaid.textBox1.Text, true);


                RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
                Fscroll();
                PrintDotMetrix(true);
                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }
        }

      
        


        public void vouchertyperetailDotmetrixMobile(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

            string Datestr ="  "+  dtdate.Value.ToString("dd/MM/yyyy");
            //Datestr = "                                                                                                                " + Datestr;
            string LineHeading = "=".PadRight(129, '=');
            string LineAbowAmount = "-".PadRight(129, '-');
            string LineFooter = "=".PadRight(129, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Pname = "Product Name".PadRight(53, ' ');
            string TsQty = "Qty".PadLeft(13, ' ');
            string Tsfree = "Free".PadLeft(10, ' ');
            string TsRate = "Rate".PadLeft(23, ' ');
            string TsAmount = "Amount".PadLeft(23, ' ');
            string TAmountstr = "Amount".PadLeft(23, ' ');
            string TTQty;
            string TTAmount;

            string TTdiscount = "0";
            string TTTax = "0";
            string TTNetAmount = "0";


            RichTextBox1.Text ="\n\n"+ Datestr + "                        " + StrVno + "\n\n" +
                "  "+Cusnam + "\n\n\n";
            
            double TRate = 0;
            double TQty = 0;
            double Tfree = 0;
            double TAmount = 0;
            double Tdiscount=0;
            double TTax=0;
            double TNetAmount=0;

            RowValidation();
            TRowCounting = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {


                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(47, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(7, ' ');

                     

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(12, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(12, ' ');



                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" +  Pname + TsQty + TsRate + TsAmount;
                        TRowCounting = TRowCounting + 1;
                    }
                }
            }
            SettintogapDotmetrix(RichTextBox1, " ", TRowCounting, 10);

            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(83, ' ');

            TTAmount = TxtTGross.Text;
               
            TTAmount = TTAmount.PadLeft(78, ' ');

            Tdiscount = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);
            TTdiscount = _Dbtask.SetintoDecimalpoint(Tdiscount);
            TTdiscount = TTdiscount.PadLeft(78, ' ');

            TTax = _Dbtask.znullDouble(txtttax.Text);
            TTTax = _Dbtask.SetintoDecimalpoint(TTax);
            TTTax = TTTax.PadLeft(78, ' ');

            TNetAmount = _Dbtask.znullDouble(txtbillamount.Text);
            TTNetAmount = _Dbtask.SetintoDecimalpoint(TNetAmount);
            TTNetAmount = TTNetAmount.PadLeft(78, ' ');

           // string Tdiscount;
            
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "Authorized Signatory".PadLeft(130, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = _Dbtask.znullDouble(txtbillamount.Text);

                OldBalance = OldBalance - BillAmt;

                OldBalance = OldBalance + _Dbtask.znullDouble(txtpaid.textBox1.Text);
                currentbalance = OldBalance + BillAmt;
                currentbalance = currentbalance - _Dbtask.znullDouble(txtpaid.textBox1.Text);
            }
            else if (TxtAccount.Text != "")
            {
                string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                if (Accountid != "" && Groupid != "25" && Groupid != "")
                {
                    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    OldBalance = Convert.ToDouble(tempp);
                    double BillAmt = TBillAmount;

                    // currentbalance = OldBalance;
                    currentbalance = OldBalance + BillAmt;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);


            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            RichTextBox1.Text = RichTextBox1.Text +

               "\n" + TTAmount + "\n" + TTdiscount + "\n\n" + TTTax + "\n" + TTNetAmount + "\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
                PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                PrintDotMetrix(true);
               // PrintBold("                  Total    :" + txtbillamount.Text, true);

                string PaidAmount;
                //if (commodeofpayment.SelectedIndex == 0)
                //    PrintBold("\n                  Paid Amount    :" + txtbillamount.Text, true);
                //else
                //    PrintBold("\n                  Paid Amount    :" + txtpaid.textBox1.Text, true);


               // RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
                RichTextBox1.Text = "";
                Fscroll();
                PrintDotMetrix(true);
                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }
        }

        public void vouchertypewholesalesother()
        {
            try
            {
                if (ChkShowPreview.Checked == true)
                {
                    
                    printPreviewDialog1.Document = printDocument1;
                    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                 
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    PrinterSettings();
                    pd.Print();
                }
            }
            catch
            {
            }
        }
        public void PrinterSettings()
        {
            pd = printDocument1;
            pd.PrinterSettings.PrinterName = ComPrintSheme.Text;
            if (Printerselect == "9")
            {
                pd.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("ddd", 583, 827);
                pd.DefaultPageSettings.PrinterSettings.PrinterName = "hh";
            }
           
        }
        public void DefinePrint()
        {
            Printerselect = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='Pselect'");
            if (IsDotmetrix())
            {
                DesignLoadRt();
            }
            else
            {
                Nocopies();
            }
        }
        public bool IsDotmetrix()
        {

            if (Printerselect == "4" || Printerselect == "5" || Printerselect == "6" || Printerselect == "100" || Printerselect == "10" || Printerselect == "7" || Printerselect == "8" || Printerselect == "9" || Printerselect == "11" || Printerselect == "12")
                return false;
            return true;
        }
        public void Nocopies()
                    {
          //  DesignLoadRt();
            NoofCopies = Convert.ToInt32 (_Dbtask.znullDouble((CommonClass._Paramlist.GetParamvalue("Nocopies"))));
            if (NoofCopies == 0)
            {
                NoofCopies = 1;
            }
           
           
                for (int k = 0; k < NoofCopies; k++)
                {
                    if (k == 0)
                        MainPrint(true);
                    else
                        MainPrint(false);
                }
            
        }

        public void vouchertyperetailDotmetrix10BrandRoot(string Invoicename)
        {
            //BAG WORLD&TOYS GALLERY
            string StrVno = txtvno.Text;
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string TelePhone = _Dbtask.ExecuteScalar("select telephone from TblCompanyMaster");
            string AddressTemp = "                                          BAG WORLD&TOYS GALLERY" + "                PH:" + TelePhone;
         
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string City = "MANJERI";
            string Address = temp;
            string Mobile = "                                               MOBILE :" + _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string CustomerMobile = CommonClass._Ledger.GetSpecificfieldBaseonName(Cusnam,"Mobile");
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string TimeStr = "                                                                       Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr =        "                                                                     " + Datestr;
            string LineHeading = "=".PadRight(105, '=');
            string LineAbowAmount = "-".PadRight(105, '-');
            string LineFooter = "=".PadRight(105, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Pname = "Product Name".PadRight(54, ' ');
            string TsQty = "Qty".PadLeft(9, ' ');
            string TsRate = "BRP".PadLeft(11, ' ');
         
            string TsMrp= "MRP".PadLeft(11, ' ');
            string TsAmount = "Amount".PadLeft(12, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;
            City = "                                                  " + City;
            
            
            RichTextBox1.Text = "\n" + AddressTemp + "\n" + Address  +"\n"+ City+"\nNo :" + StrVno  + "\nCustomer:" + Cusnam +Datestr+"\nMobile:"+CustomerMobile+TimeStr+ " \n\n" + Slno + Pname + TsQty + TsRate +TsMrp+ TAmountstr + "\n" + LineHeading + "";
           
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

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(9, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(12, ' ');

                        double sMrp= Convert.ToDouble(gridmain.Rows[i].Cells["clnmrp"].Value);
                        TsMrp = _Dbtask.SetintoDecimalpoint(sMrp);
                        TsMrp = TsMrp.PadLeft(12, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(10, ' ');



                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TMrp = TMrp + sMrp;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate +TsMrp+ TsAmount;

                    }
                }
            }
            TTQty = TQty.ToString("0.00");
            TTQty = TTQty.PadLeft(70, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(34, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string OtherizedSignature = "Authorized Signatory".PadLeft(80, ' ');
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = TBillAmount;

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
                    double BillAmt = TBillAmount;

                    currentbalance = OldBalance;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);


            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txttypebilldiscount.textBox1.Text));

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter + "\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

            RichTextBox1.Text = RichTextBox1.Text + "In Words: " + AmountinWords +
            "\n                                                                            Discount:" + BiilDiscount + "\n";
            TMrp=TMrp+_Dbtask.znullDouble(BiilDiscount);
            SavedAmount =_Dbtask.SetintoDecimalpoint(TMrp - TRate);
            if (ChkShowPreview.Checked == false)
            {
                if (!MyPrinter.Open("Qplex Print")) return;
             
                PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
                PrintBold("                      BRAND ROOT",true);
                PrintDotMetrix(true);

                if (NextGFuntion.SalesReturnVno != "")
                {
                    RichTextBox1.Text = "\n" + NextGFuntion.Salesreturnstring;

                    double Amt;
                    Amt =_Dbtask.znullDouble(txtbillamount.Text);

                    if (EditMode == true)
                        Amt = Amt - NextGFuntion.SalesReturnAmount;

                        RichTextBox1.Text = RichTextBox1.Text + "\n                                                                            Discount               :" + BiilDiscount + "\n" +
                                                                "\n                                                                            " + "Sales Return Amount :" + NextGFuntion.SalesReturnAmount +
                                                                "\n                                                                            " +

                                                                              "Net Balance           :" + Amt.ToString("0.00");
                   
                    PrintBold("",true);
                    Fscroll();
                    PrintDotMetrix(true);
                }
                else
                {
                   // PrintBold("", true);
                    PrintBold("You Saved   :" + SavedAmount + "               Total    :" + txtbillamount.Text, true);

                    CashReceivedTxt = CashReceivedTxt;
                    RichTextBox1.Text = "\n\n" + CashReceivedTxt;
                    if(SalesReturnText !="")
                        RichTextBox1.Text = "\n\n" + SalesReturnText;


                    Fscroll();
                    PrintDotMetrix(true);
                }
                // MyPrinter.Print("===================================\r\n");
                MyPrinter.Close();
            }
        }

        public void vouchertyperetailDotmetrix10BrandRootreturn(string Invoicename)
        {
            DSSalesreturn.Tables.Clear();
            DSSalesreturn.Tables.Add();
                DSSalesreturn.Tables[0].Columns.Clear();
                DSSalesreturn.Tables[0].Columns.Add("clnslno");
                DSSalesreturn.Tables[0].Columns.Add("clnitemname");
                DSSalesreturn.Tables[0].Columns.Add("clnqty");
                DSSalesreturn.Tables[0].Columns.Add("clnsrate");
                DSSalesreturn.Tables[0].Columns.Add("clnmrp");
                DSSalesreturn.Tables[0].Columns.Add("clnnettamount");

                if (Vtype == "SR")
                {
                    for (int k = 0; k < gridmain.Rows.Count; k++)
                    {
                        if (gridmain.Rows[k].Tag != null)
                        {
                            if (gridmain.Rows[k].Tag.ToString() == "1")
                            {
                                DSSalesreturn.Tables[0].Rows.Add(1);
                                DSSalesreturn.Tables[0].Rows[k]["clnitemname"] = gridmain.Rows[k].Cells["clnitemname"].Value;
                                DSSalesreturn.Tables[0].Rows[k]["clnqty"] = gridmain.Rows[k].Cells["clnqty"].Value;
                                DSSalesreturn.Tables[0].Rows[k]["clnsrate"] = gridmain.Rows[k].Cells["clnsrate"].Value;
                                DSSalesreturn.Tables[0].Rows[k]["clnmrp"] = gridmain.Rows[k].Cells["clnmrp"].Value;
                                DSSalesreturn.Tables[0].Rows[k]["clnnettamount"] = gridmain.Rows[k].Cells["clnnettamount"].Value;
                            }
                        }
                    }
                }
                else
                {
                    Ds = _Dbtask.ExecuteQuery("select * from tblreceiptdetails where vtype='SR' and recptcode='" + NextGFuntion.SalesReturnVno + "'");
                    for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                    {
                                DSSalesreturn.Tables[0].Rows.Add(1);
                                DSSalesreturn.Tables[0].Rows[k]["clnitemname"] =CommonClass._Itemmaster.SpecificField(Ds.Tables[0].Rows[k]["pcode"].ToString(),"itemname");
                                DSSalesreturn.Tables[0].Rows[k]["clnqty"] = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[k]["qty"]);
                                DSSalesreturn.Tables[0].Rows[k]["clnsrate"] = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[k]["rate"]);
                                DSSalesreturn.Tables[0].Rows[k]["clnmrp"] = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[k]["mrp"]);
                                DSSalesreturn.Tables[0].Rows[k]["clnnettamount"] = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[k]["netamt"]);
                    }
                }
            

            string LineHeading = "=".PadRight(105, '=');
            string LineAbowAmount = "-".PadRight(105, '-');
            string LineFooter = "=".PadRight(105, '=');
            string Slno = "Slno".PadRight(7, ' ');
            string Pname = "Product Name".PadRight(54, ' ');
            string TsQty = "Qty".PadLeft(9, ' ');
            string TsRate = "BRP".PadLeft(11, ' ');

            string TsMrp = "MRP".PadLeft(11, ' ');
            string TsAmount = "Amount".PadLeft(12, ' ');
            string TAmountstr = "Amount".PadLeft(12, ' ');
            string TTQty;
            string TTAmount;


            NextGFuntion.Salesreturnstring = "***************Sales Return*************** \n" + Slno + Pname + TsQty + TsRate + TsMrp + TAmountstr + "\n" + LineHeading + "";

            double TRate = 0;
            double TMrp = 0;
            double TQty = 0;
            double TAmount = 0;
            RowValidation();
            for (int i = 0; i < DSSalesreturn.Tables[0].Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = i+1.ToString();
                        Slno = Slno.PadRight(7, ' ');



                        Pname = DSSalesreturn.Tables[0].Rows[i]["clnitemname"].ToString();
                        Pname = Pname.PadRight(54, ' ');

                        double sQty = Convert.ToDouble(DSSalesreturn.Tables[0].Rows[i]["clnqty"]);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(9, ' ');

                        double sRate = Convert.ToDouble(DSSalesreturn.Tables[0].Rows[i]["clnsrate"]);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(12, ' ');

                        double sMrp = Convert.ToDouble(DSSalesreturn.Tables[0].Rows[i]["clnmrp"]);
                        TsMrp = _Dbtask.SetintoDecimalpoint(sMrp);
                        TsMrp = TsMrp.PadLeft(12, ' ');

                        double sAmount = Convert.ToDouble(DSSalesreturn.Tables[0].Rows[i]["clnnettamount"]);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(10, ' ');



                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TMrp = TMrp + sMrp;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        NextGFuntion.Salesreturnstring = NextGFuntion.Salesreturnstring + "\n" + Slno + Pname + TsQty + TsRate + TsMrp + TsAmount;

                    }
                }
            }
            TTQty = TQty.ToString("0.00");
            TTQty = TTQty.PadLeft(70, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(34, ' ');
            AmountInWords _word = new AmountInWords();

           

            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txttypebilldiscount.textBox1.Text));

            NextGFuntion.Salesreturnstring = NextGFuntion.Salesreturnstring + "\n\n\n\n\n\n" +
              LineAbowAmount +
               "\n" + TTQty + TTAmount + "\n" +
              LineFooter + "\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";

            NextGFuntion.Salesreturnstring = NextGFuntion.Salesreturnstring + "In Words: " + AmountinWords +
            "\n                                                                                        Discount:" + BiilDiscount + "\n";
            BiilDiscount = _Dbtask.ExecuteScalar("select discamt from TblTransactionReceipt where ReptCode='" + NextGFuntion.SalesReturnVno + "' and RecptType='SR' ");
            NextGFuntion.SalesReturnAmount =_Dbtask.znullDouble(TTAmount)-_Dbtask.znullDouble(BiilDiscount);
            NextGFuntion.SalesReturnVno = txtvno.Text;
        }


        public void secondary()
        {
            if (_Dbtask.znllString(CommonClass._Dbtask.GetPrinterName2()) == ComPrintSheme.Text)
            {
                if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()) != "")
                {


                    if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() != "none")
                    {
                        string typee = "";
                        //typee = CommonClass._Paramlist.GetParamvalue("Pmodel").ToLower();
                        if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() == "thermal")
                        {


                            Printerselect = "4";

                        }
                        if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() == "a4")
                        {

                            Printerselect = "A4Preprint2";//"mode12";

                        }
                        if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() == "a4 other")
                        {

                            Printerselect = "mode6";

                        }
                        if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() == "no tax a4 code + name")
                        {


                            Printerselect = "codenameNotax";

                        }
                        if (_Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower() == "no tax a4 name")
                        {

                            Printerselect = "NameNotax";

                        }



                        string which = "";
                        which = _Dbtask.znllString(CommonClass._Dbtask.Getsecondprintmodel()).ToLower();
                        if (which != "thermal" && which != "a4" && which != "a4 other" && which != "no tax a4 code + name" && which != "no tax a4 name")
                        {
                            Printerselect = "4";
                        }




                    }


                }

            }
        }





        public void MainPrint(bool Preview)
                {
                //if (Secndnow == false)
                //{
                    Printerselect = CommonClass._Dbtask.GetPrinterSelect();
               Selectedprint = ComPrintSheme.Text;
            //}
            if (chkprintconfirmation.Checked == true)
            {
                Result = MessageBox.Show("Do You want to Print?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            
            if (Result.ToString() == "Yes" || chkprintconfirmation.Checked == false)
            {
                
                PrintingInvoiceName = _Dotmetrix.PrintInvoiceHead(Vtype);
                AmountinWords = _Gen.Getmajorsymbol();
                string temp = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                string tempname = "";
                 tempname   = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + SalesAccount + "'");
                MyPrinter.PrinterName = Selectedprint;
                _lasersix.SelPrint = Selectedprint;
                Clsinvlaser.SelPrint = Selectedprint;

                secondary();

                if (temp == "1" || temp == "-1")
                {
                    if (SalesAccount == "2" || SalesAccount == "14" || tempname.ToLower() == "estimate")
                    {
                        if (Printerselect == "1")
                        {
                            RichTextBox1.Font = new System.Drawing.Font("Consolas", 6);

                            if(Vtype=="SI")
                            vouchertyperetailDotmetrix4("Sales Invoices");
                            if(Vtype=="SR")
                                vouchertyperetailDotmetrix4("Sales Return");
                        }
                        if (Printerselect == "3")
                        {
                            if (STax == true)
                            {
                                vouchertypewholesalesDotmetrix10steel("RETAIL INVOICE", "NO.8 B");
                                vouchertypewholesalesother();

                               // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");
                            }
                            else
                            {
                                vouchertyperetailDotmetrix10("Sales Invoice");
                            }
                        }
                        if (Printerselect == "2")
                        {
                            if (STax == true)
                            {
                                vouchertyperetailDotmetrix6("Retail Invoice");
                            }
                            else
                            {
                                if(Vtype=="SI")
                                
                                vouchertyperetailDotmetrix6("ESTIMATE");
                                else if(Vtype=="SR")
                                vouchertyperetailDotmetrix6("Sales return");

                            }
                        }
                        if (Printerselect == "9")
                        {
                            PrintLaserAfivesize(Heading.ToString(), Printerselect);
                        }
                        if (Printerselect == "4")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalNew("Sales Invoice");
                           // vouchertypewholesalesother();
                           Normal3PointLaser(Printerselect);



                          



                        }

                        if (Printerselect == "ThermalenglishNotax")/*For Thermel Printing*/
                        {
                            Normal3PointLaserNOTAX(Printerselect);


                        }


                        if (Printerselect == "100")
                        {
                            vouchertyperetailDotmetrix6ThermalMarrymatha("Sales Invoice");
                            vouchertypewholesalesother();
                        }

                        if (Printerselect == "DotMobile")
                        {
                            vouchertyperetailDotmetrixMobile("");
                        }
                        if (Printerselect == "3pointArabic")/*For Thermel Printing*/
                        {
                             vouchertyperetailDotmetrix6ThermalNew("Sales Invoice");
                            thermalarabthreepoint(Printerselect);
                            //PrintLaser3Point("SALES RETURN", Printerselect);
                        }
                        if (Printerselect == "ThermalarabNotax")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalNew("Sales Invoice");

                            thermalarabthreepointNOTAX(Printerselect);
                            //thermalarabthreepoint(Printerselect);
                            //PrintLaser3Point("SALES RETURN", Printerselect);
                        }
                        if (Printerselect == "7" || Printerselect == "mode7" || Printerselect == "mode6" || Printerselect == "mode5" || Printerselect == "mode3" || Printerselect == "mode4" || Printerselect == "A4Preprint" || Printerselect == "A4Qatar" || Printerselect == "A4ModeNew" || Printerselect == "A4Preprint2" || Printerselect == "14" || Printerselect == "11" || Printerselect == "Workshopmode3Notax" || Printerselect == "Workshopmode3" || Printerselect == "codenameNotax" || Printerselect == "NameNotax")/*For Mixed Dot6 and Wholesale Tax*/
                        {
                            if (STax == true)
                            {
                                //if (this.Text == "Sales Return")
                                //{
                                //    PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                //  //  PrintLaserthree("     " + this.Heading.ToUpper(), Printerselect);
                                //}
                                //else 
                                if (this.Text == "Delivery Note")
                                {
                                    temp = "Delivery Note";//  PrintLaserQATAR("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                }
                                //else
                                //{

                                    if (this.Heading == "Sales Order")
                                    {
                                        temp = "     SALES ORDER";
                                    }
                                     if (this.Heading.ToLower() == "sales quatation")
                                    {
                                        temp = "SALES QUATATION";
                                    }
                                   if (this.Heading.ToLower() == "estimate")
                                    {
                                        temp = "  ESTIMATE";
                                    }
                                   if (this.Text == "Delivery Note")
                                   {
                                       temp = "Delivery Note";//  PrintLaserQATAR("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                   }
                                    else
                                    {
                                        temp = "    RETAIL";
                                    }
                                        if (Printerselect == "A4Preprint2")
                                        {
                                            PrintLaserfive("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                        if (Printerselect == "A4Preprint")
                                        {
                                            PrintLaserfour("     " + this.Heading.ToUpper(), Printerselect);
                                        }


                                        if (Printerselect == "Workshopmode3Notax")
                                        {

                                            WORKSHOPNOTAXLASER("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/

                                            //laserworkshop("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                            //PrintLasersix("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                        }
                                        if (Printerselect == "Workshopmode3")
                                        {

                                            //WORKSHOPNOTAXLASER("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/

                                            laserworkshop("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                            //PrintLasersix("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                        }

                                        if (Printerselect == "mode3")
                                        {

                                            //WORKSHOPNOTAXLASER("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/

                                            //laserworkshop("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                            PrintLasersix("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                        }
                                        if (Printerselect == "A4Qatar")
                                        {
                                            PrintLaserQATAR("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                        }
                                        if (Printerselect == "A4ModeNew")
                                        {
                                           PrintLaserA4NEW("     " + this.Heading.ToUpper(), Printerselect);/*Normal*/
                                        }

                                        if (Printerselect == "mode4")
                                        {
                                            PrintLaserseven("     " + this.Heading.ToUpper(), Printerselect); 
                                        }
                                        if (Printerselect == "mode5")
                                        {

                                            PrintLasereight("     " + this.Heading.ToUpper(), Printerselect);
                                        
                                        }

                                        if (Printerselect == "mode6")
                                        {

                                            PrintLaserNine("     " + this.Heading.ToUpper(), Printerselect);  
                                        }
                                        if (Printerselect == "codenameNotax")
                                        {

                                            PrintLaserNineNOTAX("     " + this.Heading.ToUpper(), Printerselect);  
                                        }
                                        if (Printerselect == "NameNotax")
                                        {

                                            ItemonlyNOTAXlaser("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                               


                                        if (Printerselect == "mode7")
                                        {
                                            Normal2InchThermal(Printerselect);
                                        }

                                        if (Printerselect == "7")
                                        {
                                            PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                        if (Printerselect == "14")
                                        {
                                            PrintLaserthree("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                        else
                                        {
                                            //PrintLaser1("     " + this.Heading.ToUpper(), Printerselect);
                                            //PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                   // }
                                   // PrintLaser(temp, Printerselect);
                                }
                            //}
                            else
                            {
                                if (Printerselect == "7")
                                {
                                    PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                }
                               
                                else
                                {
                                    PrintLaser1("     " + this.Heading.ToUpper(), Printerselect);
                                }
                               // vouchertyperetailDotmetrix6("ESTIMATE");
                            }
                        }
                    }
                    temp = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + SalesAccount + "'");
                    if (temp.ToUpper() == "ESTIMATE")
                    {
                        if (Printerselect == "3")
                        {
                            vouchertyperetailDotmetrix10("ESTIMATE");
                        }
                        if (Printerselect == "7")
                        {
                            PrintLaser("ESTIMATE", Printerselect);

                        }
                        if (Printerselect == "4")
                        {
                            vouchertyperetailDotmetrix6ThermalNew("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                        if (Printerselect == "2")
                        {
                            vouchertyperetailDotmetrix6("ESTIMATE");
                           // vouchertypewholesalesother();
                        }
                        if (Printerselect == "100")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalMarrymatha("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                    }
                    if (SalesAccount != "2" && temp.ToUpper() != "ESTIMATE"&&SalesAccount != "14")
                    {
                        if (Printerselect == "3")
                        {
                           // vouchertyperetailDotmetrix10BrandRoot("WHOLESALE INVOICE");
                         //  vouchertypewholesalesDotmetrix10("WHOLESALE INVOICE", "NO.8");
                            vouchertypewholesalesDotmetrix10steel("WHOLESALE INVOICE", "NO.8");
                        }

                        if (Printerselect == "2")
                        {
                            vouchertyperetailDotmetrix6("WHOLESALE Invoice");
                        }

                        if (Printerselect == "4")
                        {
                            vouchertypewholesalesother();
                        }
                        if (Printerselect == "7")
                        {
                            PrintLaser("WHOLESALE", Printerselect);
                        }
                    }
                }
                else
                {
                    if (Printerselect == "3")
                    {
                       // vouchertypewholesalesDotmetrix10("ESTIMATE", "");
                      // vouchertyperetailDotmetrix10("ESTIMATE");

                        /*For BrandRoot*/
                        if (Vtype == "SR" && NextGFuntion.IsinSalesReturn == true)
                        {
                            vouchertyperetailDotmetrix10BrandRootreturn("Sales Return");

                            this.Close();
                        }

                        else
                        {
                            if (ComTax.SelectedIndex == 0)
                            {
                                if (Vtype == "SI" || Vtype == "SQ" || Vtype == "SO")
                                {
                                    if (NextGFuntion.SalesReturnVno != "" && EditMode == true)
                                    {
                                        vouchertyperetailDotmetrix10BrandRootreturn("Sales Return");
                                    }
                                   vouchertyperetailDotmetrix10("ESTIMATE");

                                  // vouchertyperetailDotmetrix10BrandRoot("Sales Invoice");
                                }
                            }
                            else
                            {
                               // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");

                                 vouchertyperetailDotmetrix6("Retail Invoice");

                                // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");
                            }
                        }
                    }


                    if (Printerselect == "9")
                    {
                        if (SFlex == false)
                        {
                            vouchertyperetailDotmetrix6Temp("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                        else
                        {
                            string INV = this.Text.ToLower();
                            if (INV == "estimate")
                            {
                                Passing = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                                pno = "";
                            }
                            else if (INV == "wholesale")
                            {
                                Passing = "WHOLESALE INVOICE";
                                pno = "NO.8";
                            }
                            else if (INV == "sales")
                            {
                                Passing = "Sales Invoice";
                                pno = "NO.8B";
                            }
                            vouchertyperetailDotmetrix6TempFlex(Passing, pno);
                            vouchertypewholesalesother();
                        }
                    }
                    if (Printerselect == "10")/*For 3 Bill Print*/
                    {
                        if (STax == true)
                        {
                            RichTextBox1.Text = "";
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                    FormType = "Original";
                                if (i == 1)
                                    FormType = "Duplicate";
                                if (i == 2)
                                    FormType = "Triplicate";
                                vouchertypewholesalesDotmetrix10MultiPrinting("RETAIL INVOICE CASH/CREDIT", "NO.8B", FormType);
                            }
                            vouchertypewholesalesother();
                        }
                    }
                    
                }
            }
            //if (Preview == true)
            //PrintInvoice();
        }

        //new
        public void SaveTaxinvoiceHeader()
        {

            CommonClass.temp = ComTaxinvoice.Text;

            CommonClass._Dbtask.SetTaxinvoiceHeading(CommonClass.temp);

            CommonClass._Paramlist.UPDATEPARAMVALUE("printstyletype", _Dbtask.znllString(combtypeline.SelectedIndex));

        }
        public void LaserprintNine(string FormType)
        {
            _lasernine.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _lasernine.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _lasernine.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _lasernine.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _lasernine.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _lasernine.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _lasernine.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _lasernine.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _lasernine.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _lasernine.TempCust = comcustomerproject.Text;
                _lasernine.SProject = true;
            }
            else
            {
                _lasernine.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_lasernine.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _lasernine.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _lasernine.BillDate = dtdate.Value;
            _lasernine.Billno = txtvno.Text;
            _lasernine.TgrossAmt = TxttAmount.Text;
            _lasernine.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _lasernine.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _lasernine.TotalNetamount = NetTottal;
            _lasernine.FormType = FormType;
            _lasernine.Ttaxamount = txtttax.Text;
            _lasernine.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _lasernine.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);

                    
                        if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                        {


                            Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                        }
                        else
                        {
                            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                            Tvat = _Dbtask.znllString(TxtxTvat.Text);
                            Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                        }


                }


            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _lasernine.ModeofPayment = "Bank";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }
                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _lasernine.ModeofPayment = "CREDIT";
            }

            _lasernine.StrNaration = TxtNaration.textBox1.Text;
            _lasernine.SelPrint = ComPrintSheme.Text;



            _lasernine.Taddres = Taddres;

            _lasernine.Tvat = Tvat;
            _lasernine.Tmob = Tmob;
            _lasernine.Tename = Tnamee;
        
        
        }

        public void LaserprintNineNOTAX(string FormType)
        {

            //MEEMI
            _Notaxnine.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _Notaxnine.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Notaxnine.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Notaxnine.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Notaxnine.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Notaxnine.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Notaxnine.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Notaxnine.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Notaxnine.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Notaxnine.TempCust = comcustomerproject.Text;
                _Notaxnine.SProject = true;
            }
            else
            {
                _Notaxnine.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_lasernine.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _Notaxnine.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Notaxnine.BillDate = dtdate.Value;
            _Notaxnine.Billno = txtvno.Text;
            _Notaxnine.TgrossAmt = TxttAmount.Text;
            _Notaxnine.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Notaxnine.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Notaxnine.TotalNetamount = NetTottal;
            _Notaxnine.FormType = FormType;
            _Notaxnine.Ttaxamount = txtttax.Text;
            _Notaxnine.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _Notaxnine.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }

                }


            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _Notaxnine.ModeofPayment = "Bank";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }



                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _Notaxnine.ModeofPayment = "CREDIT";
            }

            _Notaxnine.StrNaration = TxtNaration.textBox1.Text;
            _Notaxnine.SelPrint = ComPrintSheme.Text;



            _Notaxnine.Taddres = Taddres;

            _Notaxnine.Tvat = Tvat;
            _Notaxnine.Tmob = Tmob;
            _Notaxnine.Tename = Tnamee;


        }

        //acha



        public void PrintLaserNineNOTAX(string FormType, string Pselect)
        {

            LaserprintNineNOTAX(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _Notaxnine.PSelect = Pselect;
            _Notaxnine.Plangwise = combtypeline.SelectedIndex;
            _Notaxnine.ModeofPayment = combprintmode.Text;


            // _Laser.STax = STax;
            _Notaxnine.PrintInvoice(gridmain);
        }


        public void PrintLaserNine(string FormType, string Pselect)
        {

            LaserprintNine(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _lasernine.PSelect = Pselect;
            _lasernine.Plangwise = combtypeline.SelectedIndex;

            _lasernine.ModeofPayment = combprintmode.Text;

            // _Laser.STax = STax;
            _lasernine.PrintInvoice(gridmain);
        }


        public void Laserprinteight(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _lasreight.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _lasreight.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _lasreight.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _lasreight.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _lasreight.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _lasreight.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _lasreight.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _lasreight.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _lasreight.TempCust = comcustomerproject.Text;
                _lasreight.SProject = true;
            }
            else
            {
                _lasreight.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _lasreight.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _lasreight.BillDate = dtdate.Value;
            _lasreight.Billno = txtvno.Text;
            _lasreight.TgrossAmt = TxttAmount.Text;
            _lasreight.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _lasreight.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _lasreight.TotalNetamount = NetTottal;
            _lasreight.FormType = FormType;
            _lasreight.Ttaxamount = txtttax.Text;
            _lasreight.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _lasreight.ModeofPayment = "CASH";
            if (commodeofpayment.SelectedIndex == 2)
                _lasreight.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _lasreight.ModeofPayment = "CREDIT";

            _lasreight.StrNaration = TxtNaration.textBox1.Text;

        }
        public void PrintLasereight(string FormType, string Pselect)
        {
            Laserprinteight(FormType);
            _lasreight.PSelect = Pselect;
            // _Laser.STax = STax;
            _lasreight.PrintInvoice(gridmain);
        }
        public void Laserprintseven(string FormType)
        {
            _lasewrseven.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _lasewrseven.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _lasewrseven.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _lasewrseven.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _lasewrseven.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _lasewrseven.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _lasewrseven.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _lasewrseven.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _lasewrseven.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _lasewrseven.TempCust = comcustomerproject.Text;
                _lasewrseven.SProject = true;
            }
            else
            {
                _lasewrseven.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_lasewrseven.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _lasewrseven.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _lasewrseven.BillDate = dtdate.Value;
            _lasewrseven.Billno = txtvno.Text;
            _lasewrseven.TgrossAmt = TxttAmount.Text;
            _lasewrseven.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _lasewrseven.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _lasewrseven.TotalNetamount = NetTottal;
            _lasewrseven.FormType = FormType;
            _lasewrseven.Ttaxamount = txtttax.Text;
            _lasewrseven.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _lasewrseven.ModeofPayment = "CASH";
                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _lasewrseven.ModeofPayment = "Bank";
                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }


                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _lasewrseven.ModeofPayment = "CREDIT";
            }

            _lasewrseven.StrNaration = TxtNaration.textBox1.Text;
            _lasewrseven.SelPrint = ComPrintSheme.Text;


            _lasewrseven.Taddres = Taddres;

            _lasewrseven.Tvat = Tvat;
            _lasewrseven.Tmob = Tmob;
            _lasewrseven.Tename = Tnamee;
        
        
        
        }
        public void PrintLaserseven(string FormType, string Pselect)
        {

            Laserprintseven(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _lasewrseven.PSelect = Pselect;

            _lasewrseven.Plangwise = combtypeline.SelectedIndex;

            _lasewrseven.ModeofPayment = combprintmode.Text;
            // _Laser.STax = STax;
            _lasewrseven.PrintInvoice(gridmain);
        }
        public void LaserprintQATArDN(string FormType)
        {

            _Qtrdn.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Qtrdn.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Qtrdn.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Qtrdn.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Qtrdn.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Qtrdn.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Qtrdn.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Qtrdn.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Qtrdn.TempCust = comcustomerproject.Text;
                _Qtrdn.SProject = true;
            }
            else
            {
                _Qtrdn.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Qtrdn.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _Qtrdn.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Qtrdn.BillDate = dtdate.Value;
            _Qtrdn.Billno = txtvno.Text;
            _Qtrdn.TgrossAmt = TxttAmount.Text;
            _Qtrdn.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Qtrdn.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Qtrdn.TotalNetamount = NetTottal;
            _Qtrdn.FormType = FormType;
            _Qtrdn.Ttaxamount = txtttax.Text;
            _Qtrdn.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _Qtrdn.ModeofPayment = "CASH";

            if (commodeofpayment.SelectedIndex == 2)
                _Qtrdn.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _Qtrdn.ModeofPayment = "CREDIT";

            _Qtrdn.StrNaration = TxtNaration.textBox1.Text;
            _Qtrdn.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _Qatarest.Taddres = Taddres;

            _Qtrdn.Tvat = Tvat;
            _Qtrdn.Tmob = Tmob;
            _Qtrdn.Tename = Tnamee;




        }
        public void LaserprintQATArEST(string FormType)
        {

            _Qatarest.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Qatarest.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Qatarest.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Qatarest.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Qatarest.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Qatarest.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Qatarest.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Qatarest.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Qatarest.TempCust = comcustomerproject.Text;
                _Qatarest.SProject = true;
            }
            else
            {
                _Qatarest.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Qatarest.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _Qatarest.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Qatarest.BillDate = dtdate.Value;
            _Qatarest.Billno = txtvno.Text;
            _Qatarest.TgrossAmt = TxttAmount.Text;
            _Qatarest.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Qatarest.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Qatarest.TotalNetamount = NetTottal;
            _Qatarest.FormType = FormType;
            _Qatarest.Ttaxamount = txtttax.Text;
            _Qatarest.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _Qatarest.ModeofPayment = "CASH";

            if (commodeofpayment.SelectedIndex == 2)
                _Qatarest.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _Qatarest.ModeofPayment = "CREDIT";

            _Qatarest.StrNaration = TxtNaration.textBox1.Text;
            _Qatarest.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _Qatarest.Taddres = Taddres;

            _Qatarest.Tvat = Tvat;
            _Qatarest.Tmob = Tmob;
            _Qatarest.Tename = Tnamee;




        }


        public void LaserprintQATAR(string FormType)
        {

            _qatar.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _qatar.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _qatar.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _qatar.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _qatar.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _qatar.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _qatar.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _qatar.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _qatar.TempCust = comcustomerproject.Text;
                _qatar.SProject = true;
            }
            else
            {
                _qatar.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _qatar.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _qatar.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _qatar.BillDate = dtdate.Value;
            _qatar.Billno = txtvno.Text;
            _qatar.TgrossAmt = TxttAmount.Text;
            _qatar.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _qatar.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _qatar.TotalNetamount = NetTottal;
            _qatar.FormType = FormType;
            _qatar.Ttaxamount = txtttax.Text;
            _qatar.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _qatar.ModeofPayment = "CASH";

            if (commodeofpayment.SelectedIndex == 2)
                _qatar.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _qatar.ModeofPayment = "CREDIT(الآجل)";

            _qatar.StrNaration = TxtNaration.textBox1.Text;
            _qatar.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _qatar.Taddres = Taddres;

            _qatar.Tvat = Tvat;
            _qatar.Tmob = Tmob;
            _qatar.Tename = Tnamee;




        }

        public void Laserprintsix(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _lasersix.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _lasersix.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _lasersix.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _lasersix.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _lasersix.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _lasersix.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _lasersix.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _lasersix.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _lasersix.TempCust = comcustomerproject.Text;
                _lasersix.SProject = true;
            }
            else
            {
                _lasersix.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
               // _lasersix.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _lasersix.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _lasersix.BillDate = dtdate.Value;
            _lasersix.Billno = txtvno.Text;
            _lasersix.TgrossAmt = TxttAmount.Text;
            _lasersix.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _lasersix.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _lasersix.TotalNetamount = NetTottal;
            _lasersix.FormType = FormType;
            _lasersix.Ttaxamount = txtttax.Text;
            _lasersix.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _lasersix.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);

                    
                        if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                        {


                            Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                        }

                        else
                        {
                            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                            Tvat = _Dbtask.znllString(TxtxTvat.Text);
                            Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                        }
                
                
                }


            }

            if (commodeofpayment.SelectedIndex == 2)
            {
                _lasersix.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }

                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _lasersix.ModeofPayment = "CREDIT(الآجل)";
            }

            _lasersix.StrNaration = TxtNaration.textBox1.Text;
            _lasersix.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _lasersix.Taddres = Taddres;

            _lasersix.Tvat = Tvat;
            _lasersix.Tmob = Tmob;
            _lasersix.Tename = Tnamee;




        }

        public void LaserprintA4NEW(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _Afournew.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Afournew.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Afournew.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Afournew.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Afournew.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Afournew.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Afournew.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Afournew.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Afournew.TempCust = comcustomerproject.Text;
                _Afournew.SProject = true;
            }
            else
            {
                _Afournew.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Afournew.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _Afournew.BillDate = dtdate.Value;
            _Afournew.Billno = txtvno.Text;
            _Afournew.TgrossAmt = TxttAmount.Text;
            _Afournew.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Afournew.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Afournew.TotalNetamount = NetTottal;
            _Afournew.FormType = FormType;
            _Afournew.Ttaxamount = txtttax.Text;
            _Afournew.TotalQty = txttqty.Text;

                if (commodeofpayment.SelectedIndex == 0)
                    _Afournew.ModeofPayment = "Cash";

            if (commodeofpayment.SelectedIndex == 2)
                _Afournew.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _Afournew.ModeofPayment = "Credit";

            _Afournew.billnote = _Dbtask.znllString(TxtNaration.textBox1.Text);
            _Afournew.SelPrint = Selectedprint;//ComPrintSheme.Text;

            //_Afournew.Taddres = Taddres;

            //_Afournew.Tvat = Tvat;
            //_Afournew.Tmob = Tmob;
            //_Afournew.Tename = Tnamee;

        
        
        
        }
        public void PrintLaserQATAR(string FormType, string Pselect)
        {


            if (FormType == "     SALES")
            {

            LaserprintQATAR(FormType);
           
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _qatar.PSelect = Pselect;
            // _Laser.STax = STax;
            _qatar.PrintInvoice(gridmain);
            }
            if (FormType == "     ESTIMATE")
            {

                LaserprintQATArEST(FormType);

                //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
                //Laserprintspecification(FormType);
                _Qatarest.PSelect = Pselect;
                // _Laser.STax = STax;
                _Qatarest.PrintInvoice(gridmain);
            }
            if (FormType == "     DELIVERY NOTE")
            {

                LaserprintQATArDN(FormType);

                //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
                //Laserprintspecification(FormType);
               _Qtrdn .PSelect = Pselect;
                // _Laser.STax = STax;
              _Qtrdn .PrintInvoice(gridmain);
            }






        }
        public void PrintLaserA4NEW(string FormType, string Pselect)
        {

            LaserprintA4NEW(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
           _Afournew.PSelect = Pselect;
            // _Laser.STax = STax;
            _Afournew.PrintInvoice(gridmain);
        }

        //achach

        public void ItemonlyNOTAXlaser(string FormType, string Pselect)
        {
            _namenotax.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _namenotax.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _namenotax.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _namenotax.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _namenotax.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _namenotax.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _namenotax.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _namenotax.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _namenotax.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            _namenotax.vehiname = _Dbtask.znllString(txtvehiname.Text);

            _namenotax.vehclenum = _Dbtask.znllString(txtxvehiclenum.Text);

            _namenotax.metrread = _Dbtask.znllString(txtmtrread.Text);
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _namenotax.TempCust = comcustomerproject.Text;
                _namenotax.SProject = true;
            }
            else
            {
                _namenotax.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                // _lasersix.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _namenotax.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _namenotax.BillDate = dtdate.Value;
            _namenotax.Billno = txtvno.Text;
            _namenotax.TgrossAmt = TxttAmount.Text;
            _namenotax.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _namenotax.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _namenotax.TotalNetamount = NetTottal;
            _namenotax.FormType = FormType;
            _namenotax.Ttaxamount = txtttax.Text;
            _namenotax.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _namenotax.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }
                    else
                    {

                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }




                }


            }

            if (commodeofpayment.SelectedIndex == 2)
            {
                _namenotax.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _namenotax.ModeofPayment = "CREDIT(الآجل)";
            }

            _namenotax.StrNaration = TxtNaration.textBox1.Text;
            _namenotax.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _namenotax.Taddres = Taddres;

            _namenotax.Tvat = Tvat;
            _namenotax.Tmob = Tmob;
            _namenotax.Tename = Tnamee;


            _namenotax.PSelect = Pselect;

            _namenotax.Plangwise = combtypeline.SelectedIndex;

            _namenotax.ModeofPayment = combprintmode.Text;

            // _Laser.STax = STax;
            _namenotax.PrintInvoice(gridmain);
        }


        public void WORKSHOPNOTAXLASER(string FormType, string Pselect)
        {
            _Notaxworkshop.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _Notaxworkshop.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Notaxworkshop.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Notaxworkshop.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Notaxworkshop.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Notaxworkshop.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Notaxworkshop.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Notaxworkshop.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Notaxworkshop.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            _Notaxworkshop.vehiname = _Dbtask.znllString(txtvehiname.Text);

            _Notaxworkshop.vehclenum = _Dbtask.znllString(txtxvehiclenum.Text);

            _Notaxworkshop.metrread = _Dbtask.znllString(txtmtrread.Text);
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Notaxworkshop.TempCust = comcustomerproject.Text;
                _Notaxworkshop.SProject = true;
            }
            else
            {
                _Notaxworkshop.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                // _lasersix.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _Notaxworkshop.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Notaxworkshop.BillDate = dtdate.Value;
            _Notaxworkshop.Billno = txtvno.Text;
            _Notaxworkshop.TgrossAmt = TxttAmount.Text;
            _Notaxworkshop.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Notaxworkshop.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Notaxworkshop.TotalNetamount = NetTottal;
            _Notaxworkshop.FormType = FormType;
            _Notaxworkshop.Ttaxamount = txtttax.Text;
            _Notaxworkshop.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _Notaxworkshop.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }




                }


            }

            if (commodeofpayment.SelectedIndex == 2)
            {
                _Notaxworkshop.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _Notaxworkshop.ModeofPayment = "CREDIT(الآجل)";
            }

            _Notaxworkshop.StrNaration = TxtNaration.textBox1.Text;
            _Notaxworkshop.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _Notaxworkshop.Taddres = Taddres;

            _Notaxworkshop.Tvat = Tvat;
            _Notaxworkshop.Tmob = Tmob;
            _Notaxworkshop.Tename = Tnamee;


            _Notaxworkshop.PSelect = Pselect;

            _Notaxworkshop.Plangwise = combtypeline.SelectedIndex;
            // _Laser.STax = STax;
            _Notaxworkshop.PrintInvoice(gridmain);
        }


        public void laserworkshop(string FormType, string Pselect)
        {

            _workshoplaser.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _workshoplaser.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _workshoplaser.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _workshoplaser.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _workshoplaser.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _workshoplaser.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _workshoplaser.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _workshoplaser.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _workshoplaser.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;


            _workshoplaser.vehiname = _Dbtask.znllString(txtvehiname.Text);

            _workshoplaser.vehclenum = _Dbtask.znllString(txtxvehiclenum.Text);
            _workshoplaser.metrread = _Dbtask.znllString(txtmtrread.Text);
   

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _workshoplaser.TempCust = comcustomerproject.Text;
                _workshoplaser.SProject = true;
            }
            else
            {
                _workshoplaser.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                // _lasersix.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _workshoplaser.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _workshoplaser.BillDate = dtdate.Value;
            _workshoplaser.Billno = txtvno.Text;
            _workshoplaser.TgrossAmt = TxttAmount.Text;
            _workshoplaser.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _workshoplaser.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _workshoplaser.TotalNetamount = NetTottal;
            _workshoplaser.FormType = FormType;
            _workshoplaser.Ttaxamount = txtttax.Text;
            _workshoplaser.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _workshoplaser.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }


            }

            if (commodeofpayment.SelectedIndex == 2)
            {
                _workshoplaser.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }



            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _workshoplaser.ModeofPayment = "CREDIT(الآجل)";
            }

            _workshoplaser.StrNaration = TxtNaration.textBox1.Text;
            _workshoplaser.SelPrint = Selectedprint;//ComPrintSheme.Text;

            _workshoplaser.Taddres = Taddres;

            _workshoplaser.Tvat = Tvat;
            _workshoplaser.Tmob = Tmob;
            _workshoplaser.Tename = Tnamee;


            _workshoplaser.PSelect = Pselect;

            _workshoplaser.Plangwise = combtypeline.SelectedIndex;
            // _Laser.STax = STax;
            _workshoplaser.PrintInvoice(gridmain);
        }
        public void PrintLasersix(string FormType, string Pselect)
        
        
        {

            Laserprintsix(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _lasersix.PSelect = Pselect;

            _lasersix.Plangwise = combtypeline.SelectedIndex;
            _lasersix.ModeofPayment = combprintmode.Text;

            // _Laser.STax = STax;
            _lasersix.PrintInvoice(gridmain);
        }
        public void PrintLaserfour(string FormType, string Pselect)
        {

            Laserprintfour(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _laserfour.PSelect = Pselect;
            // _Laser.STax = STax;
            _laserfour.PrintInvoice(gridmain);
        }
        public void Laserprintfour(string FormType)
        {

            _laserfour.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _laserfour.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _laserfour.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _laserfour.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _laserfour.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _laserfour.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _laserfour.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _laserfour.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _laserfour.TempCust = comcustomerproject.Text;
                _laserfour.SProject = true;
            }
            else
            {
                _laserfour.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _laserfour.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _laserfour.BillDate = dtdate.Value;
            _laserfour.Billno = txtvno.Text;
            _laserfour.TgrossAmt = TxttAmount.Text;
            _laserfour.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _laserfour.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _laserfour.TotalNetamount = NetTottal;
            _laserfour.FormType = FormType;
            _laserfour.Ttaxamount = txtttax.Text;
            _laserfour.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _laserfour.ModeofPayment = "CASH";
            if (commodeofpayment.SelectedIndex == 2)
                _laserfour.ModeofPayment = "Bank";
            if (commodeofpayment.SelectedIndex == 1)
                _laserfour.ModeofPayment = "CREDIT";

            _laserfour.StrNaration = TxtNaration.textBox1.Text;
            _laserfour.SelPrint = ComPrintSheme.Text;
        }

        public void PrintLaserfive(string FormType, string Pselect)
        {

            Laserprintfive(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _laserfive.PSelect = Pselect;

            _laserfive.pvnoval = _Dbtask.znllString(txtPVNO.Text);
            _laserfive.projctname = _Dbtask.znllString(txtproject.Text);
            _laserfive.ponum = _Dbtask.znllString(txtponum.Text);
            _laserfive.mrfprnum = _Dbtask.znllString(txtmrfprno.Text);
            _laserfive.deliverynot = _Dbtask.znllString(txtdeliverinot.Text);
            _laserfive.attention = _Dbtask.znllString(txtattention.Text);

            _laserfive.Plangwise = combtypeline.SelectedIndex;
            _laserfive.duedate = dtdue.Value.ToString("dd/MM/yyyy");
            // _Laser.STax = STax;
            _laserfive.PrintInvoice(gridmain);
        }
        public void LaserprintspecificationAFIVESecond(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            //_afive.PTYpe = FormType;

            //if (FormType == "POS")
            //{
            //    _afive.FormType = "SALES";
            //}
            ////_afive.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            ////_afive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            //// _afive.TDiscount = _Dbtask.znullDouble(Txtdiscount.Text);
            ////_afive.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            //_afive.TotalTaxable = _Dbtask.znullDouble(lbltgross.Text); ;
            //_afive.TotalTaxAmount = _Dbtask.znullDouble(Lblttax.Text);
            ////_afive.SSlnotracking = SSerialnotracking; ;
            ////Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");
            //_afive.TempCust = txtCustomer.Text;
            //_afive.Lid = _Dbtask.ExecuteScalar("select ledcodedr from tblbusinessissue where vno = '" + txtvno.Text.ToString() + "'").ToString();

            ////if (Ds2.Tables[0].Rows.Count > 0)
            ////{
            ////    _afive.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            ////}
            ////_afive.OldBalance = _Dbtask.znullDouble(Lblpartybalance.Text);
            //_afive.BillDate = dtdate.Value;
            //_afive.Billno = txtvno.Text;
            ////_afive.TgrossAmt = _Dbtask.znullDouble(lbltgross.Text); 
            //// _afive.Totherexpense = txtotherexpenses.Text;
            //_afive.BillAmount = _Dbtask.znullDouble(txttotal.Text).ToString();
            //_afive.TotalNetamount = _Dbtask.znullDouble(txttotal.Text);
            ////_afive.FormType = FormType;
            ////_afive.Ttaxamount = _Dbtask.znullDouble(Lblttax.Text);
            //_afive.ModeofPayment = compayment.Text;
            //_afive.tcashrecvd = recvd.ToString();
            //// _afive.TotalQty = txttqty.Text;

            ////if (commodeofpayment.SelectedIndex == 0)
            ////    _afive.ModeofPayment = "CASH";
            ////else
            ////_afive.ModeofPayment = "CREDIT";


            //_afive.StrNaration = TxtNarretion.Text;

        }

        public void PrintLaserAfivesecond(string FormType, string Pselect)
        {
            LaserprintspecificationAFIVESecond(FormType);
            _afive.PSelect = Pselect;

            //_afive.PrintInvoice(GridMain);
        }


        public void Laserprintfive(string FormType)
        {
            _laserfive.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _laserfive.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _laserfive.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _laserfive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _laserfive.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _laserfive.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _laserfive.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _laserfive.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _laserfive.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _laserfive.TempCust = comcustomerproject.Text;
                _laserfive.SProject = true;
            }
            else
            {
                _laserfive.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_laserfive.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _laserfive.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _laserfive.BillDate = dtdate.Value;
            _laserfive.Billno = txtvno.Text;
            _laserfive.TgrossAmt = TxttAmount.Text;
            _laserfive.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _laserfive.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _laserfive.TotalNetamount = NetTottal;
            _laserfive.FormType = FormType;
            _laserfive.Ttaxamount = txtttax.Text;
            _laserfive.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _laserfive.ModeofPayment = "CASH";

                if(_Dbtask.znllString(TxtAccount.Text)!="")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);

                    if(_Dbtask.znllString(Lbltemporarydetails.Tag)!="")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }


                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }



                }



            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _laserfive.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }



                }


            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _laserfive.ModeofPayment = "CREDIT";
            }


            _laserfive.Taddres = Taddres;

            _laserfive.Tvat = Tvat;
            _laserfive.Tmob = Tmob;
            _laserfive.Tename = Tnamee;

        

            _laserfive.StrNaration = TxtNaration.textBox1.Text;
            _laserfive.SelPrint = ComPrintSheme.Text;


            _laserfive.ModeofPayment = combprintmode.Text;


        }


        public void PrintLaserAfivesize(string FormType, string Pselect)
        {
            LaserprintspecificationAFIVE(FormType);
            _afive.PSelect = Pselect;

            _afive.PrintInvoice(gridmain);
        }
        public void LaserprintspecificationAFIVE(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _afive.PTYpe = FormType;
            _afive.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _afive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _afive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _afive.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _afive.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _afive.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _afive.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _afive.SSlnotracking = SSerialnotracking; ;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");
            _Laser.TempCust = TxtAccount.Text;
            _afive.Scndhead = ComTaxinvoice.Text;
            if (Ds2.Tables[0].Rows.Count > 0)
            {
               // _afive.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _afive.OldBalance = _Dbtask.znullDouble(Lblpartybalance.Text);
            _afive.BillDate = dtdate.Value;
            _afive.Billno = txtvno.Text;
            _afive.TgrossAmt = TxttAmount.Text;
            _afive.Totherexpense = txtotherexpenses.Text;
            _afive.BillAmount = txtbillamount.Text;
            _afive.TotalNetamount = NetTottal;
            _afive.FormType = FormType;
            _afive.Ttaxamount = txtttax.Text;
            _afive.TotalQty = txttqty.Text;
            _afive.Lid = _Dbtask.znllString(TxtAccount.Tag);
            if (commodeofpayment.SelectedIndex == 0)
            {
                _afive.ModeofPayment = "CASH";
                _afive.Lid = _Dbtask.znllString(TxtAccount.Tag);


                if(_Dbtask.znllString( TxtAccount.Text)!="")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text) + " (cash)"; ;
                }
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _afive.ModeofPayment = "CREDIT";
            }

            if (commodeofpayment.SelectedIndex == 2)
            {
                _afive.ModeofPayment = "Bank";
            }
              
            _afive.StrNaration = TxtNaration.textBox1.Text;
            _afive.Tename = Tnamee;
            _afive.Tmob = Tmob;
            _afive.Tvat = Tvat;
            _afive.Taddres = Taddres;


            _afive.vehicle = _Dbtask.znllString(txtxvehiclenum.Text);

            _afive.mtrread = _Dbtask.znllString(txtmtrread.Text);


            //  _afive.PTYpe = FormType;

            //  _afive.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            // _afive.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            //  _afive.TDiscount = _Dbtask.znullDouble(Txtdiscount.Text);
            // _afive.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            // _afive.TotalTaxable = _Dbtask.znullDouble(lbltgross.Text); ;
            // _afive.TotalTaxAmount = _Dbtask.znullDouble(Lblttax.Text);
            // _afive.SSlnotracking = SSerialnotracking; ;
            // Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");
            //_afive.TempCust = txtCustomer.Text;


            // if (Ds2.Tables[0].Rows.Count > 0)
            //  {
            //     _afive.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            // }
            // _afive.OldBalance = _Dbtask.znullDouble(Lblpartybalance.Text);
            //  _afive.BillDate = dtdate.Value;
            //  _afive.Billno = txtvno.Text;
            // _afive.TgrossAmt = _Dbtask.znullDouble(lbltgross.Text); 
            //   _afive.Totherexpense = txtotherexpenses.Text;
            //  _afive.BillAmount = _Dbtask.znullDouble(txttotal.Text).ToString();
            //  _afive.TotalNetamount = _Dbtask.znullDouble(txttotal.Text);
            //_afive.FormType = FormType;
            // _afive.Ttaxamount = _Dbtask.znullDouble(Lblttax.Text);
            // _afive.ModeofPayment = compayment.Text;

            //   _afive.TotalQty = txttqty.Text;

            // if (commodeofpayment.SelectedIndex == 0)
            //      _afive.ModeofPayment = "CASH";
            // else
            // _afive.ModeofPayment = "CREDIT";
            //  _afive.StrNaration = TxtNarretion.Text;

        }
        public void MainPrintSecond(bool Preview)
        {
            Printerselect = CommonClass._Dbtask.GetPrinterSelect();
            if (chkprintconfirmation.Checked == true)
            {
                Result = MessageBox.Show("Do You want to Print?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Result.ToString() == "Yes" || chkprintconfirmation.Checked == false)
            {

                PrintingInvoiceName = _Dotmetrix.PrintInvoiceHead(Vtype);
                AmountinWords = _Gen.Getmajorsymbol();
                string temp = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                Selectedprint = ComPrintSheme.Text;
                MyPrinter.PrinterName = Selectedprint;
                Clsinvlaser.SelPrint = Selectedprint;

                if (temp == "1" || temp == "-1")
                {
                    if (SalesAccount == "2" || SalesAccount == "14")
                    {
                        if (Printerselect == "1")
                        {
                            RichTextBox1.Font = new System.Drawing.Font("Consolas", 6);

                            if (Vtype == "SI")
                                vouchertyperetailDotmetrix4("Sales Invoices");
                            if (Vtype == "SR")
                                vouchertyperetailDotmetrix4("Sales Return");
                        }
                        if (Printerselect == "3")
                        {
                            if (STax == true)
                            {
                                vouchertypewholesalesDotmetrix10steel("RETAIL INVOICE", "NO.8 B");
                                vouchertypewholesalesother();

                                // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");
                            }
                            else
                            {
                                vouchertyperetailDotmetrix10("Sales Invoice");
                            }
                        }
                        if (Printerselect == "2")
                        {
                            if (STax == true)
                            {
                                vouchertyperetailDotmetrix6("Retail Invoice");
                            }
                            else
                            {
                                if (Vtype == "SI")

                                    vouchertyperetailDotmetrix6("ESTIMATE");
                                else if (Vtype == "SR")
                                    vouchertyperetailDotmetrix6("Sales return");

                            }
                        }
                        if (Printerselect == "4")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalNew("Sales Invoice");
                            // vouchertypewholesalesother();
                            Normal3PointLaser(Printerselect);

                        }
                        if (Printerselect == "100")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalMarrymatha("Sales Invoice");
                            vouchertypewholesalesother();
                        }

                        if (Printerselect == "DotMobile")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrixMobile("");
                        }
                        if (Printerselect == "3pointArabic")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalNew("Sales Invoice");
                            thermalarabthreepoint(Printerselect);
                            //PrintLaser3Point("SALES RETURN", Printerselect);
                        }

                        if (Printerselect == "7" || Printerselect == "14" || Printerselect == "11")/*For Mixed Dot6 and Wholesale Tax*/
                        {
                            if (STax == true)
                            {
                                if (this.Text == "Sales Return")
                                {
                                    PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                    //  PrintLaserthree("     " + this.Heading.ToUpper(), Printerselect);
                                }
                                else if (this.Text == "Delivery Note")
                                {
                                    PrintLaser("DELIVERY NOTE", Printerselect);
                                }
                                else
                                {

                                    if (this.Heading == "Sales Order")
                                    {
                                        temp = "     SALES ORDER";
                                    }
                                    else if (this.Heading.ToLower() == "sales quatation")
                                    {
                                        temp = "SALES QUATATION";
                                    }
                                    else if (this.Heading.ToLower() == "estimate")
                                    {
                                        temp = "  ESTIMATE";
                                    }
                                    else
                                    {
                                        temp = "    RETAIL";

                                        if (Printerselect == "7")
                                        {
                                            PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                        if (Printerselect == "14")
                                        {
                                            PrintLaserthree("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                        else
                                        {
                                            //PrintLaser1("     " + this.Heading.ToUpper(), Printerselect);
                                            PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                        }
                                    }
                                    // PrintLaser(temp, Printerselect);
                                }
                            }
                            else
                            {
                                if (Printerselect == "7")
                                {
                                    PrintLaser("     " + this.Heading.ToUpper(), Printerselect);
                                }

                                else
                                {
                                    PrintLaser1("     " + this.Heading.ToUpper(), Printerselect);
                                }
                                // vouchertyperetailDotmetrix6("ESTIMATE");
                            }
                        }
                    }
                    temp = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + SalesAccount + "'");
                    if (temp.ToUpper() == "ESTIMATE")
                    {
                        if (Printerselect == "3")
                        {
                            vouchertyperetailDotmetrix10("ESTIMATE");
                        }
                        if (Printerselect == "7")
                        {
                            PrintLaser("ESTIMATE", Printerselect);

                        }
                        if (Printerselect == "4")
                        {
                            vouchertyperetailDotmetrix6ThermalNew("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                        if (Printerselect == "2")
                        {
                            vouchertyperetailDotmetrix6("ESTIMATE");
                            // vouchertypewholesalesother();
                        }
                        if (Printerselect == "100")/*For Thermel Printing*/
                        {
                            vouchertyperetailDotmetrix6ThermalMarrymatha("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                    }
                    if (SalesAccount != "2" && temp.ToUpper() != "ESTIMATE" && SalesAccount != "14")
                    {
                        if (Printerselect == "3")
                        {
                            // vouchertyperetailDotmetrix10BrandRoot("WHOLESALE INVOICE");
                            //  vouchertypewholesalesDotmetrix10("WHOLESALE INVOICE", "NO.8");
                            vouchertypewholesalesDotmetrix10steel("WHOLESALE INVOICE", "NO.8");
                        }

                        if (Printerselect == "2")
                        {
                            vouchertyperetailDotmetrix6("WHOLESALE Invoice");
                        }

                        if (Printerselect == "4")
                        {
                            vouchertypewholesalesother();
                        }
                        if (Printerselect == "7")
                        {
                            PrintLaser("WHOLESALE", Printerselect);
                        }
                    }
                }
                else
                {
                    if (Printerselect == "3")
                    {
                        // vouchertypewholesalesDotmetrix10("ESTIMATE", "");
                        // vouchertyperetailDotmetrix10("ESTIMATE");

                        /*For BrandRoot*/
                        if (Vtype == "SR" && NextGFuntion.IsinSalesReturn == true)
                        {
                            vouchertyperetailDotmetrix10BrandRootreturn("Sales Return");

                            this.Close();
                        }

                        else
                        {
                            if (ComTax.SelectedIndex == 0)
                            {
                                if (Vtype == "SI" || Vtype == "SQ" || Vtype == "SO")
                                {
                                    if (NextGFuntion.SalesReturnVno != "" && EditMode == true)
                                    {
                                        vouchertyperetailDotmetrix10BrandRootreturn("Sales Return");
                                    }
                                    vouchertyperetailDotmetrix10("ESTIMATE");

                                    // vouchertyperetailDotmetrix10BrandRoot("Sales Invoice");
                                }
                            }
                            else
                            {
                                // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");

                                vouchertyperetailDotmetrix6("Retail Invoice");

                                // vouchertypewholesalesDotmetrix10("RETAIL INVOICE", "NO.8B");
                            }
                        }
                    }


                    if (Printerselect == "9")
                    {
                        if (SFlex == false)
                        {
                            vouchertyperetailDotmetrix6Temp("ESTIMATE");
                            vouchertypewholesalesother();
                        }
                        else
                        {
                            string INV = this.Text.ToLower();
                            if (INV == "estimate")
                            {
                                Passing = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                                pno = "";
                            }
                            else if (INV == "wholesale")
                            {
                                Passing = "WHOLESALE INVOICE";
                                pno = "NO.8";
                            }
                            else if (INV == "sales")
                            {
                                Passing = "Sales Invoice";
                                pno = "NO.8B";
                            }
                            vouchertyperetailDotmetrix6TempFlex(Passing, pno);
                            vouchertypewholesalesother();
                        }
                    }
                    if (Printerselect == "10")/*For 3 Bill Print*/
                    {
                        if (STax == true)
                        {
                            RichTextBox1.Text = "";
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                    FormType = "Original";
                                if (i == 1)
                                    FormType = "Duplicate";
                                if (i == 2)
                                    FormType = "Triplicate";
                                vouchertypewholesalesDotmetrix10MultiPrinting("RETAIL INVOICE CASH/CREDIT", "NO.8B", FormType);
                            }
                            vouchertypewholesalesother();
                        }
                    }

                }
            }
            //if (Preview == true)
            //    PrintInvoice();
        }

        public void thermalarabthreepointNOTAX(string Pselect)
        {

            _arabthermalnotax.PTYpe = this.Text;
            _arabthermalnotax.TempCust = TxtAccount.Text;
            _arabthermalnotax.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _arabthermalnotax.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _arabthermalnotax.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _arabthermalnotax.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _arabthermalnotax.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _arabthermalnotax.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _arabthermalnotax.SSlnotracking = SSerialnotracking;
            _arabthermalnotax.warrantyStr = txtwarrantyy.Text.ToString();
            _arabthermalnotax.saleNarration = TxtNaration.textBox1.Text.ToString();
            _arabthermalnotax.TDiscount = Txttypebilldiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_arabthermal.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _arabthermalnotax.paided = _Dbtask.znullDouble(txtpaid.textBox1.Text.ToString());
            _arabthermalnotax.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _arabthermalnotax.BillDate = dtdate.Value;
            _arabthermalnotax.Billno = txtvno.Text;
            _arabthermalnotax.TgrossAmt = TxttAmount.Text;
            _arabthermalnotax.Totherexpense = txtotherexpenses.Text;
            _arabthermalnotax.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _arabthermalnotax.TotalNetamount = NetTottal;
            _arabthermalnotax.FormType = this.Text;
            _arabthermalnotax.Ttaxamount = txtttax.Text;
            _arabthermalnotax.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
            {
                _arabthermalnotax.ModeofPayment = "CASH";
                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text);


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }
                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }



                }
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _arabthermalnotax.ModeofPayment = "CREDIT";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _arabthermalnotax.ModeofPayment = "Bank";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    //if (_Dbtask.znllString(txttempNames.Text) != "")
                    //{

                    //    Tnamee = _Dbtask.znllString(txttempNames.Text);
                       
                    //    //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    //}


                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }




                }


            }

            _arabthermalnotax.StrNaration = TxtNaration.textBox1.Text;
            _arabthermalnotax.billdiscounts = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);

            // Laserprintspecification3Point(FormType);
            _arabthermalnotax.PSelect = ComPrintSheme.Text; ;

            _arabthermalnotax.Taddres = Taddres;
            _arabthermalnotax.Tvat = Tvat;
            _arabthermalnotax.Tmob = Tmob;
            _arabthermalnotax.Tename = Tnamee;
            _arabthermalnotax.vehicle = _Dbtask.znllString(txtxvehiclenum.Text);
            _arabthermalnotax.mtrread = _Dbtask.znllString(txtmtrread.Text);
            _arabthermalnotax.extrapaymnt = FrmCashDesk.Otherpayamt;
            // _Laser.STax = STax;
            _arabthermalnotax.Scndhead = ComTaxinvoice.Text;
            _arabthermalnotax.PrintInvoice(gridmain);  
        }


        public void thermalarabthreepoint(string Pselect)
        {
           _arabthermal.PTYpe = this.Text;
           _arabthermal.TempCust = TxtAccount.Text;
         _arabthermal.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
           _arabthermal.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
          _arabthermal.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
          _arabthermal.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
          _arabthermal.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
         _arabthermal.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
          _arabthermal.SSlnotracking = SSerialnotracking;
          _arabthermal.warrantyStr = txtwarrantyy.Text.ToString();
          _arabthermal.saleNarration = TxtNaration.textBox1.Text.ToString();
         _arabthermal.TDiscount = Txttypebilldiscount.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
               //_arabthermal.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            _arabthermal.paided =_Dbtask.znullDouble( txtpaid.textBox1.Text.ToString());
            _arabthermal.Lid = _Dbtask.znllString(TxtAccount.Tag);
        _arabthermal.BillDate = dtdate.Value;
           _arabthermal.Billno = txtvno.Text;
          _arabthermal.TgrossAmt = TxttAmount.Text;
           _arabthermal.Totherexpense = txtotherexpenses.Text;
         _arabthermal.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
         _arabthermal.TotalNetamount = NetTottal;
         _arabthermal.FormType = this.Text;
       _arabthermal.Ttaxamount = txtttax.Text;
          _arabthermal.TotalQty = txttqty.Text;

          if (commodeofpayment.SelectedIndex == 0)
          {
              _arabthermal.ModeofPayment = "CASH";
              if(_Dbtask.znllString(TxtAccount.Text)!="")
              {
                  Tnamee = _Dbtask.znllString(TxtAccount.Text);

                 
                      if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                      {


                          Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                          Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                          Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                          Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                          //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                      }
                      else
                      {
                          Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                          Tvat = _Dbtask.znllString(TxtxTvat.Text);
                          Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                          Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                      }


              }
          }
          if (commodeofpayment.SelectedIndex == 1)
          {
              _arabthermal.ModeofPayment = "CREDIT";
          }
          if (commodeofpayment.SelectedIndex == 2)
          {
              _arabthermal.ModeofPayment = "Bank";

              if (_Dbtask.znllString(TxtAccount.Text) != "")
              {
                  if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                  {


                      Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                      Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                      Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                      Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                      //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                  }


                  else
                  {
                      Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                      Tvat = _Dbtask.znllString(TxtxTvat.Text);
                      Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                      Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                  }


              }


          }

          _arabthermal.StrNaration = TxtNaration.textBox1.Text;
          _arabthermal.billdiscounts = _Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text);

            // Laserprintspecification3Point(FormType);
           _arabthermal.PSelect = ComPrintSheme.Text; ;

           _arabthermal.Taddres = Taddres; 
           _arabthermal.Tvat = Tvat;
           _arabthermal.Tmob = Tmob;
           _arabthermal.Tename = Tnamee;
           _arabthermal.vehicle = _Dbtask.znllString(txtxvehiclenum.Text);
           _arabthermal.mtrread = _Dbtask.znllString(txtmtrread.Text);
           _arabthermal.extrapaymnt =FrmCashDesk.Otherpayamt;
            // _Laser.STax = STax;

           _arabthermal.ModeofPayment = combprintmode.Text;


           _arabthermal.Scndhead = ComTaxinvoice.Text;
        _arabthermal.PrintInvoice(gridmain);  

        }

        public void PrintLaserthree(string FormType, string Pselect)
        {

            Laserprintthree(FormType);
            //ClsinvlaserThree _laserthree = new ClsinvlaserThree();
            //Laserprintspecification(FormType);
            _laserthree.PSelect = Pselect;
            // _Laser.STax = STax;
            _laserthree.PrintInvoice(gridmain);
        }
        public void Laserprintthree(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _laserthree.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _laserthree.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _laserthree.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _laserthree.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _laserthree.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _laserthree.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _laserthree.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _laserthree.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _laserthree.TempCust = comcustomerproject.Text;
                _laserthree.SProject = true;
            }
            else
            {
                _laserthree.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _laserthree.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _laserthree.BillDate = dtdate.Value;
            _laserthree.Billno = txtvno.Text;
            _laserthree.TgrossAmt = TxttAmount.Text;
            _laserthree.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _laserthree.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _laserthree.TotalNetamount = NetTottal;
            _laserthree.FormType = FormType;
            _laserthree.Ttaxamount = txtttax.Text;
            _laserthree.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _laserthree.ModeofPayment = "CASH";
            else
                _laserthree.ModeofPayment = "CREDIT";

            _laserthree.StrNaration = TxtNaration.textBox1.Text;
            _laserthree.SelPrint = ComPrintSheme.Text;
        }
        public void PrintLaserred(string FormType, string Pselect)
        {

            //Laserprintspecifctnred(FormType);
            ////Laserprintspecification(FormType);
            //_lasred.PSelect = Pselect;
            //// _Laser.STax = STax;
            //_lasred.PrintInvoice(gridmain);
        }

        public void Normal3PointLaserNOTAX(string Pselect)
        {
            //string printtype = CommonClass._Dbtask.SetPrinterSelect(Printerselect);


            _ThermalNOTAX.PTYpe = this.Text;
            _ThermalNOTAX.TempCust = TxtAccount.Text;
            _ThermalNOTAX.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _ThermalNOTAX.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _ThermalNOTAX.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _ThermalNOTAX.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _ThermalNOTAX.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _ThermalNOTAX.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _ThermalNOTAX.SSlnotracking = SSerialnotracking;
            _ThermalNOTAX.warrantyStr = txtwarrantyy.Text.ToString();
            _ThermalNOTAX.saleNarration = TxtNaration.textBox1.Text.ToString();
            _ThermalNOTAX.TDiscount = Txttypebilldiscount.textBox1.Text;
            _ThermalNOTAX.SitemNote = Enableitemnote;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                // _Thermal.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _ThermalNOTAX.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _ThermalNOTAX.BillDate = dtdate.Value;
            _ThermalNOTAX.Billno = txtvno.Text;
            _ThermalNOTAX.TgrossAmt = TxttAmount.Text;
            _ThermalNOTAX.Totherexpense = Txttypecooly.textBox1.Text;
            _ThermalNOTAX.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _ThermalNOTAX.TotalNetamount = NetTottal;
            _ThermalNOTAX.FormType = this.Text;
            _ThermalNOTAX.Ttaxamount = txtttax.Text;
            _ThermalNOTAX.TotalQty = txttqty.Text;
            _ThermalNOTAX.Bunit = BUNIT;
            if (commodeofpayment.SelectedIndex == 0)
            {
                _ThermalNOTAX.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text) + "(cash)";

                    if (_Dbtask.znllString(TxtAccount.Text) != "")
                    {
                        if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                        {


                            Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                        }

                        else
                        {
                            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                            Tvat = _Dbtask.znllString(TxtxTvat.Text);
                            Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                        }
                    }



                }
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _ThermalNOTAX.ModeofPayment = "CREDIT";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {

                _ThermalNOTAX.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }

                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }




            }

            _ThermalNOTAX.StrNaration = TxtNaration.textBox1.Text;

            _ThermalNOTAX.Taddres = Taddres;
            _ThermalNOTAX.cashrecvd = CashReceivedTxt;
            _ThermalNOTAX.Tvat = Tvat;
            _ThermalNOTAX.Tmob = Tmob;
            _ThermalNOTAX.Tename = Tnamee;
            _ThermalNOTAX.vehicle = _Dbtask.znllString(txtxvehiclenum.Text);
            _ThermalNOTAX.mtrread = _Dbtask.znllString(txtmtrread.Text);
            _ThermalNOTAX.extrapaymnt = _Dbtask.znllString(FrmCashDesk.Otherpayamt);
            _ThermalNOTAX.extrapymntype = _Dbtask.znllString(FrmCashDesk.secndpaymode);
            _ThermalNOTAX.deskbalnc = _Dbtask.znllString(FrmCashDesk.Balance);
            // Laserprintspecification3Point(FormType);
            if (_Dbtask.znlldoubletoobject(CashReceivedTxt) == _Dbtask.znullDouble(txtbillamount.Text))
            {
                _ThermalNOTAX.deskbalnc = "";
            }



            _ThermalNOTAX.PSelect = ComPrintSheme.Text; ;
            // _Laser.STax = STax;


            _ThermalNOTAX.secondheading = ComTaxinvoice.Text;

            _ThermalNOTAX.PrintInvoice(gridmain);
        }





        public void Normal3PointLaser(string Pselect)
        {
            //string printtype = CommonClass._Dbtask.SetPrinterSelect(Printerselect);


            _Thermal.PTYpe = this.Text;
            _Thermal.TempCust = TxtAccount.Text;
            _Thermal.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Thermal.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Thermal.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Thermal.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Thermal.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Thermal.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Thermal.SSlnotracking = SSerialnotracking;
            _Thermal.warrantyStr = txtwarrantyy.Text.ToString();
            _Thermal.saleNarration = TxtNaration.textBox1.Text.ToString();
            _Thermal.TDiscount = Txttypebilldiscount.textBox1.Text;
            _Thermal.SitemNote = Enableitemnote;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
               // _Thermal.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _Thermal.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _Thermal.BillDate = dtdate.Value;
            _Thermal.Billno = txtvno.Text;
            _Thermal.TgrossAmt = TxttAmount.Text;
            _Thermal.Totherexpense = Txttypecooly.textBox1.Text;
            _Thermal.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _Thermal.TotalNetamount = NetTottal;
            _Thermal.FormType = this.Text;
            _Thermal.Ttaxamount = txtttax.Text;
            _Thermal.TotalQty = txttqty.Text;
            _Thermal.Bunit = BUNIT;
            if (commodeofpayment.SelectedIndex == 0)
            {
                _Thermal.ModeofPayment = "CASH";

                if(_Dbtask.znllString(TxtAccount.Text)!="")
                {

                    if (Tnamee=="")
                    {

                    Tnamee = _Dbtask.znllString(TxtAccount.Text)  + "(cash)";
                    }

                    if (_Dbtask.znllString(TxtAccount.Text) != "")
                    {
                        if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                        {


                            Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                            Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                            //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                        }


                        else
                        {
                            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                            Tvat = _Dbtask.znllString(TxtxTvat.Text);
                            Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                        }


                    }
                
                
                
                }
            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _Thermal.ModeofPayment = "CREDIT";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {

                _Thermal.ModeofPayment = "Bank";


                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {


                        Taddres = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("ADDRESS", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        Tvat = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("TAXREGNO", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tmob = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("MOBILE", _Dbtask.znllString(Lbltemporarydetails.Tag)));
                        Tnamee = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", _Dbtask.znllString(Lbltemporarydetails.Tag)));

                        //_laserfive.Lid = _Dbtask.znllString(Lbltemporarydetails.Tag);
                    }


                    else
                    {
                        Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);

                        Tvat = _Dbtask.znllString(TxtxTvat.Text);
                        Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                        Tnamee = _Dbtask.znllString(TxtTcustmr.Text);

                    }


                }




            }

            _Thermal.StrNaration = TxtNaration.textBox1.Text;

            _Thermal.Taddres = Taddres;
            _Thermal.cashrecvd = CashReceivedTxt; 
            _Thermal.Tvat = Tvat;
            _Thermal.Tmob = Tmob;
            _Thermal.Tename = Tnamee;
            _Thermal.vehicle = _Dbtask.znllString(txtxvehiclenum.Text);
            _Thermal.mtrread = _Dbtask.znllString(txtmtrread.Text);
            _Thermal.extrapaymnt = _Dbtask.znllString(  FrmCashDesk.Otherpayamt);
            _Thermal.extrapymntype = _Dbtask.znllString(FrmCashDesk.secndpaymode);
            _Thermal.deskbalnc = _Dbtask.znllString(FrmCashDesk.Balance);
            // Laserprintspecification3Point(FormType);
            if (_Dbtask.znlldoubletoobject(CashReceivedTxt) == _Dbtask.znullDouble(txtbillamount.Text))
            {
                _Thermal.deskbalnc = "";
            }



            _Thermal.PSelect = ComPrintSheme.Text; ;
            // _Laser.STax = STax;


            _Thermal.secondheading = ComTaxinvoice.Text;
            _Thermal.ModeofPayment = combprintmode.Text;
            _Thermal.PrintInvoice(gridmain);
        }

        public void Normal2InchThermal(string Pselect)
        {
            //string printtype = CommonClass._Dbtask.SetPrinterSelect(Printerselect);


            _ThermalTwoInch.PTYpe = this.Text;
            _ThermalTwoInch.TempCust = TxtAccount.Text;
            _ThermalTwoInch.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _ThermalTwoInch.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _ThermalTwoInch.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _ThermalTwoInch.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _ThermalTwoInch.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _ThermalTwoInch.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _ThermalTwoInch.SSlnotracking = SSerialnotracking;
            _ThermalTwoInch.warrantyStr = txtwarrantyy.Text.ToString();
            _ThermalTwoInch.saleNarration = TxtNaration.textBox1.Text.ToString();
            _ThermalTwoInch.TDiscount = Txttypebilldiscount.textBox1.Text;
            _ThermalTwoInch.SitemNote = Enableitemnote;
            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                //_Thermal.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }

            _ThermalTwoInch.Lid = _Dbtask.znllString(TxtAccount.Tag);
            _ThermalTwoInch.BillDate = dtdate.Value;
            _ThermalTwoInch.Billno = txtvno.Text;
            _ThermalTwoInch.TgrossAmt = TxttAmount.Text;
            _ThermalTwoInch.Totherexpense = txtotherexpenses.Text;
            _ThermalTwoInch.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString("0.00");
            _ThermalTwoInch.TotalNetamount = NetTottal;
            _ThermalTwoInch.FormType = this.Text;
            _ThermalTwoInch.Ttaxamount = txtttax.Text;
            _ThermalTwoInch.TotalQty = txttqty.Text;
            _ThermalTwoInch.Bunit = BUNIT;
            if (commodeofpayment.SelectedIndex == 0)
            {
                _ThermalTwoInch.ModeofPayment = "CASH";

                if (_Dbtask.znllString(TxtAccount.Text) != "")
                {
                    Tnamee = _Dbtask.znllString(TxtAccount.Text) + "(cash)";
                }

            }
            if (commodeofpayment.SelectedIndex == 1)
            {
                _ThermalTwoInch.ModeofPayment = "Credit";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                _ThermalTwoInch.ModeofPayment = "Bank";
            }

            _ThermalTwoInch.headsett= ComTaxinvoice.Text;
            _ThermalTwoInch.StrNaration = TxtNaration.textBox1.Text;


            // Laserprintspecification3Point(FormType);
            _ThermalTwoInch.PSelect = ComPrintSheme.Text; ;
            // _Laser.STax = STax;
            _ThermalTwoInch.PrintInvoice(gridmain);
        }
        public void vouchertyperetailDotmetrix6ThermalNew(string Invoicename)
        {
            //string StrVno = txtvno.Text;
            //string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            //string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            //string Address = temp;
            //string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            //string RuleSeco = "[See rule 58(10)]".PadLeft(25);
            //string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            //string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
            //Datestr = "                      " + Datestr;
            //StrTime = "                      " + StrTime;
            //string LineHeading = "=".PadRight(40, '=');
            //string LineAbowAmount = "-".PadRight(40, '-');
            //string LineFooter = "=".PadRight(40, '=');
            //string Slno = "Sl ".PadRight(4, ' ');
            //string Pname = "Product".PadRight(15, ' ');
            //string TsQty = "Qty".PadLeft(5, ' ');
            //string TsRate = "Rate".PadLeft(8, ' ');
            //string TsAmount = "Amount".PadLeft(8, ' ');
            //string TAmountstr = "Amount".PadLeft(8, ' ');
            //string TTQty;
            //string TTAmount;

            //string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            //if (CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToUpper() == "ESTIMATE")
            //    RichTextBox1.Text = "\n\n" + "\nNo :" + StrVno + "" + "\n" + Datestr + " \n" + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            //else
            //    RichTextBox1.Text = "\n\n" + Address + "\n" + "" + Mobile + "\n" + TIN + "\nNo :" + StrVno + "" + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            //double TRate = 0;
            //double TQty = 0;
            //double TAmount = 0;

            //RowValidation();
            //Countrow = 0;
            //YY1 = 0;
            //for (int i = 0; i < gridmain.Rows.Count; i++)
            //{
            //    if (gridmain.Rows[i].Tag != null)
            //    {
            //        if (gridmain.Rows[i].Tag.ToString() == "1")
            //        {
            //            YY1 = YY1 + 11;

            //            double Unitqty = 0;
            //            double ssRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
            //            if (SUnit == true)
            //            {
            //                Munit = Convert.ToInt16(_Dbtask.gridnul(gridmain.Rows[i].Cells["Clnunit"].Tag));
            //                Unitid = Munit.ToString();
            //                UnitName = CommonClass._Unitcreation.Getspesificfield("name", Munit.ToString());
            //                ItemId = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
            //                // UnitAmountCalc();
            //                // Unitqty = Convrt * qty;
            //                ssRate = _Dbtask.znullDouble(_ItemMaster.SpecificField(ItemId, "srate"));
            //            }


            //            TsRate = (ssRate).ToString("0.0");

            //            Slno = TsRate.PadLeft(4, ' ');

            //            if (CommonClass._Menusettings.GetMnustatus("161") == "1")
            //            {
            //                Pname = _ItemMaster.SpecificField(gridmain.Rows[i].Cells["clnitemname"].Tag.ToString(), "llang");
            //            }
            //            else
            //            {
            //                Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
            //            }
            //            Pname = Pname.PadRight(35, ' ');
            //            if (Pname.Length > 35)
            //                Pname = Pname.Substring(0, 35);
            //            UnitName = UnitName.PadRight(20, ' ');
            //            UnitName = UnitName.Substring(0, 20);
            //            double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
            //            TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
            //            TsQty = TsQty.PadLeft(5, ' ');

            //            double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
            //            TsRate = _Dbtask.SetintoDecimalpoint(sRate);
            //            TsRate = TsRate.PadLeft(8, ' ');

            //            double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
            //            TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
            //            TsAmount = TsAmount.PadLeft(8, ' ');

            //            TQty = TQty + sQty;
            //            TRate = TRate + sRate;
            //            TAmount = TAmount + sAmount;

            //            string TSamount = TAmount.ToString();

            //            RichTextBox1.Text = RichTextBox1.Text + "\n\n" + Slno + Pname + "\n\n" + UnitName + TsQty + TsRate + TsAmount;
            //            Countrow++;
            //        }
            //    }
            //}
            //TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            //TTQty = TTQty.PadLeft(24, ' ');

            //TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            //TTAmount = TTAmount.PadLeft(16, ' ');
            //AmountInWords _word = new AmountInWords();
            //BillAmount = _Dbtask.znullDouble(txtbillamount.Text);
            //AmountinWords = AmountinWords + " " + _word.ConvertAmount(BillAmount);
            //if (AmountinWords.Length > 30)
            //    AmountinWords = AmountinWords.Substring(0, 30) + "\n\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);

            //string StrBillClerck = "Customer Sign               BILL CLERCK";
            //currentbalance = 0;
            //OldBalance = 0;
            //string Visitagain = "        ***THANK YOU, VISIT AGAIN***";
            //double DbSavedAmt = NetMrp - NetSrate;
            //string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            //string strTaxamt = txtttax.Text;
            //if (DbSavedAmt > 0)
            //{
            //    SavedAmount = _Dbtask.SetintoDecimalpoint(DbSavedAmt);
            //}
            //string ItemDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxttItemDiscount.Text));
            //RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
            //       LineAbowAmount +
            //      "\n" + TTQty + TTAmount + "\n" + LineFooter;

            //currentbalance = 0;
            //OldBalance = 0;


            //if (commodeofpayment.SelectedIndex == 1)
            //{
            //    string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
            //    string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
            //    OldBalance = Convert.ToDouble(tempp);
            //    double BillAmt = TBillAmount;
            //    OldBalance = OldBalance - BillAmt;
            //    currentbalance = OldBalance + BillAmt;
            //}
            //else if (TxtAccount.Text != "")
            //{
            //    string Accountid = _Dbtask.ExecuteScalar("select isnull(lid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
            //    string Groupid = _Dbtask.ExecuteScalar("select isnull(agroupid,0) from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
            //    if (Accountid != "" && Groupid != "25" && Groupid != "")
            //    {
            //        string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
            //        OldBalance = Convert.ToDouble(tempp);
            //        double BillAmt = TBillAmount;
            //        currentbalance = OldBalance;
            //    }
            //}

            //string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            //string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            //string TaxAmt = txtttax.Text;
            //string Pfooter;

            //Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");

            //if (STax == true && ComTax.SelectedIndex != 0)
            //{
            //    RichTextBox1.Text = RichTextBox1.Text + "\n             TAX Amount    :" + TaxAmt.PadLeft(12, ' ');
            //}
            ////if (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) > 0)
            ////{
            ////    RichTextBox1.Text = RichTextBox1.Text + "\n                    Discount :" + BiilDiscount.PadLeft(10, ' ');
            ////}
            ////if (Convert.ToDouble(TxttItemDiscount.Text) > 0)
            ////{
            ////    RichTextBox1.Text = RichTextBox1.Text + "\n             Item Discount :" + ItemDiscount.PadLeft(12, ' ') + "\n              Total         :" + txtbillamount.Text.PadLeft(12, ' ');
            ////}

            //RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\nIn Words:" + AmountinWords + "\n\n";




            //if (Pfooter == "")
            //{
            //    RichTextBox1.Text = RichTextBox1.Text + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            //}
            //else
            //{
            //    RichTextBox1.Text = RichTextBox1.Text + "\n*No exchange without bill" + "\n*Exchange will made within 3 days" + "\n" + Pfooter + "\n\n" + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            //}
            string StrVno = txtvno.Text;
            string TIN = "VAT No:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string RuleSeco = "[See rule 58(10)]".PadLeft(25);
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
            Datestr = "                      " + Datestr;
            StrTime = "                      " + StrTime;
            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;

            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            if (CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToUpper() == "ESTIMATE")
                RichTextBox1.Text = "\n\n" + "\nNo :" + StrVno + "" + "\n" + Datestr + " \n" + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            else
                RichTextBox1.Text = "No :" + StrVno + "" + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;

            RowValidation();
            Countrow = 0;
            YY1 = 0;
            DetectLanguage();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        YY1 = YY1 + 11;
                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(4, ' ');
                        ItemId = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();
                        // Pname = CommonClass._Itemmaster.SpecificField(ItemId,"llang");
                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(15, ' ');
                        if (Pname.Length > 15)
                            Pname = Pname.Substring(0, 15);
                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(8, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        if (CommonClass._Itemmaster.SpecificField(ItemId, "llang") == "")
                        {
                            RichTextBox1.Text = RichTextBox1.Text + "\n     " +Slno+ Pname;
                        }
                        else
                        {
                            RichTextBox1.Text = RichTextBox1.Text + "\n\n" +Slno+"   "+CommonClass._Itemmaster.SpecificField(ItemId, "llang");
                            Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                            RichTextBox1.Text = RichTextBox1.Text + "\n    " + Pname;
                        }
                        //   Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (IsArabic == true || CommonClass._Itemmaster.SpecificField(ItemId, "llang") == "")
                        {
                            RichTextBox1.Text = RichTextBox1.Text + "\n" + "    " + "               " + TsQty + TsRate + TsAmount +
                                  "\n  " + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value).ToString() + ":بدون ضريبة‎  " +
                                 _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntax"].Value).ToString() + ":(" +
                                _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClntaxPer"].Value).ToString("0") + "%)" + "ضريبة ";
                        }
                        else
                        {

                            RichTextBox1.Text = RichTextBox1.Text + "\n" + "    " + "               " + TsQty + TsRate + TsAmount +
                            "\n  " + _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClnGross"].Value).ToString() + ":بدون ضريبة‎     " +

                                 _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clntax"].Value).ToString() + ":(" +
                                _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["ClntaxPer"].Value).ToString("0") + "%)" + "ضريبة ";
                        }
                        Countrow++;
                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(24, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(16, ' ');
            AmountInWords _word = new AmountInWords();
            BillAmount = _Dbtask.znullDouble(txtbillamount.Text);
            AmountinWords = "";
            AmountinWords = AmountinWords + " " + _word.ConvertAmount(BillAmount);
            if (AmountinWords.Length > 30)
                AmountinWords = AmountinWords.Substring(0, 30) + "\n\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);

            string StrBillClerck = "Customer Sign               BILL CLERCK";
            currentbalance = 0;
            OldBalance = 0;
            string Visitagain = "        ***  شكرا لك زيارة مرة أخرى   ***";
            double DbSavedAmt = NetMrp - NetSrate;
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            string strTaxamt = txtttax.Text;
            if (DbSavedAmt > 0)
            {
                SavedAmount = _Dbtask.SetintoDecimalpoint(DbSavedAmt);
            }
            string ItemDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxttItemDiscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount;

            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {
                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = TBillAmount;
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
                    double BillAmt = TBillAmount;
                    currentbalance = OldBalance;
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string TaxAmt = txtttax.Text;
            string Pfooter;
            string StrAmount;
            StrAmount = (_Dbtask.znlldoubletoobject(txtbillamount.Text) + _Dbtask.znlldoubletoobject(Txttypebilldiscount.textBox1.Text)).ToString("0.00");
            Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");
            if (_Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text) > 0)
            {
                if (STax == true && ComTax.SelectedIndex != 0)
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n     " + TaxAmt + ": (5%) ضريبة القيمة المضافة ";
                    //  RichTextBox1.Text = RichTextBox1.Text + "\n             TAX Total     :" + TaxAmt.PadLeft(12, ' ') ;
                    RichTextBox1.Text = RichTextBox1.Text + "\n\n           Total Qty       :" + txttqty.Text.PadLeft(12, ' ');

                    RichTextBox1.Text = RichTextBox1.Text + "\n           Total Amount    :" + StrAmount.PadLeft(12, ' ');
                    RichTextBox1.Text = RichTextBox1.Text + "\n           Cash discount   :" + _Dbtask.znlldoubletoobject(Txttypebilldiscount.textBox1.Text).ToString("0.00").PadLeft(12, ' ');
                    RichTextBox1.Text = RichTextBox1.Text + "\n           Grand Total     :" + _Dbtask.znlldoubletoobject(txtbillamount.Text).ToString("0.00").PadLeft(12, ' ');

                    RichTextBox1.Text = RichTextBox1.Text + "\n\n " + CashReceivedTxt.PadLeft(12, ' ');
                }

            }
            else
            {
                if (STax == true && ComTax.SelectedIndex != 0)
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n     " + TaxAmt + ": (5%) ضريبة القيمة المضافة ";
                    //  RichTextBox1.Text = RichTextBox1.Text + "\n             TAX Total     :" + TaxAmt.PadLeft(12, ' ') ;
                    RichTextBox1.Text = RichTextBox1.Text + "\n\n             Grand Total   :" + txtbillamount.Text.PadLeft(12, ' ');
                    RichTextBox1.Text = RichTextBox1.Text + "\n\n " + CashReceivedTxt.PadLeft(12, ' ');
                }
            }
            //if (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) > 0)
            //{
            //    RichTextBox1.Text = RichTextBox1.Text + "\n                    Discount :" + BiilDiscount.PadLeft(10, ' ');
            //}
            //if (Convert.ToDouble(TxttItemDiscount.Text) > 0)
            //{
            //    RichTextBox1.Text = RichTextBox1.Text + "\n             Item Discount :" + ItemDiscount.PadLeft(12, ' ') + "\n              Total         :" + txtbillamount.Text.PadLeft(12, ' ');
            //}

            RichTextBox1.Text = RichTextBox1.Text + "\n\nIn Words:" + AmountinWords + "\n\n";




            if (Pfooter == "")
            {
                RichTextBox1.Text = RichTextBox1.Text + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            }
            else
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n*No exchange without bill" + "\n*Exchange will made within 3 days" + "\n" + Pfooter + "\n\n" + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            }
        }
        public void vouchertyperetailDotmetrix6Thermal(string Invoicename)
        {
            string StrVno = txtvno.Text;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string RuleSeco = "[See rule 58(10)]".PadLeft(25);
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            string StrTime = "Time : " + dtdate.Value.ToString("hh/mm/ss");
            Datestr = "                      " + Datestr;
            StrTime = "                      " + StrTime;
            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');

            string TTQty;
            string TTAmount;

            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

            RichTextBox1.Text = "\n\n\n" + Address + "\n" + "" + Mobile + "\nNo :" + StrVno + "" + "\nCustomer:" + Cusnam + "\n" + Datestr + " \n" + StrTime + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            double TRate = 0;
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
                        Slno = Slno.PadRight(4, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(15, ' ');
                        if (Pname.Length > 15)
                            Pname = Pname.Substring(0, 15);
                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(8, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(24, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(16, ' ');
            AmountInWords _word = new AmountInWords();

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            if (AmountinWords.Length > 30)
                AmountinWords = AmountinWords.Substring(0, 30) + "\n" + AmountinWords.Substring(30, AmountinWords.Length - 30);

            string StrBillClerck = "Customer Sign               BILL CLERCK";
            currentbalance = 0;
            OldBalance = 0;
            string Visitagain = "        ***THANK YOU, VISIT AGAIN***";
            double DbSavedAmt = NetMrp - NetSrate;
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            string strTaxamt = txtttax.Text;
            if (DbSavedAmt > 0)
            {
                SavedAmount = _Dbtask.SetintoDecimalpoint(DbSavedAmt);
            }
            string ItemDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxttItemDiscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter;

            string Cooly = txtotherexpenses.Text;
            RichTextBox1.Text = RichTextBox1.Text + "\n\nIn Words: " + AmountinWords + "\n\n\n" + StrBillClerck + "\n\n\n" + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";

        }

        public void PrintSizes(string Invoicename)
        {
            Clssizes _Size = new Clssizes();
            Ds = _Size.ShowSizes();

            string StrVno = txtvno.Text;
            string Taxruletext;
            if (SalesAccount == "2")
            {
                Taxruletext = ("           THE KERALA VALUE ADDED TAX RULES, 2005FORM 8B, [See rule 58(10)]").PadLeft(40, ' ');
            }
            else
            {
                Taxruletext = ("           THE KERALA VALUE ADDED TAX RULES, 2005FORM 8, [See rule 58(10)]").PadLeft(40, ' ');
            }
            if (Vtype == "SR")
            {
                Taxruletext = ("           THE KERALA VALUE ADDED TAX RULES, 2005FORM 9, [See rule 58(10)]").PadLeft(40, ' ');
                
            }
            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");

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

            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lid='" + TxtAccount.Tag + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lid='" + TxtAccount.Tag + "'");
            string CusMob = _Dbtask.ExecuteScalar("select mobile from tblaccountledger where lname='" + TxtAccount.Tag + "'");
            if (PInvoiceName == "                           Sales Invoice")
            {
                RichTextBox1.Text = "" + TIN + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\n" + Datestr + "\n" + StrVno + "\n" + "Customer  :" + Custname + "\nAddress   :" + CusAddress + "\n" + "Mobile    :" + CusMob + "\n" + "TIN       :" + CusTinno + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
           else if (Vtype == "SR")
            {
                RichTextBox1.Text = "" + TIN + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\n"+PInvoiceName + "\n\n" + Datestr + "\n" + StrVno + "\n" + "Customer  :" + Custname + "\nAddress   :" + CusAddress + "\n" + "Mobile    :" + CusMob + "\n" + "TIN       :" + CusTinno + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "" + TIN + "         " + CompanyName + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\n\n\n\nCustomer  :" + Custname + "\nAddress   :\n" + "Mobile    :\n" + "TIN        :\n" + Slno + Pname + TsQty + TsRate + TAmountstr + SizeNaration + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            RowValidation();
            ClearSizeInisilise();
            M = 0;
            for (int i = M; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null && TRowCounting < 24)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        string Itemcode = gridmain.Rows[i].Cells["clnitemname"].Tag.ToString();

                        SizeInitilizePrinting(i);

                        /*For Get Size Less Id*/
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

            AmountinWords = _word.ConvertAmount(TBillAmount);
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
            string TaxAmt = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txtttax.Text));
            string TaxableAmt = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxtTGross.Text));
            string Declaration = "Declaration:\n\n" +
                                 "To be furnished by the seller)Certified that all the  particulars shown In the\n" +
                                 "above Tax Invoice are true and correct in all respects and the goods on which the\n " +
                                 "tax charged and collected are in accordance with the provisions of the KERALA ACT\n" +
                                 "2003 and the rules made thereunder.It is also certified that my/our Registration \n" +
                                 "under KERALA Act 2003 is not subject to any suspension/cancellation and it is \n" +
                                 "valid as on the date of this Bill.";

            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text));

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
            LineAbowAmount +"\n" + TTQty + TTAmount + "\n" +LineFooter + 
            "\nIn Words: " + AmountinWords +
            "\n\n                                                     Bill Discount :" + BiilDiscount.PadLeft(12, ' ') +
            "\n                                                     Taxable Amount:" + TaxableAmt.PadLeft(12, ' ') +
            "\n                                                     Tax Amount    :" + TaxAmt.PadLeft(12, ' ') +
            "\n                                                     Total Amount  :" + txtbillamount.Text.PadLeft(12, ' ') + 
            "\n\n\n" + Declaration + "\n\n\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            RichTextBox Rch = new RichTextBox();

            Font fnt = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Rch.Text = "   company Name";
        }
       
        private void cmdprint_Click(object sender, EventArgs e)
                                                {
            Nocopies();
        }
        public void ShowInRichBox()
        {
            ClsPrint _Print = new ClsPrint();
            _Print.grandTotal = TBillAmount;
            _Print.RoundOff = _Dbtask.znullDouble(txtRoundOff.Text);
            _Print.narretion = TxtNaration.textBox1.Text;
            text = text.Trim();
            Tag = _Print.DotMetrixPrinter(text, gridmain, VNo, CustomerTag, PrintRowIndex);
        }

        public void DetailPrint()
        {
            string Tag;
            int j;
            positn1 = position;
            for (int k = 0; k < gridmain.Rows.Count; k++)
            {
                if (gridmain.Rows[k].Tag != null)
                {
                    if (gridmain.Rows[k].Tag.ToString() == "1")
                    {

                        for (j = position; j < RichTextBox1.TextLength; j++)
                        {
                            text = "";
                            Space = "";
                            Tag = RichTextBox1.Text[j].ToString();
                            if (Tag != "\n")
                            {

                                if (Tag == "I")
                                {
                                    while (RichTextBox1.Text[j].ToString() != ">")
                                    {
                                        text = text + RichTextBox1.Text.Substring(j, 1);
                                        j++;
                                    }
                                    PrintRowIndex = k;

                                    int length = 0;
                                    length = text.Length;
                                    ShowInRichBox();

                                    int ResultLength = 0;
                                    ResultLength = Tag.Length;
                                    int L1 = length - ResultLength;
                                    for (int i = 0; i < L1; i++)
                                    {
                                        Space = " " + Space;
                                    }
                                    if (text == "IGross(Rate*Qty)" || text == "IRate")
                                    {
                                        string TsAmount = "";
                                        int rsltLngth = 13 - ResultLength;
                                        TsAmount = Tag.PadLeft(rsltLngth, ' ');
                                        for (int i = 0; i < rsltLngth; i++)
                                        {
                                            Space = "";
                                            Space = " " + Space;
                                        }
                                        Chktemp.Text = Chktemp.Text + TsAmount + Space;
                                    }
                                    else
                                    {
                                        Chktemp.Text = Chktemp.Text + Tag + Space;
                                    }

                                }


                                else
                                {
                                    if (Tag == "<")
                                    {
                                        Chktemp.Text = Chktemp.Text + " ";

                                    }
                                    else
                                    {
                                        Chktemp.Text = Chktemp.Text + Tag;
                                    }
                                }

                                if (Tag == "F")
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                            // }
                        }
                        positionAfter = j;
                        positn1 = (positionAfter + 1) - position;
                    }
                }
                Chktemp.Text = Chktemp.Text + "\n" + "\n";
            }



        }

        public void DesignLoadRt()
        {
            Frmprintmain _PrintMain = new Frmprintmain();
            if (SalesAccount != "2")
            {
                string field = _VouchrType.GetSpecificItem(SalesAccount, "Printer");
                _PrintMain.LoadField = field;
                RichTextBox1.LoadFile(field);
                
            }
            else
            {
                _PrintMain.LoadField =  CommonClass._Gen.GetFilelocation()+"\\Sa.Rtf";
                RichTextBox1.LoadFile(_PrintMain.LoadField);
            }

            int Length = RichTextBox1.TextLength;
            _PrintMain.Richmain.Text = "";
            Chktemp.Text = "";

            VNo = txtvno.Text;
            if (commodeofpayment.SelectedIndex == 0)
            {
                CustomerTag = "1";
            }
            else
            {
                CustomerTag = TxtAccount.Tag.ToString();
            }
            for (int i = 0; i < Length; i++)
            {

                Tag = RichTextBox1.Text[i].ToString();

                if (Tag.ToString() == "<")
                {
                    text = "";
                    i = i + 1;

                    if (RichTextBox1.Text.Substring(i, 1) == "I")
                    {
                      //  position = i - 1;
                       // DetailPrint();
                       // i = positionAfter;

                    }

                    else
                    {
                        while (RichTextBox1.Text[i].ToString() != ">")
                        {
                            text = text + RichTextBox1.Text.Substring(i, 1);
                            i++;
                        }

                        ShowInRichBox();
                        if (text == "FInwords")
                        {
                            FnAmountInWords();
                            Tag = AmountinWords;
                        }
                        Chktemp.Text = Chktemp.Text + Tag;
                    }
                }
                else
                {
                    Chktemp.Text = Chktemp.Text + Tag;
                }
            }
            string Signature = "Authorized Signatory";
            string AuthorisedSignature = Signature.PadLeft(80, ' ');
            _PrintMain.Richtext = Chktemp.Text + "\n" + AuthorisedSignature;
             CommonClass.temp= _PrintMain.Richtext;
            (this.MdiParent as MDIParent2).mnuinvoicedesigndotmetrix.PerformClick();
        }

        public void FnAmountInWords()
        {
            AmountinWords = "";
            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
        }


        public void RetriveAutosave()
        {
            
            string Filepath = @"D:\ZtTemp.tmp";
            Ds.ReadXml(Filepath);

            if (gridmain.Rows.Count > 0)
                gridmain.Rows.Clear();

            string TempBathcode;
            string tempItemCode;
            string tempItemName;
            string ExpiryDate;
            string tempqty;
            string tempSrate;
            string free;
            string disper;
            string discount;
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    if (_Dbtask.znllString(Ds.Tables[0].Rows[i][0]) != "")
                    {

                        gridmain.Rows.Add(1);

                        ItemId = Ds.Tables[0].Rows[i]["Column1"].ToString();
                        TempBathcode = Ds.Tables[0].Rows[i]["Column2"].ToString();
                        ExpiryDate = Ds.Tables[0].Rows[i]["Column3"].ToString();
                        tempItemCode = Ds.Tables[0].Rows[i]["Column4"].ToString();
                        tempItemName = Ds.Tables[0].Rows[i]["Column5"].ToString();
                        tempqty = Ds.Tables[0].Rows[i]["Column6"].ToString();
                        TempMrp = Ds.Tables[0].Rows[i]["Column7"].ToString();
                        free = Ds.Tables[0].Rows[i]["Column8"].ToString();
                        tempSrate = Ds.Tables[0].Rows[i]["Column11"].ToString();
                        disper = Ds.Tables[0].Rows[i]["Column12"].ToString();
                        discount = Ds.Tables[0].Rows[i]["Column13"].ToString();
                        string TaxAmt = Ds.Tables[0].Rows[i]["Column17"].ToString();
                        string TaxPerc = Ds.Tables[0].Rows[i]["Column16"].ToString();

                        string Billdis = Ds.Tables[0].Rows[i]["Column15"].ToString();

                        gridmain.Rows[i].Cells["clnitemcode"].Value = tempItemCode;
                        gridmain.Rows[i].Cells["clnitemname"].Value = tempItemName;
                        gridmain.Rows[i].Cells["clnitemname"].Tag = ItemId;
                        gridmain.Rows[i].Cells["clnexpiry"].Value = _Dbtask.ZnullDatetime(Convert.ToInt16(ExpiryDate));
                        gridmain.Rows[i].Cells["clnqty"].Value = tempqty;
                        gridmain.Rows[i].Cells["clnsrate"].Value = tempSrate;
                        gridmain.Rows[i].Cells["clnmrp"].Value = TempMrp;
                        gridmain.Rows[i].Cells["clntax"].Value = TaxAmt;
                        gridmain.Rows[i].Cells["ClntaxPer"].Value = TaxPerc;
                        gridmain.Rows[i].Cells["clnbatch"].Value = TempBathcode;
                        gridmain.Rows[i].Cells["clndiscount"].Value = discount;
                        gridmain.Rows[i].Cells["clndiscper"].Value = disper;
                        gridmain.Rows[i].Cells["clnfree"].Value = free;

                        gridmain.Rows[i].Cells["clnbilldiscount"].Value = Billdis;

                        gridmain.Rows[i].Cells["clnslno"].Value = i + 1;

                        NQty = _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value);
                        NFree = _Dbtask.znlldoubletoobject(free);
                        NRate = _Dbtask.znlldoubletoobject(tempSrate);
                        NTaxamount = _Dbtask.znlldoubletoobject(TaxAmt);
                        NDiscamt = _Dbtask.znlldoubletoobject(discount);
                        NBillDisc = _Dbtask.znlldoubletoobject(Billdis);
                        NDiscper = _Dbtask.znlldoubletoobject(disper);
                        NMrp = _Dbtask.znlldoubletoobject(TempMrp);

                        rowindex = i;
                        CellEnterCalculationPart();


                    }

                }
                catch
                {
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
                //}
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
                    string ItemId = gridmain.Rows[0].Cells["clnitemname"].Tag.ToString();
                    string tempItemCode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemcode"].Value);
                    string tempItemName = _Dbtask.znllString(gridmain.Rows[i].Cells["clnitemname"].Value);
                    string tempqty = _Dbtask.znllString(gridmain.Rows[i].Cells["clnqty"].Value);
                    string tempbarcode = _Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value);
                    string tempSrate = _Dbtask.znllString(gridmain.Rows[i].Cells["clnsrate"].Value);
                    string tempfree = _Dbtask.znllString(gridmain.Rows[i].Cells["clnfree"].Value);
                }
                string Filepath = @"D:\ZtTemp.tmp";
 
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

        public void Laserprintspecification(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _Laser.PTYpe = FormType;
           // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Laser.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Laser.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Laser.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Laser.TotalItemDisc =_Dbtask.znullDouble(TxttItemDiscount.Text);
            _Laser.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Laser.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Laser.SSlnotracking = SSerialnotracking;
            _Laser.SitemNote = Enableitemnote;
            _Laser.Bunit = BUNIT;
           // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname=N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Laser.TempCust = comcustomerproject.Text;
                _Laser.SProject = true;
            }
            else
            {
                _Laser.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Laser.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }
            

            _Laser.BillDate = dtdate.Value;
            _Laser.Billno = txtvno.Text;
            _Laser.TgrossAmt = TxttAmount.Text;
            _Laser.Totherexpense = txtotherexpenses.Text;
             // _Laser.Receivedamount
            _Laser.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Laser.TotalNetamount = NetTottal;
            _Laser.FormType = FormType;
            _Laser.Ttaxamount = txtttax.Text;
            _Laser.TotalQty = txttqty.Text;
            
            if (commodeofpayment.SelectedIndex == 0)
                _Laser.ModeofPayment = "CASH";
            else
                _Laser.ModeofPayment = "CREDIT";

                _Laser.StrNaration = TxtNaration.textBox1.Text;
          
        }

        public void Laserprintspecification1(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _Laser1.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _Laser1.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _Laser1.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _Laser1.TDiscount = (Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _Laser1.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _Laser1.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _Laser1.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _Laser1.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname =N'" + TxtAccount.Text + "'");

            if (Spartyproject == true && comcustomerproject.Text != "None" && comcustomerproject.Text != "")
            {
                _Laser1.TempCust = comcustomerproject.Text;
                _Laser1.SProject = true;
            }
            else
            {
                _Laser1.TempCust = TxtAccount.Text;
            }

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _Laser1.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _Laser1.BillDate = dtdate.Value;
            _Laser1.Billno = txtvno.Text;
            _Laser1.TgrossAmt = TxttAmount.Text;
            _Laser.Totherexpense = txtotherexpenses.Text;
            // _Laser.Receivedamount
            _Laser1.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _Laser1.TotalNetamount = NetTottal;
            _Laser1.FormType = FormType;
            _Laser1.Ttaxamount = txtttax.Text;
            _Laser1.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _Laser1.ModeofPayment = "CASH";
            else
                _Laser1.ModeofPayment = "CREDIT";

            _Laser1.StrNaration = TxtNaration.textBox1.Text;

        }

        public void PrintLaser(string FormType, string Pselect)
        {
            Laserprintspecification(FormType);
            _Laser.PSelect = Pselect;
           // _Laser.STax = STax;
            _Laser.PrintInvoice(gridmain);
        }
        public void PrintLaser1(string FormType, string Pselect)
        {
            Laserprintspecification1(FormType);
            _Laser1.PSelect = Pselect;
            // _Laser.STax = STax;
            _Laser1.PrintInvoice(gridmain);
        }
        public void PrintLaser3Point(string FormType, string Pselect)
        {
            Laserprintspecification3Point(FormType);
            _LaserSimple.PSelect = Pselect;
            // _Laser.STax = STax;
            _LaserSimple.PrintInvoice(gridmain);
        }
        public void Laserprintspecification3Point(string FormType)
        {
            _lasersix.StrTaxinvoiceHeader = ComTaxinvoice.Text;
            _LaserSimple.PTYpe = FormType;
            // _Laser.Receivedamount = _Dbtask.znullDouble(txtpaid.textBox1.Text);
            _LaserSimple.Agentid = (_Dbtask.gridnul(ComAgent.SelectedValue)).ToString();
            _LaserSimple.EmployeeId = (_Dbtask.gridnul(Comemployee.SelectedValue)).ToString();
            _LaserSimple.TDiscount = (Convert.ToDouble(txttinvoicediscount.Text) + Convert.ToDouble(TxttItemDiscount.Text)).ToString();
            _LaserSimple.TotalItemDisc = _Dbtask.znullDouble(TxttItemDiscount.Text);
            _LaserSimple.TotalTaxable = _Dbtask.znullDouble(TxtTGross.Text);
            _LaserSimple.TotalTaxAmount = _Dbtask.znullDouble(txtttax.Text);
            _LaserSimple.SSlnotracking = SSerialnotracking;
            // _Laser.RAmount = txtpaid.textBox1.Text;

            Ds2 = _Dbtask.ExecuteQuery("select lid from tblaccountledger where lname='" + TxtAccount.Text + "'");

            

            if (Ds2.Tables[0].Rows.Count > 0)
            {
                _LaserSimple.Lid = Ds2.Tables[0].Rows[0][0].ToString();
            }


            _LaserSimple.BillDate = dtdate.Value;
            _LaserSimple.Billno = txtvno.Text;
            _LaserSimple.TgrossAmt = TxttAmount.Text;
            _LaserSimple.Totherexpense = txtotherexpenses.Text;
            _LaserSimple.BillAmount = (_Dbtask.znullDouble(txtbillamount.Text)).ToString();
            _LaserSimple.TotalNetamount = NetTottal;
            _LaserSimple.FormType = FormType;
            _LaserSimple.Ttaxamount = txtttax.Text;
            _LaserSimple.TotalQty = txttqty.Text;

            if (commodeofpayment.SelectedIndex == 0)
                _LaserSimple.ModeofPayment = "CASH";
            else
                _LaserSimple.ModeofPayment = "CREDIT";

            _LaserSimple.StrNaration = TxtNaration.textBox1.Text;

        }
       

        public void vouchertypewholesale2(string Invoicename)
        {
            string TIN = "32091280964";
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster").PadLeft(40, ' ');
            string Address = "T.S ROAD JN., MANNARKAD, PALAKKAD-678 582";
            string Address1 = "PH: 9447546432, 9745716683";
            string PInvoiceName = Invoicename.PadLeft(40, ' ');
            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = Datestr.PadLeft(60, ' ');
            string LineHeading = "=".PadRight(100, '=');
            string LineAbowAmount = "-".PadRight(100, '-');
            string LineFooter = "=".PadRight(100, '=');
            string Pname = "Product Name".PadRight(50, ' ');
            string TsQty = "Qty".PadLeft(10, ' ');
            string TsRate = "Rate".PadLeft(10, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TStaxperc = "Tax%".PadLeft(5, ' ');
            string TStaxamt = "TaxAmt".PadLeft(10, ' ');
            string TAmountstr = "Amount".PadLeft(10, ' ');
            string TTQty;
            string TTAmount;
            RichTextBox1.Text = "" + TIN + "" + CompanyName + "\n\n" + Address + "\n" + Address1 + Datestr + "\n\n" + Pname + TStaxperc + TsQty + TsRate + TStaxamt + TAmountstr + "\n" + LineHeading + "";
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(50, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = sQty.ToString();
                        TsQty = TsQty.PadLeft(10, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = sRate.ToString();
                        TsRate = TsRate.PadLeft(10, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = sAmount.ToString();
                        TsAmount = TsAmount.PadLeft(10, ' ');

                        double Staxperc = Convert.ToDouble(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                        TStaxperc = Staxperc.ToString();
                        TStaxperc = TStaxperc.PadLeft(5, ' ');

                        double Staxamt = Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                        TStaxamt = Staxamt.ToString();
                        TStaxamt = TStaxamt.PadLeft(10, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Pname + TStaxperc + TsQty + TsRate + TStaxamt + TsAmount;

                    }
                }
            }

            TTQty = TQty.ToString();
            TTQty = TTQty.PadLeft(60, ' ');

            TTAmount = TAmount.ToString();
            TTAmount = TTAmount.PadLeft(30, ' ');
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineAbowAmount +
                "\n" + TTQty + TTAmount + "\n" +
               LineFooter;

            if (!MyPrinter.Open("Test Page")) return;
            MyPrinter.Print(RichTextBox1.Text);
            MyPrinter.Close();
        }

        public void vouchertypewholesalesDotmetrix6(string Invoicename, string Formno)
        {
            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            Label lb = new Label();
            lb.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Text = CompanyName;
            CompanyName = "     " + CompanyName;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "       " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = ("        PH: " + Mobile + "");
            string Taxruletext = (" THE KERALA VALUE ADDED TAX RULES, 2005FORM " + Formno + ",\n [See rule 58(10)]").PadLeft(40, ' ');
            string PInvoiceName = "                                     " + Invoicename; ;
            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string StrVno = txtvno.Text;

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                     " + Datestr;
            string LineHeading = "=".PadRight(80, '=');
            string LineAbowAmount = "-".PadRight(80, '-');
            string LineFooter = "=".PadRight(80, '=');

            string Slno = "Slno ";

            string Pname = "Product Name             ";
            string TStaxamt = "TaxAmt   ";
            string TTaxable = "Taxable    ";
            string TDiscAmt = "Disc ";
            string TsQty = "Qty   ";
            string TsRate = "Rate   ";
            string TsAmount = "Amount";
            string TAmountstr = "Amount";
            string TTQty;
            string TTAmount;

            if (Formno == "NO.8B")
            {
                RichTextBox1.Text = "" + TIN + "         " + lb.Text + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\nCustomer :" + Custname + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname +  TsQty + TsRate + TDiscAmt +   TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "" + TIN + "         " + lb.Text + "\n\n" + Address + "\n" + Mobile + "\n" + Taxruletext + "\n\nCustomer :" + Custname + "      TIN:" + CusTinno + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname +  TsQty + TsRate + TDiscAmt +   TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double TDisc = 0;
            double TTaxAmt = 0;
            double TTaxableAmt = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(3, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (Pname.Length > 15)
                        {
                            Pname = Pname.Substring(0, 14);
                        }
                        Pname = Pname.PadRight(15, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');




                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(9, ' ');

                        double SDisc = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value);
                        TDiscAmt = SDisc.ToString();
                        TDiscAmt = TDiscAmt.PadLeft(5, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(10, ' ');

                        TDisc = TDisc + SDisc;
                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname +  TsQty + TsRate + TDiscAmt +  TsAmount;
                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpointStock(TQty);
            TTQty = TTQty.PadLeft(38, ' ');


            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(10, ' ');

            TStaxamt = _Dbtask.SetintoDecimalpoint(TTaxAmt);
            TStaxamt = TStaxamt.PadLeft(7, ' ');

            TTaxable = _Dbtask.SetintoDecimalpoint(TTaxableAmt);
            TTaxable = TTaxable.PadLeft(10, ' ');

            TDiscAmt = TDisc.ToString();
            TDiscAmt = TDiscAmt.PadLeft(14, ' ');

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(TBillAmount);
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
            currentbalance = 0;
            OldBalance = 0;


            if (commodeofpayment.SelectedIndex == 1)
            {

                string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                string tempp = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                OldBalance = Convert.ToDouble(tempp);
                double BillAmt = BillAmount;

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
            string OtherizedSignature = "                                                            Authorized Signatory";
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineAbowAmount +
                "\n" + TTQty + TDiscAmt + TTaxable + TStaxamt + TTAmount + "\n" +
               LineFooter.PadLeft(10, ' ') + "\n                                                     Bill Discount :" + BiilDiscount.PadLeft(11, ' ') + "\n                                                   Total           :" + txtbillamount.Text.PadLeft(11, ' ') + "\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            RichTextBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (ChkShowPreview.Checked == false)
            {

                if (!MyPrinter.Open("Qplex Print")) return;


                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(48).ToString() + Convert.ToChar('n').ToString());

                RichTextBox1.Font = InvTitleFont;
                MyPrinter.Close();
            }

        }

        public void SettintogapDotmetrix(RichTextBox Rch, string Str, long CRow, int Maxrow)
        {
            for (int i = Convert.ToInt32(CRow); i < Maxrow; i++)
            {
                Rch.Text = Rch.Text + "\n";
            }
        }

        public void vouchertypewholesalesDotmetrix10steel(string Invoicename, string Formno)
        {
            PrintBalance = CommonClass._Menusettings.GetMnustatus("150");
            string TIN = "TIN:"  +_Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            TIN = "                                                        " + TIN;

            Label lb = new Label();
            lb.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Text = CompanyName;
            CompanyName = "" + CompanyName;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "" + temp + "";
            string Address ="                                      "+ temp;
            temp = _Dbtask.ExecuteScalar("select address2 from TblCompanyMaster");
            temp = "" + temp + "";
            string Address2 ="                                          "+ temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = "PH: " + Mobile + "";
            Mobile = "                                                " + Mobile;
            string Taxruletext = "                                            THE KERALA VALUE ADDED TAX RULES,2005";
            string TaxruleSec = "                                                           Form "+Formno+"";
            string PInvoiceName = "                                     " + Invoicename; ;
            string Taxrule2="                               (For Presumptive Tax & Compounded Tax Payers Only)(See rule 58(10))";
            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusMob = _Dbtask.ExecuteScalar("select Mobile from tblaccountledger where lname='" + TxtAccount.Text + "'");
            Custname = Custname + "     " + CusMob;
            string Strsale = "                                                            SALE BILL";
            string StrCredit = "                                                           CASH/CREDIT";
            string StrDeclaration = "Declaration:\n\n" +
"Certified that all the particulars shown in the above tax invoice are correct.\n" +
"It is also certified that my/our registration under KVAT act 2003  is not \n" +
"subject to any suspension/cancellation and it is valid as on the date of this Bill. ";

            string Datestr = "         " + dtdate.Value.ToString("dd/MM/yyyy");
           // Datestr = "                                                                                                   " + Datestr;
            string LineHeading = "=".PadRight(134, '=');
            string LineAbowAmount = "-".PadRight(134, '-');
            string LineFooter = "=".PadRight(134, '=');

            string Slno = "Slno ";

            string Pname = "Product Name                                ";
            string TStaxperc = "Tax%      ";
            string TStaxamt = "TaxAmt       ";
            string TTaxable = " Taxable         ";
            string TDiscAmt = " Disc     ";
            string TDiscPerc = "D.Perc ";
            string TsQty = " Qty ";
            string Tsfree = "  Free      ";
            string TsRate = "   Rate      ";
            string TsAmount = " Amount";
            string StrVno = txtvno.Text;
            string TAmountstr = "Amount";
            string TTQty;
            string TTAmount;


            RichTextBox1.Text = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" + Datestr + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + Custname + "\n";
            
            double TRate = 0;
            double TQty = 0;
            double TQtyfree = 0;
            double TAmount = 0;
            double TDisc = 0;
            double TTaxAmt = 0;
            double TTaxableAmt = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        TRowCounting = i;
                        Slno = gridmain.Rows[i].Cells["clnbatch"].Value.ToString();
                        Slno = Slno.PadRight(20, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (Pname.Length > 33)
                        {
                            Pname = Pname.Substring(0, 33);
                        }
                        Pname = Pname.PadRight(33, ' ');

                        double Staxperc = Convert.ToDouble(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                        TStaxperc = Staxperc.ToString("0.0");
                        TStaxperc = TStaxperc.PadLeft(10, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sQtyfree = Convert.ToDouble(gridmain.Rows[i].Cells["clnfree"].Value);
                        Tsfree = _Dbtask.SetintoDecimalpointStock(sQtyfree);
                        Tsfree = Tsfree.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                      //  srate = sRate - Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                            
                        TsRate = (sRate).ToString("0.00");
                        TsRate = TsRate.PadLeft(8, ' ');



                        double SDisc = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value);
                        TDiscAmt = SDisc.ToString("0.00");
                        TDiscAmt = TDiscAmt.PadLeft(11, ' ');

                        double SDiscPerc = Convert.ToDouble(gridmain.Rows[i].Cells["ClnDiscPer"].Value);
                        TDiscPerc = SDiscPerc.ToString("0.00");
                        TDiscPerc = TDiscPerc.PadLeft(10, ' ');

                        double StaxableAmt = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                      
                       
                            TTaxable = (StaxableAmt).ToString("0.00");
                            TTaxable = TTaxable.PadLeft(14, ' ');
                        

                        double Staxamt = Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                        TStaxamt = (Staxamt).ToString("0.00");
                        TStaxamt = TStaxamt.PadLeft(13, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = (sAmount).ToString("0.00");
                        TsAmount = TsAmount.PadLeft(9, ' ');


                        TTaxableAmt = TTaxableAmt + StaxableAmt;
                        TTaxAmt = TTaxAmt + Staxamt;
                        TDisc = TDisc + SDisc;
                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n  " + Slno + Pname +  TsQty + TsRate +    TsAmount;
                    }
                }
            }
            SettintogapDotmetrix(RichTextBox1, " ", TRowCounting, 35);
            TTQty = (TQty).ToString("0.00");
            TTQty = TTQty.PadLeft(58, ' ');


            TTAmount = (TAmount).ToString("0.00");
            TTAmount = TTAmount.PadLeft(13, ' ');

            TStaxamt = (TTaxAmt).ToString("0.00");
            TStaxamt = TStaxamt.PadLeft(12, ' ');

            TTaxable = (TTaxableAmt).ToString("0.00");
            TTaxable = TTaxable.PadLeft(19, ' ');

            TDiscAmt = TDisc.ToString("0.00");
            TDiscAmt = TDiscAmt.PadLeft(29, ' ');

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text));
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
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
                OldBalance = Convert.ToDouble(OldBalance.ToString("0.00"));

                currentbalance =Convert.ToDouble(currentbalance.ToString("0.00"));

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
                    OldBalance = Convert.ToDouble(OldBalance.ToString("0.00"));

                    currentbalance = Convert.ToDouble(currentbalance.ToString("0.00"));
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string OtherizedSignature = "                                                                                                            Authorized Signatory";

            string Tamount =(_Dbtask.znullDouble(TxttAmount.Text).ToString("0.00"));
            string Tdisc = (_Dbtask.znullDouble(BiilDiscount).ToString("0.00"));
            string TRou = (_Dbtask.znullDouble(txtRoundOff.Text).ToString("0.00"));
            string TBill = (_Dbtask.znullDouble(txtbillamount.Text).ToString("0.00"));

            RichTextBox1.Text = RichTextBox1.Text + 
                                             "\n"+ Tamount.PadLeft(76, ' ') +
                                             "\n" + Tdisc.PadLeft(76, ' ') +
                                             "\n" + txtttax.Text.PadLeft(76, ' ') + 
                                             "\n" + TBill.PadLeft(76, ' ');

            //RichTextBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           

                //if (!MyPrinter.Open("Qplex Print")) return;

                
            
               // PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));

            
              //  PrintBold("\n\n\n\n\n\n",true);
            
               // PrintBold(CompanyName,true);

                PrintDotMetrix(true);
                RichTextBox2.Text = RichTextBox1.Text;

                if (Formno == "NO.8")
                {
                    RichTextBox1.Text = "\n\nIn Words: " + AmountinWords +"\n\n"+
                       StrDeclaration+ "\n\n" + OtherizedSignature;
                }
                else
                {
                    //RichTextBox1.Text = "\n\nIn Words: " + AmountinWords +
                    //         "\n\n" + OtherizedSignature;
                }

                 RichTextBox2.Text =  RichTextBox2.Text+ RichTextBox1.Text;
                 Fscroll();
                 PrintDotMetrix(true);
                 RichTextBox1.Text = RichTextBox2.Text;
        }


        public void vouchertypewholesalesDotmetrix10(string Invoicename, string Formno)
        {
            PrintBalance = CommonClass._Menusettings.GetMnustatus("150");
            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string StrTotal = "                                            Total         :" + txtbillamount.Text;
            Label lb = new Label();
            lb.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Text = CompanyName;
            CompanyName = "" + CompanyName;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "" + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = "PH: " + Mobile + "";
            //Mobile = Mobile.PadLeft(59);
            string Taxruletext = ("THE KERALA VALUE ADDED TAX RULES, 2005FORM " + Formno + ", [See rule 58(10)]").PadLeft(40, ' ');
            Taxruletext = "                               "+Taxruletext;
            string PInvoiceName = "                                     " + Invoicename; ;
            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusMob = _Dbtask.ExecuteScalar("select Mobile from tblaccountledger where lname='" + TxtAccount.Text + "'");

            Custname = Custname + "     " + CusMob;

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                                                                   " + Datestr;
            string LineHeading = "=".PadRight(129, '=');
            string LineAbowAmount = "-".PadRight(129, '-');
            string LineFooter = "=".PadRight(129, '=');

            string Slno = "Slno ";

            string Pname = "Product Name                                ";
            string TStaxperc = "Tax%      ";
            string TStaxamt = "TaxAmt       ";
            string TTaxable = " Taxable         ";
            string TDiscAmt = " Disc     ";
            string TDiscPerc = "D.Perc ";
            string TsQty = "  Qty      ";
            string TsRate = "   Rate      ";
            string TsAmount = " Amount";
            string StrVno = txtvno.Text;
            string TAmountstr = "Amount";
            string TTQty;
            string TTAmount;
            Taxruletext = Taxruletext.PadLeft(31);
            if (Formno == "NO.8 B")
            {
                RichTextBox1.Text = "\n\n" + Address + "\n" + "\n" + TIN + "\n" + Mobile + "\n" + Taxruletext + "\n\nCustomer :" + Custname + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname + TStaxperc + TsQty + TsRate + TDiscAmt + TTaxable + TStaxamt + TAmountstr + "\n" + LineHeading + "";
            }
            else
            {
                RichTextBox1.Text = "\n\n" + Address + "\n" + "\n" + TIN + "\n" + Mobile + "\n" + Taxruletext + "\n\nCustomer :" + Custname + "      TIN:" + CusTinno + "\nAddress :" + CusAddress + "\n" + "Inv No :" + StrVno + Datestr + " \n\n" + Slno + Pname + TStaxperc + TsQty + TsRate + TDiscAmt + TTaxable + TStaxamt + TAmountstr + "\n" + LineHeading + "";
            }
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double TDisc = 0;
            double TTaxAmt = 0;
            double TTaxableAmt = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        TRowCounting = i;
                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(5, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (Pname.Length > 38)
                        {
                            Pname = Pname.Substring(0, 38);
                        }
                        Pname = Pname.PadRight(38, ' ');

                        double Staxperc = Convert.ToDouble(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                        TStaxperc = Staxperc.ToString("0.0");
                        TStaxperc = TStaxperc.PadLeft(10, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(11, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = (sRate).ToString("0.00");
                        TsRate = TsRate.PadLeft(13, ' ');



                        double SDisc = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value);
                        TDiscAmt = SDisc.ToString("0.00");
                        TDiscAmt = TDiscAmt.PadLeft(11, ' ');

                        double SDiscPerc = Convert.ToDouble(gridmain.Rows[i].Cells["ClnDiscPer"].Value);
                        TDiscPerc = SDiscPerc.ToString("0.00");
                        TDiscPerc = TDiscPerc.PadLeft(10, ' ');

                        double StaxableAmt = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);


                        TTaxable = (StaxableAmt).ToString("0.00");
                        TTaxable = TTaxable.PadLeft(14, ' ');


                        double Staxamt = Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                        TStaxamt = (Staxamt).ToString("0.00");
                        TStaxamt = TStaxamt.PadLeft(13, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = (sAmount).ToString("0.00");
                        TsAmount = TsAmount.PadLeft(14, ' ');


                        TTaxableAmt = TTaxableAmt + StaxableAmt;
                        TTaxAmt = TTaxAmt + Staxamt;
                        TDisc = TDisc + SDisc;
                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TStaxperc + TsQty + TsRate + TDiscAmt + TTaxable + TStaxamt + TsAmount;
                    }
                }
            }
            TTQty = (TQty).ToString("0.00");
            TTQty = TTQty.PadLeft(64, ' ');


            TTAmount = (TAmount).ToString("0.00");
            TTAmount = TTAmount.PadLeft(14, ' ');

            TStaxamt = (TTaxAmt).ToString("0.00");
            TStaxamt = TStaxamt.PadLeft(13, ' ');

            TTaxable = (TTaxableAmt).ToString("0.00");
            TTaxable = TTaxable.PadLeft(14, ' ');

            TDiscAmt = TDisc.ToString("0.00");
            TDiscAmt = TDiscAmt.PadLeft(24, ' ');

            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Txttypebilldiscount.textBox1.Text) + Convert.ToDouble(TxttItemDiscount.Text));
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
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
                OldBalance = Convert.ToDouble(OldBalance.ToString("0.00"));

                currentbalance = Convert.ToDouble(currentbalance.ToString("0.00"));

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
                    OldBalance = Convert.ToDouble(OldBalance.ToString("0.00"));

                    currentbalance = Convert.ToDouble(currentbalance.ToString("0.00"));
                }
            }

            string tempoldbalance = _Dbtask.SetintoDecimalpoint(OldBalance);
            string tempcurrentbalance = _Dbtask.SetintoDecimalpoint(currentbalance);
            string OtherizedSignature = "                                                                                                            Authorized Signatory";

            string Tamount =_Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(TxttAmount.Text));
            string Tdisc =_Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(BiilDiscount));
            string TRou =_Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(txtRoundOff.Text));
            string TBill =_Dbtask.SetintoDecimalpoint(_Dbtask.znullDouble(txtbillamount.Text));

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineAbowAmount +
                "\n" + TTQty + TDiscAmt + TTaxable + TStaxamt + TTAmount + "\n" +
               LineFooter.PadLeft(10, ' ') +
                                             "\n                                                                                                       Total Amount  :" + Tamount.PadLeft(11, ' ') +
                                             "\n                                                                                                       Discount      :" + Tdisc.PadLeft(11, ' ') +
                                             "\n                                                                                                       Rounf off     :" + TRou.PadLeft(11, ' ') ;

            RichTextBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



            PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));


            PrintBold("\n\n\n\n\n", true);

            PrintBold(CompanyName, true);

            PrintDotMetrix(true);
            RichTextBox2.Text = RichTextBox1.Text;

            if (PrintBalance == "1")
            {
                PrintBold(StrTotal, true);
                RichTextBox1.Text = "\n\nIn Words: " + AmountinWords +
                    "\nBalance        :" + tempoldbalance.PadLeft(11, ' ') +
                    "\nCurrent Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
            }
            else
            {
                RichTextBox1.Text = "\n\nIn Words: " + AmountinWords +
                         "\n\n" + OtherizedSignature;
            }

            RichTextBox2.Text = RichTextBox2.Text + RichTextBox1.Text;
            Fscroll();
            PrintDotMetrix(true);
            RichTextBox1.Text = RichTextBox2.Text;
        }
        public void vouchertypewholesalesDotmetrix10MultiPrinting(string Invoicename, string Formno, string BillFormat)
        {

            string TIN = "TIN:" + _Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            Label lb = new Label();
            lb.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Text = CompanyName;
            CompanyName = "                      " + CompanyName;
            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = ("                          PH: " + Mobile + "");
            string Taxruletext = ("                  THE KERALA VALUE ADDED TAX RULES, 2005FORM " + Formno + ", [See rule 58(10)]");
            string PInvoiceName = "                                        " + Invoicename; ;
            string Custname = TxtAccount.Text;
            string CusTinno = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string CusAddress = _Dbtask.ExecuteScalar("select address from tblaccountledger where lname='" + TxtAccount.Text + "'");
            string StrVno = txtvno.Text;

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                                         " + Datestr;
            string LineHeading = "=".PadRight(101, '=');
            string LineAbowAmount = "-".PadRight(101, '-');
            string LineFooter = "=".PadRight(101, '=');

            string Slno = "Slno ";
            string PCode = "Commodity Code  ";
            string Pname = "Commodity/Item";
            string TStaxperc = "             Tax%      ";
            string TStaxamt = "TaxAmt   ";
            string TTaxable = "Taxable    ";
            string TDiscAmt = "Disc ";
            string TsQty = "  Qty             ";
            string TsRate = "  UnitPrice      ";
            string TsAmount = "Amount";

            string TAmountstr = "Amount";
            string TTQty;
            string TTAmount;



            RichTextBox1.Text = RichTextBox1.Text + "" + TIN + "         " + "\n\n" + BillFormat + Address + "\n" + Mobile + "\n" + Taxruletext + "\n" + PInvoiceName + "\nBill No:" + StrVno + Datestr + "\n\nCustomer&Address :" + Custname + "     " + CusAddress + "\n" + Datestr + " \n\n" + Slno + PCode + Pname + TStaxperc + TsRate + TsQty + TAmountstr + "\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double TDisc = 0;
            double TTaxAmt = 0;
            double TTaxableAmt = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        TRowCounting = i;
                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        Slno = Slno.PadRight(5, ' ');

                        PCode = gridmain.Rows[i].Cells["clnitemcode"].Value.ToString();
                        if (PCode.Length > 16)
                        {
                            PCode = PCode.Substring(0, 16);
                        }
                        PCode = PCode.PadRight(16, ' ');

                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (Pname.Length > 25)
                        {
                            Pname = Pname.Substring(0, 24);
                        }
                        Pname = Pname.PadRight(25, ' ');

                        double Staxperc = Convert.ToDouble(gridmain.Rows[i].Cells["ClntaxPer"].Value);
                        TStaxperc = Staxperc.ToString();
                        TStaxperc = TStaxperc.PadLeft(6, ' ');

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(12, ' ');

                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(17, ' ');

                        double SDisc = Convert.ToDouble(gridmain.Rows[i].Cells["clndiscount"].Value);
                        TDiscAmt = SDisc.ToString();
                        TDiscAmt = TDiscAmt.PadLeft(5, ' ');

                        double StaxableAmt = Convert.ToDouble(gridmain.Rows[i].Cells["ClnGross"].Value);
                        TTaxable = _Dbtask.SetintoDecimalpoint(StaxableAmt);
                        TTaxable = TTaxable.PadLeft(9, ' ');

                        double Staxamt = Convert.ToDouble(gridmain.Rows[i].Cells["clntax"].Value);
                        TStaxamt = _Dbtask.SetintoDecimalpoint(Staxamt);
                        TStaxamt = TStaxamt.PadLeft(8, ' ');

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(20, ' ');


                        TTaxableAmt = TTaxableAmt + StaxableAmt;
                        TTaxAmt = TTaxAmt + Staxamt;
                        TDisc = TDisc + SDisc;
                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + PCode + Pname + TStaxperc + TsRate + TsQty + TsAmount;                    }
                }
            }
            TTQty = _Dbtask.SetintoDecimalpointStock(TQty);
            TTQty = TTQty.PadLeft(38, ' ');


            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(10, ' ');

            TStaxamt = _Dbtask.SetintoDecimalpoint(TTaxAmt);
            TStaxamt = TStaxamt.PadLeft(7, ' ');

            TTaxable = _Dbtask.SetintoDecimalpoint(TTaxableAmt);
            TTaxable = TTaxable.PadLeft(10, ' ');

            TDiscAmt = TDisc.ToString();
            TDiscAmt = TDiscAmt.PadLeft(14, ' ');
            AmountinWords = "";
            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
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
            string OtherizedSignature = "                                                                          Authorized Signatory";
            string Cess = "0.00".PadLeft(11, ' ');
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
               LineFooter.PadLeft(10, ' ') + "\n                                                                         Tax Amt         :" + txtttax.Text.PadLeft(11, ' ') + "\n                                                                         Cess            :" + Cess + "\n                                                                         Total           :" + txtbillamount.Text.PadLeft(11, ' ') + "\n\nE&OE\n\nIn Words: " + AmountinWords +
             "\n" + LineFooter + "\nvehicle No :                     Seal                                  For NEW FRIENDS CHICKEN AGENCIE\n" + OtherizedSignature + "\n\n\n\n\n\n\n" + LineAbowAmount + "\n";
        }

        public void vouchertyperetailDotmetrix3(string Invoicename, string Formno)
        {
            string StrVno = txtvno.Text;

            string temp = _Dbtask.ExecuteScalar("select address1 from TblCompanyMaster");
            temp = "                     " + temp + "";
            string Address = temp;
            string Mobile = _Dbtask.ExecuteScalar("select mobile from TblCompanyMaster");
            Mobile = ("                          PH: " + Mobile + "");
            string RuleSeco = "[See rule 58(10)]".PadLeft(50);
            string Taxruletext = " THE KERALA VALUE ADDED TAX RULES, 2005FORM " + Formno + ",";

            string Datestr = "Date : " + dtdate.Value.ToString("dd/MM/yyyy");
            Datestr = "                                                               " + Datestr;
            string Cusnam = TxtAccount.Text.Replace("\r\n", " ");
            string LineHeading = "=".PadRight(48, '=');
            string LineAbowAmount = "-".PadRight(76, '-');
            string LineFooter = "=".PadRight(48, '=');
            string Slno = "Sl".PadRight(5, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(10, ' ');
            string TsRate = "Rate".PadLeft(16, ' ');
            string TsAmount = "Amount".PadLeft(16, ' ');
            string TAmountstr = "Amount".PadLeft(14, ' ');
            string TTQty;
            string TTAmount;
            RichTextBox1.Text = "\n" + Address + "\n" + "" + Mobile + "\n" + Taxruletext + "\n" + RuleSeco + "\nNo :" + StrVno + "" + "\nCustomer:" + Cusnam + "\n" + Datestr.PadLeft(60) + " \n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidation();
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                {
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = gridmain.Rows[i].Cells["clnslno"].Value.ToString();
                        int itemp = 5 - Slno.Length;

                        if (itemp == 0)
                        {
                            Slno = Slno.PadRight(5, ' ');
                        }
                        if (itemp != 0)
                        {
                            Slno = Slno.PadRight(itemp, ' ');
                        }
                        string SPname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = gridmain.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (Pname.Length > 10)
                        {
                            Pname = Pname.Substring(0, 9);
                        }
                        SPname = Pname;
                        itemp = 23 - Pname.Length;

                        if (itemp == 0)
                        {
                            Pname = Pname.PadRight(23, ' ');
                        }
                        if (itemp != 0)
                        {
                            Pname = Pname.PadRight(itemp, ' ');
                        }

                        double sQty = Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                        TsQty = _Dbtask.SetintoDecimalpointStock(sQty);

                        itemp = 22 - TsQty.Length;
                        int ttemp2 = 9 - SPname.Length;
                        itemp = itemp - ttemp2;
                        if (ttemp2 == 0)
                        {
                            TsQty = TsQty.PadLeft(itemp, ' ');
                        }
                        else
                        {
                            TsQty = TsQty.PadLeft(itemp + ttemp2, ' ');
                        }


                        double sRate = Convert.ToDouble(gridmain.Rows[i].Cells["clnsrate"].Value);
                        TsRate = _Dbtask.SetintoDecimalpoint(sRate);
                        itemp = TsRate.Length - 4;
                        if (itemp == 0)
                        {
                            TsRate = TsRate.PadLeft(17, ' ');
                        }
                        if (itemp != 0)
                        {
                            TsRate = TsRate.PadLeft(17 - itemp, ' ');
                        }

                        double sAmount = Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                        TsAmount = _Dbtask.SetintoDecimalpoint(sAmount);

                        itemp = TsAmount.Length - 4;
                        if (itemp == 0)
                        {
                            TsAmount = TsAmount.PadLeft(19, ' ');
                        }
                        if (itemp != 0)
                        {
                            TsAmount = TsAmount.PadLeft(19 - itemp, ' ');
                        }

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();
                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = TQty.ToString();
            TTQty = TTQty.PadLeft(50, ' ');

            TTAmount = _Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(39, ' ');
            AmountInWords _word = new AmountInWords();
            AmountinWords = AmountinWords + " " + _word.ConvertAmount(Convert.ToDouble(txtbillamount.Text));
            string OtherizedSignature = "Authorized Signatory".PadLeft(80, ' ');
            string YourBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Lblpartybalance.Text));
            if (commodeofpayment.SelectedIndex == 1)
            {
                double tempyourbalance = Convert.ToDouble(YourBalance);
                tempyourbalance = tempyourbalance + Convert.ToDouble(txtbillamount.Text);
                YourBalance = tempyourbalance.ToString();
            }
            string BiilDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(txttinvoicediscount.Text));

            string strTaxamt = txtttax.Text;
            strTaxamt = strTaxamt.PadLeft(27, ' ');

            string Visitagain = "***Thank you visit again***".PadLeft(50);
            double DbSavedAmt = NetMrp - NetSrate;

            if (DbSavedAmt > 0)
            {
                SavedAmount = _Dbtask.SetintoDecimalpoint(DbSavedAmt);
            }
            string ItemDiscount = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(TxttItemDiscount.Text));
            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter;
            if (Convert.ToDouble(txttinvoicediscount.Text) > 0)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n                                            Bill Discount :" + BiilDiscount.PadLeft(25, ' ');
            }
            if (Convert.ToDouble(TxttItemDiscount.Text) > 0)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n                                            Item Discount :" + ItemDiscount.PadLeft(25, ' ');
            }
            string Cooly = txtotherexpenses.Text;
            Cooly = Cooly.PadLeft(22, ' ');
            RichTextBox1.Text = RichTextBox1.Text + "\n                                            Tax Amount" + strTaxamt + "\n                                            Other Expense" + Cooly + " \n\n                                           Total         :" + txtbillamount.Text.PadLeft(27, ' ') + "\n\nIn Words: " + AmountinWords + "\n\nYour Saved Amount :" + SavedAmount + "\n\n" + OtherizedSignature + "\n" + Visitagain + "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
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
                    return convert(amount_int) +" "+ Frms._Gen.Getmajorsymbol() +" and " +
                            convert(amount_dec) + " " + Frms._Gen.Getminerymbol();
                }
                catch (Exception e)
                {
                    // TODO: handle exception
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
        public string Pnamespace(string Pname)
        {
            return Pname;
        }
        public void PrintInvoice()
        {
            try
            {

                if (ChkShowPreview.Checked == true)
                {
                    Frmprintmain _Print = new Frmprintmain();
                    if (Printerselect == "1")
                        _Print.Pselect = "1";
                    _Print.Richtext = RichTextBox2.Text;
                    _Print.ShowDialog();
                }

            }
            catch
            {
            }

        }

        private void CmdBack_Click(object sender, EventArgs e)
       {
          GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);
            if (EditMode == true)
            {
                txtpaid.Enabled = false;
            }
        }

        private void ComAccount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComTax.Focus();
            }

        }

        
        private void frmsalesinvoice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                _Nextg.CloseGriddetail(gridmain, this);
            }
            
        }

       
        private void TxtProduct_TextChanged_1(object sender, EventArgs e)
        {
            
            ProductGridShow(" where itemCode Like N'%" + TxtProduct.Text + "%' OR itemName Like N'%" + TxtProduct.Text + "%'");

        }

        private void TxtProduct_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyValue == 27)
                {
                    if (TxtProduct.Text == "")
                    {
                        _Nextg.CloseGriddetail(gridmain, this);
                    }
                    else
                    {
                        TxtProduct.Text = "";
                    }
                }
            }
            catch
            {
            }
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
                        NQty = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
                        NFree = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
                        NRate = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
                        NDiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
                        NDiscper = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
                        NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);
                        NTaxamount = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clntax"].Value);

                        //if (SUnit == true)
                        //{
                        //    if (ComText == true)
                        //    {
                        //        Pcode = Ds.Tables[0].Rows[i]["Pcode"].ToString();
                        //        if (Vtype == "SI" || Vtype == "DN" || Vtype == "SO")
                        //        {
                        //            Unitid = _Dbtask.ExecuteScalar("select UnitId from TblIssuedetails where IssueCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                        //        }
                        //        if (Vtype == "SR")
                        //        {
                        //            Unitid = _Dbtask.ExecuteScalar("select UnitId from TblReceiptDetails where RecptCode='" + txtvno.Text + "' and pcode='" + Pcode + "' and vtype='" + Vtype + "'");
                        //        }
                        //        string Unit = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where Id='" + Unitid + "'");
                        //        gridmain.Rows[i].Cells["ClnUnit"].Value = Unit;
                        //        gridmain.Rows[i].Cells["ClnUnit"].Tag = Unitid;
                        //        UnitName = Unit;
                        //        UnitAmountCalc();
                        //    }
                        //    else
                        //    {
                        //        string unitid = gridmain.Rows[i].Cells["ClnUnit"].Tag.ToString();
                        //        UnitName = _Dbtask.ExecuteScalar("select Name from tblUnitcreation where id='" + unitid + "'");
                        //        ItemId = gridmain.Rows[i].Cells["clnItemName"].Tag.ToString();
                        //        UnitAmountCalc();
                        //    }
                        //}
                        CellEnterCalculationPart();
                    }
                }
            }
            TottalAmountCalculate(true);
        }
        private void ComTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComTextChange();
        }

        private void TxtProduct_Enter(object sender, EventArgs e)
        {
            TxtProduct.Focus();
        }

        private void TxtTempPartyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            _Nextg.CloseGriddetail(gridmain, this);
        }

        private void CmdForward_Click(object sender, EventArgs e)
        {
            GetPrevious((Convert.ToInt64(txtvno.Tag) + 1).ToString(), false);
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                if (_UserDetails.Permited() == true)
                {
                    DialogResult Result = MessageBox.Show("Are you sure want to Delete !", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Result.ToString() == "Yes")
                    {
                        DeleteVoucher();
                        ForLogindetails("DELETE");
                        Clear();
                    }
                }
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

        private void ComStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Comemployee.SelectedValue != null)
            {
                staffid = Comemployee.SelectedValue.ToString();
            }
            else
            {
                staffid = "0";
            }
        }

        private void txtotherexpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
            _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void TxtAgentAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
            _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void TxtStaffAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Generalfunction.allowNumeric(sender, e, false);
            _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void ComDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockareaId = ComDepot.SelectedValue.ToString();
        }

        private void TxtStaffAmt_TextChanged(object sender, EventArgs e)
        {
            Txtemployeeamt.Text = _Gen.avoidnullDecimal(Txtemployeeamt.Text);
        }

        private void TxtAgentAmt_TextChanged(object sender, EventArgs e)
        {
            TxtAgentAmt.Text = _Gen.avoidnullDecimal(TxtAgentAmt.Text);
        }

        public void Truesearchbarcode()
            {
            if (SBatch == true)
            {
                SearchBarcode = true;
                dataGridViewCellStyleNew.BackColor = System.Drawing.Color.MediumVioletRed; //System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                Chksearchingmode.Checked = true;
            }
        }
        public void Falsesearchbarcode()
        {
            if (SBatch == true)
            {
                SearchBarcode = false;
                uscGridshow2.Visible = false;
               // dataGridViewCellStyleNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
                dataGridViewCellStyleNew.BackColor = System.Drawing.Color.Teal;
                dataGridViewCellStyleNew.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                dataGridViewCellStyleNew.ForeColor = System.Drawing.Color.White;
                gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleNew;
                Chksearchingmode.Checked = false;
            }
        }

        private void frmsalesinvoice_KeyDown(object sender, KeyEventArgs e)
                {

            if (e.KeyData == Keys.F10)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyData == Keys.F1)
                {
                //if (CommonClass._Menusettings.GetMnustatus("181") == "1")
                //{
                //    PrintSecondprint = true;
                //    if (PrintSecondprint == true)
                //    {
                //        Secndnow = true;
                //        Printerselect = "mode3";
                //        Selectedprint = _Dbtask.GetPrinterName2();
                //    }
                 Main();
                    Secndnow = false;
                //}
            }
            if (e.KeyValue == 116)
            {
                Main();
            }
            if (e.KeyValue == 119)
            {
                InvoiceProfitCalculation();
            }

            if (e.KeyValue == 18)/*F4 Using Active Row Focusing*/
            {
                if (SBatch == true)
                    CommonClass.temp = "clnbatch";
                else
                    CommonClass.temp = "clnitemcode";
                    CommonClass._Ingrid.FocusStartingRow(gridmain, CommonClass.temp);
            }

            if (e.KeyValue == 123)
            {
               
                if (SearchBarcode == true)
                {
                    Falsesearchbarcode();
                }
                else
                {
                    Truesearchbarcode();
                }
            }
            //if (Generalfunction.Newformsales == true)
            //{
            // SendKeys.Send("+{tab}");
            // e.SuppressKeyPress = true;
            // Generalfunction.Newformsales = false;
            //}
            }

        private void txtotherexpenses_TextChanged(object sender, EventArgs e)
        {
            txtotherexpenses.Text = _Gen.avoidnullDecimal(txtotherexpenses.Text);
        }

        public void TxtaccountTextchangeworking()
                {
            if (IsEnter == false && Isinotherwindow == false && Retrivemode == 0)
            {

               
                Gridcustomerlist.Visible = true;
                Gridcustomerlist.Rows.Clear();

                if (SearchCreditor == 0)/*Not Iclude Suppliers*/
                {
                    temp = _AccountGroup.ShowCustomerAccount("");
                    if (Salesarea == true)
                    {
                        Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where   Agroupid in(" + temp + ") and area='" + comsalesarea.SelectedValue + "'  AND    lname like N'%" + TxtAccount.Text + "%' OR laliasName like N'%" + TxtAccount.Text + "%' or mobile like N'%" + TxtAccount.Text + "%'  ");
                    }
                    else
                    {
                        Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where ( lname like N'%" + TxtAccount.Text + "%' OR laliasName like N'%" + TxtAccount.Text + "%' or mobile like N'%" + TxtAccount.Text + "%' )  and Agroupid in(" + temp + ") ");
                    }
                }
                if (SearchCreditor == 1)/* Iclude Suppliers*/
                {
                  
                    temp = _AccountGroup.ShowSupplierAndCustomerAccount("");
                    if (Salesarea == true)
                    {
                        Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + TxtAccount.Text + "%' OR laliasName like N'%" + TxtAccount.Text + "%' or mobile like N'%" + TxtAccount.Text + "%'  and Agroupid in(" + temp + ") and area='" + comsalesarea.SelectedValue + "'");
                    }
                    else
                    {
                        Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(" where ( lname like N'%" + TxtAccount.Text + "%' OR laliasName like N'%" + TxtAccount.Text + "%' or mobile like N'%" + TxtAccount.Text + "%' )  and Agroupid in(" + temp + ") ");
                    }
                }
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gridcustomerlist.Rows.Add(1);
                    Gridcustomerlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["lname"];
                    Gridcustomerlist.Rows[i].Cells[1].Value = Ds.Tables[0].Rows[i]["mobile"];
                    
                    
                    if (_Dbtask.znllString(Ds.Tables[0].Rows[i]["Taxregno"]) != "0.00" && _Dbtask.znllString(Ds.Tables[0].Rows[i]["Taxregno"]) != "")
                    {
                        Gridcustomerlist.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Ivory;
                    }
                    else
                    {
                     //   Gridcustomerlist.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
                    }
                    Gridcustomerlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["lid"];
                }
            }
        }

        public void Txtaccountleaveworking()
                        {
            if (commodeofpayment.SelectedIndex == 1 && TxtAccount.Tag == null)
            {
                MessageBox.Show("Select Customer");
            }
            if (TxtAccount.Text != "" && commodeofpayment.SelectedIndex == 1)
            {
                txttempNames.Text = _Dbtask.znllString(TxtAccount.Text);
                Lbltemporarydetails.Tag = _Dbtask.znllString(TxtAccount.Tag);

                TXTtMOB.textBox1.Text = "";
                txtTaddrss.textBox1.Text = "";
                TxtxTvat.Text = "";
                TxtTcustmr.Text = "";
                
                    


            }
            if (TxtAccount.Text == "" )
            {
                Lbltemporarydetails.Tag = "";
                txttempNames.Text = "";
            }

        }

        public void TxtaccountEnterworking()
        {
            IsEnter = false;
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();

            dtdue.Value = DateTime.Now; ;
        }

        public void ControleClick(Control Cntrl)
        {
            Cntrl.Focus();
            Cntrl.Select();
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

        private void TxtStaffAmt_Click(object sender, EventArgs e)
        {
            Txtemployeeamt.Focus();
            Txtemployeeamt.Select();
        }


        private void txtotherexpenses_Click(object sender, EventArgs e)
        {
            txtotherexpenses.Focus();
            txtotherexpenses.Select();
        }

        private void Txtcashreceived_Click(object sender, EventArgs e)
        {

            txtotherexpenses.Select();
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

      
        private void commodeofpayment_SelectedIndexChanged(object sender, EventArgs e)
                                                {
                    if (Retrivemode == 0)
            {
                if (commodeofpayment.SelectedIndex == 0)
                {

                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {
                        txttempNames.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(Lbltemporarydetails.Tag));
                    } 
                    TxtAccount.Tag = 1;
                    txtpaid.Enabled = false;
                    TxtAccount.Text = "CASH";

                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {
                        txttempNames.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(Lbltemporarydetails.Tag));
                    }
                    Gridcustomerlist.Visible = false;
                  //  txtpaid.textBox1.Text = _Dbtask.SetintoDecimalpoint(0);
                }
                else if(commodeofpayment.SelectedIndex==1)
                {
                    if (TxtAccount.Text == "")
                    {
                        TxtAccount.Tag = null;
                    }
                    if (TxtAccount.Text.ToLower() == "cash" || TxtAccount.Text.ToLower() == "bank")
                    {
                        TxtAccount.Tag = "";
                        TxtAccount.Text = "";
                    }
                    if (TxtAccount.Tag == "1" || TxtAccount.Tag == "28")
                    {
                        TxtAccount.Tag = "";
                        TxtAccount.Text = "";
                    }


                    else
                    {
                        string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname =N'" + TxtAccount.Text + "'");
                        TxtAccount.Tag = temp;
                    }
                    txtpaid.Enabled = true;
                }
                else if (commodeofpayment.SelectedIndex == 2)
                {
                    TxtAccount.Tag = "28";
                    TxtAccount.Text = "BANK";


                    if (_Dbtask.znllString(Lbltemporarydetails.Tag) != "")
                    {
                        txttempNames.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(Lbltemporarydetails.Tag));
                    } 

                        string temp = _Dbtask.ExecuteScalar("select lid from tblaccountledger where UseCard=1");
                        if (temp == "")
                        {
                            TxtAccount.Tag = "28";
                            TxtAccount.Text = "BANK";
                            // txtCustomer.Text = _Dbtask.ExecuteScalar("select LName from tblaccountledger where AGroupId='24'");
                        }
                        else
                        {
                            TxtAccount.Tag = temp;
                            TxtAccount.Text = CommonClass._Ledger.GetspecifField("lname", temp);
                        }
                        Gridcustomerlist.Visible = false;
                }
            }
        }

        private void commodeofpayment_KeyDown(object sender, KeyEventArgs e)
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
                    TxtAccount.Focus();
                }
            }
        }

        private void commodeofpayment_Click(object sender, EventArgs e)
        {
            commodeofpayment.Select();
            commodeofpayment.Focus();
        }


        public void showCashreceipt()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.mode = 0;
            // _Cash.MdiParent = this;
            _Cash.ShowDialog();
        }

        private void cmdselectprinter_Click(object sender, EventArgs e)
        {
            MyPrinter.ChoosePrinter();
        }

        private void comratetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    RowValidation();

            //    for (int i = 0; i < gridmain.Rows.Count; i++)
            //    {

            //        if (gridmain.Rows[i].Tag != null)
            //        {
            //            if (gridmain.Rows[i].Tag.ToString() == "1")
            //            {
            //                rowindex = i;
            //                ItemId = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();

            //                string tempitemid = gridmain.Rows[rowindex].Cells["clnitemname"].Tag.ToString();

            //                if (comratetype.SelectedValue.ToString() != "0")
            //                {
            //                    double Sratesecondery;
            //                    Sratesecondery = 0;
            //                    Ds2 = _Dbtask.ExecuteQuery("select * from tblproductrate where pcode='" + tempitemid + "'");
            //                    if (Ds2.Tables[0].Rows.Count > 0)
            //                    {
            //                        Sratesecondery = Convert.ToDouble(Ds2.Tables[0].Rows[Ds2.Tables[0].Rows.Count - 1]["rate"].ToString());
            //                    }

            //                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);

            //                }
            //                else
            //                {
            //                    double Sratesecondery = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(srate,0) from tblitemmaster where itemid='" + tempitemid + "'"));
            //                    gridmain.Rows[rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(Sratesecondery);
            //                }
            //                RefreshCellenterCalc();
            //                TaxCalcPart();
            //                CellEnterCalculationPart();
            //                TaxCalcPart();

            //            }
            //        }
            //    }


            //    TottalAmountCalculate(true);
            //}
            //catch
            //{
            //}
        }



        public void ClearSizeInisilise()
        {
            SizeQty = "0";
            SizeRate = "0";
            SizeNaration = "";
        }
        public bool RowValidation()
                            {
            try
            {


                //getfrstrowval();


                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null)
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {

                        if (SBatch == true)
                        {
                            if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) > 0)
                            {
                                if (_Dbtask.znllString(gridmain.Rows[i].Cells["clnbatch"].Value) == "")
                                {
                                    MessageBox.Show("Barcode is empty .Line number = " + (i + 1).ToString());
                                    return false;


                                }
                            }


                            if (gridmain.Rows[i].Cells["clnitemname"].Tag != null && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) <= 0)
                            {
                                MessageBox.Show("Check Amount Line number = " + (i + 1).ToString());
                                return false;

                            }


                        }



                        if (SSaveZeroRate == true)
                        {
                            if (_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnqty"].Value) == 0)
                            {
                                MessageBox.Show("Fill Qty ", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                gridmain.CurrentCell = gridmain.Rows[i].Cells["clnqty"];
                                return false;
                            }
                            else
                            {

                                if (frstibool == false)
                                {
                                    frstival = i;
                                    frstibool = true;
                                }

                                gridmain.Rows[i].Tag = 1;
                                gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                            }
                        }
                        else
                        {

                            if (_Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) <= 0)
                            {
                                MessageBox.Show("Check Qty Or Rate", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                gridmain.CurrentCell = gridmain.Rows[i].Cells["clnqty"];
                                return false;
                            }
                            else
                            {



                                if (frstibool == false)
                                {
                                    frstival = i;
                                    frstibool = true;
                                }
                                gridmain.Rows[i].Tag = 1;
                                gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                            }
                        }
                    }
                }


                frstibool = false;

            }
            catch
            {
            }
            return true;
        }

        public void getfrstrowval()
        {
            int allrowval = 0; frstival = 0; allrowval = 0;
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag != "" && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) > 0)
                    {
                        if(frstibool==false)
                        {
                            frstival = i;
                            frstibool = true;
                        }

                       
                    }
                    if (gridmain.Rows[i].Cells["clnitemname"].Tag == null && _Dbtask.znlldoubletoobject(gridmain.Rows[i].Cells["clnnettamount"].Value) <= 0)
                    {
                        allrowval = i;
                    }
                }

                int lastval = 0;
                lastval = (frstival + allrowval) - (allrowval);



                frstibool = false;
            }
            catch
            {
            }
        }
        public void FlexInMainGrid()
        {
            try
            {
                int Columnindexgridsizes = Datagridsizes.CurrentCell.ColumnIndex;
                int Cout = Datagridsizes.Columns.Count - 1;
                int SizeCurentrow = Datagridsizes.CurrentCell.ColumnIndex;
                double TtQty = new double();
                if (Cout == SizeCurentrow && IsEnterSize == false)
                {
                    double FMqty = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfmqty"].Value);
                    double FRate = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfrate"].Value);
                    double FHieght = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfhiegth"].Value);
                    double FWidth = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfwidth"].Value);
                    double FSqureFeet = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfsfeet"].Value);
                    double FActualQty = FSqureFeet * FMqty;

                    gridmain.Rows[rowindex].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(FActualQty);
                    gridmain.Rows[rowindex].Cells["clnslno"].Value = rowindex + 1;
                    gridmain.Rows[rowindex].Cells["clnslno"].Tag = FSqureFeet;
                    gridmain.Rows[rowindex].Cells["clngross"].Tag = FMqty;
                    gridmain.Rows[rowindex].Cells["clnnettamount"].Tag = FWidth;
                    gridmain.Rows[rowindex].Cells["clnqty"].Tag = FHieght;

                    gridmain.Rows[rowindex].Cells["Clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + ItemId + "'");
                    gridmain.Rows[rowindex].Cells["ClnMRP"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + ItemId + "'");
                    NMrp = Convert.ToDouble(_Dbtask.ExecuteScalar("select mrp from tblitemmaster where itemid='" + ItemId + "'"));

                    NQty = Convert.ToDouble(FActualQty);
                    NRate = Convert.ToDouble(FRate);

                    CellEnterCalculationPart();
                    TottalAmountCalculate(true);

                    IsEnterSize = true;
                    Pnlsizes.Visible = false;

                    gridmain.CurrentCell = gridmain.Rows[rowindex + 1].Cells["clnitemcode"];
                    gridmain.Focus();


                }
            }
            catch
            {
            }

        }
        /*Sizes function Following********************************************************************8*/
        public void SizeItemsinMainGrid()
        {
            try
            {
                int Columnindexgridsizes = Datagridsizes.CurrentCell.ColumnIndex;
                int Cout = Datagridsizes.Columns.Count;
                int SizeCurentrow = Datagridsizes.CurrentCell.ColumnIndex+1;
                double TtQty = new double();
                if (Cout == SizeCurentrow && IsEnterSize == false)
                {
                    for (int i = 1; i < Datagridsizes.Columns.Count; i++)
                    {
                        string Columnname = Datagridsizes.Columns[i].Name;
                        double DQty = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells[i].Value);
                        double SizeSrate = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnsizerate"].Value);
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
                                gridmain.Rows[rowindex].Cells["Clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + tempid + "'");
                                gridmain.Rows[rowindex].Cells["ClnMRP"].Tag = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + tempid + "'");
                                NMrp = Convert.ToDouble(_Dbtask.ExecuteScalar("select mrp from tblitemmaster where itemid='" + tempid + "'"));
                                NQty = DQty;
                                NRate = Convert.ToDouble(SizeSrate);

                                CellEnterCalculationPart();
                                TottalAmountCalculate(true);
                            }
                        }


                    }
                    IsEnterSize = true;
                    Pnlsizes.Visible = false;
                    gridmain.CurrentCell = gridmain.Rows[rowindex + 1].Cells["clnitemcode"];
                    gridmain.Focus();
                }
            }
            catch
            {
            }
        }
        public void LoadColumnInFlex()
        {
            Datagridsizes.Rows.Clear();
            Datagridsizes.Columns.Clear();

            IsEnterSize = false;
            Pnlsizes.Visible = true;

            Datagridsizes.Columns.Add("clnfhiegth", "Hieght");
            Datagridsizes.Columns.Add("clnfwidth", "Width");
            Datagridsizes.Columns.Add("clnfsfeet", "S.Feet");
            Datagridsizes.Columns.Add("clnfrate", "Rate");

            Datagridsizes.Columns.Add("clnfmqty", "MQty");
            Datagridsizes.Columns["clnfsfeet"].ReadOnly = true;
            Pnlsizes.Focus();
            Datagridsizes.Select();
            Datagridsizes.CurrentCell = Datagridsizes.Rows[0].Cells[0];
            double FTempsrate = Convert.ToDouble(_ItemMaster.SpecificField(ItemId, "srate"));
            Datagridsizes.Rows[0].Cells["clnfrate"].Value = _Dbtask.SetintoDecimalpoint(FTempsrate);
        }

        public void CalcSquerfeet()
        {
            Nsqfeat=Nwidth*Nlength;
            Nsqfeat=Nsqfeat/92912;
            gridmain.Rows[rowindex].Cells["clnsqfl"].Value = _Dbtask.SetintoDecimalpoint(Nsqfeat);
        }

        public void LoadColumnInSize()
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

            /*For Stock Balance*/

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
                Datagridsizes.Columns.Add("clnsizerate", "Srate");
                Datagridsizes.Rows[0].Cells["clnsizerate"].Value = _ItemMaster.SpecificField(ItemId, "srate");
                Pnlsizes.Focus();
                Datagridsizes.CurrentCell = Datagridsizes.Rows[0].Cells[0];
            }
        }

        public void GetExpiryDateonBatch(string BatchcodeTemp, string ItemidTemp)
        {
            if(Spharmacy==true)
                gridmain.Rows[rowindex].Cells["clnexpiry"].Value =Convert.ToDateTime(CommonClass._Batch.GetSpecificFieldofBatchWithItemid(BatchcodeTemp, "Exdate", ItemidTemp)).ToString("dd/MM/yyyy");
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
                Rate = _Dbtask.znullDouble(gridmain.Rows[ZRowIndex].Cells["clnsrate"].Value.ToString());
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
        /************************************************************************/

        public void RefreshCellenterCalc()
        {

            NRate = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
            NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);
            NQty = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnqty"].Value);
            NFree = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnfree"].Value);
            NRate = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnsrate"].Value);
            NTaxamount = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clntax"].Value);
            NDiscamt = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscount"].Value);
            NDiscper = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clndiscper"].Value);
            NMrp = Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnmrp"].Value);

        }
        private void comratetype_Click(object sender, EventArgs e)
        {
            comratetype.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxttItemDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmoptions_Click(object sender, EventArgs e)
        {
            Showoptionwindow();
        }
        public void Showoptionwindow()
        {
            if (pnloption.Visible == true)
            {
                pnloption.Visible = false;
            }
            else
            {
                pnloption.Visible = true;
                this.pnloption.Size = new System.Drawing.Size(623, 313);
            }
        }

        private void pnloptions_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                Showoptionwindow();
            }
        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            TxtaccountTextchangeworking();
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
                {
                try
                {

                    Lbltemporarydetails.Tag = "";
                    txttempNames.Text = "";
                    

                    if (e.KeyValue == 114 && e.Modifiers == Keys.Alt)/*For F3*/
                    {
                        (this.MdiParent as MDIParent2).mnucustomercreate.PerformClick();
                        commodeofpayment.SelectedIndex = 1;
                    }
                    if (IsEnter == false)
                    {
                        if (e.KeyValue == 123)/*For F12*/
                        {
                            if (SearchCreditor == 1)
                            {
                                SearchCreditor = 0;
                            }
                            else
                            {
                                SearchCreditor = 1;
                            }
                        }
                        if (Gridcustomerlist.Rows.Count > 1)
                        {
                            selectedRow = Gridcustomerlist.SelectedRows[0].Index;
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
                                    if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("215")) == "1")
                                    {
                                        if (Gridcustomerlist.SelectedRows.Count > 0)
                                                {

                                            Lbltemporarydetails.Tag = "";
                                            selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                                            IsEnter = true;
                                            txttempNames.Text = CommonClass._Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Value);
                                            TxtAccount.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                                            Ledid = CommonClass._Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag);
                                            TxtAccount.Tag = Ledid;
                                            Lbltemporarydetails.Tag = Ledid;
                                            commodeofpayment.SelectedIndex = 1;
                                            TxtAccount.Tag = Ledid;
                                            Lbltemporarydetails.Tag = Ledid;
                                            comsalesarea.SelectedValue =Convert.ToInt32( CommonClass._Ledger.GetspecifField("area", Ledid));



                                                if (Ledid != "")//&& commodeofpayment.SelectedIndex!=0
                                            {
                                                if (CommonClass._Warnings.CheckCreditLimit(Ledid, 0))
                                                {
                                                    if (commodeofpayment.SelectedIndex == 1)
                                                    {
                                                        TxtAccount.Tag = Ledid;
                                                    }

                                                }
                                                else
                                                {
                                                    TxtAccount.Tag = null;
                                                    TxtAccount.Text = "";
                                                }
                                            }
                                            Gridcustomerlist.Visible = false;
                                            Lblpartybalance.Visible = true;
                                            nocustmr = false;
                                            //string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                                            string Mob = CommonClass._Ledger.GetspecifField("mobile", TxtAccount.Tag.ToString());
                                            txtmobilee.textBox1.Text = Mob.ToString();
                                            txtmobilee.textBox1.Tag = Ledid;

                                            if (_Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("112233"))=="1")
                                            {
                                                Lblpartybalance.Text =_Dbtask.znllString( _AccountLedger.Balanceofledger(TxtAccount.Tag.ToString()));
                                            }
                                                else
                                                {
                                                    Lblpartybalance.Text="";
                                                }


                                            txttempNames.Text = CommonClass._Dbtask.znllString(TxtAccount.Text);
                                            
                                            if (Spartyproject == true)
                                            {
                                                CommonClass._Partyproject.FillComboPartyproject(false, TxtAccount.Tag.ToString(), comcustomerproject);
                                            }
                                            if (Mob != "")
                                            {
                                                lblledgertext.Text = "Customer(F3 New) زبون" + " " + Mob;
                                            }
                                            //  Lblpartybalance.Text = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                                            //if (SBatch == true)
                                            //{

                                            //}
                                            //else
                                            //{

                                            //}
                                            IsEnter = true;
                                        }
                                        }

                                   //MPYCASH WITHCUST
                                 else   if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("215")) == "-1")
                                    {

                                        if (Gridcustomerlist.SelectedRows.Count > 0 || commodeofpayment.SelectedIndex == 0)
                                        {

                                            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("215")) == "-1")
                                            {

                                               // Lbltemporarydetails.Tag = "";
                                                txttempNames.Text = "";
                                                txttempNames.Text = CommonClass._Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Value);

                                                selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                                                IsEnter = true;
                                                TxtAccount.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();

                                                TXTtMOB.textBox1.Text = "";
                                                txtTaddrss.textBox1.Text = "";
                                                TxtxTvat.Text = "";
                                                TxtTcustmr.Text = "";
                                                nocustmr = false;
                                                Ledid = CommonClass._Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag);
                                                TxtAccount.Tag = Ledid;

                                                TxtAccount.Tag = Ledid;
                                               // Lbltemporarydetails.Tag = Ledid;
                                                if (Ledid != "")//&& commodeofpayment.SelectedIndex!=0
                                                {
                                                    if (CommonClass._Warnings.CheckCreditLimit(Ledid, 0))
                                                    {

                                                        TxtAccount.Tag = Ledid;

                                                    }
                                                    else
                                                    {
                                                        TxtAccount.Tag = null;
                                                        TxtAccount.Text = "";
                                                    }
                                                }
                                                Gridcustomerlist.Visible = false;
                                                Lblpartybalance.Visible = true;

                                                string Mob = CommonClass._Ledger.GetspecifField("mobile", TxtAccount.Tag.ToString());
                                                txtmobilee.textBox1.Text = Mob.ToString();
                                                txtmobilee.textBox1.Tag = Ledid;
                                                if (Spartyproject == true)
                                                {
                                                    CommonClass._Partyproject.FillComboPartyproject(false, TxtAccount.Tag.ToString(), comcustomerproject);
                                                }
                                                if (Mob != "")
                                                {
                                                    lblledgertext.Text = "Customer(F3 New) زبون" + " " + Mob;
                                                }

                                                commodeofpayment.SelectedIndex = 0;
                                                IsEnter = true;
                                                TxtAccount.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                                                TxtAccount.Tag = Ledid;
                                            }

                                        }
                                    }



                                 //MPYCASH WITHCUST
                                    else
                                    {
                                        TxtAccount.Text = TxtAccount.Text;
                                        Gridcustomerlist.Visible = false;
                                        nocustmr = true;
                                        //if (nocustmr == true && txtmobilee.textBox1.Text != null)
                                        //{
                                        //    createacustmr();

                                        //}
                                        IsEnter = true;
                                        if (SBatch == true)
                                        {
                                        }
                                        else
                                        {
                                        }
                                    }


                                }

                                IsEnter = false;


                            }
                            catch
                            {
                            }

                        }

                    }
                    }

                catch
                {
                }
        }
        public void createacustmr()
            {
            int grpid=18;
            int soomeid=0;
            double blnce=0;
            int stts=-1;
            maxledid = _Dbtask.ExecuteScalar("select max(lid) from tblaccountledger");
            int nextid = 0;
            nextid = Convert.ToInt32(maxledid) + 1;
           // TxtAccount.Tag = nextid.ToString();
            _AccountLedger.LidLng = Convert.ToInt32(nextid.ToString());
            _AccountLedger.LNameStr = TxtAccount.Text.ToString();
            _AccountLedger.LAliasNameStr=TxtAccount.Text.ToString();
            _AccountLedger.GidLng= grpid;
            _AccountLedger.AddressStr="";
            _AccountLedger.PhoneStr="";
            _AccountLedger.MobileStr=txtmobilee.textBox1.Text.ToString();
            _AccountLedger.DiscDb=blnce;
            _AccountLedger.TaxRegNoStr="";
            _AccountLedger.EmailStr="";
            _AccountLedger.AreaStr = soomeid.ToString();
            _AccountLedger.CreditDaysInt=blnce;
           _AccountLedger.CreditLimitDb=blnce;
           _AccountLedger.OtherStr="";
          _AccountLedger.BalanceDb=blnce;
         _AccountLedger.Commision=blnce;
          _AccountLedger.Cplan=soomeid;
        _AccountLedger.Lstatus=stts;
       _AccountLedger.Lstatus2=stts;
       _AccountLedger.CST = "";
      _AccountLedger.CpBalance = blnce;
       _AccountLedger.UseCard = stts;
       _AccountLedger.InsertLedger();
      // MessageBox.Show("Customer creation is completed.");
       txtmobilee.textBox1.BackColor = Color.White;


            
        }
       

        private void TxtAccount_Enter(object sender, EventArgs e)
        {
            TxtaccountEnterworking();
        }

        private void TxtAccount_Leave(object sender, EventArgs e)
        {

            Txtaccountleaveworking();
        }

        private void TxtAccount_Click(object sender, EventArgs e)
        {
            ControleClick(TxtAccount);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (SSsizes == false)
                {
                    pictureBox1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
                }
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
            //, 8.25pt
                if (RichTextBox1.Text != "")
            {
                // int XX = 75;
                // int YY = 25;
                //XX = 250;
                XX = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Leftleser"));
                Font headerFont;
                Font Headaddress;
                Font mainheaderFont;
                if (CommonClass.ETailering == true)
                {

                    headerFont = new System.Drawing.Font("Lucida Console", 12);
                    mainheaderFont = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                    YY = 50;
                }
                else if (Printerselect == "9" || SSsizes == true)
                {

                    headerFont = new System.Drawing.Font("Lucida Console", 10F);
                    mainheaderFont = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                    YY = 50;
                }
                else
                {
                    mainheaderFont = new System.Drawing.Font("Calibri", 13, FontStyle.Bold);
                    headerFont = new System.Drawing.Font("Lucida Console", 8);
                    //if (XX < 80)
                    //{

                    //    XX = 5;
                    //    mainheaderFont = new System.Drawing.Font("Calibri", 10, FontStyle.Bold);
                    //    headerFont = new System.Drawing.Font("Lucida Console", 8);
                    //}
                    //else
                    //{
                    //    mainheaderFont = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    //    headerFont = new System.Drawing.Font("Lucida Console", 10);
                    //}                   
                }
                if (SFlex == true)
                    XX = 50;
                string CompanyName = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                string Add = "High quality Echo friendly Cloth Printing..........";
                if (Printerselect == "10")
                {
                    XX = 70;
                    mainheaderFont = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                    e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX + 200, 400 + 10);
                    e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX + 200, 800);
                }

                if (Printerselect == "10")
                {
                    e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX + 200, 25);
                }
                else
                {
                    if (SFlex == true)
                    {
                        XX = 50;
                        YY = 30;

                        e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, 200, 20);
                        e.Graphics.DrawString(Add, mainheaderFont, Brushes.Black, XX, 490);
                    }
                    else
                    {
                        if (XX == 80)
                            CompanyName = "                                                    " + CompanyName;
                        InvImage = Application.StartupPath + @"\Images\" + "Logo.jpg";
                        if (System.IO.File.Exists(InvImage) && Vtype != "SR")
                        {
                            mainheaderFont = new System.Drawing.Font("Calibri", 18, FontStyle.Bold);
                            Headaddress = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                            Bitmap oInvImage = new Bitmap(InvImage);
                            // Set Image Left to center Image:

                            //  int xImage = XX + (150 - oInvImage.Width) / 2;
                            int xImage = XX;

                            // ImageHeight = oInvImage.Height; // Get Image Height
                            //  e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(45, 5), new System.Drawing.Size(200, 90)));
                            e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(90, 5), new System.Drawing.Size(100, 90)));

                            //  e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(XX+35,5), new System.Drawing.Size(200, 90)));
                            YY = 75;
                            if (ComTax.SelectedIndex != 0)
                            {
                                YY1 = YY1 + 12;
                            }
                            if (Vtype != "SR" && CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToUpper() != "ESTIMATE")
                            {
                                e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX, 117);
                                CompanyName = CommonClass._compMaster.GetspecifField("Nameinhome");
                                e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX, 95);

                                CompanyName = CommonClass._compMaster.GetspecifField("address1");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 145);

                                CompanyName = CommonClass._compMaster.GetspecifField("Telephone");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 165);

                                CompanyName = CommonClass._compMaster.GetspecifField("taxno1");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 180);

                                YY = 202;

                            }
                            else if (Vtype == "SR")
                            {
                                e.Graphics.DrawString("                          Sales return", mainheaderFont, Brushes.Black, XX, 25);
                            }
                            else
                            {
                                e.Graphics.DrawString("                              ESTIMATE", mainheaderFont, Brushes.Black, XX, 25);

                            }
                            //if (_Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text) > 0)
                            //    e.Graphics.DrawString("                                              Discount  :" + Txttypebilldiscount.textBox1.Text.PadLeft(15, ' '), mainheaderFont, Brushes.Black, XX, YY1 + 275);

                            // e.Graphics.DrawString("                                              TOTAL      :" + txtbillamount.Text.PadLeft(15, ' '), mainheaderFont, Brushes.Black, XX, YY1 + 290);
                            //e.Graphics.DrawString("TOTAL            1000.00", mainheaderFont, Brushes.Black, XX, YY+300);

                            //e.Graphics.DrawString("       THANK YOU VISIT AGAIN       ", headerFont, Brushes.Black, XX, YY+350);
                        }
                        else
                        {

                            mainheaderFont = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                            Headaddress = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                            // Bitmap oInvImage = new Bitmap(InvImage);
                            // Set Image Left to center Image:

                            //  int xImage = XX + (150 - oInvImage.Width) / 2;
                            int xImage = XX;

                            // ImageHeight = oInvImage.Height; // Get Image Height
                            //  e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(45, 5), new System.Drawing.Size(200, 90)));
                            //    e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(90, 5), new System.Drawing.Size(100, 90)));

                            //  e.Graphics.DrawImage(oInvImage, new Rectangle(new Point(XX+35,5), new System.Drawing.Size(200, 90)));
                            YY = 25;
                            if (ComTax.SelectedIndex != 0)
                            {
                                YY1 = YY1 + 12;
                            }
                            if (Vtype != "SR" && CommonClass._Ledger.GetspecifField("lname", SalesAccount).ToUpper() != "ESTIMATE")
                            {
                                int j = 60;
                                e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX, 117 - j);
                                CompanyName = CommonClass._compMaster.GetspecifField("Nameinhome");
                                e.Graphics.DrawString(CompanyName, mainheaderFont, Brushes.Black, XX, 85 - j);

                                CompanyName = CommonClass._compMaster.GetspecifField("address1");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 145 - j);

                                CompanyName = CommonClass._compMaster.GetspecifField("Telephone");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 165 - j);

                                CompanyName = CommonClass._compMaster.GetspecifField("taxno1");
                                e.Graphics.DrawString(CompanyName, Headaddress, Brushes.Black, XX, 180 - j);

                                YY = 202 - j;

                            }
                            else if (Vtype == "SR")
                            {
                                e.Graphics.DrawString("                          Sales return", mainheaderFont, Brushes.Black, XX, 25);
                            }
                            else
                            {
                                e.Graphics.DrawString("                              ESTIMATE", mainheaderFont, Brushes.Black, XX, 25);

                            }
                            //if (_Dbtask.znullDouble(Txttypebilldiscount.textBox1.Text) > 0)
                            //    e.Graphics.DrawString("                                              Discount  :" + Txttypebilldiscount.textBox1.Text.PadLeft(15, ' '), mainheaderFont, Brushes.Black, XX, YY1 + 275);

                            // e.Graphics.DrawString("                                              TOTAL      :" + txtbillamount.Text.PadLeft(15, ' '), mainheaderFont, Brushes.Black, XX, YY1 + 290);
                            //e.Graphics.DrawString("TOTAL            1000.00", mainheaderFont, Brushes.Black, XX, YY+300);

                            //e.Graphics.DrawString("       THANK YOU VISIT AGAIN       ", headerFont, Brushes.Black, XX, YY+350);
                        }
                    }
                }

                // e.Graphics.DrawString(RichTextBox1.Text, mainheaderFont, Brushes.Black, XX, YY);

                e.Graphics.DrawString(RichTextBox1.Text, headerFont, Brushes.Black, XX, YY);
                Countrow = Countrow + 50;
                //e.Graphics.DrawString("Total", mainheaderFont, Brushes.Black, XX,25+(Countrow*5));
            }
        }

        private void gridmain_Enter(object sender, EventArgs e)
            {
            //if (gridmain.CurrentCell != null)
            //    gridmain.CurrentCell = gridmain.Rows[gridmain.CurrentCell.RowIndex].Cells["clnitemcode"];
        }

        private void cmdquickreceipt_Click(object sender, EventArgs e)
        {
            showCashreceipt();
        }
        public void ReloadInGrid(DataGridView Dt)
        {
            Grd1 = Dt;

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                string ItemId = Dt.Rows[i].Cells["clnitemname"].Tag.ToString();
                string ItemName = Dt.Rows[i].Cells["clnitemname"].Value.ToString();
                gridmain.Rows[Generalfunction.BindingRow].Cells["clnitemname"].Tag = ItemId;
                gridmain.Rows[Generalfunction.BindingRow].Cells["clnitemname"].Value = ItemName;
            }
        }
        private void cmdreload_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < Grd1.Rows.Count - 1; i++)
            {
                if (Grd1.Rows[i].Cells["clnitemname"].Tag != null)
                {
                    string ItemId = Grd1.Rows[i].Cells["clnitemname"].Tag.ToString();
                    string ItemName = Grd1.Rows[i].Cells["clnitemname"].Value.ToString();
                    string ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + ItemId + "'");
                    string Qty = Grd1.Rows[i].Cells["clnqty"].Value.ToString();
                    string Srate = Grd1.Rows[i].Cells["clnsrate"].Value.ToString();

                    gridmain.Rows[Generalfunction.BindingRow].Cells["clnitemname"].Tag = ItemId;
                    gridmain.Rows[Generalfunction.BindingRow].Cells["clnitemname"].Value = ItemName;
                    gridmain.Rows[Generalfunction.BindingRow].Cells["clnitemcode"].Value = ItemCode;
                    NQty = Convert.ToDouble(Qty);
                    NRate = Convert.ToDouble(Srate);

                    CellEnterCalculationPart();
                    TottalAmountCalculate(true);
                }

            }
        }

        private void Datagridsizes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindexSize = Datagridsizes.CurrentCell.RowIndex;
                columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;
                if (Datagridsizes.Rows[rowindexSize].Cells[columnindexSize].ReadOnly == true)
                {
                    SendKeys.Send("{Tab}");
                    // return true;
                }
            }
            catch
            {
            }
        }
        private void Datagridsizes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            int columnindexSize = Datagridsizes.CurrentCell.ColumnIndex;
            if (SSsizes == true)
            {
                SizeItemsinMainGrid();
            }
            if (SFlex == true)
            {
                FlexInMainGrid();
            }
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
            if (SFlex == true)
            {
                double FHiegth = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfhiegth"].Value);
                double FWidth = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfwidth"].Value);
                double Frate = _Dbtask.znlldoubletoobject(Datagridsizes.Rows[0].Cells["clnfrate"].Value);

                double FSquer = FHiegth * FWidth;
                Datagridsizes.Rows[0].Cells["clnfsfeet"].Value = _Dbtask.SetintoDecimalpointStock(FSquer);
            }
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

        private void comratetype_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(comratetype);
        }

        private void Comemployee_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(Comemployee);
        }

        private void ComAgent_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(ComAgent);
        }

        private void Txtemployeeamt_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(Txtemployeeamt);
        }

        private void TxtAgentAmt_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(TxtAgentAmt);
        }

        private void TxtAccount_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(TxtAccount);
        }
        public void DoubleClickCustomerGrid()
                {
            try
            {

                if (Gridcustomerlist.SelectedRows.Count > 0 )
                {
                    //|| commodeofpayment.SelectedIndex != 0
                    selectedRow = Gridcustomerlist.SelectedRows[0].Index;
                    TxtAccount.Text = Gridcustomerlist.Rows[selectedRow].Cells[0].Value.ToString();
                    TxtAccount.Tag = "";
                    TxtAccount.Tag = _Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag);
                    comsalesarea.SelectedValue = Convert.ToInt32(CommonClass._Ledger.GetspecifField("area", _Dbtask.znllString(  TxtAccount.Tag)));

                    if(CommonClass._Menusettings.GetMnustatus("215") == "1")
                    {
                    
                    
                    if (_Dbtask.znllString( Gridcustomerlist.Rows[selectedRow].Cells[0].Tag) != null)
                    {
                        TxtAccount.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();  
                    }
                    Gridcustomerlist.Visible = false;
                    Lblpartybalance.Visible = true;

                    commodeofpayment.SelectedIndex = 1;
                    Lbltemporarydetails.Tag = "";
                    Lbltemporarydetails.Tag = _Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag); ;
                    txttempNames.Text = "";
                    txttempNames.Text = _Dbtask.znllString(TxtAccount.Text); 
                        string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");

                    Lblpartybalance.Text = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));
                    //if (SBatch == true)
                    //{
                    //}
                    //else
                    //{
                    //}


                    }

                    if (CommonClass._Menusettings.GetMnustatus("215") == "-1")
                    {

                        if (_Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag) != null)
                        {
                            TxtAccount.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                        }
                        Gridcustomerlist.Visible = false;
                        Lblpartybalance.Visible = true;

                        commodeofpayment.SelectedIndex = 0;
                        Lbltemporarydetails.Tag = "";
                        Lbltemporarydetails.Tag = _Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Tag); ;

                        txttempNames.Text = "";
                        txttempNames.Text = _Dbtask.znllString(Gridcustomerlist.Rows[selectedRow].Cells[0].Value); 
                        
                        string Accountid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname ='" + TxtAccount.Text.ToString() + "'");
                        TxtAccount.Tag = Gridcustomerlist.Rows[selectedRow].Cells[0].Tag.ToString();
                        Lblpartybalance.Text = Convert.ToString(_AccountLedger.Balanceofledger(Accountid));

                    }
                }
                else
                {
                    TxtAccount.Text = TxtAccount.Text;
                    Gridcustomerlist.Visible = false;
                    if (SBatch == true)
                    {

                    }
                    else
                    {

                    }

                    TxtAccount.Select();
                }

            }
            catch
            {
            }

        }
        private void Gridcustomerlist_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickCustomerGrid();
        }
        private void frmsalesinvoice_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 121)
            {
                ShowPanelPreBill();
            }
            if (e.KeyValue == 16)
            {
                if (SFlex == true || SSsizes == true)
                {
                    if (ShowSubpanel == true)
                        ShowSubpanel = false;
                    else
                        ShowSubpanel = true;
                }
            }
            /**F6 For Mode of payment Selection*/
            if (e.KeyValue == 117)
            {
                if (commodeofpayment.SelectedIndex == 0)
                {
                    commodeofpayment.SelectedIndex = 2;
                }
                else
                {
                    commodeofpayment.SelectedIndex = 0;
                    TxtAccount.Text = "";
                }
            }
        }

        private void txtentervno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
                        {
                if (e.KeyValue == 13)
                 {
                    string GetVnoStr = txtentervno.Text;
                string GetPreNo = txtentervpreno.Text;

           
            if (Convert.ToInt64( GetVnoStr) >= 1)
            {
                
                if (Vtype == "SI")
                {
                    
                   
                     PreIssueTransaction(GetVnoStr,IsEnter,Vtype,false);
                }
                
            }
    }










                //if (Vtype == "SR")
                //{
                //    if (txtentervno.Text.Length == 3)
                //    {
                //        if(txtentervno.Text.Substring(0,1)=="0")
                //        {
                //            txtentervno.Text = txtentervno.Text.Substring(1, txtentervno.Text.Length - 1);
                //        }
                //        if (txtentervno.Text.Substring(0, 1) == "0")
                //        {
                //            txtentervno.Text = txtentervno.Text.Substring(1, txtentervno.Text.Length - 1);
                //        }
                //        GetVnoStr = txtentervno.Text;
                //    }

                //    string which = comfillingselectvoucher.Text.ToString();
                //    if (which == "Sales")
                //    {
                //        GetVnoStr = _Dbtask.ExecuteScalar("select issuecode  from TblBusinessIssue where  vno='" + GetVnoStr + "' and pvno='" + GetPreNo + "' and issuetype='SI' and ledcodeCr='" + SalesAccount + "'");


                //        PreIssueTransaction(GetVnoStr.ToString(), false, "SI", false);
                //        GetVno();
                    
                //    }
                //    else
                //    {
                //        GetVnoStr = _Dbtask.ExecuteScalar("select reptcode  from Tbltransactionreceipt where  vno='" + GetVnoStr + "'  and recpttype='SR' and ledcodeDr='" + SalesAccount + "'");


                //        PreReceiptTransaction(GetVnoStr.ToString(), false, "SR", false);
                //        }
                        
                //        EditMode = false;
                   
                    
                //}
                //else
                //{
                //    GetVnoStr = _Dbtask.ExecuteScalar("select issuecode  from TblBusinessIssue where  vno='" + GetVnoStr + "' and pvno='" + GetPreNo + "' and issuetype='" + Vtype + "' and ledcodeCr='" + SalesAccount + "'");

                //    GetPrevious(GetVnoStr.ToString(), false);
                   
                //}

                //pnlbill.Visible = false;
                txtentervno.Focus();
            
        }
        public void FillSample()
        {
            string Itemid = gridmain.Rows[0].Cells["clnitemname"].Tag.ToString();
            string ItemCode = gridmain.Rows[0].Cells["clnitemcode"].Value.ToString();
            string ItemName = gridmain.Rows[0].Cells["clnitemname"].Value.ToString();
            double qty = _Dbtask.gridnul(gridmain.Rows[0].Cells["Clnqty"].Value);
            double Srate = _Dbtask.gridnul(gridmain.Rows[0].Cells["clnsrate"].Value);

            for (int i = 0; i < 150; i++)
            {
                int TCount = gridmain.Rows.Add(1);
                gridmain.Rows[TCount].Cells["clnitemname"].Tag = Itemid;
                gridmain.Rows[TCount].Cells["clnitemcode"].Value = ItemCode;
                gridmain.Rows[TCount].Cells["clnitemname"].Value = ItemName;
                rowindex = TCount;
                NQty = qty;
                NRate = Srate;
                CellEnterCalculationPart();
                TottalAmountCalculate(true);
            }
        }

        private void cmreport_Click(object sender, EventArgs e)
        {
            //FrmSelectSalesReport _SelectSales = new FrmSelectSalesReport();
            //_SelectSales.ShowDialog();
        }

        private void mnuitemc_Click_1(object sender, EventArgs e)
        {
            _Forms.ShowItemcreate();
        }

        private void mnupurchaset_Click_1(object sender, EventArgs e)
        {
            _Forms.Showpurchase();
        }

        private void mnusalest_Click_2(object sender, EventArgs e)
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.SalesAccount = _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + Heading + "'");
            _Sales.Heading = Heading;
            _Sales.ShowDialog();
        }
        public void SaveSettings()
        {
         /*For Default Printer*/
            CommonClass.temp = ComPrintSheme.Text;
           // CommonClass._Paramlist.UpdateParamlist("SPrintSelect", "1", CommonClass.temp);
            CommonClass._Dbtask.SetPrinterName(CommonClass.temp);

        }

        private void ChkPrintWileSaving_CheckedChanged(object sender, EventArgs e)
        {
            if (Bmode == true)
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

                _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='" + TempStatus + "'  where menuid='" + 135 + "'");
            }
        }
        private void chkprintconfirmation_CheckedChanged(object sender, EventArgs e)
        {
           
                string TempStatus;
                if (chkprintconfirmation.Checked == true)
                {
                    TempStatus = "1";
                }
                else
                {
                    TempStatus = "-1";
                }

                _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='" + TempStatus + "'  where menuid='" + 136 + "'");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillSample();
        }
        public void PreSave(string IssueCode)
        {
            DataSet ds5;
            ds5 = _Dbtask.ExecuteQuery("select * from tblbusinessissue  where ledcodecr='"+SalesAccount+"' and issuetype='SI' and issuecode<'"+IssueCode+"' order by issuecode desc ");
            for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
            {
                string Issuecode = ds5.Tables[0].Rows[i]["issuecode"].ToString();
                GetPrevious(Issuecode, false);
                Main();
            }
            MessageBox.Show("Pre Saved Completed", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmpresave_Click(object sender, EventArgs e)
        {
            PreSave(txtvno.Tag.ToString());
        }

        private void cmdclosesysmbol_Click(object sender, EventArgs e)
        {
            _Nextg.CloseGriddetail(gridmain, this);
        }
        private void ChkShowPreview_CheckedChanged(object sender, EventArgs e)
        {
            string TempStatus;
            if (ChkShowPreview.Checked == true)
            {
                TempStatus = "1";
            }
            else
            {
                TempStatus = "-1";
            }

            _Dbtask.ExecuteNonQuery("update tblmnusettings set status ='" + TempStatus + "'  where menuid='" + 138 + "'");
        }

        private void ComPrintSheme_MouseClick(object sender, MouseEventArgs e)
        {
            _Ingrid.FocusinControl(ComPrintSheme);
        }

        private void ComPrintSheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtenterSlnotracking_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string Slno = txtenterSlnotracking.Text;
                Ds = _Dbtask.ExecuteQuery("select issuecode from tblissuedetails where ='"+Slno+"'");

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Slno = Ds.Tables[0].Rows[0]["issuecode"].ToString();
                }
                pnlbill.Visible = false;
                txtentervno.Focus();
            }
        }

        private void txtinvoicediscperc_TextChanged(object sender, EventArgs e)
        {
            if (txtinvoicediscperc.Enabled == true)
            {
                double InvDiscount=0;
                double InvdiscPerc=0;
                double BillAmount=0;
                InvdiscPerc = _Dbtask.znullDouble(txtinvoicediscperc.textBox1.Text);
                BillAmount = _Dbtask.znullDouble(txtbillamount.Text);
                InvDiscount = BillAmount * InvdiscPerc / 100;
                BillAmount = Math.Round(InvDiscount, 0);
                txtinvoicediscount.textBox1.Text = InvDiscount.ToString();
                TottalAmountCalculate(true);
            }
        }
        private void Gridcustomerlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                DoubleClickCustomerGrid();
            }
        }

        private void txtinvoicediscount_TextChanged(object sender, EventArgs e)
        {
            double BiilDiscount;
            double BillAmt;
            double BillAmtPerc;
            BiilDiscount = _Dbtask.znullDouble(txtinvoicediscount.textBox1.Text);
            BillAmt = TBillAmount;
            BillAmtPerc =BiilDiscount * 100 / BillAmt;
            BillAmtPerc = Math.Round(BillAmtPerc, 2);
            txtinvoicediscperc.textBox1.Text= BillAmtPerc.ToString();
            if (txtinvoicediscperc.textBox1.Text == "NaN")
                txtinvoicediscperc.textBox1.Text = "0.00";
        }
       
        private void cmdpresave_Click(object sender, EventArgs e)
        {
            PreSave(txtvno.Tag.ToString());
        }

        private void comfillingothervoucher_Click(object sender, EventArgs e)
        {
            string TempSalesAccount=SalesAccount;
            string FVno =_Dbtask.znllString(txtentervno.Text); //comfillingvno.Text;

            if (SampleVtype == "CRM" || SampleVtype == "SO" || SampleVtype == "SQ" || comfillingselectvoucher.Text == "Estimate" || SampleVtype == "DN")
            {
                if (comfillingselectvoucher.Text != "Estimate")
                    SalesAccount = "2";
                else
                    SalesAccount = CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate", "lid");

                PreIssueTransaction(FVno, false, SampleVtype, true);
                }
            if (SampleVtype == "PI" || SampleVtype == "PO" || SampleVtype == "SR")
            {
                SalesAccount = "3";
                PreReceiptTransaction(FVno, false, SampleVtype, true);
            }
            SalesAccount = TempSalesAccount;
            GetVno();
            pnlbill.Visible = false;
            EditMode = false;
        }

        private void comfillingselectvoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = comfillingselectvoucher.Text;
            SampleVtype = " ";
            lbltotbill.Text = "";
            if (comfillingselectvoucher.SelectedIndex==0)
            {
                SampleVtype = "SO";
                lbltotbill.Text = " Total Bill : " + CommonClass._Gen.returnmaxvnonumber("tblbusinessissue", SampleVtype) + "  " + "]";
            }
            if (comfillingselectvoucher.SelectedIndex == 1)
            {
                SampleVtype = "SQ";
                lbltotbill.Text = " Total Bill : " + CommonClass._Gen.returnmaxvnonumber("tblbusinessissue", SampleVtype) + "  " + "]";
            }
            if (comfillingselectvoucher.SelectedIndex == 2)
            {
                SampleVtype = "SR";
                lbltotbill.Text = " Total Bill  : " + CommonClass._Gen.returnmaxvnonumber("tbltransactionreceipt", SampleVtype) + "  " + "]";
            }
            if (comfillingselectvoucher.SelectedIndex == 3)
            {
                SampleVtype = "DN";
                lbltotbill.Text = " Total Bill : " + CommonClass._Gen.returnmaxvnonumber("tblbusinessissue", SampleVtype) + "  " + "]";
            }
            if (comfillingselectvoucher.SelectedIndex == 4)
            {
                SampleVtype = "PO";
                lbltotbill.Text = " Total Bill  : " + CommonClass._Gen.returnmaxvnonumber("tbltransactionreceipt", SampleVtype) + "  " + "]";
            }
            if (comfillingselectvoucher.SelectedIndex == 5)
            {
                SampleVtype = "PI";
                lbltotbill.Text = " Total Bill  : " + CommonClass._Gen.returnmaxvnonumber("tbltransactionreceipt", SampleVtype) + "  " + "]";
            }
            



            
            //if(temp=="Enquiry"||temp=="Sales Order"||temp=="Sales Quatation"||temp=="Estimate")
            //{
            //if(temp=="Enquiry")
            //SampleVtype = "CRM";
            //else if (temp == "Sales Order")
            //    SampleVtype = "SO";
            //else if (temp == "Sales Quatation")
            //    SampleVtype = "SQ";
            //else if (temp == "Estimate")
            //    SampleVtype = "SI";

            //if (temp != "Estimate")
            //{
            //    _Dbtask.fillDatainCombowithQuery(comfillingvno, "vno", "vno", "tblbusinessissue", "select * from tblbusinessissue where issuetype='" + SampleVtype + "'");
            //}
            //else
            //{
            // temp = CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate", "lid");
            // _Dbtask.fillDatainCombowithQuery(comfillingvno, "vno", "vno", "tblbusinessissue", "select * from tblbusinessissue where issuetype='" + SampleVtype + "' and ledcodecr='" + temp + "'  order by issuecode asc");
            //}
            //}
            //else
            //{
            //    if (temp == "Purchase Order")
            //        SampleVtype = "PO";
            //    if (temp == "Purchase")
            //        SampleVtype = "PI";

            //    _Dbtask.fillDatainCombowithQuery(comfillingvno, "vno", "vno", "tbltransactionreceipt", "select * from tbltransactionreceipt where recpttype='" + SampleVtype + "'");
            //}
        }

        private void comJobcard_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobcardId = comJobcard.SelectedValue.ToString();
            FillGridMain();
        }
  public void movingitems()
    {
        Ds = _mostmove.getitemsset();
        if (CommonClass._Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("214")) == "1")
        {
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);
                    string Slno = (i + 1).ToString();
                    string bcode = ""; string pcode = ""; string itemname = ""; string itemcode = "";
                    double srate = 0; double qty = 1;
                    bcode = _Dbtask.znllString(Ds.Tables[0].Rows[i]["MMbcode"]);
                    pcode = _Dbtask.znllString(Ds.Tables[0].Rows[i]["MMpcode"]);
                    itemname = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(pcode, "itemname"));

                    itemcode = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(pcode, "itemcode"));
                    srate = _Dbtask.znlldoubletoobject(CommonClass._Batch.GetSpecificFieldByBarcode("srate", bcode));

                    gridmain.Rows[i].Cells["clnslno"].Value = i + 1;
                    gridmain.Rows[i].Cells["clnbatch"].Value = bcode;
                    gridmain.Rows[i].Cells["clnitemname"].Value = itemname;
                    gridmain.Rows[i].Cells["clnitemname"].Tag = pcode;
                    gridmain.Rows[i].Cells["clnitemcode"].Value = itemcode;
                    // gridmain.Rows[i].Cells["clnqty"].Value = qty;
                    //gridmain.Rows[i].Cells["clnsrate"].Value = srate;

                    NQty = qty;
                    gridmain.Rows[i].Cells["clnqty"].Value = qty;

                    NRate = srate;
                    gridmain.Rows[i].Cells["clnsrate"].Value = srate;
                    rowindex = i;
                    CellEnterCalculationPart();
                    RowValidation();

                }

                TottalAmountCalculate(true);
            }
        }
             
     }


        public void FillGridMain()
        {
            comJobcard.Tag = jobcardId;
            string ProductId = _Dbtask.ExecuteScalar("select productVno from Tbladdenquiry where enqvno='" + jobcardId + "'");
            Ds = _Dbtask.ExecuteQuery("select * from TblIssuedetails where Issuecode='" + ProductId + "'");

            if(gridmain.Rows.Count>0)
            gridmain.Rows.Clear();

            Ledid = _Dbtask.ExecuteScalar("select lid from Tbladdenquiry where enqvno='" + jobcardId + "'");
            TxtAccount.Text = CommonClass._Ledger.GetspecifField("lname", Ledid);
                TxtAccount.Tag = Ledid;
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                gridmain.Rows.Add(1);
                string Slno = (i + 1).ToString();
                string Pid = Ds.Tables[0].Rows[i]["pcode"].ToString();
                string Itemname = _Dbtask.ExecuteScalar("select Itemname from TblItemMaster where itemId='" + Pid + "'");
                string Itemcode = _Dbtask.ExecuteScalar("select Itemcode from TblItemMaster where itemid='" + Pid + "'");
                string llang = _Dbtask.ExecuteScalar("select llang from TblItemMaster where itemid='" + Pid + "'");
                if (SBatch == true)
                {
                    string tempbatch = _Dbtask.ExecuteScalar("select bcode from Tblbatch where itemid='" + Pid + "'");
                    gridmain.Rows[i].Cells["clnbatch"].Value = tempbatch;
                }
                string ExpDate = _Dbtask.ExecuteScalar("select exdate from Tblbatch where itemid='" + Pid + "'");
                double rate = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Rate"]);
                double Qty = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["QTY"]);

                gridmain.Rows[i].Cells["clnslno"].Value = i+1;
                gridmain.Rows[i].Cells["clnitemname"].Value = Itemname;
                gridmain.Rows[i].Cells["clnitemname"].Tag = Pid;
                gridmain.Rows[i].Cells["clnitemcode"].Value = Itemcode;
                gridmain.Rows[i].Cells["clnitemcode"].Value = Itemcode;
                gridmain.Rows[i].Cells["clnlang"].Value = llang;
                gridmain.Rows[i].Cells["clnexpiry"].Value = ExpDate;

                NQty = Qty;
                gridmain.Rows[i].Cells["clnqty"].Value = Qty;

                NRate = rate;
                gridmain.Rows[i].Cells["clnsrate"].Value = rate;
                rowindex = i;
                CellEnterCalculationPart();
                RowValidation();
            }
            TottalAmountCalculate(true);
        }

        private void cmdautosave_Click(object sender, EventArgs e)
        {
            RetriveAutosave();
        }

        private void gridmain_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Txttypecooly_TextChanged(object Sender, EventArgs e)
        {
            TottalAmountCalculate(true);

            if ( _Dbtask.znlldoubletoobject( Txttypecooly.textBox1.Text )> 100000000)
            {
                MessageBox.Show("Please check Expense !!!!!");
            }

        }

        private void cmddeleterows_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void cmdsalesreturn_Click(object sender, EventArgs e)
        {


            DIRECTSR = true;
            DIRECTSRVNO = _Dbtask.znllString(txtvno.Text);
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.Location = new Point(0, 0);
            //_Sales.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - toolStrip.Height - 90);
            _Sales.Heading = "Sales Return";

            _Sales.SalesAccount = "2";
            //_Sales.Heading = Heading;
            _Sales.Vtype = "SR";
            // _Sales.SampleVtype ="SR";
            //SampleVtype
            _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
            NextGFuntion.IsinSalesReturn = true;

            _Sales.Location = new Point(0, 0);
            _Sales.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - 25);

            //CommonClass._Md2.MaxforSett(_Sales);
            _Sales.Show();

            Isinotherwindow = false;

            //frmsalesinvoice _Sales = new frmsalesinvoice();
            //_Sales.Location = new Point(0, 0);
            ////_Sales.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - toolStrip.Height - 90);
            //_Sales.Heading = "Sales Return";
           
            //    _Sales.SalesAccount = "2";
            //    //_Sales.Heading = Heading;
            //    _Sales.Vtype = "SR";
            //    _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
            //    NextGFuntion.IsinSalesReturn = true;
                
            //    _Sales.ShowDialog();
                
            //    Isinotherwindow = false;
            //    txtbillamount.Text = (Convert.ToDouble(txtbillamount.Text) - NextGFuntion.SalesReturnAmount).ToString("");
            //    _Sales.Vtype = "SI";
            //(this.MdiParent as MDIParent2).mnusalesreturn.PerformClick();

        }

        private void cmdprintwaranty_Click(object sender, EventArgs e)
        {
            Selectedprint = ComPrintSheme.Text;
            MyPrinter.PrinterName = Selectedprint;
            Clsinvlaser.SelPrint = Selectedprint;
            PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
            PrintBold("                      Waranty Bill", true);
            RichTextBox1.Text = "\n\n"+rchwaranty.Text;
            PrintDotMetrix(true);
            Fscroll();
            MyPrinter.Close();
        }

        private void cmdwaranty_Click(object sender, EventArgs e)
        {
            //if (Pnlwaranty.Visible == true)
            //{
            //    Pnlwaranty.Visible = false;
            //}
            //else
            //{
            //    Pnlwaranty.Visible = true;
            //    rchwaranty.Text = CommonClass._Gen.ReadWaranty();
            //}
            _Forms.ShowbarcodeTools();
        }

        private void cmdnew_Click(object sender, EventArgs e)
        {
     
            (this.MdiParent as MDIParent2).mnusalesnew.PerformClick();
           // Fufocuscolumn("clnbatch");
           // MessageBox.Show("Activate");
        }

        private void Txtitemcategory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           // if(
        }

        private void comitemcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(comitemcategory.SelectedValue) == 0)
                {
                    Falsesearchbarcode();
                }
                else
                {
                    Truesearchbarcode();
                }
            }
            catch
            {
            }
        }

        private void lblexporttoexcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommonClass._report.LblHeading.Text = this.Text + " Invoice Vno (" + txtvno.Text + ")";
            //CommonClass._report.gridcompleatlyexcel(gridmain);
        //CommonClass._report.Exporttoexcelsalee(gridmain);
            //CommonClass._report.Exporttoexcel(gridmain);

        CommonClass._report.newexcelcode(gridmain);
        }

        private void gridmain_DoubleClick(object sender, EventArgs e)
        {
            if (ColumnName == "clnserialno")
            {
                pnlslno.Visible = true;
                if (gridmain.Rows[rowindex].Cells["clnserialno"].Value != null)
                    CommonClass._SelectReport.Fillinlist(Lstslno, gridmain.Rows[rowindex].Cells["clnserialno"].Value.ToString());
            }
            else if (ColumnName == "clnqty")
            {
                    if (_Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value) != "")
                {
                    Frmquickadditems _Form = new Frmquickadditems();
                    _Form.EditMode = true;
                    _Form.Isinotherwindow = true;
                    if (SBatch == true)
                    {
                        _Form.Barcode = _Dbtask.znllString(gridmain.Rows[rowindex].Cells["clnbatch"].Value);
                        _Form.Id = ItemId;
                       
                    }
                    else
                    {
                        _Form.Id = ItemId;
                    }
                    _Form.ShowDialog();
                    gridmain.CurrentCell = gridmain.Rows[rowindex].Cells[0];
                }
            }
        }

        private void cmdslnook_Click(object sender, EventArgs e)
        {
            if (txttypeslno.textBox1.Text != "")
            {
                if (CommonClass._Slno.ShowSlno(" where itemid ='" + ItemId + "' and slno='" + txttypeslno.textBox1.Text + "'").Tables[0].Rows.Count > 0)
                {
                    Lstslno.Items.Add(txttypeslno.textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Slno already used in other item", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Cmdcloseslno_Click(object sender, EventArgs e)
        {
            pnlslno.Visible = false;
        }

        private void cmdslnodelete_Click(object sender, EventArgs e)
        {
            if (Lstslno.SelectedItems.Count > 0)
                Lstslno.Items.Remove(Lstslno.SelectedItem);
        }

        private void Txttypebilldiscount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue==13)
                TottalAmountCalculate(true);
        }

        private void TxttypebilldiscountPerc_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
                TottalAmountCalculate(false);
        }

        private void cmdsettarabic_Click(object sender, EventArgs e)
        {
            gridmain.Columns["clnslno"].HeaderText = "رقم";
            gridmain.Columns["clnbatch"].HeaderText = "الباركود";
            gridmain.Columns["clnitemcode"].HeaderText = "رمز الصنف";
            gridmain.Columns["clnitemname"].HeaderText = "اسم العنصر";
            gridmain.Columns["clnqty"].HeaderText = "كمية";
            gridmain.Columns["clnsrate"].HeaderText = "معدل";
            gridmain.Columns["clnnettamount"].HeaderText = "نيت المبلغ";
        }
        public void searchbymobile()
        {
            string partynaam = "";
            string mobile = txtmobilee.textBox1.Text.ToString();
            string customerid = _Dbtask.ExecuteScalar("select lid from tblaccountledger where agroupid='18' and mobile ='" + mobile + "'");

            if (customerid != null && customerid != "")
            {
                partynaam = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + customerid + "'");
                txtmobilee.textBox1.Text = _Dbtask.ExecuteScalar("select mobile from tblaccountledger where lid='" + customerid + "'");
                txtmobilee.textBox1.Tag = customerid.ToString();
                txtmobilee.textBox1.BackColor = Color.LimeGreen;
                TxtAccount.Text = partynaam.ToString();
                TxtAccount.Tag = customerid.ToString();
                Gridcustomerlist.Visible = false;
            }
           
        }


        private void txtvno_Enter(object sender, EventArgs e)
        {
            //FuFocusing();
        }

        private void txtmobilee_Load(object sender, EventArgs e)
        {

        }

        private void lblmobile_Click(object sender, EventArgs e)
        {

        }

        private void txtmobilee_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if(e.KeyValue==13)
            //{
            //    searchbymobile();
            //}

        }

        private void Pnlwaranty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DatagridSalesHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlbill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chksearchingmode_CheckedChanged(object sender, EventArgs e)
        {
            if (Chksearchingmode.Checked == true)
            {
               CommonClass._Menusettings.UpdateMenusettings("173", "1");
                Truesearchbarcode();
            }
            else
            {
                CommonClass._Menusettings.UpdateMenusettings("173", "-1");
                Falsesearchbarcode();
            }
        }

        private void frmsalesinvoice_Activated(object sender, EventArgs e)
        {
            //if (Generalfunction.Newformsales == true)
            //{
            //    Fufocuscolumn("clnbatch");
            //    MessageBox.Show("Form Activate");
            //}
            //if (Generalfunction.Newformsales == true)
            //{
            //    Fufocuscolumn("clnbatch");
            //    System.Threading.Thread.Sleep(1000);
            //    Generalfunction.Newformsales = false;
                
            //}
           
        }

        private void txtbillamount_Enter(object sender, EventArgs e)
        {
          //  Fufocuscolumn("clnbatch");
        }

        private void uscGridshow2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void gridmain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.P))
            {
            }
        }

        private void cmdTemset_Click(object sender, EventArgs e)
                            {
            PnlTdetails.Visible = true;
            //if (_Dbtask.znllString(TxtAccount.Tag) != ""&&_Dbtask.znllString(TxtAccount.Tag) !="1"&&_Dbtask.znllString(TxtAccount.Tag) !="28")
            //{



            //TxtTcustmr.Text = "";
            //TXTtMOB.textBox1.Text = "";
            //txtTaddrss.textBox1.Text = "";
            //TxtxTvat.Text = "";

            //    if (commodeofpayment.Text.ToLower() == "credit")
            //    {

            //        TxtTcustmr.Text = "";
            //        TXTtMOB.textBox1.Text = "";
            //        txtTaddrss.textBox1.Text = "";
            //        TxtxTvat.Text = "";

            //        //TxtTcustmr.Text = _AccountLedger.GetspecifField("lname", _Dbtask.znllString(TxtAccount.Tag));
            //        //TXTtMOB.textBox1.Text = _AccountLedger.GetspecifField("mobile", _Dbtask.znllString(TxtAccount.Tag));
            //        //txtTaddrss.textBox1.Text = _AccountLedger.GetspecifField("address", _Dbtask.znllString(TxtAccount.Tag));
            //        //TxtxTvat.Text = _AccountLedger.GetspecifField("TaxRegNo", _Dbtask.znllString(TxtAccount.Tag));

            //    }
            //    else
            //    {
                   
            //    }
            //}
            //if (_Dbtask.znllString(TxtAccount.Tag) != "" && _Dbtask.znllString(TxtAccount.Tag) == "1"|| _Dbtask.znllString(TxtAccount.Tag) == "28")
            //{
            //    TxtTcustmr.Text = "";
            //    TXTtMOB.textBox1.Text = "";
            //    txtTaddrss.textBox1.Text = "";
            //    TxtxTvat.Text = "";
            //}
            Tempretreive(_Dbtask.znllString(txtvno.Text)); 
           //Tdetail = true;
            TxtTcustmr.Focus();
        }
        public void Tempretreive(string vno)
                                                        {
            if(EditMode==true&&commodeofpayment.SelectedIndex!=1)
            {
                if (txtvno.Text.ToString() != "" && Vtype != "" && TxtAccount.Tag.ToString()!="")
                {
                    if (Vtype == "SI" || Vtype == "PR" || Vtype == "SO" || Vtype == "SQ")
                    {
                TXTtMOB.textBox1.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tmobile", txtvno.Text.ToString(), Vtype, SalesAccount));
                txtTaddrss.textBox1.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Taddres", txtvno.Text.ToString(), Vtype, SalesAccount));
                TxtxTvat.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tvat", txtvno.Text.ToString(), Vtype, SalesAccount));
                TxtTcustmr.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));
                //txttempNames.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));  
                if (TxtTcustmr.Text != "" && Lbltemporarydetails.Tag == "")
                {
                    txttempNames.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));
                }
                    }
                    if (Vtype == "PI" || Vtype == "SR" || Vtype == "PO" )
                    {
                        TXTtMOB.textBox1.Text = _Dbtask.znllString(_TransactionReceipt.GetSpecificField("Tmobile", txtvno.Text.ToString(), Vtype, SalesAccount));
                            //_Dbtask.znllString(_BusinessIssue.GetSpecificField("Tmobile", txtvno.Text.ToString(), Vtype, SalesAccount));
                        txtTaddrss.textBox1.Text = _Dbtask.znllString(_TransactionReceipt.GetSpecificField("Taddres", txtvno.Text.ToString(), Vtype, SalesAccount));
                        TxtxTvat.Text = _Dbtask.znllString(_TransactionReceipt.GetSpecificField("Tvat", txtvno.Text.ToString(), Vtype, SalesAccount));
                        TxtTcustmr.Text = _Dbtask.znllString(_TransactionReceipt.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));
                        //txttempNames.Text = _Dbtask.znllString(_TransactionReceipt.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));
                        if (TxtTcustmr.Text != "" && Lbltemporarydetails.Tag == "")
                        {
                            txttempNames.Text = _Dbtask.znllString(_BusinessIssue.GetSpecificField("Tename", txtvno.Text.ToString(), Vtype, SalesAccount));
                        }
                    }

                Tmob = _Dbtask.znllString(TXTtMOB.textBox1.Text);
                Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);
                Tvat = _Dbtask.znllString(TxtxTvat.Text);
                Tnamee = _Dbtask.znllString(TxtTcustmr.Text);
                }
            }
        }
        private void cmdTok_Click(object sender, EventArgs e)
        {
          
            Tmob =_Dbtask.znllString( TXTtMOB.textBox1.Text);
            Taddres = _Dbtask.znllString(txtTaddrss.textBox1.Text);
            Tvat = _Dbtask.znllString(TxtxTvat.Text);
            Tnamee = _Dbtask.znllString(TxtTcustmr.Text);
            TxtAccount.Text = Tnamee;

            if(commodeofpayment.SelectedIndex==0)
            {
            TxtAccount.Tag = "1";
            }
            if (commodeofpayment.SelectedIndex == 2)
            {
                TxtAccount.Tag = _Dbtask.znllString(TxtAccount.Tag);
            }

            
            PnlTdetails.Visible = false;
        
        }

        private void CmdTclose_Click(object sender, EventArgs e)
        {
            PnlTdetails.Visible = false;
        }

        private void Txttypecooly_Leave(object sender, EventArgs e)
        {
            Txttypecooly.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(Txttypecooly.textBox1.Text)));
        }

        private void Txttypebilldiscount_Leave(object sender, EventArgs e)
        {
            Txttypebilldiscount.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(Txttypebilldiscount.textBox1.Text)));
            if (_Dbtask.znlldoubletoobject(Txttypebilldiscount.textBox1.Text) == 0)
            {
                TxttypebilldiscountPerc.textBox1.Text = "";
                txtbillamount.Text = _Dbtask.znllString(NetAmount);
            }
        }

        private void TxttypebilldiscountPerc_Leave(object sender, EventArgs e)
        {
            TxttypebilldiscountPerc.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(TxttypebilldiscountPerc.textBox1.Text)));

            if (_Dbtask.znlldoubletoobject(TxttypebilldiscountPerc.textBox1.Text) == 0)
            {
                Txttypebilldiscount.textBox1.Text = "";
                txtbillamount.Text = _Dbtask.znllString(NetAmount);
            }
        }

        private void cmdmakeacopy_Click(object sender, EventArgs e)
                {

                PreIssueTransaction(_Dbtask.znllString(txtvno.Text), false, Vtype, false);
                        Tempretreive(_Dbtask.znllString(txtvno.Text));
                    GetVno();
                    EditMode = false;

       //GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);   
       
        }

        private void uscGridshow2_Load(object sender, EventArgs e)
        {

        }

        public void setwidth()
        {

            itemcodewid= gridmain.Columns["clnitemcode"].Width;
                batchwidth= gridmain.Columns["clnbatch"].Width;
                itemwid= gridmain.Columns["clnitemname"].Width;

                langwidth = gridmain.Columns["clnlang"].Width;
            _Dbtask.ExecuteNonQuery("update   tblparamlist set paramvalue='" + _Dbtask.znllString(itemcodewid) + "' where paramname='codewidthSI'");
            _Dbtask.ExecuteNonQuery("update   tblparamlist set paramvalue='" + _Dbtask.znllString(batchwidth) + "' where paramname='Batchwidthsale'");
            _Dbtask.ExecuteNonQuery("update  tblparamlist set paramvalue='" + _Dbtask.znllString(itemwid) + "' where paramname='Itemwidthinsale'");
            _Dbtask.ExecuteNonQuery("update     tblparamlist set paramvalue='" + _Dbtask.znllString(langwidth) + "' where paramname='seclangwidthinsale'");

        
        }

        private void Cmdsettprinter_Click(object sender, EventArgs e)
        {
            SaveTaxinvoiceHeader();

            setwidth();
        }

        private void cmdgridclose_Click(object sender, EventArgs e)
        {
            GridRate.Visible = false;
            PNLCOSTINVCE.Visible = false;
        }

        private void Txttypebilldiscount_TextChanged(object Sender, EventArgs e)
            {
            if (_Dbtask.znlldoubletoobject( Txttypebilldiscount.textBox1.Text )  >100000000 )
            {
                MessageBox.Show("Check DISCOUNT ..!!!!");
                Txttypebilldiscount.textBox1.Focus();
            }


            //if (CommonClass._UserDetails.GetSpecificfieldbyname(ClsUserDetails.MUserName, "ugroup") != "0")
            //{
            //    if(userwisediscallow=="1")
            //    {
            //    if (_Dbtask.znlldoubletoobject(Txttypebilldiscount.textBox1.Text) > _Dbtask.znlldoubletoobject(userwisedisc))
            //    {
            //        Txttypebilldiscount.textBox1.Text = "";
            //        Txttypebilldiscount.textBox1.Text = userwisedisc;
            //    }
            //    }
            //}
            


        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void TxtNaration_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Remarks", "tblbusinessissue", TxtNaration.textBox1);

        }

        private void TxtTcustmr_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Tename", "tblbusinessissue", TxtTcustmr);

        }

        private void TXTtMOB_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Tmobile", "tblbusinessissue", TXTtMOB.textBox1);

        }

        private void TxtxTvat_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Tvat", "tblbusinessissue", TxtxTvat);

        }

        private void txtTaddrss_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Taddres", "tblbusinessissue", txtTaddrss.textBox1);

        }

        private void txttempNames_Leave(object sender, EventArgs e)
        {
            if(txttempNames.Text=="")
            {
                Lbltemporarydetails.Tag = "";
            }

        }

        private void lbldemosale_Click(object sender, EventArgs e)
        {
            _Forms.Showdemosale();
        }
        
        private void cmdlastbillcopy_Click(object sender, EventArgs e)
        {

            GetPrevious((Convert.ToInt64(txtvno.Tag) - 1).ToString(), false);
            if (EditMode == true)
            {
                txtpaid.Enabled = false;
            }
            Nocopies();
            Clear();


            //string lastbill = "";
            //lastbill = _Dbtask.znllString( _BusinessIssue.lastvnonumsale("SI"));

            //PreIssueTransaction(lastbill, false, Vtype, false);
            //Tempretreive(lastbill);
            //GetVno();
            //EditMode = false;
        }

        private void cmdaddcustomer_Click(object sender, EventArgs e)
        {
            frmcreateledger _Form = new frmcreateledger();
            _Form.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
            Generalfunction.Comeform = "MDICUSTOMER";
            _Form.ShowDialog();
        }

        private void cmdaddproject_Click(object sender, EventArgs e)
        {
            Frmcustomerprojects _Form = new Frmcustomerprojects();
            _Form.ShowDialog();


            if (_Dbtask.znllString(TxtAccount.Tag)!="")
            {
            CommonClass._Partyproject.FillComboPartyproject(false, TxtAccount.Tag.ToString(), comcustomerproject);
            }
        }

        private void combprintmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            savemodeofpayment();
        }

        public void savemodeofpayment()
        {
            CommonClass._Dbtask.Setmodeofpayment(_Dbtask.znllString(combprintmode.Text));

        }
        public void getmodeofpayment()
        {
         combprintmode.Text=   _Dbtask.znllString(CommonClass._Dbtask.Getmodeofpayment());
        }

        //public void loadmoveitems
        //{
        //    //Ds =_mostmove.geti
        //}




        //private void Txttypebilldiscount_Enter(object sender, EventArgs e)
        //{

        //}

        //private void Txttypecooly_Load(object sender, EventArgs e)
        //{

        //}

        //private void Txttypecooly_Enter(object sender, EventArgs e)
        //    {

        //}

        //private void TxttypebilldiscountPerc_Load(object sender, EventArgs e)
        //{


        //}

        //private void Txttypecooly_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void Txttypecooly_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        //private void Txttypecooly_Leave(object sender, EventArgs e)
        //{

        //        Txttypecooly.textBox1.Text = _Dbtask.znllString(_Nextg.IsitBarcodeorNot(_Dbtask.znllString(Txttypecooly.textBox1.Text)));
        //}

        //private void Txttypebilldiscount_Leave(object sender, EventArgs e)
        //{

        //       Txttypebilldiscount.textBox1.Text = _Dbtask.znllString( _Nextg.IsitBarcodeorNot(_Dbtask.znllString(Txttypebilldiscount.textBox1.Text)));
        //    if(_Dbtask.znlldoubletoobject( Txttypebilldiscount.textBox1.Text)==0)
        //    {
        //         TxttypebilldiscountPerc.textBox1.Text = "";
        //         txtbillamount.Text =_Dbtask.znllString( NetAmount);
        //     }
        //}

        //private void TxttypebilldiscountPerc_Leave(object sender, EventArgs e)
        //{
        //   TxttypebilldiscountPerc.textBox1.Text =_Dbtask.znllString( _Nextg.IsitBarcodeorNot(_Dbtask.znllString(TxttypebilldiscountPerc.textBox1.Text)));

        //    if (_Dbtask.znlldoubletoobject(TxttypebilldiscountPerc.textBox1.Text) == 0)
        //    {
        //        Txttypebilldiscount.textBox1.Text = "";
        //        txtbillamount.Text = _Dbtask.znllString(NetAmount);
        //    }
        //}




    }
}
