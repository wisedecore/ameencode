using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmprintmain : Form
    {
        public Frmprintmain()
        {
            InitializeComponent();
        }
        public string SelectedPrintDesign = "Dotmetrix";
       
        LPrinter MyPrinter=new LPrinter();
        ClsParamlist _Paramlist = new ClsParamlist();
        Clsdotmetrixprintsettings _Dotmetrix = new Clsdotmetrixprintsettings();
        public string Richtext;
       /***********************/
        public string Pselect;

      

        /*For Following Use Invoice Design*/
        public static string DType;
        public string SelectedNode;
        public string SelectedNodeText;
        public int LocationX;
        public int LocationY;
        public string LoadField = "";
       
        private void Frmprintmain_Load(object sender, EventArgs e)
        {
           if(Pselect=="1")
               Richmain.Font = new System.Drawing.Font("Lucida Console", 6);
            Richmain.Text = Richtext;
            Showpreview();
        }
        public void Showpreview()
        {
         DType = "Preview";
         pnlleftpanel.Visible = false;
         pnlsettings.Visible = false;
       //  Richmain.ReadOnly = true;
        }
        private void cmdpreview_Click(object sender, EventArgs e)
        {
            Showpreview();
        }
        public void Showdesign()
        {
            LoadField = "D:\\sa.rtf";
            Richmain.LoadFile(LoadField);
            DType = "Design";
            pnlleftpanel.Visible = true;
            pnltoppanel.Visible = true;
            pnlsettings.Visible = true;
            Richmain.Enabled = true;
            Richmain.ReadOnly = false;
            FillSettings();
            trvmain.ExpandAll();
        }
        public void FillSettings()
        {
            _Dotmetrix.BackScroll = _Paramlist.GetParamvalue("Bscroll");
            _Dotmetrix.FScroll = _Paramlist.GetParamvalue("Fscroll");

            txtsreverse.Text = _Dotmetrix.BackScroll;
            txtsforward.Text = _Dotmetrix.FScroll;
        }
        private void Picprinter_Click(object sender, EventArgs e)
        {

            if (!MyPrinter.Open("Qplex Print")) return;
            MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
            MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
            MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
            MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
            MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());

            MyPrinter.Print(Richmain.Text);
            // MyPrinter.Print("===================================\r\n");
            MyPrinter.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                pictureBox1_Paint(sender, new PaintEventArgs(e.Graphics, this.ClientRectangle));

            }
            catch
            {
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Font headerFont = new Font("Calibri", 8);
            e.Graphics.DrawString(Richmain.Text, headerFont, Brushes.Black, 0, 0);
        }

        private void cmdprintdesign_Click(object sender, EventArgs e)
        {
            Showdesign();
        }
        
        private void trvmain_DoubleClick(object sender, EventArgs e)
        {
            TreeviewDoubleClick();
        }
        public void InsertInGrid()
        {
            if (DType == "Design")
            {
                Clipboard.SetText("<"+SelectedNodeText+">");

                Richmain.Paste();
            }
        }
        public void TreeviewDoubleClick()
        {
            if (trvmain.SelectedNode.Name != null)
            {
                SelectedNode = trvmain.SelectedNode.Name;
                SelectedNodeText = trvmain.SelectedNode.Text;
                if (SelectedNode != "NdMheader" && SelectedNode != "Ndmpageheader" && SelectedNode != "Ndhitemdetails" && SelectedNode != "Ndhreportfooter" && SelectedNode != "Ndhformatingtags")
                {
                    InsertInGrid();
                }
            }
        }

        private void Richmain_MouseClick(object sender, MouseEventArgs e)
        {
           // string searchString = "brown";
            int positionToSearch = Richmain.GetCharIndexFromPosition(new Point(e.X, e.Y));
            // Search for the search string text within the control from the point the user clicked. 
           // int textLocation = Richmain.Find(searchString, positionToSearch, RichTextBoxFinds.None);
           /// Richmai
            Richmain.Select(positionToSearch, 0);
        }

        private void txtsleft_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Generalfunction.allowNumeric(sender, e);
        }

        private void txtswidth_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Generalfunction.allowNumeric(sender, e);
        }

        private void txtsitemlines_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Generalfunction.allowNumeric(sender, e);
        }

        private void txtsreverse_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Generalfunction.allowNumeric(sender, e);
        }

        private void txtsforward_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Generalfunction.allowNumeric(sender, e);
        }

        private void txtsfooter_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Generalfunction.allowNumeric(sender, e);
        }
        public void SaveSettings()
        {
            if (SelectedPrintDesign == "Dotmetrix")
            {
                _Dotmetrix.BackScroll = txtsreverse.Text;
                _Dotmetrix.FScroll = txtsforward.Text;
                _Dotmetrix.SaveDotMetrix();
            }
            else if (SelectedPrintDesign == "Laser")
            {
            }
        }
        private void cmdsavesettings_Click(object sender, EventArgs e)
        {
           // SaveSettings();
            DesignSaveRt();
        }
        public void DesignSaveRt()
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Invoice Design File";
            theDialog.Filter = "Invoice Design File|*.rtf";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                string Filepath = theDialog.FileName;

                Richmain.SaveFile(Filepath);
            }

        }

   
    }
}
