using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsmenus
    {
       public long Id;
       public string MenuName;
        public void InsertMenus()
        {
            object[,] ObjArg = new object[2, 2]
            {
                {"@id" ,Id},
                {"@menuname", MenuName}
            };
           CommonClass._Dbtask.ExecuteNonQuery_SP("InsertMenus", ObjArg);
            return;
        }

    }
}
