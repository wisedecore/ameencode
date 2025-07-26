using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsCustomerLedger
    {
        public long Lid;
        public string RegNo;
        public string Party;
        public string MakersName;
        public string MakersModel;
        public string EngNo;
        public string ChasNo;
        public string FuelType;
        public string Colour;
        public DateTime YrofMnfr;
        public string TypeofBody;
        public string ClassofVehicle;
        public string CC;
        public int SeatingCapacity;
        public double GrossWeight;
        public int NoofCylinder;

        DBTask _DbTask=new DBTask();

        public void InsertCustomerLedger()
        {
            object[,] ObjArg = new object[15, 2]
            {
                {"@Lid",Lid},
                {"@RegNo",RegNo},
                {"@MakersName",MakersName},
                {"@MakersModel",MakersModel},
                {"@EngNo",EngNo},
                {"@ChasNO",ChasNo},
                {"@FuelType",FuelType},
                {"@Colour",Colour},
                {"@YrOfMnfr",YrofMnfr},
                {"@TypeOfBody",TypeofBody},
                {"@ClsOfVehicle",ClassofVehicle},
                {"@CC",CC},
                {"@SeatingCapacity",SeatingCapacity},
                {"@GrossWeight",GrossWeight},
                {"@NoofCylinder",NoofCylinder}
            
            };

            _DbTask.ExecuteNonQuery_SP("InsertCustomerLedger", ObjArg);
            return;
        }
    }
}
