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
    public partial class Frmareacreate : Form
    {
        public Frmareacreate()
        {
            InitializeComponent();
        }


        public bool EditMode;
        public bool Isinotherwindow;

        public long Aid;
        string Aname;
        Generalfunction _genf = new Generalfunction();

        DataSet Ds;
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
            }
        }

        private void Frmareacreate_Load(object sender, EventArgs e)
        {
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                Retrive();
            }
            txtareaname.textBox1.Focus();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        private void Frmareacreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
           
        }

        public void Retrive()
        {
            Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblarea where Aid='" + Aid + "'");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtId.Text = Aid.ToString();
                txtareaname.textBox1.Text = Ds.Tables[0].Rows[0]["aname"].ToString();
                txtnote.textBox1.Text = Ds.Tables[0].Rows[0]["aname"].ToString();
                EditMode = true;
            }
        }

        public void DeleteGroup()
        {
            CommonClass._Dbtask.ExecuteNonQuery("Delete from Tblarea where Aid='" + TxtId.Text + "'");
        }

        public void Clear()
        {
            try
            {
                TxtId.Text = Generalfunction.getnextid("Aid", "Tblarea");
                txtareaname.textBox1.Text = "";
                txtnote.textBox1.Text = "0.00";
               
                EditMode = false;
                Isinotherwindow = false;
                txtareaname.textBox1.Focus();
            }
            catch
            {
            }
        }

        public bool ValidationFu()
        {
            if (txtareaname.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Area Name", _genf.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtareaname.textBox1.Focus();
                return false;
            }
            Aname = CommonClass._Dbtask.ExecuteScalar("select Aid from tblarea where Aname='" + txtareaname.textBox1.Text + "'");
            if (Aname != "" && EditMode == false)
            {
                MessageBox.Show("Area Name Is Already Exist",_genf.MsgBxValue , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtareaname.textBox1.Focus();
                return false;
            }

            return true;
        }

        public void NextgInitialize()
        {
            CommonClass._Area.Aid = Convert.ToInt64(TxtId.Text);
            CommonClass._Area.Aname = txtareaname.textBox1.Text;
            CommonClass._Area.InsertArea();
        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteGroup();
                    }
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

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void Frmareacreate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
                Main();
        }

        private void txtnote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Main();
        }

        private void txtareaname_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Aname", "tblarea", txtareaname.textBox1);

        }


    }
}
