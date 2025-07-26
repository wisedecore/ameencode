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
    public partial class FrmCreateCompany : Form
    {
        public FrmCreateCompany()
        {
            InitializeComponent();
        }
        public DataSet Ds;
        ClsCompanyMaster _CompanyMaster = new ClsCompanyMaster();
        ClsUserDetails _UserDetails = new ClsUserDetails();
        DBTask _Dbtask = new DBTask();
        NextGFuntion _Nextg = new NextGFuntion();
        ClsParamlist _Paramlist = new ClsParamlist();
        Generalfunction _Gen = new Generalfunction();
        public bool Isinotherwindow = false;
        public bool EditMode = false;

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

        public int Mod;
        public int TaxChecking;


        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GroupBoxConvertion(Grpyear);
            }
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
            //DialogResult Result = MessageBox.Show("Login New Company", "Login Created Company", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (Result.ToString() == "Yes")
            //{

            //    FrmLogin _Login = new FrmLogin();
            //   // _Login.MdiParent = this;
            //    Generalfunction.Comeform = "MDILOG";
            //    _Login.Show();
            //} 
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
                    Insert();
                    this.Close();
                    //Clear();
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
        public void Insert()
        {
            _CompanyMaster.InsertCompany();
            
            
        }
        private bool ValidationFu()
        {
            try
            {


                if (Txtsellersname.textBox1.Text == "")
                {
                    //   MessageBox.Show("Type Vno");
                    MessageBox.Show("Type Sellers Name", "Nesma Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    Txtsellersname.Focus();
                    return false;
                }
                if (Txttrn.textBox1.Text == "")
                {
                    MessageBox.Show("Type TRN", "Nesma POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Txttrn.Focus();
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Clear()
        {
            _Nextg.ClearControles(this);
            FuMenusettings();
            fromparamlist();
            TxtCompanyName.textBox1.Focus();
            Txtvaliditydurtn.textBox1.Text =_Dbtask.znllString( CommonClass._Dbtask.GetvaliditydurationSelect());
            ChangeLanguage();
        }

        public void FuMenusettings()
        {
            if (CommonClass._Menusettings.GetMnustatus("176") == "1")
            {
                Txtcustomerid.Enabled = true;
                TxtCustomerArea.Enabled = true;
            }

            if (CommonClass._Menusettings.GetMnustatus("212") == "1")
            {
                txtnicknamee.Enabled = true;

            }
            if (CommonClass._Menusettings.GetMnustatus("213") == "1")
            {
                Txtvaliditydurtn.Enabled = true;
            }


        }

        public void fromparamlist()
        {
            TxtNoOfdecimalCurrency.textBox1.Text = _Paramlist.GetParamvalue("CurDecc");
            TxtNoofDecimalStock.textBox1.Text = _Paramlist.GetParamvalue("StockDecc");
            DtFrom.Value =Convert.ToDateTime(_Paramlist.GetParamvalue("periodfrom"));
            DtTo.Value = Convert.ToDateTime(_Paramlist.GetParamvalue("periodto"));
        }
        public void UpdateParamlist()
        {
            _Paramlist.UpdateParamlist("CurDecc", "0", TxtNoOfdecimalCurrency.textBox1.Text);
            _Paramlist.UpdateParamlist("StockDecc", "0", TxtNoofDecimalStock.textBox1.Text);

            _Paramlist.UpdateParamlist("periodfrom", "0", DtFrom.Value.ToString("dd/MMM/yyyy"));
            _Paramlist.UpdateParamlist("periodto", "0", DtFrom.Value.ToString("dd/MMM/yyyy"));
        }
        public void NextgInitialize()
        {
            _Dbtask.ExecuteNonQuery("DELETE FROM TBLCOMPANYMASTER");
            _CompanyMaster.CompanyNameStr = TxtCompanyName.textBox1.Text;

            _CompanyMaster.CompanyNameinHomeStr = TxtNameinhome.textBox1.Text;
            _CompanyMaster.TaxInt = TaxChecking;
            _CompanyMaster.Address1Str = TxtAddress1.textBox1.Text;
            _CompanyMaster.Address2Str = TxtAddress2.textBox1.Text;
            _CompanyMaster.CityStr = TxtCity.textBox1.Text;
            _CompanyMaster.StateStr = TxtState.textBox1.Text;
            _CompanyMaster.POstalcodeStr = TxtpostalCode.textBox1.Text;
            _CompanyMaster.PhoneStr = TxtPhone.textBox1.Text;
            _CompanyMaster.MobileStr = TxtMobile.textBox1.Text;
            _CompanyMaster.FaxStr = TxtFax.textBox1.Text;
            _CompanyMaster.EmailStr = TxtEmail.textBox1.Text;
            _CompanyMaster.WebsiteStr = TxtWebsite.textBox1.Text;
            _CompanyMaster.AccountNoStr = TxtAccountNo.textBox1.Text;
            _CompanyMaster.TaxNo1Str = TxtTaxNo1.textBox1.Text;
            _CompanyMaster.TaxNo2Str = TxtTaxNo2.textBox1.Text;
            _CompanyMaster.CountryStr = ComCountry.SelectedText;
            _CompanyMaster.NoOfDecimalInt =Convert.ToInt32(TxtNoOfdecimalCurrency.textBox1.Text);
            _CompanyMaster.FYearFromDt = DtFrom.Value;
            _CompanyMaster.FYearToDt = DtTo.Value;
            _CompanyMaster.VATNoStr = txtvatno.textBox1.Text;
            _CompanyMaster.CountryStr = ComCountry.Text;
            _CompanyMaster.Cusid = Txtcustomerid.textBox1.Text;
            _CompanyMaster.CusArea = TxtCustomerArea.textBox1.Text;
            _CompanyMaster.SellersName = Txtsellersname.textBox1.Text;
            _CompanyMaster.TRN = Txttrn.textBox1.Text;
            _CompanyMaster.District =_Dbtask.znllString( Txtdistrict.textBox1.Text );
            _CompanyMaster.countryname= _Dbtask.znllString(txtcountrynames.textBox1.Text);
            //_CompanyMaster.validityduration = _Dbtask.znllString(Txtvaliditydurtn.textBox1.Text);
            _CompanyMaster.nickname = _Dbtask.znllString(txtnicknamee.textBox1.Text);
            
            
            UpdateParamlist();

            CommonClass._Dbtask.Setvalidityduration(_Dbtask.znllString(Txtvaliditydurtn.textBox1.Text));/*Second Printer Save*/
            SetDecc();
        }
        public void SetDecc()
        {
            string tempstock = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='StockDecc'");
            string temocurr = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='CurDecc'");
            tempstock = _Nextg.Decconvertion(tempstock);
            temocurr = _Nextg.Decconvertion(temocurr);
            Generalfunction.CurreDeci = temocurr;
            Generalfunction.StockDeci = tempstock;
        }
        private void ChkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTax.Checked == true)
            {
                TaxChecking = 1;
            }
            else
            {
                TaxChecking = 0;
            }
        }

        private void FrmCreateCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FrmCreateCompany_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.Close();
            }
        }

        private void FrmCreateCompany_Load(object sender, EventArgs e)
        {
           // _Nextg.FormStylesett(this);
            //_Nextg.FormImage(pnlImage);
            //_Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            Clear();
            GetRetrive();
            CommonClass._Nextg.FormIcon(this);
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }
        
        public void GetRetrive()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblcompanymaster");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                TxtCompanyName.textBox1.Text = Ds.Tables[0].Rows[0]["cname"].ToString();
                TxtNameinhome.textBox1.Text = Ds.Tables[0].Rows[0]["nameinhome"].ToString();
                TxtAddress1.textBox1.Text = Ds.Tables[0].Rows[0]["address1"].ToString();
                TxtAddress2.textBox1.Text = Ds.Tables[0].Rows[0]["address2"].ToString();
                TxtCity.textBox1.Text = Ds.Tables[0].Rows[0]["city"].ToString();
                TxtState.textBox1.Text = Ds.Tables[0].Rows[0]["state"].ToString();
                TxtpostalCode.textBox1.Text = Ds.Tables[0].Rows[0]["pcode"].ToString();
                TxtPhone.textBox1.Text = Ds.Tables[0].Rows[0]["Telephone"].ToString();
                TxtMobile.textBox1.Text = Ds.Tables[0].Rows[0]["Mobile"].ToString();
                TxtFax.textBox1.Text = Ds.Tables[0].Rows[0]["fax"].ToString();
                TxtEmail.textBox1.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                TxtWebsite.textBox1.Text = Ds.Tables[0].Rows[0]["website"].ToString();
                TxtAccountNo.textBox1.Text = Ds.Tables[0].Rows[0]["accountno"].ToString();
                TxtTaxNo1.textBox1.Text = Ds.Tables[0].Rows[0]["taxno1"].ToString();
                TxtTaxNo2.textBox1.Text = Ds.Tables[0].Rows[0]["taxno2"].ToString();
                txtvatno.textBox1.Text = Ds.Tables[0].Rows[0]["vatno"].ToString();
                ComCountry.Text = Ds.Tables[0].Rows[0]["country"].ToString();
                TxtNoOfdecimalCurrency.textBox1.Text = Ds.Tables[0].Rows[0]["NoOfDecimal"].ToString();
                DtFrom.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0]["FYearFrom"].ToString());
                DtTo.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0]["FYearTo"].ToString());
                Txtcustomerid.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["CusId"]);
                TxtCustomerArea.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["CusArea"]);

                Txtsellersname.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["Sellersname"]);
                Txttrn.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["TRN"]);
                Txtdistrict.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["District"]);
                txtcountrynames.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["Countryname"]);
                //Txtvaliditydurtn.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["validityduration"]);
                //Txtvaliditydurtn.textBox1.Text = _Dbtask.znllString(CommonClass._Dbtask.GetvaliditydurationSelect());
                
                txtnicknamee.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["nickname"]);



            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

       

        

        private void TxtNoofDecimalStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void TxtCompanyName_Enter(object sender, EventArgs e)
        {
            if (TxtCompanyName.textBox1.Text == "Company Name (50 character)")
            {
                TxtCompanyName.textBox1.Text = "";
                TxtCompanyName.textBox1.ForeColor = Color.Red;
            }

        }

        private void TxtAddress2_TextChanged(object Sender, EventArgs e)
        {

        }

        private void TxtpostalCode_Load(object sender, EventArgs e)
        {

        }

        private void TxtNoofDecimalStock_TextChanged_1(object Sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void TxtCompanyName_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("cname", "TblCompanyMaster", TxtCompanyName.textBox1);

            if (TxtCompanyName.textBox1.Text.Length == 0)
            {
                TxtCompanyName.textBox1.Text = "Enter Company Name(max. 50)";
                TxtCompanyName.textBox1.ForeColor = Color.Red;
            }
        }

        private void TxtCompanyName_TextChanged(object Sender, EventArgs e)
        {
            if (TxtCompanyName.textBox1.Text.Length >250 )
            {

                MessageBox.Show("company is too long");
                TxtCompanyName.textBox1.Focus();
            
            }
        }

        private void TxtNameinhome_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Nameinhome", "TblCompanyMaster", TxtNameinhome.textBox1);

        }

        private void TxtAddress1_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address1", "TblCompanyMaster",TxtAddress1.textBox1);
        }

        private void TxtAddress2_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address2", "TblCompanyMaster", TxtAddress2.textBox1);

        }

        private void TxtCity_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("city", "TblCompanyMaster", TxtCity.textBox1);

        }

        private void Txtdistrict_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("District", "TblCompanyMaster", Txtdistrict.textBox1);

        }

        private void TxtState_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("state", "TblCompanyMaster", TxtState.textBox1);

        }

        private void txtcountrynames_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("countryname", "TblCompanyMaster", txtcountrynames.textBox1);

        }

        private void TxtpostalCode_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("pcode", "TblCompanyMaster", TxtpostalCode.textBox1);

        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("telephone", "TblCompanyMaster", TxtPhone.textBox1);

        }

        private void TxtMobile_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("mobile", "TblCompanyMaster", TxtMobile.textBox1);

        }

        private void TxtFax_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Fax", "TblCompanyMaster", TxtFax.textBox1);

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Email", "TblCompanyMaster", TxtEmail.textBox1);
        }

        private void TxtWebsite_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("website", "TblCompanyMaster", TxtWebsite.textBox1);

        }

        private void TxtAccountNo_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("accountno", "TblCompanyMaster", TxtAccountNo.textBox1);

        }

        private void TxtTaxNo1_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("taxno1", "TblCompanyMaster", TxtTaxNo1.textBox1);

        }

        private void TxtTaxNo2_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("taxno2", "TblCompanyMaster", TxtTaxNo2.textBox1);

        }

        private void Txtsellersname_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Sellersname", "TblCompanyMaster", Txtsellersname.textBox1);

        }

        private void txtvatno_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("VATno", "TblCompanyMaster", txtvatno.textBox1);

        }

        private void Txttrn_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("TRN", "TblCompanyMaster", Txttrn.textBox1);

        }

        private void Txtcustomerid_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("CusId", "TblCompanyMaster", Txtcustomerid.textBox1);

        }

        private void TxtCustomerArea_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("CusArea", "TblCompanyMaster", TxtCustomerArea.textBox1);

        }

        private void Txtvaliditydurtn_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("validityduration", "TblCompanyMaster", Txtvaliditydurtn.textBox1);
        }

        private void txtnicknamee_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("nickname", "TblCompanyMaster", txtnicknamee.textBox1);
        }

      
     

      
    }
}
