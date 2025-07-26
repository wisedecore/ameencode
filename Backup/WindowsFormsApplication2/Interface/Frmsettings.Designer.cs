namespace WindowsFormsApplication2
{
    partial class Frmsettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Create");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sales");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Purchase");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Voucher Type");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Default Settings");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Warnings");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Printer Settings");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Auto Backup");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Show startup");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("BarcodeSettings");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("OtherPrintset");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsettings));
            this.TRMain = new System.Windows.Forms.TreeView();
            this.lblheading = new System.Windows.Forms.Label();
            this.Pnlcreate = new System.Windows.Forms.Panel();
            this.chkbaseunit = new System.Windows.Forms.CheckBox();
            this.chktailoring = new System.Windows.Forms.CheckBox();
            this.chkzerotaxamount = new System.Windows.Forms.CheckBox();
            this.chkshowestimateledger = new System.Windows.Forms.CheckBox();
            this.Grpsetestimatepassword = new System.Windows.Forms.GroupBox();
            this.cmdsett = new System.Windows.Forms.Button();
            this.Chksupplierwiseitem = new System.Windows.Forms.CheckBox();
            this.chkenpharmacy = new System.Windows.Forms.CheckBox();
            this.chkweightmachine = new System.Windows.Forms.CheckBox();
            this.chkslnotracking = new System.Windows.Forms.CheckBox();
            this.chkcrm = new System.Windows.Forms.CheckBox();
            this.lblsmsbalance = new System.Windows.Forms.Label();
            this.txtsmsbalance = new System.Windows.Forms.TextBox();
            this.GrpItemSearch = new System.Windows.Forms.GroupBox();
            this.raditemanykeysearch = new System.Windows.Forms.RadioButton();
            this.Raditemlastkeysearch = new System.Windows.Forms.RadioButton();
            this.Raditemfirstsearch = new System.Windows.Forms.RadioButton();
            this.chkcustomerpoint = new System.Windows.Forms.CheckBox();
            this.chkflex = new System.Windows.Forms.CheckBox();
            this.Chkesize = new System.Windows.Forms.CheckBox();
            this.Chkecostcenter = new System.Windows.Forms.CheckBox();
            this.ChkEProduction = new System.Windows.Forms.CheckBox();
            this.chketax = new System.Windows.Forms.CheckBox();
            this.ChkEstockarea = new System.Windows.Forms.CheckBox();
            this.Chkmultiunit = new System.Windows.Forms.CheckBox();
            this.ChkEmultirate = new System.Windows.Forms.CheckBox();
            this.Pnlpurchase = new System.Windows.Forms.Panel();
            this.label97 = new System.Windows.Forms.Label();
            this.chkautomodepurchase = new System.Windows.Forms.CheckBox();
            this.ChkpprintTaxrateinclusive = new System.Windows.Forms.CheckBox();
            this.Chkpedititemcode = new System.Windows.Forms.CheckBox();
            this.ChkEditItemName = new System.Windows.Forms.CheckBox();
            this.chkpbillingdate = new System.Windows.Forms.CheckBox();
            this.chksetsaleincludetax = new System.Windows.Forms.CheckBox();
            this.chkpsavezerorate = new System.Windows.Forms.CheckBox();
            this.chkvisibleprate = new System.Windows.Forms.CheckBox();
            this.chkpitemnote2 = new System.Windows.Forms.CheckBox();
            this.chkpitemnote1 = new System.Windows.Forms.CheckBox();
            this.chkpeditgrossamt = new System.Windows.Forms.CheckBox();
            this.chkpexciseduty = new System.Windows.Forms.CheckBox();
            this.chkagentpurchase = new System.Windows.Forms.CheckBox();
            this.chkemployeepurchase = new System.Windows.Forms.CheckBox();
            this.Chkupdatemrp = new System.Windows.Forms.CheckBox();
            this.Chkupdatesrate = new System.Windows.Forms.CheckBox();
            this.Chkupdateprate = new System.Windows.Forms.CheckBox();
            this.chkeditpurchaserate = new System.Windows.Forms.CheckBox();
            this.chkpfree = new System.Windows.Forms.CheckBox();
            this.chkpitemdiscount = new System.Windows.Forms.CheckBox();
            this.PnlSales = new System.Windows.Forms.Panel();
            this.CHKinsrprefix = new System.Windows.Forms.CheckBox();
            this.CHKCUSwisevat = new System.Windows.Forms.CheckBox();
            this.label88 = new System.Windows.Forms.Label();
            this.chkuserwisedisc = new System.Windows.Forms.CheckBox();
            this.CHKautomaticmodeSET = new System.Windows.Forms.CheckBox();
            this.Chkprateinlist = new System.Windows.Forms.CheckBox();
            this.label69 = new System.Windows.Forms.Label();
            this.chkSaleitemroundoff = new System.Windows.Forms.CheckBox();
            this.chkempsales = new System.Windows.Forms.CheckBox();
            this.chkvehicle = new System.Windows.Forms.CheckBox();
            this.chkmtrread = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.chkwarranty = new System.Windows.Forms.CheckBox();
            this.lblamtwords = new System.Windows.Forms.Label();
            this.combamtinwords = new System.Windows.Forms.ComboBox();
            this.Chksitemnote = new System.Windows.Forms.CheckBox();
            this.chkprintoldblnce = new System.Windows.Forms.CheckBox();
            this.Chkssearchingmode = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.Txtsprintrate = new System.Windows.Forms.TextBox();
            this.Chksavezeroratesales = new System.Windows.Forms.CheckBox();
            this.Chksalearea = new System.Windows.Forms.CheckBox();
            this.chkseditqty = new System.Windows.Forms.CheckBox();
            this.chkremovedublicate = new System.Windows.Forms.CheckBox();
            this.chkvisiblessrate = new System.Windows.Forms.CheckBox();
            this.chkeditgrossamountinsales = new System.Windows.Forms.CheckBox();
            this.chksinvoicedisc = new System.Windows.Forms.CheckBox();
            this.chkcashcadjet = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtprefixsales = new System.Windows.Forms.TextBox();
            this.chkdeactivecustomerzerobalance = new System.Windows.Forms.CheckBox();
            this.chksfocusfirstrow = new System.Windows.Forms.CheckBox();
            this.ChkSaleUpdateSalesrate = new System.Windows.Forms.CheckBox();
            this.chkagentsales = new System.Windows.Forms.CheckBox();
            this.chksalesmansales = new System.Windows.Forms.CheckBox();
            this.chkeditsrate = new System.Windows.Forms.CheckBox();
            this.chksfree = new System.Windows.Forms.CheckBox();
            this.Chksitemdiscount = new System.Windows.Forms.CheckBox();
            this.pnlmost = new System.Windows.Forms.Panel();
            this.chkmostmove = new System.Windows.Forms.CheckBox();
            this.gridmostmove = new System.Windows.Forms.DataGridView();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMpcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label87 = new System.Windows.Forms.Label();
            this.PnlBarcodeSets = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkdatetwoline = new System.Windows.Forms.CheckBox();
            this.chkbcodeprintBold = new System.Windows.Forms.CheckBox();
            this.lblitemsize = new System.Windows.Forms.Label();
            this.LBLCODESIZE = new System.Windows.Forms.Label();
            this.chkitemnametop = new System.Windows.Forms.CheckBox();
            this.lbllangsize = new System.Windows.Forms.Label();
            this.chkmanexdate = new System.Windows.Forms.CheckBox();
            this.Chkbcodesrate = new System.Windows.Forms.CheckBox();
            this.label65 = new System.Windows.Forms.Label();
            this.lblBheight = new System.Windows.Forms.Label();
            this.chkllangbcode = new System.Windows.Forms.CheckBox();
            this.chkcodeinbcode = new System.Windows.Forms.CheckBox();
            this.lblratesize = new System.Windows.Forms.Label();
            this.lblcmpsize = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkrateroundoffbcode = new System.Windows.Forms.CheckBox();
            this.lblsample = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.chkbarcoderate = new System.Windows.Forms.CheckBox();
            this.txtBcodeRateDivision = new System.Windows.Forms.TextBox();
            this.ChkbcodeQty = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtBcodeQTYDivision = new System.Windows.Forms.TextBox();
            this.txtbcodestart = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.txtbcodeend = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.txtbcoderateend = new System.Windows.Forms.TextBox();
            this.txtqtystat = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.txtqtyend = new System.Windows.Forms.TextBox();
            this.txtbcoderatestart = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label86 = new System.Windows.Forms.Label();
            this.txtBcodetextPrefix = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.txtbcodeeprefix = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.lblbcodedig = new System.Windows.Forms.Label();
            this.txtbcodedegit = new System.Windows.Forms.TextBox();
            this.GrpBarcode = new System.Windows.Forms.GroupBox();
            this.Chkpprintsecondlangague = new System.Windows.Forms.CheckBox();
            this.chkbarcodehusecompanyname = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtbarcodeheading = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbarcodeprifix = new System.Windows.Forms.TextBox();
            this.chkbsuppliercode = new System.Windows.Forms.CheckBox();
            this.chkbitemnote2 = new System.Windows.Forms.CheckBox();
            this.chkbnote1 = new System.Windows.Forms.CheckBox();
            this.chkbpackeddate = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadBprintbutterfly = new System.Windows.Forms.RadioButton();
            this.label37 = new System.Windows.Forms.Label();
            this.txtstickerprint = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtstartingbarcode = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtdistancebarcodesticker = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtlaserleftmargin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtlasertopmargin = new System.Windows.Forms.TextBox();
            this.RadBprintlaser = new System.Windows.Forms.RadioButton();
            this.RadBPrintRoll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkprintbarcodelogo = new System.Windows.Forms.CheckBox();
            this.radprintratebyitems = new System.Windows.Forms.RadioButton();
            this.radbarcodeprintnone = new System.Windows.Forms.RadioButton();
            this.radbarcodeprintmrp = new System.Windows.Forms.RadioButton();
            this.radbarcodeprintsrate = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pnlvoucherType = new System.Windows.Forms.Panel();
            this.ChkcreditlimitON = new System.Windows.Forms.CheckBox();
            this.CHKTAILLOR = new System.Windows.Forms.CheckBox();
            this.Chkpurchasereturn = new System.Windows.Forms.CheckBox();
            this.Chksalesreturn = new System.Windows.Forms.CheckBox();
            this.chkpurchaseestimation = new System.Windows.Forms.CheckBox();
            this.chkpurchaseorder = new System.Windows.Forms.CheckBox();
            this.chkmeterialreceipt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chksalesorder = new System.Windows.Forms.CheckBox();
            this.chksalesestimation = new System.Windows.Forms.CheckBox();
            this.chkdeliverynote = new System.Windows.Forms.CheckBox();
            this.pnldefault = new System.Windows.Forms.Panel();
            this.chkdatewisectrlreport = new System.Windows.Forms.CheckBox();
            this.chkbottomstock = new System.Windows.Forms.CheckBox();
            this.chkstockshow = new System.Windows.Forms.CheckBox();
            this.lbltaxperc = new System.Windows.Forms.Label();
            this.Comtaxinclusivesales = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComLanguage = new System.Windows.Forms.ComboBox();
            this.commodeofpaymentsales = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.commodeofpaymentpurchase = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comdeftax = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comdefcashaccount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Comdefstockarea = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Comdefsalesman = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Comdefbank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PnlGeneral = new System.Windows.Forms.Panel();
            this.chkitemlistview = new System.Windows.Forms.CheckBox();
            this.panelfootr = new System.Windows.Forms.Panel();
            this.txtL5 = new System.Windows.Forms.TextBox();
            this.txtL4 = new System.Windows.Forms.TextBox();
            this.txtL3 = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.cmdFclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.ChkfootMid = new System.Windows.Forms.CheckBox();
            this.Cmdfooterset = new System.Windows.Forms.Button();
            this.chkfootpostn = new System.Windows.Forms.CheckBox();
            this.chkprintfooter = new System.Windows.Forms.CheckBox();
            this.chkservices = new System.Windows.Forms.CheckBox();
            this.Chksinglebarcode = new System.Windows.Forms.CheckBox();
            this.chkepartyproject = new System.Windows.Forms.CheckBox();
            this.Grpbatchenable = new System.Windows.Forms.GroupBox();
            this.chkuseasbarcode = new System.Windows.Forms.CheckBox();
            this.chkroundoff = new System.Windows.Forms.CheckBox();
            this.ChkItemwiseagentcomm = new System.Windows.Forms.CheckBox();
            this.Chkepayroll = new System.Windows.Forms.CheckBox();
            this.ChkEPOS = new System.Windows.Forms.CheckBox();
            this.ChkEBatch = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label98 = new System.Windows.Forms.Label();
            this.COMCASHSYMBOL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComstockDeci = new System.Windows.Forms.ComboBox();
            this.TxtMinerSymbol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMajorSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ComCurDecimal = new System.Windows.Forms.ComboBox();
            this.pnlwarnings = new System.Windows.Forms.Panel();
            this.Comwarnsaleratelessthanretailrate = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.Comwarnsaleratelessthanprate = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.Comwarnmaximumstock = new System.Windows.Forms.ComboBox();
            this.lblwarnmaximumstock = new System.Windows.Forms.Label();
            this.Comwarnreorderstock = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.Comwarnminimumstock = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.Comwarnnegetivestock = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.comwarnnegetivecash = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comwarncreditlimit = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cmdapply = new System.Windows.Forms.Button();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdok = new System.Windows.Forms.Button();
            this.Pnprintersettings = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.combsecondaryModel = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.chkheaderVisible = new System.Windows.Forms.CheckBox();
            this.Comsecondprint = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.Chkenablesecondprinter = new System.Windows.Forms.CheckBox();
            this.ChkprintnoTax = new System.Windows.Forms.CheckBox();
            this.chkQrcode = new System.Windows.Forms.CheckBox();
            this.chkmixedkerala = new System.Windows.Forms.CheckBox();
            this.chka4split = new System.Windows.Forms.CheckBox();
            this.chkmixedkarnataka = new System.Windows.Forms.CheckBox();
            this.chkmixed3 = new System.Windows.Forms.CheckBox();
            this.Raddotpreprinted = new System.Windows.Forms.RadioButton();
            this.Rad3pointarabic = new System.Windows.Forms.RadioButton();
            this.raddotmobile = new System.Windows.Forms.RadioButton();
            this.label41 = new System.Windows.Forms.Label();
            this.txttoplaser = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtleftlaser = new System.Windows.Forms.TextBox();
            this.chkconsole = new System.Windows.Forms.CheckBox();
            this.chkprintllangague = new System.Windows.Forms.CheckBox();
            this.chkprintbalance = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtreverse = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtfscroll = new System.Windows.Forms.TextBox();
            this.raddot8 = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.txtprintfooter = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtnocopies = new System.Windows.Forms.TextBox();
            this.radmultipleprint = new System.Windows.Forms.RadioButton();
            this.radotherdetail = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.combprintselectnpurchase = new System.Windows.Forms.ComboBox();
            this.chkpurchprintconfrm = new System.Windows.Forms.CheckBox();
            this.chkpurchpritwhile = new System.Windows.Forms.CheckBox();
            this.lblprintstyle = new System.Windows.Forms.Label();
            this.combprintselectn = new System.Windows.Forms.ComboBox();
            this.radother10 = new System.Windows.Forms.RadioButton();
            this.radother6 = new System.Windows.Forms.RadioButton();
            this.radother3 = new System.Windows.Forms.RadioButton();
            this.raddot10 = new System.Windows.Forms.RadioButton();
            this.raddot6 = new System.Windows.Forms.RadioButton();
            this.raddot3 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Pnlaoutobackup = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.txtautobackupfilepath4 = new System.Windows.Forms.TextBox();
            this.cmdautobackup4 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.txtautobackupfilepath3 = new System.Windows.Forms.TextBox();
            this.cmdautobackup3 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtautobackupfilepath2 = new System.Windows.Forms.TextBox();
            this.cmdautobackup2 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.txtautobackupfilepath1 = new System.Windows.Forms.TextBox();
            this.cmdautobackup1 = new System.Windows.Forms.Button();
            this.chkautobackup = new System.Windows.Forms.CheckBox();
            this.Pnlstartup = new System.Windows.Forms.Panel();
            this.Chkstrshowbalance = new System.Windows.Forms.CheckBox();
            this.chkstrshowstock = new System.Windows.Forms.CheckBox();
            this.PnlOtherprint = new System.Windows.Forms.Panel();
            this.cmdsummerrefresh = new System.Windows.Forms.Button();
            this.ChkRPdetails = new System.Windows.Forms.CheckBox();
            this.griditems = new System.Windows.Forms.DataGridView();
            this.Clnuserselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Clnitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label80 = new System.Windows.Forms.Label();
            this.txtitemcodebcodesize = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtratesize = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtbcodeHeight = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtlangsize = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtitemsize = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcompnysize = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.TxtsstartingBarcode = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtqrhight = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtqrwidth = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtphadressfont = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txttaxtfnt = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtnamehomefnt = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcompanyfnt = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.TXTICONSIZE = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txticonstartpoint = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txticonend = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcodeprintwidth = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtuserwiseMaxdisc = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtsaledefaultdisc = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcodewidth = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtbatchwidthpurchase = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txttaxpercset = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtfarab = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtestimatepwd = new WindowsFormsApplication2.Uscnormaltextbox();
            this.Txtstrshowstartupbalance = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.Txtstrshowstartupstock = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.Pnlcreate.SuspendLayout();
            this.Grpsetestimatepassword.SuspendLayout();
            this.GrpItemSearch.SuspendLayout();
            this.Pnlpurchase.SuspendLayout();
            this.PnlSales.SuspendLayout();
            this.pnlmost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmostmove)).BeginInit();
            this.PnlBarcodeSets.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.GrpBarcode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlvoucherType.SuspendLayout();
            this.pnldefault.SuspendLayout();
            this.PnlGeneral.SuspendLayout();
            this.panelfootr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Grpbatchenable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlwarnings.SuspendLayout();
            this.Pnprintersettings.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Pnlaoutobackup.SuspendLayout();
            this.Pnlstartup.SuspendLayout();
            this.PnlOtherprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griditems)).BeginInit();
            this.SuspendLayout();
            // 
            // TRMain
            // 
            this.TRMain.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.TRMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TRMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.TRMain.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRMain.ForeColor = System.Drawing.Color.White;
            this.TRMain.HideSelection = false;
            this.TRMain.ItemHeight = 55;
            this.TRMain.LineColor = System.Drawing.Color.White;
            this.TRMain.Location = new System.Drawing.Point(0, 0);
            this.TRMain.Name = "TRMain";
            treeNode1.Name = "NdGeneral";
            treeNode1.Tag = "1";
            treeNode1.Text = "General";
            treeNode2.Name = "NdCreate";
            treeNode2.Tag = "2";
            treeNode2.Text = "Create";
            treeNode3.Name = "NdSales";
            treeNode3.Tag = "3";
            treeNode3.Text = "Sales";
            treeNode4.Name = "NdPurchase";
            treeNode4.Tag = "4";
            treeNode4.Text = "Purchase";
            treeNode5.Name = "NdvouvherType";
            treeNode5.Tag = "5";
            treeNode5.Text = "Voucher Type";
            treeNode6.Name = "ndDefault";
            treeNode6.Tag = "6";
            treeNode6.Text = "Default Settings";
            treeNode7.Name = "NdWarnings";
            treeNode7.Tag = "7";
            treeNode7.Text = "Warnings";
            treeNode8.Name = "Ndprintersettings";
            treeNode8.Tag = "8";
            treeNode8.Text = "Printer Settings";
            treeNode9.Name = "Ndautobackup";
            treeNode9.Tag = "9";
            treeNode9.Text = "Auto Backup";
            treeNode10.Name = "Ndshowstartup";
            treeNode10.Tag = "10";
            treeNode10.Text = "Show startup";
            treeNode11.Name = "NdBarcodeSets";
            treeNode11.Tag = "11";
            treeNode11.Text = "BarcodeSettings";
            treeNode12.Name = "NdOtherPrintset";
            treeNode12.Tag = "12";
            treeNode12.Text = "OtherPrintset";
            this.TRMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.TRMain.Size = new System.Drawing.Size(137, 653);
            this.TRMain.TabIndex = 66;
            this.TRMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TRMain_AfterSelect);
            this.TRMain.MouseHover += new System.EventHandler(this.TRMain_MouseHover);
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblheading.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Black;
            this.lblheading.Location = new System.Drawing.Point(137, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(107, 17);
            this.lblheading.TabIndex = 68;
            this.lblheading.Text = "General Settings";
            // 
            // Pnlcreate
            // 
            this.Pnlcreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlcreate.Controls.Add(this.chkbaseunit);
            this.Pnlcreate.Controls.Add(this.chktailoring);
            this.Pnlcreate.Controls.Add(this.chkzerotaxamount);
            this.Pnlcreate.Controls.Add(this.chkshowestimateledger);
            this.Pnlcreate.Controls.Add(this.Grpsetestimatepassword);
            this.Pnlcreate.Controls.Add(this.Chksupplierwiseitem);
            this.Pnlcreate.Controls.Add(this.chkenpharmacy);
            this.Pnlcreate.Controls.Add(this.chkweightmachine);
            this.Pnlcreate.Controls.Add(this.chkslnotracking);
            this.Pnlcreate.Controls.Add(this.chkcrm);
            this.Pnlcreate.Controls.Add(this.lblsmsbalance);
            this.Pnlcreate.Controls.Add(this.txtsmsbalance);
            this.Pnlcreate.Controls.Add(this.GrpItemSearch);
            this.Pnlcreate.Controls.Add(this.chkcustomerpoint);
            this.Pnlcreate.Controls.Add(this.chkflex);
            this.Pnlcreate.Controls.Add(this.Chkesize);
            this.Pnlcreate.Controls.Add(this.Chkecostcenter);
            this.Pnlcreate.Controls.Add(this.ChkEProduction);
            this.Pnlcreate.Controls.Add(this.chketax);
            this.Pnlcreate.Controls.Add(this.ChkEstockarea);
            this.Pnlcreate.Controls.Add(this.Chkmultiunit);
            this.Pnlcreate.Controls.Add(this.ChkEmultirate);
            this.Pnlcreate.Location = new System.Drawing.Point(157, 311);
            this.Pnlcreate.Name = "Pnlcreate";
            this.Pnlcreate.Size = new System.Drawing.Size(739, 10);
            this.Pnlcreate.TabIndex = 71;
            this.Pnlcreate.Visible = false;
            // 
            // chkbaseunit
            // 
            this.chkbaseunit.AutoSize = true;
            this.chkbaseunit.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkbaseunit.ForeColor = System.Drawing.Color.Black;
            this.chkbaseunit.Location = new System.Drawing.Point(349, 178);
            this.chkbaseunit.Name = "chkbaseunit";
            this.chkbaseunit.Size = new System.Drawing.Size(80, 16);
            this.chkbaseunit.TabIndex = 136;
            this.chkbaseunit.Text = "Base Unit";
            this.chkbaseunit.UseVisualStyleBackColor = true;
            this.chkbaseunit.CheckedChanged += new System.EventHandler(this.chkbaseunit_CheckedChanged);
            // 
            // chktailoring
            // 
            this.chktailoring.AutoSize = true;
            this.chktailoring.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chktailoring.ForeColor = System.Drawing.Color.Black;
            this.chktailoring.Location = new System.Drawing.Point(349, 148);
            this.chktailoring.Name = "chktailoring";
            this.chktailoring.Size = new System.Drawing.Size(79, 16);
            this.chktailoring.TabIndex = 130;
            this.chktailoring.Text = "Tailoring";
            this.chktailoring.UseVisualStyleBackColor = true;
            this.chktailoring.Visible = false;
            // 
            // chkzerotaxamount
            // 
            this.chkzerotaxamount.AutoSize = true;
            this.chkzerotaxamount.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkzerotaxamount.ForeColor = System.Drawing.Color.Black;
            this.chkzerotaxamount.Location = new System.Drawing.Point(190, 223);
            this.chkzerotaxamount.Name = "chkzerotaxamount";
            this.chkzerotaxamount.Size = new System.Drawing.Size(124, 16);
            this.chkzerotaxamount.TabIndex = 129;
            this.chkzerotaxamount.Text = "Zero tax amount";
            this.chkzerotaxamount.UseVisualStyleBackColor = true;
            this.chkzerotaxamount.CheckedChanged += new System.EventHandler(this.chkzerotaxamount_CheckedChanged);
            // 
            // chkshowestimateledger
            // 
            this.chkshowestimateledger.AutoSize = true;
            this.chkshowestimateledger.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkshowestimateledger.ForeColor = System.Drawing.Color.Black;
            this.chkshowestimateledger.Location = new System.Drawing.Point(349, 126);
            this.chkshowestimateledger.Name = "chkshowestimateledger";
            this.chkshowestimateledger.Size = new System.Drawing.Size(159, 16);
            this.chkshowestimateledger.TabIndex = 126;
            this.chkshowestimateledger.Text = "Show Estimate Ledger";
            this.chkshowestimateledger.UseVisualStyleBackColor = true;
            this.chkshowestimateledger.Visible = false;
            this.chkshowestimateledger.CheckedChanged += new System.EventHandler(this.chkshowestimateledger_CheckedChanged);
            // 
            // Grpsetestimatepassword
            // 
            this.Grpsetestimatepassword.Controls.Add(this.cmdsett);
            this.Grpsetestimatepassword.Controls.Add(this.txtestimatepwd);
            this.Grpsetestimatepassword.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Grpsetestimatepassword.Location = new System.Drawing.Point(21, 252);
            this.Grpsetestimatepassword.Name = "Grpsetestimatepassword";
            this.Grpsetestimatepassword.Size = new System.Drawing.Size(200, 74);
            this.Grpsetestimatepassword.TabIndex = 128;
            this.Grpsetestimatepassword.TabStop = false;
            this.Grpsetestimatepassword.Visible = false;
            // 
            // cmdsett
            // 
            this.cmdsett.Location = new System.Drawing.Point(55, 45);
            this.cmdsett.Name = "cmdsett";
            this.cmdsett.Size = new System.Drawing.Size(75, 23);
            this.cmdsett.TabIndex = 1;
            this.cmdsett.Text = "Sett";
            this.cmdsett.UseVisualStyleBackColor = true;
            this.cmdsett.Click += new System.EventHandler(this.cmdsett_Click);
            // 
            // Chksupplierwiseitem
            // 
            this.Chksupplierwiseitem.AutoSize = true;
            this.Chksupplierwiseitem.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksupplierwiseitem.ForeColor = System.Drawing.Color.Black;
            this.Chksupplierwiseitem.Location = new System.Drawing.Point(21, 227);
            this.Chksupplierwiseitem.Name = "Chksupplierwiseitem";
            this.Chksupplierwiseitem.Size = new System.Drawing.Size(137, 16);
            this.Chksupplierwiseitem.TabIndex = 127;
            this.Chksupplierwiseitem.Text = "Supplier wise item";
            this.Chksupplierwiseitem.UseVisualStyleBackColor = true;
            this.Chksupplierwiseitem.Visible = false;
            this.Chksupplierwiseitem.CheckedChanged += new System.EventHandler(this.Chksupplierwiseitem_CheckedChanged);
            // 
            // chkenpharmacy
            // 
            this.chkenpharmacy.AutoSize = true;
            this.chkenpharmacy.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkenpharmacy.ForeColor = System.Drawing.Color.Black;
            this.chkenpharmacy.Location = new System.Drawing.Point(190, 196);
            this.chkenpharmacy.Name = "chkenpharmacy";
            this.chkenpharmacy.Size = new System.Drawing.Size(80, 16);
            this.chkenpharmacy.TabIndex = 126;
            this.chkenpharmacy.Text = "Pharmacy";
            this.chkenpharmacy.UseVisualStyleBackColor = true;
            this.chkenpharmacy.Visible = false;
            this.chkenpharmacy.CheckedChanged += new System.EventHandler(this.chkenpharmacy_CheckedChanged);
            // 
            // chkweightmachine
            // 
            this.chkweightmachine.AutoSize = true;
            this.chkweightmachine.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkweightmachine.ForeColor = System.Drawing.Color.Black;
            this.chkweightmachine.Location = new System.Drawing.Point(20, 195);
            this.chkweightmachine.Name = "chkweightmachine";
            this.chkweightmachine.Size = new System.Drawing.Size(119, 16);
            this.chkweightmachine.TabIndex = 125;
            this.chkweightmachine.Text = "Weight Machine";
            this.chkweightmachine.UseVisualStyleBackColor = true;
            this.chkweightmachine.Visible = false;
            this.chkweightmachine.CheckedChanged += new System.EventHandler(this.chkweightmachine_CheckedChanged);
            // 
            // chkslnotracking
            // 
            this.chkslnotracking.AutoSize = true;
            this.chkslnotracking.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkslnotracking.ForeColor = System.Drawing.Color.Black;
            this.chkslnotracking.Location = new System.Drawing.Point(390, 68);
            this.chkslnotracking.Name = "chkslnotracking";
            this.chkslnotracking.Size = new System.Drawing.Size(130, 16);
            this.chkslnotracking.TabIndex = 124;
            this.chkslnotracking.Text = "Serialno Tracking";
            this.chkslnotracking.UseVisualStyleBackColor = true;
            this.chkslnotracking.CheckedChanged += new System.EventHandler(this.chkslnotracking_CheckedChanged);
            // 
            // chkcrm
            // 
            this.chkcrm.AutoSize = true;
            this.chkcrm.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkcrm.ForeColor = System.Drawing.Color.Black;
            this.chkcrm.Location = new System.Drawing.Point(190, 159);
            this.chkcrm.Name = "chkcrm";
            this.chkcrm.Size = new System.Drawing.Size(51, 16);
            this.chkcrm.TabIndex = 123;
            this.chkcrm.Text = "CRM";
            this.chkcrm.UseVisualStyleBackColor = true;
            this.chkcrm.Visible = false;
            this.chkcrm.CheckedChanged += new System.EventHandler(this.chkcrm_CheckedChanged);
            // 
            // lblsmsbalance
            // 
            this.lblsmsbalance.AutoSize = true;
            this.lblsmsbalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblsmsbalance.Location = new System.Drawing.Point(393, 23);
            this.lblsmsbalance.Name = "lblsmsbalance";
            this.lblsmsbalance.Size = new System.Drawing.Size(80, 12);
            this.lblsmsbalance.TabIndex = 122;
            this.lblsmsbalance.Text = "SMS Balance";
            this.lblsmsbalance.Visible = false;
            // 
            // txtsmsbalance
            // 
            this.txtsmsbalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtsmsbalance.Location = new System.Drawing.Point(390, 38);
            this.txtsmsbalance.Name = "txtsmsbalance";
            this.txtsmsbalance.Size = new System.Drawing.Size(100, 20);
            this.txtsmsbalance.TabIndex = 121;
            this.txtsmsbalance.Visible = false;
            // 
            // GrpItemSearch
            // 
            this.GrpItemSearch.Controls.Add(this.raditemanykeysearch);
            this.GrpItemSearch.Controls.Add(this.Raditemlastkeysearch);
            this.GrpItemSearch.Controls.Add(this.Raditemfirstsearch);
            this.GrpItemSearch.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.GrpItemSearch.Location = new System.Drawing.Point(316, 242);
            this.GrpItemSearch.Name = "GrpItemSearch";
            this.GrpItemSearch.Size = new System.Drawing.Size(200, 100);
            this.GrpItemSearch.TabIndex = 120;
            this.GrpItemSearch.TabStop = false;
            this.GrpItemSearch.Text = "Item Search";
            // 
            // raditemanykeysearch
            // 
            this.raditemanykeysearch.AutoSize = true;
            this.raditemanykeysearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.raditemanykeysearch.Location = new System.Drawing.Point(22, 70);
            this.raditemanykeysearch.Name = "raditemanykeysearch";
            this.raditemanykeysearch.Size = new System.Drawing.Size(115, 21);
            this.raditemanykeysearch.TabIndex = 2;
            this.raditemanykeysearch.TabStop = true;
            this.raditemanykeysearch.Text = "Any Key Search";
            this.raditemanykeysearch.UseVisualStyleBackColor = true;
            this.raditemanykeysearch.CheckedChanged += new System.EventHandler(this.raditemanykeysearch_CheckedChanged);
            // 
            // Raditemlastkeysearch
            // 
            this.Raditemlastkeysearch.AutoSize = true;
            this.Raditemlastkeysearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Raditemlastkeysearch.Location = new System.Drawing.Point(22, 47);
            this.Raditemlastkeysearch.Name = "Raditemlastkeysearch";
            this.Raditemlastkeysearch.Size = new System.Drawing.Size(117, 21);
            this.Raditemlastkeysearch.TabIndex = 1;
            this.Raditemlastkeysearch.TabStop = true;
            this.Raditemlastkeysearch.Text = "Last Key Search";
            this.Raditemlastkeysearch.UseVisualStyleBackColor = true;
            this.Raditemlastkeysearch.CheckedChanged += new System.EventHandler(this.Raditemlastkeysearch_CheckedChanged);
            // 
            // Raditemfirstsearch
            // 
            this.Raditemfirstsearch.AutoSize = true;
            this.Raditemfirstsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Raditemfirstsearch.Location = new System.Drawing.Point(22, 24);
            this.Raditemfirstsearch.Name = "Raditemfirstsearch";
            this.Raditemfirstsearch.Size = new System.Drawing.Size(118, 21);
            this.Raditemfirstsearch.TabIndex = 0;
            this.Raditemfirstsearch.TabStop = true;
            this.Raditemfirstsearch.Text = "First Key Search";
            this.Raditemfirstsearch.UseVisualStyleBackColor = true;
            this.Raditemfirstsearch.CheckedChanged += new System.EventHandler(this.Raditemfirstsearch_CheckedChanged);
            // 
            // chkcustomerpoint
            // 
            this.chkcustomerpoint.AutoSize = true;
            this.chkcustomerpoint.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkcustomerpoint.ForeColor = System.Drawing.Color.Black;
            this.chkcustomerpoint.Location = new System.Drawing.Point(19, 162);
            this.chkcustomerpoint.Name = "chkcustomerpoint";
            this.chkcustomerpoint.Size = new System.Drawing.Size(116, 16);
            this.chkcustomerpoint.TabIndex = 119;
            this.chkcustomerpoint.Text = "Customer Point";
            this.chkcustomerpoint.UseVisualStyleBackColor = true;
            this.chkcustomerpoint.Visible = false;
            this.chkcustomerpoint.CheckedChanged += new System.EventHandler(this.chkcustomerpoint_CheckedChanged);
            // 
            // chkflex
            // 
            this.chkflex.AutoSize = true;
            this.chkflex.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkflex.ForeColor = System.Drawing.Color.Black;
            this.chkflex.Location = new System.Drawing.Point(190, 125);
            this.chkflex.Name = "chkflex";
            this.chkflex.Size = new System.Drawing.Size(92, 16);
            this.chkflex.TabIndex = 118;
            this.chkflex.Text = "Enable Flex";
            this.chkflex.UseVisualStyleBackColor = true;
            this.chkflex.Visible = false;
            this.chkflex.CheckedChanged += new System.EventHandler(this.chkflex_CheckedChanged);
            // 
            // Chkesize
            // 
            this.Chkesize.AutoSize = true;
            this.Chkesize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkesize.ForeColor = System.Drawing.Color.Black;
            this.Chkesize.Location = new System.Drawing.Point(19, 126);
            this.Chkesize.Name = "Chkesize";
            this.Chkesize.Size = new System.Drawing.Size(92, 16);
            this.Chkesize.TabIndex = 117;
            this.Chkesize.Text = "Enable Size";
            this.Chkesize.UseVisualStyleBackColor = true;
            this.Chkesize.Visible = false;
            this.Chkesize.CheckedChanged += new System.EventHandler(this.Chkesize_CheckedChanged);
            // 
            // Chkecostcenter
            // 
            this.Chkecostcenter.AutoSize = true;
            this.Chkecostcenter.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkecostcenter.ForeColor = System.Drawing.Color.Black;
            this.Chkecostcenter.Location = new System.Drawing.Point(19, 91);
            this.Chkecostcenter.Name = "Chkecostcenter";
            this.Chkecostcenter.Size = new System.Drawing.Size(135, 16);
            this.Chkecostcenter.TabIndex = 116;
            this.Chkecostcenter.Text = "Enable Costcenter";
            this.Chkecostcenter.UseVisualStyleBackColor = true;
            this.Chkecostcenter.CheckedChanged += new System.EventHandler(this.Chkecostcenter_CheckedChanged);
            // 
            // ChkEProduction
            // 
            this.ChkEProduction.AutoSize = true;
            this.ChkEProduction.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkEProduction.ForeColor = System.Drawing.Color.Black;
            this.ChkEProduction.Location = new System.Drawing.Point(190, 91);
            this.ChkEProduction.Name = "ChkEProduction";
            this.ChkEProduction.Size = new System.Drawing.Size(134, 16);
            this.ChkEProduction.TabIndex = 116;
            this.ChkEProduction.Text = "Enable Production";
            this.ChkEProduction.UseVisualStyleBackColor = true;
            this.ChkEProduction.CheckedChanged += new System.EventHandler(this.ChkEProduction_CheckedChanged);
            // 
            // chketax
            // 
            this.chketax.AutoSize = true;
            this.chketax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chketax.ForeColor = System.Drawing.Color.Black;
            this.chketax.Location = new System.Drawing.Point(190, 56);
            this.chketax.Name = "chketax";
            this.chketax.Size = new System.Drawing.Size(90, 16);
            this.chketax.TabIndex = 114;
            this.chketax.Text = "Enable Tax";
            this.chketax.UseVisualStyleBackColor = true;
            this.chketax.CheckedChanged += new System.EventHandler(this.chketax_CheckedChanged);
            // 
            // ChkEstockarea
            // 
            this.ChkEstockarea.AutoSize = true;
            this.ChkEstockarea.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkEstockarea.ForeColor = System.Drawing.Color.Black;
            this.ChkEstockarea.Location = new System.Drawing.Point(19, 56);
            this.ChkEstockarea.Name = "ChkEstockarea";
            this.ChkEstockarea.Size = new System.Drawing.Size(129, 16);
            this.ChkEstockarea.TabIndex = 113;
            this.ChkEstockarea.Text = "Enable StockArea";
            this.ChkEstockarea.UseVisualStyleBackColor = true;
            this.ChkEstockarea.CheckedChanged += new System.EventHandler(this.ChkEstockarea_CheckedChanged);
            // 
            // Chkmultiunit
            // 
            this.Chkmultiunit.AutoSize = true;
            this.Chkmultiunit.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkmultiunit.ForeColor = System.Drawing.Color.Black;
            this.Chkmultiunit.Location = new System.Drawing.Point(190, 19);
            this.Chkmultiunit.Name = "Chkmultiunit";
            this.Chkmultiunit.Size = new System.Drawing.Size(125, 16);
            this.Chkmultiunit.TabIndex = 106;
            this.Chkmultiunit.Text = "Enable MultiUnit";
            this.Chkmultiunit.UseVisualStyleBackColor = true;
            this.Chkmultiunit.CheckedChanged += new System.EventHandler(this.Chkmultiunit_CheckedChanged);
            // 
            // ChkEmultirate
            // 
            this.ChkEmultirate.AutoSize = true;
            this.ChkEmultirate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkEmultirate.ForeColor = System.Drawing.Color.Black;
            this.ChkEmultirate.Location = new System.Drawing.Point(19, 19);
            this.ChkEmultirate.Name = "ChkEmultirate";
            this.ChkEmultirate.Size = new System.Drawing.Size(125, 16);
            this.ChkEmultirate.TabIndex = 105;
            this.ChkEmultirate.Text = "Enable Multirate";
            this.ChkEmultirate.UseVisualStyleBackColor = true;
            this.ChkEmultirate.CheckedChanged += new System.EventHandler(this.ChkEmultirate_CheckedChanged);
            // 
            // Pnlpurchase
            // 
            this.Pnlpurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlpurchase.Controls.Add(this.txtbatchwidthpurchase);
            this.Pnlpurchase.Controls.Add(this.label97);
            this.Pnlpurchase.Controls.Add(this.chkautomodepurchase);
            this.Pnlpurchase.Controls.Add(this.ChkpprintTaxrateinclusive);
            this.Pnlpurchase.Controls.Add(this.Chkpedititemcode);
            this.Pnlpurchase.Controls.Add(this.ChkEditItemName);
            this.Pnlpurchase.Controls.Add(this.chkpbillingdate);
            this.Pnlpurchase.Controls.Add(this.chksetsaleincludetax);
            this.Pnlpurchase.Controls.Add(this.chkpsavezerorate);
            this.Pnlpurchase.Controls.Add(this.chkvisibleprate);
            this.Pnlpurchase.Controls.Add(this.chkpitemnote2);
            this.Pnlpurchase.Controls.Add(this.chkpitemnote1);
            this.Pnlpurchase.Controls.Add(this.chkpeditgrossamt);
            this.Pnlpurchase.Controls.Add(this.chkpexciseduty);
            this.Pnlpurchase.Controls.Add(this.chkagentpurchase);
            this.Pnlpurchase.Controls.Add(this.chkemployeepurchase);
            this.Pnlpurchase.Controls.Add(this.Chkupdatemrp);
            this.Pnlpurchase.Controls.Add(this.Chkupdatesrate);
            this.Pnlpurchase.Controls.Add(this.Chkupdateprate);
            this.Pnlpurchase.Controls.Add(this.chkeditpurchaserate);
            this.Pnlpurchase.Controls.Add(this.chkpfree);
            this.Pnlpurchase.Controls.Add(this.chkpitemdiscount);
            this.Pnlpurchase.Location = new System.Drawing.Point(145, 60);
            this.Pnlpurchase.Name = "Pnlpurchase";
            this.Pnlpurchase.Size = new System.Drawing.Size(743, 229);
            this.Pnlpurchase.TabIndex = 120;
            this.Pnlpurchase.Visible = false;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label97.Location = new System.Drawing.Point(460, 19);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(121, 12);
            this.label97.TabIndex = 132;
            this.label97.Text = "BatchColumn Width";
            // 
            // chkautomodepurchase
            // 
            this.chkautomodepurchase.AutoSize = true;
            this.chkautomodepurchase.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkautomodepurchase.ForeColor = System.Drawing.Color.Black;
            this.chkautomodepurchase.Location = new System.Drawing.Point(18, 205);
            this.chkautomodepurchase.Name = "chkautomodepurchase";
            this.chkautomodepurchase.Size = new System.Drawing.Size(106, 16);
            this.chkautomodepurchase.TabIndex = 131;
            this.chkautomodepurchase.Text = "AutoModeSet";
            this.chkautomodepurchase.UseVisualStyleBackColor = true;
            this.chkautomodepurchase.CheckedChanged += new System.EventHandler(this.chkautomodepurchase_CheckedChanged);
            // 
            // ChkpprintTaxrateinclusive
            // 
            this.ChkpprintTaxrateinclusive.AutoSize = true;
            this.ChkpprintTaxrateinclusive.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkpprintTaxrateinclusive.ForeColor = System.Drawing.Color.Black;
            this.ChkpprintTaxrateinclusive.Location = new System.Drawing.Point(19, 178);
            this.ChkpprintTaxrateinclusive.Name = "ChkpprintTaxrateinclusive";
            this.ChkpprintTaxrateinclusive.Size = new System.Drawing.Size(167, 16);
            this.ChkpprintTaxrateinclusive.TabIndex = 130;
            this.ChkpprintTaxrateinclusive.Text = "Print Tax Rate inclusive";
            this.ChkpprintTaxrateinclusive.UseVisualStyleBackColor = true;
            this.ChkpprintTaxrateinclusive.CheckedChanged += new System.EventHandler(this.ChkpprintTaxrateinclusive_CheckedChanged);
            // 
            // Chkpedititemcode
            // 
            this.Chkpedititemcode.AutoSize = true;
            this.Chkpedititemcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkpedititemcode.ForeColor = System.Drawing.Color.Black;
            this.Chkpedititemcode.Location = new System.Drawing.Point(316, 152);
            this.Chkpedititemcode.Name = "Chkpedititemcode";
            this.Chkpedititemcode.Size = new System.Drawing.Size(110, 16);
            this.Chkpedititemcode.TabIndex = 129;
            this.Chkpedititemcode.Text = "Edit Itemcode";
            this.Chkpedititemcode.UseVisualStyleBackColor = true;
            this.Chkpedititemcode.Visible = false;
            this.Chkpedititemcode.CheckedChanged += new System.EventHandler(this.Chkpedititemcode_CheckedChanged);
            // 
            // ChkEditItemName
            // 
            this.ChkEditItemName.AutoSize = true;
            this.ChkEditItemName.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkEditItemName.Location = new System.Drawing.Point(192, 152);
            this.ChkEditItemName.Name = "ChkEditItemName";
            this.ChkEditItemName.Size = new System.Drawing.Size(130, 16);
            this.ChkEditItemName.TabIndex = 128;
            this.ChkEditItemName.Text = "Visible Item Code";
            this.ChkEditItemName.UseVisualStyleBackColor = true;
            this.ChkEditItemName.CheckedChanged += new System.EventHandler(this.ChkEditItemName_CheckedChanged);
            // 
            // chkpbillingdate
            // 
            this.chkpbillingdate.AutoSize = true;
            this.chkpbillingdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpbillingdate.ForeColor = System.Drawing.Color.Black;
            this.chkpbillingdate.Location = new System.Drawing.Point(19, 151);
            this.chkpbillingdate.Name = "chkpbillingdate";
            this.chkpbillingdate.Size = new System.Drawing.Size(94, 16);
            this.chkpbillingdate.TabIndex = 127;
            this.chkpbillingdate.Text = "Billing date";
            this.chkpbillingdate.UseVisualStyleBackColor = true;
            this.chkpbillingdate.CheckedChanged += new System.EventHandler(this.chkpbillingdate_CheckedChanged);
            // 
            // chksetsaleincludetax
            // 
            this.chksetsaleincludetax.AutoSize = true;
            this.chksetsaleincludetax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksetsaleincludetax.ForeColor = System.Drawing.Color.Black;
            this.chksetsaleincludetax.Location = new System.Drawing.Point(315, 122);
            this.chksetsaleincludetax.Name = "chksetsaleincludetax";
            this.chksetsaleincludetax.Size = new System.Drawing.Size(182, 16);
            this.chksetsaleincludetax.TabIndex = 126;
            this.chksetsaleincludetax.Text = "Set sale rate (include tax)";
            this.chksetsaleincludetax.UseVisualStyleBackColor = true;
            this.chksetsaleincludetax.CheckedChanged += new System.EventHandler(this.chksetsaleincludetax_CheckedChanged);
            // 
            // chkpsavezerorate
            // 
            this.chkpsavezerorate.AutoSize = true;
            this.chkpsavezerorate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpsavezerorate.ForeColor = System.Drawing.Color.Black;
            this.chkpsavezerorate.Location = new System.Drawing.Point(191, 123);
            this.chkpsavezerorate.Name = "chkpsavezerorate";
            this.chkpsavezerorate.Size = new System.Drawing.Size(115, 16);
            this.chkpsavezerorate.TabIndex = 125;
            this.chkpsavezerorate.Text = "Save Zero Rate";
            this.chkpsavezerorate.UseVisualStyleBackColor = true;
            this.chkpsavezerorate.CheckedChanged += new System.EventHandler(this.chkpsavezerorate_CheckedChanged);
            // 
            // chkvisibleprate
            // 
            this.chkvisibleprate.AutoSize = true;
            this.chkvisibleprate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkvisibleprate.ForeColor = System.Drawing.Color.Black;
            this.chkvisibleprate.Location = new System.Drawing.Point(19, 124);
            this.chkvisibleprate.Name = "chkvisibleprate";
            this.chkvisibleprate.Size = new System.Drawing.Size(102, 16);
            this.chkvisibleprate.TabIndex = 124;
            this.chkvisibleprate.Text = "Visible PRate";
            this.chkvisibleprate.UseVisualStyleBackColor = true;
            this.chkvisibleprate.CheckedChanged += new System.EventHandler(this.chkvisibleprate_CheckedChanged);
            // 
            // chkpitemnote2
            // 
            this.chkpitemnote2.AutoSize = true;
            this.chkpitemnote2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpitemnote2.ForeColor = System.Drawing.Color.Black;
            this.chkpitemnote2.Location = new System.Drawing.Point(315, 95);
            this.chkpitemnote2.Name = "chkpitemnote2";
            this.chkpitemnote2.Size = new System.Drawing.Size(91, 16);
            this.chkpitemnote2.TabIndex = 123;
            this.chkpitemnote2.Text = "Item Note2";
            this.chkpitemnote2.UseVisualStyleBackColor = true;
            this.chkpitemnote2.CheckedChanged += new System.EventHandler(this.chkpitemnote2_CheckedChanged);
            // 
            // chkpitemnote1
            // 
            this.chkpitemnote1.AutoSize = true;
            this.chkpitemnote1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpitemnote1.ForeColor = System.Drawing.Color.Black;
            this.chkpitemnote1.Location = new System.Drawing.Point(191, 96);
            this.chkpitemnote1.Name = "chkpitemnote1";
            this.chkpitemnote1.Size = new System.Drawing.Size(91, 16);
            this.chkpitemnote1.TabIndex = 122;
            this.chkpitemnote1.Text = "Item Note1";
            this.chkpitemnote1.UseVisualStyleBackColor = true;
            this.chkpitemnote1.CheckedChanged += new System.EventHandler(this.chkpitemnote1_CheckedChanged);
            // 
            // chkpeditgrossamt
            // 
            this.chkpeditgrossamt.AutoSize = true;
            this.chkpeditgrossamt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpeditgrossamt.ForeColor = System.Drawing.Color.Black;
            this.chkpeditgrossamt.Location = new System.Drawing.Point(19, 96);
            this.chkpeditgrossamt.Name = "chkpeditgrossamt";
            this.chkpeditgrossamt.Size = new System.Drawing.Size(109, 16);
            this.chkpeditgrossamt.TabIndex = 121;
            this.chkpeditgrossamt.Text = "Edit GrossAmt";
            this.chkpeditgrossamt.UseVisualStyleBackColor = true;
            this.chkpeditgrossamt.CheckedChanged += new System.EventHandler(this.chkeditgrossamt_CheckedChanged);
            // 
            // chkpexciseduty
            // 
            this.chkpexciseduty.AutoSize = true;
            this.chkpexciseduty.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpexciseduty.ForeColor = System.Drawing.Color.Black;
            this.chkpexciseduty.Location = new System.Drawing.Point(314, 70);
            this.chkpexciseduty.Name = "chkpexciseduty";
            this.chkpexciseduty.Size = new System.Drawing.Size(95, 16);
            this.chkpexciseduty.TabIndex = 120;
            this.chkpexciseduty.Text = "Excise Duty";
            this.chkpexciseduty.UseVisualStyleBackColor = true;
            this.chkpexciseduty.CheckedChanged += new System.EventHandler(this.chkpexciseduty_CheckedChanged);
            // 
            // chkagentpurchase
            // 
            this.chkagentpurchase.AutoSize = true;
            this.chkagentpurchase.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkagentpurchase.ForeColor = System.Drawing.Color.Black;
            this.chkagentpurchase.Location = new System.Drawing.Point(190, 71);
            this.chkagentpurchase.Name = "chkagentpurchase";
            this.chkagentpurchase.Size = new System.Drawing.Size(59, 16);
            this.chkagentpurchase.TabIndex = 119;
            this.chkagentpurchase.Text = "Agent";
            this.chkagentpurchase.UseVisualStyleBackColor = true;
            this.chkagentpurchase.CheckedChanged += new System.EventHandler(this.chkagentpurchase_CheckedChanged);
            // 
            // chkemployeepurchase
            // 
            this.chkemployeepurchase.AutoSize = true;
            this.chkemployeepurchase.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkemployeepurchase.ForeColor = System.Drawing.Color.Black;
            this.chkemployeepurchase.Location = new System.Drawing.Point(19, 71);
            this.chkemployeepurchase.Name = "chkemployeepurchase";
            this.chkemployeepurchase.Size = new System.Drawing.Size(82, 16);
            this.chkemployeepurchase.TabIndex = 118;
            this.chkemployeepurchase.Text = "Employee";
            this.chkemployeepurchase.UseVisualStyleBackColor = true;
            this.chkemployeepurchase.CheckedChanged += new System.EventHandler(this.chkemployeepurchase_CheckedChanged);
            // 
            // Chkupdatemrp
            // 
            this.Chkupdatemrp.AutoSize = true;
            this.Chkupdatemrp.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkupdatemrp.ForeColor = System.Drawing.Color.Black;
            this.Chkupdatemrp.Location = new System.Drawing.Point(314, 45);
            this.Chkupdatemrp.Name = "Chkupdatemrp";
            this.Chkupdatemrp.Size = new System.Drawing.Size(97, 16);
            this.Chkupdatemrp.TabIndex = 117;
            this.Chkupdatemrp.Text = "Update MRP";
            this.Chkupdatemrp.UseVisualStyleBackColor = true;
            this.Chkupdatemrp.CheckedChanged += new System.EventHandler(this.Chkupdatemrp_CheckedChanged);
            // 
            // Chkupdatesrate
            // 
            this.Chkupdatesrate.AutoSize = true;
            this.Chkupdatesrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkupdatesrate.ForeColor = System.Drawing.Color.Black;
            this.Chkupdatesrate.Location = new System.Drawing.Point(189, 45);
            this.Chkupdatesrate.Name = "Chkupdatesrate";
            this.Chkupdatesrate.Size = new System.Drawing.Size(126, 16);
            this.Chkupdatesrate.TabIndex = 116;
            this.Chkupdatesrate.Text = "Update Sale.rate";
            this.Chkupdatesrate.UseVisualStyleBackColor = true;
            this.Chkupdatesrate.CheckedChanged += new System.EventHandler(this.Chkupdatesrate_CheckedChanged);
            // 
            // Chkupdateprate
            // 
            this.Chkupdateprate.AutoSize = true;
            this.Chkupdateprate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkupdateprate.ForeColor = System.Drawing.Color.Black;
            this.Chkupdateprate.Location = new System.Drawing.Point(19, 45);
            this.Chkupdateprate.Name = "Chkupdateprate";
            this.Chkupdateprate.Size = new System.Drawing.Size(153, 16);
            this.Chkupdateprate.TabIndex = 115;
            this.Chkupdateprate.Text = "Update Purchase.rate";
            this.Chkupdateprate.UseVisualStyleBackColor = true;
            this.Chkupdateprate.CheckedChanged += new System.EventHandler(this.Chkupdateprate_CheckedChanged);
            // 
            // chkeditpurchaserate
            // 
            this.chkeditpurchaserate.AutoSize = true;
            this.chkeditpurchaserate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkeditpurchaserate.ForeColor = System.Drawing.Color.Black;
            this.chkeditpurchaserate.Location = new System.Drawing.Point(313, 19);
            this.chkeditpurchaserate.Name = "chkeditpurchaserate";
            this.chkeditpurchaserate.Size = new System.Drawing.Size(133, 16);
            this.chkeditpurchaserate.TabIndex = 113;
            this.chkeditpurchaserate.Text = "Edit PurchaseRate";
            this.chkeditpurchaserate.UseVisualStyleBackColor = true;
            this.chkeditpurchaserate.CheckedChanged += new System.EventHandler(this.chkeditpurchaserate_CheckedChanged);
            // 
            // chkpfree
            // 
            this.chkpfree.AutoSize = true;
            this.chkpfree.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpfree.ForeColor = System.Drawing.Color.Black;
            this.chkpfree.Location = new System.Drawing.Point(190, 19);
            this.chkpfree.Name = "chkpfree";
            this.chkpfree.Size = new System.Drawing.Size(49, 16);
            this.chkpfree.TabIndex = 106;
            this.chkpfree.Text = "Free";
            this.chkpfree.UseVisualStyleBackColor = true;
            this.chkpfree.CheckedChanged += new System.EventHandler(this.chkpfree_CheckedChanged);
            // 
            // chkpitemdiscount
            // 
            this.chkpitemdiscount.AutoSize = true;
            this.chkpitemdiscount.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpitemdiscount.ForeColor = System.Drawing.Color.Black;
            this.chkpitemdiscount.Location = new System.Drawing.Point(19, 19);
            this.chkpitemdiscount.Name = "chkpitemdiscount";
            this.chkpitemdiscount.Size = new System.Drawing.Size(109, 16);
            this.chkpitemdiscount.TabIndex = 105;
            this.chkpitemdiscount.Text = "Item Discount";
            this.chkpitemdiscount.UseVisualStyleBackColor = true;
            this.chkpitemdiscount.CheckedChanged += new System.EventHandler(this.chkpitemdiscount_CheckedChanged);
            // 
            // PnlSales
            // 
            this.PnlSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSales.Controls.Add(this.CHKinsrprefix);
            this.PnlSales.Controls.Add(this.CHKCUSwisevat);
            this.PnlSales.Controls.Add(this.label88);
            this.PnlSales.Controls.Add(this.txtuserwiseMaxdisc);
            this.PnlSales.Controls.Add(this.chkuserwisedisc);
            this.PnlSales.Controls.Add(this.CHKautomaticmodeSET);
            this.PnlSales.Controls.Add(this.Chkprateinlist);
            this.PnlSales.Controls.Add(this.txtsaledefaultdisc);
            this.PnlSales.Controls.Add(this.label69);
            this.PnlSales.Controls.Add(this.chkSaleitemroundoff);
            this.PnlSales.Controls.Add(this.chkempsales);
            this.PnlSales.Controls.Add(this.chkvehicle);
            this.PnlSales.Controls.Add(this.chkmtrread);
            this.PnlSales.Controls.Add(this.txtcodewidth);
            this.PnlSales.Controls.Add(this.label54);
            this.PnlSales.Controls.Add(this.chkwarranty);
            this.PnlSales.Controls.Add(this.lblamtwords);
            this.PnlSales.Controls.Add(this.combamtinwords);
            this.PnlSales.Controls.Add(this.Chksitemnote);
            this.PnlSales.Controls.Add(this.chkprintoldblnce);
            this.PnlSales.Controls.Add(this.Chkssearchingmode);
            this.PnlSales.Controls.Add(this.label48);
            this.PnlSales.Controls.Add(this.Txtsprintrate);
            this.PnlSales.Controls.Add(this.Chksavezeroratesales);
            this.PnlSales.Controls.Add(this.Chksalearea);
            this.PnlSales.Controls.Add(this.chkseditqty);
            this.PnlSales.Controls.Add(this.chkremovedublicate);
            this.PnlSales.Controls.Add(this.chkvisiblessrate);
            this.PnlSales.Controls.Add(this.chkeditgrossamountinsales);
            this.PnlSales.Controls.Add(this.chksinvoicedisc);
            this.PnlSales.Controls.Add(this.chkcashcadjet);
            this.PnlSales.Controls.Add(this.label23);
            this.PnlSales.Controls.Add(this.txtprefixsales);
            this.PnlSales.Controls.Add(this.chkdeactivecustomerzerobalance);
            this.PnlSales.Controls.Add(this.chksfocusfirstrow);
            this.PnlSales.Controls.Add(this.ChkSaleUpdateSalesrate);
            this.PnlSales.Controls.Add(this.chkagentsales);
            this.PnlSales.Controls.Add(this.chksalesmansales);
            this.PnlSales.Controls.Add(this.chkeditsrate);
            this.PnlSales.Controls.Add(this.chksfree);
            this.PnlSales.Controls.Add(this.Chksitemdiscount);
            this.PnlSales.Location = new System.Drawing.Point(162, 33);
            this.PnlSales.Name = "PnlSales";
            this.PnlSales.Size = new System.Drawing.Size(752, 17);
            this.PnlSales.TabIndex = 121;
            this.PnlSales.Visible = false;
            this.PnlSales.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSales_Paint);
            // 
            // CHKinsrprefix
            // 
            this.CHKinsrprefix.AutoSize = true;
            this.CHKinsrprefix.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHKinsrprefix.ForeColor = System.Drawing.Color.Black;
            this.CHKinsrprefix.Location = new System.Drawing.Point(79, 157);
            this.CHKinsrprefix.Name = "CHKinsrprefix";
            this.CHKinsrprefix.Size = new System.Drawing.Size(81, 16);
            this.CHKinsrprefix.TabIndex = 176;
            this.CHKinsrprefix.Text = "SR_prefix";
            this.CHKinsrprefix.UseVisualStyleBackColor = true;
            this.CHKinsrprefix.CheckedChanged += new System.EventHandler(this.CHKinsrprefix_CheckedChanged);
            // 
            // CHKCUSwisevat
            // 
            this.CHKCUSwisevat.AutoSize = true;
            this.CHKCUSwisevat.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHKCUSwisevat.ForeColor = System.Drawing.Color.Black;
            this.CHKCUSwisevat.Location = new System.Drawing.Point(464, 184);
            this.CHKCUSwisevat.Name = "CHKCUSwisevat";
            this.CHKCUSwisevat.Size = new System.Drawing.Size(137, 16);
            this.CHKCUSwisevat.TabIndex = 175;
            this.CHKCUSwisevat.Text = "Customer wise tax";
            this.CHKCUSwisevat.UseVisualStyleBackColor = true;
            this.CHKCUSwisevat.CheckedChanged += new System.EventHandler(this.CHKCUSwisevat_CheckedChanged);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label88.Location = new System.Drawing.Point(8, 279);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(125, 12);
            this.label88.TabIndex = 174;
            this.label88.Text = "User discount Max :";
            // 
            // chkuserwisedisc
            // 
            this.chkuserwisedisc.AutoSize = true;
            this.chkuserwisedisc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkuserwisedisc.ForeColor = System.Drawing.Color.Black;
            this.chkuserwisedisc.Location = new System.Drawing.Point(9, 256);
            this.chkuserwisedisc.Name = "chkuserwisedisc";
            this.chkuserwisedisc.Size = new System.Drawing.Size(140, 16);
            this.chkuserwisedisc.TabIndex = 172;
            this.chkuserwisedisc.Text = "User wise Discount";
            this.chkuserwisedisc.UseVisualStyleBackColor = true;
            this.chkuserwisedisc.CheckedChanged += new System.EventHandler(this.chkuserwisedisc_CheckedChanged);
            // 
            // CHKautomaticmodeSET
            // 
            this.CHKautomaticmodeSET.AutoSize = true;
            this.CHKautomaticmodeSET.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHKautomaticmodeSET.ForeColor = System.Drawing.Color.Black;
            this.CHKautomaticmodeSET.Location = new System.Drawing.Point(465, 157);
            this.CHKautomaticmodeSET.Name = "CHKautomaticmodeSET";
            this.CHKautomaticmodeSET.Size = new System.Drawing.Size(147, 16);
            this.CHKautomaticmodeSET.TabIndex = 171;
            this.CHKautomaticmodeSET.Text = "Automatic Mode set";
            this.CHKautomaticmodeSET.UseVisualStyleBackColor = true;
            this.CHKautomaticmodeSET.CheckedChanged += new System.EventHandler(this.CHKautomaticmodeSET_CheckedChanged);
            // 
            // Chkprateinlist
            // 
            this.Chkprateinlist.AutoSize = true;
            this.Chkprateinlist.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkprateinlist.Location = new System.Drawing.Point(468, 137);
            this.Chkprateinlist.Name = "Chkprateinlist";
            this.Chkprateinlist.Size = new System.Drawing.Size(157, 16);
            this.Chkprateinlist.TabIndex = 169;
            this.Chkprateinlist.Text = "Prate In Itemshow list";
            this.Chkprateinlist.UseVisualStyleBackColor = true;
            this.Chkprateinlist.CheckedChanged += new System.EventHandler(this.Chkprateinlist_CheckedChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(647, 11);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(92, 12);
            this.label69.TabIndex = 167;
            this.label69.Text = "Default Disc %";
            // 
            // chkSaleitemroundoff
            // 
            this.chkSaleitemroundoff.AutoSize = true;
            this.chkSaleitemroundoff.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkSaleitemroundoff.ForeColor = System.Drawing.Color.Black;
            this.chkSaleitemroundoff.Location = new System.Drawing.Point(465, 90);
            this.chkSaleitemroundoff.Name = "chkSaleitemroundoff";
            this.chkSaleitemroundoff.Size = new System.Drawing.Size(133, 16);
            this.chkSaleitemroundoff.TabIndex = 166;
            this.chkSaleitemroundoff.Text = "Saleitem roundoff";
            this.chkSaleitemroundoff.UseVisualStyleBackColor = true;
            this.chkSaleitemroundoff.CheckedChanged += new System.EventHandler(this.chkSaleitemroundoff_CheckedChanged);
            // 
            // chkempsales
            // 
            this.chkempsales.AutoSize = true;
            this.chkempsales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkempsales.ForeColor = System.Drawing.Color.Black;
            this.chkempsales.Location = new System.Drawing.Point(464, 15);
            this.chkempsales.Name = "chkempsales";
            this.chkempsales.Size = new System.Drawing.Size(106, 16);
            this.chkempsales.TabIndex = 165;
            this.chkempsales.Text = "Employeesale";
            this.chkempsales.UseVisualStyleBackColor = true;
            this.chkempsales.CheckedChanged += new System.EventHandler(this.chkempsales_CheckedChanged);
            // 
            // chkvehicle
            // 
            this.chkvehicle.AutoSize = true;
            this.chkvehicle.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkvehicle.ForeColor = System.Drawing.Color.Black;
            this.chkvehicle.Location = new System.Drawing.Point(464, 64);
            this.chkvehicle.Name = "chkvehicle";
            this.chkvehicle.Size = new System.Drawing.Size(87, 16);
            this.chkvehicle.TabIndex = 162;
            this.chkvehicle.Text = "vehicleNo.";
            this.chkvehicle.UseVisualStyleBackColor = true;
            this.chkvehicle.CheckedChanged += new System.EventHandler(this.chkvehicle_CheckedChanged);
            // 
            // chkmtrread
            // 
            this.chkmtrread.AutoSize = true;
            this.chkmtrread.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkmtrread.ForeColor = System.Drawing.Color.Black;
            this.chkmtrread.Location = new System.Drawing.Point(464, 42);
            this.chkmtrread.Name = "chkmtrread";
            this.chkmtrread.Size = new System.Drawing.Size(85, 16);
            this.chkmtrread.TabIndex = 161;
            this.chkmtrread.Text = "MTR Read";
            this.chkmtrread.UseVisualStyleBackColor = true;
            this.chkmtrread.CheckedChanged += new System.EventHandler(this.chkmtrread_CheckedChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label54.Location = new System.Drawing.Point(8, 204);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(106, 12);
            this.label54.TabIndex = 143;
            this.label54.Text = "Itemcodewidth :";
            // 
            // chkwarranty
            // 
            this.chkwarranty.AutoSize = true;
            this.chkwarranty.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkwarranty.Location = new System.Drawing.Point(467, 115);
            this.chkwarranty.Name = "chkwarranty";
            this.chkwarranty.Size = new System.Drawing.Size(77, 16);
            this.chkwarranty.TabIndex = 123;
            this.chkwarranty.Text = "Warranty";
            this.chkwarranty.UseVisualStyleBackColor = true;
            this.chkwarranty.CheckedChanged += new System.EventHandler(this.chkwarranty_CheckedChanged);
            // 
            // lblamtwords
            // 
            this.lblamtwords.AutoSize = true;
            this.lblamtwords.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblamtwords.Location = new System.Drawing.Point(11, 232);
            this.lblamtwords.Name = "lblamtwords";
            this.lblamtwords.Size = new System.Drawing.Size(77, 12);
            this.lblamtwords.TabIndex = 141;
            this.lblamtwords.Text = "AmtInwords";
            // 
            // combamtinwords
            // 
            this.combamtinwords.AutoCompleteCustomSource.AddRange(new string[] {
            "Arabic",
            "English"});
            this.combamtinwords.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.combamtinwords.ForeColor = System.Drawing.Color.Blue;
            this.combamtinwords.FormattingEnabled = true;
            this.combamtinwords.Items.AddRange(new object[] {
            "Arabic",
            "English"});
            this.combamtinwords.Location = new System.Drawing.Point(90, 229);
            this.combamtinwords.Name = "combamtinwords";
            this.combamtinwords.Size = new System.Drawing.Size(100, 20);
            this.combamtinwords.TabIndex = 140;
            // 
            // Chksitemnote
            // 
            this.Chksitemnote.AutoSize = true;
            this.Chksitemnote.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksitemnote.ForeColor = System.Drawing.Color.Black;
            this.Chksitemnote.Location = new System.Drawing.Point(340, 183);
            this.Chksitemnote.Name = "Chksitemnote";
            this.Chksitemnote.Size = new System.Drawing.Size(79, 16);
            this.Chksitemnote.TabIndex = 139;
            this.Chksitemnote.Text = "Itemnote";
            this.Chksitemnote.UseVisualStyleBackColor = true;
            this.Chksitemnote.CheckedChanged += new System.EventHandler(this.Chksitemnote_CheckedChanged);
            // 
            // chkprintoldblnce
            // 
            this.chkprintoldblnce.AutoSize = true;
            this.chkprintoldblnce.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkprintoldblnce.ForeColor = System.Drawing.Color.Black;
            this.chkprintoldblnce.Location = new System.Drawing.Point(340, 159);
            this.chkprintoldblnce.Name = "chkprintoldblnce";
            this.chkprintoldblnce.Size = new System.Drawing.Size(95, 16);
            this.chkprintoldblnce.TabIndex = 135;
            this.chkprintoldblnce.Text = "Old Balance";
            this.chkprintoldblnce.UseVisualStyleBackColor = true;
            this.chkprintoldblnce.CheckedChanged += new System.EventHandler(this.chkprintoldblnce_CheckedChanged);
            // 
            // Chkssearchingmode
            // 
            this.Chkssearchingmode.AutoSize = true;
            this.Chkssearchingmode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkssearchingmode.ForeColor = System.Drawing.Color.Black;
            this.Chkssearchingmode.Location = new System.Drawing.Point(340, 134);
            this.Chkssearchingmode.Name = "Chkssearchingmode";
            this.Chkssearchingmode.Size = new System.Drawing.Size(121, 16);
            this.Chkssearchingmode.TabIndex = 134;
            this.Chkssearchingmode.Text = "Searching Mode";
            this.Chkssearchingmode.UseVisualStyleBackColor = true;
            this.Chkssearchingmode.CheckedChanged += new System.EventHandler(this.Chkssearchingmode_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label48.Location = new System.Drawing.Point(186, 157);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(65, 12);
            this.label48.TabIndex = 133;
            this.label48.Text = "Print Rate";
            // 
            // Txtsprintrate
            // 
            this.Txtsprintrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Txtsprintrate.Location = new System.Drawing.Point(183, 175);
            this.Txtsprintrate.Name = "Txtsprintrate";
            this.Txtsprintrate.Size = new System.Drawing.Size(100, 20);
            this.Txtsprintrate.TabIndex = 132;
            // 
            // Chksavezeroratesales
            // 
            this.Chksavezeroratesales.AutoSize = true;
            this.Chksavezeroratesales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksavezeroratesales.ForeColor = System.Drawing.Color.Black;
            this.Chksavezeroratesales.Location = new System.Drawing.Point(340, 113);
            this.Chksavezeroratesales.Name = "Chksavezeroratesales";
            this.Chksavezeroratesales.Size = new System.Drawing.Size(115, 16);
            this.Chksavezeroratesales.TabIndex = 131;
            this.Chksavezeroratesales.Text = "Save Zero Rate";
            this.Chksavezeroratesales.UseVisualStyleBackColor = true;
            this.Chksavezeroratesales.CheckedChanged += new System.EventHandler(this.Chksavezeroratesales_CheckedChanged);
            // 
            // Chksalearea
            // 
            this.Chksalearea.AutoSize = true;
            this.Chksalearea.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksalearea.ForeColor = System.Drawing.Color.Black;
            this.Chksalearea.Location = new System.Drawing.Point(340, 86);
            this.Chksalearea.Name = "Chksalearea";
            this.Chksalearea.Size = new System.Drawing.Size(85, 16);
            this.Chksalearea.TabIndex = 130;
            this.Chksalearea.Text = "Party Area";
            this.Chksalearea.UseVisualStyleBackColor = true;
            this.Chksalearea.CheckedChanged += new System.EventHandler(this.Chksalearea_CheckedChanged);
            // 
            // chkseditqty
            // 
            this.chkseditqty.AutoSize = true;
            this.chkseditqty.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkseditqty.ForeColor = System.Drawing.Color.Black;
            this.chkseditqty.Location = new System.Drawing.Point(191, 133);
            this.chkseditqty.Name = "chkseditqty";
            this.chkseditqty.Size = new System.Drawing.Size(71, 16);
            this.chkseditqty.TabIndex = 129;
            this.chkseditqty.Text = "EditQty";
            this.chkseditqty.UseVisualStyleBackColor = true;
            this.chkseditqty.CheckedChanged += new System.EventHandler(this.chkseditqty_CheckedChanged);
            // 
            // chkremovedublicate
            // 
            this.chkremovedublicate.AutoSize = true;
            this.chkremovedublicate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkremovedublicate.ForeColor = System.Drawing.Color.Black;
            this.chkremovedublicate.Location = new System.Drawing.Point(20, 132);
            this.chkremovedublicate.Name = "chkremovedublicate";
            this.chkremovedublicate.Size = new System.Drawing.Size(170, 16);
            this.chkremovedublicate.TabIndex = 128;
            this.chkremovedublicate.Text = "Remove Dublicate Entry";
            this.chkremovedublicate.UseVisualStyleBackColor = true;
            this.chkremovedublicate.CheckedChanged += new System.EventHandler(this.chkremovedublicate_CheckedChanged);
            // 
            // chkvisiblessrate
            // 
            this.chkvisiblessrate.AutoSize = true;
            this.chkvisiblessrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkvisiblessrate.ForeColor = System.Drawing.Color.Black;
            this.chkvisiblessrate.Location = new System.Drawing.Point(191, 111);
            this.chkvisiblessrate.Name = "chkvisiblessrate";
            this.chkvisiblessrate.Size = new System.Drawing.Size(103, 16);
            this.chkvisiblessrate.TabIndex = 127;
            this.chkvisiblessrate.Text = "Visible SRate";
            this.chkvisiblessrate.UseVisualStyleBackColor = true;
            this.chkvisiblessrate.CheckedChanged += new System.EventHandler(this.chkvisiblessrate_CheckedChanged);
            // 
            // chkeditgrossamountinsales
            // 
            this.chkeditgrossamountinsales.AutoSize = true;
            this.chkeditgrossamountinsales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkeditgrossamountinsales.ForeColor = System.Drawing.Color.Black;
            this.chkeditgrossamountinsales.Location = new System.Drawing.Point(20, 112);
            this.chkeditgrossamountinsales.Name = "chkeditgrossamountinsales";
            this.chkeditgrossamountinsales.Size = new System.Drawing.Size(109, 16);
            this.chkeditgrossamountinsales.TabIndex = 126;
            this.chkeditgrossamountinsales.Text = "Edit GrossAmt";
            this.chkeditgrossamountinsales.UseVisualStyleBackColor = true;
            this.chkeditgrossamountinsales.CheckedChanged += new System.EventHandler(this.chkeditgrossamountinsales_CheckedChanged);
            // 
            // chksinvoicedisc
            // 
            this.chksinvoicedisc.AutoSize = true;
            this.chksinvoicedisc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksinvoicedisc.ForeColor = System.Drawing.Color.Black;
            this.chksinvoicedisc.Location = new System.Drawing.Point(190, 90);
            this.chksinvoicedisc.Name = "chksinvoicedisc";
            this.chksinvoicedisc.Size = new System.Drawing.Size(126, 16);
            this.chksinvoicedisc.TabIndex = 125;
            this.chksinvoicedisc.Text = "Invoice Discount";
            this.chksinvoicedisc.UseVisualStyleBackColor = true;
            this.chksinvoicedisc.CheckedChanged += new System.EventHandler(this.chksinvoicedisc_CheckedChanged);
            // 
            // chkcashcadjet
            // 
            this.chkcashcadjet.AutoSize = true;
            this.chkcashcadjet.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkcashcadjet.ForeColor = System.Drawing.Color.Black;
            this.chkcashcadjet.Location = new System.Drawing.Point(19, 90);
            this.chkcashcadjet.Name = "chkcashcadjet";
            this.chkcashcadjet.Size = new System.Drawing.Size(85, 16);
            this.chkcashcadjet.TabIndex = 124;
            this.chkcashcadjet.Text = "Cash Desk";
            this.chkcashcadjet.UseVisualStyleBackColor = true;
            this.chkcashcadjet.CheckedChanged += new System.EventHandler(this.chkcashcadjet_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(17, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 12);
            this.label23.TabIndex = 123;
            this.label23.Text = "PrefixVno";
            // 
            // txtprefixsales
            // 
            this.txtprefixsales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtprefixsales.Location = new System.Drawing.Point(14, 174);
            this.txtprefixsales.Name = "txtprefixsales";
            this.txtprefixsales.Size = new System.Drawing.Size(100, 20);
            this.txtprefixsales.TabIndex = 122;
            // 
            // chkdeactivecustomerzerobalance
            // 
            this.chkdeactivecustomerzerobalance.AutoSize = true;
            this.chkdeactivecustomerzerobalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkdeactivecustomerzerobalance.ForeColor = System.Drawing.Color.Black;
            this.chkdeactivecustomerzerobalance.Location = new System.Drawing.Point(190, 64);
            this.chkdeactivecustomerzerobalance.Name = "chkdeactivecustomerzerobalance";
            this.chkdeactivecustomerzerobalance.Size = new System.Drawing.Size(221, 16);
            this.chkdeactivecustomerzerobalance.TabIndex = 119;
            this.chkdeactivecustomerzerobalance.Text = "Deactive Customer(ZeroBalance)";
            this.chkdeactivecustomerzerobalance.UseVisualStyleBackColor = true;
            this.chkdeactivecustomerzerobalance.CheckedChanged += new System.EventHandler(this.chkdeactivecustomerzerobalance_CheckedChanged);
            // 
            // chksfocusfirstrow
            // 
            this.chksfocusfirstrow.AutoSize = true;
            this.chksfocusfirstrow.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksfocusfirstrow.ForeColor = System.Drawing.Color.Black;
            this.chksfocusfirstrow.Location = new System.Drawing.Point(19, 64);
            this.chksfocusfirstrow.Name = "chksfocusfirstrow";
            this.chksfocusfirstrow.Size = new System.Drawing.Size(113, 16);
            this.chksfocusfirstrow.TabIndex = 118;
            this.chksfocusfirstrow.Text = "Focus Firstrow";
            this.chksfocusfirstrow.UseVisualStyleBackColor = true;
            this.chksfocusfirstrow.CheckedChanged += new System.EventHandler(this.chkfocusfirstrow_CheckedChanged);
            // 
            // ChkSaleUpdateSalesrate
            // 
            this.ChkSaleUpdateSalesrate.AutoSize = true;
            this.ChkSaleUpdateSalesrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkSaleUpdateSalesrate.ForeColor = System.Drawing.Color.Black;
            this.ChkSaleUpdateSalesrate.Location = new System.Drawing.Point(340, 41);
            this.ChkSaleUpdateSalesrate.Name = "ChkSaleUpdateSalesrate";
            this.ChkSaleUpdateSalesrate.Size = new System.Drawing.Size(126, 16);
            this.ChkSaleUpdateSalesrate.TabIndex = 117;
            this.ChkSaleUpdateSalesrate.Text = "Update Sale.rate";
            this.ChkSaleUpdateSalesrate.UseVisualStyleBackColor = true;
            this.ChkSaleUpdateSalesrate.CheckedChanged += new System.EventHandler(this.ChkSaleUpdateSalesrate_CheckedChanged);
            // 
            // chkagentsales
            // 
            this.chkagentsales.AutoSize = true;
            this.chkagentsales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkagentsales.ForeColor = System.Drawing.Color.Black;
            this.chkagentsales.Location = new System.Drawing.Point(190, 41);
            this.chkagentsales.Name = "chkagentsales";
            this.chkagentsales.Size = new System.Drawing.Size(59, 16);
            this.chkagentsales.TabIndex = 115;
            this.chkagentsales.Text = "Agent";
            this.chkagentsales.UseVisualStyleBackColor = true;
            this.chkagentsales.CheckedChanged += new System.EventHandler(this.chkagentsales_CheckedChanged);
            // 
            // chksalesmansales
            // 
            this.chksalesmansales.AutoSize = true;
            this.chksalesmansales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksalesmansales.ForeColor = System.Drawing.Color.Black;
            this.chksalesmansales.Location = new System.Drawing.Point(19, 41);
            this.chksalesmansales.Name = "chksalesmansales";
            this.chksalesmansales.Size = new System.Drawing.Size(79, 16);
            this.chksalesmansales.TabIndex = 114;
            this.chksalesmansales.Text = "Salesman";
            this.chksalesmansales.UseVisualStyleBackColor = true;
            this.chksalesmansales.CheckedChanged += new System.EventHandler(this.chkemployeesales_CheckedChanged);
            // 
            // chkeditsrate
            // 
            this.chkeditsrate.AutoSize = true;
            this.chkeditsrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkeditsrate.ForeColor = System.Drawing.Color.Black;
            this.chkeditsrate.Location = new System.Drawing.Point(340, 19);
            this.chkeditsrate.Name = "chkeditsrate";
            this.chkeditsrate.Size = new System.Drawing.Size(106, 16);
            this.chkeditsrate.TabIndex = 113;
            this.chkeditsrate.Text = "Edit SaleRate";
            this.chkeditsrate.UseVisualStyleBackColor = true;
            this.chkeditsrate.CheckedChanged += new System.EventHandler(this.chkeditsrate_CheckedChanged);
            // 
            // chksfree
            // 
            this.chksfree.AutoSize = true;
            this.chksfree.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksfree.ForeColor = System.Drawing.Color.Black;
            this.chksfree.Location = new System.Drawing.Point(190, 19);
            this.chksfree.Name = "chksfree";
            this.chksfree.Size = new System.Drawing.Size(49, 16);
            this.chksfree.TabIndex = 106;
            this.chksfree.Text = "Free";
            this.chksfree.UseVisualStyleBackColor = true;
            this.chksfree.CheckedChanged += new System.EventHandler(this.chksfree_CheckedChanged);
            // 
            // Chksitemdiscount
            // 
            this.Chksitemdiscount.AutoSize = true;
            this.Chksitemdiscount.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksitemdiscount.ForeColor = System.Drawing.Color.Black;
            this.Chksitemdiscount.Location = new System.Drawing.Point(19, 19);
            this.Chksitemdiscount.Name = "Chksitemdiscount";
            this.Chksitemdiscount.Size = new System.Drawing.Size(109, 16);
            this.Chksitemdiscount.TabIndex = 105;
            this.Chksitemdiscount.Text = "Item Discount";
            this.Chksitemdiscount.UseVisualStyleBackColor = true;
            this.Chksitemdiscount.CheckedChanged += new System.EventHandler(this.Chksitemdiscount_CheckedChanged);
            // 
            // pnlmost
            // 
            this.pnlmost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.pnlmost.Controls.Add(this.chkmostmove);
            this.pnlmost.Controls.Add(this.gridmostmove);
            this.pnlmost.Controls.Add(this.label87);
            this.pnlmost.Location = new System.Drawing.Point(355, 5);
            this.pnlmost.Name = "pnlmost";
            this.pnlmost.Size = new System.Drawing.Size(381, 421);
            this.pnlmost.TabIndex = 172;
            // 
            // chkmostmove
            // 
            this.chkmostmove.AutoSize = true;
            this.chkmostmove.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkmostmove.ForeColor = System.Drawing.Color.Black;
            this.chkmostmove.Location = new System.Drawing.Point(179, 3);
            this.chkmostmove.Name = "chkmostmove";
            this.chkmostmove.Size = new System.Drawing.Size(135, 16);
            this.chkmostmove.TabIndex = 173;
            this.chkmostmove.Text = "Enable Most move";
            this.chkmostmove.UseVisualStyleBackColor = true;
            this.chkmostmove.CheckedChanged += new System.EventHandler(this.chkmostmove_CheckedChanged);
            // 
            // gridmostmove
            // 
            this.gridmostmove.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmostmove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmostmove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmostmove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Batch,
            this.MMpcode,
            this.Item});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmostmove.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridmostmove.EnableHeadersVisualStyles = false;
            this.gridmostmove.GridColor = System.Drawing.Color.White;
            this.gridmostmove.Location = new System.Drawing.Point(5, 26);
            this.gridmostmove.Name = "gridmostmove";
            this.gridmostmove.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Crimson;
            this.gridmostmove.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridmostmove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmostmove.Size = new System.Drawing.Size(357, 382);
            this.gridmostmove.StandardTab = true;
            this.gridmostmove.TabIndex = 216;
            this.gridmostmove.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmostmove_CellLeave);
            this.gridmostmove.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmostmove_EditingControlShowing);
            this.gridmostmove.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmostmove_CellEnter);
            // 
            // Batch
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Batch.DefaultCellStyle = dataGridViewCellStyle2;
            this.Batch.HeaderText = "Batch";
            this.Batch.Name = "Batch";
            this.Batch.Width = 170;
            // 
            // MMpcode
            // 
            this.MMpcode.HeaderText = "MMpcode";
            this.MMpcode.Name = "MMpcode";
            this.MMpcode.Visible = false;
            // 
            // Item
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson;
            this.Item.DefaultCellStyle = dataGridViewCellStyle3;
            this.Item.HeaderText = "Name";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 180;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Transparent;
            this.label87.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label87.Location = new System.Drawing.Point(10, 5);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(121, 15);
            this.label87.TabIndex = 0;
            this.label87.Text = "Most moving Sale";
            // 
            // PnlBarcodeSets
            // 
            this.PnlBarcodeSets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBarcodeSets.Controls.Add(this.panel6);
            this.PnlBarcodeSets.Controls.Add(this.panel5);
            this.PnlBarcodeSets.Controls.Add(this.panel4);
            this.PnlBarcodeSets.Controls.Add(this.GrpBarcode);
            this.PnlBarcodeSets.Location = new System.Drawing.Point(152, 350);
            this.PnlBarcodeSets.Name = "PnlBarcodeSets";
            this.PnlBarcodeSets.Size = new System.Drawing.Size(742, 46);
            this.PnlBarcodeSets.TabIndex = 132;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.panel6.Controls.Add(this.chkdatetwoline);
            this.panel6.Controls.Add(this.chkbcodeprintBold);
            this.panel6.Controls.Add(this.lblitemsize);
            this.panel6.Controls.Add(this.txtitemcodebcodesize);
            this.panel6.Controls.Add(this.LBLCODESIZE);
            this.panel6.Controls.Add(this.chkitemnametop);
            this.panel6.Controls.Add(this.lbllangsize);
            this.panel6.Controls.Add(this.chkmanexdate);
            this.panel6.Controls.Add(this.Chkbcodesrate);
            this.panel6.Controls.Add(this.label65);
            this.panel6.Controls.Add(this.txtratesize);
            this.panel6.Controls.Add(this.lblBheight);
            this.panel6.Controls.Add(this.chkllangbcode);
            this.panel6.Controls.Add(this.txtbcodeHeight);
            this.panel6.Controls.Add(this.txtlangsize);
            this.panel6.Controls.Add(this.chkcodeinbcode);
            this.panel6.Controls.Add(this.txtitemsize);
            this.panel6.Controls.Add(this.lblratesize);
            this.panel6.Controls.Add(this.lblcmpsize);
            this.panel6.Controls.Add(this.txtcompnysize);
            this.panel6.Location = new System.Drawing.Point(6, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 373);
            this.panel6.TabIndex = 185;
            // 
            // chkdatetwoline
            // 
            this.chkdatetwoline.AutoSize = true;
            this.chkdatetwoline.BackColor = System.Drawing.Color.White;
            this.chkdatetwoline.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkdatetwoline.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkdatetwoline.Location = new System.Drawing.Point(3, 310);
            this.chkdatetwoline.Name = "chkdatetwoline";
            this.chkdatetwoline.Size = new System.Drawing.Size(133, 16);
            this.chkdatetwoline.TabIndex = 170;
            this.chkdatetwoline.Text = "MF_EX Date 2 line";
            this.chkdatetwoline.UseVisualStyleBackColor = false;
            this.chkdatetwoline.CheckedChanged += new System.EventHandler(this.chkdatetwoline_CheckedChanged);
            // 
            // chkbcodeprintBold
            // 
            this.chkbcodeprintBold.AutoSize = true;
            this.chkbcodeprintBold.BackColor = System.Drawing.Color.White;
            this.chkbcodeprintBold.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkbcodeprintBold.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkbcodeprintBold.Location = new System.Drawing.Point(4, 351);
            this.chkbcodeprintBold.Name = "chkbcodeprintBold";
            this.chkbcodeprintBold.Size = new System.Drawing.Size(82, 16);
            this.chkbcodeprintBold.TabIndex = 169;
            this.chkbcodeprintBold.Text = "Font Bold";
            this.chkbcodeprintBold.UseVisualStyleBackColor = false;
            this.chkbcodeprintBold.CheckedChanged += new System.EventHandler(this.chkbcodeprintBold_CheckedChanged);
            // 
            // lblitemsize
            // 
            this.lblitemsize.AutoSize = true;
            this.lblitemsize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblitemsize.Location = new System.Drawing.Point(2, 65);
            this.lblitemsize.Name = "lblitemsize";
            this.lblitemsize.Size = new System.Drawing.Size(87, 12);
            this.lblitemsize.TabIndex = 148;
            this.lblitemsize.Text = "ItemnameSize";
            // 
            // LBLCODESIZE
            // 
            this.LBLCODESIZE.AutoSize = true;
            this.LBLCODESIZE.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.LBLCODESIZE.Location = new System.Drawing.Point(1, 154);
            this.LBLCODESIZE.Name = "LBLCODESIZE";
            this.LBLCODESIZE.Size = new System.Drawing.Size(86, 12);
            this.LBLCODESIZE.TabIndex = 157;
            this.LBLCODESIZE.Text = "ItemcodeSize";
            // 
            // chkitemnametop
            // 
            this.chkitemnametop.AutoSize = true;
            this.chkitemnametop.BackColor = System.Drawing.Color.White;
            this.chkitemnametop.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkitemnametop.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkitemnametop.Location = new System.Drawing.Point(3, 329);
            this.chkitemnametop.Name = "chkitemnametop";
            this.chkitemnametop.Size = new System.Drawing.Size(105, 16);
            this.chkitemnametop.TabIndex = 162;
            this.chkitemnametop.Text = "ItemnameTOP";
            this.chkitemnametop.UseVisualStyleBackColor = false;
            this.chkitemnametop.CheckedChanged += new System.EventHandler(this.chkitemnametop_CheckedChanged);
            // 
            // lbllangsize
            // 
            this.lbllangsize.AutoSize = true;
            this.lbllangsize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbllangsize.Location = new System.Drawing.Point(4, 184);
            this.lbllangsize.Name = "lbllangsize";
            this.lbllangsize.Size = new System.Drawing.Size(59, 12);
            this.lbllangsize.TabIndex = 159;
            this.lbllangsize.Text = "lang Size";
            // 
            // chkmanexdate
            // 
            this.chkmanexdate.AutoSize = true;
            this.chkmanexdate.BackColor = System.Drawing.Color.White;
            this.chkmanexdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkmanexdate.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkmanexdate.Location = new System.Drawing.Point(2, 289);
            this.chkmanexdate.Name = "chkmanexdate";
            this.chkmanexdate.Size = new System.Drawing.Size(152, 16);
            this.chkmanexdate.TabIndex = 161;
            this.chkmanexdate.Text = "Manf & Ex date visible";
            this.chkmanexdate.UseVisualStyleBackColor = false;
            this.chkmanexdate.CheckedChanged += new System.EventHandler(this.chkmanexdate_CheckedChanged);
            // 
            // Chkbcodesrate
            // 
            this.Chkbcodesrate.AutoSize = true;
            this.Chkbcodesrate.BackColor = System.Drawing.Color.White;
            this.Chkbcodesrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkbcodesrate.ForeColor = System.Drawing.Color.Fuchsia;
            this.Chkbcodesrate.Location = new System.Drawing.Point(3, 215);
            this.Chkbcodesrate.Name = "Chkbcodesrate";
            this.Chkbcodesrate.Size = new System.Drawing.Size(121, 16);
            this.Chkbcodesrate.TabIndex = 154;
            this.Chkbcodesrate.Text = "SaleRate visible";
            this.Chkbcodesrate.UseVisualStyleBackColor = false;
            this.Chkbcodesrate.CheckedChanged += new System.EventHandler(this.Chkbcodesrate_CheckedChanged);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Blue;
            this.label65.Location = new System.Drawing.Point(9, 7);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(150, 15);
            this.label65.TabIndex = 146;
            this.label65.Text = "Batch Label create set";
            // 
            // lblBheight
            // 
            this.lblBheight.AutoSize = true;
            this.lblBheight.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBheight.Location = new System.Drawing.Point(5, 32);
            this.lblBheight.Name = "lblBheight";
            this.lblBheight.Size = new System.Drawing.Size(83, 12);
            this.lblBheight.TabIndex = 146;
            this.lblBheight.Text = "BcodeHeight";
            // 
            // chkllangbcode
            // 
            this.chkllangbcode.AutoSize = true;
            this.chkllangbcode.BackColor = System.Drawing.Color.White;
            this.chkllangbcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkllangbcode.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkllangbcode.Location = new System.Drawing.Point(3, 242);
            this.chkllangbcode.Name = "chkllangbcode";
            this.chkllangbcode.Size = new System.Drawing.Size(120, 16);
            this.chkllangbcode.TabIndex = 155;
            this.chkllangbcode.Text = "2nd lang visible";
            this.chkllangbcode.UseVisualStyleBackColor = false;
            this.chkllangbcode.CheckedChanged += new System.EventHandler(this.chkllangbcode_CheckedChanged);
            // 
            // chkcodeinbcode
            // 
            this.chkcodeinbcode.AutoSize = true;
            this.chkcodeinbcode.BackColor = System.Drawing.Color.White;
            this.chkcodeinbcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkcodeinbcode.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkcodeinbcode.Location = new System.Drawing.Point(2, 266);
            this.chkcodeinbcode.Name = "chkcodeinbcode";
            this.chkcodeinbcode.Size = new System.Drawing.Size(125, 16);
            this.chkcodeinbcode.TabIndex = 156;
            this.chkcodeinbcode.Text = "Itemcode visible";
            this.chkcodeinbcode.UseVisualStyleBackColor = false;
            this.chkcodeinbcode.CheckedChanged += new System.EventHandler(this.chkcodeinbcode_CheckedChanged);
            // 
            // lblratesize
            // 
            this.lblratesize.AutoSize = true;
            this.lblratesize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblratesize.Location = new System.Drawing.Point(3, 126);
            this.lblratesize.Name = "lblratesize";
            this.lblratesize.Size = new System.Drawing.Size(57, 12);
            this.lblratesize.TabIndex = 152;
            this.lblratesize.Text = "RateSize";
            // 
            // lblcmpsize
            // 
            this.lblcmpsize.AutoSize = true;
            this.lblcmpsize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblcmpsize.Location = new System.Drawing.Point(2, 96);
            this.lblcmpsize.Name = "lblcmpsize";
            this.lblcmpsize.Size = new System.Drawing.Size(84, 12);
            this.lblcmpsize.TabIndex = 150;
            this.lblcmpsize.Text = "CompanySize";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.panel5.Controls.Add(this.chkrateroundoffbcode);
            this.panel5.Controls.Add(this.lblsample);
            this.panel5.Controls.Add(this.label72);
            this.panel5.Controls.Add(this.chkbarcoderate);
            this.panel5.Controls.Add(this.txtBcodeRateDivision);
            this.panel5.Controls.Add(this.ChkbcodeQty);
            this.panel5.Controls.Add(this.label79);
            this.panel5.Controls.Add(this.label70);
            this.panel5.Controls.Add(this.txtBcodeQTYDivision);
            this.panel5.Controls.Add(this.txtbcodestart);
            this.panel5.Controls.Add(this.label78);
            this.panel5.Controls.Add(this.label71);
            this.panel5.Controls.Add(this.txtbcodeend);
            this.panel5.Controls.Add(this.label76);
            this.panel5.Controls.Add(this.label73);
            this.panel5.Controls.Add(this.txtbcoderateend);
            this.panel5.Controls.Add(this.txtqtystat);
            this.panel5.Controls.Add(this.label74);
            this.panel5.Controls.Add(this.txtqtyend);
            this.panel5.Controls.Add(this.txtbcoderatestart);
            this.panel5.Controls.Add(this.label75);
            this.panel5.Location = new System.Drawing.Point(232, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 146);
            this.panel5.TabIndex = 184;
            // 
            // chkrateroundoffbcode
            // 
            this.chkrateroundoffbcode.AutoSize = true;
            this.chkrateroundoffbcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkrateroundoffbcode.ForeColor = System.Drawing.Color.Black;
            this.chkrateroundoffbcode.Location = new System.Drawing.Point(307, 76);
            this.chkrateroundoffbcode.Name = "chkrateroundoffbcode";
            this.chkrateroundoffbcode.Size = new System.Drawing.Size(125, 16);
            this.chkrateroundoffbcode.TabIndex = 184;
            this.chkrateroundoffbcode.Text = "Bcode Round off";
            this.chkrateroundoffbcode.UseVisualStyleBackColor = true;
            this.chkrateroundoffbcode.CheckedChanged += new System.EventHandler(this.chkrateroundoffbcode_CheckedChanged);
            // 
            // lblsample
            // 
            this.lblsample.AutoSize = true;
            this.lblsample.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsample.ForeColor = System.Drawing.Color.Red;
            this.lblsample.Location = new System.Drawing.Point(345, 130);
            this.lblsample.Name = "lblsample";
            this.lblsample.Size = new System.Drawing.Size(157, 14);
            this.lblsample.TabIndex = 183;
            this.lblsample.Text = "Read more About Sample";
            this.lblsample.Click += new System.EventHandler(this.lblsample_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label72.ForeColor = System.Drawing.Color.Black;
            this.label72.Location = new System.Drawing.Point(151, 52);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(110, 12);
            this.label72.TabIndex = 172;
            this.label72.Text = "Barcode QTY End";
            // 
            // chkbarcoderate
            // 
            this.chkbarcoderate.AutoSize = true;
            this.chkbarcoderate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkbarcoderate.ForeColor = System.Drawing.Color.Black;
            this.chkbarcoderate.Location = new System.Drawing.Point(9, 74);
            this.chkbarcoderate.Name = "chkbarcoderate";
            this.chkbarcoderate.Size = new System.Drawing.Size(146, 16);
            this.chkbarcoderate.TabIndex = 163;
            this.chkbarcoderate.Text = "Barcode rate enable";
            this.chkbarcoderate.UseVisualStyleBackColor = true;
            this.chkbarcoderate.CheckedChanged += new System.EventHandler(this.chkbarcoderate_CheckedChanged);
            // 
            // txtBcodeRateDivision
            // 
            this.txtBcodeRateDivision.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBcodeRateDivision.Location = new System.Drawing.Point(344, 100);
            this.txtBcodeRateDivision.Name = "txtBcodeRateDivision";
            this.txtBcodeRateDivision.Size = new System.Drawing.Size(87, 20);
            this.txtBcodeRateDivision.TabIndex = 182;
            // 
            // ChkbcodeQty
            // 
            this.ChkbcodeQty.AutoSize = true;
            this.ChkbcodeQty.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkbcodeQty.ForeColor = System.Drawing.Color.Black;
            this.ChkbcodeQty.Location = new System.Drawing.Point(160, 74);
            this.ChkbcodeQty.Name = "ChkbcodeQty";
            this.ChkbcodeQty.Size = new System.Drawing.Size(131, 16);
            this.ChkbcodeQty.TabIndex = 164;
            this.ChkbcodeQty.Text = "Bcode Qty enable";
            this.ChkbcodeQty.UseVisualStyleBackColor = true;
            this.ChkbcodeQty.CheckedChanged += new System.EventHandler(this.ChkbcodeQty_CheckedChanged);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label79.ForeColor = System.Drawing.Color.Black;
            this.label79.Location = new System.Drawing.Point(219, 102);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(119, 12);
            this.label79.TabIndex = 181;
            this.label79.Text = "BcodeRateDivision";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label70.ForeColor = System.Drawing.Color.Black;
            this.label70.Location = new System.Drawing.Point(10, 26);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(84, 12);
            this.label70.TabIndex = 166;
            this.label70.Text = "Barcodestart";
            // 
            // txtBcodeQTYDivision
            // 
            this.txtBcodeQTYDivision.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBcodeQTYDivision.Location = new System.Drawing.Point(129, 99);
            this.txtBcodeQTYDivision.Name = "txtBcodeQTYDivision";
            this.txtBcodeQTYDivision.Size = new System.Drawing.Size(87, 20);
            this.txtBcodeQTYDivision.TabIndex = 180;
            // 
            // txtbcodestart
            // 
            this.txtbcodestart.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcodestart.Location = new System.Drawing.Point(101, 27);
            this.txtbcodestart.Name = "txtbcodestart";
            this.txtbcodestart.Size = new System.Drawing.Size(46, 20);
            this.txtbcodestart.TabIndex = 165;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label78.ForeColor = System.Drawing.Color.Black;
            this.label78.Location = new System.Drawing.Point(11, 101);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(117, 12);
            this.label78.TabIndex = 179;
            this.label78.Text = "BcodeQTYDivision";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label71.ForeColor = System.Drawing.Color.Black;
            this.label71.Location = new System.Drawing.Point(11, 50);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(76, 12);
            this.label71.TabIndex = 168;
            this.label71.Text = "BarcodeEnd";
            // 
            // txtbcodeend
            // 
            this.txtbcodeend.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcodeend.Location = new System.Drawing.Point(101, 53);
            this.txtbcodeend.Name = "txtbcodeend";
            this.txtbcodeend.Size = new System.Drawing.Size(46, 20);
            this.txtbcodeend.TabIndex = 167;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.Blue;
            this.label76.Location = new System.Drawing.Point(11, 8);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(233, 15);
            this.label76.TabIndex = 177;
            this.label76.Text = "BarcodeSettings weighing mechine";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label73.ForeColor = System.Drawing.Color.Black;
            this.label73.Location = new System.Drawing.Point(150, 28);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(113, 12);
            this.label73.TabIndex = 170;
            this.label73.Text = "Barcode qty start";
            // 
            // txtbcoderateend
            // 
            this.txtbcoderateend.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcoderateend.Location = new System.Drawing.Point(448, 51);
            this.txtbcoderateend.Name = "txtbcoderateend";
            this.txtbcoderateend.Size = new System.Drawing.Size(46, 20);
            this.txtbcoderateend.TabIndex = 175;
            // 
            // txtqtystat
            // 
            this.txtqtystat.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtqtystat.Location = new System.Drawing.Point(264, 26);
            this.txtqtystat.Name = "txtqtystat";
            this.txtqtystat.Size = new System.Drawing.Size(46, 20);
            this.txtqtystat.TabIndex = 169;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(326, 52);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(108, 12);
            this.label74.TabIndex = 176;
            this.label74.Text = "BarcodeRate End";
            // 
            // txtqtyend
            // 
            this.txtqtyend.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtqtyend.Location = new System.Drawing.Point(262, 50);
            this.txtqtyend.Name = "txtqtyend";
            this.txtqtyend.Size = new System.Drawing.Size(46, 20);
            this.txtqtyend.TabIndex = 171;
            // 
            // txtbcoderatestart
            // 
            this.txtbcoderatestart.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcoderatestart.Location = new System.Drawing.Point(451, 27);
            this.txtbcoderatestart.Name = "txtbcoderatestart";
            this.txtbcoderatestart.Size = new System.Drawing.Size(46, 20);
            this.txtbcoderatestart.TabIndex = 173;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label75.ForeColor = System.Drawing.Color.Black;
            this.label75.Location = new System.Drawing.Point(325, 28);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(116, 12);
            this.label75.TabIndex = 174;
            this.label75.Text = "BarcodeRate start";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.panel4.Controls.Add(this.label86);
            this.panel4.Controls.Add(this.txtBcodetextPrefix);
            this.panel4.Controls.Add(this.label85);
            this.panel4.Controls.Add(this.label58);
            this.panel4.Controls.Add(this.TxtsstartingBarcode);
            this.panel4.Controls.Add(this.label64);
            this.panel4.Controls.Add(this.txtbcodeeprefix);
            this.panel4.Controls.Add(this.label59);
            this.panel4.Controls.Add(this.lblbcodedig);
            this.panel4.Controls.Add(this.txtbcodedegit);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 135);
            this.panel4.TabIndex = 183;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label86.ForeColor = System.Drawing.Color.Black;
            this.label86.Location = new System.Drawing.Point(101, 80);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(104, 12);
            this.label86.TabIndex = 149;
            this.label86.Text = "BcodeTextPrefix";
            // 
            // txtBcodetextPrefix
            // 
            this.txtBcodetextPrefix.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtBcodetextPrefix.Location = new System.Drawing.Point(121, 102);
            this.txtBcodetextPrefix.Multiline = true;
            this.txtBcodetextPrefix.Name = "txtBcodetextPrefix";
            this.txtBcodetextPrefix.Size = new System.Drawing.Size(86, 20);
            this.txtBcodetextPrefix.TabIndex = 148;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.ForeColor = System.Drawing.Color.Black;
            this.label85.Location = new System.Drawing.Point(140, 32);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(55, 12);
            this.label85.TabIndex = 146;
            this.label85.Text = "Mechine";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label58.Location = new System.Drawing.Point(12, 29);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(108, 12);
            this.label58.TabIndex = 137;
            this.label58.Text = "Starting Barcode";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Black;
            this.label64.Location = new System.Drawing.Point(124, 19);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(88, 12);
            this.label64.TabIndex = 29;
            this.label64.Text = "BarcodePrefix";
            // 
            // txtbcodeeprefix
            // 
            this.txtbcodeeprefix.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcodeeprefix.Location = new System.Drawing.Point(120, 50);
            this.txtbcodeeprefix.Name = "txtbcodeeprefix";
            this.txtbcodeeprefix.Size = new System.Drawing.Size(87, 20);
            this.txtbcodeeprefix.TabIndex = 28;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Blue;
            this.label59.Location = new System.Drawing.Point(5, 7);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(112, 15);
            this.label59.TabIndex = 145;
            this.label59.Text = "BarcodeSettings";
            // 
            // lblbcodedig
            // 
            this.lblbcodedig.AutoSize = true;
            this.lblbcodedig.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblbcodedig.ForeColor = System.Drawing.Color.Black;
            this.lblbcodedig.Location = new System.Drawing.Point(13, 80);
            this.lblbcodedig.Name = "lblbcodedig";
            this.lblbcodedig.Size = new System.Drawing.Size(73, 12);
            this.lblbcodedig.TabIndex = 31;
            this.lblbcodedig.Text = "BcodeDigit";
            // 
            // txtbcodedegit
            // 
            this.txtbcodedegit.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcodedegit.Location = new System.Drawing.Point(12, 100);
            this.txtbcodedegit.Name = "txtbcodedegit";
            this.txtbcodedegit.Size = new System.Drawing.Size(71, 20);
            this.txtbcodedegit.TabIndex = 30;
            // 
            // GrpBarcode
            // 
            this.GrpBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.GrpBarcode.Controls.Add(this.Chkpprintsecondlangague);
            this.GrpBarcode.Controls.Add(this.chkbarcodehusecompanyname);
            this.GrpBarcode.Controls.Add(this.label27);
            this.GrpBarcode.Controls.Add(this.txtbarcodeheading);
            this.GrpBarcode.Controls.Add(this.label19);
            this.GrpBarcode.Controls.Add(this.txtbarcodeprifix);
            this.GrpBarcode.Controls.Add(this.chkbsuppliercode);
            this.GrpBarcode.Controls.Add(this.chkbitemnote2);
            this.GrpBarcode.Controls.Add(this.chkbnote1);
            this.GrpBarcode.Controls.Add(this.chkbpackeddate);
            this.GrpBarcode.Controls.Add(this.panel2);
            this.GrpBarcode.Controls.Add(this.panel1);
            this.GrpBarcode.Controls.Add(this.label17);
            this.GrpBarcode.Controls.Add(this.label18);
            this.GrpBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBarcode.Location = new System.Drawing.Point(185, 158);
            this.GrpBarcode.Name = "GrpBarcode";
            this.GrpBarcode.Size = new System.Drawing.Size(548, 200);
            this.GrpBarcode.TabIndex = 138;
            this.GrpBarcode.TabStop = false;
            this.GrpBarcode.Text = "Barcode";
            // 
            // Chkpprintsecondlangague
            // 
            this.Chkpprintsecondlangague.AutoSize = true;
            this.Chkpprintsecondlangague.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Chkpprintsecondlangague.Location = new System.Drawing.Point(414, 139);
            this.Chkpprintsecondlangague.Name = "Chkpprintsecondlangague";
            this.Chkpprintsecondlangague.Size = new System.Drawing.Size(129, 21);
            this.Chkpprintsecondlangague.TabIndex = 149;
            this.Chkpprintsecondlangague.Text = "Print Second lgue";
            this.Chkpprintsecondlangague.UseVisualStyleBackColor = true;
            this.Chkpprintsecondlangague.CheckedChanged += new System.EventHandler(this.Chkpprintsecondlangague_CheckedChanged);
            // 
            // chkbarcodehusecompanyname
            // 
            this.chkbarcodehusecompanyname.AutoSize = true;
            this.chkbarcodehusecompanyname.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbarcodehusecompanyname.Location = new System.Drawing.Point(340, 155);
            this.chkbarcodehusecompanyname.Name = "chkbarcodehusecompanyname";
            this.chkbarcodehusecompanyname.Size = new System.Drawing.Size(160, 21);
            this.chkbarcodehusecompanyname.TabIndex = 148;
            this.chkbarcodehusecompanyname.Text = "Use as CompanyName";
            this.chkbarcodehusecompanyname.UseVisualStyleBackColor = true;
            this.chkbarcodehusecompanyname.CheckedChanged += new System.EventHandler(this.chkbarcodehusecompanyname_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(227, 172);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 17);
            this.label27.TabIndex = 147;
            this.label27.Text = "Barcode Heading";
            // 
            // txtbarcodeheading
            // 
            this.txtbarcodeheading.Location = new System.Drawing.Point(338, 172);
            this.txtbarcodeheading.Name = "txtbarcodeheading";
            this.txtbarcodeheading.Size = new System.Drawing.Size(100, 20);
            this.txtbarcodeheading.TabIndex = 146;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(13, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 17);
            this.label19.TabIndex = 145;
            this.label19.Text = "Barcode Prefix";
            // 
            // txtbarcodeprifix
            // 
            this.txtbarcodeprifix.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtbarcodeprifix.Location = new System.Drawing.Point(117, 169);
            this.txtbarcodeprifix.Name = "txtbarcodeprifix";
            this.txtbarcodeprifix.Size = new System.Drawing.Size(100, 25);
            this.txtbarcodeprifix.TabIndex = 144;
            // 
            // chkbsuppliercode
            // 
            this.chkbsuppliercode.AutoSize = true;
            this.chkbsuppliercode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbsuppliercode.Location = new System.Drawing.Point(295, 139);
            this.chkbsuppliercode.Name = "chkbsuppliercode";
            this.chkbsuppliercode.Size = new System.Drawing.Size(118, 21);
            this.chkbsuppliercode.TabIndex = 143;
            this.chkbsuppliercode.Text = "Inc.SpplierCode";
            this.chkbsuppliercode.UseVisualStyleBackColor = true;
            this.chkbsuppliercode.CheckedChanged += new System.EventHandler(this.chkbsuppliercode_CheckedChanged);
            // 
            // chkbitemnote2
            // 
            this.chkbitemnote2.AutoSize = true;
            this.chkbitemnote2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbitemnote2.Location = new System.Drawing.Point(216, 139);
            this.chkbitemnote2.Name = "chkbitemnote2";
            this.chkbitemnote2.Size = new System.Drawing.Size(82, 21);
            this.chkbitemnote2.TabIndex = 142;
            this.chkbitemnote2.Text = "Inc.Note2";
            this.chkbitemnote2.UseVisualStyleBackColor = true;
            this.chkbitemnote2.CheckedChanged += new System.EventHandler(this.chkbitemnote2_CheckedChanged);
            // 
            // chkbnote1
            // 
            this.chkbnote1.AutoSize = true;
            this.chkbnote1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbnote1.Location = new System.Drawing.Point(139, 140);
            this.chkbnote1.Name = "chkbnote1";
            this.chkbnote1.Size = new System.Drawing.Size(82, 21);
            this.chkbnote1.TabIndex = 141;
            this.chkbnote1.Text = "Inc.Note1";
            this.chkbnote1.UseVisualStyleBackColor = true;
            this.chkbnote1.CheckedChanged += new System.EventHandler(this.chkbnote1_CheckedChanged);
            // 
            // chkbpackeddate
            // 
            this.chkbpackeddate.AutoSize = true;
            this.chkbpackeddate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbpackeddate.Location = new System.Drawing.Point(0, 138);
            this.chkbpackeddate.Name = "chkbpackeddate";
            this.chkbpackeddate.Size = new System.Drawing.Size(142, 21);
            this.chkbpackeddate.TabIndex = 140;
            this.chkbpackeddate.Text = "Inc.Manfacture date";
            this.chkbpackeddate.UseVisualStyleBackColor = true;
            this.chkbpackeddate.CheckedChanged += new System.EventHandler(this.chkbpackeddate_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadBprintbutterfly);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.txtstickerprint);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.txtstartingbarcode);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.txtdistancebarcodesticker);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtlaserleftmargin);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtlasertopmargin);
            this.panel2.Controls.Add(this.RadBprintlaser);
            this.panel2.Controls.Add(this.RadBPrintRoll);
            this.panel2.Location = new System.Drawing.Point(14, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 41);
            this.panel2.TabIndex = 139;
            // 
            // RadBprintbutterfly
            // 
            this.RadBprintbutterfly.AutoSize = true;
            this.RadBprintbutterfly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBprintbutterfly.ForeColor = System.Drawing.Color.Black;
            this.RadBprintbutterfly.Location = new System.Drawing.Point(90, 17);
            this.RadBprintbutterfly.Name = "RadBprintbutterfly";
            this.RadBprintbutterfly.Size = new System.Drawing.Size(103, 21);
            this.RadBprintbutterfly.TabIndex = 148;
            this.RadBprintbutterfly.TabStop = true;
            this.RadBprintbutterfly.Text = "Print Butterfly";
            this.RadBprintbutterfly.UseVisualStyleBackColor = true;
            this.RadBprintbutterfly.CheckedChanged += new System.EventHandler(this.RadBprintbutterfly_CheckedChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(438, 3);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 12);
            this.label37.TabIndex = 147;
            this.label37.Text = "Sti.Print";
            // 
            // txtstickerprint
            // 
            this.txtstickerprint.Location = new System.Drawing.Point(437, 17);
            this.txtstickerprint.Name = "txtstickerprint";
            this.txtstickerprint.Size = new System.Drawing.Size(49, 20);
            this.txtstickerprint.TabIndex = 146;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(384, 2);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 12);
            this.label36.TabIndex = 145;
            this.label36.Text = "Sta.Bar";
            // 
            // txtstartingbarcode
            // 
            this.txtstartingbarcode.Location = new System.Drawing.Point(385, 16);
            this.txtstartingbarcode.Name = "txtstartingbarcode";
            this.txtstartingbarcode.Size = new System.Drawing.Size(49, 20);
            this.txtstartingbarcode.TabIndex = 144;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(321, 2);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 12);
            this.label31.TabIndex = 143;
            this.label31.Text = "Dis(Sticker)";
            // 
            // txtdistancebarcodesticker
            // 
            this.txtdistancebarcodesticker.Location = new System.Drawing.Point(322, 16);
            this.txtdistancebarcodesticker.Name = "txtdistancebarcodesticker";
            this.txtdistancebarcodesticker.Size = new System.Drawing.Size(49, 20);
            this.txtdistancebarcodesticker.TabIndex = 142;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(263, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 12);
            this.label22.TabIndex = 141;
            this.label22.Text = "Left Margin";
            // 
            // txtlaserleftmargin
            // 
            this.txtlaserleftmargin.Location = new System.Drawing.Point(264, 16);
            this.txtlaserleftmargin.Name = "txtlaserleftmargin";
            this.txtlaserleftmargin.Size = new System.Drawing.Size(49, 20);
            this.txtlaserleftmargin.TabIndex = 140;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(200, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 12);
            this.label21.TabIndex = 139;
            this.label21.Text = "Top Margin";
            // 
            // txtlasertopmargin
            // 
            this.txtlasertopmargin.Location = new System.Drawing.Point(201, 16);
            this.txtlasertopmargin.Name = "txtlasertopmargin";
            this.txtlasertopmargin.Size = new System.Drawing.Size(49, 20);
            this.txtlasertopmargin.TabIndex = 138;
            // 
            // RadBprintlaser
            // 
            this.RadBprintlaser.AutoSize = true;
            this.RadBprintlaser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBprintlaser.ForeColor = System.Drawing.Color.Black;
            this.RadBprintlaser.Location = new System.Drawing.Point(90, 0);
            this.RadBprintlaser.Name = "RadBprintlaser";
            this.RadBprintlaser.Size = new System.Drawing.Size(87, 21);
            this.RadBprintlaser.TabIndex = 137;
            this.RadBprintlaser.TabStop = true;
            this.RadBprintlaser.Text = "Print Laser";
            this.RadBprintlaser.UseVisualStyleBackColor = true;
            this.RadBprintlaser.CheckedChanged += new System.EventHandler(this.RadBprintlaser_CheckedChanged);
            // 
            // RadBPrintRoll
            // 
            this.RadBPrintRoll.AutoSize = true;
            this.RadBPrintRoll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadBPrintRoll.ForeColor = System.Drawing.Color.Black;
            this.RadBPrintRoll.Location = new System.Drawing.Point(9, 11);
            this.RadBPrintRoll.Name = "RadBPrintRoll";
            this.RadBPrintRoll.Size = new System.Drawing.Size(78, 21);
            this.RadBPrintRoll.TabIndex = 136;
            this.RadBPrintRoll.TabStop = true;
            this.RadBPrintRoll.Text = "Print Roll";
            this.RadBPrintRoll.UseVisualStyleBackColor = true;
            this.RadBPrintRoll.CheckedChanged += new System.EventHandler(this.RadBPrintRoll_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkprintbarcodelogo);
            this.panel1.Controls.Add(this.radprintratebyitems);
            this.panel1.Controls.Add(this.radbarcodeprintnone);
            this.panel1.Controls.Add(this.radbarcodeprintmrp);
            this.panel1.Controls.Add(this.radbarcodeprintsrate);
            this.panel1.Location = new System.Drawing.Point(14, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 37);
            this.panel1.TabIndex = 138;
            // 
            // chkprintbarcodelogo
            // 
            this.chkprintbarcodelogo.AutoSize = true;
            this.chkprintbarcodelogo.Location = new System.Drawing.Point(393, 12);
            this.chkprintbarcodelogo.Name = "chkprintbarcodelogo";
            this.chkprintbarcodelogo.Size = new System.Drawing.Size(84, 17);
            this.chkprintbarcodelogo.TabIndex = 146;
            this.chkprintbarcodelogo.Text = "Print Logo";
            this.chkprintbarcodelogo.UseVisualStyleBackColor = true;
            this.chkprintbarcodelogo.CheckedChanged += new System.EventHandler(this.chkprintbarcodelogo_CheckedChanged);
            // 
            // radprintratebyitems
            // 
            this.radprintratebyitems.AutoSize = true;
            this.radprintratebyitems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radprintratebyitems.ForeColor = System.Drawing.Color.Black;
            this.radprintratebyitems.Location = new System.Drawing.Point(253, 8);
            this.radprintratebyitems.Name = "radprintratebyitems";
            this.radprintratebyitems.Size = new System.Drawing.Size(144, 21);
            this.radprintratebyitems.TabIndex = 145;
            this.radprintratebyitems.TabStop = true;
            this.radprintratebyitems.Text = "Print Rate with Items";
            this.radprintratebyitems.UseVisualStyleBackColor = true;
            this.radprintratebyitems.CheckedChanged += new System.EventHandler(this.radprintratebyitems_CheckedChanged);
            // 
            // radbarcodeprintnone
            // 
            this.radbarcodeprintnone.AutoSize = true;
            this.radbarcodeprintnone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbarcodeprintnone.ForeColor = System.Drawing.Color.Black;
            this.radbarcodeprintnone.Location = new System.Drawing.Point(192, 8);
            this.radbarcodeprintnone.Name = "radbarcodeprintnone";
            this.radbarcodeprintnone.Size = new System.Drawing.Size(58, 21);
            this.radbarcodeprintnone.TabIndex = 138;
            this.radbarcodeprintnone.TabStop = true;
            this.radbarcodeprintnone.Text = "None";
            this.radbarcodeprintnone.UseVisualStyleBackColor = true;
            this.radbarcodeprintnone.CheckedChanged += new System.EventHandler(this.radbarcodeprintnone_CheckedChanged);
            // 
            // radbarcodeprintmrp
            // 
            this.radbarcodeprintmrp.AutoSize = true;
            this.radbarcodeprintmrp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbarcodeprintmrp.ForeColor = System.Drawing.Color.Black;
            this.radbarcodeprintmrp.Location = new System.Drawing.Point(109, 9);
            this.radbarcodeprintmrp.Name = "radbarcodeprintmrp";
            this.radbarcodeprintmrp.Size = new System.Drawing.Size(83, 21);
            this.radbarcodeprintmrp.TabIndex = 137;
            this.radbarcodeprintmrp.TabStop = true;
            this.radbarcodeprintmrp.Text = "Print MRP";
            this.radbarcodeprintmrp.UseVisualStyleBackColor = true;
            this.radbarcodeprintmrp.CheckedChanged += new System.EventHandler(this.radbarcodeprintmrp_CheckedChanged);
            // 
            // radbarcodeprintsrate
            // 
            this.radbarcodeprintsrate.AutoSize = true;
            this.radbarcodeprintsrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbarcodeprintsrate.ForeColor = System.Drawing.Color.Black;
            this.radbarcodeprintsrate.Location = new System.Drawing.Point(9, 9);
            this.radbarcodeprintsrate.Name = "radbarcodeprintsrate";
            this.radbarcodeprintsrate.Size = new System.Drawing.Size(86, 21);
            this.radbarcodeprintsrate.TabIndex = 136;
            this.radbarcodeprintsrate.TabStop = true;
            this.radbarcodeprintsrate.Text = "Print Srate";
            this.radbarcodeprintsrate.UseVisualStyleBackColor = true;
            this.radbarcodeprintsrate.CheckedChanged += new System.EventHandler(this.radbarcodeprintsrate_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(10, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 17);
            this.label17.TabIndex = 134;
            this.label17.Text = "Barcode Printing";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(12, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(431, 13);
            this.label18.TabIndex = 135;
            this.label18.Text = "---------------------------------------------------------------------------------" +
                "-------------------------";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(4, 85);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(52, 15);
            this.label63.TabIndex = 170;
            this.label63.Text = "IconEnd";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(4, 56);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(70, 15);
            this.label62.TabIndex = 168;
            this.label62.Text = "Iconstarting";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(4, 29);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(94, 15);
            this.label61.TabIndex = 166;
            this.label61.Text = "Iconsizethermal";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(180, 268);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(128, 12);
            this.label60.TabIndex = 163;
            this.label60.Text = "Itemcodewidthprint";
            // 
            // pnlvoucherType
            // 
            this.pnlvoucherType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlvoucherType.Controls.Add(this.ChkcreditlimitON);
            this.pnlvoucherType.Controls.Add(this.CHKTAILLOR);
            this.pnlvoucherType.Controls.Add(this.Chkpurchasereturn);
            this.pnlvoucherType.Controls.Add(this.Chksalesreturn);
            this.pnlvoucherType.Controls.Add(this.chkpurchaseestimation);
            this.pnlvoucherType.Controls.Add(this.chkpurchaseorder);
            this.pnlvoucherType.Controls.Add(this.chkmeterialreceipt);
            this.pnlvoucherType.Controls.Add(this.label5);
            this.pnlvoucherType.Controls.Add(this.label6);
            this.pnlvoucherType.Controls.Add(this.label20);
            this.pnlvoucherType.Controls.Add(this.label4);
            this.pnlvoucherType.Controls.Add(this.chksalesorder);
            this.pnlvoucherType.Controls.Add(this.chksalesestimation);
            this.pnlvoucherType.Controls.Add(this.chkdeliverynote);
            this.pnlvoucherType.Location = new System.Drawing.Point(152, 205);
            this.pnlvoucherType.Name = "pnlvoucherType";
            this.pnlvoucherType.Size = new System.Drawing.Size(744, 10);
            this.pnlvoucherType.TabIndex = 122;
            this.pnlvoucherType.Visible = false;
            // 
            // ChkcreditlimitON
            // 
            this.ChkcreditlimitON.AutoSize = true;
            this.ChkcreditlimitON.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkcreditlimitON.ForeColor = System.Drawing.Color.Black;
            this.ChkcreditlimitON.Location = new System.Drawing.Point(304, 70);
            this.ChkcreditlimitON.Name = "ChkcreditlimitON";
            this.ChkcreditlimitON.Size = new System.Drawing.Size(139, 16);
            this.ChkcreditlimitON.TabIndex = 131;
            this.ChkcreditlimitON.Text = "Credit limit On/Off";
            this.ChkcreditlimitON.UseVisualStyleBackColor = true;
            this.ChkcreditlimitON.CheckedChanged += new System.EventHandler(this.ChkcreditlimitON_CheckedChanged);
            // 
            // CHKTAILLOR
            // 
            this.CHKTAILLOR.AutoSize = true;
            this.CHKTAILLOR.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.CHKTAILLOR.ForeColor = System.Drawing.Color.Black;
            this.CHKTAILLOR.Location = new System.Drawing.Point(152, 69);
            this.CHKTAILLOR.Name = "CHKTAILLOR";
            this.CHKTAILLOR.Size = new System.Drawing.Size(79, 16);
            this.CHKTAILLOR.TabIndex = 130;
            this.CHKTAILLOR.Text = "Tailoring";
            this.CHKTAILLOR.UseVisualStyleBackColor = true;
            this.CHKTAILLOR.CheckedChanged += new System.EventHandler(this.CHKTAILLOR_CheckedChanged);
            // 
            // Chkpurchasereturn
            // 
            this.Chkpurchasereturn.AutoSize = true;
            this.Chkpurchasereturn.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkpurchasereturn.ForeColor = System.Drawing.Color.Black;
            this.Chkpurchasereturn.Location = new System.Drawing.Point(24, 171);
            this.Chkpurchasereturn.Name = "Chkpurchasereturn";
            this.Chkpurchasereturn.Size = new System.Drawing.Size(117, 16);
            this.Chkpurchasereturn.TabIndex = 129;
            this.Chkpurchasereturn.Text = "Purchase return";
            this.Chkpurchasereturn.UseVisualStyleBackColor = true;
            this.Chkpurchasereturn.CheckedChanged += new System.EventHandler(this.Chkpurchasereturn_CheckedChanged);
            // 
            // Chksalesreturn
            // 
            this.Chksalesreturn.AutoSize = true;
            this.Chksalesreturn.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chksalesreturn.ForeColor = System.Drawing.Color.Black;
            this.Chksalesreturn.Location = new System.Drawing.Point(24, 68);
            this.Chksalesreturn.Name = "Chksalesreturn";
            this.Chksalesreturn.Size = new System.Drawing.Size(99, 16);
            this.Chksalesreturn.TabIndex = 128;
            this.Chksalesreturn.Text = "Sales Return";
            this.Chksalesreturn.UseVisualStyleBackColor = true;
            this.Chksalesreturn.CheckedChanged += new System.EventHandler(this.Chksalesreturn_CheckedChanged);
            // 
            // chkpurchaseestimation
            // 
            this.chkpurchaseestimation.AutoSize = true;
            this.chkpurchaseestimation.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpurchaseestimation.ForeColor = System.Drawing.Color.Black;
            this.chkpurchaseestimation.Location = new System.Drawing.Point(304, 145);
            this.chkpurchaseestimation.Name = "chkpurchaseestimation";
            this.chkpurchaseestimation.Size = new System.Drawing.Size(145, 16);
            this.chkpurchaseestimation.TabIndex = 127;
            this.chkpurchaseestimation.Text = "Purchase Estimation";
            this.chkpurchaseestimation.UseVisualStyleBackColor = true;
            this.chkpurchaseestimation.CheckedChanged += new System.EventHandler(this.chkpurchaseestimation_CheckedChanged);
            // 
            // chkpurchaseorder
            // 
            this.chkpurchaseorder.AutoSize = true;
            this.chkpurchaseorder.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkpurchaseorder.ForeColor = System.Drawing.Color.Black;
            this.chkpurchaseorder.Location = new System.Drawing.Point(154, 145);
            this.chkpurchaseorder.Name = "chkpurchaseorder";
            this.chkpurchaseorder.Size = new System.Drawing.Size(114, 16);
            this.chkpurchaseorder.TabIndex = 126;
            this.chkpurchaseorder.Text = "Purchase Order";
            this.chkpurchaseorder.UseVisualStyleBackColor = true;
            this.chkpurchaseorder.CheckedChanged += new System.EventHandler(this.chkpurchaseorder_CheckedChanged);
            // 
            // chkmeterialreceipt
            // 
            this.chkmeterialreceipt.AutoSize = true;
            this.chkmeterialreceipt.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkmeterialreceipt.ForeColor = System.Drawing.Color.Black;
            this.chkmeterialreceipt.Location = new System.Drawing.Point(24, 145);
            this.chkmeterialreceipt.Name = "chkmeterialreceipt";
            this.chkmeterialreceipt.Size = new System.Drawing.Size(126, 16);
            this.chkmeterialreceipt.TabIndex = 125;
            this.chkmeterialreceipt.Text = "Material Receipt";
            this.chkmeterialreceipt.UseVisualStyleBackColor = true;
            this.chkmeterialreceipt.CheckedChanged += new System.EventHandler(this.chkmeterialreceipt_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(22, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 12);
            this.label5.TabIndex = 124;
            this.label5.Text = "-----------------------------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 123;
            this.label6.Text = "Purchase";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(22, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(236, 12);
            this.label20.TabIndex = 121;
            this.label20.Text = "-----------------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 120;
            this.label4.Text = "Sales";
            // 
            // chksalesorder
            // 
            this.chksalesorder.AutoSize = true;
            this.chksalesorder.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksalesorder.ForeColor = System.Drawing.Color.Black;
            this.chksalesorder.Location = new System.Drawing.Point(304, 43);
            this.chksalesorder.Name = "chksalesorder";
            this.chksalesorder.Size = new System.Drawing.Size(93, 16);
            this.chksalesorder.TabIndex = 119;
            this.chksalesorder.Text = "Sales Order";
            this.chksalesorder.UseVisualStyleBackColor = true;
            this.chksalesorder.CheckedChanged += new System.EventHandler(this.chksalesorder_CheckedChanged);
            // 
            // chksalesestimation
            // 
            this.chksalesestimation.AutoSize = true;
            this.chksalesestimation.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chksalesestimation.ForeColor = System.Drawing.Color.Black;
            this.chksalesestimation.Location = new System.Drawing.Point(154, 43);
            this.chksalesestimation.Name = "chksalesestimation";
            this.chksalesestimation.Size = new System.Drawing.Size(124, 16);
            this.chksalesestimation.TabIndex = 118;
            this.chksalesestimation.Text = "Sales Estimation";
            this.chksalesestimation.UseVisualStyleBackColor = true;
            this.chksalesestimation.CheckedChanged += new System.EventHandler(this.chksalesestimation_CheckedChanged);
            // 
            // chkdeliverynote
            // 
            this.chkdeliverynote.AutoSize = true;
            this.chkdeliverynote.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkdeliverynote.ForeColor = System.Drawing.Color.Black;
            this.chkdeliverynote.Location = new System.Drawing.Point(24, 43);
            this.chkdeliverynote.Name = "chkdeliverynote";
            this.chkdeliverynote.Size = new System.Drawing.Size(107, 16);
            this.chkdeliverynote.TabIndex = 117;
            this.chkdeliverynote.Text = "Delivery Note";
            this.chkdeliverynote.UseVisualStyleBackColor = true;
            this.chkdeliverynote.CheckedChanged += new System.EventHandler(this.chkdeliverynote_CheckedChanged);
            // 
            // pnldefault
            // 
            this.pnldefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldefault.Controls.Add(this.chkdatewisectrlreport);
            this.pnldefault.Controls.Add(this.chkbottomstock);
            this.pnldefault.Controls.Add(this.chkstockshow);
            this.pnldefault.Controls.Add(this.txttaxpercset);
            this.pnldefault.Controls.Add(this.lbltaxperc);
            this.pnldefault.Controls.Add(this.Comtaxinclusivesales);
            this.pnldefault.Controls.Add(this.label47);
            this.pnldefault.Controls.Add(this.ComLanguage);
            this.pnldefault.Controls.Add(this.commodeofpaymentsales);
            this.pnldefault.Controls.Add(this.label43);
            this.pnldefault.Controls.Add(this.label39);
            this.pnldefault.Controls.Add(this.commodeofpaymentpurchase);
            this.pnldefault.Controls.Add(this.label38);
            this.pnldefault.Controls.Add(this.comdeftax);
            this.pnldefault.Controls.Add(this.label11);
            this.pnldefault.Controls.Add(this.comdefcashaccount);
            this.pnldefault.Controls.Add(this.label10);
            this.pnldefault.Controls.Add(this.Comdefstockarea);
            this.pnldefault.Controls.Add(this.label9);
            this.pnldefault.Controls.Add(this.Comdefsalesman);
            this.pnldefault.Controls.Add(this.label8);
            this.pnldefault.Controls.Add(this.Comdefbank);
            this.pnldefault.Controls.Add(this.label7);
            this.pnldefault.Location = new System.Drawing.Point(149, 113);
            this.pnldefault.Name = "pnldefault";
            this.pnldefault.Size = new System.Drawing.Size(754, 10);
            this.pnldefault.TabIndex = 123;
            this.pnldefault.Visible = false;
            this.pnldefault.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldefault_Paint);
            // 
            // chkdatewisectrlreport
            // 
            this.chkdatewisectrlreport.AutoSize = true;
            this.chkdatewisectrlreport.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkdatewisectrlreport.ForeColor = System.Drawing.Color.Black;
            this.chkdatewisectrlreport.Location = new System.Drawing.Point(387, 14);
            this.chkdatewisectrlreport.Name = "chkdatewisectrlreport";
            this.chkdatewisectrlreport.Size = new System.Drawing.Size(175, 18);
            this.chkdatewisectrlreport.TabIndex = 150;
            this.chkdatewisectrlreport.Text = "Date wise Ctrl Q Report";
            this.chkdatewisectrlreport.UseVisualStyleBackColor = true;
            this.chkdatewisectrlreport.CheckedChanged += new System.EventHandler(this.chkdatewisectrlreport_CheckedChanged);
            // 
            // chkbottomstock
            // 
            this.chkbottomstock.AutoSize = true;
            this.chkbottomstock.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbottomstock.ForeColor = System.Drawing.Color.Black;
            this.chkbottomstock.Location = new System.Drawing.Point(384, 100);
            this.chkbottomstock.Name = "chkbottomstock";
            this.chkbottomstock.Size = new System.Drawing.Size(142, 18);
            this.chkbottomstock.TabIndex = 149;
            this.chkbottomstock.Text = "Stockshow bottom";
            this.chkbottomstock.UseVisualStyleBackColor = true;
            this.chkbottomstock.CheckedChanged += new System.EventHandler(this.chkbottomstock_CheckedChanged);
            // 
            // chkstockshow
            // 
            this.chkstockshow.AutoSize = true;
            this.chkstockshow.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkstockshow.ForeColor = System.Drawing.Color.Black;
            this.chkstockshow.Location = new System.Drawing.Point(384, 80);
            this.chkstockshow.Name = "chkstockshow";
            this.chkstockshow.Size = new System.Drawing.Size(120, 18);
            this.chkstockshow.TabIndex = 148;
            this.chkstockshow.Text = "Stock show list";
            this.chkstockshow.UseVisualStyleBackColor = true;
            this.chkstockshow.CheckedChanged += new System.EventHandler(this.chkstockshow_CheckedChanged);
            // 
            // lbltaxperc
            // 
            this.lbltaxperc.AutoSize = true;
            this.lbltaxperc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbltaxperc.ForeColor = System.Drawing.Color.Black;
            this.lbltaxperc.Location = new System.Drawing.Point(23, 339);
            this.lbltaxperc.Name = "lbltaxperc";
            this.lbltaxperc.Size = new System.Drawing.Size(35, 12);
            this.lbltaxperc.TabIndex = 28;
            this.lbltaxperc.Text = "Tax%";
            // 
            // Comtaxinclusivesales
            // 
            this.Comtaxinclusivesales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comtaxinclusivesales.DropDownWidth = 142;
            this.Comtaxinclusivesales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comtaxinclusivesales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comtaxinclusivesales.FormattingEnabled = true;
            this.Comtaxinclusivesales.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Comtaxinclusivesales.Location = new System.Drawing.Point(216, 300);
            this.Comtaxinclusivesales.Name = "Comtaxinclusivesales";
            this.Comtaxinclusivesales.Size = new System.Drawing.Size(142, 20);
            this.Comtaxinclusivesales.TabIndex = 27;
            this.Comtaxinclusivesales.SelectedIndexChanged += new System.EventHandler(this.Comtaxinclusivesales_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(17, 300);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(118, 12);
            this.label47.TabIndex = 26;
            this.label47.Text = "Tax Inclusive sales";
            // 
            // ComLanguage
            // 
            this.ComLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComLanguage.DropDownWidth = 142;
            this.ComLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComLanguage.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComLanguage.FormattingEnabled = true;
            this.ComLanguage.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.ComLanguage.Location = new System.Drawing.Point(214, 263);
            this.ComLanguage.Name = "ComLanguage";
            this.ComLanguage.Size = new System.Drawing.Size(142, 20);
            this.ComLanguage.TabIndex = 25;
            // 
            // commodeofpaymentsales
            // 
            this.commodeofpaymentsales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commodeofpaymentsales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commodeofpaymentsales.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.commodeofpaymentsales.FormattingEnabled = true;
            this.commodeofpaymentsales.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.commodeofpaymentsales.Location = new System.Drawing.Point(214, 222);
            this.commodeofpaymentsales.Name = "commodeofpaymentsales";
            this.commodeofpaymentsales.Size = new System.Drawing.Size(142, 20);
            this.commodeofpaymentsales.TabIndex = 23;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(15, 263);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(62, 12);
            this.label43.TabIndex = 24;
            this.label43.Text = "Language";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(15, 225);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(150, 12);
            this.label39.TabIndex = 24;
            this.label39.Text = "Mode of Payment(Sales)";
            // 
            // commodeofpaymentpurchase
            // 
            this.commodeofpaymentpurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commodeofpaymentpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commodeofpaymentpurchase.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.commodeofpaymentpurchase.FormattingEnabled = true;
            this.commodeofpaymentpurchase.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.commodeofpaymentpurchase.Location = new System.Drawing.Point(216, 186);
            this.commodeofpaymentpurchase.Name = "commodeofpaymentpurchase";
            this.commodeofpaymentpurchase.Size = new System.Drawing.Size(138, 20);
            this.commodeofpaymentpurchase.TabIndex = 21;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(14, 189);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(173, 12);
            this.label38.TabIndex = 22;
            this.label38.Text = "Mode of payment(Purchase)";
            // 
            // comdeftax
            // 
            this.comdeftax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comdeftax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comdeftax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.comdeftax.FormattingEnabled = true;
            this.comdeftax.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.comdeftax.Location = new System.Drawing.Point(215, 148);
            this.comdeftax.Name = "comdeftax";
            this.comdeftax.Size = new System.Drawing.Size(140, 20);
            this.comdeftax.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tax";
            // 
            // comdefcashaccount
            // 
            this.comdefcashaccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comdefcashaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comdefcashaccount.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.comdefcashaccount.FormattingEnabled = true;
            this.comdefcashaccount.Location = new System.Drawing.Point(215, 12);
            this.comdefcashaccount.Name = "comdefcashaccount";
            this.comdefcashaccount.Size = new System.Drawing.Size(140, 20);
            this.comdefcashaccount.TabIndex = 17;
            this.comdefcashaccount.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cash Account";
            this.label10.Visible = false;
            // 
            // Comdefstockarea
            // 
            this.Comdefstockarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comdefstockarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comdefstockarea.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comdefstockarea.FormattingEnabled = true;
            this.Comdefstockarea.Location = new System.Drawing.Point(215, 113);
            this.Comdefstockarea.Name = "Comdefstockarea";
            this.Comdefstockarea.Size = new System.Drawing.Size(140, 20);
            this.Comdefstockarea.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "StockArea";
            // 
            // Comdefsalesman
            // 
            this.Comdefsalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comdefsalesman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comdefsalesman.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comdefsalesman.FormattingEnabled = true;
            this.Comdefsalesman.Location = new System.Drawing.Point(215, 79);
            this.Comdefsalesman.Name = "Comdefsalesman";
            this.Comdefsalesman.Size = new System.Drawing.Size(140, 20);
            this.Comdefsalesman.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salesman";
            // 
            // Comdefbank
            // 
            this.Comdefbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comdefbank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comdefbank.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comdefbank.FormattingEnabled = true;
            this.Comdefbank.Location = new System.Drawing.Point(215, 45);
            this.Comdefbank.Name = "Comdefbank";
            this.Comdefbank.Size = new System.Drawing.Size(140, 20);
            this.Comdefbank.TabIndex = 11;
            this.Comdefbank.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bank Account";
            this.label7.Visible = false;
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGeneral.Controls.Add(this.chkitemlistview);
            this.PnlGeneral.Controls.Add(this.panelfootr);
            this.PnlGeneral.Controls.Add(this.label56);
            this.PnlGeneral.Controls.Add(this.label57);
            this.PnlGeneral.Controls.Add(this.label55);
            this.PnlGeneral.Controls.Add(this.ChkfootMid);
            this.PnlGeneral.Controls.Add(this.Cmdfooterset);
            this.PnlGeneral.Controls.Add(this.chkfootpostn);
            this.PnlGeneral.Controls.Add(this.chkprintfooter);
            this.PnlGeneral.Controls.Add(this.chkservices);
            this.PnlGeneral.Controls.Add(this.Chksinglebarcode);
            this.PnlGeneral.Controls.Add(this.chkepartyproject);
            this.PnlGeneral.Controls.Add(this.Grpbatchenable);
            this.PnlGeneral.Controls.Add(this.chkroundoff);
            this.PnlGeneral.Controls.Add(this.ChkItemwiseagentcomm);
            this.PnlGeneral.Controls.Add(this.Chkepayroll);
            this.PnlGeneral.Controls.Add(this.ChkEPOS);
            this.PnlGeneral.Controls.Add(this.ChkEBatch);
            this.PnlGeneral.Controls.Add(this.groupBox2);
            this.PnlGeneral.Location = new System.Drawing.Point(145, 353);
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.Size = new System.Drawing.Size(739, 29);
            this.PnlGeneral.TabIndex = 125;
            this.PnlGeneral.Visible = false;
            this.PnlGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGeneral_Paint);
            // 
            // chkitemlistview
            // 
            this.chkitemlistview.AutoSize = true;
            this.chkitemlistview.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkitemlistview.ForeColor = System.Drawing.Color.Black;
            this.chkitemlistview.Location = new System.Drawing.Point(18, 121);
            this.chkitemlistview.Name = "chkitemlistview";
            this.chkitemlistview.Size = new System.Drawing.Size(100, 16);
            this.chkitemlistview.TabIndex = 169;
            this.chkitemlistview.Text = "Itemlistview";
            this.chkitemlistview.UseVisualStyleBackColor = true;
            this.chkitemlistview.CheckedChanged += new System.EventHandler(this.chkitemlistview_CheckedChanged);
            // 
            // panelfootr
            // 
            this.panelfootr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.panelfootr.Controls.Add(this.txtfarab);
            this.panelfootr.Controls.Add(this.txtL5);
            this.panelfootr.Controls.Add(this.txtL4);
            this.panelfootr.Controls.Add(this.txtL3);
            this.panelfootr.Controls.Add(this.txtL2);
            this.panelfootr.Controls.Add(this.label53);
            this.panelfootr.Controls.Add(this.label52);
            this.panelfootr.Controls.Add(this.label51);
            this.panelfootr.Controls.Add(this.label50);
            this.panelfootr.Controls.Add(this.label49);
            this.panelfootr.Controls.Add(this.cmdFclose);
            this.panelfootr.Controls.Add(this.pictureBox1);
            this.panelfootr.Location = new System.Drawing.Point(364, 45);
            this.panelfootr.Name = "panelfootr";
            this.panelfootr.Size = new System.Drawing.Size(367, 174);
            this.panelfootr.TabIndex = 125;
            this.panelfootr.Visible = false;
            this.panelfootr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfootr_Paint);
            // 
            // txtL5
            // 
            this.txtL5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtL5.Location = new System.Drawing.Point(52, 140);
            this.txtL5.Name = "txtL5";
            this.txtL5.Size = new System.Drawing.Size(279, 25);
            this.txtL5.TabIndex = 11;
            this.txtL5.TextChanged += new System.EventHandler(this.txtL5_TextChanged);
            // 
            // txtL4
            // 
            this.txtL4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtL4.Location = new System.Drawing.Point(53, 109);
            this.txtL4.Name = "txtL4";
            this.txtL4.Size = new System.Drawing.Size(279, 25);
            this.txtL4.TabIndex = 10;
            this.txtL4.TextChanged += new System.EventHandler(this.txtL4_TextChanged);
            // 
            // txtL3
            // 
            this.txtL3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtL3.Location = new System.Drawing.Point(54, 77);
            this.txtL3.Name = "txtL3";
            this.txtL3.Size = new System.Drawing.Size(279, 25);
            this.txtL3.TabIndex = 9;
            this.txtL3.TextChanged += new System.EventHandler(this.txtL3_TextChanged);
            // 
            // txtL2
            // 
            this.txtL2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtL2.Location = new System.Drawing.Point(53, 49);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(279, 25);
            this.txtL2.TabIndex = 8;
            this.txtL2.TextChanged += new System.EventHandler(this.txtL2_TextChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label53.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(9, 144);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(36, 12);
            this.label53.TabIndex = 6;
            this.label53.Text = "Line5";
            this.label53.Click += new System.EventHandler(this.label53_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label52.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(11, 117);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(36, 12);
            this.label52.TabIndex = 5;
            this.label52.Text = "Line4";
            this.label52.Click += new System.EventHandler(this.label52_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label51.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(10, 85);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(36, 12);
            this.label51.TabIndex = 4;
            this.label51.Text = "Line3";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label50.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(11, 54);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(36, 12);
            this.label50.TabIndex = 3;
            this.label50.Text = "Line2";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label49.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(11, 22);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(36, 12);
            this.label49.TabIndex = 2;
            this.label49.Text = "Line1";
            this.label49.Click += new System.EventHandler(this.label49_Click);
            // 
            // cmdFclose
            // 
            this.cmdFclose.BackColor = System.Drawing.Color.Crimson;
            this.cmdFclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFclose.ForeColor = System.Drawing.Color.White;
            this.cmdFclose.Location = new System.Drawing.Point(336, -1);
            this.cmdFclose.Name = "cmdFclose";
            this.cmdFclose.Size = new System.Drawing.Size(31, 23);
            this.cmdFclose.TabIndex = 0;
            this.cmdFclose.Text = "X";
            this.cmdFclose.UseVisualStyleBackColor = false;
            this.cmdFclose.Click += new System.EventHandler(this.cmdFclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 168);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(18, 414);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(21, 12);
            this.label56.TabIndex = 168;
            this.label56.Text = "To";
            this.label56.Visible = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Location = new System.Drawing.Point(18, 390);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(34, 12);
            this.label57.TabIndex = 166;
            this.label57.Text = "From";
            this.label57.Visible = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label55.Location = new System.Drawing.Point(19, 365);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(80, 12);
            this.label55.TabIndex = 134;
            this.label55.Text = "Report Time";
            this.label55.Visible = false;
            // 
            // ChkfootMid
            // 
            this.ChkfootMid.AutoSize = true;
            this.ChkfootMid.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkfootMid.Location = new System.Drawing.Point(567, 24);
            this.ChkfootMid.Name = "ChkfootMid";
            this.ChkfootMid.Size = new System.Drawing.Size(110, 16);
            this.ChkfootMid.TabIndex = 133;
            this.ChkfootMid.Text = "Footer Middle";
            this.ChkfootMid.UseVisualStyleBackColor = true;
            this.ChkfootMid.CheckedChanged += new System.EventHandler(this.ChkfootMid_CheckedChanged);
            // 
            // Cmdfooterset
            // 
            this.Cmdfooterset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmdfooterset.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Cmdfooterset.Location = new System.Drawing.Point(478, 6);
            this.Cmdfooterset.Name = "Cmdfooterset";
            this.Cmdfooterset.Size = new System.Drawing.Size(83, 26);
            this.Cmdfooterset.TabIndex = 132;
            this.Cmdfooterset.Text = "Footer set";
            this.Cmdfooterset.UseVisualStyleBackColor = true;
            this.Cmdfooterset.Click += new System.EventHandler(this.Cmdfooterset_Click);
            // 
            // chkfootpostn
            // 
            this.chkfootpostn.AutoSize = true;
            this.chkfootpostn.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkfootpostn.Location = new System.Drawing.Point(567, 6);
            this.chkfootpostn.Name = "chkfootpostn";
            this.chkfootpostn.Size = new System.Drawing.Size(131, 16);
            this.chkfootpostn.TabIndex = 124;
            this.chkfootpostn.Text = "Footer(Right-left)";
            this.chkfootpostn.UseVisualStyleBackColor = true;
            this.chkfootpostn.CheckedChanged += new System.EventHandler(this.chkfootpostn_CheckedChanged);
            // 
            // chkprintfooter
            // 
            this.chkprintfooter.AutoSize = true;
            this.chkprintfooter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkprintfooter.Location = new System.Drawing.Point(381, 12);
            this.chkprintfooter.Name = "chkprintfooter";
            this.chkprintfooter.Size = new System.Drawing.Size(98, 19);
            this.chkprintfooter.TabIndex = 122;
            this.chkprintfooter.Text = "Footer -Print";
            this.chkprintfooter.UseVisualStyleBackColor = true;
            this.chkprintfooter.CheckedChanged += new System.EventHandler(this.chkprintfooter_CheckedChanged);
            // 
            // chkservices
            // 
            this.chkservices.AutoSize = true;
            this.chkservices.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkservices.Location = new System.Drawing.Point(18, 103);
            this.chkservices.Name = "chkservices";
            this.chkservices.Size = new System.Drawing.Size(74, 16);
            this.chkservices.TabIndex = 121;
            this.chkservices.Text = "Services";
            this.chkservices.UseVisualStyleBackColor = true;
            this.chkservices.CheckedChanged += new System.EventHandler(this.chkservices_CheckedChanged);
            // 
            // Chksinglebarcode
            // 
            this.Chksinglebarcode.AutoSize = true;
            this.Chksinglebarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chksinglebarcode.ForeColor = System.Drawing.Color.Black;
            this.Chksinglebarcode.Location = new System.Drawing.Point(231, 77);
            this.Chksinglebarcode.Name = "Chksinglebarcode";
            this.Chksinglebarcode.Size = new System.Drawing.Size(114, 21);
            this.Chksinglebarcode.TabIndex = 120;
            this.Chksinglebarcode.Text = "Single Barcode";
            this.Chksinglebarcode.UseVisualStyleBackColor = true;
            this.Chksinglebarcode.CheckedChanged += new System.EventHandler(this.Chksinglebarcode_CheckedChanged);
            // 
            // chkepartyproject
            // 
            this.chkepartyproject.AutoSize = true;
            this.chkepartyproject.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkepartyproject.ForeColor = System.Drawing.Color.Black;
            this.chkepartyproject.Location = new System.Drawing.Point(18, 83);
            this.chkepartyproject.Name = "chkepartyproject";
            this.chkepartyproject.Size = new System.Drawing.Size(148, 16);
            this.chkepartyproject.TabIndex = 119;
            this.chkepartyproject.Text = "Enable Party project";
            this.chkepartyproject.UseVisualStyleBackColor = true;
            this.chkepartyproject.CheckedChanged += new System.EventHandler(this.chkepartyproject_CheckedChanged);
            // 
            // Grpbatchenable
            // 
            this.Grpbatchenable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Grpbatchenable.Controls.Add(this.chkuseasbarcode);
            this.Grpbatchenable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grpbatchenable.Location = new System.Drawing.Point(230, 30);
            this.Grpbatchenable.Name = "Grpbatchenable";
            this.Grpbatchenable.Size = new System.Drawing.Size(127, 45);
            this.Grpbatchenable.TabIndex = 118;
            this.Grpbatchenable.TabStop = false;
            this.Grpbatchenable.Text = "Batch";
            // 
            // chkuseasbarcode
            // 
            this.chkuseasbarcode.AutoSize = true;
            this.chkuseasbarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkuseasbarcode.ForeColor = System.Drawing.Color.Black;
            this.chkuseasbarcode.Location = new System.Drawing.Point(5, 18);
            this.chkuseasbarcode.Name = "chkuseasbarcode";
            this.chkuseasbarcode.Size = new System.Drawing.Size(118, 21);
            this.chkuseasbarcode.TabIndex = 117;
            this.chkuseasbarcode.Text = "Use as Barcode";
            this.chkuseasbarcode.UseVisualStyleBackColor = true;
            this.chkuseasbarcode.CheckedChanged += new System.EventHandler(this.chkuseasbarcode_CheckedChanged);
            // 
            // chkroundoff
            // 
            this.chkroundoff.AutoSize = true;
            this.chkroundoff.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkroundoff.ForeColor = System.Drawing.Color.Black;
            this.chkroundoff.Location = new System.Drawing.Point(19, 27);
            this.chkroundoff.Name = "chkroundoff";
            this.chkroundoff.Size = new System.Drawing.Size(80, 16);
            this.chkroundoff.TabIndex = 117;
            this.chkroundoff.Text = "Roundoff";
            this.chkroundoff.UseVisualStyleBackColor = true;
            this.chkroundoff.CheckedChanged += new System.EventHandler(this.chkroundoff_CheckedChanged);
            // 
            // ChkItemwiseagentcomm
            // 
            this.ChkItemwiseagentcomm.AutoSize = true;
            this.ChkItemwiseagentcomm.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkItemwiseagentcomm.ForeColor = System.Drawing.Color.Black;
            this.ChkItemwiseagentcomm.Location = new System.Drawing.Point(19, 7);
            this.ChkItemwiseagentcomm.Name = "ChkItemwiseagentcomm";
            this.ChkItemwiseagentcomm.Size = new System.Drawing.Size(195, 16);
            this.ChkItemwiseagentcomm.TabIndex = 106;
            this.ChkItemwiseagentcomm.Text = "Item Wise Agent Commission";
            this.ChkItemwiseagentcomm.UseVisualStyleBackColor = true;
            this.ChkItemwiseagentcomm.CheckedChanged += new System.EventHandler(this.ChkItemwiseagentcomm_CheckedChanged);
            // 
            // Chkepayroll
            // 
            this.Chkepayroll.AutoSize = true;
            this.Chkepayroll.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkepayroll.ForeColor = System.Drawing.Color.Black;
            this.Chkepayroll.Location = new System.Drawing.Point(19, 64);
            this.Chkepayroll.Name = "Chkepayroll";
            this.Chkepayroll.Size = new System.Drawing.Size(109, 16);
            this.Chkepayroll.TabIndex = 115;
            this.Chkepayroll.Text = "Enable Payroll";
            this.Chkepayroll.UseVisualStyleBackColor = true;
            this.Chkepayroll.CheckedChanged += new System.EventHandler(this.Chkepayroll_CheckedChanged);
            // 
            // ChkEPOS
            // 
            this.ChkEPOS.AutoSize = true;
            this.ChkEPOS.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkEPOS.ForeColor = System.Drawing.Color.Black;
            this.ChkEPOS.Location = new System.Drawing.Point(19, 46);
            this.ChkEPOS.Name = "ChkEPOS";
            this.ChkEPOS.Size = new System.Drawing.Size(90, 16);
            this.ChkEPOS.TabIndex = 114;
            this.ChkEPOS.Text = "Enable POS";
            this.ChkEPOS.UseVisualStyleBackColor = true;
            this.ChkEPOS.CheckedChanged += new System.EventHandler(this.ChkEPOS_CheckedChanged);
            // 
            // ChkEBatch
            // 
            this.ChkEBatch.AutoSize = true;
            this.ChkEBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEBatch.ForeColor = System.Drawing.Color.Black;
            this.ChkEBatch.Location = new System.Drawing.Point(229, 6);
            this.ChkEBatch.Name = "ChkEBatch";
            this.ChkEBatch.Size = new System.Drawing.Size(118, 21);
            this.ChkEBatch.TabIndex = 113;
            this.ChkEBatch.Text = "Enable Barcode";
            this.ChkEBatch.UseVisualStyleBackColor = true;
            this.ChkEBatch.CheckedChanged += new System.EventHandler(this.ChkEBatch_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.label98);
            this.groupBox2.Controls.Add(this.COMCASHSYMBOL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ComstockDeci);
            this.groupBox2.Controls.Add(this.TxtMinerSymbol);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtMajorSymbol);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.ComCurDecimal);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 99);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decimal";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(155, 72);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(76, 15);
            this.label98.TabIndex = 35;
            this.label98.Text = "Cash Symbol";
            // 
            // COMCASHSYMBOL
            // 
            this.COMCASHSYMBOL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMCASHSYMBOL.FormattingEnabled = true;
            this.COMCASHSYMBOL.Items.AddRange(new object[] {
            " ₹",
            "SAR",
            "AED",
            "£",
            "$",
            "¥",
            "৳",
            "﷼",
            "KWD(ك)",
            "BHD",
            "QAR",
            "Є",
            "£L ",
            "RM",
            "Rs",
            "₱",
            "₩",
            "₽"});
            this.COMCASHSYMBOL.Location = new System.Drawing.Point(237, 67);
            this.COMCASHSYMBOL.Name = "COMCASHSYMBOL";
            this.COMCASHSYMBOL.Size = new System.Drawing.Size(66, 21);
            this.COMCASHSYMBOL.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock.Deci";
            // 
            // ComstockDeci
            // 
            this.ComstockDeci.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComstockDeci.FormattingEnabled = true;
            this.ComstockDeci.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComstockDeci.Location = new System.Drawing.Point(96, 43);
            this.ComstockDeci.Name = "ComstockDeci";
            this.ComstockDeci.Size = new System.Drawing.Size(42, 20);
            this.ComstockDeci.TabIndex = 30;
            // 
            // TxtMinerSymbol
            // 
            this.TxtMinerSymbol.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtMinerSymbol.Location = new System.Drawing.Point(238, 43);
            this.TxtMinerSymbol.Name = "TxtMinerSymbol";
            this.TxtMinerSymbol.Size = new System.Drawing.Size(66, 20);
            this.TxtMinerSymbol.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(145, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "Minor Symbol";
            // 
            // TxtMajorSymbol
            // 
            this.TxtMajorSymbol.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtMajorSymbol.Location = new System.Drawing.Point(235, 16);
            this.TxtMajorSymbol.Name = "TxtMajorSymbol";
            this.TxtMajorSymbol.Size = new System.Drawing.Size(66, 20);
            this.TxtMajorSymbol.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "Major Symbol";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "Currency.Deci";
            // 
            // ComCurDecimal
            // 
            this.ComCurDecimal.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ComCurDecimal.FormattingEnabled = true;
            this.ComCurDecimal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComCurDecimal.Location = new System.Drawing.Point(97, 16);
            this.ComCurDecimal.Name = "ComCurDecimal";
            this.ComCurDecimal.Size = new System.Drawing.Size(42, 20);
            this.ComCurDecimal.TabIndex = 0;
            // 
            // pnlwarnings
            // 
            this.pnlwarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlwarnings.Controls.Add(this.Comwarnsaleratelessthanretailrate);
            this.pnlwarnings.Controls.Add(this.label68);
            this.pnlwarnings.Controls.Add(this.Comwarnsaleratelessthanprate);
            this.pnlwarnings.Controls.Add(this.label46);
            this.pnlwarnings.Controls.Add(this.Comwarnmaximumstock);
            this.pnlwarnings.Controls.Add(this.lblwarnmaximumstock);
            this.pnlwarnings.Controls.Add(this.Comwarnreorderstock);
            this.pnlwarnings.Controls.Add(this.label44);
            this.pnlwarnings.Controls.Add(this.Comwarnminimumstock);
            this.pnlwarnings.Controls.Add(this.label45);
            this.pnlwarnings.Controls.Add(this.Comwarnnegetivestock);
            this.pnlwarnings.Controls.Add(this.label42);
            this.pnlwarnings.Controls.Add(this.comwarnnegetivecash);
            this.pnlwarnings.Controls.Add(this.label25);
            this.pnlwarnings.Controls.Add(this.comwarncreditlimit);
            this.pnlwarnings.Controls.Add(this.label24);
            this.pnlwarnings.Location = new System.Drawing.Point(154, 523);
            this.pnlwarnings.Name = "pnlwarnings";
            this.pnlwarnings.Size = new System.Drawing.Size(739, 10);
            this.pnlwarnings.TabIndex = 126;
            this.pnlwarnings.Visible = false;
            // 
            // Comwarnsaleratelessthanretailrate
            // 
            this.Comwarnsaleratelessthanretailrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnsaleratelessthanretailrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnsaleratelessthanretailrate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnsaleratelessthanretailrate.FormattingEnabled = true;
            this.Comwarnsaleratelessthanretailrate.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnsaleratelessthanretailrate.Location = new System.Drawing.Point(289, 259);
            this.Comwarnsaleratelessthanretailrate.Name = "Comwarnsaleratelessthanretailrate";
            this.Comwarnsaleratelessthanretailrate.Size = new System.Drawing.Size(140, 20);
            this.Comwarnsaleratelessthanretailrate.TabIndex = 132;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(15, 260);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(188, 12);
            this.label68.TabIndex = 133;
            this.label68.Text = "Sale rate Less than Retail rate";
            // 
            // Comwarnsaleratelessthanprate
            // 
            this.Comwarnsaleratelessthanprate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnsaleratelessthanprate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnsaleratelessthanprate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnsaleratelessthanprate.FormattingEnabled = true;
            this.Comwarnsaleratelessthanprate.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnsaleratelessthanprate.Location = new System.Drawing.Point(287, 223);
            this.Comwarnsaleratelessthanprate.Name = "Comwarnsaleratelessthanprate";
            this.Comwarnsaleratelessthanprate.Size = new System.Drawing.Size(140, 20);
            this.Comwarnsaleratelessthanprate.TabIndex = 130;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(14, 224);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(204, 12);
            this.label46.TabIndex = 131;
            this.label46.Text = "Sale rate Less than Purchase rate";
            // 
            // Comwarnmaximumstock
            // 
            this.Comwarnmaximumstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnmaximumstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnmaximumstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnmaximumstock.FormattingEnabled = true;
            this.Comwarnmaximumstock.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnmaximumstock.Location = new System.Drawing.Point(287, 191);
            this.Comwarnmaximumstock.Name = "Comwarnmaximumstock";
            this.Comwarnmaximumstock.Size = new System.Drawing.Size(140, 20);
            this.Comwarnmaximumstock.TabIndex = 128;
            // 
            // lblwarnmaximumstock
            // 
            this.lblwarnmaximumstock.AutoSize = true;
            this.lblwarnmaximumstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblwarnmaximumstock.ForeColor = System.Drawing.Color.Black;
            this.lblwarnmaximumstock.Location = new System.Drawing.Point(12, 185);
            this.lblwarnmaximumstock.Name = "lblwarnmaximumstock";
            this.lblwarnmaximumstock.Size = new System.Drawing.Size(99, 12);
            this.lblwarnmaximumstock.TabIndex = 129;
            this.lblwarnmaximumstock.Text = "Maximum stock";
            // 
            // Comwarnreorderstock
            // 
            this.Comwarnreorderstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnreorderstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnreorderstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnreorderstock.FormattingEnabled = true;
            this.Comwarnreorderstock.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnreorderstock.Location = new System.Drawing.Point(287, 156);
            this.Comwarnreorderstock.Name = "Comwarnreorderstock";
            this.Comwarnreorderstock.Size = new System.Drawing.Size(140, 20);
            this.Comwarnreorderstock.TabIndex = 126;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(12, 150);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(91, 12);
            this.label44.TabIndex = 127;
            this.label44.Text = "Reorder stock";
            // 
            // Comwarnminimumstock
            // 
            this.Comwarnminimumstock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnminimumstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnminimumstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnminimumstock.FormattingEnabled = true;
            this.Comwarnminimumstock.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnminimumstock.Location = new System.Drawing.Point(287, 122);
            this.Comwarnminimumstock.Name = "Comwarnminimumstock";
            this.Comwarnminimumstock.Size = new System.Drawing.Size(140, 20);
            this.Comwarnminimumstock.TabIndex = 124;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(12, 116);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 12);
            this.label45.TabIndex = 125;
            this.label45.Text = "Minimum stock";
            // 
            // Comwarnnegetivestock
            // 
            this.Comwarnnegetivestock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comwarnnegetivestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comwarnnegetivestock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Comwarnnegetivestock.FormattingEnabled = true;
            this.Comwarnnegetivestock.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.Comwarnnegetivestock.Location = new System.Drawing.Point(286, 87);
            this.Comwarnnegetivestock.Name = "Comwarnnegetivestock";
            this.Comwarnnegetivestock.Size = new System.Drawing.Size(140, 20);
            this.Comwarnnegetivestock.TabIndex = 122;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(11, 81);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(97, 12);
            this.label42.TabIndex = 123;
            this.label42.Text = "Negetive stock";
            // 
            // comwarnnegetivecash
            // 
            this.comwarnnegetivecash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comwarnnegetivecash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comwarnnegetivecash.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.comwarnnegetivecash.FormattingEnabled = true;
            this.comwarnnegetivecash.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.comwarnnegetivecash.Location = new System.Drawing.Point(286, 51);
            this.comwarnnegetivecash.Name = "comwarnnegetivecash";
            this.comwarnnegetivecash.Size = new System.Drawing.Size(140, 20);
            this.comwarnnegetivecash.TabIndex = 115;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(11, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 12);
            this.label25.TabIndex = 116;
            this.label25.Text = "Negetive Cash";
            // 
            // comwarncreditlimit
            // 
            this.comwarncreditlimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comwarncreditlimit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comwarncreditlimit.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.comwarncreditlimit.FormattingEnabled = true;
            this.comwarncreditlimit.Items.AddRange(new object[] {
            "Allow",
            "Warn",
            "Block"});
            this.comwarncreditlimit.Location = new System.Drawing.Point(286, 16);
            this.comwarncreditlimit.Name = "comwarncreditlimit";
            this.comwarncreditlimit.Size = new System.Drawing.Size(140, 20);
            this.comwarncreditlimit.TabIndex = 113;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(11, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 114;
            this.label24.Text = "Credit Limit";
            // 
            // cmdapply
            // 
            this.cmdapply.BackColor = System.Drawing.Color.Transparent;
            this.cmdapply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdapply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdapply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdapply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdapply.ForeColor = System.Drawing.Color.Black;
            this.cmdapply.Location = new System.Drawing.Point(602, 601);
            this.cmdapply.Name = "cmdapply";
            this.cmdapply.Size = new System.Drawing.Size(75, 36);
            this.cmdapply.TabIndex = 129;
            this.cmdapply.Text = "Apply";
            this.cmdapply.UseVisualStyleBackColor = false;
            this.cmdapply.Click += new System.EventHandler(this.cmdapply_Click);
            // 
            // cmdcancel
            // 
            this.cmdcancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdcancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcancel.ForeColor = System.Drawing.Color.Black;
            this.cmdcancel.Location = new System.Drawing.Point(524, 601);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 36);
            this.cmdcancel.TabIndex = 128;
            this.cmdcancel.Text = "Cancel";
            this.cmdcancel.UseVisualStyleBackColor = false;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdok
            // 
            this.cmdok.BackColor = System.Drawing.Color.Transparent;
            this.cmdok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdok.ForeColor = System.Drawing.Color.Black;
            this.cmdok.Location = new System.Drawing.Point(446, 601);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(75, 36);
            this.cmdok.TabIndex = 127;
            this.cmdok.Text = "OK";
            this.cmdok.UseVisualStyleBackColor = false;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // Pnprintersettings
            // 
            this.Pnprintersettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnprintersettings.Controls.Add(this.panel7);
            this.Pnprintersettings.Controls.Add(this.lblModel);
            this.Pnprintersettings.Controls.Add(this.combsecondaryModel);
            this.Pnprintersettings.Controls.Add(this.panel3);
            this.Pnprintersettings.Controls.Add(this.chkheaderVisible);
            this.Pnprintersettings.Controls.Add(this.Comsecondprint);
            this.Pnprintersettings.Controls.Add(this.label67);
            this.Pnprintersettings.Controls.Add(this.Chkenablesecondprinter);
            this.Pnprintersettings.Controls.Add(this.txtcodeprintwidth);
            this.Pnprintersettings.Controls.Add(this.label60);
            this.Pnprintersettings.Controls.Add(this.ChkprintnoTax);
            this.Pnprintersettings.Controls.Add(this.chkQrcode);
            this.Pnprintersettings.Controls.Add(this.chkmixedkerala);
            this.Pnprintersettings.Controls.Add(this.chka4split);
            this.Pnprintersettings.Controls.Add(this.chkmixedkarnataka);
            this.Pnprintersettings.Controls.Add(this.chkmixed3);
            this.Pnprintersettings.Controls.Add(this.Raddotpreprinted);
            this.Pnprintersettings.Controls.Add(this.Rad3pointarabic);
            this.Pnprintersettings.Controls.Add(this.raddotmobile);
            this.Pnprintersettings.Controls.Add(this.label41);
            this.Pnprintersettings.Controls.Add(this.txttoplaser);
            this.Pnprintersettings.Controls.Add(this.label40);
            this.Pnprintersettings.Controls.Add(this.txtleftlaser);
            this.Pnprintersettings.Controls.Add(this.chkconsole);
            this.Pnprintersettings.Controls.Add(this.chkprintllangague);
            this.Pnprintersettings.Controls.Add(this.chkprintbalance);
            this.Pnprintersettings.Controls.Add(this.label29);
            this.Pnprintersettings.Controls.Add(this.txtreverse);
            this.Pnprintersettings.Controls.Add(this.label30);
            this.Pnprintersettings.Controls.Add(this.txtfscroll);
            this.Pnprintersettings.Controls.Add(this.raddot8);
            this.Pnprintersettings.Controls.Add(this.label28);
            this.Pnprintersettings.Controls.Add(this.txtprintfooter);
            this.Pnprintersettings.Controls.Add(this.label26);
            this.Pnprintersettings.Controls.Add(this.txtnocopies);
            this.Pnprintersettings.Controls.Add(this.radmultipleprint);
            this.Pnprintersettings.Controls.Add(this.radotherdetail);
            this.Pnprintersettings.Controls.Add(this.groupBox3);
            this.Pnprintersettings.Controls.Add(this.radother10);
            this.Pnprintersettings.Controls.Add(this.radother6);
            this.Pnprintersettings.Controls.Add(this.radother3);
            this.Pnprintersettings.Controls.Add(this.raddot10);
            this.Pnprintersettings.Controls.Add(this.raddot6);
            this.Pnprintersettings.Controls.Add(this.raddot3);
            this.Pnprintersettings.Controls.Add(this.label12);
            this.Pnprintersettings.Controls.Add(this.label13);
            this.Pnprintersettings.Controls.Add(this.label14);
            this.Pnprintersettings.Controls.Add(this.label15);
            this.Pnprintersettings.Location = new System.Drawing.Point(167, 540);
            this.Pnprintersettings.Name = "Pnprintersettings";
            this.Pnprintersettings.Size = new System.Drawing.Size(745, 13);
            this.Pnprintersettings.TabIndex = 130;
            this.Pnprintersettings.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.qrrr2;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Controls.Add(this.label96);
            this.panel7.Controls.Add(this.label95);
            this.panel7.Controls.Add(this.label93);
            this.panel7.Controls.Add(this.txtqrhight);
            this.panel7.Controls.Add(this.label94);
            this.panel7.Controls.Add(this.txtqrwidth);
            this.panel7.Location = new System.Drawing.Point(411, 154);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 112);
            this.panel7.TabIndex = 182;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label96.Location = new System.Drawing.Point(2, 27);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(131, 16);
            this.label96.TabIndex = 183;
            this.label96.Text = "QR set                   ";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label95.Location = new System.Drawing.Point(3, 8);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(58, 16);
            this.label95.TabIndex = 182;
            this.label95.Text = "3 point ";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(3, 58);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(40, 14);
            this.label93.TabIndex = 178;
            this.label93.Text = "Width";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(1, 80);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(43, 14);
            this.label94.TabIndex = 179;
            this.label94.Text = "Height";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(7, 344);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 14);
            this.lblModel.TabIndex = 176;
            this.lblModel.Text = "Model";
            // 
            // combsecondaryModel
            // 
            this.combsecondaryModel.BackColor = System.Drawing.Color.White;
            this.combsecondaryModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combsecondaryModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combsecondaryModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.combsecondaryModel.FormattingEnabled = true;
            this.combsecondaryModel.Items.AddRange(new object[] {
            "None",
            "A4",
            "Thermal",
            "A4 Other",
            "No tax A4 Code + name",
            "No tax A4 Name"});
            this.combsecondaryModel.Location = new System.Drawing.Point(55, 344);
            this.combsecondaryModel.Name = "combsecondaryModel";
            this.combsecondaryModel.Size = new System.Drawing.Size(146, 23);
            this.combsecondaryModel.TabIndex = 175;
            this.combsecondaryModel.SelectedIndexChanged += new System.EventHandler(this.combsecondaryModel_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(230)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.label84);
            this.panel3.Controls.Add(this.label83);
            this.panel3.Controls.Add(this.label82);
            this.panel3.Controls.Add(this.label81);
            this.panel3.Controls.Add(this.txtphadressfont);
            this.panel3.Controls.Add(this.txttaxtfnt);
            this.panel3.Controls.Add(this.txtnamehomefnt);
            this.panel3.Controls.Add(this.txtcompanyfnt);
            this.panel3.Controls.Add(this.label77);
            this.panel3.Controls.Add(this.label61);
            this.panel3.Controls.Add(this.TXTICONSIZE);
            this.panel3.Controls.Add(this.label62);
            this.panel3.Controls.Add(this.txticonstartpoint);
            this.panel3.Controls.Add(this.label63);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Controls.Add(this.txticonend);
            this.panel3.Location = new System.Drawing.Point(545, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 252);
            this.panel3.TabIndex = 174;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(4, 215);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(97, 15);
            this.label84.TabIndex = 180;
            this.label84.Text = "PH & Address font";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(2, 186);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(50, 15);
            this.label83.TabIndex = 179;
            this.label83.Text = "Tax font";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(3, 158);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(96, 15);
            this.label82.TabIndex = 178;
            this.label82.Text = "Namehome font";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(2, 130);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(110, 15);
            this.label81.TabIndex = 177;
            this.label81.Text = "Comany name font";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label77.Location = new System.Drawing.Point(7, 107);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(146, 15);
            this.label77.TabIndex = 172;
            this.label77.Text = "Thermal Header font set";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label66.Location = new System.Drawing.Point(4, 7);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(150, 15);
            this.label66.TabIndex = 169;
            this.label66.Text = "Thermal print icon adjust";
            // 
            // chkheaderVisible
            // 
            this.chkheaderVisible.AutoSize = true;
            this.chkheaderVisible.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkheaderVisible.Location = new System.Drawing.Point(555, 81);
            this.chkheaderVisible.Name = "chkheaderVisible";
            this.chkheaderVisible.Size = new System.Drawing.Size(111, 16);
            this.chkheaderVisible.TabIndex = 173;
            this.chkheaderVisible.Text = "Header visible";
            this.chkheaderVisible.UseVisualStyleBackColor = true;
            this.chkheaderVisible.CheckedChanged += new System.EventHandler(this.chkheaderVisible_CheckedChanged);
            // 
            // Comsecondprint
            // 
            this.Comsecondprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comsecondprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Comsecondprint.FormattingEnabled = true;
            this.Comsecondprint.Location = new System.Drawing.Point(5, 320);
            this.Comsecondprint.Name = "Comsecondprint";
            this.Comsecondprint.Size = new System.Drawing.Size(197, 21);
            this.Comsecondprint.TabIndex = 169;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Blue;
            this.label67.Location = new System.Drawing.Point(463, 94);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(214, 13);
            this.label67.TabIndex = 172;
            this.label67.Text = "---------------------------------------------------------------------";
            // 
            // Chkenablesecondprinter
            // 
            this.Chkenablesecondprinter.AutoSize = true;
            this.Chkenablesecondprinter.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkenablesecondprinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Chkenablesecondprinter.Location = new System.Drawing.Point(8, 303);
            this.Chkenablesecondprinter.Name = "Chkenablesecondprinter";
            this.Chkenablesecondprinter.Size = new System.Drawing.Size(144, 16);
            this.Chkenablesecondprinter.TabIndex = 168;
            this.Chkenablesecondprinter.Text = "Enable Second Print";
            this.Chkenablesecondprinter.UseVisualStyleBackColor = true;
            this.Chkenablesecondprinter.CheckedChanged += new System.EventHandler(this.Chkenablesecondprinter_CheckedChanged);
            // 
            // ChkprintnoTax
            // 
            this.ChkprintnoTax.AutoSize = true;
            this.ChkprintnoTax.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkprintnoTax.Location = new System.Drawing.Point(439, 81);
            this.ChkprintnoTax.Name = "ChkprintnoTax";
            this.ChkprintnoTax.Size = new System.Drawing.Size(97, 16);
            this.ChkprintnoTax.TabIndex = 168;
            this.ChkprintnoTax.Text = "Print no Tax";
            this.ChkprintnoTax.UseVisualStyleBackColor = true;
            this.ChkprintnoTax.CheckedChanged += new System.EventHandler(this.ChkprintnoTax_CheckedChanged);
            // 
            // chkQrcode
            // 
            this.chkQrcode.AutoSize = true;
            this.chkQrcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkQrcode.Location = new System.Drawing.Point(557, 59);
            this.chkQrcode.Name = "chkQrcode";
            this.chkQrcode.Size = new System.Drawing.Size(120, 16);
            this.chkQrcode.TabIndex = 167;
            this.chkQrcode.Text = "QR Code visible";
            this.chkQrcode.UseVisualStyleBackColor = true;
            this.chkQrcode.CheckedChanged += new System.EventHandler(this.chkQrcode_CheckedChanged);
            // 
            // chkmixedkerala
            // 
            this.chkmixedkerala.AutoSize = true;
            this.chkmixedkerala.Location = new System.Drawing.Point(320, 93);
            this.chkmixedkerala.Name = "chkmixedkerala";
            this.chkmixedkerala.Size = new System.Drawing.Size(63, 17);
            this.chkmixedkerala.TabIndex = 135;
            this.chkmixedkerala.Text = "Mixed 1";
            this.chkmixedkerala.UseVisualStyleBackColor = true;
            this.chkmixedkerala.CheckedChanged += new System.EventHandler(this.chkmixed_CheckedChanged);
            // 
            // chka4split
            // 
            this.chka4split.AutoSize = true;
            this.chka4split.Location = new System.Drawing.Point(321, 94);
            this.chka4split.Name = "chka4split";
            this.chka4split.Size = new System.Drawing.Size(62, 17);
            this.chka4split.TabIndex = 136;
            this.chka4split.Text = "A4 Split";
            this.chka4split.UseVisualStyleBackColor = true;
            this.chka4split.CheckedChanged += new System.EventHandler(this.chka4split_CheckedChanged);
            // 
            // chkmixedkarnataka
            // 
            this.chkmixedkarnataka.AutoSize = true;
            this.chkmixedkarnataka.Location = new System.Drawing.Point(321, 95);
            this.chkmixedkarnataka.Name = "chkmixedkarnataka";
            this.chkmixedkarnataka.Size = new System.Drawing.Size(63, 17);
            this.chkmixedkarnataka.TabIndex = 137;
            this.chkmixedkarnataka.Text = "Mixed 2";
            this.chkmixedkarnataka.UseVisualStyleBackColor = true;
            this.chkmixedkarnataka.CheckedChanged += new System.EventHandler(this.chkmixedkarnataka_CheckedChanged);
            // 
            // chkmixed3
            // 
            this.chkmixed3.AutoSize = true;
            this.chkmixed3.Location = new System.Drawing.Point(323, 96);
            this.chkmixed3.Name = "chkmixed3";
            this.chkmixed3.Size = new System.Drawing.Size(63, 17);
            this.chkmixed3.TabIndex = 139;
            this.chkmixed3.Text = "Mixed 3";
            this.chkmixed3.UseVisualStyleBackColor = true;
            this.chkmixed3.CheckedChanged += new System.EventHandler(this.chkmixed3_CheckedChanged);
            // 
            // Raddotpreprinted
            // 
            this.Raddotpreprinted.AutoSize = true;
            this.Raddotpreprinted.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raddotpreprinted.ForeColor = System.Drawing.Color.Black;
            this.Raddotpreprinted.Location = new System.Drawing.Point(555, 37);
            this.Raddotpreprinted.Name = "Raddotpreprinted";
            this.Raddotpreprinted.Size = new System.Drawing.Size(109, 16);
            this.Raddotpreprinted.TabIndex = 165;
            this.Raddotpreprinted.TabStop = true;
            this.Raddotpreprinted.Text = "DotPreprinted";
            this.Raddotpreprinted.UseVisualStyleBackColor = true;
            this.Raddotpreprinted.CheckedChanged += new System.EventHandler(this.Raddotpreprinted_CheckedChanged);
            // 
            // Rad3pointarabic
            // 
            this.Rad3pointarabic.AutoSize = true;
            this.Rad3pointarabic.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Rad3pointarabic.ForeColor = System.Drawing.Color.Black;
            this.Rad3pointarabic.Location = new System.Drawing.Point(557, 15);
            this.Rad3pointarabic.Name = "Rad3pointarabic";
            this.Rad3pointarabic.Size = new System.Drawing.Size(107, 16);
            this.Rad3pointarabic.TabIndex = 164;
            this.Rad3pointarabic.TabStop = true;
            this.Rad3pointarabic.Text = "3 Point Arabic";
            this.Rad3pointarabic.UseVisualStyleBackColor = true;
            this.Rad3pointarabic.CheckedChanged += new System.EventHandler(this.Rad3pointarabic_CheckedChanged);
            // 
            // raddotmobile
            // 
            this.raddotmobile.AutoSize = true;
            this.raddotmobile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddotmobile.ForeColor = System.Drawing.Color.Black;
            this.raddotmobile.Location = new System.Drawing.Point(340, 29);
            this.raddotmobile.Name = "raddotmobile";
            this.raddotmobile.Size = new System.Drawing.Size(67, 21);
            this.raddotmobile.TabIndex = 163;
            this.raddotmobile.TabStop = true;
            this.raddotmobile.Text = "Mobile";
            this.raddotmobile.UseVisualStyleBackColor = true;
            this.raddotmobile.CheckedChanged += new System.EventHandler(this.raddotmobile_CheckedChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(94, 267);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 12);
            this.label41.TabIndex = 162;
            this.label41.Text = "Topprinter";
            // 
            // txttoplaser
            // 
            this.txttoplaser.Location = new System.Drawing.Point(99, 282);
            this.txttoplaser.Name = "txttoplaser";
            this.txttoplaser.Size = new System.Drawing.Size(49, 20);
            this.txttoplaser.TabIndex = 161;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Lucida Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(20, 264);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 12);
            this.label40.TabIndex = 160;
            this.label40.Text = "Leftprinter";
            // 
            // txtleftlaser
            // 
            this.txtleftlaser.Location = new System.Drawing.Point(29, 279);
            this.txtleftlaser.Name = "txtleftlaser";
            this.txtleftlaser.Size = new System.Drawing.Size(49, 20);
            this.txtleftlaser.TabIndex = 159;
            // 
            // chkconsole
            // 
            this.chkconsole.AutoSize = true;
            this.chkconsole.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkconsole.Location = new System.Drawing.Point(439, 59);
            this.chkconsole.Name = "chkconsole";
            this.chkconsole.Size = new System.Drawing.Size(72, 16);
            this.chkconsole.TabIndex = 158;
            this.chkconsole.Text = "Console";
            this.chkconsole.UseVisualStyleBackColor = true;
            this.chkconsole.CheckedChanged += new System.EventHandler(this.chkconsole_CheckedChanged);
            // 
            // chkprintllangague
            // 
            this.chkprintllangague.AutoSize = true;
            this.chkprintllangague.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkprintllangague.Location = new System.Drawing.Point(439, 36);
            this.chkprintllangague.Name = "chkprintllangague";
            this.chkprintllangague.Size = new System.Drawing.Size(92, 16);
            this.chkprintllangague.TabIndex = 157;
            this.chkprintllangague.Text = "Print L.lang";
            this.chkprintllangague.UseVisualStyleBackColor = true;
            this.chkprintllangague.CheckedChanged += new System.EventHandler(this.chkprintllangague_CheckedChanged);
            // 
            // chkprintbalance
            // 
            this.chkprintbalance.AutoSize = true;
            this.chkprintbalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkprintbalance.Location = new System.Drawing.Point(439, 13);
            this.chkprintbalance.Name = "chkprintbalance";
            this.chkprintbalance.Size = new System.Drawing.Size(102, 16);
            this.chkprintbalance.TabIndex = 156;
            this.chkprintbalance.Text = "Print Balance";
            this.chkprintbalance.UseVisualStyleBackColor = true;
            this.chkprintbalance.CheckedChanged += new System.EventHandler(this.chkprintbalance_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(363, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 155;
            this.label29.Text = "Reverse";
            // 
            // txtreverse
            // 
            this.txtreverse.Location = new System.Drawing.Point(362, 66);
            this.txtreverse.Name = "txtreverse";
            this.txtreverse.Size = new System.Drawing.Size(49, 20);
            this.txtreverse.TabIndex = 154;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(305, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 12);
            this.label30.TabIndex = 153;
            this.label30.Text = "FScroll";
            // 
            // txtfscroll
            // 
            this.txtfscroll.Location = new System.Drawing.Point(301, 67);
            this.txtfscroll.Name = "txtfscroll";
            this.txtfscroll.Size = new System.Drawing.Size(49, 20);
            this.txtfscroll.TabIndex = 152;
            // 
            // raddot8
            // 
            this.raddot8.AutoSize = true;
            this.raddot8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddot8.ForeColor = System.Drawing.Color.Black;
            this.raddot8.Location = new System.Drawing.Point(178, 28);
            this.raddot8.Name = "raddot8";
            this.raddot8.Size = new System.Drawing.Size(66, 21);
            this.raddot8.TabIndex = 151;
            this.raddot8.TabStop = true;
            this.raddot8.Text = "8 Point";
            this.raddot8.UseVisualStyleBackColor = true;
            this.raddot8.CheckedChanged += new System.EventHandler(this.raddot8_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(430, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 12);
            this.label28.TabIndex = 149;
            this.label28.Text = "Footer";
            // 
            // txtprintfooter
            // 
            this.txtprintfooter.Location = new System.Drawing.Point(481, 110);
            this.txtprintfooter.Multiline = true;
            this.txtprintfooter.Name = "txtprintfooter";
            this.txtprintfooter.Size = new System.Drawing.Size(261, 25);
            this.txtprintfooter.TabIndex = 150;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(19, 242);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 12);
            this.label26.TabIndex = 147;
            this.label26.Text = "No Copies";
            // 
            // txtnocopies
            // 
            this.txtnocopies.Location = new System.Drawing.Point(91, 242);
            this.txtnocopies.Name = "txtnocopies";
            this.txtnocopies.Size = new System.Drawing.Size(100, 20);
            this.txtnocopies.TabIndex = 146;
            // 
            // radmultipleprint
            // 
            this.radmultipleprint.AutoSize = true;
            this.radmultipleprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmultipleprint.ForeColor = System.Drawing.Color.Black;
            this.radmultipleprint.Location = new System.Drawing.Point(323, 91);
            this.radmultipleprint.Name = "radmultipleprint";
            this.radmultipleprint.Size = new System.Drawing.Size(73, 21);
            this.radmultipleprint.TabIndex = 141;
            this.radmultipleprint.TabStop = true;
            this.radmultipleprint.Text = "Multiple";
            this.radmultipleprint.UseVisualStyleBackColor = true;
            this.radmultipleprint.CheckedChanged += new System.EventHandler(this.radmultipleprint_CheckedChanged);
            // 
            // radotherdetail
            // 
            this.radotherdetail.AutoSize = true;
            this.radotherdetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radotherdetail.ForeColor = System.Drawing.Color.Black;
            this.radotherdetail.Location = new System.Drawing.Point(258, 90);
            this.radotherdetail.Name = "radotherdetail";
            this.radotherdetail.Size = new System.Drawing.Size(59, 21);
            this.radotherdetail.TabIndex = 140;
            this.radotherdetail.TabStop = true;
            this.radotherdetail.Text = "Detail";
            this.radotherdetail.UseVisualStyleBackColor = true;
            this.radotherdetail.CheckedChanged += new System.EventHandler(this.radotherdetail_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label92);
            this.groupBox3.Controls.Add(this.label90);
            this.groupBox3.Controls.Add(this.label91);
            this.groupBox3.Controls.Add(this.label89);
            this.groupBox3.Controls.Add(this.combprintselectnpurchase);
            this.groupBox3.Controls.Add(this.chkpurchprintconfrm);
            this.groupBox3.Controls.Add(this.chkpurchpritwhile);
            this.groupBox3.Controls.Add(this.lblprintstyle);
            this.groupBox3.Controls.Add(this.combprintselectn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 105);
            this.groupBox3.TabIndex = 139;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mixed Mode";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.Color.Blue;
            this.label92.Location = new System.Drawing.Point(7, 16);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(38, 15);
            this.label92.TabIndex = 177;
            this.label92.Text = "Sales";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(274, 147);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(29, 12);
            this.label90.TabIndex = 175;
            this.label90.Text = "SALE";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.Color.Blue;
            this.label91.Location = new System.Drawing.Point(8, 54);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(59, 15);
            this.label91.TabIndex = 176;
            this.label91.Text = "Purchase";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.Color.DarkOrange;
            this.label89.Location = new System.Drawing.Point(1, 70);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(73, 15);
            this.label89.TabIndex = 178;
            this.label89.Text = "Print Type";
            // 
            // combprintselectnpurchase
            // 
            this.combprintselectnpurchase.BackColor = System.Drawing.Color.Black;
            this.combprintselectnpurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combprintselectnpurchase.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F);
            this.combprintselectnpurchase.ForeColor = System.Drawing.Color.Yellow;
            this.combprintselectnpurchase.FormattingEnabled = true;
            this.combprintselectnpurchase.Items.AddRange(new object[] {
            "3  Point English",
            "3  Point Arabic",
            "A4  Half Mode",
            "A4  Mode  1      [item + unit]",
            "A4  Mode   2    [pre print]",
            "A4  Mode  3     [ item ]",
            "A4  Mode   4    [code + item + unit]",
            "A4  Mode   5    [Tax bill format]",
            "A4  Mode   6    [code + name]",
            " 2 Inch Thermal",
            "A4  Mode Qatar",
            "A4  Mode New",
            "3  Point Arabic No Tax",
            "3  Point English No Tax"});
            this.combprintselectnpurchase.Location = new System.Drawing.Point(74, 66);
            this.combprintselectnpurchase.Name = "combprintselectnpurchase";
            this.combprintselectnpurchase.Size = new System.Drawing.Size(302, 24);
            this.combprintselectnpurchase.TabIndex = 177;
            this.combprintselectnpurchase.SelectedIndexChanged += new System.EventHandler(this.combprintselectnpurchase_SelectedIndexChanged);
            // 
            // chkpurchprintconfrm
            // 
            this.chkpurchprintconfrm.AutoSize = true;
            this.chkpurchprintconfrm.Location = new System.Drawing.Point(82, 5);
            this.chkpurchprintconfrm.Name = "chkpurchprintconfrm";
            this.chkpurchprintconfrm.Size = new System.Drawing.Size(135, 17);
            this.chkpurchprintconfrm.TabIndex = 176;
            this.chkpurchprintconfrm.Text = "Purchase print conform";
            this.chkpurchprintconfrm.UseVisualStyleBackColor = true;
            this.chkpurchprintconfrm.Visible = false;
            // 
            // chkpurchpritwhile
            // 
            this.chkpurchpritwhile.AutoSize = true;
            this.chkpurchpritwhile.Location = new System.Drawing.Point(82, 5);
            this.chkpurchpritwhile.Name = "chkpurchpritwhile";
            this.chkpurchpritwhile.Size = new System.Drawing.Size(121, 17);
            this.chkpurchpritwhile.TabIndex = 175;
            this.chkpurchpritwhile.Text = "Purchase print while";
            this.chkpurchpritwhile.UseVisualStyleBackColor = true;
            this.chkpurchpritwhile.Visible = false;
            this.chkpurchpritwhile.CheckedChanged += new System.EventHandler(this.chkpurchpritwhile_CheckedChanged);
            // 
            // lblprintstyle
            // 
            this.lblprintstyle.AutoSize = true;
            this.lblprintstyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprintstyle.ForeColor = System.Drawing.Color.DeepPink;
            this.lblprintstyle.Location = new System.Drawing.Point(1, 32);
            this.lblprintstyle.Name = "lblprintstyle";
            this.lblprintstyle.Size = new System.Drawing.Size(73, 15);
            this.lblprintstyle.TabIndex = 171;
            this.lblprintstyle.Text = "Print Type";
            // 
            // combprintselectn
            // 
            this.combprintselectn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combprintselectn.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combprintselectn.ForeColor = System.Drawing.Color.Crimson;
            this.combprintselectn.FormattingEnabled = true;
            this.combprintselectn.Items.AddRange(new object[] {
            "3  Point English",
            "3  Point Arabic",
            "A4  Half Mode",
            "A4  Mode  1      [item + unit]",
            "A4  Mode   2    [pre print]",
            "A4  Mode  3     [ item ]",
            "A4  Mode   4    [code + item + unit]",
            "A4  Mode   5    [Tax bill format]",
            "A4  Mode   6    [code + name]",
            " 2 Inch Thermal",
            "A4  Mode Qatar",
            "A4  Mode New",
            "3  Point Arabic No Tax",
            "3  Point English No Tax",
            "A4 MODE3 WORKSHOP",
            "A4 MODE3 WORKSHOP NO TAX",
            "A4    [Code + Name] No Tax",
            "A4    [ Name] No Tax"});
            this.combprintselectn.Location = new System.Drawing.Point(74, 28);
            this.combprintselectn.Name = "combprintselectn";
            this.combprintselectn.Size = new System.Drawing.Size(302, 24);
            this.combprintselectn.TabIndex = 170;
            this.combprintselectn.SelectedIndexChanged += new System.EventHandler(this.combprintselectn_SelectedIndexChanged);
            // 
            // radother10
            // 
            this.radother10.AutoSize = true;
            this.radother10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radother10.ForeColor = System.Drawing.Color.Black;
            this.radother10.Location = new System.Drawing.Point(182, 90);
            this.radother10.Name = "radother10";
            this.radother10.Size = new System.Drawing.Size(73, 21);
            this.radother10.TabIndex = 133;
            this.radother10.TabStop = true;
            this.radother10.Text = "10 Point";
            this.radother10.UseVisualStyleBackColor = true;
            this.radother10.CheckedChanged += new System.EventHandler(this.radother10_CheckedChanged);
            // 
            // radother6
            // 
            this.radother6.AutoSize = true;
            this.radother6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radother6.ForeColor = System.Drawing.Color.Black;
            this.radother6.Location = new System.Drawing.Point(106, 89);
            this.radother6.Name = "radother6";
            this.radother6.Size = new System.Drawing.Size(66, 21);
            this.radother6.TabIndex = 132;
            this.radother6.TabStop = true;
            this.radother6.Text = "6 Point";
            this.radother6.UseVisualStyleBackColor = true;
            this.radother6.CheckedChanged += new System.EventHandler(this.radother6_CheckedChanged);
            // 
            // radother3
            // 
            this.radother3.AutoSize = true;
            this.radother3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radother3.ForeColor = System.Drawing.Color.Black;
            this.radother3.Location = new System.Drawing.Point(24, 89);
            this.radother3.Name = "radother3";
            this.radother3.Size = new System.Drawing.Size(66, 21);
            this.radother3.TabIndex = 131;
            this.radother3.TabStop = true;
            this.radother3.Text = "3 Point";
            this.radother3.UseVisualStyleBackColor = true;
            this.radother3.CheckedChanged += new System.EventHandler(this.radother3_CheckedChanged);
            // 
            // raddot10
            // 
            this.raddot10.AutoSize = true;
            this.raddot10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddot10.ForeColor = System.Drawing.Color.Black;
            this.raddot10.Location = new System.Drawing.Point(260, 24);
            this.raddot10.Name = "raddot10";
            this.raddot10.Size = new System.Drawing.Size(73, 21);
            this.raddot10.TabIndex = 130;
            this.raddot10.TabStop = true;
            this.raddot10.Text = "10 Point";
            this.raddot10.UseVisualStyleBackColor = true;
            this.raddot10.CheckedChanged += new System.EventHandler(this.raddot10_CheckedChanged);
            // 
            // raddot6
            // 
            this.raddot6.AutoSize = true;
            this.raddot6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddot6.ForeColor = System.Drawing.Color.Black;
            this.raddot6.Location = new System.Drawing.Point(104, 28);
            this.raddot6.Name = "raddot6";
            this.raddot6.Size = new System.Drawing.Size(66, 21);
            this.raddot6.TabIndex = 129;
            this.raddot6.TabStop = true;
            this.raddot6.Text = "6 Point";
            this.raddot6.UseVisualStyleBackColor = true;
            this.raddot6.CheckedChanged += new System.EventHandler(this.raddot6_CheckedChanged);
            // 
            // raddot3
            // 
            this.raddot3.AutoSize = true;
            this.raddot3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddot3.ForeColor = System.Drawing.Color.Black;
            this.raddot3.Location = new System.Drawing.Point(28, 28);
            this.raddot3.Name = "raddot3";
            this.raddot3.Size = new System.Drawing.Size(66, 21);
            this.raddot3.TabIndex = 128;
            this.raddot3.TabStop = true;
            this.raddot3.Text = "3 Point";
            this.raddot3.UseVisualStyleBackColor = true;
            this.raddot3.CheckedChanged += new System.EventHandler(this.raddot3_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(22, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "-----------------------------------------------------------------------------";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(22, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 12);
            this.label13.TabIndex = 123;
            this.label13.Text = "Other";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(22, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 13);
            this.label14.TabIndex = 121;
            this.label14.Text = "-----------------------------------------------------------------------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(22, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 12);
            this.label15.TabIndex = 120;
            this.label15.Text = "Dotmetrix";
            // 
            // Pnlaoutobackup
            // 
            this.Pnlaoutobackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlaoutobackup.Controls.Add(this.label35);
            this.Pnlaoutobackup.Controls.Add(this.txtautobackupfilepath4);
            this.Pnlaoutobackup.Controls.Add(this.cmdautobackup4);
            this.Pnlaoutobackup.Controls.Add(this.label34);
            this.Pnlaoutobackup.Controls.Add(this.txtautobackupfilepath3);
            this.Pnlaoutobackup.Controls.Add(this.cmdautobackup3);
            this.Pnlaoutobackup.Controls.Add(this.label33);
            this.Pnlaoutobackup.Controls.Add(this.txtautobackupfilepath2);
            this.Pnlaoutobackup.Controls.Add(this.cmdautobackup2);
            this.Pnlaoutobackup.Controls.Add(this.label32);
            this.Pnlaoutobackup.Controls.Add(this.txtautobackupfilepath1);
            this.Pnlaoutobackup.Controls.Add(this.cmdautobackup1);
            this.Pnlaoutobackup.Controls.Add(this.chkautobackup);
            this.Pnlaoutobackup.Location = new System.Drawing.Point(151, 112);
            this.Pnlaoutobackup.Name = "Pnlaoutobackup";
            this.Pnlaoutobackup.Size = new System.Drawing.Size(737, 10);
            this.Pnlaoutobackup.TabIndex = 131;
            this.Pnlaoutobackup.Visible = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(1, 214);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(18, 13);
            this.label35.TabIndex = 139;
            this.label35.Text = "4:";
            // 
            // txtautobackupfilepath4
            // 
            this.txtautobackupfilepath4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtautobackupfilepath4.Location = new System.Drawing.Point(20, 211);
            this.txtautobackupfilepath4.Name = "txtautobackupfilepath4";
            this.txtautobackupfilepath4.Size = new System.Drawing.Size(386, 20);
            this.txtautobackupfilepath4.TabIndex = 138;
            // 
            // cmdautobackup4
            // 
            this.cmdautobackup4.BackColor = System.Drawing.Color.Transparent;
            this.cmdautobackup4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdautobackup4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdautobackup4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdautobackup4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdautobackup4.ForeColor = System.Drawing.Color.Black;
            this.cmdautobackup4.Location = new System.Drawing.Point(412, 209);
            this.cmdautobackup4.Name = "cmdautobackup4";
            this.cmdautobackup4.Size = new System.Drawing.Size(75, 24);
            this.cmdautobackup4.TabIndex = 137;
            this.cmdautobackup4.Text = "Browse";
            this.cmdautobackup4.UseVisualStyleBackColor = false;
            this.cmdautobackup4.Click += new System.EventHandler(this.cmdautobackup4_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(2, 164);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(18, 13);
            this.label34.TabIndex = 136;
            this.label34.Text = "3:";
            // 
            // txtautobackupfilepath3
            // 
            this.txtautobackupfilepath3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtautobackupfilepath3.Location = new System.Drawing.Point(21, 161);
            this.txtautobackupfilepath3.Name = "txtautobackupfilepath3";
            this.txtautobackupfilepath3.Size = new System.Drawing.Size(386, 20);
            this.txtautobackupfilepath3.TabIndex = 135;
            // 
            // cmdautobackup3
            // 
            this.cmdautobackup3.BackColor = System.Drawing.Color.Transparent;
            this.cmdautobackup3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdautobackup3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdautobackup3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdautobackup3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdautobackup3.ForeColor = System.Drawing.Color.Black;
            this.cmdautobackup3.Location = new System.Drawing.Point(413, 159);
            this.cmdautobackup3.Name = "cmdautobackup3";
            this.cmdautobackup3.Size = new System.Drawing.Size(75, 24);
            this.cmdautobackup3.TabIndex = 134;
            this.cmdautobackup3.Text = "Browse";
            this.cmdautobackup3.UseVisualStyleBackColor = false;
            this.cmdautobackup3.Click += new System.EventHandler(this.cmdautobackup3_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(2, 116);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(18, 13);
            this.label33.TabIndex = 133;
            this.label33.Text = "2:";
            // 
            // txtautobackupfilepath2
            // 
            this.txtautobackupfilepath2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtautobackupfilepath2.Location = new System.Drawing.Point(21, 113);
            this.txtautobackupfilepath2.Name = "txtautobackupfilepath2";
            this.txtautobackupfilepath2.Size = new System.Drawing.Size(386, 20);
            this.txtautobackupfilepath2.TabIndex = 132;
            // 
            // cmdautobackup2
            // 
            this.cmdautobackup2.BackColor = System.Drawing.Color.Transparent;
            this.cmdautobackup2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdautobackup2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdautobackup2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdautobackup2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdautobackup2.ForeColor = System.Drawing.Color.Black;
            this.cmdautobackup2.Location = new System.Drawing.Point(413, 111);
            this.cmdautobackup2.Name = "cmdautobackup2";
            this.cmdautobackup2.Size = new System.Drawing.Size(75, 24);
            this.cmdautobackup2.TabIndex = 131;
            this.cmdautobackup2.Text = "Browse";
            this.cmdautobackup2.UseVisualStyleBackColor = false;
            this.cmdautobackup2.Click += new System.EventHandler(this.cmdautobackup2_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 60);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 13);
            this.label32.TabIndex = 130;
            this.label32.Text = "1:";
            // 
            // txtautobackupfilepath1
            // 
            this.txtautobackupfilepath1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtautobackupfilepath1.Location = new System.Drawing.Point(22, 57);
            this.txtautobackupfilepath1.Name = "txtautobackupfilepath1";
            this.txtautobackupfilepath1.Size = new System.Drawing.Size(386, 20);
            this.txtautobackupfilepath1.TabIndex = 129;
            // 
            // cmdautobackup1
            // 
            this.cmdautobackup1.BackColor = System.Drawing.Color.Transparent;
            this.cmdautobackup1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdautobackup1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdautobackup1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdautobackup1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdautobackup1.ForeColor = System.Drawing.Color.Black;
            this.cmdautobackup1.Location = new System.Drawing.Point(414, 55);
            this.cmdautobackup1.Name = "cmdautobackup1";
            this.cmdautobackup1.Size = new System.Drawing.Size(75, 24);
            this.cmdautobackup1.TabIndex = 128;
            this.cmdautobackup1.Text = "Browse";
            this.cmdautobackup1.UseVisualStyleBackColor = false;
            this.cmdautobackup1.Click += new System.EventHandler(this.cmdautobackup1_Click);
            // 
            // chkautobackup
            // 
            this.chkautobackup.AutoSize = true;
            this.chkautobackup.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkautobackup.ForeColor = System.Drawing.Color.Black;
            this.chkautobackup.Location = new System.Drawing.Point(18, 16);
            this.chkautobackup.Name = "chkautobackup";
            this.chkautobackup.Size = new System.Drawing.Size(99, 16);
            this.chkautobackup.TabIndex = 107;
            this.chkautobackup.Text = "Auto Backup";
            this.chkautobackup.UseVisualStyleBackColor = true;
            this.chkautobackup.CheckedChanged += new System.EventHandler(this.chkautobackup_CheckedChanged);
            // 
            // Pnlstartup
            // 
            this.Pnlstartup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlstartup.Controls.Add(this.Txtstrshowstartupbalance);
            this.Pnlstartup.Controls.Add(this.Chkstrshowbalance);
            this.Pnlstartup.Controls.Add(this.Txtstrshowstartupstock);
            this.Pnlstartup.Controls.Add(this.chkstrshowstock);
            this.Pnlstartup.Location = new System.Drawing.Point(151, 330);
            this.Pnlstartup.Name = "Pnlstartup";
            this.Pnlstartup.Size = new System.Drawing.Size(739, 10);
            this.Pnlstartup.TabIndex = 127;
            this.Pnlstartup.Visible = false;
            // 
            // Chkstrshowbalance
            // 
            this.Chkstrshowbalance.AutoSize = true;
            this.Chkstrshowbalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Chkstrshowbalance.ForeColor = System.Drawing.Color.Black;
            this.Chkstrshowbalance.Location = new System.Drawing.Point(18, 75);
            this.Chkstrshowbalance.Name = "Chkstrshowbalance";
            this.Chkstrshowbalance.Size = new System.Drawing.Size(135, 16);
            this.Chkstrshowbalance.TabIndex = 128;
            this.Chkstrshowbalance.Text = "Show CashBalance";
            this.Chkstrshowbalance.UseVisualStyleBackColor = true;
            this.Chkstrshowbalance.CheckedChanged += new System.EventHandler(this.Chkstrshowbalance_CheckedChanged);
            // 
            // chkstrshowstock
            // 
            this.chkstrshowstock.AutoSize = true;
            this.chkstrshowstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkstrshowstock.ForeColor = System.Drawing.Color.Black;
            this.chkstrshowstock.Location = new System.Drawing.Point(19, 19);
            this.chkstrshowstock.Name = "chkstrshowstock";
            this.chkstrshowstock.Size = new System.Drawing.Size(96, 16);
            this.chkstrshowstock.TabIndex = 105;
            this.chkstrshowstock.Text = "Show Stock";
            this.chkstrshowstock.UseVisualStyleBackColor = true;
            this.chkstrshowstock.CheckedChanged += new System.EventHandler(this.chkstrshowstock_CheckedChanged);
            // 
            // PnlOtherprint
            // 
            this.PnlOtherprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlOtherprint.Controls.Add(this.cmdsummerrefresh);
            this.PnlOtherprint.Controls.Add(this.pnlmost);
            this.PnlOtherprint.Controls.Add(this.ChkRPdetails);
            this.PnlOtherprint.Controls.Add(this.griditems);
            this.PnlOtherprint.Controls.Add(this.label80);
            this.PnlOtherprint.Location = new System.Drawing.Point(145, 422);
            this.PnlOtherprint.Name = "PnlOtherprint";
            this.PnlOtherprint.Size = new System.Drawing.Size(739, 10);
            this.PnlOtherprint.TabIndex = 134;
            this.PnlOtherprint.Visible = false;
            // 
            // cmdsummerrefresh
            // 
            this.cmdsummerrefresh.BackColor = System.Drawing.Color.White;
            this.cmdsummerrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsummerrefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsummerrefresh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdsummerrefresh.Location = new System.Drawing.Point(120, 3);
            this.cmdsummerrefresh.Name = "cmdsummerrefresh";
            this.cmdsummerrefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdsummerrefresh.TabIndex = 217;
            this.cmdsummerrefresh.Text = "Refresh";
            this.cmdsummerrefresh.UseVisualStyleBackColor = false;
            this.cmdsummerrefresh.Click += new System.EventHandler(this.cmdsummerrefresh_Click);
            // 
            // ChkRPdetails
            // 
            this.ChkRPdetails.AutoSize = true;
            this.ChkRPdetails.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRPdetails.ForeColor = System.Drawing.Color.Black;
            this.ChkRPdetails.Location = new System.Drawing.Point(8, 349);
            this.ChkRPdetails.Name = "ChkRPdetails";
            this.ChkRPdetails.Size = new System.Drawing.Size(135, 19);
            this.ChkRPdetails.TabIndex = 216;
            this.ChkRPdetails.Text = "R_P Details Shows";
            this.ChkRPdetails.UseVisualStyleBackColor = true;
            this.ChkRPdetails.CheckedChanged += new System.EventHandler(this.ChkRPdetails_CheckedChanged);
            // 
            // griditems
            // 
            this.griditems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griditems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.griditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griditems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clnuserselect,
            this.Clnitems});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griditems.DefaultCellStyle = dataGridViewCellStyle8;
            this.griditems.EnableHeadersVisualStyles = false;
            this.griditems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.griditems.Location = new System.Drawing.Point(5, 32);
            this.griditems.Name = "griditems";
            this.griditems.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            this.griditems.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.griditems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.griditems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.griditems.Size = new System.Drawing.Size(337, 307);
            this.griditems.StandardTab = true;
            this.griditems.TabIndex = 215;
            // 
            // Clnuserselect
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Clnuserselect.DefaultCellStyle = dataGridViewCellStyle7;
            this.Clnuserselect.FalseValue = "0";
            this.Clnuserselect.FillWeight = 25F;
            this.Clnuserselect.HeaderText = "";
            this.Clnuserselect.Name = "Clnuserselect";
            this.Clnuserselect.TrueValue = "1";
            this.Clnuserselect.Width = 35;
            // 
            // Clnitems
            // 
            this.Clnitems.FillWeight = 200F;
            this.Clnitems.HeaderText = "Details";
            this.Clnitems.Name = "Clnitems";
            this.Clnitems.ReadOnly = true;
            this.Clnitems.Width = 300;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.Crimson;
            this.label80.Location = new System.Drawing.Point(1, 5);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(113, 15);
            this.label80.TabIndex = 0;
            this.label80.Text = "Summery PrintSET";
            // 
            // txtitemcodebcodesize
            // 
            this.txtitemcodebcodesize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtitemcodebcodesize.Location = new System.Drawing.Point(95, 154);
            this.txtitemcodebcodesize.Name = "txtitemcodebcodesize";
            this.txtitemcodebcodesize.Size = new System.Drawing.Size(68, 23);
            this.txtitemcodebcodesize.TabIndex = 158;
            // 
            // txtratesize
            // 
            this.txtratesize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtratesize.Location = new System.Drawing.Point(95, 123);
            this.txtratesize.Name = "txtratesize";
            this.txtratesize.Size = new System.Drawing.Size(68, 23);
            this.txtratesize.TabIndex = 153;
            // 
            // txtbcodeHeight
            // 
            this.txtbcodeHeight.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbcodeHeight.Location = new System.Drawing.Point(95, 32);
            this.txtbcodeHeight.Name = "txtbcodeHeight";
            this.txtbcodeHeight.Size = new System.Drawing.Size(68, 23);
            this.txtbcodeHeight.TabIndex = 147;
            // 
            // txtlangsize
            // 
            this.txtlangsize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtlangsize.Location = new System.Drawing.Point(93, 184);
            this.txtlangsize.Name = "txtlangsize";
            this.txtlangsize.Size = new System.Drawing.Size(71, 23);
            this.txtlangsize.TabIndex = 160;
            // 
            // txtitemsize
            // 
            this.txtitemsize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtitemsize.Location = new System.Drawing.Point(95, 63);
            this.txtitemsize.Name = "txtitemsize";
            this.txtitemsize.Size = new System.Drawing.Size(68, 23);
            this.txtitemsize.TabIndex = 149;
            // 
            // txtcompnysize
            // 
            this.txtcompnysize.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtcompnysize.Location = new System.Drawing.Point(96, 92);
            this.txtcompnysize.Name = "txtcompnysize";
            this.txtcompnysize.Size = new System.Drawing.Size(68, 23);
            this.txtcompnysize.TabIndex = 151;
            // 
            // TxtsstartingBarcode
            // 
            this.TxtsstartingBarcode.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtsstartingBarcode.Location = new System.Drawing.Point(14, 49);
            this.TxtsstartingBarcode.Name = "TxtsstartingBarcode";
            this.TxtsstartingBarcode.Size = new System.Drawing.Size(69, 28);
            this.TxtsstartingBarcode.TabIndex = 138;
            // 
            // txtqrhight
            // 
            this.txtqrhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqrhight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtqrhight.Location = new System.Drawing.Point(48, 78);
            this.txtqrhight.Name = "txtqrhight";
            this.txtqrhight.Size = new System.Drawing.Size(73, 21);
            this.txtqrhight.TabIndex = 181;
            // 
            // txtqrwidth
            // 
            this.txtqrwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqrwidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtqrwidth.Location = new System.Drawing.Point(48, 55);
            this.txtqrwidth.Name = "txtqrwidth";
            this.txtqrwidth.Size = new System.Drawing.Size(73, 21);
            this.txtqrwidth.TabIndex = 180;
            // 
            // txtphadressfont
            // 
            this.txtphadressfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphadressfont.Location = new System.Drawing.Point(115, 211);
            this.txtphadressfont.Name = "txtphadressfont";
            this.txtphadressfont.Size = new System.Drawing.Size(68, 23);
            this.txtphadressfont.TabIndex = 176;
            // 
            // txttaxtfnt
            // 
            this.txttaxtfnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaxtfnt.Location = new System.Drawing.Point(115, 182);
            this.txttaxtfnt.Name = "txttaxtfnt";
            this.txttaxtfnt.Size = new System.Drawing.Size(68, 23);
            this.txttaxtfnt.TabIndex = 175;
            // 
            // txtnamehomefnt
            // 
            this.txtnamehomefnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamehomefnt.Location = new System.Drawing.Point(115, 153);
            this.txtnamehomefnt.Name = "txtnamehomefnt";
            this.txtnamehomefnt.Size = new System.Drawing.Size(68, 23);
            this.txtnamehomefnt.TabIndex = 174;
            // 
            // txtcompanyfnt
            // 
            this.txtcompanyfnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyfnt.Location = new System.Drawing.Point(115, 126);
            this.txtcompanyfnt.Name = "txtcompanyfnt";
            this.txtcompanyfnt.Size = new System.Drawing.Size(68, 23);
            this.txtcompanyfnt.TabIndex = 173;
            // 
            // TXTICONSIZE
            // 
            this.TXTICONSIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTICONSIZE.Location = new System.Drawing.Point(115, 25);
            this.TXTICONSIZE.Name = "TXTICONSIZE";
            this.TXTICONSIZE.Size = new System.Drawing.Size(68, 23);
            this.TXTICONSIZE.TabIndex = 167;
            // 
            // txticonstartpoint
            // 
            this.txticonstartpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txticonstartpoint.Location = new System.Drawing.Point(115, 54);
            this.txticonstartpoint.Name = "txticonstartpoint";
            this.txticonstartpoint.Size = new System.Drawing.Size(68, 23);
            this.txticonstartpoint.TabIndex = 169;
            // 
            // txticonend
            // 
            this.txticonend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txticonend.Location = new System.Drawing.Point(115, 81);
            this.txticonend.Name = "txticonend";
            this.txticonend.Size = new System.Drawing.Size(68, 23);
            this.txticonend.TabIndex = 171;
            // 
            // txtcodeprintwidth
            // 
            this.txtcodeprintwidth.Location = new System.Drawing.Point(189, 282);
            this.txtcodeprintwidth.Name = "txtcodeprintwidth";
            this.txtcodeprintwidth.Size = new System.Drawing.Size(95, 20);
            this.txtcodeprintwidth.TabIndex = 164;
            // 
            // txtuserwiseMaxdisc
            // 
            this.txtuserwiseMaxdisc.Location = new System.Drawing.Point(136, 276);
            this.txtuserwiseMaxdisc.Name = "txtuserwiseMaxdisc";
            this.txtuserwiseMaxdisc.Size = new System.Drawing.Size(55, 21);
            this.txtuserwiseMaxdisc.TabIndex = 173;
            // 
            // txtsaledefaultdisc
            // 
            this.txtsaledefaultdisc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtsaledefaultdisc.Location = new System.Drawing.Point(645, 26);
            this.txtsaledefaultdisc.Margin = new System.Windows.Forms.Padding(4);
            this.txtsaledefaultdisc.Name = "txtsaledefaultdisc";
            this.txtsaledefaultdisc.Size = new System.Drawing.Size(96, 25);
            this.txtsaledefaultdisc.TabIndex = 168;
            // 
            // txtcodewidth
            // 
            this.txtcodewidth.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtcodewidth.Location = new System.Drawing.Point(113, 198);
            this.txtcodewidth.Name = "txtcodewidth";
            this.txtcodewidth.Size = new System.Drawing.Size(65, 25);
            this.txtcodewidth.TabIndex = 144;
            this.txtcodewidth.Load += new System.EventHandler(this.txtcodewidth_Load);
            this.txtcodewidth.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtcodewidth_TextChanged);
            this.txtcodewidth.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtcodewidth_PreviewKeyDown);
            // 
            // txtbatchwidthpurchase
            // 
            this.txtbatchwidthpurchase.Location = new System.Drawing.Point(580, 15);
            this.txtbatchwidthpurchase.Name = "txtbatchwidthpurchase";
            this.txtbatchwidthpurchase.Size = new System.Drawing.Size(73, 24);
            this.txtbatchwidthpurchase.TabIndex = 133;
            // 
            // txttaxpercset
            // 
            this.txttaxpercset.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.txttaxpercset.Location = new System.Drawing.Point(214, 332);
            this.txttaxpercset.Name = "txttaxpercset";
            this.txttaxpercset.Size = new System.Drawing.Size(140, 26);
            this.txttaxpercset.TabIndex = 29;
            // 
            // txtfarab
            // 
            this.txtfarab.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfarab.Location = new System.Drawing.Point(53, 18);
            this.txtfarab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfarab.Name = "txtfarab";
            this.txtfarab.Size = new System.Drawing.Size(278, 26);
            this.txtfarab.TabIndex = 13;
            this.txtfarab.Load += new System.EventHandler(this.txtfarab_Load);
            // 
            // txtestimatepwd
            // 
            this.txtestimatepwd.Location = new System.Drawing.Point(9, 19);
            this.txtestimatepwd.Name = "txtestimatepwd";
            this.txtestimatepwd.Size = new System.Drawing.Size(177, 22);
            this.txtestimatepwd.TabIndex = 0;
            // 
            // Txtstrshowstartupbalance
            // 
            this.Txtstrshowstartupbalance.Enabled = false;
            this.Txtstrshowstartupbalance.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Txtstrshowstartupbalance.Location = new System.Drawing.Point(37, 95);
            this.Txtstrshowstartupbalance.Name = "Txtstrshowstartupbalance";
            this.Txtstrshowstartupbalance.Size = new System.Drawing.Size(70, 22);
            this.Txtstrshowstartupbalance.TabIndex = 129;
            // 
            // Txtstrshowstartupstock
            // 
            this.Txtstrshowstartupstock.Enabled = false;
            this.Txtstrshowstartupstock.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.Txtstrshowstartupstock.Location = new System.Drawing.Point(38, 39);
            this.Txtstrshowstartupstock.Name = "Txtstrshowstartupstock";
            this.Txtstrshowstartupstock.Size = new System.Drawing.Size(70, 22);
            this.Txtstrshowstartupstock.TabIndex = 127;
            // 
            // Frmsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(924, 653);
            this.Controls.Add(this.PnlOtherprint);
            this.Controls.Add(this.PnlBarcodeSets);
            this.Controls.Add(this.pnlwarnings);
            this.Controls.Add(this.Pnprintersettings);
            this.Controls.Add(this.PnlSales);
            this.Controls.Add(this.Pnlpurchase);
            this.Controls.Add(this.pnlvoucherType);
            this.Controls.Add(this.pnldefault);
            this.Controls.Add(this.PnlGeneral);
            this.Controls.Add(this.Pnlcreate);
            this.Controls.Add(this.Pnlstartup);
            this.Controls.Add(this.Pnlaoutobackup);
            this.Controls.Add(this.cmdapply);
            this.Controls.Add(this.cmdcancel);
            this.Controls.Add(this.cmdok);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.TRMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.Frmsettings_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmsettings_KeyPress);
            this.Pnlcreate.ResumeLayout(false);
            this.Pnlcreate.PerformLayout();
            this.Grpsetestimatepassword.ResumeLayout(false);
            this.GrpItemSearch.ResumeLayout(false);
            this.GrpItemSearch.PerformLayout();
            this.Pnlpurchase.ResumeLayout(false);
            this.Pnlpurchase.PerformLayout();
            this.PnlSales.ResumeLayout(false);
            this.PnlSales.PerformLayout();
            this.pnlmost.ResumeLayout(false);
            this.pnlmost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmostmove)).EndInit();
            this.PnlBarcodeSets.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.GrpBarcode.ResumeLayout(false);
            this.GrpBarcode.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlvoucherType.ResumeLayout(false);
            this.pnlvoucherType.PerformLayout();
            this.pnldefault.ResumeLayout(false);
            this.pnldefault.PerformLayout();
            this.PnlGeneral.ResumeLayout(false);
            this.PnlGeneral.PerformLayout();
            this.panelfootr.ResumeLayout(false);
            this.panelfootr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Grpbatchenable.ResumeLayout(false);
            this.Grpbatchenable.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlwarnings.ResumeLayout(false);
            this.pnlwarnings.PerformLayout();
            this.Pnprintersettings.ResumeLayout(false);
            this.Pnprintersettings.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Pnlaoutobackup.ResumeLayout(false);
            this.Pnlaoutobackup.PerformLayout();
            this.Pnlstartup.ResumeLayout(false);
            this.Pnlstartup.PerformLayout();
            this.PnlOtherprint.ResumeLayout(false);
            this.PnlOtherprint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griditems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TRMain;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Panel Pnlcreate;
        private System.Windows.Forms.CheckBox Chkecostcenter;
        private System.Windows.Forms.CheckBox chketax;
        private System.Windows.Forms.CheckBox ChkEstockarea;
        private System.Windows.Forms.CheckBox Chkmultiunit;
        private System.Windows.Forms.CheckBox ChkEmultirate;
        private System.Windows.Forms.Panel Pnlpurchase;
        private System.Windows.Forms.CheckBox chkeditpurchaserate;
        private System.Windows.Forms.CheckBox chkpfree;
        private System.Windows.Forms.CheckBox chkpitemdiscount;
        private System.Windows.Forms.Panel PnlSales;
        private System.Windows.Forms.CheckBox chkeditsrate;
        private System.Windows.Forms.CheckBox chksfree;
        private System.Windows.Forms.CheckBox Chksitemdiscount;
        private System.Windows.Forms.Panel pnlvoucherType;
        private System.Windows.Forms.CheckBox chkpurchaseestimation;
        private System.Windows.Forms.CheckBox chkpurchaseorder;
        private System.Windows.Forms.CheckBox chkmeterialreceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chksalesorder;
        private System.Windows.Forms.CheckBox chksalesestimation;
        private System.Windows.Forms.CheckBox chkdeliverynote;
        private System.Windows.Forms.Panel pnldefault;
        private System.Windows.Forms.ComboBox Comdefstockarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Comdefsalesman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Comdefbank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PnlGeneral;
        private System.Windows.Forms.CheckBox ChkEProduction;
        private System.Windows.Forms.CheckBox Chkepayroll;
        private System.Windows.Forms.CheckBox ChkEPOS;
        private System.Windows.Forms.CheckBox ChkEBatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComstockDeci;
        private System.Windows.Forms.TextBox TxtMinerSymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMajorSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ComCurDecimal;
        private System.Windows.Forms.CheckBox ChkItemwiseagentcomm;
        private System.Windows.Forms.Panel pnlwarnings;
        private System.Windows.Forms.Button cmdapply;
        private System.Windows.Forms.Button cmdcancel;
        private System.Windows.Forms.Button cmdok;
        private System.Windows.Forms.CheckBox chkroundoff;
        private System.Windows.Forms.ComboBox comdefcashaccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Chkpurchasereturn;
        private System.Windows.Forms.CheckBox Chksalesreturn;
        private System.Windows.Forms.CheckBox Chkupdateprate;
        private System.Windows.Forms.CheckBox Chkupdatesrate;
        private System.Windows.Forms.CheckBox Chkupdatemrp;
        private System.Windows.Forms.ComboBox comdeftax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkagentsales;
        private System.Windows.Forms.CheckBox chksalesmansales;
        private System.Windows.Forms.CheckBox chkagentpurchase;
        private System.Windows.Forms.CheckBox chkemployeepurchase;
        private System.Windows.Forms.CheckBox chkpexciseduty;
        private System.Windows.Forms.CheckBox chkpeditgrossamt;
        private System.Windows.Forms.Panel Pnprintersettings;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radother10;
        private System.Windows.Forms.RadioButton radother6;
        private System.Windows.Forms.RadioButton radother3;
        private System.Windows.Forms.RadioButton raddot10;
        private System.Windows.Forms.RadioButton raddot6;
        private System.Windows.Forms.RadioButton raddot3;
        private System.Windows.Forms.GroupBox Grpbatchenable;
        private System.Windows.Forms.CheckBox chkuseasbarcode;
        private System.Windows.Forms.Panel Pnlaoutobackup;
        private System.Windows.Forms.TextBox txtautobackupfilepath1;
        private System.Windows.Forms.Button cmdautobackup1;
        private System.Windows.Forms.CheckBox chkautobackup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radbarcodeprintmrp;
        private System.Windows.Forms.RadioButton radbarcodeprintsrate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox GrpBarcode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkmixedkerala;
        private System.Windows.Forms.CheckBox Chkesize;
        private System.Windows.Forms.CheckBox chka4split;
        private System.Windows.Forms.CheckBox ChkSaleUpdateSalesrate;
        private System.Windows.Forms.CheckBox chkflex;
        private System.Windows.Forms.RadioButton radotherdetail;
        private System.Windows.Forms.RadioButton radmultipleprint;
        private System.Windows.Forms.CheckBox chksfocusfirstrow;
        private System.Windows.Forms.CheckBox chkmixedkarnataka;
        private System.Windows.Forms.CheckBox chkpitemnote2;
        private System.Windows.Forms.CheckBox chkpitemnote1;
        private System.Windows.Forms.CheckBox chkcustomerpoint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadBprintlaser;
        private System.Windows.Forms.RadioButton RadBPrintRoll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbpackeddate;
        private System.Windows.Forms.CheckBox chkbitemnote2;
        private System.Windows.Forms.CheckBox chkbnote1;
        private System.Windows.Forms.CheckBox chkbsuppliercode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbarcodeprifix;
        private System.Windows.Forms.CheckBox chkdeactivecustomerzerobalance;
        private System.Windows.Forms.GroupBox GrpItemSearch;
        private System.Windows.Forms.RadioButton raditemanykeysearch;
        private System.Windows.Forms.RadioButton Raditemlastkeysearch;
        private System.Windows.Forms.RadioButton Raditemfirstsearch;
        private System.Windows.Forms.Label lblsmsbalance;
        private System.Windows.Forms.TextBox txtsmsbalance;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtlasertopmargin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtlaserleftmargin;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtprefixsales;
        private System.Windows.Forms.CheckBox chkcashcadjet;
        private System.Windows.Forms.CheckBox chkcrm;
        private System.Windows.Forms.CheckBox chkslnotracking;
        private System.Windows.Forms.ComboBox comwarnnegetivecash;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comwarncreditlimit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtnocopies;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtbarcodeheading;
        private System.Windows.Forms.CheckBox chkbarcodehusecompanyname;
        private System.Windows.Forms.CheckBox chksinvoicedisc;
        private System.Windows.Forms.CheckBox chkweightmachine;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtprintfooter;
        private System.Windows.Forms.CheckBox chkenpharmacy;
        private System.Windows.Forms.CheckBox chkvisibleprate;
        private System.Windows.Forms.CheckBox chkvisiblessrate;
        private System.Windows.Forms.CheckBox chkeditgrossamountinsales;
        private System.Windows.Forms.RadioButton raddot8;
        private System.Windows.Forms.RadioButton radbarcodeprintnone;
        private System.Windows.Forms.CheckBox Chksupplierwiseitem;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtreverse;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtfscroll;
        private System.Windows.Forms.CheckBox chkprintbalance;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtdistancebarcodesticker;
        private System.Windows.Forms.RadioButton radprintratebyitems;
        private System.Windows.Forms.CheckBox chkpsavezerorate;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtstartingbarcode;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtautobackupfilepath4;
        private System.Windows.Forms.Button cmdautobackup4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtautobackupfilepath3;
        private System.Windows.Forms.Button cmdautobackup3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtautobackupfilepath2;
        private System.Windows.Forms.Button cmdautobackup2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtstickerprint;
        private System.Windows.Forms.CheckBox chkremovedublicate;
        private System.Windows.Forms.ComboBox commodeofpaymentsales;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox commodeofpaymentpurchase;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox chkepartyproject;
        private System.Windows.Forms.CheckBox chkprintbarcodelogo;
        private System.Windows.Forms.GroupBox Grpsetestimatepassword;
        private System.Windows.Forms.Button cmdsett;
        private Uscnormaltextbox txtestimatepwd;
        private System.Windows.Forms.CheckBox chkshowestimateledger;
        private System.Windows.Forms.Panel Pnlstartup;
        private System.Windows.Forms.CheckBox chkstrshowstock;
        private Uscnuemerictextbox Txtstrshowstartupbalance;
        private System.Windows.Forms.CheckBox Chkstrshowbalance;
        private Uscnuemerictextbox Txtstrshowstartupstock;
        private System.Windows.Forms.CheckBox chkseditqty;
        private System.Windows.Forms.CheckBox chkprintllangague;
        private System.Windows.Forms.RadioButton RadBprintbutterfly;
        private System.Windows.Forms.CheckBox chkconsole;
        private System.Windows.Forms.CheckBox chksetsaleincludetax;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txttoplaser;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtleftlaser;
        private System.Windows.Forms.CheckBox chkzerotaxamount;
        private System.Windows.Forms.CheckBox chkpbillingdate;
        private System.Windows.Forms.CheckBox chktailoring;
        private System.Windows.Forms.CheckBox Chksinglebarcode;
        private System.Windows.Forms.CheckBox Chksalearea;
        private System.Windows.Forms.ComboBox Comwarnsaleratelessthanprate;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox Comwarnmaximumstock;
        private System.Windows.Forms.Label lblwarnmaximumstock;
        private System.Windows.Forms.ComboBox Comwarnreorderstock;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox Comwarnminimumstock;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox Comwarnnegetivestock;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox Chksavezeroratesales;
        private System.Windows.Forms.ComboBox ComLanguage;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.RadioButton raddotmobile;
        private System.Windows.Forms.CheckBox Chkpprintsecondlangague;
        private System.Windows.Forms.RadioButton Raddotpreprinted;
        private System.Windows.Forms.RadioButton Rad3pointarabic;
        private System.Windows.Forms.CheckBox ChkEditItemName;
        private System.Windows.Forms.ComboBox Comtaxinclusivesales;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox Chkpedititemcode;
        private System.Windows.Forms.CheckBox ChkpprintTaxrateinclusive;
        private System.Windows.Forms.CheckBox chkservices;
        public System.Windows.Forms.CheckBox chkprintfooter;
        public System.Windows.Forms.CheckBox chkwarranty;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox Txtsprintrate;
        public System.Windows.Forms.CheckBox chkfootpostn;
        private System.Windows.Forms.Panel panelfootr;
        private System.Windows.Forms.Button Cmdfooterset;
        private System.Windows.Forms.Button cmdFclose;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtL5;
        private System.Windows.Forms.TextBox txtL4;
        private System.Windows.Forms.TextBox txtL3;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Uscnormaltextbox txtfarab;
        public System.Windows.Forms.CheckBox ChkfootMid;
        private System.Windows.Forms.CheckBox chkQrcode;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.CheckBox Chkssearchingmode;
        private System.Windows.Forms.CheckBox chkprintoldblnce;
        private System.Windows.Forms.CheckBox chkbaseunit;
        private System.Windows.Forms.CheckBox chkmixed3;
        private System.Windows.Forms.CheckBox CHKTAILLOR;
        private System.Windows.Forms.Label label58;
        private Uscnuemerictextbox TxtsstartingBarcode;
        private System.Windows.Forms.ComboBox Comsecondprint;
        private System.Windows.Forms.CheckBox Chkenablesecondprinter;
        private System.Windows.Forms.CheckBox Chksitemnote;
        private System.Windows.Forms.CheckBox ChkprintnoTax;
        private System.Windows.Forms.ComboBox combprintselectn;
        private System.Windows.Forms.Label lblprintstyle;
        private System.Windows.Forms.Label lblamtwords;
        private System.Windows.Forms.ComboBox combamtinwords;
        private System.Windows.Forms.Label label54;
        private Uscnuemerictextbox txtcodewidth;
        private System.Windows.Forms.Label label59;
        private Uscnuemerictextbox txtbcodeHeight;
        private System.Windows.Forms.Label lblBheight;
        private Uscnuemerictextbox txtcompnysize;
        private System.Windows.Forms.Label lblcmpsize;
        private Uscnuemerictextbox txtitemsize;
        private System.Windows.Forms.Label lblitemsize;
        private Uscnuemerictextbox txtratesize;
        private System.Windows.Forms.Label lblratesize;
        private System.Windows.Forms.CheckBox Chkbcodesrate;
        private System.Windows.Forms.CheckBox chkllangbcode;
        private Uscnuemerictextbox txtlangsize;
        private System.Windows.Forms.Label lbllangsize;
        private Uscnuemerictextbox txtitemcodebcodesize;
        private System.Windows.Forms.Label LBLCODESIZE;
        private System.Windows.Forms.CheckBox chkcodeinbcode;
        private System.Windows.Forms.CheckBox ChkcreditlimitON;
        private System.Windows.Forms.CheckBox chkmtrread;
        private System.Windows.Forms.CheckBox chkvehicle;
        private Uscnuemerictextbox txtcodeprintwidth;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.CheckBox chkempsales;
        private Uscnuemerictextbox TXTICONSIZE;
        private System.Windows.Forms.Label label61;
        private Uscnuemerictextbox txticonstartpoint;
        private System.Windows.Forms.Label label62;
        private Uscnuemerictextbox txticonend;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txtbcodeeprefix;
        private System.Windows.Forms.Label lblbcodedig;
        private System.Windows.Forms.TextBox txtbcodedegit;
        private System.Windows.Forms.Panel PnlBarcodeSets;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private Uscnuemerictextbox txttaxpercset;
        private System.Windows.Forms.Label lbltaxperc;
        private System.Windows.Forms.CheckBox chkitemlistview;
        private System.Windows.Forms.CheckBox chkmanexdate;
        private System.Windows.Forms.CheckBox chkitemnametop;
        private System.Windows.Forms.CheckBox chkheaderVisible;
        private System.Windows.Forms.CheckBox chkSaleitemroundoff;
        private System.Windows.Forms.ComboBox Comwarnsaleratelessthanretailrate;
        private System.Windows.Forms.Label label68;
        private Uscnuemerictextbox txtsaledefaultdisc;
        private System.Windows.Forms.Label label69;
        public System.Windows.Forms.CheckBox Chkprateinlist;
        private System.Windows.Forms.CheckBox chkbarcoderate;
        private System.Windows.Forms.CheckBox ChkbcodeQty;
        private System.Windows.Forms.TextBox txtbcodeend;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox txtbcodestart;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtqtyend;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtqtystat;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox txtbcoderateend;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtbcoderatestart;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox txtBcodeRateDivision;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txtBcodeQTYDivision;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Panel PnlOtherprint;
        public System.Windows.Forms.DataGridView griditems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Clnuserselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clnitems;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.CheckBox CHKautomaticmodeSET;
        private System.Windows.Forms.CheckBox ChkRPdetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private Uscnuemerictextbox txtphadressfont;
        private Uscnuemerictextbox txttaxtfnt;
        private Uscnuemerictextbox txtnamehomefnt;
        private Uscnuemerictextbox txtcompanyfnt;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox txtBcodetextPrefix;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Panel pnlmost;
        private System.Windows.Forms.Label label87;
        public System.Windows.Forms.DataGridView gridmostmove;
        private System.Windows.Forms.CheckBox chkmostmove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MMpcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.Label lblsample;
        private System.Windows.Forms.CheckBox chkrateroundoffbcode;
        private System.Windows.Forms.CheckBox chkuserwisedisc;
        private System.Windows.Forms.Label label88;
        private Uscnuemerictextbox txtuserwiseMaxdisc;
        private System.Windows.Forms.CheckBox chkpurchpritwhile;
        private System.Windows.Forms.CheckBox chkpurchprintconfrm;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.ComboBox combprintselectnpurchase;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.CheckBox chkbottomstock;
        private System.Windows.Forms.CheckBox chkstockshow;
        private System.Windows.Forms.CheckBox chkautomodepurchase;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox combsecondaryModel;
        private System.Windows.Forms.CheckBox CHKCUSwisevat;
        private System.Windows.Forms.CheckBox chkbcodeprintBold;
        private System.Windows.Forms.CheckBox chkdatetwoline;
        private System.Windows.Forms.Label label93;
        private Uscnuemerictextbox txtqrhight;
        private Uscnuemerictextbox txtqrwidth;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label97;
        private Uscnuemerictextbox txtbatchwidthpurchase;
        private System.Windows.Forms.Button cmdsummerrefresh;
        private System.Windows.Forms.CheckBox chkdatewisectrlreport;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox COMCASHSYMBOL;
        private System.Windows.Forms.CheckBox CHKinsrprefix;
    }
}