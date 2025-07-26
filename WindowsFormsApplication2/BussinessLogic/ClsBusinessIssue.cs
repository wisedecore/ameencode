using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Windows;
using System.Net.NetworkInformation;
namespace WindowsFormsApplication2
{
    class ClsBusinessIssue
    {
        public string Uid="";
        public long IdSales;
        public long IssueCodeLng;
        public string VnoStr="";
        public string IssueTypeStr="";
        public string DCode="";
        public string warrantyy = "";
        public string LedCodeCr="";
        public string LedCodeDr="";
        public double AMTDb;
        public string RemarkStr="";
        public string EmpId="";
        public double DiscAmtDb=0;
        public double TaxAMTDb=0;
        public double CoolyDb=0;
        public double CpDiscount = 0;
        public string Agent="0";
        public string Pvno = "";
        public string TaxId ="0";
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";
        public string vehicle = "";
        public string mtrread = "";
        public string twopaymode = "";
        public double twopayAmt= 0;
        public string CashReceived = "";
        public string SR = "";
        public double AdvanceAmount = 0;
        public double InvDisc = 0;
        public int Opno=0;
        public int ModeOfpayment;
        public long Pproject=0;
        public string LBLaccnt = "";
        public string vehiclename = "";
        public DateTime IssueDateDt;
        public string POnum= "";
        public string Deliverynote= "";
        public string Attention= "";
        public string MRFPRnum= "";
        public string Projcts = "";
        public string Due = "";


        DataSet Ds = new DataSet();

        DBTask _Dbtask = new DBTask();

        public void InsertBusinessIssuePara(int Opnof,long IIssuecode, string IVno, string IType, string IDcode
             ,DateTime IDate,string ILedCodeCr,string ILedcodeDr,double IAmt,string IRemarks
             ,string IEmp,double IDiscAmt,double IInvDisc,double ITaxAmt,double ICooly,double IAdamount,
             string Iagent, string Ipvno, string ITaxid, string ITename, double Icpdiscount, int IMpayment, string CashReceivedf,string SRf,long Iproject,
             string warrantyyf,string Uidf,string Tmobf,string Taddresf,string Tvatf,string vehiclef, string mtrreadf,string twopaymodef,double twopayAmtf,string LBLaccntf)
        {

            Opno=Opnof;
            IssueCodeLng=IIssuecode;
            VnoStr=IVno;
            IssueTypeStr=IType;
            DCode=IDcode;//30
            IssueDateDt=IDate;
            LedCodeCr=ILedCodeCr;
            LedCodeDr=ILedcodeDr;
            AMTDb=IAmt;
            RemarkStr=IRemarks;
            EmpId=IEmp;
            DiscAmtDb=IDiscAmt;
            InvDisc=IInvDisc;
            TaxAMTDb=ITaxAmt;//21
            CoolyDb=ICooly;
            AdvanceAmount=IAdamount;
            Agent=Iagent;
            Pvno=Ipvno;
            TaxId=ITaxid;
            Tename=ITename;
            CpDiscount = Icpdiscount;
            ModeOfpayment = IMpayment;
            CashReceived = CashReceivedf;
            SR = SRf;
            Pproject = Iproject;
            warrantyy= warrantyyf;
            Uid=Uidf;
            Tmob=Tmobf; 
            Taddres= Taddresf;
            Tvat=Tvatf;
            vehicle=vehiclef; 
            mtrread=mtrreadf;
            twopaymode=twopaymodef; 
            twopayAmt=twopayAmtf;
            LBLaccnt = LBLaccntf;

            InsertBusinessIssue();
        }
         public void UpdateFiled(string Query)
         {
             _Dbtask.ExecuteNonQuery(Query);
         }

        public void InsertBusinessIssue()
        {
            object[,] objArg = new object[42, 2]
        {
            {"@opno",Opno},
            {"@IssueCode",IssueCodeLng},
            {"@Vno",VnoStr},  
            {"@IssueType",IssueTypeStr},
            {"@Dcode",DCode},
            {"@IssueDate", IssueDateDt},
            {"@LedcodeCr",LedCodeCr},  
            {"@LedcodeDr",LedCodeDr},    
            {"@Amt",AMTDb},
            {"@Remarks",RemarkStr},  
            {"@Empid",EmpId},
            {"@DiscAmt",DiscAmtDb},
            {"@invdisc",InvDisc},
            {"@TaxAmt",TaxAMTDb},  
            {"@cooly",CoolyDb},
            {"@adamount",AdvanceAmount},
            {"@agent",Agent},
            {"@pvno",Pvno},
            {"@Taxid",TaxId},
            {"@Tename",Tename},
            {"@cpdiscount",CpDiscount},
            {"@Mpayment",ModeOfpayment},
            {"@CashReceived",CashReceived},
            {"@SR",SR},
            {"@pproject",Pproject},
            {"@warranty",warrantyy},
            {"@Uid",Uid},
            {"@Tmobile",Tmob}, 
            {"@Taddres",Taddres}, 
            {"@Tvat",Tvat},
            {"@vehiclenum",vehicle}, 
            {"@Mtrread",mtrread},
            {"@Twopayment",twopaymode}, 
            {"@twopayAmt",twopayAmt},
            {"@LBLaccnt",LBLaccnt},
            {"@vehiclename",vehiclename},
            {"@POnum",POnum},
            {"@Deliverynote",Deliverynote},
            {"@Attention",Attention},
            {"@MRFPRnum",MRFPRnum},
            {"@Projcts",Projcts},
            {"@Due",Due}
            


        };
            _Dbtask.ExecuteNonQuery_SP("InsertBusinessIssue", objArg);
            _Dbtask.ExecuteNonQueryAzureServer_SP("InsertBusinessIssue", objArg);
            //bool isConnected =_Dbtask.IsInternetAvailable();
            //if (isConnected)
            //{
            //    _Dbtask.ExecuteNonQueryAzureServer_SP("InsertBusinessIssue", objArg);
            //}
            //else
            //{
            //    MessageBox.Show("Please check your Internet Connection !");
            //}

            return;
        }







        public string getfeildsbyvtype(string VNN, string FiledName, string vtype)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select " + FiledName + " from tblbusinessissue where vno='" + VNN + "'  and Issuetype='" + vtype + "'  ");
            return Specific;
        }


        public void UpdateBusinessIssue()
        {
            object[,] objArg = new object[13, 2]
        {
            {"@IssueCode",IssueCodeLng},
            {"@Vno",VnoStr},  
            {"@IssueType",IssueTypeStr},
            {"@Dcode",DCode},
            {"@LedcodeCr",LedCodeCr},  
            {"@LedcodeDr",LedCodeDr},    
            {"@Amt",AMTDb},
            {"@Remarks",RemarkStr},  
            {"@Empid",EmpId},
            {"@DiscAmt",DiscAmtDb},
            {"@TaxAmt",TaxAMTDb},  
            {"@coolyAmt",CoolyDb},
            {"@IssueDate",IssueDateDt},
        };
            _Dbtask.ExecuteNonQuery_SP("UpdateBusinessIssue", objArg);
            return;
        }
        
        public void DeleteBusinessIssue()
        {
            object[,] objArg = new object[13, 2]
        {
            {"@IssueCode",IssueCodeLng},
            {"@Vno",VnoStr},  
            {"@IssueType",IssueTypeStr},
            {"@Dcode",DCode},
            {"@LedcodeCr",LedCodeCr},  
            {"@LedcodeDr",LedCodeDr},    
            {"@Amt",AMTDb},
            {"@Remarks",RemarkStr},  
            {"@Empid",EmpId},
            {"@DiscAmt",DiscAmtDb},
            {"@TaxAmt",TaxAMTDb},  
            {"@coolyAmt",CoolyDb},
            {"@IssueDate",IssueDateDt},
        };
            _Dbtask.ExecuteNonQuery_SP("DeleteBusinessIssue", objArg);
            return;
        }

        public double totcashamtbysaleee(string Where)
        {
            double amtt = 0;
            double totcardBysale = 0; double totcashBysale = 0;
            double totcreditcashBysale = 0; double totcreditcardBysale = 0;
            double totcardd = 0;
            totcardBysale =_Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr='28' and issuetype='SI'     and twopayment='0' "+Where+""));
            totcardd = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(amt)   from tblbusinessissue where ledcodedr='1' and  issuetype='si' " + Where + " "));
            totcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr='1' and  issuetype='si' and twopayment='2' " + Where + "  "));
            totcreditcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr not in('1','28') and twopayment='0'  and  issuetype='si'   and twopayamt!=0  " + Where + " "));
            amtt = (totcardBysale + totcardd + totcreditcashBysale) - (totcashBysale);
            return amtt;

        }
        public double totcashamtbysaleeeAzure(string Where)
        {
            double amtt = 0;
            double totcardBysale = 0; double totcashBysale = 0;
            double totcreditcashBysale = 0; double totcreditcardBysale = 0;
            double totcardd = 0;
            totcardBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr='28' and issuetype='SI'     and twopayment='0' " + Where + ""));
            totcardd = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(amt)   from tblbusinessissue where ledcodedr='1' and  issuetype='si' " + Where + " "));
            totcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr='1' and  issuetype='si' and twopayment='2' " + Where + "  "));
            totcreditcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr not in('1','28') and twopayment='0'  and  issuetype='si'   and twopayamt!=0  " + Where + " "));
            amtt = (totcardBysale + totcardd + totcreditcashBysale) - (totcashBysale);
            return amtt;

        }
        public string lastvnonumsale(string vtype)
        {
            string LASTVNO = "";
            LASTVNO = _Dbtask.znllString(_Dbtask.ExecuteScalar("SELECT { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='" + vtype + "' and ledcodeCr='2'"));
            return LASTVNO;
        
        }
        public double countofsale()
        {
            DateTime today;
            today = System.DateTime.Today;

            double countsale = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select count(vno) from tblbusinessissue  "+
             "  where  issuetype='SI' AND issuedate between '" + today.ToString("MM-dd-yyyy 00:00:00") + "'and '" + today.ToString("MM-dd-yyyy 23:59:59") + "'"));
            double count = 0;
            count = _Dbtask.znlldoubletoobject(countsale);

            return count;
        }
        public double getdiscount(string vnon)
        {
            double GADpur = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select discamt from tblbusinessissue where vno='" + vnon + "'"));

            double GDpuramt = _Dbtask.znlldoubletoobject(GADpur);
            return GDpuramt;
        }

        public string SpecificField(string VNN, string FiledName)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select " + FiledName + " from tblbusinessissue where vno='" + VNN + "'");
            return Specific;
        }
        public double totcrdamtbysale(string Where)
        {
            double amtt = 0;
            double totcardBysale = 0; double totcashBysale = 0;
            double totcreditcashBysale = 0; double totcreditcardBysale = 0;
            double totcardd = 0;
            totcardBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr='1' and  issuetype='si' and twopayment='2'  " + Where + " "));
            totcardd = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(amt)   from tblbusinessissue where ledcodedr='28' and  issuetype='si'   " + Where + " "));
            totcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr='28' and  issuetype='si'  and twopayment='0'  " + Where + " "));
            totcreditcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(twopayamt ) from tblbusinessissue where ledcodedr not in('1','28') and twopayment='2' and  issuetype='si'   and twopayamt!=0  " + Where + " "));
            amtt = (totcardBysale + totcardd + totcreditcashBysale) - (totcashBysale);
            return amtt;
        
        }
        public double totcrdamtbysaleAzure(string Where)
        {
            double amtt = 0;
            double totcardBysale = 0; double totcashBysale = 0;
            double totcreditcashBysale = 0; double totcreditcardBysale = 0;
            double totcardd = 0;
            totcardBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr='1' and  issuetype='si' and twopayment='2'  " + Where + " "));
            totcardd = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(amt)   from tblbusinessissue where ledcodedr='28' and  issuetype='si'   " + Where + " "));
            totcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr='28' and  issuetype='si'  and twopayment='0'  " + Where + " "));
            totcreditcashBysale = _Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(twopayamt ) from tblbusinessissue where ledcodedr not in('1','28') and twopayment='2' and  issuetype='si'   and twopayamt!=0  " + Where + " "));
            amtt = (totcardBysale + totcardd + totcreditcashBysale) - (totcashBysale);
            return amtt;

        }
        public string IdPurticular(string Vtype)
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='"+Vtype+"'"));
            return IdSales.ToString();
        }
        public void IdBusinessIssue()
        {
            IssueCodeLng = Convert.ToInt64(Generalfunction.getnextid("IssueCode", "TblBusinessIssue"));
        }
        public string GetSpecificField(string Field, string TempVno, string TempVtype, string TempLedcodeCr)
        {

            string Qry = "Select " + Field + " From TblBusinessIssue Where IssueType = '" + TempVtype + "' And Vno = '" + TempVno + "' And LedcodeCr in( " + TempLedcodeCr + ")";
            string Value = _Dbtask.ExecuteScalar(Qry);
            return Value;
        }
        public DataSet GetCustomerWiseBillList(string CustCode)
        {
            string Sql = "Select (pvno+vno) As Vno From TblBusinessIssue Where LedcodeDr = '" + CustCode + "' And Issuetype = 'SI'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            return Ds;
        }
        public double GetTotalAmt(string TempVno, string TempVtype)
        {
            if (TempVno.Substring(0, CommonClass._Paramlist.GetParamvalue("Sprefix").Length) == CommonClass._Paramlist.GetParamvalue("Sprefix"))
            {
                string Sql = "Select Amt From TblbusinessIssue Where Vno = '" + TempVno.Substring(CommonClass._Paramlist.GetParamvalue("Sprefix").Length, TempVno.Length - CommonClass._Paramlist.GetParamvalue("Sprefix").Length) + "' And IssueType = '" + TempVtype + "' And Pvno = '" + CommonClass._Paramlist.GetParamvalue("Sprefix") + "'";
                double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
                return Amt;
            }
            else
            {
                string Sql = "Select Amt From TblbusinessIssue Where Vno = '" + TempVno + "' And IssueType = '" + TempVtype + "' And Ledcodecr = '2'";
                double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
                return Amt;
            }
        }

        public string IdSalesFu(string SalesAccount,string Vtype)
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='"+Vtype+"' and LedcodeCr='"+SalesAccount+"'"));
                return IdSales.ToString();
        }
        public string IdSalesFuAzure(string SalesAccount, string Vtype)
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidConditionAzure("IssueCode", "TblBusinessIssue", " where IssueType='" + Vtype + "' and LedcodeCr='" + SalesAccount + "'"));
            return IdSales.ToString();
            }
        public string IdSalesreturnFu(string SalesAccount)
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='SR' and LedcodeDr='" + SalesAccount + "'"));
            return IdSales.ToString();
        }
     
        public string IdDeliveryNote()
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='DN'"));
            return IdSales.ToString();
        }
        public string IdDeliveryNoteReturn()
        {
            IdSales = Convert.ToInt64(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='DNR'"));
            return IdSales.ToString();
        }
        public void Vno(string Account)
        {
            VnoStr = Convert.ToString(Generalfunction.getnextidCondition("IssueCode", "TblBusinessIssue", " where IssueType='SI' and ledcodeCr='" + Account + "'"));
        }
        public void PVno2(string Account,string Vtype)
        {
            string TempVno = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='"+Vtype+"' and ledcodeCr='" + Account + "'");
            Pvno = CommonClass._Paramlist.GetParamvalue("Sprefix");
            VnoStr = _Dbtask.ExecuteScalar("select vno from TblbusinessIssue where IssueCode='" + TempVno + "' and issuetype='"+Vtype+"' and ledcodecr='" + Account + "'");
            if (VnoStr == "")
            {
                if (Vtype == "SI")
                {
                    VnoStr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select PARAMVALUE FROM TBLPARAMLIST WHERE PARAMNAME='MAXOFSI' "));
                }
                else
                {
                    VnoStr = "1";
                }
                
                }
            else
            {
                VnoStr = (Convert.ToInt64(VnoStr) + 1).ToString();
            }
        }
        public void PVno2Server(string Account, string Vtype)
        {
            string TempVno = _Dbtask.ExecuteScalarAzureServer("SELECT     { fn IFNULL(MAX(IssueCode), 0) } AS Expr1  FROM TblBusinessIssue where IssueType='" + Vtype + "' and ledcodeCr='" + Account + "'");
            Pvno = CommonClass._Paramlist.GetParamvalue("Sprefix");
            VnoStr = _Dbtask.ExecuteScalarAzureServer("select vno from TblbusinessIssue where IssueCode='" + TempVno + "' and issuetype='" + Vtype + "' and ledcodecr='" + Account + "'");
                if (VnoStr == "")
            {
                if (Vtype == "SI")
                {
                    VnoStr = _Dbtask.znllString(_Dbtask.ExecuteScalarAzureServer("select PARAMVALUE FROM TBLPARAMLIST WHERE PARAMNAME='MAXOFSI' "));
                }
                else
                {
                    VnoStr = "1";
                }

            }
            else
            {
                VnoStr = (Convert.ToInt64(VnoStr) + 1).ToString();
                }
        }

        public DataSet ShowBusinessIssue(string DisplayField,string Where)
        {
        Ds=_Dbtask.ExecuteQuery("select "+DisplayField+" from TblbusinessIssue "+Where+"");
        return Ds;
        }
        public double TottalAmountOfTypewithotCRDT(string Field, string VType, string Where)
        {
            string ammtt = "";
            ammtt = _Dbtask.ExecuteScalar("select sum(" + Field + ") from TblbusinessIssue where  IssueType='" + VType + "'      " + Where + " AND mpayment!='1'").ToString();
            AMTDb = _Dbtask.znlldoubletoobject(ammtt);
            //AMTDb = _Dbtask.SetintoDecimalpoint(AMTDb);

            return AMTDb;
        }
        public double TottalAmountOfTypewithotCRDTAzure(string Field, string VType, string Where)
        {
            string ammtt = "";
            ammtt = _Dbtask.ExecuteScalarAzureServer("select sum(" + Field + ") from TblbusinessIssue where  IssueType='" + VType + "'      " + Where + " AND mpayment!='1'").ToString();
            AMTDb = _Dbtask.znlldoubletoobject(ammtt);
            //AMTDb = _Dbtask.SetintoDecimalpoint(AMTDb);

            return AMTDb;
        }
        public double TottalAmountOfType(string Field, string VType, string Where)
        {
            string ammtt = "";
            ammtt = _Dbtask.ExecuteScalar("select sum(" + Field + ") from TblbusinessIssue where  IssueType='" + VType + "'      " + Where + "").ToString();
            AMTDb = _Dbtask.znlldoubletoobject(ammtt);
            //AMTDb = _Dbtask.SetintoDecimalpoint(AMTDb);

            return AMTDb;
        }
        public double TottalAmountOfTypeAzure(string Field, string VType, string Where)
        {
            string ammtt = "";
            ammtt = _Dbtask.ExecuteScalarAzureServer("select sum(" + Field + ") from TblbusinessIssue where  IssueType='" + VType + "'      " + Where + "").ToString();
            AMTDb = _Dbtask.znlldoubletoobject(ammtt);
            //AMTDb = _Dbtask.SetintoDecimalpoint(AMTDb);

            return AMTDb;
        }
        public DataSet ShowBusinessIssueWithJoint(string Vtype)
        {
            Generalfunction.TempCompanyname = "";
            Ds = _Dbtask.ExecuteQuery("SELECT     TblBusinessIssue.issuecode,TblBusinessIssue.LedcodeCr,"+
            " Convert(nvarchar(50),TblAccountLedger.LName)+':Vno='+Convert(nvarchar(50),TblBusinessIssue.VNo) "+
            " +':Amount='+Convert(nvarchar(50),TblBusinessIssue.AMT) as Sales FROM   TblBusinessIssue INNER JOIN "+
            " TblAccountLedger ON TblBusinessIssue.LedcodeCr = TblAccountLedger.Lid "+
" group by TblBusinessIssue.issuetype,TblBusinessIssue.LedcodeCr "+
" ,TblBusinessIssue.issuecode,TblAccountLedger.LName,TblBusinessIssue.VNo, "+
" TblBusinessIssue.AMT having TblBusinessIssue.issuetype='SI'");
            return Ds;
        }
    }
}
