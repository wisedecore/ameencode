using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsGeneralLedger
    {
        public string Uid="";
        public bool Btemp;
        /*For Calculating Functions*/
        public double SaleAmt;
        /**************************************/
        public DateTime VdateDt;
        public string VTypeStr = "";
        public string VnoStr = "";
        public long SlNoLng=0;
        public string LedCodeStr = "";
        public string PurticularsStr = "";
        public double DbAmtDb;
        public double CrAmt;
        public string Naration = "";
        public string Naration2 = "";
        public string RefnoStr = "";
        public string EmployeeIdStr = "";
        public long Pproject=0;
        public double billbalance = 0;
        public double Discount = 0;
        DateTime frst; DateTime Last;
        public double RPtaxperc = 0;
        public double RPtaxamt = 0;
        public double cashdskRcvamt= 0;
        public string SpecificField;
        public string Agvno = "";

        DataSet Ds;
        DataSet DSw;
        DBTask _Dbtask = new DBTask();
        public void InsertGeneralLedger()
        {

            
            object[,] objArg = new object[20, 2]
        {
          
            {"@vdate",VdateDt},
            {"@vtype",VTypeStr},  
            {"@vno",VnoStr},
            {"@Slno",SlNoLng},
            {"@ledcode",LedCodeStr},  
            {"@purticulars",PurticularsStr},   
            {"@Dbamt",DbAmtDb},
            {"@Cramt",CrAmt},  
            {"@naration",Naration},
            {"@naration2",Naration2},
             {"@Refno",RefnoStr},  
            {"@Employee",EmployeeIdStr},
             {"@pproject",Pproject},
              {"@Uid",Uid},
              {"@discount",Discount},
              {"@BillBalance",billbalance},
              {"@RecvdAmt",cashdskRcvamt},
              {"@RPtaxperc",RPtaxperc},
              {"@RPtaxamt",RPtaxamt},
              {"@Agvno",Agvno}


              
        };
            _Dbtask.ExecuteNonQuery_SP("InsertGeneralLedger", objArg);
            return;
        }

        public void UpdateGeneralLedger()
        {

            object[,] objArg = new object[11, 2]
        {
            {"@vdate",VdateDt},
            {"@vtype",VTypeStr},  
            {"@vno",VnoStr},
            {"@Slno",SlNoLng},
            {"@ledcode",LedCodeStr},  
            {"@Purticulars",PurticularsStr},    
            {"@Dbamt",DbAmtDb},
            {"@Cramt",CrAmt},  
            {"@naration",Naration},
             {"@RefnoStr",RefnoStr},  
            {"@EmployeeIdStr",EmployeeIdStr}
        };
            _Dbtask.ExecuteNonQuery_SP("UpdateGeneralLedger", objArg);
            return;
        }

        public void DeleteGeneralLedger()
        {

            object[,] objArg = new object[11, 2]
        {
            {"@vdate",VdateDt},
            {"@vtype",VTypeStr},  
            {"@vno",VnoStr},
            {"@Slno",SlNoLng},
            {"@ledcode",LedCodeStr},  
            {"@Purticulars",PurticularsStr},    
            {"@Dbamt",DbAmtDb},
            {"@Cramt",CrAmt},  
            {"@naration",Naration},
             {"@RefnoStr",RefnoStr},  
            {"@EmployeeIdStr",EmployeeIdStr}
        };
            _Dbtask.ExecuteNonQuery_SP("DeleteGeneralLedger", objArg);
            return;


        }
        public double cashtobankamtPayment(string wheredatee, string TYPE)
        {
            double lastamt = 0; double totamtt = 0;
            if (TYPE == "C2B")
            {
                Ds = _Dbtask.ExecuteQuery("select distinct vno from tblgeneralledger where vtype='P' AND " + wheredatee + " AND purticulars!='Two type paymentSales' and CRamt>0");
            }

            if (TYPE == "B2C")
            {
                Ds = _Dbtask.ExecuteQuery("select distinct vno from tblgeneralledger where vtype='P' AND " + wheredatee + " AND purticulars!='Two type paymentSales' and CRamt>0");
            }

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                {
                    string tvno = ""; double amt2 = 0;
                    string leddcode = ""; double amt = 0;
                    string leddcode2 = ""; double amt3 = 0;
                    tvno = Ds.Tables[0].Rows[k]["vno"].ToString();
                    if (TYPE == "B2C")
                    {
                        DSw = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + tvno + "' and ledcode in('1') and vtype='P' and  CRAMT>0");
                    }
                    if (TYPE == "C2B")
                    {
                        DSw = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + tvno + "' and ledcode in('28') and vtype='P' and CRAMT>0");
                    }

                    if (DSw.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < DSw.Tables[0].Rows.Count; i++)
                        {
                            leddcode = DSw.Tables[0].Rows[i]["ledcode"].ToString();
                            if (leddcode == "1" || leddcode == "28")
                            {
                                if (leddcode == "1")
                                {
                                    amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt - cramt) from tblgeneralledger where vtype='P' and vno='" + tvno + "' and ledcode='" + leddcode + "'"));
                                    if (amt < 0)
                                    {
                                        amt = amt * (-1);
                                    }

                                    leddcode2 = "";
                                    leddcode2 = _Dbtask.znllString(_Dbtask.ExecuteScalar("select ledcode from tblgeneralledger where vtype='P' and vno='" + tvno + "' and ledcode!='" + leddcode + "' and dbamt>0 "));
                                    if (leddcode2 == "28")
                                    {
                                        //amt2 = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt - cramt) from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode='" + leddcode2 + "'"));
                                        //if (amt2 < 0)
                                        //{
                                        //    amt2 = amt2 * (-1);
                                        //}


                                        //totamtt = 0;amt3 = 0;
                                        amt3 = amt + amt3;
                                        totamtt = totamtt + amt3;
                                    }
                                }
                                if (leddcode == "28")
                                {
                                    amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where vtype='P' and vno='" + tvno + "' and ledcode='" + leddcode + "'"));
                                    leddcode2 = "";
                                    leddcode2 = _Dbtask.znllString(_Dbtask.ExecuteScalar("select ledcode from tblgeneralledger where vtype='P' and vno='" + tvno + "' and ledcode!='" + leddcode + "' and dbamt>0"));
                                    if (leddcode2 == "1")
                                    {
                                        amt2 = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where vtype='P' and vno='" + tvno + "' and ledcode='" + leddcode2 + "'"));
                                        //totamtt = 0; amt3 = 0;
                                        amt3 = amt + amt3;
                                        totamtt = totamtt + amt3;
                                    }

                                }

                            }
                        }
                    }
                    lastamt = 0;
                    lastamt = totamtt;
                }
            }

            return lastamt;
            
        }
        public double cashtobankamtReceipt(string wheredatee,string TYPE)
        {
            double lastamt = 0; double totamtt = 0;
            if ( TYPE=="C2B")
            {
            Ds = _Dbtask.ExecuteQuery("select distinct vno from tblgeneralledger where vtype='R' AND " + wheredatee + " AND purticulars!='Two type paymentSales' and dbamt>0");
            }

            if (TYPE == "B2C")
            {
                Ds = _Dbtask.ExecuteQuery("select distinct vno from tblgeneralledger where vtype='R' AND " + wheredatee + " AND purticulars!='Two type paymentSales' and dbamt>0");
            }

                if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int k = 0; k < Ds.Tables[0].Rows.Count; k++)
                {
                    string tvno = ""; double amt2 = 0; 
                    string leddcode = ""; double  amt = 0;
                    string leddcode2 = "";double amt3 = 0;
                    tvno = Ds.Tables[0].Rows[k]["vno"].ToString();
                    if (TYPE == "B2C")
                    {
                        DSw = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + tvno + "' and ledcode in('1') and vtype='R' and  dbamt>0");
                    }
                    if (TYPE == "C2B")
                    {
                        DSw = _Dbtask.ExecuteQuery("select * from tblgeneralledger where vno='" + tvno + "' and ledcode in('28') and vtype='R' and dbamt>0");
                    }

                    if (DSw.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < DSw.Tables[0].Rows.Count; i++)
                        {
                            leddcode = DSw.Tables[0].Rows[i]["ledcode"].ToString();
                            if (leddcode == "1" || leddcode == "28")
                            {
                                if (leddcode == "1")
                                {
                                    amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt - cramt) from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode='" + leddcode + "'"));
                                    if (amt<0)
                                     {
                                       amt = amt * (-1);
                                    }
                                    
                                    leddcode2 = "";
                                    leddcode2 = _Dbtask.znllString(_Dbtask.ExecuteScalar("select ledcode from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode!='" + leddcode + "' and cramt>0 "));
                                 if (leddcode2 == "28")
                                   {
                                       //amt2 = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt - cramt) from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode='" + leddcode2 + "'"));
                                       //if (amt2 < 0)
                                       //{
                                       //    amt2 = amt2 * (-1);
                                       //}
                                     
                                     
                                     //totamtt = 0;amt3 = 0;
                                     amt3 = amt+amt3;
                                     totamtt = totamtt + amt3;
                                 }
                                }
                                if (leddcode == "28")
                                {
                                    amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode='" + leddcode + "'"));
                                    leddcode2 = "";
                                    leddcode2 = _Dbtask.znllString(_Dbtask.ExecuteScalar("select ledcode from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode!='" + leddcode + "' and cramt>0"));
                                    if (leddcode2 == "1")
                                    {
                                        amt2 = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where vtype='R' and vno='" + tvno + "' and ledcode='" + leddcode2 + "'"));
                                        //totamtt = 0; amt3 = 0;
                                        amt3 = amt + amt3;
                                        totamtt = totamtt + amt3;
                                    }

                                }




                            }

                        }
                    }
                   lastamt=0;  
                   lastamt=totamtt;
                }
            }

            return lastamt;
        }
        

        public double creditdaysstatus(string lidd)
                        {
           
            Ds = _Dbtask.ExecuteQuery("select vdate from tblgeneralledger where ledcode='" + lidd + "' and vtype='si' order by vdate asc");
            if (Ds.Tables[0].Rows.Count>0)
           {
               frst = Convert.ToDateTime(Ds.Tables[0].Rows[0]["vdate"]);
           }

         
            Ds = _Dbtask.ExecuteQuery("select vdate from tblgeneralledger where ledcode='" + lidd + "' and vtype='si' order by vdate desc");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Last = Convert.ToDateTime(Ds.Tables[0].Rows[0]["vdate"]);
            }

            TimeSpan ts = Last -  frst;



           int differenceInDays = ts.Days; // This is in int
          double difDays= ts.TotalDays;

          return difDays;
        
        }

        public string creditdayschekbylastbill(string ledcode,int DAYS)
        {
            string RESULT = "";
            Ds = _Dbtask.ExecuteQuery("select vdate from tblgeneralledger where ledcode='" + ledcode + "' and vtype='SI' order by vdate desc");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Last = Convert.ToDateTime(Ds.Tables[0].Rows[0]["vdate"]);

            }
            TimeSpan ts =  System.DateTime.Today - Last;



            int differenceInDays = ts.Days; // This is in int
            if (differenceInDays > DAYS)
            {
                RESULT = "OVER";
             
            }
            else
            {
                RESULT = "";
               
            }
            return RESULT;
        }


        public void IdGeneralLedger(string where)
        {
            VnoStr = Generalfunction.getnextidConditionforgeneralledger("vno", "Tblgeneralledger",where);
        }

        //public void IdGeneralLedger(string where)
        //{
        //    VnoStr = Generalfunction.getnextidCondition("vno", "Tblgeneralledger", where);
        //}
        public void Delete(string Vno, string Vtype)
        {
            string Sql = "Delete From TblGeneralLedger Where Vno = '" + Vno + "' And Vtype = '" + Vtype + "'";
            _Dbtask.ExecuteNonQuery(Sql);
        }
        public double TottalAmountOfType(string Field, string VType, string Where)
        {
          double Tottal   = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(" + Field + ") from Tblgeneralledger where  VType='" + VType + "' " + Where + ""));
          return Tottal;
        }
        public string getspecificfeild(string ledcode, string Field)
        {
            SpecificField = _Dbtask.ExecuteScalar("select " + Field + " from tblgeneralledger where ledcode='" + ledcode + "' and vtype = 'OB'");
            return SpecificField;


        }
        public double getopeningbalancesupplier(string ledcode)
        {
            double opbalance = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select cramt-dbamt from tblgeneralledger where ledcode = '" + ledcode + "' and vtype = 'ob'"));
            return opbalance;
        }
        
        public double getopeningbalance(string ledcode)
        {
            double opbalance = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select dbamt-cramt from tblgeneralledger where ledcode = '" + ledcode + "' and vtype = 'ob'"));
            return opbalance;
        }
       


        public void DiscountPayInsert(string Purticulars,string CreditedAccount,double DbAmt1,double CrAmt1)
        {
            LedCodeStr = "15";
            PurticularsStr = Purticulars;
            DbAmtDb = DbAmt1;
            CrAmt = CrAmt1;
            InsertGeneralLedger();

            LedCodeStr = CreditedAccount;
            PurticularsStr =Purticulars;
            DbAmtDb = CrAmt1;
            CrAmt = DbAmt1;
            InsertGeneralLedger();
        }
        public void InsertAccountsDrSales(string Ledcode,string Purticulars, double DbAmt1, double CrAmt1,string SaleAccount)
        {
            LedCodeStr = Ledcode;
            PurticularsStr = Purticulars;
            DbAmtDb = DbAmt1;
            CrAmt = CrAmt1;
            RefnoStr = SaleAccount;
            InsertGeneralLedger();

        }

        public void InsertAccountsCrPurchase(string Ledcode, string Purticulars, double DbAmt1, double CrAmt1, string PurchaseAcount)
        {
            LedCodeStr = Ledcode;
            PurticularsStr = Purticulars;
            DbAmtDb = DbAmt1;
            CrAmt = CrAmt1;
            RefnoStr = PurchaseAcount;
            InsertGeneralLedger();

        }
        public string PurticularsCreateForLedger(string LblHeading, TextBox TextboxVno)
        {
            PurticularsStr = LblHeading + " vno:" + TextboxVno.Text;
            return PurticularsStr;
        }
        public string PurticularsCreate(TextBox TextboxAccount, TextBox TextboxVno)
        {
            if (TextboxAccount.Text == "")
                PurticularsStr = "Cash";
            else
                PurticularsStr = TextboxAccount.Text;

            PurticularsStr = PurticularsStr + " vno:" + TextboxVno.Text;
            return PurticularsStr;
        }
        public double SalesAmountofCustomer(string Cusid, DateTime Datefrom, DateTime DateTo)
        {
            return SaleAmt;
        
        }

        public double GADSALE(DateTime FROMDT, DateTime TODT)
                {
            double GADSALE = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt) from tblgeneralledger where vtype='si'and ledcode='1'  AND vdate between '" + FROMDT.ToString("MM/dd/yyyy  00:00:00") + "' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDSALEAMT = _Dbtask.znlldoubletoobject(GADSALE);
            return GDSALEAMT;
        }

        public double GADSALERETURN(DateTime FROMDT, DateTime TODT)
        {
            double GADSALE = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT SUM(AMT) FROM TBLTRANSACTIONRECEIPT WHERE RECPTTYPE='SR' AND Mpayment='0' and recptdate between '" + FROMDT.ToString("MM/dd/yyyy  00:00:00") + "' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDSALEAMT = _Dbtask.znlldoubletoobject(GADSALE);
            return GDSALEAMT;
        }



        public double GADpurchs(DateTime FROMDT, DateTime TODT)
        {
            double GADpur = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(cramt) from tblgeneralledger where vtype='pi'and ledcode='1'  AND vdate between '" + FROMDT.ToString("MM/dd/yyyy 00:00:00") + " ' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDpuramt = _Dbtask.znlldoubletoobject(GADpur);
            return GDpuramt;
        }
        public double GADpurchsRETURN(DateTime FROMDT, DateTime TODT)
        {
            double GADpur = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(DBamt) from tblgeneralledger where vtype='PR'and ledcode='1'  AND vdate between '" + FROMDT.ToString("MM/dd/yyyy 00:00:00") + " ' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDpuramt = _Dbtask.znlldoubletoobject(GADpur);
            return GDpuramt;
        }
        public double gadrecept(DateTime FROMDT, DateTime TODT)
        {
            double GADRECP = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT SUM(DBAMT) FROM TBLGENERALLEDGER WHERE VTYPE='R' AND LEDCODE='1' AND vdate between '" + FROMDT.ToString("MM/dd/yyyy 00:00:00") + " ' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDRCPAMT = _Dbtask.znlldoubletoobject(GADRECP);
            return GDRCPAMT;

        }

        public double gadPAYMNT(DateTime FROMDT, DateTime TODT)
        {
            double GADPAY = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT SUM(CRAMT) FROM TBLGENERALLEDGER WHERE VTYPE='P' AND LEDCODE='1' AND vdate between '" + FROMDT.ToString("MM/dd/yyyy 00:00:00") + " ' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDPAYAMT = _Dbtask.znlldoubletoobject(GADPAY);
            return GDPAYAMT;

        }

        public double gadbank(DateTime FROMDT, DateTime TODT)
        {
            double GADPAY = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT SUM(dbAMT) FROM TBLGENERALLEDGER where LEDCODE IN('24','28') AND vdate between '" + FROMDT.ToString("MM/dd/yyyy 00:00:00") + " ' and '" + TODT.ToString("MM/dd/yyyy 23:59:59") + "'"));
            double GDPAYAMT = _Dbtask.znlldoubletoobject(GADPAY);
            return GDPAYAMT;

        }



        public double gadclosng(DateTime datey)
        {
            string GADclose = _Dbtask.ExecuteScalar("select  sum(dbamt)-Sum(CrAmt)  from tblgeneralledger where ledcode='1' and vdate<='" + datey.ToString("MM/dd/yyyy 23:59:59") + "'");
            double GDclosamt = _Dbtask.znlldoubletoobject(GADclose);
            return GDclosamt;

        }


        public double gadopng(DateTime datey)
        {
            string GADclose = _Dbtask.ExecuteScalar("select  sum(dbamt) from tblgeneralledger where ledcode='1' and vdate<='" + datey.ToString("MM/dd/yyyy") + "'");
            double GDclosamt = _Dbtask.znlldoubletoobject(GADclose);
            return GDclosamt;

        }
        public bool CountLedgerTRansaction(string where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger "+where+"");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
