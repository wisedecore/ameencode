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
    public partial class FrmSelectChequeReport : Form
    {
        public FrmSelectChequeReport()
        {
            InitializeComponent();
        }
        DBTask _DbTask = new DBTask();

        public void Clear()
        {
            ComChequeMode.SelectedIndex = 0;
            ComDates.SelectedIndex = 2;
            ComStatus.SelectedIndex = 1;
            Generalfunction.FillCombo(ComBank, "LName", "Lid", "TblAccountLedger", "All", " Where AgroupId = 24");
            ChkAccountAll.Checked = true;
            ChkAllStatus.Checked = true;
        }
        public string WhereCMode()
        {
            //Cheque Receipt
            //Cheque Payment
            string Where = "";
            if (ComChequeMode.Text == "Cheque Receipt")
            {
                Where = " Where CMode = 0 ";
            }
            if (ComChequeMode.Text == "Cheque Payment")
            {
                Where = " Where CMode = 1 ";
            }
            return Where;
        }
        public string WhereAccount()
        {
            if (ChkAccountAll.Checked == true)
            {
                return "";
            }
            else
            {
                return " And Alid = " + TxtAccount.Tag.ToString();
            }
        }
        public string WhereBank()
        {
            if (ComBank.SelectedValue.ToString() == "0")
            {
                return "";
            }
            else
            {
                return " And Blid = " + ComBank.SelectedValue.ToString();
            }
        }
        public string WhereStatus()
        {
            if (ChkAllStatus.Checked == true)
            {
                return "";
            }
            return " And Status = '" + ComStatus.Text + "'";
        }
        public string WhereDate()
        {
            //Paid Date
            //Cheque Date
            //Collected Date
            string Where = "";

            if (ComDates.Text == "Paid Date")
            {
                Where = " And Pdate";
            }
            if (ComDates.Text == "Cheque Date")
            {
                Where = " And CDate";
            }
            if (ComDates.Text == "Collected Date")
            {
                Where = " And CollDate";
            }
            return Where;
        }
        public void Main()
        {
            if (Validation())
            {
                string Where = MainWhere();

                FrmReport _Form = new FrmReport();
                _Form.ReportType = ComChequeMode.Text;
                _Form.DTFrom = DtFrom.Value;
                _Form.DTTo = DtTo.Value;
                _Form.Where = Where;

                (this.MdiParent as MDIParent2).MaxforSett(_Form);
                (this.MdiParent as MDIParent2).FormShowNromal(_Form);

            }
        }
        public string MainWhere()
        {
            string Where = WhereCMode() + WhereAccount() + WhereBank() + WhereStatus() + WhereDate();
            return Where;
        }
        public bool Validation()
        {
            if (ChkAccountAll.Checked == false)
            {
                if (TxtAccount.Text != "")
                {
                    if (CommonClass._Ledger.GetspecifField("LName", TxtAccount.Tag.ToString()) != TxtAccount.Text)
                    {
                        MessageBox.Show("Properly Select The Account", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtAccount.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Enter The Account", NextGFuntion.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAccount.Focus();
                    return false;
                }
            }
            return true;
        }
        public void LoadAccounts()
        {
            GridAccount.Rows.Clear();
            GridAccount.Visible = true;

            string Sql = "Select Lid,LName from TblAccountLedger Where (AgroupID = 18 OR AgroupID = 19) And LNAme Like '%" + TxtAccount.Text + "%'";
            DataSet Ds = _DbTask.ExecuteQuery(Sql);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    GridAccount.Rows.Add(1);
                    GridAccount.Rows[i].Cells["ClnName"].Value = Ds.Tables[0].Rows[i]["LName"].ToString();
                    GridAccount.Rows[i].Cells["ClnName"].Tag = Ds.Tables[0].Rows[i]["Lid"].ToString();
                    GridAccount.Rows[i].Selected = false;
                }
                GridAccount.Rows[0].Selected = true;
            }
        }
        public void GridToTextBox()
        {
            TxtAccount.Tag = GridAccount.SelectedRows[0].Cells["ClnName"].Tag;
            TxtAccount.Text = GridAccount.SelectedRows[0].Cells["ClnName"].Value.ToString();
            GridAccount.Visible = false;
        }
        private void FrmSelectChequeReport_Load(object sender, EventArgs e)
        {
            CommonClass._Nextg.FormIcon(this);
            Clear();
            CommonClass._Nextg.FormIcon(this);
        }
        private void ChkAccountAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAccountAll.Checked == true)
            {
                TxtAccount.Enabled = false;
            }
            else
            {
                TxtAccount.Enabled = true;
            }
        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (GridAccount.SelectedRows.Count > 0)
            {
                int CrtRow = GridAccount.SelectedRows[0].Index;
                
                if (e.KeyValue == 40)
                {
                    if (GridAccount.Rows.Count - 2 > CrtRow)
                    {
                        GridAccount.Rows[CrtRow + 1].Selected = true;
                        GridAccount.Rows[CrtRow].Selected = false;
                    }
                }
                if (e.KeyValue == 38)
                {
                    if (CrtRow > 0)
                    {
                        GridAccount.Rows[CrtRow - 1].Selected = true;
                        GridAccount.Rows[CrtRow].Selected = false;
                    }
                }
                if (e.KeyValue == 13)
                {
                    GridToTextBox();
                }
            }
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void GridAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridAccount.SelectedRows.Count > 0)
            {
                if (_DbTask.znllString(GridAccount.SelectedRows[0].Cells["ClnName"].Tag) != "")
                {
                    GridToTextBox();
                }
            }
        }

        private void ChkAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAllStatus.Checked == true)
            {
                ComStatus.Enabled = false;
            }
            else
            {
                ComStatus.Enabled = true;
            }
        }
    }
}
