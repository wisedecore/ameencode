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
    public partial class Selectzatpandl : Form
    {
        public Selectzatpandl()
        {
            InitializeComponent();
        }
        Generalfunction _Gen = new Generalfunction();
        NextGFuntion _NextgFunction = new NextGFuntion();
        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void Clear()
        {
          //  Dtfrom.Value = _Gen.GetFyearFrom();
            _NextgFunction.FormStylesett(this);
            ChangeLanguage();
           
        }
        public void Main()
        {
            CommonClass._report.DTFrom = Convert.ToDateTime(Dtfrom.Value.ToString("dd/MMM/yyyy"));
            CommonClass._report.DTTo = Convert.ToDateTime(DtTo.Value.ToString("dd/MMM/yyyy"));

            if(radsummery.Checked==true)
            Clsselectreport.RType = "QplexP&L";
            else if(raddetail.Checked==true)
                Clsselectreport.RType = "QplexP&Ldetail";
            else
                Clsselectreport.RType = "QplexP&Ldate";


            Clsselectreport.RQuery = "select * from tblgeneralledger ";
            Clsselectreport.RQueryTemp = CommonClass._report.QueryTemp;
            Clsselectreport.RQueryDetail = CommonClass._report.QueryDetail;
            Clsselectreport.RDtfrom = CommonClass._report.DTFrom;
            Clsselectreport.Rdtto = CommonClass._report.DTTo;
            CommonClass._Clreport.ShowReport(this,true);

        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Selectzatpandl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void Selectzatpandl_Load(object sender, EventArgs e)
        {
            Clear();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GroupBoxConvertion(grpselection);
            }
        }
        private void Selectzatpandl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
                Main();
        }
    }
}
