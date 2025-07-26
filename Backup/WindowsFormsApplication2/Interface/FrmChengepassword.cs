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
    public partial class FrmChengepassword : Form
    {
        public FrmChengepassword()
        {
            InitializeComponent();
        }
        ClsUserDetails _User = new ClsUserDetails();
        DBTask _Dbtask = new DBTask();
        public DataSet Ds;


        public void FillCombo()
        {
            _Dbtask.fillDatainCombowithQuery(comuser, "userid", "username", "tbluserdetails", "select * from tbluserdetails");

        }
        private bool ValidationFu()
        {
            if (txtnewpassword.textBox1.Text != txtconfirmpassword.textBox1.Text)
            {
                MessageBox.Show("Correct Confirm password");
                txtconfirmpassword.Focus();
              
                return false;
            }
            Ds = _Dbtask.ExecuteQuery("select * from tbluserdetails where userid='" + comuser.SelectedValue + "' and upassword ='" + txtoldpassword.textBox1.Text + "'");
            if (Ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Invalid oldPassword");
                txtoldpassword.textBox1.Focus();
                return false;
            }
            return true;
        }
        public void Main()
        {
            if (ValidationFu())
            {
                try
                {
                    _Dbtask.ExecuteNonQuery("update tbluserdetails set upassword='" + txtnewpassword.textBox1.Text + "' where userid='" + comuser.SelectedValue + "'");
                    this.Close();
                }
                catch
                {
                }
            }
        
        }

        private void FrmChengepassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdchange_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void FrmChengepassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        private void FrmChengepassword_Load(object sender, EventArgs e)
        {
            FillCombo();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        private void comuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtoldpassword.textBox1.Focus();
            }
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.GridHeaderConversion(gridmain);
                //CommonClass._Language.PanelBasedConversion(pnltotal);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
            }
        }
    

       

        private void txtoldpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtnewpassword.textBox1.Focus();
            }
        }

        private void txtnewpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                txtconfirmpassword.textBox1.Focus();
            }

        }

        private void txtconfirmpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        private void txtnewpassword_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("uPassword", "tbluserdetails",txtnewpassword.textBox1);

        }

        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("uPassword", "tbluserdetails", txtconfirmpassword.textBox1);

        }

     


    }
}
