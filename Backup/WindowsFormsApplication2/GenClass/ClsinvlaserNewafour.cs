using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using ZXing.Common;
using System.Globalization;
using ZXing;
using ZXing.QrCode;
using System.Text.RegularExpressions; 
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class ClsinvlaserNewafour
    {
        public bool PrintBarcodeLaser;
        private QrCodeEncodingOptions options;
        public double Cess = 0;
        public bool PrintHeader=true;
        public double CGSTTAX;
        public double SGSTTAX;
        public double IGSTTAX;
        public string billnote = "";
        /*For Settings*/
        string Cst = ""; public int RecordsPerPage = 14;
        public bool SSlnotracking;
        public  string SelPrint;
        public bool SProject;
        /***************/
        public string StrNaration = "";
        public string Strstate = "KARNATAKA";
        public string PSelect;
        public string PTYpe;
        public string wichtax = "";

        public bool PrintOldbalance;
        public long ValidRecord = 0;
        public string vehicle = "";
        //int RecordsPerPage = 14; // twenty items in a page
        /*Load Data*/
        public string fper = ""; public string f2per = ""; public string f3per = "";
        public double fv = 0; public double fv1 = 0; public double fv2 = 0;

        public double alldisc = 0;
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
        public string discprint = "";

        public string SALERCAMT;
        public string SALEBLNCAMTT;
        public string Totherexpense;
        public string BillAmount;
        public string AmountinWords;
        public string Ttaxamount;
        public double recevdamtt = 0;
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

        private Font ArLAST = new Font("Franklin Gothic Demi", 10, FontStyle.Italic);
        private Font ArLAST2 = new Font("Franklin Gothic Demi", 7, FontStyle.Regular);

        private Font Arialbold = new Font("Arial", 10, FontStyle.Bold);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        //Arial Rounded MT Bold
        private Font HEADD = new Font("Arial Rounded MT Bold", 13, FontStyle.Regular);
       // private Font HEADD = new Font("Berlin Sans FB Demi", 13, FontStyle.Regular);
        private Font OUR = new Font("Tw Cen MT", 12, FontStyle.Regular);
        private Font OUR2 = new Font("Tw Cen MT", 10, FontStyle.Regular);
        //Copperplate Gothic Light
        private Font Invhead = new Font("Roboto Black", 18, FontStyle.Bold);
        //Berlin Sans FB Demi
        private Font xeroterms = new Font("Lucida Bright", 7, FontStyle.Bold);
        private Font STRT = new Font("Javanese Text", 6, FontStyle.Bold);

        private Font xerofnt = new Font("Microsoft Himalaya", 16, FontStyle.Regular);
        private Font xerofnt2 = new Font("Microsoft Himalaya", 14, FontStyle.Bold);
        private Font xerotermhead = new Font("Lucida Fax", 9, FontStyle.Bold);

        // Invoice Font
        // private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //private Font InvoiceFont = new Font("Calibri", 12, FontStyle.Regular);
        private Font VerdanaBoldHeading = new Font("Verdana", 12, FontStyle.Bold);
        private Font VerdanaBold = new Font("Verdana", 8, FontStyle.Bold);
        //Customer Detail
        private Font Verdananormal = new Font("Verdana", 8, FontStyle.Regular);
        //private Font VerdananormalC = new Font("Verdana", , FontStyle.Regular);

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

            Temp = "                   GOODS AND SERVICE TAX RULE 2017";

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
            else if (FormType == "SALES QUOTATION")
            {
                InvSubTitle5 = "               QUOTATION";
            }
            else 
            {
                //if (CommonClass._Md2.debso == true)
                //{
                //    FormType = "Debit Note";
                //}
                //if (CommonClass._Md2.debsocr == true)
                //{
                //    FormType = "Credit Note";
                //}
                InvSubTitle5 = "TAX  INVOICE";
            }

            if (FormType != "ESTIMATE" && FormType != "     SALES ORDER")
            {
                InvTitle = _Companymaster.GetspecifField("cname");
                InvSubTitleTaxDeclaration = TaxDeclarationfU();
                InvSubTitle1 = _Companymaster.GetspecifField("Address1");
                InvSubTitle11 = _Companymaster.GetspecifField("Address2");
                InvSubTitle2 = "Phone " + _Companymaster.GetspecifField("Telephone");//Kerala
                InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
                InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
                InvSubTitle6 =   Billno  ;
                InvSubTitle7 = "Name&Address :" + _Accountledger.GetspecifField("lname", Lid) + "," + _Accountledger.GetspecifField("address", Lid) + ";                                                                                     Bill Date";
                Cst = _Companymaster.GetspecifField("taxno2");
            }
            //else
            //{
            //  //  RecordsPerPage = 40;
            //    RecordsPerPage = 31;

            //}
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
            if (System.IO.File.Exists(InvImage))
            {
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, xImage, CurrentY);
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
            if (InvSubTitle3 != ""&&FormType!="ESTIMATE" )/*For Company Heading*/
            {
                //g.DrawString("GSTIN:", Arialnormal, BlackBrush, 50, CurrentY / 2);/*For Tin*/
                //g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 100, CurrentY / 2);/*CST Reg No*/

                //g.DrawString("State Code:", Arialnormal, BlackBrush, 50, CurrentY);/*For Tin*/
                //g.DrawString(_Companymaster.GetspecifField("statecode"), Arialbold, BlackBrush, 150, CurrentY);/*State Code*/

            }
            else
            {
                RecordsPerPage = 40;
            }
           // RecordsPerPage = 36;
            //new rectangle

            Pen selpen = new Pen(Color.Black);

            g.DrawRectangle(selpen, 1, 5, 780, 280);
            g.DrawRectangle(selpen, 1, 5, 780, 1140);
            Pen penborder = new Pen(Color.Black);

            //g.DrawRectangle(selpen, 70, rectyy + 8, 700, 30);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 5, 400, 250);

            g.DrawLine(new Pen(Brushes.Black, 1), 630, 5, 630, 180);
            
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 30, 780,30);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 60, 780, 60);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 120, 780, 120);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 150, 780, 150);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 91,780, 91);
            g.DrawLine(new Pen(Brushes.Black, 1),1, 150, 400, 150);

            g.DrawLine(new Pen(Brushes.Black, 1), 1, 250, 780, 250);
            g.DrawLine(new Pen(Brushes.Black, 1), 400, 182, 780, 182);
            //rectngle
            //g.DrawLine(new Pen(Brushes.Black, 1),580, 182, 580, 250);

            //g.DrawLine(new Pen(Brushes.Black, 1), 580, 216, 780, 216);



            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            if (Cst != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
               // g.DrawString("CST", Arialnormal, BlackBrush, 600, CurrentY / 2);/*For CST Reg No*/

                //g.DrawString(Cst, Arialbold, BlackBrush, 650, CurrentY / 2);/*CST Reg No*/
            }
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/
            //if(FormType != "ESTIMATE")
            //{
            if (InvTitle != "" )/*For Company Heading*/
            {
                CurrentY = CurrentY + ImageHeight;
                //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, xInvTitle, CurrentY);
                CurrentY = CurrentY + 5;
            }
            if (InvSubTitle1 != "" )/*For Address*/
            {
                CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, xInvSubTitle1, CurrentY);
                CurrentY = CurrentY + 5;
            }

            if (InvSubTitle11 != "" )/*For Address2*/
            {
                CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(InvSubTitle11, VerdanaBold, BlackBrush, xInvSubTitle11, CurrentY);
                CurrentY = CurrentY + 5;
            }
            if (InvSubTitle2 != "" )/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2, CurrentY);
                CurrentY = CurrentY + 5;
            }
            if (InvSubTitle4 != "" && FormType != "ESTIMATE")/*For TaxRule*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle4, Arialnormal, BlackBrush, 180, CurrentY);
                CurrentY = CurrentY + 5;

                CurrentY = CurrentY + InvSubTitleHeight;

                //if (FormType == "WHOLESALE")
                //{
                //    g.DrawString("FORM NO.8", Arialbold, BlackBrush, 350, CurrentY);
                //}
                //else if (FormType == "    RETAIL")
                //{
                //    g.DrawString("FORM NO.8B", Arialbold, BlackBrush, 350, CurrentY);
                //    CurrentY = CurrentY + 5;

                //    CurrentY = CurrentY + InvSubTitleHeight;
                //    g.DrawString("(For Customers When input tax credit is not required)", Verdanaitalic, BlackBrush, 250, CurrentY);
                //    CurrentY = CurrentY + 5;
                //}
                //else if (FormType == "SALES RETURN" || FormType == "DELIVERY NOTE")
                //{
                //    g.DrawString("FORM NO.9", Arialbold, BlackBrush, 350, CurrentY);
                //}



                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("[See rule 58(10)]", Verdanaitalic, BlackBrush, 350, CurrentY);
                //CurrentY = CurrentY + 5;
            }
            //}

            //if (InvSubTitle3 != "")/*For Tin*/
            //{
            //    CurrentY = CurrentY + InvSubTitleHeight;
            //    g.DrawString(InvSubTitle3, InvSubTitleFont, BlackBrush, xInvSubTitle3, CurrentY);
            //}

            if (InvSubTitle5 != ""&&PrintHeader==true)/*For InVoiceName*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 300, CurrentY);
                CurrentY = CurrentY + 5;

                //if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                //{
                    CurrentY = CurrentY + InvSubTitleHeight;
                    //g.DrawString( "Credit/Cash", Arialnormal, BlackBrush, 350, CurrentY);
                    CurrentY = CurrentY + 5;
               // }

                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("(To be Prepared in Duplicate)", Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle6 != "" && FormType == "Multi")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("Vno : ", Verdananormal, BlackBrush, 500, 15);
                //g.DrawString(InvSubTitle6, Verdananormal, BlackBrush, 500, 20,Str);
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
            
            CurrentX = leftMargin ;
            CurrentY = topMargin ;

            //CurrentX = 200;
            if (FormType != "ESTIMATE" && FormType != "     SALES ORDER")
            {
                CurrentY = 170;
            }
            else
            {
                CurrentY = 100;
            }
            //CurrentY = 170;
            if (FormType == "SALES QUATATION")
            {
                FieldValue = "QUATATION NO: ";
            }
            else
            {
                FieldValue = "NO:  ";
            }
            
            //new
            string city = ""; string mob = ""; string state = ""; string ststcode = "";
            string email = "";
            city = _Companymaster.GetspecifField("city").ToString();
            mob =_Companymaster.GetspecifField("mobile").ToString();
            state = _Companymaster.GetspecifField("state").ToString();
           //ststcode= _Companymaster.GetspecifField("statecode").ToString();
           email = _Companymaster.GetspecifField("email").ToString();

           g.DrawString(InvTitle.ToString(), HEADD, BlackBrush, 10, 10);
            g.DrawString(InvSubTitle1.ToString(), OUR2, BlackBrush, 10, 35);
            g.DrawString(InvSubTitle11.ToString(), OUR, BlackBrush, 10, 55);
            g.DrawString(city.ToString(), VerdanaBold, BlackBrush, 10, 75);
            g.DrawString(InvSubTitle2.ToString(), VerdanaBold, BlackBrush, 10, 88);
            g.DrawString("Mobile: " + mob.ToString(), VerdanaBold, BlackBrush, 160, 88);
           g.DrawString("VAT : " + InvSubTitle3.ToString(), OUR, BlackBrush, 10, 101);
           g.DrawString("State :" + state.ToString(), VerdanaBold, BlackBrush, 10, 119);
           //g.DrawString("State code :" + ststcode.ToString(), VerdanaBold, BlackBrush, 140, 119);
           g.DrawString("Email :" + email.ToString(), VerdanaBold, BlackBrush, 10, 135);
            
            
            
            
            string CTin = "";
            CTin = _Accountledger.GetspecifField("Taxregno", Lid);

          string cumob = "";
          cumob =  _Accountledger.GetspecifField("mobile", Lid);
            g.DrawString("Buyer (Bill to )  ", Verdananormal, BlackBrush,10, 150);
            g.DrawString(TempCust.ToString(), VerdanaBold, BlackBrush, 10, 170);
            g.DrawString("Mobile : " + cumob.ToString(), xeroterms, BlackBrush, 10, 185);
            g.DrawString("VAT : " + CTin.ToString(), xeroterms, BlackBrush, 10, 199);

            if (FormType == "    RETAIL" || FormType == "     SALES")
            {
                g.DrawString("TAX INVOICE ", Invhead, BlackBrush, 350, 258);
            }
            else
            {
                g.DrawString(FormType, Invhead, BlackBrush, 350, 258);
            }
            
            g.DrawString("Vno : ", Verdananormal, BlackBrush, 400, 15);
            g.DrawString(Billno, VerdanaBold, BlackBrush, 600, 15, Str);
            g.DrawString("Delivery note", Verdananormal, BlackBrush, 400, 35);
            g.DrawString("Reference no.&date", Verdananormal, BlackBrush, 400, 60);
            g.DrawString("buyer's order no.", Verdananormal, BlackBrush, 400, 95);
            g.DrawString("Dispatch doc no.", Verdananormal, BlackBrush, 400, 119);
            g.DrawString("Dispatched through", Verdananormal, BlackBrush, 400, 150);
            g.DrawString("Terms of delivery", Verdananormal, BlackBrush, 400, 190);

           // g.DrawString("Bill of ladding LR-RR no.", Verdananormal, BlackBrush, 581, 186);
           // g.DrawString("Motor vehicle no.", Verdananormal, BlackBrush, 581, 219);
            //g.DrawString(vehicle, VerdanaBold, BlackBrush, 780, 229,Str);
            
            g.DrawString("Date :  ", Verdananormal, BlackBrush, 630, 15);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, 775, 15, Str);
            g.DrawString("Mode of payment", Verdananormal, BlackBrush, 630, 35);
            g.DrawString(ModeofPayment, VerdanaBold, BlackBrush, 775, 35, Str);
            g.DrawString("Other reference", Verdananormal, BlackBrush, 630, 60);
            g.DrawString("Dated", Verdananormal, BlackBrush, 630, 95);
            g.DrawString("Delivery note date", Verdananormal, BlackBrush, 630, 119);
            g.DrawString("Destination", Verdananormal, BlackBrush, 630, 150);
            
            
            
            TDiscount = CommonClass._Businessissue.getdiscount(Billno).ToString();

            FieldValue = "Date: ";
            //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 600, CurrentY);
            //g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, CurrentX + 640, CurrentY);

            CurrentY = CurrentY + InvoiceFontHeight * 2;

            string CName = TempCust;
            
            string Address = _Accountledger.GetspecifField("address", Lid);

           
            int CCount = Address.Split('\n').Length - 1;

            //int CCount = Address.Split('\n').Length - 1;


            if (SProject == true)
            {
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }

            FieldValue = "Customer :" + CName;
            //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);

            int count = 0;
            FieldValue = "";
            int kk = 1; CurrentY = 200;
            foreach (char c in Address)
            {
                FieldValue = FieldValue + c;
                if (c == '\n')
                {
                    g.DrawString(FieldValue, Verdananormal, BlackBrush, 10, CurrentY + 15 * kk);
                    kk++;
                    FieldValue = "";
                }
                count++;
            }
            g.DrawString(FieldValue, Verdananormal, BlackBrush, 10, CurrentY + 15 * kk);
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

            if (FormType == "WHOLESALE" || FormType == "Purchase Return"||SProject==false)
            {
                FieldValue = "GST";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight;
            }

            FieldValue = "Mobile";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);

            if (SProject == true)
            {
                FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
                Address= CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }
            else
            {
                FieldValue = _Accountledger.GetspecifField("mobile", Lid);
            }
           // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);


            CurrentY = CurrentY + InvoiceFontHeight;
            // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
            FieldValue = "Phone";
           // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
            FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
            FieldValue = _Accountledger.GetspecifField("phone", Lid);
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight;

            if (FormType == "WHOLESALE")
            {
                FieldValue = "CST";
               // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                FieldValue = _Accountledger.GetspecifField("cst", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
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
            CurrentY = CurrentY + 20;
            g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno,288);
            int xProductName = new int();
            int XHsncode = new int();

            int xRate;

            if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
            {

                xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName+50, 288);//CurrentY


                XHsncode = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 175;
                g.DrawString("Qty", Verdananormal, BlackBrush, 380, 288); //297


                xQty = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 250;
                g.DrawString("Rate", Verdananormal, BlackBrush, 470, 288);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 20;//10
                g.DrawString("perc  ", Verdananormal, BlackBrush, 580, 288);

                //xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                //g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                g.DrawString("Vat", Verdananormal, BlackBrush, 630, 288);



                xTaxable = xDiscount + (int)g.MeasureString("Cess", Verdananormal).Width + 30;//25
                //g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, xTaxable, CurrentY);

                xTaxperc = xTaxable + (int)g.MeasureString("Taxable(Amt)", Verdananormal).Width + 10;//10
                //g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxperc, CurrentY);

                xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
                //g.DrawString("Tax(Amt)", Verdananormal, BlackBrush, xTaxAmt, CurrentY);
            }
            else
            {
                //510
                //602
                //638
                xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 430;
                g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
                g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);

                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
                g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
            }


            xNetamt = xTaxAmt + (int)g.MeasureString("Tax(Amt)", Verdananormal).Width + 10;//10
            g.DrawString("Amount", Verdananormal, BlackBrush, 730, 288);

            // Set Invoice Table:
            CurrentY = CurrentY;
            g.DrawLine(new Pen(Brushes.Black, 1), 0, 288, 780, 288);
            //CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 1), 0, 311, 780, 311);
            //CurrentY = CurrentY + InvoiceFontHeight + 8;

            RowValidation(MainGrid);
            CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote; CurrentY = 315;

            for (int i = TRowcounting; i <= MainGrid.Rows.Count - 1; i++)
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

                       // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                        if (FieldValue.Length > 45)
                            FieldValue = FieldValue.Substring(0, 45);

                        if (CommonClass._settings.ReturnStatus("172") == "1")
                        {
                            ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                            FieldValue = FieldValue +"     "+ ItemNote;
                        }
                        else
                        {
                            ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemcode"].Value);
                        }

                        g.DrawString(FieldValue, xeroterms, BlackBrush, xProductName, CurrentY);


                        

                          //FieldValue =CommonClass._Itemmaster.SpecificField(Itemid,"")

                        //if(SSlnotracking==true)
                        //g.DrawString(ItemNote, Verdananormal, BlackBrush, xProductName, CurrentY + InvoiceFontHeight + 2);

                        string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();

                        //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "TaxCode");
                        // FieldValue = "";
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 50, CurrentY, Str);

                        if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                        {
                            //FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "TaxCode");
                            // FieldValue = "";
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 50, CurrentY, Str);
                        }
                       // FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "Taxcode").ToString();
                        // FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, 380, CurrentY);



                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                       // FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 360, CurrentY);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 535, CurrentY, Str);

                        //FieldValue = String.Format("{0:0}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clntaxperc"].Value));
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xDiscount + 30, CurrentY, Str);
                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 680, CurrentY, Str);

                        //if(wichtax=="GST")
                        //{
                        //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsgstperc"].Value));
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush,700, CurrentY, Str);
                        //}
                        //if(wichtax=="IGST")
                        //{
                        //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clnigstperc"].Value));
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush,700, CurrentY, Str);
                        //}
                    


                        if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                        {


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc + 30, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxAmt + 60, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxable + 60, CurrentY, Str);
                        }
                        //clnnettamount
                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, 775, CurrentY,Str);


                        CurrentY = CurrentY + InvoiceFontHeight +4 ;
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
                if (FormType.ToUpper() != "ESTIMATE" && FormType != "     SALES ORDER")
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
                
               // gridlining 
                CurrentY = CurrentY + 20;
                g.DrawLine(new Pen(Brushes.Black, 1), 1, CurrentY, 780, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 360, 288, 360, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 460, 288, 460, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 555, 288, 555, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 630, 288, 630, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 680, 288, 680, CurrentY);
                g.DrawLine(new Pen(Brushes.Black, 1), 57, 288, 57, CurrentY);
                CurrentY = CurrentY + 10;
                g.DrawString("Continue ...", HEADD, BlackBrush, 450, CurrentY);
                RecordsPerPage = 14;
                // gridlining 



                // TRowcounting = TRowcounting + 1;
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
            int RecordsPerPage =33 ; // twenty items in a page
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

                    ClsinvlaserNewafour Frms = new ClsinvlaserNewafour ();
                    int amount_int = (int)amount;
                    int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                    return convert(amount_int) + " and " +
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
                if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                {
                    //g.DrawString("Tax%  Tax          Taxable      NetAmount", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    //CurrentY = CurrentY + 16;
                    //g.DrawLine(new Pen(Brushes.Black, 1), 500, CurrentY, rightMargin, CurrentY);
                    //CurrentY = CurrentY + 16;
                    double TNetAmount;

                    //g.DrawString("TOTAL SGST :" + SGSTTAX, ArialnormalItalic, BlackBrush, 500, CurrentY);
                    CurrentY = CurrentY + 16;

                    //g.DrawString("TOTAL CGST :" + CGSTTAX, ArialnormalItalic, BlackBrush, 500, CurrentY);
                    CurrentY = CurrentY + 16;

                    //g.DrawString("TOTAL IGST :" + IGSTTAX, ArialnormalItalic, BlackBrush, 500, CurrentY);
                    CurrentY = CurrentY + 16;

                    if (Cess > 0)
                    {
                       // g.DrawString("TOTAL CESS :" + _Dbtask.SetintoDecimalpoint(Cess), ArialnormalItalic, BlackBrush, 500, CurrentY);
                        CurrentY = CurrentY + 16;
                    }
                }
                CurrentY = CurrentY + 16;
                //g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, 500, CurrentY+13);
                xTotalValue = 750 - (int)g.MeasureString(discprint, ArialnormalItalic).Width;


                //g.DrawString(discprint, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY + 13);

                if (FormType == "    RETAIL")
                {
                    CurrentY = CurrentY + 5;
                    double RECVVD =_Dbtask.znlldoubletoobject( CommonClass._Businessissue.SpecificField(Billno, "adamount").ToString());
                    SALERCAMT = RECVVD.ToString();

                   // g.DrawString("Received.AMT=", ArialnormalItalic, BlackBrush, 500, CurrentY-20);
                    xTotalValue = 750 - (int)g.MeasureString(SALERCAMT, ArialnormalItalic).Width;

                    //g.DrawString(SALERCAMT, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY-20);

                    double SALEBLNN = _Dbtask.znlldoubletoobject(BillAmount) - _Dbtask.znlldoubletoobject(SALERCAMT);
                    //SALEBLNCAMTT = SALEBLNN.ToString();

                    CurrentY = CurrentY + 5;
                   // g.DrawString("Balance.AMT=", ArialnormalItalic, BlackBrush, 500, CurrentY-10);
                    xTotalValue = 750 - (int)g.MeasureString(SALEBLNCAMTT, ArialnormalItalic).Width;

                    //g.DrawString(SALEBLNCAMTT, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY-10);
                }






                if (_Dbtask.znullDouble(Totherexpense) != 0)
                {
                    CurrentY = CurrentY + 16;
                    //g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                   // g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
                }

                CurrentY = CurrentY + 16;
                //g.DrawString("Bill Amount", ArialnormalItalic, BlackBrush, 500, CurrentY+11);
                xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), Arialbold, BlackBrush, xTotalValue, CurrentY+11);
            

            if (FormType != "     SALES ORDER")
            {
                string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                if (samplid == "18" && PrintOldbalance == true)
                {
                    CurrentY = CurrentY + 16;
                    //g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, 500, CurrentY+5);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                   // g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, xTotalValue, CurrentY+5);

                    CurrentY = CurrentY + 16;
                    //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, 500, CurrentY+10);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    double GrandTotal;

                    if (FormType != "SALES RETURN")
                        GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                    else
                        GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                    //g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, xTotalValue, CurrentY+10);
                }
            }

            CurrentY = CurrentY + 16;
        }


        public void PrintTotal(Graphics g)
        {
           // CurrentY = 750;
            //incolumn
            CurrentY = CurrentY + 3;
           //g.DrawLine(new Pen(Brushes.Black, 1), 715, CurrentY, 780, CurrentY);
            CurrentY = CurrentY + 15;

            //g.DrawString(_Dbtask.znlldoubletoobject(TgrossAmt).ToString(), VerdanaBold, BlackBrush, 720, CurrentY);
            //CurrentY = CurrentY + 18;
            //g.DrawString(" SGST ", ArLAST, BlackBrush, 200, CurrentY);
            //g.DrawString(CGSTTAX.ToString(), VerdanaBold, BlackBrush, 720, CurrentY);
            //CurrentY = CurrentY + 18;
            //g.DrawString(" CGST", ArLAST, BlackBrush, 200, CurrentY);
            //g.DrawString(SGSTTAX.ToString(), VerdanaBold, BlackBrush, 720, CurrentY);
            //CurrentY = CurrentY + 18;
            //g.DrawString("IGST", ArLAST, BlackBrush, 200, CurrentY);
            //g.DrawString(IGSTTAX.ToString(), VerdanaBold, BlackBrush, 720, CurrentY);
            //CurrentY = CurrentY + 18;
            //g.DrawString("Cess", ArLAST, BlackBrush, 200, CurrentY);
            //g.DrawString(Cess.ToString(), VerdanaBold, BlackBrush, 720, CurrentY);
            
            
            CurrentY = CurrentY + 15;
            //g.DrawString("Receved", ArLAST, BlackBrush, 200, CurrentY);
            //g.DrawString("ramt", VerdanaBold, BlackBrush, 720, CurrentY);
            
            CurrentY = CurrentY + 40;
            g.DrawLine(new Pen(Brushes.Black, 1), 0, CurrentY, 780, CurrentY);
            CurrentY = CurrentY +15;
            g.DrawString("Total", Arialbold, BlackBrush, 80, CurrentY);
         
            if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
            {
                g.DrawString(TotalQty, VerdanaBold, BlackBrush, 470, CurrentY);/*For Qty*///350
                //g.DrawString(TotalItemDisc.ToString(), VerdanaBold, BlackBrush, 490, CurrentY);/*For Discount*/
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 525, CurrentY);/*For Taxable*/
                //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 650, CurrentY);/*For Tax*/
            }
            else
            {
                g.DrawString(TotalQty, VerdanaBold, BlackBrush, 350 + 150, CurrentY);/*For Qty*/
            }
           // g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, 750, CurrentY);/*For Amount*/
            //BillAmount.ToString()
            g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 720, CurrentY);/*For Amount*/

            CurrentY = CurrentY + 20; int up = 288; int bot = CurrentY;
            g.DrawLine(new Pen(Brushes.Black, 1), 0, CurrentY, 780, CurrentY);

            Pen selpentot = new Pen(Color.Black);
            CurrentY = CurrentY;
            g.DrawRectangle(selpentot, 340, CurrentY, 440, 90); //
            g.DrawString("Taxable value  " , Verdananormal, BlackBrush, 340, CurrentY+2);
            g.DrawString("Value added tax 15% " , Verdananormal, BlackBrush, 340, CurrentY+20);
            g.DrawString("Bill Discount ", Verdananormal, BlackBrush, 340, CurrentY + 35);
            g.DrawString(_Dbtask.znllString( TotalTaxable), Verdananormal, BlackBrush, 780, CurrentY + 2,Str);
            g.DrawString(_Dbtask.znllString(TotalTaxAmount), Verdananormal, BlackBrush, 780, CurrentY + 20,Str);
            g.DrawString(_Dbtask.SetintoDecimalpoint( _Dbtask.znlldoubletoobject( TDiscount)), Verdananormal, BlackBrush, 780, CurrentY + 35, Str);



            g.DrawLine(new Pen(Brushes.Black, 1), 340, CurrentY + 60, 780, CurrentY + 60);
            g.DrawString("Invoice Total ", xerotermhead, BlackBrush, 340, CurrentY + 66);
            g.DrawString(BillAmount, xerotermhead, BlackBrush, 780, CurrentY + 66, Str);

            

            if(_Dbtask.znlldoubletoobject(TDiscount)>0)
            {
                //CurrentY = CurrentY + 10;
                //g.DrawString("Bill Discount:  " +_Dbtask.SetintoDecimalpoint( _Dbtask.znlldoubletoobject( TDiscount)), Verdananormal, BlackBrush, 10, CurrentY);

            }
            //grdln
            g.DrawLine(new Pen(Brushes.Black, 1), 360, 288, 360, bot);
            g.DrawLine(new Pen(Brushes.Black, 1), 460, 288, 460, bot);
            g.DrawLine(new Pen(Brushes.Black, 1), 555, 288, 555, bot);
            g.DrawLine(new Pen(Brushes.Black, 1), 620, 288, 620, bot);
            g.DrawLine(new Pen(Brushes.Black, 1), 680, 288, 680, bot);
            g.DrawLine(new Pen(Brushes.Black, 1), 57, 288, 57, bot);


            CurrentY = CurrentY+10;
            //R c t
            
            //if (InvSubTitle5 != "      ESTIMATE"&&InvSubTitle5!="           SALES ORDER")
            //{
            //    g.DrawString(TotalQty, VerdanaBold, BlackBrush, 370, CurrentY);/*For Qty*///350
            //    g.DrawString(TotalItemDisc.ToString(), VerdanaBold, BlackBrush, 490, CurrentY);/*For Discount*/
            //    g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 525, CurrentY);/*For Taxable*/
            //    g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 650, CurrentY);/*For Tax*/
            //}
            //else
            //{
            //    g.DrawString(TotalQty, VerdanaBold, BlackBrush, 350 + 150, CurrentY);/*For Qty*/
            //}

            //g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, 750, CurrentY);/*For Amount*/
            //CurrentY = CurrentY + 32;
        }
        private void SetInvoiceTotal(Graphics g)
        {// Set Invoice Total:
            // Draw line:
            //CurrentY = CurrentY + 8;
            string TotalValue;
            PrintTotal(g);
            // g.DrawLine(new Pen(Brushes.Black,1), leftMargin, CurrentY, rightMargin, CurrentY);

            // Get Right Edge of Invoice:

            Pen selpen = new Pen(Color.Black);
            CurrentY = CurrentY;
            g.DrawRectangle(selpen, 1, 762, 780, 300); //g.DrawRectangle(selpen, 5, 762, 850, 300);
            CurrentY = CurrentY + 7;

            AmountInWords _word = new AmountInWords();
            AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));


            string vatinwords = "";
            vatinwords = _word.ConvertAmount(_Dbtask.znlldoubletoobject(TotalTaxAmount));

            g.DrawString("Amount In chargeable(in words):" ,Verdananormal , BlackBrush, 15, 765);
            g.DrawString("E & O.E", Verdananormal, BlackBrush, 750, 769, Str);
            CurrentY = CurrentY + 10;
            g.DrawString(AmountinWords +"(SAR "+BillAmount+")", ArLAST, BlackBrush, 20, 779);
           
            //g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            
            CurrentY = 794;
            //g.DrawLine(new Pen(Brushes.Black, 1), 1, 794, 780, 794);
            g.DrawString("VAT Amount(in words):", Verdananormal, BlackBrush, 15, CurrentY+5);
            CurrentY = CurrentY + 15;
            g.DrawString(vatinwords + "(SAR " + _Dbtask.znllString(TotalTaxAmount) + ")", ArLAST, BlackBrush, 20, CurrentY);
           
            g.DrawLine(new Pen(Brushes.Black, 1), 1, 825, 780, 825);
            int xRightEdg = AmountPosition + (int)g.MeasureString("Amount", Arialbold).Width;

            //  g.DrawLine(new Pen(Brushes.Black, 1), xRightEdg + 7, 100, xRightEdg + 7, 1050);

            // Write Sub Total:
            int xSubTotal = AmountPosition - (int)g.MeasureString("Gross", Arialbold).Width;
            //CurrentY = CurrentY + 8;
            int Crss = 794; int secH = 812; 
           // CurrentY = CurrentY + 45;
           // g.DrawLine(new Pen(Brushes.Black, 1), 1,839, 780, 839);
           // g.DrawLine(new Pen(Brushes.Black, 1), 400, secH, 780, secH);
           // g.DrawLine(new Pen(Brushes.Black, 1), 530, secH, 530, 905);
           // g.DrawLine(new Pen(Brushes.Black, 1), 680, secH, 680, 905);

            
           // CurrentY = CurrentY + 23;
           // g.DrawLine(new Pen(Brushes.Black, 1), 1, 862, 780, 862);
           // CurrentY = CurrentY + 23;
           // g.DrawLine(new Pen(Brushes.Black, 1), 1, 885, 780, 885);
           // g.DrawLine(new Pen(Brushes.Black, 1), 1, 905, 780, 905);

           // int Crss2 = 905;
           // g.DrawLine(new Pen(Brushes.Black, 1), 200, Crss, 200, Crss2);
           // g.DrawLine(new Pen(Brushes.Black, 1), 400, Crss, 400, Crss2);
           // g.DrawLine(new Pen(Brushes.Black, 1), 600, Crss, 600, Crss2);
           // //g.DrawLine(new Pen(Brushes.Black, 1), 650, Crss, 700, Crss2);
           // //g.DrawLine(new Pen(Brushes.Black, 1), 750, Crss, 750, Crss2);
           ////DATA
           // double valuess = 0;
           // g.DrawString("Rate", Verdananormal, BlackBrush, 400, 820);
           // g.DrawString("Rate", Verdananormal, BlackBrush, 630, 820);
           // g.DrawString("Amount", Verdananormal, BlackBrush, 535, 820);
           // g.DrawString("Amount", Verdananormal, BlackBrush, 720, 820);
            
           // g.DrawString("HSN/SAC", Verdananormal, BlackBrush, 20, 820);
           // g.DrawString("Taxable value", Verdananormal, BlackBrush, 200, 820);
           // g.DrawString("Central tax", Verdananormal, BlackBrush, 400, 795);
           // g.DrawString("State tax", Verdananormal, BlackBrush, 660, 795);
           // g.DrawString(_Dbtask.znlldoubletoobject(TgrossAmt).ToString(), ArLAST, BlackBrush, 200, 840);

           // if(fper!="")
           // {
           //     g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(fper)).ToString() + " %", Verdananormal, BlackBrush, 415, 840);
           // g.DrawString(fv.ToString(), Verdananormal, BlackBrush, 535, 840);
           // g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(fper)).ToString() + " %", Verdananormal, BlackBrush, 630, 840);
           // g.DrawString(fv.ToString(), Verdananormal, BlackBrush, 700, 840);
           
           // }
           // if (f2per != "")
           // {
           //     g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(f2per)).ToString()+" %", Verdananormal, BlackBrush, 415, 860);
           //     g.DrawString(fv1.ToString(), Verdananormal, BlackBrush, 535, 864);
           //     g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(f2per)).ToString() + " %", Verdananormal, BlackBrush, 630, 860);
           //     g.DrawString(fv1.ToString(), Verdananormal, BlackBrush, 700, 864);

           // }
           // if (f3per!= "")
           // {
           //     g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(f3per)).ToString() + " %", Verdananormal, BlackBrush, 415, 885);
           //     g.DrawString(fv2.ToString(), Verdananormal, BlackBrush, 535, 885);
           //     g.DrawString(_Dbtask.SetintoDecimalpoint(_Dbtask.znlldoubletoobject(f3per)).ToString() + " %", Verdananormal, BlackBrush, 630, 885);
           //     g.DrawString(fv2.ToString(), Verdananormal, BlackBrush, 700, 885);

           // }

           // g.DrawRectangle(selpen, 1, 930, 780, 960);
           // g.DrawLine(new Pen(Brushes.Black, 1), 500, 905, 500, 930);
           // string head = "SGST + CGST :";
           // if (IGSTTAX > 0)
           // {
           //     head = "IGST  :";
           // }


           // g.DrawString(head.ToString() + TotalTaxAmount.ToString(), VerdanaBold, BlackBrush, 10, 910);
           // g.DrawString("Total CESS :  " +Cess.ToString() , VerdanaBold, BlackBrush, 610, 910);
           // g.DrawLine(new Pen(Brushes.Black, 1), 5, 960, 780, 960);
           // g.DrawString(" Bill Dis.Amount :  " +alldisc.ToString() , VerdanaBold, BlackBrush, 10, 940);
           // g.DrawLine(new Pen(Brushes.Black, 1), 250, 930, 250, 960);
           // g.DrawString("Received:  " + recevdamtt.ToString(), VerdanaBold, BlackBrush, 255, 940);
            
           // g.DrawLine(new Pen(Brushes.Black, 1), 500, 930, 500, 960);
           // g.DrawString(" TOTAL :  " + BillAmount.ToString(), VerdanaBold, BlackBrush, 610, 940);
            //grdlin


            g.DrawString("Declaration", VerdanaBold, BlackBrush, 10, 830);//975
            g.DrawString("-----------", VerdanaBold, BlackBrush, 10, 836);//980
            g.DrawString("We declare that this invoice shows the actual price of the", Verdananormal, BlackBrush, 10, 847);//990
            g.DrawString("goods describes and that all particulars are true and", Verdananormal, BlackBrush, 10, 857);//1000
            g.DrawString("correct.", Verdananormal, BlackBrush, 10, 867);//1010
            CurrentY = 867 + 20;
            g.DrawString("Narration :  " + billnote.ToString(), xeroterms, BlackBrush, 10, CurrentY);

            if (CommonClass._Menusettings.GetMnustatus("9000") == "1")
            {
                setqrtwo(g);
            }
            
            
            //Bnk
            //g.DrawString("Bank Details ", VerdanaBold, BlackBrush, 260, 960);
            //g.DrawString("Bank Holder Name : MALABAR SOUNDS", VerdanaBold, BlackBrush, 260, 980);
            //g.DrawString("Bank Name :  FEDERAL BANK", VerdanaBold, BlackBrush, 260, 1005);
            //g.DrawString("Account no. : 20730200000816", VerdanaBold, BlackBrush, 260, 1025);
            //g.DrawString("Branch& IFC Code : MAKKARAPARAMBA& FDRL0002073", VerdanaBold, BlackBrush, 260, 1045);
            g.DrawString(InvTitle, VerdanaBold, BlackBrush, 640, 1030);
            g.DrawString("Authorised Signatory ", VerdanaBold, BlackBrush, 640, 1045);
            g.DrawString("[With staus& Seal]", Verdananormal, BlackBrush, 650, 1064);
            //Bnk

            VatPrinting(g);

            if (FormType == "WHOLESALE" || FormType == "SALES RETURN" || FormType == "DELIVERY NOTE"  || FormType == "Purchase Return")
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
            //TotalValue = "Autherised Signatory";
            //CurrentY = CurrentY - 14;
            ////g.DrawString(TotalValue, Arialbold, BlackBrush, 600, CurrentY);
            //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
            //TotalValue = "  [With Status&Seal]";
            //g.DrawString(TotalValue, Arialnormal, BlackBrush, 600, CurrentY);

            if(Pfooter!="")
                //g.DrawString(Pfooter, Arialbold, BlackBrush, 100, CurrentY);

            if (FormType != "ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
            {
               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Details:";
               //// g.DrawString(TotalValue, Arialbold, BlackBrush, 100, CurrentY);

               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Holder name:" + _Companymaster.GetspecifField("Bankdetails");
               // //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);

               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Name : " + _Companymaster.GetspecifField("bankname");
               // //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Branch : " + _Companymaster.GetspecifField("bankbranch");
               // //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Account Number : " + _Companymaster.GetspecifField("aCCOUNTNO");
               // //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


               // CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
               // TotalValue = "Bank Branch IFSC   :" + _Companymaster.GetspecifField("IFSC");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);
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
            //string totamtt = grandamtt.ToString();
            StrQrData = _Gen.FureturnQrValue(_Companymaster.GetspecifField("Sellersname"), _Companymaster.GetspecifField("TRN"), Billno, BillDate, Ttaxamount, BillAmount); options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 110,
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
            g.DrawImage(newbit, (15), 930);//800 x180
            g.DrawLine(new Pen(Brushes.Black, 1), 0,940, 780, 940);

            g.DrawLine(new Pen(Brushes.Black, 1), 120, 940, 120, 1060);
            g.DrawString("Customer's seal and signature", Declarationfont, BlackBrush, 130, 940);
            g.DrawString("For all enterprises", Declarationfont, BlackBrush,780, 940,Str);

            g.DrawLine(new Pen(Brushes.Black, 1), 480, 940, 480, 1060);
            //g.DrawLine(new Pen(Brushes.Black, 1), 0, 1050, 780, 1050);
            //CurrentY = CurrentY + 100;

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

                if(FormType.ToUpper()=="ESTIMATE")
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
                if (PrintHeader == true)
                {
                    SetInvoiceHead(e.Graphics); // Draw Invoice Head
                }
                    SetOrderData(e.Graphics); // Draw Order Data
                SetInvoiceData(e.Graphics, e); // Draw Invoice Data
                Lid = "";
                ReadInvoice = true;
            }
            else
            {
                SetInvoiceData(e.Graphics, e); // Draw Invoice Data
            }
        }
    }
}
