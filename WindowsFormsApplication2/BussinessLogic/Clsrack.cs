using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Clsrack
    {


        public long Rid;
        public string Rack= "";


        public void Insertrack()
        {
            object[,] objArg = new object[2, 2]
              {
                {"@Rid",Rid},
                {"@Rack",Rack}
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("InsertRack", objArg);
            return;
        }


        public string FurackName(string Aid)
        {
            return CommonClass._Dbtask.ExecuteScalar("select rack from Tblrack  where rid='" + Aid + "'");
        }


        public void Fillrack(ComboBox Cmb)
        {

            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Rid", "Rack", "Tblrack", "SELECT rack,rid FROM Tblrack  order by rack asc");
                Cmb.SelectedValue = 0;
            }
            catch
            {
            }
        }
    }
}
