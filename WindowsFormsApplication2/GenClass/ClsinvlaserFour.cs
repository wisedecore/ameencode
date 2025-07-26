using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.Text.RegularExpressions; 
namespace WindowsFormsApplication2
{
    class ClsinvlaserFour

    {
        public bool PrintBarcodeLaser;
        /*For Settings*/
        string Cst = "";
        public bool SSlnotracking;
        public  string SelPrint;
        public bool SProject;
        /***************/
        private QrCodeEncodingOptions options;
        public string langarab = "";
        public string StrNaration = "";
        public string Strstate = "KARNATAKA";
        public string PSelect;
        public string PTYpe;
        public bool PrintOldbalance;
        public long ValidRecord = 0;
        int RecordsPerPage = 33; // twenty items in a page
        /*Load Data*/
        public string ModeofPayment;
        public string Lid;
        public string grandamtt = "";
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

        public string TotalQty;
        public double TotalItemDisc;
        public double TotalTaxable;
        public double TotalTaxAmount;
        public double TotalNetamount;
        public double OldBalance;

        public string InvoiceName;
        public string TaxDeclaration;
        public string FormType;
        public bool isarbicdotprint = false;
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
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";
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


        // Font and Color:------------------
        // Title Font
        private Font Arialnormal = new Font("Arial", 10, FontStyle.Regular);
        private Font ArialnormalItalic = new Font("Arial", 10, FontStyle.Italic);
        private Font Arialbold = new Font("Arial", 10, FontStyle.Bold);
        // Title Font height
        private Font Arialboldbottm = new Font("Century", 10, FontStyle.Bold);
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        // private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //private Font InvoiceFont = new Font("Calibri", 12, FontStyle.Regular);
        private Font VerdanaBoldHeading = new Font("Verdana", 14, FontStyle.Bold);
        private Font VerdanaBoldHeadingsub = new Font("Verdana", 14, FontStyle.Bold);

        private Font VerdanaBoldSmall = new Font("Verdana", 8, FontStyle.Bold);
        private Font VerdanaBold = new Font("Verdana", 10, FontStyle.Bold);

        private Font VerdanaBoldperc = new Font("Verdana", 8, FontStyle.Bold);
        //Customer Detail
        private Font Verdananormal = new Font("Verdana", 8, FontStyle.Regular);

        private Font Verdanaitalic = new Font("Verdana", 8, FontStyle.Regular);
        //Declaration Font
        private Font Declarationfont = new Font("Calibri", 8, FontStyle.Regular);
        private Font AmountInwordsfont2 = new Font("Century", 10, FontStyle.Italic);
        private Font AmountInwordsfont3 = new Font("Arial", 8, FontStyle.Bold);
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
            langarab = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='language'").ToString();
            //if (langarab=="Arabic")
            //{
                isarbicdotprint = true;
                
            //}
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
                InvSubTitle5 = "       " + FormType + " INVOICE";
            }
            if (FormType != "ESTIMATE")
            {
                //InvTitle = _Companymaster.GetspecifField("cname");
                //InvSubTitleTaxDeclaration = TaxDeclarationfU();
                //InvSubTitle1 = _Companymaster.GetspecifField("Address1");
                //InvSubTitle11 = _Companymaster.GetspecifField("Address2");
                //InvSubTitle2 = "Phone " + _Companymaster.GetspecifField("Telephone");//Kerala
                //InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
                //InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
                //InvSubTitle6 = "Bill No:" + Billno + "                                                                                     Bill Date";
                //InvSubTitle7 = "Name&Address :" + _Accountledger.GetspecifField("lname", Lid) + "," + _Accountledger.GetspecifField("address", Lid) + ";                                                                                     Bill Date";
                Cst = _Companymaster.GetspecifField("taxno2");
                RecordsPerPage = 13;
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
                int xImage = InvoiceWidth - oInvImage.Width;
                ImageHeight = oInvImage.Height; // Get Image Height
                ImageHeight = 0;
                g.DrawImage(oInvImage, 10, 5, 780, 1050);
               //g.DrawImage(oInvImage, 25, 5);
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
     
            // Draw Invoice Head:

            string Strheading;
            Strheading = "بِسْمِ اللهِ الرَّحْمٰنِ الرَّحِيْمِ";
            int xInvTitlex = CurrentX + (InvoiceWidth - (int)g.MeasureString(Strheading, VerdanaBoldHeading).Width) / 2;

            //if (InvSubTitle3 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            //{
            //    g.DrawString("VAT:", Arialnormal, BlackBrush, 50, CurrentY / 2);/*For Tin*/
            //    g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 100, CurrentY / 2);/*CST Reg No*/
            //}
            //else
            //{
            //    RecordsPerPage = 31;
            //}
            //g.DrawString(Strheading, VerdanaBoldHeading, BlackBrush, xInvTitlex, 20);/*For Tin*/

            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            if (Cst != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                //g.DrawString("CST:", Arialnormal, BlackBrush, 600, CurrentY / 2);/*For CST Reg No*/

                //g.DrawString(Cst, Arialbold, BlackBrush, 650, CurrentY / 2);/*CST Reg No*/
            }
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/

            if (InvTitle != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                CurrentY = CurrentY + ImageHeight;
               // g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, xInvTitle, CurrentY);
                CurrentY = CurrentY + 5;

                InvTitle = _Companymaster.GetspecifField("Nameinhome");

                if (InvTitle != "")
                {
                    CurrentY = CurrentY + 20;
                    xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
                   // g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, xInvTitle-80, CurrentY);
                    CurrentY = CurrentY + 5;
                }
            }
            if (InvSubTitle1 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address*/
            {
                CurrentY = CurrentY + InvTitleHeight;
               // g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, xInvSubTitle1 - 80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            if (InvSubTitle11 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address2*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle11, InvSubTitleFont, BlackBrush, xInvSubTitle11-80, CurrentY);
                CurrentY = CurrentY + 5;
            }
            /*City*/
            InvSubTitle2 = _Companymaster.GetspecifField("City");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*State*/
            InvSubTitle2 = _Companymaster.GetspecifField("State");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Postal code*/
            InvSubTitle2 = _Companymaster.GetspecifField("Pcode");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Telephone*/
            InvSubTitle2 = _Companymaster.GetspecifField("Telephone");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Mobile*/
            InvSubTitle2 = _Companymaster.GetspecifField("Mobile");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }
            /*Fax*/
            InvSubTitle2 = _Companymaster.GetspecifField("Fax");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }
            /*Email*/
            InvSubTitle2 = _Companymaster.GetspecifField("Email");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Website*/
            InvSubTitle2 = _Companymaster.GetspecifField("website");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Account no*/
            InvSubTitle2 = _Companymaster.GetspecifField("Accountno");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*Account no2*/
            InvSubTitle2 = _Companymaster.GetspecifField("Taxno2");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                CurrentY = CurrentY + 5;
            }

            /*VAT*/
            InvSubTitle2 = _Companymaster.GetspecifField("Vatno");
            xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2-80, CurrentY);
                //CurrentY = CurrentY + 5;
            }
            //if (InvSubTitle3 != "")/*For Tin*/
            //{
            //    CurrentY = CurrentY + InvSubTitleHeight;
            //    g.DrawString(InvSubTitle3, InvSubTitleFont, BlackBrush, xInvSubTitle3, CurrentY);
            //}

            if (InvSubTitle5 != "")/*For InVoiceName*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 300, CurrentY);
                CurrentY = CurrentY + 5;

                if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                {
                    CurrentY = CurrentY + InvSubTitleHeight;
                   // g.DrawString("    " + ModeofPayment, Arialnormal, BlackBrush, 350, CurrentY);
                    CurrentY = CurrentY + 5;
                }

                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("(To be Prepared in Duplicate)", Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle6 != "" && FormType == "Multi")
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle6, Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle7 != "" && FormType == "Multi")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle7, Verdananormal, BlackBrush, 300, CurrentY);
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
            CurrentY = CurrentY + 8;
            if(isarbicdotprint==true)
            {
            //g.DrawLine(new Pen(Brushes.Black, 1), 650, CurrentY, 650 + 150, CurrentY);
            //g.DrawLine(new Pen(Brushes.Black, 1), 650, CurrentY, 650, CurrentY + 50);
            //g.DrawLine(new Pen(Brushes.Black, 1), 650 + 150, CurrentY, 650 + 150, CurrentY + 50);
            //g.DrawLine(new Pen(Brushes.Black, 1), 650, CurrentY + 50, 650 + 150, CurrentY + 50);

            FieldValue = "رقم الفاتورة والتاريخ";
            //DrawString(FieldValue, Arialnormal, BlackBrush, 650 + 40, CurrentY,Str);
            CurrentY = CurrentY + InvoiceFontHeight * 2;
            //g.DrawLine(new Pen(Brushes.Black, 1), 650, CurrentY - 4, 650 + 150, CurrentY - 4);
           // g.DrawString(" /  " + Billno , VerdanaBold, BlackBrush, 750, CurrentY);
            //g.DrawString(BillDate.ToString("dd/MM/yyyy"), Arialnormal, BlackBrush, 650 + 10, CurrentY);
            }
            else
            {
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX + 150, CurrentY);
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX, CurrentY + 50);
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX + 150, CurrentY, CurrentX + 150, CurrentY + 50);
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY + 50, CurrentX + 150, CurrentY + 50);

            FieldValue = "Invoice No & Date: ";
            //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 10, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight * 2;
            //g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY - 4, CurrentX + 150, CurrentY - 4);
            //g.DrawString(Billno+"   "+"/", VerdanaBold, BlackBrush, CurrentX, CurrentY);
            //g.DrawString(BillDate.ToString("dd/MM/yyyy"), Arialnormal, BlackBrush, CurrentX + 50, CurrentY);
            }
            //FieldValue = "Date: ";
            //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 600, CurrentY);
            //g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, CurrentX + 640, CurrentY);

            CurrentY = CurrentY + InvoiceFontHeight * 2;

            string CName = TempCust;

            string Address = _Accountledger.GetspecifField("address", Lid);

            string CTin = _Accountledger.GetspecifField("Taxregno", Lid);
            string cusmob = _Accountledger.GetspecifField("mobile", Lid);
            int CCount = Address.Split('\n').Length - 1;

            if (SProject == true)
            {
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }


            FieldValue = "Name of Purchaser:" + CName;
            if (isarbicdotprint == true)
            {
                FieldValue = ": الزبون";
                //g.DrawString(CTin, VerdanaBold, BlackBrush, 230, CurrentY+54, Str);
                //g.DrawString(InvSubTitle2, VerdanaBold, BlackBrush, 700, CurrentY+120, Str);
                //g.DrawString(CName, VerdanaBold, BlackBrush, 500, CurrentY+4 , Str);
                g.DrawString("Mob: "+cusmob, VerdanaBold, BlackBrush, 100, 220);
                g.DrawString(BillDate.ToString("dd/MM/yyyy")+" "+  BillDate.ToString("hh:mm:ss"), VerdanaBold, BlackBrush, 120, 160);
                g.DrawString(BillDate.ToString("dd/MM/yyyy") + " " + BillDate.ToString("hh:mm:ss"), VerdanaBold, BlackBrush, 670, 160, Str);
                if (FormType == "     SALES RETURN")
                {
                    g.DrawString("مرتجع فاتورة", VerdanaBold, BlackBrush, 420, 190);
                }
                else
                {
                    g.DrawString(ModeofPayment+":Mode of payment", VerdanaBold, BlackBrush, 750, 190,Str);
                }
              
                g.DrawString("Invoice:"+Billno, VerdanaBold, BlackBrush, 100, 190);



                 g.DrawString(CName +":Customer", VerdanaBold, BlackBrush, 750,220, Str);
                g.DrawString("VAT :"+CTin, Verdananormal, BlackBrush, 100, 235);
                //FieldValue = _Companymaster.GetspecifField("VATno");
               // g.DrawString(FieldValue, VerdanaBold, BlackBrush, 630, 260, Str);

            }
            else
            {
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);
            }
            CurrentY = 235;
            int count = 0;
            FieldValue = "";
            int kk = 1;
            foreach (char c in Address)
            {
                FieldValue = FieldValue + c;
                if (c == '\n')
                {
                    if (isarbicdotprint == true)
                    {
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 750, CurrentY + 15 * kk,Str);
                        kk++;
                        FieldValue = "";
                    }
                    else
                    {

                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 750, CurrentY + 15 * kk);
                        kk++;
                        FieldValue = "";
                    }
                }
                count++;
            }


            if (isarbicdotprint == true)
            {
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, 760, CurrentY + 15 * kk,Str);
                kk++;
            }
            else
            {
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
                kk++;
            }
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

            if (FormType == "WHOLESALE" || FormType == "Purchase Return" || SProject == false)
            {
                if (isarbicdotprint == true)
                {
                    FieldValue = ":  ظريبه الشراء";
                    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 200, CurrentY,Str);
                    //FieldValue = ":";
                    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 200, CurrentY, Str);
                    //FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                    //g.DrawString(FieldValue, Verdananormal, BlackBrush, 130, CurrentY, Str);
                    CurrentY = CurrentY + InvoiceFontHeight;
                }
                else
                {
                    FieldValue = "VAT";
                    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                    FieldValue = ":";
                    //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                    FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                   // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                    CurrentY = CurrentY + InvoiceFontHeight;
                }
            }


            if (isarbicdotprint == true)
            {
                FieldValue = " التليفون المحمول";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 120, CurrentY);
                
            }
            else
            {
                FieldValue = "Mobile";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
            }


            if (SProject == true)
            {
                FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }
            else
            {
                FieldValue = _Accountledger.GetspecifField("mobile", Lid);
            }

            if (isarbicdotprint == true)
            {
                //g.DrawString(FieldValue+" :", Verdananormal, BlackBrush, 130, CurrentY, Str);

                CurrentY = CurrentY + InvoiceFontHeight;
                // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
                FieldValue = "  هاتف";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 200, CurrentY,Str);
               
                FieldValue = _Accountledger.GetspecifField("phone", Lid);
                //g.DrawString(FieldValue+" :", Verdananormal, BlackBrush, 130, CurrentY,Str);
                CurrentY = CurrentY + InvoiceFontHeight;
            }
            else
            {
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);


                CurrentY = CurrentY + InvoiceFontHeight;
                // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
                FieldValue = "Phone";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                FieldValue = _Accountledger.GetspecifField("phone", Lid);
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;
            }
            if (FormType == "WHOLESALE")
            {
                FieldValue = "CST";
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                FieldValue = _Accountledger.GetspecifField("cst", Lid);
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            }
            CurrentY = CurrentY + InvoiceFontHeight + 8;
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







            // Set Table Head:
            int xSlno = leftMargin + 10;
            //CurrentY = CurrentY ;
            CurrentY = CurrentY + 30;
            if (isarbicdotprint == true)
            {
               
            }
            else
            {
                //g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno, CurrentY);
                //g.DrawString("رقم", Verdananormal, BlackBrush, xSlno, CurrentY + 13);
            }
            int xProductName = new int();

           

            if (InvSubTitle5 != "      ESTIMATE")
            {
                if (isarbicdotprint == true)
                {
                    //g.DrawString("Net.Amt", Verdananormal, BlackBrush, xSlno, CurrentY);
                   // g.DrawString("كمية الشبكة", Verdananormal, BlackBrush, xSlno, CurrentY + 13);

                    xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                   // g.DrawString("Tax", Verdananormal, BlackBrush,110, CurrentY);

                   // g.DrawString("ضريبة", Verdananormal, BlackBrush, 110, CurrentY + 13);

                    //g.DrawLine(new Pen(Brushes.Black, 1), xProductName - 400, CurrentY, xProductName-400, 890);
                    xQty = 500;
                }
                else
                {
                    xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                   // g.DrawString("Product Name", Verdananormal, BlackBrush, 180, CurrentY);

                   // g.DrawString("اسم العنصر", Verdananormal, BlackBrush, 180, CurrentY + 13);

                    //g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 890);
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

                    xQty = 500;
                }
                
                if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
                {
                    if (isarbicdotprint == true)
                    {
                        //g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 890);
                       // g.DrawString("gross", Verdananormal, BlackBrush, 190, CurrentY);
                       // g.DrawString("إجمالي", Verdananormal, BlackBrush, 190, CurrentY + 13);

                        xRate = xQty + (int)g.MeasureString("gross", Verdananormal).Width + 20;//10
                        //g.DrawLine(new Pen(Brushes.Black, 1), 430, CurrentY, 430, 890);
                        //g.DrawLine(new Pen(Brushes.Black, 1), 330, CurrentY, 330, 890);
                        //g.DrawLine(new Pen(Brushes.Black, 1), 260, CurrentY, 260, 890);
                        SolidBrush fillgblk = new SolidBrush(Color.Gainsboro);
                        Pen selpen2 = new Pen(Color.Gray);

                        Rectangle invrect = new Rectangle(60, CurrentY-8, 690, 25);
                        g.DrawRectangle(selpen2, invrect);
                        g.FillRectangle(fillgblk, invrect);
                        g.DrawLine(new Pen(Brushes.Gray, 1), 60, CurrentY - 8, 60, 920);
                        g.DrawString("Slno", Verdananormal, BlackBrush,55, CurrentY,Str);

                       g.DrawString("Rate", Verdananormal, BlackBrush, 550, CurrentY);
                       g.DrawLine(new Pen(Brushes.Gray, 1), 535, CurrentY-8, 535, 920);
                        
                        // g.DrawString("معدل", Verdananormal, BlackBrush, 280, CurrentY + 13);

                        xDiscount = xRate + (int)g.MeasureString("Rate   ", Verdananormal).Width + 30;//25
                        //g.DrawLine(new Pen(Brushes.Black, 1), 180, CurrentY, 180, 890);
                        g.DrawString("Unit", Verdananormal, BlackBrush,430, CurrentY);
                        g.DrawLine(new Pen(Brushes.Gray, 1), 430, CurrentY-8, 430, 920);
                        
                        //g.DrawString("وحدة", Verdananormal, BlackBrush, 390, CurrentY + 13);

                        xTaxable = xDiscount + (int)g.MeasureString("Unit", Verdananormal).Width + 30;//25
                        //g.DrawLine(new Pen(Brushes.Black, 1), xTaxable, CurrentY, xTaxable, 770);
                        //g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, 560, CurrentY);

                        xTaxperc = xTaxable;
                        //g.DrawLine(new Pen(Brushes.Black, 1), 100, CurrentY, 100, 890);
                        g.DrawString("Qty", Verdananormal, BlackBrush, 480, CurrentY);
                        g.DrawLine(new Pen(Brushes.Gray, 1), 480, CurrentY-8, 480, 920);
                        //g.DrawString("كمية", Verdananormal, BlackBrush, 450, CurrentY + 13);

                        xTaxAmt = xTaxperc + (int)g.MeasureString("Qty", Verdananormal).Width;
                        //g.DrawLine(new Pen(Brushes.Black, 1), xTaxAmt+60, CurrentY, xTaxAmt+60, 890);
                        //g.DrawString("Code", Verdananormal, BlackBrush, 450, CurrentY);

                        //g.DrawString("Code", Verdananormal, BlackBrush, 450, CurrentY + 13);
                    }
                    else
                    {
                        //g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 890);
                       // g.DrawString("Qty", Verdananormal, BlackBrush, 505, CurrentY);
                        //g.DrawString("الكمية", Verdananormal, BlackBrush, 505, CurrentY + 13);

                       // xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 20;//10
                       // g.DrawLine(new Pen(Brushes.Black, 1), xRate, CurrentY, xRate, 890);
                        //g.DrawString("Gross  ", Verdananormal, BlackBrush, xRate + 5, CurrentY);
                        //g.DrawString("إجمالي  ", Verdananormal, BlackBrush, xRate + 5, CurrentY + 13);

                        xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                       // g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 890);
                      //g.DrawString("Item", Verdananormal, BlackBrush, 70, CurrentY);
                       // g.DrawString("خصم", Verdananormal, BlackBrush, xDiscount + 5, CurrentY + 13);

                        xTaxable = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 30;//25
                        //g.DrawLine(new Pen(Brushes.Black, 1), xTaxable, CurrentY, xTaxable, 770);
                        //g.DrawString("Amount", Verdananormal, BlackBrush,700, CurrentY,Str);

                        xTaxperc = xTaxable;
                        //g.DrawLine(new Pen(Brushes.Black, 1), xTaxperc, CurrentY, xTaxperc, 890);
                       //g.DrawString("Tax", Verdananormal, BlackBrush, 620, CurrentY);
                        //g.DrawString("ضريبة%", Verdananormal, BlackBrush, xTaxperc, CurrentY + 13);

                        xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
                        //g.DrawLine(new Pen(Brushes.Black, 1), xTaxAmt, CurrentY, xTaxAmt, 890);
                        //g.DrawString("  Tax", Verdananormal, BlackBrush, xTaxAmt, CurrentY);

                       // g.DrawString("ضريبة", Verdananormal, BlackBrush, xTaxAmt + 5, CurrentY + 13);

                    }
                    }

                
            }
            else
            {
                //510
                //602
                //638
                xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width;
               // g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);
               // g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 890);
                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 107;
                //g.DrawString("Length", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 214;
                //g.DrawString("Width", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Width%", Verdananormal).Width + 321;
                //g.DrawString("Sq.Ft", Verdananormal, BlackBrush, xQty, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Product Name", Verdananormal).Width + 492;
                //g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);
               // g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 770);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
                //g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);
                
                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
               // g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
                //g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 770);
            }

            if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
            {

                if (isarbicdotprint == true)
                {
                   // g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 890);
                   // g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 890);
                   // g.DrawLine(new Pen(Brushes.Black, 1), 740, CurrentY, 740, 890);
                    xNetamt = xTaxAmt + (int)g.MeasureString("Code", Verdananormal).Width + 10;//10
                    //  g.DrawLine(new Pen(Brushes.Black, 1), xNetamt, CurrentY, xNetamt, 770);
                   // g.DrawString("Item", Verdananormal, BlackBrush, xNetamt-100, CurrentY);
                    //g.DrawString("المنتج", Verdananormal, BlackBrush, xNetamt - 100, CurrentY + 13);

                    xDiscount = xRate + (int)g.MeasureString("Item  ", Verdananormal).Width + 25;
                    //g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 770);
                    g.DrawString("Amount", Verdananormal, BlackBrush, 750, CurrentY, Str);
                    g.DrawLine(new Pen(Brushes.Gray, 1), 660, CurrentY - 8, 660, 920);
                    g.DrawString("Tax15%", Verdananormal, BlackBrush, 600, CurrentY);
                    g.DrawLine(new Pen(Brushes.Gray, 1), 600, CurrentY-8, 600, 920);
                    g.DrawString("Item", Verdananormal, BlackBrush, 70, CurrentY);

                }
                else
                {

                   // g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 890);
                   // g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 890);
                   // g.DrawLine(new Pen(Brushes.Black, 1), 740, CurrentY, 740, 890);
                    xNetamt = xTaxAmt + (int)g.MeasureString("Tax", Verdananormal).Width + 10;//10
                    //  g.DrawLine(new Pen(Brushes.Black, 1), xNetamt, CurrentY, xNetamt, 770);
                    //g.DrawString("    Amount", Verdananormal, BlackBrush, xNetamt, CurrentY);
                    //g.DrawString("كمية الشبكة", Verdananormal, BlackBrush, xNetamt + 15, CurrentY + 13);

                }
                }

            else
            {
               // g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 890);
               // g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 890);
                xNetamt = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 10;//10
               // g.DrawString("Qty", Verdananormal, BlackBrush, 750, CurrentY);
            }







            // Set Invoice Table:
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);



            CurrentY = CurrentY + InvoiceFontHeight + 8;
           // g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+10, rightMargin, CurrentY+10);

            //CurrentY = CurrentY + InvoiceFontHeight + 8;
            CurrentY = CurrentY ;
            RowValidation(MainGrid); RecordsPerPage = 20;
            CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote; string pcode = ""; string stats = "";
            bool ratechange = false; double realrate = 0; double notxrate = 0;
            for (int i = TRowcounting; i <= MainGrid.Rows.Count - 1; i++)
            {

                if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                {
                    if (TempRowcounting < RecordsPerPage)
                    {
                        if (isarbicdotprint == true)
                        {

                            notxrate = 0; pcode = ""; realrate = 0; stats = "";
                            FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 40, CurrentY);
                            pcode = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();
                            ItemNote = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "itemcode");
                            //g.DrawString(ItemNote, Verdananormal, BlackBrush, 90, CurrentY,Str );

                            //FieldValue = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang");
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 110, CurrentY );
                            FieldValue = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "itemname");
                            if (FieldValue!= "")
                            {
                            g.DrawString(FieldValue, Verdananormal, BlackBrush,70 , CurrentY);
                            }
                            
                            
                            stats = CommonClass._Itemmaster.SpecificField(pcode, "Incs").ToString();
                            if (stats == "1")
                            {
                                ratechange = true;
                            }
                            else
                            {
                                ratechange = false;
                            }
                        
                        
                        }
                        else
                        {

                            FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xSlno, CurrentY);
                            //FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xProductName, CurrentY);
                            //ItemNote = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang");
                            //g.DrawString(ItemNote, Verdananormal, BlackBrush, xProductName, CurrentY + InvoiceFontHeight + 2);
                        }
                        //FieldValue = MainGrid.Rows[i].Cells["clnitemcode"].Value.ToString();
                        //if (FieldValue.Length > 35)
                        //    FieldValue = FieldValue.Substring(0, 35);
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, Xcode, CurrentY);

                        //FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();

                        // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        //if (FieldValue.Length > 45)
                        //    FieldValue = FieldValue.Substring(0, 45);
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xProductName, CurrentY);
                        //ItemNote = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang");

                       // if (SSlnotracking == true)
                            ////g.DrawString(ItemNote, Verdananormal, BlackBrush, xProductName, CurrentY + InvoiceFontHeight + 2);

                        //string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();
                        //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "unit");
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 25, CurrentY, Str);


                        if (InvSubTitle5 != "      ESTIMATE")
                        {
                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnlength"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 250, CurrentY, Str);

                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnwidth"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 300, CurrentY, Str);

                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsqfl"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 350, CurrentY, Str);

                        }
                        else
                        {
                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnlength"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 284, CurrentY, Str);

                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnwidth"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 386, CurrentY, Str);

                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsqfl"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, 450, CurrentY, Str);
                        }
                        if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
                        {
                            if(isarbicdotprint==true)
                            {


                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 520, CurrentY,Str);

                                FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["ClnbaseU"].Value);
                                //FieldValue = 

                                FieldValue = Regex.Replace(FieldValue, "[0-9]", "");
                                FieldValue = Regex.Replace(FieldValue, "-", "");
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 460, CurrentY,Str);

                                //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 500, CurrentY);

                                //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clngross"].Value));
                                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 250, CurrentY, Str);
                                if( ratechange == true)
                                {
                                    realrate =CommonClass._Dbtask.znlldoubletoobject(   MainGrid.Rows[i].Cells["Clnsrate"].Value);
                                    notxrate = (realrate * 15) / (115);
                                    realrate = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.SetintoDecimalpoint(realrate - notxrate));
                                    FieldValue = String.Format("{0:0.00}",realrate.ToString());
                                }
                                else
                                {

                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clnsrate"].Value));
                                }
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 595, CurrentY,Str);

                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clngross"].Value));
                                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 580, CurrentY);

                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 650, CurrentY,Str);

                                
                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 750, CurrentY,Str);
                        
                            }
                            else
                            {


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty + 35, CurrentY, Str);


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clngross"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xRate + 55, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc + 30, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxAmt + 41, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 800, CurrentY, Str);
                        
                            }
                            }
                        else
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            FieldValue =FieldValue+" ("+ CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "Rack")+")";

                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 800, CurrentY, Str);
                        }


                       

                     


                        CurrentY = CurrentY + 25;
                        // * 2+4

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;
                    }
                }

            }
            
            if (CurrentRecord < RecordsPerPage)
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
                //g.DrawLine(new Pen(Brushes.Black, 1), 15, 890, rightMargin, 890);
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

                    ClsinvlaserFour Frms = new ClsinvlaserFour();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " "+ Frms._Gen.Getmajorsymbol() + " and " +
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
            CurrentY = CurrentY + 18;
            if (isarbicdotprint == true)
            {
                if (StrNaration.Length > 55)
                {
                    //g.DrawString(StrNaration.Substring(0, 55), ArialnormalItalic, BlackBrush, 760, CurrentY,Str);
                    //g.DrawString(StrNaration.Substring(55, StrNaration.Length - 55), ArialnormalItalic, BlackBrush, 760, CurrentY + 15,Str);
                }
                else
                {
                    ///g.DrawString(StrNaration, ArialnormalItalic, BlackBrush, 760, CurrentY,Str);
                }
            }
            else
            {

                if (StrNaration.Length > 55)
                {
                   // g.DrawString(StrNaration.Substring(0, 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                    //g.DrawString(StrNaration.Substring(55, StrNaration.Length - 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY + 15);
                }
                else
                {
                   // g.DrawString(StrNaration, ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                }
            }
            if (InvSubTitle5 != "      ESTIMATE")
            {
                if(isarbicdotprint==true)
                {
                 //g.DrawString(" (5%) ضريبة القيمة المضافة ", ArialnormalItalic, BlackBrush, 200, CurrentY,Str);
                CurrentY = CurrentY + 16;
                //g.DrawLine(new Pen(Brushes.Black, 1), 220, CurrentY, leftMargin, CurrentY);
                CurrentY = CurrentY + 16;
                }
                
                else
                {
                //g.DrawString(" (5%) ضريبة القيمة المضافة ", ArialnormalItalic, BlackBrush, 500, CurrentY);
                CurrentY = CurrentY + 16;
                //g.DrawLine(new Pen(Brushes.Black, 1), 500, CurrentY, rightMargin, CurrentY);
                CurrentY = CurrentY + 16;
                }
                double TNetAmount;
                if (Clstax.ZeroPercTaxableAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.ZeroPercTaxAmount, Clstax.ZeroPercTaxableAmount);

                    g.DrawString("0", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.ZeroPercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.ZeroPercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY);

                    CurrentY = CurrentY + 16;
                }
                if (Clstax.OnePercTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.OnePercTaxAmount, Clstax.OnePercTaxableAmount);

                    g.DrawString("1", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.OnePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.OnePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY);

                    CurrentY = CurrentY + 16;
                }
                if (Clstax.TwoPercTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwoPercTaxAmount, Clstax.TwoPercTaxableAmount);
                    g.DrawString("2", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwoPercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwoPercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.FivePercTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.FivePercTaxAmount, Clstax.FivePercTaxableAmount);
                   // g.DrawString("5", ArialnormalItalic, BlackBrush, 500, CurrentY);

                  g.DrawString(Clstax.FivePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                   // g.DrawString(Clstax.FivePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                   // g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY);
                    //" + Clstax.FivePercTaxableAmount + ",  " + TNetAmount, ArialnormalItalic, BlackBrush, 500, CurrentY);

                    CurrentY = CurrentY + 16;
                }
                if (Clstax.TwelPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwelPerceTaxAmount, Clstax.TwelPerceTaxableAmount);

                    g.DrawString("12.5", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwelPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwelPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.ForteenPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.ForteenPerceTaxAmount, Clstax.ForteenPerceTaxableAmount);

                    g.DrawString("14.5", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.ForteenPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.ForteenPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
                if (Clstax.TwenteenPerceTaxAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.TwenteenPerceTaxAmount, Clstax.TwenteenPerceTaxableAmount);

                    g.DrawString("20", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.TwenteenPerceTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.TwenteenPerceTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString(), ArialnormalItalic, BlackBrush, 700, CurrentY); CurrentY = CurrentY + 16;
                    CurrentY = CurrentY + 16;
                }
            }
            CurrentY = CurrentY + 16;

            if (Convert.ToDouble(TDiscount) > 0)
            {
                if (isarbicdotprint == true)
                {
                   // g.DrawString(" خصم", ArialnormalItalic, BlackBrush, 300, CurrentY,Str);
                    xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(TDiscount)).ToString(), Arialboldbottm, BlackBrush, 680, 790);
               
                
                
}
                else
                {

                    //g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                    //g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
                }
                
                }
            if (_Dbtask.znullDouble(Totherexpense) != 0)
            {
                CurrentY = CurrentY + 16;
                //g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                //g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }
           g.DrawLine(new Pen(Brushes.Gray, 4), 60, 920, 750, 920);
            if(isarbicdotprint==true)
            {
                CurrentY = 925;
                //if (Convert.ToDouble(TDiscount) > 0)
                //{
                //    if (isarbicdotprint == true)
                //    {
                        // g.DrawString(" خصم", ArialnormalItalic, BlackBrush, 300, CurrentY,Str);
                        xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                        g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(TDiscount)).ToString(), Arialboldbottm, BlackBrush, 680, CurrentY);
                        g.DrawString("Discount", Arialbold, BlackBrush, 400, CurrentY);
                        CurrentY = CurrentY + 25;
                //    }
                //}
                //g.DrawString(": مبلغ الفاتورة", VerdanaBoldHeading, BlackBrush, 300, CurrentY, Str);
                xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                g.DrawString("Amount(exclusive vat)", Arialbold, BlackBrush, 400, CurrentY );
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable).ToString(), Arialboldbottm, BlackBrush, 680, CurrentY);
                CurrentY = CurrentY + 25;
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount).ToString(), Arialboldbottm, BlackBrush, 680, CurrentY);
                g.DrawString("15%", Arialbold, BlackBrush, 490, CurrentY);
                //g.DrawString("15%", Verdananormal, BlackBrush, 630, 307);
                g.DrawString("Vat", Arialbold, BlackBrush, 400, CurrentY );
                
            
            }
            else
            {
            CurrentY = CurrentY + 16;
           // g.DrawString("Bill Amount", VerdanaBoldHeading, BlackBrush, 500, CurrentY);
            xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), VerdanaBoldHeading, BlackBrush, 700, CurrentY-60);
            }

            if (FormType != "     SALES ORDER")
            {
                string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                if (samplid == "18" && PrintOldbalance == true)
                {


                    if(isarbicdotprint==true)
                    {
                     CurrentY = CurrentY + 19;
                     //g.DrawString("التوازن القديم", ArialnormalItalic, BlackBrush, 300, CurrentY, Str);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    //g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, 150, CurrentY,Str);

                    CurrentY = CurrentY + 16;
                    //g.DrawString("المجموع الكلي", ArialnormalItalic, BlackBrush, 300, CurrentY, Str);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                   // g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush,690, CurrentY-20);
                    }
                    else
                    {
                    CurrentY = CurrentY + 16;
                   // g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    //g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, xTotalValue, CurrentY);

                    CurrentY = CurrentY + 16;
                    //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                   // g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, 690, CurrentY-20);
                
                    }
                    }
            }
           // g.DrawString(GrandTotal, Arialbold, BlackBrush, 690, CurrentY);
           
            CurrentY = CurrentY + 16;
        }


        public void PrintTotal(Graphics g)
        {
            CurrentY = 780;
           // g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);

            if(isarbicdotprint==true)
            {

                //g.DrawString("مجموع", Arialbold, BlackBrush, 760, CurrentY, Str);
            }

            else
            {

            //g.DrawString("Total", Verdananormal, BlackBrush, 60, CurrentY);
            }
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+20, rightMargin, CurrentY+20);

            if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
            {

                if (isarbicdotprint == true)
                {
                    //g.DrawString(TotalQty, Verdananormal, BlackBrush, 465, CurrentY,Str);/*For Qty*///350
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), Verdananormal, BlackBrush, 200, CurrentY);/*For Qty*///350
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalItemDisc), Verdananormal, BlackBrush, xDiscount, CurrentY);/*For Discount*/
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBoldSmall, BlackBrush, xTaxable, CurrentY);/*For Taxable*/
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), Verdananormal, BlackBrush, 130, CurrentY);/*For Tax*/

                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), Verdananormal, BlackBrush, 50, CurrentY);/*For Amount*/
                }
                else
                {
                    //g.DrawString(TotalQty, Verdananormal, BlackBrush, xQty, CurrentY);/*For Qty*///350
                   // g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), Verdananormal, BlackBrush, xRate, CurrentY);/*For Qty*///350
                   // g.DrawString(_Dbtask.SetintoDecimalpoint(TotalItemDisc), Verdananormal, BlackBrush, xDiscount, CurrentY);/*For Discount*/
                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBoldSmall, BlackBrush, xTaxable, CurrentY);/*For Taxable*/
                   // g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), Verdananormal, BlackBrush, xTaxAmt, CurrentY);/*For Tax*/

                    //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), Verdananormal, BlackBrush, 740, CurrentY);/*For Amount*/
                }
            }
            else
            {
                //g.DrawString(TotalQty, Verdananormal, BlackBrush, 740, CurrentY);/*For Amount*/
            }

            CurrentY = CurrentY + 32;
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
            StrQrData = _Gen.FureturnQrValue(_Companymaster.GetspecifField("Sellersname"), _Companymaster.GetspecifField("TRN"), Billno, BillDate, Ttaxamount, BillAmount); options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 140,
                Height = 120,

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
            g.DrawImage(newbit, 200,925);

            //CurrentY = CurrentY + 100;

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
                CurrentY = CurrentY + 8;


                VatPrinting(g);
                double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);
                    
                    
                


                AmountInWords _word = new AmountInWords();
                AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));
                if(isarbicdotprint==true)
                {
                    g.DrawString(" " + AmountinWords + " only", AmountInwordsfont3, BlackBrush, 60, 1050);
                    g.DrawString("Total", Arialboldbottm, BlackBrush, 400, 1020);
                    g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialboldbottm, BlackBrush, 680, 1020);
                    grandamtt = _Dbtask.SetintoDecimalpoint(GrandTotal).ToString();
                
                }
                else
                {

               // g.DrawString("Amount In Words :Rupees " + AmountinWords + " only", AmountInwordsfont, BlackBrush, 50, CurrentY);
                }
                if (CommonClass._Menusettings.GetMnustatus("9000") == "1")
                {
                    setqrtwo(g);
                }



                CurrentY = CurrentY + InvoiceFontHeight * 1;
                //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;


                string Pfooter;
                Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");
                if(isarbicdotprint==true)
                {
                    TotalValue = "الموقّع الموثق";
                CurrentY = CurrentY - 14;
                //g.DrawString(TotalValue, Arialbold, BlackBrush, 780, CurrentY,Str);
                CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                TotalValue = "مع الحالة والختم";
               // g.DrawString(TotalValue, Arialnormal, BlackBrush, 740, CurrentY,Str);
                }
                else
               {


                TotalValue = "Autherised Signatory";
                CurrentY = CurrentY - 14;
               // g.DrawString(TotalValue, Arialbold, BlackBrush, 600, CurrentY);
                CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                TotalValue = "  [With Status&Seal]";
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 600, CurrentY);
                 }
                if (Pfooter != "")
                    g.DrawString(Pfooter, Arialbold, BlackBrush, 100, CurrentY);
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
