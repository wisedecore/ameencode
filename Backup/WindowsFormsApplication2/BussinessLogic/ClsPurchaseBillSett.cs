using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsPurchaseBillSett
    {
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        DBTask _Dbtask = new DBTask();
        int count = 0;

        public DateTime Date = DateTime.Now;
        public string Vno = "";
        public string Vtype = "";
        public string LedCode = "";
        public double DbAmt = 0;
        public double CrAmt = 0;
        public string AgVno = "";


        public void InsertBillSet(DateTime Date, string Vno, string Vtype, string LedCode, double DbAmt, double CrAmt, string AgVno)
        {
            this.Date = Date;
            this.Vno = Vno;
            this.Vtype = Vtype;
            this.LedCode = LedCode;
            this.DbAmt = DbAmt;
            this.CrAmt = CrAmt;
            this.AgVno = AgVno;

            InsertBillSet();
        }

        public void InsertBillSet()
        {
            object[,] objArg = new object[7, 2]
              {
                {"@Date",Date},
                {"@Vno",Vno},
                {"@Vtype",Vtype},
                {"@LedCode",LedCode},
                {"@DbAmt",DbAmt},
                {"@CrAmt",CrAmt},
                {"@AgVno",AgVno}
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("InsertPurchaseBillSett", objArg);
            return;
        }
        public double GetBillWiseBalence(string Vno)
        {
            string Sql = "select IsNull(sum(Dbamt),0) from TblPurchaseBillSett where agvno = '" + Vno + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));

            double BAmt = CommonClass._Transactionreceipt.GetTotalAmt(Vno, "PI");
            return BAmt - GvnAmt;
        }
        public DataSet GetPendingBillListOfSupplier(string LedCode)
        {
            DataSet Ds = _TransactionReceipt.GetSupplierBasedBillList(LedCode);

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (IsBillFullySettled(Ds.Tables[0].Rows[i]["Vno"].ToString()) == true)
                {
                    Ds.Tables[0].Rows.RemoveAt(i);
                    i = i - 1;
                }

            }
            return Ds;
        }
        //public DataSet GetSupplierBasedBillList(string LedCode)
        //{
        //    DataSet Ds = GetCreditBillList();
        //    string LedDr = "";
        //    string TVno = "";
        //    string TVtype = "";

        //    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
        //    {
        //        LedDr = Ds.Tables[0].Rows[i]["LedCodeDr"].ToString();
        //        TVno = Ds.Tables[0].Rows[i]["Vno"].ToString();
        //        TVtype = Ds.Tables[0].Rows[i]["RecptType"].ToString();

        //        if (GetSpecificField("LedCodeCr", TVno, TVtype, LedDr) != LedCode)
        //        {
        //            Ds.Tables[0].Rows.RemoveAt(i);
        //            i = i - 1;
        //        }
        //    }
        //    return Ds;
        //}


        public void FillPendingBillInCombo(ComboBox Cmb, string Supplier)
        {
            Cmb.Items.Clear();

            if (Supplier == "1")
            {
                return;
            }

            DataSet Ds = GetPendingBillListOfSupplier(Supplier);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Cmb.Items.Add(Ds.Tables[0].Rows[i]["Vno"]);
            }
        }
        public DataSet GetPendingBillList()
        {
            DataSet Ds = _TransactionReceipt.GetCreditBillList();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (IsBillFullySettled(Ds.Tables[0].Rows[i]["Vno"].ToString()) == true)
                {
                    Ds.Tables[0].Rows.RemoveAt(i);
                    i = i - 1;
                }

            }
            return Ds;
        }
        public double GetTotalPurchaseReturnAgainstBii(string AgVno)
        {
            string Sql = "Select IsNull(Sum(DbAmt),0) From TblPurchaseBillSett Where Vtype = 'PR' And Agvno = '" + AgVno + "'";
            double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return Amt;

        }
        public double GetTotalPaymentAgainstVno(string Agvno)
        {
            string Sql = "Select IsNull(Sum(DbAmt),0) From TblPurchaseBillSett Where (Vtype = 'ChP' Or Vtype = 'P') And Agvno = '" + Agvno + "'";
            double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return Amt;
        }
        public string GetSpecificField(string Vno, string Vtype, string Field)
        {
            string Sql = "Select " + Field + " from TblPurchaseBillSett Where vno = " + Vno + " And Vtype = '" + Vtype + "'";
            return _Dbtask.ExecuteScalar(Sql);
        }
        public bool IsBillFullySettled(string vno)
        {
            string Sql = "select IsNull(sum(Dbamt),0) from TblPurchaseBillSett where agvno = '" + vno + "'";
            double GvnAmt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));

            //double BAmt = CommonClass._Businessissue.GetTotalAmt(vno, "SI");
            double BAmt = CommonClass._Transactionreceipt.GetTotalAmt(vno, "PI");
            if (GvnAmt < BAmt)
            {
                return false;
            }
            return true;
        }
        public DataSet GetPendingBillList(string Ledcode)
        {
            string Sql = "Select vno As TempVno From TblTransactionReceipt Where LedcodeCr = '" + Ledcode + "' And RecptType = 'PI'";
            DataSet DsVnoList = _Dbtask.ExecuteQuery(Sql);
            for (int i = 0; i < DsVnoList.Tables[0].Rows.Count; i++)
            {
                if (IsBillFullySettled(DsVnoList.Tables[0].Rows[i]["TempVno"].ToString()) == true)
                {
                    DsVnoList.Tables[0].Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            return DsVnoList;
        }
        //public string GetSpecificField(string Vno, string Vtype, string Field)
        //{
        //    string Sql = "Select " + Field + " from TblPurchaseBillSett Where vno = " + Vno + " And Vtype = '" + Vtype + "'";
        //    return _Dbtask.ExecuteScalar(Sql);
        //}
        //public string GetSpecificField(string Vno, string Vtype, string Field)
        //{
        //    string Sql = "Select " + Field + " from TblPurchaseBillSett Where vno = " + Vno + " And Vtype = '" + Vtype + "'";
        //    return _Dbtask.ExecuteScalar(Sql);
        //}
        public void ShowbillBaseonledger(DataGridView Grid, string PLedcode)
        {
            string Bvno;
            double Bamt;
            double BRecamt;
            double TotSr;
            DateTime Date;

            

            Grid.Rows.Clear();
            Grid.Columns.Clear();

            Grid.Columns.Add("ClnVno", "Vno");
            Grid.Columns["clnvno"].Width = 50;

            Grid.Columns.Add("ClnDate", "Date");
            Grid.Columns["ClnDate"].Width = 70;

            Grid.Columns.Add("ClnPurchaseAmt", "PurchaseAmt");
            Grid.Columns["ClnPurchaseAmt"].Width = 70;

            Grid.Columns.Add("clnPaidAmt", "PaidAmt");
            Grid.Columns["clnPaidAmt"].Width = 75;

            Grid.Columns.Add("ClnPR", "PR");
            Grid.Columns["ClnPR"].Width = 70;

            Grid.Columns.Add("ClnBalamt", "Balance");
            Grid.Columns["ClnBalamt"].Width = 75;

            //if (IsshowBill(PLedcode,"",Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()),DateTime.Now,"")> 0)
            //{
            //Ds1 = CommonClass._BillSett.ShowBillsett(PLedcode, "SI", Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()), DateTime.Now, "");

            DataSet Ds1 = GetPendingBillList(PLedcode);

            for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
            {
                Bvno = Ds1.Tables[0].Rows[k]["TempVno"].ToString();
                Bamt = _Dbtask.znlldoubletoobject(GetSpecificField(Bvno, "PI", "Cramt"));
                //BRecamt = CommonClass._BillSett.IsshowBill(PLedcode, Bvno, Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial()),DateTime.Now,"");

                BRecamt = GetTotalPaymentAgainstVno(Bvno);
                TotSr = GetTotalPurchaseReturnAgainstBii(Bvno);
                if (_Dbtask.znlldoubletoobject(Bvno) == 0)
                {
                    string TVno = Bvno.Substring(CommonClass._Paramlist.GetParamvalue("Sprefix").Length, (Bvno.Length - CommonClass._Paramlist.GetParamvalue("Sprefix").Length));
                    Date = Convert.ToDateTime(CommonClass._Businessissue.GetSpecificField("IssueDate", TVno, "SI", CommonClass._Ledger.ReturnLedid("Estimate")));
                }
                else
                {
                    Date = Convert.ToDateTime(CommonClass._Transactionreceipt.GetSpecificField("RecptDate", Bvno, "PI", "3"));
                }

                if (Bamt > (BRecamt + TotSr))
                {
                    string PartyName = CommonClass._Ledger.GetspecifField("lname", PLedcode);
                    count = Grid.Rows.Add(1);
                    Grid.Rows[count].Cells["clnvno"].Value = Bvno;
                    double KFinaBalance;
                    KFinaBalance = Bamt - BRecamt;
                    Grid.Rows[count].Cells["ClnDate"].Value = Date.ToString("dd/MM/yyyy");
                    Grid.Rows[count].Cells["ClnPurchaseAmt"].Value = _Dbtask.SetintoDecimalpoint(Bamt);
                    Grid.Rows[count].Cells["ClnPR"].Value = _Dbtask.SetintoDecimalpoint(TotSr);
                    Grid.Rows[count].Cells["clnPaidAmt"].Value = _Dbtask.SetintoDecimalpoint(BRecamt);
                    Grid.Rows[count].Cells["clnbalamt"].Value = GetBillWiseBalence(Bvno);
                }
            }
        }


        //public string GetSpecificField(string Vno, string Vtype, string Field)
        //{
        //    string Sql = "Select " + Field + " from TblPurchaseBillSett Where vno = " + Vno + " And Vtype = '" + Vtype + "'";
        //    return _Dbtask.ExecuteScalar(Sql);
        //}

        public void Delete(string Vno, string Vtype)
        {
            string Sql = "Delete From TblPurchaseBillSett Where Vno = '" + Vno + "' And Vtype = '" + Vtype + "'";
            //CommonClass._Dbtask.ExecuteNonQuery(Sql);
        }

        public void CreateTable()
        {
            string Sql = "CREATE TABLE [dbo].[TblPurchaseBillSett]( " +
                         "[Date] [DateTime],  " +
                         "[Vno] [nvarchar](50), " +
                         "[Vtype] [nvarchar](50), " +
                         "[LedCode] [nvarchar](50) , " +
                         "[DbAmt] [Decimal](18,5),  " +
                         "[CrAmt] [Decimal](18,5),  " +
                         "[AgVno] [nvarchar](50) , " +
                         " ) ON [PRIMARY]";

            CommonClass._Dbtask.ExecuteNonQuery(Sql);

            Sql = "  CREATE PROCEDURE [dbo].[InsertPurchaseBillSett] " +
                  "  @Date DateTime, " +
                  "  @Vno nvarchar(50), " +
                  "  @Vtype nvarchar(50), " +
                  "  @LedCode nvarchar(50), " +
                  "  @DbAmt Decimal(18,5), " +
                  "  @CrAmt Decimal(18,5), " +
                  "  @Agvno nvarchar(50) " +
                  "  AS " +
                  "  BEGIN" +
                  "  insert into   TblPurchaseBillSett (Date,Vno,Vtype,LedCode,DbAmt,CrAmt,AgVno) " +
                  "  values (@Date,@Vno,@Vtype,@LedCode,@DbAmt,@CrAmt,@AgVno)" +
                  "  RETURN " +
                  "  END";

            CommonClass._Dbtask.ExecuteNonQuery(Sql);

        }
    }
}
