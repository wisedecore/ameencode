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
    public partial class Frmcmnd : Form
    {
        public Frmcmnd()
        {
            InitializeComponent();
        }
        
        string userr = "";
        string pass = "";
        public static bool okk = false;
        private void Frmcmnd_Load(object sender, EventArgs e)
        {
            CommonClass._Nextg.FormIcon(this);
        }
        public void Shwcmndwindow()
        {
            okk = false;
            userr = txtuser.Text.ToString();
            pass = txtpasswrd.Text.ToString();
            if (userr == "nes321" && pass == "nes321")
            {
                okk = true;
                Frmcommandwindow _Fform = new Frmcommandwindow();
                _Fform.ShowDialog();
                
               
            }
            else
            {
                okk = false;
                MessageBox.Show("Wrong attempt");
            }
            
        }

        private void bttnok_Click(object sender, EventArgs e)
        {
            Shwcmndwindow();
           txtuser.Text="";
           txtpasswrd.Text = "";
        }
        public void Enetersett(TextBox txt)
        {

            txt.BackColor = System.Drawing.Color.Black;
            txt.ForeColor = System.Drawing.Color.White;
            if (txt.Text.Length > 0)
            {
                txt.Select();
            }
        }
        public void Leavesett(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            txt.ForeColor = System.Drawing.Color.Black;
        }
        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            Enetersett(txtuser);
        }

        private void txtpasswrd_Enter(object sender, EventArgs e)
        {
            Enetersett(txtpasswrd);
        }

        private void txtpasswrd_Leave(object sender, EventArgs e)
        {
            Leavesett(txtpasswrd);
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            Leavesett(txtuser);
        }
    }
}
