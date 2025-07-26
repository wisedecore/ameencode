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
    public partial class Frmmechinetool : Form
    {
        public Frmmechinetool()
        {
            InitializeComponent();
        }
        DataSet Ds;
        string Temp;
        string Sql;

        private void cmdexportcustomers_Click(object sender, EventArgs e)
        {
            Ds=CommonClass._Ledger.ShowLedgerNoteincludeDeactive(" where agroupid=18 ");
            for(int i=0;i<Ds.Tables[0].Rows.Count;i++)
            {
                Temp=Ds.Tables[0].Rows[i]["lid"].ToString();
                Sql="INSERT INTO creditors "+
           "(CustCode, CustName, Address, Balance, CrditLimit, Tin_No, PhoneNo)" +
            " VALUES "+
           "("+Temp+","+
           "'"+CommonClass._Ledger.GetspecifField("lname",Temp).Substring(0,19)+"',"+
           "'" + CommonClass._Ledger.GetspecifField("address", Temp).Substring(0, 49) + "'," +
            "'"+CommonClass._Ledger.GetspecifField("Balance",Temp)+"',"+
           "'" + CommonClass._Ledger.GetspecifField("Creditlimit", Temp) + "'," +
            "'" + CommonClass._Ledger.GetspecifField("TaxRegNo", Temp) + "'," +
           "'" + CommonClass._Ledger.GetspecifField("Mobile", Temp) + "')";
                CommonClass._Dbtask.AccessConection(Sql);
            }
            MessageBox.Show("Successfully");
        }

        private void Cmdexportitems_Click(object sender, EventArgs e)
        {
            Ds = CommonClass._Itemmaster.ShowItemsProductName(" where status=1",2);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Temp = Ds.Tables[0].Rows[i]["itemid"].ToString();
                Sql = "INSERT INTO openingBal " +
           "(Id, Itemcode, Stock)" +
            " VALUES " +
           "(" + Temp + "," +
           "'" +CommonClass._Itemmaster.SpecificField(Temp,"itemcode") + "'," +
           "" + CommonClass._Inventory.GetStock(" where pcode='"+Temp+"'") + ")";
                CommonClass._Dbtask.AccessConection(Sql);
            }
            MessageBox.Show("Successfully");
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.GridHeaderConversion(gridmain);
                //CommonClass._Language.PanelBasedConversion(pnltotal);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
                CommonClass._Language.GroupBoxConvertion(Grpexport);
                CommonClass._Language.GroupBoxConvertion(Grpimport);
            }
        }
        private void Frmmechinetool_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }
    }
}
