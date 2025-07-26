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
    public partial class FrmCheckinuser : Form
    {
        public FrmCheckinuser()
        {
            InitializeComponent();
        }
        public static bool Blreturn;
        public bool IncludeBatch;
        public string Vtype;
        public string UserName;
        public string Password;
        ClsUserDetails _Userdetails = new ClsUserDetails();
        DBTask _Dbtask = new DBTask();
        public DataSet Ds;
        public static bool RetriveType;

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
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
            }
        }

        private void FrmCheckinuser_Load(object sender, EventArgs e)
        {
            RetriveType = false;
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);
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
        public void Main()
        {
            RetriveType = false; bool del = false;
            UserName = txtusername.Text.Replace("'","");
            Password = TxtPassword.Text.Replace("'","");
            
                //Ds = _Dbtask.ExecuteQuery("select * from tbluserdetails where username='" + UserName + "' and upassword='" + Password + "' and userid=1");
            //Ds.Tables[0].Rows.Count > 0



            if (UserName == "nes321" && Password == "nes321")
            {
                Blreturn = true;

             
                
                if (Vtype == "ClearTransaction")
                {
                    DialogResult Result = MessageBox.Show("Confirm clear Transaction !", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (Result.ToString() == "Yes")
                     {
                         ClearTRansaction();
                     }
                     this.Close();
                }
                if (Vtype == "showsettings")
                {
                    Frmsettings _settings = new Frmsettings();
                    _settings.ShowDialog();
                }
                if (Vtype == "yearend")
                {
                    Frmyearending _YearEnd = new Frmyearending();
                    _YearEnd.ShowDialog();
                }
                if (Vtype == "creditlimit")
                {
                    RetriveType = true;
                }
                if (Vtype == "DeletePurchase")
                {
                    Frmpurchase _Purchase = new Frmpurchase();
                    _Purchase.Clear();
                }

                if (Vtype == "Showdeletecompany")
                {
                    frmdeletecomp _deletecompany = new frmdeletecomp();
                    _deletecompany.ShowDialog();
                    
                }

                if (Vtype == "ShowCommandwindow")
                {
                    //this.Close();
                    Frmcommandwindow _Form = new Frmcommandwindow();
                  _Form.ShowDialog();
                    //_Form.Show();
                  this.Close();
                  this.Close();
                }

           

                //foreach (Form f in Application.OpenForms)
                //{
                //    if (f.Name == "FrmCheckinuser")
                //    {
                //        f.Close();
                //    }
                //}

                
               
            }
            else
            {
                MessageBox.Show("Invalid Login", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                txtusername.Focus();
                Blreturn = false;
            }
        }
        public void ClearTRansaction()
        {
            _Dbtask.ExecuteNonQuery("DELETE FROM TBLTRANSACTIONRECEIPT");
            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails");
            _Dbtask.ExecuteNonQuery("delete from tblbusinessissue");
            _Dbtask.ExecuteNonQuery("delete from tblissuedetails");
            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger");
            _Dbtask.ExecuteNonQuery("delete from tblinventory");
            _Dbtask.ExecuteNonQuery("delete from tblinterneltransfer");
            _Dbtask.ExecuteNonQuery("delete from tbltransferdetails");
           
            if(IncludeBatch==true)
            _Dbtask.ExecuteNonQuery("delete from tblbatch");

            _Dbtask.ExecuteNonQuery("delete from tblproductsett");
            _Dbtask.ExecuteNonQuery("delete from tblproductsettdetail");
            _Dbtask.ExecuteNonQuery("delete from tblreceivedproduct");
            _Dbtask.ExecuteNonQuery("delete from tblreceivedproductdetail");
            _Dbtask.ExecuteNonQuery("delete from tblissueproduct");
            _Dbtask.ExecuteNonQuery("delete from tblissueproductdetail");
            _Dbtask.ExecuteNonQuery("delete from tblrepacking");
            _Dbtask.ExecuteNonQuery("delete from tblrepackingdetails");
            _Dbtask.ExecuteNonQuery("delete from Tblchqreceived");
            _Dbtask.ExecuteNonQuery("delete from tblbillsett");
            _Dbtask.ExecuteNonQuery("delete from tblauditlog");

            _Dbtask.ExecuteNonQuery("UPDATE  tblparamlist SET PARAMVALUE='1'  where paramname IN ('MaxofSO','MaxofSI','MaxofSQ','MaxofSR','MaxofPI','MaxofPR','MaxofSIwh','MaxofPO')");
   

            _Dbtask.ExecuteNonQuery("UPDATE  tblparamlist SET PARAMVALUE='1' where paramname IN ('MINofSO','MINofSI','MINofSQ','MINofSR','MINofPI','MINofPR','MINofSIwh','MINofPO')");    
            
          //tblauditlog
      
            
            MessageBox.Show("Transaction  Fully cleared  & RESTART the Software", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            Main();
        }

       



        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmCheckinuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {

            Enetersett(txtusername);
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            Leavesett(txtusername);
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {

            //Enetersett(txtpassword.textBox1);
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {

          // Leavesett(txtpassword.textBox1);
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        

    

       

       
      
        
    }
}
