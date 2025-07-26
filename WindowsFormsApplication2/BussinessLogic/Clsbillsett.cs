using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clsbillsett
    {
        double Amt;

        public string Vno;
        public string Vtype;
        public long Ledcode;
        public long Emp = 0;
        public double Dbamt;
        public double Cramt;
        public string Agvno;
        public DateTime Dt;
        public string due = "";
        int count;

        DataSet Ds1;

        DBTask _Dbtask = new DBTask();


        public void InsertBillsett()
        {
            object[,] objArg = new object[8, 2]
        {
            {"@vno",Vno},
            {"@vtype",Vtype},  
            {"@ledcode",Ledcode},
            {"@dbamt",Dbamt},  
            {"@cramt",Cramt},
            {"@agvno",Agvno},
            {"@Dt",Dt},
            {"@Due",due}
           
        };
            _Dbtask.ExecuteNonQuery_SP("InsertBillsett", objArg);
            return;
        }


        public string GETfeildBYSALE(string agvno, string ledcode, string feild)
        {
           string ansr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select  "+feild+"  from tblbillsett where ledcode='"+ledcode+"' and agvno='" + agvno + "' and vtype='R' "));
      

           return ansr;
        }
        public string GETfeildBYSALEAMT(string agvno, string ledcode, string feild)
        {
            string ansr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select  SUM(" + feild + ")  from tblbillsett where ledcode='" + ledcode + "' and agvno='" + agvno + "' and vtype='R' "));


            return ansr;
        }


        public void InsertBillsettlement(string Pvno, string Pvtype, long PLedcode, double PDbamt, double PCramt, string PAgvno, DateTime Pdt, int PEmp,string dueday)
        {
            if (PLedcode != 1)
            {
                Vno = Pvno;
                Vtype = Pvtype;
                Ledcode = PLedcode;
                Dbamt = PDbamt;
                Cramt = PCramt;
                Agvno = PAgvno;
                Dt = Pdt;
                Emp = PEmp;
                due = dueday;
                InsertBillsett();
            }
        }


        public void FillCombocustmrbill(bool All, string FPartyid, ComboBox Comb)
        {
            _Dbtask.fillDatainCombowithQuery1(Comb, "vno", "tblbillsett", "select * from tblbillsett where ledcode ='" + FPartyid + "' and vtype='si' ");
        }


        public double IsshowBill(string PLedcode, string PAgvno, DateTime PdateFrom, DateTime Pdateto, string Pemp)
        {


            if (PAgvno == "" || PAgvno == null)
            {
                if (Pemp == "" || Pemp == null)
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(cramt-dbamt) from tblbillsett where ledcode='" + PLedcode + "' and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' "));
                }
                else
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(cramt-dbamt) from tblbillsett where ledcode='" + PLedcode + "' and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") "));
                }
            }
            else
            {
                if (Pemp == "" || Pemp == null)
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from tblbillsett where ledcode='" + PLedcode + "' and agvno='" + PAgvno + "'  and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' "));
                }
                else
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(dbamt),0) from tblbillsett where ledcode='" + PLedcode + "' and agvno='" + PAgvno + "'  and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") "));
                }
            }


            return Amt;

            return Amt;
        }

        public double correspondngSR(string AGVNO, string ledcode1)
        {
            double SR = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(cramt) from tblbillsett where vtype='sr' and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double sramt = _Dbtask.znlldoubletoobject(SR);

            return sramt;
        }
        public double correspondngRamt(string AGVNO, string ledcode1)
        {
            double SR = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt) from tblbillsett where VTYPE='R' and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double sramt = _Dbtask.znlldoubletoobject(SR);

            return sramt;
        }

        public double correspondngCHQRamt(string AGVNO, string ledcode1)
        {
            double CHQ = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt) from tblbillsett where vtype='ChR'  and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double CHQsramt = _Dbtask.znlldoubletoobject(CHQ);

            return CHQsramt;
        }


        public DataSet ShowBillsett(string PLedcode, string PVtype, DateTime Pdatefrom, DateTime Pdateto, string Pemp)
        {
            if (Vtype == "")
            {
                if (Pemp == "" || Pemp == null)
                {
                    return _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + PLedcode + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59'  order by dt asc");
                }
                else
                {
                    return _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + PLedcode + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") order by dt asc");
                }
            }

            if (Pemp == "" || Pemp == null)
            {
                return _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + PLedcode + "' and vtype='" + PVtype + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' order by dt asc");
            }
            else
            {
                return _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + PLedcode + "' and vtype='" + PVtype + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in (" + Pemp + ") order by dt asc");
            }
        }


        public void showcustmrbillss(DataGridView Grid, string PLedcode)
        {

            string Bvno;
            double Bamt;
            double SRAMTT = 0;
            double RAMOUNTS = 0;
            double totalrecamt = 0;

            double finalamts = 0;

            Grid.Rows.Clear();
            Grid.Columns.Clear();

            Grid.Columns.Add("clnvno", "vno");
            Grid.Columns["clnvno"].Width = 70;

            Grid.Columns.Add("clnbalamt", "Balance");
            Grid.Columns["clnbalamt"].Width = 100;

            Grid.Columns.Add("clnamt", "Amt");
            Grid.Columns["clnamt"].Width = 150;
            DataSet ds2 = _Dbtask.ExecuteQuery("select * from tblbillsett where ledcode='" + PLedcode + "' and vtype='si' ");
            for (int k = 0; k < ds2.Tables[0].Rows.Count; k++)
            {
                Bvno = ds2.Tables[0].Rows[k]["vno"].ToString();
                Bamt = _Dbtask.znlldoubletoobject(ds2.Tables[0].Rows[k]["cramt"]);
                SRAMTT = correspondngSR(Bvno, PLedcode);

                RAMOUNTS = correspondngRamt(Bvno, PLedcode);
                totalrecamt = SRAMTT + RAMOUNTS;


                if (Bamt != totalrecamt)
                {
                    if (Bamt > totalrecamt)
                    {
                        finalamts = Bamt - totalrecamt;
                        count = Grid.Rows.Add(1);
                        Grid.Rows[count].Cells["clnvno"].Value = Bvno;

                        Grid.Rows[count].Cells["clnbalamt"].Value = finalamts;

                    }

                }

            }

            Grid.Rows.Add(1);

        }
        public void DeleteBillSett(string Vtype, string Vno)
        {
            string Qry = "Delete From TblBillSett Where Vno = " + Vno + " And Vtype = '" + Vtype + "'";
            _Dbtask.ExecuteNonQuery(Qry);
        }
        public double GetBillWiseBalence(string Vno)
        {
            string Sql = "select IsNull(sum(Dbamt),0) from tblbillsett where agvno = '" + Vno + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));

            string Sql2 = "select IsNull(sum(CRAMT),0) from tblbillsett where agvno = '" + Vno + "' AND vtype='sr'";
            double RETNAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql2));

            double BAmt = CommonClass._Businessissue.GetTotalAmt(Vno, "SI");
            BAmt = BAmt - (GvnAmt + RETNAmt);

            return BAmt;
        }
        public double getbilladjustment(string vno, string ledcode)
        {
            //double bmt = 0;
            string bamounts = _Dbtask.ExecuteScalar("select IsNull(sum(dbamt),0) from tblbillsett where agvno ='" + vno + "' and vtype = 'BA' AND LEDCODE ='" + ledcode + "'");

            return _Dbtask.znlldoubletoobject(bamounts);
        }
        public double GetTotalSalesReturnAgainstBii(string AgVno)
        {
            string Sql = "Select IsNull(Sum(DbAmt),0) From TblBillSett Where Vtype = 'SR' And Agvno = '" + AgVno + "'";
            double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return Amt;

        }


        public double GetTotalReceiptAgainstVno(string Agvno)
        {
            string Sql = "Select IsNull(Sum(DbAmt),0) From TblBillSett Where (Vtype = 'ChR' Or Vtype = 'R') And Agvno = '" + Agvno + "'";
            double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return Amt;
        }

        public string GetSpecificField(string Vno, string Vtype, string Field)
        {
            string Sql = "Select " + Field + " from TblBillSett Where vno = '" + Vno + "' And Vtype = '" + Vtype + "'";
            return _Dbtask.ExecuteScalar(Sql);
        }

        public double isfullysettlbill(string vnod)
        {
            string Sql = "select IsNull(sum(Dbamt),0) from tblbillsett where agvno = '" + vnod + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));

            string SQL2 = "select IsNull(sum(CRAMT),0) from tblbillsett where agvno = '" + vnod + "' AND VTYPE='SR'";
            double RETNAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(SQL2));




            double BAmt = CommonClass._Businessissue.GetTotalAmt(vnod, "SI");

            BAmt = BAmt - (GvnAmt + RETNAmt);
            return BAmt;

        }
        public double recptamtedit(string vnoo, string agvno)
        {
            string Sql = "SELECT sum(dbamt) FROM TBLBILLSETT WHERE AGVNO='" + agvno + "' and vtype='r' and vno = '" + vnoo + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return GvnAmt;

        }


        public bool IsBillFullySettled(string vno)
        {
            string Sql = "select IsNull(sum(Dbamt),0) from tblbillsett where agvno = '" + vno + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));

            string SQL2 = "select IsNull(sum(CRAMT),0) from tblbillsett where agvno = '" + vno + "' AND VTYPE='SR'";
            double RETNAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(SQL2));




            double BAmt = CommonClass._Businessissue.GetTotalAmt(vno, "SI");

            BAmt = BAmt - (GvnAmt + RETNAmt);
            if (BAmt > 0)
            {
                return false;
            }
            return true;
        }

        public double billamountbyvno(string vnoss)
        {
            string sql1 = "SELECT SUM(CRAMT) FROM TBLBILLSETT WHERE VTYPE ='SI' AND VNO = '" + vnoss + "'";
            double vnobill = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(sql1));
            return vnobill;

        }




        public void FillpendingbillCombo(string ledcode, ComboBox Cmb)
        {
            Cmb.Items.Clear();
            string Sql = "Select (pvno+vno) As TempVno From TblBusinessIssue Where LedcodeDr = '" + ledcode + "' And Issuetype = 'SI'";
            DataSet DsVnoList = _Dbtask.ExecuteQuery(Sql);
            for (int i = 0; i < DsVnoList.Tables[0].Rows.Count; i++)
            {
                if (IsBillFullySettled(DsVnoList.Tables[0].Rows[i]["TempVno"].ToString()) == false)
                {
                    Cmb.Items.Add(DsVnoList.Tables[0].Rows[i]["TempVno"].ToString());
                }
            }

        }



        public void ShowbillBaseonledger(DataGridView Grid, string PLedcode, DateTime Pdate)
        {
            string Bvno;
            double Bamt;
            double BRecamt;
            DateTime BILLSDAT;
            double SRAMTT = 0;
            double RAMOUNTS = 0;
            double CHQAMOUNTS = 0;


            Grid.Rows.Clear();
            Grid.Columns.Clear();

            Grid.Columns.Add("clnvno", "vno");
            Grid.Columns["clnvno"].Width = 80;

            Grid.Columns.Add("clndate", "Date");
            Grid.Columns["clndate"].Width = 280;



            Grid.Columns.Add("clnsalesamt", "SaleAmt");
            Grid.Columns["clnsalesamt"].Width = 200;

            Grid.Columns.Add("clnrecamt", "ReceAmt");
            Grid.Columns["clnrecamt"].Width = 100;

            Grid.Columns.Add("clnSR", "SR");
            Grid.Columns["clnSR"].Width = 90;
            Grid.Columns["clnSR"].Visible = false;


            Grid.Columns.Add("clnbalamt", "Balance");
            Grid.Columns["clnbalamt"].Width = 100;


            DateTime frmod=Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());

            //if (IsshowBill(PLedcode,"",Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()),DateTime.Now,"")> 0)
            //{
            Ds1 = CommonClass._BillSett.ShowBillsett(PLedcode, "SI", frmod, DateTime.Now, "");
            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
            {
                Bvno = Ds1.Tables[0].Rows[k]["vno"].ToString();
                BILLSDAT = _Dbtask.ZnullDatetime(Ds1.Tables[0].Rows[k]["Dt"].ToString());
                string BILLSDATee = Convert.ToString(BILLSDAT).Substring(0, 11);


                SRAMTT = correspondngSR(Bvno, PLedcode);

                RAMOUNTS = correspondngRamt(Bvno, PLedcode);
                Bamt = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["cramt"]);
                CHQAMOUNTS = correspondngCHQRamt(Bvno, PLedcode);

                BRecamt = CommonClass._BillSett.IsshowBill(PLedcode, Bvno, frmod, DateTime.Now, "");
                if (Bamt > BRecamt)
                {
                    string PartyName = CommonClass._Ledger.GetspecifField("lname", PLedcode);
                    count = Grid.Rows.Add(1);
                    Grid.Rows[count].Cells["clnvno"].Value = Bvno;
                    Grid.Rows[count].Cells["clndate"].Value = BILLSDATee.ToString();
                    double KFinaBalance=0;
                    KFinaBalance = Bamt;
                    Grid.Rows[count].Cells["clnsalesamt"].Value = Bamt;
                    Grid.Rows[count].Cells["clnrecamt"].Value = BRecamt;

                    //Grid.Rows[count].Cells["clnSR"].Value = SRAMTT;

                    if (SRAMTT > 0)
                    {

                        KFinaBalance = KFinaBalance - SRAMTT;

                    }
                    if (RAMOUNTS > 0)
                    {
                        KFinaBalance = KFinaBalance - RAMOUNTS;

                    }
                    if (CHQAMOUNTS > 0)
                    {
                        KFinaBalance = KFinaBalance - CHQAMOUNTS;


                    }

                    Grid.Rows[count].Cells["clnbalamt"].Value = KFinaBalance;
                }
            }
            Grid.Rows.Add(1);
            //}
        }
    }
}