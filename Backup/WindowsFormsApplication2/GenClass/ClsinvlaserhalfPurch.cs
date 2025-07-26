 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using ZXing;
using ZXing.QrCode;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class ClsinvlaserhalfPurch
    {
        public bool PrintBarcodeLaser;
        private QrCodeEncodingOptions options;
        public double Cess = 0;
        public string vehicle = "";
        public string mtrread = "";
        public bool PrintHeader=true;
        public double CGSTTAX;
        public double SGSTTAX;
        public double IGSTTAX; public string EmployeeId = "";
        public string warrantyy = "";
        public string discprint = "";
        /*For Settings*/
        string Cst = ""; int decval2;
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
        int RecordsPerPage = 14; // twenty items in a page
        /*Load Data*/
        public string ModeofPayment;
        public string Lid="";
        public string TempCust;
        //public string EmployeeId;
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
        public int Cln = 0;
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
        public bool itemnotee = false;
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";
        public string Scndhead = "";  

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

            Temp = "                   GOODS AND SERVICE TAX RULE 2017";
            Temp = "                                        TAX INVOICE";

            return Temp;
        }
        private void ReadInvoiceHead()
        {
            //Titles and Image of invoice:
            InvSubTitleInvoicename = InvoiceName;
           
           //if (CommonClass._Menusettings.GetMnustatus("176").ToString()=="1")
           // {
           //     itemnotee = true;
           // }
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
            else if (FormType == "SALES QUATATION")
            {
                InvSubTitle5 = "               QUATATION";
            }
            else 
            {
               InvSubTitle5 = "         "+FormType+" INVOICE";
            }

            if (FormType != "ESTIMATE" && FormType != "     SALES ORDER")
            {
                InvTitle = _Companymaster.GetspecifField("cname");
                InvSubTitleTaxDeclaration = TaxDeclarationfU();
                InvSubTitle1 = _Companymaster.GetspecifField("Address1");
                InvSubTitle11 = _Companymaster.GetspecifField("Address2");
                InvSubTitle2 =  _Companymaster.GetspecifField("Telephone");//Kerala
                InvSubTitle3 = _Companymaster.GetspecifField("TaxNo1");//Kerala
                InvSubTitle4 = TaxDeclarationfU();//Kearala                           ";
                InvSubTitle6 = "Bill No:" + Billno + "                                                                                     Bill Date";
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

            //CurrentX = leftMargin;
            int ImageHeight = 0;
            CurrentX = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Leftleser"));
            Pen selpens = new Pen(Color.Gray);

            g.DrawRectangle(selpens, CurrentX, 5, 558, 792);
            // Draw Invoice image:
            if (System.IO.File.Exists(InvImage))
            {
                CurrentY =  20;
                Bitmap oInvImage = new Bitmap(InvImage);
                // Set Image Left to center Image:
                int xImage = CurrentX + (InvoiceWidth - oInvImage.Width) / 2;
                ImageHeight = oInvImage.Height; // Get Image Height
                g.DrawImage(oInvImage, CurrentX, CurrentY - 10, 550, 80);
                CurrentY = CurrentY + 90;

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
            string secsubtit = "";
            InvoiceWidth = 560;
            //if (FormType == "Sales Quatation")
            //{
            //    InvSubTitle5 = "SALES QUATATION";//, VerdanaBold, BlackBrush, 480, CurrentY);//142
            //}
            if (FormType == "Purchase Order")
            {
                InvSubTitle5 = "Purchase Order";//, VerdanaBold, BlackBrush, 480, CurrentY);//142
            }
            if (FormType == "Purchase Return")
            {
                InvSubTitle5 = "Purchase Return";//, VerdanaBold, BlackBrush, 550, CurrentY);//142
            }
            if (FormType == "Purchase")
            {
                InvSubTitle5 = "Purchase Invoice";
            }
            if (InvSubTitle3 != "" && FormType != "ESTIMATE")/*For Company Heading*/
            {
                //g.DrawString("GSTIN", Arialnormal, BlackBrush, 15, 10);/*For Tin*/
                //g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 65, 10);/*CST Reg No*/
                //g.DrawString(InvSubTitle3, Arialbold, BlackBrush, 558, 10, Str);/*CST Reg No*/


                //g.DrawString("Place of supplier:", Arialnormal, BlackBrush, 15, 25);/*For Tin*/
                //g.DrawString(_Companymaster.GetspecifField("state"), Arialnormal, BlackBrush, 140, 25);/*State Code*/
                //g.DrawString(_Companymaster.GetspecifField("state"), Arialnormal, BlackBrush, 558, 25, Str);
               // CurrentY = 40;
            }
            else
            {
                RecordsPerPage = 14;
            }
            RecordsPerPage = 14;
            ImageHeight = 13;
            // g.DrawString("Tax Prayer's Identification Number", Arialnormal, BlackBrush, 50, 60);/*For Tin*/

            if (Cst != "" && FormType != "     SALES ORDER" && FormType != "Purchase Order" && FormType != "SALES QUATATION")/*For Company Heading*/
            {
                //g.DrawString("CST", Arialnormal, BlackBrush, 600, CurrentY / 2);/*For CST Reg No*/

                //g.DrawString(Cst, Arialbold, BlackBrush, 650, CurrentY / 2);/*CST Reg No*/
            }
            //g.DrawString(InvTitle, VerdanaBold, BlackBrush, xInvTitle, CurrentY);/*CST Reg No*/
            //if(FormType != "ESTIMATE")
            //{
            CurrentY = CurrentY - 10;

            if (InvTitle != "" )/*For Company Heading*/
            {
                //CurrentY = CurrentY  +ImageHeight;
                xInvTitle = (InvoiceWidth - (int)g.MeasureString(InvTitle, VerdanaBoldHeading).Width) / 2;
                //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush,15, CurrentY);
                //g.DrawString(InvTitle, VerdanaBoldHeading, BlackBrush, 558, CurrentY,Str);
                CurrentY = CurrentY + 5;
            }
            if (InvSubTitle1 != "" )/*For Address*/
            {
                CurrentY = CurrentY + InvTitleHeight;
                xInvSubTitle1 = (InvoiceWidth - (int)g.MeasureString(InvSubTitle1, VerdanaBold).Width) / 2;
                //g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, 15, CurrentY);
                //g.DrawString(InvSubTitle1, VerdanaBold, BlackBrush, 558, CurrentY,Str);
                CurrentY = CurrentY + 20;
            }

            if (InvSubTitle11 != "" )/*For Address2*/
            {
                CurrentY = CurrentY + InvTitleHeight;
                xInvSubTitle11 = (InvoiceWidth - (int)g.MeasureString(InvSubTitle11, VerdanaBold).Width) / 2;
                //g.DrawString(InvSubTitle11, VerdanaBold, BlackBrush, 15, CurrentY);
                //g.DrawString(InvSubTitle11, VerdanaBold, BlackBrush, 558, CurrentY,Str);
                CurrentY = CurrentY + 15;
            }
            //g.DrawString(, Arialnormal, BlackBrush, 15, 10);/*For Tin*/
            //g.DrawString("vat:" + InvSubTitle3, VerdanaBold, BlackBrush, 15, CurrentY);/*CST Reg No*/
            //g.DrawString(InvSubTitle3 + ":vat", VerdanaBold, BlackBrush, 558, CurrentY, Str);/*CST Reg No*/
            if (InvSubTitle2 != "" )/*For Phone*/
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                xInvSubTitle2 = (InvoiceWidth - (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width) / 2;
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush,15, CurrentY);
                //g.DrawString(InvSubTitle2, InvSubTitleFont, BlackBrush, 558, CurrentY,Str);
                CurrentY = CurrentY + 5;
            }
            if (InvSubTitle5 != "" && FormType != "ESTIMATE")/*For TaxRule*/
            {
                InvSubTitle5 = InvSubTitle5.TrimStart(' ');
                CurrentY = CurrentY + InvSubTitleHeight;
                CurrentX = (InvoiceWidth - (int)g.MeasureString(InvSubTitle5, Arialnormal).Width) / 2;
                g.DrawString(InvSubTitle5, Arialbold, BlackBrush, CurrentX, CurrentY);
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
                if (InvSubTitle5 == "              ESTIMATE INVOICE")
                {
                    //CurrentY = CurrentY + InvSubTitleHeight;
                    //g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 150, CurrentY);
                }
                else
                {
                    //CurrentY = CurrentY + InvSubTitleHeight;
                    //g.DrawString(InvSubTitle5, Arialbold, BlackBrush, 150, CurrentY);
                }
                //CurrentY = CurrentY + 5;

                //if (InvSubTitle5 != "      ESTIMATE" && InvSubTitle5 != "           SALES ORDER")
                //{
                //CurrentY = CurrentY + InvSubTitleHeight;
               // g.DrawString("Credit/Cash", Arialnormal, BlackBrush, 350, CurrentY);
                //CurrentY = CurrentY + 5;
               // }

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
                //CurrentY = CurrentY + InvSubTitleHeight;
                //g.DrawString(InvSubTitle7, Verdananormal, BlackBrush, 300, CurrentY);
            }


            CurrentX = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Leftleser"));
            // Draw line:
            //CurrentY = CurrentY + InvSubTitleHeight;
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
            CurrentX = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Leftleser"));
            //CurrentX = 2;// leftMargin;
            //CurrentY = topMargin;
            CurrentY = CurrentY + 20;
            //CurrentX = 200;
            if (FormType != "              ESTIMATE INVOICE" && FormType != "     SALES ORDER")
            {
                //CurrentY = 170;
            }
            else
            {
                //CurrentY = 100;
            }
            //CurrentY = 170;
            if (FormType == "SALES QUATATION")
            {
                FieldValue = "QUATATION NO: ";
            }
            else
            {
                FieldValue = "INVOICE NO: ";
            }
            CurrentY = CurrentY - 10;
           
            Pen selpen = new Pen(Color.Black);

            g.DrawRectangle(selpen,CurrentX+ 10, CurrentY, 200, 60);
            g.DrawLine(new Pen(Brushes.Gray, 1), CurrentX + 10, CurrentY + 20, CurrentX + 210, CurrentY + 20);

            //g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX, CurrentY);
            //g.DrawString(Billno, VerdanaBold, BlackBrush, CurrentX + 90, CurrentY);

            //CurrentY = CurrentY + 16;
            string time = BillDate.ToString();
            time = time.Substring(11);
            FieldValue = "Bill no. & Date  ";
            g.DrawString(FieldValue, Arialnormal, BlackBrush, CurrentX + 10, CurrentY);
            g.DrawString(BillDate.ToString("dd/MM/yyyy"), VerdanaBold, BlackBrush, CurrentX + 200, CurrentY + 25, Str);
            g.DrawString(Billno, VerdanaBold, BlackBrush, CurrentX + 10, CurrentY + 25);
            g.DrawString("Time(زمن) ", Arialnormal, BlackBrush, CurrentX + 10, CurrentY + 40);
            g.DrawString(time, Verdananormal, BlackBrush, CurrentX + 200, CurrentY + 40, Str);
            if (CommonClass._Menusettings.GetMnustatus("199").ToString() == "1")
            {
                if (vehicle != "")
                {
                    //CurrentY = CurrentY + 45;
                    g.DrawString(vehicle + ": " + " Vehicle no."+ " "+"رقم لوحة السيارة ", VerdanaBold, BlackBrush,CurrentX+ 550, CurrentY, Str);
                    //g.DrawString(vehicle, VerdanaBold, BlackBrush, 500, CurrentY);
                   CurrentY = CurrentY + 18; 
                }

            }
            if (CommonClass._Menusettings.GetMnustatus("200").ToString() == "1")
            {
                if (mtrread != "")
                {

                    g.DrawString(mtrread + ":  " +  " Meter read" +"  "+ "رقم عداد السيارة ", VerdanaBold, BlackBrush,CurrentX+ 550, CurrentY, Str);
                    //g.DrawString(mtrread, VerdanaBold, BlackBrush, 500, CurrentY);

                    CurrentY = CurrentY + 18;
                }
            }



            if (FormType == "WHOLESALE" || FormType == "Purchase Return" || SProject == false)
            {
                //FieldValue = "VAT";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, 558, CurrentY,Str);
                //FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 60, CurrentY);
                FieldValue = _Accountledger.GetspecifField("taxregno", Lid);
               if(Tvat!="")
               {
                   FieldValue = Tvat;
               }


               g.DrawString(FieldValue + ":VAT" + " " + "رقم الضريبي العميل ", Verdananormal, BlackBrush,CurrentX+ 558, CurrentY, Str);
                CurrentY = CurrentY + 15;
                FieldValue = _Accountledger.GetspecifField("mobile", Lid);
                if (Tmob != "")
                {
                    FieldValue = Tmob;
                }

                g.DrawString(FieldValue + " :Mobile" + " " + " جوال ", Verdananormal, BlackBrush, CurrentX+558, CurrentY, Str);

                CurrentY = CurrentY + 15;
                FieldValue = _Accountledger.GetspecifField("phone", Lid);
                g.DrawString(FieldValue + " :Phone" + " " + "هاتف", Verdananormal, BlackBrush,CurrentX+ 558, CurrentY, Str);

            }

            string employeid = ""; string employee = "";
            employeid =CommonClass._Dbtask.znllString(EmployeeId);
            employee = CommonClass._Dbtask.znllString(_Accountledger.GetspecifField("lname", employeid));
            if (employee != "")
            {
                CurrentY = CurrentY + 15;
                g.DrawString(employee + "  : Employee  " + "  " + "الموظف", VerdanaBold, BlackBrush, CurrentX+558, CurrentY, Str);
                CurrentY = CurrentY + 18;
            }
            CurrentY = CurrentY + 16;

            string CName = _Accountledger.GetspecifField("LNAME", Lid);
            if (CName == "" &&Tename != "")
            {
                CName = Tename;
            }

            string Address = _Accountledger.GetspecifField("address", Lid);

            string CTin = _Accountledger.GetspecifField("Taxregno", Lid);

            int CCount = Address.Split('\n').Length - 1;

            if (SProject == true)
            {
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }

            if (Address==""&&Taddres!="")
            {
                Address = Taddres;
            }
            CurrentY = CurrentY + 18;
            FieldValue = "Supplier " + " " + "( المورد ) ";
            g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX, CurrentY);
            g.DrawString("  : " +CName, VerdanaBold, BlackBrush, CurrentX + 150,CurrentY);

            //CurrentY = CurrentY + 40;
            if (Address!="")
            {
                g.DrawString("Address" + " " + "(العنوان)" + "  :", VerdanaBold, BlackBrush, CurrentX, CurrentY + 15);
            }
            int count = 0;
            FieldValue = "";
            int kk = 1;
            foreach (char c in Address)
            {
                FieldValue = FieldValue + c;
                if (c == '\n')
                {
                    g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX + 120, CurrentY + 15 * kk);
                    kk++;
                    FieldValue = "";
                }
                count++;
            }
            g.DrawString(FieldValue, VerdanaBold, BlackBrush, CurrentX+120, CurrentY + 15 * kk);
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
           // CurrentX = 369;

            

            FieldValue = "Mobile";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX, CurrentY);
            FieldValue = ":";
           // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 60, CurrentY);

            if (SProject == true)
            {
                FieldValue = CommonClass._Partyproject.GetspecifFieldBaseonName("mobile", TempCust);
                Address = CommonClass._Partyproject.GetspecifFieldBaseonName("address", TempCust);
            }
            else
            {
                FieldValue = _Accountledger.GetspecifField("mobile", Lid);
            }
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 90, CurrentY);


            //CurrentY = CurrentY + InvoiceFontHeight;
            // FieldValue = "Mobile       : " + _Accountledger.GetspecifField("Mobile", Lid);
            FieldValue = "Phone";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX, CurrentY);
            FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 60, CurrentY);
            FieldValue = _Accountledger.GetspecifField("phone", Lid);
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 90, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight;

            FieldValue = "State";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX, CurrentY);
            FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 60, CurrentY);
            //FieldValue = _Accountledger.GetspecifField("state", Lid);
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 90, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight;

            FieldValue = "State code";
           // g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX, CurrentY);
            FieldValue = ":";
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 60, CurrentY);
            //FieldValue = _Accountledger.GetspecifField("statecode", Lid);
            //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 90, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight;

            if (FormType == "WHOLESALE")
            {
                FieldValue = "CST";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 500, CurrentY);
                FieldValue = ":";
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 560, CurrentY);
               // FieldValue = _Accountledger.GetspecifField("cst", Lid);
                //g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + 590, CurrentY);
            }
            CurrentY = CurrentY + 16;
            // g.DrawLine(new Pen(Brushes.Black,1), leftMargin, 100, rightMargin, 100);
            //  g.DrawLine(new Pen(Brushes.Black,1), leftMargin, CurrentY, rightMargin, CurrentY);
            // CurrentY = CurrentY + InvoiceFontHeight + 8;

            //CurrentX = 2;
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

            RecordsPerPage = 10;
            if(itemnotee==true)
            {
            RecordsPerPage =6;
            }
            // Set Table Head:
            int xSlno = CurrentX + 10;
                //leftMargin 
            //CurrentY = CurrentY ;
            CurrentY = CurrentY + 8;
            Cln = CurrentY; leftMargin = 5;
            g.DrawString("SlNo", Verdananormal, BlackBrush, xSlno, CurrentY+13);
            g.DrawString("رقم", Verdananormal, BlackBrush, xSlno, CurrentY + 26);
            
            int xProductName = new int();
            int XHsncode = new int();

            int xRate;

            if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
            {

                xProductName =  (int)g.MeasureString("Product Name", Verdananormal).Width + 4;
                g.DrawString("Product Name", Verdananormal, BlackBrush, CurrentX + xProductName, CurrentY + 13);
                g.DrawString("اسم العنصر", Verdananormal, BlackBrush, CurrentX + xProductName, CurrentY + 26);

                XHsncode = xSlno + (int)g.MeasureString("Product Name%", Verdananormal).Width + 61;
                //g.DrawString("HSN", Verdananormal, BlackBrush, XHsncode, CurrentY);


                xQty = XHsncode + (int)g.MeasureString("HSN", Verdananormal).Width + 50;
                g.DrawString("Qty", Verdananormal, BlackBrush, CurrentX + 271, CurrentY + 13);//XHsncode
                g.DrawString("الكمية", Verdananormal, BlackBrush, CurrentX + 271, CurrentY + 26);

                xRate = xQty + (int)g.MeasureString("Rate  ", Verdananormal).Width + 33;//10
                g.DrawString("Rate  ", Verdananormal, BlackBrush, CurrentX + 300, CurrentY + 13);//xQty
                g.DrawString("إجمالي", Verdananormal, BlackBrush, CurrentX + 300, CurrentY + 26);
                //xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 30;//25
                //g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);


                xTaxable = xRate + (int)g.MeasureString("Gross", Verdananormal).Width + 27;//25
                g.DrawString("Gross", Verdananormal, BlackBrush, CurrentX + 370, CurrentY + 13);//xRate
                g.DrawString("المبلغ", Verdananormal, BlackBrush, CurrentX + 370, CurrentY + 26);

                //xTaxperc = xTaxable + (int)g.MeasureString("Taxable(Amt)", Verdananormal).Width + 10;//10
                //g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxable, CurrentY+13);//xTaxable
                //g.DrawString("Tax%", Verdananormal, BlackBrush, xTaxable, CurrentY + 26);

                xTaxAmt = xTaxable + (int)g.MeasureString("Taxable", Verdananormal).Width + 25;
                g.DrawString("Tax", Verdananormal, BlackBrush, CurrentX + 425, CurrentY + 13);//xTaxperc
                g.DrawString("ضريبة", Verdananormal, BlackBrush, CurrentX + 425, CurrentY + 26);
            }
            else
            {
                
                xProductName = xSlno + (int)g.MeasureString("SlNo", Verdananormal).Width+4;
                g.DrawString("Product Name", Verdananormal, BlackBrush, xProductName, CurrentY);

                xQty = xProductName + (int)g.MeasureString("Product Name%", Verdananormal).Width +61;
                g.DrawString("Qty", Verdananormal, BlackBrush, xQty, CurrentY);

                xRate = xQty + (int)g.MeasureString("Qty", Verdananormal).Width + 50;
                g.DrawString("Rate  ", Verdananormal, BlackBrush, xRate, CurrentY);

                xDiscount = xRate + (int)g.MeasureString("Rate  ", Verdananormal).Width + 33;
                g.DrawString("Disc", Verdananormal, BlackBrush, xDiscount, CurrentY);

                xNetamt = xTaxAmt + (int)g.MeasureString("Tax", Verdananormal).Width + 30;//10
                g.DrawString("Amount", Verdananormal, BlackBrush, xNetamt+400, CurrentY);



            }

            if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
            {
                xNetamt = xTaxAmt + (int)g.MeasureString("Tax", Verdananormal).Width + 30;//10
                g.DrawString("Amount", Verdananormal, BlackBrush, CurrentX + 480, CurrentY + 13);
                g.DrawString("كمية الشبكة", Verdananormal, BlackBrush, CurrentX + 480, CurrentY + 26);
                CurrentY = CurrentY + 13;
            
            }



            // Set Invoice Table:
            //g.DrawLine(new Pen(Brushes.Black, 1), 5, 5, InvoiceWidth, 5);
            //g.DrawLine(new Pen(Brushes.Black, 1), 5, 1060, InvoiceWidth, 1060);

            //g.DrawLine(new Pen(Brushes.Black, 1), 5, 5, 5, 1060);
            //g.DrawLine(new Pen(Brushes.Black, 1), InvoiceWidth, 5, InvoiceWidth, 1060);

            //  g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, bottomMargin, rightMargin, CurrentY);


            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX+InvoiceWidth, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight + 16;
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX+InvoiceWidth, CurrentY);
            //CurrentY = CurrentY + InvoiceFontHeight + 8;

            RowValidation(MainGrid);
            CurrentY = CurrentY + InvoiceFontHeight + 2;
            string ItemNote;
            
            for (int i = TRowcounting; i <= MainGrid.Rows.Count - 1; i++)
            {

                if (_Dbtask.znllString(MainGrid.Rows[i].Tag) == "1")
                {
                    if (TempRowcounting < RecordsPerPage)
                    {

                        FieldValue = MainGrid.Rows[i].Cells["clnslno"].Value.ToString();
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, CurrentX + xSlno, CurrentY);


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
                            ItemNote = "";
                            //ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                            FieldValue = FieldValue + "     " + ItemNote;
                        }
                        else
                        {
                            //ItemNote = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemcode"].Value);
                        }

                        if (FieldValue.Length > 15)
                        {
                            FieldValue = FieldValue.Substring(0, 15);
                        }

                        g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX + xProductName), CurrentY);
                         if(itemnotee==true)
                         {
                          FieldValue = MainGrid.Rows[i].Cells["clnitemnote"].Value.ToString();
                          if (FieldValue!="")
                          {
                              CurrentY = CurrentY + 20;
                              g.DrawString(FieldValue, Verdananormal, BlackBrush,( CurrentX + xProductName), CurrentY);
                          }
                         }




                        string Itemid = MainGrid.Rows[i].Cells["clnitemname"].Tag.ToString();

                        if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
                        {
                            FieldValue = "";// CommonClass._Itemmaster.SpecificField(Itemid, "TaxCode");
                            // FieldValue = "";
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX + XHsncode), CurrentY);
                        }

                        FieldValue = Convert.ToDouble(MainGrid.Rows[i].Cells["clnqty"].Value).ToString();
                        // FieldValue = _Dbtask.znllString(MainGrid.Rows[i].Cells["clnitemnote"].Value);
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX +( 271 + 20)), CurrentY, Str);


                        FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnprate"].Value));
                        g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX + (370)), CurrentY, Str);

                        //FieldValue = String.Format("{0:0}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clndiscount"].Value));
                        //g.DrawString(FieldValue, Verdananormal, BlackBrush, xDiscount + 30, CurrentY, Str);

                        if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
                        {


                            //FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClntaxPer"].Value));
                            //g.DrawString(FieldValue, Verdananormal, BlackBrush, xTaxperc + 30, CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["Clntax"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX +( 425)), CurrentY, Str);

                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["ClnGross"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush,( CurrentX + (480)), CurrentY, Str);
                        }
                        if (InvSubTitle5 == "              ESTIMATE INVOICE")
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX + 523) + (55 - CurrentX), CurrentY, Str);
                        }
                        else
                        {
                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnnettamount"].Value));
                            g.DrawString(FieldValue, Verdananormal, BlackBrush, (CurrentX+ xNetamt + 55), CurrentY, Str);
                        }

                        CurrentY = CurrentY + InvoiceFontHeight + 4;
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
                if (FormType != "     SALES ORDER"&&FormType !="     ESTIMATE" && RecordsPerPage != 15)
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
            int RecordsPerPage = 14; // twenty items in a page
            decimal Amount = 0;
            bool StopReading = false;
            if (InvSubTitle5 != "              ESTIMATE INVOICE")
            {
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
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, InvoiceWidth, CurrentY);
                CurrentY = CurrentY + InvoiceFontHeight + 8;
                g.DrawLine(new Pen(Brushes.Black, 1), leftMargin, CurrentY, InvoiceWidth, CurrentY);
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


                            FieldValue = String.Format("{0:0.00}", _Dbtask.gridnul(MainGrid.Rows[i].Cells["clnprate"].Value));
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

                }
                if (StopReading)
                {

                    SetInvoiceTotal(g);
                }

                g.Dispose();
            }
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

                    ClsinvlaserhalfPurch Frms = new ClsinvlaserhalfPurch();
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
                if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
                {
                    //g.DrawString("Tax%  Tax          Taxable      NetAmount", ArialnormalItalic, BlackBrush, 500, CurrentY);
                    //CurrentY = CurrentY + 16;
                    //g.DrawLine(new Pen(Brushes.Black, 1), 500, CurrentY, rightMargin, CurrentY);
                    //CurrentY = CurrentY + 16;

                    setqrtwo(g);
                    
                    double TNetAmount;

                    g.DrawString("Total Gross( المجموع الإجمالي ) :", VerdanaBold, BlackBrush, CurrentX+260, CurrentY);
                    g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, CurrentX + 470, CurrentY);
                    
                    CurrentY = CurrentY + 16;

                    g.DrawString("Total Discount( إجمالي الخصم ):", VerdanaBold, BlackBrush, CurrentX + 260, CurrentY);
                    g.DrawString(TDiscount, VerdanaBold, BlackBrush, CurrentX + 470, CurrentY);
                    CurrentY = CurrentY + 16;

                    g.DrawString("Total VAT( مجموع الضريبة ):", VerdanaBold, BlackBrush, CurrentX + 260, CurrentY);
                    g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, CurrentX + 470, CurrentY);
                    CurrentY = CurrentY + 16;
                   string tcashrecvd = "";
                   g.DrawString("Total Billamount( مبلغ الفاتورة ):", VerdanaBold, BlackBrush, CurrentX + 260, CurrentY);
                   g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), VerdanaBold, BlackBrush, CurrentX + 470, CurrentY);
                    
                    
                    //CurrentY = CurrentY + 16;
                    ////CurrentY = CurrentY + 16;
                    //tcashrecvd = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select adamount from tblbusinessissue where vno='" + Billno + "' and ISSUEtype ='SI'")).ToString();
                    //g.DrawString(" Received Amount (تم الاستلام)", VerdanaBold, BlackBrush, 260, CurrentY);
                    //g.DrawString(tcashrecvd, VerdanaBold, BlackBrush, 470, CurrentY);

                    //double current = 0;
                    //current = _Dbtask.znlldoubletoobject(BillAmount) - _Dbtask.znlldoubletoobject(tcashrecvd);
                    //CurrentY = CurrentY + 16;
                    //g.DrawString(" Current Balance (الرصيد الحالي)", VerdanaBold, BlackBrush, 260, CurrentY);
                    //g.DrawString(_Dbtask.znlldoubletoobject(current).ToString(), VerdanaBold, BlackBrush, 470, CurrentY);

                    ////g.DrawString("TOTAL CESS   :" + _Dbtask.SetintoDecimalpoint(Cess), ArialnormalItalic, BlackBrush, xTaxable - 30, CurrentY);
                    //CurrentY = CurrentY + 16;
                    //string rndoff = "";
                    //decval2 = Convert.ToInt32(_Dbtask.znullDouble(BillAmount));

                    ////string lst = BillAmount.Substring(BillAmount.Length - 3);
                    ////double dvalue = Convert.ToDouble(BillAmount);
                    ////if ( decval2> Convert.ToDouble( BillAmount))
                    ////{

                    //    rndoff = "1";
                    //}

                    //g.DrawString("Round off : (   " + rndoff+"  )", ArialnormalItalic, BlackBrush, xTaxable - 30, CurrentY);

                
                }
                CurrentY = CurrentY + 30;
                CurrentX = xTaxable - 30;

                if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
                {
                    //g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                    //g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, CurrentX + 120, CurrentY);

                    if (_Dbtask.znullDouble(Totherexpense) != 0)
                    {
                        //CurrentY = CurrentY + 16;
                        //g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                        xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                        //g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, CurrentX + 90, CurrentY);
                    }
                    decval2 = Convert.ToInt32(_Dbtask.znullDouble(BillAmount));

                    BillAmount = decval2.ToString();
                    //CurrentY = CurrentY + 16;
                    //g.DrawString("Bill Amount", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                    xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                    //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), Arialbold, BlackBrush, CurrentX + 90, CurrentY);
                }
                else
                {

                    if (InvSubTitle5 == "              ESTIMATE INVOICE")
                    {
                        //g.DrawString("Discount(-)", ArialnormalItalic, BlackBrush, CurrentX + 400, CurrentY);
                        xTotalValue = 750 - (int)g.MeasureString(TDiscount, ArialnormalItalic).Width;
                        //g.DrawString(TDiscount, ArialnormalItalic, BlackBrush, CurrentX + 490, CurrentY);

                        if (_Dbtask.znullDouble(Totherexpense) != 0)
                        {
                            //CurrentY = CurrentY + 16;
                            //g.DrawString("Frieght(+)", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                            xTotalValue = 750 - (int)g.MeasureString(Totherexpense, ArialnormalItalic).Width;
                           // g.DrawString(Totherexpense, ArialnormalItalic, BlackBrush, CurrentX + 520, CurrentY);
                        }

                        //CurrentY = CurrentY + 16;
                        //g.DrawString("Bill Amount", ArialnormalItalic, BlackBrush, CurrentX + 400, CurrentY);
                        xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                        //g.DrawString(_Dbtask.znullDouble(BillAmount).ToString("0.00"), Arialbold, BlackBrush, CurrentX + 510, CurrentY);


                        string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                        if (samplid == "18" && PrintOldbalance == true)
                        {
                            CurrentY = CurrentY + 16;
                            double oldbalnce = 0;
                            oldbalnce = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='" + Lid + "' "));

                            oldbalnce = oldbalnce - _Dbtask.znullDouble(BillAmount);
                            g.DrawString("Old Balance (التوازن القديم)", VerdanaBold, BlackBrush, CurrentX + 260, CurrentY);
                            g.DrawString(oldbalnce.ToString(), VerdanaBold, BlackBrush, CurrentX + 470, CurrentY);

                        //CurrentY = CurrentY + 20;
                            //g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, CurrentX + 400, CurrentY);
                            xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                           // g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, CurrentX + 520, CurrentY);

                            //CurrentY = CurrentY + 16;
                            //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, CurrentX + 400, CurrentY);
                            xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                            double GrandTotal;

                            if (FormType != "SALES RETURN")
                                GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                            else
                                GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                            //g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, CurrentX + 510, CurrentY);





                        }
                    }
                }

                if (FormType != "     SALES ORDER" && InvSubTitle5 != "              ESTIMATE INVOICE")
                {
                    string samplid = _Dbtask.ExecuteScalar("select agroupid from tblaccountledger where lname='" + TempCust + "'");
                    if (samplid == "18" && PrintOldbalance == true)
                    {
                        //CurrentY = CurrentY + 20;
                        //g.DrawString("Old Balance", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                        xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                        //g.DrawString(OldBalance.ToString(), Arialbold, BlackBrush, CurrentX + 90, CurrentY);

                        //CurrentY = CurrentY + 16;
                        //g.DrawString("Grand Total", ArialnormalItalic, BlackBrush, CurrentX, CurrentY);
                        xTotalValue = 750 - (int)g.MeasureString(BillAmount, Arialbold).Width;
                        double GrandTotal;

                        if (FormType != "SALES RETURN")
                            GrandTotal = Convert.ToDouble(BillAmount) + Convert.ToDouble(OldBalance);
                        else
                            GrandTotal = Convert.ToDouble(OldBalance) - Convert.ToDouble(BillAmount);

                        //g.DrawString(_Dbtask.SetintoDecimalpoint(GrandTotal), Arialbold, BlackBrush, CurrentX + 90, CurrentY);
                    }
                }

            CurrentX = 15;
            CurrentY = CurrentY + 16;
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
            string totamtt = BillAmount;

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

            CurrentY = CurrentY + 8;
            g.DrawImage(newbit, CurrentX + 20, CurrentY - 10);
            CurrentY = CurrentY + 18;
            //CurrentY = CurrentY + 100;

        }
        public void PrintTotal(Graphics g)
        {
           // CurrentY = 750;
            if (InvSubTitle5 == "              ESTIMATE INVOICE")
            {
                g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, CurrentX+InvoiceWidth, CurrentY);
                g.DrawString("Total", Arialbold, BlackBrush, CurrentX + 55, CurrentY);

                g.DrawString(TotalQty, VerdanaBold, BlackBrush, CurrentX + 200, CurrentY);
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, xNetamt + 460, CurrentY, Str);/*For Amount*/
                g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY + 5, CurrentX+InvoiceWidth, CurrentY + 5);
                CurrentY = CurrentY + 20;

            }
            else
            {

                g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY + 240,CurrentX+ InvoiceWidth, CurrentY + 240);
                g.DrawString("Total", Arialbold, BlackBrush, CurrentX + 55, CurrentY + 250);
            }

            if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
            {
                g.DrawString(TotalQty, VerdanaBold, BlackBrush, xQty + 20, CurrentY + 250, Str);/*For Qty*///350
                //g.DrawString(TotalItemDisc.ToString(), VerdanaBold, BlackBrush, 490, CurrentY);/*For Discount*/
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxable), VerdanaBold, BlackBrush, xTaxable + 45, CurrentY + 250, Str);/*For Taxable*/
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalTaxAmount), VerdanaBold, BlackBrush, xTaxAmt + 30, CurrentY + 250, Str);/*For Tax*/
            }
            else
            {
                if (InvSubTitle5 != "              ESTIMATE INVOICE")
                {
                    g.DrawString(TotalQty, VerdanaBold, BlackBrush, CurrentX +( 350 + 150), CurrentY + 250);/*For Qty*/
                }

                




            }

            if (InvSubTitle5 != "              ESTIMATE INVOICE" && InvSubTitle5 != "           SALES ORDER")
            {
                g.DrawString(_Dbtask.SetintoDecimalpoint(TotalNetamount), VerdanaBold, BlackBrush, xNetamt + 55, CurrentY + 250, Str);/*For Amount*/
                CurrentY = CurrentY + 20;

                g.DrawLine(new Pen(Brushes.Gray, 1), CurrentX + 5, CurrentY + 260, CurrentX + 558, CurrentY + 260);

                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 58, Cln + 10, CurrentX + 58, CurrentY + 260);//230
                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 250, Cln + 10, CurrentX + 250, CurrentY + 260);
                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 300, Cln + 10, CurrentX + 300, CurrentY + 260);
                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 370, Cln + 10, CurrentX + 370, CurrentY + 260);
                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 425, Cln + 10, CurrentX + 425, CurrentY + 260);
                g.DrawLine(new Pen(Brushes.LightGray, 1), CurrentX + 480, Cln + 10, CurrentX + 480, CurrentY + 260);


                CurrentY = CurrentY + 260;
            }
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

            CurrentY = CurrentY + 16;

            AmountInWords _word = new AmountInWords();
            AmountinWords = _word.ConvertAmount(Convert.ToDouble(BillAmount));

            g.DrawString("Amount In Words :" + AmountinWords, AmountInwordsfont, BlackBrush, CurrentX, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight * 1;
            g.DrawLine(new Pen(Brushes.Black, 1), CurrentX, CurrentY, InvoiceWidth, CurrentY);
            CurrentY = CurrentY + InvoiceFontHeight;

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
            TotalValue = "Autherised Signatory";

             //if (FormType != "ESTIMATE"
            CurrentY = CurrentY - 35;
            if (FormType != "     ESTIMATE")
            {
                g.DrawString(TotalValue, Verdananormal, BlackBrush, xTaxable+60, CurrentY);
            }
            CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
            TotalValue = "  [With Status&Seal]";
            if (FormType != "     ESTIMATE")
            {
                g.DrawString(TotalValue, Verdananormal, BlackBrush, xTaxable + 60, CurrentY);
            }
            if(Pfooter!="")
                g.DrawString(Pfooter, Arialbold, BlackBrush,CurrentX+ 100, CurrentY);

            if (FormType != "     ESTIMATE" && InvSubTitle5 != "           SALES ORDER" && RecordsPerPage != 36)
            {
                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Details:";
                //g.DrawString(TotalValue, Arialbold, BlackBrush, 100, CurrentY);

                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Holder name:"; //+ _Companymaster.GetspecifField("Bankdetails");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);

                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Name : ";// +_Companymaster.GetspecifField("bankname");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Branch : ";// +_Companymaster.GetspecifField("bankbranch");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Account Number : "; //+ //_Companymaster.GetspecifField("aCCOUNTNO");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);


                //CurrentY = CurrentY + (int)g.MeasureString(TotalValue, Arialbold).Height;
                //TotalValue = "Bank Branch IFSC   :";// +_Companymaster.GetspecifField("IFSC");
                //g.DrawString(TotalValue, Arialnormal, BlackBrush, 100, CurrentY);
            }

            else
            {
                if (FormType == "     ESTIMATE")
                {
                    TotalValue = "Autherised Signatory";

                    g.DrawString(TotalValue, Arialbold, BlackBrush, xTaxable+320, CurrentY-2);
                    TotalValue = "  [With Status&Seal]";
                    CurrentY = CurrentY + 12;

                    g.DrawString(TotalValue, Arialnormal, BlackBrush, xTaxable+320, CurrentY);


                }
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

                ReadInvoice = true;
            }
            else
            {
                SetInvoiceData(e.Graphics, e); // Draw Invoice Data
            }
        }
    }
}
