using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;

namespace WindowsFormsApplication2
{
    class ClsIssueDetails
    {
        public long IssueCodeLng;
        public long SlNoLng;
        public string PCodeStr = "";
        public long UnitIdLng=0;
        public string BatchIdStr="0";
        public int MultiRateIdLng=0;
        public double QtyDb=0;
        public double QtyFreeDb=0;
        public double RateDb=0;
        public double Mrp=0;
        public double DiscDb=0;
        public double BillDisc = 0;
        public double TaxRateDb=0;
        public double NetAmtDb=0;
        public string ItemNoteStr = "";
        public string Ledcode="";
        public string SlnoTracking = "";
        public string Vtype = "";
        public double Taxper = 0;
        public double Qty1 = 0;
        public double Qty2 = 0;
        public double CRate = 0;
        public double Length = 0;
        public double width = 0;
        public long Pnum = 0;
        public string Itemnote2 = "";


         public double billtot=0;
         public string billtime = "";
        public DateTime ExDate;
        public DateTime ManDate;
        string stringtemp;

        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        DataSet Ds2 = new DataSet();
        DataSet Ds3 = new DataSet();
        ClsBusinessIssue _BusinessIssue = new ClsBusinessIssue();

        public void InsertIssueDetailsPara(long IIssueCode,long ISlno,string IPcode,long IUnitid
           ,string IBatch,int IMrate,double IQty, double IQtyFree,double IMRp,double IRate,
            double IDisc,double IBillDisc,double ITaxRate,double INetAmt,string IItemnote,
            string ILedcode,string IVtype,double ITaxper,string ISlnoTracking,DateTime exdate,double billtotf,string billtimef)
        {

            IssueCodeLng = IIssueCode;                 
            SlNoLng=ISlno;
            PCodeStr=IPcode;
            UnitIdLng=IUnitid;
            BatchIdStr=IBatch;
            MultiRateIdLng=IMrate;
            QtyDb=IQty;
            QtyFreeDb=IQtyFree;
            Mrp=IMRp;
            RateDb=IRate;
            DiscDb=IDisc;
            BillDisc=IBillDisc;
            TaxRateDb=ITaxRate;
            NetAmtDb=INetAmt;
            ItemNoteStr=IItemnote;
            Ledcode=ILedcode;
            Vtype=IVtype;
            Taxper=ITaxper;
            SlnoTracking = ISlnoTracking;
            ExDate = exdate;
            billtot = billtotf;
            billtime=billtimef;
            InsertIssueDetails();
        }

        public void InsertIssueDetails()
        {
            object[,] objArg = new object[29, 2]
        {
            {"@issueCode",IssueCodeLng},                    
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdStr},
            {"@MultirateId",MultiRateIdLng},
            {"@Qty",QtyDb},  
            {"@Qty1",Qty1},  
            {"@Qty2",Qty2},
            {"@Pnum",Pnum},
            {"@freeQty",QtyFreeDb},
            {"@Mrp",Mrp},
            {"@CRate",CRate},
            {"@Rate",RateDb},
            {"@DiscRate",DiscDb},
            {"@Billdisc",BillDisc},
            {"@Taxrate",TaxRateDb},
            {"@NetAmt",NetAmtDb},
            {"@Itemnote",ItemNoteStr},
            {"@Ledcode",Ledcode},
            {"@vtype",Vtype},
            {"@Taxper",Taxper},
            {"@Lth",Length},
            {"@wth",width},
            {"@Slnotracking",SlnoTracking},
            {"@Itemnote2",Itemnote2},
            {"@Exdate",ExDate},
            {"@billtot",billtot},
            {"@billtime",billtime}

        };
            _Dbtask.ExecuteNonQuery_SP("InsertIssueDetails", objArg);
       //    _Dbtask.ExecuteNonQueryAzureServer_SP("InsertIssueDetails", objArg);

            //bool isConnected = _Dbtask.IsInternetAvailable();
            //if (isConnected)
            //{
            //    _Dbtask.ExecuteNonQueryAzureServer_SP("InsertIssueDetails", objArg);
            //}
            //else
            //{
            //    MessageBox.Show("Please check your Internet Connection !");
            //}
            return;
        }
        public DataTable GetIssueDetailsDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("IssueCode", typeof(double));      // FLOAT in SQL
            dt.Columns.Add("Slno", typeof(double));           // FLOAT
            dt.Columns.Add("Pcode", typeof(string));          // NVARCHAR(100)
            dt.Columns.Add("UnitId", typeof(int));            // INT
            dt.Columns.Add("BatchId", typeof(string));        // NVARCHAR(100)
            dt.Columns.Add("MultiRateId", typeof(int));       // INT
            dt.Columns.Add("Qty", typeof(decimal));
            dt.Columns.Add("Qty1", typeof(decimal));
            dt.Columns.Add("Qty2", typeof(decimal));
            dt.Columns.Add("pnum", typeof(double));           // FLOAT
            dt.Columns.Add("FreeQty", typeof(decimal));
            dt.Columns.Add("Rate", typeof(decimal));
            dt.Columns.Add("Crate", typeof(decimal));
            dt.Columns.Add("DiscRate", typeof(decimal));
            dt.Columns.Add("Billdisc", typeof(decimal));
            dt.Columns.Add("TaxRate", typeof(decimal));
            dt.Columns.Add("mrp", typeof(decimal));
            dt.Columns.Add("Taxper", typeof(decimal));
            dt.Columns.Add("NetAMT", typeof(decimal));
            dt.Columns.Add("ItemNote", typeof(string));
            dt.Columns.Add("Ledcode", typeof(string));
            dt.Columns.Add("Vtype", typeof(string));
            dt.Columns.Add("lth", typeof(decimal));
            dt.Columns.Add("wth", typeof(decimal));
            dt.Columns.Add("Slnotracking", typeof(string));
            dt.Columns.Add("Exdate", typeof(DateTime));
            dt.Columns.Add("Itemnote2", typeof(string));
            dt.Columns.Add("billtot", typeof(decimal));
            dt.Columns.Add("billtime", typeof(string));


            return dt;
        }

        public void UpdateIssueDetails()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@issueCode",IssueCodeLng},
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdStr},
            {"@MultirteId",MultiRateIdLng},
            {"@Qty",QtyDb},  
            {"@freeQty",QtyFreeDb},
            {"@Rate",RateDb},
            {"@DiscRate",DiscDb},
              {"@Taxrate",TaxRateDb},
            {"@NetAmt",NetAmtDb},
            {"@Itemnote",ItemNoteStr}

        };
            _Dbtask.ExecuteNonQuery_SP("UpdateIssueDetails", objArg);
            return;
        }

        public void DeleteIssueDetails()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@issueCode",IssueCodeLng},
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdStr},
            {"@MultirteId",MultiRateIdLng},
            {"@Qty",QtyDb},  
            {"@freeQty",QtyFreeDb},
            {"@Rate",RateDb},
            {"@DiscRate",DiscDb},
              {"@Taxrate",TaxRateDb},
            {"@NetAmt",NetAmtDb},
            {"@Itemnote",ItemNoteStr}

        };
            _Dbtask.ExecuteNonQuery_SP("DeleteIssueDetails", objArg);
            return;
        }
        public void IdIssueDetails()
        {
            IssueCodeLng = Convert.ToInt64(Generalfunction.getnextid("issuecode", "TblIssuedetails"));
        }

        //public double TottalAmountOfType(string Field, string VType, string Where)
        //{
        //    AMTDb = Convert.ToDouble(_Dbtask.ExecuteScalar("select sum(" + Field + ") from tblissuedetails where  RecptType='" + VType + "' " + Where + ""));
        //    return AMTDb;
        //}
        
        public double GetDiscAmt(string Where)
        {
            Ds= _Dbtask.ExecuteQuery("SELECT       SUM(TblIssuedetails.DiscRate) AS Discamt "+
                    " FROM    TblBusinessIssue INNER JOIN TblIssuedetails ON TblBusinessIssue.IssueCode = "+
             " TblIssuedetails.IssueCode group by TblIssuedetails.Pcode,tblbusinessissue.issuedate " + Where + "");

            DataTable table;
            table = Ds.Tables[0];
            object sumObject;

            sumObject = table.Compute("Sum(Discamt)", "");
            if (Ds.Tables[0].Rows.Count == 0)
                return 0;

            return _Dbtask.znullDouble(sumObject.ToString());
        }

        public DataSet Show(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblIssuedetails " + Where + "");
            return Ds;
        }
        public double TottalAmountOfType(string Field, string VType, string Where)
        {
            //string ammtt = "";
            //ammtt = _Dbtask.ExecuteScalar("select sum(" + Field + ") from tblbusinessissue where  IssueType='" + VType + "'      " + Where + "").ToString();
            //AMTDb = _Dbtask.znlldoubletoobject(ammtt);
            ////AMTDb = _Dbtask.SetintoDecimalpoint(AMTDb);

            //return AMTDb;
            return 0;
        }
         public DataSet ShowAccountsSales(string Where,string ProductCode,string LedCode,string Bcode)
        {

            Ds = _BusinessIssue.ShowBusinessIssue(" * ", Where);
            object[] Temp = new object[Ds.Tables[0].Rows.Count];
            stringtemp = "";
             for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Temp[i] = Ds.Tables[0].Rows[i]["Issuecode"];
                stringtemp += Temp[i] + ",";
                if (Ds.Tables[0].Rows.Count - 1 == i)
                    stringtemp = stringtemp.Substring(0, stringtemp.Length - 1);

            }
             if(Bcode !="")
                 Ds2=Show("where pcode='"+ProductCode+"' and issuecode in("+stringtemp+") and batchid='"+Bcode+"'");
             else
                 Ds2 = Show("where pcode='" + ProductCode + "' and issuecode in(" + stringtemp + ")");

           return Ds2;
         }
    }
}
