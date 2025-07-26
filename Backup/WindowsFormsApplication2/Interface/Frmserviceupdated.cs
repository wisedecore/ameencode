using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;
//using 

namespace WindowsFormsApplication2
{
    public partial class Frmserviceupdated : Form
    {
        public Frmserviceupdated()
        {
            InitializeComponent();
        }

        string Productid;
        string CdKey;
        string RegistrationNumber;
        string Temp;
        string NewProductId;
        string NewCdKey;
        string NewCode;
        ClsAmc _amc = new ClsAmc();
        RegistryKey regKey = Registry.CurrentUser;
        Clsregistration _Reg = new Clsregistration();
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        ManagementObjectSearcher searcher;

        public string GetRegistrationCode()
        {
            CdKey = txtcdkey.Text;
            Productid = txtproductidHdd.Text+txtproductidfirmware.Text+txtproductidMB.Text+txtproductidCPU.Text;

            CdKey = rgx.Replace(CdKey, "");
            Productid = rgx.Replace(Productid, "");

            NewProductId = CdKey + Productid;

            //NewProductId = "123457985333";
            string Temp = MD5HashGenerator.GenerateKeySERVICE(NewProductId);

            return Temp;
        }

       
        private string GetUniqueKey()
        {
            int maxSize = 8;
            int minSize = 5;
            char[] chars = new char[62];
            string a;
            a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            chars = a.ToCharArray();
            int size = maxSize;
            byte[] data = new byte[1];
            //RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
           // crypto.GetNonZeroBytes(data);
            size = maxSize;
            data = new byte[size];
           // crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(size);
            foreach(byte b in data )
            { 
             //   result.Append(chars[__b % (chars.Length - )>); }
             //<span class="code-keyword">return result.ToString();
            }
            return "";
        }

        public string FuHdmodelno(string Pcdkey)
        {
              /*******For Hard discModelNumber***********/
                string Hdiscid = _Reg.HraddiscModelNumber() + Pcdkey;
                Hdiscid = MD5HashGenerator.GenerateKeySERVICE(Hdiscid);
                return Hdiscid.Substring(0, 4);
        }

        public string FuHdfirmware(string Pcdkey)
        {
                /*******For Hard discFirmware***********/
                string HdFirmWare = _Reg.HarddiscFirmware() + Pcdkey;
                HdFirmWare = MD5HashGenerator.GenerateKeySERVICE(HdFirmWare);
                return  HdFirmWare.Substring(0, 4);
        }

        public string FuMbno(string PMBmodelno)
        {
            /*******For Mother Board number***********/
            string MBModelNumber = _Reg.MotherBoardId() + PMBmodelno;
            MBModelNumber = MD5HashGenerator.GenerateKeySERVICE(MBModelNumber);
            return MBModelNumber.Substring(0, 4);
        }

        public string FuCpuslno(string Pcpuid)
        {
            /*******For CPU Serial***********/
            string CPUID = _Reg.CPUSerialNumber() + Pcpuid;
            CPUID = MD5HashGenerator.GenerateKeySERVICE(CPUID);
            return CPUID.Substring(0, 4);
        }

        public void GenerateProductId()
        {
            CdKey = txtcdkey.Text;
            if (CdKey != "")
            {
                /*******For Hard discModelNumber***********/
                txtproductidHdd.Text = FuHdmodelno(CdKey);


                /*******For Hard discFirmware***********/
                txtproductidfirmware.Text = FuHdfirmware(CdKey);

                /*******For Mother Board number***********/
                txtproductidMB.Text = FuMbno(CdKey);

                /*******For CPU Serial***********/
                txtproductidCPU.Text = FuCpuslno(CdKey);
            }
        }

        private void txtproductid_Enter(object sender, EventArgs e)
        {
        }

        private void cmdgenerateregistrationnumber_Click(object sender, EventArgs e)
        {
          txtregistrationno.Text= GetRegistrationCode();
        }

        private void cmdregister_Click(object sender, EventArgs e)
        {
            if (GetRegistrationCode() == txtregistrationno.Text)
            {

                //string BB = CommonClass._Dbtask.znllString(txtcdkey.Text).Substring(0, 2);

                if (CommonClass._Dbtask.znllString(txtcdkey.Text).Substring(0, 2) == "SR")
                {


                    Clsregistration.IsRegistred = true;

                    //CommonClass._Registration.InsertTable();
                    _amc.Amccdkey = txtcdkey.Text;
                    _amc.Amcproductid = txtproductidHdd.Text + txtproductidfirmware.Text + txtproductidMB.Text + txtproductidCPU.Text;
                    _amc.Amcregnumber = txtregistrationno.Text;
                    _amc.insertAMCdetails();



                    regKey.SetValue("Rn", DateTime.Now.ToString("dd/MM/yyyy"));
                    // regKey.SetValue(
                    MessageBox.Show("Service  Updated", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Generalfunction.TempCompanyname = "";

                    this.Close();
                }


                else
                {
                    MessageBox.Show("Invalid CDKey", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid CDKey", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double  CHKSERVICEupdate()
        {

           
            string rndate = "";

          
            //rndate = regKey.GetValue("Opcompany", 0).ToString();

           
            if (regKey.GetValue("Rn") == null)
            {
                rndate =CommonClass._Dbtask.znllString( CommonClass._Paramlist.GetParamvalue("RGdate"));
                regKey.SetValue("Rn",CommonClass._Dbtask.ZnullDatetime( rndate).ToString("dd/MM/yyyy"));
            
            }
            else
            {
            rndate = regKey.GetValue("Rn", 0).ToString();
             }
           


            DateTime lstdate = CommonClass._Dbtask.ZnullDatetime(rndate);
            lstdate = lstdate.AddDays(365);
            DateTime ttdy;
            ttdy = System.DateTime.Today;
            int dayss = 0;
            //dayss = (lstdate - ttdy).TotalDays;
            //lstdate = lstdate.AddDays(-365);
            
            
            TimeSpan t = lstdate - ttdy;
             double NrOfDays =0;
             NrOfDays = t.TotalDays;
             return NrOfDays;

        }

        private void Frmregistration_Load(object sender, EventArgs e)
        {
            regKey = regKey.CreateSubKey("Software\\Techno");
            //regKey = regKey.CreateSubKey("Computer\\HKEY_CURRENT_USER\\SOFTWARE\\Techno");

            CommonClass._Reg.Checkisregistred();
            if (Clsregistration.IsRegistred == true)
            {
                if (CHKSERVICEupdate() <=0 )
                {
                    pnlregistration.Visible = true;
                    panltrue.Visible = false;
                }
                else
                {
                    pnlregistration.Visible = false;
                    lblreg.Visible = true;
                    lblreg.Text = "VALIDITY  " + CommonClass._Dbtask.znllString(CHKSERVICEupdate())  + "  "+" DAYS.";
                    //lblreg.Location = new Point(30, 150);
                    panltrue.Visible = true;
                    panltrue.Location = new Point(0, 120);
                }
            }
            else
            {
                pnlregistration.Visible = true;
                panltrue.Visible = false;
            }

            CommonClass._Nextg.FormIcon(this);

        }

        private void txtcdkey_Leave(object sender, EventArgs e)
        {
            GenerateProductId();

        }

       
    }
}