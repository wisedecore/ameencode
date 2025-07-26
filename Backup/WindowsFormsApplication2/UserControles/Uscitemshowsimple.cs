using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Uscitemshowsimple : UserControl
    {
        public static TextBox ActiveControle;
        public static Form ActiveForm;
        int SeleRow;
        public static string Vtype;

        string Id;
        string Code;
        public Uscitemshowsimple()
        {
            InitializeComponent();
        }

        private void GridProductShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleRow = GridProductShow.SelectedRows[0].Index;
            
           
            if (Vtype == "Item")
            {
                Id = GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                Name = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Id + "'");
                Code = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Id + "'");
            }
            else if (Vtype == "Ledger")
            {
                Id = GridProductShow.Rows[SeleRow].Cells["lid"].Value.ToString();
                Name = CommonClass._Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Id + "'");
                Code = CommonClass._Dbtask.ExecuteScalar("select laliasname from tblaccountledger where lid='" + Id + "'");
            }

            ActiveControle.Text = Name;
            ActiveControle.Tag = Id;
            this.Visible = false;
        }

    
    }
}
