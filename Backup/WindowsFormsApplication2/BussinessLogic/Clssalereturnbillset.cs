using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Clssalereturnbillset
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

        int count;

        DataSet Ds1;

        DBTask _Dbtask = new DBTask();


        public void InsertSRbillsett()
        {
            object[,] objArg = new object[7, 2]
        {
            {"@vno",Vno},
            {"@vtype",Vtype},  
            {"@ledcode",Ledcode},
            {"@dbamt",Dbamt},  
            {"@cramt",Cramt},
            {"@agvno",Agvno},
            {"@Dt",Dt}
           
        };
            _Dbtask.ExecuteNonQuery_SP("InsertSRbillsett", objArg);
            return;
        }


        public string GETfeildBYSRSETTILE(string agvno, string ledcode, string feild)
        {
            string ansr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select  " + feild + "  from tblSRbillsett where ledcode='" + ledcode + "' and agvno='" + agvno + "' and vtype='P' "));


            return ansr;
        }

        public string GETfeildBYSRSETTILEAMT(string agvno, string ledcode, string feild)
        {
            string ansr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select  SUM(" + feild + ")  from tblSRbillsett where ledcode='" + ledcode + "' and agvno='" + agvno + "' and vtype='P' "));


            return ansr;
        }


        public void InsertSRBillsettlement(string Pvno, string Pvtype, long PLedcode, double PDbamt, double PCramt, string PAgvno, DateTime Pdt, int PEmp)
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
                InsertSRbillsett();
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



            Grid.Columns.Add("clnsalesamt", "SRAmt");
            Grid.Columns["clnsalesamt"].Width = 200;

            Grid.Columns.Add("clnrecamt", "PaymentAmt");
            Grid.Columns["clnrecamt"].Width = 100;

            Grid.Columns.Add("clnSR", "SR");
            Grid.Columns["clnSR"].Width = 90;
            Grid.Columns["clnSR"].Visible = false;


            Grid.Columns.Add("clnbalamt", "Balance");
            Grid.Columns["clnbalamt"].Width = 100;


            DateTime frmod = Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());

            //if (IsshowBill(PLedcode,"",Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()),DateTime.Now,"")> 0)
            //{
            Ds1 = ShowBillsett(PLedcode, "SR", frmod, DateTime.Now, "");
            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
            {
                Bvno = Ds1.Tables[0].Rows[k]["vno"].ToString();
                BILLSDAT = _Dbtask.ZnullDatetime(Ds1.Tables[0].Rows[k]["Dt"].ToString());
                string BILLSDATee = Convert.ToString(BILLSDAT).Substring(0, 11);


                SRAMTT = correspondngSR(Bvno, PLedcode);

                RAMOUNTS = correspondngRamt(Bvno, PLedcode);
                Bamt = _Dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[k]["dbamt"]);//cr
                CHQAMOUNTS = correspondngCHQRamt(Bvno, PLedcode);

                BRecamt = IsshowBill(PLedcode, Bvno, frmod, DateTime.Now, "");
                if (Bamt > BRecamt)
                {
                    string PartyName = CommonClass._Ledger.GetspecifField("lname", PLedcode);
                    count = Grid.Rows.Add(1);
                    Grid.Rows[count].Cells["clnvno"].Value = Bvno;
                    Grid.Rows[count].Cells["clndate"].Value = BILLSDATee.ToString();
                    double KFinaBalance = 0;
                    KFinaBalance = Bamt;
                    Grid.Rows[count].Cells["clnsalesamt"].Value = Bamt;
                    Grid.Rows[count].Cells["clnrecamt"].Value = BRecamt;

                    //Grid.Rows[count].Cells["clnSR"].Value = SRAMTT;

                    if (SRAMTT > 0)
                    {

                        KFinaBalance = KFinaBalance + SRAMTT;

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

        public DataSet ShowBillsett(string PLedcode, string PVtype, DateTime Pdatefrom, DateTime Pdateto, string Pemp)
        {
            if (Vtype == "")
            {
                if (Pemp == "" || Pemp == null)
                {
                    return _Dbtask.ExecuteQuery("select * from tblSRbillsett where ledcode='" + PLedcode + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59'  order by dt asc");
                }
                else
                {
                    return _Dbtask.ExecuteQuery("select * from tblSRbillsett where ledcode='" + PLedcode + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") order by dt asc");
                }
            }

            if (Pemp == "" || Pemp == null)
            {
                return _Dbtask.ExecuteQuery("select * from tblSRbillsett where ledcode='" + PLedcode + "' and vtype='" + PVtype + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' order by dt asc");
            }
            else
            {
                return _Dbtask.ExecuteQuery("select * from tblSRbillsett where ledcode='" + PLedcode + "' and vtype='" + PVtype + "' and dt between '" + Pdatefrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in (" + Pemp + ") order by dt asc");
            }
        }
        public double IsshowBill(string PLedcode, string PAgvno, DateTime PdateFrom, DateTime Pdateto, string Pemp)
        {


            if (PAgvno == "" || PAgvno == null)
            {
                if (Pemp == "" || Pemp == null)
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(cramt-dbamt) from tblSRbillsett where ledcode='" + PLedcode + "' and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' "));
                }
                else
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select sum(cramt-dbamt) from tblSRbillsett where ledcode='" + PLedcode + "' and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") "));
                }
            }
            else
            {
                if (Pemp == "" || Pemp == null)
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(CRamt),0) from tblSRbillsett where ledcode='" + PLedcode + "' and agvno='" + PAgvno + "'  and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' "));
                }
                else
                {
                    Amt = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(CRamt),0) from tblSRbillsett where ledcode='" + PLedcode + "' and agvno='" + PAgvno + "'  and dt between '" + PdateFrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdateto.ToString("MM-dd-yyyy") + " 23:59:59' and emp in(" + Pemp + ") "));
                }
            }


            return Amt;

            return Amt;
        }

        public double correspondngSR(string AGVNO, string ledcode1)
        {
            double SR = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(dbamt) from tblSRbillsett where vtype='SR' and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double sramt = _Dbtask.znlldoubletoobject(SR);

            return sramt;
        }
        public double correspondngRamt(string AGVNO, string ledcode1)
        {
            double SR = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(CRamt) from tblSRbillsett where VTYPE='P' and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double sramt = _Dbtask.znlldoubletoobject(SR);

            return sramt;
        }

        public double correspondngCHQRamt(string AGVNO, string ledcode1)
        {
            double CHQ = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select sum(CRamt) from tblSRbillsett where vtype='ChR'  and agvno='" + AGVNO + "' and ledcode='" + ledcode1 + "'"));
            double CHQsramt = _Dbtask.znlldoubletoobject(CHQ);

            return CHQsramt;
        }




    }
}
