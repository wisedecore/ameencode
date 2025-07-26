using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace WindowsFormsApplication2
{
    public partial class FrmCompanyName : Form
    {
       // MDIParent1 _Mdi = new MDIParent1();
        NextGFuntion _Nextg = new NextGFuntion();
        public FrmCompanyName()
        {
            InitializeComponent();
        }
        ClsCompanyCreate _ComCreate = new ClsCompanyCreate();
        RegistryKey regKey = Registry.CurrentUser;
        public bool Bakcompany;

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                
            }
        }

        private void FrmCompanyName_Load(object sender, EventArgs e)
        {
          
            TxtFileName.textBox1.Focus();
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
        }

        private void FrmCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            Main();        
        }
        public void Main()
        {
            try
            {
                
                //Cursor.c;
                ////_Mdi.PrgMain.Visible = false;
                if (TxtFileName.textBox1.Text != "")
                {
                   
                    PrgMain.Value = 20;
                    if (chkbakcompany.Checked == true)
                    {
                        Bakcompany = true;
                        regKey = regKey.CreateSubKey("Software\\Techno");

                        regKey.SetValue("bak", txtbakpassword.Text);
                    }
                    else
                    {
                        Bakcompany=false;
                    }
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    TxtFileName.textBox1.Text = TxtFileName.textBox1.Text.Replace(" ", "");
                    TxtFileName.textBox1.Text = TxtFileName.textBox1.Text.ToUpper();
                    _ComCreate.CompanyCreate(TxtFileName.textBox1.Text.Replace(" ", ""),Bakcompany);
                    PrgMain.Value = 100;
                    this.Cursor = System.Windows.Forms.Cursors.Default;

                    this.Close();
                    //FrmCreateCompany _Createcompany = new FrmCreateCompany();
                    //_Createcompany.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Enter the Company Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtFileName.textBox1.Focus();
                }
            }
            catch (Exception Exe)
            {
                MessageBox.Show(Exe.ToString());
            }
        }

        private void TxtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == 13)
            {
                if (TxtFileName.textBox1.Text == "ZAT585")
                {
                    chkbakcompany.Visible = true;
                    txtbakpassword.Visible = true;
                    TxtFileName.textBox1.Text = "";
                }
                else
                {
                    Main();
                }
            }
        }

        private void TxtFileName_TextChanged(object Sender, EventArgs e)
        {

        }


    
       
    }
}
