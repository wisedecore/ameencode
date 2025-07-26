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
    public partial class Frmselectanalysisreport : Form
    {
        public Frmselectanalysisreport()
        {
            InitializeComponent();
        }
        FrmReport _Report = new FrmReport();
        NextGFuntion _Nextg = new NextGFuntion();

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TreeViewConvertion(TreeMain);
            }
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool ValidationFu()
        {
            return true;
        }
        public void NextgInitialize()
        {
            _Report.DTFrom = Convert.ToDateTime(Dtfrom.Value.ToString("dd/MM/yyyy"));
            _Report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MM/yyyy"));
            CommonClass._report.ReportType = "Analysissalesandpurchase";
        }
        public void ShowReport()
        {
            _Report.Show();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
                    ShowReport();

                    return true;

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Frmselectanalysisreport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmselectanalysisreport_Load(object sender, EventArgs e)
        {
            _Nextg.FormStylesett(this);
            _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            _Nextg.FormHeadStyle(pnlHead);
           // _Nextg.FormImage(pnlImage);
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        private void pnlHead_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
