using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClsSAgroup
    {
        public long GidLng;
        public string GnameStr = "";
        public int GunderInt;
        DBTask _Dbtask = new DBTask();
        public void InsertStockAdjustmentGroup()
        {
            object[,] objArg = new object[3, 2]
            {
      
              {"@Gid",GidLng},
              {"@Gname",GnameStr},  
              {"@Gunder",GunderInt},    
            };
            _Dbtask.ExecuteNonQuery_SP("InsertSagroup", objArg);
            return;
        }

        public void IdStockAdjustmentGroup()
        {
            GidLng = Convert.ToInt64(Generalfunction.getnextid("Gid", "TblSagroup"));
        }

        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Gid", "Gname", "TblSagroup", "SELECT * FROM TblSagroup ");
        }
    }
}
