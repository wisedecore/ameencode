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
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }
        public long cid;
        string cname;
        private void FrmColor_Load(object sender, EventArgs e)
        {
            Clear();
            txtcolor.textBox1.Focus();
            CommonClass._Nextg.FormIcon(this);
        }
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
        public bool ValidationFu()
        {
            if (txtcolor.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Area Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcolor.textBox1.Focus();
                return false;
            }
           cname = CommonClass._Dbtask.ExecuteScalar("select Aid from tblarea where Aname='" + txtcolor.textBox1.Text + "'");
           if (cname != "")
            {
                MessageBox.Show("Area Name Is Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcolor.textBox1.Focus();
                return false;
            }

            return true;
        }
        public void Clear()
        {
            try
            {
                TxtId.Text = Generalfunction.getnextid("cid", "Tblcolor");
                txtcolor.textBox1.Text = "";
               

              
                txtcolor.textBox1.Focus();
            }
            catch
            {
            }
        }
        public void NextgInitialize()
        {
            CommonClass._colors.cid= Convert.ToInt64(TxtId.Text);
            CommonClass._colors.cname = txtcolor.textBox1.Text;
            CommonClass._colors.Insertcolor();
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    
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

        private void txtcolor_Load(object sender, EventArgs e)
        {

        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FrmColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
    }
}
