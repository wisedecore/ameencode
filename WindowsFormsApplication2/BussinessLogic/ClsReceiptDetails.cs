using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;

namespace WindowsFormsApplication2
{
    class ClsReceiptDetails
    {
        public long RcptCodeLng;
        public long SlNoLng;
        public string PCodeStr = "";
        public long UnitIdLng=Convert.ToInt64(0);
        public string BatchIdstr="";
        public long MultiRateIdLng=Convert.ToInt64(0);
        public double QtyDb=0;
        public double QtyFreeDb=0;
        public double RateDb=0;
        public double DiscDb=0;
        public double TaxRateDb=0;
        public double NetAmtDb=0;
        public double CRate=0;
        public double SRate=0;
        public double Mrp=0;
        public double BillDisc = 0;
        public double profit = 0;
        public double ExciseDuty = Convert.ToDouble(0);
        public double Wrate = 0;
        public string ItemNoteStr = "";
        public string ItemNoteStr2 = "";
        public string Ledcode="0";
        public long TaxId =Convert.ToInt64(0);
        public string Vtype="";
        public double Taxper = 0;
        public DateTime DtExdate=Convert.ToDateTime("01-01-1900");
        public DateTime Dtmandate=Convert.ToDateTime("01-01-1900");
        bool Yes;
        public double billtot = 0;
        DBTask _Dbtask = new DBTask();
        ClsTransactionRceipt _TransactionReceipt = new ClsTransactionRceipt();
        DataSet Ds = new DataSet();
        DataSet Ds2 = new DataSet();
        public string stringtemp;
        public void InsertReceiptDetails()
        {

            object[,] objArg = new object[27, 2]
        {
            {"@RecptCode",RcptCodeLng},
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdstr},
            {"@MultirateId",MultiRateIdLng},
            {"@Qty",QtyDb},  
            {"@freeQty",QtyFreeDb},
            {"@Rate",RateDb},
            {"@DiscRate",DiscDb},
            {"@Billdisc",BillDisc},
            {"@profit",profit},
            {"@Taxrate",TaxRateDb},
            {"@NetAmt",NetAmtDb},
            {"@Itemnote",ItemNoteStr},
            {"@Itemnote1",ItemNoteStr2},
            {"@mandate",Dtmandate},
            {"@exdate",DtExdate},
            {"@Srate",SRate},
            {"@crate",CRate},
            {"@Mrp",Mrp},
            {"@Ledcode",Ledcode},
            {"@vtype",Vtype},
            {"@Taxper",Taxper},
            {"@exciseduty",ExciseDuty},
             {"@wrate",Wrate},
             {"@billtot",billtot}


        };
            _Dbtask.ExecuteNonQuery_SP("InsertReceiptDetails", objArg);

            //bool isConnected = _Dbtask.IsInternetAvailable();
            //if (isConnected)
            //{
            //    _Dbtask.ExecuteNonQueryAzureServer_SP("InsertReceiptDetails", objArg);
            //}
            //else
            //{
            //    MessageBox.Show("Please check your Internet Connection !");
            //}
            return;
        }


        public DataTable ReceiptdetailDataBulk()
        {
          
            DataTable dtReceiptDetails = new DataTable();

            dtReceiptDetails.Columns.Add("RecptCode", typeof(double));       // FLOAT
            dtReceiptDetails.Columns.Add("Slno", typeof(int));               // INT
            dtReceiptDetails.Columns.Add("Pcode", typeof(string));           // NVARCHAR(100)
            dtReceiptDetails.Columns.Add("UnitId", typeof(string));          // NVARCHAR(100)
            dtReceiptDetails.Columns.Add("BatchId", typeof(string));         // NVARCHAR(100)
            dtReceiptDetails.Columns.Add("MultiRateId", typeof(int));        // INT
            dtReceiptDetails.Columns.Add("Qty", typeof(decimal));            // DECIMAL(18,5)
            dtReceiptDetails.Columns.Add("FreeQty", typeof(decimal));
            dtReceiptDetails.Columns.Add("Rate", typeof(decimal));
            dtReceiptDetails.Columns.Add("DiscRate", typeof(decimal));
            dtReceiptDetails.Columns.Add("Billdisc", typeof(decimal));
            dtReceiptDetails.Columns.Add("Profit", typeof(decimal));
            dtReceiptDetails.Columns.Add("TaxRate", typeof(decimal));
            dtReceiptDetails.Columns.Add("NetAMT", typeof(decimal));
            dtReceiptDetails.Columns.Add("ItemNote", typeof(string));
            dtReceiptDetails.Columns.Add("ItemNote1", typeof(string));
            dtReceiptDetails.Columns.Add("mandate", typeof(DateTime));
            dtReceiptDetails.Columns.Add("exdate", typeof(DateTime));
            dtReceiptDetails.Columns.Add("srate", typeof(decimal));
            dtReceiptDetails.Columns.Add("crate", typeof(decimal));
            dtReceiptDetails.Columns.Add("mrp", typeof(decimal));
            dtReceiptDetails.Columns.Add("Ledcode", typeof(string));
            dtReceiptDetails.Columns.Add("vtype", typeof(string));
            dtReceiptDetails.Columns.Add("Taxper", typeof(decimal));
            dtReceiptDetails.Columns.Add("exciseduty", typeof(decimal));
            dtReceiptDetails.Columns.Add("wrate", typeof(decimal));
            dtReceiptDetails.Columns.Add("billtot", typeof(decimal));

            return dtReceiptDetails;
        }


        public void UpdateReceiptDetails()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@RecptCode",RcptCodeLng},
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdstr},
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

        public void DeleteReceiptDetails()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@RecptCode",RcptCodeLng},
            {"@Slno",SlNoLng},  
            {"@Pcode",PCodeStr},
            {"@UnitId",UnitIdLng},
            {"@BatchId",BatchIdstr},
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
        public bool ItemexstinginPurchase(string Itemcode)
        {
          
            Ds=_Dbtask.ExecuteQuery("select * from tblreceiptdetails where pcode='"+Itemcode+"'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Yes = true;
            }
            return Yes;
        }
        public void IdReceiptDetails()
        {
            RcptCodeLng = Convert.ToInt64(Generalfunction.getnextid("Recptcode", "TblReceiptDetails"));
        }
        public DataSet ShowAccountsSales(string Where, string ProductCode, string LedCode)
        {

            Ds = _TransactionReceipt.ShowTransactionReceipt(" * ", Where);
            object[] Temp = new object[Ds.Tables[0].Rows.Count];
            stringtemp = "";
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Temp[i] = Ds.Tables[0].Rows[i]["RecptCode"];
                stringtemp += Temp[i] + ",";
                if (Ds.Tables[0].Rows.Count - 1 == i)
                    stringtemp = stringtemp.Substring(0, stringtemp.Length - 1);

            }
            Ds2 = Show("where pcode='" + ProductCode + "' and RecptCode in(" + stringtemp + ")");
            return Ds2;
        }

        public DataSet Show(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblReceiptDetails " + Where + "");
            return Ds;
        }
       
        public string CategoryNameinavoucher(string Purcode,string Vcode)
        {
         return  CommonClass._SelectReport.Showindataset("select category from tblitemcategory where categoryid in (select categoryid from tblitemmaster "+
            " where itemid in((  select pcode from tblreceiptdetails where recptcode='8' and ledcode='3' and vtype='PI')))");
        }
    
    }
}
