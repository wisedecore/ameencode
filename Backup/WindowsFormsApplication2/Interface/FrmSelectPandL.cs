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
    public partial class FrmSelectPandL : Form
    {
        public FrmSelectPandL()
        {
            InitializeComponent();
        }
        ClsDepot _Depot = new ClsDepot();
        DataSet Ds = new DataSet();
        public string Sql;
        DBTask _Dbtask = new DBTask();
        NextGFuntion _Nextg = new NextGFuntion();
        private void FrmSelectPandL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        public void Main()
        {
            FrmReport _Report = new FrmReport();
            CommonClass._report.ReportType = "P&L Report";
            _Report.DTFrom = DtFrom.Value;
            _Report.DTTo = DtTo.Value;

            Clsselectreport.RType = CommonClass._report.ReportType;
            Clsselectreport.RQuery = _Report.Query;
            Clsselectreport.RDtfrom = _Report.DTFrom;
            Clsselectreport.Rdtto = _Report.DTTo;

            CommonClass._Clreport.ShowReport(this,true);
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void Clear()
        {
            DtFrom.Value =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
        }

        private void FrmSelectPandL_Load(object sender, EventArgs e)
        {
            _Nextg.FormStylesett(this);
            Clear();
            CommonClass._Nextg.FormIcon(this);
        }

        
        private void FrmSelectPandL_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
                Main();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
