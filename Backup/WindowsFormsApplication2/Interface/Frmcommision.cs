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
    public partial class Frmcommision : Form
    {
        public Frmcommision()
        {
            InitializeComponent();
        }

       public bool  EditMode ;
       public bool  Isinotherwindow ;

        public   long Cid;
        string Cname;
        double Cperc;
        double Fromamount;
        double Toamount;


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
        private void Frmcommision_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            if (Isinotherwindow == false)
            {
                Clear();
            }
            else
            {
                Retrive();
            }
            txtcommisionname.textBox1.Focus();
            CommonClass._Nextg.FormIcon(this);
        }

        private void Frmcommision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            if (e.KeyChar == 116)
            {
                Main();
            }
        }

        public void Retrive()
        {
            Ds =CommonClass._Dbtask.ExecuteQuery("select * from tblcommision where cid='" + Cid + "'");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtId.Text = Cid.ToString();
                txtcommisionname.textBox1.Text = Ds.Tables[0].Rows[0]["cname"].ToString();
                txtcommisionperc.textBox1.Text = (CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["Cperc"])).ToString();
                txtfromamount.textBox1.Text =(CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["Cfromamount"]).ToString());
                txttoamount.textBox1.Text =(CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["Ctoamount"]).ToString());
                Comcommisionfor.Text = Ds.Tables[0].Rows[0]["Cfor"].ToString();
                EditMode = true;
            }
        }
        public void DeleteGroup()
        {
           CommonClass._Dbtask.ExecuteNonQuery("Delete from Tblcommision where Cid='" + TxtId.Text + "'");
        }

        public void Clear()
        {
            try
            {
                EditMode = false;
                TxtId.Text = Generalfunction.getnextid("Cid", "Tblcommision");
                txtcommisionname.textBox1.Text = "";
                txtcommisionperc.textBox1.Text = "0.00";
                txtfromamount.textBox1.Text = "0.00";
                txttoamount.textBox1.Text = "0.00";
                Comcommisionfor.SelectedIndex = 0;
                EditMode = false;
                Isinotherwindow = false;
                txtcommisionname.textBox1.Focus();
            }
            catch
            {
            }
        }

        public bool ValidationFu()
        {
            if (txtcommisionname.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Commision Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcommisionname.textBox1.Focus();
                return false;
            }
           Cname=CommonClass._Dbtask.ExecuteScalar("select Cid from tblcommision where Cname='" + txtcommisionname.textBox1.Text + "'");
           if (Cname != "" && EditMode == false)
            {
                MessageBox.Show("commision Name Is Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcommisionname.textBox1.Focus();
                return false;
            }

            return true;
        }

        public void NextgInitialize()
        {
            CommonClass._commision.Cid = Convert.ToInt64(TxtId.Text);
            CommonClass._commision.Cname = txtcommisionname.textBox1.Text;
            CommonClass._commision.Cperc = CommonClass._Dbtask.znullDouble(txtcommisionperc.textBox1.Text);
            CommonClass._commision.Cfromamount = CommonClass._Dbtask.znullDouble(txtfromamount.textBox1.Text);
            CommonClass._commision.Ctoamount = CommonClass._Dbtask.znullDouble(txttoamount.textBox1.Text);
            CommonClass._commision.Cfor = Comcommisionfor.Text;
            CommonClass._commision.InsertCommision();
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

        private void txttoamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void Frmcommision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
                Main();
        }

        

    }
}
