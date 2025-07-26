using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       // ClsUserDetails _Userdetails = new ClsUserDetails();
        DataSet Ds = new DataSet();
      //  //DBTask _Dbtask = new DBTask();
       // ClsCompanyCreate _ComCreate = new ClsCompanyCreate();
        RegistryKey regKey = Registry.CurrentUser;
         // Generalfunction _Gen = new Generalfunction();
        //ClsCompanyMaster _CompanyMaster=new ClsCompanyMaster();
       // MDIParent1 _Mdi = new MDIParent1();
       // NextGFuntion _Nextg = new NextGFuntion();
        //Generalfunction _Gen = new Generalfunction();
      //  Clssettings _Settings = new Clssettings();
        //ClsParamlist _Paramlist = new ClsParamlist();
          public string Savepassword;
          public bool Loadbakcompany;
          public string Backc;

          public string Lng = "";
        //ClsUserDetails _clsuserdetails = new ClsUserDetails();

        
        

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
        public void CompanyList()
        {
            try
            {
                Ds = CommonClass._ComCreate.LoadCompany();
                CmbSelctCompany.Items.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string TempLoadingCompany = Ds.Tables[0].Rows[i]["name"].ToString();

                        if (TempLoadingCompany == "NEWCOMPANY")
                        {
                        }

                        Generalfunction.TempCompanyname = TempLoadingCompany;
                        string Temp = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                        if (Temp == "1" || Temp == "0")
                        {
                            CmbSelctCompany.Items.Add(TempLoadingCompany);
                        }
                    }
                    catch
                    {

                    }
                }
                
                
                
                try
                {
                    Backc = regKey.GetValue("Backc").ToString();
                    if (File.Exists(Backc))
                    {
                        CmbSelctCompany.Items.Add(Backc);
                    }
                    Backc = regKey.GetValue("Backc1").ToString();
                    if (File.Exists(Backc))
                    {
                        CmbSelctCompany.Items.Add(Backc);
                    }
                    Backc = regKey.GetValue("Backc2").ToString();
                    if (File.Exists(Backc))
                    {
                        CmbSelctCompany.Items.Add(Backc);
                    }
                }
                catch
                {
                }

                Savepassword = regKey.GetValue("Savepwd").ToString();



                if (Savepassword == "1")
                {
                    TxtUserName.Text = regKey.GetValue("Username").ToString();
                    TxtPassword.Text = regKey.GetValue("Pwd").ToString();
                    //CmbSelctCompany.Select(); 
                    CmbSelctCompany.Text = regKey.GetValue("Opcompany").ToString();
                    TxtServerName.Text = CommonClass._Dbtask.GetServerName();
                    ChkSetasdefault.Checked = true;
                }

                /* Check AMC*/
                DateTime Rndate;
                int DefrenceDays;
                if (regKey.GetValue("Rn") == null)
                {
                    regKey.SetValue("Rn",DateTime.Now.ToString("dd/MM/yyyy"));
                     
                }
                else
                {
                    Rndate = Convert.ToDateTime(regKey.GetValue("Rn").ToString());
                    DefrenceDays=(DateTime.Now-Rndate).Days;
                    if (DefrenceDays > 365)
                    {
                        Frmamc _Frm = new Frmamc();
                        _Frm.ShowDialog();
                        //MessageBox.Show("Renewe Ur Maintance Service for better experince", "Nesma POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
            }
            

        }
        public void CompanyListAll()
        {
            try
            {
                Ds = CommonClass._ComCreate.LoadCompany();
                CmbSelctCompany.Items.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        string TempLoadingCompany = Ds.Tables[0].Rows[i]["name"].ToString();
                        if (TempLoadingCompany == "NEWBACK")
                        {
                        }
                        Generalfunction.TempCompanyname = TempLoadingCompany;
                        string Temp = CommonClass._Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='SDelete'");
                        if (Temp == "1" || Temp == "0" || Temp == "-1")
                        {
                            CmbSelctCompany.Items.Add(TempLoadingCompany);
                        }
                    }
                    catch
                    {
                    }

                }
                if (regKey.ValueCount <= 2)
                {
                    regKey = regKey.CreateSubKey("Software\\Techno");
                }
                Backc = regKey.GetValue("Backc").ToString();
                if (File.Exists(Backc))
                {
                    CmbSelctCompany.Items.Add(Backc);
                }
            }
            catch
            {
            
            }

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ComLanguage.SelectedIndex = 0;
           CommonClass._Dbtask.Form = "login";

       
            CompanyList();
      
            if (CmbSelctCompany.Items.Count == 0)
            {
                CommonClass._ComCreate.CompanyCreate("DEMO COMPANY", false);
                CompanyList();

            }

            
           
            TxtUserName.Focus();
            TxtUserName.Select();

            TxtServerName.Text =CommonClass._Dbtask.GetServerName();
        }
        public void Clear()
        {
            CommonClass._Dbtask.Form = "login";
            CompanyList();
            //  
            // cmbControl.DataSource = ds.Tables[0];
            //CmbSelctCompany
            if (CmbSelctCompany.Items.Count == 0)
            {
                CommonClass._ComCreate.CompanyCreate("DEMO COMPANY", false);
                CompanyList();

            }
            CmbSelctCompany.SelectedIndex = 0;
            TxtUserName.Focus();
            TxtUserName.Select();

            regKey = regKey.CreateSubKey("Software\\Techno");
            Savepassword = regKey.GetValue("Savepwd").ToString();

            if (Savepassword == "1")
            {
                TxtUserName.Text = regKey.GetValue("Username").ToString();
                TxtPassword.Text = regKey.GetValue("Pwd").ToString();
                CmbSelctCompany.Text = regKey.GetValue("opcompany").ToString();
                ChkSetasdefault.Checked = true;
            }


            DtDate.Format = DateTimePickerFormat.Custom;
            DtDate.CustomFormat = "dd MMM yyyy";
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            Main();
        }
       
        public string Decconvertion(string temp)
        {
            if (temp == "2")
            {
                temp = "0.00";
            }
            if (temp == "3")
            {
                temp = "0.000";
            }
            if (temp == "4")
            {
                temp = "0.0000";
            }
            if (temp == "5")
            {
                temp = "0.00000";
            }
            return temp;
        }
        
        public void NextgInitialize()
        {
        
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    CommonClass._Registration.Checkisregistred();
                    LoginFu();
                    Generalfunction.TempCompanyname = "";
                    ShowWindows();
                    NextGFuntion.AutoBackup();


                    CommonClass._Dbtask.ExecuteNonQuery("update tblparamlist set paramvalue='" + CommonClass._Dbtask.znllString(ComLanguage.Text) + "' where paramname='Language'");
                    //ChangeLanguage();

                    //ChangeLanguage();
                    return true;
                    
                    this.Close();
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


        public void SpecificationFu()
        {
            //regKey = regKey.CreateSubKey("Software\\Techno");
            Generalfunction.OpCompany = CmbSelctCompany.Text;
            ///regKey.SetValue("Opcompany", CmbSelctCompany.Text);

           CommonClass._Dbtask.SetServerName(TxtServerName.Text);
            
               
            regKey.SetValue("username", TxtUserName.Text);
            regKey.SetValue("Password", TxtPassword.Text);
            
            if (regKey.GetValue("Hpwd", 0).ToString() != "")
            {
                Generalfunction.BlShowEst = false;
            }

                if (ChkSetasdefault.Checked == true)
                {
                    regKey.SetValue("Savepwd", "1");
                    regKey.SetValue("Username",TxtUserName.Text);
                    regKey.SetValue("Pwd",TxtPassword.Text);
                    regKey.SetValue("Opcompany", CmbSelctCompany.Text);
                }
                else
                {
                    regKey.SetValue("Savepwd", "2");
                }
           
         
        }
        public void ShowWindows()
        {
            if (Generalfunction.EPharmacy == true)
                CommonClass._Forms.ShowExpiryReport();
        }
        private bool ValidationFu()
        {
            string UserName;
            string Password;

            try
            {
                Generalfunction.TempCompanyname = "";
                if (TxtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter a valid UserName", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUserName.Focus();
                    return false;
                }
                if (TxtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter a valid Password", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtPassword.Focus();
                    return false;
                }
               
                ClsUserDetails.MUserName = TxtUserName.Text;
                ClsUserDetails.ComputerName = System.Environment.MachineName.ToString();
              
           
                int Checked;

                if(ChkSetasdefault.Checked==true)
                {
                Checked=1;
                }
                else
                {
                    Checked=0;
                }

          
                CommonClass._ComCreate.SetLegistry(CmbSelctCompany.Text, TxtServerName.Text, TxtUserName.Text, TxtPassword.Text, Checked, DtDate);
              
                //_Userdetails.CheckUser(TxtUserName.Text.ToUpper(), TxtPassword.Text);
                UserName = CommonClass._Dbtask.ExecuteScalar("select UserName from tbluserdetails where username='" + TxtUserName.Text + "' and Upassword='" + TxtPassword.Text + "'");
               
                Password = CommonClass._Dbtask.ExecuteScalar("select UPassword from tbluserdetails where username='" + TxtUserName.Text + "' and Upassword='" + TxtPassword.Text + "'");
               
                ClsUserDetails.UserGroupid = CommonClass._Dbtask.ExecuteScalar("select ugroup from tbluserdetails where username='" + TxtUserName.Text + "' and Upassword='" + TxtPassword.Text + "'");

                UserName = UserName.ToLower();
                TxtUserName.Text = TxtUserName.Text.ToLower();
               
                if (UserName == TxtUserName.Text && Password == TxtPassword.Text)
                {
                    //  (this.MdiParent as MDIParent1).menuStrip.Enabled = true;
                   
                   CommonClass._settings.RefreshMenusettings();
                    Clssettings.ActiveCompany = true;
                    Generalfunction.BlnLogin = true;
                    this.Close();
                }
                else
                {
                    //(this.MdiParent as MDIParent1).menuStrip.Enabled = true;
                    //_Settings.RefreshMenusettings();
                    //this.Close();
                    MessageBox.Show("Invalid UserName or Password", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtUserName.Focus();
                    return false;
                }
            }
            catch
            {
                return false;
                MessageBox.Show("Error validation");
            }
            return true;
        }

        public void LoginFu()
        {
            try
            {
                SpecificationFu();
            }
            catch
            {
                
            }
          
        }

        private void TxtServerName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtServerName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void CmbSelctCompany_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbSelctCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Lblcompanyname.Text = CommonClass._ComCreate.CompanyName(CmbSelctCompany.Text);

                Lng = CommonClass._Dbtask.znllString(CommonClass._Dbtask.ExecuteScalar("SELECT  PARAMVALUE FROM  " + CmbSelctCompany.Text + "..TBLPARAMLIST " +
                     "  WHERE PARAMNAME='LANGUAGE'"));

                if (Lng == "English")
                {
                    ComLanguage.SelectedIndex = 0;
                }

                if (Lng == "Arabic")
                {
                    ComLanguage.SelectedIndex = 1;
                }


                if (Lng == "")
                {
                    ComLanguage.SelectedIndex = 0;


                }
            
            
            
            
            }
            catch
            {

            }
        }

       

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
            
                Main();
            }

        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure to Exit Application ?", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result.ToString() == "Yes")
            {
                Application.Exit();
            } 
        }

        private void CmbSelctCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13&&ChkSetasdefault.Checked==true)
            {
                Main();
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Generalfunction.BlnLogin == false)
                {
                    Application.Exit();
                }
            }
            catch
            {
            }
        }

        private void label21_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            try
            {
            string temp=TxtPassword.Text.ToLower();
                if(regKey.GetValue("bak") !=null)
             CommonClass.temp= regKey.GetValue("bak").ToString();

             if (TxtPassword.Text == CommonClass.temp)
            {
                CompanyListAll();
            }

            }
            catch
            {

            }
        }

        private void ChkSetasdefault_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
