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
    public partial class Frmcreatesizes : Form
    {
        public Frmcreatesizes()
        {
            InitializeComponent();
        }
        Clssizes _Sizes = new Clssizes();
        NextGFuntion _Nextg = new NextGFuntion();
        DBTask _Dbtask = new DBTask();

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    if (this.ActiveControl.Name != "Txtsizename")
                    {
                       
                            SendKeys.Send("{Tab}");
                            return true;
                                    
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        public bool EditMode;
        private void Frmcreatesizes_Load(object sender, EventArgs e)
        {
           // _Nextg.FormStylesett(this);
          //_Nextg.FormImage(pnlImage);
          //  _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
          //  _Nextg.FormHeadStyle(pnlHead);
            Clear();
            CommonClass._Nextg.FormIcon(this);
        }

        private bool ValidationFu()
        {
            if (Txtsizename.textBox1.Text == "")
            {
                MessageBox.Show("Enter the Size", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txtsizename.Focus();
                return false;
            }
            return true;
        }
        public void DeleteSizes()
        {
         string Sid=txtid.Text;
        _Dbtask.ExecuteNonQuery("delete from tblsizes where sid='"+Sid+"'");
        }
        public void NextgInitialize()
        {
            long Sid =Convert.ToInt64(txtid.Text);
            string Sname = Txtsizename.textBox1.Text;
            string Sremarks = Txtremarks.textBox1.Text;

            _Sizes.Sid =Sid;
            _Sizes.Sname = Sname;
            _Sizes.Sremarks = Sremarks;
        }
        public void Insert()
        {
            _Sizes.Insertsizes();
        }
        public void GetSizeCode()
        {
            txtid.Text = _Sizes.IdSizes();
        }
        public void Clear()
        {
            GetSizeCode();
            Txtsizename.textBox1.Text = "";
            Txtremarks.textBox1.Text = "";
            Txtsizename.textBox1.Focus();
        }
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteSizes();
                    }
                    NextgInitialize();
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

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void Txtremarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        private void Frmcreatesizes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
