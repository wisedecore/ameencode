using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2

{
    class ClsDepot
    {
        public long Dcode;
        public string Dname = "";
        public int VehicleNo;
        public string Address = "";
        public string City = "";
        public string Pin = "";
        public string PhoneNo = "";
        public string Mobile = "";
        public string Cpersone = "";
        public string RegNo = "";
        public string Lisenseno = "";
        public string Description = "";
        public string SpecificField = "";
        DBTask _Dbtask = new DBTask();

        public void InsertdepotPara(long DcodeF, string DnameF, int VehicleNoF,
           string AddressF, string CityF, string PinF, string PhoneNoF, string MobileF, 
            string CpersoneF, string RegNoF, string LisensenoF, string DescriptionF)
        {
            {
                Dcode = DcodeF;
                Dname = DnameF;
                VehicleNo = VehicleNoF;
                Address = AddressF;
                City = CityF;
                Pin = PinF;
                PhoneNo = PhoneNoF;
                Mobile = MobileF;
                Cpersone = CpersoneF;
                RegNo = RegNoF;
                Lisenseno = LisensenoF;
                Description = DescriptionF;
                InsertDepot();
            }
        }




        public void InsertDepot()
        {

            object[,] objArg = new object[12, 2]
        {
            {"@Dcode",Dcode},
            {"@Dname",Dname},  
            {"@VehicleNo",VehicleNo},
            {"@Address",Address},
            {"@City",City},
             {"@Pin",Pin},
            {"@Phoneno",PhoneNo},  
            {"@Mobile",Mobile},
            {"@Cperson",Cpersone},
            {"@RegNo",RegNo},
             {"@Lisenseno",Lisenseno},
            {"@Description",Description}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertDepot", objArg);
            return;
        }

       





        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Dcode", "Dname", "TblDepot", "SELECT Dname,Dcode FROM TblDepot");
            //Cmb.SelectedIndex = 0;
        }
        public string GetspecifField(string Field, string depo)
        {
            SpecificField = _Dbtask.ExecuteScalar("select " + Field + " from TblDepot where Dcode='" + depo + "'");
            return SpecificField;
        }
        public void IdDepot()
        {
            Dcode = Convert.ToInt64(Generalfunction.getnextid("Dcode", "TblDepot"));
        }

        public string NameDepot(string Depid)
        {
            string DepName = _Dbtask.ExecuteScalar("Select dname from TblDepot where Dcode=" + Depid + "");
            return DepName;
        }

    }
}
