using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Org.BouncyCastle.Asn1.Crmf;
using System.Runtime.ConstrainedExecution;
using sun.misc;
using Org.BouncyCastle.Utilities.IO.Pem;
using java.lang.annotation;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZatcaIntegrationSDK;
using ZatcaIntegrationSDK.APIHelper;
using ZatcaIntegrationSDK.BLL;
using ZatcaIntegrationSDK.HelperContracts;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Microsoft;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using System.IO;


namespace WindowsFormsApplication2
{
    public partial class FrmAutogenerate : Form
    {
        public FrmAutogenerate()
        {
            InitializeComponent();
        }


        private Mode mode { get; set; }
        DBTask _dbtask = new DBTask();
        ClsCompanyMaster _company = new ClsCompanyMaster();

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
        private void FrmAutogenerate_Load(object sender, EventArgs e)
        {
            retreive();
        }
        public void main()
        {
            _dbtask.ExecuteNonQuery("delete from TblPHASEtwocompanyprofile");
            CommonClass._phase.Workingtype = _dbtask.znllString(combotype.SelectedIndex);
            CommonClass._phase.OTP = _dbtask.znllString(txt_otp.Text);
            CommonClass._phase.CommonName = _dbtask.znllString(txt_commonName.Text);
            CommonClass._phase.firmname = _dbtask.znllString(txtfirmname.Text);
            CommonClass._phase.countrytext = _dbtask.znllString(txt_countryName.Text);
            CommonClass._phase.SerialNumber = _dbtask.znllString(txt_serialNumber.Text);
            CommonClass._phase.location = _dbtask.znllString(txt_location.Text);
            CommonClass._phase.Branchname = _dbtask.znllString(Txtbranchname.Text);

            CommonClass._phase.vatnumber = _dbtask.znllString(TxtVAT.Text);
            CommonClass._phase.Industry = _dbtask.znllString(txt_industry.Text);
            CommonClass._phase.CSR = _dbtask.znllString(txt_csr.Text);
            CommonClass._phase.PrtKEY = _dbtask.znllString(txt_privatekey.Text);
            CommonClass._phase.PblKEY = _dbtask.znllString(txt_publickey.Text);
            CommonClass._phase.ScrtKEY = _dbtask.znllString(txt_secret.Text);

            CommonClass._phase.CRN = _dbtask.znllString(Txtcrn.Text);
            CommonClass._phase.Street = _dbtask.znllString(Txtstreet.Text);
            CommonClass._phase.BuildingNo = _dbtask.znllString(TxtbuildingNo.Text);
            CommonClass._phase.City = _dbtask.znllString(Txtcity.Text);
            CommonClass._phase.Postelcode = _dbtask.znllString(Txtpostelcode.Text);
            CommonClass._phase.Subdivision = _dbtask.znllString(Txtsubdivision.Text);

            CommonClass._phase.InsertPHASEtwocompanyprofile();



        }

        public void clear()
        {
            combotype.SelectedIndex = 0;
            txt_otp.Text = "";
            txt_commonName.Text = "";
            txtfirmname.Text = "";
            TxtVAT.Text = "";
            Txtbranchname.Text = "";

            txt_countryName.Text = "";
            txt_serialNumber.Text = "";
            txt_location.Text = "";
            txt_industry.Text = "";
            txt_csr.Text = "";
            txt_privatekey.Text = "";

            txt_publickey.Text = "";
            txt_secret.Text = "";
        }
        public void retreive()
        {

            DataSet DSS;
            DSS = _dbtask.ExecuteQuery("SELECT * FROM TblPHASEtwocompanyprofile");

            if (DSS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DSS.Tables[0].Rows.Count; i++)
                {
                    combotype.SelectedIndex = Convert.ToInt32(DSS.Tables[0].Rows[i]["Workingtype"]);
                    txt_otp.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["OTP"]);
                    txt_commonName.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["CommonName"]);
                    txtfirmname.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["firmname"]);
                    TxtVAT.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["vatnumber"]);
                    Txtbranchname.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["Branchname"]);

                    txt_countryName.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["countrytext"]);
                    txt_serialNumber.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["SerialNumber"]);
                    txt_location.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["location"]);
                    txt_industry.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["Industry"]);
                    txt_csr.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["CSR"]);
                    txt_privatekey.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["PrtKEY"]);

                    txt_publickey.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["PblKEY"]);
                    txt_secret.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["ScrtKEY"]);

                    Txtcrn.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["CRN"]);
                    Txtstreet.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["CStreet"]);
                    TxtbuildingNo.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["BuildingNo"]);
                    Txtcity.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["City"]);
                    Txtpostelcode.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["PostelCode"]);
                    Txtsubdivision.Text = _dbtask.znllString(DSS.Tables[0].Rows[i]["SubDivision"]);
                }


            }
            else
            {
                clear();
                //CommonClass._phase.vatnumber = _dbtask.znllString(_company.GetspecifField("taxno1"));
                //CommonClass._phase.Industry = _dbtask.znllString(_company.GetspecifField("industry"));
                //CommonClass._phase.location = _dbtask.znllString(_company.GetspecifField("city"));
                //CommonClass._phase.Branchname = _dbtask.znllString(_company.GetspecifField("branch"));
                //CommonClass._phase.countrytext = _dbtask.znllString(_company.GetspecifField("countryname"));


            }




        }


        private CertificateRequest GetCSRRequest()
        {
            CertificateRequest certrequest = new CertificateRequest();
            certrequest.OTP = _dbtask.znllString(txt_otp.Text);
            certrequest.CommonName = txt_commonName.Text;
            certrequest.OrganizationName = txt_commonName.Text;
            certrequest.OrganizationUnitName = "Thalaa Mall trading Company";
            certrequest.CountryName = _dbtask.znllString(_company.GetspecifField("countryname"));
            certrequest.SerialNumber = _dbtask.znllString(txt_serialNumber.Text);
            certrequest.OrganizationIdentifier = "311267971300003";
            certrequest.Location = "Jizan";
            certrequest.BusinessCategory = "Retail";
            // certrequest.InvoiceType = cmb_invoicetype.SelectedValue.ToString();
            return certrequest;
        }

        private void btn_csid_Click(object sender, EventArgs e)
        {
            main();
            //Invoice inv = new Invoice();
            ////STRT
            //CertificateRequest certrequest = GetCSRRequest();

            //if (combotype.SelectedIndex == 0)
            //    mode = Mode.Simulation;
            //else if (combotype.SelectedIndex == 1)
            //    mode = Mode.Production;
            //else
            //    mode = Mode.developer;
            //CSIDGenerator generator = new CSIDGenerator(mode);
            //CertificateResponse response = generator.GenerateCSID(certrequest, inv, Directory.GetCurrentDirectory());
            //if (response.IsSuccess)
            //{
            //    // get all certificate data
            //    txt_csr.Text = response.CSR;
            //    txt_privatekey.Text = response.PrivateKey;
            //    txt_publickey.Text = response.CSID;
            //    txt_secret.Text = response.SecretKey;
            //    btn_publickey_save.Visible = true;
            //    btn_info.Visible = true;
            //    btn_privatekey_save.Visible = true;
            //    btn_csr_save.Visible = true;
            //    btn_secretkey_save.Visible = true;
            //}
            //else
            //{
            //    MessageBox.Show(response.ErrorMessage);
            //}

        }

        private void btn_csr_save_Click(object sender, EventArgs e)
        {
            main();
        }
    }
}
