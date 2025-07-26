using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsTable
    {
        public long Id;
        public string Name;
        public int Status;
        public string Note = "";
        public long KOTId = 0;

        DBTask _DbTask = new DBTask();

        public void InsertTable()
        {
            object[,] ObjArg = new object[5, 2]
            {
                {"@Id",Id},
                {"@Name",Name},
                {"@Status",Status},
                {"@Note",Note},
                {"@KOTId",KOTId}
            };
            _DbTask.ExecuteNonQuery_SP("InsertTable", ObjArg);
            return;
        }

        public void UpdateTbl(string Vtype,int status,long KOTId, string where)
        {
            //if(Vtype=="KOT")
            //{
                _DbTask.ExecuteQuery("update TblTable set Status='" + status + "' " + where + "");
                _DbTask.ExecuteQuery("update TblTable set KOTId='" + KOTId + "' " + where + " ");
            //}
        }
    }
}
