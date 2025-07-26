using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsCompanyMaster
    {
        public string CompanyNameinHomeStr = "";
        public string CompanyNameStr="";
        public int TaxInt;
        public string Address1Str="";
        public string Address2Str="";
        public string CityStr="";
        public string StateStr="";
        public string POstalcodeStr="";
        public string PhoneStr="";
        public string MobileStr="";
        public string FaxStr = "";
        public string EmailStr = "";
        public string WebsiteStr = "";
        public string AccountNoStr = "";
        public string TaxNo1Str = "";
        public string TaxNo2Str = "";
        public string VATNoStr = "";
        public string CountryStr = "";
        public string Cusid = "";
        public string CusArea = "";
        public string SellersName = "";
        public string TRN = "";
        public string District="";
        public string countryname = "";
      public string validityduration = "";
      public string nickname = "";
        public int NoOfDecimalInt;
        public DateTime FYearFromDt;
        public DateTime FYearToDt;
        public int Status;
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen = new Generalfunction();
        public void InsertCompany()
        { 
                object[,] objArg = new object[30, 2]
            {
              {"@cname",CompanyNameStr},
              {"@tax",TaxInt},  
             {"@Address1",Address1Str},
              {"@Address2",Address2Str},
              {"@city",CityStr},
              {"@state",StateStr},
              {"@pcode",POstalcodeStr},
              {"@telephone",PhoneStr},
              {"@mobile",MobileStr},
              {"@Fax",FaxStr},
              {"@Email",EmailStr},
              {"@website",WebsiteStr},
              {"@accountno",AccountNoStr},
              {"@taxno1",TaxNo1Str},
              {"@taxno2",TaxNo2Str},
              {"@VATno",VATNoStr},
              {"@country",CountryStr},
              {"@NoOfDecimal",NoOfDecimalInt},
              {"@FYearFrom",FYearFromDt},
              {"@FYearTo",FYearToDt},
              {"@CStatus",Status},
              {"@Nameinhome",CompanyNameinHomeStr},
               {"@CusId",Cusid},
               {"@CusArea",CusArea},
               {"@Sellersname",SellersName},
               {"@TRN",TRN},
               {"@District",District},
               {"@countryname", countryname},
               {"@validityduration", validityduration},
               {"@nickname",nickname}


            };
                _Dbtask.ExecuteNonQuery_SP("InsertCompanymaster", objArg);
                return ;  
        }
        public void UpdateCompany()
        {

            object[,] objArg = new object[21, 2]
            {
              {"@cname",CompanyNameStr},
              {"@tax",TaxInt},  
             {"@Address1",Address1Str},
              {"@Address2",Address2Str},
              {"@city",CityStr},
              {"@state",StateStr},
              {"@pcode",POstalcodeStr},
              {"@telephone",PhoneStr},
              {"@mobile",MobileStr},
              {"@Fax",FaxStr},
              {"@Email",EmailStr},
              {"@website",WebsiteStr},
              {"@accountno",AccountNoStr},
              {"@taxno1",TaxInt},
              {"@taxno2",TaxNo2Str},
              {"@VATno",VATNoStr},
              {"@country",CountryStr},
              {"@NoOfDecimal",NoOfDecimalInt},
              {"@FYearFrom",FYearFromDt},
              {"@FYearTo",FYearToDt},
              {"@CStatus",Status}
              

            };
            _Dbtask.ExecuteNonQuery_SP("UpdateCompany", objArg);
            return; 
        }
        public  string CompanyName(string CompanyName)

        {
            Generalfunction.TempCompanyname = CompanyName;
            CompanyNameStr= _Dbtask.ExecuteScalar("select Cname from TblCompanyMaster");

           return CompanyNameStr;
        }
        public string GetspecifField(string Field)
        {
            //Generalfunction.TempCompanyname = CompanyName;
            CompanyNameStr = _Dbtask.ExecuteScalar("select " + Field + " from TblCompanyMaster");

            return CompanyNameStr;
        }
    }
}
