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
    public partial class Frmselectdaybook : Form
    {
        public Frmselectdaybook()
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
            }
        }

        private void Frmselectdaybook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void ShowReport()
        {
              NextgInitialize();
              Clsselectreport.RTypeSecond = _Report.ReportTypeSecond;
              Clsselectreport.RType = CommonClass._report.ReportType;
              Clsselectreport.RQuery = _Report.Query;
              Clsselectreport.RQueryTemp = _Report.QueryTemp;
              Clsselectreport.RQueryDetail = _Report.QueryDetail;
              Clsselectreport.RDtfrom = _Report.DTFrom;
              Clsselectreport.Rdtto = _Report.DTTo;
              CommonClass._Clreport.ShowReport(this,true);

        }
        public void NextgInitialize()
        {
            _Report.DTFrom = Convert.ToDateTime(Dtfrom.Value);
            _Report.DTTo = Convert.ToDateTime(DtTo.Value);

            CommonClass._report.ReportType = "Daybook";
            if (Radsummery.Checked == true)
            {
                _Report.ReportTypeSecond = "Summury";
            }
            else
            {
                _Report.ReportTypeSecond = "Detail";
            }
            _Report.Query = "select * from tblgeneralledger ";
            
           
        }
        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        private bool ValidationFu()
        {
            return true;
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    // NextgInitialize();
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

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmselectdaybook_Load(object sender, EventArgs e)
        {
            //_Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            _Nextg.FormStylesett(this);
            Dtfrom.Value = CommonClass._Gen.FuFromdateReportdef();
            DtTo.Value = CommonClass._Gen.FuTodateReportdef();
            //_Nextg.FormImage(pnlImage);
            ChangeLanguage();

            CommonClass._Nextg.FormIcon(this);
        }

        private void Frmselectdaybook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                Main();
            }
        }

      
    
    }
}
