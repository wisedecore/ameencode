using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clsfeedback
    {
        public string fid;
        public string fcustomer;
        public string fcalling;
        public string ffeedback;
        DBTask _dbtask = new DBTask();

        public void insertfeedback() 
        {
            object[,] objArg = new object[4, 2]
            {
                {"@fid",fid},
                {"@fcustomer",fcustomer},
                {"@fcalling",fcalling},
                {"@ffeedback",ffeedback}
            };
            _dbtask.ExecuteNonQuery_SP("insertfeedback", objArg);
            return;
        }
        public string getstatus( string stsid)
        {
            string status="";

            if( stsid=="0")
            {
            status="URGENT";
            }
            else if(stsid=="1")
            {
            status="NOT URGENT";
            }
            else if (stsid == "2")
            {
                status="CALLING";
            }
            else
            {
            status="SUGGESTION";
            }

            return status;
        }
    }
}
