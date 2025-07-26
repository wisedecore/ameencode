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
    public partial class Frmtempcantacts : Form
    {
        public Frmtempcantacts()
        {
            InitializeComponent();
        }
        Clstempcontact _TempContacts = new Clstempcontact();

        long Tid;
        string Tname;
        string TMobile;
        string TAddress;
        string Area;
        string TEmail;

        public int RowIndex;
        public int ColumnIndex;
        public string ColumnName;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (this.ActiveControl != null)
            {
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        public void Clear()
        {
           // gridmain.Rows.Clear();
            ShowContacts();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        public void ShowContacts()
        {
            gridmain.DataSource = _TempContacts.ShowContactList("").Tables[0];
            gridmain.Columns["slno"].ReadOnly = true;
            //gridmain.Refresh();
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RowValidation()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Cells["slno"].Value == null || gridmain.Rows[i].Cells["name"].Value == null)
                    {
                        gridmain.Rows[i].Tag = -1;
                    }
                    else
                    {
                        gridmain.Rows[i].Tag = 1;
                    }
                }
            }
            catch
            {
            }
        }
        private bool ValidationFu()
        {
            try
            {
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    if (gridmain.Rows[i].Tag != null)
                    {
                        if (gridmain.Rows[i].Tag.ToString() == "1")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No Valid Entries", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteVoucher()
        {
            CommonClass._Dbtask.ExecuteNonQuery("delete from tbltempcontact");
        }

        public void NextgInitialize()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                if (gridmain.Rows[i].Tag != null)
                    if (gridmain.Rows[i].Tag.ToString() == "1")
                    {
                        Tid = Convert.ToInt64(gridmain.Rows[i].Cells["slno"].Value);
                        Tname = gridmain.Rows[i].Cells["name"].Value.ToString();
                        TMobile = gridmain.Rows[i].Cells["mobile"].Value.ToString();
                        TAddress = gridmain.Rows[i].Cells["address"].Value.ToString();
                        Area = gridmain.Rows[i].Cells["area"].Value.ToString();
                        TEmail = gridmain.Rows[i].Cells["email"].Value.ToString();

                        _TempContacts.tid = Tid;
                        _TempContacts.tname = Tname;
                        _TempContacts.tmobile = TMobile;
                        _TempContacts.taddress = TAddress;
                        _TempContacts.temail = TEmail;
                        _TempContacts.tarea = Area;
                        _TempContacts.Inserttempcontact();
                    }
            }
            MessageBox.Show("Saved Completed", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Main()
        {
            RowValidation();
            if (ValidationFu())
            {
                try
                {
                    DeleteVoucher();
                    NextgInitialize();
                    Clear();
                    return true;

                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Frmtempcantacts_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = gridmain.CurrentCell.RowIndex;
            ColumnIndex = gridmain.CurrentCell.ColumnIndex;
            ColumnName = gridmain.Columns[ColumnIndex].Name.ToString();
            gridmain.Rows[RowIndex].Cells["slno"].Value = RowIndex + 1;
            if (gridmain.Columns[ColumnName].ReadOnly == true)
                SendKeys.Send("{Tab}");
        }

        private void Frmtempcantacts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
            else if (e.KeyValue == 27)
            {
                this.Close();
            }
        }


        
    }
}