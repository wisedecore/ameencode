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
    public partial class Frmusers : Form
    {
        public Frmusers()
        {
            InitializeComponent();
        }


        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {

                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

       
        public bool EditMode;
        ClsUserDetails _User = new ClsUserDetails();

        public long Id;
        public string UserName;
        public long GroupId;
        public string Password;
        public string ConfirmPassword;
        public int Astatus;
        private void Frmusers_Load(object sender, EventArgs e)
        {
            Clear();
        }
        public void GetId()
        {
            txtid.Text = (_User.GetUserId()).ToString();
        }
        public void Clear()
        {        
            GetId();
            EditMode = false;
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconfirmpassword.Text = "";
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
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
        public void Delete()
        {
        
        }
        public long GetGroupId()
        {
            if (comgroup.Text == "ADMIN")
                GroupId = 0;
            else if (comgroup.Text == "SALES")
                GroupId = 1;
            else if (comgroup.Text == "COUNTER SALE")
                GroupId = 100;
            else if (comgroup.Text == "PURCHASER")
                GroupId = 101;
            return GroupId;
        }
        public void GetAstatus()
        {
            if (comastatus.Text == "Active")
                Astatus = -1;
            else
                Astatus = 0;
        }
        private bool ValidationFu()
        {
            Id = Convert.ToInt64(txtid.Text);
            UserName = txtusername.Text;
           GroupId= GetGroupId();
            Password = txtpassword.Text;
            ConfirmPassword = txtconfirmpassword.Text;
            GetAstatus();
            if (UserName == "")
            {
                MessageBox.Show("Invalid UserName");
                txtusername.Focus();
                return false;
            }
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Confirm Password");
                txtpassword.Focus();
                return false;
            }
            return true;
        }
        public void NextgInitilize()
        {
            _User.UserId = Id;
            _User.UserName = UserName;
            _User.Password = Password;
            _User.Groupid = GroupId;
            _User.AStatus = Astatus;
        }
        public void Insert()
        {
            _User.InserUser();
        }
       
        private bool Main()
        {

            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        Delete();
                    }
                    NextgInitilize();
                    Insert();
                    Clear();
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
            return true;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmusers_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

       

        private void Frmusers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("UserName", "tbluserdetails", txtusername);

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("uPassword", "tbluserdetails", txtusername);

        }

        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("uPassword", "tbluserdetails", txtconfirmpassword);

        }
    }
}
