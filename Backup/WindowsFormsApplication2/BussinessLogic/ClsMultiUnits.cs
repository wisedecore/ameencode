using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace WindowsFormsApplication2
{
    class ClsMultiUnits
    {
        public long UnitIdLng;
        public string BaseStr = "";
        public string UnameStr = "";
        public double CF;
        DataSet Ds = new DataSet();
        string Temp;

        DBTask _Dbtask = new DBTask();
        public void InsertMultiUnit()
        {
            object[,] objArg = new object[4, 2]
        {
            {"@UnitId",UnitIdLng},
            {"@Base",BaseStr},  
            {"@UName",UnameStr},
            {"@CF",CF},
        };
            _Dbtask.ExecuteNonQuery_SP("InsertMultiunits", objArg);
            return;
        }

        public void IdMultiUnits()
        {
            UnitIdLng = Convert.ToInt64(Generalfunction.getnextid("Unitid","TblMultiunits"));
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "UnitId", "UName", "TblMultiUnits", "SELECT * FROM TblMultiUnits ");
        }
        public void FillComboMainUnit(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "UnitId", "UName", "TblMultiUnits", "SELECT * FROM TblMultiUnits where CF=1 ");
        }
        public string GetOne(string GetField, String Where)
        {
            Temp = _Dbtask.ExecuteScalar("select " + GetField + " from TblMultiUnits " + Where + "");
            return Temp;
        
        }
        public DataSet ShowMultiUnit(string Base)
        {
            Ds = _Dbtask.ExecuteQuery("Select * from TblMultiUnits where Base='" + Base + "'");
            return Ds;
        }
    }

}
