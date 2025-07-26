using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApplication2
{
    class ClsEmployeeMaster
    {
        public long EmpidLng;
        public string EmpNameStr = "";
        public string EmpCode = "";
        public int SexInt;
        public string DepartmentStr = "";
        public string MobileStr = "";
        public string AddressStr = "";
        public string EmailStr = "";
        public DateTime DjoiningDt = DateTime.Now;
        public double SalryDb;
        public string PhoneStr = "";
        public string PassportNoStr = "";
        public string VisaNoStr = "";
        public string MpaymentStr = "";
        public int EStatus=1;
        public double Commision;
        DBTask _Dbtask = new DBTask();

        DataSet Ds;
        ClsGeneralLedger _GeneralLedger = new ClsGeneralLedger();
        public void InsertEmployeeMaster()
        {
            object[,] objArg = new object[16, 2]
        {
                {"@EmpId",EmpidLng},
                {"@Empcode",EmpCode},
                {"@Empname",EmpNameStr},  
                {"@Sex",SexInt},
                {"@Department",DepartmentStr},
                {"@mobile",MobileStr},  
                {"@Address",AddressStr},
                {"@Email",EmailStr},
                {"@DJoining",DjoiningDt},  
                {"@Salary",SalryDb},
                {"@Phone",PhoneStr},
                {"@PassportNo",PassportNoStr},  
                {"@VisaNo",VisaNoStr},
                {"@EStatus",EStatus},
                {"@Commi",Commision},
                {"@mpayment",MpaymentStr}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertEmployeeMaster", objArg);
            return;
        }
        public void UpdateEmployeeMaster()
        {
            object[,] objArg = new object[14, 2]
        {
                {"@EmpId",EmpidLng},
                {"@Empname",EmpNameStr},  
                {"@Sex",SexInt},
                {"@Department",DepartmentStr},
                {"@mobile",MobileStr},  
                {"@Address",AddressStr},
                {"@Email",EmailStr},
                {"@DJoining",DjoiningDt},  
                {"@Salary",SalryDb},
                {"@Phone",PhoneStr},
                {"@PassportNo",PassportNoStr},  
                {"@VisaNo",VisaNoStr},
                {"@EStatus",EStatus},
                {"@EmpCode",EmpCode}


        };
            _Dbtask.ExecuteNonQuery_SP("UpdateEmployeeMaster", objArg);
            return;
        }

        public string GetspecifField(string Field, string Lid)
        {
            return _Dbtask.ExecuteScalar("select " + Field + " from TblEmployeeMaster where empid='" + Lid + "'");
        }

        public void IdEmployee()
        {
            EmpidLng = Convert.ToInt64(Generalfunction.getnextid("EmpidLng", "TblEmployeeMaster"));
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Empid", "Empname", "TblEmployeeMaster", "SELECT       'None'  AS Empname,0 as empid UNION ALL SELECT empname,Empid FROM TblEmployeeMaster");
            //Cmb.Items.Add("None");
            if (Cmb.Items.Count > 0)
            {
                Cmb.SelectedIndex = 0;
            }
               //Cmb.SelectedValue = 0;
        }

        public DataSet ShowEmployeeInGrid(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblemployeemaster " + Where + "");
            return Ds;
        }

        public void NextgInitializeInsertDr(string StaffCode,string CreditedCode,string Purticulars,double StaffAmt,double CrAmt)
        {
            _GeneralLedger.LedCodeStr = StaffCode;
            _GeneralLedger.PurticularsStr =Purticulars ;
            _GeneralLedger.DbAmtDb = StaffAmt;
            _GeneralLedger.CrAmt = 0;
            _GeneralLedger.InsertGeneralLedger();

            _GeneralLedger.LedCodeStr = CreditedCode;
            _GeneralLedger.PurticularsStr =Purticulars;
            _GeneralLedger.DbAmtDb =0;
            _GeneralLedger.CrAmt = CrAmt;
            _GeneralLedger.InsertGeneralLedger();
        }
        public void NextgInitializeInsertCr(string StaffCode, string DebitedCode, string Purticulars, double StaffAmt, double DrAmt)
        {
            _GeneralLedger.LedCodeStr = DebitedCode;
            _GeneralLedger.PurticularsStr = Purticulars;
            _GeneralLedger.DbAmtDb = DrAmt;
            _GeneralLedger.CrAmt = 0;
            _GeneralLedger.InsertGeneralLedger();

            _GeneralLedger.LedCodeStr = StaffCode;
            _GeneralLedger.PurticularsStr = Purticulars;
            _GeneralLedger.DbAmtDb = 0;
            _GeneralLedger.CrAmt = StaffAmt;
            _GeneralLedger.InsertGeneralLedger();
        }
    }


}
