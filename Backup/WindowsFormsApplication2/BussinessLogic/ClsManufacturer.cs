using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace WindowsFormsApplication2
{
    class ClsManufacturer
    {
        public long Mid;
        public string Mname = "";
        public string Address="";
        public string Phone="";
        DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();

        public void InsertManufacturer()
        {
            object[,] ObjArg = new object[4, 2]
            {
            {"@Mid",Mid},
            {"@Mname",Mname},
            {"@Address",Address},  
            {"@Phone",Phone},
        };
            _Dbtask.ExecuteNonQuery_SP("InsertManufacturer", ObjArg);
            return;
        }
        public void IdManufacturer()
        {
        Mid=Convert.ToInt64(Generalfunction.getnextid("Mid", "TblManufacturer"));
        }

        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "Mid", "Mname", "Tblmanufacturer", "SELECT * FROM Tblmanufacturer ");
        }

        //public void ManfactureIsexsting(string Name)
        //{
        // Ds=_Dbtask.ExecuteQuery("select * from  Tblmanufacturer where Mid= 
        //}
        public string SpecificField(string Id, string FiledName)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select " + FiledName + " from Tblmanufacturer where Mid='" + Id + "' ");
            return Specific;
        }

        public DataSet ShowManfacturer(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from Tblmanufacturer " + Where + "");
            return Ds;
        }
    }
}
