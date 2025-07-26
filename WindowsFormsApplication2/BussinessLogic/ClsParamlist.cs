using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsParamlist
    {
        public string ParamName = "";
        public string Paramtype = "";
        public string ParamValue = "";
        DBTask _Dbtask = new DBTask();
        public void InsertParamlist()
        {
            object[,] ObjArg = new object[3, 2]
            {
            {"@paramname",ParamName},
            {"@paramtype",Paramtype},
            {"@paramvalue",ParamValue}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertParamlist", ObjArg);
            _Dbtask.ExecuteNonQueryAzureServer_SP("InsertParamlist", ObjArg);
            return;
        }

        public void UpdateParamlistquey()
        {
            object[,] ObjArg = new object[3, 2]
            {
            {"@paramname",ParamName},
            {"@paramtype",Paramtype},
            {"@paramvalue",ParamValue}
        };
            _Dbtask.ExecuteNonQuery_SP("UpdateParamList", ObjArg);
            return;
        }
        public void UPDATEPARAMVALUE(string PARAMNAME, string paramval)
        {
            _Dbtask.ExecuteNonQuery("update tblparamlist set paramvalue='" + paramval + "' where paramname='" + PARAMNAME + "'");
        }
        public void UpdateParamlist(string paramname, string ptype, string pvalue)
        {
            _Dbtask.ExecuteNonQuery("update tblparamlist set paramtype='" + ptype + "',paramvalue='" + pvalue + "' where paramname='" + paramname + "'");
        }
        public string GetParamvalue(string paramnameA)
        {
            string PramvalueS = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='" + paramnameA + "'");
            return PramvalueS;
        }
        public string GetParamvalueazure(string paramnameA)
        {
            string PramvalueS = _Dbtask.ExecuteScalarAzureServer("select paramvalue from tblparamlist where paramname='" + paramnameA + "'");
            return PramvalueS;
        }
        public void updateparamvalueVNO(string PARAMNAME, int Preval)
        {
            string newval = "";
            newval = _Dbtask.znllString((Preval + 1));
            _Dbtask.ExecuteNonQuery("update tblparamlist set paramvalue='" + newval + "' where paramname='" + PARAMNAME + "'");
            _Dbtask.ExecuteNonQuery("update tblparamlist set paramvalue='" + newval + "' where paramname='" + PARAMNAME + "'");
        }

        public void updateparamvalueVNOAzure(string PARAMNAME, int Preval)
        {
            string newval = "";
            newval = _Dbtask.znllString((Preval + 1));
            _Dbtask.ExecuteNonQueryAzureServer("update tblparamlist set paramvalue='" + newval + "' where paramname='" + PARAMNAME + "'");
            _Dbtask.ExecuteNonQueryAzureServer("update tblparamlist set paramvalue='" + newval + "' where paramname='" + PARAMNAME + "'");
        }
        public string GetFromfinacial()
        {
            string PramvalueS = _Dbtask.ExecuteScalar("select paramvalue from tblparamlist where paramname='Periodfrom'") +" 00:00:00 AM";
            return PramvalueS;
        }
        public bool IsParamNameExist(string ParamName)
        {
            DataSet Ds;
            string Qry = "Select * from Tblparamlist where ParamName = '" + ParamName + "'";
            Ds = CommonClass._Dbtask.ExecuteQuery(Qry);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
