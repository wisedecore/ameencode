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
    public partial class FrmExpirysales : Form
    {
        public FrmExpirysales()
        {
            InitializeComponent();
        }
        public DataSet Ds;
        public int SelectedRow;
        public string BatchCode = "";

        private void FrmExpirysales_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                DateTime DtExp;
                DtExp = CommonClass._Dbtask.ZnullDatetime(Ds.Tables[0].Rows[i]["exdate"]);
                if (CommonClass._Inventory.GetStock(BatchCode, DtExp) == 0)
                {
                    Ds.Tables[0].Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                GridExDate.Visible = true;
                PnlExpire.Visible = true;
                GridExDate.Rows.Add(1);
                DateTime DtExp;
                DtExp = CommonClass._Dbtask.ZnullDatetime(Ds.Tables[0].Rows[i]["exdate"]);
                GridExDate.Rows[i].Cells["ClnExDate"].Value = DtExp.ToString("dd/MM/yyyy");
                GridExDate.Rows[i].Cells["Clnrate"].Value = CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["srate"]).ToString();
            }


            CommonClass._Nextg.FormIcon(this);
        }

        private void GridExDate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GridExDate.SelectedRows.Count > 0)
            {
                SelectedRow = GridExDate.SelectedRows[0].Index;
                Clssales.PassExpiryDate = CommonClass._Dbtask.ZnullDatetime(GridExDate.Rows[SelectedRow].Cells["ClnExDate"].Value).ToString();
                Clssales.PassExpiryRate = CommonClass._Dbtask.znlldoubletoobject(GridExDate.Rows[SelectedRow].Cells["clnrate"].Value).ToString();
                this.Close();
            }
        }
    }
}
