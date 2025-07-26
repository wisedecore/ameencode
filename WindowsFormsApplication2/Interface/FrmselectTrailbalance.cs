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
    public partial class FrmselectTrailbalance : Form
    {
        public FrmselectTrailbalance()
        {
            InitializeComponent();
        }
        ClsReports _ReportClass = new ClsReports();
        Clsforms _Forms = new Clsforms();
        Clssettings _Settings = new Clssettings();
        NextGFuntion _NextgFunction = new NextGFuntion();

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        public void Clear()
        {
            Dtfrom.Value = _Settings.GetFyearFrom();
            ChangeLanguage();
        }
        public void Main()
        {
            Clsselectreport.RType = "TrailBalance";
            Clsselectreport.RQuery = CommonClass._report.Query;
            Clsselectreport.RQueryTemp = CommonClass._report.QueryTemp;
            Clsselectreport.RQueryDetail = CommonClass._report.QueryDetail;
            Clsselectreport.RDtfrom = Dtfrom.Value;
            Clsselectreport.Rdtto = Dtto.Value;
            CommonClass._Clreport.ShowReport(this,true);
            
            //_Forms.ShowTrailBalance(Dtfrom.Value, Dtto.Value);
        }
        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void FrmselectTrailbalance_Load(object sender, EventArgs e)
        {
            _NextgFunction.FormStylesett(this);
            //_NextgFunction.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
           // _NextgFunction.FormHeadStyle(pnlHead);
            //_NextgFunction.FormImage(pnlImage);
            Clear();
            CommonClass._Nextg.FormIcon(this);

        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmselectTrailbalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
           
        }

        private void FrmselectTrailbalance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                Main();
            }
        }
       
    }
}
