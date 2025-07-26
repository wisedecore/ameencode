using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class Clscheque
    {
        public long Id;
        public DateTime PDate;
        public long ALid;
        public long BLid;
        public double Amount;
        public string ChequeNo;
        public string Status;
        public DateTime CDate;
        public DateTime CollDate;
        public string Note;
        public int CMode;
        public long GenId;
        public string Agvno;
        public double DISAmount;

        public double totalAmount;
        public long Emp = 0;
        public string GetVno1()
        {
            return Convert.ToString(Generalfunction.getnextidCondition("id", "Tblchqreceived", " "));
        }
        public int GetMax(string Mode)
        {
            string Sql = "Select IsNull(Max(Id)+1,1) From Tblchqreceived Where CMode = " + Mode;
            int m = Convert.ToInt32(CommonClass._Dbtask.ExecuteScalar(Sql));
            return m;
        }
        public string GetSpesificField(string Field, string TempId, string TempCMode)
        {
            string Sql = "select " + Field + " from TblChqreceived where CMode = " + TempCMode + " And Id = " + TempId;
            return CommonClass._Dbtask.ExecuteScalar(Sql);
        }
        public bool ShowChequePayholding()
        {
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tblchqreceived where cmode='1' and status='Holding'");
            if (CommonClass.Ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }

        public bool ShowChequeRecholding()
        {
            CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tblchqreceived where cmode='0' and status='Holding'");
            if (CommonClass.Ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
        public DataSet GetChequeList(string Where)
        {
            DataSet Ds;
            Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tblchqreceived " + Where + "");
            return Ds;
        }

        public DataSet Show(string Where)
        {
            DataSet Ds;
            Ds = CommonClass._Dbtask.ExecuteQuery("select * from Tblchqreceived " + Where + "");
            return Ds;
        }

        public void InsertCheque()
        {
            object[,] ObjArg = new object[16, 2]
            {
            {"@id",Id},
            {"@PDate",PDate},
            {"@ALid",ALid},  
            {"@BLid",BLid},
            {"@Amount",Amount},
            {"@ChequeNo",ChequeNo},
            {"@CDate",CDate},
            {"@Status",Status},  
            {"@Note",Note},
            {"@CMode",CMode},
            {"@CollDate",CollDate},
            {"@Genid",GenId},
            {"@Discount",DISAmount},
            {"@Emp",Emp},
            {"@Agvno",Agvno},
            {"@TotAmt",totalAmount}

        };
            CommonClass._Dbtask.ExecuteNonQuery_SP("Insertchequereceived", ObjArg);
            return;
        }
        public void DeleteCheque(string TempId, string TempMode)
        {
            string Sql = "Delete From Tblchqreceived Where Id = " + TempId + " And CMode = " + TempMode;
            CommonClass._Dbtask.ExecuteNonQuery(Sql);

            if (TempMode == "0")
            {
                CommonClass._GenLedger.Delete(TempId, "ChR");
                //CommonClass._ChequeAgainstBill.Delete(TempId, "ChR");
                CommonClass._BillSett.DeleteBillSett("ChR", TempId);
            }
            if (TempMode == "1")
            {
                CommonClass._GenLedger.Delete(TempId, "ChP");
                //CommonClass._PurchaseBillSett.Delete(TempId, "Chp");
                CommonClass._ChequeAgainstBill.Delete(TempId, "ChP");
            }
        }
        public void CreateTable()
        {
           string sql = "CREATE TABLE [dbo].[Tblchqreceived]( " +
               " [Id] [float], " +
               " [Pdate] [datetime] NULL, " +
               " [Alid] [float] NULL, " +
               " [Blid] [float] NULL, " +
               " [Amount] [decimal](18, 5) NULL, " +
               " [ChequeNo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [Status] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [CDate] [datetime] NULL, " +
               " [Note] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, " +
               " [CMode] Int, " +
               " [CollDate] [datetime] NULL, " +
               " [Genid] float " +
               " ) ON [PRIMARY]";
            CommonClass._Dbtask.ExecuteNonQuery(sql);


            sql = "create PROCEDURE [dbo].[Insertchequereceived]" +
                      "@Id float," +
                      "@Pdate datetime," +
                      "@Alid float," +
                      "@Blid float," +
                      "@Amount [decimal](18, 5)," +
                      "@ChequeNo [nvarchar](50)," +
                      "@Status [nvarchar](50)," +
                      "@CDate datetime," +
                      "@CollDate datetime," +
                      "@Note [nvarchar](50)," +
                      "@CMode int," +
                      "@Genid float" +
                      " AS" +
                      " BEGIN" +
                      " insert into Tblchqreceived(Id,Pdate,Alid,Blid,Amount,ChequeNo," +
                      " Status,CDate,CollDate,Note,CMode,Genid " +
                      " ) values (@Id,@Pdate,@Alid,@Blid,@Amount,@ChequeNo,@Status,@CDate,@CollDate,@Note,@CMode,@Genid)" +
                      " END";
            CommonClass._Dbtask.ExecuteNonQuery(sql);
        }
    }
}
