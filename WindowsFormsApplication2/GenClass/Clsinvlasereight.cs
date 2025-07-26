using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using System.Text.RegularExpressions; 
namespace WindowsFormsApplication2
{
    class Clsinvlasereight
    {
        private QrCodeEncodingOptions options;
        public bool PrintBarcodeLaser;
        public string grandamtt = "";
        /*For Settings*/
        string faxvalue = "";
        string Cst = "";
        public bool SSlnotracking;
        public static string SelPrint;
        public bool SProject;
        /***************/
        public string StrNaration = "";
        public string Strstate = "KARNATAKA";
        public string PSelect;
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
        public int totpart = 0;
        public string TotalQty;
        public double TotalItemDisc;
        public double TotalTaxable;
        public double TotalTaxAmount;
        public double TotalNetamount;
        public double OldBalance;

        public string InvoiceName;
        public string TaxDeclaration;
        public string FormType;
        public int itemsrt = 0;
        public int xTotalValue;

        int TRowcounting = 0;
        int TempRowcounting = 0;
        /**********************************/

        int xQty;
        int xRate ;
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

        public static DataGridView MainGrid;
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        public System.Windows.Forms.PrintDialog prnDialog;
        public System.Windows.Forms.PrintPreviewDialog prnPreview;
        public System.Drawing.Printing.PrintDocument prnDocument;
        public System.ComponentModel.Container components = null;

        // for Invoice Head:
        private string InvTitle = "";
        private string InvTitleHome = "";
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

        //arab heading
        string arab = "تونة سادة حجر";
        string arab1 = "قلابة كبير";
        string arab2 = "عدس وسط";
        string arab3 = "";
        string arab4 = "";
        string arab5 = "";



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
        string invheadarab = "فاتورةضریبیةالمبسطة";


        // Font and Color:------------------
        // Title Font
        private Font Arialnormal = new Font("Arial", 10, FontStyle.Regular);
        private Font ArialnormalItalic = new Font("Arial", 10, FontStyle.Italic);
        private Font Arialbold = new Font("Arial", 10, FontStyle.Bold);

        private Font Arialboldformname = new Font("Copperplate Gothic Bold", 12, FontStyle.Bold);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        // private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //private Font InvoiceFont = new Font("Calibri", 12, FontStyle.Regular);
        private Font VerdanaBoldHeading = new Font("Verdana", 14, FontStyle.Bold);

        private Font VerdanaBoldarb = new Font("Verdana", 11, FontStyle.Bold);
        private Font VerdanaBoldHeadingsub = new Font("Verdana", 14, FontStyle.Bold);

        private Font VerdanaBoldSmall = new Font("Verdana", 8, FontStyle.Bold);
        private Font VerdanaBold = new Font("Verdana", 10, FontStyle.Bold);
        //Customer Detail
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
            newSettings.PrinterName = SelPrint;
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
            //Titles and Image of invoice:
            InvSubTitleInvoicename = InvoiceName;

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
                InvSubTitle5 = "" + FormType + " Invoice";
            }
            if (FormType != "ESTIMATE")
            {
                InvTitle = _Companymaster.GetspecifField("cname");
                InvSubTitleTaxDeclaration = TaxDeclarationfU();
                InvSubTitle1 = _Companymaster.GetspecifField("Address1");
                InvSubTitle11 = _Companymaster.GetspecifField("Address2");
                InvSubTitle2 = "Phone " + _Companymaster.GetspecifField("Telephone");//Kerala
                InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
                InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
                InvSubTitle6 = "Bill No:" + Billno + "                                                                                     Bill Date";
                InvSubTitle7 = "Name&Address :" + _Accountledger.GetspecifField("lname", Lid) + "," + _Accountledger.GetspecifField("address", Lid) + ";                                                                                     Bill Date";
                Cst = _Companymaster.GetspecifField("taxno2");
               faxvalue = _Companymaster.GetspecifField("fax"); 
                RecordsPerPage = 25;
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

            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage) && FormType != "ESTIMATE")
            {
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                
                
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 4;
                ImageHeight = oInvImage.Height/4; // Get Image Height
                g.DrawImage(oInvImage, 430, 20,70,70);
                    CurrentY = CurrentY + 30;
                
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

            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle11 = CurrentX + (InvoiceWidth - lenInvSubTitle11) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;
            int xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2;
            int xInvSubTitle5 = CurrentX + (InvoiceWidth - lenInvSubTitle5) / 2;
            int xInvSubTitle6 = CurrentX + (InvoiceWidth - lenInvSubTitle6) / 2;


            CurrentY = 80;
            //invoice headpart
            CurrentY = CurrentY + 20;
            g.DrawString(invheadarab, Arialnormal, BlackBrush, 400, CurrentY);
            CurrentY = CurrentY + 10;
            g.DrawString(InvSubTitle5, Arialnormal, BlackBrush,378, CurrentY);
            //qr
            setqrtwo(g);

            CurrentY = CurrentY + 30;
            Pen selpen = new Pen(Color.Black);

            g.DrawRectangle(selpen, 10, CurrentY, 450, 30);
            
            g.DrawLine(new Pen(Brushes.Black, 1), 120, CurrentY, 120, CurrentY+30);
            g.DrawLine(new Pen(Brushes.Black, 1), 210, CurrentY, 210, CurrentY + 30);
            g.DrawLine(new Pen(Brushes.Black, 1), 320, CurrentY, 320, CurrentY + 30);

            CurrentY = CurrentY + 8;
            g.DrawString("Invoice number", Verdananormal, BlackBrush, 12, CurrentY);
            g.DrawString(Billno, Verdananormal, BlackBrush, 200, CurrentY,Str);
            g.DrawString(Billno, Verdananormal, BlackBrush, 230, CurrentY);
            g.DrawString("arab number", Verdananormal, BlackBrush, 440, CurrentY,Str);



            CurrentY = CurrentY + 50;
            g.DrawRectangle(selpen, 10, CurrentY, 450, 50);
            g.DrawLine(new Pen(Brushes.Black, 1), 10, CurrentY+25, 460, CurrentY+25);
            g.DrawLine(new Pen(Brushes.Black, 1), 130, CurrentY, 130, CurrentY + 50);
            g.DrawLine(new Pen(Brushes.Black, 1), 230, CurrentY, 230, CurrentY + 50);
            g.DrawLine(new Pen(Brushes.Black, 1), 320, CurrentY, 320, CurrentY + 50);
            CurrentY = CurrentY + 8;
            g.DrawString("Invoice Issue date", Verdananormal, BlackBrush, 12, CurrentY);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), Verdananormal, BlackBrush, 229, CurrentY,Str);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), Verdananormal, BlackBrush, 235, CurrentY);
            g.DrawString("Invoice Issue date", Verdananormal, BlackBrush, 449, CurrentY,Str);
            CurrentY = CurrentY + 19;
            g.DrawString("Date of supply", Verdananormal, BlackBrush, 12, CurrentY);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), Verdananormal, BlackBrush, 229, CurrentY, Str);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), Verdananormal, BlackBrush, 235, CurrentY);
            g.DrawString("Date of supply", Verdananormal, BlackBrush, 449, CurrentY, Str);

            CurrentY = CurrentY + 50;
           
           

           
        }
        public void DrawHorizontalline(int Width)
        {
            //g.DrawLine(new Pen(Brushes.Black,1), leftMargin, 100, rightMargin, 100);
        }
        private void SetOrderData(Graphics g)
        {
            int sx = 120;int cx =500;
            string Sellrid = ""; string spcode = "";
            string Scountry = ""; string scity = ""; string sDist = "";
            Scountry = _Companymaster.GetspecifField("countryname");
            sDist = _Companymaster.GetspecifField("district");
            scity = _Companymaster.GetspecifField("city");
            Sellrid = _Companymaster.GetspecifField("sellersname");
            spcode = _Companymaster.GetspecifField("pcode");

            string buyer = ""; string Bstreet = ""; string Bbuilding = ""; string Bdist = "";
            string Bcountry = ""; string Bcity = ""; string Bpin = "";
            string Bvatno = ""; string buyrid = "";
            buyer = _Accountledger.GetspecifField("Lname", Lid).ToString();
            Bstreet = _Accountledger.GetspecifField("area", Lid).ToString();
            if (Bstreet!="")
            {
            Bstreet = CommonClass._Area.getareaname(Bstreet).ToString();
            }
            Bbuilding = _Accountledger.GetspecifField("address", Lid).ToString();
            Bcountry = _Accountledger.GetspecifField("Lcountryname", Lid).ToString();
            Bdist = _Accountledger.GetspecifField("LDistrict", Lid).ToString();
            Bcity = _Accountledger.GetspecifField("cityy", Lid).ToString();
            Bpin = _Accountledger.GetspecifField("postcode", Lid).ToString();
            Bvatno = _Accountledger.GetspecifField("taxregno", Lid).ToString();
            //buyrid = _Accountledger.GetspecifField("lAliasname", Lid).ToString();
            
            Pen selpen = new Pen(Color.Black);
           
            SolidBrush graybrush = new SolidBrush(Color.Gray);
            Rectangle rect = new Rectangle(10, CurrentY, 780, 20);
          
            g.FillRectangle(graybrush, rect);

            SolidBrush whitepen = new SolidBrush(Color.White);


           
            g.DrawLine(new Pen(Brushes.Black, 1), 385, CurrentY , 385, CurrentY + 20);
            int A = CurrentY;
            
            CurrentY= CurrentY + 5;
           g.DrawString("Seller:", Verdananormal, whitepen, 12, CurrentY);
           g.DrawString("Seller:", Verdananormal, whitepen, 384, CurrentY, Str);
           g.DrawString("Buyer:", Verdananormal, whitepen, 386, CurrentY);
           g.DrawString("Buyer:", Verdananormal, whitepen, 775, CurrentY, Str);

           CurrentY = CurrentY + 13;
            g.DrawRectangle(selpen, 10, CurrentY, 780, 180);


            CurrentY = CurrentY + 20;
            g.DrawString("Name:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Name:", Verdananormal, BlackBrush, 385, CurrentY,Str);
            g.DrawString(InvTitle, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("Name:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("Name:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(buyer, Verdananormal, BlackBrush, cx, CurrentY);

            
            
            
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY + 15, 460, CurrentY + 15); CurrentY = CurrentY + 15;
            g.DrawString("Building No.:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Building No.:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(InvSubTitle1, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("Building No.:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("Building No.:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bbuilding, Verdananormal, BlackBrush, cx, CurrentY);


            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("Street Name:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Street Name:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(InvSubTitle11, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("Street Name:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("Street Name:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bstreet, Verdananormal, BlackBrush, cx, CurrentY);


            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("District:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("District:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(sDist, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("District:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("District:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bdist, Verdananormal, BlackBrush, cx, CurrentY);



            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("City:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("City:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(scity, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("City:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("City:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bcity, Verdananormal, BlackBrush, cx, CurrentY);


            
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("Country:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Country:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(Scountry, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("Country:", Verdananormal, BlackBrush,390, CurrentY);
            g.DrawString("Country:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bcountry, Verdananormal, BlackBrush, cx, CurrentY);



            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("PostalCode:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("PostalCode:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(spcode, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("PostalCode:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("PostalCode:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bpin, Verdananormal, BlackBrush, cx, CurrentY);


            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("Additional No.", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Additional No.", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(_Companymaster.GetspecifField("telephone"), Verdananormal, BlackBrush, sx, CurrentY);
            
            
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("VAT number:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("VAT number:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(InvSubTitle3, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("VAT number:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("VAT number:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(Bvatno, Verdananormal, BlackBrush, cx, CurrentY);


            
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 15;
            g.DrawString("Other seller ID:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawString("Other seller ID:", Verdananormal, BlackBrush, 385, CurrentY, Str);
            g.DrawString(Sellrid, Verdananormal, BlackBrush, sx, CurrentY);

            g.DrawString("Other seller ID:", Verdananormal, BlackBrush, 390, CurrentY);
            g.DrawString("Other seller ID:", Verdananormal, BlackBrush, 780, CurrentY, Str);
            g.DrawString(buyrid, Verdananormal, BlackBrush, cx, CurrentY);


            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY); CurrentY = CurrentY + 21;
            //g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY);
            //g.DrawString("Name:", Verdananormal, BlackBrush, 11, CurrentY);
            g.DrawLine(new Pen(Brushes.LightGray, 1), 385, A, 385, CurrentY +3);
            g.DrawLine(new Pen(Brushes.LightGray, 1), sx - 5, A, sx - 5, CurrentY+3);
            g.DrawLine(new Pen(Brushes.LightGray, 1), sx +160, A, sx+160, CurrentY + 3);
            
            g.DrawLine(new Pen(Brushes.LightGray, 1), cx - 5, A, cx - 5, CurrentY+3);
            g.DrawLine(new Pen(Brushes.LightGray, 1), cx +160, A, cx+160, CurrentY + 3);



           CurrentY = CurrentY + 10;

           SolidBrush lgraybrush = new SolidBrush(Color.LightGray);
           Rectangle rect1 = new Rectangle(10, CurrentY, 780, 20);
           g.FillRectangle(lgraybrush, rect1);
           g.DrawString("Line Items:", Verdananormal, whitepen, 12, CurrentY);
           g.DrawString("Line Items:", Verdananormal, whitepen, 780, CurrentY, Str);
           CurrentY = CurrentY + 20;
           Rectangle rect2 = new Rectangle(10, CurrentY, 780, 40);
           g.FillRectangle(graybrush, rect2);
           g.DrawString("Nature of goods:", Verdananormal, whitepen, 11, CurrentY);
           g.DrawString("or service:", Verdananormal, whitepen, 11, CurrentY+9);
           g.DrawString("arab:", Verdananormal, whitepen, 11, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 260, CurrentY, 260, CurrentY + 40);

           g.DrawString("Unit price:", Verdananormal, whitepen, 262, CurrentY);
           g.DrawString("arab:", Verdananormal, whitepen, 262, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 330, CurrentY, 330, CurrentY + 40);

           g.DrawString("Quantity:", Verdananormal, whitepen, 331, CurrentY);
           g.DrawString("arab:", Verdananormal, whitepen, 331, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 400, CurrentY, 400, CurrentY + 40);

            
            g.DrawString("Taxable Amt:", Verdananormal, whitepen, 401, CurrentY);
           g.DrawString("arab:", Verdananormal, whitepen, 401, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 484, CurrentY, 484, CurrentY + 40);


           g.DrawString("Discount:", Verdananormal, whitepen, 485, CurrentY);
           g.DrawString("arab:", Verdananormal, whitepen,485, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 550, CurrentY, 550, CurrentY + 40);


           g.DrawString("TaxRate:", Verdananormal, whitepen, 551, CurrentY);
           g.DrawString("arab:", Verdananormal, whitepen, 551, CurrentY + 20);
           g.DrawLine(new Pen(Brushes.White, 1), 610, CurrentY, 610, CurrentY + 40);


            g.DrawString("TaxAmt:", Verdananormal, whitepen, 684, CurrentY,Str);
           g.DrawString("arab:", Verdananormal, whitepen, 684, CurrentY + 20,Str);
           g.DrawLine(new Pen(Brushes.White, 1), 685, CurrentY, 685, CurrentY + 40);




           g.DrawString("Subtotal:", Verdananormal, whitepen, 780, CurrentY,Str);
           g.DrawString("arab:", Verdananormal, whitepen, 780, CurrentY + 20,Str);

            itemsrt = CurrentY+40;


            //string FieldValue = "";
            //string CName = TempCust;
            //string Address = _Accountledger.GetspecifField("address", Lid);
            //string CTin = _Accountledger.GetspecifField("Taxregno", Lid);

            //int CCount = Address.Split('\n').Length - 1;

            //if (SProject == true)
            //{
            //    Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            //}

            
            ////g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);

            //int count = 0;
            //FieldValue = "";
            //int kk = 1;
            //foreach (char c in Address)
            //{
            //    FieldValue = FieldValue + c;
            //    if (c == '\n')
            //    {
            //       // g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
            //        kk++;
            //        FieldValue = "";
            //    }
            //    count++;
            //}
            ////g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
            //kk++;
            ////  g.DrawString(Address.Substring(M,5), VerdanaBold, BlackBrush, CurrentX, CurrentY);

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
            //    //FieldValue = "VAT";
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            //    //FieldValue = ":";
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
            //    //FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            //    //CurrentY = CurrentY + InvoiceFontHeight;
            //}

            ////FieldValue = "Mobile";
            ////g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            ////FieldValue = ":";
            ////g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);

            //if (SProject == true)
            //{
            //    FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
            //    Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            //}
            //else
            //{
            //    FieldValue = _Accountledger.GetspecifField("mobile", Lid);
            //}
            ////g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);


            //CurrentY = CurrentY + InvoiceFontHeight;
            // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
            //FieldValue = "Phone";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            //FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
            //FieldValue = _Accountledger.GetspecifField("phone", Lid);
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight;

            //if (FormType == "WHOLESALE")
            //{
            //    //FieldValue = "CST";
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            //    //FieldValue = ":";
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
            //    //FieldValue = _Accountledger.GetspecifField("cst", Lid);
            //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            //}
            //CurrentY = CurrentY + InvoiceFontHeight + 8;
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
            int itemend = 0;
            RecordsPerPage = 8;
            // Set Table Head:
            int xSlno = leftMargin + 10;
            //CurrentY = CurrentY ;
            CurrentY = itemsrt+10;
            //g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno, CurrentY);
            //g.DrawString("رقم", Verdananormal, BlackBrush, xSlno, CurrentY+13);
            int xProductName = new int();



            if (InvSubTitle5 != "      ESTIMATE")
            {
                xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                //g.DrawString("Product Name", Verdananormal, BlackBrush, 180, CurrentY);

                //g.DrawString("اسم العنصر", Verdananormal, BlackBrush, 180, CurrentY + 13);

                //g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 870);
                //xQty = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 250;
                //g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty =200;

                //g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 735);
                //g.DrawString("Length", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty =250;
                //g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 735);
                //g.DrawString("width", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = 300;
                //g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 735);
                //g.DrawString("Sq.Ft", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = 500;
               if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
                {
                   // g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 870);
                    //g.DrawString("Qty", Verdananormal, BlackBrush, 505, CurrentY);
                    //g.DrawString("الكمية", Verdananormal, BlackBrush, 505, CurrentY + 13);

                    //xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 20;//10
                    ////g.DrawLine(new Pen(Brushes.Black, 1), xRate, CurrentY, xRate, 870);
                    //g.DrawString("Unit Rate  ", Verdananormal, BlackBrush, xRate + 5, CurrentY);
                    //g.DrawString("إجمالي  ", Verdananormal, BlackBrush, xRate + 5, CurrentY+13);

                    //xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                    ////g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 870);
                    //g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount + 5, CurrentY);
                    //g.DrawString("خصم", Verdananormal, BlackBrush, xDiscount + 5, CurrentY + 13);

                    //xTaxable = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 30;//25
                    ////g.DrawLine(new Pen(Brushes.Black, 1), xTaxable, CurrentY, xTaxable, 770);
                    ////g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, 560, CurrentY);

                    //xTaxperc = xTaxable;
                    ////g.DrawLine(new Pen(Brushes.Black, 1), xTaxperc, CurrentY, xTaxperc, 870);
                    //g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxperc, CurrentY);
                    //g.DrawString("ضريبة%", Verdananormal, BlackBrush, xTaxperc, CurrentY + 13);

                    //xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
                    ////g.DrawLine(new Pen(Brushes.Black, 1), xTaxAmt, CurrentY, xTaxAmt, 870);
                    //g.DrawString("  Tax", Verdananormal, BlackBrush, xTaxAmt, CurrentY);
                    //g.DrawString("ضريبة", Verdananormal, BlackBrush, xTaxAmt+5, CurrentY + 13);
                }
                
           }
           else
           {
                //510
                //602
                //638
                //xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width;
                //g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);
                ////g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 890);
                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 107;
                //g.DrawString("Length", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 214;
                //g.DrawString("Width", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Width%", Verdananormal).Width + 321;
                //g.DrawString("Sq.Ft", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Product Name", Verdananormal).Width + 492;
                //g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);
                ////g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 770);

                //xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
                //g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);
                ////g.DrawLine(new Pen(Brushes.Black, 1), xRate, CurrentY, xRate, 770);

                //xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
               // g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
                //g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 770);
           }

           if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
           {
                //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 870);
                //g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 870);
                //g.DrawLine(new Pen(Brushes.Black, 1), 740, CurrentY, 740, 870);
                //xNetamt = xTaxAmt + (int)g.MeasureString("Tax", Verdananormal).Width + 10;//10
              //  g.DrawLine(new Pen(Brushes.Black, 1), xNetamt, CurrentY, xNetamt, 770);
                //g.DrawString("    Amount", Verdananormal, BlackBrush, xNetamt, CurrentY);
                //g.DrawString("كمية الشبكة", Verdananormal, BlackBrush, xNetamt+15, CurrentY + 13);
           }
           else
            {
            //    //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 870);
            //    //g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 870);
            //    //xNetamt = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 10;//10
            //    //g.DrawString("Qty", Verdananormal, BlackBrush, 750, CurrentY);
            }







            // Set Invoice Table:
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);



            //CurrentY = CurrentY + InvoiceFontHeight + 8;
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+10, rightMargin, CurrentY+10);

            //CurrentY = CurrentY + InvoiceFontHeight + 8;

            RowValidation(MainGrid);
            //CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote;

            for (int i = TRowcounting; i < MainGrid.Rows.Count - 1; i++)
            {

                if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                {
                    if (TempRowcounting < RecordsPerPage)
                    {

                        FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xSlno, CurrentY);


                        //FieldValue = MainGrid.Rows[i].Cells["clnitemcode"].Value.ToString();
                        //if (FieldValue.Length > 35)
                        //    FieldValue = FieldValue.Substring(0, 35);
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, Xcode, CurrentY);

                        FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();

                        // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        //if (FieldValue.Length > 45)
                        //    FieldValue = FieldValue.Substring(0, 45);
                        xProductName = 450 - (int)g.MeasureString(FieldValue, Verdananormal).Width ;
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 11, CurrentY);
                        ItemNote = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang");
                        string unittt = "";
                        if (_Dbtask.znllString(MainGrid.Rows[i].Cells["ClnUnit"].Value) != "")
                        {
                            unittt = _Dbtask.znllString(MainGrid.Rows[i].Cells["ClnUnit"].Value);   
                        }

                        if (ItemNote != "" || unittt!="")
                        {
                            CurrentY = CurrentY + 10;
                            g.DrawString(ItemNote, Verdananormal, BlackBrush, 260, CurrentY,Str );
                            g.DrawString("[ "+unittt+" ]", Verdananormal, BlackBrush, 11, CurrentY);
                            CurrentY = CurrentY + 1;
                        }


                        //string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();
                        //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "unit");
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 25, CurrentY, Str);


                        if (InvSubTitle5 != "      ESTIMATE")
                        {
                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnlength"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 250, CurrentY, Str);

                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnwidth"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 300, CurrentY, Str);

                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsqfl"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 350, CurrentY, Str);

                        }
                        else
                        {
                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnlength"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 284, CurrentY, Str);

                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnwidth"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 386, CurrentY, Str);

                        //    //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsqfl"].Value));
                        //    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 450, CurrentY, Str);
                        }
                        if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
                        {
                            

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 330, CurrentY, Str);


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 400, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 484, CurrentY, Str);

                             FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clndiscount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 550, CurrentY, Str);


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 610, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 685, CurrentY, Str);

                            

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 780, CurrentY, Str);
                        }
                        else
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            FieldValue =FieldValue+" ("+ CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "Rack")+")";

                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 800, CurrentY, Str);
                        }

                        CurrentY = CurrentY + 15;
                        
                        itemend = CurrentY;
                        g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY, 790, CurrentY);
                        CurrentY = CurrentY + 5;
                        

                        //if (CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang") != "")
                        //{
                        //    CurrentY = CurrentY + 38;
                        //}
                        //else
                        //{
                        //    CurrentY = CurrentY + 17;
                        //}

                      
                        // * 2+4

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;
                    }
                }

            }

           
            
            g.DrawLine(new Pen(Brushes.Gray, 1), 10, itemsrt, 10, itemend);
            g.DrawLine(new Pen(Brushes.Gray, 1), 260, itemsrt,260, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 330, itemsrt, 330, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 400, itemsrt, 400, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 484, itemsrt, 484, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 550, itemsrt, 550, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 610, itemsrt, 610, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 685, itemsrt, 685, itemend );
            g.DrawLine(new Pen(Brushes.Gray, 1), 790, itemsrt, 790, itemend + 3);



            if (CurrentRecord <= RecordsPerPage&&_Dbtask.znllString(MainGrid.Rows[TRowcounting+1].Tag) != "1")
            {
                if (FormType.ToUpper() != "ESTIMATE")
                {
                    CurrentRecord = CurrentRecord + 10;
                    e.HasMorePages = false;
                    for (int i = CurrentRecord; i < RecordsPerPage; i++)
                    {
                        g.DrawString("", Verdananormal, BlackBrush, AmountPosition, CurrentY);
                        CurrentY = CurrentY + InvoiceFontHeight;
                    }
                }
            }
            else
            {
                e.HasMorePages = true;
                TempRowcounting = 0;
                TRowcounting = TRowcounting + 1;
                //g.DrawLine(new Pen(Brushes.Black, 1), 15, 920, rightMargin, 920);

                g.DrawString("Continue.....................", VerdanaBoldHeading, BlackBrush, 300, 950);
            }
            if (e.HasMorePages == false)//StopReading &&
            {
                //rdrInvoice.Close();
                //cnn.Close();
                if (TempRowcounting > RecordsPerPage && ValidRecord > RecordsPerPage)
                {
                    e.HasMorePages = true;
                    TempRowcounting = 0;
                    TRowcounting = TRowcounting + 1;
                }
                else
                {
                    totpart = CurrentY;
                    SetInvoiceTotal(g);
                }
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

                    Clsinvlasereight Frms = new Clsinvlasereight();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " "+Frms._Gen.Getmajorsymbol()+ " and " +
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


 
        
        public void setqrtwo(Graphics g)
        {
            string Companyyy = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            //Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
            string vatnm = _Dbtask.ExecuteScalar("select VATno from TblCompanyMaster");
            //_Dbtask.ExecuteScalar("select taxno1 from TblCompanyMaster");
            string datte = BillDate.ToString("dd/MM/yyyy");
            string ttime = BillDate.ToString("hh:mm:ss");
            string vattot = _Dbtask.SetintoDecimalpoint(TotalTaxAmount).ToString();
            string StrQrData;
            string totamtt = grandamtt.ToString();

            StrQrData = _Gen.FureturnQrValue(_Companymaster.GetspecifField("Sellersname"), _Companymaster.GetspecifField("TRN"), Billno, BillDate, Ttaxamount, BillAmount);

           // StrQrData = "Seller's Name=" + _Companymaster.GetspecifField("Vatno") + ",Tax NO=" + InvSubTitle3 + ",Bill No=" + Billno.ToString() + ",Date=" + datte + ",Time=" + ttime + ",VAT Amount=" + Ttaxamount + ",Total Amount=" + _Dbtask.znullDouble(BillAmount).ToString("0.00");
        //    StrQrData = GetKSAEncriptedText(
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 150,
                Height = 160,

                //Width = 97,
                //Height = 97,

            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var qr = new ZXing.BarcodeWriter();
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.QR_CODE;
            Bitmap newbit = new Bitmap(qr.Write(StrQrData));

            InvoiceWidth = 350;
            // InvoiceHeight = (int)e.MarginBounds.Height;
            InvoiceHeight = 900;
            int ImageHeight = 0;
            //var myqrf = result;
            // //var codeq = new QRCoder.QRCode(myqrf);
            //Bitmap bitMap = qr.GetGraphic(5);

            int xImageq = CurrentX + (InvoiceWidth - newbit.Width) / 2;
            ImageHeight = newbit.Height;
            g.DrawImage(newbit, 670, CurrentY);

            //CurrentY = CurrentY + 100;

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

            SolidBrush whitepen2 = new SolidBrush(Color.White);
            CurrentY = totpart;
            int rsrt = 0; ;
            SolidBrush graybrush = new SolidBrush(Color.Gray);
            SolidBrush whitebrshh = new SolidBrush(Color.White);
            Rectangle rect1 = new Rectangle(10, CurrentY, 780, 20);
            rsrt = CurrentY;
            g.FillRectangle(graybrush, rect1);
            g.DrawString("Total Amounts:", Verdananormal, whitepen2, 12, CurrentY);
            g.DrawString("Total Amounts:", Verdananormal, whitepen2, 780, CurrentY, Str);
            CurrentY = CurrentY + 20;
            Pen selpen2 = new Pen(Color.Gray);

            g.DrawRectangle(selpen2, 10, CurrentY, 780, 130);


            //Rectangle rect2 = new Rectangle(10, CurrentY, 780, 70);
            //g.FillRectangle(whitebrshh, rect2);
            g.DrawLine(new Pen(Brushes.Gray, 1), 120, rsrt, 120, CurrentY+130);
            g.DrawLine(new Pen(Brushes.Gray, 1), 350, rsrt, 350, CurrentY + 130);
            g.DrawLine(new Pen(Brushes.Gray, 1), 590, rsrt, 590, CurrentY + 130);
            



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
                //setqrtwo(g);
                //g.DrawString("TOTAL", ArialnormalItalic, BlackBrush, 500, CurrentY);
                //g.DrawString("(مجموع)", ArialnormalItalic, BlackBrush, 600, CurrentY);
                //g.DrawString(TotalTaxable.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);
                //CurrentY = CurrentY + 16;

                //g.DrawString("VAT 15%", ArialnormalItalic, BlackBrush, 500, CurrentY);
                //g.DrawString("(ضريبة)", ArialnormalItalic, BlackBrush, 600, CurrentY);
                //g.DrawString(Ttaxamount, ArialnormalItalic, BlackBrush, 700, CurrentY);
                //CurrentY = CurrentY + 16;
                //double TNetAmount;
               
               
             
                
               
              
              
            }
            //CurrentY = CurrentY + 16;

            if (Convert.ToDouble(TDiscount) > 0)
            {
                //g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                //xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                //g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }
            if (_Dbtask.znullDouble(Totherexpense) != 0)
            {
                //CurrentY = CurrentY + 16;
                //g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                //xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                //g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }

            //CurrentY = CurrentY + 16;
            //g.DrawString("Bill Amount", VerdanaBoldHeading, BlackBrush, 500, CurrentY);
            //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), VerdanaBoldHeading, BlackBrush, 700, CurrentY);


            if (FormType != "     SALES ORDER")
            {
                string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                if (samplid == "18" && PrintOldbalance == true)
                {
                    //CurrentY = CurrentY + 16;
                    //g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    //g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, xTotalValue, CurrentY);

                    //CurrentY = CurrentY + 16;
                    //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    //xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                    //g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, xTotalValue, CurrentY);
                }
            }
            CurrentY = CurrentY + 8;
            g.DrawString("Total(Excluding VAT):", Verdananormal, BlackBrush, 130, CurrentY);
            g.DrawString("Total(Excluding VAT):", Verdananormal, BlackBrush, 590, CurrentY, Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 780, CurrentY, Str);
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY+20, 790, CurrentY+20);
            
            CurrentY = CurrentY + 23;
            g.DrawString("Discount:", Verdananormal, BlackBrush, 130, CurrentY);
            g.DrawString("Discount:", Verdananormal, BlackBrush, 590, CurrentY, Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(TDiscount)).ToString(), VerdanaBold, BlackBrush, 780, CurrentY, Str);
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY+20, 790, CurrentY+20);
            CurrentY = CurrentY + 23;
            g.DrawString("Total Taxable Amount(Exclude Vat):", Verdananormal, BlackBrush, 130, CurrentY);
            g.DrawString("Total Taxable Amount(Exclude Vat):", Verdananormal, BlackBrush, 590, CurrentY, Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 780, CurrentY, Str);
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY+20, 790, CurrentY+20);
            CurrentY = CurrentY + 23;
            g.DrawString("Total VAT:", Verdananormal, BlackBrush, 130, CurrentY);
            g.DrawString("Total VAT:", Verdananormal, BlackBrush, 590, CurrentY, Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 780, CurrentY, Str);
            g.DrawLine(new Pen(Brushes.LightGray, 1), 10, CurrentY+20, 790, CurrentY+20);
            CurrentY = CurrentY + 23;
            g.DrawString("Total Amount Due:", Verdananormal, BlackBrush, 130, CurrentY);
            g.DrawString("Total Amount Due:", Verdananormal, BlackBrush, 590, CurrentY, Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(BillAmount)).ToString(), VerdanaBold, BlackBrush, 780, CurrentY, Str);








            //CurrentY = CurrentY + 30;
        }


        public void PrintTotal(Graphics g)
        {
            //CurrentY = 870;
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            //g.DrawString("Total", Verdananormal, BlackBrush, 60, CurrentY);
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+20, rightMargin, CurrentY+20);





            if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
            {
                //g.DrawString(TotalQty, Verdananormal, BlackBrush, xQty, CurrentY);/*For Qty*///350
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), Verdananormal, BlackBrush, xRate, CurrentY);/*For Qty*///350
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalItemDisc), Verdananormal, BlackBrush, xDiscount, CurrentY);/*For Discount*/
                ////g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBoldSmall, BlackBrush, xTaxable, CurrentY);/*For Taxable*/
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), Verdananormal, BlackBrush, xTaxAmt, CurrentY);/*For Tax*/

                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), Verdananormal, BlackBrush, 740, CurrentY);/*For Amount*/
            }
            else
            {
                //g.DrawString(TotalQty, Verdananormal, BlackBrush, 740, CurrentY);/*For Amount*/
            }

            //CurrentY = CurrentY + 32;
        }
        private void SetInvoiceTotal(Graphics g)
        {
            PrintTotal(g);
            if (FormType != "DELIVERY NOTE")
            {
                // Set Invoice Total:
                // Draw line:
                //CurrentY = CurrentY + 8;
                string TotalValue;
                //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
             


                // Get Right Edge of Invoice:
                int xRightEdg = AmountPosition + (int)g.MeasureString("Amount", Arialbold).Width;

                //  g.DrawLine(new Pen(Brushes.Black, 1), xRightEdg + 7, 100, xRightEdg + 7, 1050);

                // Write Sub Total:
                int xSubTotal = AmountPosition - (int)g.MeasureString("Gross", Arialbold).Width;
                //CurrentY = CurrentY + 8;


                VatPrinting(g);



                AmountInWords _word = new AmountInWords();
                AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));

                //g.DrawString("Amount In Words :" + AmountinWords + " only", AmountInwordsfont, BlackBrush, 50, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight * 1;
                //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight;


                string Pfooter;
                Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");
                TotalValue = "Autherised Signatory";
                //CurrentY = CurrentY - 14;
                //g.DrawString(TotalValue, Arialbold, BlackBrush, 600, CurrentY);
                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "  [With Status&Seal]";
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 600, CurrentY);

                //if (Pfooter != "")
                    //g.DrawString(Pfooter, Arialbold, BlackBrush, 100, CurrentY);
            }
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
                leftMargin = 15;
                //rightMargin = (int)e.MarginBounds.Right;
                rightMargin = 800;

                //  topMargin = (int)e.MarginBounds.Top;
                topMargin = 50;

                if (FormType.ToUpper() == "ESTIMATE")
                    topMargin = 25;
                // topMargin = 50;
                //bottomMargin = (int)e.MarginBounds.Bottom;
                bottomMargin = 1000;
                // InvoiceWidth = (int)e.MarginBounds.Width;
                InvoiceWidth = 800;
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
