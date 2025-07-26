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
    public partial class frmaccountGroup : Form
    {
        public frmaccountGroup()
        {
            InitializeComponent();
        }
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        Generalfunction _Gen = new Generalfunction();
        NextGFuntion _NextgFunction = new NextGFuntion();
        DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();
        public float Id;
        public bool Isinotherwindow = false;
        public bool EditMode = false;
        private void frmaccountGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteAccountgroup();
                    }
                    Insert();
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
        private bool ValidationFu()
        {
            if (TxtGroupName.Text == "")
            {
                MessageBox.Show("Enter Group Name","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtGroupName.Focus();
                return false;
            }
            return true;
        }

        private void frmaccountGroup_Load(object sender, EventArgs e)
        {
           CommonClass._Nextg.FormStylesett(this);
           CommonClass._Nextg.ClearControles(this);
            if (EditMode == false)
            {
                Clear();
            }
            else
            {
                _AccountGroup.FillCombo(ComUnder);
                Ds = _Dbtask.ExecuteQuery("select * from tblaccountgroup where agroupid='" + Id + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    TxtGroupName.Text = Ds.Tables[0].Rows[0]["agroupname"].ToString();
                    ComUnder.SelectedValue = Ds.Tables[0].Rows[0]["aunder"].ToString();
                }
            }
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }
        public void Insert()
        {
            NextgInitialize();
            _AccountGroup.InsertAccountsGroup();
           
        }
        public void NextgInitialize()
        {
            _AccountGroup.AccountGroupIDLng = Convert.ToInt64(TxtId.Text);
            _AccountGroup.GroupNameStr = TxtGroupName.Text;
            _AccountGroup.UnderInt = Convert.ToInt16(ComUnder.SelectedValue);
            
        }
        public void Clear()
        {
            _NextgFunction.ClearControles(this);
            _NextgFunction.SetControlesBehave(this);
            _AccountGroup.IdAccountGroup();
            TxtId.Text = Convert.ToString(_AccountGroup.AccountGroupIDLng);
            TxtGroupName.Text = "";
            _AccountGroup.FillCombo(ComUnder);
            TxtGroupName.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void frmaccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void TxtGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComUnder.Focus();
            }
        }

        private void ComUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        private void TxtGroupName_Enter(object sender, EventArgs e)
        {
            
        }
        public void DeleteAccountgroup()
        {
            _Dbtask.ExecuteNonQuery("Delete from tblaccountgroup where agroupid='" + TxtId.Text + "'");
        }

    }
}
