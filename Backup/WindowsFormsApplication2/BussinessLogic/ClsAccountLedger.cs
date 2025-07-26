using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsAccountLedger
    {
        public string temp;
        public double LedgerBalance;
        public string SpecificField;
        public long LidLng;
        public string LNameStr="";
        public string LAliasNameStr="";
        public long GidLng;
        public string AddressStr="";
        public string PhoneStr="";
        public string MobileStr = ""; public string custmrcode = "";
        public double DiscDb;
        public string TaxRegNoStr="";
        public string EmailStr="";
        public string AreaStr="";
        public double CreditDaysInt;
        public double CreditLimitDb;
        public string OtherStr="";
        public double BalanceDb=0;
        public double Commision=0;
        public string CST = "";
        public long Cplan=0;
        public int Lstatus = -1;
        public int Lstatus2 = -1;
        public int UseCard = -1;
        public double CpBalance = 0;
       
  public string cityy="";
  public string Lcountryname="";
  public string postcode="";
  public string LDistrict = "";
        DBTask _Dbtask = new DBTask();
        Clssettings _Settings = new Clssettings();
        Clsselectreport _SelectReport = new Clsselectreport();
        ClsAccountGroup _AccountGroup=new ClsAccountGroup();
        ClsGeneralLedger _Generalledger = new ClsGeneralLedger();
        public DataSet Ds;

        public void InsertLedgerPara(long IIdF,string ILnameF,string IAliasNameF,long IGidF,
            string IAddressF,
            string IphoneF,string IMobileF,double IDiscpercF,string ITaxRegF,string IemailF,string IAreaF,
            double ICreditDaysF, double ICreLimiF, string IOthersF, double IBalanceF, double ICommiF,
            long ICplanF,int ILstatusF,int ILstatus2F,string ICstF,double ICpBalanceF,int IUsecardF,
            string custmrcodeF,string cityyF,string LcountrynameF,string postcodeF,string LDistrictF)
        {
            
            {
                LidLng =IIdF;
                LNameStr=ILnameF;
                LAliasNameStr=IAliasNameF;
                GidLng=IGidF;
                AddressStr=IAddressF;
                PhoneStr=IphoneF;
                MobileStr=IMobileF;
                DiscDb=IDiscpercF;
                TaxRegNoStr=ITaxRegF;
                EmailStr=IemailF;
                AreaStr=IAreaF;
                CreditDaysInt=ICreditDaysF;
                CreditLimitDb=ICreLimiF;
                OtherStr=IOthersF;
                BalanceDb=IBalanceF;
                Commision=ICommiF;
                Cplan=ICplanF;
                Lstatus=ILstatusF;
                Lstatus2=ILstatus2F;
                CST=ICstF;
                CpBalance = ICpBalanceF;
                UseCard = IUsecardF;
               custmrcode= custmrcodeF;
               cityy=cityyF;
               Lcountryname=LcountrynameF;
               postcode=postcodeF;
               LDistrict = LDistrictF;
                InsertLedger();
            }
           
        }
        public DataSet ShowSpecifcFiled(string Field, string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select DISTINCT " + Field + " from TblAccountledger " + Where + "");
            return Ds;
        }

        public void FillArea(ComboBox Comb)
        {
            _Dbtask.fillDatainCombowithQuery(Comb,"area","area","TblAccountledger","select DISTINCT area from TblAccountledger");
        }

        public double BalanceofledgerWhere(string Ledcode, string Where)
        {
            string LedBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode='" + Ledcode + "' " + Where + "")));
            double LB = Convert.ToDouble(LedBalance);
            return LB;
        }


        public void InsertLedger()
        {
            object[,] objArg = new object[27, 2]
            {
              {"@Lid",LidLng},
              {"@Lname",LNameStr},  
              {"@LAliasName",LAliasNameStr},
              {"@AGroupId",GidLng},
              {"@Address",AddressStr},
              {"@Phone",PhoneStr},
              {"@Mobile",MobileStr},
              {"@DiscPer",DiscDb},
              {"@TaxregNo",TaxRegNoStr},
              {"@email",EmailStr},
              {"@Area",AreaStr},
              {"@CreditDays",CreditDaysInt},
              {"@CreditLimit",CreditLimitDb},
              {"@Other",OtherStr},
              {"@Balance",BalanceDb}, 
              {"@Commision",Commision},
              {"@cplan",Cplan},
              {"@lstatus",Lstatus},
              {"@lstatus2",Lstatus2},
              {"@cst",CST},
              {"@cpbalance",CpBalance},
              {"@usecard",UseCard},
              {"@customercode",custmrcode},
              {"@cityy",cityy},
              {"@Lcountryname",Lcountryname},
              {"@postcode",postcode},
              {"@LDistrict",LDistrict}


            };
            _Dbtask.ExecuteNonQuery_SP("InsertLedger", objArg);
            return;
        }


        public void UpdateLedger()
        {
            object[,] objArg = new object[16, 2]
            {
      
             {"@Lid",LidLng},
              {"@Lname",LNameStr},  
             {"@LAliasName",LAliasNameStr},
              {"@AGroupId",GidLng},
              {"@Address",AddressStr},
              {"@Phone",PhoneStr},
              {"@Mobile",MobileStr},
              {"@DiscPer",DiscDb},
              {"@TaxregNo",TaxRegNoStr},
              {"@email",EmailStr},
              {"@Area",AreaStr},
              {"@CreditDays",CreditDaysInt},
              {"@CreditLimit",CreditLimitDb},
              {"@Other",OtherStr},
              {"@Balance",BalanceDb},
               {"@Commision",Commision} 
            };
            _Dbtask.ExecuteNonQuery_SP("ExecuteNonQuery_SP", objArg);
            return;
        }
        public void FillComboWhere(ComboBox Cmb,string whereunder)  
        {
            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Lid", "Lname", "TblAccountLedger", "SELECT * FROM TblAccountLedger " + whereunder + " order by lname asc");
                if (Cmb.Items.Count > 0)
                {
                    Cmb.SelectedIndex = 0;
                }
            }
            catch
            {
            }
        }
        public void FillAgent(ComboBox Cmb, string whereunder)
        {
            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Lid", "Lname", "TblAccountLedger", "SELECT       'None'  AS lname,0 as lid UNION ALL  SELECT lname,lid FROM TblAccountLedger " + whereunder + " order by lname asc");
                Cmb.SelectedValue = 0;
            }
            catch
            {
            }
        }
        public bool alreadyexistcustomer(string cusid)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where lid='" + cusid + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
        public DataSet VtypeinSales()
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where  lid !=2 and agroupid=21 and lid !=17 and lid !=24 ");
            return Ds;
        }
        public DataSet getcustomeronly(string which)
        {
            Ds = _Dbtask.ExecuteQuery("select lname,lid from tblaccountledger where  agroupid='18' and  lname like N'%" + which + "%' ");
            return Ds;
        }
        public DataSet VtypeinPurchase()
        {
            Ds = _Dbtask.ExecuteQuery("SELECT * FROM TblAccountLedger  where  AgroupId=26 and Lid not in(3,18,25)");
            return Ds;
        }
        public void updatefeildopening(string lid,string VNO,double amt)
        {

             CommonClass._GenLedger.VdateDt = System.DateTime.Today; ;
            CommonClass._GenLedger.VTypeStr = "OB";
             CommonClass._GenLedger.VnoStr = VNO;
            CommonClass._GenLedger.SlNoLng = Convert.ToInt64("1");
           CommonClass._GenLedger.LedCodeStr = lid;
             CommonClass._GenLedger.PurticularsStr = "Opening Balance";
            CommonClass._GenLedger.RefnoStr = "1001";
             CommonClass._GenLedger.DbAmtDb = amt;
            CommonClass._GenLedger.CrAmt = 0;
             CommonClass._GenLedger.InsertGeneralLedger();
           


            //_Dbtask.ExecuteNonQuery("update tblaccountledger set balance ='" + amt + "' where lid ='" + lid + "'  and agroupid='" + grpid + "' ");
        }

        public void FillComboWhereNormal(ComboBox Cmb, string whereunder)
        {
            try
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "Lid", "Lname", "TblAccountLedger", "SELECT * FROM TblAccountLedger " + whereunder + "");
                // Cmb.Items.Add("None");
                if (Cmb.Items.Count > 0)
                {
                    Cmb.SelectedIndex = 0;
                }
            }
            catch
            {
            }
        }


        public void IdAccountLedger()
        {
            LidLng = Convert.ToInt64(Generalfunction.getnextid("Lid", "TblAccountledger"));
        }
        public string ReturnLedid(string Name)
        {
            string lid = _Dbtask.ExecuteScalar("Select lid from TblAccountledger where lname='" + Name + "'");
            return lid;
        }
        public string NameAccountLedger(string LId)
        {
            string AccountName=_Dbtask.ExecuteScalar("Select Lname from TblAccountledger where Lid="+LId+"");
            return AccountName;
        }

        public string GetSpecificfieldBaseonName(string Name, string Field)
        {
            try
            {
                return _Dbtask.ExecuteScalar("select " + Field + " from tblaccountledger where  lname='" + Name + "'");
            }
            catch
            {
                return "";
            }
        }
        public DataSet ShowLedger(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblAccountledger " + Where + "");
            return Ds;
        }
        public DataSet ShowLedgerInGrid(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select lid,lname as Name,laliasname as 'Alias Name',address,mobile,email from TblAccountledger " + Where + "");
            return Ds;
        }
        public DataSet ShowLedgerNoteincludeDeactive(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblAccountledger " + Where + " and lstatus !=0");
            return Ds;
        }
        
        public double Balanceofledger(string Ledcode)
        {
            string LedBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode='" + Ledcode + "'")));
            double LB=Convert.ToDouble(LedBalance);
            return LB;
        }
        public double Balanceofledgerwhere(string Ledcode, string wheree)
        {
            string LedBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode='" + Ledcode + "' and  " + wheree + "")));
            double LB = Convert.ToDouble(LedBalance);
            return LB;
        }
        public double BalanceofledgerWISEDATE(string Ledcode, string Pproject,string CONDTN)
        {
            string LedBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode='" + Ledcode + "' and pproject='" + Pproject + "'  and "+CONDTN+" ")));
            double LB = CommonClass._Dbtask.znlldoubletoobject(LedBalance);
            return LB;
        }
        public double BalanceofledgerBasepproject(string Ledcode, string Pproject)
        {
            string LedBalance = _Dbtask.SetintoDecimalpoint(Convert.ToDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt)-sum(cramt),0) from tblgeneralledger where ledcode='" + Ledcode + "' and pproject='"+Pproject+"'")));
            double LB = Convert.ToDouble(LedBalance);
            return LB;
        }

        public string GetDiscount(string Lid)
        {
            SpecificField = _Dbtask.ExecuteScalar("select Discper from tblaccountledger where lid='" + Lid + "'");
            return SpecificField;
        }

        public string GetspecifField(string Field, string Lid)
        {
            SpecificField = _Dbtask.ExecuteScalar("select " + Field + " from tblaccountledger where lid='" + Lid + "'");
            return SpecificField;
        }
        public void UpdatetspecifField(string Field,string Value, string Lid)
        {
            SpecificField = _Dbtask.ExecuteScalar("update   tblaccountledger set " + Field +"='"+Value+"' where lid='" + Lid + "'");
        }
        public void FillComboCustomer(ComboBox Comb)
        {
            temp=_AccountGroup.ShowCustomerAccount("");
            _Dbtask.fillDatainCombowithQuery(Comb, "lid", "lname", "tblaccountledger", "select  'None' as lname,0 as lid UNION ALL  select lname,lid from tblaccountledger where agroupid in(" + temp + ") order by lname asc");
        }
        public void FillComboSupplier(ComboBox Comb)
        {
            temp = _AccountGroup.ShowSupplierAccount("");
            _Dbtask.fillDatainCombowithQuery(Comb, "lid", "lname", "tblaccountledger", "select  'None' as lname,0 as enqvno UNION ALL  select lname,lid  from tblaccountledger where agroupid in(" + temp + ")order by lname asc");
        }
        public void FillComboAgent(ComboBox Comb)
        {
            temp = _AccountGroup.ShowAgentAccount("");
            _Dbtask.fillDatainCombowithQuery(Comb, "lid", "lname", "tblaccountledger", "select  'None' as lname,0 as lid UNION ALL  select lname,lid from tblaccountledger where agroupid in(" + temp + ")order by lname asc");
        }
        public void FillComboEmployee(ComboBox Comb)
        {
            temp = _AccountGroup.ShowEmployeeAccount("");
            _Dbtask.fillDatainCombowithQuery(Comb, "lid", "lname", "tblaccountledger", "select  'None' as lname,0 as lid UNION ALL  select lname,lid from tblaccountledger where agroupid in(" + temp + ")order by lname asc");
        }
        public void FillComboSupplierandCustomer(ComboBox Comb)
        {
            temp = _AccountGroup.ShowSupplierAndCustomerAccount("");
            _Dbtask.fillDatainCombowithQuery(Comb, "lid", "lname", "tblaccountledger", "select  'None' as lname,0 as lid UNION ALL  select lname,lid from tblaccountledger where agroupid in(" + temp + ")order by lname asc");
        }
       
        public void CheCkForLedgerUpdation()
        {
            _Dbtask.ExecuteNonQuery("update tblaccountledger set lstatus=-1 ");/*For Updating Lstatus*/
            if (Clssettings.SDeactiveLedger == true)
            {
                temp = _AccountGroup.ShowSupplierAndCustomerAccount("");

                Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid in ("+temp+")");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string Lid = Ds.Tables[0].Rows[i]["lid"].ToString();
                    LedgerBalance = Balanceofledger(Lid);
                    if (_Generalledger.CountLedgerTRansaction(" where ledcode in(" + Lid + ")") == true)
                    {
                        if (LedgerBalance == 0)
                            UpdatetspecifField("lstatus", "0", Lid);
                        else
                            UpdatetspecifField("lstatus", "-1", Lid);
                    }
                    else
                    {
                        UpdatetspecifField("lstatus", "-1", Lid);
                    }
                }
            }
        }
    }
}
