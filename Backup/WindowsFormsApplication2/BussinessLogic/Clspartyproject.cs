using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clspartyproject
    {
        public string temp;
        public long Pid;
        public string ProjectName;
        public long PartyId;
        public string Mobile;
        public string Address;

        public string SpecificField;
        //DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();

        public void InsertParty()
        {
            object[,] ObjArg = new object[5, 2]
            {
            {"@pid",Pid},
            {"@pname",ProjectName},
            {"@partyid",PartyId},
            {"@Mobile",Mobile},
            {"@Address",Address}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertpartyproject", ObjArg);
            return;
        }

        public string Getvno()
        {
            temp = Generalfunction.getnextid("pid", "Tblpartyproject");
            return temp;
        }

        public void FillComboPartyproject(bool All,string FPartyid,ComboBox Comb)
        {
            _Dbtask.fillDatainCombowithQuery(Comb, "pid", "pname", "Tblpartyproject", "SELECT       0 as pid, 'None'  AS pname UNION ALL select  pid,pname from Tblpartyproject where partyid in (" + FPartyid + ")");
        }

        public DataSet Showpartyproject(bool All, string FPartyid)
        {
            return  _Dbtask.ExecuteQuery("SELECT       0 as pid, 'None'  AS pname UNION ALL  select  pid,pname from Tblpartyproject where partyid in (" + FPartyid + ")");
        }

        public void FillDataPartyproject(bool All, string FPartyid,DataGridView Grid)
        {

        }


        public string GetspecifField(string Field, string Lid)
        {
            SpecificField = _Dbtask.ExecuteScalar("select " + Field + " from Tblpartyproject where pid='" + Lid + "'");
            return SpecificField;
        }

        public string GetspecifFieldBaseonName(string Field, string Name)
        {
            SpecificField = _Dbtask.ExecuteScalar("select " + Field + " from Tblpartyproject where pname='" + Name + "'");
            return SpecificField;
        }
    }
}
