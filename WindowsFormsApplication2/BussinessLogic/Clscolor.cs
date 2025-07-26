using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace WindowsFormsApplication2
{
    class Clscolor
    {
        public long cid;
        public string cname = "";
        DBTask _Dbtask = new DBTask();
        DataSet ds = new DataSet(); public DataSet Ds;


        public void Insertcolor()
        {
            object[,] objArg = new object[2, 2]
              {
                {"@cid",cid},
                {"@cname",cname}
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertcolor", objArg);
            return;
        }
        public string getcolor(string cid)
        {
            string cname = "";
            cname = _Dbtask.ExecuteScalar("select cname from tblcolor where cid='"+cid+"'").ToString();
            return cname;
        }
        public DataSet showcolorss(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select cid,cname as Color from tblcolor  " + Where + "");
            return Ds;
        }
    }
}
