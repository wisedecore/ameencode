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
    public partial class frmcreateledger : Form
    {
        public frmcreateledger()
        {
            InitializeComponent();
        }

        frmsalesinvoice _sales = new frmsalesinvoice();
        NextGFuntion _Nextg = new NextGFuntion();
        Clssettings _Settings = new Clssettings();
        DataSet Ds = new DataSet();
        DataSet Ds1 = new DataSet();
        int Isusecard;
        public bool Isinotherwindow = false;
        public bool EditMode = false;
        public bool FillingMode;
        public long Ledid;
        string Temptname;

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                //CommonClass._Language.PanelBasedConversion(panel1);
                //CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (this.ActiveControl != null)
            {
                if (this.ActiveControl.Name != "TxtAddress")
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Enter)
                    {
                        SendKeys.Send("{Tab}");
                        return true;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        Clscustomerpoint _Customerpoint = new Clscustomerpoint();
        DBTask _Dbtask = new DBTask();
        public double DBAmt;
        public double CRAmt;
        public string WheregroupeQuerye;
       // public static int Isinotherwindow = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void DeleteLedger()
        {
            _Dbtask.ExecuteNonQuery("delete from tblaccountledger where lid ='" + TxtLedId.Text + "'");
            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger  where ledcode='" + TxtLedId.Text + "' and purticulars='Opening Balance' and refno=1001 and vtype='OB'");

        }
        public void DeleteLedgerAzureServer()
        {
            _Dbtask.ExecuteNonQueryAzureServer("delete from tblaccountledger where lid ='" + TxtLedId.Text + "'");
            _Dbtask.ExecuteNonQueryAzureServer("delete from tblgeneralledger  where ledcode='" + TxtLedId.Text + "' and purticulars='Opening Balance' and refno=1001 and vtype='OB'");

        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if(EditMode==false)
                    GetLedCode();
                    if (EditMode == true)
                    {
                        Temptname = _AccountLedger.GetspecifField("lname", TxtLedId.Text);
                        DeleteLedger();
                        DeleteLedgerAzureServer();
                    }
                    NextgInitialize();

                    Insert();
                    
                    if (Isinotherwindow == true)
                    {
                        this.Close();
                       _sales.TxtAccount.Text = TxtName.textBox1.Text;
                       _sales.TxtAccount.Tag = TxtLedId.Text;
                       
                    }
                    Clear(false);
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
            _AccountLedger.InsertLedger();
            _AccountLedger.InsertLedgerAzure();
            if (DBAmt != 0.0 || CRAmt != 0.0)
            {
                _GeneralLedger.InsertGeneralLedger();
                _GeneralLedger.InsertGeneralLedgerAzureServer();
            }
        }
        public void Clear(bool FillComb)
        {
            ClearControles();
            GetLedCode();
            GetVno();

            if(FillComb==true)
            {
            FillCombo();
            }

            TxtOpeningBalance.Text = "0.00";
           // SetDecimal();
            TxtName.textBox1.Focus();
            if (Generalfunction.Comeform == "MDISUPPLIER")
            {
                RadCr.Checked = true;
                this.Text = "Create Supplier";
            }

            if (Generalfunction.Comeform == "MDICUSTOMER")
            {
                RadDr.Checked = true;

            if (_Settings.FunSettings1("customerpoint") == true)
            {
                    lblcardplan.Visible = true;
                    lblcardplandot.Visible = true;
                    comcustomercardplan.Visible = true;
            }

            this.Text = "Create Customer";
            }

            if (Generalfunction.Comeform == "MDIAGENT")
            {
                RadCr.Checked = true;
                this.Text = "Create Agent";
            }
            if (this.Text == "Create Ledger")
            {
              //  lblheading.Location = new System.Drawing.Point(108, 3);
            }
           // Isinotherwindow = false;

            TxtTaxRegNum.Text = "";

            txtscheme.Text = "";
            txtstreetname.Text = "";
            txtadditionalstreet.Text = "";
            txtbuildingnum.Text = "";
            txtcountrysubenitity.Text = "";
            txtcitysubdivision.Text = "";
            txtidentificationcode.Text = "";
            txtregistrationame.Text = "";
            txtcompanyid.Text = "";



            EditMode = false;
            Gridcustomerlist.Visible = false;
        }

        public void FillCombo()
        {
            _AccountGroup.FillComboWhere(ComAccountGroup,WheregroupeQuerye);
            _Customerpoint.FillCustomerpoint(comcustomercardplan);
            CommonClass._Area.FillArea(Comarea);
        }
        public void GetLedCode()
        {
            _AccountLedger.IdAccountLedger();
            TxtLedId.Text = Convert.ToString(_AccountLedger.LidLng);
        }
        public void GetVno()
        {
            _GeneralLedger.IdGeneralLedger(" where vtype='OB'");
            TxtVno.Text = _GeneralLedger.VnoStr;
        }
        public void ClearControles()
        {
            _Nextg.ClearUsercontroles(this);
        }
        public void NextgInitialize()
        {
            /*Account Ledger */

            if (_Dbtask.znllString(TxtAliasName.textBox1.Text) == "")
            {
                TxtAliasName.textBox1.Text =_Dbtask.znllString( TxtName.textBox1.Text);
            }
            _AccountLedger.LidLng =Convert.ToInt64(TxtLedId.Text);
            _AccountLedger.LNameStr = TxtName.textBox1.Text;
            _AccountLedger.LAliasNameStr = TxtAliasName.textBox1.Text;
            _AccountLedger.GidLng =Convert.ToInt64(ComAccountGroup.SelectedValue);
            _AccountLedger.AddressStr = TxtAddress.textBox1.Text;
            _AccountLedger.PhoneStr = TxtPhone.textBox1.Text;
            _AccountLedger.MobileStr = TxtMobile.textBox1.Text;
            _AccountLedger.DiscDb = _Dbtask.znullDouble(TxtDiscount.textBox1.Text);
            _AccountLedger.TaxRegNoStr = _Dbtask.znllString( TxtTaxRegNum.Text);
            _AccountLedger.EmailStr = TxtEmail.textBox1.Text;
            _AccountLedger.AreaStr = Comarea.SelectedValue.ToString();
            _AccountLedger.CreditDaysInt = _Dbtask.znullDouble(TxtCreditDays.textBox1.Text);
            _AccountLedger.CreditLimitDb = _Dbtask.znullDouble(TxtCreditLimit.textBox1.Text);
            _AccountLedger.OtherStr = TxtOther.textBox1.Text;
            _AccountLedger.Commision = _Dbtask.znullDouble(TxtCommision.textBox1.Text);
            _AccountLedger.CST = txtcst.textBox1.Text;
            _AccountLedger.Cplan =Convert.ToInt64(comcustomercardplan.SelectedValue);
            _AccountLedger.custmrcode = _Dbtask.znllString(txtcustomercode.textBox1.Text);

            _AccountLedger.cityy = _Dbtask.znllString(txtcityy.textBox1.Text);

            _AccountLedger.Lcountryname = _Dbtask.znllString(txtcountryy.textBox1.Text);

            _AccountLedger.postcode = _Dbtask.znllString(txtpostcode.textBox1.Text);

            _AccountLedger.LDistrict = _Dbtask.znllString(TXTdistrict.textBox1.Text);
            //new
            _AccountLedger.schemeId = _Dbtask.znllString(txtscheme.Text);
            _AccountLedger.streetname = _Dbtask.znllString(txtstreetname.Text);
            _AccountLedger.additionalstreetname = _Dbtask.znllString(txtadditionalstreet.Text);
            _AccountLedger.buildingnumber = _Dbtask.znllString(txtbuildingnum.Text);
            _AccountLedger.countrysubentity = _Dbtask.znllString(txtcountrysubenitity.Text);
            _AccountLedger.citysubdivisionname = _Dbtask.znllString(txtcitysubdivision.Text);
            _AccountLedger.identificationCode = _Dbtask.znllString(txtidentificationcode.Text);
            _AccountLedger.RegistrationNumber = _Dbtask.znllString(txtregistrationame.Text);
            _AccountLedger.CompanyId = _Dbtask.znllString(txtcompanyid.Text);


            CheckUseCard(true);
            
            if (RadDr.Checked == true)
            {
                DBAmt = _Dbtask.znullDouble(TxtOpeningBalance.Text);
                CRAmt = 0;
            }
            else
            {
                CRAmt = _Dbtask.znullDouble(TxtOpeningBalance.Text);
                DBAmt = 0;
            }
            /*General Ledger */
            if (DBAmt != 0.0 || CRAmt != 0.0)
            {
                _GeneralLedger.VdateDt = DtOpeningDate.Value;
                _GeneralLedger.VTypeStr = "OB";
                _GeneralLedger.VnoStr = TxtVno.Text;
                _GeneralLedger.SlNoLng = Convert.ToInt64("1");
                _GeneralLedger.LedCodeStr = TxtLedId.Text;
                _GeneralLedger.PurticularsStr = "Opening Balance";
                _GeneralLedger.RefnoStr = "1001";
                _GeneralLedger.DbAmtDb = DBAmt;
                _GeneralLedger.CrAmt = CRAmt;
               // _GeneralLedger.InsertGeneralLedger();
            
            }
            /*For Refresh Purchase and Sales*/
            if(EditMode==true)
            {
           
            //CommonClass._Transactionreceipt.UpdateFiled("update tbltransactionreceipt set tename ='"+TxtName.textBox1.Text+"' where tename='"+Temptname+"'");
            //CommonClass._Transactionreceipt.UpdateFiled("update tblbusinessissue set tename ='"+TxtName.textBox1.Text+"' where tename='"+Temptname+"'");
            }
        }

        private bool ValidationFu()
        {
            if (TxtName.textBox1.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Please Enter Ledger Name", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.textBox1.Focus();
                return false;
            }
            if (ComAccountGroup.SelectedValue ==null)
            {
                MessageBox.Show("Please Select Account Group", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComAccountGroup.Focus();
                return false;
            }

            if (chkcard.Checked == true)
            {
                double USECARD = 0;
                USECARD = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT COUNT(LID) FROM TBLACCOUNTLEDGER WHERE USECARD=1"));

                if(EditMode==false)
                {

                if (USECARD > 0)
                {
                    chkcard.Checked = false;
                    MessageBox.Show("Allowed use as card count = 1 ");
                    return false;
                }
                }

            }



            if (EditMode == false)
            {
                string Ledcode = _Dbtask.ExecuteScalar("select lname from tblaccountledger where lname=N'" + TxtAliasName.textBox1.Text.ToString() + "' and lstatus=-1").ToString();
                if (Ledcode != "")
                {
                    MessageBox.Show("Leadger Name Already Exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAliasName.textBox1.Focus();
                    return false;
                }
            }
            return true;
        }
        public void HeadingSett()
        {
            if (Generalfunction.Comeform == "MDISUPPLIER")
            {
                RadCr.Checked = true;
                this.Text = "Create Supplier";
            }

            if (Generalfunction.Comeform == "MDICUSTOMER")
            {
                RadDr.Checked = true;
                this.Text = "Create Customer";
            }

            if (Generalfunction.Comeform == "MDIAGENT")
            {
                RadCr.Checked = true;
                this.Text = "Create Agent";
            }

            FillCombo();
        }
        private void frmcreateledger_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            _Nextg.FormStylesett(this);
          
            _Nextg.ClearControles(this);
            if (Isinotherwindow == true)
            {
                GetPre();
            }
            else
            {
                if (EditMode == false)
                {
                    Clear(true);
                }
                else
                {
                    HeadingSett();
                    TxtOpeningBalance.Text = _Dbtask.SetintoDecimalpoint(0);
                }
            }

            CommonClass._Nextg.FormIcon(this);


        }

        private void frmcreateledger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

      

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear(true);
        }

        private void frmcreateledger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

        

       

        public void GetPre()
        {
            if (EditMode == true)
            {
                HeadingSett();
                FillingMode = true;
                FillCombo();
                Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where lid='" + Ledid + "'");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    TxtLedId.Text = Ledid.ToString();
                    CheckUseCard(false);
                    double tempdiscountperc = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["DiscPer"].ToString());
                    double tempcreditlimit = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["creditlimit"].ToString());
                    double tempcreditdays = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["creditdays"].ToString());
                    double tempcommision = _Dbtask.znullDouble(Ds.Tables[0].Rows[0]["commision"].ToString());
                    float tempcategoryid = Convert.ToInt64(Ds.Tables[0].Rows[0]["agroupid"].ToString());
                    float CardPlan = Convert.ToInt64(_Dbtask.znullDouble(Ds.Tables[0].Rows[0]["cplan"].ToString()));
                    TxtName.textBox1.Text = Ds.Tables[0].Rows[0]["lname"].ToString();
                    TxtMobile.textBox1.Text = Ds.Tables[0].Rows[0]["mobile"].ToString();
                    TxtEmail.textBox1.Text = Ds.Tables[0].Rows[0]["email"].ToString();
                    TxtDiscount.textBox1.Text = _Dbtask.SetintoDecimalpoint(tempdiscountperc);
                    TxtCreditLimit.textBox1.Text = _Dbtask.SetintoDecimalpoint(tempcreditlimit);
                    TxtCreditDays.textBox1.Text = _Dbtask.SetintoDecimalpointStock(tempcreditdays);
                    TxtCommision.textBox1.Text = _Dbtask.SetintoDecimalpoint(tempcommision);
                    Comarea.SelectedValue = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["area"]);
                    TxtAliasName.textBox1.Text = Ds.Tables[0].Rows[0]["laliasname"].ToString();
                    TxtAddress.textBox1.Text = Ds.Tables[0].Rows[0]["address"].ToString();
                    TxtPhone.textBox1.Text = Ds.Tables[0].Rows[0]["phone"].ToString();
                    TxtOther.textBox1.Text = Ds.Tables[0].Rows[0]["other"].ToString();
                     TxtTaxRegNum.Text = Ds.Tables[0].Rows[0]["taxregno"].ToString();
                    txtcst.textBox1.Text = Ds.Tables[0].Rows[0]["cst"].ToString();
                    ComAccountGroup.SelectedValue = tempcategoryid;
                    comcustomercardplan.SelectedValue = CardPlan;
                    txtcustomercode.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["customercode"]);

                    txtcityy.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["cityy"]);
                    txtcountryy.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["Lcountryname"]);
                   txtpostcode.textBox1.Text= _Dbtask.znllString(Ds.Tables[0].Rows[0]["postcode"]);
                    TXTdistrict.textBox1.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["LDistrict"]);



                    txtscheme.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["schemeID"]);
                    txtstreetname.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["StreetName"]);
                    txtadditionalstreet.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["AdditionalStreetName"]);
                    txtbuildingnum.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["BuildingNumber"]);
                    txtcountrysubenitity.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["CountrySubentity"]);
                    txtcitysubdivision.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["CitySubdivisionName"]);
                    txtidentificationcode.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["IdentificationCode"]);
                    txtregistrationame.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["RegistrationName"]);
                    txtcompanyid.Text = _Dbtask.znllString(Ds.Tables[0].Rows[0]["CompanyID"]);











                    FillingMode = false;
                }

                /*For Opening Balance*/
                Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode='" + TxtLedId.Text + "' and purticulars='Opening Balance' and refno=1001 and vtype='OB'");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    double tempDbamt = Convert.ToDouble(Ds.Tables[0].Rows[0]["dbamt"]);
                    double tempCramt = Convert.ToDouble(Ds.Tables[0].Rows[0]["cramt"]);
                    double Amt;
                    if (tempDbamt > tempCramt)
                    {
                        RadDr.Checked = true;
                        Amt = tempDbamt;
                    }
                    else
                    {
                        RadCr.Checked = true;
                        Amt = tempCramt;

                    }
                    TxtOpeningBalance.Text = _Dbtask.SetintoDecimalpoint(Amt);
                }
                /********************************/
            }
        }

      
       
        private void TxtCommision_Leave(object sender, EventArgs e)
        {
            //if (e.KeyValue == 13)
            //{
            //    Main();
            //}
        }

      

        private void txtcst_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void txtcst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

       
        private void TxtName_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                TxtAliasName.textBox1.Text = TxtName.textBox1.Text;
                TxtName.textBox1.Focus();
            }
        }

        private void TxtName_Leave_1(object sender, EventArgs e)
        {
            Gridcustomerlist.Visible = false;
       
            if (TxtName.textBox1.Text == "")
            {
                //  this.ErrBlank.SetError(this.TxtName, "Fill Here");
            }
        }

        
        private void txtcst_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

        private void txtcst_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Main();
            }
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {

            CommonClass._GenF.CHECKCHARACTER("Lname", "tblaccountledger", TxtName.textBox1);
            Gridcustomerlist.Visible = false;
        }

        private void chkcard_CheckedChanged(object sender, EventArgs e)
        {
            CheckUseCard(true);
        }
        public void CheckUseCard(bool IsNew)
        {
            if (IsNew == true)
            {
                if (chkcard.Checked == true)
                    _AccountLedger.UseCard = 1;
                else
                    _AccountLedger.UseCard = -1;
            }
            else
            {
                Isusecard =Convert.ToInt16(_Dbtask.znullDouble(CommonClass._Ledger.GetspecifField("usecard",Ledid.ToString())));
                if (Isusecard == 1)
                {
                    chkcard.Checked = true;
                }
                else
                {
                    chkcard.Checked = false;
                }
               
            }
        }

        private void TxtName_TextChanged(object Sender, EventArgs e)
        {
            try
            {
                if (FillingMode == false)
                {
                    if (Generalfunction.Comeform == "MDICUSTOMER")
                    {
                        CommonClass.temp = _AccountGroup.ShowCustomerAccount("");
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblaccountledger where lname like N'%" + TxtName.textBox1.Text + "%' and Agroupid in (" + CommonClass.temp + ")");
                    }
                    if (Generalfunction.Comeform == "MDISUPPLIER")
                    {
                        CommonClass.temp = _AccountGroup.ShowSupplierAccount("");
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblaccountledger where lname like N'%" + TxtName.textBox1.Text + "%' and Agroupid in (" + CommonClass.temp + ")");
                    }
                    if (Generalfunction.Comeform == "MDIAGENT")
                    {
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblaccountledger where lname like N'%" + TxtName.textBox1.Text + "%' and Agroupid=29");
                    }
                    Gridcustomerlist.Visible = true;
                    Gridcustomerlist.Rows.Clear();
                    if (Generalfunction.Comeform == "")
                    {
                        Ds1 = _Dbtask.ExecuteQuery("select * from tblaccountledger where lname like N'%" + TxtName.textBox1.Text + "%'");
                    }
                    for (int i = 0; i < Ds1.Tables[0].Rows.Count; i++)
                    {
                        Gridcustomerlist.Rows.Add(1);
                        Gridcustomerlist.Rows[i].Cells[0].Value = Ds1.Tables[0].Rows[i]["lname"];
                    }
                }
            }
            catch
            {
            }
        }

        private void TxtOpeningBalance_TextChanged(object sender, EventArgs e)
        {
            if (_Dbtask.znlldoubletoobject(TxtOpeningBalance.Text)>10000000)
            {
                MessageBox.Show("Varify DB/CR Amount..");
            }
        }

        private void TxtOpeningBalance_Leave(object sender, EventArgs e)
        {
            if (_Dbtask.znlldoubletoobject(TxtOpeningBalance.Text) > 10000000)
            {
                TxtOpeningBalance.Text = "";   
            }
        }

        private void TxtName_Load(object sender, EventArgs e)
        {

        }

        private void TxtAliasName_Load(object sender, EventArgs e)
        {

        }

        private void TxtAliasName_Leave(object sender, EventArgs e)
        {

            CommonClass._GenF.CHECKCHARACTER("LAliasName", "tblaccountledger", TxtAliasName.textBox1);
        }

        private void txtcustomercode_Load(object sender, EventArgs e)
        {
            //CommonClass._GenF.CHECKCHARACTER("customercode", "tblaccountledger", txtcustomercode.textBox1);

        }

        private void TxtPhone_Load(object sender, EventArgs e)
        {

        }

        private void TxtMobile_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Mobile", "tblaccountledger", TxtMobile.textBox1);

        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Phone", "tblaccountledger", TxtPhone.textBox1);

        }

        private void TxtDiscount_Leave(object sender, EventArgs e)
        {
           // CommonClass._GenF.CHECKCHARACTER("DiscPer", "tblaccountledger", TxtDiscount.textBox1);

        }

        private void TxtTaxRegNo_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("TaxregNo", "tblaccountledger", TxtTaxRegNo.textBox1);
            Generalfunction.lngnum = false;
        }

        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address", "tblaccountledger", TxtAddress.textBox1);

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("email", "tblaccountledger", TxtEmail.textBox1);

        }

        private void txtcityy_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("cityy", "tblaccountledger", txtcityy.textBox1);

        }

        private void TXTdistrict_Load(object sender, EventArgs e)
        {
          //  CommonClass._GenF.CHECKCHARACTER("LDistrict", "tblaccountledger", TXTdistrict.textBox1);

        }

        private void txtcountryy_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Lcountryname", "tblaccountledger", txtcountryy.textBox1);

        }

        private void txtpostcode_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("postcode", "tblaccountledger", txtpostcode.textBox1);

        }

        private void TxtCreditDays_Leave(object sender, EventArgs e)
        {
          //  CommonClass._GenF.CHECKCHARACTER("CreditDays", "tblaccountledger", TxtCreditDays.textBox1);

        }

        private void TxtCreditLimit_Load(object sender, EventArgs e)
        {

        }

        private void TxtCreditLimit_Leave(object sender, EventArgs e)
        {
           // CommonClass._GenF.CHECKCHARACTER("CreditLimit", "tblaccountledger", TxtCreditLimit.textBox1);

        }

        private void TxtOther_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Other", "tblaccountledger", TxtOther.textBox1);

        }

        private void TxtCommision_Leave_1(object sender, EventArgs e)
        {
            //if(keyva)
            //{
            //}
            //CommonClass._GenF.CHECKCHARACTER("Commision", "tblaccountledger", TxtCommision.textBox1);

        }

        private void txtcst_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("cst", "tblaccountledger", txtcst.textBox1);

        }

        private void TxtIntest_Leave(object sender, EventArgs e)
        {
            //CommonClass._GenF.CHECKCHARACTER("CreditDays", "tblaccountledger", TxtCreditDays.textBox1);

        }

        private void txtcustomercode_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("customercode", "tblaccountledger", txtcustomercode.textBox1);

        }

        private void TXTdistrict_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("LDistrict", "tblaccountledger", TXTdistrict.textBox1);

        }

        private void TxtTaxRegNo_TextChanged(object Sender, EventArgs e)
        {
            //Generalfunction.lngnum = true;
        }

        private void TxtCommision_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Main();
            }
        }

      
        
       
    }
}
