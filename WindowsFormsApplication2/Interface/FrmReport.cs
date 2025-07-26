using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

using System.Globalization;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        clssaletaxHorizontal _saletax = new clssaletaxHorizontal();
        clsPurchasetaxHorizontal _purtax = new clsPurchasetaxHorizontal();
        clsstockreportthemal _stockReport = new clsstockreportthemal();
        RichTextBox RichTextBox1 = new RichTextBox();
        LPrinter MyPrinter = new LPrinter();
        MDIParent2 _mdi2 = new MDIParent2();
        DataGridView DtGridSecond;
        ClsInvThermalReport _ThermalReport = new ClsInvThermalReport();
        ClsIsalesReportThermal _salereportTH = new ClsIsalesReportThermal();
        ClsInvThermal _Thermal = new ClsInvThermal();
        public  static bool printvalue = false;
        double billadjst = 0;
        public double OPbalance = 0;
        public string cuson = "";


        public static bool PRTAX = false;
        public static DateTime ddlimitdate;
        public static int datenum;
        //public static string ledonly = "";
        public static string ledonly = "";
        /*For settings use*/
        public string partyid = "";
        public string agvnlid = "";
        public string CUSCODE = "";
        public string partycode = "";
        string Sinclusivetax;
        string Pinclusivetax;
        /*************************/
        ClsinvlaserSimple _lasersimple = new ClsinvlaserSimple();
        /*For Stock Value Report*/
        string MainGname;
        string SubGname;
        public static string Lbl2;
        /********************/
        /*For Qplex P&L*/

        public static string Decodee = "";
        public bool Removeborder = false;
        int Count;
        double ServiceAmount = 0;
        double SalesAmount = 0;
        double Pcost = 0;
        double SalesReturnAmount = 0;
        double SPcost = 0;
        double IndirectExpence = 0;
        double TindirectIncome = 0;
        double EmployeeExpense = 0;
        double Tottal = 0;
        /*For Sales Report*/
        string Issuecode;
        string Ledcode;
        double TaxAmt;
        double TotalAmt;
        public long Lid;

        /****************For Profit Date********/
        double Perc;
        double Profit;
        double Income;
        double Expence;
        double TIncome;
        double TsalesNet;
        double TSRNet;
        double TcostNet;
        double Tperc;
        double TExpence;
        double Tprofit;

        /***********************/
        string Pid;
        double Crate;
        double Prate;
        double Temp;
        double Srate;
        double Qty;
        double TCrate;
        double TSrate;
        double TCooly = 0;
        double TDiscount = 0;
        double TEmployeeAmt = 0;

        public static string Thirdcondition;
        public static string SelUnit;
        /***************************For Drill Down*/
        int SelectedRow;
        string SelectedColumnname;
      public static string ClickCode;
      public static string Vno;
       public static string MainAccount;
        /***********************************/

        /*********************************************/
        string AccountID;
        string StrPurticulars;
        double DbDebit;
        double DbCredit;
        double DBTDebit;
        double DBTCredit;
        double DbAmount;
        /*********************************************/

        public double TempTaxableamt;

        public bool CheckedAll;
        public bool Conditionworking2;
        public string QueryWhere;
        //public static string QueryTemp;
        //public static string Query;

        public  string QueryTemp;
        public  string Query;
        public string QueryDetail;

        public string QueryTemp2;
        public static string Secondcondition;
        public string Depoin = "";
        public  string ReportType;
        public  string ReportTypeSecond;
        public int RowExp = 0;
        public int RowInc = 0;
        public int RowsCount;
        public   DateTime DTFrom;
        public DateTime RVDate;
        public   DateTime DTTo;
        public double AmtDiExpense = 0;
        public double AmtDiIncome = 0;
        public double AmtInExpense = 0;
        public double AmtInIcome = 0;
        double Taxperc = 0;
        public string Tempcategoryname;
        public string SalesManin = "";
        public string Where = "";
        public double TStock = 0;
        public double TAmount = 0;
        public string Craiteria;
        public string PreLedcodeGroup;/*For Using DayBook*/
        public string Employeeid;/*For Using Itemstatus Report in Production*/
        public string StockReceId;/*For Using Itemstatus Report in Production*/
        public double StockRece;/*For Using Itemstatus Report in Production*/
        DateTime DtTemp;
        public int GridWidth;
        int k = 0;
        string tempin;
        DBTask _Dbtask = new DBTask();

        DataSet Ds = new DataSet();
        DataSet Ds1 = new DataSet();
        DataSet Ds2 = new DataSet();

        string frstqts;
        string Lstqts;
       //// ClsCompanyMaster _companyMaster = new ClsCompanyMaster();
       //// ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
       // ClsBusinessIssue _BusinessIssue = new ClsBusinessIssue();
        //ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        //ClsDepot _Depot = new ClsDepot();
       // ClsAccountLedger _AccountLedger = new ClsAccountLedger();
      //  ClsInventory _Inventory = new ClsInventory();
       // NextGFuntion _Nextg = new NextGFuntion();
       // Generalfunction _Gen = new Generalfunction();
       // Clscommenevent _ComEvent = new Clscommenevent();
      //  ClsReports  CommonClass._Clreport = new ClsReports();
       // Clsbatch _Batch = new Clsbatch();
       
   //  private System.ComponentModel.Container components;
        Bitmap bm;
        int i = 0;
        string Iid;
        ClspurchaseReportThermal _purchreportTh = new ClspurchaseReportThermal();
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        private void GridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RowBoldFunction(int Rowindex)
        {
            GridMain.Rows[Rowindex].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                if (ReportType != "Tool Data")
                {
                    CommonClass._Language.FormBasedConversion(this);
                    CommonClass._Language.GridHeaderConversion(GridMain);
                    CommonClass._Language.PanelBasedConversion(panel3);
                    //CommonClass._Language.PanelBasedConversion(pnlmain);
                    LblHeadingArbic.Text = CommonClass._Language.GetArabicString(LblHeading.Text);
                }
            }
        }
        public string MaxDate(DateTime Dtdate)
        {
            string A = Dtdate.ToString("MM/dd/yyyy") + " 23:59:59";
            return A;
        }
        public string MinDate(DateTime Dtdate)
        {
            string A = Dtdate.ToString("MM/dd/yyyy") + " 00:00:00";
            return A;
        }
        public void SetGrid()
        {
            try
            {
               
                
                
                if (ReportType == null)
                {
                    ReportType = ClsReports.ReportType;
                    QueryTemp = ClsReports.QueryTemp;
                    QueryTemp2 = ClsReports.QueryTemp;
                    Query = ClsReports.Query;
                    DTFrom = ClsReports.DTFrom;
                    DTTo = ClsReports.DTTo;
                }

                if (ReportType == "Stock Value")
                {
                    if (ReportTypeSecond == "All Units")
                    {
                        GridMain.Columns.Clear();

                        GridMain.Columns.Add("clncategory", "Category");
                        GridMain.Columns["clncategory"].Width = 100;

                        GridMain.Columns.Add("clnitemname", "Itemname");
                        GridMain.Columns["clnitemname"].Width = 250;

                        Ds = _Dbtask.ExecuteQuery("select * from tblUnitcreation");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Columns.Add(Ds.Tables[0].Rows[i]["id"].ToString(), Ds.Tables[0].Rows[i]["name"].ToString());
                            GridMain.Columns[Ds.Tables[0].Rows[i]["id"].ToString()].Width = 100;
                        }
                        GridMain.Columns.Add("clnqty", "QTY");
                        GridMain.Columns["clnqty"].Width = 150;
                        GridMain.Columns.Add("clnrate", "Rate");
                        GridMain.Columns["clnrate"].Width = 150;

                        GridMain.Columns.Add("clnamount", "Amount");
                        GridMain.Columns["clnamount"].Width = 250;
                    }
                }


                if (ReportType == "Day Summery report Sale")
                {

                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 50;

                    GridMain.Columns.Add("clnTSaleAMT", "Amount");
                    GridMain.Columns["clnTSaleAMT"].Width = 250;

                    GridMain.Columns.Add("clnTotDisc", "Tot.Disc");
                    GridMain.Columns["clnTotDisc"].Width = 250;
                        

                    
                        GridMain.Columns.Add("clnTotSR", "SaleReturn");
                        GridMain.Columns["clnTotSR"].Width = 250;

                    GridMain.Columns.Add("clnNetamt", "NetAMT");
                    GridMain.Columns["clnNetamt"].Width = 250;

                   // GridMain.Columns.Add("clnramount", "Amount");
                    //GridMain.Columns["clnramount"].Width = 150;




                }

                if (ReportType == "Purchase Bill Wise SettleMent")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    //GridMain.Columns.Add("clndate", "Date");
                    //GridMain.Columns.Add("clnvno", "vno");
                    //GridMain.Columns.Add("clnparty", "Customer Name");
                    //GridMain.Columns.Add("clnBillamt", "AMT");
                    //GridMain.Columns.Add("ClnSR", "Sales Return");
                    //GridMain.Columns.Add("clnR", "Paid");
                    //GridMain.Columns.Add("clnBamt", "Balance");
                    //GridMain.Columns.Add("ClnPercColl", "Collection %");
                    //ClnPercColl
                    AddColumnInGridMain("Party", "ClnParty", 200, false);
                    AddColumnInGridMain("Date", "ClnDate", 90, false);
                    AddColumnInGridMain("Vno", "ClnVno", 120, false);
                    AddColumnInGridMain("Bill Amt", "ClnBillAmt", 150, true);
                    AddColumnInGridMain("Purchase Return", "ClnPR", 150, true);
                    AddColumnInGridMain("Paid", "ClnP", 150, true);
                    AddColumnInGridMain("Balance", "ClnBAmt", 150, true);
                    AddColumnInGridMain("Pending Days", "ClnPendingDays", 150, false);
                }



                if (ReportType == "Sales Bill Wise SettleMent")
                {

                    //GridMain.Columns.Add("clndate", "Date");
                    //GridMain.Columns.Add("clnvno", "vno");
                    //GridMain.Columns.Add("clnparty", "Customer Name");
                    //GridMain.Columns.Add("clnBillamt", "AMT");
                    //GridMain.Columns.Add("ClnSR", "Sales Return");
                    //GridMain.Columns.Add("clnR", "Paid");
                    //GridMain.Columns.Add("clnBamt", "Balance");
                    //GridMain.Columns.Add("ClnPercColl", "Collection %");

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    AddColumnInGridMain("Party", "ClnParty", 200, false);
                    AddColumnInGridMain("Date", "ClnDate", 90, false);
                    AddColumnInGridMain("Vno", "ClnVno", 120, false);
                    AddColumnInGridMain("Bill Amt", "ClnBillAmt", 150, true);
                    AddColumnInGridMain("Sales Return", "ClnSR", 150, true);
                    AddColumnInGridMain("Paid", "ClnR", 150, true);
                    AddColumnInGridMain("Bill Adjustment", "ClnBA", 150, false);

                    AddColumnInGridMain("Balance", "ClnBAmt", 150, true);
                    AddColumnInGridMain("Pending Days", "ClnPendingDays", 150, false);
                    // AddColumnInGridMain("Bill Adjustment", "ClnBA", 150, false);

                }



                if (ReportType == "Payment and Receipt Report")
                {
                    
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnrvno", "Vno");
                    GridMain.Columns["clnrvno"].Width = 50;

                    GridMain.Columns.Add("clnreceipt", "Receipt");
                    GridMain.Columns["clnreceipt"].Width = 250;
                    GridMain.Columns.Add("clnramount", "Amount");
                    GridMain.Columns["clnramount"].Width = 150;

                    GridMain.Columns.Add("clnpvno", "Vno");
                    GridMain.Columns["clnpvno"].Width = 50;

                    GridMain.Columns.Add("clnpayment", "Payment");
                    GridMain.Columns["clnpayment"].Width = 250;
                    GridMain.Columns.Add("clnpamount", "Amount");
                    GridMain.Columns["clnpamount"].Width = 150;
                }


                if (ReportType == "Salescustomeranditem")
                {
                    
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnpartname", "Party");
                    GridMain.Columns["clnpartname"].Width = 200;
                    string Tempitemid;
                    string Tempitemname;
                    Ds = CommonClass._Item.ShowItemsProductName(" having tblitemmaster.status=1 ", 1);

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                       Tempitemid=Ds.Tables[0].Rows[i]["itemid"].ToString();
                       Tempitemname=Ds.Tables[0].Rows[i]["itemname"].ToString();
                       GridMain.Columns.Add(Tempitemid, Tempitemname);
                       GridMain.Columns[Tempitemid].Width = 150;
                    }
                    GridMain.Columns.Add("clntotal", "Total");
                    GridMain.Columns["clntotal"].Width = 150;
                }

                 if (ReportType == "SalesDay")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 100;

                    GridMain.Columns.Add("clndate", "Date");
                    GridMain.Columns["clndate"].Width = 150;

                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 200;

                    GridMain.Columns.Add("clnqty", "Qty");
                    GridMain.Columns["clnqty"].Width = 50;

                    GridMain.Columns.Add("clnfreeqty", "Free.Qty");
                    GridMain.Columns["clnfreeqty"].Width = 50;

                    GridMain.Columns.Add("clntaxamt", "Tax Amt");
                    GridMain.Columns["clntaxamt"].Width = 150;

                    GridMain.Columns.Add("clnnetamount", "Net.Amt");
                    GridMain.Columns["clnnetamount"].Width = 200;
                }

                 



                if (ReportType == "Trading Account")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnpurticulars", "Purticulars");
                    GridMain.Columns["clnpurticulars"].Width = 250;

                    GridMain.Columns.Add("clnamount", "Amount");
                    GridMain.Columns["clnamount"].Width = 200;
                }

                if(ReportType=="SalesOther")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnitemname", "ItemName");
                    GridMain.Columns["clnitemname"].Width = 250;

                    GridMain.Columns.Add("clndiscount", "Discount");
                    GridMain.Columns["clndiscount"].Width = 200;

                    GridMain.Columns.Add("clnpurchase", "Purchase");
                    GridMain.Columns["clnpurchase"].Width = 200;

                    GridMain.Columns.Add("clnsales", "Sales");
                    GridMain.Columns["clnsales"].Width = 200;

                     GridMain.Columns.Add("clnbalance", "Balance");
                     GridMain.Columns["clnbalance"].Width = 200;
                
                }

                if (ReportType == "RatioAnalysis")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    tempin = DTFrom.ToString("dd-MM-yyyy") + " To " + DTTo.ToString("dd-MM-yyyy");

                    GridMain.Columns.Add("clnprincgrp", "Principal Groups");
                    GridMain.Columns["clnprincgrp"].Width = 250;


                    GridMain.Columns.Add("clnprincgrpAmount", tempin);
                    GridMain.Columns["clnprincgrpAmount"].Width = 200;

                    GridMain.Columns.Add("clnprincrat", "Principal Ratios");
                    GridMain.Columns["clnprincrat"].Width = 250;

                    GridMain.Columns.Add("clnprincratamount", tempin);
                    GridMain.Columns["clnprincratamount"].Width = 200;
                }

                if (ReportType == "P&L Report")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    /*Column Add */

                    GridMain.Columns.Add("ClncPurticulars", "Particulars");
                    GridMain.Columns["ClncPurticulars"].Width = 350;

                    GridMain.Columns.Add("ClncAmount", "Credit");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clncamount", 150);

                    GridMain.Columns.Add("ClnDPurticulars", "Particulars");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndpurticulars", 350);

                    GridMain.Columns.Add("ClnDbAmount", "Debit");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndbamount", 150);

                    //GridMain.

                }

                if (ReportType == "Stock Transfer Summury")
                {
                    GridMain.DataSource = null;
                   // GridMain.Columns.Clear();
                }

                if (ReportType == "Stransferdetail")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnvdate", "Date");
                    GridMain.Columns["clnvdate"].Width = 100;

                    GridMain.Columns.Add("clnfromdepo", "From Depo");
                    GridMain.Columns["clnfromdepo"].Width = 250;

                    GridMain.Columns.Add("clntodepo", "To Depo");
                    GridMain.Columns["clntodepo"].Width = 250;

                    GridMain.Columns.Add("clnAamount", "Amount");
                    GridMain.Columns["clnAamount"].Width = 200;
                }

                if (ReportType == "Balancesheet")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnlaibilities", "Laibilities");
                    GridMain.Columns["clnlaibilities"].Width = 300;

                    GridMain.Columns.Add("clnlamount", "Amount");
                    GridMain.Columns["clnlamount"].Width = 200;

                    GridMain.Columns.Add("clnassets", "Assets");
                    GridMain.Columns["clnassets"].Width = 300;

                    GridMain.Columns.Add("clnAamount", "Amount");
                    GridMain.Columns["clnAamount"].Width = 200;

                }
                
                if (ReportType == "TrailBalance")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnpurticulars", "Particulars");
                    GridMain.Columns["clnpurticulars"].Width = 800;

                    GridMain.Columns.Add("clndebit", "Debit");
                    GridMain.Columns["clndebit"].Width = 200;

                    GridMain.Columns.Add("clncredit", "Credit");
                    GridMain.Columns["clncredit"].Width = 200;
                }

                if (ReportType == "QplexP&Ldate")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clndate", "Date");
                    GridMain.Columns["clndate"].Width = 100;

                    GridMain.Columns.Add("clnsales", "Sales");
                    GridMain.Columns["clnsales"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnsales", 150);

                    GridMain.Columns.Add("clncost", "Cost");
                    GridMain.Columns["clncost"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clncost", 150);

                    GridMain.Columns.Add("clnpr", "% profit");
                    GridMain.Columns["clnpr"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnpr", 150);

                    GridMain.Columns.Add("clnsr", "S.return");
                    GridMain.Columns["clnsr"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnsr", 150);

                    GridMain.Columns.Add("clnincome", "Income");
                    GridMain.Columns["clnincome"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnincome", 150);

                    GridMain.Columns.Add("clnexpence", "Expence");
                    GridMain.Columns["clnexpence"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnexpence", 150);

                    GridMain.Columns.Add("clnprofit", "Profit");
                    GridMain.Columns["clnprofit"].Width = 150;
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnprofit", 150);
                }

                if (ReportType == "QplexP&L" || ReportType == "QplexP&Ldetail")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnpurticulars", "Particulars");
                    GridMain.Columns["clnpurticulars"].Width = 800;

                    GridMain.Columns.Add("clnamount", "Amount");
                    GridMain.Columns["clnamount"].Width = 200;
                  CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 200);
                }
                if (ReportType == "OutstandingReportsummery")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnslno", "Slno");
                    GridMain.Columns["clnslno"].Width = 100;
                    GridMain.Columns.Add("clnledcode", "lid");
                    GridMain.Columns["clnledcode"].Width = 100;
                    GridMain.Columns.Add("clnparty", "Party Name");
                    GridMain.Columns["clnparty"].Width = 600;
                    GridMain.Columns.Add("clnmob", "Contact");
                    GridMain.Columns["clnmob"].Width = 300;
                    GridMain.Columns.Add("clntax", "VAT");
                    GridMain.Columns["clntax"].Width = 300;
                    GridMain.Columns.Add("clnamount", "Amount");
                    GridMain.Columns["clnamount"].Width = 200;
                }
                if (ReportType == "Billwisesettlement")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clndate", "Date");
                    GridMain.Columns["clndate"].Width = 150;

                    GridMain.Columns.Add("clnvno", "vno");
                    GridMain.Columns["clnvno"].Width = 50;

                    GridMain.Columns.Add("clnparty", "Party Name");
                    GridMain.Columns["clnparty"].Width = 500;

                


                    GridMain.Columns.Add("clnBillamt", "Bill");
                    GridMain.Columns["clnBillamt"].Width = 100;

                    GridMain.Columns.Add("clnBamt", "Bill Pending");
                    GridMain.Columns["clnBamt"].Width = 100;

                    GridMain.Columns.Add("clnamount", "Amount");
                    GridMain.Columns["clnamount"].Width = 200;
                }

                if (ReportType == "Receivedreport")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clndate", "Received Date");
                    GridMain.Columns["clndate"].Width = 200;

                    GridMain.Columns.Add("clnvno", "Received Vno");
                    GridMain.Columns["clnvno"].Width = 100;

                    GridMain.Columns.Add("clnitem", "Finished Item");
                    GridMain.Columns["clnitem"].Width = 300;

                    GridMain.Columns.Add("clnqty", "Qty");
                    GridMain.Columns["clnqty"].Width = 100;

                    GridMain.Columns.Add("clnissuedate", "Issue Date");
                    GridMain.Columns["clnissuedate"].Width = 200;

                    GridMain.Columns.Add("clnemployee", "Employee");
                    GridMain.Columns["clnemployee"].Width = 200;
                }

                if (ReportType == "Issuereport")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 200;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 150;

                    GridMain.Columns.Add("clnemployee", "Employee");
                    GridMain.Columns["clnemployee"].Width = 300;

                    GridMain.Columns.Add("clnemployee2", "");
                    GridMain.Columns["clnemployee2"].Width = 150;
                }

                if (ReportType == "Productionitemstatus")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnemployee", "Employee");
                    GridMain.Columns["clnemployee"].Width = 300;

                    GridMain.Columns.Add("clnamtbalance", "Balance Amount");
                    GridMain.Columns["clnamtbalance"].Width = 150;

                    GridMain.Columns.Add("clnitem", "");
                    GridMain.Columns["clnitem"].Width = 150;

                    GridMain.Columns.Add("clnstock", "");
                    GridMain.Columns["clnstock"].Width = 150;

                    GridMain.Columns.Add("clnissue", "");
                    GridMain.Columns["clnissue"].Width = 150;

                    GridMain.Columns.Add("clnrec", "");
                    GridMain.Columns["clnrec"].Width = 150;

                    GridMain.Columns.Add("clnstockvalue", "");
                    GridMain.Columns["clnstockvalue"].Width = 150;

                }

                if (ReportType == "Salestaxdetail")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clntaxperc", "Tax%");
                    GridMain.Columns["clntaxperc"].Width = 100;
                    GridMain.Columns["clntaxperc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    GridMain.Columns["clntaxperc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    GridMain.Columns.Add("clnitemname", "Item Name");
                    GridMain.Columns["clnitemname"].Width = 200;

                    GridMain.Columns.Add("clnitemcode", "Item Code");
                    GridMain.Columns["clnitemcode"].Width = 200;

                    GridMain.Columns.Add("clnqty", "Qty");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 100);

                    GridMain.Columns.Add("clnrate", "Rate");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnrate", 200);


                    //GridMain.Columns.Add("clncess", "Cess");
                    //GridMain.Columns["clncess"].Width = 100;

                    GridMain.Columns.Add("clngross", "Taxable");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clngross", 200);

                    GridMain.Columns.Add("clntaxamount", "Tax Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clntaxamount", 200);

                    GridMain.Columns.Add("clnamount", "Net Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 200);

                }

                if (ReportType == "Billwiseprofitstatement")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    //  this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 100;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 100;

                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 300;

                    GridMain.Columns.Add("clnamount", "Amount");
                    GridMain.Columns["clnamount"].Width = 150;

                    GridMain.Columns.Add("clnbilldisc", "Bill Disc.");
                    GridMain.Columns["clnbilldisc"].Width = 150;

                    GridMain.Columns.Add("clnprate", "P.Amount");
                    GridMain.Columns["clnprate"].Width = 150;

                    GridMain.Columns.Add("clnprofitperc", "Profit%");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnprofitperc", 70);

                    GridMain.Columns.Add("clnprofit", "Profit");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnprofit", 200);

                }

                if (ReportType == "Salesdaybook" || ReportType == "Purchasereturndaybook" || ReportType == "Purchasedaybook" || ReportType == "Sales returnaybook")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    //  this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 150;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 50;

                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 300;

                    if (CommonClass._Menusettings.GetMnustatus("103") == "1")
                    {
                        GridMain.Columns.Add("clnbcode", "Barcode");
                        GridMain.Columns["clnbcode"].Width = 100;
                    }

                    GridMain.Columns.Add("clnitemname", "Item Name");
                    GridMain.Columns["clnitemname"].Width = 200;

                    GridMain.Columns.Add("clnqty", "Qty");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 100);

                    GridMain.Columns.Add("clnfree", "free");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnfree", 50);

                    GridMain.Columns.Add("clnrate", "Rate");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnrate", 150);


                    GridMain.Columns.Add("clnamount", "Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 150);

                }
                if (ReportType == "Cashcadjet")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnpurticularsDB", "Particulars");
                    GridMain.Columns["clnpurticularsDB"].Width = 300;


                    GridMain.Columns.Add("clndbamt", "IN Amount");
                    GridMain.Columns["clndbamt"].Width = 150;

                    GridMain.Columns.Add("clnpurticularsCR", "Particulars");
                    GridMain.Columns["clnpurticularsCR"].Width = 300;

                    GridMain.Columns.Add("clncramt", "Out Amount");
                    GridMain.Columns["clncramt"].Width = 150;
                }
                if (ReportType == "Daybook")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    if (ReportTypeSecond == "Summury")
                    {
                        GridMain.Columns.Add("clnvno", "Vno");
                        GridMain.Columns["clnvno"].Width = 70;


                        GridMain.Columns.Add("clnpurticulars", "Particulars");
                        GridMain.Columns["clnpurticulars"].Width = 300;

                        GridMain.Columns.Add("clnamt", "Amount");
                        GridMain.Columns["clnamt"].Width = 100;

                    }
                    else
                    {
                        GridMain.Columns.Add("clndate", "VDate");
                        GridMain.Columns["clndate"].Width = 200;


                        GridMain.Columns.Add("clnpurticulars", "Particulars");
                        GridMain.Columns["clnpurticulars"].Width = 200;

                        GridMain.Columns.Add("clnvtype", "Vtype");
                        GridMain.Columns["clnvtype"].Width = 100;

                        GridMain.Columns.Add("clnvno", "Vno");
                        GridMain.Columns["clnvno"].Width = 75;

                        GridMain.Columns.Add("clndebit", "Debit");
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndebit", 150);

                        GridMain.Columns.Add("clncredit", "Credit");
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "clncredit", 150);

                        GridMain.Columns.Add("clnbalance", "Balance");
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbalance", 150);


                        GridMain.Columns.Add("clnnaration", "Naration");
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnnaration", 300);
                    }


                }

                if (ReportType == "Salestaxsummery" && CommonClass.SRmode == "Mode4")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();


                    GridMain.Columns.Add("clnvno", "B.No");
                    GridMain.Columns["clnvno"].Width = 50;

                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 100;

                    GridMain.Columns.Add("clnnetamt", "Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnnetamt", 150);

                    GridMain.Columns.Add("clnstax", "S.Tax");
                    GridMain.Columns["clnstax"].Width = 100;

                    GridMain.Columns.Add("clnparty", "Party Details");
                    GridMain.Columns["clnparty"].Width = 250;
                }
                if (ReportType == "Analysissalesandpurchase")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    // this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clnsales", "SALES");
                    GridMain.Columns["clnsales"].Width = 200;

                    GridMain.Columns.Add("clnpurchase", "PURCHASE");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnpurchase", 200);

                    GridMain.Columns.Add("clnbalance", "BALANCE");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbalance", 250);
                }

                if (ReportType == "GroupReportSummury")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.Columns.Add("clnpurticulars", "PARTICULARS");
                    GridMain.Columns["clnpurticulars"].Width = 800;

                    GridMain.Columns.Add("clndebit", "Debit");
                    GridMain.Columns["clndebit"].Width = 150;

                    GridMain.Columns.Add("clncredit", "Credit");
                    GridMain.Columns["clncredit"].Width = 100;

                }

                if (ReportType == "AccountReport" || ReportType == "OutstandingReport")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    // this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clndate", "DATE");
                    GridMain.Columns["clndate"].Width = 150;

                    GridMain.Columns.Add("clndue", "DUE");
                    GridMain.Columns["clndue"].Width = 150;



                    GridMain.Columns.Add("clndays", "Days");
                    GridMain.Columns["clndays"].Width = 50;

                    GridMain.Columns.Add("clnpurticulars", "PARTICULARS");
                    GridMain.Columns["clnpurticulars"].Width = 200;


                    GridMain.Columns.Add("clnnotes", "Notes");
                    GridMain.Columns["clnnotes"].Width = 200;

                    GridMain.Columns.Add("clnvtype", "VOUCHER");
                    GridMain.Columns["clnvtype"].Width = 150;

                    GridMain.Columns.Add("clnvno", "VNO");
                    GridMain.Columns["clnvno"].Width = 50;


                    GridMain.Columns.Add("clndebit", "DEBIT");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndebit", 150);

                    GridMain.Columns.Add("clncredit", "CREDIT");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clncredit", 150);

                    GridMain.Columns.Add("clnbalance", "BALANCE");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbalance", 200);
                }
                if (ReportType == "Cheque Receipt" || ReportType == "Cheque Payment")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    AddColumnInGridMain("Vno", "ClnVno", 100, false);
                    AddColumnInGridMain("Paid Date", "ClnPDate", 125, false);
                    AddColumnInGridMain("Cheque Date", "ClnCDate", 125, false);
                    AddColumnInGridMain("CollectedDate", "ClnCollDate", 125, false);
                    AddColumnInGridMain("Account", "ClnAccount", 300, false);
                    AddColumnInGridMain("Bank", "ClnBank", 100, false);
                    AddColumnInGridMain("Cheque No", "ClnChqNo", 150, false);
                    AddColumnInGridMain("Status", "ClnStatus", 80, false);
                    AddColumnInGridMain("Amount", "ClnAmount", 150, true);
                    AddColumnInGridMain("Discount", "ClnDiscount", 150, true);
                    AddColumnInGridMain("NetAmount", "ClnNetAmount", 150, true);
                }
                

             
                if (ReportType == "Purchasetaxsummery")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    //this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 100;

                    GridMain.Columns.Add("clnvnoT", "Vno");
                    GridMain.Columns["clnvnoT"].Width = 50;

                    GridMain.Columns.Add("clnvno", "Invoice.No");
                    GridMain.Columns["clnvno"].Width = 100;


                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 250;


                    GridMain.Columns.Add("Clnarea", "City");
                    GridMain.Columns["Clnarea"].Width = 150;

                    GridMain.Columns.Add("Clntin", "TIN");
                    GridMain.Columns["Clntin"].Width = 100;

                    //GridMain.Columns.Add("clnitemcategory", "Item Name");
                    //GridMain.Columns["clnitemcategory"].Width = 150;

                   
                    GridMain.Columns.Add("cln1tax", "1% Tax");
                    GridMain.Columns["cln1tax"].Width = 100;
                    GridMain.Columns["cln1tax"].Visible = false;

                    GridMain.Columns.Add("cln2tax", "2% Tax");
                    GridMain.Columns["cln2tax"].Width = 100;
                    GridMain.Columns["cln2tax"].Visible = false;

                    GridMain.Columns.Add("cln5tax", "5% Tax");
                    GridMain.Columns["cln5tax"].Width = 100;
                    GridMain.Columns["cln5tax"].Visible = false;

                    GridMain.Columns.Add("cln14tax", "15% Tax");
                    GridMain.Columns["cln14tax"].Width = 100;
                    GridMain.Columns["cln14tax"].Visible = false;

                    GridMain.Columns.Add("cln20tax", "20% Tax");
                    GridMain.Columns["cln20tax"].Width = 100;
                    GridMain.Columns["cln20tax"].Visible = false;
                    
                    GridMain.Columns.Add("clnttax", "Tottal Tax");
                    GridMain.Columns["clnttax"].Width = 100;
                   

                    GridMain.Columns.Add("cln0taxableamt", "0%Taxable Amt");
                    GridMain.Columns["cln0taxableamt"].Width = 100;

                    GridMain.Columns.Add("cln1taxableamt", "1%Taxable Amt");
                    GridMain.Columns["cln1taxableamt"].Width = 150;
                    GridMain.Columns["cln1taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln2taxableamt", "2%Taxable Amt");
                    GridMain.Columns["cln2taxableamt"].Width = 150;
                    GridMain.Columns["cln2taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln5taxableamt", "5%Taxable Amt");
                    GridMain.Columns["cln5taxableamt"].Width = 150;
                    GridMain.Columns["cln5taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln14taxableamt", "15%Taxable Amt");
                    GridMain.Columns["cln14taxableamt"].Width = 150;
                    GridMain.Columns["cln14taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln20taxableamt", "20%Taxable Amt");
                    GridMain.Columns["cln20taxableamt"].Width = 150;
                    GridMain.Columns["cln20taxableamt"].Visible = false;


                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=1");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        
                        GridMain.Columns["cln1tax"].Visible = true;
                        GridMain.Columns["cln1taxableamt"].Visible = true;
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=2 or cst=2");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        GridMain.Columns["cln2tax"].Visible = true;
                        GridMain.Columns["cln2taxableamt"].Visible = true;

                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=5");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                       
                        GridMain.Columns["cln5tax"].Visible = true;
                        GridMain.Columns["cln5taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=15");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                       
                        GridMain.Columns["cln14tax"].Visible = true;
                        GridMain.Columns["cln14taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=20");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                       
                        GridMain.Columns["cln20tax"].Visible = true;
                        GridMain.Columns["cln20taxableamt"].Visible = true;
                    }
                    //GridMain.Columns.Add("clntaxableamt", "Taxble Amt");
                    //Qtycolumnsettings("clntaxableamt", 150);

                    //GridMain.Columns.Add("clntaxamt", "Tax Amt");
                    //Qtycolumnsettings("clntaxamt", 150);
                    GridMain.Columns.Add("clndisc", "Discount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndisc", 100);

                    GridMain.Columns.Add("clnnetamt", "Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnnetamt", 150);

                }

                if (ReportType == "Sales" || ReportType == "Delivery" || ReportType == "Delivery NoteReturn")
                {
                    // this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();

                    /*Column Add */

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 60;

                    GridMain.Columns.Add("ClnDate", "Date");
                    GridMain.Columns["ClnDate"].Width = 120;

                    GridMain.Columns.Add("ClnDepot", "Stock Area");
                    GridMain.Columns["ClnDepot"].Width = 100;

                    GridMain.Columns.Add("ClnParty", "Party");
                    GridMain.Columns["ClnParty"].Width = 250;

                    GridMain.Columns.Add("ClnQty", "Qty");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 100);


                    GridMain.Columns.Add("Clnfree", "Free");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnfree", 100);

                    GridMain.Columns.Add("Clndiscount", "Discount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndiscount", 100);

                    GridMain.Columns.Add("ClnTax", "Tax Amt");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clntax", 100);

                    GridMain.Columns.Add("Clnnett", "Net Total");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnnett", 100);

                    //GridMain.

                }
                if (ReportType == "Stockconsolidated"||ReportType=="Stockconsolidatedwithbatch")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();


                    GridMain.Columns.Add("clnitemname", "Item");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnitemname", 150);

              

                    GridMain.Columns.Add("clnopening", "Opening");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnopening", 70);

                   


                    GridMain.Columns.Add("clnpurchase", "Purchase");

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnpurchase", 70);

                    GridMain.Columns.Add("clnsr", "SR");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnsr", 70);

                    GridMain.Columns.Add("clnbalancen", "BN");

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbalancen", 70);

                    GridMain.Columns.Add("clnmr", "MR");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnMr", 70);


                  

                    GridMain.Columns.Add("clnireceipt", "IReceipt");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnireceipt", 70);

                    GridMain.Columns.Add("clnbmr", "BMR");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbmr", 70);


                    GridMain.Columns.Add("clnfreepre", "Freepre");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnfreepre", 70);

                    GridMain.Columns.Add("clnps", "PS");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnps", 70);

                    GridMain.Columns.Add("clndnr", "DNR");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndnr", 70);


             
                    GridMain.Columns.Add("clnsales", "Sales");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnsales", 70);

                    GridMain.Columns.Add("clnpr", "PR");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnps", 70);

                    GridMain.Columns.Add("clndn", "DN");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnfreepre", 70);

                   

                    GridMain.Columns.Add("clniissue", "IIssue");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndnr", 70);


                    GridMain.Columns.Add("clnsh", "SH");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnsales", 70);

                    GridMain.Columns.Add("clndmg", "DMG");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnfreepre", 70);

                    GridMain.Columns.Add("clnbmi", "BMI");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnps", 70);

                    GridMain.Columns.Add("clnfreeiss", "Freeiss");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clndnr", 70);

                    GridMain.Columns.Add("clnbalance", "Balance");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnbalance", 70);
                }


                if (ReportType == "Stock Value")
                {
                    //GridMain.Columns.Clear();
                }

                if (ReportType == "Stock ValueBatchwise")
                {
                    GridMain.Columns.Clear();
                }
                ChangeLanguage();
            }
            catch
            {
            }

        }
        public void AddColumnInGridMain(string Header, string Columnname, int Width, bool IsAmountCln)
        {

            GridMain.Columns.Add(Columnname, Header);
            GridMain.Columns[Columnname].Width = Width;
            if (IsAmountCln == true)
            {
                GridMain.Columns[Columnname].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                GridMain.Columns[Columnname].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                GridMain.Columns[Columnname].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridMain.Columns[Columnname].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            GridMain.Columns[Columnname].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
       
        public void ReportShowInGrid()
                    {
            try
            {
                if (ReportType == "Tool Data")
                {

                    //frstqts = """";
                    //Lstqts = "'"'";

                    frstqts = @"""";
                   // frstqts = (char)34;
                   // frstqts.Insert(0,@"""");
                    Query = @"SELECT     TblCompanyMaster.Fax as 'Store Id' " +
                        ",TblCompanyMaster.Cname as 'Store Name' " +
                    ",TblBusinessIssue.VNo as 'Bill No',CONVERT(NVARCHAR ,TblBusinessIssue.IssueDate ,105) +' '+ CONVERT(NVARCHAR ,TblBusinessIssue.IssueDate ,8) 'Transaction timestamp'," +
                     "'" + frstqts + "'+" +
                     "TblItemMaster.ItemName "+
                     "+'" + frstqts + "'" +
                     " as 'Item description',TblIssuedetails.BatchId as 'Item barcode'" +
                    ", TblIssuedetails.Qty  as 'Item sale volume ', TblIssuedetails.rate as 'Item unit price'," +
                    " TblIssuedetails.NetAMT as 'Item total sale',TblIssuedetails.Netamtsum  as 'Transaction total sale'," +
                    "TblItemCategory.Category as 'Item Category'                   " +
                    "FROM         TblBusinessIssue INNER JOIN " +
                    " TblIssuedetails ON TblBusinessIssue.IssueCode = TblIssuedetails.IssueCode AND TblBusinessIssue.IssueType = TblIssuedetails.Vtype INNER JOIN " +
                    " Tblbatch ON TblIssuedetails.BatchId = Tblbatch.Bcode AND TblIssuedetails.Pcode = Tblbatch.itemid INNER JOIN " +
                    " TblItemMaster ON TblIssuedetails.Pcode = TblItemMaster.ItemId INNER JOIN " +
                    " TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId CROSS JOIN " +
                    " TblCompanyMaster group by TblCompanyMaster.Cname,TblCompanyMaster.fax " +
                    " ,TblBusinessIssue.VNo , TblBusinessIssue.IssueDate ,tblbusinessissue.issuetype, TblItemMaster.ItemName,TblIssuedetails.BatchId " +
                    " , TblIssuedetails.Qty  , TblIssuedetails.rate , TblIssuedetails.NetAMT ,TblIssuedetails.Netamtsum " +
                    ",TblItemCategory.Category ";

                    Ds = CommonClass._Dbtask.ExecuteQuery(Query + " having  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy hh:mm tt") + " ' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy hh:mm tt") + "' and issuetype='SI' ORDER BY CAST(TblBusinessIssue.VNo AS INT)");

                    GridMain.DataSource = Ds.Tables[0];

                    GridMain.Columns["Store Id"].Width = 200;
                    GridMain.Columns["Store Name"].Width = 300;
                    GridMain.Columns["Bill No"].Width = 100;
                    GridMain.Columns["Transaction timestamp"].Width = 300;
                    GridMain.Columns["Item description"].Width = 350;
                    GridMain.Columns["Item barcode"].Width = 300;

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Item sale volume ", 300);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Item unit price", 300);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Item total sale", 300);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Transaction total sale", 350);
                    GridMain.Columns["Item Category"].Width = 300;
                    GridMain.Columns["Item Category"].HeaderText = "Item Category";
                }

                if (ReportType == "feedbackandFollow")
                {
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clncustomer", "Name");
                    GridMain.Columns["clncustomer"].Width = 200;
                    GridMain.Columns.Add("clnstatus", "Status");
                    GridMain.Columns["clnstatus"].Width = 250;
                    GridMain.Columns.Add("clnfeedback", "Feedback");
                    GridMain.Columns["clnfeedback"].Width = 250;

                    string id = ""; string stsid="";string status="";
                    Ds = _Dbtask.ExecuteQuery("select * from tblfeedback");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            int Count = GridMain.Rows.Add(1);
                            status="";stsid="";id = "";
                            id = _Dbtask.znllString(Ds.Tables[0].Rows[i]["fcustomer"]);
                            stsid = _Dbtask.znllString(Ds.Tables[0].Rows[i]["fcalling"]);
                            GridMain.Rows[Count].Cells["clncustomer"].Value = CommonClass._Ledger.GetspecifField("lname", id);

                            GridMain.Rows[Count].Cells["clnstatus"].Value = CommonClass._feed.getstatus(stsid);
                           GridMain.Rows[Count].Cells["clnfeedback"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["ffeedback"]);

                        }
                    }


                }



                if (ReportType == "Due date bill Report")
                {
                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 40;

                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 250;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 250;

                    GridMain.Columns.Add("clnamt", "Amount");
                    GridMain.Columns["clnamt"].Width = 250;


                    GridMain.Columns.Add("clnnetbalance", "Party Net Balance");
                    GridMain.Columns["clnnetbalance"].Width = 250;


                    Ds = _Dbtask.ExecuteQuery(Query);

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            string ledcode = "";
                            ledcode = _Dbtask.znllString(Ds.Tables[0].Rows[i]["ledcodedr"]);
                           
                                  



                                  DataSet dv;
                                  dv = _Dbtask.ExecuteQuery(" select vno,amt,issuedate,ledcodedr from tblbusinessissue  "+
                                 " where ledcodedr='" + ledcode + "' order by issuedate desc");
                                  if (dv.Tables[0].Rows.Count > 0)
                                  {
                                      for (int K = 0; K < dv.Tables[0].Rows.Count; K++)
                                      {
                                          string lID = "";
                                          lID = _Dbtask.znllString(dv.Tables[0].Rows[K]["ledcodedr"]);
                                          DateTime DDcheck;
                                          DDcheck = _Dbtask.ZnullDatetime(dv.Tables[0].Rows[K]["issuedate"]);
                                          
                                          //if (_Dbtask.ZnullDatetime( DDcheck.ToShortDateString()) <=_Dbtask.ZnullDatetime( ddlimitdate.ToShortDateString()))
                                          // {

                                          DateTime fromm;
                                          fromm = _Dbtask.ZnullDatetime(dateTimePickerto.Value);
                                          int days = 0; days =Convert.ToInt32( (fromm - DDcheck).TotalDays);

                                          if (days>= datenum)
                                           {
                                               double netbalance = 0;


                                               netbalance = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + lID + "'"));

                                               if (netbalance>0)
                                              {

                                               Count = GridMain.Rows.Add(1);

                                               GridMain.Rows[Count].Cells["clnparty"].Tag = lID;

                                               GridMain.Rows[Count].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("Lname", lID);

                                               GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(dv.Tables[0].Rows[K]["vno"]);
                                               GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.znlldoubletoobject(dv.Tables[0].Rows[K]["Amt"]);
                                              GridMain.Rows[Count].Cells["clnnetbalance"].Value =_Dbtask.znlldoubletoobject( _Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + lID + "'"));                     
                                              }
                                           }

                                         K= dv.Tables[0].Rows.Count;

                                      
                                      }
                                  }


                            
                              
                        
                        }
                    }


                }

                //itemwisereprtsale

                if (ReportType == "ItemwiseSlesPreport")
                {


                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height =30;
                    GridMain.ColumnHeadersHeight = 40;
                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 250;

                    GridMain.Columns.Add("clnitem", "Item");
                    GridMain.Columns["clnitem"].Width = 250;

                    GridMain.Columns.Add("clnbatch", "Batch");
                    GridMain.Columns["clnbatch"].Width = 250;
                    GridMain.Columns.Add("clnQty", "Qty");
                    GridMain.Columns["clnQty"].Width = 150;
                    GridMain.Columns.Add("clnnet", "NetAmt");
                    GridMain.Columns["clnnet"].Width = 250;


                    bool Btchy = false;
                       

                    if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                    {
                        Btchy = true;
                        Ds = CommonClass._Transactionreceipt.getitemwisereport(QueryDetail, "  tblbusinessissue.issuedate between '" + DTFrom.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DTTo.ToString("MM/dd/yyyy  HH:mm:ss") + "'");

                    }
                    else
                    {
                        Ds = CommonClass._Transactionreceipt.getitemwisereport(QueryDetail, "  tblbusinessissue.issuedate between '" + DTFrom.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DTTo.ToString("MM/dd/yyyy  HH:mm:ss") + "'");
                        Btchy = false;
                        GridMain.Columns["clnbatch"].Visible = false;
                    }


                    int Count = 0; double sumqty = 0; double ntamttss = 0;
                    if (Ds.Tables[0].Rows.Count > 0)
                    {


                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            string vo = "";
                            vo = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);

                            string pcode = "";
                            string batch = "";
                            double qty = 0;
                            double netamt = 0;
                            pcode = _Dbtask.znllString(_Dbtask.ExecuteScalar("select pcode from tblissuedetails where issuecode='" + vo + "' and   " +
                             " " + QueryDetail + "    "));
                            
                            if( Btchy == true)
                            {
                            batch = _Dbtask.znllString(_Dbtask.ExecuteScalar("select batchid from tblissuedetails where issuecode='" + vo + "' and   " +
                             " " + QueryDetail + "    "));

                            }

                            qty = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(qty) from tblissuedetails where issuecode='" + vo + "'  and   " +
                             " " + QueryDetail + "    "));

                            netamt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(netamt) from tblissuedetails where issuecode='" + vo + "'  and    " +
                             " " + QueryDetail + "    "));

                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LemonChiffon;
                            GridMain.Rows[Count].Cells["clnvno"].Value = vo;
                            GridMain.Rows[Count].Cells["clnitem"].Value = CommonClass._Itemmaster.SpecificField(pcode, "Itemname");

                            if (Btchy == true)
                            {
                                GridMain.Rows[Count].Cells["clnbatch"].Value = batch;
                            }
                            
                            GridMain.Rows[Count].Cells["clnQty"].Value = _Dbtask.SetintoDecimalpoint(qty);
                            sumqty = sumqty + qty;

                            GridMain.Rows[Count].Cells["clnnet"].Value = _Dbtask.SetintoDecimalpoint(netamt);
                            ntamttss = ntamttss + netamt;

                        }
                    }




                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnQty"].Value = _Dbtask.SetintoDecimalpoint(sumqty);
                    GridMain.Rows[Count].Cells["clnnet"].Value = _Dbtask.SetintoDecimalpoint(ntamttss);
                      



                    //GridMain.Columns.Clear();
                    //GridMain.DataSource = null;
                    //Ds.Tables[0].Rows.Add();
                    //Count = Ds.Tables[0].Rows.Count - 1;
                    //DataTable table;
                    //table = Ds.Tables[0];
                    //object sumObject;
                    //sumObject = table.Compute("Sum(qty)", "");
                    //Ds.Tables[0].Rows[Count]["qty"] = _Dbtask.znlldoubletoobject(sumObject);
                    //sumObject = table.Compute("Sum(NetAmt)", "");
                    //Ds.Tables[0].Rows[Count]["NetAmt"] = _Dbtask.znlldoubletoobject(sumObject);

                    //GridMain.DataSource = Ds.Tables[0];
                    //GridMain.Columns["Issuedate"].Width = 170;
                    //GridMain.Columns["VNO"].Width = 70;
                    //if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                    //{

                    //    GridMain.Columns["Batchid"].Width = 190;
                    //}
                    //else
                    //{
                    //    GridMain.Columns["Itemname"].Width = 190;
                    //}
                    //GridMain.Columns["qty"].Width = 90;
                    //GridMain.Columns["Rate"].Width = 90;
                    //GridMain.Columns["Party"].Width = 190;

                    //GridMain.Columns["NetAmt"].Width = 150;

                }








                if (ReportType == "Productionanddetails")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 165;
                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 80;
                    GridMain.Columns.Add("clnPKDate", "Packed");
                    GridMain.Columns["clnPKDate"].Width = 165;
                    GridMain.Columns.Add("clnDepot", "Depo");
                    GridMain.Columns["clnDepot"].Width = 130;

                    
                    GridMain.Columns.Add("clnbarcode", "Barcode");
                    GridMain.Columns["clnbarcode"].Width = 150;

                    GridMain.Columns.Add("clnitemname", "Item");
                    GridMain.Columns["clnitemname"].Width = 190;

                    GridMain.Columns.Add("clnqty", "Qty");
                    GridMain.Columns["clnqty"].Width = 100;

                    GridMain.Columns.Add("clnprate", "P.rate");
                    GridMain.Columns["clnprate"].Width = 90;

                    GridMain.Columns.Add("clncrate", "C.rate");
                    GridMain.Columns["clncrate"].Width = 90;
                    
                    GridMain.Columns.Add("clnamt", "Amount");
                    GridMain.Columns["clnamt"].Width = 130;
                    int Count = 0;
                    string pid = ""; string depid = ""; double netamt = 0; double amts = 0; double netqty = 0; double qty = 0;
                    Ds = _Dbtask.ExecuteQuery("select * from tblrepacking where   " + QueryTemp + "  between '" + DTFrom.ToString("MM/dd/yyyy  00:00:00") + "'  and  '" + DTTo.ToString("MM/dd/yyyy  23:59:59") + "'   " + Query + "");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            pid = ""; depid = ""; amts = 0; qty = 0;


                           Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.White;
                            GridMain.Rows[Count].Cells["clnDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vdate"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnPKDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["packdate"]);

                            depid = _Dbtask.znllString(Ds.Tables[0].Rows[i]["depoid"]);
                            GridMain.Rows[Count].Cells["clnDepot"].Value = CommonClass._Depot.NameDepot(depid);
                            GridMain.Rows[Count].Cells["clnbarcode"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["batchcode"]);

                            pid = _Dbtask.znllString(Ds.Tables[0].Rows[i]["itemid"]);
                            GridMain.Rows[Count].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(pid, "itemname");

                            qty = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"]);
                            netqty = netqty + qty;
                            GridMain.Rows[Count].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(qty); 
                            GridMain.Rows[Count].Cells["clnprate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["prate"]);
                            GridMain.Rows[Count].Cells["clncrate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Crate"]);

                            amts = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["amount"]);
                            netamt=netamt+amts;
                            GridMain.Rows[Count].Cells["clnamt"].Value = amts;
                            



                        }
                    }

                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.Gold;
                    GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(netamt);
                    GridMain.Rows[Count].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(netqty);

                    GridMain.Rows[Count].Cells["clnDate"].Value = "Total";



                }











                //PRSETTLE


                if (ReportType == "BillwisesettilementPR")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 250;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 130;

                    GridMain.Columns.Add("clnactualbill", "Bill Amount");
                    GridMain.Columns["clnactualbill"].Width = 350;
                    GridMain.Columns.Add("clnagainamt", "Received Amt");
                    GridMain.Columns["clnagainamt"].Width = 250;
                    GridMain.Columns.Add("clnBALANCE", "Pending");
                    GridMain.Columns["clnBALANCE"].Width = 250;
                    GridMain.Columns.Add("clnagvno", "Receipt Vno.");
                    GridMain.Columns["clnagvno"].Width = 100;
                    GridMain.Columns["clnagvno"].Visible = false;

                    string Cusnamee = ""; string ledid = ""; double bill = 0; double netbillamt = 0;
                    double recvd = 0; double netreceivd = 0; double netpending = 0; double pending = 0;

                    Ds = _Dbtask.ExecuteQuery("select * from tblPRbillsett where ledcode='" + agvnlid + "' and vtype='PR'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        Cusnamee = CommonClass._Ledger.GetspecifField("lname", agvnlid);
                        int Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Underline);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.Pink;

                        GridMain.Rows[Count].Cells["clnactualbill"].Value = Cusnamee;
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {



                            bill = 0; recvd = 0; pending = 0;
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.Azure;

                            GridMain.Rows[Count].Cells["clnDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Dt"]);
                            string vno = "";
                            vno = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Cramt"]));
                            bill = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Cramt"]);
                            netbillamt = netbillamt + bill;


                            recvd = _Dbtask.znlldoubletoobject(CommonClass._PRbill.GETfeildBYPRAMT(vno, agvnlid, "Dbamt"));
                            GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(recvd);



                            netreceivd = netreceivd + recvd;
                            pending = (bill - recvd);
                            GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(pending);
                            netpending = netpending + pending;


                            GridMain.Rows[Count].Cells["clnagvno"].Value = CommonClass._PRbill.GETfeildBYPR(vno, agvnlid, "vno");


                        }



                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.Pink;
                        GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(netbillamt);
                        GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(netreceivd);
                        GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(netpending);
                        GridMain.Rows[Count].Cells["clnDate"].Value = "Total";

                    }

                }
                //PRSETTLE

                //srbillwise
                if (ReportType == "BillwisesettilementSR")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 250;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 120;

                    GridMain.Columns.Add("clnactualbill", "Bill Amount");
                    GridMain.Columns["clnactualbill"].Width = 350;
                    GridMain.Columns.Add("clnagainamt", "Paid Amt");
                    GridMain.Columns["clnagainamt"].Width = 250;
                    GridMain.Columns.Add("clnBALANCE", "Pending");
                    GridMain.Columns["clnBALANCE"].Width = 250;

                    GridMain.Columns.Add("clnagvno", "Payment Vno.");
                    GridMain.Columns["clnagvno"].Width = 100;
                    GridMain.Columns["clnagvno"].Visible = false;

                    string Cusnamee = ""; string ledid = ""; double bill = 0; double netbillamt = 0;
                    double recvd = 0; double netreceivd = 0; double netpending = 0; double pending = 0;

                    Ds = _Dbtask.ExecuteQuery("select * from tblSRbillsett where ledcode='" + agvnlid + "' and vtype='SR'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        Cusnamee = CommonClass._Ledger.GetspecifField("lname", agvnlid);
                        int Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Underline);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                        GridMain.Rows[Count].Cells["clnactualbill"].Value = Cusnamee;
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {



                            bill = 0; recvd = 0; pending = 0;
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.AliceBlue;

                            GridMain.Rows[Count].Cells["clnDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Dt"]);
                            string vno = "";
                            vno = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]));
                            bill = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]);
                            netbillamt = netbillamt + bill;



                            recvd = _Dbtask.znlldoubletoobject(CommonClass._SRbill.GETfeildBYSRSETTILEAMT(vno, agvnlid, "CRamt"));
                            GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(recvd);

                            netreceivd = netreceivd + recvd;

                            pending = (bill - recvd);
                            GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(pending);
                            netpending = netpending + pending;

                            GridMain.Rows[Count].Cells["clnagvno"].Value = CommonClass._SRbill.GETfeildBYSRSETTILE(vno, agvnlid, "vno");




                        }



                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                        GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(netbillamt);
                        GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(netreceivd);
                        GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(netpending);
                        GridMain.Rows[Count].Cells["clnDate"].Value = "Total";

                    }

                }
                //srbillwise


                if (ReportType == "BillwisesettilementPurchData")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 200;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 100;

                    GridMain.Columns.Add("clnactualbill", "Bill Amount");
                    GridMain.Columns["clnactualbill"].Width = 250;
                    GridMain.Columns.Add("clnagainamt", "Paid Amt");
                    GridMain.Columns["clnagainamt"].Width = 250;
                    GridMain.Columns.Add("clnBALANCE", "Pending");
                    GridMain.Columns["clnBALANCE"].Width = 250;

                    GridMain.Columns.Add("clnagvno", "Payment Vno.");
                    GridMain.Columns["clnagvno"].Width = 100;
                    GridMain.Columns["clnagvno"].Visible = false;
                    

                    string Cusnamee = ""; string ledid = ""; double bill = 0; double netbillamt = 0;
                    double recvd = 0; double netreceivd = 0; double netpending = 0; double pending = 0;

                    Ds = _Dbtask.ExecuteQuery("select * from tblpurchasebillsett where ledcode='" + agvnlid + "' and vtype='PI'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        Cusnamee = CommonClass._Ledger.GetspecifField("lname", agvnlid);
                        int Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Underline);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LightCyan;

                        GridMain.Rows[Count].Cells["clnactualbill"].Value = Cusnamee;
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {



                            bill = 0; recvd = 0; pending = 0;
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.Khaki;

                            GridMain.Rows[Count].Cells["clnDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Dt"]);
                            string vno = "";
                            vno = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]));
                            bill = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]);
                            netbillamt = netbillamt + bill;



                            recvd = _Dbtask.znlldoubletoobject(CommonClass._purbill.GETfeildBYpurchaseAMT(vno, agvnlid, "CRamt"));

                            GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(recvd);
                            netreceivd = netreceivd + recvd;

                            pending = (bill - recvd);
                            GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(pending);
                            netpending = netpending + pending;


                            GridMain.Rows[Count].Cells["clnagvno"].Value = CommonClass._purbill.GETfeildBYpurchase(vno, agvnlid, "vno");


                        }



                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LightCyan;
                        GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(netbillamt);
                        GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(netreceivd);
                        GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(netpending);
                        GridMain.Rows[Count].Cells["clnDate"].Value = "Total";

                    }

                }
                //purchbill

                if (ReportType == "BillwisesettilementData")
                {

                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnDate", "Date");
                    GridMain.Columns["clnDate"].Width = 180;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 100;

                    GridMain.Columns.Add("clnactualbill", "Bill Amount");
                    GridMain.Columns["clnactualbill"].Width = 250;
                    GridMain.Columns.Add("clnagainamt", "Received Amt");
                    GridMain.Columns["clnagainamt"].Width = 250;
                    GridMain.Columns.Add("clnBALANCE", "Pending");
                    GridMain.Columns["clnBALANCE"].Width = 250;
                    GridMain.Columns.Add("clnagvno", "Receipt Vno.");
                    GridMain.Columns["clnagvno"].Width = 100;
                    GridMain.Columns["clnagvno"].Visible = false;

                    GridMain.Columns.Add("clndue", "DueDate");
                    GridMain.Columns["clndue"].Width = 180;

                    string Cusnamee = ""; string ledid = ""; double bill = 0; double netbillamt = 0;
                    double recvd = 0; double netreceivd = 0; double netpending = 0; double pending = 0;

                    Ds = _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + agvnlid + "' and vtype='SI'");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {

                        Cusnamee = CommonClass._Ledger.GetspecifField("lname", agvnlid);
                        int Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Underline);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LemonChiffon;

                        GridMain.Rows[Count].Cells["clnactualbill"].Value = Cusnamee;
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {



                            bill = 0; recvd = 0; pending = 0;
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LavenderBlush;

                            GridMain.Rows[Count].Cells["clndue"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Due"]);

                            GridMain.Rows[Count].Cells["clnDate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Dt"]);
                            string vno = "";
                            vno = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]);
                            GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Cramt"]));
                            bill = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Cramt"]);
                            netbillamt = netbillamt + bill;



                            recvd = _Dbtask.znlldoubletoobject(CommonClass._BillSett.GETfeildBYSALEAMT(vno, agvnlid, "Dbamt"));
                            GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(recvd);


                            netreceivd = netreceivd + recvd;
                            pending = (bill - recvd);
                            GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(pending);
                            netpending = netpending + pending;


                            GridMain.Rows[Count].Cells["clnagvno"].Value = CommonClass._BillSett.GETfeildBYSALE(vno, agvnlid, "vno");


                        }



                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LemonChiffon;
                        GridMain.Rows[Count].Cells["clnactualbill"].Value = _Dbtask.SetintoDecimalpoint(netbillamt);
                        GridMain.Rows[Count].Cells["clnagainamt"].Value = _Dbtask.SetintoDecimalpoint(netreceivd);
                        GridMain.Rows[Count].Cells["clnBALANCE"].Value = _Dbtask.SetintoDecimalpoint(netpending);
                        GridMain.Rows[Count].Cells["clnDate"].Value = "Total";

                    }

                }




                if (ReportType == "Dress Details")
                {
                    GridMain.RowTemplate.Height = 30;
                    GridMain.ColumnHeadersHeight = 80;
                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 200;
                    GridMain.Columns.Add("clnArrivd", "Arrived");
                    GridMain.Columns["clnArrivd"].Width = 250;
                    GridMain.Columns.Add("clnCustomer", "Customer");
                    GridMain.Columns["clnCustomer"].Width = 350;
                    GridMain.Columns.Add("clndelivery", "Delivery");
                    GridMain.Columns["clndelivery"].Width = 250;
                    GridMain.Columns.Add("clncolor", "color");
                    GridMain.Columns["clncolor"].Width = 50;
                    GridMain.Columns["clncolor"].Visible = false;
                    string tvno = ""; string ledid = "";

                    if (Frmtaillorreport.only == true)
                    {
                        Ds = _Dbtask.ExecuteQuery("select * from tbltaillor where lid ='" + cuson + "'");
                    }
                    else
                    {
                        Ds = _Dbtask.ExecuteQuery("select * from tbltaillor where Ardate between '" + DTFrom.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DTTo.ToString("MM/dd/yyyy  HH:mm:ss") + "'");
                    }
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            int Count = GridMain.Rows.Add(1);
                            tvno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                            GridMain.Rows[Count].Cells["clnvno"].Value = tvno.ToString();
                            GridMain.Rows[Count].Cells["clnArrivd"].Value = Ds.Tables[0].Rows[i]["Ardate"].ToString();
                            GridMain.Rows[Count].Cells["clnCustomer"].Value = CommonClass._Ledger.GetspecifField("lname", ledid).ToString();
                            GridMain.Rows[Count].Cells["clndelivery"].Value = Ds.Tables[0].Rows[i]["Deldate"].ToString();
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = Color.LavenderBlush;

                        }
                    }

                }



                //acho

                if (ReportType == "Receipt Report only")
                {

                    string tax = "";
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnrvno", "Vno");
                    GridMain.Columns["clnrvno"].Width = 50;




                    GridMain.Columns.Add("clnrdate", "Date");
                    GridMain.Columns["clnrdate"].Width = 190;

                    GridMain.Columns.Add("clnreceipt", "Receipt");
                    GridMain.Columns["clnreceipt"].Width = 250;

                    if(FrmReport.PRTAX==true)
                    {
                        GridMain.Columns.Add("clnrTAX", "Tax%");
                        GridMain.Columns["clnrTAX"].Width = 190;
                        GridMain.Columns.Add("clnrtaxamt", "Taxamt");
                        GridMain.Columns["clnrtaxamt"].Width = 190;

                        tax = " and rptaxamt>0 ";
                    }

                    GridMain.Columns.Add("clnramount", "Amount");
                    GridMain.Columns["clnramount"].Width = 150;


                    GridMain.Columns.Add("clnNOTE", "Naration");
                    GridMain.Columns["clnNOTE"].Width = 250;
                    GridMain.Columns.Add("clnREF", "Ref No.");
                    GridMain.Columns["clnREF"].Width = 250;


                    double TReceipt = new double();
                    double TPayment = new double();

                    double Receipt = new double();
                    double Payment = new double();

                    double TAmount;
                    double taxrp = 0;

                    double sumtaxrp = 0;
                    string Vno;
                    string Lid;
                    string Lname;

                    /*Following Recipt*/

                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger  where vtype in ('R') and dbamt=0  " + tax + "    and vdate " +
                        " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " +
                    " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        taxrp = 0;
                        GridMain.Rows.Add(1);
                        Lid = Ds.Tables[0].Rows[i]["ledcode"].ToString();

                        Lname = CommonClass._Ledger.GetspecifField("lname", Lid);

                        Receipt = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["cramt"]);
                        
                        
                        Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        GridMain.Rows[i].Cells["clnrvno"].Value = Vno;

                        GridMain.Rows[i].Cells["clnrdate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Vdate"]);


                        GridMain.Rows[i].Cells["clnNOTE"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["naration"]);


                        GridMain.Rows[i].Cells["clnREF"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["refno"]);
                        GridMain.Rows[i].Cells["clnreceipt"].Value = Lname;
                        GridMain.Rows[i].Cells["clnramount"].Value = Receipt;

                        if (FrmReport.PRTAX == true)
                        {
                            GridMain.Rows[i].Cells["clnrTAX"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxperc"]);


                            GridMain.Rows[i].Cells["clnrtaxamt"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxamt"]);

                            taxrp = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxamt"]);
                            sumtaxrp = sumtaxrp + taxrp;
                        }
                        
                        TReceipt = TReceipt + Receipt;
                    }

                   
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnreceipt"].Value = "Total";
                   
                    GridMain.Rows[Count].Cells["clnramount"].Value = _Dbtask.SetintoDecimalpoint(TReceipt);
                    if (FrmReport.PRTAX == true)
                    {

                        GridMain.Rows[Count].Cells["clnrtaxam"].Value = _Dbtask.SetintoDecimalpoint(sumtaxrp);
                    }
                }



                if (ReportType == "Payment Report only")
                {

                    string tax = "";
                    GridMain.Columns.Clear();

                    GridMain.Columns.Add("clnpvno", "Vno");
                    GridMain.Columns["clnpvno"].Width = 50;



                    GridMain.Columns.Add("clnpdate", "Date");
                    GridMain.Columns["clnpdate"].Width = 190;

                    GridMain.Columns.Add("clnpayment", "Payment");
                    GridMain.Columns["clnpayment"].Width = 250;



                    if (FrmReport.PRTAX == true)
                    {
                        GridMain.Columns.Add("clnpTAX", "Tax%");
                        GridMain.Columns["clnpTAX"].Width = 190;

                        GridMain.Columns.Add("clnptaxamt", "Taxamt");
                        GridMain.Columns["clnptaxamt"].Width = 190;

                        tax = " and rptaxamt>0 ";
                    }



                    GridMain.Columns.Add("clnpamount", "Amount");
                    GridMain.Columns["clnpamount"].Width = 150;
                    GridMain.Columns.Add("clnREF", "Ref No.");
                    GridMain.Columns["clnREF"].Width = 250;

                    GridMain.Columns.Add("clnNOTE", "Naration");
                    GridMain.Columns["clnNOTE"].Width = 250;

                    double TReceipt = new double();
                    double TPayment = new double();

                    double Receipt = new double();
                    double Payment = new double();
                    double taxrp = 0;

                    double sumtaxrp = 0;
                    double TAmount;

                    string Vno;
                    string Lid;
                    string Lname;

                    /*Following Recipt*/

                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger  where vtype in ('P') and cramt=0   " + tax + "     and vdate " +
                       " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'" +
                   " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        taxrp = 0;
                        GridMain.Rows.Add(1);
                        Lid = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                        Lname = CommonClass._Ledger.GetspecifField("lname", Lid);
                        Payment = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]);
                        Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        GridMain.Rows[i].Cells["clnpdate"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Vdate"]);


                        GridMain.Rows[i].Cells["clnNOTE"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["naration"]);
                        GridMain.Rows[i].Cells["clnREF"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["refno"]);

                        GridMain.Rows[i].Cells["clnpvno"].Value = Vno;
                        GridMain.Rows[i].Cells["clnpayment"].Value = Lname;
                        GridMain.Rows[i].Cells["clnpamount"].Value = Payment;

                        if (FrmReport.PRTAX == true)
                        {

                            GridMain.Rows[i].Cells["clnpTAX"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxperc"]);


                            GridMain.Rows[i].Cells["clnptaxamt"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxamt"]);

                            taxrp = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rptaxamt"]);
                            sumtaxrp = sumtaxrp + taxrp;

                        }
                        
                        TPayment = TPayment + Payment;
                    }

                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnpayment"].Value = "Total";
                    //GridMain.Rows[Count].Cells["clnpayment"].Value = "Total";
                    //CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                    //GridMain.Rows[Count].Cells["clnramount"].Value = _Dbtask.SetintoDecimalpoint(TReceipt);
                    GridMain.Rows[Count].Cells["clnpamount"].Value = _Dbtask.SetintoDecimalpoint(TPayment);

                    if (FrmReport.PRTAX == true)
                    {

                        GridMain.Rows[Count].Cells["clnptaxamt"].Value = _Dbtask.SetintoDecimalpoint(sumtaxrp);
                    }
                    //Count = GridMain.Rows.Add(1);
                    //GridMain.Rows[Count].Cells["clnreceipt"].Value = "Deferents";
                    //GridMain.Rows[Count].Cells["clnramount"].Value = _Dbtask.SetintoDecimalpoint(TReceipt - TPayment);

                }
















                //acho
















                if (ReportType == "Payment and Receipt Report")
                {

                    double TReceipt=new double();
                    double TPayment = new double();

                    double Receipt = new double();
                    double Payment = new double();

                    double TAmount;

                    string Vno;
                    string Lid;
                    string Lname;

                    /*Following Recipt*/
                    
                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger  where vtype in ('R') and dbamt=0 and vdate "+
                        " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' "+
                    " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))" );
                 
                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add(1);
                        Lid=Ds.Tables[0].Rows[i]["ledcode"].ToString();

                        Lname=CommonClass._Ledger.GetspecifField("lname",Lid);

                        Receipt = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["cramt"]);
                        Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        GridMain.Rows[i].Cells["clnrvno"].Value = Vno;
                        GridMain.Rows[i].Cells["clnreceipt"].Value = Lname;
                        GridMain.Rows[i].Cells["clnramount"].Value = Receipt;
                        TReceipt = TReceipt + Receipt;
                    }

                    /*Following Payment*/

                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger  where vtype in ('P') and cramt=0 and vdate " +
                        " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'" +
                    " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add(1);
                        Lid = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                        Lname = CommonClass._Ledger.GetspecifField("lname", Lid);
                        Payment = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["dbamt"]);
                        Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        GridMain.Rows[i].Cells["clnpvno"].Value = Vno;
                        GridMain.Rows[i].Cells["clnpayment"].Value = Lname;
                        GridMain.Rows[i].Cells["clnpamount"].Value = Payment;
                        TPayment = TPayment + Payment;
                    }

                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnreceipt"].Value = "Total";
                    GridMain.Rows[Count].Cells["clnpayment"].Value = "Total";
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                    GridMain.Rows[Count].Cells["clnramount"].Value = _Dbtask.SetintoDecimalpoint(TReceipt);
                    GridMain.Rows[Count].Cells["clnpamount"].Value = _Dbtask.SetintoDecimalpoint(TPayment);



                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnreceipt"].Value = "Deferents";
                    GridMain.Rows[Count].Cells["clnramount"].Value = _Dbtask.SetintoDecimalpoint(TReceipt - TPayment);
                  

                }

                if(ReportType=="Day Summery report Sale")
                {

                    string Dvno;




                    //DataSet Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by vno");
                    //if()
                    //{
                    //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    //    {
                    //        Dvno = 



                    //    }

                    //}
 
                
                
                
                
                }

                //chqqq

                if (ReportType == "Cheque Receipt" || ReportType == "Cheque Payment")
                {
                    //AddColumnInGridMain("Vno", "ClnVno", 50, false);
                    //AddColumnInGridMain("Paid Date", "ClnPDate", 50, false);
                    //AddColumnInGridMain("Cheque Date", "ClnCDate", 50, false);
                    //AddColumnInGridMain("CollectedDate", "ClnCollDate", 50, false);
                    //AddColumnInGridMain("Account", "ClnAccount", 150, false);
                    //AddColumnInGridMain("Bank", "ClnBank", 150, false);
                    //AddColumnInGridMain("Cheque No", "ClnChqNo", 150, false);
                    //AddColumnInGridMain("Status", "ClnStatus", 150, false);
                    //AddColumnInGridMain("Amount", "ClnAmount", 150, true);
                    //AddColumnInGridMain("Discount", "ClnDiscount", 150, true);
                    //AddColumnInGridMain("NetAmount", "ClnNetAmount", 150, true);

                    double TotalAmt = 0;
                    double TotalDisc = 0;
                    double NetAmt = 0;
                    double discount = 0;
                    double firstamt = 0;
                    double withdiscount = 0;
                    double totnetamounts = 0;
                    string Sql = "select * from TblChqreceived " + Where + " between '" + MinDate(DTFrom) + "' and '" + MaxDate(DTTo) + "' ";
                    DataSet DsChq = _Dbtask.ExecuteQuery(Sql);

                    GridMain.Rows.Clear();
                    //GridMain.DefaultCellStyle.BackColor = Color.DarkRed;

                    if (DsChq.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < DsChq.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Rows.Add(1);
                            GridMain.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                            GridMain.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.DarkMagenta;

                            GridMain.Rows[i].Cells["ClnVno"].Value = DsChq.Tables[0].Rows[i]["id"].ToString();
                            GridMain.Rows[i].Cells["ClnPDate"].Value = Convert.ToDateTime(DsChq.Tables[0].Rows[i]["PDate"]).ToString("dd/MM/yyyy");
                            GridMain.Rows[i].Cells["ClnCDate"].Value = Convert.ToDateTime(DsChq.Tables[0].Rows[i]["CDate"]).ToString("dd/MM/yyyy");
                            GridMain.Rows[i].Cells["ClnCollDate"].Value = Convert.ToDateTime(DsChq.Tables[0].Rows[i]["CollDate"]).ToString("dd/MM/yyyy");
                            GridMain.Rows[i].Cells["ClnAccount"].Tag = DsChq.Tables[0].Rows[i]["Alid"].ToString();
                            GridMain.Rows[i].Cells["ClnAccount"].Value = CommonClass._Ledger.GetspecifField("LName", GridMain.Rows[i].Cells["ClnAccount"].Tag.ToString());
                            GridMain.Rows[i].Cells["ClnBank"].Tag = DsChq.Tables[0].Rows[i]["Blid"].ToString();
                            GridMain.Rows[i].Cells["ClnBank"].Value = CommonClass._Ledger.GetspecifField("LName", GridMain.Rows[i].Cells["ClnBank"].Tag.ToString());
                            GridMain.Rows[i].Cells["ClnChqNo"].Value = DsChq.Tables[0].Rows[i]["ChequeNo"].ToString();
                            GridMain.Rows[i].Cells["ClnStatus"].Value = DsChq.Tables[0].Rows[i]["Status"].ToString();

                            //GridMain.Rows[i].Cells["ClnAmount"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Amount"]));
                            //TotalAmt = TotalAmt + _Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Amount"]);



                            GridMain.Rows[i].Cells["ClnAmount"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["totamt"]));
                            TotalAmt = TotalAmt + _Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["totamt"]);

                            //GridMain.Rows[i].Cells["ClnDiscount"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Discount"]));
                            //TotalDisc = TotalDisc + _Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Discount"]);

                            GridMain.Rows[i].Cells["ClnDiscount"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Discount"]));
                            discount = _Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["Discount"]);
                            firstamt = _Dbtask.znlldoubletoobject(DsChq.Tables[0].Rows[i]["totamt"]);

                            withdiscount = firstamt - discount;
                            GridMain.Rows[i].Cells["ClnNetAmount"].Value = _Dbtask.SetintoDecimalpoint(withdiscount);
                            totnetamounts = totnetamounts + withdiscount;
                             


                        }
                        int Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Black;

                        GridMain.Rows[Count].Cells["ClnAmount"].Value = "--------";
                        GridMain.Rows[Count].Cells["ClnNetAmount"].Value = "--------";
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                        GridMain.Rows[Count].Cells["ClnAmount"].Value = _Dbtask.SetintoDecimalpoint(TotalAmt);
                        GridMain.Rows[Count].Cells["ClnNetAmount"].Value = _Dbtask.SetintoDecimalpoint(totnetamounts);
                    }
                }




                if (ReportType == "Salescustomeranditem")
                {
                    Ds = CommonClass._Ledger.ShowLedger(" where agroupid=18");
                    string TLedid;
                    string TItemId;
                    double Amount;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        TLedid = Ds.Tables[0].Rows[i]["lid"].ToString();
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[i].Cells[0].Value = CommonClass._Ledger.GetspecifField("lname", TLedid);
                        Amount = 0;
                        for (int k = 1; k < GridMain.Columns.Count-1; k++)
                        {
                            TItemId=GridMain.Columns[k].Name.ToString();

                            if (ReportTypeSecond == "Count")
                            {
                                Amount=Amount+_Dbtask.znullDouble(_Dbtask.ExecuteScalar("SELECT     sum(TblIssuedetails.qty) AS Expr1 " +
                                " FROM         TblIssuedetails INNER JOIN TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode " +
                                " group by TblBusinessIssue.LedcodeDr,TblIssuedetails.Pcode HAVING      (TblBusinessIssue.LedcodeDr IN (" + TLedid + ")) " +
                                " AND (TblIssuedetails.Pcode IN (" + TItemId + "))"));

                                GridMain.Rows[i].Cells[k].Value =_Dbtask.znullDouble( _Dbtask.ExecuteScalar("SELECT     sum(TblIssuedetails.qty) AS Expr1 " +
                                " FROM         TblIssuedetails INNER JOIN TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode " +
                                " group by TblBusinessIssue.LedcodeDr,TblIssuedetails.Pcode HAVING      (TblBusinessIssue.LedcodeDr IN (" + TLedid + ")) " +
                                " AND (TblIssuedetails.Pcode IN (" + TItemId + "))"));
                            }

                            else
                            {
                                Amount = Amount + _Dbtask.znullDouble(_Dbtask.ExecuteScalar("SELECT     sum(TblIssuedetails.qty)*sum(TblIssuedetails.rate) AS Expr1 " +
                               " FROM         TblIssuedetails INNER JOIN TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode " +
                               " group by TblBusinessIssue.LedcodeDr,TblIssuedetails.Pcode HAVING      (TblBusinessIssue.LedcodeDr IN (" + TLedid + ")) " +
                               " AND (TblIssuedetails.Pcode IN (" + TItemId + "))"));

                                GridMain.Rows[i].Cells[k].Value =_Dbtask.znullDouble( _Dbtask.ExecuteScalar("SELECT     sum(TblIssuedetails.qty)*sum(TblIssuedetails.rate) AS Expr1 " +
                                  " FROM         TblIssuedetails INNER JOIN TblBusinessIssue ON TblIssuedetails.IssueCode = TblBusinessIssue.IssueCode " +
                                  " group by TblBusinessIssue.LedcodeDr,TblIssuedetails.Pcode HAVING      (TblBusinessIssue.LedcodeDr IN (" + TLedid + ")) " +
                                  " AND (TblIssuedetails.Pcode IN (" + TItemId + "))"));
                            }
                        }
                        GridMain.Rows[i].Cells["clntotal"].Value = Amount;

                    }
                }

                if (ReportType == "PurchaseMonthsummury")
                {
                    Ds = _Dbtask.ExecuteQuery(Query + "  and recptdate  " +
                    " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " +
                    " GROUP BY month (recptdate) ,year (recptdate) " +
                    " order by month (recptdate) ,year (recptdate)asc");
                    Ds.Tables[0].Rows.Add();
                    Count = Ds.Tables[0].Rows.Count - 1;
                    DataTable table;
                    table = Ds.Tables[0];
                    object sumObject;
                    sumObject = table.Compute("Sum(amount)", "");
                    Ds.Tables[0].Rows[Count]["amount"] = _Dbtask.znlldoubletoobject(sumObject);
                    sumObject = table.Compute("Sum(No)", "");
                    Ds.Tables[0].Rows[Count]["No"] = _Dbtask.znlldoubletoobject(sumObject);
                    GridMain.DataSource = Ds.Tables[0];
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "amount", 200);
                }

                if (ReportType == "PurchaseDaysummury")
                {
                    Ds = _Dbtask.ExecuteQuery(Query + "  and recptdate  " +
                    " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " +
                    " GROUP BY day (recptdate), month (recptdate) ,year (recptdate) " +
                  " order by  month (recptdate) ,year (recptdate)asc");
                    Ds.Tables[0].Rows.Add();
                    Count = Ds.Tables[0].Rows.Count - 1;
                    DataTable table;
                    table = Ds.Tables[0];
                    object sumObject;
                    sumObject = table.Compute("Sum(amount)", "");
                    Ds.Tables[0].Rows[Count]["amount"] = _Dbtask.znlldoubletoobject(sumObject);
                    sumObject = table.Compute("Sum(No)", "");
                    Ds.Tables[0].Rows[Count]["No"] = _Dbtask.znlldoubletoobject(sumObject);
                    GridMain.DataSource = Ds.Tables[0];
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "amount", 200);
                }


                 if (ReportType == "SalesMonthsummury")
                {
                   Ds=_Dbtask.ExecuteQuery(Query +"  and issuedate  " +
                   " between '" + DTFrom.ToString("MM/dd/yyyy  hh:mm tt") + " ' and '" + DTTo.ToString("MM/dd/yyyy hh:mm tt") + " ' " +
                   " GROUP BY month (issuedate) ,year (issuedate) "+
                   " order by month (issuedate) ,year (issuedate)asc");
                   Ds.Tables[0].Rows.Add();
                   Count = Ds.Tables[0].Rows.Count - 1;
                   DataTable table;
                   table = Ds.Tables[0];
                   object sumObject;
                   sumObject = table.Compute("Sum(amount)", "");
                   Ds.Tables[0].Rows[Count]["amount"] = _Dbtask.znlldoubletoobject(sumObject);
                   sumObject = table.Compute("Sum(No)", "");
                   Ds.Tables[0].Rows[Count]["No"] = _Dbtask.znlldoubletoobject(sumObject);
                   GridMain.DataSource = Ds.Tables[0];
                   CommonClass._Clreport.Qtycolumnsettings(GridMain, "amount", 200);
                 }

                 if (ReportType == "SalesDaysummury")
                 {

                     GridMain.Rows.Clear();
                     GridMain.Columns.Clear();
                     //this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                     GridMain.Columns.Add("clnday", "Day");
                     GridMain.Columns["clnday"].Width = 100;

                     GridMain.Columns.Add("clnmonth", "Month");
                     GridMain.Columns["clnmonth"].Width = 100;


                     GridMain.Columns.Add("clnyear", "Year");
                     GridMain.Columns["clnyear"].Width = 100;
                     GridMain.Columns.Add("clnno", "No.");
                     GridMain.Columns["clnno"].Width = 80;
                     GridMain.Columns.Add("clntax", "Taxamt");
                     GridMain.Columns["clntax"].Width = 150;
                     GridMain.Columns.Add("clnamt", "Amount");
                     GridMain.Columns["clnamt"].Width = 200;

                     GridMain.Columns.Add("clnsramt", "SalesReturn");
                     GridMain.Columns["clnsramt"].Width = 200;
                     GridMain.Columns.Add("clnbalance", "NetAmount");
                     GridMain.Columns["clnbalance"].Width = 200;
                     double sumnet = 0;
                     double sumtax = 0;
                     double sumamt = 0; double sumsramt = 0;

                     Ds = _Dbtask.ExecuteQuery(Query + "  and issuedate  " +
                     " between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " +
                     " GROUP BY day (issuedate), month (issuedate) ,year (issuedate) " +
                   " order by  month (issuedate) ,year (issuedate)asc");

                      //Ds1 = _Dbtask.ExecuteQuery(" SELECT  SUM (tbltransactionreceipt.AMT) AS 'SR.Amount' "+
                      //         " ,Count (*) as 'SR.No' "+
                      //         " FROM         tbltransactionreceipt "+
                      //         " where RECPTtype='SR'   and "+
                      //         " RECPTdate   between '" + DTFrom.ToString("MM/dd/yyyy") +" 00:00:00' "+
                      //         " and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " +
                      //         "  GROUP BY "+
                      //         " day (RECPTdate), "+
                      //         "  month (RECPTdate) , "+
                      //         "  year (RECPTdate) "+
                      //         " order by  month (RECPTdate), "+
                      //         "  year (RECPTdate)asc ");

                     if (Ds.Tables[0].Rows.Count>0 ||    Ds1.Tables[0].Rows.Count>0)
                     {
                          
                         if(Ds.Tables[0].Rows.Count>0)
                         {
                         for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                         {
                             
                                     string date = ""; double sramt = 0; double tax = 0;
                             DateTime srdate; double samt=0; double balnce=0;
                             string day = ""; string yrr = ""; string mnt = "";
                             int Count = GridMain.Rows.Add(1);
                             
                             GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                             GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;

                             GridMain.Rows[Count].Cells["clnday"].Value =_Dbtask.znllString( Ds.Tables[0].Rows[i]["Day"]);
                             day = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Day"]);
                             GridMain.Rows[Count].Cells["clnmonth"].Value =_Dbtask.znllString( Ds.Tables[0].Rows[i]["Month"]);
                             mnt = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Month"]);
                             GridMain.Rows[Count].Cells["clnyear"].Value =_Dbtask.znllString(  Ds.Tables[0].Rows[i]["Year"]);
                             yrr = _Dbtask.znllString(Ds.Tables[0].Rows[i]["Year"]);
                             GridMain.Rows[Count].Cells["clnno"].Value =_Dbtask.znllString(  Ds.Tables[0].Rows[i]["No"]);
                             GridMain.Rows[Count].Cells["clntax"].Value =_Dbtask.znlldoubletoobject( Ds.Tables[0].Rows[i]["Taxamt"]);
                             tax = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Taxamt"]);
                             GridMain.Rows[Count].Cells["clnamt"].Value =_Dbtask.znlldoubletoobject( Ds.Tables[0].Rows[i]["Amount"]);
                             
                             samt=_Dbtask.znlldoubletoobject( Ds.Tables[0].Rows[i]["Amount"]);
                             sumamt = sumamt + samt;
                             sumtax = sumtax + tax;
                             
                              string dateString = ( mnt +"-"+day +"-"+ yrr);
                              srdate = Convert.ToDateTime(dateString, CultureInfo.InvariantCulture);
                            //srdate = DateTime.ParseExact(dateString, "MM-dd-yyyy", provider);
                             Ds1 = _Dbtask.ExecuteQuery(" SELECT  SUM (tbltransactionreceipt.AMT) AS 'SR.Amount' " +
                               " ,Count (*) as 'SR.No' " +
                               " FROM         tbltransactionreceipt " +
                               " where RECPTtype='SR'   and " +
                               " RECPTdate   between '" + srdate.ToString("MM/dd/yyyy") + " 00:00:00' " +
                               " and '" + srdate.ToString("MM/dd/yyyy") + " 23:59:59' " +
                               "  GROUP BY " +
                               " day (RECPTdate), " +
                               "  month (RECPTdate) , " +
                               "  year (RECPTdate) " +
                               " order by  month (RECPTdate), " +
                               "  year (RECPTdate)asc ");


                             if (Ds1.Tables[0].Rows.Count > 0)
                             {
                                 for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                                 {
                                    
                                     GridMain.Rows[Count].Cells["clnsramt"].Value = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["SR.Amount"]);
                                     sramt=_Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["SR.Amount"]);
                                     sumsramt = sumsramt + sramt;
                                     
                                     
                                 }
                             }

                             balnce= (samt -  sramt);
                             GridMain.Rows[Count].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(balnce);
                             sumnet = sumnet + balnce;
                         
                         
                         }
                         }


                         int Countt = GridMain.Rows.Add(3);

                         GridMain.Rows[Countt].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                         GridMain.Rows[Countt].DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;

                         GridMain.Rows[Countt].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(sumamt);
                         GridMain.Rows[Countt].Cells["clntax"].Value = _Dbtask.SetintoDecimalpoint(sumtax);
                         GridMain.Rows[Countt].Cells["clnsramt"].Value = _Dbtask.SetintoDecimalpoint(sumsramt);
                         GridMain.Rows[Countt].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(sumnet);

                        
                         
                     }
                    //GridMain.Rows[Count].Cells["ClnAmount"].Value =


                    
                     //Ds.Tables[0].Rows.Add();
                     //Count = Ds.Tables[0].Rows.Count - 1;
                     //DataTable table;
                     //table = Ds.Tables[0];
                     //object sumObject;
                     //sumObject = table.Compute("Sum(amount)", "");
                     //Ds.Tables[0].Rows[Count]["amount"] = _Dbtask.znlldoubletoobject(sumObject);
                     //sumObject = table.Compute("Sum(No)", "");
                     //Ds.Tables[0].Rows[Count]["No"] = _Dbtask.znlldoubletoobject(sumObject);
                     //GridMain.DataSource = Ds.Tables[0];
                     //CommonClass._Clreport.Qtycolumnsettings(GridMain, "amount", 200);

                     //CommonClass._Clreport.Qtycolumnsettings(GridMain, "bbbb", 200);

                     //GridMain.Columns.Add("clnvno", "Vno");
                     //GridMain.Columns["clnvno"].Width = 200;
                 
                 }

                if (ReportType == "Salestaxsummery")
                {


                    GridMain.Rows.Clear();
                    GridMain.Columns.Clear();
                    //this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
                    GridMain.Columns.Add("clndate", "VDate");
                    GridMain.Columns["clndate"].Width = 100;

                    GridMain.Columns.Add("clnvno", "Vno");
                    GridMain.Columns["clnvno"].Width = 50;

                    GridMain.Columns.Add("clnparty", "Party");
                    GridMain.Columns["clnparty"].Width = 250;

                    GridMain.Columns.Add("clnaddress", "Address");
                    GridMain.Columns["clnaddress"].Width = 250;

                    GridMain.Columns.Add("clntin", "TIN");
                    GridMain.Columns["clntin"].Width = 150;

                    GridMain.Columns.Add("cln1tax", "1% Tax");
                    GridMain.Columns["cln1tax"].Width = 100;
                    GridMain.Columns["cln1tax"].Visible = false;

                    GridMain.Columns.Add("cln2tax", "2% Tax");
                    GridMain.Columns["cln2tax"].Width = 100;
                    GridMain.Columns["cln2tax"].Visible = false;

                    GridMain.Columns.Add("cln5tax", "5% Tax");
                    GridMain.Columns["cln5tax"].Width = 100;
                    GridMain.Columns["cln5tax"].Visible = false;

                    GridMain.Columns.Add("cln15tax", "15% Tax");
                    GridMain.Columns["cln15tax"].Width = 100;
                    GridMain.Columns["cln15tax"].Visible = false;

                    GridMain.Columns.Add("cln20tax", "20% Tax");
                    GridMain.Columns["cln20tax"].Width = 100;
                    GridMain.Columns["cln20tax"].Visible = false;

                    GridMain.Columns.Add("clnttax", "Tottal Tax");
                    GridMain.Columns["clnttax"].Width = 100;


                    GridMain.Columns.Add("cln0taxableamt", "0%Taxable");
                    GridMain.Columns["cln0taxableamt"].Width = 100;

                    GridMain.Columns.Add("cln1taxableamt", "1%Taxable");
                    GridMain.Columns["cln1taxableamt"].Width = 150;
                    GridMain.Columns["cln1taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln2taxableamt", "2%Taxable");
                    GridMain.Columns["cln2taxableamt"].Width = 150;
                    GridMain.Columns["cln2taxableamt"].Visible = false;


                    GridMain.Columns.Add("cln5taxableamt", "5%Taxable");
                    GridMain.Columns["cln5taxableamt"].Width = 150;
                    GridMain.Columns["cln5taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln15taxableamt", "15%Taxable");
                    GridMain.Columns["cln15taxableamt"].Width = 150;
                    GridMain.Columns["cln15taxableamt"].Visible = false;

                    GridMain.Columns.Add("cln20taxableamt", "20%Taxable");
                    GridMain.Columns["cln20taxableamt"].Width = 150;
                    GridMain.Columns["cln20taxableamt"].Visible = false;


                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=1");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        GridMain.Columns["cln1tax"].Visible = true;
                        GridMain.Columns["cln1taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=2 or cst=2");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        GridMain.Columns["cln2tax"].Visible = true;
                        GridMain.Columns["cln2taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where taxper=5");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        GridMain.Columns["cln5tax"].Visible = true;
                        GridMain.Columns["cln5taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails where taxper=15");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        GridMain.Columns["cln15tax"].Visible = true;
                        GridMain.Columns["cln15taxableamt"].Visible = true;
                    }
                    Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where vat=20");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        GridMain.Columns["cln20tax"].Visible = true;
                        GridMain.Columns["cln20taxableamt"].Visible = true;
                    }
                    //GridMain.Columns.Add("clntaxableamt", "Taxble Amt");
                    //Qtycolumnsettings("clntaxableamt", 150);

                    //GridMain.Columns.Add("clntaxamt", "Tax Amt");
                    //Qtycolumnsettings("clntaxamt", 150);

                    GridMain.Columns.Add("clnttaxable", "Total Gross");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnttaxable", 150);

                    GridMain.Columns.Add("clnnetamt", "Amount");
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnnetamt", 150);



                }
                if (ReportType == "Cheque Details")
                {
                   Ds=_Dbtask.ExecuteQuery("select CASE WHEN cmode = 1  THEN ( 'Cheque Paid') "+
                       " ELSE 'Cheque Received' END AS 'Payment'  ,id as 'Vno',pdate as 'Date',( select lname from tblaccountledger where lid =alid) as 'Party', "+
                    " ( select lname from tblaccountledger where lid =blid) as 'Bank',chequeNo,status "+
                    " from Tblchqreceived");

                    GridMain.DataSource=Ds.Tables[0];

                    GridMain.Columns["Payment"].Width = 150;
                    GridMain.Columns["date"].Width = 150;
                    GridMain.Columns["party"].Width = 200;
                    GridMain.Columns["bank"].Width = 150;
                    GridMain.Columns["chequeno"].Width = 150;
                }

                if (ReportType == "RatioAnalysis")
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Working Capital";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Current Assets-Current Liabilities";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Cash-in-hand";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Bank Accounts";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Bank OD A/c";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Sundry Debtors";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Sundry Debtors";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Sales Accounts";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Purchase Accounts";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Stock-in-hand";
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnprincgrp"].Value = "Nett Profit";

                    GridMain.Rows[0].Cells["clnprincrat"].Value = "Quick Ratio";
                    GridMain.Rows[1].Cells["clnprincrat"].Value = "Gross Profit%";
                    GridMain.Rows[2].Cells["clnprincrat"].Value = "Nett Profit%";

                }

                if (ReportType == "Trading Account")
                {
                    double TDrAmount=new double();
                    double TCrAmount =new double();
                    CommonClass._Clreport.TDirectIncome = 0;
                    CommonClass._Clreport.TIncome = 0;
                    CommonClass._Clreport.TDirectExpence = 0;
                    CommonClass._Clreport.TExpence = 0;
                    CommonClass._Clreport.TIndirectIncome = 0;
                    CommonClass._Clreport.TIndirectExpence = 0;



                    /*For Opening Stock*/
                    GridMain.Rows[0].Cells["clnpurticulars"].Value = "Opening Stock";
                    GridMain.Rows[0].Cells["Clnamount"].Value = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom.AddYears(-50), DTFrom.AddDays(-1));
                    /*************************************************************************/

                    Count = GridMain.Rows.Add(1);
                    /*Closing Stock*/
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Closing Stock";
                    GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom, DTTo);
      
                    /*For Sales*/
                    Count = GridMain.Rows.Add(1);
                      GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Sales";
                      GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("21", DTFrom, DTTo, "CRamt");

                      /*For Sales Return*/
                      Count = GridMain.Rows.Add(1);
                      GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Sales Return";
                      GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("21", DTFrom, DTTo, "dbamt");

                    /*For Purchase*/
                      Count = GridMain.Rows.Add(1);
                      GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Purchase";
                      GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("26", DTFrom, DTTo, "dbamt");

                      /*For Purchase Return*/
                      Count = GridMain.Rows.Add(1);
                      GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Purchase Return";
                      GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("26", DTFrom, DTTo, "cramt");

                    /*For Direct Expence*/
                      Count = GridMain.Rows.Add(1);
                      GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Direct Expence";
                      GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("12", DTFrom, DTTo, "dbamt-cramt");

                    /*For Indirect Expense*/
                      Count = GridMain.Rows.Add(1);
                    tempin = CommonClass._commenevent.DatasetToString("select * from tblaccountgroup where aunder='15' AND agroupid not in(22)", "Agroupid");
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Indirect Expence";
                    GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("15", DTFrom, DTTo, "dbamt-cramt");


                    /*For Indirect Income*/
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Indirect Income";
                    GridMain.Rows[Count].Cells["Clnamount"].Value = CommonClass._Clreport.TraidingAccountFilling("16", DTFrom, DTTo, "dbamt-cramt");

                }


                if (ReportType == "P&L Report")
                {
                    CommonClass._Clreport.TDirectIncome = 0;
                    CommonClass._Clreport.TIncome = 0;
                    CommonClass._Clreport.TDirectExpence = 0;
                    CommonClass._Clreport.TExpence = 0;
                    CommonClass._Clreport.TIndirectIncome = 0;
                    CommonClass._Clreport.TIndirectExpence = 0;



                    /*For Opening Stock*/
                    CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Opening Stock";
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Tag = "Opening Stock";
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom.AddYears(-50), DTFrom.AddDays(-1));
                    CommonClass._Clreport.TDirectExpence = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom.AddYears(-50), DTFrom.AddDays(-1));
                    /*************************************************************************/

                    CommonClass._Clreport.ProfitandLossAccountFilling("12", GridMain, "EXPENCE", DTFrom, DTTo, "12"); /*Direct Expence*/
                    CommonClass._Clreport.ProfitandLossAccountFilling("13", GridMain, "INCOME", DTFrom, DTTo, "13");/*Direct Income*/

                    /*For Closing Stock*/
                    CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Closing Stock";
                    double ClosingStock;
                    ClosingStock = CommonClass._Inventory.DbStockvalue("", "Prate",Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()), DTTo);
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["clndbamount"].Value = ClosingStock;
                    GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["clndbamount"].Tag = "Closing Stock"; 
                    CommonClass._Clreport.ProfitAndLossGroupBalance("13", ClosingStock);

                    /*************************************************************************/

                    /********************/
                    double Gross = new double();
                    double GrossTotal;
                    if (CommonClass._Clreport.TDirectIncome < CommonClass._Clreport.TDirectExpence)
                    {
       
                               /*For Gross Loss*/
                        Gross = CommonClass._Clreport.TDirectExpence - CommonClass._Clreport.TDirectIncome;
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Gross Loss";
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TDirectExpence;
                    }
                    else if (CommonClass._Clreport.TDirectExpence < CommonClass._Clreport.TDirectIncome)
                    {
                        /*For Gross Profit*/
                        Gross = CommonClass._Clreport.TDirectIncome - CommonClass._Clreport.TDirectExpence;
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Gross Profit";
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TDirectIncome;
                    }
                    else
                    {
                        GrossTotal = CommonClass._Clreport.TDirectIncome;
                    }
                    /*********************/
                    CommonClass._Clreport.ForProfitandLossAccountTotal(GridMain, CommonClass._Clreport.RowCountingLiabilty, GrossTotal);
                    /*****************************/
                    if (CommonClass._Clreport.TDirectIncome < CommonClass._Clreport.TDirectExpence)
                    {
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Gross Loss";
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clncamount"].Value = Gross;
                        CommonClass._Clreport.TExpence = CommonClass._Clreport.TExpence + Gross;
                        CommonClass._Clreport.TIndirectExpence = CommonClass._Clreport.TIndirectExpence + Gross;
                    }
                    else if (CommonClass._Clreport.TDirectExpence < CommonClass._Clreport.TDirectIncome)
                    {
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Gross Profit";
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        CommonClass._Clreport.TIncome = CommonClass._Clreport.TIncome + Gross;
                        CommonClass._Clreport.TIndirectIncome = CommonClass._Clreport.TIndirectIncome + Gross;
                      //  CommonClass._Clreport.TIndirectExpence = CommonClass._Clreport.TIndirectExpence + Gross;
                    }
                    /****************************/
                    CommonClass._Clreport.ProfitandLossAccountFilling("15", GridMain, "EXPENCE", DTFrom, DTTo, "15"); /*Indirect Expence*/
                    CommonClass._Clreport.ProfitandLossAccountFilling("16", GridMain, "INCOME", DTFrom, DTTo, "16");/*Indirect Income*/
                    /**********************************/


                    if (CommonClass._Clreport.TIndirectIncome < CommonClass._Clreport.TIndirectExpence)
                    {
                        /*For Gross Loss*/
                        Gross = CommonClass._Clreport.TIndirectExpence - CommonClass._Clreport.TIndirectIncome;
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Net Loss";
                        Gross = CommonClass._Clreport.TIndirectExpence - CommonClass._Clreport.TIndirectIncome;
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TIndirectExpence;
                    }
                    else if (CommonClass._Clreport.TIndirectExpence < CommonClass._Clreport.TIndirectIncome)
                    {
                        /*For Gross Profit*/
                        Gross = CommonClass._Clreport.TIndirectIncome - CommonClass._Clreport.TIndirectExpence;
                        CommonClass._Clreport.RowCountingLiabilty = GridMain.Rows.Add(1);
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Net Profit";
                        GridMain.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TIndirectIncome;
                    }
                    CommonClass._Clreport.ForProfitandLossAccountTotal(GridMain, CommonClass._Clreport.RowCountingLiabilty, GrossTotal);
                }

                if (ReportType == "Stock Transfer Summury")
                {
                   // GridMain.Rows.Clear();
                    Ds = _Dbtask.ExecuteQuery("SELECT TblInternelTransfer.TDate as Date,TblInternelTransfer.tcode as Vno, (SELECT  DName FROM TblDepot WHERE Dcode = TblInternelTransfer.DcodeFrom) AS FromDepot," +
                    " (SELECT  DName FROM TblDepot WHERE Dcode = TblInternelTransfer.dcodeto )AS ToDepot, "+
                    "  SUM(TblTransferDetails.Rate) AS Amount " +
                    " FROM  TblInternelTransfer INNER JOIN "+
                    " TblTransferDetails ON TblInternelTransfer.Tcode = TblTransferDetails.Tcode "+
                    " GROUP BY TblInternelTransfer.tcode,TblInternelTransfer.DcodeFrom,TblInternelTransfer.dcodeto," +
                    " TblInternelTransfer.TDate having TblInternelTransfer.TDate  between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'");
                    GridMain.DataSource = Ds.Tables[0];
                    GridMain.Columns["fromdepot"].Width = 200;
                    GridMain.Columns["todepot"].Width = 200;
                    GridMain.Columns["date"].Width = 200;
                    GridMain.Columns["Amount"].Visible = false;

                }

                if (ReportType == "Balancesheet")
                {
                    string GroupName;
                    string Temp;
                    double TDrAmount = new double();
                    double TCrAmount = new double();
                    double TCashAmount;
                    double TCurrentLiability;
                    double TCustomerAmount;
                    double TSupplierAmount;
                    double TDExpenceAmount;
                    double TFixedAssetAmount;
                    double TIExpenceAmount;
                    double TIIncomeAmount;
                    double TPurchaseAmount;
                    double TSaleAmount;
                    double OpBalance;
                    double OPDebit;
                    double OpCredit;
                     CommonClass._Clreport.MTCrAmount = 0;
                     CommonClass._Clreport.MTDrAmount = 0;
                     //CommonClass._Clreport.Dtfrom = Dtfrom;
                     //CommonClass._Clreport.Dtto = DTTo;
                   /*Printing Laibility*/
                    /*******************************************/

                     CommonClass._Clreport.TCLability = 0;
                     CommonClass._Clreport.TCAsset = 0;
                     CommonClass._Clreport.TLLability = 0;
                     CommonClass._Clreport.TFAsset = 0;
                     CommonClass._Clreport.RowCountingLiabilty = 0;
                     CommonClass._Clreport.RowCountingAsset = 0;
                     CommonClass._Clreport.TLability = 0;
                     CommonClass._Clreport.TAsset = 0;
                     //DTFrom =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
                    /*************************Liability***************************/
                      /*Current Laibility Following (ID IN --11)*/
                     CommonClass._Clreport.BalancesheetFilling("11", GridMain, "LIABILITY", DTFrom, DTTo);
                   // Count = GridMain.Rows.Add(1);
                    // CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                    //GridMain.Rows[Count].Cells["clnlamount"].Value =  CommonClass._Clreport.TCLability;

                    /*Long Term Laibility*/
                     CommonClass._Clreport.BalancesheetFilling("17", GridMain, "LIABILITY", DTFrom, DTTo);

                     CommonClass._Clreport.BalancesheetFilling("P&LCLOSING", GridMain, "LIABILITY", DTFrom, DTTo);
                     

                   // Count = GridMain.Rows.Add(1);
                   //  CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                   // GridMain.Rows[Count].Cells["clnlamount"].Value =  CommonClass._Clreport.TLLability;

                    
                    /****************************Asset****************************/
                    /*Current Asset*/
                     CommonClass._Clreport.BalancesheetFilling("10", GridMain, "ASSET", DTFrom, DTTo);
                  //  Count = GridMain.Rows.Add(1);
                   //  CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                   // GridMain.Rows[Count].Cells["clnaamount"].Value =  CommonClass._Clreport.TCAsset;

                    /*Fixed Asset*/
                     CommonClass._Clreport.BalancesheetFilling("14", GridMain, "ASSET", DTFrom, DTTo);
                     CommonClass._Clreport.BalancesheetFilling("ClosingStock", GridMain, "ClosingStock", DTFrom, DTTo);
                    Count = GridMain.Rows.Add(1);
                    double Deffe;
                    if ( CommonClass._Clreport.TLability >  CommonClass._Clreport.TAsset)
                    {
                        Deffe =  CommonClass._Clreport.TLability -  CommonClass._Clreport.TAsset;
                        GridMain.Rows[Count].Cells["clnassets"].Value = "Deference in Opening Balance";
                        GridMain.Rows[Count].Cells["clnaamount"].Value =_Dbtask.SetintoDecimalpoint(Deffe);
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnlamount"].Value =_Dbtask.SetintoDecimalpoint( CommonClass._Clreport.TLability);
                        GridMain.Rows[Count].Cells["clnaamount"].Value =_Dbtask.SetintoDecimalpoint( CommonClass._Clreport.TLability);
                    }
                    else
                    {
                        Deffe =  CommonClass._Clreport.TAsset -  CommonClass._Clreport.TLability;
                  

                        GridMain.Rows[Count].Cells["clnlaibilities"].Value = "Deference in Opening Balance";
                        GridMain.Rows[Count].Cells["clnlamount"].Value =_Dbtask.SetintoDecimalpoint(Deffe);
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnlamount"].Value =_Dbtask.SetintoDecimalpoint( CommonClass._Clreport.TAsset);
                        GridMain.Rows[Count].Cells["clnaamount"].Value =_Dbtask.SetintoDecimalpoint( CommonClass._Clreport.TAsset);
                    }
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                } 

                if (ReportType == "TrailBalance")
                {
                    string GroupName;
                    string Temp;
                    double TDrAmount=new double();
                    double TCrAmount=new double();
                    double TCashAmount;
                    double TCurrentLiability;
                    double TCustomerAmount;
                    double TSupplierAmount;
                    double TDExpenceAmount;
                    double TFixedAssetAmount;
                    double TIExpenceAmount;
                    double TIIncomeAmount;
                    double TPurchaseAmount;
                    double TSaleAmount;
                    double OpBalance=new double();
                    double OPDebit=new double();
                    double OpCredit=new double();
                     CommonClass._Clreport.MTCrAmount = 0;
                     CommonClass._Clreport.MTDrAmount = 0;

                   DTFrom=  dateTimePickerfrom.Value;
                   DTTo= dateTimePickerto.Value;
                   /*For Deference in Opening Balance*/

                   if (Generalfunction.BlShowEst == true || Generalfunction.BlShowEst == false)
                   {
                       OpBalance = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt-cramt),0) from  tblgeneralledger where vtype='OB' and  vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'"));
                       OPDebit = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from  tblgeneralledger where vtype='OB' and vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'"));
                       OpCredit = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from  tblgeneralledger where vtype='OB'  and vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59'"));
                   }
                   else
                   {
                        string Estlid=CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate","lid");
                        if (Estlid != "")
                        {
                            OpBalance = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt-cramt),0) from  tblgeneralledger where vtype='OB' and  vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='"+Estlid+"'"));
                            OPDebit = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from  tblgeneralledger where vtype='OB' and vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='"+Estlid+"'"));
                            OpCredit = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from  tblgeneralledger where vtype='OB'  and vdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='"+Estlid+"'"));
                        }
                   }

                  
                       if (OPDebit > OpCredit)
                       {
                           OpBalance = OpCredit - OPDebit;
                            CommonClass._Clreport.TrailBalanceFillingOpeningBalance(GridMain, "Cr", "OB", "Defernce in Opening Balance Ledger", "OB", OpBalance);
                       }
                       else if (OpCredit > OPDebit)
                       {
                           OpBalance = Math.Abs(OpBalance);
                            CommonClass._Clreport.TrailBalanceFillingOpeningBalance(GridMain, "DR", "OB", "Defernce in Opening Balance Ledger", "OB", OpBalance);
                       }
                   

                    /************************************/
                  
                    /*For Capital*/
                     CommonClass._Clreport.TrailBalanceFilling("28", GridMain, TDrAmount, TCrAmount, "CAPITAL", "DR", "", DTFrom, DTTo);
                    /*For Cash*/
                     CommonClass._Clreport.TrailBalanceFilling("25", GridMain, TDrAmount, TCrAmount, "CASH", "DR", "", DTFrom, DTTo);

                    /*For Bank*/
                     CommonClass._Clreport.TrailBalanceFilling("24", GridMain, TDrAmount, TCrAmount, "BANK", "DR", "", DTFrom, DTTo);
                    /*For Current Liability*/
                     tempin = CommonClass._commenevent.DatasetToString("select * from tblaccountgroup where aunder='11' AND agroupid not in(19,23) or agroupid=11", "Agroupid");
                     CommonClass._Clreport.TrailBalanceFilling(tempin, GridMain, TDrAmount, TCrAmount, "Current LIABILITY", "CR", "", DTFrom, DTTo);

                     /*For Long Term Liability*/
                     tempin = CommonClass._commenevent.DatasetToString("select * from tblaccountgroup where (agroupid=17) or aunder=17  and agroupid !=28", "Agroupid");
                     CommonClass._Clreport.TrailBalanceFilling(tempin, GridMain, TDrAmount, TCrAmount, "Long Term LIABILITY", "CR", "", DTFrom, DTTo);
                    
                    
                    /*For Purchase*/
                     CommonClass._Clreport.TrailBalanceFilling("26", GridMain, TDrAmount, TCrAmount, "PURCHASE", "DR", "", DTFrom, DTTo);
                    
                    
                    /*For Customer*/
                     CommonClass._Clreport.TrailBalanceFilling("18", GridMain, TDrAmount, TCrAmount, "CUSTOMER", "DR", "", DTFrom, DTTo);
                    
                    
                    /*For Direct Expence*/
                     tempin = CommonClass._commenevent.DatasetToString("select * from tblaccountgroup where (aunder='12' AND agroupid not in(26,27))or agroupid=12", "Agroupid");
                 
                     CommonClass._Clreport.TrailBalanceFilling(tempin, GridMain, TDrAmount, TCrAmount, "DIRECT EXPENCE", "DR", "", DTFrom, DTTo);


                    /*For Fixed Asset*/
                     CommonClass._Clreport.TrailBalanceFilling("14", GridMain, TDrAmount, TCrAmount, "FIXED ASSET", "DR", "", DTFrom, DTTo);

                    /*For Indirect Expense*/
                     tempin = CommonClass._commenevent.DatasetToString("select * from tblaccountgroup where (aunder='15' AND agroupid not in(22)) or  agroupid=15", "Agroupid");
                     
                     CommonClass._Clreport.TrailBalanceFilling(tempin, GridMain, TDrAmount, TCrAmount, "INDIRECT EXPENCE", "DR", "", DTFrom, DTTo);

                    /*For Indirect Income*/
                     CommonClass._Clreport.TrailBalanceFilling("16", GridMain, TDrAmount, TCrAmount, "INDIRECT INCOME", "CR", "", DTFrom, DTTo);


                    /*For Sales*/
                     CommonClass._Clreport.TrailBalanceFilling("21", GridMain, TDrAmount, TCrAmount, "SALES", "CR", "", DTFrom, DTTo);

                    /*For Loan*/
                    // CommonClass._Clreport.TrailBalanceFilling("30", GridMain, TDrAmount, TCrAmount, "LOANS", "DR", "", DTFrom, DTTo);
                    
                    /*For Supplier*/
                     CommonClass._Clreport.TrailBalanceFilling("19", GridMain, TDrAmount, TCrAmount, "SUPPLIER", "CR", "", DTFrom, DTTo);

                    /*For Employee*/
                     CommonClass._Clreport.TrailBalanceFilling("22", GridMain, TDrAmount, TCrAmount, "Employee", "DR", "", DTFrom, DTTo);

                    /*For Current Liability*/
                     CommonClass._Clreport.TrailBalanceFilling("2", GridMain, TDrAmount, TCrAmount, "CURRENT LIABILITY", "DR", "", DTFrom, DTTo);

                    /*For TAXCOLLECTED*/
                     CommonClass._Clreport.TrailBalanceFilling("23", GridMain, TDrAmount, TCrAmount, "TAX COLLECTED", "DR", "", DTFrom, DTTo);

                    Count = GridMain.Rows.Add(2);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint( CommonClass._Clreport.MTCrAmount);
                    GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint( CommonClass._Clreport.MTDrAmount);
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                }

                if (ReportType == "QplexP&Ldate")
                {
                    Profit = 0;
                    Income = 0;
                    Expence = 0;
                    TIncome = 0;
                    TsalesNet = 0;
                    TSRNet = 0;
                    TcostNet = 0;
                    Tperc = 0;
                    TExpence = 0;
                    Tprofit = 0;
                    SalesAmount = 0;
                    SalesReturnAmount = 0;

                    Crate = 0;
                    Srate = 0;
                    Qty = 0;
                 
                    Pcost = 0;
                  
                    SPcost = 0;

                   

                    bool Sbatch;


                    if (CommonClass._Menusettings.GetMnustatus("103") == "1")
                    {
                        Sbatch = true;
                    }
                    else
                    {
                        Sbatch = false;
                    }

                    for (DateTime Dk = DTFrom; Dk <= DTTo; Dk.AddDays(1))
                    {
                        SalesAmount = 0;
                        Perc = 0;
                        Pcost = 0;
                        SPcost = 0;
                        SalesReturnAmount = 0;

                        Income = 0;
                        Expence = 0;
                        Profit = 0;

                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clndate"].Value = Dk.ToString("dd/MM/yyyy");
                       
                    
                        Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuedate between '" + Dk.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dk.ToString("MM/dd/yyyy") + " 23:59:59' and issuetype='SI' order by issuedate asc");

                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            string Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                            string LecodeCr = Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                            Ds1 = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + Issuecode + "' and vtype='SI' and ledcode='" + LecodeCr + "'");

                           
                            for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                            {
                                Pid = Ds1.Tables[0].Rows[ii]["Pcode"].ToString();
                                Sinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incs");
                                Pinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incp");
                                if (Sbatch == true)
                                {
                                    string Bcode;
                                    Bcode = Ds1.Tables[0].Rows[ii]["Batchid"].ToString();
                                    Crate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Bcode, "prate"));

                                    if (Crate == 0)
                                    {
                                    }
                                }
                                else
                                {
                                    Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0) from tblitemmaster where itemid='" + Pid + "'"));
                                }
                                Srate = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["rate"].ToString());

                                if (Sinclusivetax == "-1")
                                {
                                    Srate = Srate + _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["taxrate"].ToString());
                                }

                                if (Pinclusivetax == "-1")
                                {
                                    if (Sbatch == true)
                                    {
                                        Temp = Crate * _Dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(Pid, "purtax")) / 100;
                                        Crate = Crate + Temp;
                                    }
                                }

                                Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());
                                TSrate = Qty * Srate;
                                TCrate = Qty * Crate;
                                SalesAmount = SalesAmount + TSrate;
                                Pcost = Pcost + TCrate;

                            
                            
                            }

                        }
                     

                        Ds = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where recptdate between '" + Dk.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dk.ToString("MM/dd/yyyy") + " 23:59:59' and recpttype='SR' order by recptdate asc");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            string Issuecode = Ds.Tables[0].Rows[i]["reptcode"].ToString();
                            string tVtype = Ds.Tables[0].Rows[i]["recpttype"].ToString();
                            Ds1 = _Dbtask.ExecuteQuery("select * from tblreceiptdetails where recptcode='" + Issuecode + "' and vtype='" + tVtype + "' " + QueryTemp + "");
                            for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                            {
                                Pid = Ds1.Tables[0].Rows[ii]["Pcode"].ToString();

                                if (Sbatch == true)
                                {
                                    string Bcode;
                                    Bcode = Ds1.Tables[0].Rows[ii]["Batchid"].ToString();
                                    Crate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Bcode, "prate"));

                                    if (Crate == 0)
                                    {
                                    }
                                }
                                else
                                {
                                    Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0) from tblitemmaster where itemid='" + Pid + "'"));
                                }

                                Srate = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["rate"].ToString());
                                Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());
                                TSrate = Qty * Srate;
                                TCrate = Qty * Crate;
                                SalesReturnAmount = SalesReturnAmount + TSrate;
                                SPcost = SPcost + TCrate;
                            }

                        }



                        Income = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(cramt) from tblgeneralledger where ledcode " +
                                 " in(select lid from tblaccountledger where agroupid in (select agroupid from tblaccountgroup where( " +
                                 " agroupid in (7,13,16) or aunder in (7,13,16)) and agroupid not in (21)))" +
                                 " and vdate between '" + Dk.ToString("MM/dd/yyyy 00:00:00") + "' and '" + Dk.ToString("MM/dd/yyyy 23:59:59") + "' "));

                        Expence = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(dbamt) from tblgeneralledger where ledcode " +
                                 " in(select lid from tblaccountledger where agroupid in (select agroupid from tblaccountgroup where( " +
                                 " agroupid in (6,12,15) or aunder in (6,12,15)) and agroupid not in (27,26)))" +
                                 " and vdate between '" + Dk.ToString("MM/dd/yyyy 00:00:00") + "' and '" + Dk.ToString("MM/dd/yyyy 23:59:59") + "' "));


                        Profit = (SalesAmount-SalesReturnAmount) - (Pcost - SPcost);
                        Profit = Profit + Income;
                        Profit = Profit - Expence;
                        Perc = (SalesAmount - SalesReturnAmount)-(Pcost - SPcost) ;
                        Perc = 100 * Perc / (SalesAmount - SalesReturnAmount);

                        GridMain.Rows[Count].Cells["clnsales"].Value = _Dbtask.SetintoDecimalpoint(SalesAmount);
                        GridMain.Rows[Count].Cells["clnpr"].Value = _Dbtask.SetintoDecimalpoint(Perc);
                        GridMain.Rows[Count].Cells["clncost"].Value = _Dbtask.SetintoDecimalpoint(Pcost - SPcost);

                        GridMain.Rows[Count].Cells["clnsr"].Value = _Dbtask.SetintoDecimalpoint(SalesReturnAmount);

                        GridMain.Rows[Count].Cells["clnincome"].Value = _Dbtask.SetintoDecimalpoint(Income);
                        GridMain.Rows[Count].Cells["clnexpence"].Value = _Dbtask.SetintoDecimalpoint(Expence);
                        GridMain.Rows[Count].Cells["clnprofit"].Value = _Dbtask.SetintoDecimalpoint(Profit);

                        TIncome = TIncome + Income;
                        TExpence = TExpence + Expence;
                        Tprofit = Tprofit + Profit;
                        TsalesNet = TsalesNet + SalesAmount;
                        TSRNet = TSRNet + SalesReturnAmount;
                        TcostNet = TcostNet + (Pcost - SPcost);
                       

                       
                        Dk = Dk.AddDays(1);
                    }
                    double TExp = TEmployeeAmt + IndirectExpence + Pcost;
                    double TInc = SalesAmount + TindirectIncome;
                    Count = GridMain.Rows.Add(1);


                    GridMain.Rows[Count].Cells["clnsales"].Value = _Dbtask.SetintoDecimalpoint(TsalesNet);
                    GridMain.Rows[Count].Cells["clncost"].Value = _Dbtask.SetintoDecimalpoint(TcostNet);
                    GridMain.Rows[Count].Cells["clnsr"].Value = _Dbtask.SetintoDecimalpoint(TSRNet);

                    GridMain.Rows[Count].Cells["clnincome"].Value = _Dbtask.SetintoDecimalpoint(TIncome);
                    GridMain.Rows[Count].Cells["clnexpence"].Value = _Dbtask.SetintoDecimalpoint(TExpence);
                    GridMain.Rows[Count].Cells["clnprofit"].Value = _Dbtask.SetintoDecimalpoint(Tprofit);


                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }


                if (ReportType == "QplexP&L" || ReportType == "QplexP&Ldetail")
                {
                    Crate = 0;
                    Srate = 0;
                    Qty = 0;
                    SalesAmount = 0;
                    ServiceAmount = 0;
                    Pcost = 0;
                    SalesReturnAmount = 0;
                    SPcost = 0;
                    bool Sbatch;
                   

                    if (CommonClass._Menusettings.GetMnustatus("103") == "1")
                    {
                        Sbatch = true;
                    }
                    else
                    {
                        Sbatch = false;
                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and issuetype='SV' order by issuedate asc");

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                        string LecodeCr = Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + Issuecode + "' and vtype='SV' and ledcode='" + LecodeCr + "'");

                        
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            Pid = Ds1.Tables[0].Rows[ii]["Pcode"].ToString();
                            Sinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incs");
                            Pinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incp");
                            
                            //                            Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0) from tblitemmaster where itemid='" + Pid + "'"));
                            Srate = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["rate"].ToString());

                            if (Sinclusivetax == "-1")
                            {
                                Srate = Srate + _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["taxrate"].ToString());
                            }

                            if (Pinclusivetax == "-1")
                            {
                                if (Sbatch == true)
                                {
                                    Temp = Crate * _Dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(Pid, "purtax")) / 100;
                                    Crate = Crate + Temp;
                                }
                            }

                            Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());
                            TSrate = Qty * Srate;
                            ServiceAmount = ServiceAmount + TSrate;
                        }

                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tblbusinessissue where issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and issuetype='SI' order by issuedate asc");

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                        string LecodeCr = Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode='" + Issuecode + "' and vtype='SI' and ledcode='"+LecodeCr+"'");

                        if (Ds.Tables[0].Rows[i]["ledcodecr"].ToString() == "2")
                        {
                        }
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            Pid = Ds1.Tables[0].Rows[ii]["Pcode"].ToString();
                            Sinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incs");
                            Pinclusivetax = CommonClass._Itemmaster.SpecificField(Pid, "incp");
                            if (Sbatch == true)
                            {
                                string Bcode;
                                Bcode = Ds1.Tables[0].Rows[ii]["Batchid"].ToString();
                                Crate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Bcode, "prate"));

                                if (Crate == 0)
                                {
                                }
                            }
                            else
                            {
                                
                                Ds2 = _Dbtask.ExecuteQuery("select * from tblrepacking where itemid="+Pid+" ");
                                if (Ds2.Tables[0].Rows.Count > 0)
                                {
                                    Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum (prate) from tblrepacking where itemid='" + Pid + "'")) / Ds2.Tables[0].Rows.Count;
                                }
                                else
                                {
                               
                                        Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(netamt)/sum(qty+freeqty) from tblreceiptdetails where pcode='" + Pid + "'"));
                                  
                                }
                            }
                           
                            if (Crate == 0)
                            {
                                Prate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0) from tblitemmaster where itemid='" + Pid + "'"));

                                Crate = Prate * _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(Purtax,0) from tblitemmaster where itemid='" + Pid + "'"))/100;
                                Crate =Prate+ Crate;
                            }


                            Srate = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["rate"].ToString());
                            Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());
                            if (Sinclusivetax == "-1")
                            {

                                double PP=_Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["taxrate"].ToString());

                                Srate = Srate + (_Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["taxrate"].ToString()) / Qty);
                            }

                            if (Pinclusivetax == "-1")
                            {
                                if (Sbatch == true)
                                {
                                    Temp = Crate * _Dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(Pid, "purtax")) / 100;
                                    Crate = Crate + Temp;
                                }
                            }

                            Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());
                            TSrate = Qty * Srate;
                            TCrate = Qty * Crate;
                            SalesAmount = SalesAmount + TSrate;
                            Pcost = Pcost + TCrate;
                        }

                    }


                    Ds = _Dbtask.ExecuteQuery("select * from tbltransactionreceipt where recptdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' and recpttype='SR' order by recptdate asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuecode = Ds.Tables[0].Rows[i]["reptcode"].ToString();
                        string tVtype = Ds.Tables[0].Rows[i]["recpttype"].ToString();
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblreceiptdetails where recptcode='" + Issuecode + "' and vtype='" + tVtype + "' " + QueryTemp + "");
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            Pid = Ds1.Tables[0].Rows[ii]["Pcode"].ToString();

                            if (Sbatch == true)
                            {
                                string Bcode;
                                Bcode = Ds1.Tables[0].Rows[ii]["Batchid"].ToString();
                                Crate = _Dbtask.znullDouble(CommonClass._Batch.GetSpecificFieldofBatch(Bcode, "prate"));

                                if (Crate == 0)
                                {
                                }
                            }
                            else
                            {
                                Crate = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(prate,0) from tblitemmaster where itemid='" + Pid + "'"));
                            }

                            Srate = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["rate"].ToString());
                            Qty = _Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["qty"].ToString());

                            //uii
                            if (Sinclusivetax == "-1")
                            {
                                Srate = Srate + (_Dbtask.znullDouble(Ds1.Tables[0].Rows[ii]["taxrate"].ToString()) / Qty);
                            }

                            if (Pinclusivetax == "-1")
                            {
                                if (Sbatch == true)
                                {
                                    Temp = Crate * _Dbtask.znlldoubletoobject(CommonClass._Itemmaster.SpecificField(Pid, "purtax")) / 100;
                                    Crate = Crate + Temp;
                                }
                            }

                            
                            
                            
                            TSrate = Qty * Srate;
                            TCrate = Qty * Crate;
                            SalesReturnAmount = SalesReturnAmount + TSrate;
                            SPcost = SPcost + TCrate;
                        }

                    }

                    //Count = GridMain.Rows.Add(1);
                    //GridMain.Rows[Count].Tag = "Services";
                    //GridMain.Rows[Count].Cells[0].Value = "Total Services";
                    //GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(ServiceAmount);
                    //GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);


                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "Sales";
                    GridMain.Rows[Count].Cells[0].Value = "Total Sales";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(SalesAmount);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);



                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "SR";
                    GridMain.Rows[Count].Cells[0].Value = "Total SalesReturn";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(SalesReturnAmount);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "Crate";
                    GridMain.Rows[Count].Cells[0].Value = "Cost Rate";
                    GridMain.Rows[Count].Cells[1].Value =_Dbtask.SetintoDecimalpoint(Pcost-SPcost);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    SalesAmount = SalesAmount - SalesReturnAmount;
                    Pcost = Pcost - SPcost;
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "Gross Profit";
                    GridMain.Rows[Count].Cells[0].Value = "Gross Profit";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(SalesAmount - Pcost);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Blue;

                    TCooly = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select  isnull(sum(cramt),0) from tblgeneralledger where ledcode=26   and vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));
                    TDiscount = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select  isnull(sum(dbamt),0) from tblgeneralledger where ledcode=7 and  vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));

                    TindirectIncome = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("SELECT     isnull(SUM(TblGeneralLedger.crAmt),0) AS Expr1 FROM TblAccountLedger INNER JOIN " +
                     " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                     "where   (tblaccountledger.agroupid IN (16))and  vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));

                    IndirectExpence = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("SELECT     SUM(TblGeneralLedger.DbAmt)-SUM(TblGeneralLedger.cramt) AS Expr1 FROM TblAccountLedger INNER JOIN " +
                     " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode "+
                     "where   (tblaccountledger.agroupid IN (15))and  vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));
                    
                    
                    Ds2 = _Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid=22");
                    string Employeeid = "";
                    for (int k = 0; k < Ds2.Tables[0].Rows.Count; k++)
                    {
                        Employeeid = Employeeid + "," + Ds2.Tables[0].Rows[k]["lid"].ToString();
                    }
                    if (Employeeid.Length > 0)
                    {
                        Employeeid = Employeeid.Substring(1, Employeeid.Length - 1);
                        TEmployeeAmt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select  isnull(sum(dbamt),0) from tblgeneralledger where ledcode in(" + Employeeid + ") and   vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));
                    }
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Tag = "Iicome";
                    GridMain.Rows[Count].Cells[0].Value = "Indirect Income";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TindirectIncome);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    if (ReportType == "QplexP&Ldetail")
                    {

                        Ds = CommonClass._Clreport.LedgerSummuryBaseOnGroup(" where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where agroupid in (16) or aunder in (16)) " + " and  tblgeneralledger.vDate between  '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                            StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                            DbAmount = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["amount"].ToString());

                            if (DbAmount != 0)
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = "                          " + StrPurticulars;
                                GridMain.Rows[Count].Tag = AccountID;


                                GridMain.Rows[Count].Cells[1].Value = "                          " + _Dbtask.SetintoDecimalpoint(DbAmount);
                                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
                                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                            }
                        }
                    }
                    


                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "Iexpence";
                    GridMain.Rows[Count].Cells[0].Value = "Indirect Expense";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(IndirectExpence);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    if (ReportType == "QplexP&Ldetail")
                    {
                        Ds = CommonClass._Clreport.LedgerSummuryBaseOnGroup(" where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where agroupid in (15) or aunder in (25)) " + " and  tblgeneralledger.vDate between  '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                            StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                            DbAmount = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["amount"].ToString());

                            if (DbAmount != 0)
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = "                          " + StrPurticulars;
                                GridMain.Rows[Count].Tag = AccountID;


                                GridMain.Rows[Count].Cells[1].Value = "                          " + _Dbtask.SetintoDecimalpoint(DbAmount);
                                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
                                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                            }
                        }

                    }


                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = "Eexpense";
                    GridMain.Rows[Count].Cells[0].Value = "Employee Expense";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TEmployeeAmt);
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    if (ReportType == "QplexP&Ldetail")
                    {
                        Ds = CommonClass._Clreport.LedgerSummuryBaseOnGroup(" where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where agroupid in (22) or aunder in (22)) " + " and  tblgeneralledger.vDate between  '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                            StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                            DbAmount = _Dbtask.znullDouble(Ds.Tables[0].Rows[i]["amount"].ToString());

                            if (DbAmount != 0)
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = "                          " + StrPurticulars;
                                GridMain.Rows[Count].Tag = AccountID;


                                GridMain.Rows[Count].Cells[1].Value = "                          " + _Dbtask.SetintoDecimalpoint(DbAmount);

                            }
                            
                        }
                     
                    }

                    double TExp = TEmployeeAmt + IndirectExpence + Pcost ;
                    double TInc = SalesAmount + TindirectIncome;
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells[0].Value = "Nett Profit";
                    GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TInc - TExp);

                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                }



                //billagainst


                if (ReportType == "Purchase Bill Wise SettleMent")
                {
                    Ds = _Dbtask.ExecuteQuery("Select * from TblAccountLedger Where AGroupid = '19' " + Where + " Order By LName Asc");
                    for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                    {
                        double TotalBillAmt = 0;
                        double TotalSr = 0;
                        double TotalR = 0;
                        double TotalBAmt = 0;
                        double latesttotal = 0;

                        string LedCode = Ds.Tables[0].Rows[k]["Lid"].ToString();
                        string Vno = "";

                        //ob

                        CommonClass._Transactionreceipt.GetSupplierBasedBillList(LedCode);
                        DataSet DsPurchase = CommonClass._Transactionreceipt.GetSupplierBasedBillList(LedCode);


                        if (DsPurchase.Tables[0].Rows.Count > 0) //Filtering the Fully Settled Bill
                        {
                            for (int i = 0; i < DsPurchase.Tables[0].Rows.Count; i++)
                            {
                                Vno = DsPurchase.Tables[0].Rows[i]["VNo"].ToString();
                                if (CommonClass._PurchaseBillSett.IsBillFullySettled(Vno) == true)
                                {
                                    DsPurchase.Tables[0].Rows.RemoveAt(i);
                                    i = i - 1;
                                }
                            }
                        }

                        //GridMain.Columns.Add("clndate", "Date");
                        //GridMain.Columns.Add("clnvno", "vno");
                        //GridMain.Columns.Add("clnparty", "Customer Name");
                        //GridMain.Columns.Add("clnBillamt", "AMT");
                        //GridMain.Columns.Add("ClnSR", "Sales Return");
                        //GridMain.Columns.Add("clnR", "Paid");
                        //GridMain.Columns.Add("clnBamt", "Balance");
                        //GridMain.Columns.Add("ClnPercColl", "Collection %");

                        if (DsPurchase.Tables[0].Rows.Count > 0)
                        {
                            int Count2 = GridMain.Rows.Add(1);
                            GridMain.Rows[Count2].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                            GridMain.Rows[Count2].DefaultCellStyle.BackColor = System.Drawing.Color.DarkMagenta;

                            GridMain.Rows[Count].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("LName", LedCode);
                            GridMain.Rows[Count].Cells["clnparty"].Tag = LedCode;
                            // int Count2 = GridMain.Rows.Add(1);


                            GridMain.Rows[Count2].Cells["clnvno"].Value = "Opening Balance";
                            GridMain.Rows[Count2].Cells["clndate"].Value = CommonClass._GenLedger.getspecificfeild(LedCode, "vdate");

                            GridMain.Rows[Count2].Cells["clnBillamt"].Value = CommonClass._GenLedger.getopeningbalancesupplier(LedCode);
                            GridMain.Rows[Count2].Cells["clnBamt"].Value = CommonClass._GenLedger.getopeningbalancesupplier(LedCode);
                            OPbalance = CommonClass._GenLedger.getopeningbalancesupplier(LedCode);
                            Count = GridMain.Rows.Add(1);

                            GridMain.Rows[Count].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Cyan;

                            for (int i = 0; i < DsPurchase.Tables[0].Rows.Count; i++)
                            {
                                Vno = DsPurchase.Tables[0].Rows[i]["VNo"].ToString();
                                GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                                GridMain.Rows[Count].Cells["clndate"].Value = Convert.ToDateTime(CommonClass._PurchaseBillSett.GetSpecificField(Vno, "PI", "Date")).ToString("dd/MM/yyyy");

                                GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(CommonClass._PurchaseBillSett.GetSpecificField(Vno, "PI", "Cramt")));
                                TotalBillAmt = TotalBillAmt + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnBillamt"].Value);

                                GridMain.Rows[Count].Cells["clnP"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._PurchaseBillSett.GetTotalPaymentAgainstVno(Vno));
                                TotalR = TotalR + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnP"].Value);

                                GridMain.Rows[Count].Cells["ClnPR"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._PurchaseBillSett.GetTotalPurchaseReturnAgainstBii(Vno));
                                TotalSr = TotalSr + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["ClnPR"].Value);

                                GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._PurchaseBillSett.GetBillWiseBalence(Vno));
                                TotalBAmt = TotalBAmt + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnBamt"].Value);

                                GridMain.Rows[Count].Cells["ClnPendingDays"].Value = (DateTime.Now - Convert.ToDateTime(GridMain.Rows[Count].Cells["clndate"].Value)).Days;

                                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);

                                Count = GridMain.Rows.Add(1);
                            }


                            latesttotal = latesttotal + TotalBAmt + OPbalance;
                            //GridMain.Rows[Count].Cells["clnBillamt"].Value = "-------";
                            //GridMain.Rows[Count].Cells["clnR"].Value = "-------";
                            //GridMain.Rows[Count].Cells["ClnSR"].Value = "-------";
                            //GridMain.Rows[Count].Cells["clnBamt"].Value = "-------";
                            //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);
                            //Count = GridMain.Rows.Add(1);

                            GridMain.Rows[Count].Cells["ClnDate"].Value = "Total  :";
                            //GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(TotalBillAmt);
                            //GridMain.Rows[Count].Cells["clnP"].Value = _Dbtask.SetintoDecimalpoint(TotalR);
                            //GridMain.Rows[Count].Cells["ClnPR"].Value = _Dbtask.SetintoDecimalpoint(TotalSr);
                            GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(latesttotal);




                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                        }

                    }
                }



                if (ReportType == "Sales Bill Wise SettleMent")
                {
                    Ds = _Dbtask.ExecuteQuery("Select * from TblAccountLedger Where AGroupid = '18' " + Where + " Order By LName Asc");
                    for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                    {
                        double TotalBillAmt = 0;
                        double TotalSr = 0;
                        double TotalR = 0;
                        double TotalBAmt = 0;
                        double latesttotal = 0;


                        string LedCode = Ds.Tables[0].Rows[k]["Lid"].ToString();
                        string Vno = "";

                        //DataSet Dss = _Dbtask.ExecuteQuery("Select * from tblgeneralledger where ledcode='" + LedCode + "' and vtype ='ob'");
                        //if (Dss.Tables[0].Rows.Count > 0)
                        //{
                        //    int count1 = GridMain.Rows.Add(1);
                        //    for (int m = 0; m < Dss.Tables[0].Rows.Count; m++)
                        //    {

                        //        //GridMain.Rows.Add(1);
                        //        GridMain.Rows[count1].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("LName", LedCode);
                        //        GridMain.Rows[count1].Cells["clndate"].Value = Convert.ToDateTime(Dss.Tables[0].Rows[m]["vdate"]);
                        //        GridMain.Rows[count1].Cells["clnvno"].Value = "Opening balance";
                        //        OPbalance = _Dbtask.znlldoubletoobject(Dss.Tables[0].Rows[m]["Dbamt"]);

                        //        GridMain.Rows[count1].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Dss.Tables[0].Rows[m]["Dbamt"].ToString()));
                        //        GridMain.Rows[count1].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(Dss.Tables[0].Rows[m]["Dbamt"].ToString()));
                        //    }
                        //}
                        DataSet DsSales = CommonClass._Businessissue.GetCustomerWiseBillList(LedCode);


                        if (DsSales.Tables[0].Rows.Count > 0) //Filtering the Fully Settled Bill
                        {
                            for (int i = 0; i < DsSales.Tables[0].Rows.Count; i++)
                            {
                                Vno = DsSales.Tables[0].Rows[i]["VNo"].ToString();
                                if (CommonClass._BillSett.IsBillFullySettled(Vno) == true)
                                {
                                    DsSales.Tables[0].Rows.RemoveAt(i);
                                    i = i - 1;
                                }
                            }
                        }

                        //GridMain.Columns.Add("clndate", "Date");
                        //GridMain.Columns.Add("clnvno", "vno");
                        //GridMain.Columns.Add("clnparty", "Customer Name");
                        //GridMain.Columns.Add("clnBillamt", "AMT");
                        //GridMain.Columns.Add("ClnSR", "Sales Return");
                        //GridMain.Columns.Add("clnR", "Paid");
                        //GridMain.Columns.Add("clnBamt", "Balance");
                        //GridMain.Columns.Add("ClnPercColl", "Collection %");

                        if (DsSales.Tables[0].Rows.Count > 0)
                        {
                            int Count2 = GridMain.Rows.Add(1);
                            GridMain.Rows[Count2].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                            GridMain.Rows[Count2].DefaultCellStyle.BackColor = System.Drawing.Color.DarkMagenta;

                            GridMain.Rows[Count2].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("LName", LedCode);
                            GridMain.Rows[Count2].Cells["clnparty"].Tag = LedCode;

                            GridMain.Rows[Count2].Cells["clndate"].Value = "Opening Balance";
                            //GridMain.Rows[Count2].Cells["clndate"].Value = CommonClass._GenLedger.getspecificfeild(LedCode, "vdate");

                            GridMain.Rows[Count2].Cells["clnBillamt"].Value = CommonClass._GenLedger.getopeningbalance(LedCode);
                            GridMain.Rows[Count2].Cells["clnBamt"].Value = CommonClass._GenLedger.getopeningbalance(LedCode);
                            OPbalance = CommonClass._GenLedger.getopeningbalance(LedCode);

                            //GridMain.Rows[Count2].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);

                            Count = GridMain.Rows.Add(1);
                            
                            for (int i = 0; i < DsSales.Tables[0].Rows.Count; i++)
                            {
                                GridMain.Rows[Count].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;

                                Vno = DsSales.Tables[0].Rows[i]["VNo"].ToString();
                                GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                                GridMain.Rows[Count].Cells["clndate"].Value = Convert.ToDateTime(CommonClass._BillSett.GetSpecificField(Vno, "SI", "Dt")).ToString("dd/MM/yyyy");

                                GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(CommonClass._BillSett.GetSpecificField(Vno, "SI", "Cramt")));
                                // TotalBillAmt = TotalBillAmt + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnBillamt"].Value);

                                GridMain.Rows[Count].Cells["clnR"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._BillSett.GetTotalReceiptAgainstVno(Vno));
                                //TotalR = TotalR + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnR"].Value);

                                GridMain.Rows[Count].Cells["ClnSR"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._BillSett.GetTotalSalesReturnAgainstBii(Vno));
                                //TotalSr = TotalSr + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["ClnSR"].Value);

                                GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(CommonClass._BillSett.GetBillWiseBalence(Vno));
                                TotalBAmt = TotalBAmt + _Dbtask.znlldoubletoobject(GridMain.Rows[Count].Cells["clnBamt"].Value);


                                billadjst = CommonClass._BillSett.getbilladjustment(Vno, LedCode);

                                GridMain.Rows[Count].Cells["ClnBA"].Value = billadjst;

                                GridMain.Rows[Count].Cells["ClnPendingDays"].Value = (DateTime.Now - Convert.ToDateTime(GridMain.Rows[Count].Cells["clndate"].Value)).Days;


                                //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);


                               
                                //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);

                                Count = GridMain.Rows.Add(1);
                            }
                            //GridMain.Rows[Count].Cells["clnBillamt"].Value = "-------";
                            //GridMain.Rows[Count].Cells["clnR"].Value = "-------";
                            //GridMain.Rows[Count].Cells["ClnSR"].Value = "-------";
                            //GridMain.Rows[Count].Cells["clnBamt"].Value = "-------";
                            //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(214, 246, 214);
                            //Count = GridMain.Rows.Add(1);

                            GridMain.Rows[Count].Cells["ClnDate"].Value = "Total  :";
                            //GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(TotalBillAmt);
                            //GridMain.Rows[Count].Cells["clnR"].Value = _Dbtask.SetintoDecimalpoint(TotalR);
                            // GridMain.Rows[Count].Cells["ClnSR"].Value = _Dbtask.SetintoDecimalpoint(TotalSr);

                            latesttotal = latesttotal + TotalBAmt + OPbalance;

                            GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(latesttotal);
                            //GridMain.Rows[Count].Cells["ClnBA"].Value =_Dbtask.SetintoDecimalpoint( billadjst);
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                        }
                    }



                }


                if (ReportType == "OutstandingReportsummery")
                {
                    //int count;
                    double TTbalance = 0;
                    Ds = _Dbtask.ExecuteQueryAzureServer(QueryTemp);
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                        double Tempbalace = Convert.ToDouble(_Dbtask.ExecuteScalarAzureServer("select isnull (sum(dbamt-cramt),0) as amt from tblgeneralledger where ledcode='" + Ledid + "' and vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));

                        if (Tempbalace != 0)
                        {
                            int count2;
                            string PartyId = Ledid;
                            string PartyName = _Dbtask.ExecuteScalarAzureServer("select lname from tblaccountledger where lid='" + PartyId + "'");
                            count2 = GridMain.Rows.Add(1);
                            GridMain.Rows[count2].Cells["clnslno"].Value = count2 + 1;
                            GridMain.Rows[count2].Cells["clnledcode"].Value = PartyId;
                            //clnledcode
                            GridMain.Rows[count2].Cells["clnparty"].Value = PartyName;
                            GridMain.Rows[count2].Tag = Ledid;
                            GridMain.Rows[count2].Cells["clnmob"].Value = CommonClass._Ledger.GetspecifField("Mobile", Ledid).ToString();
                            GridMain.Rows[count2].Cells["clntax"].Value = CommonClass._Ledger.GetspecifField("Taxregno", Ledid).ToString();

                            GridMain.Rows[count2].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(Tempbalace);
                            TTbalance = TTbalance + Tempbalace;
                        }

                    }
                   
                    
                    
                   int count3 = GridMain.Rows.Add(1);
                    GridMain.Rows[count3].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TTbalance);
                    GridMain.Rows[count3].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[count3].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[count3].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }

                //if (ReportType == "Billwisesettlement")
                //{
                //    //int count;
                //    double TTbalance = 0;
                //    string Bvno;
                //    double Bamt=0;
                //    double BRecamt=0;

                //    double FinalBalance = 0;
                //    double TFinalBalance = 0;
                //    double KFinaBalance;
                //    Count = 0;
                //    Ds = _Dbtask.ExecuteQuery(QueryTemp + " order by lname asc");
                //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                //    {
                //        string Ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                //        if (CommonClass._BillSett.IsshowBill(Ledid,"",DTFrom,DTTo)>0)
                //        {
                //            Ds1 = CommonClass._BillSett.ShowBillsett(Ledid,"SI",DTFrom,DTTo);

                //            if (Count == 0)
                //            {
                //                Count = GridMain.Rows.Add(1);
                //            }
                //            string PartyName = CommonClass._Ledger.GetspecifField("lname", Ledid);

                            
                //                GridMain.Rows[Count].Cells["clnparty"].Value = PartyName;
                //                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                            
                //            KFinaBalance = 0;
                //            FinalBalance = 0;


                //            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                //            {
                //                Bvno = Ds1.Tables[0].Rows[k]["vno"].ToString();
                //                Bamt = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["cramt"]);
                //                DateTime Dt;
                //                Dt=_Dbtask.ZnullDatetime(Ds1.Tables[0].Rows[k]["dt"]);
                //                BRecamt = CommonClass._BillSett.IsshowBill(Ledid, Bvno,DTFrom,DTTo);
                //                if (Bamt>BRecamt)
                //                {
                //                    Count = GridMain.Rows.Add(1);
                //                    GridMain.Rows[Count].Cells["clndate"].Value = Dt.ToString("dd/MM/yyyy");

                //                    GridMain.Rows[Count].Cells["clnvno"].Value = Bvno;
                                   
                //                    KFinaBalance = Bamt - BRecamt;

                //                    GridMain.Rows[Count].Cells["clnBillamt"].Value = Bamt;

                //                    GridMain.Rows[Count].Cells["clnBamt"].Value = KFinaBalance;
                //                    FinalBalance = FinalBalance + KFinaBalance;

                                    

                //                    GridMain.Rows[Count].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(FinalBalance);

                //                   // if (k == Ds1.Tables[0].Rows.Count - 1)
                //                        //GridMain.Rows[Count].Cells["clnamount"].InheritedStyle.BackColor = System.Drawing.Color.Aqua;
                //                }
                //            }
                //            TFinalBalance = TFinalBalance + FinalBalance;
                //            Count = GridMain.Rows.Add(1);
                //            GridMain.Rows[Count].Cells["clnamount"].Value = "-----------------------";
                //        }
                //    }
                //    Count = GridMain.Rows.Add(1);
                //    GridMain.Rows[Count].Cells["clnamount"].Value = TFinalBalance;
                //    GridMain.Rows[Count].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                //    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                //    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                //}


                //if (ReportType == "Productionitemstatus")
                //{
                //    bool ConditionWorking;

                //    double TQty = 0;
                //    TAmount = 0;
                //    double TstockIssue = 0;
                //    double TstockReceved = 0;

                //    Ds = _Dbtask.ExecuteQuery(Query + "  issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by employee asc");
                //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                //    {
                //        int count;
                //        count = GridMain.Rows.Add(1);
                //        DateTime Dtissuedate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]);
                //        string vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                //        if (Employeeid != Ds.Tables[0].Rows[i]["employee"].ToString())
                //        {
                //            Employeeid = Ds.Tables[0].Rows[i]["employee"].ToString();
                //            string Employeename = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Employeeid + "'");

                //            GridMain.Rows[count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                //            double Empbalance =CommonClass._Ledger.Balanceofledger(Employeeid);
                //            GridMain.Rows[count].Cells["clnamtbalance"].Value = _Dbtask.SetintoDecimalpoint(Empbalance);
                //            GridMain.Rows[count].Cells["clnemployee"].Value = Employeename;

                //            Ds1 = _Dbtask.ExecuteQuery("select * from tblissueproductdetail where issueid='" + vno + "'");
                //            count = GridMain.Rows.Add(1);
                //            count = GridMain.Rows.Add(1);
                //            GridMain.Rows[count].Cells["clnemployee"].Value = "Item Name";
                //            GridMain.Rows[count].Cells["clnamtbalance"].Value = "Stock In hand";
                //            GridMain.Rows[count].Cells[2].Value = "Stock Issue";
                //            GridMain.Rows[count].Cells[3].Value = "Stock Receved";
                //            GridMain.Rows[count].Cells[4].Value = "Stock Value";

                //            string UVno = "";
                //            Ds1 = _Dbtask.ExecuteQuery("select vno from tblissueproduct where employee='" + Employeeid + "'");
                //            for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                //            {
                //                UVno = UVno + "," + Ds1.Tables[0].Rows[ii]["vno"].ToString();
                //            }
                //            if (UVno.Length > 0)
                //            {
                //                UVno = UVno.Substring(1, UVno.Length - 1);
                //            }
                //            Ds1 = _Dbtask.ExecuteQuery("select distinct item from tblissueproductdetail where issueid in (" + UVno + ")");
                //            for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                //            {
                //                count = GridMain.Rows.Add(1);
                //                string Itemid = Ds1.Tables[0].Rows[ii]["item"].ToString();
                //                string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                //                double Stockissue = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(qty),0) from tblissueproductdetail where issueid in(" + UVno + ") and item='" + Itemid + "'"));
                //                StockReceId = "";
                //                Ds2 = _Dbtask.ExecuteQuery("select id from tblreceivedproduct where issueid in(" + UVno + ")");
                //                StockRece = 0;
                //                for (int k = 0; k < Ds2.Tables[0].Rows.Count; k++)
                //                {
                //                    StockReceId = StockReceId + "," + Ds2.Tables[0].Rows[k]["id"].ToString();
                //                }
                //                if (StockReceId.Length > 0)
                //                {
                //                    StockReceId = StockReceId.Substring(1, StockReceId.Length - 1);
                //                    StockRece = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(qty),0) from tblreceivedproductdetail where item ='" + Itemid + "' and id in(" + StockReceId + ")")); ;
                //                }




                //                double Stockinhand = Stockissue - StockRece;

                //                double Rate = Convert.ToDouble(_Dbtask.ExecuteScalar("select prate from tblitemmaster where itemid='" + Itemid + "'"));
                //                double Amount = Stockinhand * Rate;
                //                TQty = TQty + Stockinhand;
                //                TstockIssue = TstockIssue + Stockissue;
                //                TstockReceved = TstockReceved + StockRece;
                //                TAmount = TAmount + Amount;
                //                GridMain.Rows[count].Cells[0].Value = Itemname;
                //                GridMain.Rows[count].Cells[1].Value = _Dbtask.SetintoDecimalpointStock(Stockinhand);
                //                GridMain.Rows[count].Cells[2].Value = _Dbtask.SetintoDecimalpointStock(Stockissue);
                //                GridMain.Rows[count].Cells[3].Value = _Dbtask.SetintoDecimalpointStock(StockRece);
                //                GridMain.Rows[count].Cells[4].Value = _Dbtask.SetintoDecimalpointStock(Amount);
                //                // GridMain.Rows[count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(Rate);
                //                // GridMain.Rows[count].Cells[3].Value = _Dbtask.SetintoDecimalpoint(Amount);
                //            }
                //            count = GridMain.Rows.Add(1);
                //            count = GridMain.Rows.Add(1);
                //            GridMain.Rows[count].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                //            GridMain.Rows[count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                //            GridMain.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                //            GridMain.Rows[count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TQty);
                //            GridMain.Rows[count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TstockIssue);
                //            GridMain.Rows[count].Cells[3].Value = _Dbtask.SetintoDecimalpoint(TstockReceved);
                //            GridMain.Rows[count].Cells[4].Value = _Dbtask.SetintoDecimalpoint(TAmount);
                //            TQty = 0;
                //            TstockIssue = 0;
                //            TstockReceved = 0;
                //            TAmount = 0;
                //        }
                //    }


                //}
                if (ReportType == "Billwisesettlement")
                {
                    //int count;
                    DateTime DueDate;
                    double TTbalance = 0;
                    string Bvno;
                    double Bamt = 0;
                    double BRecamt = 0;

                    double FinalBalance = 0;
                    double TFinalBalance = 0;
                    double KFinaBalance;
                    Count = 0;

                    double Tbill = 0;
                    double TRece = 0;
                    double Tbillpending = 0;


                    Ds = _Dbtask.ExecuteQuery(QueryTemp + " order by lname asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                        double Opbalance = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt-cramt),0) from tblgeneralledger where ledcode='" + Ledid + "' and vtype='OB'"));
                        double OpRec = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from tblbillsett where ledcode='" + Ledid + "' and dt between '" + DTFrom.ToString("MM/dd/yyyy 23:59:59") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and agvno=''"));
                        double OpBill = Opbalance - OpRec;
                        string PartyName = CommonClass._Ledger.GetspecifField("lname", Ledid);
                        FinalBalance = 0;
                        KFinaBalance = 0;
                        if (Ledid == "68")
                        {
                        }


                        if (Opbalance != 0)
                        {
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnparty"].Value = PartyName;
                            GridMain.Rows[Count].Cells["clnvno"].Value = "OS";
                            GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Opbalance));
                            GridMain.Rows[Count].Cells["clnr"].Value = OpRec;

                            GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(OpBill);
                            GridMain.Rows[Count].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(OpBill);


                            FinalBalance = FinalBalance + OpBill;

                            Tbill = Tbill + Convert.ToDouble(Opbalance);
                            TRece = TRece + OpRec;
                            Tbillpending = Tbillpending + OpBill;
                        }



                        if (CommonClass._BillSett.IsshowBill(Ledid, "", DTFrom, DTTo, SalesManin) != 0)
                        {
                            Ds1 = CommonClass._BillSett.ShowBillsett(Ledid, "SI", DTFrom, DTTo, SalesManin);

                            KFinaBalance = 0;



                            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                            {
                                Bvno = Ds1.Tables[0].Rows[k]["vno"].ToString();
                                Bamt = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["cramt"]);
                                DateTime Dt;
                                DateTime Dtt2;
                                Dt = _Dbtask.ZnullDatetime(Ds1.Tables[0].Rows[k]["dt"]);

                                BRecamt = CommonClass._BillSett.IsshowBill(Ledid, Bvno, DTFrom, DTTo, SalesManin);
                                Dtt2 = Dt;
                                DueDate = Dtt2.AddDays(Convert.ToInt16(_Dbtask.ExecuteScalar("select isnull(creditdays,0)  from tblbusinessissue where vno='" + Bvno + "' and issuetype='SI'")));


                                if (Bamt > BRecamt)
                                {
                                    if (ReportTypeSecond == "Duedates")
                                    {
                                        {
                                            if (DueDate <= DateTime.Now)
                                            {
                                                Count = GridMain.Rows.Add(1);
                                                GridMain.Rows[Count].Cells["clnparty"].Value = PartyName;
                                                GridMain.Rows[Count].Cells["clndate"].Value = Dt.ToString("dd/MM/yyyy");

                                                GridMain.Rows[Count].Cells["clnvno"].Value = Bvno;

                                                KFinaBalance = Bamt - BRecamt;

                                                GridMain.Rows[Count].Cells["clnr"].Value = _Dbtask.SetintoDecimalpoint(BRecamt);

                                                GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(Bamt);

                                                GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(KFinaBalance);
                                                FinalBalance = FinalBalance + KFinaBalance;

                                                GridMain.Rows[Count].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(FinalBalance);
                                                GridMain.Rows[Count].Cells["clndue"].Value = DueDate.ToString("dd/MM/yyyy");

                                                Tbill = Tbill + Bamt;
                                                TRece = TRece + BRecamt;
                                                Tbillpending = Tbillpending + KFinaBalance;
                                            }
                                        }

                                    }
                                    else
                                    {

                                        {
                                            Count = GridMain.Rows.Add(1);
                                            GridMain.Rows[Count].Cells["clnparty"].Value = PartyName;
                                            GridMain.Rows[Count].Cells["clndate"].Value = Dt.ToString("dd/MM/yyyy");

                                            GridMain.Rows[Count].Cells["clnvno"].Value = Bvno;

                                            KFinaBalance = Bamt - BRecamt;

                                            GridMain.Rows[Count].Cells["clnr"].Value = _Dbtask.SetintoDecimalpoint(BRecamt);

                                            GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(Bamt);

                                            GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(KFinaBalance);
                                            FinalBalance = FinalBalance + KFinaBalance;

                                            GridMain.Rows[Count].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(FinalBalance);
                                            GridMain.Rows[Count].Cells["clndue"].Value = DueDate.ToString("dd/MM/yyyy");

                                            Tbill = Tbill + Bamt;
                                            TRece = TRece + BRecamt;
                                            Tbillpending = Tbillpending + KFinaBalance;
                                        }
                                    }
                                }
                            }
                            //TFinalBalance = TFinalBalance + FinalBalance;
                            //Count = GridMain.Rows.Add(1);
                            //GridMain.Rows[Count].Cells["clnamount"].Value = "-----------------------";
                        }
                    }
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells["clnBillamt"].Value = _Dbtask.SetintoDecimalpoint(Tbill);

                    GridMain.Rows[Count].Cells["clnr"].Value = _Dbtask.SetintoDecimalpoint(TRece);

                    GridMain.Rows[Count].Cells["clnBamt"].Value = _Dbtask.SetintoDecimalpoint(Tbillpending);


                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnBillamt", 100);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnr", 100);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnBamt", 100);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 120);

                    GridMain.Rows[Count].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }

                if (ReportType == "Receivedreport")
                {
                    Ds = _Dbtask.ExecuteQuery(Query + " where recdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by id asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        int count = GridMain.Rows.Add(1);
                        DateTime Dtissuedate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["recdate"]);
                        string Issueid = Ds.Tables[0].Rows[i]["issueid"].ToString();
                        string vno = Ds.Tables[0].Rows[i]["id"].ToString();
                        string Itemid = Ds.Tables[0].Rows[i]["item"].ToString();
                        string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                        double Qty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());

                        GridMain.Rows[count].Cells["clndate"].Value = Dtissuedate.ToString("dd/MM/yyyy");
                        GridMain.Rows[count].Cells["clnvno"].Value = vno;
                        GridMain.Rows[count].Cells["clnitem"].Value = Itemname;
                        GridMain.Rows[count].Cells["clnqty"].Value = Qty;

                        Ds1 = _Dbtask.ExecuteQuery("select * from tblissueproduct where vno='" + Issueid + "'");
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            //count = GridMain.Rows.Add(1);
                            string Employeeid = Ds1.Tables[0].Rows[ii]["employee"].ToString();
                            string Employeename = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Employeeid + "'");
                            DateTime Issuedate = Convert.ToDateTime(Ds1.Tables[0].Rows[ii]["issuedate"]);

                            GridMain.Rows[count].Cells["clnissuedate"].Value = Issuedate.ToString("dd/MM/yyyy");
                            GridMain.Rows[count].Cells["clnemployee"].Value = Employeename;

                        }
                    }
                }
                if (ReportType == "Billwiseprofitstatement")
                    {
                    double NAmount = 0;
                    double NPurchaseAmount= 0;
                    double Nprofit = 0;
                    double NsrateAmt = 0;
                    double NprateAmt = 0;
                    double totbilldic = 0;
                    Ds = _Dbtask.ExecuteQuery(Query + " and issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by issuedate asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuedate = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]).ToString("dd/MM/yyyy");
                        string Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        string Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                        string billdisamt = Ds.Tables[0].Rows[i]["discamt"].ToString();
                        string Netamt = Ds.Tables[0].Rows[i]["amt"].ToString();
                        
                        string Party = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode ='" + Issuecode + "'");
                        double SrateAmt = 0;
                        double PrateAmt = 0;
                        NsrateAmt = 0;
                        NprateAmt = 0;
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            string Pcode = Ds1.Tables[0].Rows[ii]["pcode"].ToString();
                            string Bcode =_Dbtask.znllString(Ds1.Tables[0].Rows[ii]["batchid"]);
                            string Qty = Ds1.Tables[0].Rows[ii]["qty"].ToString();
                            string Srate = Ds1.Tables[0].Rows[ii]["rate"].ToString();
                            double stax = 0;
                            stax = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[ii]["taxrate"]);
                            
                            string Prate;
                            if (Bcode == "")
                            {
                                Prate = CommonClass._Itemmaster.SpecificField(Pcode,"crate");
                            }
                            else
                            {
                                Prate = CommonClass._Batch.GetSpecificFieldofBatchWithItemid(Bcode, "prate", Pcode);
                                Prate =_Dbtask.znllString( ((_Dbtask.znlldoubletoobject(Prate) * 15) / 100) + _Dbtask.znlldoubletoobject(Prate));
                            
                            }

                            if (CommonClass._Itemmaster.SpecificField(Pcode, "incs") == "1")
                            {
                                SrateAmt = _Dbtask.znullDouble(Srate) * _Dbtask.znullDouble(Qty);
                            }
                            else
                            {
                                SrateAmt = _Dbtask.znullDouble(Srate) * _Dbtask.znullDouble(Qty);
                                SrateAmt = SrateAmt + stax;

                            }
                            
                            
                            PrateAmt = _Dbtask.znullDouble(Prate) * _Dbtask.znullDouble(Qty);
                            if (SrateAmt < PrateAmt)
                            {

                            }
                            NsrateAmt = NsrateAmt + SrateAmt;
                            NprateAmt = NprateAmt + PrateAmt;
                            totbilldic = totbilldic + Convert.ToDouble(billdisamt);


                        }
                        GridMain.Rows.Add(1);
                        GridMain.Rows[i].Cells["clndate"].Value = Issuedate;
                        GridMain.Rows[i].Cells["clnvno"].Value = Vno;
                        GridMain.Rows[i].Cells["clnparty"].Value = Party;
                        GridMain.Rows[i].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Netamt));

                        GridMain.Rows[i].Cells["clnbilldisc"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(billdisamt));
                        GridMain.Rows[i].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(NprateAmt);
                        double temprofit = (NsrateAmt - Convert.ToDouble(billdisamt)) - NprateAmt;

                        GridMain.Rows[i].Cells["clnprofitperc"].Value = _Dbtask.SetintoDecimalpoint(100 * temprofit / Convert.ToDouble(NprateAmt));
                        GridMain.Rows[i].Cells["clnprofit"].Value = _Dbtask.SetintoDecimalpoint(temprofit);

                        NAmount = NAmount + Convert.ToDouble(Netamt);
                        NPurchaseAmount=NPurchaseAmount+NprateAmt;
                        Nprofit = Nprofit + temprofit;


                    }
                    GridMain.Rows.Add(1);
                    int Trowcount = GridMain.Rows.Count - 1;
                    GridMain.Rows[Trowcount].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(NAmount);
                    GridMain.Rows[Trowcount].Cells["clnbilldisc"].Value = _Dbtask.SetintoDecimalpoint(totbilldic);
                    GridMain.Rows[Trowcount].Cells["clnprate"].Value = _Dbtask.SetintoDecimalpoint(NPurchaseAmount);
                    GridMain.Rows[Trowcount].Cells["clnprofit"].Value = _Dbtask.SetintoDecimalpoint(Nprofit);
                    GridMain.Rows[Trowcount].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[Trowcount].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Trowcount].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                if (ReportType == "Salestaxdetail")
                {
                    double TTQty = 0;
                    double TTRate = 0;
                    double TTGross = 0;
                    double TTTaxamount = 0;
                    double TTAmount = 0;

                    double TQty = 0;
                    double TRate = 0;
                    double TGross = 0;
                    double TTaxamount = 0;
                    double TAmount = 0;
                    Ds1 = _Dbtask.ExecuteQuery(Query + " and issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' oredr by vno asc");

                    tempin = "";
                    for (int i = 0; i < Ds1.Tables[0].Rows.Count; i++)
                    {
                        tempin = tempin + Ds1.Tables[0].Rows[i]["issuecode"].ToString() + ",";
                    }
                    if (tempin.Length > 0)
                    {
                        tempin = tempin.Substring(0, tempin.Length - 1);
                    }

                    Ds = _Dbtask.ExecuteQuery("select * from tblissuedetails  " + QueryTemp + " " + QueryTemp2 + " order by taxper ");
                    int k = 0;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add(1);


                        if (Taxperc != Convert.ToDouble(Ds.Tables[0].Rows[i]["taxper"]))
                        {
                            if (k != 0)
                            {
                                //k = k + 1;

                                GridMain.Rows.Add(1);
                                GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(TQty);
                                // GridMain.Rows[k].Cells["clnrate"].Value =_Dbtask.SetintoDecimalpoint(TRate);
                                GridMain.Rows[k].Cells["clngross"].Value = _Dbtask.SetintoDecimalpoint(TGross);
                                GridMain.Rows[k].Cells["clntaxamount"].Value = _Dbtask.SetintoDecimalpoint(TTaxamount);
                                GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TAmount);
                                GridMain.Rows[k].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                                GridMain.Rows[k].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));

                                TTQty = TTQty + TQty;
                                TTRate = TTRate + TRate;
                                TTGross = TTGross + TGross;
                                TTTaxamount = TTTaxamount + TTTaxamount;
                                TTAmount = TTAmount + TAmount;

                                TQty = 0;
                                TRate = 0;
                                TGross = 0;
                                TTaxamount = 0;
                                TAmount = 0;

                                GridMain.Rows.Add(2);
                                k = k + 2;
                            }
                            Taxperc = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxper"]);
                            GridMain.Rows[k].Cells["clntaxperc"].Value = Taxperc;
                        }

                        double Qty = Convert.ToDouble(Ds.Tables[0].Rows[i]["qty"].ToString());
                        double Rate = Convert.ToDouble(Ds.Tables[0].Rows[i]["rate"].ToString());
                        double Taxrate = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxrate"]);
                        double TNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["netamt"]);
                        double GrossAmt = TNetAmt + Taxrate;

                        GridMain.Rows[k].Cells["clnitemname"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Ds.Tables[0].Rows[i]["pcode"] + "'");
                        GridMain.Rows[k].Cells["clnitemcode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Ds.Tables[0].Rows[i]["pcode"] + "'");

                        GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(Qty);
                        GridMain.Rows[k].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Rate);

                        GridMain.Rows[k].Cells["clngross"].Value = _Dbtask.SetintoDecimalpoint(GrossAmt);

                        GridMain.Rows[k].Cells["clntaxamount"].Value = _Dbtask.SetintoDecimalpoint(Taxrate);
                        GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TNetAmt);
                        k = k + 1;

                        TQty = TQty + Qty;
                        TRate = TRate + Rate;
                        TGross = TGross + GrossAmt;
                        TTaxamount = TTaxamount + Taxrate;
                        //       TTaxamount = TTaxamount + Taxrate;
                        TAmount = TAmount + TNetAmt;

                    }
                    if (k != 0)
                    {
                        // k = k + 1;
                        //GridMain.Rows.Add(2);


                        TTQty = TTQty + TQty;
                        TTRate = TTRate + TRate;
                        TTGross = TTGross + TGross;
                        TTTaxamount = TTTaxamount + TTaxamount;
                        TTAmount = TTAmount + TAmount;

                        GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(TQty);
                        // GridMain.Rows[k].Cells["clnrate"].Value =_Dbtask.SetintoDecimalpoint(TRate);
                        GridMain.Rows[k].Cells["clngross"].Value = _Dbtask.SetintoDecimalpoint(TGross);
                        GridMain.Rows[k].Cells["clntaxamount"].Value = _Dbtask.SetintoDecimalpoint(TTaxamount);
                        GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TAmount);
                        GridMain.Rows[k].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[k].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
                        // GridMain.Rows.Add(1);
                        // GridMain.Rows.Add(1);
                        // k = k + 1;
                    }
                    k = k + 2;
                    GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpointStock(TTQty);
                    // GridMain.Rows[k].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TTRate);
                    GridMain.Rows[k].Cells["clngross"].Value = _Dbtask.SetintoDecimalpoint(TTGross);
                    GridMain.Rows[k].Cells["clntaxamount"].Value = _Dbtask.SetintoDecimalpoint(TTTaxamount);
                    GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TTAmount);
                    GridMain.Rows[k].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    GridMain.Rows[k].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[k].DefaultCellStyle.BackColor = System.Drawing.Color.Red;


                }

                if (ReportType == "Purchasedaybooksumqty")
                {
                  Ds = _Dbtask.ExecuteQuery(Query + "    order by TblItemMaster.ItemName asc");
                 if (Ds.Tables[0].Rows.Count>0)
                  {
                     

                      Ds.Tables[0].Rows.Add();
                      Count = Ds.Tables[0].Rows.Count - 1;
                      DataTable table;
                      table = Ds.Tables[0];
                      object sumObject;

                      sumObject = table.Compute("Sum(Qty)", "");
                      Ds.Tables[0].Rows[Count]["Qty"] = _Dbtask.znlldoubletoobject(sumObject);

                     

                      GridMain.DataSource = Ds.Tables[0];
                      GridMain.Columns["itemname"].Width = 250;
                      CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                  }

                }

                if (ReportType == "Sales returnaybook" || ReportType == "Purchasedaybook")
                {
                    double TQty = 0;
                    double TRate = 0;
                    double TAmount = 0;
                    int k = 0;
                    string Vtype;
                        if(ReportType == "Sales returnaybook")
                        Vtype="SR";
                    else
                         Vtype="PI";

                    Ds = _Dbtask.ExecuteQuery(Query + "   and recptdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by cast(vno as float) asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuecode = Ds.Tables[0].Rows[i]["reptcode"].ToString();
                        string LedCode = Ds.Tables[0].Rows[i]["ledcodedr"].ToString();
                        string Party = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                        string strDate = (Convert.ToDateTime(Ds.Tables[0].Rows[i]["recptdate"].ToString())).ToString("dd-MM-yyyy");

                        Ds1 = _Dbtask.ExecuteQuery("select * from tblreceiptdetails where recptcode ='" + Issuecode + "' and ledcode='" + LedCode + "' " + QueryDetail + "");

                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            GridMain.Rows.Add(1);
                            string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Ds1.Tables[0].Rows[ii]["pcode"] + "'");
                            GridMain.Rows[k].Cells["clnitemname"].Value = Itemname;
                            string Unitid = Ds1.Tables[0].Rows[ii]["unitid"].ToString();
                            double Qty = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["qty"])*_Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount",Unitid));
                            double Rate = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["rate"]);
                            double Amount = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["netamt"]);

                            /*****/
                            GridMain.Rows[k].Cells["clnqty"].Tag = Issuecode;
                            GridMain.Rows[k].Cells["clnrate"].Tag = LedCode;
                            /*****/
                            GridMain.Rows[k].Cells["clndate"].Tag =strDate;
                            GridMain.Rows[k].Cells["clnvno"].Tag = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[k].Cells["clnparty"].Tag = Party;

                            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
                            {
                                GridMain.Rows[k].Cells["clnbcode"].Value = Ds1.Tables[0].Rows[ii]["batchid"];
                            }

                            if (k != 0)
                            {
                                string TagDate = GridMain.Rows[k - 1].Cells["clndate"].Tag.ToString();
                                string TagVno = GridMain.Rows[k - 1].Cells["clnvno"].Tag.ToString();
                                string Tagparty = GridMain.Rows[k - 1].Cells["clnparty"].Tag.ToString();
                                if (TagDate == strDate && TagVno != Ds.Tables[0].Rows[i]["vno"].ToString() && Tagparty != Party)
                                {
                                    GridMain.Rows[k].Cells["clndate"].Value = strDate;
                                    GridMain.Rows[k].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                                    GridMain.Rows[k].Cells["clnparty"].Value = Party;
                                }
                            }
                            else
                            {

                            }

                            GridMain.Rows[k].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["recptdate"];
                            GridMain.Rows[k].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[k].Cells["clnparty"].Value = Party;

                            GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(Qty);
                            GridMain.Rows[k].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Rate);
                            GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(Amount);

                            TQty = TQty + Qty;
                            TRate = TRate + Rate;
                            TAmount = TAmount + Amount;
                            k = k + 1;
                        }
                    }
                    GridMain.Rows.Add(1);
                    GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(TQty);
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(TRate);
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TAmount);
                }

                if (ReportType == "ReceiptandPayment")
                {
                    string Vtype;
                   
                    string RefNo;
                    /*For Receipt*/
                    Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode in (select lid from tblaccountledger where agroupid in "+
                        " ( select agroupid from tblaccountgroup where agroupid=25 or aunder=25))and dbamt !=0");
                    
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        Vtype = Ds.Tables[0].Rows[i]["vtype"].ToString();
                        Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                        RefNo = Ds.Tables[0].Rows[i]["RefNo"].ToString();

                        Ds1 = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vtype='" + Vtype + "' and vno='" + Vno + "'  and refNo='" + RefNo + "'");
                        for(int M=0;M<Ds1.Tables[0].Rows.Count;M++)
                        {
                         // string Ledger
                        }
                    }
                }

                if (ReportType == "SalesOther")
                {
                    double TPurchase = 0;
                    double TSales = 0;
                    double TBalance = 0;
                    double TDiscAmt = 0;
                   
                    Ds = _Dbtask.ExecuteQuery(Query);

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Pcode = Ds.Tables[0].Rows[i]["pcode"].ToString();
                        string ItemName = Ds.Tables[0].Rows[i]["itemname"].ToString();

                        double Purchase;
                        double Sales;
                        double Balance;
                        double DiscAmt;

                     

                       string WhereDate=" between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and  '"+DTTo.ToString("MM/dd/yyyy")+" 23:59:59'";

                        DiscAmt = CommonClass._IssueDetails.GetDiscAmt(
                        " HAVING (TblIssuedetails.Pcode = "+Pcode+") and tblbusinessissue.issuedate "+WhereDate+"");

                        if (Convert.ToDouble(DiscAmt) > 0)
                        {
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnitemname"].Value = ItemName;
                            GridMain.Rows[Count].Cells["clnDiscount"].Value = DiscAmt;
                            TDiscAmt = TDiscAmt + DiscAmt;

                           
                            Purchase= CommonClass._Inventory.SumofField("purchase", " where invdate "+
                            WhereDate +" and pcode="+Pcode+"" );
                            TPurchase = TPurchase + Purchase;

                            Sales = CommonClass._Inventory.SumofField("Sales", " where invdate " +
                            WhereDate + " and pcode=" + Pcode + "");
                            TSales = TSales + Sales;

                            Balance= CommonClass._Inventory.GetStock(" where invdate " + WhereDate + " and pcode=" + Pcode + "");
                            TBalance = TBalance + Balance;

                             GridMain.Rows[Count].Cells["clnpurchase"].Value =_Dbtask.SetintoDecimalpoint(Purchase);
                            GridMain.Rows[Count].Cells["clnsales"].Value=_Dbtask.SetintoDecimalpoint(Sales);
                            GridMain.Rows[Count].Cells["clnbalance"].Value =_Dbtask.SetintoDecimalpoint(Balance);
                        }
                    }
                    Count = GridMain.Rows.Add();
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    GridMain.Rows[Count].Cells["clndiscount"].Value = _Dbtask.SetintoDecimalpoint(TDiscAmt);
                    GridMain.Rows[Count].Cells["clnpurchase"].Value =_Dbtask.SetintoDecimalpoint(TPurchase);
                    GridMain.Rows[Count].Cells["clnsales"].Value =_Dbtask.SetintoDecimalpoint(TSales);
                    GridMain.Rows[Count].Cells["clnbalance"].Value =_Dbtask.SetintoDecimalpoint(TBalance);

                }

                if (ReportType == "Salesdaybook"||ReportType=="Purchasereturndaybook")
                {
                    GridMain.Rows.Clear();
                    double TQty = 0;
                    double Tfree = 0;
                    double TRate = 0;
                    double TAmount = 0;
                    int k = 0;
                    string Strissuedetails;
                    Strissuedetails="select issuecode from tblissuedetails where  ledcode='2' " + QueryDetail + " ";

                    Ds = _Dbtask.ExecuteQuery(Query + " and  issuedate between '" + DTFrom.ToString("MM/dd/yyyy hh:mm tt") + " ' and '" + DTTo.ToString("MM/dd/yyyy hh:mm tt") + " ' "+
                   " and issuecode in("+Strissuedetails+")"+
                    " order by cast(vno as float) asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                        string LedCode = Ds.Tables[0].Rows[i]["ledcodecr"].ToString();
                        string Party = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                        string strDate =Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"].ToString()).ToString("dd-MM-YYYY");
                       
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblissuedetails where issuecode ='" + Issuecode + "' and ledcode='" + LedCode + "' " + QueryDetail + " ");
                        
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            if (_Dbtask.znllString(Ds1.Tables[0].Rows[ii]["issuecode"]) == "173")
                            {
                            }
                            GridMain.Rows.Add(1);
                            string Itemname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Ds1.Tables[0].Rows[ii]["pcode"] + "'");
                            lblheading2.Text = Itemname;
                            if (CommonClass._Menusettings.GetMnustatus("103") == "1")
                            GridMain.Rows[k].Cells["clnbcode"].Value = Ds1.Tables[0].Rows[ii]["Batchid"].ToString();

                            //GridMain.Rows[k].Cells["clnitemname"].Value = Itemname;
                            string Unitid = Ds1.Tables[0].Rows[ii]["unitid"].ToString();
                            
                            double Qty = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["qty"]) * _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", Unitid));
                            double Free = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["freeqty"]) * _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", Unitid));

                            double Rate = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["rate"]);
                            double Amount = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["netamt"]);
                            Amount = Qty * Rate;
                            /*****/
                            GridMain.Rows[k].Cells["clnqty"].Tag =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["issuecode"]);
                            GridMain.Rows[k].Cells["clnrate"].Tag =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["ledcodecr"]);
                            /*****/
                            GridMain.Rows[k].Cells["clndate"].Tag = Ds.Tables[0].Rows[i]["issuedate"];
                            GridMain.Rows[k].Cells["clnvno"].Tag = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[k].Cells["clnparty"].Tag = Party;

                            if (k != 0)
                            {
                                string TagDate = GridMain.Rows[k - 1].Cells["clndate"].Tag.ToString();
                                string TagVno = GridMain.Rows[k - 1].Cells["clnvno"].Tag.ToString();
                                string Tagparty = GridMain.Rows[k - 1].Cells["clnparty"].Tag.ToString();
                                if (TagDate == Ds.Tables[0].Rows[i]["issuedate"].ToString() && TagVno != Ds.Tables[0].Rows[i]["vno"].ToString() && Tagparty != Party)
                                {
                                    GridMain.Rows[k].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["issuedate"];
                                    GridMain.Rows[k].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                                    GridMain.Rows[k].Cells["clnparty"].Value = Party;
                                }
                            }
                            else
                            {

                            }

                            GridMain.Rows[k].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["issuedate"];
                            GridMain.Rows[k].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[k].Cells["clnparty"].Value = Party;
                            GridMain.Rows[k].Cells["clnitemname"].Value = Itemname;

                            GridMain.Rows[k].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(Qty);
                            GridMain.Rows[k].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpoint(Free);
                            GridMain.Rows[k].Cells["clnrate"].Value = _Dbtask.SetintoDecimalpoint(Rate);
                            GridMain.Rows[k].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(Amount);

                            TQty = TQty + Qty;
                            Tfree = Tfree + Free;
                            TRate = TRate + Rate;
                            TAmount = TAmount + Amount;
                            k = k + 1;
                        }
                    }
                    GridMain.Rows.Add(1);
                    GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnqty"].Value = _Dbtask.SetintoDecimalpoint(TQty);
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnfree"].Value = _Dbtask.SetintoDecimalpoint(Tfree);

                    lblheading2.Tag = TAmount;
                    GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnamount"].Value = _Dbtask.SetintoDecimalpoint(TAmount);
                }

                if (ReportType == "Cashcadjet")
                {
                    double TopeningBalance = 0;

                    double TCredit = 0;
                    double TDebit = 0;

                    TopeningBalance =CommonClass._Gen.GetOpeningBalance("select * from tblgeneralledger where  vDate < '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "'", DTFrom);
                    GridMain.Rows.Clear();
                    int RowPos = GridMain.Rows.Add(1);
                    GridMain.Rows[RowPos].Cells["clnpurticularsDB"].Value = "Opening Balance";
                    GridMain.Rows[RowPos].Cells["clncramt"].Value = _Dbtask.SetintoDecimalpoint(TopeningBalance);
                    GridMain.Rows[RowPos].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                    TCredit = 0;
                    TDebit = 0;

                    Ds = _Dbtask.ExecuteQuery("select lid from tblaccountledger where agroupid=25");
                    string Gids = "";

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string temp = Ds.Tables[0].Rows[i]["lid"].ToString();
                        if (i != Ds.Tables[0].Rows.Count - 1)
                        {
                            Gids = Gids + "," + temp;
                        }
                        else
                        {
                            Gids = Gids + ","+ temp ;
                        }
                    }

                    if (Gids.Length > 0)
                    {
                        Gids = Gids.Substring(1,Gids.Length-1);
                        Ds = _Dbtask.ExecuteQuery(Query + "where ledcode in(" + Gids + ") and  vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' order by vDate asc");
                        k = 1;
                        double TSalesamt = 0;
                        double TPurchaseAmt = 0;
                        double TRceiptAmt = 0;
                        double TPayment = 0;
                        double TSalesReturnAmt = 0;
                        double TPurchasereturnAmt = 0;

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TSalesamt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SI' "));
                            TSalesReturnAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='SR' "));
                            TPurchaseAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='PI' "));
                            TPurchasereturnAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='PR' "));
                            TRceiptAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='R' "));
                            TPayment = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(cramt),0) from tblgeneralledger where ledcode in(" + Gids + ") and  VDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and vtype='P' "));
                            TSalesamt = TSalesamt - TSalesReturnAmt;
                            TPurchaseAmt = TPurchaseAmt - TPurchasereturnAmt;
                        }
                        GridMain.Rows.Add(3);

                        GridMain.Rows[1].Cells["clnpurticularsDB"].Value = "Sales";
                        GridMain.Rows[2].Cells["clnpurticularsDB"].Value = "Receipt";
                        GridMain.Rows[1].Cells["clnpurticularsCR"].Value = "Purchase";
                        GridMain.Rows[2].Cells["clnpurticularsCR"].Value = "Payment";


                        GridMain.Rows[1].Cells["clndbamt"].Value = _Dbtask.SetintoDecimalpoint(TSalesamt);
                        GridMain.Rows[2].Cells["clndbamt"].Value = _Dbtask.SetintoDecimalpoint(TRceiptAmt);
                        GridMain.Rows[1].Cells["clncramt"].Value = _Dbtask.SetintoDecimalpoint(TPurchaseAmt);
                        GridMain.Rows[2].Cells["clncramt"].Value = _Dbtask.SetintoDecimalpoint(TPayment);

                        double Tdbbalance = TSalesamt + TRceiptAmt;
                        double Tcrbalance = TPurchaseAmt + TPayment;

                        double BBalance = Tdbbalance - Tcrbalance;


                        GridMain.Rows[3].Cells["clnpurticularsDB"].Value = "Todays Balance";
                        GridMain.Rows[3].Cells["clndbamt"].Value = _Dbtask.SetintoDecimalpoint(BBalance);
                        GridMain.Rows[3].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                        GridMain.Rows[4].Cells["clnpurticularsDB"].Value = "Balance";
                        GridMain.Rows[4].Cells["clndbamt"].Value = _Dbtask.SetintoDecimalpoint(BBalance + TopeningBalance);
                        GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    }

                }
                if (ReportType == "Daybook")
                {
                    double TDebit = 0;
                    double TCredit = 0;
                    double TopeningBalance = 0;

                    /*For Opening Balance*/
                    if (ReportTypeSecond == "Summury")
                    {
                        string Vdate;
                        string Vno;
                        string Account;

                        double TSalesAmt = 0;
                        double TSalesReturn = 0;
                        double TPurchaseAmt = 0;
                        double TPurchaseReturn = 0;
                        double TPayment = 0;
                        double TReceipt = 0;
                        double TClosingBalance = 0;

                        TopeningBalance = CommonClass._Gen.GetOpeningBalance("select * from tblgeneralledger where  vDate < '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "'", DTFrom);
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnpurticulars"].Value = _Dbtask.SetintoDecimalpoint(TopeningBalance);


                        /*For Sales*/


                        Ds = _Dbtask.ExecuteQuery(" SELECT     ISNULL(SUM(TblGeneralLedger.DbAmt), 0) AS SalesAmt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='SI' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Sales";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["SalesAmt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);

                            TSalesAmt = TSalesAmt + Amt;
                        }


                        /*For Purchase Return*/


                        Ds = _Dbtask.ExecuteQuery(" SELECT     ISNULL(SUM(TblGeneralLedger.DbAmt), 0) AS SalesAmt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='PR' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Purchase Return";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["SalesAmt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);

                            TPurchaseReturn = TPurchaseReturn + Amt;
                        }


                        /*For Purchase*/


                        Ds = _Dbtask.ExecuteQuery(" SELECT     ISNULL(SUM(TblGeneralLedger.Cramt), 0) AS SalesAmt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='PI' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Purchase";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["SalesAmt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);
                            TPurchaseAmt = TPurchaseAmt + Amt;
                        }


                        /*For Sale Return*/


                        Ds = _Dbtask.ExecuteQuery(" SELECT     ISNULL(SUM(TblGeneralLedger.Cramt), 0) AS SalesAmt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='SR' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Sales Return";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["SalesAmt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);
                            TSalesReturn = TSalesReturn + Amt;
                        }

                        /*For Receipt*/

                        Ds = _Dbtask.ExecuteQuery("  SELECT     ISNULL(SUM(TblGeneralLedger.Dbamt), 0) AS Amt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='R' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Receipt";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["Amt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);
                            TReceipt = TReceipt + Amt;
                        }


                        /*For Payment*/

                        Ds = _Dbtask.ExecuteQuery("  SELECT     ISNULL(SUM(TblGeneralLedger.Cramt), 0) AS Amt,TblGeneralLedger.vno as vno" +
                                " FROM         TblAccountLedger INNER JOIN" +
                                " TblGeneralLedger ON TblAccountLedger.Lid = TblGeneralLedger.LedCode " +
                                " WHERE     (TblAccountLedger.AGroupId IN (25)) and TblGeneralLedger.vtype='P' " +
                                " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' " +
                                " group by tblgeneralledger.vno");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                            Account = "Payment";
                            double Amt = Convert.ToDouble(Ds.Tables[0].Rows[i]["Amt"]);
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Account;
                            GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(Amt);

                            TPayment = TPayment + Amt;
                        }
                        Count = GridMain.Rows.Add(1);
                        TDebit = TSalesAmt + TReceipt + TPurchaseReturn;
                        TCredit = TPurchaseAmt + TPayment + TSalesReturn;
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        Account = "Closing Balance";
                        GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Todays Balance";
                        double TodaysBalance = TDebit - TCredit;
                        double ClosingBalance = TopeningBalance + TodaysBalance;
                        GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(TodaysBalance);
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Closing Balance";
                        GridMain.Rows[Count].Cells["clnamt"].Value = _Dbtask.SetintoDecimalpoint(ClosingBalance);

                    }
                    else if (ReportTypeSecond == "Detail")
                    {
                        int k = 0;
                        double DayClosing = 0;
                        double SumDbAmt = 0;
                        double SumCrAmt = 0;
                        DateTime VDate;
                        GridMain.Rows.Clear();
                        int RowPos = GridMain.Rows.Add(1);
                        GridMain.Rows[RowPos].Cells["clnpurticulars"].Value = "Opening Balance";
                        string Estled;
                        Estled=CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate","lid");

                        if (Generalfunction.BlShowEst == true)
                        {
                            TopeningBalance = CommonClass._Gen.GetOpeningBalance(Query + "where  vDate < '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "'", DTFrom);
                        }
                        else
                        {
                            TopeningBalance = CommonClass._Gen.GetOpeningBalance(Query + "where  vDate < '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and refno !='" + Estled + "'", DTFrom);
                        }

                        GridMain.Rows[RowPos].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TopeningBalance);
                        GridMain.Rows[RowPos].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                        TCredit = 0;
                        TDebit = 0;
                        DayClosing = TopeningBalance;
                        // double tempDbamt=
                        if (Generalfunction.BlShowEst == true)
                        {
                            Ds = _Dbtask.ExecuteQuery(Query + "where  vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' order by vDate asc");
                        }
                        else
                        {
                            Ds = _Dbtask.ExecuteQuery(Query + "where  vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'  order by vDate asc");
                        }

                        k = 1;
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {

                            /*21 =Sales Groupid*/
                            /*26 =Purchase*/
                            /*24 =Bank*/
                            /*25 =Cash*/

                            /*For DayBook Total*/
                            if (RVDate != Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["vdate"]).ToString("dd/MM/yyyy")) && i != 0)
                            {
                                CommonClass._Clreport.ForDayBookDetailTotal(GridMain, RowPos, SumDbAmt, SumCrAmt, DayClosing);
                                DayClosing = CommonClass.DBtemp;
                                SumDbAmt = 0;
                                SumCrAmt = 0;
                            }
                            RVDate = Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["vdate"]).ToString("dd/MM/yyyy"));
                            /// string Gid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");
                            string Lid = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                            //if (VDate != Convert.ToDateTime(Ds.Tables[0].Rows[i]["vdate"]))
                            //{

                            ////}
                            string Vtype = Ds.Tables[0].Rows[i]["vtype"].ToString();
                            if (Vtype == "PI" || Vtype == "SI" || Vtype == "DN" || Vtype == "DNR" || Vtype == "SR" || Vtype == "PR")
                            {
                                double Debit = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]);
                                double Credit = Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                                double daybalnce1 = 0;
                                if (Lid != "1")
                                {

                                    TDebit = TDebit + Debit;
                                    TCredit = TCredit + Credit;

                                    SumCrAmt = SumCrAmt + Debit;
                                    SumDbAmt = SumDbAmt + Credit;
                                    daybalnce1 = SumDbAmt - SumCrAmt;
                                    RowPos = GridMain.Rows.Add(1); //GridMain.Rows.Add(1);
                                    GridMain.Rows[RowPos].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["vdate"];
                                    GridMain.Rows[RowPos].Cells["clnpurticulars"].Value = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");
                                    GridMain.Rows[RowPos].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds.Tables[0].Rows[i]["vtype"].ToString());
                                    string Vtype1 = Ds.Tables[0].Rows[i]["vtype"].ToString();
                                    if (Vtype1 == "PI" || Vtype1 == "SR" || Vtype1 == "PO")
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvtype"].Tag = _Dbtask.ExecuteScalar("select LedcodeDr from TblTransactionReceipt where RecptType='" + Vtype1 + "'");
                                    }
                                    else if (Vtype1 == "SI" || Vtype1 == "PR" || Vtype1 == "SO" || Vtype1 == "SE")
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvtype"].Tag = _Dbtask.ExecuteScalar("select LedcodeCr from TblBusinessIssue where IssueType='" + Vtype1 + "'");
                                    }
                                    else
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvtype"].Tag = 0;
                                    }
                                    string vno = Ds.Tables[0].Rows[i]["vno"].ToString();
                                    GridMain.Rows[RowPos].Cells["clnvno"].Value = vno;

                                    if (Vtype1 == "PI" || Vtype1 == "SR" || Vtype1 == "PO")
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvno"].Tag = _Dbtask.ExecuteScalar("select ReptCode from TblTransactionReceipt where VNo='" + vno + "'");
                                    }
                                    else if (Vtype1 == "SI" || Vtype1 == "PR" || Vtype1 == "SO" || Vtype1 == "SE")
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvno"].Tag = _Dbtask.ExecuteScalar("select IssueCode from TblBusinessIssue where VNo='" + vno + "'");
                                    }
                                    else
                                    {
                                        GridMain.Rows[RowPos].Cells["clnvno"].Tag = 0;
                                    }
                                    GridMain.Rows[RowPos].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(Credit);
                                    GridMain.Rows[RowPos].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(Debit);
                                    GridMain.Rows[RowPos].Cells["clnnaration"].Value = Ds.Tables[0].Rows[i]["naration"];
                                    GridMain.Rows[RowPos].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(daybalnce1);
                                    
                                    
                                    k = k + 1;
                                }
                            }
                            if (Vtype == "P" || Vtype == "R" || Vtype == "DBN" || Vtype == "CRN"||Vtype=="JNR"||Vtype=="JNP"||Vtype=="CNR")
                            {
                                if (Lid != "1")
                                {
                                    double daybalnce = 0;
                                    double Debit = Convert.ToDouble(Ds.Tables[0].Rows[i]["cramt"]);
                                    double Credit = Convert.ToDouble(Ds.Tables[0].Rows[i]["dbamt"]);
                                    TDebit = TDebit + Credit;
                                    TCredit = TCredit + Debit;

                                    SumCrAmt = SumCrAmt + Credit;
                                    SumDbAmt = SumDbAmt + Debit;

                                    daybalnce = SumDbAmt - SumCrAmt;

                                    RowPos = GridMain.Rows.Add(1);
                                    GridMain.Rows[RowPos].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["vdate"];
                                    GridMain.Rows[RowPos].Cells["clnpurticulars"].Value = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcode"] + "'");
                                    GridMain.Rows[RowPos].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds.Tables[0].Rows[i]["vtype"].ToString());
                                    GridMain.Rows[RowPos].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                                    GridMain.Rows[RowPos].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(Debit);
                                    GridMain.Rows[RowPos].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(Credit);
                                    GridMain.Rows[RowPos].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(daybalnce);
                                    
                                    GridMain.Rows[RowPos].Cells["clnnaration"].Value = Ds.Tables[0].Rows[i]["naration"];
                                    k = k + 1;
                                }

                            }
                         
                            // string Vtype = Ds.Tables[0].Rows[i]["vtype"].ToString();
                            if (GridMain.Rows[RowPos].Cells["clndate"].Value != null)
                            {
                                VDate = Convert.ToDateTime(GridMain.Rows[RowPos].Cells["clndate"].Value);
                                VDate = Convert.ToDateTime(VDate.ToString("dd/MM/yyyy"));
                            }
                        }

                        Ds = _Dbtask.ExecuteQuery("select * from TblBusinessIssue where  IssueDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and IssueType='SO' order by IssueDate asc");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            if (RVDate != Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["IssueDate"]).ToString("dd/MM/yyyy")) && i != 0)
                            {
                                CommonClass._Clreport.ForDayBookDetailTotal(GridMain, RowPos, SumDbAmt, SumCrAmt, DayClosing);
                                DayClosing = CommonClass.DBtemp;
                                SumDbAmt = 0;
                                SumCrAmt = 0;
                            }
                            RVDate = Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["IssueDate"]).ToString("dd/MM/yyyy"));
                            string Lid = Ds.Tables[0].Rows[i]["LedcodeCr"].ToString();
                            string Vtype = Ds.Tables[0].Rows[i]["IssueType"].ToString();

                            if (Lid != "1")
                            {
                                RowPos = GridMain.Rows.Add(1); //GridMain.Rows.Add(1);
                                GridMain.Rows[RowPos].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["IssueDate"];
                                GridMain.Rows[RowPos].Cells["clnpurticulars"].Value = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["LedcodeCr"] + "'");
                                GridMain.Rows[RowPos].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds.Tables[0].Rows[i]["IssueType"].ToString());
                                string Vtype1 = Ds.Tables[0].Rows[i]["IssueType"].ToString();
                                GridMain.Rows[RowPos].Cells["clnvtype"].Tag = _Dbtask.ExecuteScalar("select LedcodeCr from TblBusinessIssue where IssueType='" + Vtype1 + "'");
                                string vno = Ds.Tables[0].Rows[i]["VNo"].ToString();
                                GridMain.Rows[RowPos].Cells["clnvno"].Value = vno;
                                GridMain.Rows[RowPos].Cells["clnvno"].Tag = _Dbtask.ExecuteScalar("select IssueCode from TblBusinessIssue where VNo='" + vno + "'");
                                k = k + 1;
                            }
                        }
                        Ds = _Dbtask.ExecuteQuery("select * from TblTransactionReceipt where  RecptDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and RecptType='PO' order by RecptDate asc ");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            if (RVDate != Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["RecptDate"]).ToString("dd/MM/yyyy")) && i != 0)
                            {
                                CommonClass._Clreport.ForDayBookDetailTotal(GridMain, RowPos, SumDbAmt, SumCrAmt, DayClosing);
                                DayClosing = CommonClass.DBtemp;
                                SumDbAmt = 0;
                                SumCrAmt = 0;
                            }
                            RVDate = Convert.ToDateTime(Convert.ToDateTime(Ds.Tables[0].Rows[i]["RecptDate"]).ToString("dd/MM/yyyy"));
                            string Lid = Ds.Tables[0].Rows[i]["LedcodeDr"].ToString();
                            string Vtype = Ds.Tables[0].Rows[i]["RecptType"].ToString();

                            string templedcode;

                            if (Lid != "1")
                            {
                                RowPos = GridMain.Rows.Add(1); //GridMain.Rows.Add(1);
                                GridMain.Rows[RowPos].Cells["clndate"].Value = Ds.Tables[0].Rows[i]["RecptDate"];
                                GridMain.Rows[RowPos].Cells["clnpurticulars"].Value = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["LedcodeDr"] + "'");
                                GridMain.Rows[RowPos].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds.Tables[0].Rows[i]["RecptType"].ToString());
                                string Vtype1 = Ds.Tables[0].Rows[i]["RecptType"].ToString();
                                GridMain.Rows[RowPos].Cells["clnvtype"].Tag = _Dbtask.ExecuteScalar("select LedcodeDr from TblTransactionReceipt where RecptType='" + Vtype1 + "'");
                                string vno = Ds.Tables[0].Rows[i]["VNo"].ToString();
                                GridMain.Rows[RowPos].Cells["clnvno"].Value = vno;
                                GridMain.Rows[RowPos].Cells["clnvno"].Tag = _Dbtask.ExecuteScalar("select ReptCode from TblTransactionReceipt where VNo='" + vno + "'");
                                k = k + 1;
                            }
                        }
                        CommonClass._Clreport.ForDayBookDetailTotal(GridMain, RowPos, SumDbAmt, SumCrAmt, DayClosing);
                        RowPos = GridMain.Rows.Add(1);
                        GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        TCredit = TCredit + TopeningBalance;
                        GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(TCredit - TDebit);
                    }
                }

                if (ReportType == "Salestaxsummery")
                {
                    double TTax = 0;
                    double TZerotaxable = 0;
                    double TOnetaxable = 0;
                    double TTwotaxable = 0;
                    double TFivetaxable = 0;
                    double TFortenntaxable = 0;
                    double TTwentytaxable = 0;
                    double TTaxable = 0;
                    double TTotalAmt = 0;

                    double TZerotax = 0;
                    double TOnetax = 0;
                    double TTwotax = 0;
                    double TFivetax = 0;
                    double TFortenntax = 0;
                    double TTwentytax = 0;

                    if (ReportType == "Salestaxsummery" && CommonClass.SRmode != "Mode3" && CommonClass.SRmode != "Mode4")
                    {
                        double TTTax = 0;
                        double TTaxamt = 0;
                        double Tnetamt = 0;
                        double TTaxableamt = 0;
                        double T1Pertax = 0;
                        double T2Pertax = 0;
                        double T5Pertax = 0;
                        double T15Pertax = 0;
                        double T20Pertax = 0;

                        double T0PertaxAmt = 0;
                        double T1PertaxAmt = 0;
                        double T2PertaxAmt = 0;
                        double T5PertaxAmt = 0;
                        double T15PertaxAmt = 0;
                        double T20PertaxAmt = 0;

                        double TT1Pertax = 0;
                        double TT2Pertax = 0;
                        double TT5Pertax = 0;
                        double TT15Pertax = 0;
                        double TT20Pertax = 0;
                        double TT0PertaxAmt = 0;
                        double TT1PertaxAmt = 0;
                        double TT2PertaxAmt = 0;
                        double TT5PertaxAmt = 0;
                        double TT15PertaxAmt = 0;
                        double TT20PertaxAmt = 0;


                        Ds = _Dbtask.ExecuteQuery(Query + " and  issuedate between '" + DTFrom.ToString("MM/dd/yyyy  hh:mm tt") + " ' and '" + DTTo.ToString("MM/dd/yyyy  hh:mm tt") + " ' order by cast(vno as float)");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Rows.Add(1);
                            CommonClass.Dttemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]);
                            Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                            Ledcode = Ds.Tables[0].Rows[i]["Ledcodecr"].ToString();
                            GridMain.Rows[i].Cells["clndate"].Value = CommonClass.Dttemp.ToString("dd/MM/yyyy");
                            GridMain.Rows[i].Cells["clnvno"].Value = _Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]) + _Dbtask.znllString(Ds.Tables[0].Rows[i]["pvno"]);

                            string TaxRegNo = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                            string TempName = Ds.Tables[0].Rows[i]["tename"].ToString();
                            if (TempName != "")
                            {
                                string Ledid = CommonClass._Ledger.ReturnLedid(TempName);

                                GridMain.Rows[i].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("lname", Ledid);
                                GridMain.Rows[i].Cells["clnaddress"].Value = CommonClass._Ledger.GetspecifField("address", Ledid);
                                GridMain.Rows[i].Cells["clntin"].Value = CommonClass._Ledger.GetspecifField("taxregno", Ledid);
                            }
                            double TempTaxamt = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxamt"]);
                            double TempAmt1 = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Amt"]);
                            double TempDiscTax = TempAmt1 * 5 / 100;
                            // TempTaxamt = TempTaxamt - TempDiscTax;
                            double TempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["amt"]);
                            double TempTaxableamt = TempNetAmt - TempTaxamt;

                            TTaxamt = TTaxamt + TempTaxamt;
                            TTaxableamt = TTaxableamt + TempTaxableamt;
                            Tnetamt = Tnetamt + TempNetAmt;
                            CommonClass.temp = CommonClass.Dttemp.ToString("dd/MM/yyyy");
                            if (_Dbtask.znllString(Ds.Tables[0].Rows[i]["vno"]) == "1180")
                            {
                            }
                            if (GridMain.Columns["cln15tax"].Visible == true)
                            {
                                T15Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=15  and vtype='SI' and issuecode='" + Issuecode + "'  "));
                                GridMain.Rows[i].Cells["cln15tax"].Value = _Dbtask.SetintoDecimalpointStock(T15Pertax);
                                TT15Pertax = TT15Pertax + T15Pertax;
                            }

                            if (GridMain.Columns["cln2tax"].Visible == true)
                            {
                                T2Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=2 and vtype='SI' and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln2tax"].Value = _Dbtask.SetintoDecimalpointStock(T2Pertax);
                                TT2Pertax = TT2Pertax + T2Pertax;
                            }

                            if (GridMain.Columns["cln5tax"].Visible == true)
                            {
                                T5Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=5 and vtype='SI' and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                //T5Pertax = TempDiscTax;
                                GridMain.Rows[i].Cells["cln5tax"].Value = _Dbtask.SetintoDecimalpointStock(T5Pertax);
                                TT5Pertax = TT5Pertax + T5Pertax;

                            }

                            if (GridMain.Columns["cln1tax"].Visible == true)
                            {
                                T1Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=1 and vtype='SI' and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln1tax"].Value = _Dbtask.SetintoDecimalpointStock(T1Pertax);
                                TT1Pertax = TT1Pertax + T1Pertax;
                            }

                            if (GridMain.Columns["cln20tax"].Visible == true)
                            {
                                T20Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=20 and vtype='SI' and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln20tax"].Value = _Dbtask.SetintoDecimalpointStock(T20Pertax);
                                TT20Pertax = TT20Pertax + T20Pertax;
                            }

                            TTax = T15Pertax + T5Pertax + T1Pertax + T20Pertax + T2Pertax;
                            GridMain.Rows[i].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpointStock(TTax);
                            if (GridMain.Columns["cln15taxableamt"].Visible == true)
                            {
                                T15PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=15 and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln15taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T15PertaxAmt);
                                TT15PertaxAmt = TT15PertaxAmt + T15PertaxAmt;

                            }

                            if (GridMain.Columns["cln5taxableamt"].Visible == true)
                            {
                                T5PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt),0) from tblissuedetails where taxper=5 and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));

                                T5PertaxAmt = T5PertaxAmt - _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["discamt"]);
                                T5PertaxAmt = T5PertaxAmt - T5Pertax;
                                GridMain.Rows[i].Cells["cln5taxableamt"].Value = T5PertaxAmt;
                                TT5PertaxAmt = TT5PertaxAmt + T5PertaxAmt;

                            }

                            if (GridMain.Columns["cln0taxableamt"].Visible == true)
                            {
                                T0PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=0 and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T0PertaxAmt);
                                TT0PertaxAmt = TT0PertaxAmt + T0PertaxAmt;

                            }

                            if (GridMain.Columns["cln1taxableamt"].Visible == true)
                            {
                                T1PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=1 and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T1PertaxAmt);
                                TT1PertaxAmt = TT1PertaxAmt + T1PertaxAmt;
                            }

                            if (GridMain.Columns["cln20taxableamt"].Visible == true)
                            {
                                T20PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=20 and issuecode='" + Issuecode + "' and ledcode='" + Ledcode + "' and vtype='SI'"));
                                GridMain.Rows[i].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T20PertaxAmt);
                                TT20PertaxAmt = TT20PertaxAmt + T20PertaxAmt;
                            }

                            //GridMain.Rows[i].Cells["clntaxamt"].Value = _Dbtask.SetintoDecimalpoint(TempTaxamt);
                            GridMain.Rows[i].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T0PertaxAmt);
                            GridMain.Rows[i].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T1PertaxAmt);
                            GridMain.Rows[i].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T2PertaxAmt);
                            GridMain.Rows[i].Cells["cln15taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T15PertaxAmt);
                            GridMain.Rows[i].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T5PertaxAmt);
                            GridMain.Rows[i].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(TempNetAmt);
                            GridMain.Rows[i].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(T20PertaxAmt);
                            // GridMain.Rows[i].Cells["clntaxableamt"].Value = _Dbtask.SetintoDecimalpoint(TempTaxableamt);

                            GridMain.Rows[i].Cells["clnttaxable"].Value = _Dbtask.SetintoDecimalpoint(T0PertaxAmt + T1PertaxAmt + T2PertaxAmt + T15PertaxAmt + T5PertaxAmt + T20PertaxAmt);
                            TTTax = TTTax + TTax;
                            TTaxable = TTaxable + T0PertaxAmt + T1PertaxAmt + T2PertaxAmt + T15PertaxAmt + T5PertaxAmt + T20PertaxAmt;
                        }


                        Count = GridMain.Rows.Add(1);
                        if (GridMain.Columns["cln15tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln15tax"].Value = _Dbtask.SetintoDecimalpoint(TT15Pertax);
                            GridMain.Rows[Count].Cells["cln15taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT5PertaxAmt);
                        }
                        if (GridMain.Columns["cln2tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln2tax"].Value = _Dbtask.SetintoDecimalpoint(TT2Pertax);
                            GridMain.Rows[Count].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT2PertaxAmt);
                        }
                        if (GridMain.Columns["cln5tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln5tax"].Value = _Dbtask.SetintoDecimalpoint(TT5Pertax);
                            GridMain.Rows[Count].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT15PertaxAmt);
                        }
                        if (GridMain.Columns["cln1tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln1tax"].Value = _Dbtask.SetintoDecimalpoint(TT1Pertax);
                            GridMain.Rows[Count].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT1PertaxAmt);
                        }
                        if (GridMain.Columns["cln20tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln20tax"].Value = _Dbtask.SetintoDecimalpoint(TT20Pertax);
                            GridMain.Rows[Count].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT20PertaxAmt);
                        }
                        //GridMain.Rows[GridMain.Rows.Count - 1].Cells["clntaxamt"].Value = _Dbtask.SetintoDecimalpoint(TTaxamt);
                        GridMain.Rows[Count].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpoint(TTTax);
                        GridMain.Rows[Count].Cells["cln15taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT15PertaxAmt);
                        GridMain.Rows[Count].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT5PertaxAmt);
                        GridMain.Rows[Count].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT0PertaxAmt);
                        GridMain.Rows[Count].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT1PertaxAmt);
                        GridMain.Rows[Count].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT2PertaxAmt);
                        GridMain.Rows[Count].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT20PertaxAmt);
                        GridMain.Rows[Count].Cells["clnttaxable"].Value = _Dbtask.SetintoDecimalpoint(TTaxable);
                        GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(Tnetamt);
                        GridMain.Rows[Count].Cells["clndate"].Tag ="EXB";
                        GridMain.Rows[Count].Cells["clndate"].Value= "TOTAL";

                        RowBoldFunction(Count);



                        Count = GridMain.Rows.Add(2);

                        //GridMain.Rows[Count].Cells[0].Value = "0% Tax";
                        //GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT0PertaxAmt);
                        //RowBoldFunction(Count);
                        //Count = GridMain.Rows.Add(1);


                        GridMain.Rows[Count].Cells[0].Value = "Total Gross";
                        GridMain.Rows[Count].Cells[0].Tag= "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TTaxable);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "1% Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT1Pertax);
                        RowBoldFunction(Count);
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "2% Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT2Pertax);
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "5% Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";

                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT5Pertax);
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "15% Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT15Pertax);
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "20% Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT20Pertax);
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "Tottal VAT";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        double TVat = TT15Pertax + TT1Pertax + TT5Pertax + TT20Pertax + TT2Pertax;
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TVat);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "Tottal Discount";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        string Wheredate;
                         Wheredate= "  issuedate between '" + dateTimePickerfrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + dateTimePickerto.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
                        double discc = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("  select sum(discamt) from tblbusinessissue where " + Wheredate + ""));
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(discc);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);


                        GridMain.Rows[Count].Cells[0].Value = "Grand Total";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(Tnetamt);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        double DiscTax;
                        DiscTax = discc *_Dbtask.znullDouble(_Dbtask.ExecuteScalar("select vat from tblitemmaster"))/100;
                        GridMain.Rows[Count].Cells[0].Value = "Discount Tax";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(DiscTax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "Nett Vat";
                        GridMain.Rows[Count].Cells[0].Tag = "EXB";
                        GridMain.Rows[Count].Cells[2].Tag = "EXB";
                        GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                        GridMain.Rows[Count].Cells[2].Value = TVat - DiscTax;
                        RowBoldFunction(Count);

                        if (CommonClass.SRmode == "Mode1")
                        {
                            string[] Passing = {  "cln1tax", "cln20tax", "cln2tax" };

                            CommonClass._Clreport.VisibleFalseColumns(Passing, GridMain);
                        }
                    }

                    if (CommonClass.SRmode == "Mode3")
                    {
                        Ds = _Dbtask.ExecuteQuery(Query +
                            " and issuedate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'" +
                            " and issuetype='SI' " +
                            " order BY CONVERT(VARCHAR(10),issuedate,120) asc ");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Rows.Add(1);
                            DtTemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["vdate"]);
                            TaxAmt = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["taxamt"]);
                            Issuecode = CommonClass._SelectReport.Showindataset("select issuecode from tblbusinessissue where  issuetype='SI' and issuedate between '" + DtTemp.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DtTemp.ToString("MM/dd/yyyy 23:59:59") + "'");
                            string Vno = CommonClass._SelectReport.ShowFirstandLast("select vno from tblbusinessissue where   issuetype='SI' and  issuecode in(" + Issuecode + ")" +
                               " order by cast(vno as float)");

                            TotalAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt),0) from tblissuedetails where   vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Zerotax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=0  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Onetax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=1  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Twotax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=2  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Fivetax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=5  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Fortenntax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=14.5  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Twentytax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails where taxper=20  and vtype='SI' and issuecode in (" + Issuecode + ")"));

                            double Zerotaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=0  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Onetaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=1  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Twotaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=2  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Fivetaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=5  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Fortenntaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=14.5  and vtype='SI' and issuecode in (" + Issuecode + ")"));
                            double Twentytaxable = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from tblissuedetails where taxper=20  and vtype='SI' and issuecode in (" + Issuecode + ")"));

                            TZerotax = TZerotax + Zerotax;
                            TOnetax = TOnetax + Onetax;
                            TTwotax = TTwotax + Twotax;
                            TFivetax = TFivetax + Fivetax;
                            TFortenntax = TFortenntax + Fortenntax;
                            TTwentytax = TTwentytax + Twentytax;

                            TotalAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt),0) from tblissuedetails where  vtype='SI' and issuecode in (" + Issuecode + ")"));

                            double TotalTax = Zerotax + Onetax + Fivetax + Fortenntax + Twentytax + Twotax;
                            TTax = TTax + TotalTax;
                            GridMain.Rows[i].Cells["clndate"].Value = DtTemp.ToString("dd/MM/yyyy");
                            GridMain.Rows[i].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[i].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpoint(TotalTax);

                            if (GridMain.Columns["cln0taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Zerotaxable);
                                TZerotaxable = TZerotaxable + Zerotaxable;
                            }

                            if (GridMain.Columns["cln1taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Onetaxable);
                                TOnetaxable = TOnetaxable + Onetaxable;
                            }

                            if (GridMain.Columns["cln2taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Twotaxable);
                                Twotaxable = Twotaxable + Twotaxable;
                            }

                            if (GridMain.Columns["cln5taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Fivetaxable);
                                TFivetaxable = TFivetaxable + Fivetaxable;
                            }

                            if (GridMain.Columns["cln14taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Fortenntaxable);
                                TFortenntaxable = TFortenntaxable + Fortenntaxable;
                            }

                            if (GridMain.Columns["cln20taxableamt"].Visible == true)
                            {
                                GridMain.Rows[i].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(Twentytaxable);
                                TTwentytaxable = TTwentytaxable + TTwentytaxable;
                            }

                            GridMain.Rows[i].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(TotalAmt);
                            TTotalAmt = TTotalAmt + TotalAmt;
                        }
                        /*For TotalCalculation*/
                        Count = GridMain.Rows.Add(1);
                        if (GridMain.Columns["cln0taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TZerotaxable);

                        if (GridMain.Columns["cln1taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TOnetaxable);

                        if (GridMain.Columns["cln2taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TTwotaxable);

                        if (GridMain.Columns["cln5taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TFivetaxable);


                        if (GridMain.Columns["cln14taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TFortenntaxable);

                        if (GridMain.Columns["cln20taxableamt"].Visible == true)
                            GridMain.Rows[Count].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TTwentytaxable);

                        GridMain.Rows[Count].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpoint(TTax);
                        GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(TTotalAmt);


                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells[0].Value = "1% Tax";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TOnetax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "2% Tax";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TTwotax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "5% Tax";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TFivetax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "14.5% Tax";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TFortenntax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "20% Tax";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TTwentytax);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "Total VAT";
                        double TVat = TOnetax + TTwotax + TFivetax + TFortenntax + TTwentytax;
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TVat);
                        RowBoldFunction(Count);
                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = "Grand Total";
                        GridMain.Rows[Count].Cells[1].Value = _Dbtask.SetintoDecimalpoint(TTotalAmt);
                        RowBoldFunction(Count);

                        GridMain.Columns["clnvno"].Width = 100;
                        if (CommonClass.SRmode == "Mode3")
                        {
                            string[] Passing = { "clnparty", "clnaddress", "clntin", "cln1tax", "cln2tax", "cln5tax", "cln14tax", "cln20tax" };

                            CommonClass._Clreport.VisibleFalseColumns(Passing, GridMain);
                        }
                        /*********************************************/
                    }

                }
                if (ReportType == "Salestaxsummery" &&CommonClass.SRmode == "Mode4")
                {
                    double STAmount=new double();
                    double STTax = new double();

                    string LedSales;
                    double TTax = 0;
                    double TTTax = 0;
                    double TTaxamt = 0;
                    double Tnetamt = 0;
                    double TTaxableamt = 0;
                    double T1Pertax = 0;
                    double T2Pertax = 0;
                    double T5Pertax = 0;
                    double T145Pertax = 0;
                    double T20Pertax = 0;

                    double T0PertaxAmt = 0;
                    double T1PertaxAmt = 0;
                    double T2PertaxAmt = 0;
                    double T5PertaxAmt = 0;
                    double T145PertaxAmt = 0;
                    double T20PertaxAmt = 0;

                    double TT1Pertax = 0;
                    double TT2Pertax = 0;
                    double TT5Pertax = 0;
                    double TT145Pertax = 0;
                    double TT20Pertax = 0;
                    double TT0PertaxAmt = 0;
                    double TT1PertaxAmt = 0;
                    double TT2PertaxAmt = 0;
                    double TT5PertaxAmt = 0;
                    double TT145PertaxAmt = 0;
                    double TT20PertaxAmt = 0;


                   /*WholeSale*/

                        tempin = CommonClass._Ledger.GetSpecificfieldBaseonName("wholesale","lid");
                        Ds = _Dbtask.ExecuteQuery(Query + "and ledcodecr='"+tempin+"' and   issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by cast(vno as float)");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {


                         Count=GridMain.Rows.Add(1);
                            CommonClass.Dttemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]);
                            Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                            Ledcode = Ds.Tables[0].Rows[i]["Ledcodecr"].ToString();

                            GridMain.Rows[Count].Cells["clndate"].Value = CommonClass.Dttemp.ToString("dd/MM/yyyy");
                            GridMain.Rows[Count].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"]+" A";

                            string TaxRegNo = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                            string TempName = Ds.Tables[0].Rows[i]["tename"].ToString();

                        
                            if (TempName != "")
                            {
                                string Ledid = CommonClass._Ledger.ReturnLedid(TempName);
                                GridMain.Rows[Count].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("lname", Ledid) + "," + CommonClass._Ledger.GetspecifField("taxregno", Ledid); 
                                
                            }
                            double TempTaxamt = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxamt"]);
                            double TempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["amt"]);
                            double TempTaxableamt = TempNetAmt - TempTaxamt;

                            TTaxamt = TTaxamt + TempTaxamt;
                            TTaxableamt = TTaxableamt + TempTaxableamt;
                            Tnetamt = Tnetamt + TempNetAmt;
                            CommonClass.temp = CommonClass.Dttemp.ToString("dd/MM/yyyy");

                            GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpointStock(TempNetAmt);
                            GridMain.Rows[Count].Cells["clnstax"].Value = _Dbtask.SetintoDecimalpointStock(TempTaxamt);
                            TTTax = TTTax + TTax;
                        }
                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clndate"].Value = "Total";
                        GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpointStock(Tnetamt);
                        GridMain.Rows[Count].Cells["clnstax"].Value = _Dbtask.SetintoDecimalpointStock(TTaxamt);
                        GridMain.Rows[Count].Cells["clnnetamt"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                        GridMain.Rows[Count].Cells["clnstax"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);

                    /*Sales*/
                        tempin = CommonClass._Ledger.GetSpecificfieldBaseonName("sales","lid");

                        Ds = _Dbtask.ExecuteQuery(Query + "and ledcodecr='" + tempin + "' and   issuedate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by cast(vno as float)");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                          Count=  GridMain.Rows.Add(1);
                            CommonClass.Dttemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["issuedate"]);
                            Issuecode = Ds.Tables[0].Rows[i]["issuecode"].ToString();
                            Ledcode = Ds.Tables[0].Rows[i]["Ledcodecr"].ToString();

                            GridMain.Rows[Count].Cells["clndate"].Value = CommonClass.Dttemp.ToString("dd/MM/yyyy");
                            GridMain.Rows[Count].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"]+" B";

                            string TaxRegNo = _Dbtask.ExecuteScalar("select taxregno from tblaccountledger where lid='" + Ds.Tables[0].Rows[i]["ledcodedr"] + "'");
                            string TempName = Ds.Tables[0].Rows[i]["tename"].ToString();


                            if (TempName != "")
                            {
                                string Ledid = CommonClass._Ledger.ReturnLedid(TempName);
                                GridMain.Rows[Count].Cells["clnparty"].Value = CommonClass._Ledger.GetspecifField("lname", Ledid) + "," + CommonClass._Ledger.GetspecifField("taxregno", Ledid);

                            }
                            double TempTaxamt = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxamt"]);
                            double TempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["amt"]);
                            double TempTaxableamt = TempNetAmt - TempTaxamt;


                            TTaxamt = TTaxamt + TempTaxamt;
                            TTaxableamt = TTaxableamt + TempTaxableamt;
                            Tnetamt = Tnetamt + TempNetAmt;
                            STAmount = STAmount + TempNetAmt;
                            STTax = STTax + TempTaxamt;
                            CommonClass.temp = CommonClass.Dttemp.ToString("dd/MM/yyyy");

                            GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpointStock(TempNetAmt);
                            GridMain.Rows[Count].Cells["clnstax"].Value = _Dbtask.SetintoDecimalpointStock(TempTaxamt);
                            TTTax = TTTax + TTax;
                        }

                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clndate"].Value = "Total";
                        GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpointStock(STAmount);
                        GridMain.Rows[Count].Cells["clnstax"].Value = _Dbtask.SetintoDecimalpointStock(STTax);
                        GridMain.Rows[Count].Cells["clnnetamt"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                        GridMain.Rows[Count].Cells["clnstax"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);

                        Count = GridMain.Rows.Add(2);
                        GridMain.Rows[Count].Cells["clndate"].Value = "Grand Total";
                        GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpointStock(Tnetamt);
                        GridMain.Rows[Count].Cells["clnstax"].Value = _Dbtask.SetintoDecimalpointStock(TTaxamt);
                        GridMain.Rows[Count].Cells["clnnetamt"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                        GridMain.Rows[Count].Cells["clnstax"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                    /**********************************************************/



                    /*1 Tax */


                    /**********************************************************/



                    /*2 Tax */


                    /**********************************************************/


                    /*5 Tax */


                    /**********************************************************/


                    /*14.5 Tax */


                    /**********************************************************/


                    /*20 Tax */


                    /**********************************************************/

                   
                }

               
              

                if (ReportType == "GroupReportSummury")
                {
                    Ds = CommonClass._Clreport.LedgerSummuryBaseOnGroup(Query + " and  tblgeneralledger.vDate between  '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "'");
                    DBTDebit = 0;
                    DBTCredit = 0;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        AccountID=Ds.Tables[0].Rows[i]["ledcode"].ToString();
                        StrPurticulars=CommonClass._Ledger.GetspecifField("lname",AccountID);
                        DbAmount =_Dbtask.znullDouble(Ds.Tables[0].Rows[i]["amount"].ToString());

                        if (DbAmount != 0)
                        {
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = StrPurticulars;
                            GridMain.Rows[Count].Tag = AccountID;

                            if (DbAmount > 0)
                            {
                                DbDebit = DbAmount;
                                DbCredit = 0;
                                GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(DbDebit);
                            }
                            else
                            {
                                DbCredit = CommonClass._commenevent.RemoveMInesinAmount(DbAmount);
                                DbDebit = 0;
                                GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(DbCredit);
                            }
                           
                            DBTDebit = DBTDebit + DbDebit;
                            DBTCredit = DBTCredit + DbCredit;
                        }
                    }
                    Count = GridMain.Rows.Add(1);
                    if (DBTDebit > DBTCredit)
                    {
                        GridMain.Rows[Count].Cells["clndebit"].Value = DBTDebit - DBTCredit;
                    }
                    else
                    {
                        GridMain.Rows[Count].Cells["clncredit"].Value = DBTCredit - DBTDebit;
                    }
                     CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                     GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Total";

                }

                if (ReportType == "AccountReport")
                                {
                    Ds = _Dbtask.ExecuteQueryAzureServer(QueryTemp);
                    string Ledid;
                    int Temprow = 0;
                    lblheading2.Text = Lbl2;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        //Count= GridMain.Rows.Add(1);
                        Count=  GridMain.Rows.Add(1);
                        Ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                        CUSCODE = Ledid;
                        partycode = Ledid;

                        GridMain.Rows[Count].Cells["clndate"].Value = "Ledger";


                         CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                        GridMain.Rows[Count].Cells["clnpurticulars"].Value = Ds.Tables[0].Rows[i]["lname"];

                        double ONLYdatewisamt= 0;
                        double Balance = 0;
                        double BalanceTemp = 0;
                        double BalanceInDate = 0;
                        string Opbalance = _Dbtask.ExecuteScalarAzureServer("select isnull(sum(dbamt-cramt),0) from tblgeneralledger where ledcode='" + Ledid + "' and vDate <'" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "'");
                        Balance = Convert.ToDouble(Opbalance);
                        //if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("226")) == "-1")
                        //{
                            BalanceInDate = Balance;
                        //}
                        //else
                        //{
                            BalanceInDate =BalanceInDate;
                        //}
                        Count= GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnpurticulars"].Value = "Opening Balance";
                        if (Balance > 0)
                        {
                            GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                        }
                        else
                        {
                            GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                        }
                        GridMain.Rows[Count].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                      // Query="select * from tblgeneralledger  where ledcode in ("+Ledid+")";
                        
                       
                        
                        
                        Ds1 = _Dbtask.ExecuteQueryAzureServer(Query + " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' order by vdate asc");
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                           Count= GridMain.Rows.Add(1);
                            Temprow = Temprow + 1;
                            GridMain.Rows[Count].Cells["clndate"].Value = Ds1.Tables[0].Rows[ii]["vdate"];

          
                              string Vtype = Ds1.Tables[0].Rows[ii]["vtype"].ToString();
                             Vno = Ds1.Tables[0].Rows[ii]["vno"].ToString();
                             string Purticulars = CommonClass._Ledger.GetspecifField("lname", _Dbtask.ExecuteScalar("select ledcode from tblgeneralledger where vno='" + Vno + "' and vtype='" + Vtype + "' and ledcode !=" + Ds1.Tables[0].Rows[ii]["ledcode"].ToString() + ""));
                            
                                Ds1.Tables[0].Rows[ii]["purticulars"].ToString();
                                string Note = "";
                                Note = _Dbtask.znllString(Ds1.Tables[0].Rows[ii]["naration2"]);

                            GridMain.Rows[Count].Cells["clndate"].Tag = Vno.ToString();
                          
                            string RefNo = Ds1.Tables[0].Rows[ii]["refno"].ToString();
                            string Naration = Ds1.Tables[0].Rows[ii]["naration"].ToString();
                            if (Vtype == "SI" || Vtype == "PR" || Vtype == "SO" || Vtype == "SV")
                            {
                                if (CommonClass._Paramlist.GetParamvalue("Sprefix") != "")
                                {
                                    ClickCode = _Dbtask.ExecuteScalarAzureServer("select issuecode from tblbusinessissue where vno='" + Vno.Replace(CommonClass._Paramlist.GetParamvalue("Sprefix"), "") + "' and ledcodecr='" + RefNo + "' and issuetype='" + Vtype + "'");

                                }
                                else
                                {
                                    ClickCode = _Dbtask.ExecuteScalarAzureServer("select issuecode from tblbusinessissue where vno='" + Vno + "' and ledcodecr='" + RefNo + "' and issuetype='" + Vtype + "'");

                                }

                            }
                            else if (Vtype == "PI" || Vtype == "SR" || Vtype == "PO")
                            {
                                ClickCode = _Dbtask.ExecuteScalarAzureServer("select reptcode from tbltransactionreceipt where vno='" + Vno + "' and ledcodeDr='" + RefNo + "' and recpttype='" + Vtype + "'");

                            }
                            //if (Vtype == "SI"||Vtype=="PR"||Vtype=="SO"||Vtype=="SV")
                            //{
                            //    ClickCode = _Dbtask.ExecuteScalar("select issuecode from tblbusinessissue where vno='" + Vno + "' and ledcodecr='" + RefNo + "' and issuetype='" + Vtype + "'");

                            //}
                            //else if (Vtype == "PI"||Vtype=="SR"||Vtype=="PO")
                            //{
                            //    ClickCode = _Dbtask.ExecuteScalar("select reptcode from tbltransactionreceipt where vno='" + Vno + "' and ledcodeDr='" + RefNo + "' and recpttype='" + Vtype + "'");

                            //}
                            string DUE = "";
                            if (Vtype == "SI" )
                            {
                                
                                DUE = _Dbtask.znllString( _Dbtask.ExecuteScalarAzureServer("SELECT due from tblbusinessissue where issuecode='" + Vno + "'"));
                            }

                            GridMain.Rows[Count].Cells["clndate"].Tag = ClickCode;
                            GridMain.Rows[Count].Cells["clndue"].Value = DUE;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Tag = RefNo;


                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Ds1.Tables[0].Rows[ii]["Uid"].ToString();
                                //Ds1.Tables[0].Rows[ii]["purticulars"] +"("+Purticulars+")";
                            GridMain.Rows[Count].Cells["clnnotes"].Value = Note;
                            GridMain.Rows[Count].Cells["clnvtype"].Value =CommonClass._Nextg.VtypeDescription(Ds1.Tables[0].Rows[ii]["vtype"].ToString());
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            GridMain.Rows[Count].Cells["clndebit"].Value = Ds1.Tables[0].Rows[ii]["Dbamt"];
                            GridMain.Rows[Count].Cells["clncredit"].Value = Ds1.Tables[0].Rows[ii]["Cramt"];
                            BalanceTemp = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Dbamt"]) - Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Cramt"]);
                            ONLYdatewisamt = ONLYdatewisamt + BalanceTemp;
                            BalanceInDate = BalanceInDate + BalanceTemp;
                           // Balance = Balance + BalanceTemp;
                            

                                GridMain.Rows[Count].Cells["clnbalance"].Value = BalanceInDate;
                            

                            if (Naration != "")
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = Naration;
                                GridMain.Rows[Count].Cells["clnvtype"].Value = CommonClass._Partyproject.GetspecifField("pname", Ds1.Tables[0].Rows[ii]["pproject"].ToString());
                                CommonClass._Clreport.CellItalicStyle(GridMain, "clnpurticulars", Count);
                            }
                           
                        }
                        Ds1 = _Dbtask.ExecuteQueryAzureServer("select * from Tblbusinessissue where LedcodeCr in (" + Ledid + ") and IssueDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and IssueType='SO' order by IssueDate asc");
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Temprow = Temprow + 1;
                            GridMain.Rows[Count].Cells["clndate"].Value = Ds1.Tables[0].Rows[ii]["IssueDate"];
                            string Purticulars = _Dbtask.ExecuteScalarAzureServer("select lname from tblaccountledger where lid='" + Ds1.Tables[0].Rows[i]["LedcodeCr"] + "'");
                            //string notess = "";
                            //notess = _Dbtask.znllString(Ds1.Tables[0].Rows[ii]["Narration2"]);
                            string Vtype = Ds1.Tables[0].Rows[ii]["IssueType"].ToString();
                            string RefNo = Ds1.Tables[0].Rows[ii]["LedcodeCr"].ToString();
                            string Naration = Ds1.Tables[0].Rows[ii]["Remarks"].ToString();
                            Vno = Ds1.Tables[0].Rows[ii]["VNo"].ToString();
                            ClickCode = _Dbtask.ExecuteScalarAzureServer("select issuecode from tblbusinessissue where vno='" + Vno + "' and ledcodecr='" + RefNo + "' and issuetype='" + Vtype + "'");

                            GridMain.Rows[Count].Cells["clndate"].Tag = ClickCode;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Tag = RefNo;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                         
                            GridMain.Rows[Count].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds1.Tables[0].Rows[ii]["IssueType"].ToString());
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            //GridMain.Rows[Count].Cells["clndebit"].Value = Ds1.Tables[0].Rows[ii]["Dbamt"];
                            //GridMain.Rows[Count].Cells["clncredit"].Value = Ds1.Tables[0].Rows[ii]["Cramt"];
                            //BalanceTemp = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Dbamt"]) - Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Cramt"]);
                            //BalanceInDate = BalanceInDate + BalanceTemp;
                            // Balance = Balance + BalanceTemp;
                            GridMain.Rows[Count].Cells["clnbalance"].Value = BalanceInDate;

                            if (Naration != "")
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = Naration;
                                CommonClass._Clreport.CellItalicStyle(GridMain, "clnpurticulars", Count);
                            }
                        }
                        Ds1 = _Dbtask.ExecuteQueryAzureServer("select * from TblTransactionReceipt where LedcodeDr in (" + Ledid + ") and RecptDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' and RecptType='PO' order by RecptDate asc");
                        for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                        {
                            Count = GridMain.Rows.Add(1);
                            Temprow = Temprow + 1;
                            GridMain.Rows[Count].Cells["clndate"].Value = Ds1.Tables[0].Rows[ii]["RecptDate"];
                            string Purticulars = _Dbtask.ExecuteScalarAzureServer("select lname from tblaccountledger where lid='" + Ds1.Tables[0].Rows[i]["LedcodeDr"] + "'");
                            string Vtype = Ds1.Tables[0].Rows[ii]["RecptType"].ToString();
                            string RefNo = Ds1.Tables[0].Rows[ii]["LedcodeDr"].ToString();
                            string Naration = Ds1.Tables[0].Rows[ii]["Remarks"].ToString();
                            Vno = Ds1.Tables[0].Rows[ii]["VNo"].ToString();
                            ClickCode = _Dbtask.ExecuteScalarAzureServer("select reptcode from tbltransactionreceipt where vno='" + Vno + "' and ledcodeDr='" + RefNo + "' and recpttype='" + Vtype + "'");
                            GridMain.Rows[Count].Cells["clndate"].Tag = ClickCode;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Tag = RefNo;
                            GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;

                            GridMain.Rows[Count].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Ds1.Tables[0].Rows[ii]["RecptType"].ToString());
                            GridMain.Rows[Count].Cells["clnvno"].Value = Vno;
                            //GridMain.Rows[Count].Cells["clndebit"].Value = Ds1.Tables[0].Rows[ii]["Dbamt"];
                            //GridMain.Rows[Count].Cells["clncredit"].Value = Ds1.Tables[0].Rows[ii]["Cramt"];
                            //BalanceTemp = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Dbamt"]) - Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Cramt"]);
                            //BalanceInDate = BalanceInDate + BalanceTemp;
                            // Balance = Balance + BalanceTemp;
                            GridMain.Rows[Count].Cells["clnbalance"].Value = BalanceInDate;
                            if (Naration != "")
                            {
                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnpurticulars"].Value = Naration;
                                CommonClass._Clreport.CellItalicStyle(GridMain, "clnpurticulars", Count);
                            }
                        }
                            //Count= GridMain.Rows.Add(1);
                            // Temprow = Temprow + 1;
                            Count = GridMain.Rows.Add(1);
                        //Temprow = Temprow + 1;

                        



                            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("226")) == "1")
                            {
                                GridMain.Rows[Count].Cells["clnDATE"].Value = "Date wise Balance";
                                GridMain.Rows[Count].Cells["clncredit"].Value = "Date wise Balance";
                                GridMain.Rows[Count].Cells["clnbalance"].Value = BalanceInDate - Balance; //ONLYdatewisamt; //BalanceInDate-Balance;
                                Balance = BalanceInDate;
                                string which = "";
                                if (Balance > 0)
                                {
                                    which = " ( Debit )";
                                }
                                else
                                {
                                    which = " ( Credit )";
                                }


                                Count = GridMain.Rows.Add(1);
                                GridMain.Rows[Count].Cells["clnDATE"].Value = "Balance";
                                GridMain.Rows[Count].Cells["clncredit"].Value = "Balance" + which;
                                GridMain.Rows[Count].Cells["clnbalance"].Value = Balance;

                                GridMain.Rows[Count].Cells["clncredit"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                                GridMain.Rows[Count].Cells["clnbalance"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                            }
                            else
                            {
                                //GridMain.Rows[Count].Cells["clncredit"].Value = "Date wise Balance";
                                //GridMain.Rows[Count].Cells["clnbalance"].Value = ONLYdatewisamt; //BalanceInDate-Balance;

                                string which = "";
                                Balance = BalanceInDate - _Dbtask.znlldoubletoobject(Opbalance);
                                Count = GridMain.Rows.Add(1);
                                
                                GridMain.Rows[Count].Cells["clnbalance"].Value = Balance +_Dbtask.znlldoubletoobject( Opbalance); ;


                                if ((Balance + _Dbtask.znlldoubletoobject(Opbalance)) > 0)
                                {
                                    which = " ( Debit )";
                                }
                                else
                                {
                                    which = " ( Credit )";
                                }
                                GridMain.Rows[Count].Cells["clncredit"].Value = "Balance" + which;

                                GridMain.Rows[Count].Cells["clncredit"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                                GridMain.Rows[Count].Cells["clnbalance"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                            }
                    
                    
                    }
                }

                if (ReportType == "OutstandingReport")
                {
                    Ds = _Dbtask.ExecuteQueryAzureServer(QueryTemp);
                    string Ledid;
                    int Temprow = 0;
                    long k = 0;
                    double NetBalance = 0;
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        Ledid = Ds.Tables[0].Rows[i]["lid"].ToString();
                        double Tempbalace = Convert.ToDouble(_Dbtask.ExecuteScalarAzureServer("select isnull (sum(dbamt-cramt),0) as amt from tblgeneralledger where ledcode='" + Ledid + "' and vdate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' "));

                        if (CommonClass._SelectReport.Reportselect(Tempbalace)==true)
                        {
                            GridMain.Rows.Add(1);
                            GridMain.Rows.Add(1);
                            k = k + 2;
                            Temprow = Temprow + 1;

                            GridMain.Rows[Temprow].Cells["clndate"].Value = "Ledger";
                            GridMain.Rows[Temprow].Cells["clndate"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                            GridMain.Rows[Temprow].Cells["clnpurticulars"].Value = Ds.Tables[0].Rows[i]["lname"];

                            double Balance = 0;
                            double BalanceTemp = 0;
                            double Days;
                            Ds1 = _Dbtask.ExecuteQueryAzureServer("select * from tblgeneralledger where   ledcode='" + Ledid + "'" + " and vDate between '" + DTFrom.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DTTo.ToString("MM/dd/yyyy 23:59:59") + "' order by vdate asc");
                            for (int ii = 0; ii < Ds1.Tables[0].Rows.Count; ii++)
                            {
                                DateTime Dtv = DateTime.Now;
                                DateTime DtFro = Convert.ToDateTime(Ds1.Tables[0].Rows[ii]["vdate"]);
                                Days = (Dtv - DtFro).TotalDays;
                                Temprow = GridMain.Rows.Add(1);
                                GridMain.Rows[Temprow].Cells["clndate"].Value = Ds1.Tables[0].Rows[ii]["vdate"];
                                GridMain.Rows[Temprow].Cells["clnpurticulars"].Value = Ds1.Tables[0].Rows[ii]["purticulars"];
                                GridMain.Rows[Temprow].Cells["clnvtype"].Value =CommonClass._Nextg.VtypeDescription(Ds1.Tables[0].Rows[ii]["vtype"].ToString());
                                GridMain.Rows[Temprow].Cells["clnvno"].Value = Ds1.Tables[0].Rows[ii]["vno"];
                                GridMain.Rows[Temprow].Cells["CLNDAYS"].Value = Days.ToString("0");
                                GridMain.Rows[Temprow].Cells["clndebit"].Value = Ds1.Tables[0].Rows[ii]["Dbamt"];
                                GridMain.Rows[Temprow].Cells["clncredit"].Value = Ds1.Tables[0].Rows[ii]["Cramt"];
                                BalanceTemp = Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Dbamt"]) - Convert.ToDouble(Ds1.Tables[0].Rows[ii]["Cramt"]);
                                Balance = Balance + BalanceTemp;
                                GridMain.Rows[Temprow].Cells["clnbalance"].Value = Balance;

                            }
                            GridMain.Rows.Add(1);
                            Temprow = Temprow + 1;
                            GridMain.Rows.Add(1);
                            Temprow = Temprow + 1;
                            GridMain.Rows[Temprow].Cells["clncredit"].Value = "Balance";
                            GridMain.Rows[Temprow].Cells["clnbalance"].Value = Balance;
                            
                            NetBalance = NetBalance + Balance;
                            GridMain.Rows[Temprow].Cells["clnbalance"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                        }
                    }
                    Temprow= GridMain.Rows.Add(1);
                    GridMain.Rows[Temprow].Cells["clncredit"].Value = "Net Balance";
                    GridMain.Rows[Temprow].Cells["clnbalance"].Value = NetBalance;
                    GridMain.Rows[Temprow].Cells["clnbalance"].Style.Font = new Font(GridMain.Font, FontStyle.Bold);
                }

                if (ReportType == "SalesDay")
                {
                    Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'","SI");

                    double TotAmt = 0;
                    double NetAmt = 0;
                    string TempDate;
                }

                if (ReportType == "SalesDay")
                {
                    Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'","SI");

                    double TotAmt=0;
                    double NetAmt=0;
                    string TempDate;
                  
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        
                    
                        TempDate=(Convert.ToDateTime(Ds.Tables[0].Rows[i]["Date"].ToString())).ToString("dd-MM-yyyy");
                        if (TempDate == CommonClass.temp || i == 0)
                        {
                            Count = GridMain.Rows.Add(2);
                            CommonClass.temp =(Convert.ToDateTime(Ds.Tables[0].Rows[i]["date"].ToString())).ToString("dd-MM-yyyy");
                            GridMain.Rows[Count].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[Count].Cells["clndate"].Value = CommonClass.temp;
                            GridMain.Rows[Count].Cells["clnparty"].Value = Ds.Tables[0].Rows[i]["party"];
                            GridMain.Rows[Count].Cells["clnqty"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"]);
                            GridMain.Rows[Count].Cells["clnfreeqty"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["freeqty"]);
                            GridMain.Rows[Count].Cells["clntaxamt"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["taxamt"]);
                            GridMain.Rows[Count].Cells["clnnetamount"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);
                            NetAmt = NetAmt + _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);
                            TotAmt = TotAmt + _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);
                        }
                        else
                        {
                           
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnnetamount"].Value = "-----------------------";

                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnnetamount"].Value = _Dbtask.SetintoDecimalpoint(NetAmt);
                            RowBoldFunction(Count);

                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnnetamount"].Value = "-----------------------";

                            NetAmt = 0;
                            Count = GridMain.Rows.Add(2);
                            CommonClass.temp = (Convert.ToDateTime(Ds.Tables[0].Rows[i]["date"].ToString())).ToString("dd-MM-yyyy");
                            GridMain.Rows[Count].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                            GridMain.Rows[Count].Cells["clndate"].Value = CommonClass.temp;
                            GridMain.Rows[Count].Cells["clnparty"].Value = Ds.Tables[0].Rows[i]["party"];
                            GridMain.Rows[Count].Cells["clnqty"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"]);
                            GridMain.Rows[Count].Cells["clnfreeqty"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["freeqty"]);
                            GridMain.Rows[Count].Cells["clntaxamt"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["taxamt"]);
                            GridMain.Rows[Count].Cells["clnnetamount"].Value =_Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);
                            
                            NetAmt = NetAmt + _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);
                            TotAmt = TotAmt + _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["netamount"]);

                        }
                    }
                   // TotAmt = TotAmt + NetAmt;
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnetamount"].Value = "-----------------------";
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnetamount"].Value = _Dbtask.SetintoDecimalpoint(NetAmt);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnetamount"].Value = "-----------------------";

                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnetamount"].Value = "=======================";
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnetamount"].Value = _Dbtask.SetintoDecimalpoint(TotAmt);
                }


                    if (ReportType == "Sales" ||ReportType == "Purchase Return" || ReportType == "Sales Order" || ReportType == "Sales Quatation"||ReportType=="Services")
                {

                    double Totamt = 0;

                    GridMain.Columns.Clear();

                        

                    if (ReportType == "Services")
                        Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'", "SV");
                    else if (ReportType == "Sales")
                        Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy hh:mm tt") + " ' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy hh:mm tt") +"'", "SI");
                    else if (ReportType == "Purchase Return")
                        Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'", "PR");
                    else if (ReportType == "Sales Order")
                        Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'", "SO");
                    else if (ReportType == "Sales Quatation")
                        Ds = CommonClass._ClSales.ShowSalesReport(Query + " and  tblbusinessissue.issuedate between'" + dateTimePickerfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + dateTimePickerto.Value.ToString("MM-dd-yyyy") + " 23:59:59'", "SQ");

                    Ds.Tables[0].Rows.Add();
                    Count = Ds.Tables[0].Rows.Count - 1;
                    DataTable table;
                    table = Ds.Tables[0];

                        
                    object sumObject;

                    sumObject = table.Compute("Sum(netamount)", "");
                    Ds.Tables[0].Rows[Count]["netamount"] =_Dbtask.znlldoubletoobject(sumObject);

                   // double sumnet = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(discount)", "");
                    Ds.Tables[0].Rows[Count]["discount"] = _Dbtask.znlldoubletoobject(sumObject);

                    //double sumdis =_Dbtask.znlldoubletoobject(sumObject);
                    //Totamt = sumnet + sumdis;  


                    sumObject = table.Compute("Sum(qty)", "");
                    Ds.Tables[0].Rows[Count]["qty"] = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(freeqty)", "");
                    Ds.Tables[0].Rows[Count]["freeqty"] = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(taxamt)", "");
                    Ds.Tables[0].Rows[Count]["taxamt"] = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(Amount)", "");
                    Ds.Tables[0].Rows[Count]["Amount"] = _Dbtask.SetintoDecimalpoint(  _Dbtask.znlldoubletoobject(sumObject));


                    if (ReportType == "Sales")
                    {
                        sumObject = table.Compute("Sum(cash)", "");
                        Ds.Tables[0].Rows[Count]["cash"] = _Dbtask.znlldoubletoobject(sumObject);
                    }
                    GridMain.DataSource = Ds.Tables[0];

                    GridMain.Columns["issuecode"].Visible = false;
                    GridMain.Columns["mainaccount"].Visible = false;
                    GridMain.Columns["cash"].Visible = false;

                    GridMain.Columns["vno"].Width = 50;
                    GridMain.Columns["date"].Width = 100;
                    GridMain.Columns["party"].Width = 300;
                    GridMain.Columns["date"].Width = 250;
                    

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "discount", 100);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "taxamt", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "qty", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "freeqty", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "netamount", 150);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "cash", 150);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "amount", 150);

                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                   // int countC = 0;
                   


                    //GridMain.Rows[countC].Cells["date"].Value = "TotalAMT";
                        //GridMain.Rows


                }

                if (ReportType == "Delivery")
                {
                    Ds =CommonClass._Businessissue.ShowBusinessIssue(" * "," where IssueType='DN' and IssueDate between '" + DTFrom.ToString("dd/MM/yyyy") + "' and '" + DTTo.ToString("dd/MM/yyyy") + "' " + QueryWhere + "");

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add();
                        DtTemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["IssueDate"]);
                        GridMain.Rows[i].Cells["Clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                        GridMain.Rows[i].Cells["ClnDate"].Value = DtTemp.ToString("dd/MM/yyyy");
                        GridMain.Rows[i].Cells["ClnDepot"].Value = CommonClass._Depot.NameDepot(Ds.Tables[0].Rows[i]["Dcode"].ToString());
                        GridMain.Rows[i].Cells["ClnParty"].Value = CommonClass._Ledger.NameAccountLedger(Ds.Tables[0].Rows[i]["LedcodeDr"].ToString());
                        string TQty = _Dbtask.ExecuteScalar("select sum(qty) from tblissuedetails where issuecode='" + Ds.Tables[0].Rows[i]["issuecode"] + "' and ledcode=''");
                        string TFree = _Dbtask.ExecuteScalar("select sum(freeqty) from tblissuedetails where issuecode='" + Ds.Tables[0].Rows[i]["issuecode"] + "' and ledcode=''");
                        GridMain.Rows[i].Cells["ClnQty"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(TQty));
                        //
                        GridMain.Rows[i].Cells["Clnfree"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(TFree));
                        GridMain.Rows[i].Cells["Clndiscount"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscAmt"]));
                        GridMain.Rows[i].Cells["ClnTax"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["TaxAmt"]));
                        GridMain.Rows[i].Cells["Clnnett"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["Amt"]));
                    }

                }

                if (ReportType == "Delivery NoteReturn")
                {
                    Ds =CommonClass._Businessissue.ShowBusinessIssue(" * ", " where IssueType='DNN' and IssueDate between '" + DTFrom.ToString("dd/MM/yyyy") + "' and '" + DTTo.ToString("dd/MM/yyyy") + "' " + QueryWhere + "");

                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add();
                        DtTemp = Convert.ToDateTime(Ds.Tables[0].Rows[i]["IssueDate"]);
                        GridMain.Rows[i].Cells["Clnvno"].Value = Ds.Tables[0].Rows[i]["vno"];
                        GridMain.Rows[i].Cells["ClnDate"].Value = DtTemp.ToString("dd/MM/yyyy");
                        GridMain.Rows[i].Cells["ClnDepot"].Value =CommonClass._Depot.NameDepot(Ds.Tables[0].Rows[i]["Dcode"].ToString());
                        GridMain.Rows[i].Cells["ClnParty"].Value = CommonClass._Ledger.NameAccountLedger(Ds.Tables[0].Rows[i]["LedcodeDr"].ToString());
                        string TQty = _Dbtask.ExecuteScalar("select sum(qty) from tblissuedetails where issuecode='" + Ds.Tables[0].Rows[i]["issuecode"] + "' and ledcode=''");
                        string TFree = _Dbtask.ExecuteScalar("select sum(freeqty) from tblissuedetails where issuecode='" + Ds.Tables[0].Rows[i]["issuecode"] + "' and ledcode=''");
                        GridMain.Rows[i].Cells["ClnQty"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(TQty));
                        //
                        GridMain.Rows[i].Cells["Clnfree"].Value = _Dbtask.SetintoDecimalpointStock(Convert.ToDouble(TFree));
                        GridMain.Rows[i].Cells["Clndiscount"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["DiscAmt"]));
                        GridMain.Rows[i].Cells["ClnTax"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["TaxAmt"]));
                        GridMain.Rows[i].Cells["Clnnett"].Value = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Ds.Tables[0].Rows[i]["Amt"]));
                    }

                }


                    if (ReportType == "Purchase" ||ReportType=="Purchase Order"|| ReportType == "Sales return")
                {
                    GridMain.Columns.Clear();

                    if (ReportType == "Purchase" || ReportType == "Purchase Order")
                    {
                        if (ReportType == "Purchase")
                            {
                                Ds = CommonClass._ClPurchase.ShowpurchaseReport(Query + " and TR.recptdate between'" + dateTimePickerfrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + " ' and '" + dateTimePickerto.Value.ToString("MM/dd/yyyy  hh:mm tt") + " '" +
                            " AND (rd.vtype = 'PI') ");
                        }
                        else
                        {
                            Ds = CommonClass._ClPurchase.ShowpurchaseReport(Query + " and TR.recptdate between'" + dateTimePickerfrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + " ' and '" + dateTimePickerto.Value.ToString("MM/dd/yyyy  hh:mm tt") + " '" +
                               " AND (tr.recpttype = 'PO')  ");
                        }
                    }
                    else
                    {
                        Ds = CommonClass._ClPurchase.ShowpurchaseReport(Query + " and TR.recptdate between'" + dateTimePickerfrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + " ' and '" + dateTimePickerto.Value.ToString("MM/dd/yyyy  hh:mm tt") + " '" +
                          " AND (tr.recpttype = 'SR') and (rd.vtype = 'SR')");
                    }

                    Ds.Tables[0].Rows.Add(1);
                    Count = Ds.Tables[0].Rows.Count - 1;
                    DataTable table;
                    table = Ds.Tables[0];
                    object sumObject;

                    sumObject = table.Compute("Sum(qty)", "");
                    //Ds.Tables[0].Rows[Count]["qty"] = (sumObject.ToString());
                    Ds.Tables[0].Rows[Count]["qty"] = _Dbtask.znlldoubletoobject(sumObject);
                    
                    sumObject = table.Compute("Sum(freeqty)", "");
                    Ds.Tables[0].Rows[Count]["freeqty"] =_Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(Gross)", "");
                    Ds.Tables[0].Rows[Count]["Gross"] = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(taxamt)", "");
                    Ds.Tables[0].Rows[Count]["taxamt"] = _Dbtask.znlldoubletoobject(sumObject);

                    sumObject = table.Compute("Sum(netamount)", "");
                    Ds.Tables[0].Rows[Count]["netamount"] = _Dbtask.znlldoubletoobject(sumObject);

                    GridMain.DataSource = Ds.Tables[0];
                   

                    GridMain.Columns["reptcode"].Visible = false;
                    GridMain.Columns["mainaccount"].Visible = false;
                    GridMain.Columns["vno"].Width = 100;
                    GridMain.Columns["date"].Width = 100;
                    GridMain.Columns["refno"].Width = 100;
                    GridMain.Columns["party"].Width = 250;

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "taxamt", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "qty", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "freeqty", 70);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Gross", 130);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Discount", 100);  
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "netamount", 150);
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);
                }
                if (ReportType == "Purchasetaxsummery")
                {
                    double TTaxamt = 0;
                    double Tnetamt = 0;
                    double TDisc = 0;
                    double TTax = 0;
                    double TTTax = 0;
                    double TTaxableamt = 0;
                    double T1Pertax = 0;
                    double T2Pertax = 0;
                    double T5Pertax = 0;
                    double T145Pertax = 0;
                    double T20Pertax = 0;

                    double T0PertaxAmt = 0;
                    double T1PertaxAmt = 0;
                    double T2PertaxAmt = 0;
                    double T5PertaxAmt = 0;
                    double T145PertaxAmt = 0;
                    double T20PertaxAmt = 0;

                    double TT1Pertax = 0;
                    double TT2Pertax = 0;
                    double TT5Pertax = 0;
                    double TT145Pertax = 0;
                    double TT20Pertax = 0;
                    double TT0PertaxAmt = 0;
                    double TT1PertaxAmt = 0;
                    double TT2PertaxAmt = 0;
                    double TT5PertaxAmt = 0;
                    double TT145PertaxAmt = 0;
                    double TT20PertaxAmt = 0;

                    //Ds = _Dbtask.ExecuteQuery(Query + " and RecptDate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' order by vno");
                    Ds = CommonClass._Transactionreceipt.ShowTransactionReceipt(" * ", " where RecptType='PI' and  Recptdate between '" + DTFrom.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DTTo.ToString("MM/dd/yyyy  hh:mm tt") + " ' order by cast(vno as float) asc");
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        GridMain.Rows.Add(1);
                        string Lid=Ds.Tables[0].Rows[i]["LedcodeCr"].ToString();

                        string RecptCode = Ds.Tables[0].Rows[i]["ReptCode"].ToString();
                        string Ledcode = Ds.Tables[0].Rows[i]["Ledcodedr"].ToString();
                        GridMain.Rows[i].Cells["clndate"].Value =(Convert.ToDateTime(Ds.Tables[0].Rows[i]["RecptDate"])).ToString("dd/MM/yyyy");
                        GridMain.Rows[i].Cells["clnvnoT"].Value = Ds.Tables[0].Rows[i]["vno"];
                        GridMain.Rows[i].Cells["clnvno"].Value = Ds.Tables[0].Rows[i]["refno"];
                        string TaxRegNo = CommonClass._Ledger.GetspecifField("taxregno",Lid);

                        GridMain.Rows[i].Cells["clnparty"].Value =  CommonClass._Ledger.GetspecifField("lname",Lid);
                        GridMain.Rows[i].Cells["clntin"].Value = TaxRegNo;
                        GridMain.Rows[i].Cells["clnarea"].Value = CommonClass._Ledger.GetspecifField("area",Lid);
                       // GridMain.Rows[i].Cells["clnitemcategory"].Value = CommonClass._ReceiptDetails.CategoryNameinavoucher(Ledcode, RecptCode);
                        
                        double TempTaxamt = Convert.ToDouble(Ds.Tables[0].Rows[i]["taxamt"]);
                        double TempNetAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["amt"]);
                        double TempDiscAmt = Convert.ToDouble(Ds.Tables[0].Rows[i]["discamt"]);
                        double TempTaxableamt = TempNetAmt - TempTaxamt;

                        TTaxamt = TTaxamt + TempTaxamt;
                        TTaxableamt = TTaxableamt + TempTaxableamt + TempDiscAmt;
                        Tnetamt = Tnetamt + TempNetAmt;
                        
                            if (GridMain.Columns["cln14tax"].Visible == true)
                            {
                                T145Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from TblReceiptDetails where taxper=15 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                                GridMain.Rows[i].Cells["cln14tax"].Value = _Dbtask.SetintoDecimalpointStock(T145Pertax);
                                TT145Pertax = TT145Pertax + T145Pertax;
                            }
                            if (GridMain.Columns["cln5tax"].Visible == true)
                            {
                                T5Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from TblReceiptDetails where taxper=5 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                                GridMain.Rows[i].Cells["cln5tax"].Value = _Dbtask.SetintoDecimalpointStock(T5Pertax);
                                TT5Pertax = TT5Pertax + T5Pertax;
                            }
                            if (GridMain.Columns["cln1tax"].Visible == true)
                            {
                                T1Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from TblReceiptDetails where taxper=1 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                                GridMain.Rows[i].Cells["cln1tax"].Value = _Dbtask.SetintoDecimalpointStock(T1Pertax);
                                TT1Pertax = TT1Pertax + T1Pertax;
                            }
                            if (GridMain.Columns["cln2tax"].Visible == true)
                            {
                                T2Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from TblReceiptDetails where taxper=2 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                                GridMain.Rows[i].Cells["cln2tax"].Value = _Dbtask.SetintoDecimalpointStock(T2Pertax);
                                TT2Pertax = TT2Pertax + T2Pertax;
                            }
                            if (GridMain.Columns["cln20tax"].Visible == true)
                            {
                                T20Pertax = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from TblReceiptDetails where taxper=20 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                                GridMain.Rows[i].Cells["cln20tax"].Value = _Dbtask.SetintoDecimalpointStock(T20Pertax);
                                TT20Pertax = TT20Pertax + T20Pertax;
                            }
                        
                        if (GridMain.Columns["cln14taxableamt"].Visible == true)
                        {
                            T145PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=15 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T145PertaxAmt);
                            TT145PertaxAmt = TT145PertaxAmt + T145PertaxAmt;
                        }
                        if (GridMain.Columns["cln5taxableamt"].Visible == true)
                        {
                            T5PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=5 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T5PertaxAmt);
                            TT5PertaxAmt = TT5PertaxAmt + T5PertaxAmt;
                        }
                        if (GridMain.Columns["cln0taxableamt"].Visible == true)
                        {
                            T0PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=0 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T0PertaxAmt);
                            TT0PertaxAmt = TT0PertaxAmt + T0PertaxAmt;

                        }
                        if (GridMain.Columns["cln1taxableamt"].Visible == true)
                        {
                            T1PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=1 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T1PertaxAmt);
                            TT1PertaxAmt = TT1PertaxAmt + T1PertaxAmt;
                        }
                        if (GridMain.Columns["cln2taxableamt"].Visible == true)
                        {
                            T2PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=2 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T2PertaxAmt);
                            TT2PertaxAmt = TT2PertaxAmt + T2PertaxAmt;
                        }
                        if (GridMain.Columns["cln20taxableamt"].Visible == true)
                        {
                            T20PertaxAmt = Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(netamt-taxrate),0) from TblReceiptDetails where taxper=20 and RecptCode='" + RecptCode + "' and Ledcode='" + Ledcode + "' and vtype='PI'"));
                            GridMain.Rows[i].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T20PertaxAmt);
                            TT20PertaxAmt = TT20PertaxAmt + T20PertaxAmt;
                        }
                        TTax = T145Pertax + T5Pertax + T1Pertax + T20Pertax + T2Pertax;
                        GridMain.Rows[i].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpointStock(TTax);
                        //GridMain.Rows[i].Cells["clntaxamt"].Value = _Dbtask.SetintoDecimalpoint(TempTaxamt);
                        GridMain.Rows[i].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T0PertaxAmt);
                        GridMain.Rows[i].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T1PertaxAmt);
                        GridMain.Rows[i].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T2PertaxAmt);
                        GridMain.Rows[i].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T5PertaxAmt);
                        GridMain.Rows[i].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpointStock(T145PertaxAmt);
                        GridMain.Rows[i].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(T20PertaxAmt);

                        GridMain.Rows[i].Cells["clndisc"].Value = _Dbtask.SetintoDecimalpointStock(TempDiscAmt);
                        GridMain.Rows[i].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(TempNetAmt);
                        
                        // GridMain.Rows[i].Cells["clntaxableamt"].Value = _Dbtask.SetintoDecimalpoint(TempTaxableamt);
                        
                       
                        TTTax = TTTax + TTax;
                        TDisc = TDisc + TempDiscAmt;
                    }

                        Count = GridMain.Rows.Add(3);
                   
                        if (GridMain.Columns["cln14tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln14tax"].Value = _Dbtask.SetintoDecimalpoint(TT145Pertax);
                            GridMain.Rows[Count].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT5PertaxAmt);
                        }
                        if (GridMain.Columns["cln5tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln5tax"].Value = _Dbtask.SetintoDecimalpoint(TT5Pertax);
                            GridMain.Rows[Count].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT145PertaxAmt);
                        }
                        if (GridMain.Columns["cln1tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln1tax"].Value = _Dbtask.SetintoDecimalpoint(TT1Pertax);
                            GridMain.Rows[Count].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT1PertaxAmt);
                        }
                        if (GridMain.Columns["cln2tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln2tax"].Value = _Dbtask.SetintoDecimalpoint(TT2Pertax);
                            GridMain.Rows[Count].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT2PertaxAmt);
                        }
                        if (GridMain.Columns["cln20tax"].Visible == true)
                        {
                            GridMain.Rows[Count].Cells["cln20tax"].Value = _Dbtask.SetintoDecimalpoint(TT20Pertax);
                            GridMain.Rows[Count].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT20PertaxAmt);
                        }
                    
                    // GridMain.Rows[GridMain.Rows.Count - 1].Cells["clntaxamt"].Value = _Dbtask.SetintoDecimalpoint(TTaxamt);
                    GridMain.Rows[Count].Cells["clnttax"].Value = _Dbtask.SetintoDecimalpoint(TTTax);
                    GridMain.Rows[Count].Cells["cln14taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT145PertaxAmt);
                    GridMain.Rows[Count].Cells["cln5taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT5PertaxAmt);
                    GridMain.Rows[Count].Cells["cln0taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT0PertaxAmt);
                    GridMain.Rows[Count].Cells["cln1taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT1PertaxAmt);
                    GridMain.Rows[Count].Cells["cln2taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT2PertaxAmt);
                    GridMain.Rows[Count].Cells["cln20taxableamt"].Value = _Dbtask.SetintoDecimalpoint(TT20PertaxAmt);
                    GridMain.Rows[Count].Cells["clndisc"].Value = _Dbtask.SetintoDecimalpoint(TDisc);
                    GridMain.Rows[Count].Cells["clnnetamt"].Value = _Dbtask.SetintoDecimalpoint(Tnetamt);
                    RowBoldFunction(Count);

                    Count = GridMain.Rows.Add(2);

                    GridMain.Rows[Count].Cells[0].Value = "Total Gross";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TTaxableamt);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "0% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(0);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "1% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT1Pertax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "2% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT2Pertax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "5% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT5Pertax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "15% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT145Pertax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "20% Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TT20Pertax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "Total VAT";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    double TVat = TT145Pertax + TT1Pertax + TT5Pertax + TT20Pertax + TT2Pertax;
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(TVat);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "Tottal Discount";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    string Wheredate;
                    Wheredate = "  Recptdate between '" + dateTimePickerfrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + dateTimePickerto.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
                    double discc = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("  select sum(discamt) from tbltransactionreceipt where " + Wheredate + ""));
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(discc);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "Grand Total";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(Tnetamt);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    double DiscTax;
                    DiscTax = discc * _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select vat from tblitemmaster")) / 100;
                    GridMain.Rows[Count].Cells[0].Value = "Discount Tax";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = _Dbtask.SetintoDecimalpoint(DiscTax);
                    RowBoldFunction(Count);
                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = "Nett Vat";
                    GridMain.Rows[Count].Cells[0].Tag = "EXB";
                    GridMain.Rows[Count].Cells[2].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Tag = "EXB";
                    GridMain.Rows[Count].Cells[3].Value = CommonClass._Language.GetArabicString(GridMain.Rows[Count].Cells[0].Value.ToString());
                    GridMain.Rows[Count].Cells[2].Value = TVat - DiscTax;
                    RowBoldFunction(Count);

                    if (CommonClass.SRmode == "Mode1")
                    {
                        string[] Passing = { "cln14tax", "cln5tax", "cln1tax", "cln20tax", "cln2tax" };

                         CommonClass._Clreport.VisibleFalseColumns(Passing,GridMain);
                    }
                }

                if (ReportType == "Stockconsolidated" || ReportType == "Stockconsolidatedwithbatch")
                {
                    string Itemid;
                    double Os;
                    double Purchase;
                    double Mr;
                    double Sr;
                    double Ireceipt;
                    double Bmr;
                    double Freepre;
                    double Ps;
                    double Dnr;

                    double Sales;
                    double Dn;
                    double Pr;
                    double Iissue;
                    double Sh;
                    double Dmg;
                    double Bmi;
                    double freeiss;


                    double Balance;
                    double BalanceNotOpening;
                    double Add;
                    double Less;

                    double SumOs=0;
                    double SumPurchase=0;
                    double SumMr=0;
                    double SumSr=0;
                    double SumIreceipt=0;
                    double SumBmr=0;
                    double SumFreepre=0;
                    double SumPs=0;
                    double SumDnr=0;

                    double SumSales=0;
                    double SumDn=0;
                    double SumPr=0;
                    double SumIissue=0;
                    double SumSh=0;
                    double SumDmg=0;
                    double SumBmi=0;
                    double Sumfreeiss=0;


                    double SumBalance=0;
                    double SumBalanceNotOpening=0;


                    Ds = _Dbtask.ExecuteQuery(Query);
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        Itemid=Ds.Tables[0].Rows[i]["itemid"].ToString();

                        Os = CommonClass._Inventory.GetStock(" where invdate < '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and pcode='"+Itemid+"' "+QueryTemp+"");
                        Os = Os + CommonClass._Inventory.SumofField("OS", " where pcode='" + Itemid + "'");
                        Purchase = CommonClass._Inventory.SumofField("purchase", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Mr = CommonClass._Inventory.SumofField("Mr", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Sr = CommonClass._Inventory.SumofField("Sr", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Ireceipt = CommonClass._Inventory.SumofField("Ireceipt", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Bmr = CommonClass._Inventory.SumofField("Bmr", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Freepre = CommonClass._Inventory.SumofField("Freepre", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Ps = CommonClass._Inventory.SumofField("Ps", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Dnr = CommonClass._Inventory.SumofField("Dnr", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");

                        Add = (Purchase + Mr + Sr + Ireceipt + Bmr + Freepre + Ps + Dnr);

                        SumOs = SumOs + Os;
                        SumPurchase = SumPurchase + Purchase;
                        SumMr = SumMr + Mr;
                        SumSr = SumSr + Sr;
                        SumIreceipt = SumIreceipt + Ireceipt;
                        SumBmr = SumBmr + Bmr;
                        SumFreepre = SumFreepre + Freepre;
                        SumPs = SumPs + Ps;
                        SumDnr = SumDnr + Dnr;


                        Sales = CommonClass._Inventory.SumofField("sales", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Dn = CommonClass._Inventory.SumofField("Dn", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Pr = CommonClass._Inventory.SumofField("Pr", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Iissue = CommonClass._Inventory.SumofField("iissue", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Sh = CommonClass._Inventory.SumofField("Sh", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Dmg = CommonClass._Inventory.SumofField("dmg", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        Bmi = CommonClass._Inventory.SumofField("Bmi", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");
                        freeiss = CommonClass._Inventory.SumofField("freeiss", " where pcode='" + Itemid + "' and Invdate between '" + DTFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DTTo.ToString("MM/dd/yyyy") + " 23:59:59' " + QueryTemp + "");

                        Less = (Sales + Dn + Pr + Iissue + Sh + Dmg + Bmi + freeiss);

                        SumSales = SumSales + Sales;
                        SumDn = SumDn + Dn;
                        SumPr = SumPr + Pr;
                        SumIissue = SumIissue + Iissue;
                        SumSh = SumSh + Sh;
                        SumDmg = SumDmg + Dmg;
                        SumBmi = SumBmi + Bmi;
                        Sumfreeiss = Sumfreeiss + freeiss;

                        Balance = Os + Add;
                        Balance = Balance - Less;

                        BalanceNotOpening = Add - Less;

                        Count = GridMain.Rows.Add(1);
                        GridMain.Rows[Count].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "itemname");
                        GridMain.Rows[Count].Cells["clnopening"].Value = Os.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnbalance"].Value = Balance.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnbalancen"].Value = BalanceNotOpening.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnpurchase"].Value = Purchase.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnmr"].Value = Mr.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnsr"].Value = Sr.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnireceipt"].Value = Ireceipt.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnbmr"].Value = Bmr.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnfreepre"].Value = Freepre.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnps"].Value = Ps.ToString("0.00");
                        GridMain.Rows[Count].Cells["clndnr"].Value = Dnr.ToString("0.00");


                        GridMain.Rows[Count].Cells["clnsales"].Value = Sales.ToString("0.00");
                        GridMain.Rows[Count].Cells["clndn"].Value = Dn.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnpr"].Value = Pr.ToString("0.00");
                        GridMain.Rows[Count].Cells["clniissue"].Value = Iissue.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnsh"].Value = Sh.ToString("0.00");
                        GridMain.Rows[Count].Cells["clndmg"].Value = Dmg.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnbmi"].Value = Bmi.ToString("0.00");
                        GridMain.Rows[Count].Cells["clnfreeiss"].Value = freeiss.ToString("0.00");

                        SumBalance = SumBalance + Balance;
                        SumBalanceNotOpening = SumBalanceNotOpening + BalanceNotOpening;

                    }

                    Count = GridMain.Rows.Add(1);
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                    GridMain.Rows[Count].Cells["clnopening"].Value = SumOs.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnbalance"].Value = SumBalance.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnbalancen"].Value = SumBalanceNotOpening.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnpurchase"].Value = SumPurchase.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnmr"].Value = SumMr.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnsr"].Value = SumSr.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnireceipt"].Value = SumIreceipt.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnbmr"].Value = SumBmr.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnfreepre"].Value = SumFreepre.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnps"].Value = SumPs.ToString("0.00");
                    GridMain.Rows[Count].Cells["clndnr"].Value = SumDnr.ToString("0.00");


                    GridMain.Rows[Count].Cells["clnsales"].Value = SumSales.ToString("0.00");
                    GridMain.Rows[Count].Cells["clndn"].Value = SumDn.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnpr"].Value = SumPr.ToString("0.00");
                    GridMain.Rows[Count].Cells["clniissue"].Value = SumIissue.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnsh"].Value = SumSh.ToString("0.00");
                    GridMain.Rows[Count].Cells["clndmg"].Value = SumDmg.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnbmi"].Value = SumBmi.ToString("0.00");
                    GridMain.Rows[Count].Cells["clnfreeiss"].Value = Sumfreeiss.ToString("0.00");
                    // if (ReportType == "Stockconsolidatedwithbatch")
                   // {
                   //     Ds = CommonClass._Clreport.StockConsolidateBaseonItem(Query + "  order by IMS.ItemId asc", true, DTFrom.ToString("yyyyMMdd 00:00:00"), DTTo.ToString("yyyyMMdd 23:59:59"));
                   // }
                   // else
                   // {
                       //Ds = CommonClass._Clreport.StockConsolidateBaseonItem("", false, DTFrom.ToString("yyyyMMdd 00:00:00"), DTTo.ToString("yyyyMMdd 23:59:59"));
                   // }

                   // Ds.Tables[0].Rows.Add();
                   // Count = Ds.Tables[0].Rows.Count - 1;
                   // DataTable table;
                   // table = Ds.Tables[0];
                   // object sumObject;

                   // sumObject = table.Compute("Sum(balance)", "");
                   // Ds.Tables[0].Rows[Count]["balance"] = (sumObject.ToString());

                   // sumObject = table.Compute("Sum(Opening)", "");
                   // Ds.Tables[0].Rows[Count]["Opening"] = (sumObject.ToString());

                   // sumObject = table.Compute("Sum(Purchase)", "");
                   // Ds.Tables[0].Rows[Count]["Purchase"] = (sumObject.ToString());


                   // sumObject = table.Compute("Sum(DNR)", "");
                   // Ds.Tables[0].Rows[Count]["DNR"] = (sumObject.ToString());

                   // sumObject = table.Compute("Sum(IReceipt)", "");
                   // Ds.Tables[0].Rows[Count                     ]["IReceipt"] = (sumObject.ToString());

                   // sumObject = table.Compute("Sum(Sales)", "");
                   // Ds.Tables[0].Rows[Count]["Sales"] = (sumObject.ToString());

                   // sumObject = table.Compute("Sum(Shortage)", "");
                   // Ds.Tables[0].Rows[Count]["Shortage"] = (sumObject.ToString());

                   // if (ReportType != "Stockconsolidated")
                   // {
                   //     sumObject = table.Compute("Sum(pvalue)", "");
                   //     Ds.Tables[0].Rows[Count]["pvalue"] = (sumObject.ToString());

                   //     sumObject = table.Compute("Sum(svalue)", "");
                   //     Ds.Tables[0].Rows[Count]["svalue"] = (sumObject.ToString());
                   // }
                   // GridMain.DataSource = Ds.Tables[0];
                   // CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                   //// GridMain.Columns["itemid"].Visible = false;
                   // GridMain.Columns["itemcode"].Width = 250;
                   // GridMain.Columns["itemname"].Width = 250;
                    
                   // if (ReportType != "Stockconsolidated")
                   // {
                   //     GridMain.Columns["batchcode"].Width = 100;
                   // }
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "balance", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "opening", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "py(stock)", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "purchase", 70);

                   // if (ReportType != "Stockconsolidated")
                   // {
                   //     CommonClass._Clreport.Qtycolumnsettings(GridMain, "pvalue", 100);
                   // }
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "s.return", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "dnr", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "ireceipt", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "sales", 70);

                   // if (ReportType != "Stockconsolidated")
                   // {
                   //     CommonClass._Clreport.Qtycolumnsettings(GridMain, "Svalue", 100);
                   // }
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "p.return", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "d.note", 70);
                   // CommonClass._Clreport.Qtycolumnsettings(GridMain, "shortage", 70);

                   // if (ReportType != "Stockconsolidated")
                   // {
                   //     GridMain.Columns["pvalue"].DisplayIndex = 9;
                   //     GridMain.Columns["svalue"].DisplayIndex = 18;
                   // }
                }


                if (ReportType == "Item list count")
                {
                    Ds = _Dbtask.ExecuteQuery("select(select  itemname from tblitemmaster where itemid=pcode) as 'ItemName' "+
                        " ,sum(Qty) as 'Qty',(select name from tblUnitcreation  where id=unitid) as 'Unit' "+
                        " from tblissuedetails "+Query+" ");

                    GridMain.DataSource = Ds.Tables[0];
                    GridMain.Columns["itemname"].Width = 250;
                     GridMain.Columns["qty"].Width = 100;
                     GridMain.Columns["Unit"].Width = 150;
                }

                if (ReportType == "Stock Value")
                {

                    if (ReportTypeSecond == "All Units")
                    {
                        string Itemid;
                        string Stock;
                        double StockSub;
                        string UnitId;
                       
                            Ds = CommonClass._Itemmaster.ShowItemsBaseonCategory(QueryTemp);
                       

                        double[] Total = new double[100];
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clncategory"].Value = Ds.Tables[0].Rows[i]["Category"];
                            GridMain.Rows[Count].Cells["clnitemname"].Value = Ds.Tables[0].Rows[i]["Itemname"];
                            Itemid = Ds.Tables[0].Rows[i]["Itemid"].ToString();
                            Stock = (CommonClass._Inventory.GetStock(" where pcode='" + Itemid + "' and "+Decodee+"")).ToString();
                            Ds1 = _Dbtask.ExecuteQuery("select * from tblunitsrates where itemid='" + Itemid + "'");

                            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                            {
                                UnitId = Ds1.Tables[0].Rows[k]["Uid"].ToString();
                                StockSub= _Dbtask.znullDouble(Stock) / _Dbtask.znullDouble(CommonClass._Unitcreation.Getspesificfield("ucount", UnitId));
                                GridMain.Rows[Count].Cells[UnitId].Value =StockSub;
                                Total[GridMain.Columns[UnitId].Index] += StockSub;
                            }
                            GridMain.Rows[Count].Cells["clnrate"].Value = Ds.Tables[0].Rows[i]["Prate"];
                            GridMain.Rows[Count].Cells["clnamount"].Value = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["Prate"]) * _Dbtask.znullDouble(Stock);
                            GridMain.Rows[Count].Cells["clnqty"].Value = _Dbtask.znlldoubletoobject(Stock);

                        }
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "ClnRate", 150);
                        //CommonClass._Clreport.Qtycolumnsettings(GridMain, "qty", 150);
                        CommonClass._Clreport.Qtycolumnsettings(GridMain, "ClnAmount", 200);
                        Count = GridMain.Rows.Add(1);
                        Ds = _Dbtask.ExecuteQuery("select * from tblUnitcreation");
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            GridMain.Rows[Count].Cells[Ds.Tables[0].Rows[i]["id"].ToString()].Value = Total[GridMain.Columns[Ds.Tables[0].Rows[i]["id"].ToString()].Index];
                            CommonClass._Clreport.Qtycolumnsettings(GridMain, Ds.Tables[0].Rows[i]["id"].ToString(), 100);
                        }
                    }
                    else
                    {
                        Ds = CommonClass._Clreport.StockListBaseonItem(Query + " order by IMS.categoryid asc", Secondcondition, Thirdcondition, dateTimePickerfrom.Value, dateTimePickerto.Value);
                        //  (Query+" order by IM.ItemId asc",Secondcondition,false,dateTimePickerfrom.Value,dateTimePickerto.Value)
                        Ds.Tables[0].Rows.Add();
                        Count = Ds.Tables[0].Rows.Count - 1;

                        DataTable table;
                        table = Ds.Tables[0];
                        object sumObject;
                        sumObject = table.Compute("Sum(totalvalue)", "");

                        Ds.Tables[0].Rows[Count]["totalvalue"] = (sumObject.ToString());

                        sumObject = table.Compute("Sum(qty)", "");
                        Ds.Tables[0].Rows[Count]["qty"] = (sumObject.ToString());

                        Ds.Tables[0].Rows[Count]["Itemname"] = "Total Stock";


                        GridMain.DataSource = Ds.Tables[0];


                        GridMain.Columns["itemid"].Visible = false;
                        GridMain.Columns["itemcode"].Width = 250;
                        GridMain.Columns["itemname"].Width = 250;
                        CommonClass._Clreport.TottalRowStyle(GridMain, Count);


                    }
                    

                }

                if (ReportType == "Stock ValueBatchwise")
                {
                    Ds =  CommonClass._Clreport.StockListBaseonBarcode(Query+" order by IM.ItemId asc",Secondcondition,false,dateTimePickerfrom.Value,dateTimePickerto.Value);

                    Ds.Tables[0].Rows.Add();
                    Count = Ds.Tables[0].Rows.Count - 1;
                   // Ds.Tables[0].Rows[Count]["qty"] = CommonClass._Inventory.GetStock(QueryTemp + " where invdate between  '" + DTFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + DTTo.ToString("MM-dd-yyyy") + " 23:59:59' ");
                    DataTable table;
                    table = Ds.Tables[0];


                    object sumObject;
                    sumObject = table.Compute("Sum(Amount)", "");

                    Ds.Tables[0].Rows[Count]["Amount"] = (sumObject.ToString());

                    sumObject = table.Compute("Sum(Qty)", "");

                    Ds.Tables[0].Rows[Count]["qty"] = (sumObject.ToString());

                    Ds.Tables[0].Rows[Count]["Item Name"] = "Total Stock";

                    GridMain.DataSource = Ds.Tables[0];
                    CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                    GridMain.Columns["itemid"].Visible = false;
                    GridMain.Columns["Second Language"].Width = 250;
                    GridMain.Columns["Item Name"].Width = 250;
                    GridMain.Columns["Barcode"].Width = 200;

                    CommonClass._Clreport.Qtycolumnsettings(GridMain, Secondcondition, 150);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "qty", 150);
                    CommonClass._Clreport.Qtycolumnsettings(GridMain, "Amount", 200);

                    //Ds.Tables[0].Rows.Add();

                    //DataTable table;
                   
                    //table = Ds.Tables[0];

                    //Count = Ds.Tables[0].Rows.Count-1;
    

                    
                    //object sumObject=new object();
                    
                    //GridMain.DataSource = Ds.Tables[0];
                    
                    //sumObject = table.Compute("Sum(Totalvalue)", "0.00");
                    //Ds.Tables[0].Rows[Count]["Totalvalue"] = (sumObject.ToString());

                    //sumObject = table.Compute("Sum(Qty)", "");
                    //Ds.Tables[0].Rows[Count]["qty"] = (sumObject.ToString());


                    //Ds.Tables[0].Rows[Count]["Itemname"] = "Total Stock";

                    //GridMain.DataSource = Ds.Tables[0];
                    //CommonClass._Clreport.TottalRowStyle(GridMain, Count);

                    //GridMain.Columns["itemid"].Visible = false;
                    //GridMain.Columns["itemcode"].Width = 250;
                    //GridMain.Columns["itemname"].Width = 250;
                    //GridMain.Columns["bcode"].Width = 200;

                    // CommonClass._Clreport.Qtycolumnsettings(GridMain, "rate", 150);
                    // CommonClass._Clreport.Qtycolumnsettings(GridMain, "qty", 150);
                    // CommonClass._Clreport.Qtycolumnsettings(GridMain, "totalvalue", 200);
                    
                }

                if (ReportType == "Analysissalesandpurchase")
                {
                    GridMain.Rows.Add(1);
                    string Sale = _Dbtask.ExecuteScalar(" select isnull(sum(cramt),0) from tblgeneralledger where vtype='SI' and   VDate between '" + dateTimePickerfrom.Value.ToString("dd/MM/yyyy 00:00:00") + "' and '" + dateTimePickerto.Value.ToString("dd/MM/yyyy 23:59:59") + "'");
                    string Purchase = _Dbtask.ExecuteScalar(" select isnull(sum(Dbamt),0) from tblgeneralledger where vtype='PI' and   VDate between '" + dateTimePickerfrom.Value.ToString("dd/MM/yyyy 00:00:00") + "' and '" + dateTimePickerto.Value.ToString("dd/MM/yyyy 23:59:59") + "'");
                    double TempSale = Convert.ToDouble(Sale);
                    double Temppurchase = Convert.ToDouble(Purchase);
                    double Balance = Temppurchase - TempSale;
                    GridMain.Rows[0].Cells["clnsales"].Value = _Dbtask.SetintoDecimalpoint(TempSale);
                    GridMain.Rows[0].Cells["clnpurchase"].Value = _Dbtask.SetintoDecimalpoint(Temppurchase);
                    GridMain.Rows[0].Cells["clnbalance"].Value = _Dbtask.SetintoDecimalpoint(Balance);
                }
                ChangeLanguage();
            }
                catch
            {
            }
        }
        

        public void CalcGrossLossandGrossProfit()
        {
            if (AmtDiExpense > AmtDiIncome)
            {
                RowInc = RowInc + 1;
                GridMain.Rows[RowInc].Cells[2].Value = "Gross Loss";
                GridMain.Rows[RowInc].Cells[3].Value = AmtDiExpense - AmtDiExpense;
                RowsCount = GridMain.Rows.Count - 1;

                GridMain.Rows[RowsCount].Cells[3].Value = AmtDiExpense;
                GridMain.Rows[RowsCount].Cells[1].Value = AmtDiExpense;

            }
            else
            {

                // GridMain.Rows[RowInc].Cells[1].Value = AmtDiIncome;
                RowExp = RowExp + 1;
                GridMain.Rows[RowExp].Cells[0].Value = "Gross Profit";
                GridMain.Rows[RowExp].Cells[1].Value = AmtDiIncome - AmtDiExpense;
                RowsCount = GridMain.Rows.Count - 1;

                GridMain.Rows[RowsCount].Cells[3].Value = AmtDiIncome;
                GridMain.Rows[RowsCount].Cells[1].Value = AmtDiIncome;
            }
            GridMain.Rows[RowsCount].DefaultCellStyle.BackColor = System.Drawing.Color.Purple;
            GridMain.Rows[RowsCount].DefaultCellStyle.ForeColor = System.Drawing.Color.White;

        }
        private void FrmReport_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void SetHeadingAndControleSize()
        {
            try
            {
                LblHeading.Text = ReportType;
                // dateTimePickerfrom.
                if (DTFrom.Date.Year != 1)
                {
                    dateTimePickerfrom.Value = DTFrom;
                    dateTimePickerto.Value = DTTo;
                    LblDateBetween.Text = DTFrom.ToString("dd-MM-yyyy") + "To" + DTTo.ToString("dd-MM-yyyy");
                }
                else
                {
                    LblDateBetween.Visible = false;
                }
                GridWidth = 0;
                LblHeading.Left = (this.ClientSize.Width - LblHeading.Width) / 2;
                LblDateBetween.Left = (this.ClientSize.Width - LblDateBetween.Width) / 2;
                GridMain.CellBorderStyle = DataGridViewCellBorderStyle.None;
                GridMain.Left = (this.ClientSize.Width - GridMain.Width) / 2;
                dateTimePickerfrom.Focus();

            }
            catch
            {
            }
        }

        public void Clear()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            CommonClass._Gen.FillActivePrinter(comprint);

            Mainload();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);

        }
        public void ExporttoexcelImport()
        {
            int cols;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save File";
            theDialog.Filter = "Excel File|*.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string Filepath = theDialog.FileName;

                //open file
                StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                //determine the number of columns and write columns to file
                cols = GridMain.Columns.Count;
                wr.Write("Company Name\n\n\n");


                // wr.Write(LblHeading.Text + "\n\n");

                for (int i = 0; i < cols; i++)
                {
                    wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                }
                wr.WriteLine();
                // write rows to excel file
                for (int i = 0; i < (GridMain.Rows.Count); i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (GridMain.Rows[i].Cells[j].Value != null)
                        {
                            string StrValue;
                            StrValue = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", " ");
                            StrValue = StrValue.Replace("\n", " ");
                            wr.Write(StrValue + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                //close file
                wr.Close();
                System.Diagnostics.Process.Start(Filepath);

                // File.Open(Filepath,FileMode.Open);

            }
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            Clear();
        }
        public void Mainload()
        {
            CommonClass._commenevent.WaitCursor(this);
            SetGrid();
            SetHeadingAndControleSize();
            ReportShowInGrid();
            Formsett();
            CommonClass._commenevent.NormalCursor(this);
        }
        public void Formsett()
        {
            GridMain.Height = this.Height - pnlmain.Height;
            this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            
            if (Removeborder == true)
            {
                this.GridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
                this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            }
            else
            {
                this.GridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
                this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            }
        }


        private void FrmReport_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        //public void gridcompleatlyexcel(DataGridView dataGridView1)
        //{
           
        //    // creating Excel Application  
        //    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    // creating new WorkBook within Excel application  
        //    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    // creating new Excelsheet in workbook  
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //    // see the excel sheet behind the program  
        //    app.Visible = true;
        //    // get the reference of first sheet. By default its name is Sheet1.  
        //    // store its reference to worksheet  
        //    worksheet = workbook.Sheets["Sheet1"];
        //    //workbook.Sheets["Sheet1"];
        //    worksheet = workbook.ActiveSheet;
        //    // changing the name of active sheet  
        //    worksheet.Name = "Exported from gridview";
        //    // storing header part in Excel  
        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
        //    }
        //    // storing Each row and column value to excel sheet  
        //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
        //    // save the application  
        //    workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    // Exit from the application  
        //    app.Quit();
        //}


        public void newexcelcode(DataGridView Grid)
        {
            int cols;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save File";
            theDialog.Filter = "Excel File|*.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string Filepath = theDialog.FileName;

                //open file
                StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                //determine the number of columns and write columns to file
                cols = GridMain.Columns.Count;
                wr.Write("Company Name\n\n\n");


                // wr.Write(LblHeading.Text + "\n\n");

                for (int i = 0; i < cols; i++)
                {
                    wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                }
                wr.WriteLine();
                // write rows to excel file




                for (int i = 0; i < (Grid.Rows.Count); i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (Grid.Rows[i].Cells[j].Value != null && _Dbtask.znllString(Grid.Rows[i].Cells[j].Value) != "")
                        {
                            Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                            Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                            wr.Write(Grid.Rows[i].Cells[j].Value + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                
                
                
                
                
                //close file
                wr.Close();
                System.Diagnostics.Process.Start(Filepath);

                // File.Open(Filepath,FileMode.Open);

            }
        }

        public void Exporttoexcelsalee(DataGridView Grid)
        {
            int cols;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save File";
            theDialog.Filter = "Excel File|*.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string Filepath = theDialog.FileName;

                //open file
                StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                //determine the number of columns and write columns to file
                cols = GridMain.Columns.Count;
                wr.Write("Company Name\n\n\n");


                // wr.Write(LblHeading.Text + "\n\n");

                for (int i = 0; i < cols; i++)
                {
                    wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                }
                wr.WriteLine();
                // write rows to excel file
                for (int i = 0; i < (Grid.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (Grid.Rows[i].Cells[j].Value != null && _Dbtask.znllString( Grid.Rows[i].Cells[j].Value)!="")
                            {
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(Grid.Rows[i].Cells[j].Value + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    //}
                    //wr.WriteLine();
                }
                //close file
                wr.Close();
                System.Diagnostics.Process.Start(Filepath);

                // File.Open(Filepath,FileMode.Open);

            }
        }
        public void Exporttoexcel(DataGridView Grid)
        {

            try
            {
                int cols;
                SaveFileDialog theDialog = new SaveFileDialog();
                theDialog.Title = "Save File";
                //theDialog.Filter = "Excel File|*.xlsx";
                theDialog.Filter = "Excel File|*.xls";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    string Filepath = theDialog.FileName;

                    //open file
                    StreamWriter wr = new StreamWriter(Filepath,true,Encoding.UTF8);

                    //determine the number of columns and write columns to file
                    cols = Grid.Columns.Count;
                    wr.Write("" + CommonClass._compMaster.GetspecifField("cname") + "\n\n\n");
                    wr.Write(DTFrom.ToString("dd-MM-yyyy") + "  To " + DTTo.ToString("dd-MM-yyyy") + " \n\n");

                    wr.Write(LblHeading.Text + "\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(Grid.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (Grid.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (Grid.Rows[i].Cells[j].Value != null)
                            {
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(Grid.Rows[i].Cells[j].Value + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
                }
            }
            catch
            {
            }
        }


        public void PrintConsole()
        {
            string Name;
            string Amount;

            Name = "Party Name".PadRight(40, ' ');
            Amount = "Amount".PadLeft(15, ' ');

            string LineHeading = "=".PadRight(70, '=');

            RichTextBox1.Text = Name + Amount+"\n"+LineHeading;
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Cells[0].Value != null)
                {
                        
                        
                        Name = GridMain.Rows[i].Cells[1].Value.ToString();
                        Amount = GridMain.Rows[i].Cells[2].Value.ToString();

                        Name = GridMain.Rows[i].Cells[1].Value.ToString();
                        Name = Name.PadRight(40, ' ');
                        if (Name.Length > 40)
                            Name = Name.Substring(0, 40);

                        double Samount = Convert.ToDouble(GridMain.Rows[i].Cells[2].Value);
                        Amount = _Dbtask.SetintoDecimalpointStock(Samount);
                        Amount = Amount.PadLeft(7, ' ');


                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Name +Amount;
                    
                }
            }
            if (!MyPrinter.Open("Qplex Print")) return;
            PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));

            PrintDotMetrix(true);
            // PrintBold("You Saved   :" + SavedAmount + "                 Total    :" + txtbillamount.Text, true);

            //  RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
            //  RichTextBox1.Text = "\n\nCash Received: " + FrmCashDesk.TCash + "\nBalance:" + FrmCashDesk.Balance;

            Fscroll();

            // MyPrinter.Print("===================================\r\n");
            MyPrinter.Close();
        }

        public void Fscroll()
        {

            int Fscroll = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Fscroll"));

            for (int i = 0; i <= Fscroll; i++)
            {
                RichTextBox1.Text = RichTextBox1.Text + "\n";
            }

        }

        public void PrintRollBack(int Count)
        {

            MyPrinter.Close();
            if (!MyPrinter.Open("Qplex Print")) return;

            for (int i = 0; i <= Count; i++)
            {
                MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
            }
            MyPrinter.Close();

        }
        public void PrintDotMetrix(bool Isconsole)
        {

            MyPrinter.Close();

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

            MyPrinter.Close();
        }

        public void Showprinting()
        {
            //if ( ReportType == "BillwisesettilementPurchData" || ReportType == "BillwisesettilementSR" || ReportType == "BillwisesettilementPR")
            //{
            //    ClsBILLWISElaser _lasbillwisesettle = new ClsBILLWISElaser();
            //    _lasbillwisesettle.Lid = agvnlid;

            //    //if (ReportType == "BillwisesettilementData")
            //    //{
            //    //    _lasbillwisesettle.FormType = "Sales Billwise Settlement Details";
            //    //}
            //    if (ReportType == "BillwisesettilementPurchData")
            //    {
            //        _lasbillwisesettle.FormType = "Purchase Billwise Settlement Details";
            //    }
            //    if (ReportType == "BillwisesettilementSR")
            //    {
            //        _lasbillwisesettle.FormType = "Sale Return Billwise Settlement Details";
            //    }
            //    if (ReportType == "BillwisesettilementPR")
            //    {
            //        _lasbillwisesettle.FormType = "Purchase Return Billwise Settlement Details";
            //    }

            //    //_lasbillwisesettle.timestr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");

            //    ClsBILLWISElaser.SelPrint = comprint.Text;
            //    _lasbillwisesettle.PrintInvoice(GridMain);


            //}

            if (ReportType == "BillwisesettilementData" || ReportType == "BillwisesettilementPurchData" || ReportType == "BillwisesettilementSR" || ReportType == "BillwisesettilementPR")
            {
                ClsBillwisesettleprintreport _billset = new ClsBillwisesettleprintreport();
                _billset.FormType = ReportType;
                //_quick.timestr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _billset.Lid = agvnlid;

                ClsRPSeperatereport.SelPrint = comprint.Text;
                _billset.PrintInvoice(GridMain);
            }






            if (ReportType == "Receipt Report only" || ReportType == "Payment Report only")
            {
                ClsRPSeperatereport _rpprint = new ClsRPSeperatereport();
                _rpprint.FormType = ReportType;
                //_quick.timestr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _rpprint.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                ClsRPSeperatereport.SelPrint = comprint.Text;
                _rpprint.PrintInvoice(GridMain);

            }
            
            if (ReportType == "Balancesheet")
            {
                ClsBalancesheet _SHEET = new ClsBalancesheet();
                _SHEET.FormType = "Balancesheet";
                _SHEET.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                ClsBalancesheet.SelPrint = comprint.Text;
                _SHEET.PrintInvoice(GridMain);

            }
            if (ReportType == "GroupReportSummury")
            {
                Clsgroupoutstanddetail _outstanddetail = new Clsgroupoutstanddetail();
                _outstanddetail.FormType = "GroupReportSummury";
                _outstanddetail.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                Clsgroupoutstanddetail.SelPrint = comprint.Text;
                _outstanddetail.PrintInvoice(GridMain);

            }
            if (ReportType == "P&L Report")
            {
                ClsProfitandloss _prloss= new ClsProfitandloss();
                _prloss.FormType = "P&L Report";
                _prloss.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                ClsProfitandloss.SelPrint = comprint.Text;
                _prloss.PrintInvoice(GridMain);

            }



            if (ReportType == "Daybook")
            {
                ClsDaybook _book = new ClsDaybook();
                _book.FormType = "Daybook";
                _book.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                ClsDaybook.SelPrint = comprint.Text;
                _book.PrintInvoice(GridMain);

            }
            if (ReportType == "TrailBalance")
            {
                Clstrailbalance _trail = new Clstrailbalance();
                _trail.FormType = "trailbalance";
                _trail.timestr = "Time: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("dd/MM/yyyy hh:mm:ss");

                Clstrailbalance.SelPrint = comprint.Text;
                _trail.PrintInvoice(GridMain);

            }

            if (ReportType == "Payment and Receipt Report")
            {
                Clsreceiptpaymentreport _rpreport = new Clsreceiptpaymentreport();
                _rpreport.FormType = "Payment and Receipt Report";
                //_quick.timestr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");

                Clsreceiptpaymentreport.SelPrint = comprint.Text;
                _rpreport.PrintInvoice(GridMain);

            }
            if (ReportType == "Salestaxsummery")
            {
                _saletax.FormType = "Salestax";
                _saletax.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _saletax.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _saletax.Sumgrss = 0;
                _saletax.SUmNetAmt = 0;
                _saletax.SUmqty = 0;
               
                _saletax.SumSrate = 0;
                clssaletaxHorizontal.SelPrint = comprint.Text;
                _saletax.PrintInvoice(GridMain);
            }
            if (ReportType == "Purchasetaxsummery")
            {
                _purtax.FormType = "Purchasetax";
                _purtax.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _purtax.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _purtax.Sumgrss = 0;
                _purtax.SUmNetAmt = 0;
                _purtax.SUmqty = 0;
                _purtax.SumSrate = 0;
                clsPurchasetaxHorizontal.SelPrint = comprint.Text;
                _purtax.PrintInvoice(GridMain);
            }



            if (ReportType == "Stock ValueBatchwise")
            {
                clsstockreportthemal.SelPrint = comprint.Text;
                _stockReport.FormType = "StockReport A4";
                _stockReport.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _stockReport.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _stockReport.SUmqty = 0;
                _stockReport.SUmNetAmt = 0;
               
                _stockReport.PrintInvoice(GridMain);
            }

            if (LblHeading.Text == "Salesdaybook")
            {
                ClsInvThermalSummury _ThermalThermal = new ClsInvThermalSummury();
                _ThermalThermal.FormType = "Salesdaybook";
                _ThermalThermal.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _ThermalThermal.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _ThermalThermal.Stritemname = lblheading2.Text;
                _ThermalThermal.Strtotalamount = _Dbtask.znllString(lblheading2.Tag);
                _ThermalThermal.PSelect = comprint.Text;
                _ThermalThermal.PrintInvoice(GridMain);

            }

            if (LblHeading.Text == "SalesDaysummury")
            {
                printPreviewDialog1.Document = printDocument1;
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                printPreviewDialog1.ShowDialog();
            }

            else if (chkconsole.Checked == true)
            {
                PrintConsole();
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                //dlg.ShowDialog();
               
                if (LblHeading.Text != "AccountReport" && LblHeading.Text != "Sales")
                {
                    //  printPreviewDialog1.ShowDialog();
                }
                frmsalesinvoice _printvalue = new frmsalesinvoice();
                printvalue = true;
                newprintreport();
                Frmreport2 _reporttwo = new Frmreport2();

                printvalue = false;

            }
        }

        public void RowValidationsale()
        {
            try
            {
                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    //string slnno = GridMain.Rows[i].Cells["party"].Value.ToString();

                    if (GridMain.Rows[i].Cells["vno"].Value == null || Convert.ToDouble(GridMain.Rows[i].Cells["netamount"].Value) == Convert.ToDouble(0))
                    {


                        GridMain.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridMain.Rows[i].Tag = 1;
                        GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }


        //mymy
        public void newprintreport()
        {
            string Strheading = "sales report";
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

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



            //RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + Slno + TsRate + "\n" + LineHeading + "";


            //double TRate = 0;
            //double TQty = 0;
            //double TAmount = 0;
            //double Qty = 0;
            //double Rate = 0;
            //double Amount = 0;
            //RowValidationsale();
            //for (int i = 0; i < GridMain.Rows.Count; i++)
            //{
            //    if (GridMain.Rows[i].Tag != null)
            //    {
            //        if (GridMain.Rows[i].Tag.ToString() == "1")
            //        {

            //            Slno = (i + 1).ToString();
            //            Slno = Slno.PadRight(4, ' ');

            //            Pname = GridMain.Rows[i].Cells["date"].Value.ToString();
            //            Pname = Pname.PadRight(15, ' ');
            //            if (Pname.Length > 20)
            //                Pname = Pname.Substring(0, 20);

            //            double sQty = Convert.ToDouble(GridMain.Rows[i].Cells["qty"].Value);
            //            TsQty = CommonClass._Dbtask.SetintoDecimalpointStock(sQty);
            //            TsQty = TsQty.PadRight(5, ' ');

            //            double taxamt = Convert.ToDouble(GridMain.Rows[i].Cells["taxamt"].Value);
            //            TsRate = CommonClass._Dbtask.SetintoDecimalpoint(taxamt);
            //            TsRate = TsRate.PadLeft(8, ' ');

            //            double sAmount = Convert.ToDouble(GridMain.Rows[i].Cells["netamount"].Value);
            //            TsAmount = CommonClass._Dbtask.SetintoDecimalpoint(sAmount);
            //            TsAmount = TsAmount.PadRight(9, ' ');



            //            RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

            //        }
            //    }
            //}



            //string StrBillClerck = "Customer Sign               BILL CLERCK";
            //// currentbalance = 0;
            ////OldBalance = 0;
            //string Visitagain;



            //RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
            //       LineAbowAmount +
            //      "\n" + "\n" + LineFooter;


            //frmsalesinvoice _Sales = new frmsalesinvoice();


            //_Sales.RichTextBox1.Text = RichTextBox1.Text;
            //// _Sales.SelectedPrinter = comPrint.Text;


           // _Thermal.PSelect = comPrint.Text;
            // _Laser.STax = STax;

            Clsinvlasershortsreport _short = new Clsinvlasershortsreport();

            ClsinvlaserSimple _lasersimple1= new ClsinvlaserSimple(); 
            if (ReportType == "OutstandingReportsummery")
            {
                _lasersimple1.FormType = ReportType;
                ClsinvlaserSimple.SelPrint = comprint.Text;
                _lasersimple1.PrintInvoice(GridMain);
            }

            ClsinvlaserSimpleTwo _lasersimple = new ClsinvlaserSimpleTwo();
            //_Thermal.FormType = this.Text;
            //_Thermal.PrintInvoice(GridMain);
            if (ReportType == "AccountReport")
            {
                ClsinvlaserSimpleTwo.SelPrint = comprint.Text;
                _lasersimple.FormType = ReportType;
                _lasersimple.Lid = CUSCODE;
                _lasersimple.Timeperiod = dateTimePickerfrom.Value.ToString() + "  to  " + dateTimePickerto.Value.ToString();
                //_lasersimple.SelPrint = comprint.Text;
                _lasersimple.DateStr = "Date: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _lasersimple.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                
                
                _lasersimple.PrintInvoice(GridMain);
            }
            if (ReportType == "Sales")
                {
                    ClsinvlaserSimpleTwo.SelPrint = comprint.Text;
                    _lasersimple.FormType = ReportType;
                    //_lasersimple.Lid = CUSCODE;
                    _lasersimple.Timeperiod = dateTimePickerfrom.Value.ToString() + "  to  " + dateTimePickerto.Value.ToString();


                    _lasersimple.Lid = ledonly;
                    _lasersimple.DateStr = "Date: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                    _lasersimple.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                    //_lasersimple.SelPrint = comprint.Text;
                _lasersimple.PrintInvoice(GridMain);

                }

            if (ReportType == "SalesDay")
            {
                Clsinvlasershortsreport.SelPrint = comprint.Text;
                _short.FormType = ReportType;
                //_lasersimple.Lid = CUSCODE;
                _short.Timeperiod = dateTimePickerfrom.Value.ToString() + "  to  " + dateTimePickerto.Value.ToString();

                _short.DateStr = "Date: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _short.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                //_lasersimple.SelPrint = comprint.Text;
                _short.PrintInvoice(GridMain);

            }

            if (ReportType == "Purchase")
            {
                ClsinvlaserSimpleTwo.SelPrint = comprint.Text;
                _lasersimple.FormType = ReportType;
                //_lasersimple.Lid = CUSCODE;
                _lasersimple.Timeperiod = dateTimePickerfrom.Value.ToString() + "  to  " + dateTimePickerto.Value.ToString();
                _lasersimple.Lid = ledonly;
                _lasersimple.DateStr = "Date: " + dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _lasersimple.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");

               // _lasersimple.SelPrint = comprint.Text;
                _lasersimple.PrintInvoice(GridMain);

            }


            else
            {
                if (ReportType != "AccountReport" &&ReportType != "GroupReportSummury"&& ReportType != "P&L Report" && ReportType != "Balancesheet" && ReportType != "Daybook" && ReportType != "Stock ValueBatchwise" && ReportType != "TrailBalance" && ReportType != "OutstandingReportsummery" && ReportType != "Payment and Receipt Report" && ReportType != "Sales" && ReportType != "SalesDay" && ReportType != "Receipt Report only" && ReportType != "Payment Report only")
                {

                    if (ReportType != "BillwisesettilementData" && ReportType != "BillwisesettilementPurchData" && ReportType != "BillwisesettilementSR" && ReportType != "BillwisesettilementPR")
                    {
                        _Thermal.FormType = this.Text;
                        _Thermal.PSelect = comprint.Text;
                        _Thermal.PrintInvoice(GridMain);
                    }
                }
                


            }




           // _Sales.IfPrintPreview = false;
           // _Sales.XX = 6;
           // _Sales.Selectedprint = "4";
           // _Sales.Printerselect = "9";
           // //_Sales.Printerselect = "4";
           // _Sales.vouchertypewholesalesother2();
           // _Sales.Printerselect = "4";
           //// _Sales.SelectedPrinter = _Sales.comPrint.Text;
           // _Sales.vouchertypewholesalesother();
        }

        //public void vouchertypewholesalesother2()
        //{
        //    try
        //    {
        //        if (_Sales.IfPrintPreview == true)
        //        {
        //            printPreviewDialog1.Document = printDocument1;
        //            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
        //            printPreviewDialog1.ShowDialog();
        //        }
        //        else
        //        {
        //            PrinterSettings();
        //            pd.Print();
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}




        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in GridMain.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in GridMain.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= GridMain.Rows.Count - 1)
                {

                    DataGridViewRow GridRow = GridMain.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            if (LblHeading.Text == "AccountReport")
                            {
                                e.Graphics.DrawString("Accounts Reports on "+lblheading2.Text+" date between '" + DTFrom.Date.ToString("dd/MM/yyyy") + " and '" + DTTo.Date.ToString("dd/MM/yyyy") + " ", new Font(GridMain.Font, FontStyle.Bold),
                                   Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                   e.Graphics.MeasureString(LblHeading.Text, new Font(GridMain.Font,
                                   FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            }
                            else
                            {
                                e.Graphics.DrawString(LblHeading.Text, new Font(GridMain.Font, FontStyle.Bold),
                                        Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                        e.Graphics.MeasureString(LblHeading.Text, new Font(GridMain.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                            }

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(GridMain.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(GridMain.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(LblHeading.Text, new Font(new Font(GridMain.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in GridMain.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {

                            k = k + 1;
                            if (k > 200)
                            {
                                //MessageBox.Show("Hello");
                            }
                            if (Cel.Value == null)
                            {
                                Cel.Value = "";
                            }
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                        (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            //}

                            //Drawing Cells Borders 
                            if (Removeborder == false)
                            {
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));
                            }

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void cmdexcel_Click(object sender, EventArgs e)
        {
            if (GridMain.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = GridMain.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[GridMain.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += GridMain.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < GridMain.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    if (GridMain.Rows[i - 1].Cells[j].Value != null)
                                    {
                                        outputCsv[i] += GridMain.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }  

            //Exporttoexcel(GridMain);
            //RichTextBox Rch = new RichTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Showprinting();
        }

        private void cmdsettcolumns_Click(object sender, EventArgs e)
        {
            ShowSettingsPanle();
        }
        public void ShowSettingsPanle()
        {
            pnlsettings.Visible = true;
        }

        private void Cmdrefresh_Click(object sender, EventArgs e)
        {
            RefreshFu();
        }
        public void RefreshFu()
                {
            DTFrom = dateTimePickerfrom.Value;
            DTTo = dateTimePickerto.Value;
            Mainload();
        }
        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePickerfrom_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                dateTimePickerto.Focus();
            }
        }

        private void dateTimePickerto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                RefreshFu();
            }
        }
        public void Showattendence(string Svno)
        {
            Frmattendence _Atte = new Frmattendence();
            _Atte.Isinotherwindow = true;
            _Atte.Vno =Convert.ToInt64(Svno);

            _Atte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            _Atte.Location = new Point(0, 0);
            _Atte.MdiParent = this.ParentForm;
            _Atte.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
            _Atte.Show();
        }

        public void Showpurchase(string PVtype,string VnoCode,string Vno,string PAccount)
        {
            Frmpurchase _Purchase = new Frmpurchase();
            _Purchase.Vtype = PVtype;
            _Purchase.txtvno.Tag = VnoCode;
            _Purchase.txtvno.Text = Vno;
            _Purchase.PurchaseAccount = PAccount;

            _Purchase.Isinotherwindow = true;
            if (PVtype == "PR")
            {
                _Purchase.Heading = "Purchase Return";
            }
            else
            {
                _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", PAccount) + " Invoice";
            }
            _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
            _Purchase.Location = new Point(0, 0);
            _Purchase.MdiParent = this.ParentForm;
            _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
            _Purchase.Show();
        }
        
        public void ShowStockTransfer(long Tcode)
        {
            FrmStockTRansfer _StockTransfer = new FrmStockTRansfer();
            _StockTransfer.Temvno = Tcode;
            _StockTransfer.Isinother = true;
            _StockTransfer.Show();
        }

        public void ShowsalesInvoice(string PVtype, string VnoCode, string Vno, string PAccount)
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.Vtype = PVtype;
            _Sales.txtvno.Tag = VnoCode;
            _Sales.txtvno.Text = Vno;
            FrmReport.ClickCode = VnoCode;

            _Sales.Isinotherwindow = true;
            if (PVtype == "SR")
            {
                _Sales.Heading = "Sales Return";
            }
            else if (PVtype == "SO" || PVtype == "SQ")
            {
                _Sales.Heading = LblHeading.Text;
            }
            
            else
            {
                _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", PAccount) + " Invoice";
            }
                if (PVtype == "SV")
            {
                _Sales.Heading = "Services";
            }
            _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
            _Sales.Location = new Point(0, 0);
            _Sales.MdiParent = this.ParentForm;
            _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
            _Sales.Show();
        }
        public void ShowDebitNote()
        {
            Frmcash _Cash = new Frmcash();
            _Cash.Vtype = "DBN";
            Frmcash.Isinotherwindow = true;
            _Cash.txtvno.Text = Vno;
            _Cash.mode = 2;
            Frmcash.Isinotherwindow = true;
            _Cash.Show();
            }
       
        public void ShowCashreceipt(string vtype)
        {
            Frmcash _Cash = new Frmcash();
            _Cash.Vtype = vtype;
            Frmcash.Isinotherwindow = true;
            _Cash.txtvno.Text = Vno;

            if (vtype == "P")
            {
                _Cash.mode = 0;
            }
            if (vtype == "JNR")
            {
                _Cash.mode = 4;
            }

            
            Frmcash.Isinotherwindow = true;
            _Cash.Show();
        }
        public void ShowCashpayment(string vtype)
        {
            Frmcash _Cash = new Frmcash();
         
            _Cash.Vtype = vtype;
            _Cash.txtvno.Text = Vno;

            if (vtype == "P")
            {
                _Cash.mode = 1;
            }
            if (vtype == "JNP")
            {
                _Cash.mode = 5;
            }
           
           

            
            Frmcash.Isinotherwindow = true;
            _Cash.Show();
        }
        public void Showdailyexpence(string vtype)
        {
            Frmdailyexpence _Cash = new Frmdailyexpence();
            Frmdailyexpence.Isinotherwindow = true;
            _Cash.Vtype = vtype;
            _Cash.txtvno.Text = Vno;
            _Cash.mode = 1;
            Frmdailyexpence.Isinotherwindow = true;
            _Cash.Show();
        }
        public void ShowCreditNote()
        {
            Frmcash _Cash = new Frmcash();
            Frmcash.Isinotherwindow = true;
            _Cash.Vtype = "CRN";
            _Cash.txtvno.Text = Vno;
            _Cash.mode = 3;
            Frmcash.Isinotherwindow = true;
            _Cash.Show();
        }
        public void ShowReport()
        {
            ////FrmReport  CommonClass._Clreport = new FrmReport();
            //if ( CommonClass._Clreport.IsDisposed == true)
            //{
            //     CommonClass._Clreport = new FrmReport();
            //    // NextgInitialize();
            //     CommonClass._Clreport.Show();
            //}
            //else
            //{

            //    // NextgInitialize();
            //     CommonClass._Clreport.Show();
            //}
        }
        public void ShowReportSalesReportsummery()
        {

            //FrmReport  CommonClass._Clreport = new FrmReport();
            Query = "select * from tblbusinessissue where issuetype='SI' ";
            ReportType = "Sales";

            DTFrom = Convert.ToDateTime(dateTimePickerfrom.Value.ToString("dd/MMM/yyyy"));
            DTTo = Convert.ToDateTime(dateTimePickerto.Value.ToString("dd/MMM/yyyy"));
            ShowReport();
        }

        public void ShowReportMain(DateTime PDtfrom, DateTime PDtto, string Prtype, string PRquery, string PRquerytemp, string PRQueryDetail, string PRTypeSecond)
        {
            CommonClass._report.DTFrom = PDtfrom;
            CommonClass._report.DTTo = PDtto;

            Clsselectreport.RType = Prtype;
            Clsselectreport.RQuery = PRquery;
            Clsselectreport.RQueryTemp = PRquerytemp;
            Clsselectreport.RQueryDetail = PRQueryDetail;
            Clsselectreport.RDtfrom = PDtfrom;
            Clsselectreport.Rdtto = PDtto;
            Clsselectreport.RTypeSecond = PRTypeSecond;
            CommonClass._Clreport.ShowReport(this, true);

        }


        public void DrillDown()
                                                    {

            ReportType = LblHeading.Text;

            if (LblHeading.Text == "Dress Details")
            {
                FrmDesigning _desgn = new FrmDesigning();

                SelectedRow = GridMain.SelectedCells[0].RowIndex;
                _desgn.txtvno.Text = Convert.ToInt64(GridMain.Rows[SelectedRow].Cells["clnvno"].Value).ToString();
                _desgn.EditMode = true;
                _desgn.Isinotherwindow = true;
                _desgn.ShowDialog();

            }
            if (LblHeading.Text == "BillwisesettilementData")
            {
                SelectedRow = GridMain.SelectedCells[0].RowIndex;
                ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();

                FrmReport.MainAccount = "2";
             FrmReport.ClickCode=Vno;
                
                //MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                ShowsalesInvoice("SI", ClickCode, Vno, "2");
            }
            if (LblHeading.Text == "BillwisesettilementSR")
            {
                SelectedRow = GridMain.SelectedCells[0].RowIndex;

                ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();

                FrmReport.MainAccount = "2";
                FrmReport.ClickCode = Vno;
                
                //MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                ShowsalesInvoice("SR", ClickCode, Vno, "2");
            }
            if (LblHeading.Text == "BillwisesettilementPurchData")
            {
                SelectedRow = GridMain.SelectedCells[0].RowIndex;
                ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();


                FrmReport.MainAccount = "3";
                FrmReport.ClickCode = Vno;
                //MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                Showpurchase("PI", ClickCode, Vno, "3");

            }
            if (LblHeading.Text == "BillwisesettilementPR")
            {
                SelectedRow = GridMain.SelectedCells[0].RowIndex;
                ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                FrmReport.MainAccount = "3";
                FrmReport.ClickCode = Vno;
                
                //MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                Showpurchase("PR", ClickCode, Vno,"3");

            }

            if (LblHeading.Text == "Productionanddetails")
            {

                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    SelectedColumnname = GridMain.SelectedCells[0].OwningColumn.Name.ToString();
                    if (GridMain.Rows[SelectedRow].Cells["clnvno"].Value != null)
                    {
                        Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                        FrmRepacking _Form = new FrmRepacking();
                        _Form.EditMode = true;
                        _Form.IsEnter = true;
                        _Form.vno = Vno;
                        _Form.ShowDialog();
                    
                    
                    
                    
                    }
                }

            }




            if (LblHeading.Text == "P&L Report")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    SelectedColumnname = GridMain.SelectedCells[0].OwningColumn.Name.ToString();
                    if(GridMain.Rows[SelectedRow].Cells[SelectedColumnname].Tag !=null)
                    {
                        Vno = GridMain.Rows[SelectedRow].Cells[SelectedColumnname].Tag.ToString();

                        if ( Vno== "Opening Stock"||Vno=="Closing Stock")
                        {
                            CommonClass.temp = "select itemid from tblitemmaster ";
                            ClsReports.Query = " having IMS.ItemId in(" + CommonClass.temp + ")  ";
                            ClsReports.ReportType = "Stock Value";
                            FrmReport.Secondcondition = "Prate";

                            if (Vno == "Opening Stock")
                            {
                                ClsReports.DTFrom = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
                                ClsReports.DTTo = Convert.ToDateTime(dateTimePickerfrom.Value).AddDays(-1);
                            }
                            else
                            {
                                ClsReports.DTFrom = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
                                ClsReports.DTTo = DTTo;
                            }
                        }
                        if (Vno == "12"||Vno=="13"||Vno=="15"||Vno=="16")
                        {
                            ClsReports.QueryTemp = "select * from tblaccountledger where agroupid in(" + Vno + ") or " +
                           " agroupid in (select agroupid from tblaccountgroup where aunder='" + Vno + "' ) order by lname asc";

                           ClsReports.ReportType = "GroupReportSummury";
                           ClsReports.Query = "where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where " +
                           " agroupid in (" + Vno + ") or aunder in (" + Vno + "))";

                            ClsReports.DTFrom = DTFrom;
                            ClsReports.DTTo = DTTo;
                        }
                   
                        Clsforms _Forms = new Clsforms();
                        ShowReportMain(ClsReports.DTFrom, ClsReports.DTTo, ClsReports.ReportType, ClsReports.Query, ClsReports.QueryTemp, "", "");
                    }
                }
            }

            if (LblHeading.Text == "Stock Transfer Summury")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Cells["VNO"].Value != null)
                    {
                        ShowStockTransfer(Convert.ToInt64(GridMain.Rows[SelectedRow].Cells["VNO"].Value));
                    }
                }
            }

            if (LblHeading.Text == "TrailBalance")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag !=null)
                    {
                        ReportType = "";
                        Vno = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();/*For Declare To Ledger Code*/
                        ClsReports.ReportType = "GroupReportSummury";
                        ClsReports.Query = "where TblAccountLedger.AGroupId in (" + Vno + ")";
                        ClsReports.DTFrom = Convert.ToDateTime(dateTimePickerfrom.Value);
                        ClsReports.DTTo = Convert.ToDateTime(dateTimePickerto.Value);
                        Clsforms _Forms = new Clsforms();
                        ShowReportMain(DTFrom, DTTo, ClsReports.ReportType, ClsReports.Query,"","","");
                    }
                }
            }

            if (LblHeading.Text == "Balancesheet")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Tag != null)
                    {
                        ReportType = "";
                        Vno = GridMain.Rows[SelectedRow].Tag.ToString();/*For Declare To Ledger Code*/
                        if (Vno == "P&L")
                        {
                            ClsReports.ReportType = "P&L Report";
                        }
                        else
                        {
                            ClsReports.ReportType = "GroupReportSummury";
                        }
                        
                        ClsReports.Query = "where TblAccountLedger.AGroupId in (" + Vno + ")";
                        ClsReports.DTFrom = Convert.ToDateTime(dateTimePickerfrom.Value);
                        ClsReports.DTTo = Convert.ToDateTime(dateTimePickerto.Value);
                        Clsforms _Forms = new Clsforms();
                        ShowReportMain(DTFrom, DTTo, ClsReports.ReportType, ClsReports.Query, "", "", "");
                    }
                }
            }

            if (LblHeading.Text == "GroupReportSummury"||LblHeading.Text=="OutstandingReportsummery")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Tag != null)
                    {
                        ReportType = "";
                        Vno = GridMain.Rows[SelectedRow].Tag.ToString();/*For Declare To Ledger Code*/
                        ClsReports.Query = "select * from tblgeneralledger   where ledcode='" + Vno + "' ";
                        ClsReports.QueryTemp = "select * from tblaccountledger where lid='" + Vno + "'  ";
                        ClsReports.ReportType = "AccountReport";
                        ClsReports.DTFrom = Convert.ToDateTime(dateTimePickerfrom.Value);
                        ClsReports.DTTo = Convert.ToDateTime(dateTimePickerto.Value);
                        Clsforms _Forms = new Clsforms();
                        ShowReportMain(DTFrom, DTTo, ClsReports.ReportType, ClsReports.Query, ClsReports.QueryTemp, "", "");
                    }
                }
            }
            if (LblHeading.Text == "Daybook")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    ReportType = "";
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Cells["clnvtype"].Value != null)
                    {
                        string Vtype = GridMain.Rows[SelectedRow].Cells["clnvtype"].Value.ToString();
                        if (Vtype == "Purchase")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            Showpurchase("PI", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Sales")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            ShowsalesInvoice("SI", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Purchase return")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            Showpurchase("PR", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Sales return")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            ShowsalesInvoice("SR", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Purchase Order")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            Showpurchase("PO", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Sales Order")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnvtype"].Tag.ToString();
                            ShowsalesInvoice("SO", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Payment")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("P");
                        }
                        if (Vtype == "CNR")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("CNR");
                        }
                        if (Vtype == "Receipt")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashreceipt("R");
                        }
                        if (Vtype == "Debit Note")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowDebitNote();
                        }
                        if (Vtype == "Credit Note")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCreditNote();
                        }
                        if (Vtype == "Journel payment")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("JNP");
                        }
                        if (Vtype == "Journel Receipt")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashreceipt("JNR");
                        }
                    }
                }
            }

            if (LblHeading.Text == "Payment and Receipt Report")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    ReportType = GridMain.SelectedCells[0].ColumnIndex.ToString();
                    //ReportType = GridMain.Columns[ReportType].Name.ToString();
                    if (GridMain.Rows[SelectedRow].Cells[GridMain.SelectedCells[0].ColumnIndex].Value != null)
                    {
                        string Vtype = GridMain.Columns[GridMain.SelectedCells[0].ColumnIndex].Name.ToString();
                        if (Vtype == "clnrvno")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnrvno"].Value.ToString();
                            ShowCashpayment("R");
                        }
                        if (Vtype == "clnpvno")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnpvno"].Value.ToString();
                            ShowCashpayment("P");
                        }
                    }
                }
            }

            if (LblHeading.Text == "AccountReport")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    //ReportType = "";
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (GridMain.Rows[SelectedRow].Cells["clnvtype"].Value != null)
                    {
                        string Vtype = GridMain.Rows[SelectedRow].Cells["clnvtype"].Value.ToString();
                        if (Vtype == "Debit Note")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowDebitNote();
                        }
                        if (Vtype == "Credit Note")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCreditNote();
                        }
                        if (Vtype == "Receipt")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashreceipt("R");
                        }
                        if (Vtype == "Receipt")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashreceipt("R");
                        }

                        //if (Vtype == "Credit Note")
                        //{
                        //    Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                        //    ShowCashpayment("CRN");
                        //    ShowCreditNote();
                        //}
                        if (Vtype == "Payment")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("P");
                        }

                        if (Vtype == "Daily expence")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("P");
                        }

                        if (Vtype == "Journel payment")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashpayment("JNP");
                        }
                        if (Vtype == "Journel Receipt")
                        {
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            ShowCashreceipt("JNR");
                        }
                        if (Vtype == "Sales"||Vtype=="SV")
                        {
                            //SelectedRow = GridMain.SelectedCells[0].RowIndex;
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            if(Vtype=="Sales")
                            ShowsalesInvoice("SI", ClickCode, Vno,MainAccount);
                            if(Vtype=="SV")
                            ShowsalesInvoice("SV", ClickCode, Vno, MainAccount);
                            }
                        if (Vtype == "Purchase")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount= GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            Showpurchase("PI", ClickCode, Vno,MainAccount);
                        }
                        if (Vtype == "Sales return")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            ShowsalesInvoice("SR", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Purchase return")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            Showpurchase("PR", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Sales Order")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            ShowsalesInvoice("SO", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "Purchase Order")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clndate"].Tag.ToString();
                            Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();
                            MainAccount = GridMain.Rows[SelectedRow].Cells["clnpurticulars"].Tag.ToString();
                            Showpurchase("PO", ClickCode, Vno, MainAccount);
                        }
                        if (Vtype == "At")
                        {
                            ClickCode = GridMain.Rows[SelectedRow].Cells["clnvno"].Value.ToString();

                            Showattendence(ClickCode);
                        }

                    }
                }
            }


            if (LblHeading.Text == "Sales" || LblHeading.Text == "Sales Order" || LblHeading.Text == "Sales Quatation" || LblHeading.Text=="Services" || LblHeading.Text == "Purchase Return")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    ClickCode = GridMain.Rows[SelectedRow].Cells["IssueCode"].Value.ToString();
                    Vno = GridMain.Rows[SelectedRow].Cells["vno"].Value.ToString();
                    MainAccount = GridMain.Rows[SelectedRow].Cells["mainaccount"].Value.ToString();
                    if (LblHeading.Text == "Sales")
                    {
                        ShowsalesInvoice("SI", ClickCode, Vno, MainAccount);
                    }
                    if (LblHeading.Text == "Services")
                    {
                        ShowsalesInvoice("SV", ClickCode, Vno, MainAccount);
                    }
                    if (LblHeading.Text == "Sales Order")
                    {
                        ShowsalesInvoice("SO", ClickCode, Vno, MainAccount);
                    }
                    if (LblHeading.Text == "Sales Quatation")
                    {
                        ShowsalesInvoice("SQ", ClickCode, Vno, MainAccount);
                    }
                    if (LblHeading.Text == "Purchase Return")
                    {
                        Showpurchase("PR", ClickCode, Vno, MainAccount);
                    }

                }
            }
          if (LblHeading.Text == "Purchase" || LblHeading.Text == "Purchase Order" || LblHeading.Text == "Sales return")
          {
              if (GridMain.SelectedCells.Count > 0)
              {
                  
                        SelectedRow = GridMain.SelectedCells[0].RowIndex;
                      ClickCode = GridMain.Rows[SelectedRow].Cells["ReptCode"].Value.ToString();
                      Vno = GridMain.Rows[SelectedRow].Cells["VNo"].Value.ToString();
                      MainAccount = GridMain.Rows[SelectedRow].Cells["MainAccount"].Value.ToString();
                      if (LblHeading.Text == "Purchase")
                      {
                          Showpurchase("PI", ClickCode, Vno, MainAccount);
                      }
                      if (LblHeading.Text == "Purchase Order")
                      {
                          Showpurchase("PO", ClickCode, Vno, MainAccount);
                      }
                      if (LblHeading.Text == "Purchase Order")
                      {
                          Showpurchase("PO", ClickCode, Vno, MainAccount);
                      }
                      if (LblHeading.Text == "Sales return")
                      {
                          ShowsalesInvoice("SR", ClickCode, Vno, MainAccount);
                      }
                  
              }
          }
            if (LblHeading.Text == "Salesdaybook")
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    SelectedRow = GridMain.SelectedCells[0].RowIndex;
                    ClickCode = GridMain.Rows[SelectedRow].Cells["clnqty"].Tag.ToString();
                    Vno = GridMain.Rows[SelectedRow].Cells["clnvno"].Tag.ToString();
                    MainAccount = GridMain.Rows[SelectedRow].Cells["clnrate"].Tag.ToString();
                    ShowsalesInvoice("SI", ClickCode, Vno, MainAccount);
                }
            }
            if (LblHeading.Text == "QplexP&L")
            {
                SelectedRow = GridMain.SelectedCells[0].RowIndex;
                ClickCode = GridMain.Rows[SelectedRow].Tag.ToString();
                if (ClickCode == "Sales")
                {
                    ShowReportSalesReportsummery();
                }
            }
        }
        private void GridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DrillDown();
        }

       
        private void chkremoveborder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkremoveborder.Checked == true)
                Removeborder = true;
            else
                Removeborder = false;
        }

         public double Nettprofit(DateTime Pdtfrom,DateTime Pdtto)
                {
                    DataGridView Grid = new DataGridView();

                    Grid.Rows.Clear();
                    Grid.Columns.Clear();

                    /*Column Add */

                    Grid.Columns.Add("ClncPurticulars", "Particulars");
                    Grid.Columns["ClncPurticulars"].Width = 350;

                    Grid.Columns.Add("ClncAmount", "Credit");
                    CommonClass._Clreport.Qtycolumnsettings(Grid, "clncamount", 150);

                    Grid.Columns.Add("ClnDPurticulars", "Particulars");
                    CommonClass._Clreport.Qtycolumnsettings(Grid, "clndpurticulars", 350);

                    Grid.Columns.Add("ClnDbAmount", "Debit");
                    CommonClass._Clreport.Qtycolumnsettings(Grid, "clndbamount", 150);


                    CommonClass._Clreport.TDirectIncome = 0;
                    CommonClass._Clreport.TIncome = 0;
                    CommonClass._Clreport.TDirectExpence = 0;
                    CommonClass._Clreport.TExpence = 0;
                    CommonClass._Clreport.TIndirectIncome = 0;
                    CommonClass._Clreport.TIndirectExpence = 0;

                    DTFrom = Pdtfrom;
                    DTTo = Pdtto;


                    /*For Opening Stock*/
                    CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Opening Stock";
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Tag = "Opening Stock";
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom.AddYears(-50), DTFrom.AddDays(-1));
                    CommonClass._Clreport.TDirectExpence = CommonClass._Inventory.DbStockvalue("", "Prate", DTFrom.AddYears(-50), DTFrom.AddDays(-1));
                    /*************************************************************************/

                    CommonClass._Clreport.ProfitandLossAccountFilling("12", Grid, "EXPENCE", DTFrom, DTTo, "12"); /*Direct Expence*/
                    CommonClass._Clreport.ProfitandLossAccountFilling("13", Grid, "INCOME", DTFrom, DTTo, "13");/*Direct Income*/

                    /*For Closing Stock*/
                    CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Closing Stock";
                    double ClosingStock;
                    ClosingStock = CommonClass._Inventory.DbStockvalue("", "Prate", Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()), DTTo);
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["clndbamount"].Value = ClosingStock;
                    Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["clndbamount"].Tag = "Closing Stock";
                    CommonClass._Clreport.ProfitAndLossGroupBalance("13", ClosingStock);

                    /*************************************************************************/

                    /********************/
                    double Gross = new double();
                    double GrossTotal;
                    if (CommonClass._Clreport.TDirectIncome < CommonClass._Clreport.TDirectExpence)
                    {

                        /*For Gross Loss*/
                        Gross = CommonClass._Clreport.TDirectExpence - CommonClass._Clreport.TDirectIncome;
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Gross Loss";
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TDirectExpence;
                    }
                    else if (CommonClass._Clreport.TDirectExpence < CommonClass._Clreport.TDirectIncome)
                    {
                        /*For Gross Profit*/
                        Gross = CommonClass._Clreport.TDirectIncome - CommonClass._Clreport.TDirectExpence;
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Gross Profit";
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TDirectIncome;
                    }
                    else
                    {
                        GrossTotal = CommonClass._Clreport.TDirectIncome;
                    }
                    /*********************/
                    CommonClass._Clreport.ForProfitandLossAccountTotal(Grid, CommonClass._Clreport.RowCountingLiabilty, GrossTotal);
                    /*****************************/
                    if (CommonClass._Clreport.TDirectIncome < CommonClass._Clreport.TDirectExpence)
                    {
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Gross Loss";
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clncamount"].Value = Gross;
                        CommonClass._Clreport.TExpence = CommonClass._Clreport.TExpence + Gross;
                        CommonClass._Clreport.TIndirectExpence = CommonClass._Clreport.TIndirectExpence + Gross;
                    }
                    else if (CommonClass._Clreport.TDirectExpence < CommonClass._Clreport.TDirectIncome)
                    {
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Gross Profit";
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        CommonClass._Clreport.TIncome = CommonClass._Clreport.TIncome + Gross;
                        CommonClass._Clreport.TIndirectIncome = CommonClass._Clreport.TIndirectIncome + Gross;
                        //  CommonClass._Clreport.TIndirectExpence = CommonClass._Clreport.TIndirectExpence + Gross;
                    }
                    /****************************/
                    CommonClass._Clreport.ProfitandLossAccountFilling("15", Grid, "EXPENCE", DTFrom, DTTo, "15"); /*Indirect Expence*/
                    CommonClass._Clreport.ProfitandLossAccountFilling("16", Grid, "INCOME", DTFrom, DTTo, "16");/*Indirect Income*/
                    /**********************************/


                    if (CommonClass._Clreport.TIndirectIncome < CommonClass._Clreport.TIndirectExpence)
                    {
                        /*For Gross Loss*/
                        Gross = CommonClass._Clreport.TIndirectIncome - CommonClass._Clreport.TIndirectExpence;
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClndPurticulars"].Value = "Net Loss";
                        Gross =CommonClass._Clreport.TIndirectIncome- CommonClass._Clreport.TIndirectExpence ;
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["Clndbamount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TIndirectExpence;
                    }
                    else if (CommonClass._Clreport.TIndirectExpence < CommonClass._Clreport.TIndirectIncome)
                    {
                        /*For Gross Profit*/
                        Gross = CommonClass._Clreport.TIndirectIncome - CommonClass._Clreport.TIndirectExpence;
                        CommonClass._Clreport.RowCountingLiabilty = Grid.Rows.Add(1);
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncPurticulars"].Value = "Net Profit";
                        Grid.Rows[CommonClass._Clreport.RowCountingLiabilty].Cells["ClncAmount"].Value = Gross;
                        GrossTotal = CommonClass._Clreport.TIndirectIncome;
                    }
                    return Gross;
                    //CommonClass._Clreport.ForProfitandLossAccountTotal(GridMain, CommonClass._Clreport.RowCountingLiabilty, GrossTotal);
                }

        private void GridMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (GridMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void cmdclosepanel_Click(object sender, EventArgs e)
        {
            pnlsettings.Visible = false;
        }

        private void cmdexcelimp_Click(object sender, EventArgs e)
        {
            ExporttoexcelImport();
        }

        private void CMD_THERMAL_Click(object sender, EventArgs e)
        {

            mainReportPrint();
        }


        public void mainReportPrint() 
        {
            if (ReportType == "Sales")
            {
                ClsIsalesReportThermal.SelPrint = comprint.Text;
                _salereportTH.FormType = ReportType;
                _salereportTH.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _salereportTH.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");

               
                _salereportTH.PrintInvoice(GridMain);
            }

            if (ReportType == "Purchase")
            {

                ClspurchaseReportThermal.SelPrint = comprint.Text;
                    _purchreportTh.FormType = ReportType;
                    _purchreportTh.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                    _purchreportTh.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                   
                
                _purchreportTh.PrintInvoice(GridMain);

                

            }

            if (ReportType == "AccountReport")
            {

                
                _ThermalReport.FormType = "Account Report";
                // _ThermalReport.TempCust = Lid;
                _ThermalReport.TEmpparty = partycode;
                _ThermalReport.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _ThermalReport.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _ThermalReport.PSelect = comprint.Text;
                _ThermalReport.PrintInvoice(GridMain);
            }


            if (ReportType == "Stock ValueBatchwise")
            {
                clsstockreportthemal.SelPrint = comprint.Text;
                _stockReport.FormType = "StockReport";
                _stockReport.DateStr = dateTimePickerfrom.Value.ToString("dd/MM/yyyy") + " To " + dateTimePickerto.Value.ToString(" dd/MM/yyyy");
                _stockReport.TimeStr = "Time: " + dateTimePickerfrom.Value.ToString("hh:mm:ss") + " To " + dateTimePickerto.Value.ToString("hh:mm:ss");
                _stockReport.SUmqty = 0;
                _stockReport.SUmNetAmt = 0;
                
                _stockReport.PrintInvoice(GridMain);
            }

            if (ReportType == "SalesDay")
            {

                _Thermal.FormType = this.Text;
                _Thermal.PSelect = comprint.Text;
                _Thermal.PrintInvoice(GridMain);
            }

        }
        
    }
}
