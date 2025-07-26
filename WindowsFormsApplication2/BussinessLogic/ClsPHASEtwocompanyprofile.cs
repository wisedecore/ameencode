using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using java.util;
using org.apache.xerces.impl.dv.xs;
using Org.BouncyCastle.Asn1.Pkcs;

namespace WindowsFormsApplication2
{
    internal class ClsPHASEtwocompanyprofile
    {


        public string  Workingtype = "";
        public string    OTP = "";
        public string  CommonName = "";
        public string  SerialNumber = "";
        public string  firmname = "";
        public string  Branchname = "";
        public string  countrytext = "";
        public string  vatnumber = "";
        public string  location = "";
        public string  Industry = "";
        public string  CSR = "";
        public string  PrtKEY = "";
        public string  PblKEY = "";
        public string  ScrtKEY = "";

        public static string PHcrn;
        public static string PHschemeID;
        public static string PHStreetName;
        public static string PHBuildingNumber;
        public static string PHCityName;
        public static string PHPostalZone;
        public static string PHCitySubdivisionName;
        public static string PHIdentificationCode;
        public static string PHRegistrationName;
        public static string PHCompanyID;


        public string CRN = "";
        public string Street = "";
        public string BuildingNo = "";
        public string City = "";
        public string Postelcode = "";
        public string Subdivision = "";
        DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();
        public void InsertPHASEtwocompanyprofile()
        {
            object[,] ObjArg = new object[20, 2]
            {
            {"@Workingtype",Workingtype },
            {"@OTP",OTP },
            {"@CommonName",CommonName },
            {"@SerialNumber", SerialNumber},
            {"@firmname",firmname },
            {"@Branchname",Branchname },
            {"@countrytext",countrytext },
            {"@vatnumber", vatnumber},
            {"@location",location },
            {"@Industry",Industry },
            {"@CSR", CSR},
            {"@PrtKEY",PrtKEY },
            {"@PblKEY", PblKEY},
            {"@ScrtKEY",ScrtKEY },
             {"@CRN",CRN },
            {"@CStreet",Street },
            {"@BuildingNo", BuildingNo},
            {"@City",City },
            {"@PostelCode", Postelcode},
            {"@SubDivision",Subdivision}

        };
            _Dbtask.ExecuteNonQuery_SP("InsertPHASEtwocompanyprofile", ObjArg);
            return;
        }

        public string GetspecifField(string Field)
        {
            //Generalfunction.TempCompanyname = CompanyName;
            string Txt;
            return Txt = _Dbtask.ExecuteScalar("select " + Field + " from TblPHASEtwocompanyprofile");

            
        }












    }
}
