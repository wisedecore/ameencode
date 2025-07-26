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
    public partial class Frmdiscountslab : Form
    {
        public Frmdiscountslab()
        {
            InitializeComponent();
        }
        string Dname;
        public bool EditMode;
        public bool Isinotherwindow;

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        public void DeleteGroup()
        {
            CommonClass._Dbtask.ExecuteNonQuery("Delete from tbldiscount where Did='" + TxtId.Text + "'");
        }

        public void NextgInitialize()
        {
            CommonClass._Discount.Did = Convert.ToInt64(TxtId.Text);
            CommonClass._Discount.Dname = Txtdiscountname.textBox1.Text;
            CommonClass._Discount.Dperc = CommonClass._Dbtask.znullDouble(txtdiscountperc.textBox1.Text);
            CommonClass._Discount.Dfromamount = CommonClass._Dbtask.znullDouble(txtfromamount.textBox1.Text);
            CommonClass._Discount.Dtoamount = CommonClass._Dbtask.znullDouble(txttoamount.textBox1.Text);
            CommonClass._commision.InsertCommision();
        }

        public bool ValidationFu()
        {
            if (Txtdiscountname.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Discount Name", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txtdiscountname.textBox1.Focus();
                return false;
            }
            Dname = CommonClass._Dbtask.ExecuteScalar("select Did from tbldiscount where Dname='" + Txtdiscountname.textBox1.Text + "'");
            if (Dname != "" && EditMode == false)
            {
                MessageBox.Show("Discount Name Is Already Exist", "Qplex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txtdiscountname.textBox1.Focus();
                return false;
            }

            return true;
        }

        public void Clear()
        {
            try
            {
                EditMode = false;
                ChangeLanguage();
                TxtId.Text = Generalfunction.getnextid("Did", "tbldiscount");
                Txtdiscountname.textBox1.Text = "";
                txtdiscountperc.textBox1.Text = "0.00";
                txtfromamount.textBox1.Text = "0.00";
                txttoamount.textBox1.Text = "0.00";
                EditMode = false;
                Isinotherwindow = false;
                Txtdiscountname.textBox1.Focus();
                CommonClass._Nextg.FormIcon(this);
            }
            catch
            {
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
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }
        private void Frmdiscountslab_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
