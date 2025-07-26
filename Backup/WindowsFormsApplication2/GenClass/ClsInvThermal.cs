using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using CnetSDK.Barcode.Generator.Trial;
using ZXing;
using ZXing.QrCode;

namespace WindowsFormsApplication2
{
    class ClsInvThermal
    {
        private QrCodeEncodingOptions options;
      public  string FieldValue;

        public bool SitemNote;
        int xRate;
        int xProductName = new int();
        int XGrossAmt;
        double SUmNetAmt = 0;
        double SumSrate = 0;
        public bool PrintBarcodeLaser;
        public string secondheading = "";
        public string cashrecvd = "";
        public string extrapymnt = "";
        public string extrapymntype = "";
        public string deskbalnc = "";
        public string vehicle = "";
        public string mtrread = "";
        //thermalreportpos
        private string InvImageheadrr;
        public string totP = "";
        public string totPamt = "";
        public string totstaxname = "";
        public string totstaxnameamt = "";
        public string TPTX = "";
        public string TPTXamt = "";
        public string STPT = "";
        public string STPTamt = "";
        public string TCS = "";
        public string TCSamt = "";
        public string TCshS = "";
        public string TCshSamt = "";
        public string TD = "";
        public string TDamt = "";
        public string TSl = "";
        public string TSlamt = "";
        public string saleNarration = "";
        public string warrantyStr = "";

        public string extrapaymnt = "";

        /*For Settings*/
        string Cst = "";
        public bool SSlnotracking;
        public static string SelPrint;
        public bool SProject;
        /***************/
        public string StrNaration = "";
        public string Strstate = "KARNATAKA";
        public string PSelect;
        public bool Bunit;
        public string PTYpe;
        public bool PrintOldbalance;
        public long ValidRecord = 0;
        int RecordsPerPage = 31; // twenty items in a page
        /*Load Data*/
        public string ModeofPayment;
        public string Lid;
        public string TempCust;
        public string EmployeeId;
        public string Agentid;
        public double CashDiscount;
        public DateTime BillDate;
        public string Billno;
        public string TgrossAmt;
        public string TDiscount;
        public string Totherexpense;
        public string BillAmount;
        public string AmountinWords;
        public string Ttaxamount;

        string NameInHome = "";

        public string TotalQty;
        public double TotalItemDisc;
        public double TotalTaxable;
        public double TotalTaxAmount;
        public double TotalNetamount;
        public double OldBalance;

        public string InvoiceName;
        public string TaxDeclaration;
        public string FormType;
        public string DateStr;
        public string TimeStr;

        public int xTotalValue;

        int TRowcounting = 0;
        int TempRowcounting = 0;
        /**********************************/

        int xQty;
        int xDiscount;
        int xTaxable;
        int xTaxAmt;
        int xNetamt;
        int xTaxperc;
        public string Temp;
        DBTask _Dbtask = new DBTask();
        ClsCompanyMaster _Companymaster = new ClsCompanyMaster();
        ClsAccountLedger _Accountledger = new ClsAccountLedger();
        Generalfunction _Gen = new Generalfunction();
        Clstax _Tax = new Clstax();

        ClsSalesBarcodePrint _BcodePrint = new ClsSalesBarcodePrint();

        public static DataGridView MainGrid;
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        public System.Windows.Forms.PrintDialog prnDialog;
        public System.Windows.Forms.PrintPreviewDialog prnPreview;
        public System.Drawing.Printing.PrintDocument prnDocument;
        public System.ComponentModel.Container components = null;

        // for Invoice Head:
        private string InvTitle = "";
        private string InvSubTitleInvoicename = "";
        private string InvSubTitleTaxDeclaration = "";
        private string InvSubTitle1 = "";
        private string InvSubTitle11 = "";
        private string InvSubTitle2 = "";
        private string InvSubTitle3 = "";
        private string InvSubTitle4 = "";
        private string InvSubTitle5 = "";
        private string InvSubTitle6 = "";
        private string InvSubTitle7 = "";
        private string InvImage;
        public double OLDBBLNC = 0;
        public double NOWBBLNC = 0;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
        private string CustomerName;
        private string CustomerCity;
        private string SellerName;
        private string SaleID;
        private string SaleDate;
        private decimal SaleFreight;
        private decimal SubTotal;
        private decimal InvoiceTotal;
        private bool ReadInvoice;
        private int AmountPosition;
        StringFormat Str;
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";


        public int qrhight = 0;
        public int qrwidth = 0;




        public int HX;
        public int HY;
        public int FX;
        public int FY;

        // Font and Color:------------------
        // Title Font
        private Font Arialnormal = new Font("Arial", 10, FontStyle.Regular);
        private Font ArialnormalItalic = new Font("Arial", 10, FontStyle.Italic);
        private Font Arialbold = new Font("Arial", 10, FontStyle.Bold);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        // private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //private Font InvoiceFont = new Font("Calibri", 12, FontStyle.Regular);
        private Font VerdanaBoldHeadingMain = new Font("Calibri", 15, FontStyle.Bold);
        private Font VerdanaBoldHeadingMain2 = new Font("Calibri", 12, FontStyle.Bold);

        private Font VerdanaBoldHeading = new Font("Verdana", 12, FontStyle.Bold);
       
        private Font VerdanaBold = new Font("Verdana", 9, FontStyle.Regular);
        //private Font VerdanaArabic = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        private Font VerdanaArabic = new Font("Calibri", 8, FontStyle.Bold);
        private Font arbHead = new Font("Calibri", 12, FontStyle.Bold);
        private Font arbHead2 = new Font("Calibri", 10, FontStyle.Bold);
        
        
        private Font VerdanaBoldAddress = new Font("Verdana", 9, FontStyle.Bold);
        private Font CalibiRiItalic = new Font("Verdana", 8, FontStyle.Italic);
        private Font CalibiRiItalic2 = new Font("Comic Sans MS", 9, FontStyle.Bold);
        private Font CalibiRiItalic3 = new Font("Comic Sans MS", 7, FontStyle.Bold);

        private Font CalibiRiItalic4 = new Font("Comic Sans MS", 10, FontStyle.Bold);
        //Customer Detail MV Boli

        private Font BOLI = new Font("SimHei", 12, FontStyle.Regular);
       
        private Font Verdananormal = new Font("Verdana", 8, FontStyle.Regular);

        private Font Verdanaitalic = new Font("Verdana", 8, FontStyle.Regular);
        //Declaration Font
        private Font Declarationfont = new Font("Calibri", 8, FontStyle.Regular);

        private Font AmountInwordsfont = new Font("Calibri", 10, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);
        //private SolidBrush BlackBrush = new SolidBrush(Color.Black);
        DBTask _dbtask = new DBTask();


        public void PrinterSettingsNew()
        {
            if (CommonClass._settings.ReturnStatus("150") == "1")
            {
                PrintOldbalance = true;
            }
            else
            {
                PrintOldbalance = false;
            }

            System.Drawing.Printing.PrinterSettings newSettings = new System.Drawing.Printing.PrinterSettings();
            newSettings.PrinterName = PSelect;
            prnDocument.PrinterSettings.PrinterName = newSettings.PrinterName;
        }

        public void frmOrder()
        {
            //InitializeComponent();

            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // The Event of 'PrintPage'
            //prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
        }
        public string TaxDeclarationfU()
        {
            if (PSelect == "7" || PSelect == "8")
                Strstate = "KERALA";

            Temp = "               THE " + Strstate + " VALUE ADDED TAX RULES, 2005";

            return Temp;
        }
        private void ReadInvoiceHead()
            {


                qrhight = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("QRheight"));
                qrwidth = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("QRwidth"));

            //HX = Convert.ToInt32(_dbtask.ExecuteScalar("select Xvalue from tblicon where icon='Header'"));
            //HY = Convert.ToInt32(_dbtask.ExecuteScalar("select Yvalue from tblicon where icon='Header'"));
           
            //FX = Convert.ToInt32(_dbtask.ExecuteScalar("select Xvalue from tblicon where icon='Footer'"));
            //FY = Convert.ToInt32(_dbtask.ExecuteScalar("select Yvalue from tblicon where icon='Footer'"));
           
            //Titles and Image of invoice:
            InvSubTitleInvoicename = InvoiceName;
            InvImageheadrr = Application.StartupPath + @"\Images\" + "QR.jpg";
            InvImage = Application.StartupPath + @"\Images\" + "InvPic.jpg";
            if (FormType == "SALES RETURN")
            {
                InvSubTitle5 = " " + FormType + " INVOICE";
            }
            else if (FormType == "DELIVERY NOTE")
            {
                InvSubTitle5 = "" + FormType + " INVOICE";
            }
            else if (FormType == "     SALES ORDER")
            {
                InvSubTitle5 = "      " + FormType;
            }
            else if (FormType == "ESTIMATE")
            {
                InvSubTitle5 = "      " + FormType;
            }
            else
            {
                InvSubTitle5 = "       " + FormType + " INVOICE";
            }


            InvSubTitle5 = CommonClass._Language.GetArabicString(InvSubTitle5);

            InvTitle = _Companymaster.GetspecifField("cname");
            InvSubTitleTaxDeclaration = TaxDeclarationfU();
            InvSubTitle1 = _Companymaster.GetspecifField("Address1");
            InvSubTitle11 = _Companymaster.GetspecifField("Address2");
            InvSubTitle2 = _Companymaster.GetspecifField("Telephone") + ": هاتف";//Kerala
            InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
            InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
            InvSubTitle6 = "Bill No:" + Billno + "                                                                                     Bill Date";
            InvSubTitle7 = "Name&Address :" + _Accountledger.GetspecifField("lname", Lid) + "," + _Accountledger.GetspecifField("address", Lid) + ";                                                                                     Bill Date";
            Cst = _Companymaster.GetspecifField("taxno2");
            if (FormType != "ESTIMATE")
            {
                InvTitle = _Companymaster.GetspecifField("cname");
                NameInHome = _Companymaster.GetspecifField("NameInHome");
                InvSubTitleTaxDeclaration = TaxDeclarationfU();
                InvSubTitle1 = _Companymaster.GetspecifField("Address1");
                InvSubTitle11 = _Companymaster.GetspecifField("Address2");
                InvSubTitle2 = _Companymaster.GetspecifField("Telephone");
                InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
                InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
                InvSubTitle6 = "Bill No:" + Billno + "                                                                                     Bill Date";
                InvSubTitle7 = "Name&Address :" + _Accountledger.GetspecifField("lname", Lid) + "," + _Accountledger.GetspecifField("address", Lid) + ";                                                                                     Bill Date";
                Cst = _Companymaster.GetspecifField("taxno2");
            }
            else
            {
                //  RecordsPerPage = 40;
                RecordsPerPage = 31;

            }
        }

        private void SetInvoiceHead(Graphics g)
                {
            ReadInvoiceHead();
            string Arbsubtit = "";
            if (FormType == "WHOLESALE")
            {
                CurrentY = topMargin / 2;
            }
            else
            {
                CurrentY = topMargin;
            }
            // CurrentY = topMargin;

            CurrentX = leftMargin;
            int ImageHeight = 0;

            int icosizze = 0;
            icosizze =Convert.ToInt32( CommonClass._Paramlist.GetParamvalue("Iconsize"));
            int icostart = 0;
            icostart = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Iconstart"));
            int icoend = 0;
            icoend = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Iconend"));

            //if(FormType!="Salesdaybookcount")
            //{
            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage) && FormType != "Salesdaybookcount")
            {
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, icostart, CurrentY, icoend, icosizze);

                CurrentY = CurrentY + 70;
            }
            InvTitleHeight = (int)(VerdanaBoldHeading.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvsubtitleinvoice = (int)g.MeasureString(InvSubTitleInvoicename, InvSubTitleFont).Width;
            int lenInvTitle = (int)g.MeasureString(InvTitle, VerdanaBoldHeading).Width;
            int lenInvsubTitleTaxdeclaration = (int)g.MeasureString(InvSubTitleTaxDeclaration, InvSubTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle11 = (int)g.MeasureString(InvSubTitle11, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            int lenInvSubTitle4 = (int)g.MeasureString(InvSubTitle4, InvSubTitleFont).Width;
            int lenInvSubTitle5 = (int)g.MeasureString(InvSubTitle5, Verdananormal).Width;
            int lenInvSubTitle6 = (int)g.MeasureString(InvSubTitle6, Verdananormal).Width;
            int lenInvSubTitle7 = (int)g.MeasureString(InvSubTitle7, Verdananormal).Width;

            // Set Titles Left:
            int xInvsubtitleinvoice = CurrentX + (InvoiceWidth - lenInvsubtitleinvoice) / 2;
            int xInvsubTitleTaxdeclaration = CurrentX + (InvoiceWidth - lenInvsubTitleTaxdeclaration) / 2;

            int xInvTitle = CurrentX + (250 - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (250 - lenInvSubTitle1) / 2;
            int xInvSubTitle11 = CurrentX + (250 - lenInvSubTitle11) / 2;
            int xInvSubTitle2 = CurrentX + (250 - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (250 - lenInvSubTitle3) / 2;
            int xInvSubTitle4 = CurrentX + (250 - lenInvSubTitle4) / 2;
            int xInvSubTitle5 = CurrentX + (250 - lenInvSubTitle5) / 2;
            int xInvSubTitle6 = CurrentX + (250 - lenInvSubTitle6) / 2;
            int hx = 5;
            CurrentX = 5;
            
            // Draw Invoice Head:
            if (InvSubTitle3 != "" && FormType != "Report" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                //g.DrawString("VAT:", Arialnormal, BlackBrush, 25, CurrentY / 2);/*For Tin*/
                //g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 75, CurrentY / 2);/*CST Reg No*/

            }
            else
            {
                RecordsPerPage = 40;
            }
            string Scndhead= "";InvSubTitle5 ="";
            if (FormType == "Sales Quatation")
            {
                InvSubTitle5 = "Sales Quatation";//, VerdanaBold, BlackBrush, 480, CurrentY);//142
            }
            if (FormType == "Sales Order")
            {
                InvSubTitle5 = "Saler Order";//, VerdanaBold, BlackBrush, 480, CurrentY);//142
            }
            if (FormType == "Sales Return")
            {
                InvSubTitle5 = "مرتجع فاتورة ";//, VerdanaBold, BlackBrush, 550, CurrentY);//142
                Scndhead ="Saler Return";
            }
            if (FormType == "Sales" || FormType == "Frmpointofsale")
            {

                InvSubTitle5 = "فاتورة ضريبية مبسطة" ;
                Scndhead = secondheading;
            }
            int InvTitlefntsiz = 0; int InHomefntsiz = 0; int taxfntsiz = 0; int addphonefntsiz = 0;
            InvTitlefntsiz = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("THheadfnt"));
            InHomefntsiz = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("THinhomefnt"));
            taxfntsiz = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("THtaxfnt"));
            addphonefntsiz = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("THaddphfnt"));



            Font InvTitlefnt = new Font("Lucida Bright", InvTitlefntsiz, FontStyle.Bold);
            Font addphonefnt = new Font("Lucida Fax", addphonefntsiz, FontStyle.Bold);
            Font InHomefnt = new Font("Lucida Bright", InHomefntsiz, FontStyle.Bold);
            Font taxfnt = new Font("Rockwell", taxfntsiz, FontStyle.Bold);
            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            //if (Cst != "" && FormType != "Report" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            //{
            //    g.DrawString("CST", Arialnormal, BlackBrush, 600, CurrentY / 2);/*For CST Reg No*/

            //    g.DrawString(Cst, Arialbold, BlackBrush, 650, CurrentY / 2);/*CST Reg No*/
            //}
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/

            //if (FormType != "Purchase Order" && FormType != "Purchase")/**/
            //{
            //    CurrentY = CurrentY + 10;
            //   hx = (300 - (int)g.MeasureString(InvSubTitle5, arbHead).Width) / 2;
            //   g.DrawString(InvSubTitle5, arbHead, BlackBrush, hx - 20, CurrentY);
            //    CurrentY = CurrentY + 23;
            //    if (Scndhead!="")
            //    {
            //        hx = (300 - (int)g.MeasureString(Scndhead, arbHead).Width) / 2;
            //        g.DrawString(Scndhead, arbHead, BlackBrush, hx - 20, CurrentY);
            //        CurrentY = CurrentY + 23;
                
            //    }

            //}
            if (InvTitle != "" && FormType != "Purchase Order" )/*For Company Heading*/
            {
                //if (FormType == "Sales Return")/**/
                //{
                //    Arbsubtit = "عائد المبيعات";  //CurrentY = CurrentY + ImageHeight;
                //}
                //if(FormType=="Sales")
                //{
                //Arbsubtit = "فاتورة ضریبیة المبسطة";
                //}
                //if(FormType=="SALES QUATATION")
                //{
                //Arbsubtit = "تسعير المبيعات";
                //}
                //if (FormType == "     SALES ORDER")
                //{
                //    Arbsubtit = "طلب المبيعات";
                //}

    
                
                if (FormType != "Salesdaybookcount")
                {
                    hx = (300 - (int)g.MeasureString(InvTitle, InvTitlefnt).Width) / 2;
                    CurrentY = CurrentY + 5;
                    g.DrawString(InvTitle, InvTitlefnt, BlackBrush, hx - 15, CurrentY);
                    CurrentY = CurrentY + 30;
                }
            }
            if (NameInHome != "" &&FormType != "Salesdaybookcount")
            {
               
                
                hx = (300 - (int)g.MeasureString(NameInHome,InHomefnt).Width) / 2;
                g.DrawString(NameInHome, InHomefnt, BlackBrush, hx - 20, CurrentY);
                CurrentY = CurrentY + 30;
            }
            
            if (InvSubTitle1 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "Salesdaybookcount")/*For Address*/
            {

                hx = (300 - (int)g.MeasureString(InvSubTitle1, addphonefnt).Width) / 2;
                g.DrawString(InvSubTitle1, addphonefnt, BlackBrush, hx - 20, CurrentY);
                CurrentY = CurrentY + 7;
            }

                if (InvSubTitle11 != "" && FormType !="Salesdaybookcount"&& FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address2*/
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle11, addphonefnt, BlackBrush, 50, CurrentY);
                CurrentY = CurrentY + 7;
            }
                if (InvSubTitle2 != "" && FormType != "Salesdaybookcount" && FormType != "Report" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                hx = (300 - (int)g.MeasureString(InvSubTitle2, addphonefnt).Width) / 2;

                g.DrawString(InvSubTitle2, addphonefnt, BlackBrush, hx - 20, CurrentY);
                CurrentY = CurrentY + 7;
            }
                if (InvSubTitle3 != "" && FormType != "Report" && FormType != "Salesdaybookcount" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*VAt Number*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                hx = (300 - (int)g.MeasureString(InvSubTitle3, taxfnt).Width) / 2;

                g.DrawString(InvSubTitle3, taxfnt, BlackBrush, hx - 20, CurrentY);
                CurrentY = CurrentY + 7;
            }

            /***********New Rule*******************/
                if (CommonClass._Menusettings.GetMnustatus("194") == "-1")
                {
                    //CurrentY = CurrentY + InvSubTitleHeight + 5;
                    hx = (300 - (int)g.MeasureString(InvSubTitle3, arbHead2).Width) / 2;
                    if (FormType != "Sales")
                    {
                        //g.DrawString(FormType, arbHead, BlackBrush, hx - 5, CurrentY);
                    }
                        // CurrentY = CurrentY + 7;

                    //CurrentY = CurrentY + InvSubTitleHeight;
                    hx = (300 - (int)g.MeasureString(InvSubTitle3, arbHead).Width) / 2;
                    if (FormType == "Sales")
                    {
                    //g.DrawString("Simplified Tax Invoice", arbHead, BlackBrush, hx - 5, CurrentY);
                    //CurrentY = CurrentY + 10;
                    }
                }
            //    g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+5, rightMargin, CurrentY+5);
            ///*************************/

            //CurrentY = CurrentY + 16;
            //if (InvSubTitle4 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION"&&FormType !="ESTIMATE")/*For TaxRule*/
            //{
            //    CurrentY = CurrentY + InvSubTitleHeight;
            //    g.DrawString(InvSubTitle4, Arialnormal, BlackBrush, 180, CurrentY);
            //    CurrentY = CurrentY + 5;

            //    CurrentY = CurrentY + InvSubTitleHeight;

            //    if (FormType == "WHOLESALE")
            //    {
            //        g.DrawString("FORM NO.8", Arialbold, BlackBrush, 350, CurrentY);
            //    }
            //    else if (FormType == "    RETAIL")
            //    {
            //        g.DrawString("FORM NO.8B", Arialbold, BlackBrush, 350, CurrentY);
            //        CurrentY = CurrentY + 5;

            //        CurrentY = CurrentY + InvSubTitleHeight;
            //        g.DrawString("(For Customers When input tax credit is not required)", Verdanaitalic, BlackBrush, 250, CurrentY);
            //        CurrentY = CurrentY + 5;
            //    }
            //    else if (FormType == "SALES RETURN" || FormType == "DELIVERY NOTE")
            //    {
            //        g.DrawString("FORM NO.9", Arialbold, BlackBrush, 350, CurrentY);
            //    }



            //    CurrentY = CurrentY + InvSubTitleHeight;
            //    g.DrawString("[See rule 58(10)]", Verdanaitalic, BlackBrush, 350, CurrentY);
            //    CurrentY = CurrentY + 5;

            //}

            //if (InvSubTitle3 != "")/*For Tin*/
            //{
            //    CurrentY = CurrentY + InvSubTitleHeight;
            //    g.DrawString(InvSubTitle3, InvSubTitleFont, BlackBrush, xInvSubTitle3, CurrentY);
            //}

            if (InvSubTitle5 != "")/*For InVoiceName*/
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 25, CurrentY);
                // CurrentY = CurrentY + 5;

                //if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                //{
                //    CurrentY = CurrentY + InvSubTitleHeight;
                //    if (ModeofPayment == "CASH")
                //    {
                //        CurrentX = (300 - (int)g.MeasureString("CASH", VerdanaBold).Width) / 2;
                //        g.DrawString("CASH", VerdanaBold, BlackBrush, CurrentX, CurrentY);
                //    }
                //    else if (ModeofPayment == "CREDIT")
                //    {
                //        CurrentX = (300 - (int)g.MeasureString("CREDIT", VerdanaBold).Width) / 2;
                //        g.DrawString("CREDIT", VerdanaBold, BlackBrush, CurrentX, CurrentY);
                //    }
                //    else
                //    {
                //        CurrentX = (300 - (int)g.MeasureString("CASH", VerdanaBold).Width) / 2;
                //        g.DrawString("CASH", VerdanaBold, BlackBrush, CurrentX, CurrentY);
                //    }
                //    CurrentY = CurrentY + 15;
                //}

                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("(To be Prepared in Duplicate)", Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle6 != "" && FormType != "Salesdaybookcount" && FormType == "Multi" && FormType != "Report")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle6, Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle7 != "" && FormType != "Salesdaybookcount" && FormType == "Multi" && FormType != "Report")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle7, Verdananormal, BlackBrush, 300, CurrentY);
            }

            if (FormType != "Purchase Order" && FormType != "Purchase")/**/
            {
              

                //if (CommonClass._Ledger.GetspecifField("taxregno", Lid) != "" && CommonClass._Ledger.GetspecifField("taxregno", Lid) != "0.00")
                //{

                CurrentY = CurrentY + 10;
                    
                    if (Scndhead != "")
                    {
                        if ("Simplified Tax Invoice   فاتورة ضربيية مبسطة" == Scndhead)
                        {
                          
                            hx = (300 - (int)g.MeasureString(InvSubTitle5, arbHead).Width) / 2;
                            g.DrawString(InvSubTitle5, arbHead, BlackBrush, hx - 20, CurrentY);
                            CurrentY = CurrentY + 23;

                            Scndhead = "Simplified Tax Invoice";
                        }
                        if ("Tax Invoice   فاتورة ضريبية" == Scndhead)
                        {
                            Scndhead = Scndhead;
                        }


                        hx = (300 - (int)g.MeasureString(Scndhead, arbHead).Width) / 2;
                        g.DrawString(Scndhead, arbHead, BlackBrush, hx - 20, CurrentY);
                        CurrentY = CurrentY + 23;

                    }
                //}
                //else
                //{
                //    InvSubTitle5 = "Sales Invoice";
                //    hx = (300 - (int)g.MeasureString(InvSubTitle5, arbHead).Width) / 2;
                //    g.DrawString(InvSubTitle5, arbHead, BlackBrush, hx - 20, CurrentY);
                //    CurrentY = CurrentY + 23;
                
                //}





            }



            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            //g.DrawLine(new Pen(Brushes.Black, 1), 50, 100, 50, 1050);
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, rightMargin, CurrentY);
        }
        public void DrawHorizontalline(int Width)
        {
            //g.DrawLine(new Pen(Brushes.Black,1), leftMargin, 100, rightMargin, 100);
        }
        private void SetOrderData(Graphics g)
        {
            string FieldValue = "";
            InvoiceFontHeight = (int)(Arialbold.GetHeight(g));

            CurrentX = leftMargin + 10;
            CurrentY = CurrentY - 18;
            if (FormType != "Report" && FormType != "Salesdaybookcount")
            {
                FieldValue = "INVOICE NO: ";
                g.DrawString(FieldValue, VerdanaBold, BlackBrush, 3, CurrentY);
                g.DrawString(Billno, VerdanaBold, BlackBrush, 105, CurrentY);

                CurrentY = CurrentY + 16;
                FieldValue = "Date ";
                g.DrawString(FieldValue, VerdanaBold, BlackBrush, 3, CurrentY);
                g.DrawString(":" + BillDate.ToString("dd/MM/yyyy"), Verdananormal, BlackBrush, 80, CurrentY);

                // CurrentY = CurrentY + 16;


                g.DrawString("Time", VerdanaBold, BlackBrush, 160, CurrentY);
                g.DrawString(":" + BillDate.ToString("hh:mm:ss tt"), Verdananormal, BlackBrush, 200, CurrentY);
                CurrentY = CurrentY + 16;
                string CName = TempCust;
                string employeid = "";string employee = "";
               employeid =_dbtask.znllString( EmployeeId);
               employee = _dbtask.znllString(_Accountledger.GetspecifField("lname", employeid));

               if (CommonClass._Menusettings.GetMnustatus("199").ToString() == "1")
               {
                   if (vehicle != "")
                {
                    g.DrawString("رقم لوحة السيارة  :" , VerdanaBold, BlackBrush, 3, CurrentY);
                    g.DrawString( vehicle, VerdanaBold, BlackBrush, 100, CurrentY);
                    CurrentY = CurrentY + 18;
                    
                }
        
               }
               if (CommonClass._Menusettings.GetMnustatus("200").ToString() == "1")
               {
                   if (mtrread != "")
                   {
                       g.DrawString("رقم عداد السيارة  :" , VerdanaBold, BlackBrush, 3, CurrentY);
                       g.DrawString( mtrread, VerdanaBold, BlackBrush, 100, CurrentY);
                       
                       CurrentY = CurrentY + 18;
                    
                   }
               }


                string Address =_dbtask.znllString( _Accountledger.GetspecifField("address",Lid));

                string CTin = Tvat;
                string MOBI = "";
                int CCount = Address.Split('\n').Length - 1;

                if (Tename != ""  )
                {
                    CName = Tename;
                }
                if ( Address=="")
                {
                    Address = Taddres;
                }


                if (SProject == true)
                {
                    Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
                }
                if (employee!="")
                 {
                     g.DrawString("Employee : " + employee, VerdanaBold, BlackBrush, 3, CurrentY);
                     CurrentY = CurrentY + 18;
                }
                g.DrawString("Customer : ", VerdanaBold, BlackBrush, 3, CurrentY);
                FieldValue = CName;
                g.DrawString(FieldValue, Verdananormal, BlackBrush, 75, CurrentY);

                int count = 0;
                FieldValue = "";
                int kk = 1;
                //foreach (char c in Address)
                //{
                //    FieldValue = FieldValue + c;
                //    if (c == '\n')
                //    {
                //        g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
                //        kk++;
                //        FieldValue = "";
                //    }
                //    count++;
                //}
                if (Address != "")
                {
                    CurrentY = CurrentY + 18;
                    FieldValue = "Address: " + Address;
                    g.DrawString(FieldValue, VerdanaBold, BlackBrush, 3, CurrentY);

                    if (Address.Length>30)
                {
                    CurrentY = CurrentY + 18;
                }
                
                }
                    // kk++;
                //  g.DrawString(Address.Substring(M,5), VerdanaBold, BlackBrush, CurrentX, CurrentY);

                // int CCount=Address.

                //if (FieldValue.Length > 92)
                //{
                //    g.DrawString(FieldValue.Substring(0,92), VerdanaBold, BlackBrush, CurrentX, CurrentY);
                //    g.DrawString(FieldValue.Substring(92, FieldValue.Length-92), VerdanaBold, BlackBrush, CurrentX, CurrentY+15);
                //}
                //else
                //{
                //    g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);
                //}

                // if(



                //CurrentX = leftMargin;
                // CurrentY = CurrentY + InvoiceFontHeight * 2;
                //FieldValue = "Telephone    : " + _Accountledger.GetspecifField("phone", Lid);

                //if (FormType == "WHOLESALE" || FormType == "Purchase Return" || SProject == false)
                //{
                //    FieldValue = "TRN";
                //    g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //    FieldValue = ":";
                //    g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //    FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                //    g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                //    CurrentY = CurrentY + InvoiceFontHeight;
                //}

                //FieldValue = "Mobile";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);

                if (SProject == true)
                {
                    FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
                    Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
                }
                else
                {
                   // MOBI =  = _Accountledger.GetspecifField("mobile", Lid);
                
                }
                   MOBI   = _Accountledger.GetspecifField("mobile", Lid);
                   if ( MOBI != "" && MOBI != "0.00")
                   {
                       Tmob = MOBI;
                   }
                    if(Tmob!=""||MOBI!=""&&MOBI!="0.00")
                    {
                         
                    CurrentY = CurrentY + 18;
                    FieldValue = Tmob; 
                    g.DrawString("Mobile : "+FieldValue, Verdananormal, BlackBrush, 5, CurrentY);
                    //CurrentY = CurrentY + 20;
                  }
                
                
               
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);


                //CurrentY = CurrentY + InvoiceFontHeight;
                // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
                //FieldValue = "Phone";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //FieldValue = _Accountledger.GetspecifField("phone", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight;
            }
            if (FormType == "WHOLESALE" || FormType == "Sales" )
            {
                string CTin = "";
                if (Lid != "")
                {
                    CTin = _Accountledger.GetspecifField("tAXREGNO", Lid);
                }
                
                if (CTin==""&&Tvat!="")
                {
                    CTin = Tvat;
                }
                FieldValue = "VAT:" + CTin;
                if (CTin != "" && CTin != null && CTin != "0.00")
                {
                    CurrentY = CurrentY + 20;
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX-5 , CurrentY);
                
                }
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //FieldValue = _Accountledger.GetspecifField("cst", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            }
            CurrentY = CurrentY + InvoiceFontHeight ;
            // g.DrawLine(new Pen(Brushes.Black,1), leftMargin, 100, rightMargin, 100);
            //  g.DrawLine(new Pen(Brushes.Black,1), leftMargin, CurrentY, rightMargin, CurrentY);
            // CurrentY = CurrentY + InvoiceFontHeight + 8;
        }
        public void RowValidation(DataGridView gridmain)
        {
            try
            {
                ValidRecord = 0;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (InvSubTitle5 == "       Report INVOICE")
                    {
                        if (i <= gridmain.Rows.Count-2)
                        {
                        //string valuekal = gridmain.Rows[i].Cells["vno"].Value.ToString();
                        if (gridmain.Rows[i].Cells["vno"].Value.ToString() == "" )

                        {

                            
                            gridmain.Rows[i].Tag = -1;
                            // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                            
                        }
                        else
                        {
                            ValidRecord = ValidRecord + 1;
                            gridmain.Rows[i].Tag = 1;
                            gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }
                        }
                    }

                    if (InvSubTitle5 != "       Report INVOICE" && FormType != "Salesdaybookcount")
                    {

                        if (gridmain.Rows[i].Cells["clnitemname"].Tag == null || Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value) == Convert.ToDouble(0))
                        {
                            gridmain.Rows[i].Tag = -1;
                            // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                        }

                        else
                        {
                            ValidRecord = ValidRecord + 1;
                            gridmain.Rows[i].Tag = 1;
                            gridmain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                        }
                    }

                    else
                    {
                        if(FormType == "Salesdaybookcount")
                        {
                            

                        }
                    }






                }

            }
            catch
            {
            }
        }

        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Invoice Table:
            string FieldValue = "";
            int CurrentRecord = 0;
            int Xcode = new int();
            decimal Amount = 0;
            bool StopReading = false;

            string SecondLanguage = "";

            // Set Table Head:
            int xSlno = leftMargin;
            //CurrentY = CurrentY ;
            CurrentY = CurrentY + 8;
            if (CommonClass._Paramlist.GetParamvalue("SPrintRate") != "Srate" && CommonClass._Paramlist.GetParamvalue("SPrintRate") != "Gross")
            {
                CommonClass._Paramlist.UpdateParamlist("SPrintRate", "", "Srate");
            }
            //g.DrawString("Rate", Verdananormal, BlackBrush, xSlno, CurrentY);

                    if( FormType =="Salesdaybookcount")
            {
                //xSlno = leftMargin;
                ////g.DrawString("Sl", VerdanaBold, BlackBrush, xSlno, CurrentY);

                ////xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                //g.DrawString("ItemName", VerdanaBold, BlackBrush, xProductName, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("ItemName", VerdanaBold).Width + 35;
                //g.DrawString("Qty", VerdanaBold, BlackBrush, xQty + 30, CurrentY);      //Qty

                //xRate = xQty + (int)g.MeasureString("Qty", VerdanaBold).Width + 30;
                ////g.DrawString("Tax", VerdanaBold, BlackBrush, xRate + 30, CurrentY); //rate

                //xNetamt = xRate + (int)g.MeasureString("Tax", VerdanaBold).Width + 35;
                //g.DrawString("Amount", VerdanaBold, BlackBrush, xNetamt - 8, CurrentY);
            }





            if (InvSubTitle5 == "       Report INVOICE")
            {

                xSlno = leftMargin;
                //g.DrawString("Sl", VerdanaBold, BlackBrush, xSlno, CurrentY);

                //xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                g.DrawString("Date", VerdanaBold, BlackBrush, xProductName, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Date", VerdanaBold).Width + 35;
                g.DrawString("Qty", VerdanaBold, BlackBrush, xQty + 30, CurrentY);      //Qty

                xRate = xQty + (int)g.MeasureString("Qty", VerdanaBold).Width + 30;
                g.DrawString("Tax", VerdanaBold, BlackBrush, xRate +30, CurrentY); //rate

                xNetamt = xRate + (int)g.MeasureString("Tax", VerdanaBold).Width + 35;
                g.DrawString("Amount", VerdanaBold, BlackBrush, xNetamt + 18, CurrentY);

            }


            if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "       Report INVOICE" && FormType != "Salesdaybookcount")
            {
                xSlno = leftMargin;
                g.DrawString("Sl", VerdanaBold, BlackBrush, xSlno, CurrentY);

                xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                g.DrawString("Item", VerdanaBold, BlackBrush, xProductName, CurrentY);

                xQty = xSlno + (int)g.MeasureString("Slno", VerdanaBold).Width + 70;
                g.DrawString("Qty", VerdanaBold, BlackBrush, xQty - 20, CurrentY);      //Qty

                xRate = xQty + (int)g.MeasureString("Qty", VerdanaBold).Width + 30;
                g.DrawString("Rate", VerdanaBold, BlackBrush, xRate - 30, CurrentY); //rate

                if (CommonClass._Menusettings.GetMnustatus("194") == "-1")
                {
                    XGrossAmt = xRate + (int)g.MeasureString("Rate", VerdanaBold).Width + 15;
                    g.DrawString("Tax", VerdanaBold, BlackBrush, XGrossAmt - 30, CurrentY);
                }

                
                    xNetamt = XGrossAmt + (int)g.MeasureString("Tax", VerdanaBold).Width + 30;
                    g.DrawString("Amount", VerdanaBold, BlackBrush, xNetamt - 50, CurrentY);
                

            }
            else
            {
                //510
                //602
                //638
                if (InvSubTitle5 != "       Report INVOICE" && FormType != "Salesdaybookcount")
                {
                    xSlno = leftMargin;
                    g.DrawString("Sl", VerdanaBold, BlackBrush, xSlno, CurrentY);

                    xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                    g.DrawString("ProductName", VerdanaBold, BlackBrush, xProductName, CurrentY);

                    xQty = xProductName + (int)g.MeasureString("ProductName", VerdanaBold).Width + 50;
                    g.DrawString("Qty", VerdanaBold, BlackBrush, xQty, CurrentY);      //Qty

                    xRate = xQty + (int)g.MeasureString("Qty", VerdanaBold).Width + 16;
                    g.DrawString("Rate", VerdanaBold, BlackBrush, xRate, CurrentY); //rate

                    xNetamt = xRate + (int)g.MeasureString("Rate", VerdanaBold).Width + 40;
                    g.DrawString("Amount", VerdanaBold, BlackBrush, xNetamt, CurrentY);

                }
            }




            // Set Invoice Table:
                if (FormType != "Salesdaybookcount")
            {
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY , rightMargin, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight + 8;
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight + 8;
            }
            RowValidation(MainGrid);
            CurrentY = CurrentY + 5;
            string ItemNote;

            SumSrate = 0;
            SUmNetAmt = 0;

            //posreport

            if(FormType=="Salesdaybookcount")
            {
                
                string language = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='language'").ToString();
                if (language != "Arabic")
                {
                    CurrentY = 30;
                    /****************************/
                    g.DrawString(_Companymaster.GetspecifField("Cname"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Nameinhome"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Address1"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Mobile"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("TaxNo1"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;


                    g.DrawString(DateStr, AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;


                    g.DrawString(TimeStr, AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    /***************************/
                    e.Graphics.DrawString("Total Purchase", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[0].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Sales Tax", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[1].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Purchase Tax", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[2].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Tax Net", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[3].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Sales", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[4].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Payment", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[5].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Receipt", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[6].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Card Sale", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[7].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Cash Sale", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[8].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Total Services", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[9].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("Net Balance", VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[10].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, 200, CurrentY);

                }
                else
                {
                    CurrentY = 30;
                    /****************************/
                    g.DrawString(_Companymaster.GetspecifField("Cname"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Nameinhome"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Address1"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("Mobile"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    g.DrawString(_Companymaster.GetspecifField("TaxNo1"), AmountInwordsfont, BlackBrush, 50, CurrentY);
                    CurrentY = CurrentY + 20;

                    /***************************/
                    e.Graphics.DrawString("إجمالي الشراء", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[0].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي ضريبة المبيعات", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[1].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي ضريبة الشراء", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[2].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("صافي مبلغ الضريبة", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[3].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي المبيعات", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[4].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("المبلغ الإجمالي", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[5].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي الإيصال", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[6].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي بيع البطاقة", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[7].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي البيع النقدي", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[8].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("إجمالي الخدمات", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[9].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);
                    CurrentY = CurrentY + 30;

                    e.Graphics.DrawString("الرصيد الصافي", VerdanaBoldHeadingMain2, BlackBrush, 250, CurrentY, Str);
                    e.Graphics.DrawString(_Dbtask.znlldoubletoobject(MainGrid.Rows[10].Cells[1].Value).ToString("0.00"), VerdanaBoldHeadingMain, BlackBrush, xSlno, CurrentY);

                
                    

                }

            }


            if (InvSubTitle5 == "       Report INVOICE")
            {






                for (int i = TRowcounting; i < MainGrid.Rows.Count - 1; i++)
                {

                    if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                    {
                        FieldValue = "";
                        //string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();

                        //SecondLanguage = CommonClass._Item.SpecificField(Itemid, "llang");

                        //if (_Dbtask.znllString(SecondLanguage) != "")
                        //{
                            FieldValue = MainGrid.Rows[i].Cells["date"].Value.ToString();
                            FieldValue = FieldValue.Substring(0, 11).ToString();
                            e.Graphics.DrawString(FieldValue, VerdanaBold, BlackBrush, xSlno, CurrentY);

                            e.Graphics.DrawString(SecondLanguage, VerdanaArabic, BlackBrush, 20, CurrentY);
                            //CurrentY = CurrentY + 15;//23
                        //}
                        //else
                            double qttty= _Dbtask.znlldoubletoobject( MainGrid.Rows[i].Cells["qty"].Value);
                            FieldValue = qttty.ToString();
                            e.Graphics.DrawString(FieldValue, VerdanaBold, BlackBrush, xSlno+100, CurrentY);
                        //}



                        //FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();


                        // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        if (FieldValue.Length > 25)
                            FieldValue = FieldValue.Substring(0, 25);
                        //e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xProductName, CurrentY);
                       // CurrentY = CurrentY + 12;//20




                        //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "unit");
                        //FieldValue = "";
                        //e.Graphics.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 25, CurrentY, Str);

                        if (CommonClass._Menusettings.GetMnustatus("194") == "-1")
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["taxamt"].Value));
                            e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xQty + 105, CurrentY, Str);
                            SumSrate = SumSrate + CommonClass._Dbtask.znlldoubletoobject(FieldValue);
                        }
                        //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                        //e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xRate, CurrentY, Str);
                        //SumSrate = SumSrate + CommonClass._Dbtask.znlldoubletoobject(FieldValue);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["netamount"].Value));
                        e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xNetamt+60, CurrentY, Str);
                        SUmNetAmt = SUmNetAmt + CommonClass._Dbtask.znlldoubletoobject(FieldValue);

                       // FieldValue = _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clngross"].Value).ToString() + ":بدون ضريبة‎     " +
                       // _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clntax"].Value).ToString() + ":(" +
                       //_Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")).ToString("0.0") + "%)" + "ضريبة ";
                        CurrentY = CurrentY + 10;//20
                       // e.Graphics.DrawString(FieldValue, CalibiRiItalic, BlackBrush, xProductName, CurrentY);


                        CurrentY = CurrentY + InvoiceFontHeight +4;//35
                        // * 2+4

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;

                    }

                }



            }
            else{


                if (FormType != "Salesdaybookcount")
                {






            for (int i = TRowcounting; i < MainGrid.Rows.Count ; i++)
            {

                if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                {
                    
                        string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();

                        SecondLanguage = CommonClass._Item.SpecificField(Itemid, "llang");

                        if (_Dbtask.znllString(SecondLanguage) != "")
                        {
                            
                            FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                            e.Graphics.DrawString(FieldValue, VerdanaBold, BlackBrush, xSlno, CurrentY);

                            //e.Graphics.DrawString(SecondLanguage, VerdanaArabic, BlackBrush, 20, CurrentY);
                            //CurrentY = CurrentY + 15;//23
                        }
                        else
                        {
                            FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                            e.Graphics.DrawString(FieldValue, VerdanaBold, BlackBrush, xSlno, CurrentY);
                        }



                        FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();


                        // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        if (FieldValue.Length > 24)
                        {
                            FieldValue = FieldValue.Substring(0, 23);
                        }

                        e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xProductName, CurrentY);

                        if (SecondLanguage.Length > 21)
                        {
                            SecondLanguage = SecondLanguage.Substring(0, 20);
                        }

                        int x = (275 - (int)g.MeasureString(SecondLanguage, VerdanaArabic).Width);
                        e.Graphics.DrawString(SecondLanguage, VerdanaArabic, BlackBrush, x, CurrentY);

                        CurrentY = CurrentY + 12;//20




                        //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "unit");
                        //FieldValue = "";
                        //e.Graphics.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 25, CurrentY, Str);
                            if (SitemNote == true)
                            {
                            FieldValue = _dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                            e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xProductName, CurrentY, Str);
                            }
                            if (Bunit == true)
                            {
                                FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["ClnbaseU"].Value);
                                e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xProductName, CurrentY, Str);
                            }

                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                        e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xQty, CurrentY, Str);

                        

                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["cln"+CommonClass._Paramlist.GetParamvalue("SPrintRate")+""].Value));
                        e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xRate, CurrentY, Str);
                        SumSrate = SumSrate + CommonClass._Dbtask.znlldoubletoobject(FieldValue);

                        if (CommonClass._Menusettings.GetMnustatus("194") == "-1")
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clntax"].Value));
                            e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, XGrossAmt, CurrentY, Str);
                        }
                            //SumSrate = SumSrate + CommonClass._Dbtask.znlldoubletoobject(FieldValue);



                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                        e.Graphics.DrawString(FieldValue, VerdanaArabic, BlackBrush, xNetamt, CurrentY, Str);
                        SUmNetAmt = SUmNetAmt + CommonClass._Dbtask.znlldoubletoobject(FieldValue);

                        FieldValue = _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clngross"].Value).ToString() + ":بدون ضريبة‎     " +
                        _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clntax"].Value).ToString() + ":(" +
                       _Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")).ToString("0.0") + "%)" + "ضريبة ";
                      //  CurrentY = CurrentY + 10;//20
                        


                        CurrentY = CurrentY + 5 ;//35
                        FieldValue = "-------------------------------------------------";
                        e.Graphics.DrawString(FieldValue, CalibiRiItalic, BlackBrush, xProductName, CurrentY);
                        CurrentY = CurrentY + 7;    
                    // * 2+4

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;
                   
                }

            }
            }
            }

          
            if (FormType != "Salesdaybookcount")
            {
                SetInvoiceTotal(g);
            }

            g.Dispose();
        }

        private void SetInvoiceDataBracode(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Invoice Table:
            string FieldValue = "";
            int CurrentRecord = 0;
            int RecordsPerPage = 25; // twenty items in a page
            decimal Amount = 0;
            bool StopReading = false;


            // Set Table Head:
            int xSlno = leftMargin + 10;
            //CurrentY = CurrentY ;
            CurrentY = CurrentY + 8;
            g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno, CurrentY);

            int xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width + 4;
            g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);

            xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 180;
            g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);

            int xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
            g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);

            xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
            g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);

            xTaxable = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 25;
            g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, xTaxable, CurrentY);

            int xTaxperc = xTaxable + (int)g.MeasureString("Taxable(Amt)", Verdananormal).Width + 10;
            g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxperc, CurrentY);

            xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
            g.DrawString("Tax(Amt)", Verdananormal, BlackBrush, xTaxAmt, CurrentY);

            xNetamt = xTaxAmt + (int)g.MeasureString("Tax(Amt)", Verdananormal).Width + 10;
            g.DrawString("Amount", Verdananormal, BlackBrush, xNetamt, CurrentY);

            // Set Invoice Table:
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight + 8;

            RowValidation(MainGrid);
            CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote;
            for (int i = TRowcounting; i < MainGrid.Rows.Count - 1; i++)
            {

                if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                {
                    if (TempRowcounting < RecordsPerPage)
                    {

                        FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xSlno, CurrentY);

                        FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();
                        if (FieldValue.Length > 35)
                            FieldValue = FieldValue.Substring(0, 35);
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xProductName, CurrentY);
                        ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnserialno"].Value);

                        if (SSlnotracking == true)
                            g.DrawString(ItemNote, Verdananormal, BlackBrush, xProductName, CurrentY + InvoiceFontHeight + 2);

                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty + 20, CurrentY, Str);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xRate + 50, CurrentY, Str);

                        FieldValue = String.Format("{0:0}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clndiscount"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xDiscount + 40, CurrentY, Str);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxable + 60, CurrentY, Str);

                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc + 30, CurrentY, Str);

                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxAmt + 50, CurrentY, Str);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xNetamt + 50, CurrentY, Str);


                        //Amount = Convert.ToDecimal(rdrInvoice["ExtendedPrice"]);
                        //// Format Extended Price and Align to Right:
                        //FieldValue = String.Format("{0:0.00}", Amount);
                        //int xAmount = AmountPosition + (int)g.MeasureString("Extended Price", InvoiceFont).Width;
                        //xAmount = xAmount - (int)g.MeasureString(FieldValue, InvoiceFont).Width;
                        //g.DrawString(FieldValue, InvoiceFont, BlackBrush, xAmount, CurrentY);
                        if (SSlnotracking == true)
                            CurrentY = CurrentY + InvoiceFontHeight * 2 + 4;
                        else
                            CurrentY = CurrentY + InvoiceFontHeight + 2;
                        StopReading = true;

                        //if (!rdrInvoice.Read())
                        //{
                        //    StopReading = true;
                        //    break;
                        //}

                        CurrentRecord++;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;
                    }
                }

            }

            if (CurrentRecord < RecordsPerPage)
            {
                e.HasMorePages = false;


                for (int i = CurrentRecord; i < RecordsPerPage; i++)
                {
                    g.DrawString("", Verdananormal, BlackBrush, AmountPosition, CurrentY);
                    CurrentY = CurrentY + InvoiceFontHeight;
                }
            }
            else
            {
                e.HasMorePages = true;

                TempRowcounting = 0;
                TRowcounting = TRowcounting + 1;
                // TRowcounting = TRowcounting + 1;
            }
            if (StopReading)
            {
                //rdrInvoice.Close();
                //cnn.Close();
                SetInvoiceTotal(g);
            }

            g.Dispose();
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

                    ClsInvThermal Frms = new ClsInvThermal();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " " + Frms._Gen.Getmajorsymbol() + " and " +
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
        public void BlankPrinting(Graphics g)
        {
            // g.DrawString(FieldValue, InvoiceFont, BlackBrush, xTaxperc, CurrentY);
            g.DrawString("", Verdananormal, BlackBrush, 0, 0);
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
        public double CalcTaxAmount(double TaxPerc, double Taxable)
        {
            return TaxPerc + Taxable;
        }

        public void VatPrinting(Graphics g)
        {

            if (StrNaration.Length > 55)
            {
                //g.DrawString(StrNaration.Substring(0, 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                //g.DrawString(StrNaration.Substring(55, StrNaration.Length - 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY + 15);
            }
            else
            {
                //g.DrawString(StrNaration, ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
            }
            if (InvSubTitle5 != "      ESTIMATE")
            {
                double TNetAmount;
                TNetAmount = CalcTaxAmount(Clstax.FivePercTaxAmount, Clstax.FivePercTaxableAmount);

                //g.DrawString(Clstax.FivePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 105, CurrentY);
                //g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 200, CurrentY);

                //g.DrawString("Tax % : ", VerdanaBoldHeading, BlackBrush, 0, CurrentY);
                //g.DrawString("5", ArialnormalItalic, BlackBrush, 105, CurrentY);

                //CurrentY = CurrentY + 20;

                //g.DrawString("Tax : ", VerdanaBoldHeading, BlackBrush, 0, CurrentY);
                //g.DrawString(Clstax.FivePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 95, CurrentY);
                //g.DrawString(CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(TotalTaxAmount)), ArialnormalItalic, BlackBrush, 105, CurrentY);

                //CurrentY = CurrentY + 20;

                //g.DrawString(": قيمة المشتريات", VerdanaBoldHeading, BlackBrush, 165, CurrentY);
                //g.DrawString(Clstax.FivePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 95, CurrentY);
                //g.DrawString(CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(TotalTaxable)), ArialnormalItalic, BlackBrush, 85, CurrentY);

                //CurrentY = CurrentY + 20;

                //g.DrawString(": المبلغ الإجمالي", VerdanaBoldHeading, BlackBrush, 165, CurrentY);
                //g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 95, CurrentY);
                //g.DrawString(CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(TotalNetamount)), ArialnormalItalic, BlackBrush, 85, CurrentY);

                //CurrentY = CurrentY + 20;

                //g.DrawLine(new Pen(Brushes.Black, 1), 0, CurrentY, 300, CurrentY);

                //CurrentY = CurrentY + 16;

                if (Clstax.ZeroPercTaxableAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.ZeroPercTaxAmount, Clstax.ZeroPercTaxableAmount);

                    //g.DrawString("0", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    //g.DrawString(Clstax.ZeroPercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    //g.DrawString(Clstax.ZeroPercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    //g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);

                    //CurrentY = CurrentY + 16;
                }
                if (Clstax.OnePercTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.OnePercTaxAmount, Clstax.OnePercTaxableAmount);

                    g.DrawString("1", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.OnePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.OnePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);

                    CurrentY = CurrentY + 16;
                }
                if (Clstax.TwoPercTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwoPercTaxAmount, Clstax.TwoPercTaxableAmount);
                    g.DrawString("2", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwoPercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwoPercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.FivePercTaxAmount > 0)
                {
                    //TNetAmount = CalcTaxAmount(Clstax.FivePercTaxAmount, Clstax.FivePercTaxableAmount);
                    //g.DrawString("5", ArialnormalItalic, BlackBrush, 0, CurrentY);

                    //g.DrawString(Clstax.FivePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 45, CurrentY);
                    //g.DrawString(Clstax.FivePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 105, CurrentY);
                    //g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 200, CurrentY);
                    //" + Clstax.FivePercTaxableAmount + ",  " + TNetAmount, ArialnormalItalic, BlackBrush, 500, CurrentY);

                    //CurrentY = CurrentY + 16;
                }
                if (Clstax.TwelPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwelPerceTaxAmount, Clstax.TwelPerceTaxableAmount);

                    g.DrawString("12.5", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwelPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwelPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.ForteenPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.ForteenPerceTaxAmount, Clstax.ForteenPerceTaxableAmount);

                    g.DrawString("14.5", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.ForteenPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.ForteenPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.TwenteenPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwenteenPerceTaxAmount, Clstax.TwenteenPerceTaxableAmount);

                    g.DrawString("20", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwenteenPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwenteenPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
            }


            //CurrentY = CurrentY + 10;
            //g.DrawString( Ttaxamount + ": (5%) ضريبة القيمة المضافة" , VerdanaBold, BlackBrush, 25, CurrentY);
            //xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
            //g.DrawString(CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(TDiscount)), VerdanaBold, BlackBrush, 105, CurrentY);



            //if (_Dbtask.znullDouble(Totherexpense) != 0)
            //{
            //    CurrentY = CurrentY + 16;
            //    g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
            //    xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
            //    g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            //}

            //CurrentY = CurrentY + 20;
            //g.DrawString("Bill Amt : ", VerdanaBoldHeading, BlackBrush, 0, CurrentY);
            //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), VerdanaBoldHeading, BlackBrush, 105, CurrentY);

            //CurrentY = CurrentY + 16;
          // g.DrawString("Cash Received", VerdanaBold, BlackBrush, 25, CurrentY);
           // xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
          //g.DrawString(CommonClass._Dbtask.SetintoDecimalpoint(Convert.ToDouble(TDiscount)), VerdanaBold, BlackBrush, 105, CurrentY);

            //CurrentY = CurrentY + 16;
            //g.DrawString(AmountinWords, CalibiRiItalic, BlackBrush, 25, CurrentY);
            //xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;

            //if (FormType != "     SALES ORDER")
            //{
                //string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                //if (samplid == "18" && PrintOldbalance == true)
                //{
                  

                //    //double oldbalnce=0;
                //    //oldbalnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" +Lid + "' and vno!='" + Billno + "'"));
                //    //g.DrawString("Old Balance", CalibiRiItalic2, BlackBrush, 10, CurrentY);
                //    ////        //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                //    //g.DrawString(oldbalnce.ToString(), CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);
                //    //CurrentY = CurrentY + 15;
                    
                //    //double currentblnce=0;
                //    //currentblnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + Lid + "'"));
                //    //g.DrawString("Current Balance", CalibiRiItalic2, BlackBrush, 10, CurrentY);
                //    ////        //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                //    //g.DrawString(currentblnce.ToString(), CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);
                //    //CurrentY = CurrentY + 15;
                
                //}
            //        //CurrentY = CurrentY + 16;
            //        //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, 500, CurrentY);
            //        //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            //        //double GrandTotal;

            //        ////if (FormType != "SALES RETURN")
            //        ////    GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
            //        ////else
            //        ////    GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

            //        ////g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, xTotalValue, CurrentY);
            //    }
            //}

            string tot = SUmNetAmt.ToString("0.00");
            string tottax = SumSrate.ToString("0.00");

            if (InvSubTitle5 == "       Report INVOICE" || FormType == "Salesdaybookcount")
            {
                if (InvSubTitle5 == "       Report INVOICE")
                {


                    FieldValue = "TOTAL";
                    g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, 90, CurrentY, Str);
                    //string tot= SUmNetAmt.ToString();
                    FieldValue = "(مجموع)";
                    g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, 160, CurrentY, Str);
                    //string tottax = SumSrate.ToString();
                    FieldValue = TotalTaxable.ToString("  ");
                    g.DrawString(FieldValue + tot, VerdanaBoldHeadingMain2, BlackBrush, xNetamt + 30, CurrentY, Str);
                    CurrentY = CurrentY + 18;


                    FieldValue = "VAT 15%";
                    g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, 95, CurrentY, Str);

                    FieldValue = "(ضريبة)";
                    g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, 150, CurrentY, Str);

                    FieldValue = Ttaxamount;
                    g.DrawString(FieldValue + tottax, VerdanaBoldHeadingMain2, BlackBrush, xNetamt, CurrentY, Str);

                }

                else
                {
                    if (FormType == "Salesdaybookcount")
                    {
                        g.DrawString("Total" + ":   " + tot, CalibiRiItalic2, BlackBrush, 0, CurrentY);
                       g.DrawString(totstaxname + ":   " + totstaxnameamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 14);
                        g.DrawString(TPTX + ":   " + TPTXamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 28);
                        g.DrawString(STPT + ":   " + STPTamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 42);
                        g.DrawString(TCS + ":   " + TCSamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 56);
                        g.DrawString(TCshS + ":   " + TCshSamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 70);
                        g.DrawString(TD + ":   " + TDamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 84);
                        g.DrawString(TSl + ":   " + TSlamt, CalibiRiItalic2, BlackBrush, 0, CurrentY + 98);

                        CurrentY = CurrentY + 15;




                    }
                }



            }

            else
            {

                if (FormType != "Salesdaybookcount")
                    {
                    //SumSrate
                        FieldValue = String.Format("{0:0.}", TotalQty);
                        g.DrawString(FieldValue, VerdanaArabic, BlackBrush, xQty, CurrentY, Str);
                        CurrentY = CurrentY + 10;

                        if (CommonClass._Menusettings.GetMnustatus("194") == "-1")
                        {

                            //if (CommonClass._Ledger.GetspecifField("taxregno", Lid) != "" && CommonClass._Ledger.GetspecifField("taxregno", Lid) != "0.00")
                            //{

                                FieldValue = "TOTAL";
                                g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, 70, CurrentY, Str);
                                //string tot= SUmNetAmt.ToString();
                                FieldValue = "(مجموع)";
                                g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, 140, CurrentY, Str);
                                //string tottax = SumSrate.ToString();
                                FieldValue = TotalTaxable.ToString("0.00");
                                g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);
                                CurrentY = CurrentY + 18;




                                FieldValue = "VAT 15%";
                                g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 75, CurrentY, Str);

                                FieldValue = "(ضريبة)";
                                g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 145, CurrentY, Str);

                                FieldValue = Ttaxamount;
                                g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);

                            //}
                            
                            
                            }

                    if (_Dbtask.znullDouble(TDiscount) > 0)
                    {
                        //wthout
                        CurrentY = CurrentY + 18;//28
                        FieldValue = "Before Discount";
                        g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 90, CurrentY, Str);

                        double bfrdis = 0;

                        bfrdis = Convert.ToDouble(TDiscount) + Convert.ToDouble(BillAmount);

                        FieldValue = "بدون خصم";
                        g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 150, CurrentY, Str);

                        FieldValue = bfrdis.ToString();
                        g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);


                        CurrentY = CurrentY + 18;//28
                        FieldValue = "Discount";
                        g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 90, CurrentY, Str);

                        FieldValue = "(خصم)";
                        g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 150, CurrentY, Str);

                        FieldValue = _Dbtask.znullDouble(TDiscount).ToString("0.00");
                        g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);

                       
                    
                    
                    
                    }
                    if (_Dbtask.znullDouble(Totherexpense) > 0)
                    {
                   

                        CurrentY = CurrentY + 18;//28
                        FieldValue = "Delivery charge";
                        g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 90, CurrentY, Str);

                        //FieldValue = "(خصم)";
                        //g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 150, CurrentY, Str);

                        FieldValue = _Dbtask.znullDouble(Totherexpense).ToString("0.00");
                        g.DrawString(FieldValue, CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);

                    }

                    if (NextGFuntion.SalesReturnAmount > 0)
                    {
                        CurrentY = CurrentY + 18;//28
                        FieldValue = "Sales return";
                        g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, 90, CurrentY, Str);



                        FieldValue = (NextGFuntion.SalesReturnAmount).ToString("0.00");
                        g.DrawString(FieldValue, VerdanaBoldHeadingMain2, BlackBrush, xNetamt, CurrentY, Str);

                        TotalNetamount = TotalNetamount - NextGFuntion.SalesReturnAmount;

                    }


                    CurrentY = CurrentY + 18;//28//25
                    FieldValue = "GRAND TOTAL ";
                    g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 90, CurrentY, Str);

                    //CurrentY = CurrentY + 18;//28
                    FieldValue = "(المجموع الإجمالي)";
                    g.DrawString(FieldValue, CalibiRiItalic3, BlackBrush, 180, CurrentY, Str);
                    g.DrawString(BillAmount, CalibiRiItalic4, BlackBrush, xNetamt, CurrentY, Str);

                    CurrentY = CurrentY + 22;

                    if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("112233")) == "1")
                    {
                        g.DrawString(OLDBBLNC +  "  Old Balance", VerdanaBold, BlackBrush, xNetamt, CurrentY, Str);

                        CurrentY = CurrentY + 20;
                        g.DrawString(NOWBBLNC + "  Current Balance", VerdanaBold, BlackBrush, xNetamt, CurrentY, Str);

                        CurrentY = CurrentY + 20;

                    }



                    g.DrawString("--------------------------------", CalibiRiItalic4, BlackBrush, 0, CurrentY);

                    CurrentY = CurrentY + 22;
                    if (_dbtask.znlldoubletoobject(cashrecvd)>0)
                    {
                        string recvdtype = "";
                        if (ModeofPayment == "CASH")
                        {
                            recvdtype = "Received by Cash :";
                        }
                        if (ModeofPayment == "Bank")
                        {
                         recvdtype = "Received to Bank =";
                        }
                        g.DrawString(recvdtype, Verdananormal, BlackBrush, 0, CurrentY);
                        g.DrawString(cashrecvd, Verdananormal, BlackBrush, 120, CurrentY);
                       
                        }

                    if(_dbtask.znlldoubletoobject( extrapaymnt)>0)
                    {
                        string accnt = "";
                        //CurrentY = CurrentY + 18;
                        if(extrapymntype=="2")
                        {
                            accnt = "Bank =";
                        }
                        if (extrapymntype == "0")
                        {
                            accnt = "Cash =";
                        }

                        g.DrawString(accnt, Verdananormal, BlackBrush, 220, CurrentY, Str);
                        g.DrawString(extrapaymnt, Verdananormal, BlackBrush,270, CurrentY, Str);

                        //CurrentY = CurrentY + 18;
                    }

                    if (_dbtask.znlldoubletoobject(deskbalnc) != _dbtask.znlldoubletoobject(cashrecvd))
                    {
                        CurrentY = CurrentY + 18;
                        g.DrawString("Balance  =", Verdananormal, BlackBrush, 0, CurrentY);
                        g.DrawString(deskbalnc, Verdananormal, BlackBrush, 70, CurrentY);
                        
                   }
                    CurrentY = CurrentY + 18;

                    string complaint=saleNarration.ToString();
                    if(saleNarration!=null&&saleNarration!="")
                    {
                        if (complaint.Length <= 25)
                        {
                            CurrentY = CurrentY + 22;
                            if (FormType == "Sales")
                            {
                                g.DrawString("Narration:" + saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);


                            }
                            else
                            {
                                g.DrawString("Complaints:" + saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);


                            }
                        }
                        else
                        {
                            CurrentY = CurrentY + 22;
                            if (FormType == "Sales")
                            {
                                saleNarration = complaint.Substring(0, 24).ToString();
                                g.DrawString("Complaints:" + saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);
                                CurrentY = CurrentY + 14;
                                saleNarration = complaint.Substring(24).ToString();
                                g.DrawString(saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);


                            }
                            else
                            {
                                saleNarration = complaint.Substring(0, 24).ToString();
                                g.DrawString("Complaints:" + saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);
                                CurrentY = CurrentY + 14;
                                saleNarration = complaint.Substring(24).ToString();
                                g.DrawString(saleNarration, VerdanaBold, BlackBrush, 2, CurrentY);
                               // g.DrawString("Complaints:" + saleNarration, BOLI, BlackBrush, 2, CurrentY);


                            }

                        }
                        CurrentY = CurrentY + 7;
                    }
                    if (warrantyStr != null && warrantyStr != "")
                    {
                        g.DrawString("Warranty: " + warrantyStr, BOLI, BlackBrush, 2, CurrentY + 20);
                    }
                    //المجموع الإجمالي)
                    //CurrentY = CurrentY + 15;//28
                    //FieldValue = "GRAND TOTAL";
                    //e.Graphics.DrawString(FieldValue, HeaderFontSecond, BlackBrush, 70, CurrentY, Str);

                    //CurrentY = CurrentY + 23;
                    //FieldValue = "(المجموع الإجمالي)";
                    //e.Graphics.DrawString(FieldValue, HeaderFontSecond, BlackBrush, 70, CurrentY, Str);

                }




            }
        }


        public void PrintTotal(Graphics g)
        {
          
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+5, rightMargin, CurrentY+5);
            // g.DrawString("Total  : ", VerdanaBold, BlackBrush, xProductName, CurrentY);

            //CurrentY = CurrentY + 8;
            //g.DrawString("Total", VerdanaBold, BlackBrush, 0, CurrentY);

            //g.DrawString(TotalQty, VerdanaBold, BlackBrush, 90, CurrentY);
            //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 190, CurrentY,Str);/*For Tax*/
            //g.DrawString(_Dbtask.SetintoDecimalpoint(SUmNetAmt), VerdanaBold, BlackBrush, 270, CurrentY,Str);

            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY + 15, rightMargin, CurrentY + 15);
            //CurrentY = CurrentY + 20;
            
            
            //if (InvSubTitle5 != "      ESTIMATE")
            //{
              
            
            /*For Qty*///350
            //    //g.DrawString(TotalItemDisc.ToString(), VerdanaBold, BlackBrush, 490, CurrentY);/*For Discount*/
            //    //g.DrawString(_Dbtask.SetintoDecimalpoint(SumSrate), VerdanaBold, BlackBrush, xRate, CurrentY);/*For Taxable*/
            //    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 650, CurrentY);/*For Tax*/
            //}
            //else
            //{
            //    g.DrawString(TotalQty, VerdanaBold, BlackBrush, 350  + 150, CurrentY);/*For Qty*/
            //}

            //g.DrawString(_Dbtask.SetintoDecimalpoint(SUmNetAmt), VerdanaBold, BlackBrush, xNetamt, CurrentY);

            ////g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, 750, CurrentY);/*For Amount*/
            //CurrentY = CurrentY + 20;
              
        }
        public void GETfooterLINES(Graphics g)
        {
            //footer picture
            InvImageheadrr = Application.StartupPath + @"\Images\" + "Footerpic.jpg";
            int ImageHeightT = 0;
            if (System.IO.File.Exists(InvImageheadrr))
            {
                CurrentY = CurrentY + 30;
                Bitmap oInvImageF = new Bitmap(InvImageheadrr);
                // Set Image Left to center Image:

                int xImage = CurrentX + (InvoiceWidth - oInvImageF.Width) / 2;
                ImageHeightT = oInvImageF.Height; // Get Image Height
                g.DrawImage(oInvImageF, 90, CurrentY + 10, 90, 95);

                CurrentY = CurrentY + 90;

            }

            //footer conditns
            string footrfileexist = "";

            string postn = ""; string mid= "";
            postn = _dbtask.ExecuteScalar("select status from tblmnusettings where menuname='footerStart' and menuid='102030' ").ToString();
            mid = _dbtask.ExecuteScalar("select status from tblmnusettings where menuname='footermidd' and menuid='8000' ").ToString();
            string line = ""; int x = 5; 
            
            //CurrentY = CurrentY + 20;
            if (postn == "1"&&  mid !="1")
            {
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer1'").ToString();
                if (line!="")
               {
                g.DrawString(line, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
                CurrentY = CurrentY + 20; line = "";
               }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer2'").ToString();
                if (line != "")
                {
                    g.DrawString(line, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer3'").ToString();
                if (line != "")
                {
                    g.DrawString(line, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer4'").ToString();
                if (line != "")
                {
                    g.DrawString(line, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer5'").ToString();
                if (line != "")
                {
                    g.DrawString(line, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
                }

            }
            else
            {
                if (postn != "1" && mid != "1")
                {
                    line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer1'").ToString();
                    if (line != "")
                    {
                        g.DrawString(line, VerdanaArabic, BlackBrush, 10, CurrentY);
                        CurrentY = CurrentY + 20; line = "";
                    }
                    line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer2'").ToString();
                    if (line != "")
                    {
                        g.DrawString(line, VerdanaArabic, BlackBrush, 10, CurrentY);
                        CurrentY = CurrentY + 20; line = "";
                    }
                    line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer3'").ToString();
                    if (line != "")
                    {
                        g.DrawString(line, VerdanaArabic, BlackBrush, 10, CurrentY);
                        CurrentY = CurrentY + 20; line = "";
                    }
                    line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer4'").ToString();
                    if (line != "")
                    {
                        g.DrawString(line, VerdanaArabic, BlackBrush, 10, CurrentY);
                        CurrentY = CurrentY + 20; line = "";
                    }
                    line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer5'").ToString();
                    if (line != "")
                    {
                        g.DrawString(line, VerdanaArabic, BlackBrush, 10, CurrentY);
                    }
                    
                    }
           
                }
            if(mid=="1"||mid=="1"&&postn=="1")
            {
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer1'").ToString();
                if (line != "")
                {
                    x = (300 - (int)g.MeasureString(line, VerdanaArabic).Width) / 2;
                    g.DrawString(line, VerdanaArabic, BlackBrush, x - 20, CurrentY);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer2'").ToString();
                if (line != "")
                {
                    x = (300 - (int)g.MeasureString(line, VerdanaArabic).Width) / 2;
                    g.DrawString(line, VerdanaArabic, BlackBrush, x - 20, CurrentY);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer3'").ToString();
                if (line != "")
                {
                    x = (300 - (int)g.MeasureString(line, VerdanaArabic).Width) / 2;
                    g.DrawString(line, VerdanaArabic, BlackBrush, x - 20, CurrentY);
                    CurrentY = CurrentY + 20; line = "";
                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer4'").ToString();
                if (line != "")
                {
                    x = (300 - (int)g.MeasureString(line, VerdanaArabic).Width) / 2;
                    g.DrawString(line, VerdanaArabic, BlackBrush, x - 20, CurrentY);
                    CurrentY = CurrentY + 20; line = "";

                }
                line = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname ='footer5'").ToString();
                if (line != "")
                {
                    x = (300 - (int)g.MeasureString(line, VerdanaArabic).Width) / 2;
                    g.DrawString(line, VerdanaArabic, BlackBrush, x - 20, CurrentY);
                    line = "";
                }
               
               }
            
            //footrfileexist = @"C:\FooterText\Footer.txt";


            //if (System.IO.File.Exists(footrfileexist))
            //{
            //    string[] nnme = File.ReadAllLines(@"C:\FooterText\Footer.txt");

            //    string secnnme = nnme[0].ToString();

            //    int h = 0;
            //    using (StreamReader RDR = File.OpenText(@"C:\FooterText\Footer.txt"))
            //    {
            //        while (RDR.ReadLine() != null)
            //        {
            //            h++;
            //        }
            //    }

            //    int k = 0;
            //    for (k = 0; k <= h - 1; k++)
            //    {
            //        if (nnme[k].ToString() != null && nnme[k].ToString() != "")
            //        {
            //            secnnme = nnme[k].ToString();

            //            CurrentY = CurrentY + 20;
            //            if (postn == "1")
            //            {
            //                g.DrawString(secnnme, VerdanaArabic, BlackBrush, 280, CurrentY, Str);
            //            }
            //            else
            //            {
            //                g.DrawString(secnnme, VerdanaArabic, BlackBrush, 10, CurrentY);
            //            }
            //        }
            //    }
            //}


        }
        private void SetInvoiceTotal(Graphics g)
            {
                float xx = 5;
            string footrvisible="";
            // Set Invoice Total:
            // Draw line:
            //CurrentY = CurrentY + 8;
            string TotalValue;
            PrintTotal(g);
            // g.DrawLine(new Pen(Brushes.Black,1), leftMargin, CurrentY, rightMargin, CurrentY);

            // Get Right Edge of Invoice:
            int xRightEdg = AmountPosition + (int)g.MeasureString("Amount", Arialbold).Width;

            //  g.DrawLine(new Pen(Brushes.Black, 1), xRightEdg + 7, 100, xRightEdg + 7, 1050);

            // Write Sub Total:
            int xSubTotal = AmountPosition - (int)g.MeasureString("Gross", Arialbold).Width;
            CurrentY = CurrentY + 8;

            VatPrinting(g);

            CurrentY = CurrentY + 20;//35
            AmountInWords _word = new AmountInWords();

            if (_Dbtask.znullDouble(Totherexpense) > 0)
            {
                TotalNetamount = TotalNetamount + _Dbtask.znullDouble(Totherexpense);
            }
            double BillAmountDb =_dbtask.znlldoubletoobject( BillAmount); //TotalNetamount;
            AmountinWords = "";
            AmountinWords = "Amount in Words:" + AmountinWords + " " + _word.ConvertAmount(BillAmountDb);

            if (AmountinWords.Length > 40)
                AmountinWords = AmountinWords.Substring(0, 40) + "\n" + AmountinWords.Substring(40, AmountinWords.Length - 40);


            FieldValue = AmountinWords;

            if (FormType != "Salesdaybookcount" && FormType != "Report" && FormType != "Frmpointofsale")
            {
               // CurrentY = CurrentY + 20;
            g.DrawString(FieldValue, CalibiRiItalic, BlackBrush, 2, CurrentY-15);
            }

            string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
            if (samplid == "18" && PrintOldbalance == true)
            {

               // CurrentY = CurrentY + 15;
                double oldbalnce = 0;
                oldbalnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + Lid + "' "));
                oldbalnce = oldbalnce - _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + Lid + "' and vno='" + Billno + "' and vtype='SI' "));
                oldbalnce = _Dbtask.znlldoubletoobject(_dbtask.SetintoDecimalpoint(oldbalnce));

                //g.DrawString("Old Balance", CalibiRiItalic2, BlackBrush, 10, CurrentY);
                ////        //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                //g.DrawString(oldbalnce.ToString("0.00"), CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);
                //CurrentY = CurrentY + 15;

                double currentblnce = 0;
                currentblnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + Lid + "'"));
                currentblnce = _Dbtask.znlldoubletoobject(_dbtask.SetintoDecimalpoint(currentblnce));
                //g.DrawString("Current Balance", CalibiRiItalic2, BlackBrush, 10, CurrentY);
                ////        //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                //g.DrawString(currentblnce.ToString("0.00"), CalibiRiItalic2, BlackBrush, xNetamt, CurrentY, Str);
                //CurrentY = CurrentY + 15;

            }
            if (PrintOldbalance == false)
            {
                //CurrentY = CurrentY + 35;
                FieldValue = CommonClass.CashDesk;
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, 2, CurrentY - 14);
            }
            //xx = (300 - (int)g.MeasureString("المبلغ شامل الضريبة", VerdanaArabic).Width) / 2;

            //g.DrawString("المبلغ شامل الضريبة", VerdanaArabic, BlackBrush, xx, CurrentY - 12);


            CurrentY = CurrentY + 22;

            //FieldValue = "Tax inclusive";
            //g.DrawString(FieldValue, VerdanaArabic, BlackBrush, 2, CurrentY +5, Str);


            //g.DrawString("Amount In Words :" + AmountinWords, AmountInwordsfont, BlackBrush, 50, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight * 1;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY - 10, rightMargin, CurrentY  -10);
            CurrentY = CurrentY + InvoiceFontHeight;
           // g.DrawString("jjj", VerdanaBold, BlackBrush, 2, CurrentY, Str);


            int wid;
            float x = 5;

            if (InvSubTitle5 != "       Report INVOICE" && FormType != "Salesdaybookcount")
            {
            string BCode = _BcodePrint.GetBarcode(Billno);

            // Create a CnetSDK barcode object.
            CSBarcode csharpbarcode = new CSBarcode();

            // Define data information that will be encoded into your barcode.
            csharpbarcode.BarcodeData = BCode;

            // Define a barcode type to draw and create.
            csharpbarcode.BarcodeType = CSBarcodeType.Code128;

            // Set image width of your Code 128 barcode.
            csharpbarcode.BarcodeWidth = 200;

            // Set image height of your Code 128 barcode.
            csharpbarcode.BarcodeHeight = 50;

            // Set foreground color of Code 128 barcode.
            csharpbarcode.BarColor = Color.Black;

            // Set background color of Code 128 barcode.
            csharpbarcode.BackgroundColor = Color.White;

            // Define an image file format to save your Code 128 barcode.
            //csharpbarcode.CSPictureFormat = ImageFormat.Jpeg;



            // Save Code 128 barcode image to a local JPEG image file.
            //byte[] TempBCode = csharpbarcode.CreateBarcode("CnetSDKCode128.jpeg");
            byte[] TempBCode = csharpbarcode.CreateBarcodeInBytes();



            Image BImage = CommonClass._Nextg.ByteToImage(TempBCode);

            


                /*****Qr Code***/


     string qrshow="";
     qrshow = _dbtask.ExecuteScalar("select status from tblmnusettings where menuid='9000' and menuname ='QRshow'").ToString();

     if (qrshow == "1")
           {
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = qrwidth,
                Height = qrhight,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var qr = new ZXing.BarcodeWriter();
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.QR_CODE;
            string StrQRCode;

            StrQRCode = _Gen.FureturnQrValue(_Companymaster.GetspecifField("Sellersname"), _Companymaster.GetspecifField("TRN"), Billno, BillDate, Ttaxamount, BillAmount);

            //StrQRCode = "Seller's Name=" + InvTitle+"\n";
            //StrQRCode = StrQRCode+"VAT NO=" + InvSubTitle3 + "\nBill No=" + Billno.ToString() + "\nDate=" + BillDate.ToString("dd/MM/yyyy") + "\nTime=" + BillDate.ToString("hh:mm:ss") + "\nVAT Amount=" + Ttaxamount + "\nTotal Amount=" + BillAmount;
            
            //StrQRCode = Generalfunction.GetKSAEncriptedText(InvTitle, InvSubTitle3, BillDate, Convert.ToDecimal(_dbtask.znullDouble(BillAmount)), Convert.ToDecimal(_dbtask.znullDouble(Ttaxamount)));
         // Generalfunction.GetKSAEncriptedText("","",BillDate,
         // StrQRCode = InvTitle.Replace(" ","") + " VAT NO:" + InvSubTitle3 + " DATE:" + BillDate.ToString("dd/MM/yyyy") +"  Bill no. :"+Billno.ToString()+
           //"  " + BillDate.ToString("hh:mm:ss tt") + " VAT TOTAL:" + Ttaxamount + " BILL TOTTAL:" + BillAmount;
            //StrQRCode = "تموينات السبهاني VAT#310306829500003   DATE:19-08-2021  TIME:06:50:27 PM  VAT TOTAL:3.90  BILL TOTTAL:29.90";
                var result = new Bitmap(qr.Write(StrQRCode));

            x = Convert.ToInt32((270 - result.Width) / 2);

            g.DrawImage(result, x, CurrentY - 22);
            CurrentY = CurrentY + (qrhight/2)+85;
}
    
    //Font PFont = new Font("Code 128", 35, FontStyle.Regular);
            //SolidBrush black = new SolidBrush(Color.Black);
            //g.DrawString(" " + BCode + " ", PFont, black, x, CurrentY);

                //footersetting
         //  ---------------------
            footrvisible = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='2024'").ToString();

            //if (footrvisible == "1")
            //{


            //    int ImageHeightT = 0;
            //    if (System.IO.File.Exists(InvImageheadrr))
            //    {
            //        Bitmap oInvImageF = new Bitmap(InvImageheadrr);
            //        // Set Image Left to center Image:

            //        int xImage = CurrentX + (InvoiceWidth - oInvImageF.Width) / 2;
            //        ImageHeightT = oInvImageF.Height; // Get Image Height
            //        g.DrawImage(oInvImageF, 90, CurrentY - 15, FX, FY);
            //    }

            //    //g.DrawImage(BImage, x, CurrentY +40);

            //    string web = "http://www.tgredh-sa.com";
            //    g.DrawString(web, VerdanaBoldHeadingMain2, BlackBrush, 50, CurrentY + 85);

            //    CurrentY = CurrentY + 10;

            //    //CurrentY = CurrentY + 139;

            //    //x = (300 - (int)g.MeasureString("شكرا لشرائك من تغريدة للاتصالات! نتمنى أنها كانت رحلة تسوق سعيدة.", VerdanaArabic).Width) / 2;

            //    //g.DrawString("شكرا لشرائك من تغريدة للاتصالات! نتمنى أنها كانت رحلة تسوق سعيدة.", VerdanaArabic, BlackBrush, x, CurrentY);

            //    //x = (300 - (int)g.MeasureString("**-----شكراً لزيارتكم-----**", VerdanaArabic).Width) / 2;

            //    //g.DrawString("**-----شكراً لزيارتكم-----**", VerdanaArabic, BlackBrush, x, CurrentY);

            //    if (FormType == "Services")
            //    {

            //        CurrentY = CurrentY + 100;
            //        g.DrawString("       عند فقدان الفاتورة لايتم تسليم الجهاز الا برقم الهوية *", VerdanaArabic, BlackBrush, leftMargin + 20, CurrentY);

            //        CurrentY = CurrentY + 20;
            //        g.DrawString(" مدة ضمان الصيانة ٤٨ ساعة فقط على نفس العطل *", VerdanaArabic, BlackBrush, leftMargin + 20, CurrentY);

            //        CurrentY = CurrentY + 20;
            //        g.DrawString(" المحل غير مسؤول عن الجهاز بعد مرور شهر من استلامه *", VerdanaArabic, BlackBrush, leftMargin + 20, CurrentY);
            //    }
            //    else
            //    {
            //        if (FormType == "Sales")
            //        {
            //            CurrentY = CurrentY + 100;
            //            g.DrawString("       احضار الفاتوره ضروري خلال الضمان . *", VerdanaArabic, BlackBrush, leftMargin + 20, CurrentY);

            //            CurrentY = CurrentY + 20;
            //            g.DrawString(" الضمان لايشمل سوء الإستخدام المواد الاستهلاكيه وكذا الملحقات *", VerdanaArabic, BlackBrush, leftMargin + 20, CurrentY);


            //        }
            //    }
            //}


               // g.DrawImage(BImage, x, CurrentY -20);

                //x = (300 - (int)g.MeasureString("شكرا لشرائك من تغريدة للاتصالات! نتمنى أنها كانت رحلة تسوق سعيدة.", VerdanaArabic).Width) / 2;

                //g.DrawString("شكرا لشرائك من تغريدة للاتصالات! نتمنى أنها كانت رحلة تسوق سعيدة.", VerdanaArabic, BlackBrush, x, CurrentY+90);

            //CurrentY = CurrentY + 60;
                //x = (300 - (int)g.MeasureString("**-----شكراً لزيارتكم-----**", VerdanaArabic).Width) / 2;

                //g.DrawString("**-----شكراً لزيارتكم-----**", VerdanaArabic, BlackBrush, x-20, CurrentY+90);


              
                GETfooterLINES(g);
                x = (300 - (int)g.MeasureString("**-----شكراً لزيارتكم-----**", VerdanaArabic).Width) / 2;
                CurrentY = CurrentY + 15;
                g.DrawString("**-----شكراً لزيارتكم-----**", VerdanaArabic, BlackBrush, x - 20, CurrentY);



            }

            
            if (FormType == "WHOLESALE" || FormType == "SALES RETURN" || FormType == "DELIVERY NOTE" || FormType == "Purchase Return")
            {
                //CurrentY = CurrentY + InvoiceFontHeight - 5;
                //g.DrawString("Decleration:", Declarationfont, BlackBrush, 50, CurrentY);

                //CurrentY = CurrentY + InvoiceFontHeight;

                //g.DrawString("               To be furnished by the seller)Certified that all the  particulars shown in the above Tax Invoice are true\n" +
                //             "               and correct in all respects and the goods on which the tax charged and collected nare in accordance with \n" +
                //             "               the provisions of the " + Strstate + " ACT 2003 and the rules made thereunder. It is also certified    that my/our\n" +
                //             "               Registration under " + Strstate + " Act 2003 is not subject to  any suspension/cancellation and it is valid as on  \n" +
                //             "               the date of this Bill.", Declarationfont, BlackBrush, 100, CurrentY);

                //CurrentY = CurrentY + InvoiceFontHeight * 5;
            }
            string Pfooter;
            Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");
            TotalValue = "Autherised Signatory";
            CurrentY = CurrentY - 14;
            //g.DrawString(TotalValue, Arialbold, BlackBrush, 50, CurrentY);
            //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
            //TotalValue = "  [With Status&Seal]";
            //g.DrawString(TotalValue, Arialnormal, BlackBrush, 50, CurrentY);

            if (Pfooter != "")
                g.DrawString(Pfooter, Arialbold, BlackBrush, 100, CurrentY);
        }

        private void DisplayDialog()
        {
            try
            {
                prnDialog.Document = this.prnDocument;
                DialogResult ButtonPressed = prnDialog.ShowDialog();
                // If user Click 'OK', Print Invoice
                if (ButtonPressed == DialogResult.OK)
                    prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void DisplayInvoice()
        {
            prnPreview.Document = this.prnDocument;

            try
            {
                prnPreview.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
       
        public void PrintInvoice(DataGridView Grd)
        {
            TempRowcounting = 0;
            TRowcounting = 0;

            Str = new StringFormat();
            Str.Alignment = StringAlignment.Far;

            MainGrid = Grd;
            ReadInvoice = false;
            PrintReport(); // Print Invoice
        }
        private void PrintReport()
        {
            try
            {
                this.prnDialog = new System.Windows.Forms.PrintDialog();
                this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
                this.prnDocument = new System.Drawing.Printing.PrintDocument();

                prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);
                ReadInvoice = false;
                prnDialog.Document = prnDocument;
                prnDialog.UseEXDialog = true;
                PrinterSettingsNew();
                prnDocument.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void ReadInvoiceData()
        {
            // cnn.Open();
            // rdrInvoice = cmd.ExecuteReader();
            // rdrInvoice.Read();
        }
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (FormType != "BARCODELASERPRINTING")
            {
                // leftMargin = (int)e.MarginBounds.Left;
                leftMargin = 0;
                //rightMargin = (int)e.MarginBounds.Right;
                rightMargin = 274;

                //  topMargin = (int)e.MarginBounds.Top;
                topMargin = 3;

                if (FormType.ToUpper() == "ESTIMATE")
                    topMargin = 25;
                // topMargin = 50;
                //bottomMargin = (int)e.MarginBounds.Bottom;
                bottomMargin = 1000;
                // InvoiceWidth = (int)e.MarginBounds.Width;
                InvoiceWidth = 350;
                // InvoiceHeight = (int)e.MarginBounds.Height;
                InvoiceHeight = 900;

                if (!ReadInvoice)
                    ReadInvoiceData();

                SetInvoiceHead(e.Graphics); // Draw Invoice Head
                SetOrderData(e.Graphics); // Draw Order Data
                SetInvoiceData(e.Graphics, e); // Draw Invoice Data

                ReadInvoice = true;
            }
            else
            {
                SetInvoiceData(e.Graphics, e); // Draw Invoice Data
            }
        }

    }
}
