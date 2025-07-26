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
    public partial class Frmstocktransferdetails : Form
    {
        public Frmstocktransferdetails()
        {
            InitializeComponent();
        }
        DBTask _dbtask = new DBTask();
        Frmreport2 _rep2 = new Frmreport2();

        private void Frmstocktransferdetails_Load(object sender, EventArgs e)
        {
            clear();
        }

        public void MAIN()
        {
             string toarea ="";
            if (Chkall.Checked == true)
            {
                _rep2.Dquery = "";
                toarea =" ";
            }
            else
            {
                _rep2.Dquery = "";

                toarea = "and  dcodeto='"+ _dbtask.znllString( comtoarea.SelectedValue)+"' ";
            }
           

            string query="SELECT TblinternelTransfer.tcode, TblinternelTransfer.dcodefrom, "+
                         " TblinternelTransfer.dcodeto,TblinternelTransfer.tdate,  "+
                         "  Tbltransferdetails.tcode,Tbltransferdetails.batchid,Tbltransferdetails.pcode,  " +
                         " Tbltransferdetails.qty,Tbltransferdetails.rate   "+
                         " FROM TblinternelTransfer JOIN Tbltransferdetails "+
                         " ON TblinternelTransfer.tcode =Tbltransferdetails.tcode  "+
                         " where tdate between '" + dtFROMdate.Value.ToString("MM/dd/yyyy  00:00:00 ") + "' and '" + dtTodate.Value.ToString("MM/dd/yyyy  23:59:59 ") + "'  "+
                         " "+toarea+" " ;

            _rep2.Dquery =query;
            Frmreport2.DTFrom = dtFROMdate.Value;
            Frmreport2.Dtto = dtTodate.Value;
            
            _rep2.Reporttype = "stocktranferdetailsall";
            MaxforSett(_rep2);
            _rep2.ShowDialog();
            

        }
        public void MaxforSett(Form Frm)
        {
            // Frm.Size = new System.Drawing.Size(this.Width - 40, this.Size.Height - 130 - toolStrip.Height);
            Frm.Location = new Point(0, 0);
            Frm.Size = new System.Drawing.Size(1200, 885);

            // Frm.Size = new System.Drawing.Size(
        }
        public void clear()
        {
            CommonClass._Depot.FillCombo(comtoarea);
         
            Chkall.Checked = true;
        }

        private void cmdshow_Click(object sender, EventArgs e)
        {
            MAIN();
        }

        private void Chkall_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkall.Checked == true)
            {
                comtoarea.Enabled = false;
            }
            else
            {
                comtoarea.Enabled = true;
            }
        }


    }
}
