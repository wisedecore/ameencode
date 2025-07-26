using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsMultiRates
    {
        public long RateIdLng;
        public string RateNameStr = "";
        public string DescriptionStr = "";
        public int RateInInt;
        DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();

        public void InsertMultiRate()
        {
            object[,] objArg = new object[4, 2]
        {
            {"@RateId",RateIdLng},
            {"@Ratename",RateNameStr},  
            {"@Description",DescriptionStr},
            {"@Ratein",RateInInt},
        };
            _Dbtask.ExecuteNonQuery_SP("InsertMultirates", objArg);
            return;
        }
        public void IdMultiRate()
        {
            RateIdLng =Convert.ToInt64(Generalfunction.getnextid("RateId", "TblMultirates"));
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "RateId", "Ratename", "TblMultirates", "SELECT * FROM TblMultirates ");
        }

        public DataSet ShowMultiRates()
        {
            Ds = _Dbtask.ExecuteQuery("Select * from TblMultirates");
            return Ds;
        }

    }
}
