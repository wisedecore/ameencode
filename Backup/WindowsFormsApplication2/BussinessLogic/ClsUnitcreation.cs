using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class ClsUnitcreation
    {
        DataSet Ds;
        public long Id;
        public string Name;
        public double Ucount;

        DBTask _DBTask = new DBTask();

        public void InsertUnit()
        {
            object[,] ObjArg = new object[3, 2]
            {
                {"@Id",Id},
                {"@Name",Name},
                {"@ucount",Ucount}
            };
            _DBTask.ExecuteNonQuery_SP("InsertUnitcreation", ObjArg);
            return;
        }
        public void FillUnit(ComboBox Cmb)
        {
            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Id", "Name", "tblUnitcreation", "select * from tblUnitcreation");
                // Cmb.Items.Add("None");
                Cmb.SelectedIndex = 0;
            }
            catch
            {
            }
        }
        public DataSet LoadUnit(string where)
        {
            return _DBTask.ExecuteQuery("select * from tblUnitcreation "+where+"");
        }

        public string Getspesificfield(string PField,string Pid)
        {
            if (PField == "ucount")
            {
                string temp;
                if (Pid == "0")
                {
                    temp = "1";
                }
                else
                {
                    temp = _DBTask.ExecuteScalar("select " + PField + " from tblUnitcreation where id='" + Pid + "'");
                    if (temp=="")
                {
                    temp = "1";
                }
                
                
                }
              return  temp = (_DBTask.znullDouble(temp)).ToString();
            }
            
                return _DBTask.ExecuteScalar("select " + PField + " from tblUnitcreation where id='" + Pid + "'");
            
        }

        public string Getunitofitem(string itemid)
        {
            Ds = _DBTask.ExecuteQuery("select unitid from tblreceiptdetails where pcode='" + itemid + "'");
           if (Ds.Tables[0].Rows.Count > 0)
           {
               return Ds.Tables[0].Rows[0]["unitid"].ToString();
           }
           return "1";
        }
    }
}
