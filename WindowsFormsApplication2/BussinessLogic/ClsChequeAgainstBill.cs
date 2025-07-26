using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsChequeAgainstBill
    {
        public string BillVno = "";
        public string ChqVno = "";
        public string Vtype = "";
        public double Balence = 0;
        public double Amount = 0;


        public void InsertValues(string TempChqVno, string TempBillVno, string TempVtype, double TempBalence, double TempAmount)
        {
            BillVno = TempBillVno;
            ChqVno = TempChqVno;
            Vtype = TempVtype;
            Balence = TempBalence;
            Amount = TempAmount;
            InsertAgainstBill();
        }
        
        public DataSet GetSettleMentDetails(string TempVno,string TempVtype)
        {
            string Sql = "Select * From TblChequeAgainstBill Where ChqVno = '" + TempVno + "' And Vtype = '" + TempVtype + "'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            return Ds;
        }
        public void Delete(string TempVno, string TempVtype)
        {
            string Sql = "Delete From TblChequeAgainstBill Where ChqVno = '" + TempVno + "' And Vtype = '" + TempVtype + "'";
            CommonClass._Dbtask.ExecuteNonQuery(Sql);
        }
        public double GetUnCollectedAgAmount(string AgVno)
        {
            string Status = "";
            double Amt = 0;
            string Sql = "select * from TblChequeAgainstBill Where BillVno = '" + AgVno + "'";
            DataSet Ds = CommonClass._Dbtask.ExecuteQuery(Sql);
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Status = CommonClass._ClsCheque.GetSpesificField("Status", Ds.Tables[0].Rows[i]["ChqVno"].ToString(), "0");
                    if (Status == "Collected")
                    {
                        Ds.Tables[0].Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
            }
            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < Ds.Tables[0].Rows.Count; j++)
                {
                    Amt = Amt + CommonClass._Dbtask.znlldoubletoobject(Ds.Tables[0].Rows[j]["Amount"]);
                }
            }
            return Amt;
        }
        public void InsertAgainstBill()
        {
            object[,] objArg = new object[5, 2]
            {
                {"@ChqVno",ChqVno},
                {"@BillVno",BillVno},
                {"@Vtype",Vtype},
                {"@Balence",Balence},
                {"@Amount",Amount}
            };

            CommonClass._Dbtask.ExecuteNonQuery_SP("InsertChequeAgainstBill", objArg);
            return;
        }
        public void CreateTable()
        {
            string Sql = "CREATE TABLE [dbo].[TblChequeAgainstBill]( " +
                         "[ChqVno] [nvarchar](50) NULL, " +
                         "[BillVno] [nvarchar](50) NULL, " +
                         "[Vtype] [nvarchar](50) NULL, " +
                         "[Balence] [Decimal](18,5),  " +
                         "[Amount] [Decimal](18,5)  " +
                         " ) ON [PRIMARY]";

            CommonClass._Dbtask.ExecuteNonQuery(Sql);

            Sql = "  CREATE PROCEDURE [dbo].[InsertChequeAgainstBill] " +
                  "  @ChqVno nvarchar(50)," +
                  "  @BillVno nvarchar(50)," +
                  "  @Vtype nvarchar(50)," +
                  "  @Balence Decimal(18,5)," +
                  "  @Amount Decimal(18,5) " +
                  "  AS " +
                  "  BEGIN" +
                  "  insert into   TblChequeAgainstBill (ChqVno,BillVno,Vtype,Balence,Amount)" +
                  "  values (@ChqVno,@BillVno,@Vtype,@Balence,@Amount)" +
                  "  RETURN " +
                  "  END";

            CommonClass._Dbtask.ExecuteNonQuery(Sql);
        }
    }
}
