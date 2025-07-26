using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class CommonClass
    {
     public static  PictureBox TestPic = new PictureBox();

     public static ClsLanguage _Language = new ClsLanguage();
      public static int EditMode;
      public static int RowCount;
      public static double DBtemp;
      public static string temp;
      public static string temp1;
      public static DateTime Dttemp;
      public static string Sql;



        public static Clssecondphase _SecondPhaseTran = new Clssecondphase();
        public static ClsPHASEtwocompanyprofile _phase = new ClsPHASEtwocompanyprofile();
        public static ClsOtherprintset _otherPrint = new ClsOtherprintset();
      public static Clscolor _colors = new Clscolor();
      public static ClsBaseunit _base = new ClsBaseunit();
      public static ClsChequeAgainstBill _ChequeAgainstBill = new ClsChequeAgainstBill();
      public static Clsiconset _iconset = new Clsiconset();
      public static ClsCompanyMaster _compMaster = new ClsCompanyMaster();
      public static NextGFuntion _Nextg = new NextGFuntion();
      public static Generalfunction _Gen = new Generalfunction();
      public static ClsPurchaseBillSett _PurchaseBillSett = new ClsPurchaseBillSett();
      public static DBTask _Dbtask = new DBTask();
      public static ClsUserDetails _UserDetails = new ClsUserDetails();
      public static ClsAccountLedger _Ledger = new ClsAccountLedger();
      public static ClsParamlist _Paramlist = new ClsParamlist();
      public static ClsInventory _Inventory = new ClsInventory();
      public static ClsItemMaster _Itemmaster = new ClsItemMaster();
      public static Clsitemmastersimple _Itemmastersimple = new Clsitemmastersimple();
      public static clsitemCategory _ItemCategory = new clsitemCategory();
      public static ClsproductRate _ProductRate = new ClsproductRate();
      public static Clsforms _Forms = new Clsforms();
      public static ClsInGrid _Ingrid = new ClsInGrid();
      public static Clsselectreport _SelectReport = new Clsselectreport();
      public static Clstempcontact _tempcontacts = new Clstempcontact();
      public static Clswarnings _Warnings = new Clswarnings();
      public static Clscommenevent _commenevent = new Clscommenevent();
      public static Clsbatch _Batch = new Clsbatch();
      public static FrmSelectSalesReport _slctsalerprt = new FrmSelectSalesReport();

      public static Frmphysical _physical = new Frmphysical();




      public static clsitemCategory _category = new clsitemCategory();
      public static EditingShow _Edit = new EditingShow();
      public static Clsauditlog _auditlog = new Clsauditlog();
      public static ClsGeneralLedger _GenLedger = new ClsGeneralLedger();
      public static ClsReceiptDetails _ReceiptDetails = new ClsReceiptDetails();
      public static ClsTransactionRceipt _Transactionreceipt = new ClsTransactionRceipt();
      public static ClsCompanyCreate _ComCreate = new ClsCompanyCreate();
      public static ClsBusinessIssue _Businessissue = new ClsBusinessIssue();
      public static ClsIssueDetails _IssueDetails = new ClsIssueDetails();
      public static Clsguest _Clsguest = new Clsguest();
      public static Clsunitsrates _Unitsrates = new Clsunitsrates();
      //public static FormOp _Formop = new FormOp();
      public static Clsop _OP = new Clsop();
      public static Clsopdetails _Opdetails = new Clsopdetails();
      public static ClsDepartment _Department = new ClsDepartment();
      public static Clssettings _settings = new Clssettings();
      public static  ClsReports _Clreport = new ClsReports();
      public static ClsDepot _Depot = new ClsDepot();
      public static ClsInGrid _grid = new ClsInGrid();
      public static Clssms _Sms = new Clssms();
      public static MDIParent2 _Md2 = new MDIParent2();
      public static Frmusercontroles _Usercontroles = new Frmusercontroles();
      public static Generalfunction _GenF = new Generalfunction();
      public static ClsItemMaster _Item = new ClsItemMaster();
      public static Frmpurchase _Purchase = new Frmpurchase();
      public static frmsalesinvoice _Sales = new frmsalesinvoice();
      public static Clspurchase _ClPurchase = new Clspurchase();
      public static Clssales _ClSales = new Clssales();
      public static Clsmenus _menus = new Clsmenus();
      public static ClsAccountGroup _AccountGroup = new ClsAccountGroup();
      public static ClsCompanyCreate _CompanyCreate = new ClsCompanyCreate();
      public static ClsManufacturer _Manufacturer = new ClsManufacturer();
      public static clsmnusettings _Menusettings = new clsmnusettings();
      public static Clsregistration _Registration = new Clsregistration();
      public static Clsregdetails _RegDetails = new Clsregdetails();
      public static Clscheque _ClsCheque = new Clscheque();
      public static ClspriceCode _Clspricecode = new ClspriceCode();
      public static Clspartyproject _Partyproject = new Clspartyproject();
      public static Clsremainder _Remainder = new Clsremainder();
      public static ClsUnitcreation _Unitcreation = new ClsUnitcreation();
      public static Clsbillsett _BillSett = new Clsbillsett();
      public static Clspurchasebillset _purbill = new Clspurchasebillset();
      public static Clssalereturnbillset _SRbill = new Clssalereturnbillset();
      public static ClsbillsettPR _PRbill = new ClsbillsettPR();



      public static ClsEmployeeMaster _Employee = new ClsEmployeeMaster();
      public static Clsattendancemain _attendence = new Clsattendancemain();
      public static Clsattendancedetail _attendencedetail = new Clsattendancedetail();
      public static Clsslno _Slno = new Clsslno();
      public static Clsdressmaster _dress = new Clsdressmaster();
      public static Clscommision _commision = new Clscommision();
      public static Clsdiscount _Discount = new Clsdiscount();
      public static Clsarea _Area = new Clsarea();
      public static string SRmode;/*For Using Report Detail and Summury*/
      public static Clsregistration _Reg = new Clsregistration();
      public static Frmquickadditems _additem = new Frmquickadditems();


      public static Clsfeedback _feed = new Clsfeedback();
      //public static ClsPaymentMethod _PayMethode = new ClsPaymentMethod();

      public static FrmReport  _report = new FrmReport();
      public static Frmreport2 _report2 = new Frmreport2();

      public static DataSet Ds;
      public static DataSet Ds1;
      public static DataSet Ds2;
      public static DataSet Ds3;
      public static DataSet Ds4;

      public static string CashDesk="";
      public  string CashDeskDiscount = "";
      public static bool CashDeskValidate;
      public static bool ETailering;


      string[] StrTables = new string[50];
       //StrTables[
   
    }
}
