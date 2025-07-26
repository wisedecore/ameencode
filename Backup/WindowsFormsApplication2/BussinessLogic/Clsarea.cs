using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clsarea
    {
        public long Aid;
        public string Aname = "";


        public void InsertArea()
        {
                object[,] objArg = new object[2, 2]
              {
                {"@Aid",Aid},
                {"@Aname",Aname}
              };
                CommonClass._Dbtask.ExecuteNonQuery_SP("Insertarea", objArg);
                return;
        }

        public void FillArea(ComboBox Cmb)
        {

            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Aid", "Aname", "tblarea", "SELECT Aname,Aid FROM tblarea  order by Aname asc");
                Cmb.SelectedValue = 0;
            }
            catch
            {
            }
        }

        public void Updatecustomerfield()
        {
            CommonClass._Dbtask.ExecuteNonQuery("update tblaccountledger set Aid=0 where Aid=''");        
        }

        public DataSet Showarea(string Where)
        {
            return CommonClass._Dbtask.ExecuteQuery("select *  from tblarea " + Where + "");
        }

        public string getareaname(string id)
        {
            return CommonClass._Dbtask.ExecuteScalar("select aname from tblarea where aid ='" + id + "'").ToString();
        }
        
    }
}
