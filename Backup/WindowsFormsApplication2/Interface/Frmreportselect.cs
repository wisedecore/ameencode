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
    public partial class Frmreportselect : Form
    {
        NextGFuntion _Nextg = new NextGFuntion();
        Clsforms _Forms = new Clsforms();

        bool Spharmacy;
        string temp;

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        public Frmreportselect()
        {
            InitializeComponent();
        }
        public void ShowStockreport()
        {
            FrmSelectStockList _Stock = new FrmSelectStockList();
            
           // _Stock.MdiParent = this;
            _Stock.ShowDialog();
        }
        public void ShowSelecttrailbalance()
        {
            FrmselectTrailbalance _TrailbalanceSelect = new FrmselectTrailbalance();
            //_Ledger.MdiParent = this;
            _TrailbalanceSelect.ShowDialog();
        }
        
        public void ShowLedgerreport()
        {
            Frmselectaccountreport _Ledger = new Frmselectaccountreport();
            //_Ledger.MdiParent = this;
            _Ledger.ShowDialog();
        }
        public void Showpandlreport()
        {
            FrmSelectPandL _PandL = new FrmSelectPandL();
            //_PandL.MdiParent = this;
            _PandL.ShowDialog();
        }
        private void Stockreport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowStockreport();
        }

        private void salesreport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // ShowSalesreport();
        }

        private void purchasereport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Showpurchasereport();
        }

        private void ledgerreport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLedgerreport();
        }

        private void pandlreport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showpandlreport();
        }

        private void Frmreportselect_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Frmreportselect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Frmreportselect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void Frmreportselect_KeyUp(object sender, KeyEventArgs e)
        {

        }
        public void ShowAnalysisReport()
        {
            Frmselectanalysisreport _Analysis = new Frmselectanalysisreport();
            //_Analysis.MdiParent = this;
            _Analysis.ShowDialog();
        }
        private void analysisireport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAnalysisReport();
        }

        private void daybook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmselectdaybook _Daybook = new Frmselectdaybook();
            _Daybook.ShowDialog();
        }
        public void Showproductionreport()
        {
            Frmselectproduction _Productionreport = new Frmselectproduction();
            _Productionreport.ShowDialog();
        }

        private void linkproductionreport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Showproductionreport();
        }

        private void cmdStockReport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnustockreport.PerformClick();
        }

        private void cmdProductionReport_Click(object sender, EventArgs e)
        {
            Showproductionreport();
        }

        private void cmdDaybook_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnudaybook.PerformClick();

        }

        private void cmdLedgerReport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnuledgerreport.PerformClick();
        }

        private void cmdAnalysisReport_Click(object sender, EventArgs e)
        {
            ShowAnalysisReport();
        }

        private void cmdSalesReport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnusalesreport.PerformClick();
        }

        private void cmdPurchaseReport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnupurchasereport.PerformClick();
        }

        public void setuserwise()
        {
            string user = ClsUserDetails.MUserName;
            if (CommonClass._UserDetails.Permitedblock() == true)
            {
                CommonClass._UserDetails.FillCombo(Comuser);
                Chkalluser.Checked = true;
            }
            else
            {
                CommonClass._UserDetails.FillCombobyuser(Comuser, user);
                Chkalluser.Enabled = false;
            }
           
        }




        private void Frmreportselect_Load(object sender, EventArgs e)
        {
            if (Generalfunction.EPharmacy == false)
                cmdexpiryreport.Visible = false;
            ChangeLanguage();
            //_Nextg.FormStylesett(this);
            //_Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            //_Nextg.FormImage(pnlImage);
            setuserwise();
            CommonClass._Nextg.FormIcon(this); 


        }

        private void cmdshowtrailbalance_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnutrailbalance.PerformClick();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdbalancesheet_Click(object sender, EventArgs e)
        {
            CommonClass._Forms.ShowBalancesheet(DateTime.Now, DateTime.Now);
            Clsselectreport.RType = CommonClass._report.ReportType;
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;
            CommonClass._Clreport.ShowReport(this,true);
        }

        private void cmdexpiryreport_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            _Forms.ShowExpiryReport();
        }

        private void cmdStocktransferReport_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).mnustocktransferreport.PerformClick();
        }
        public void User()
        {
            Frmreport2 _Report = new Frmreport2();

            if (Chkalluser.Checked == false)
            {
                Frmreport2.Userid = " and uid='" +CommonClass._Dbtask.znllString( Comuser.Text) + "'";
            }
            else
            {
                Frmreport2.Userid = "";
            }
        }
        private void CmdSummeryrprt_Click(object sender, EventArgs e)
        {

            User();
            (this.MdiParent as MDIParent2).itemListReportToolStripMenuItem.PerformClick();
            //(this.MdiParent as MDIParent2).itemListReportToolStripMenuItem.PerformClick();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).tailortoolStripMenuItem3.PerformClick();
        }

        private void Cmdtaxreprtsummry_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).tAXSummeryToolStripMenuItem.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.MdiParent as MDIParent2).taxSummeryTwoMenuItem.PerformClick();
        }
       
    }
}
