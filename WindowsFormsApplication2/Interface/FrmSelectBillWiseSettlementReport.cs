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
    public partial class FrmSelectBillWiseSettlementReport : Form
    {
        public FrmSelectBillWiseSettlementReport()
        {
            InitializeComponent();
        }
        public void LoadPartyFromGridToBox()
        {

            if (GridAccount.SelectedRows.Count > 0)
            {
                int Index = GridAccount.SelectedRows[0].Index;
                if (CommonClass._Dbtask.znlldoubletoobject(GridAccount.Rows[Index].Cells["ClnAccount"].Tag) != 0)
                {
                    TxtAccount.Tag = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Tag);
                    TxtAccount.Text = CommonClass._Dbtask.znllString(GridAccount.Rows[Index].Cells["ClnAccount"].Value);
                    GridAccount.Visible = false;
                }
            }
        }
        public void LoadPartyOnGrid(string GroupId, string NameLike)
        {
            string Sql = "Select * From TblAccountLedger Where AgroupId = " + GroupId + " And LName Like '%" + NameLike + "%'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            GridAccount.Location = new Point(TxtAccount.Location.X, TxtAccount.Location.Y + TxtAccount.Size.Height);
            GridAccount.Visible = true;
            GridAccount.Rows.Clear();
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GridAccount.Rows.Add(1);
                    GridAccount.Rows[i].Cells["ClnAccount"].Value = Ds.Tables[0].Rows[i]["LName"];
                    GridAccount.Rows[i].Cells["ClnAccount"].Tag = Ds.Tables[0].Rows[i]["Lid"];
                    GridAccount.Rows[i].Selected = false;
                }
                GridAccount.Rows[0].Selected = true;
            }
        }
        public string MainWhere()
        {
            return WhereAccount() + WhereArea();
        }
        public string ReportType()
        {
            if (ComSelectReport.SelectedIndex == 0)
            {
                return "Sales Bill Wise SettleMent";
            }
            else
            {
                return "Purchase Bill Wise SettleMent";
            }
        }
        public string WhereArea()
        {
            if (ChkAllArea.Checked == true)
            {
                return "";
            }
            else
            {
                return " And Area = " + ComArea.SelectedValue.ToString() + " ";
            }
        }
        public string WhereAccount()
        {
            if (ChkAllAccount.Checked == true)
            {
                return "";
            }
            else
            {
                return " And Lid = " + TxtAccount.Tag.ToString() + " ";
            }
        }
        public bool Validation()
        {
            if (ChkAllAccount.Checked == false)
            {
                if (CommonClass._Dbtask.znllString(TxtAccount.Tag) == "")
                {
                    Generalfunction.ShowMessage("Select The Account");
                    TxtAccount.Focus();
                    return false;
                }
                if (CommonClass._Ledger.GetspecifField("LName", TxtAccount.Tag.ToString()) != TxtAccount.Text)
                {
                    Generalfunction.ShowMessage("Proper Account Selection Is Not Detected.Select The Account One More Time");
                    TxtAccount.Focus();
                    return false;
                }
            }
            if (ChkAllArea.Checked == false)
            {
                if (ComArea.SelectedValue.ToString() == "0")
                {
                    Generalfunction.ShowMessage("Select The Area");
                    ComArea.Focus();
                    return false;
                }
            }
            return true;
        }
        public void Main()
        {
            if (Validation())
            {
                FrmReport _Form = new FrmReport();
                _Form.Where = MainWhere();
                _Form.ReportType = ReportType();
                (this.MdiParent as MDIParent2).MaxforSett(_Form);
                (this.MdiParent as MDIParent2).FormShowNromal(_Form);
            }
        }
        public void FillCombo(bool OnlyFillAccount)
        {
            TxtAccount.Text = "";
            GridAccount.Visible = false;
            TxtAccount.Tag = "";

            if (ComSelectReport.SelectedIndex == 0)
            {
                //CommonClass._Ledger.FillComboCustomer(ComAccount);
                //Generalfunction.FillCombo(ComAccount, "LName", "Lid", "TblAccountLedger", "None", " Where AGroupid = '18' ");
            }
            else
            {
                //CommonClass._Ledger.FillComboSupplier(ComAccount);
                //Generalfunction.FillCombo(ComAccount, "LName", "Lid", "TblAccountLedger", "None", " Where AGroupid = '19' ");
            }
            if (OnlyFillAccount == false)
            {
                Generalfunction.FillCombo(ComArea, "AName", "Aid", "TblArea", "None", " Where AName != 'None' ");
            }
        }
        public void Clear()
        {
            ComSelectReport.SelectedIndex = 0;

            
            FillCombo(false);
            ChkAllAccount.Checked = true;
            ChkAllArea.Checked = true;

            CommonClass._Nextg.FormIcon(this);
        }
        private void ChkAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAllAccount.Checked == true)
            {
                TxtAccount.Enabled = false;
            }
            else
            {
                TxtAccount.Enabled = true;
            }
        }
        private void FrmSelectBillWiseSettlementReport_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void ComSelectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombo(true);
        }

        private void ChkAllArea_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAllArea.Checked == true)
            {
                ComArea.Enabled = false;
            }
            else
            {
                ComArea.Enabled = true;
            }
        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            if (ComSelectReport.SelectedIndex == 0)
            {
                //CommonClass._Ledger.FillComboCustomer(ComAccount);
                // Generalfunction.FillCombo(ComAccount, "LName", "Lid", "TblAccountLedger", "None", " Where AGroupid = '18' ");
                LoadPartyOnGrid("18", TxtAccount.Text);
            }
            else
            {
                //CommonClass._Ledger.FillComboSupplier(ComAccount);
                //Generalfunction.FillCombo(ComAccount, "LName", "Lid", "TblAccountLedger", "None", " Where AGroupid = '19' ");
                LoadPartyOnGrid("19", TxtAccount.Text);
            }
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LoadPartyFromGridToBox();
            }
            else
            {
                Generalfunction.ChangeGridSelection(GridAccount, e.KeyValue);
            }
        }

        private void TxtAccount_Leave(object sender, EventArgs e)
        {
            GridAccount.Visible = false;
        }

    }
}
