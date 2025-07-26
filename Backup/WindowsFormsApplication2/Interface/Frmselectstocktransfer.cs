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
    public partial class Frmselectstocktransfer : Form
    {
        public Frmselectstocktransfer()
        {
            InitializeComponent();
        }
        string Reporttype;
        string Where;

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TabBasedConversion(tabmainSummury);
                CommonClass._Language.TabBasedConversion(tabMainDetail);
            }
        }

        public void Fillcombo()
        {

        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
           // Stransfersummury
            CommonClass._report.DTFrom = Convert.ToDateTime(Dtfrom.Value.ToString("dd/MMM/yyyy"));
            CommonClass._report.DTTo = Convert.ToDateTime(Dtto.Value.ToString("dd/MMM/yyyy"));
            Reporttype = "Stock Transfer Summury";

            Clsselectreport.RType = Reporttype;
            Clsselectreport.RQuery = CommonClass._report.Query + "" + Where;
            Clsselectreport.RQueryTemp = CommonClass._report.QueryTemp;
            Clsselectreport.RQueryDetail = CommonClass._report.QueryDetail;
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;

            //NextgInitialize();
            CommonClass._Clreport.ShowReport(this,true);
        }

        private void Frmselectstocktransfer_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

       
    }
}
