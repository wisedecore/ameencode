using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ClsBaseunit
    {
        public long Id;
        public string Name; DBTask _DBTask = new DBTask();
        public void InserBasetUnit()
        {
            object[,] ObjArg = new object[2, 2]
            {
                {"@Id",Id},
                {"@Name",Name}
               
            };
            _DBTask.ExecuteNonQuery_SP("InsertBaseunit", ObjArg);
            return;
        }
        public DataSet LoadUnit(string where)
        {
            return _DBTask.ExecuteQuery("select * from tblbaseunit " + where + "");
        }
        public void FillUnit(ComboBox Cmb)
        {
            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Id", "Name", "tblbaseunit", "select * from tblbaseunit");
            }
            catch
            {
            }
        }

    }
}
