using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clssizedetails
    {
        DBTask _Dbtask = new DBTask();
        public string ItemSizename;
        public string Sname;

        public void InsertSize()
        {
            object[,] ObjArg = new object[2, 2]
            {
            {"@itemsizename",ItemSizename},
            {"@sname",Sname}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertsizesdetail", ObjArg);
            return;
        }
    }
}
