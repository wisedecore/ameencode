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
    public partial class Frmbillwisesettlereport : Form
    {
        public Frmbillwisesettlereport()
        {
            InitializeComponent();
        }
        public string cusid = "";
        public  static string conditn = "";

        private void txtcusctomer_TextChanged(object sender, EventArgs e)
        {
            if (MDIParent2.billsetSI == true)
            {


                CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtcusctomer.Text, uscitemshowsimple2, 1);
            }
            else
            {
                CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtcusctomer.Text, uscitemshowsimple2, 2);
            }
            
            
            }

        private void txtcusctomer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtcusctomer);
            if (e.KeyValue == 13)
            {
                cusid = CommonClass._Dbtask.znllString(txtcusctomer.Tag);
            }

            if (e.KeyValue == 27)
            {

                uscitemshowsimple2.Visible = false;
            }
        }

        private void Frmbillwisesettlereport_Load(object sender, EventArgs e)
        {
            cusid = "";

            
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            if (conditn=="SI")
            {
                Clsselectreport.RType = "BillwisesettilementData";
            }
            if (conditn == "PI")
            {
                Clsselectreport.RType = "BillwisesettilementPurchData";
            }
            if (conditn == "SR")
            {
                Clsselectreport.RType = "BillwisesettilementSR";
            }
            if (conditn == "PR")
            {
                Clsselectreport.RType = "BillwisesettilementPR";
            }
            Clsselectreport.agvnolid = CommonClass._Dbtask.znllString(txtcusctomer.Tag);
            CommonClass._Clreport.ShowReport(this, true);
        
        
        
        
        }
    }
}
