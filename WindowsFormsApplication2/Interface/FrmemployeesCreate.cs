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
    public partial class Frmemployees : Form
    {
        public Frmemployees()
        {
            InitializeComponent();
        }
        ClsEmployeeMaster _EmployeeMaster = new ClsEmployeeMaster();
        ClsGeneralLedger _Generalledger = new ClsGeneralLedger();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsDepartment _Clsdepartment = new ClsDepartment();
        DBTask _Dbtask = new DBTask();
        NextGFuntion _Nextg = new NextGFuntion();
        DataSet Ds = new DataSet();
        public int Empid;
        
        public string EStatus;
        public bool Isinotherwindow = false;
        public bool EditMode = false;
        public int selectedRow;

        /*For Common Declaration*/
        //////////////////
       
        public string EmpName;
        public string EmpCode;
      
        public string Department;
        public string Mobile;
        public string Address;
        public string Email;
        public DateTime DateOfjoining;
        public double Salary;
        public string PhoneNo;
        public string PassportNo;
        public string VisaNo;
        public double Commision;
        public string Sex;
        public string Mpayment;
        /************************************************************/

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

        private void Frmemployees_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
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
        private void CmdSave_Click(object sender, EventArgs e)
        {
            Main();
        }

        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    if (EditMode == true)
                    {
                        DeleteEmployeemaster();
                    }
                    NextgInitialize();
                    Insert();
                   // Clear();
                   tempclear();
                
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

        private bool ValidationFu()
        {
            if (TxtName.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Employee Name","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtName.textBox1.Focus();
                return false;
            }
            if (Txtdepartment.textBox1.Tag == null && Txtdepartment.textBox1.Text=="")
            {
                MessageBox.Show("Please select Department","Qplex",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Txtdepartment.textBox1.Focus();
                return false;
            }
            return true;
        }
        
        public void Fillcombo()
        {
            compaymode.SelectedIndex = 0;
        }

        public void Clear()
        {
            _Nextg.ClearControles(this);
            GetVno();
           // DepStore();
           // SetDecimel();
            TxtEmpCode.textBox1.Focus();
            EditMode = false;
            Isinotherwindow = false;
        }

        public void tempclear()
        {
            
            TxtEmpCode.textBox1.Text = "";
            TxtName.textBox1.Text = "";
            Txtdepartment.textBox1.Text = "";
            TxtMobile.textBox1.Text = "";
            TxtAddress.textBox1.Text = "";
            TxtEmail.textBox1.Text = "";
            TxtSalary.textBox1.Text = "0.00";
            TxtCommision.textBox1.Text = "0.00";
            TxtPhone.textBox1.Text = "";
            TxtPassportNo.textBox1.Text = "";
            TxtVisaNo.textBox1.Text = "";
            _Nextg.ClearControles(this);
            GetVno();
            // DepStore();
            // SetDecimel();
            TxtEmpCode.textBox1.Focus();
            EditMode = false;
            Isinotherwindow = false;
        }

       
        //public void DepStore()
        //{
        //    _Clsdepartment.FillCombo(ComDepartment);
        //}
        public void DeleteEmployeemaster()
        {
        string Empid=TxtEmployeeId.Text;
        _Dbtask.ExecuteNonQuery("delete from tblemployeemaster where empid='" + Empid + "'");
        _Dbtask.ExecuteNonQuery("delete from tblaccountledger where lid ='" + Empid + "'");
        }
        public void NextgInitialize()
        {
            
            /*Department*/

            if (Txtdepartment.textBox1.Tag == null&&Txtdepartment.textBox1.Text!="")
            {
              _Clsdepartment.IdDepartment();
              _Clsdepartment.DepName = Txtdepartment.textBox1.Text;
              _Clsdepartment.InsertDepartment();
              Txtdepartment.textBox1.Tag = _Clsdepartment.DepId;
            }
                /*For Employee Master */
            _EmployeeMaster.EmpidLng=Convert.ToInt64(TxtEmployeeId.Text);
            _EmployeeMaster.EmpNameStr=TxtName.textBox1.Text;
            _EmployeeMaster.EmpCode = TxtEmpCode.textBox1.Text;
            _EmployeeMaster.SexInt=Convert.ToInt16(Sex);
            _EmployeeMaster.DepartmentStr = Txtdepartment.textBox1.Tag.ToString();
            _EmployeeMaster.MobileStr = TxtMobile.textBox1.Text;
            _EmployeeMaster.AddressStr = TxtAddress.textBox1.Text;
            _EmployeeMaster.EmailStr = TxtEmail.textBox1.Text;
            _EmployeeMaster.DjoiningDt = DtDateofJoining.Value;
            _EmployeeMaster.SalryDb =_Dbtask.znullDouble(TxtSalary.textBox1.Text);
            _EmployeeMaster.PhoneStr = TxtPhone.textBox1.Text;
            _EmployeeMaster.PassportNoStr = TxtPassportNo.textBox1.Text;
            _EmployeeMaster.VisaNoStr = TxtVisaNo.textBox1.Text;
            _EmployeeMaster.EmpCode = TxtEmpCode.textBox1.Text;
            _EmployeeMaster.MpaymentStr = compaymode.Text;
            _EmployeeMaster.Commision = _Dbtask.znullDouble(TxtCommision.textBox1.Text);

            /*For Account Ledger*/
            _AccountLedger.LidLng = Convert.ToInt64(TxtEmployeeId.Text);
            _AccountLedger.GidLng = 22;
            _AccountLedger.LNameStr = TxtName.textBox1.Text;
            _AccountLedger.MobileStr = TxtMobile.textBox1.Text;
            _AccountLedger.AddressStr = TxtAddress.textBox1.Text;
            _AccountLedger.EmailStr = TxtEmail.textBox1.Text;
            _AccountLedger.PhoneStr = TxtPhone.textBox1.Text;   
       

        }
        public void Insert()
        {
            _EmployeeMaster.InsertEmployeeMaster();
            _AccountLedger.InsertLedger();
        }

        private void RadMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadMale.Checked == true)
            {
                Sex = "1";
            }
        }

        private void RadFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadFemale.Checked == true)
            {
                Sex = "-1";
            }
        }

        private void ChkActiveEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkActiveEmployee.Checked == true)
            {
                EStatus = "1";
            }
            else
            {
                EStatus = "0";
            }
        }
        public void GetVno()
        {
            _AccountLedger.IdAccountLedger();
            TxtEmployeeId.Text =Convert.ToString(_AccountLedger.LidLng);
        }

        private void Frmemployees_Load(object sender, EventArgs e)
        {
            
            _Nextg.FormStylesett(this);
           
            if (EditMode == false)
            {
                Clear();
            }
            else
            {
                GetRetrive(Empid.ToString());
            }
            ChangeLanguage();
            CommonClass._Nextg.FormIcon(this);

        }
        public void SexSelect(string Value)
        {
            if (Value == "-1")
                RadFemale.Checked = true;
            else
                RadMale.Checked = true;
        }

        public void GetRetrive(string Empid)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblEmployeemaster where empid='" + Empid + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Empid = Ds.Tables[0].Rows[0]["empid"].ToString();
                EmpName = Ds.Tables[0].Rows[0]["empname"].ToString();
                EmpCode = Ds.Tables[0].Rows[0]["empcode"].ToString();
                Sex = Ds.Tables[0].Rows[0]["sex"].ToString();
                Department = Ds.Tables[0].Rows[0]["department"].ToString();
                Mobile = Ds.Tables[0].Rows[0]["mobile"].ToString();
                Address = Ds.Tables[0].Rows[0]["address"].ToString();
                Email = Ds.Tables[0].Rows[0]["email"].ToString();
                DateOfjoining = Convert.ToDateTime(Ds.Tables[0].Rows[0]["djoining"].ToString());
                Salary = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["salary"]);
                PhoneNo = Ds.Tables[0].Rows[0]["phone"].ToString();
                PassportNo = Ds.Tables[0].Rows[0]["passportno"].ToString();
                VisaNo = Ds.Tables[0].Rows[0]["visano"].ToString();
                EStatus = Ds.Tables[0].Rows[0]["estatus"].ToString();
                Commision = _Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[0]["commi"]);
                Mpayment = Ds.Tables[0].Rows[0]["mpayment"].ToString();

                TxtEmployeeId.Text = Empid;
                TxtName.textBox1.Text = EmpName;
                TxtEmpCode.textBox1.Text = EmpCode;
                SexSelect(Sex);
                Txtdepartment.textBox1.Tag = Department;
                Txtdepartment.textBox1.Text = _Clsdepartment.Getspecificfield(Department, "depname");
                TxtMobile.textBox1.Text = Mobile;
                TxtAddress.textBox1.Text = Address;
                TxtEmail.Text = Email;
                DtDateofJoining.Value = DateOfjoining;
                TxtSalary.textBox1.Text = _Dbtask.SetintoDecimalpoint(Salary);
                TxtPhone.textBox1.Text = PhoneNo;
                TxtPassportNo.textBox1.Text = PassportNo;
                TxtVisaNo.textBox1.Text = VisaNo;
                EmployeeStatuschecked(EStatus);
                TxtCommision.textBox1.Text = _Dbtask.SetintoDecimalpoint(Commision);
                compaymode.Text = Mpayment;
                Griddepartment.Visible = false;
                Isinotherwindow = false;
            }
        }
        public void EmployeeStatuschecked(string Status)
        {
            if (Status == "1")
                ChkActiveEmployee.Checked = true;
            else
                ChkActiveEmployee.Checked = false;
        }
        private void TxtVisaNo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmemployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                Main();
            }
        }

       

        

       


     

       
        public void Enetersett(TextBox txt)
        {
            txt.Select();
            txt.BackColor = System.Drawing.Color.Blue;
            txt.ForeColor = System.Drawing.Color.White;
        }
        public void Leavesett(TextBox txt)
        {

            txt.BackColor = System.Drawing.Color.White;
            txt.ForeColor = System.Drawing.Color.Black;
        }
        public void GetRetrive()
        {
        
        }

 

        private void Txtdepartment_Enter(object sender, EventArgs e)
        {
            Enetersett(Txtdepartment.textBox1);
        }

        private void Txtdepartment_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Department", "TblEmployeeMaster", Txtdepartment.textBox1);


            Leavesett(Txtdepartment.textBox1);
            Griddepartment.Visible = false;
        }

        private void Txtdepartment_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (Griddepartment.SelectedRows.Count > 0)
                {
                    selectedRow = Griddepartment.SelectedRows[0].Index;
                }
                if (e.KeyValue == 40 && Griddepartment.Rows[selectedRow].Cells[0].Value != null)
                {

                    if (Griddepartment.Rows[selectedRow + 1].Cells[0].Value != null)
                    {
                        Griddepartment.Rows[selectedRow + 1].Selected = true;
                        Griddepartment.Rows[selectedRow].Selected = false;
                        Griddepartment.CurrentCell = Griddepartment.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 38 && selectedRow != 0)
                {
                    Griddepartment.Rows[selectedRow - 1].Selected = true;
                    Griddepartment.Rows[selectedRow].Selected = false;
                    Griddepartment.CurrentCell = Griddepartment.SelectedRows[0].Cells[0];
                }

                if (e.KeyValue == 13)
                {
                    if (Griddepartment.SelectedRows.Count > 0 && Griddepartment.Visible == true)
                    {
                        Txtdepartment.textBox1.Text = Griddepartment.SelectedRows[0].Cells[0].Value.ToString();
                        Txtdepartment.textBox1.Tag = Griddepartment.SelectedRows[0].Cells[0].Tag;
                    }
                    if (Txtdepartment.textBox1.Text == "")
                    {
                        Txtdepartment.textBox1.Text = "None";
                        Txtdepartment.textBox1.Tag = 0;
                    }
                    Griddepartment.Visible = false;
                }

                if (e.KeyValue == 27)
                {
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void Txtdepartment_TextChanged(object Sender, EventArgs e)
        {
            Griddepartment.Rows.Clear();
            Ds = _Dbtask.ExecuteQuery("select * from tbldepartment where Depname like '%" + Txtdepartment.textBox1.Text + "%'");

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Griddepartment.Rows.Add(1);
                Griddepartment.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["Depid"].ToString();
                Griddepartment.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["Depname"].ToString();
            }
            Griddepartment.Visible = true;
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtName.textBox1);

        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Empname", "TblEmployeeMaster", TxtName.textBox1);

            Leavesett(TxtName.textBox1);

        }

        private void TxtMobile_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtMobile.textBox1);
        }

        private void TxtMobile_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("mobile", "TblEmployeeMaster", TxtMobile.textBox1);

            Leavesett(TxtMobile.textBox1);

        }

        private void TxtAddress_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtAddress.textBox1);

        }

        private void TxtAddress_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Address", "TblEmployeeMaster",TxtAddress.textBox1);

            Leavesett(TxtAddress.textBox1);
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtEmail.textBox1);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {

            CommonClass._GenF.CHECKCHARACTER("Email", "TblEmployeeMaster", TxtEmail.textBox1);

            Leavesett(TxtEmail.textBox1);
        }

       
    


        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Phone", "TblEmployeeMaster", TxtPhone.textBox1);

            Leavesett(TxtPhone.textBox1);
        }

        private void TxtPhone_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtPhone.textBox1);
        }

        private void TxtPassportNo_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtPassportNo.textBox1);
        }

        private void TxtPassportNo_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("PassportNo", "TblEmployeeMaster", TxtPassportNo.textBox1);

            Leavesett(TxtPassportNo.textBox1);
        }

        private void TxtVisaNo_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtVisaNo.textBox1);
        }

        private void TxtVisaNo_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("VisaNo", "TblEmployeeMaster", TxtVisaNo.textBox1);

            Leavesett(TxtVisaNo.textBox1);
        }

        private void TxtEmpCode_Enter(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                GetRetrive();
            }
            else
            {
                Enetersett(TxtEmpCode.textBox1);
            }
        }

        private void TxtEmpCode_Leave(object sender, EventArgs e)
        {
            CommonClass._GenF.CHECKCHARACTER("Empcode", "TblEmployeeMaster",TxtEmpCode.textBox1);

            Leavesett(TxtEmpCode.textBox1);
        }

        private void TxtSalary_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtSalary.textBox1);
        }

        private void TxtSalary_Leave(object sender, EventArgs e)
        {

            Leavesett(TxtSalary.textBox1);
        }

        private void TxtCommision_Enter(object sender, EventArgs e)
        {
            Enetersett(TxtCommision.textBox1);
        }

        private void TxtCommision_Leave(object sender, EventArgs e)
        {
            Leavesett(TxtCommision.textBox1);
        }

        private void TxtEmpCode_Load(object sender, EventArgs e)
        {

        }

      

        

       

      
       


    }
}
