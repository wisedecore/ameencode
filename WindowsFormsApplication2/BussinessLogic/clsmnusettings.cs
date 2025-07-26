using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class clsmnusettings
    {
        public string Menuid;
        public string MenuName = "";
        public string Parentid;
        public string Status;
        DBTask _Dbtask = new DBTask();
        public void InsertMnusettings()
        {
            object[,] ObjArg = new object[4, 2]
            {
            {"@Menuid",Menuid},
            {"@Menuname",MenuName},
            {"@parentid",Parentid},
             {"@status",Status}
        };
            _Dbtask.ExecuteNonQuery_SP("Insertmnusettings", ObjArg);
            return;
        }

        public void UpdateMenusettings(string menuid, string status)
        {
            _Dbtask.ExecuteNonQuery("update tblmnusettings set status='" + status + "' where menuid='" + menuid + "'");
        }

        public string GetMnustatus(string Menuid)
        {
            string Menustatus = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='" + Menuid + "'");
            return Menustatus;
        }
        public void InsertMnusettingsIsnotexsting(string MnuId, string MnuName, string ParntId, string stats)
        {
            if (IsMenuFound(MnuId) == true)
            {
                return;
            }

            this.Menuid = MnuId;
            this.MenuName = MnuName;
            this.Parentid = ParntId;
            this.Status = stats;

            InsertMnusettings();
        }
        public bool IsMenuAlreadyExist(string MnuName)
        {
            if (NextGFuntion.IsValueFoundInTable("'" + MnuName + "'", "tblmnusettings", "MenuName") == true)
            {
                return true;
            }
            return false;
        }
        public void AddNewMenu(string MnuId, string MnuName, string PrntId, string Stats)
        {
            Menuid = MnuId;
            MenuName = MnuName;
            Parentid = PrntId;
            Status = Stats;
            InsertMnusettings();
        }
        public bool IsMenuFound(string MnuId)
        {
            string Sql = "Select * from tblmnusettings Where menuid = '" + MnuId + "'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
