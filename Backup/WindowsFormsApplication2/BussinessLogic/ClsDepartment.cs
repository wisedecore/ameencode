using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClsDepartment
    {
        public long DepId;
        public string DepName = "";
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen = new Generalfunction();

        public void InsertDepartment()
        {
            object[,] objArg = new object[2, 2]
            {
      
              {"@DepId",DepId},
              {"@Depname",DepName}  
            };
            _Dbtask.ExecuteNonQuery_SP("InsertDepartment", objArg);
            return;
        }

        public void SelectDepartment()
        {
            object[,] objArg = new object[2, 2]
            {
      
              {"@DepId",DepId},
              {"@Depname",DepName}  
            };
            _Dbtask.ExecuteNonQuery_SP("SelectDepartment", objArg);
            return;
        }
        public string Getspecificfield(string Id,string Field)
        {
            return _Dbtask.ExecuteScalar("select "+Field+" from tbldepartment where depid='"+Id+"'");
        }
        public void FillCombo(ComboBox Cmb)
        {
             Generalfunction.fillDatainCombowithQuery(Cmb, "Depid", "Depname", "Tbldepartment", "select * from tbldepartment");
        }

        public void IdDepartment()
        {
            DepId = Convert.ToInt64(Generalfunction.getnextid("DepId", "Tbldepartment"));
        }


    }

}
