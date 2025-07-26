using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsVoucherType
    {
        public string Vname;
        public string UnderVuchr;
        public int ItemCategryId;
        public string ItemClass;
        public string Printer;
        public int Lid;

        DBTask _DBTask = new DBTask();

        public void InsertVouchrType()
        {
            object[,] ObjArg = new object[6, 2]
            {
                {"@Vname",Vname},
                {"@UndrVouchr",UnderVuchr},
                {"@ItemCategryId",ItemCategryId},
                {"@ItemClass",ItemClass},
                {"@Printer",Printer},
                {"@Lid",Lid}
            };
            _DBTask.ExecuteNonQuery_SP("InsertVoucherType", ObjArg);
            return;
        }

        public string GetSpecificItem(string Lid,string FieldName)
        {
            string Item = _DBTask.ExecuteScalar("select " +FieldName+ " from tblVoucherType where Lid='" + Lid + "'");
            return Item;
        }
    }
}
