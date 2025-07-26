using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class ClsinvlaserSimpleTwo
    {
        public bool PrintBarcodeLaser;
        /*For Settings*/
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

        public string Timeperiod = "";
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
        private Font Arialbold = new Font("Arial", 10, FontStyle.Bold);
        // Title Font height

        private Font fntnote = new Font("Monotype Corsiva", 11, FontStyle.Italic);
        
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        // private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        //private Font InvoiceFont = new Font("Calibri", 12, FontStyle.Regular);
        private Font VerdanaBoldHeading = new Font("Verdana", 12, FontStyle.Bold);
        private Font VerdanaBold = new Font("Verdana", 8, FontStyle.Bold);
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
                InvSubTitle5 = "       " + FormType + " INVOICE";
            }
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
            bool head = false;
            CurrentX = leftMargin;
            int ImageHeight = 0;
            InvImage = Application.StartupPath + @"\Images\" + "InvPicHeader.jpg";
            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage))
            {
                head = true;

                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, 10,5,750,100);
                CurrentY = CurrentY + 60;
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
            if (InvSubTitle3 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales")/*For Company Heading*/
            {
                //g.DrawString("VAT:", Arialnormal, BlackBrush, 50, CurrentY / 2);/*For Tin*/
                //g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 100, CurrentY / 2);/*CST Reg No*/

            }
            else
            {
                RecordsPerPage = 40;
            }
            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            if (Cst != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales")/*For Company Heading*/
            {
                //g.DrawString("CST", Arialnormal, BlackBrush, 600, CurrentY / 2);/*For CST Reg No*/

                //g.DrawString(Cst, Arialbold, BlackBrush, 650, CurrentY / 2);/*CST Reg No*/
            }
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/

            if (InvTitle != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")/*For Company Heading*/
            {
                //CurrentY = CurrentY + ImageHeight;
                //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, xInvTitle, CurrentY);
                //CurrentY = CurrentY + 5;
            }
            if (InvSubTitle1 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")/*For Address*/
            {
                //CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, xInvSubTitle1, CurrentY);
                //CurrentY = CurrentY + 5;
            }

            if (InvSubTitle11 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")/*For Address2*/
            {
                //CurrentY = CurrentY + InvTitleHeight;
                //g.DrawString(InvSubTitle11, VerdanaBold, BlackBrush, xInvSubTitle11, CurrentY);
                //CurrentY = CurrentY + 5;
            }
            if (InvSubTitle2 != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")/*For Phone*/
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, xInvSubTitle2, CurrentY);
                //CurrentY = CurrentY + 5;
            }
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
            if (FormType == "AccountReport" ||FormType =="Sales"||FormType =="Purchase")
            {
                if(head == false)
                {
                CurrentY = 10;

                string NameInHome = _Companymaster.GetspecifField("NameInHome");

                if (InvTitle != "")
                {
                    g.DrawString(InvTitle, VerdanaBold, BlackBrush, 300, CurrentY);
                    CurrentY = CurrentY + 23;
                }
                if (NameInHome != "")
                {
                    g.DrawString(NameInHome, VerdanaBold, BlackBrush, 300, CurrentY);
                    CurrentY = CurrentY + 23;
                }
                if (InvSubTitle1 != "")
                {
                    g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, 300, CurrentY);
                    CurrentY = CurrentY + 23;

                }
                if (InvSubTitle3 != "")
                {
                    g.DrawString("VAT: " + InvSubTitle3, VerdanaBold, BlackBrush, 300, CurrentY);
                    CurrentY = CurrentY + 23;

                }
                }


            }
            if (FormType == "AccountReport"  )
            {
                g.DrawString(FormType, VerdanaBold, BlackBrush, 300, CurrentY);
                CurrentY = CurrentY + 23;

                
            }


            if (InvSubTitle5 != "" && FormType != "Sales" && FormType != "Purchase")/*For InVoiceName*/
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 300, CurrentY);
                //CurrentY = CurrentY + 5;

                if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
                {
                    //CurrentY = CurrentY + InvSubTitleHeight;
                    //g.DrawString("    " + ModeofPayment, Arialnormal, BlackBrush, 350, CurrentY);
                    //CurrentY = CurrentY + 5;
                }

                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString("(To be Prepared in Duplicate)", Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle6 != "" && FormType == "Multi" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle6, Verdananormal, BlackBrush, 300, CurrentY);
            }
            if (InvSubTitle7 != "" && FormType == "Multi" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle7, Verdananormal, BlackBrush, 300, CurrentY);
            }
            // Draw line:
            //CurrentY = CurrentY + InvSubTitleHeight + 8;
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
           CurrentY = CurrentY + 10;
            string CName = TempCust;
            string mob = "";
            string Address = _Accountledger.GetspecifField("address", Lid);

            string CTin = _Accountledger.GetspecifField("Taxregno", Lid);

            

            int CCount = Address.Split('\n').Length - 1;

            FieldValue = "";
            if (Lid != "")
            {
               // CurrentY = CurrentY + 10;
                FieldValue = _Accountledger.GetspecifField("lname", Lid);
                 CTin = _Accountledger.GetspecifField("Taxregno", Lid);
                 mob = _Accountledger.GetspecifField("mobile", Lid);
                 if (CTin == "0.00")
                 {
                     CTin = "  ";
                 }
                CurrentY = CurrentY + 15;
                g.DrawString("Name : " + FieldValue, VerdanaBold, BlackBrush, 10, CurrentY );
                CurrentY = CurrentY + 10;
                g.DrawString("Mobile : " + mob, VerdanaBold, BlackBrush, 10, CurrentY);
                CurrentY = CurrentY + 10;
                g.DrawString("VAT : " + CTin, VerdanaBold, BlackBrush, 10, CurrentY );

                CurrentY = CurrentY + 10;
                Address = _Accountledger.GetspecifField("address", Lid);
                g.DrawString("Address : " + Address, VerdanaBold, BlackBrush, 10, CurrentY );
                CurrentY = CurrentY + 20;
                
               
            }
            CurrentY = CurrentY + 20;
            g.DrawString("Time Period : " + Timeperiod, VerdanaBold, BlackBrush, 150, CurrentY);
            CurrentY = CurrentY + 23;
            
            
            if (FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //FieldValue = "INVOICE NO: ";
                //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX, CurrentY);
                 

                //FieldValue = "Date: ";
                //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 600, CurrentY);
                //g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, CurrentX + 640, CurrentY);

                //CurrentY = CurrentY + InvoiceFontHeight * 2;

                

                if (SProject == true)
                {
                    Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
                }

                //FieldValue = "Customer :" + CName;
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);

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
                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY + 15 * kk);
                //kk++;
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
            }
            if (FormType == "WHOLESALE" || FormType == "Purchase Return" || SProject == false && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //FieldValue = "TRN";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight;
            }
            if (FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //FieldValue = "Mobile";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
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
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);


            //CurrentY = CurrentY + InvoiceFontHeight;
            // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
            if (FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //FieldValue = "Phone";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //FieldValue = _Accountledger.GetspecifField("phone", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
                //CurrentY = CurrentY + InvoiceFontHeight;
            }
            if (FormType == "WHOLESALE" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
                //FieldValue = "CST";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
                //FieldValue = _Accountledger.GetspecifField("cst", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            }
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
                    if (FormType != "Itemsreport" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
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
                    if (FormType == "Sales" || FormType == "Purchase")
                    {
                        if (gridmain.Rows[i].Cells["Date"].Value== null || gridmain.Rows[i].Cells["Date"].Value == "")
                        {
                           gridmain.Rows[i].Tag = -1;
                        }
                        else
                        {
                          gridmain.Rows[i].Tag = 1;
                        }
                    }

                    if (FormType == "AccountReport")
                    {
                        gridmain.Rows[i].Tag = 1;
                    }
                }

            }
            catch
            {
            }
        }

        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set Invoice Table:
            string FieldValue = "";
            int CurrentRecord = 0;
            int Xcode = new int();
            decimal Amount = 0;
            bool StopReading = false;
            double SUmNetAmt = 0;
            double SumSrate = 0;

            double credit = 0;
            double debit = 0;
            double dbandcr = 0;

            // Set Table Head:
            int xSlno = leftMargin + 10;
            //CurrentY = CurrentY ;
            CurrentY = CurrentY + 20;
            //g.DrawString("Rate", Verdananormal, BlackBrush, xSlno, CurrentY);
            int xProductName = new int();

            int xRate;
            if (FormType == "Sales"|| FormType == "Purchase")
            {
                RecordsPerPage = 45;
                //CurrentY = 130;
                g.DrawString( FormType + "  Report  ", VerdanaBoldHeading, BlackBrush, 300, CurrentY);      //Qty
                CurrentY = CurrentY + 30;
                xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                g.DrawString("Date", VerdanaBold, BlackBrush, 10, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("vno", VerdanaBold, BlackBrush, 100, CurrentY);      //Qty
                
                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("Customer", VerdanaBold, BlackBrush, 230, CurrentY);      //Qty
                
                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("QTY", VerdanaBold, BlackBrush, 450, CurrentY);      //Qty

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("Tax", VerdanaBold, BlackBrush, 530, CurrentY);      //Qty

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("Gross", VerdanaBold, BlackBrush, 610, CurrentY);      //Qty

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("NetAMT", VerdanaBold, BlackBrush, 750, CurrentY, Str);      //Qty
                CurrentY = CurrentY + 20;
                g.DrawLine(new Pen(Brushes.Gray, 1), 0, CurrentY, 750, CurrentY);
            }

            if (FormType == "AccountReport")
            {
                xProductName = xSlno + (int)g.MeasureString("SlN", VerdanaBold).Width;
                g.DrawString("Date", VerdanaBold, BlackBrush, 50, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("vno", VerdanaBold, BlackBrush, 300, CurrentY);      //Qty
                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("vtype", VerdanaBold, BlackBrush, 450, CurrentY);      //Qty
                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("Amount", VerdanaBold, BlackBrush, 600, CurrentY, Str);      //Qty

                xQty = xProductName + (int)g.MeasureString("Note", VerdanaBold).Width + 50;
                g.DrawString("Balance", VerdanaBold, BlackBrush, 750, CurrentY, Str);      //Qty
                CurrentY = CurrentY + 20;
                g.DrawLine(new Pen(Brushes.Gray, 1), 0, CurrentY, 750, CurrentY);
            }
            if (FormType == "Sales" || FormType == "Purchase")
            {
              CurrentY = CurrentY + 20;
             for (int i = TRowcounting; i <= MainGrid.Rows.Count - 1; i++)
              {

                  if (_Dbtask.znllString(MainGrid.Rows[i].Cells["Date"].Value) != "" && MainGrid.Rows[i].Cells["NetAmount"].Value != null)
                  {
                      if (TempRowcounting < RecordsPerPage)
                      {

                          double qty = 0; double amt = 0; double tax = 0; double net = 0;

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Date"].Value);
                          FieldValue = FieldValue.Substring(0, 10);
                          g.DrawString(FieldValue, Verdananormal, BlackBrush, 10, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["VNo"].Value);
                          g.DrawString(FieldValue, Verdananormal, BlackBrush, 100, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Party"].Value);
                          if (FieldValue.Length < 50)
                          {
                              FieldValue = FieldValue;
                          }
                          else
                          {
                              FieldValue = FieldValue.Substring(0, 40);
                          }
                          g.DrawString(FieldValue, Verdananormal, BlackBrush, 170, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Qty"].Value);
                          qty = _Dbtask.znullDouble(FieldValue);
                          g.DrawString(_Dbtask.SetintoDecimalpoint(qty), Verdananormal, BlackBrush, 430, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Taxamt"].Value);
                          tax = _Dbtask.znullDouble(FieldValue);

                          
                          g.DrawString(_Dbtask.SetintoDecimalpoint(tax), Verdananormal, BlackBrush, 560, CurrentY, Str);

                          if (FormType == "Purchase")
                          {
                              FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Gross"].Value);
                          }
                          else
                          {
                              FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Amount"].Value);
                          }
                          amt = _Dbtask.znullDouble(FieldValue);
                          //FieldValue = _Dbtask.SetintoDecimalpoint(amt)//.ToString();
                          g.DrawString(_Dbtask.SetintoDecimalpoint(amt), Verdananormal, BlackBrush, 660, CurrentY, Str);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["NetAmount"].Value);
                          net = _Dbtask.znullDouble(FieldValue);
                          //FieldValue = _Dbtask.SetintoDecimalpoint(net).ToString();
                          g.DrawString(_Dbtask.SetintoDecimalpoint(net), Verdananormal, BlackBrush, 750, CurrentY, Str);



                          CurrentY = CurrentY + 15;
                          CurrentRecord = CurrentRecord + 1;
                          TRowcounting = i;
                          TempRowcounting = TempRowcounting + 1;
                      }




                  }
                  else
                  {
                      if (_Dbtask.znllString(MainGrid.Rows[i].Cells["Date"].Value) == "" &&MainGrid.Rows[i].Cells["NetAmount"].Value != null)
                      {
                          double qty = 0; double amt = 0; double tax = 0; double net = 0;
                          CurrentY = CurrentY + 25;
                          g.DrawLine(new Pen(Brushes.Gray, 1), 0, CurrentY, 750, CurrentY);

                          CurrentY = CurrentY + 25;
                          g.DrawString("Total ", VerdanaBold, BlackBrush, 10, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Qty"].Value);
                          qty = _Dbtask.znullDouble(FieldValue);
                          g.DrawString(_Dbtask.SetintoDecimalpoint(qty), VerdanaBold, BlackBrush, 430, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Taxamt"].Value);
                          tax = _Dbtask.znullDouble(FieldValue);
                          g.DrawString(_Dbtask.SetintoDecimalpoint(tax), VerdanaBold, BlackBrush, 490, CurrentY);

                          if (FormType == "Purchase")
                          {
                              FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Gross"].Value);
                          }
                          else
                          {
                              FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["Amount"].Value);
                          }
                          amt = _Dbtask.znullDouble(FieldValue);
                          //FieldValue = _Dbtask.SetintoDecimalpoint(amt)//.ToString();
                          g.DrawString(_Dbtask.SetintoDecimalpoint(amt), VerdanaBold, BlackBrush, 600, CurrentY);

                          FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["NetAmount"].Value);
                          net = _Dbtask.znullDouble(FieldValue);
                          //FieldValue = _Dbtask.SetintoDecimalpoint(net).ToString();
                          g.DrawString(_Dbtask.SetintoDecimalpoint(net), VerdanaBold, BlackBrush, 750, CurrentY, Str);




                      }
                  }





              }
            }
            if (CurrentRecord < RecordsPerPage)
            {
                //if (FormType.ToUpper() != "ESTIMATE")
                //{
                //    CurrentRecord = CurrentRecord + 10;
                //    e.HasMorePages = false;
                //    for (int i = CurrentRecord; i < RecordsPerPage; i++)
                //    {
                //        g.DrawString("", Verdananormal, BlackBrush, AmountPosition, CurrentY);
                //        CurrentY = CurrentY + InvoiceFontHeight;
                //    }
                //}
            }
            else
            {
                e.HasMorePages = true;
                TempRowcounting = 0;
                TRowcounting = TRowcounting + 1;
                // TRowcounting = TRowcounting + 1;
            }




            if (FormType == "AccountReport")
            {
                RecordsPerPage = 15;
                CurrentY = CurrentY + 20;
                for (int i = TRowcounting; i <= MainGrid.Rows.Count - 1; i++)
                {
                   

                    if (TempRowcounting < RecordsPerPage)
                    {
                        if (MainGrid.Rows[i].Cells["clndate"].Value != null && MainGrid.Rows[i].Cells["clndate"].Value != "Ledger")
                        {
                            string notess = "";
                            FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clndate"].Value);
                            if (FieldValue != "")
                            {
                                FieldValue = MainGrid.Rows[i].Cells["clndate"].Value.ToString();
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 50, CurrentY);

                            
                            
                            }

                            FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clndue"].Value);
                            CurrentY = CurrentY + 15;
                                //FieldValue = MainGrid.Rows[i].Cells["clndue"].Value.ToString();
                            if (_Dbtask.znllString(MainGrid.Rows[i].Cells["clndate"].Value) != "Date wise Balance" && _Dbtask.znllString(MainGrid.Rows[i].Cells["clndate"].Value) != "Balance")
                               {
                            
                            g.DrawString("Due: "+FieldValue, fntnote, BlackBrush, 50, CurrentY);

                               }

                            


                            notess = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnnotes"].Value);

                            if (notess != "")
                            {
                                FieldValue = MainGrid.Rows[i].Cells["clnnotes"].Value.ToString();
                                g.DrawString("Note : " + FieldValue, fntnote, BlackBrush, 200, CurrentY);
                               
                            }

                            FieldValue = " ";
                            //FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnpurticulars"].Value);
                            //if (FieldValue != "")
                            //{

                            //    g.DrawString(FieldValue, Verdananormal, BlackBrush, 100, CurrentY);
                            //}
                            FieldValue = " ";

                            FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnvtype"].Value);

                            if (FieldValue != "")
                            {
                                FieldValue = MainGrid.Rows[i].Cells["clnvtype"].Value.ToString();
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 450, CurrentY);
                            }
                            FieldValue = " ";

                            FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnvno"].Value);
                            if (FieldValue != "")
                            {
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 300, CurrentY);
                            }

                            FieldValue = " ";
                            debit = _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clndebit"].Value);
                            credit = _Dbtask.znlldoubletoobject(MainGrid.Rows[i].Cells["clncredit"].Value);
                            dbandcr = (debit + credit);
                            FieldValue = _Dbtask.SetintoDecimalpoint(dbandcr).ToString();


                            //FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clndebit"].Value);
                            //if (FieldValue != "")
                            //{
                            //    g.DrawString(FieldValue, Verdananormal, BlackBrush, 450, CurrentY);
                            //}

                            //FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clncredit"].Value);
                            //if (FieldValue != "")
                            //{
                            //    g.DrawString(FieldValue, Verdananormal, BlackBrush, 570, CurrentY);
                            //}
                            //FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnbalance"].Value);
                            if (FieldValue != "")
                            {
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, 600, CurrentY, Str);
                                FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnbalance"].Value);
                                if (FieldValue != "")
                                {
                                    g.DrawString(FieldValue, Verdananormal, BlackBrush, 750, CurrentY, Str);
                                    SUmNetAmt = _Dbtask.znlldoubletoobject(FieldValue);
                                }
                            }
                            string lie = "---------------------------------------------------------------------------------------------------------------------------------------------------------------";
                            CurrentY = CurrentY + 8;
                            g.DrawString(lie, Verdananormal, BlackBrush, 0, CurrentY);
                            CurrentY = CurrentY + 10;
                        }
                        if (MainGrid.Rows[i].Cells["clndate"].Value == "Ledger")
                        {
                            FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnpurticulars"].Value);
                            if (FieldValue != "")
                            {



                                //g.DrawString(FieldValue, VerdanaBold, BlackBrush, 100, CurrentY - 100);

                               
                            }
                        }

                        StopReading = true;

                        CurrentRecord = CurrentRecord + 1;
                        TRowcounting = i;
                        TempRowcounting = TempRowcounting + 1;

                    }
                }

                if (CurrentRecord < RecordsPerPage)
                {
                    if (FormType.ToUpper() != "ESTIMATE")
                    {
                        //CurrentRecord = CurrentRecord + 10;
                        e.HasMorePages = false;
                        for (int i = CurrentRecord; i < RecordsPerPage; i++)
                        {
                            g.DrawString("", Verdananormal, BlackBrush, AmountPosition, CurrentY);
                            CurrentY = CurrentY + InvoiceFontHeight;
                        }
                        TRowcounting = 0;
                        TempRowcounting = 0;
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

                       // SetInvoiceTotal(g);
                    }
                }


                // CurrentY = CurrentY + 20;
                //g.DrawLine(new Pen(Brushes.Black, 1), 0, CurrentY, 250, CurrentY);
                CurrentY = CurrentY + 8;
                string which = "";
                if (SUmNetAmt>0)
                {
                    which = "(Debit)";
                }
                else
                {
                    SUmNetAmt = SUmNetAmt * (-1);
                    which = "(Credit)";
                }


                g.DrawString("Balance" + " " + which, VerdanaBold, BlackBrush, 500, CurrentY);
                g.DrawString(SUmNetAmt.ToString(), VerdanaBold, BlackBrush, 750, CurrentY, Str);

            }
            if (FormType == "OutstandingReportsummery")
            {
                //g.DrawString("Slno", Verdananormal, BlackBrush, 10, CurrentY);
                g.DrawString("Name", Verdananormal, BlackBrush, 50, CurrentY);

                g.DrawString("Contact", Verdananormal, BlackBrush, 300, CurrentY);

                g.DrawString("Code", Verdananormal, BlackBrush, 450, CurrentY);

                g.DrawString("Amount", Verdananormal, BlackBrush, 650, CurrentY);

            }




            if (InvSubTitle5 != "      ESTIMATE" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {

                xProductName = xSlno + (int)g.MeasureString("code", Verdananormal).Width + 4;
                g.DrawString("Qty", Verdananormal, BlackBrush, xProductName, CurrentY);



                xQty = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 50;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xQty, CurrentY);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 20;//10
                g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);

                //xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                //g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);


                //xTaxable = xDiscount + (int)g.MeasureString("Disc", Verdananormal).Width + 30;//25
                //g.DrawString("Taxable(Amt)", Verdananormal, BlackBrush, xTaxable, CurrentY);

                //xTaxperc = xTaxable + (int)g.MeasureString("Taxable(Amt)", Verdananormal).Width + 10;//10
                //g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxperc, CurrentY);

                //xTaxAmt = xTaxperc + (int)g.MeasureString("Tax%", Verdananormal).Width;
                //g.DrawString("Tax(Amt)", Verdananormal, BlackBrush, xTaxAmt, CurrentY);
            }
            else
            {
                //510
                //602
                //638

                if (FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
                {
                xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width + 430;
                g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 10;
                g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);

                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 25;
                g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);
                
                }
            }


            xNetamt = 200;

            if (InvSubTitle5 != "       OutstandingReportsummery INVOICE" && FormType != "Itemsreport" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
            g.DrawString("Amount", Verdananormal, BlackBrush, 250, CurrentY);
            }
            // Set Invoice Table:
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, 750, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, 750, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight + 8;

            RowValidation(MainGrid);
            CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote;
            if (FormType != "Itemsreport" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
            {
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

                            // MainGrid.Columns["clnitemname"].DefaultCellStyle.Font = new System.Drawing.Font("Kerala Lite", 10F);
                            if (FieldValue.Length > 45)
                                FieldValue = FieldValue.Substring(0, 45);
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xProductName, CurrentY);
                            ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemcode"].Value);

                            if (SSlnotracking == true)
                                g.DrawString(ItemNote, Verdananormal, BlackBrush, xProductName, CurrentY + InvoiceFontHeight + 2);

                            string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();
                            FieldValue = CommonClass._Itemmaster.SpecificField(Itemid, "unit");
                            FieldValue = "";
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty - 25, CurrentY, Str);


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnqty"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty + 20, CurrentY, Str);


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnsrate"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xQty + 50, CurrentY, Str);

                            FieldValue = String.Format("{0:0}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clndiscount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, xDiscount + 30, CurrentY, Str);




                            if (InvSubTitle5 != "      ESTIMATE" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
                            {


                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc + 30, CurrentY, Str);

                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxAmt + 50, CurrentY, Str);

                                FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                                g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxable + 60, CurrentY, Str);
                            }

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, 800, CurrentY, Str);


                            CurrentY = CurrentY + InvoiceFontHeight + 4;
                            // * 2+4

                            StopReading = true;

                            CurrentRecord = CurrentRecord + 1;
                            TRowcounting = i;
                            TempRowcounting = TempRowcounting + 1;
                        }
                    }


                }
            }

            if (CurrentRecord < RecordsPerPage)
            {
                //if (FormType.ToUpper() != "ESTIMATE")
                //{
                //    CurrentRecord = CurrentRecord + 10;
                //    e.HasMorePages = false;
                //    for (int i = CurrentRecord; i < RecordsPerPage; i++)
                //    {
                //        g.DrawString("", Verdananormal, BlackBrush, AmountPosition, CurrentY);
                //        CurrentY = CurrentY + InvoiceFontHeight;
                //    }
                //}
            }
            else
            {
                  if (FormType != "AccountReport") 
                {
                e.HasMorePages = true;
                TempRowcounting = 0;
                TRowcounting = TRowcounting + 1;

            }
                // TRowcounting = TRowcounting + 1;
            }
            if (e.HasMorePages == false)//StopReading &&
            {
                //rdrInvoice.Close();
                //cnn.Close();
                if (TempRowcounting > RecordsPerPage - 16 && ValidRecord > RecordsPerPage - 16)
                {
                    if (FormType != "AccountReport")
                    {
                        e.HasMorePages = true;
                        TempRowcounting = 0;
                        TRowcounting = TRowcounting + 1;
                    }
                }
                else
                {
                    if (FormType != "Itemsreport" && FormType != "AccountReport" && FormType != "Sales" && FormType != "Purchase")
                    {

                        SetInvoiceTotal(g);
                    }
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

                    ClsinvlaserSimpleTwo Frms = new ClsinvlaserSimpleTwo();
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
                g.DrawString(StrNaration.Substring(0, 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                g.DrawString(StrNaration.Substring(55, StrNaration.Length - 55), ArialnormalItalic, BlackBrush, CurrentX, CurrentY + 15);
            }
            else
            {
                g.DrawString(StrNaration, ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
            }
            if (InvSubTitle5 != "      ESTIMATE")
            {
                g.DrawString("Tax%  Tax          Taxable      NetAmount", ArialnormalItalic, BlackBrush, 500, CurrentY);
                CurrentY = CurrentY + 16;
                g.DrawLine(new Pen(Brushes.Black, 1), 500, CurrentY, rightMargin, CurrentY);
                CurrentY = CurrentY + 16;
                double TNetAmount;
                if (Clstax.ZeroPercTaxableAmount > 0)
                {
                    TNetAmount = CalcTaxAmount(Clstax.ZeroPercTaxAmount, Clstax.ZeroPercTaxableAmount);

                    g.DrawString("0", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    g.DrawString(Clstax.ZeroPercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.ZeroPercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);

                    CurrentY = CurrentY + 16;
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
                    TNetAmount = CalcTaxAmount(Clstax.FivePercTaxAmount, Clstax.FivePercTaxableAmount);
                    g.DrawString("5", ArialnormalItalic, BlackBrush, 500, CurrentY);

                    g.DrawString(Clstax.FivePercTaxAmount.ToString(), ArialnormalItalic, BlackBrush, 540, CurrentY);
                    g.DrawString(Clstax.FivePercTaxableAmount.ToString(), ArialnormalItalic, BlackBrush, 610, CurrentY);
                    g.DrawString(TNetAmount.ToString("0.00"), ArialnormalItalic, BlackBrush, 700, CurrentY);
                    //" + Clstax.FivePercTaxableAmount + ",  " + TNetAmount, ArialnormalItalic, BlackBrush, 500, CurrentY);

                    CurrentY = CurrentY + 16;
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
            CurrentY = CurrentY + 16;
            g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, 500, CurrentY);
            xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
            g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);

            if (_Dbtask.znullDouble(Totherexpense) != 0)
            {
                CurrentY = CurrentY + 16;
                g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, 500, CurrentY);
                xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, xTotalValue, CurrentY);
            }

            CurrentY = CurrentY + 16;
            g.DrawString("Bill Amount", ArialnormalItalic, BlackBrush, 500, CurrentY);
            xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
            g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), Arialbold, BlackBrush, xTotalValue, CurrentY);


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

            CurrentY = CurrentY + 16;
        }


        public void PrintTotal(Graphics g)
        {
            // CurrentY = 750;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            g.DrawString("Total", Arialbold, BlackBrush, 50, CurrentY);


            if (InvSubTitle5 != "      ESTIMATE")
            {
                g.DrawString(TotalQty, VerdanaBold, BlackBrush, 370, CurrentY);/*For Qty*///350
                g.DrawString(TotalItemDisc.ToString(), VerdanaBold, BlackBrush, 490, CurrentY);/*For Discount*/
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, 525, CurrentY);/*For Taxable*/
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, 650, CurrentY);/*For Tax*/
            }
            else
            {
                g.DrawString(TotalQty, VerdanaBold, BlackBrush, 350 + 150, CurrentY);/*For Qty*/
            }

            g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, 750, CurrentY);/*For Amount*/
            CurrentY = CurrentY + 32;
        }
        private void SetInvoiceTotal(Graphics g)
        {// Set Invoice Total:
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



            AmountInWords _word = new AmountInWords();
            AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));

            g.DrawString("Amount In Words :" + AmountinWords, AmountInwordsfont, BlackBrush, 50, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight * 1;
            g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, rightMargin, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight;

            if (FormType == "WHOLESALE" || FormType == "SALES RETURN" || FormType == "DELIVERY NOTE" || FormType == "Purchase Return")
            {
                CurrentY = CurrentY + InvoiceFontHeight - 5;
                g.DrawString("Decleration:", Declarationfont, BlackBrush, 50, CurrentY);

                CurrentY = CurrentY + InvoiceFontHeight;

                g.DrawString("               To be furnished by the seller)Certified that all the  particulars shown in the above Tax Invoice are true\n" +
                             "               and correct in all respects and the goods on which the tax charged and collected nare in accordance with \n" +
                             "               the provisions of the " + Strstate + " ACT 2003 and the rules made thereunder. It is also certified    that my/our\n" +
                             "               Registration under " + Strstate + " Act 2003 is not subject to  any suspension/cancellation and it is valid as on  \n" +
                             "               the date of this Bill.", Declarationfont, BlackBrush, 100, CurrentY);

                CurrentY = CurrentY + InvoiceFontHeight * 5;
            }
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
                rightMargin = 300;

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
