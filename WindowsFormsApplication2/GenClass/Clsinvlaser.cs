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
    class Clsinvlaser
    {
        private QrCodeEncodingOptions options;
        public bool Bunit;
        public bool PrintBarcodeLaser;
        public bool SitemNote;
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

        public string TotalQty;
        public double TotalItemDisc;
        public double TotalTaxable;
        public double TotalTaxAmount;
        public double TotalNetamount;
        public double OldBalance;

        public string InvoiceName;
        public string TaxDeclaration;
        public string FormType;

        public int xTotalValue;

        int TRowcounting = 0;
        int TempRowcounting = 0;
        /**********************************/

        int xQty; int xProductName;
        int xRate; int lastline;
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
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";

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

            int Fleft = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Leftleser"));
            leftMargin = Fleft;
            InvSubTitleInvoicename = InvoiceName;

            InvImage = Application.StartupPath + @"\Images\" + "InvPicSecond.jpg";
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
                int xImage = InvoiceWidth - oInvImage.Width;
               // ImageHeight = oInvImage.Height; // Get Image Height
                ImageHeight = 0;
                    g.DrawImage(oInvImage, CurrentX, 0);
                
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
            //Strheading = "بِسْمِ اللهِ الرَّحْمٰنِ الرَّحِيْمِ";
            Strheading = " ";
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
            g.DrawString(Strheading, VerdanaBoldHeading, BlackBrush, xInvTitlex-20, 20);/*For Tin*/

            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            if (Cst != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                //g.DrawString("CST:", Arialnormal, BlackBrush, 50, CurrentY / 2);/*For CST Reg No*/

                //g.DrawString(Cst, Arialbold, BlackBrush, 80, CurrentY / 2);/*CST Reg No*/
                ////arab
                //g.DrawString(Cst, Arialbold, BlackBrush, 550, CurrentY / 2);/*CST Reg No*/
            }
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/

            if (InvTitle != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                //CurrentY = CurrentY + ImageHeight;
                //xInvTitle = 50;
                //g.DrawString(InvTitle, VerdanaBoldarb, BlackBrush, xInvTitle, CurrentY);
                ////arab
                //InvTitle = _Companymaster.GetspecifField("fax");
                //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, 510, CurrentY);
                //CurrentY = CurrentY + 13;

                //InvTitle = _Companymaster.GetspecifField("Nameinhome");

                //if (InvTitle != "")
                //{
                //    CurrentY = CurrentY + 20;
                //    xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
                //   // g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, xInvTitle, CurrentY);
                //    //arab
                //    //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, 550, CurrentY);
                //    CurrentY = CurrentY + 5;
                //}
            }
            if (_Companymaster.GetspecifField("Nameinhome") != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address*/
            {
                //CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(_Companymaster.GetspecifField("Nameinhome"), VerdanaBold, BlackBrush, 50, CurrentY);//xInvSubTitle1
                ////arab
                //g.DrawString(_Companymaster.GetspecifField("email"), VerdanaBold, BlackBrush, 510, CurrentY );//xInvSubTitle1
                //CurrentY = CurrentY + 5;
            }

            if (_Companymaster.GetspecifField("website") != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address2*/
            {
                //CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(_Companymaster.GetspecifField("address1"), VerdanaBold, BlackBrush, 50, CurrentY);//xInvSubTitle1
                ////arab
                //g.DrawString(_Companymaster.GetspecifField("website"), VerdanaBold, BlackBrush, 510, CurrentY );//xInvSubTitle1
                //CurrentY = CurrentY + 5;
            }
            /*City*/
            if (_Companymaster.GetspecifField("accountno") != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Address2*/
            {
                //CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(_Companymaster.GetspecifField("address2"), VerdanaBold, BlackBrush, 50, CurrentY);//xInvSubTitle1
                ////arab
                //g.DrawString(_Companymaster.GetspecifField("accountno"), VerdanaBold, BlackBrush, 510, CurrentY );//xInvSubTitle1
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
                g.DrawString(InvSubTitle5, Arialboldformname, BlackBrush, leftMargin+280, 120);
               // CurrentY = CurrentY + 5;

                if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                {
                    CurrentY = CurrentY + InvSubTitleHeight;
                    g.DrawString("    " + ModeofPayment, Arialbold, BlackBrush, 365, 140);
                    CurrentY = CurrentY + 5;
                }

                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("(To be Prepared in Duplicate)", Verdananormal, BlackBrush, 300, CurrentY);
            }

            CurrentY = CurrentY + InvSubTitleHeight;
            g.DrawString("فاتورة ضريبية", VerdanaBoldHeading, BlackBrush, leftMargin + 340, 160);

            CurrentY = CurrentY + InvSubTitleHeight;
            g.DrawString("Tax Invoice", VerdanaBoldHeading, BlackBrush, leftMargin + 330, 180);

            CurrentY = 140;
            if (InvSubTitle6 != "" && FormType == "Multi")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle6, Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle7 != "" && FormType == "Multi")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle7, Verdananormal, BlackBrush, 300, CurrentY);
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

            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX + 230, CurrentY);
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX, CurrentY + 50);
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX + 230, CurrentY, CurrentX + 230, CurrentY + 50);
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY + 50, CurrentX + 230, CurrentY + 50);

            FieldValue = "Bill No(رقم)               &Date(تاريخ)";
            g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 2, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight * 2;
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY - 4, CurrentX + 230, CurrentY - 4);
            g.DrawString(Billno+" "+"/", VerdanaBold, BlackBrush, CurrentX, CurrentY);
            g.DrawString(BillDate.ToString("dd/MM/yyyy hh:mm:ss"), Arialnormal, BlackBrush, CurrentX + 68, CurrentY);


            //FieldValue = "Date: ";
            //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 600, CurrentY);
            //g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, CurrentX + 640, CurrentY);

            CurrentY = CurrentY + InvoiceFontHeight * 2;

            string CName = TempCust;

            string Address = _Accountledger.GetspecifField("address", Lid);

            string CTin = _Accountledger.GetspecifField("Taxregno", Lid);

            int CCount = Address.Split('\n').Length - 1;

            if (SProject == true)
            {
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }

            FieldValue = "Customer (عميل):";
            g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY); //+CName;

            

            //FieldValue = CName;
            //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX+150, CurrentY);
            if (CName.Length > 27)
            {
                g.DrawString(CName.Substring(0, 25), VerdanaBold, BlackBrush, CurrentX, CurrentY + 15);
                g.DrawString(CName.Substring(25, CName.Length-25), VerdanaBold, BlackBrush, CurrentX, CurrentY + 30);
            }
            else
            {
                g.DrawString(CName, VerdanaBold, BlackBrush, CurrentX+100, CurrentY + 15);
            }

            int count = 0;
            int kk = 1;
         
            
         
            FieldValue = "";
         
            foreach (char c in Address)
            {
                FieldValue = FieldValue + c;
                if (c == '\n')
                {
                    g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
                    kk++;
                    FieldValue = "";
                }
                count++;
            }
            g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
            kk++;
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
                FieldValue = "VAT(الرقم الضريبي)";
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 460, CurrentY);
                FieldValue = ":";
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 620, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;
            }

            FieldValue = "Mobile(رقم الهاتف المحمول)";
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 460, CurrentY);
            FieldValue = ":";
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);

            if (SProject == true)
            {
                FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }
            else
            {
                FieldValue = _Accountledger.GetspecifField("mobile", Lid);
            }
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 620, CurrentY);


            CurrentY = CurrentY + InvoiceFontHeight;
            // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
            FieldValue = "Phone(رقم)";
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 460, CurrentY);
            FieldValue = ":";
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            FieldValue = _Accountledger.GetspecifField("phone", Lid);
            g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 620, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight;

            if (FormType == "WHOLESALE")
            {
                FieldValue = "CST";
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                FieldValue = _Accountledger.GetspecifField("cst", Lid);
                g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
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
            CurrentY = CurrentY + 8;
            g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno, CurrentY);
            g.DrawString("رقم", Verdananormal, BlackBrush, xSlno, CurrentY+13);
            //int xProductName = new int();

           

            if (InvSubTitle5 != "      ESTIMATE")
            {
                xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);

                g.DrawString("اسم العنصر", Verdananormal, BlackBrush, xProductName, CurrentY + 13);

                g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 870);
                xQty = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 250;
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

               // xQty = 480;
                if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
                {
                    g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 870);
                    g.DrawString("Qty", Verdananormal, BlackBrush, xQty+5, CurrentY);
                    g.DrawString("الكمية", Verdananormal, BlackBrush, xQty+5, CurrentY + 13);

                    xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 20;//10
                    g.DrawLine(new Pen(Brushes.Black, 1), xRate, CurrentY, xRate, 870);
                    g.DrawString("Unit Rate  ", Verdananormal, BlackBrush, xRate + 5, CurrentY);
                    g.DrawString("إجمالي  ", Verdananormal, BlackBrush, xRate + 5, CurrentY+13);

                    xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                    g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 870);
                    g.DrawString("Gross", Verdananormal, BlackBrush, xDiscount + 5, CurrentY);
                    g.DrawString("المبلغ ", Verdananormal, BlackBrush, xDiscount + 5, CurrentY + 13);

                    xTaxable = xDiscount + (int)g.MeasureString("  Tax%", Verdananormal).Width + 30;//25
                    //g.DrawLine(new Pen(Brushes.Black, 1), xTaxable, CurrentY, xTaxable, 770);
                    //g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, 560, CurrentY);
                    g.DrawLine(new Pen(Brushes.Black, 1), xTaxable, CurrentY, xTaxable, 870);
                    

                    g.DrawString(" Tax% ", Verdananormal, BlackBrush, xTaxable+5, CurrentY);
                    g.DrawString("ضريبة%", Verdananormal, BlackBrush, xTaxable+5, CurrentY + 13);



                    xTaxAmt = xTaxable + (int)g.MeasureString("  Tax%", Verdananormal).Width;
                    g.DrawLine(new Pen(Brushes.Black, 1), xTaxAmt, CurrentY, xTaxAmt, 870);
                    
                    //xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
                    //g.DrawLine(new Pen(Brushes.Black, 1), xTaxAmt, CurrentY, xTaxAmt, 870);
                    g.DrawString("  Tax  ", Verdananormal, BlackBrush, xTaxAmt+5, CurrentY);
                    g.DrawString("ضريبة", Verdananormal, BlackBrush, xTaxAmt+5, CurrentY + 13);

                    xNetamt = xTaxAmt + (int)g.MeasureString(" Amount", Verdananormal).Width + 10;//10

                    g.DrawLine(new Pen(Brushes.Black, 1), xNetamt, CurrentY, xNetamt, 870);
                
                
                }
                
            }
            else
            {
                //510
                //602
                //638
                xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), xProductName, CurrentY, xProductName, 890);
                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 107;
                //g.DrawString("Length", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 214;
                //g.DrawString("Width", Verdananormal, BlackBrush, xQty, CurrentY);

                //xQty = xProductName + (int)g.MeasureString("Width%", Verdananormal).Width + 321;
                //g.DrawString("Sq.Ft", Verdananormal, BlackBrush, xQty, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Product Name", Verdananormal).Width + 492;
                g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), xQty, CurrentY, xQty, 770);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
                g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), xRate, CurrentY, xRate, 770);

                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
               // g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), xDiscount, CurrentY, xDiscount, 770);
            }

            if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
            {
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 870);

               
               // g.DrawLine(new Pen(Brushes.Black, 1), 720, CurrentY, 720, 870);
                //xNetamt = xTaxAmt + (int)g.MeasureString("Tax", Verdananormal).Width + 10;//10
               //g.DrawLine(new Pen(Brushes.Black, 1), xNetamt, CurrentY, xNetamt, 770);
                g.DrawString("    Amount", Verdananormal, BlackBrush, xNetamt+5, CurrentY);
                g.DrawString("كمية الشبكة", Verdananormal, BlackBrush, xNetamt+5, CurrentY + 13);
                lastline = xNetamt + (int)g.MeasureString("  Amount", Verdananormal).Width + 10;//10
                rightMargin = lastline;
                g.DrawLine(new Pen(Brushes.Black, 1), lastline, CurrentY, lastline, 870);
            
            
            }
            else
            {
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, leftMargin, 870);
                g.DrawLine(new Pen(Brushes.Black, 1), rightMargin, CurrentY, rightMargin, 870);
                xNetamt = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 10;//10
                g.DrawString("Qty", Verdananormal, BlackBrush, 750, CurrentY);
            }







            // Set Invoice Table:
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);



            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+10, rightMargin, CurrentY+10);

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


                        //FieldValue = MainGrid.Rows[i].Cells["clnitemcode"].Value.ToString();
                        //if (FieldValue.Length > 35)
                        //    FieldValue = FieldValue.Substring(0, 35);
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, Xcode, CurrentY);

                        FieldValue = MainGrid.Rows[i].Cells["clnitemname"].Value.ToString();

                        if (SitemNote == true)
                        {
                            FieldValue = FieldValue + " " + _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                        }

                        if (Bunit == true)
                        {
                            FieldValue = FieldValue + " " + _Dbtask.znllString(MainGrid.Rows[i].Cells["ClnbaseU"].Value);
                        }
                           // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        //if (FieldValue.Length > 45)
                        //    FieldValue = FieldValue.Substring(0, 45);
                       // xProductName = 50;
                        
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, xProductName, CurrentY);
                        ItemNote = CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang");

                        if (ItemNote != "")
                        {
                            g.DrawString(ItemNote, Verdananormal, BlackBrush, (350+ leftMargin) - (int)g.MeasureString(ItemNote, Verdananormal).Width, CurrentY + InvoiceFontHeight + 2);

                            RecordsPerPage = 11;
                        }


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
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xRate-5, CurrentY, Str);


                          
                            //FieldValue =_Dbtask.znllString( MainGrid.Rows[i].Cells["clnunit"].Value);
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc - 5, CurrentY, Str);

                            
                            
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush,xDiscount-5, CurrentY, Str);

                            xTaxperc = xProductName + (int)g.MeasureString(FieldValue, Verdananormal).Width + 492;

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxAmt-5, CurrentY, Str);




                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xNetamt-5, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xDiscount + 5, CurrentY);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, rightMargin-20, CurrentY, Str);
                        }
                        else
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            FieldValue =FieldValue+" ("+ CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "Rack")+")";

                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 800, CurrentY, Str);
                        }





                        if (CommonClass._Itemmaster.SpecificField(_Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemname"].Tag), "llang") != "")
                        {
                            CurrentY = CurrentY + 38;
                        }
                        else
                        {
                            CurrentY = CurrentY + 17;
                        }

                      
                        // * 2+4

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;
                    }
                }

            }
            
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
                g.DrawLine(new Pen(Brushes.Black, 1), 15, 920, rightMargin, 920);

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

                    Clsinvlaser Frms = new Clsinvlaser();
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
                Width = 120,
                Height = 125,

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
            g.DrawImage(newbit, 370, 890);

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

            if (StrNaration.Length > 50)
            {
                g.DrawString(StrNaration.Substring(0, 50), ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                g.DrawString(StrNaration.Substring(50, StrNaration.Length - 50), ArialnormalItalic, BlackBrush, CurrentX, CurrentY + 15);
            }
            else
            {
                g.DrawString(StrNaration, ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
            }
            if (InvSubTitle5 != "      ESTIMATE")
            {
                setqrtwo(g);
                g.DrawString("TOTAL", ArialnormalItalic, BlackBrush, 500, CurrentY);
                g.DrawString("(مجموع)", ArialnormalItalic, BlackBrush, 600, CurrentY);
                g.DrawString(TotalTaxable.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);
                CurrentY = CurrentY + 16;

                g.DrawString("VAT 15%", ArialnormalItalic, BlackBrush, 500, CurrentY);
                g.DrawString("(ضريبة)", ArialnormalItalic, BlackBrush, 600, CurrentY);
                g.DrawString(Ttaxamount, ArialnormalItalic, BlackBrush, 700, CurrentY);
                CurrentY = CurrentY + 16;
                double TNetAmount;
               
               
             
                
               
              
              
            }
            CurrentY = CurrentY + 16;

            if (Convert.ToDouble(TDiscount) > 0)
            {
                g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }
            if (_Dbtask.znullDouble(Totherexpense) != 0)
            {
                CurrentY = CurrentY + 16;
                g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }

            CurrentY = CurrentY + 16;
            g.DrawString("Bill Amount(المجموع الإجمالي)", ArialnormalItalic, BlackBrush, 500, CurrentY);
            xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), VerdanaBoldHeading, BlackBrush, 700, CurrentY);


            if (FormType != "     SALES ORDER")
            {
                string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                if (samplid == "18" && PrintOldbalance == true)
                {
                    CurrentY = CurrentY + 16;
                    g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, xTotalValue, CurrentY);

                    CurrentY = CurrentY + 16;
                    g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                    g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, xTotalValue, CurrentY);
                }
            }

            CurrentY = CurrentY + 30;
        }


        public void PrintTotal(Graphics g)
        {
            CurrentY = 870;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            g.DrawString("Total", Verdananormal, BlackBrush, xProductName, CurrentY);
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY+20, rightMargin, CurrentY+20);

            if (InvSubTitle5 != "DELIVERY NOTE INVOICE")
            {
                g.DrawString(TotalQty, Verdananormal, BlackBrush, xQty, CurrentY);/*For Qty*///350
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), Verdananormal, BlackBrush, xRate, CurrentY);/*For Qty*///350
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalItemDisc), Verdananormal, BlackBrush, xDiscount, CurrentY);/*For Discount*/
                ////g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBoldSmall, BlackBrush, xTaxable, CurrentY);/*For Taxable*/
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), Verdananormal, BlackBrush, xTaxAmt, CurrentY);/*For Tax*/

                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), Verdananormal, BlackBrush, 740, CurrentY);/*For Amount*/
            }
            else
            {
                g.DrawString(TotalQty, Verdananormal, BlackBrush, xQty, CurrentY);/*For Amount*/
            }

            CurrentY = CurrentY + 32;
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
                CurrentY = CurrentY + 10;


                VatPrinting(g);



                AmountInWords _word = new AmountInWords();
                AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));

                g.DrawString("Amount In Words :" + AmountinWords + " only", AmountInwordsfont, BlackBrush, 50, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight * 1;
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;


                string Pfooter;
                Pfooter = CommonClass._Paramlist.GetParamvalue("Pfooter");
                TotalValue = "Autherised Signatory";
                CurrentY = CurrentY - 14;
                g.DrawString(TotalValue, Arialbold, BlackBrush, 600, CurrentY);
                CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                TotalValue = "  [With Status&Seal]";
                g.DrawString(TotalValue, Arialnormal, BlackBrush, 600, CurrentY);

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
                leftMargin = 2;
                //rightMargin = (int)e.MarginBounds.Right;
                rightMargin = 787;

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
