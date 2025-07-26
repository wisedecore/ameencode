using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsTransactionRceipt
    {
        public string Uid="";
        public long RcptCodeLng;
        public string  VNoStr;
        public string RCptTypeStr = "";
        public string DcodeStr = "";
        public DateTime RcptDateDt;
        public DateTime Rcptdatebilling;
        public string LedCodeCr="";
        public string LedCodeDr="";
        public double AMTDb=0;
        public string RemarkStr = "";
        public string EmpId="0";
        public double DiscAmtDb=0;
        public string LBLaccnt = "";
        public double TaxAMTDb=0;
        public double CoolyDb=0;
        public double Ramount = 0;
        public double Srate=0;
        public double Crate=0;
        public double Invdisc = 0;
        public string pvno = ""; public string agvno = "";
        public string Agent="0";
        public string Taxid="0";
        public string RefNo = "";
        public string Tename = "";
        public string Tmob = "";
        public string Tvat = "";
        public string Taddres = "";
        public int Modeofpayment = 0;
        public float Pproject = 0;
        public byte[] Billimg = null; 
        DataSet Ds = new DataSet();

       /* For opening Stock Id*/
        public long IdOpeningStock;

        /* For PI Id */
        public long IdPurchase;

        DBTask _Dbtask = new DBTask();
        public void UpdateFiled(string Query)
        {
            _Dbtask.ExecuteNonQuery(Query);
        }
        
        
        public void InsertTransactionReceipt()
        {
            if (Billimg == null)
              Billimg = CommonClass._Nextg.ImageToStream("");
          
            if (Rcptdatebilling.Year == 1)
                Rcptdatebilling = RcptDateDt;
            object[,] objArg = new object[32, 2]
        {
            {"@ReptCode",RcptCodeLng},
            {"@vno",VNoStr},  
            {"@RecptType",RCptTypeStr},
            {"@Dcode",DcodeStr},
            {"@RecptDate",RcptDateDt},
            {"@Bdate",Rcptdatebilling},
            {"@LedcodeCr",LedCodeCr},
            {"@LedcodeDr",LedCodeDr},  
            {"@AMT",AMTDb},
            {"@Remarks",RemarkStr},
            {"@Empid",EmpId},
            {"@DiscAmt",DiscAmtDb},
            {"@invdisc",Invdisc},
            {"@TaxAmt",TaxAMTDb},
            {"@cooly",CoolyDb},
            {"@Adamount", Ramount},
            {"@srate",Srate},
            {"@crate",Crate},
            {"@agent",Agent},
            {"@pvno",pvno},
            {"@taxid",Taxid},
            {"@refno",RefNo},
            {"@Tename",Tename},
            {"@Mpayment",Modeofpayment},
            {"@Billimg",Billimg},
            {"@pproject",Pproject},
            {"@Uid",Uid},
            {"@Agvno",agvno },
            {"@Tmobile",Tmob}, 
            {"@Taddres",Taddres}, 
            {"@Tvat",Tvat},
            {"@LBLaccnt",LBLaccnt}

        };
            _Dbtask.ExecuteNonQuery_SP("InsertTransactionReceipt", objArg);
            return;
        }
        public void UpdateTransactionReceipt()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@ReptCode",RcptCodeLng},
            {"@vno",VNoStr},  
            {"@RecptType",RCptTypeStr},
            {"@Dcode",DcodeStr},
            {"@RecptDate",RcptDateDt},
            {"@LedcodeCr",LedCodeCr},
            {"@LedcodeDr",LedCodeDr},  
            {"@AMT",AMTDb},
            {"@Remarks",RemarkStr},
            {"@Empid",EmpId},
              {"@DiscAmt",DiscAmtDb},
            {"@TaxAmt",TaxAMTDb},
            {"@cooly",CoolyDb}

        };
            _Dbtask.ExecuteNonQuery_SP("UpdateTransactionReceipt", objArg);
            return;
        }
        public void PVno(string Account,string Vtype)
        {
            string TempVno = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='"+Vtype+"' and LedcodeDr='" + Account + "'");
            pvno = _Dbtask.ExecuteScalar("select pvno from TbltransactionReceipt where ReptCode='" + TempVno + "' and RecptType='"+Vtype+"' and LedcodeDr='" + Account + "'");
            VNoStr = _Dbtask.ExecuteScalar("select vno from TbltransactionReceipt where ReptCode='" + TempVno + "' and RecptType='"+Vtype+"' and LedcodeDr='" + Account + "'");
            if (VNoStr == "")
            {

                if (Vtype == "PI")
                {
                    VNoStr = _Dbtask.znllString(_Dbtask.ExecuteScalar("select PARAMVALUE FROM TBLPARAMLIST WHERE PARAMNAME='MAXOFPI' "));
                }
                else
                {
                    VNoStr = "1";
                }
                
                
             
        
        }
            
           
            else
            {
                VNoStr = (Convert.ToInt64(VNoStr) + 1).ToString();
            }
        }


        public DataSet getitemwisereport(string where,string date)
        {
       
            string query = "";
            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {


          query = "select distinct vno from tblbusinessissue    " +
                "   inner join tblissuedetails on tblbusinessissue.issuecode    " +
                "  = ( select tblissuedetails.issuecode    " +
                "  where " + where + ") where    " +
                "  " + date + "  ";




     //           query = "SELECT  tblbusinessissue.Issuedate,tblbusinessissue.VNO,tblissuedetails.Batchid,  " +
     //"  tblissuedetails.qty,tblissuedetails.Rate,  tblbusinessissue.TeNAME as Party,  " +
     // "   tblissuedetails.NetAmt  " +
     //"   FROM  tblbusinessissue  " +
     //"  INNER JOIN tblissuedetails ON   " +
     // "  tblbusinessissue.vno = tblissuedetails.issuecode  " +

     //"   WHERE " + where + "    " +
     //"  ORDER BY tblbusinessissue.Issuedate DESC";

            }
            else
            {
//               


                query = "select distinct vno from tblbusinessissue    " +
               "   inner join tblissuedetails on tblbusinessissue.issuecode    " +
               "  = ( select tblissuedetails.issuecode    " +
               "  where " + where + ") where    " +
               "  " + date + "  ";

                
                
                
                
                
                
                
                
                //query = "SELECT  tblbusinessissue.Issuedate,tblbusinessissue.VNO,tblissuedetails.PCODE, TBLITEMMASTER.ITEMNAME,   "+
// "  tblissuedetails.qty,tblissuedetails.Rate,  tblbusinessissue.TeNAME as Party,    "+
//  "   tblissuedetails.NetAmt    "+
// "   FROM  ((tblbusinessissue    "+ 
// "  INNER JOIN tblissuedetails ON      "+
// "   tblbusinessissue.vno = tblissuedetails.issuecode  )   "+
//"  INNER JOIN TBLITEMMASTER ON TBLISSUEDETAILS.PCODE =TBLITEMMASTER.ITEMID )   "+

// "   WHERE " + where + "    " +

// "   ORDER BY tblbusinessissue.Issuedate DESC  ";
            }



            DataSet Dp = _Dbtask.ExecuteQuery(query);
            return Dp;


        }
        public DataSet GetCreditBillList()
        {
            string Sql = "Select * from TblTransactionReceipt Where RecptType = 'PI' And LedcodeCr !='1' Order By RecptDate Asc";
            DataSet Ds = _Dbtask.ExecuteQuery(Sql);
            return Ds;
        }
        public string getosvno()
        {
            string vno = _Dbtask.znllString(_Dbtask.ExecuteScalar("SELECT  cast( MAX(  ReptCode) as int   )+1  " +
                                                 " FRom TblTransactionReceipt where RecptType='OS' "));
            return vno;
        }
        public DataSet GetSupplierBasedBillList(string LedCode)
        {
            DataSet Ds = GetCreditBillList();
            string LedDr = "";
            string TVno = "";
            string TVtype = "";

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                LedDr = Ds.Tables[0].Rows[i]["LedCodeDr"].ToString();
                TVno = Ds.Tables[0].Rows[i]["Vno"].ToString();
                TVtype = Ds.Tables[0].Rows[i]["RecptType"].ToString();

                if (GetSpecificField("LedCodeCr", TVno, TVtype, LedDr) != LedCode)
                {
                    Ds.Tables[0].Rows.RemoveAt(i);
                    i = i - 1;
                }
            }
            return Ds;
        }
        public double GetTotalAmt(string TempVno, string TempVtype)
        {

            string Sql = "Select Amt From TblTransactionReceipt Where Vno = '" + TempVno + "' And RecptType = '" + TempVtype + "' And LedcodeDr = '3'";
            double Amt = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar(Sql));
            return Amt;

        }
        public string GetSpecificField(string Field, string TempVno, string TempVtype, string TempLedcodeDr)
        {

            string Qry = "Select " + Field + " From TblTransactionReceipt Where RecptType = '" + TempVtype + "' And Vno = '" + TempVno + "' And LedcodeDr in( " + TempLedcodeDr + ")";
            string Value = _Dbtask.ExecuteScalar(Qry);
            return Value;
        }

        public void SRVno(string Account)
        {
            string TempVno = _Dbtask.ExecuteScalar("SELECT     { fn IFNULL(MAX(ReptCode), 0) } AS Expr1  FROM TbltransactionReceipt where RecptType='SR' and LedcodeDr='" + Account + "'");
            pvno = _Dbtask.ExecuteScalar("select pvno from TbltransactionReceipt where ReptCode='" + TempVno + "'  and RecptType='SR' and LedcodeDr='" + Account + "' ");
            VNoStr = _Dbtask.ExecuteScalar("select vno from TbltransactionReceipt where ReptCode='" + TempVno + "' and  RecptType='SR' and LedcodeDr='" + Account + "'");
            if (VNoStr == "")
            {
                VNoStr = "1";
            }
            else
            {
                VNoStr = (Convert.ToInt64(VNoStr) + 1).ToString();
            }
        }

        public void DeleteTransactionReceipt()
        {

            object[,] objArg = new object[13, 2]
        {
            {"@ReptCode",RcptCodeLng},
            {"@vno",VNoStr},  
            {"@RecptType",RCptTypeStr},
            {"@Dcode",DcodeStr},
            {"@RecptDate",RcptDateDt},
            {"@LedcodeCr",LedCodeCr},
            {"@LedcodeDr",LedCodeDr},  
            {"@AMT",AMTDb},
            {"@Remarks",RemarkStr},
            {"@Empid",EmpId},
              {"@DiscAmt",DiscAmtDb},
            {"@TaxAmt",TaxAMTDb},
            {"@cooly",CoolyDb}

        };
            _Dbtask.ExecuteNonQuery_SP("DeleteTransactionReceipt", objArg);
            return;
        }
        public void IdTransactionReceiptPurticular(string vtype)
        {
            RcptCodeLng = Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "TblTransactionReceipt", " where RecptType='"+vtype+"'"));
        }
        public void IdTransactionReceipt()
        {
            RcptCodeLng = Convert.ToInt64(Generalfunction.getnextid("ReptCode", "TblTransactionReceipt"));
        }
        public void IdOpeningStockFu()
        {
            RcptCodeLng = Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "TblTransactionReceipt", " where RecptType='OS'"));
        }

        public string IdPurchaseFu(string PurchaseAccount,string Vtype)
        {
            IdPurchase = Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "TblTransactionReceipt", " where RecptType='"+Vtype+"' and LedcodeDr='" + PurchaseAccount + "'"));
            return IdPurchase.ToString();
        }
        public string IdSRFu(string PurchaseAccount)
        {
            IdPurchase = Convert.ToInt64(Generalfunction.getnextidCondition("ReptCode", "TblTransactionReceipt", " where RecptType='SR' and LedcodeDr='" + PurchaseAccount + "'"));
            return IdPurchase.ToString();
        }
        public double TottalAmountOfType(string Field,string VType,string Where)
        {
            AMTDb =_Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(" + Field + "),0) from Tbltransactionreceipt where  RecptType='" + VType + "' " + Where + ""));
            return AMTDb;
        }
        public double TottalAmountOfTypewthoutcr(string Field, string VType, string Where)
        {
            AMTDb = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(" + Field + "),0) from Tbltransactionreceipt where  RecptType='" + VType + "' " + Where + "  and mpayment!='1' "));
            return AMTDb;
        }
        public DataSet ShowTransactionReceipt(string DisplayField, string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select "+DisplayField+" from TblTransactionReceipt " + Where + "");
            return Ds;
        }


        public double TottalAmountOfTypewherequery(string Field, string VType, string Where)
        {
            AMTDb = _Dbtask.znullDouble(_Dbtask.ExecuteScalar("select isnull(sum(" + Field + "),0) from Tbltransactionreceipt where  RecptType='" + VType + "' " + Where + "   "));
            return AMTDb;
        }


    }
}
