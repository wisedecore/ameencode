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
    public partial class Frmexpiryreport : Form
    {
        public Frmexpiryreport()
        {
            InitializeComponent();
        }
        DateTime Dtfrom;
        DateTime Dtto;
        string Supplier;
        string Sql;

        string itemid;
        string Itemname;
        string Batchcode;
        DateTime ExpirtDate;
        DateTime ManDate;
        string Rack;
        string Stock;
        private void Frmexpiryreport_Load(object sender, EventArgs e)
        {
            Dtfromdate.Value = DateTime.Now;
            Dttodate.Value = DateTime.Now.AddMonths(1);
            ShowReport();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GridHeaderConversion(gridmain);
                CommonClass._Language.PanelBasedConversion(pnltop);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
            }
        }
        public void ShowReport()
        {
            gridmain.Rows.Clear();
            Dtfrom = Dtfromdate.Value;
            Dtto = Dttodate.Value;
            double Stock;
            Sql = "select * from tblbatch where exdate between  '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59' order by exdate asc";
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            for(int i=0;i<CommonClass.Ds.Tables[0].Rows.Count;i++)
            {
                gridmain.Rows.Add(1);
                itemid=CommonClass.Ds.Tables[0].Rows[i]["itemid"].ToString();
                Batchcode=CommonClass.Ds.Tables[0].Rows[i]["bcode"].ToString();
                gridmain.Rows[i].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(itemid, "itemname");
                gridmain.Rows[i].Cells["clnbatch"].Value = Batchcode;
                ExpirtDate=Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["exdate"].ToString());
                ManDate=Convert.ToDateTime(CommonClass.Ds.Tables[0].Rows[i]["mandate"].ToString());
                gridmain.Rows[i].Cells["clnexpiry"].Value =ExpirtDate.ToString("dd/MM/yyyy");
                gridmain.Rows[i].Cells["clnmandate"].Value = ManDate.ToString("dd/MM/yyyy");
                gridmain.Rows[i].Cells["clnrack"].Value = CommonClass._Itemmaster.SpecificField(itemid, "rack"); 
                Stock=CommonClass._Inventory.GetStock(" where pcode='" + itemid + "' and batchcode='" + Batchcode + "' and exdate ='" + ExpirtDate.ToString("dd/MMM/yyyy") + "'");
                gridmain.Rows[i].Cells["clnstock"].Value = Stock;
                if (Stock == 0)
                {
                    gridmain.Rows[i].Visible = false;

                }
            }
        }
        private void cmdsearch_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}
