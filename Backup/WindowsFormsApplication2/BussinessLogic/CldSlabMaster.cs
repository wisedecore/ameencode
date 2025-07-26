using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClSSlabMaster
    {
        public long Slid;
        public string Slname="";
        public string Discri="";
        public long Slno;
        public DateTime Efffrom;
        public double Perc;


        DBTask _Dbtask = new DBTask();
        public void InsertSlabMaster()
        {
            object[,] ObjArg = new object[5, 2]
            {
            {"@Slid",Slid},
            {"@Slname",Slname},
            {"@Discri",Discri},  
            //{"@Slno",Slno},
            {"@Efffrom",Efffrom},
            {"@Perc",Perc}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertSlabMaster", ObjArg);
            return;
        }

        public void UpdateSlabMaster()
        {
            object[,] ObjArg = new object[6, 2]
            {
            {"@Slid",Slid},
            {"@Slname",Slname},
            {"@Discri",Discri},  
            {"@Slno",Slno},
            {"@Efffrom",Efffrom},
            {"@Perc",Perc}
        };
            _Dbtask.ExecuteNonQuery_SP("UpdateMultirates", ObjArg);
            return;
        }

        public void IdSlabMaster()
        {
            Slid = Convert.ToInt64(Generalfunction.getnextid("Slid", "TblSlabmaster"));
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Slid", "Slname", "TblSlabmaster", "SELECT * FROM TblSlabmaster ");
        }


    }
}
