using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsfields
    {
        public long ID;
        public string Name;

        DBTask _DBTask = new DBTask();


        public void Insertfields()
        {
            object[,] objArg = new object[2, 2]
            {
                {"@Id",ID},
                {"@Name",Name}
            };
            _DBTask.ExecuteNonQuery_SP("Insertfields", objArg);
            return;
        }
    }
}
