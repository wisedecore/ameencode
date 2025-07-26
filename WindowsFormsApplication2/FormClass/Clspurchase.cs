using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApplication2
{
    class Clspurchase
    {
        DBTask _Dbtask = new DBTask();
        ClsInGrid _Ingrid = new ClsInGrid();
        public static bool onlinecheck=false;
        public void RefillingRow(DataGridView gridmain,string Itemid,int Rowindex,string Bcode)
        {
            string ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
            string ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
            string PRate;
            string MRP;
            string SRate;

            if (Bcode == "")
            {
                PRate = _Dbtask.ExecuteScalar("select prate from tblitemmaster where itemid='" + Itemid + "'");
                MRP = _Dbtask.ExecuteScalar("select MRP from tblitemmaster where itemid='" + Itemid + "'");
                SRate = _Dbtask.ExecuteScalar("select srate from tblitemmaster where itemid='" + Itemid + "'");
            }
            else
            {
                PRate = _Dbtask.ExecuteScalar("select prate from tblbatch where itemid='" + Itemid + "' and bcode='"+Bcode+"'");
                MRP = _Dbtask.ExecuteScalar("select MRP from tblbatch where itemid='" + Itemid + "'  and bcode='" + Bcode + "'");
                SRate = _Dbtask.ExecuteScalar("select srate from tblbatch where itemid='" + Itemid + "'  and bcode='" + Bcode + "'");
            
            }

            string Incp = _Dbtask.ExecuteScalar("select incp from tblitemmaster where itemid='" + Itemid + "'");

            gridmain.Rows[Rowindex].Cells["ClnItemCode"].Value = ItemCode;
            gridmain.Rows[Rowindex].Cells["ClnItemName"].Tag = Itemid;
            gridmain.Rows[Rowindex].Cells["ClnItemName"].Value = ItemName;
            gridmain.Rows[Rowindex].Cells["Clnprate"].Value = _Dbtask.znullDouble(PRate);
            gridmain.Rows[Rowindex].Cells["ClnMRP"].Value =_Dbtask.znullDouble(MRP);
            gridmain.Rows[Rowindex].Cells["clnsrate"].Value = _Dbtask.znullDouble(SRate);
            gridmain.Rows[Rowindex].Cells["ClnMRP"].Tag = Incp;
        }
        public DataSet ShowpurchaseReport(string Where)
          {

            if (onlinecheck == true)
            {
                CommonClass.Ds1 = _Dbtask.ExecuteQueryAzureServer("SELECT        TR.ReptCode, TR.VNo,TR.Uid, TR.RecptDate AS Date, TR.Refno, TR.Tename AS Party, SUM(RD.Qty) AS Qty, SUM(RD.FreeQty) AS FreeQty,TR.discamt AS Discount, (((TR.AMT-SUM(RD.discrate)) +TR.Discamt) - TR.taxamt) as 'Gross', TR.TaxAmt " +
                          ", TR.AMT AS NetAmount, TR.LedcodeDr AS MainAccount FROM   TblTransactionReceipt AS TR INNER JOIN " +
                          " TblReceiptDetails AS RD ON TR.ReptCode = RD.RecptCode GROUP BY TR.Mpayment,TR.taxid , TR.discamt ,TR.RecptType,TR.Empid,TR.RecptType,TR.agent, TR.LedcodeDr, TR.RecptDate, " +
                          " TR.RecptDate, TR.ReptCode, TR.VNo,TR.Uid, TR.VNo, TR.RecptDate, TR.Refno, TR.Tename, TR.TaxAmt, TR.AMT,TR.Tename,rd.vtype,TR.LedcodeCr " +
                          Where + " ORDER BY CAST(TR.VNO AS INT) ASC");
            }
            else {
                CommonClass.Ds1 = _Dbtask.ExecuteQuery("SELECT        TR.ReptCode, TR.VNo,TR.Uid, TR.RecptDate AS Date, TR.Refno, TR.Tename AS Party, SUM(RD.Qty) AS Qty, SUM(RD.FreeQty) AS FreeQty,TR.discamt AS Discount, (((TR.AMT-SUM(RD.discrate)) +TR.Discamt) - TR.taxamt) as 'Gross', TR.TaxAmt " +
              ", TR.AMT AS NetAmount, TR.LedcodeDr AS MainAccount FROM   TblTransactionReceipt AS TR INNER JOIN " +
              " TblReceiptDetails AS RD ON TR.ReptCode = RD.RecptCode GROUP BY TR.Mpayment,TR.taxid , TR.discamt ,TR.RecptType,TR.Empid,TR.RecptType,TR.agent, TR.LedcodeDr, TR.RecptDate, " +
              " TR.RecptDate, TR.ReptCode, TR.VNo,TR.Uid, TR.VNo, TR.RecptDate, TR.Refno, TR.Tename, TR.TaxAmt, TR.AMT,TR.Tename,rd.vtype,TR.LedcodeCr " +
              Where + " ORDER BY CAST(TR.VNO AS INT) ASC");
            }
            

            return CommonClass.Ds1;
          }
       
    }
}
