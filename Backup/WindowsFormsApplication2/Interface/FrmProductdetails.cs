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
    public partial class FrmProductdetails : Form
    {
        public FrmProductdetails()
        {
            InitializeComponent();
        }
        RegistryKey regKey = Registry.CurrentUser;
        DBTask _Dbtask = new DBTask();
        public string Prodctid = ""; public string cdkey = ""; public string Registrationnumber = "";
        public string companyname = ""; public string contact = "";
        public string vat = ""; public string adrss = ""; public string Cusid = ""; public string CusArea = "";
        public string validitydt = ""; public string nickname = "";
        string validationtext = ""; string validationtexttwo = "";

        public void validitychk()
        {
            DateTime noww;
            regKey = regKey.CreateSubKey("Software\\Techno");
            if (_Dbtask.znllString(regKey.GetValue("Rn", 0)) != "")
            {
                string jj = _Dbtask.znllString(regKey.GetValue("Rn", ""));
                DateTime dd = _Dbtask.ZnullDatetime(regKey.GetValue("Rn", ""));
                 dd = dd.AddYears(1);
                 noww = System.DateTime.Today;

                 //noww = noww.AddYears(1);
                 if (noww > dd)
                 {
                     validitydt = "Expired";
                 }
                 else
                 {
                     validitydt =_Dbtask.znllString( dd);
                     validitydt = validitydt.Substring(0, 10);

                 }


            }
        }
        public void productdetails()
        {


            validitychk();
            CommonClass._Reg.Checkisregistred();
            if (Clsregistration.IsRegistred == true)
            {
                lblheadng.Text = "Product Details";
                companyname = CommonClass._compMaster.GetspecifField("cname").ToString();
                contact = CommonClass._compMaster.GetspecifField("mobile").ToString();
                adrss = CommonClass._compMaster.GetspecifField("Address1").ToString();
                vat = CommonClass._compMaster.GetspecifField("taxno1").ToString();
                Cusid = CommonClass._compMaster.GetspecifField("CusId").ToString();
                CusArea = CommonClass._compMaster.GetspecifField("CusArea").ToString();
                nickname = CommonClass._compMaster.GetspecifField("nickname").ToString();
                validationtext = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("validatnfrom"));

                validationtexttwo = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("validatnTO"));


                
                
                CommonClass._Reg.GetRegistrationdetails();

                cdkey = Clsregistration.PCdkey;
                Prodctid = Clsregistration.Pproductid;
                Registrationnumber = Clsregistration.Pregistrationno;

                lblkeyy.Text = cdkey.ToString();
                labeliD.Text = Prodctid.ToString();
                Lblregistrationno.Text = Registrationnumber.ToString();

                LblcustomerArea.Text = CusArea;
                lblcaddress.Text = adrss.ToString();
                lblvat.Text = vat.ToString();
                lblmob.Text = contact.ToString();
                labelheaadds.Text = companyname.ToString();
                Lblcustomerid.Text = Cusid;
                lblvalityvalue.Text = validitydt;
                lblnickname.Text = nickname;

                lblvaliditydurationvalue.Text =   _Dbtask.znllString( CommonClass._Dbtask.GetvaliditydurationSelect());
                lblvalidationtext.Text = validationtext + "  - " + validationtexttwo;


            }
            else
            {
                lblheadng.Text = "Not Registred Copy";
                Pnlregistrationdetails.Visible = false;
            }
        }

        private void FrmProductdetails_Load(object sender, EventArgs e)
        {
            productdetails();
        }

        private void Cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnlregistrationdetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
