using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsInternelTransfer
    {
        public long TCode;
        public int DCodeFrom;
        public int DCodeTo;
        public DateTime TDate;
        public string Remarks = "";

        DBTask _Dbtask = new DBTask();

        public void InsertInternelTransfer()
        {

            object[,] objArg = new object[5, 2]
        {
            {"@Tcode",TCode},
            {"@Dcodefrom",DCodeFrom},  
            {"@DcodeTo",DCodeTo},
            {"@TDate",TDate},
            {"@Remarks",Remarks}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertInternelTransfer", objArg);
            return;
        }
        public long Id()
        {
            TCode = Convert.ToInt64(_Dbtask.ExecuteScalar("select Tcode from TblinternelTransfer"));
            return TCode;
        }
    }

}
