using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
using System.Management;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.Drawing.Printing;
using System.Text;


namespace DSBarCode
{
    public class BarCodeCtrl : System.Windows.Forms.UserControl
    {
        string InvImage; /*For Logo*/

        private QrCodeEncodingOptions options;
        public float XValue;
        public float YValue;
        public int LL = 0;
        public string PrintingText;
        public int Printtype;
        public int RecWidth;
        public int RecI;
        public Font ActualFont;
        public int k = 0;
        public int kk = 0;
        public int i;
        float x = 0;
        int wid = 0;

        int bcodeH = 0;
        int brateSize = 0;
        int bcompny = 0;
        int bitem = 0;
        int bitemcode = 0;
        int bitemlang = 0;

        public int TCount = 110;
        public int StartingColumn = 2;
        public int StartingRow = 2;
        public int PrintperRow = 5;
        int RecordsPerPage = 65;
        public int DistanceBysticker;

        SizeF hSize;
        SizeF fSize;
        SizeF PinfoSize;
        SizeF Pinfo1Size;

        String encodedString = "";


        int encodedStringLength;
        int widthOfBarCodeString = 0;
        double wideToNarrowRatio = 3;
        float standingValue = 0;



        /*For Testing*/
        public int totalnumber;
        int itemperpage;
        /************************************/

        int TRowcounting = 0;
        int TempRowcounting = 0;

        //WindowsFormsApplication2.Frmpurchase _Purchase = new WindowsFormsApplication2.Frmpurchase();
        public Panel panel1;
        public Panel Pn2;
        public int CurrentRecord = 0;
        public int MainRecord = 0;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument PrintDocumentBarcode;

        private System.ComponentModel.Container components = null;

        public static string Ptype;

        public static DataGridView gridmain;
        /*Settings*/

        public bool bcdpic;

        public bool PrintManDate;
        public bool PrintNote1;
        public bool PrintNote2;
        public bool PrintMorePages;
        public bool IfInnextpage;
        public int ThemalTopmargin;
        public string Barcodeprintingin;
        /***************************************/
        public int SRows;
        public string Strprate;
      

        public enum AlignType
        {
            Left, Center, Right
        }

        public enum BarCodeWeight
        {
            Small = 1, Medium, Large
        }
        public string StrHeader;
        public string StrDate = "10-10-2014";
        private string StrBatchNo = "123";
        private string StrItemnote2 = "123";
        private string StrItemnote = "123";
        public string StrRateCode;
        public string StrMrp;

        public string taxinout = "";
        public string PrintLogo;
        public string StrWhoRate;
        private Image Rupeeimg;

        private AlignType align = AlignType.Left;
        private String code = "9645254148";
        private int leftMargin = 40;
        private int topMargin = 0;
        private int height = 0;
        private bool showHeader;
        private bool showFooter;
        private String headerText = "";
        Panel PanelRoll = new Panel();
        private BarCodeWeight weight = BarCodeWeight.Small;
        private Font headerFont = new Font("Calibri", 8);
        private Font newfntt2 = new Font("Calibri", 10, FontStyle.Bold);
        private Font newfntt = new Font("Calibri", 10, FontStyle.Bold);
        private Font headerFont2 = new Font("Calibri", 12);
        private Font footerFont = new Font("Calibri", 8);
        private Font SideFont = new Font("Calibri", 6);



        private Font fcompny = new Font("Calibri", 8);
        private Font frate = new Font("Calibri", 8);
        private Font fname = new Font("Calibri", 8);
        private Font fcode = new Font("Calibri", 8);
        private Font fdt = new Font("Calibri", 7);
        private Font flangg = new Font("Calibri",8);


        public int Noofcpies = 1;
        public bool ShowSupplierCode;
        public bool Showitemnote1;
        public bool Showitemnote;
        public string SuppCode;
        public string Itemnote1Str;
        public int yTop;
        public int yTopTemp;
        public int RowNo;/*For Multi Print*/
        public int Norowinmain;
        public AlignType VertAlign
        {
            get { return align; }
            set { align = value; panel1.Invalidate(); }
        }

        public String BarCode
        {
            get { return code; }
            set { code = value.ToUpper(); panel1.Invalidate(); }
        }

        public int BarCodeHeight
        {
            get { return height; }
            set { height = value; panel1.Invalidate(); }
        }

        public int LeftMargin
        {
            get { return leftMargin; }
            set { leftMargin = value; panel1.Invalidate(); }
        }

        public int TopMargin
        {
            get { return topMargin; }
            set { topMargin = value; panel1.Invalidate(); }
        }
        public Font Rsfont
        {
            get;
            set;
        }
        public Font ProductFont
        {
            get;
            set;
        }
        public string seclang
        {
            get;
            set;
        }
        public string itemcodee
        {
            get;
            set;
        }
        public string PInfo
        {
            get;
            set;
        }
        public string PInfo1
        {
            get;
            set;
        }
        public string exedate
        {
            get;
            set;
        }
        public string mandate
        {
            get;
            set;
        }
        public bool ShowHeader
        {
            get { return showHeader; }
            set { showHeader = value; panel1.Invalidate(); }
        }

        public bool ShowFooter
        {
            get { return showFooter; }
            set { showFooter = value; panel1.Invalidate(); }
        }

        public String HeaderText
        {
            get { return headerText; }
            set { headerText = value; panel1.Invalidate(); }
        }

        public BarCodeWeight Weight
        {
            get { return weight; }
            set { weight = value; panel1.Invalidate(); }
        }

        public Font HeaderFont
        {
            get { return headerFont; }
            set { headerFont = value; panel1.Invalidate(); }
        }

        public Font FooterFont
        {
            get { return footerFont; }
            set { footerFont = value; panel1.Invalidate(); }
        }

        public BarCodeCtrl()
        {
            InitializeComponent();
        }

        public void PrintBarcodeLaser(int BRow)
        {
            try
            {
                DialogResult Result = MessageBox.Show("Do You want to Print?", "Qplex", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "Yes")
                {
                    if (gridmain.Rows[BRow].Tag != null)
                    {
                        if (gridmain.Rows[BRow].Tag.ToString() == "1")
                        {
                            VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;
                            // this.barCodeCtrl1.LeftMargin = 20;
                            // this.barCodeCtrl1.Height = 50;
                            BarCodeHeight = 30;
                            // this.barCodeCtrl1.Width = 800;
                            //this.barCodeCtrl1.TopMargin=50;
                            // this.barCodeCtrl1.Height = 50;

                            WindowsFormsApplication2.DBTask _Dbtask = new WindowsFormsApplication2.DBTask();
                            /*************For Get Heading Barcode***********/

                            double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
                            if (Dbtemp == 1)
                            {
                                StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                            }
                            else
                            {
                                StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
                            }
                            /*******************************************************/
                            string Strpname = gridmain.Rows[BRow].Cells["clnitemname"].Value.ToString();

                            //if (Barcodeprintingin == "Srate")
                            //{
                            //    Strprate = gridmain.Rows[BRow].Cells["clnsrate"].Value.ToString();
                            //}
                            //else if (Barcodeprintingin == "MRP")
                            //{
                            //    Strprate = gridmain.Rows[BRow].Cells["ClnMRP"].Value.ToString();
                            //}
                            string StrBarcode = gridmain.Rows[BRow].Cells["clnbatch"].Value.ToString();
                            double temp = Convert.ToDouble(gridmain.Rows[BRow].Cells["clnqty"].Value.ToString());
                            if (temp % 2 != 0)
                            {
                                temp = temp + 1;
                            }

                            // double temp2= temp / 2;
                            //Strprate = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(Strprate));
                            int InNoofcpies = Convert.ToInt16(temp) / 5;

                            this.ShowHeader = true;
                            this.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
                            this.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
                            this.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
                            this.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
                            this.HeaderText = StrHeader;
                            // this.RupeeImgaeFu = Picrupee.BackgroundImage;
                            this.PInfo = Strpname;
                            //this.PInfo1 = ": " + Strprate;
                            this.BarCode = StrBarcode;
                            this.ShowFooter = true;
                            this.Noofcpies = InNoofcpies;
                            this.yTop = 0;
                            //CRow = i;

                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void PrintImage()
        {
            panel1.Invalidate();
            panel1.Refresh();
        }

        int pages = 0;

        public bool DrawBarcode(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            for (int L = LL; L < PrintperRow; L++)
            {

                k++;
                CurrentRecord++;

                if (k <= Noofcpies)
                {
                    if (CurrentRecord > RecordsPerPage)
                    {
                        //yTop += (int)fSize.Height;
                        //yTop = yTop + 20;
                        return false;
                    }

                    else
                    {
                        x = XValue;
                        e.Graphics.DrawString(headerText, headerFont, Brushes.Black, XValue + standingValue, yTop - (int)hSize.Height);

                        for (int M = 0; M < encodedStringLength; M++)
                        {
                            if (encodedString[M] == '1')
                                wid = (int)(wideToNarrowRatio * (int)weight);
                            else
                                wid = (int)weight;

                            e.Graphics.FillRectangle(M % 2 == 0 ? Brushes.Black : Brushes.White, x + standingValue, yTop, wid, height);
                            x += wid;
                        }




                        yTop += height;

                        e.Graphics.DrawString(code, footerFont, Brushes.Black, XValue + standingValue, yTop);
                        yTop += (int)fSize.Height - 4;


                        e.Graphics.DrawString(this.PInfo, this.ProductFont, Brushes.Black, XValue + standingValue, yTop);
                        yTop += (int)fSize.Height - 2;



                        e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, XValue + standingValue, yTop - 2);


                        PrintManDate = true;
                        ShowSupplierCode = true;
                        Showitemnote1 = true;

                        if (PrintManDate == true)
                        {
                            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                            //  e.Graphics.DrawString("MFD:" + this.StrDate, footerFont, Brushes.Black, 5, yTop - 60, drawFormat);
                            this.StrDate = Convert.ToDateTime(this.StrDate).ToString("MMM-yyyy");
                            if (standingValue == 0)
                            {
                                e.Graphics.DrawString("P.K.Dt:" + this.StrDate, footerFont, Brushes.Black, 13 + DistanceBysticker, yTop - 60, drawFormat);
                            }
                            else
                            {
                                e.Graphics.DrawString("P.K.Dt:" + this.StrDate, footerFont, Brushes.Black, (XValue + standingValue) - 37, yTop - 60, drawFormat);
                            }
                        }
                        if (Showitemnote1 == true)
                        {
                            //this.SuppCode
                            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                            // e.Graphics.DrawString("001", footerFont, Brushes.Black, 10, yTop - 60, drawFormat);

                            if (standingValue == 0)
                            {
                                e.Graphics.DrawString("EXP:" + this.StrItemnote, footerFont, Brushes.Black, 23 + DistanceBysticker, yTop - 60, drawFormat);
                            }
                            else
                            {
                                e.Graphics.DrawString("EXP:" + this.StrItemnote, footerFont, Brushes.Black, (XValue + standingValue) - 27, yTop - 60, drawFormat);
                            }

                        }
                        if (Showitemnote1 == true)
                        {
                            //this.Itemnote1Str
                            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                            // e.Graphics.DrawString("IT", footerFont, Brushes.Black, 15, yTop - 60, drawFormat);

                            if (standingValue == 0)
                            {
                                e.Graphics.DrawString("Batch:" + this.StrItemnote2, footerFont, Brushes.Black, 33 + DistanceBysticker, yTop - 60, drawFormat);
                            }
                            else
                            {
                                e.Graphics.DrawString("Batch:" + this.StrItemnote2, footerFont, Brushes.Black, (XValue + standingValue) - 17, yTop - 60, drawFormat);
                            }
                        }
                        standingValue += 160;
                        yTop = yTopTemp;
                        LL++;

                    }

                }
                else
                {


                    XValue = XValue + standingValue;
                    return false;
                }
            }
            XValue = leftMargin;
            //yTop += (int)fSize.Height;
            //yTop = yTop + 70;
            yTop += 83;
            LL = 0;

            return true;
        }
        public void SetXandY()
        {

        }

        public void SettValues(string Str, Font Fnt, int X, int Y, int PPrinttype)
        {
            //headerText = Str;
            //ActualFont = Fnt;
            //XValue = X;
            //YValue = Y;
            //Printtype = PPrinttype;
        }

        public void PageSettings()
        {
            if (StartingRow > 1)
            {
                // StartingRow = StartingRow - 1;
                yTop = (83) * (StartingRow - 1);
                yTop = yTop + ThemalTopmargin;
            }
            else
            {
                yTop = ThemalTopmargin;
            }

            if (StartingColumn > 1)
            {
                // XValue = XValue + 40;
                XValue = (160) * (StartingColumn - 1);
                XValue = XValue + leftMargin;
            }
            else
            {
                XValue = leftMargin;
            }

            CurrentRecord = 1 * StartingRow - 1;
            CurrentRecord = CurrentRecord + (StartingRow - 1) * 5;
            LL = StartingColumn - 1;
        }

        private bool Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            for (; totalnumber < gridmain.Rows.Count; totalnumber++) // check the number of items 
            {
                if (gridmain.Rows[totalnumber].Tag != null && IfInnextpage == false)
                {
                    if (gridmain.Rows[totalnumber].Tag.ToString() == "1")
                    {
                        VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;
                        // this.barCodeCtrl1.LeftMargin = 20;
                        // this.barCodeCtrl1.Height = 50;
                        BarCodeHeight = 30;
                        //this.leftMargin = 50;
                        // this.barCodeCtrl1.Width = 800;
                        if (totalnumber != 0)
                        {
                            this.TopMargin = 12;
                        }


                        WindowsFormsApplication2.DBTask _Dbtask = new WindowsFormsApplication2.DBTask();
                        /*************For Get Heading Barcode***********/
                        double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
                        if (Dbtemp == 1)
                        {
                            StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                        }
                        else
                        {
                            StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
                        }
                        /*******************************************************/
                        string Strpname = gridmain.Rows[totalnumber].Cells["clnitemname"].Value.ToString();

                        if (Barcodeprintingin == "Srate")
                        {
                            Strprate = gridmain.Rows[totalnumber].Cells["clnsrate"].Value.ToString();
                        }
                        else if (Barcodeprintingin == "MRP")
                        {
                            Strprate = gridmain.Rows[totalnumber].Cells["ClnMRP"].Value.ToString();
                        }
                        StrItemnote = gridmain.Rows[totalnumber].Cells["clnitemnote"].Value.ToString();
                        StrItemnote2 = gridmain.Rows[totalnumber].Cells["clnitemnote1"].Value.ToString();
                        //StrItemnote2 = gridmain.Rows[totalnumber].Cells["clnitemnote2"].Value.ToString();
                        string StrBarcode = gridmain.Rows[totalnumber].Cells["clnbatch"].Value.ToString();
                        double temp = Convert.ToDouble(gridmain.Rows[totalnumber].Cells["clnqty"].Value.ToString());


                        int InNoofcpies;
                        double DbSample;

                        InNoofcpies = Convert.ToInt16(temp);
                        this.ShowHeader = true;
                        this.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
                        this.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
                        this.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
                        this.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
                        this.HeaderText = StrHeader;
                        this.PInfo = Strpname;

                        if (Barcodeprintingin == "MRP")
                            this.PInfo1 = "MRP: " + Strprate;
                        else
                            this.PInfo1 = Strprate;

                        this.BarCode = StrBarcode;
                        this.ShowFooter = true;
                        this.Noofcpies = InNoofcpies;
                        // this.yTop = 0;
                        //CRow = i;
                        for (; k < Noofcpies; )
                        {
                            if (CurrentRecord > RecordsPerPage)
                            {
                                CurrentRecord = 0;
                                e.HasMorePages = true;
                                yTop = ThemalTopmargin;
                                // yTop += (int)fSize.Height;

                                k--;
                                XValue = leftMargin;
                                return false;
                            }
                            String intercharacterGap = "0";
                            String str = '*' + code.ToUpper() + '*';
                            int strLength = str.Length;

                            for (int i = 0; i < code.Length; i++)
                            {
                                if (alphabet39.IndexOf(code[i]) == -1 || code[i] == '*')
                                {
                                    e.Graphics.DrawString("INVALID BAR CODE TEXT", Font, Brushes.Red, 10, 10);
                                    return false;
                                }
                            }

                            encodedString = "";

                            for (int i = 0; i < strLength; i++)
                            {
                                if (i > 0)
                                    encodedString += intercharacterGap;

                                encodedString += coded39Char[alphabet39.IndexOf(str[i])];
                            }

                            encodedStringLength = encodedString.Length;
                            widthOfBarCodeString = 0;
                            wideToNarrowRatio = 3;


                            if (align != AlignType.Left)
                            {
                                for (int i = 0; i < encodedStringLength; i++)
                                {
                                    if (encodedString[i] == '1')
                                        widthOfBarCodeString += (int)(wideToNarrowRatio * (int)weight);
                                    else
                                        widthOfBarCodeString += (int)weight;
                                }
                            }

                            x = 0;
                            wid = 0;

                            hSize = e.Graphics.MeasureString(headerText, headerFont);
                            fSize = e.Graphics.MeasureString(code, footerFont);
                            PinfoSize = e.Graphics.MeasureString(this.PInfo, ProductFont);
                            Pinfo1Size = e.Graphics.MeasureString(this.PInfo1, Rsfont);
                            int headerX = 0;
                            int footerX = 0;
                            int PinfoX = 0;
                            int PinfoX1 = 0;
                            int PinfoX2 = 0;
                            int PinfoX3 = 0;

                            if (align == AlignType.Left)
                            {
                                XValue = 50;
                                leftMargin = 50;
                                x = leftMargin;
                                headerX = leftMargin;
                                footerX = leftMargin;
                                PinfoX = leftMargin;
                                PinfoX1 = leftMargin;
                                PinfoX2 = leftMargin;
                                PinfoX3 = leftMargin;
                            }
                            else if (align == AlignType.Center)
                            {
                                x = (Width - widthOfBarCodeString) / 2;
                                headerX = (Width - (int)hSize.Width) / 2;
                                footerX = (Width - (int)fSize.Width) / 2;
                                PinfoX = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX1 = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX2 = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX3 = (Width - (int)PinfoSize.Width) / 2;
                            }
                            else
                            {
                                x = Width - widthOfBarCodeString - leftMargin;
                                headerX = Width - (int)hSize.Width - leftMargin;
                                footerX = Width - (int)fSize.Width - leftMargin;
                                PinfoX = (Width - (int)PinfoSize.Width - leftMargin);
                                PinfoX1 = (Width - (int)Pinfo1Size.Width - leftMargin);
                                PinfoX2 = (Width - (int)PinfoSize.Width - leftMargin);
                                PinfoX3 = (Width - (int)Pinfo1Size.Width - leftMargin);
                            }
                            SettValues(headerText, HeaderFont, headerX, yTop - 14, 0);
                            standingValue = 0;

                            yTopTemp = yTop;
                            //  XValue = leftMargin;
                            // PanelRoll_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
                            //XValue = leftMargin;
                            DrawBarcode(e.Graphics, e);
                        }
                    }

                }
                k = 0;
            }
            return true;
        }

        public void Print(DataGridView Grid, string Brprinting, string PrintingType, bool Print1by1,string SelectedPrinter)
        {
            PrinterSettings settings = new PrinterSettings();
            settings.Copies = Convert.ToSByte(Noofcpies);
            settings.PrinterName = SelectedPrinter;
            Ptype = PrintingType;
            gridmain = Grid;
            Barcodeprintingin = Brprinting;
            PrintDialog pd = new PrintDialog();
            printDocument1.PrinterSettings = settings;
            pd.Document = printDocument1;

            pd.UseEXDialog = true;
            if (Print1by1 == true)
            {
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    pd.Document.Print();
                }
            }
            else
            {

                pd.Document.Print();
            }

        }
        public void PrintSingle(string Brprinting, string PrintingType)
        {
            PrinterSettings settings = new PrinterSettings();
            settings.Copies = Convert.ToSByte(Noofcpies);

            Ptype = PrintingType;
            Barcodeprintingin = Brprinting;
            PrintDialog pd = new PrintDialog();
            printDocument1.PrinterSettings = settings;
            pd.Document = printDocument1;

            pd.UseEXDialog = true;
            pd.Document.Print();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintDocumentBarcode = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            //
            //PrintDocument2
            ///
            this.PrintDocumentBarcode.PrintPage += new PrintPageEventHandler(PrintDocumentBarcode_PrintPage);
            // 
            // 
            // BarCodeCtrl
            // 
            this.Controls.Add(this.panel1);
            this.Name = "BarCodeCtrl";
            this.Size = new System.Drawing.Size(100, 57);
            this.Resize += new System.EventHandler(this.BarCodeCtrl_Resize);
            this.ResumeLayout(false);

        }

        void PanelRoll_Paint(object sender, PaintEventArgs e)
        {

            WindowsFormsApplication2.ClsParamlist _param = new WindowsFormsApplication2.ClsParamlist();
               WindowsFormsApplication2.clsmnusettings _mnuset= new WindowsFormsApplication2.clsmnusettings();


            bcodeH = Convert.ToInt32(_param.GetParamvalue("BcodeH"));
            brateSize = Convert.ToInt32(_param.GetParamvalue("Bratesize"));
             bcompny = Convert.ToInt32(_param.GetParamvalue("BcompnySize"));
             bitem = Convert.ToInt32(_param.GetParamvalue("BitemSize"));

            bitemcode = Convert.ToInt32(_param.GetParamvalue("Bitemcodesize"));

          bitemlang = Convert.ToInt32(_param.GetParamvalue("Blangsize"));
           int dtvis= 0;
          dtvis =Convert.ToInt32 (_mnuset.GetMnustatus("203"));
          int Ploctn = 0;
          Ploctn = Convert.ToInt32(_mnuset.GetMnustatus("204"));


          if (Convert.ToInt32(_mnuset.GetMnustatus("223")) == 1)
          {

             fcompny = new Font("Calibri", bcompny);
            frate = new Font("Calibri", brateSize, FontStyle.Bold);
              fname = new Font("Calibri", bitem, FontStyle.Bold);
              fcode = new Font("Calibri", bitemcode, FontStyle.Bold);
             fdt = new Font("Calibri", 7, FontStyle.Bold);
             flangg = new Font("Calibri", bitemlang, FontStyle.Bold);

          }
          else
          {
           fcompny = new Font("Calibri", bcompny);
             frate = new Font("Calibri", brateSize);
             fname = new Font("Calibri", bitem);
             fcode = new Font("Calibri", bitemcode);
              fdt = new Font("Calibri", 7);
           flangg = new Font("Calibri", bitemlang);
          }


            String intercharacterGap = "0";

            String str = '*' + code.ToUpper() + '*';
            int strLength = str.Length;
            StrDate = DateTime.Now.ToString("MM-yy");

            for (int i = 0; i < code.Length; i++)
            {
                if (alphabet39.IndexOf(code[i]) == -1 || code[i] == '*')
                {
                    e.Graphics.DrawString("INVALID BAR CODE TEXT", Font, Brushes.Red, 10, 10);
                    return;
                }
            }

            String encodedString = "";

            for (int i = 0; i < strLength; i++)
            {
                if (i > 0)
                    encodedString += intercharacterGap;

                encodedString += coded39Char[alphabet39.IndexOf(str[i])];
            }

            int encodedStringLength = encodedString.Length;
            int widthOfBarCodeString = 0;
            double wideToNarrowRatio = 3;


            if (align != AlignType.Left)
            {
                for (int i = 0; i < encodedStringLength; i++)
                {
                    if (encodedString[i] == '1')
                        widthOfBarCodeString += (int)(wideToNarrowRatio * (int)weight);
                    else
                        widthOfBarCodeString += (int)weight;
                }
            }

            int x = 0;
            int wid = 0;
            int yTop = 0;
            SizeF hSize = e.Graphics.MeasureString(headerText, headerFont);
            SizeF fSize = e.Graphics.MeasureString(code, footerFont);
            SizeF PinfoSize = e.Graphics.MeasureString(this.PInfo, ProductFont);
            SizeF Pinfo1Size = e.Graphics.MeasureString(this.PInfo1, Rsfont);
            int headerX = 0;
            int footerX = 0;
            int PinfoX = 0;
            int PinfoX1 = 0;
            // leftMargin = 90;
            if (align == AlignType.Left)
            {
                x = leftMargin;
                headerX = leftMargin;
                footerX = leftMargin;
                PinfoX = leftMargin;
                PinfoX1 = leftMargin;
            }
            else if (align == AlignType.Center)
            {
                x = (Width - widthOfBarCodeString) / 2;
                headerX = (Width - (int)hSize.Width) / 2;
                footerX = (Width - (int)fSize.Width) / 2;
                PinfoX = (Width - (int)PinfoSize.Width) / 2;
                PinfoX1 = (Width - (int)PinfoSize.Width) / 2;
            }
            else
            {
                x = Width - widthOfBarCodeString - leftMargin;
                headerX = Width - (int)hSize.Width - leftMargin;
                footerX = Width - (int)fSize.Width - leftMargin;
                PinfoX = (Width - (int)PinfoSize.Width - leftMargin);
                PinfoX1 = (Width - (int)Pinfo1Size.Width - leftMargin);
            }

            if (showHeader)
            {
                yTop = (int)hSize.Height + topMargin;
                // yTop = (int)hSize.Height ;
                // yTop = 0;

                //InvImage = Application.StartupPath + @"\Images\" + "Logo.jpg";
                //if (System.IO.File.Exists(InvImage))
                //{
                //    Bitmap oInvImage = new Bitmap(InvImage);
                //    e.Graphics.DrawImage(oInvImage, new Rectangle(headerX, topMargin + 10, 30, 40));
                //    e.Graphics.DrawImage(oInvImage, new Rectangle(headerX + DistanceBysticker, topMargin + 10, 30, 40));
                //}


                //40headerFont
                if (Ploctn==-1)
            {


                e.Graphics.DrawString(headerText, fcompny, Brushes.Black, headerX+26, topMargin);
             }
                if (Ploctn == 1)
                {
                    e.Graphics.DrawString(this.PInfo, fname, Brushes.Black, headerX + 26, topMargin);//+15x
                    yTop += bitem;
                }
    
 
            }
            else
            {
                yTop = topMargin;
            }


            if (bcdpic == true)
            {

             // yTop   += (int)fSize.Height;
                //yTop = yTop + bcompny;
                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 50,
                    Height =bcodeH,
                };
                var writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.CODE_128;
                //"UTF-8"

                writer.Options = options;
                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.CODE_128;
               Bitmap newbit = new Bitmap(qr.Write(code));

               e.Graphics.DrawImage(newbit, x, yTop);//footerX//gafoor yTop+20
                //e.Graphics.DrawImage(newbit, x + DistanceBysticker, yTop);
                yTop = yTop + bcodeH;
            }



            if (bcdpic == true)
            {
                for (int i = 0; i < encodedStringLength; i++)
                {
                    if (encodedString[i] == '1')
                        wid = (int)(wideToNarrowRatio * (int)weight);
                    else
                        wid = (int)weight;
                    // wid = wid / 2;
                    //33
                    //e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x, yTop, wid, height);
                    //e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + DistanceBysticker, yTop, wid, height);
                    x += wid;
                }
            }

            yTop = yTop+15;

            if (Barcodeprintingin == "Namewithrate")
            {
                this.PInfo = this.PInfo + " (Srate " + this.PInfo1 + ")";
            }

            if (showFooter)
                //33

                if (bcdpic == true)
                {


                    //e.Graphics.DrawString(code, footerFont, Brushes.Black, footerX, yTop);
                    //e.Graphics.DrawString(code, footerFont, Brushes.Black, footerX + DistanceBysticker, yTop);


                    //yTop += (int)fSize.Height;
                    //33
                    //temname  this.ProductFont
                    if (Ploctn == -1)
                    {
                        e.Graphics.DrawString(this.PInfo, fname, Brushes.Black, PinfoX, yTop - 14);//+15x
                        yTop += bitem;
                    }
                    //if (Convert.ToInt32(_mnuset.GetMnustatus("197")) == 1)
                    //{
                    //    e.Graphics.DrawString(this.itemcodee, fcode, Brushes.Black, PinfoX , yTop);
                    //    yTop +=bitemcode ;//(int)fSize.Height;
                    //}


                    if (Convert.ToInt32(_mnuset.GetMnustatus("196")) == 1)
                    {
                        if (this.seclang!="")
                        {
                        e.Graphics.DrawString(this.seclang, flangg, Brushes.Black, PinfoX , yTop );
                        yTop += bitemlang +2 ;//(int)fSize.Height;
                        }
                    }


                    
                    //e.Graphics.DrawString(this.PInfo, newfntt, Brushes.Black, PinfoX + DistanceBysticker, yTop - 4);
                   
                
                }
                else
                {
                   // yTop += (int)fSize.Height;
                    //33this.headerFont2

                    e.Graphics.DrawString(this.PInfo, fname, Brushes.Black, PinfoX, yTop - 40);
                   // e.Graphics.DrawString(this.PInfo, this.headerFont2, Brushes.Black, PinfoX + DistanceBysticker, yTop - 40);
                    yTop += bitem;

                    if (Convert.ToInt32(_mnuset.GetMnustatus("197")) == 1)
                    {
                        e.Graphics.DrawString(this.itemcodee, fcode, Brushes.Black, PinfoX , yTop);
                        yTop += bitemcode;//(int)fSize.Height;
                    }



                    if (Convert.ToInt32(_mnuset.GetMnustatus("196")) == 1)
                    {
                        e.Graphics.DrawString(this.seclang, flangg, Brushes.Black, PinfoX , yTop - 10);
                        yTop += bitemlang +2;
                    }
                  
                
                }


            //yTop = yTop + bitem+20;

            if (Barcodeprintingin != "None" && Barcodeprintingin != "Namewithrate")
            {
                if (Barcodeprintingin == "MRP")
                {
                    //e.Graphics.DrawString("MRP", this.Rsfont, Brushes.Black, footerX, yTop - 2);
                    //e.Graphics.DrawString("MRP", this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 2);
                    //PinfoX1 = PinfoX1 + 20;
                }

                else
                {
                    //33
                    //e.Graphics.DrawString("MRP:", this.Rsfont, Brushes.Black, footerX, yTop - 6);
                    //e.Graphics.DrawString("MRP:", this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 6);
                    //PinfoX1 = PinfoX1 + 20;
                    //e.Graphics.DrawString(this.StrMrp, this.Rsfont, Brushes.Black, PinfoX1 + 8, yTop - 6);
                    //e.Graphics.DrawString(this.StrMrp, this.Rsfont, Brushes.Black, PinfoX1 + DistanceBysticker + 8, yTop - 6);

                    //yTop += (int)Rsfont.Height;
                    //e.Graphics.DrawString("MDP", this.Rsfont, Brushes.Black, footerX, yTop - 6);
                    //e.Graphics.DrawString("MDP", this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 6);
                    
                    //e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 8, yTop - 5);
                    //e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + DistanceBysticker + 8, yTop - 5);

                    //e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX, yTop - 5, 10, 12));
                    //e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + DistanceBysticker, yTop - 5, 10, 12));
                    //PinfoX1 = PinfoX1 + 10;

                    //e.Graphics.DrawString("SR", this.Rsfont, Brushes.Black, footerX, yTop - 4);
                    //e.Graphics.DrawString("SR", this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 4);
                    //PinfoX1 = PinfoX1 + 20;
                }
                //33
                //yTop -= (int)Rsfont.Height;
                //e.Graphics.DrawString(this.StrMrp, this.Rsfont, Brushes.Black, PinfoX1 + 8, yTop - 6);
                //e.Graphics.DrawString(this.StrMrp, this.Rsfont, Brushes.Black, PinfoX1 + DistanceBysticker + 8, yTop - 6);
                //yTop += (int)Rsfont.Height;
                //e.Graphics.DrawString(this.PInfo1 , this.Rsfont, Brushes.Black, PinfoX1 + 8, yTop-5 );
                //e.Graphics.DrawString(this.PInfo1 , this.Rsfont, Brushes.Black, PinfoX1 + DistanceBysticker + 8, yTop-5 );

                //string Temp;
                //Temp = WindowsFormsApplication2.CommonClass._Clspricecode.GetCode(Strprate);
                //e.Graphics.DrawString(Temp, this.headerFont, Brushes.Black, footerX + 100, yTop - 2);
                //e.Graphics.DrawString(Temp, this.headerFont, Brushes.Black, footerX + DistanceBysticker + 100, yTop - 2);

                if (bcdpic == true)
                {
                    if (Convert.ToInt32(_mnuset.GetMnustatus("197")) == 1)
                    {
                        e.Graphics.DrawString(this.itemcodee, fcode, Brushes.Black, PinfoX+80, yTop-8);
                        //yTop += bitemcode;//(int)fSize.Height;
                    }

                    //rate this.Rsfont
                    if (Convert.ToInt32(_mnuset.GetMnustatus("195")) == 1)
                    {
                    e.Graphics.DrawString("SR" + this.PInfo1 + "/-",frate, Brushes.Black, PinfoX1 , yTop - 8);//x+ 25
                    }
                        //e.Graphics.DrawString("SR" + this.PInfo1 + "/-", newfntt2, Brushes.Black, PinfoX1 + DistanceBysticker + 9, yTop - 6);
                }
                else
                {
                    if (Convert.ToInt32(_mnuset.GetMnustatus("195")) == 1)
                    {
                        e.Graphics.DrawString("SR" + this.PInfo1 + "/-", frate, Brushes.Black, PinfoX1 , yTop - 30);
                    }
                         //e.Graphics.DrawString("SR" + this.PInfo1 + "/-", newfntt2, Brushes.Black, PinfoX1 + DistanceBysticker + 9, yTop - 30);
                }

            if(dtvis==1)
         {

             if (Convert.ToInt32(_mnuset.GetMnustatus("225")) == 1)
                {
                    e.Graphics.DrawString(this.mandate, fdt, Brushes.Black, 30, yTop + 4);
                    e.Graphics.DrawString(this.exedate, fdt, Brushes.Black,30, yTop + 15);
                }
                else
                {

              e.Graphics.DrawString(this.exedate, fdt, Brushes.Black, 5, yTop + 4);
                }
          }




            }


            if (PrintManDate == true)
            {
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                //e.Graphics.DrawString("MFD:" + this.StrDate, footerFont, Brushes.Black, 5, yTop - 60, drawFormat);
                //e.Graphics.DrawString("MFD:" + this.StrDate, footerFont, Brushes.Black, 5 + DistanceBysticker, yTop - 60, drawFormat);
            }
            if (ShowSupplierCode == true)
            {
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                e.Graphics.DrawString(this.SuppCode, footerFont, Brushes.Black, 25, yTop - 60, drawFormat);
                e.Graphics.DrawString(this.SuppCode, footerFont, Brushes.Black, 25 + DistanceBysticker, yTop - 60, drawFormat);
            }
            if (Showitemnote1 == true)
            {
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                e.Graphics.DrawString(this.Itemnote1Str, footerFont, Brushes.Black, 35, yTop - 60, drawFormat);
                e.Graphics.DrawString(this.Itemnote1Str, footerFont, Brushes.Black, 315 + DistanceBysticker, yTop - 60, drawFormat);
            }

            panel1 = PanelRoll;


            //String intercharacterGap = "0";

            //String str = '*' + code.ToUpper() + '*';
            //int strLength = str.Length;
            //StrDate = DateTime.Now.ToString("MM-yy");

            //for (int i = 0; i < code.Length; i++)
            //{
            //    if (alphabet39.IndexOf(code[i]) == -1 || code[i] == '*')
            //    {
            //        e.Graphics.DrawString("INVALID BAR CODE TEXT", Font, Brushes.Red, 10, 10);
            //        return;
            //    }
            //}

            //String encodedString = "";

            //for (int i = 0; i < strLength; i++)
            //{
            //    if (i > 0)
            //        encodedString += intercharacterGap;

            //    encodedString += coded39Char[alphabet39.IndexOf(str[i])];
            //}

            //int encodedStringLength = encodedString.Length;
            //int widthOfBarCodeString = 0;
            //double wideToNarrowRatio = 3;


            //if (align != AlignType.Left)
            //{
            //    for (int i = 0; i < encodedStringLength; i++)
            //    {
            //        if (encodedString[i] == '1')
            //            widthOfBarCodeString += (int)(wideToNarrowRatio * (int)weight);
            //        else
            //            widthOfBarCodeString += (int)weight;
            //    }
            //}

            //int x = 0;
            //int wid = 0;
            //int yTop = 0;
            //SizeF hSize = e.Graphics.MeasureString(headerText, headerFont);
            //SizeF fSize = e.Graphics.MeasureString(code, footerFont);
            //SizeF PinfoSize = e.Graphics.MeasureString(this.PInfo, ProductFont);
            //SizeF Pinfo1Size = e.Graphics.MeasureString(this.PInfo1, Rsfont);
            //int headerX = 0;
            //int footerX = 0;
            //int PinfoX = 0;
            //int PinfoX1 = 0;
            ////leftMargin = 90;
            //if (align == AlignType.Left)
            //{
            //    x = leftMargin;
            //    headerX = leftMargin;
            //    footerX = leftMargin;
            //    PinfoX = leftMargin;
            //    PinfoX1 = leftMargin;
            //}
            //else if (align == AlignType.Center)
            //{
            //    x = (Width - widthOfBarCodeString) / 2;
            //    headerX = (Width - (int)hSize.Width) / 2;
            //    footerX = (Width - (int)fSize.Width) / 2;
            //    PinfoX = (Width - (int)PinfoSize.Width) / 2;
            //    PinfoX1 = (Width - (int)PinfoSize.Width) / 2;
            //}
            //else
            //{
            //    x = Width - widthOfBarCodeString - leftMargin;
            //    headerX = Width - (int)hSize.Width - leftMargin;
            //    footerX = Width - (int)fSize.Width - leftMargin;
            //    PinfoX = (Width - (int)PinfoSize.Width - leftMargin);
            //    PinfoX1 = (Width - (int)Pinfo1Size.Width - leftMargin);
            //}

            //if (showHeader)
            //{
            //    yTop = (int)hSize.Height + topMargin;
            //    // yTop = (int)hSize.Height ;
            //    // yTop = 0;

            //    //InvImage = Application.StartupPath + @"\Images\" + "Logo.jpg";
            //    //if (System.IO.File.Exists(InvImage))
            //    //{
            //    //    Bitmap oInvImage = new Bitmap(InvImage);
            //    //    e.Graphics.DrawImage(oInvImage, new Rectangle(headerX, topMargin + 10, 30, 40));
            //    //    e.Graphics.DrawImage(oInvImage, new Rectangle(headerX + DistanceBysticker, topMargin + 10, 30, 40));
            //    //}



            //    e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX, topMargin);
            //    e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX + DistanceBysticker, topMargin);
            //}
            //else
            //{
            //    yTop = topMargin;
            //}

            //for (int i = 0; i < encodedStringLength; i++)
            //{
            //    if (encodedString[i] == '1')
            //        wid = (int)(wideToNarrowRatio * (int)weight);
            //    else
            //        wid = (int)weight;
            //    // wid = wid / 2;
            //    e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x, yTop, wid, height);
            //    e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + DistanceBysticker, yTop, wid, height);
            //    x += wid;
            //}

            //yTop += height;


            //if (Barcodeprintingin == "Namewithrate")
            //{
            //    this.PInfo = this.PInfo + " (Srate " + this.PInfo1 + ")";
            //}

            //if (showFooter)
            //    e.Graphics.DrawString(code + " " + this.PInfo, footerFont, Brushes.Black, footerX, yTop);
            //e.Graphics.DrawString(code + " " + this.PInfo, footerFont, Brushes.Black, footerX + DistanceBysticker, yTop);
            //// yTop += (int)fSize.Height;
            ////e.Graphics.DrawString(this.PInfo, this.ProductFont, Brushes.Black, PinfoX, yTop);
            ////e.Graphics.DrawString(this.PInfo, this.ProductFont, Brushes.Black, PinfoX + DistanceBysticker, yTop);
            //yTop += (int)fSize.Height;
            ////if (Barcodeprintingin != "None" &&Barcodeprintingin != "Namewithrate")
            ////{
            ////    if (Barcodeprintingin == "MRP")
            ////    {
            ////        e.Graphics.DrawString("MRP", this.Rsfont, Brushes.Black, footerX, yTop - 2);
            ////        e.Graphics.DrawString("MRP", this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 2);
            ////        PinfoX1 = PinfoX1 + 20;
            ////    }

            ////    else
            ////    {
            ////        e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX, yTop, 10, 12));
            ////        e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + DistanceBysticker, yTop, 10, 12));
            ////    }

            ////    e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 9, yTop - 2);
            ////    e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + DistanceBysticker + 9, yTop - 2);
            ////}

            //e.Graphics.DrawString("MRP:" + StrMrp, this.Rsfont, Brushes.Black, footerX, yTop - 2);
            //e.Graphics.DrawString("MRP:" + StrMrp, this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 2);
            //PinfoX1 = PinfoX1 + 20;


            //e.Graphics.DrawString(SuppCode, this.headerFont, Brushes.Black, footerX + 100, yTop - 2);
            //e.Graphics.DrawString(SuppCode, this.headerFont, Brushes.Black, footerX + DistanceBysticker + 100, yTop - 2);

            //yTop += (int)fSize.Height;
            //e.Graphics.DrawString("BRP" + this.PInfo1, this.Rsfont, Brushes.Black, footerX, yTop - 2);
            //e.Graphics.DrawString("BRP" + this.PInfo1, this.Rsfont, Brushes.Black, footerX + DistanceBysticker, yTop - 2);

            //string Temp;
            //Temp = WindowsFormsApplication2.CommonClass._Clspricecode.GetCode(Strprate);
            //e.Graphics.DrawString(Temp, this.headerFont, Brushes.Black, footerX + 100, yTop - 2);
            //e.Graphics.DrawString(Temp, this.headerFont, Brushes.Black, footerX + DistanceBysticker + 100, yTop - 2);

            //if (PrintManDate == true)
            //{
            //    System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
            //    e.Graphics.DrawString("MFD:" + this.StrDate, footerFont, Brushes.Black, 5, yTop - 60, drawFormat);
            //    e.Graphics.DrawString("MFD:" + this.StrDate, footerFont, Brushes.Black, 5 + DistanceBysticker, yTop - 60, drawFormat);
            //}
            //if (ShowSupplierCode == true)
            //{
            //    System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
            //    e.Graphics.DrawString(this.SuppCode, footerFont, Brushes.Black, 25, yTop - 60, drawFormat);
            //    e.Graphics.DrawString(this.SuppCode, footerFont, Brushes.Black, 25 + DistanceBysticker, yTop - 60, drawFormat);
            //}
            //if (Showitemnote1 == true)
            //{
            //    System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
            //    e.Graphics.DrawString(this.Itemnote1Str, footerFont, Brushes.Black, 35, yTop - 60, drawFormat);
            //    e.Graphics.DrawString(this.Itemnote1Str, footerFont, Brushes.Black, 315 + DistanceBysticker, yTop - 60, drawFormat);
            //}

            //panel1 = PanelRoll;


        }

        void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        #endregion

        String alphabet39 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%*";

        String[] coded39Char = 
		{
			/* 0 */ "000110100", 
			/* 1 */ "100100001", 
			/* 2 */ "001100001", 
			/* 3 */ "101100000",
			/* 4 */ "000110001", 
			/* 5 */ "100110000", 
			/* 6 */ "001110000", 
			/* 7 */ "000100101",
			/* 8 */ "100100100", 
			/* 9 */ "001100100", 
			/* A */ "100001001", 
			/* B */ "001001001",
			/* C */ "101001000", 
			/* D */ "000011001", 
			/* E */ "100011000", 
			/* F */ "001011000",
			/* G */ "000001101", 
			/* H */ "100001100", 
			/* I */ "001001100", 
			/* J */ "000011100",
			/* K */ "100000011", 
			/* L */ "001000011", 
			/* M */ "101000010", 
			/* N */ "000010011",
			/* O */ "100010010", 
			/* P */ "001010010", 
			/* Q */ "000000111", 
			/* R */ "100000110",
			/* S */ "001000110", 
			/* T */ "000010110", 
			/* U */ "110000001", 
			/* V */ "011000001",
			/* W */ "111000000", 
			/* X */ "010010001", 
			/* Y */ "110010000", 
			/* Z */ "011010000",
			/* - */ "010000101", 
			/* . */ "110000100", 
			/*' '*/ "011000100",
			/* $ */ "010101000",
			/* / */ "010100010", 
			/* + */ "010001010", 
			/* % */ "000101010", 
			/* * */ "010010100" 
		};



        public void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            this.TopMargin = ThemalTopmargin;
            this.leftMargin = 50;
            yTop = this.TopMargin;
            for (int m = SRows; m < gridmain.Rows.Count; m++)
            {

                if (gridmain.Rows[m].Tag != null && IfInnextpage == false)
                {
                    if (gridmain.Rows[m].Tag.ToString() == "1")
                    {
                        VertAlign = DSBarCode.BarCodeCtrl.AlignType.Left;
                        BarCodeHeight = 30;
                        if (m != 0)
                        {
                            this.TopMargin = 12;
                        }

                        WindowsFormsApplication2.DBTask _Dbtask = new WindowsFormsApplication2.DBTask();
                        /*************For Get Heading Barcode***********/
                        double Dbtemp = Convert.ToDouble(_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=142"));
                        if (Dbtemp == 1)
                        {
                            StrHeader = _Dbtask.ExecuteScalar("select cname from TblCompanyMaster");
                        }
                        else
                        {
                            StrHeader = WindowsFormsApplication2.CommonClass._Paramlist.GetParamvalue("BarcodeHeading");
                        }
                        /*******************************************************/
                        string Strpname = gridmain.Rows[m].Cells["clnitemname"].Value.ToString();

                        if (Barcodeprintingin == "Srate")
                        {
                            Strprate = gridmain.Rows[m].Cells["clnsrate"].Value.ToString();
                        }
                        else if (Barcodeprintingin == "MRP")
                        {
                            Strprate = gridmain.Rows[m].Cells["ClnMRP"].Value.ToString();
                        }
                        StrBatchNo = _Dbtask.znllString(gridmain.Rows[m].Cells["clnitemnote"].Value);

                        StrItemnote2 = _Dbtask.znllString(gridmain.Rows[m].Cells["clnitemnote2"].Value);
                        string StrBarcode = _Dbtask.znllString(gridmain.Rows[m].Cells["clnbatch"].Value);
                        double temp = _Dbtask.znlldoubletoobject(gridmain.Rows[m].Cells["clnqty"].Value);
                        if (temp % 2 != 0)
                        {
                            temp = temp + 1;
                        }
                        int InNoofcpies;
                        if (temp > 5)
                            InNoofcpies = Convert.ToInt16(temp) / 5;
                        else
                            InNoofcpies = 1;
                        this.ShowHeader = true;
                        this.HeaderFont = new Font("Calibri", 8, FontStyle.Bold);
                        this.ProductFont = new Font("Calibri", 8, FontStyle.Regular);
                        this.Rsfont = new Font("Calibri", 9, FontStyle.Bold);
                        this.FooterFont = new Font("Calibri", 8, FontStyle.Regular);
                        this.HeaderText = StrHeader;
                        this.PInfo = Strpname;

                        if (Barcodeprintingin == "MRP")
                            this.PInfo1 = "MRP: " + Strprate;
                        else
                            this.PInfo1 = Strprate;

                        this.BarCode = StrBarcode;
                        this.ShowFooter = true;
                        this.Noofcpies = InNoofcpies;
                        for (int k = 0; k < Noofcpies; k++)
                        {

                            String intercharacterGap = "0";
                            String str = '*' + code.ToUpper() + '*';
                            int strLength = str.Length;

                            for (int i = 0; i < code.Length; i++)
                            {
                                if (alphabet39.IndexOf(code[i]) == -1 || code[i] == '*')
                                {
                                    e.Graphics.DrawString("INVALID BAR CODE TEXT", Font, Brushes.Red, 10, 10);
                                    return;
                                }
                            }

                            String encodedString = "";

                            for (int i = 0; i < strLength; i++)
                            {
                                if (i > 0)
                                    encodedString += intercharacterGap;

                                encodedString += coded39Char[alphabet39.IndexOf(str[i])];
                            }

                            int encodedStringLength = encodedString.Length;
                            int widthOfBarCodeString = 0;
                            double wideToNarrowRatio = 3;


                            if (align != AlignType.Left)
                            {
                                for (int i = 0; i < encodedStringLength; i++)
                                {
                                    if (encodedString[i] == '1')
                                        widthOfBarCodeString += (int)(wideToNarrowRatio * (int)weight);
                                    else
                                        widthOfBarCodeString += (int)weight;
                                }
                            }

                            int x = 0;
                            int wid = 0;

                            SizeF hSize = e.Graphics.MeasureString(headerText, headerFont);
                            SizeF fSize = e.Graphics.MeasureString(code, footerFont);
                            SizeF PinfoSize = e.Graphics.MeasureString(this.PInfo, ProductFont);
                            SizeF Pinfo1Size = e.Graphics.MeasureString(this.PInfo1, Rsfont);
                            int headerX = 0;
                            int footerX = 0;
                            int PinfoX = 0;
                            int PinfoX1 = 0;
                            int PinfoX2 = 0;
                            int PinfoX3 = 0;

                            if (align == AlignType.Left)
                            {
                                x = leftMargin;
                                headerX = leftMargin;
                                footerX = leftMargin;
                                PinfoX = leftMargin;
                                PinfoX1 = leftMargin;
                                PinfoX2 = leftMargin;
                                PinfoX3 = leftMargin;
                            }
                            else if (align == AlignType.Center)
                            {
                                x = (Width - widthOfBarCodeString) / 2;
                                headerX = (Width - (int)hSize.Width) / 2;
                                footerX = (Width - (int)fSize.Width) / 2;
                                PinfoX = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX1 = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX2 = (Width - (int)PinfoSize.Width) / 2;
                                PinfoX3 = (Width - (int)PinfoSize.Width) / 2;
                            }
                            else
                            {
                                x = Width - widthOfBarCodeString - leftMargin;
                                headerX = Width - (int)hSize.Width - leftMargin;
                                footerX = Width - (int)fSize.Width - leftMargin;
                                PinfoX = (Width - (int)PinfoSize.Width - leftMargin);
                                PinfoX1 = (Width - (int)Pinfo1Size.Width - leftMargin);
                                PinfoX2 = (Width - (int)PinfoSize.Width - leftMargin);
                                PinfoX3 = (Width - (int)Pinfo1Size.Width - leftMargin);
                            }

                            if (showHeader)
                            {
                                yTop = yTop + (int)hSize.Height + topMargin;
                                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX, yTop - 14);
                                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX + 160, yTop - 14);
                                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX + 320, yTop - 14);
                                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX + 480, yTop - 14);
                                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX + 640, yTop - 14);
                                this.TopMargin = 12;


                            }
                            else
                            {
                                yTop = topMargin;
                            }

                            for (int i = 0; i < encodedStringLength; i++)
                            {
                                if (encodedString[i] == '1')
                                    wid = (int)(wideToNarrowRatio * (int)weight);
                                else
                                    wid = (int)weight;

                                e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x, yTop, wid, height);
                                e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + 160, yTop, wid, height);
                                e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + 320, yTop, wid, height);
                                e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + 480, yTop, wid, height);
                                e.Graphics.FillRectangle(i % 2 == 0 ? Brushes.Black : Brushes.White, x + 640, yTop, wid, height);

                                x += wid;
                            }

                            yTop += height;

                            if (showFooter)
                                e.Graphics.DrawString(code, this.Rsfont, Brushes.Black, footerX, yTop);
                            e.Graphics.DrawString(code, this.Rsfont, Brushes.Black, footerX + 160, yTop);
                            e.Graphics.DrawString(code, this.Rsfont, Brushes.Black, footerX + 320, yTop);
                            e.Graphics.DrawString(code, this.Rsfont, Brushes.Black, footerX + 480, yTop);
                            e.Graphics.DrawString(code, this.Rsfont, Brushes.Black, footerX + 640, yTop);

                            yTop += (int)fSize.Height - 4;
                            e.Graphics.DrawString(this.PInfo, this.Rsfont, Brushes.Black, PinfoX, yTop);
                            e.Graphics.DrawString(this.PInfo, this.Rsfont, Brushes.Black, PinfoX + 160, yTop);
                            e.Graphics.DrawString(this.PInfo, this.Rsfont, Brushes.Black, PinfoX + 320, yTop);
                            e.Graphics.DrawString(this.PInfo, this.Rsfont, Brushes.Black, PinfoX + 480, yTop);
                            e.Graphics.DrawString(this.PInfo, this.Rsfont, Brushes.Black, PinfoX + 640, yTop);
                            yTop += (int)fSize.Height - 2;
                            if (Barcodeprintingin == "Srate")
                            {
                                e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX, yTop, 10, 12));
                                e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + 160, yTop, 10, 12));
                                e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + 320, yTop, 10, 12));
                                e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + 480, yTop, 10, 12));
                                e.Graphics.DrawImage(this.Rupeeimg, new Rectangle(footerX + 640, yTop, 10, 12));
                                PinfoX1 = PinfoX1 + 10;
                            }
                            e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1, yTop - 2);
                            e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 160, yTop - 2);
                            e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 320, yTop - 2);
                            e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 480, yTop - 2);
                            e.Graphics.DrawString(this.PInfo1, this.Rsfont, Brushes.Black, PinfoX1 + 640, yTop - 2);

                            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
                            this.StrDate = Convert.ToDateTime(this.StrDate).ToString("MMM-yyyy");

                            e.Graphics.DrawString("Pk.Dt:" + this.StrDate, footerFont, Brushes.Black, 13, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Pk.Dt:" + this.StrDate, footerFont, Brushes.Black, 13 + 160, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Pk.Dt:" + this.StrDate, footerFont, Brushes.Black, 13 + 320, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Pk.Dt:" + this.StrDate, footerFont, Brushes.Black, 13 + 480, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Pk.Dt:" + this.StrDate, footerFont, Brushes.Black, 13 + 640, yTop - 60, drawFormat);



                            e.Graphics.DrawString("Exp:" + this.StrItemnote2, footerFont, Brushes.Black, 23, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Exp:" + this.StrItemnote2, footerFont, Brushes.Black, 23 + 160, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Exp:" + this.StrItemnote2, footerFont, Brushes.Black, 23 + 320, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Exp:" + this.StrItemnote2, footerFont, Brushes.Black, 23 + 480, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Exp:" + this.StrItemnote2, footerFont, Brushes.Black, 23 + 640, yTop - 60, drawFormat);



                            e.Graphics.DrawString("Batch:" + this.StrBatchNo, footerFont, Brushes.Black, 33, yTop - 50, drawFormat);
                            e.Graphics.DrawString("Batch:" + this.StrBatchNo, footerFont, Brushes.Black, 33 + 160, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Batch:" + this.StrBatchNo, footerFont, Brushes.Black, 33 + 320, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Batch:" + this.StrBatchNo, footerFont, Brushes.Black, 33 + 480, yTop - 60, drawFormat);
                            e.Graphics.DrawString("Batch:" + this.StrBatchNo, footerFont, Brushes.Black, 33 + 640, yTop - 60, drawFormat);


                            RowNo++;


                            yTop = yTop + 5;
                            if (RowNo > 13)
                            {

                            }
                            else
                            {

                            }
                        }

                    }
                }
            }
        }
        public void PrintDocumentBarcode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //// leftMargin = (int)e.MarginBounds.Left;
            //leftMargin = 50;
            ////rightMargin = (int)e.MarginBounds.Right;
            //rightMargin = 750;
            //topMargin = (int)e.MarginBounds.Top;
            //// topMargin = 50;
            ////bottomMargin = (int)e.MarginBounds.Bottom;
            //bottomMargin = 1000;
            //// InvoiceWidth = (int)e.MarginBounds.Width;
            //InvoiceWidth = 700;
            //// InvoiceHeight = (int)e.MarginBounds.Height;
            //InvoiceHeight = 900;



            Doc_PrintPage(e.Graphics, e);

            //ReadInvoice = true;

        }
        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (Ptype == "Laser")
                {
                    Doc_PrintPage(e.Graphics, e);
                    //  panel1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
                }
                else
                {
                    new System.Drawing.Printing.PaperSize("ddd", Convert.ToInt32(8 * 37.795275591f), Convert.ToInt32(2.5 * 37.795275591f));
                    PanelRoll_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));
                }
            }
            catch
            {
            }
        }

        public void SaveImage(String file)
        {
            Bitmap bmp = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(bmp);
            //g.FillRectangle(Brushes.White, 0, 0, 800, Height);
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);

            panel1_Paint(null, new PaintEventArgs(g, this.ClientRectangle));

            bmp.Save(file);
        }


        //public Bitmap GetBarcode(Font headerfont,Font productfont,Font Rsfont,Font footerfonter,string headertext,string pininfo,string pininfo1,string barcode)
        public Image LogoImgaeFu
        {
            get { return Rupeeimg; }
            set { Rupeeimg = value; panel1.Invalidate(); }
        }

        public Image RupeeImgaeFu
        {
            get { return Rupeeimg; }
            set { Rupeeimg = value; panel1.Invalidate(); }
        }
        public Bitmap GetBarcode()
        {
            Bitmap bmp = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);

            panel1_Paint(null, new PaintEventArgs(g, this.ClientRectangle));
            return bmp;
        }

        private void BarCodeCtrl_Resize(object sender, System.EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
