using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsAccountGroup
    {
        public string temp; 

        public long AccountGroupIDLng;
        public string GroupNameStr="";
        public int UnderInt;
        public DataSet Ds;
        DBTask _Dbtask = new DBTask();
        Generalfunction _Gen=new Generalfunction();
        Clsselectreport _SelectReport = new Clsselectreport();

        public void InsertAccountsGroup()
        {
        object [,]objArg=new object[3,2]
        {
                {"@AGroupId",AccountGroupIDLng},
              {"@AGroupName",GroupNameStr},  
             {"@AUnder",UnderInt}
            };
        _Dbtask.ExecuteNonQuery_SP("InsertAccount", objArg);
        return;
        }

        public void UpdateAccount()
        {
            object[,] objArg = new object[3, 2]
        {
             {"@AGroupId",AccountGroupIDLng},
             {"@AGroupName",GroupNameStr},  
             {"@AUnder",UnderInt}
            };
            _Dbtask.ExecuteNonQuery_SP("UpdateAccount", objArg);
            return;
        }

        public void DeleteAccount()
        {
            object[,] objArg = new object[3, 2]
        {
             {"@AGroupId",AccountGroupIDLng},
             {"@AGroupName",GroupNameStr},  
             {"@AUnder",UnderInt}
            };
            _Dbtask.ExecuteNonQuery_SP("DeleteAccount", objArg);
            return;
        }

        public void IdAccountGroup()
        {
            AccountGroupIDLng =Convert.ToInt64( Generalfunction.getnextid("Agroupid", "TblAccountGroup"));   
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "AgroupId", "AgroupName", "TblaccountGroup", "select * from Tblaccountgroup where Agroupid!=1 and Agroupid!=2 and Agroupid!=3 and Agroupid!=4 and Agroupid!=6 and Agroupid!=7 and Agroupid!=23");
        }

        public void FillComboWhere(ComboBox Cmb,String Where)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "AgroupId", "AgroupName", "TblaccountGroup", "select * from Tblaccountgroup "+Where+"");
        }

        public DataSet ShowAccountGroup(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from Tblaccountgroup where Agroupid not in (3) " + Where + "");
           return Ds;
        }
        public string ShowCustomerAccount(string Where)
        {
            temp =_SelectReport.Showindataset ("select * from Tblaccountgroup where agroupid in(18) or aunder in(18)");
            return temp;
        }
        public string ShowSupplierAccount(string Where)
        {
            temp = _SelectReport.Showindataset("select * from Tblaccountgroup where agroupid in(19) or aunder in(19)");
            return temp;
        }
        public string ShowCashandBank(string Where)
        {
            temp = _SelectReport.Showindataset("select * from Tblaccountgroup where agroupid in(24,25) or aunder in(24,25)");
            return temp;
        }
        public string ShowEmployeeAccount(string Where)
        {
            temp = _SelectReport.Showindataset("select * from Tblaccountgroup where agroupid in(22) or aunder in(22)");
            return temp;
        }
        public string ShowAgentAccount(string Where)
        {
            temp = _SelectReport.Showindataset("select * from Tblaccountgroup where agroupid in(29) or aunder in(29)");
            return temp;
        }
        public string ShowSupplierAndCustomerAccount(string Where)
        {
            temp = _SelectReport.Showindataset("select * from Tblaccountgroup where agroupid in(19,18) or aunder in(19,18)");
            return temp;
        }
        public DataSet DsShowSupplierAndCustomerAccount(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from Tblaccountgroup where agroupid in(19,18) or aunder in(19,18)");
            return Ds;
        }
        public void ComboShowSupplierAndCustomerAccount(ComboBox Combo)
        {
            _Dbtask.fillDatainCombowithQuery(Combo, "agroupid", "agroupname","Tblaccountgroup", "select * from Tblaccountgroup where agroupid in(19,18) or aunder in(19,18)");
        }
    }
}
