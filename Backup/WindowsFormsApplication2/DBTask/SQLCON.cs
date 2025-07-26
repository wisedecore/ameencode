using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class SQLCON
    {
        public static SqlConnection SQlCon;
        public static void SQlConopen()
        {
            DBTask objtask = new DBTask();
            objtask.setconstr();
            SQlCon = new SqlConnection(objtask._ConnectionString);
           // SQlCon.ConnectionTimeout = 200;
            SQlCon.Open();
        }

        public static void SQlConopensecondary()
        {
            DBTask objtask = new DBTask();
            objtask.setconstrsecondary();
            SQlCon = new SqlConnection(objtask._ConnectionString);
            SQlCon.Open();
        }

        public static void MasterSQlConopen()
        {
            DBTask objtask = new DBTask();
            objtask.setconstrMaster();
            SQlCon = new SqlConnection(objtask._ConnectionString);
            SQlCon.Open();
        }

        public static void SQLClose()
        {

        }

    }
}
