using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace WindowsFormsApplication2
{
    class ClsReports
    {
        
        public DataSet Ds;
        DBTask _Dbtask = new DBTask();
        Clscommenevent _ComEvent = new Clscommenevent();
        Clsselectreport _SelectReport = new Clsselectreport();
        public static bool allgodwn = false;
        public static string RType;
        public static string RQuery;
        public static string RQueryTemp;
        public static string RQueryDetail;
        public static string RTypeSecond;

        public static DateTime RDtfrom;
        public static DateTime Rdtto;

        public static DateTime DTFrom;
        public static DateTime DTTo;

        public static string ReportType;
        public static string Query;
        public static string QueryTemp;
        public static string QueryTemp2;


        public int Count;/*Row Counting*/
        public string Temp;
        public double TCashAmount;
        public double MTDrAmount;
        public double MTCrAmount;

       public string InclQuey;
        /*For Using Balancesheet*/
       public double TLability = 0;
       public double TAsset = 0;
       public double TCLability = 0;
       public double TLLability = 0;
       public double TCAsset = 0;
       public double TFAsset = 0;


        /*For Using Profit and Loss Account*/

       public double TIncome = 0;
       public double TExpence = 0;
       public double TDirectIncome = 0;
       public double TDirectExpence = 0;
       public double TIndirectIncome = 0;
       public double TIndirectExpence = 0;

       public int RowCountingLiabilty;
       public int RowCountingAsset;

       public void CellItalicStyle(DataGridView GridMain, string Columnname, int Rowindex)
       {
           GridMain.Columns[Columnname].DefaultCellStyle.Font = new Font(GridMain.DefaultCellStyle.Font, FontStyle.Italic);
       }

       public void CellBoldStyle(DataGridView GridMain, string Columnname, int Rowindex)
       {
           GridMain.Columns[Columnname].DefaultCellStyle.Font = new Font(GridMain.DefaultCellStyle.Font, FontStyle.Bold);
       }
       public double NetProfit(DateTime Dtfrom, DateTime DtTo)
       {


           //Temp = _Dbtask.ExecuteScalar("select sum(cramt)-(select sum(dbamt) "+
           // "from tblgeneralledger where ledcode "+ 
           // "in(select lid from tblaccountledger "+
           // "where agroupid in ( select agroupid from tblaccountgroup "+
           // "where aunder in(12,15) or agroupid in (12,15)))) "+
           // "from tblgeneralledger where ledcode "+
           // "in(select lid from tblaccountledger "+
           // "where agroupid in ( select agroupid from tblaccountgroup "+
           // "where aunder in(13,16) or agroupid in (13,16)))");
           return _Dbtask.znullDouble(Temp);
       }
       public void VisibleFalseColumns(string[] Passing,DataGridView Gridmain)
        {
            for (int i = 0; i < Passing.Length; i++)
            {
                Gridmain.Columns[Passing[i]].Visible = false;
            }
        }
       public void Qtycolumnsettings(DataGridView GridMain, string Columnname, Int32 Width)
       {
           GridMain.Columns[Columnname].Width = Width;
           GridMain.Columns[Columnname].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
           GridMain.Columns[Columnname].SortMode = DataGridViewColumnSortMode.NotSortable;
           GridMain.Columns[Columnname].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           GridMain.Columns[Columnname].DefaultCellStyle.Format = ("0.00").ToString();
       }
      
       public void ForProfitandLossAccountTotal(DataGridView GridMain, int Rowindex,double SumTottalBalance)
       {
           Count = GridMain.Rows.Add(1);
           GridMain.Rows[Count].Cells["ClncAmount"].Value = "--------";
           GridMain.Rows[Count].Cells["ClnDbAmount"].Value = "--------";

           Count = GridMain.Rows.Add(1);
           GridMain.Rows[Count].Cells["ClncAmount"].Value = _Dbtask.SetintoDecimalpoint(SumTottalBalance);
           GridMain.Rows[Count].Cells["ClnDbAmount"].Value = _Dbtask.SetintoDecimalpoint(SumTottalBalance);
           CommonClass._Clreport.TottalRowStyle(GridMain, Count);

           Count = GridMain.Rows.Add(1);
           GridMain.Rows[Count].Cells["ClncAmount"].Value = "======";
           GridMain.Rows[Count].Cells["ClnDbAmount"].Value ="======";
           Count = GridMain.Rows.Add(1);
       }

        public void ForDayBookDetailTotal(DataGridView GridMain, int Rowindex,double SumDebit,double SumCredit,double SumTottalBalance)
        {
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clndebit"].Value =  "--------";
            GridMain.Rows[Count].Cells["clncredit"].Value = "--------";
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(SumDebit);
            GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(SumCredit);
            Count = GridMain.Rows.Add(1);

            GridMain.Rows[Count].Cells["clndebit"].Value = "--------";
            GridMain.Rows[Count].Cells["clncredit"].Value = "--------";

            Count = GridMain.Rows.Add(1);
            double TLessAmount = SumDebit - SumCredit;
            TottalRowStyle(GridMain, Count);
            GridMain.Rows[Count].Cells["clndebit"].Value = "Today Balance";
            GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TLessAmount);

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clndebit"].Value = "======";
            GridMain.Rows[Count].Cells["clncredit"].Value = "======";

            Count = GridMain.Rows.Add(1);
            SumTottalBalance = SumTottalBalance + TLessAmount;
            TottalRowStyle(GridMain, Count);
            GridMain.Rows[Count].Cells["clndebit"].Value = "TodayClosing Balance";
            GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(SumTottalBalance);
            CommonClass.DBtemp = SumTottalBalance;
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clndebit"].Value = "======";
            GridMain.Rows[Count].Cells["clncredit"].Value = "======";
        }
        public void TottalRowStyle(DataGridView GridMain,int Rowindex)
        {
            GridMain.Rows[Rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Purple;
            GridMain.Rows[Rowindex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
        }

        public void ShowReport(Form Frm,bool Isinform)
        {
            FrmReport _Report = new FrmReport();
            _Report.ReportType = Clsselectreport.RType;
            _Report.Query = Clsselectreport.RQuery;
            _Report.QueryTemp = Clsselectreport.RQueryTemp;
            _Report.QueryDetail = Clsselectreport.RQueryDetail;
            _Report.DTFrom = Clsselectreport.RDtfrom;
            _Report.DTTo = Clsselectreport.Rdtto;
            _Report.ReportTypeSecond = Clsselectreport.RTypeSecond;

            _Report.agvnlid = Clsselectreport.agvnolid;
            _Report.Location = new Point(0, 0);
            _Report.MdiParent = Frm.ParentForm;
            if(Isinform==true)
            _Report.Size = new System.Drawing.Size(Frm.ParentForm.Width - 40, Frm.ParentForm.Height - 25 - 90);
            else
                _Report.Size = new System.Drawing.Size(1226 - 40, 776- 25 - 90);

            _Report.Show();
        }

        public DataSet LedgerSummuryBaseOnGroup(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("SELECT     ISNULL(SUM(TblGeneralLedger.DbAmt) - SUM(TblGeneralLedger.CrAmt), 0) AS amount,tblgeneralledger.ledcode "+
                " FROM   TblGeneralLedger INNER JOIN TblAccountLedger ON TblGeneralLedger.LedCode = TblAccountLedger.Lid "+
                " "+Where+" group by tblgeneralledger.ledcode ");
            return Ds;
        }
       

        public DataSet StockConsolidateBaseonItem(string Where,bool Batch,string Sdtfrom,string Sdtto)
        {
            if (Batch == true)
            {
                Ds = _Dbtask.ExecuteQuery("SELECT     IMS.ItemId, IMS.Itemcode, IMS.ItemName, INV.batchcode, SUM(INV.Os + INV.Purchase + INV.Mr + INV.Sr + INV.Ireceipt + INV.bmr + INV.freepre + INV.Dnr + INV.ps) " +
                     "  - SUM(INV.Sales + INV.dn + INV.pr + INV.iissue + INV.sh + INV.dmg + INV.bmi + INV.freeiss) AS Balance, SUM(INV.Os) AS Opening, SUM(INV.ps) AS 'Py(stock)', " +
                     "  SUM(INV.Purchase) + SUM(INV.freepre) AS Purchase,Tblbatch.prate as 'PRate',sum(INV.Purchase)*Tblbatch.prate as 'PValue',  SUM(INV.Sr) AS 'S.Return', SUM(INV.Dnr) AS 'DNR', SUM(INV.Ireceipt) AS 'IReceipt', SUM(INV.Sales) " +
                     "  + SUM(INV.freeiss) AS Sales ,Tblbatch.srate as 'SRate', SUM(INV.sales)*Tblbatch.srate as 'SValue', SUM(INV.pr) AS 'P.Return', SUM(INV.dn) AS 'D.Note', SUM(INV.sh) AS Shortage " +
                     "    FROM         TblItemMaster AS IMS INNER JOIN " +
                     "  TblInventory AS INV ON IMS.ItemId = INV.PCode INNER JOIN " +
                     "  Tblbatch ON INV.batchcode = Tblbatch.Bcode " +
                     "  GROUP BY IMS.ItemId, IMS.Itemcode, IMS.ItemName, INV.DCode, IMS.Itemclass, INV.batchcode, Tblbatch.prate, Tblbatch.srate " +
                     " " + Where + "");
            }
            else
            {
                //Ds = _Dbtask.ExecuteQuery("SELECT     IMS.ItemId, IMS.Itemcode, IMS.ItemName,SUM(INV.Os+INV.purchase+INV.Mr+INV.Sr+INV.Ireceipt+INV.bmr+INV.freepre+INV.dnr+INV.ps)-SUM(INV.sales+INV.dn+INV.pr+INV.iissue+INV.sh+INV.dmg+INV.bmi+INV.freeiss ) AS Balance," +
                //" sum(INV.Os) as Opening,sum(INV.ps) as 'Py(stock)', sum(INV.Purchase)+sum(INV.freepre) as Purchase,sum(INV.Sr) as 'S.Return', sum(INV.Dnr) as 'DNR',sum(INV.ireceipt) as 'IReceipt', " +
                //" sum(INV.Sales)+sum(INV.freeiss)as Sales,sum(INV.pr)as 'P.Return',sum(INV.dn) as 'D.Note',sum(INV.sh) as Shortage " +
                //" FROM         TblItemMaster as IMS INNER JOIN " +
                //" TblInventory as INV ON IMS.ItemId = INV.PCode " +
                //" group by IMS.ItemId, IMS.Itemcode, IMS.ItemName,INV.dcode,IMS.Itemclass  " +
                //" " + Where + "");

                Ds = _Dbtask.ExecuteQuery("DECLARE @Date1 Datetime DECLARE @Date2 Datetime "+
                       " SET              @Date1 = '"+Sdtfrom+"' "+
                       " SET              @Date2 = '"+Sdtto+"' "+
                       " SELECT   (select itemname from tblitemmaster where itemid=PCode) as 'Itemname',(select itemcode from tblitemmaster where itemid=PCode) as 'Itemcode', "+
                       " SUM(Os + Purchase + Mr + Sr + Ireceipt + bmr + freepre + Dnr + ps) - SUM(Sales + dn + pr + iissue + sh + dmg + bmi + freeiss) AS Balance, SUM(Os)  "+
                       " AS Opening, SUM(ps) AS 'Py(stock)', SUM(Purchase) + SUM(freepre) AS Purchase, SUM(Sr) AS 'S.Return', SUM(Dnr) AS 'DNR', SUM(Ireceipt) AS 'IReceipt', "+
                       " SUM(Sales) + SUM(freeiss) AS Sales, SUM(pr) AS 'P.Return', SUM(dn) AS 'D.Note', SUM(sh) AS Shortage "+
                       " FROM         TblInventory AS INV RIGHT OUTER JOIN "+
                       " (SELECT     DATEADD(DAY, number + 1, @Date1) AS dtDate "+
                       " FROM          master.dbo.spt_values "+
                       " WHERE      (type = 'P') AND (DATEADD(DAY, number + 1, @Date1) < @Date2)) AS tbldate ON cast(floor(cast(inv.invDate AS float)) AS datetime)  "+
                       " = tbldate.dtDate "+
                       " GROUP BY DCode, PCode");

         
            }
        return Ds;
        }
//        public DataSet StockListBaseonItem(string Where, string SelRate, DateTime Pdtfrom, DateTime Pdtto)
//        {
//            if (SelRate == "Srate")
//            {
//                InclQuey = " IMS.srate ";
//            }
//            if (SelRate == "Prate")
//            {
//                InclQuey = " IMS.prate ";
//            }
//            if (SelRate == "Crate")
//            {
//                InclQuey = " IMS.Crate ";
//            }
//            Where = InclQuey + Where;
//            Ds = _Dbtask.ExecuteQuery("SELECT CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IMS.CategoryId order by IMS.CategoryId ) = 1  " +
//" THEN ( select category from tblitemcategory where categoryid= IMS.CategoryId)" +
//" ELSE ' ' END AS 'Group', " +
//"  IMS.Itemcode, IMS.ItemName, IMS.ItemId, " + InclQuey + " AS rate,isnull((select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  " +
//"          SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory  where pcode=IMS.ItemId  "+
//"          and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
//"        ),0) as Qty, "+
//"         isnull( (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IMS.ItemId  "+
//"        and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'  " +
//"     )* " + InclQuey + " - " +
//"    (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IMS.ItemId  "+
//"    and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'    " +
//"  ) * " + InclQuey + " ,0)as TotalValue   " +
//" FROM         TblItemMaster AS IMS INNER JOIN "+
//"                   TblInventory AS INV ON IMS.ItemId = INV.PCode "+
//" GROUP BY IMS.Itemcode, IMS.ItemName, IMS.CategoryId, IMS.ItemId, INV.DCode, IMS.Itemclass, " + Where + "");
//            return Ds;
//        }

        public DataSet StockListBaseonItem(string Where, string SelRate, string SelUnit, DateTime Pdtfrom, DateTime Pdtto)
        {
            if (SelRate == "Srate")
            {
                InclQuey = " IMS.srate ";
                Temp = "IMS.Srate";
            }
            if (SelRate == "Prate")
            {
                InclQuey = " IMS.prate ";
                Temp = "IMS.prate";
            }
            if (SelRate == "Crate")
            {
                InclQuey = " (select sum(netamt)/sum(qty+freeqty) from tblreceiptdetails where pcode=IMS.ItemId) ";
                Temp = "IMS.prate";
               // IMS.Crate ";
            }
            Where = Temp + Where;

//            Ds = _Dbtask.ExecuteQuery("SELECT CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IMS.CategoryId order by IMS.CategoryId ) = 1  " +
//" THEN ( select category from tblitemcategory where categoryid= IMS.CategoryId)" +
//" ELSE ' ' END AS 'Group', " +
//"  IMS.Itemcode, IMS.ItemName, IMS.ItemId,cast( " + InclQuey + " as numeric(36," + CommonClass._Paramlist.GetParamvalue("CurDecc") + ")) AS rate,cast((select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)/" + SelUnit + "-  " +
//"          SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss )/" + SelUnit + "   from TblInventory  where pcode=IMS.ItemId  " +
//"          and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
//"        )as numeric(36," + CommonClass._Paramlist.GetParamvalue("StockDecc") + "))as Qty, " +
//"         cast((select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)/" + SelUnit + " from TblInventory where pcode=IMS.ItemId  " +
//"        and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'  " +
//"     )* " + InclQuey + " - " +
//"    (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss)/" + SelUnit + " from TblInventory where pcode=IMS.ItemId  " +
//"    and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'    " +
//"  ) * " + InclQuey + " as numeric(36," + CommonClass._Paramlist.GetParamvalue("CurDecc") + ")) as  TotalValue   " +
//" FROM         TblItemMaster AS IMS INNER JOIN " +
//"                   TblInventory AS INV ON IMS.ItemId = INV.PCode " +
//" GROUP BY IMS.Itemcode, IMS.ItemName, IMS.CategoryId, IMS.ItemId, INV.DCode, IMS.Itemclass, " + Where + "");
//            return Ds;
            
            //            Ds = _Dbtask.ExecuteQuery("SELECT CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IMS.CategoryId order by IMS.CategoryId ) = 1  " +
//" THEN ( select category from tblitemcategory where categoryid= IMS.CategoryId)" +
//" ELSE ' ' END AS 'Group', " +
//"  IMS.Itemcode, IMS.ItemName, IMS.ItemId, " + InclQuey + " AS Rate,SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  " +
//"          SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss )   from TblInventory  where pcode=IMS.ItemId  " +
//"          and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
//"        as Qty, " +
//"         (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IMS.ItemId  " +
//"        and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'  " +
//"     )* " + InclQuey + " - " +
//"    (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IMS.ItemId  " +
//"    and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'    " +
//"  ) * " + InclQuey + " as   TotalValue   " +
//" FROM         TblItemMaster AS IMS INNER JOIN " +
//"                   TblInventory AS INV ON IMS.ItemId = INV.PCode " +
//" GROUP BY IMS.Itemcode, IMS.ItemName, IMS.CategoryId, IMS.ItemId, INV.DCode, IMS.Itemclass, " + Where + "");
//            return Ds;

            Ds = _Dbtask.ExecuteQuery("SELECT CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IMS.CategoryId order by IMS.CategoryId ) = 1  " +
" THEN ( select category from tblitemcategory where categoryid= IMS.CategoryId)" +
" ELSE ' ' END AS 'Group', " +
"  IMS.Itemcode, IMS.ItemName, IMS.ItemId, " + InclQuey + " AS rate,isnull((select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  " +
"          SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory  where pcode=IMS.ItemId  " +
"          and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
"        ),0) as Qty, " +
"         isnull( (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IMS.ItemId  " +
"        and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'  " +
"     )* " + InclQuey + " - " +
"    (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IMS.ItemId  " +
"    and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'    " +
"  ) * " + InclQuey + " ,0)as TotalValue   " +
" FROM         TblItemMaster AS IMS INNER JOIN " +
"                   TblInventory AS INV ON IMS.ItemId = INV.PCode " +
" GROUP BY IMS.Itemcode, IMS.ItemName, IMS.CategoryId, IMS.ItemId, INV.DCode, IMS.Itemclass, " + Where + "");
            return Ds;
        }

        public DataSet ShowSalesBase(string Where, string SelRate)
        {
            Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.Itemcode order by IM.Itemcode ) = 1 " +
            " THEN  IM.Itemcode ELSE NULL END AS 'Itemcode'," +
            " CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.ItemName order by IM.ItemName ) = 1 " +
            " THEN  IM.ItemName ELSE NULL END AS 'ItemName'" +
            " , TB.Bcode," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps+dnr)- " +
            " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) as Qty, " +
            "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps+dnr) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode)* " + InclQuey + " - " +
            " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) * " + InclQuey + "  as TotalValue " +
             " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
             "TblInventory AS TI ON IM.ItemId = TI.PCode " +
             "GROUP BY IM.ItemId, IM.Itemcode, IM.ItemName, TB.Bcode," + Where + "");
            return Ds;
        }
       
        public DataSet StockListBaseonBarcode(string Where,string SelRate,bool UseWieghtMechine,DateTime Pdtfrom,DateTime Pdtto)
        {
            CommonClass._Dbtask.ExecuteNonQuery("update tblinventory set sr=0 where sr=null");
            string head = "";
            
            if (SelRate == "Srate")
            {
                InclQuey = " TB.srate ";
            }

            if (SelRate == "Prate")
            {
                InclQuey = " TB.prate ";
            }


            //string RATEEQRY = "";
            //if (SelRate == "Srate")
            //{
            //    InclQuey = " TB.srate ";
            //    head = "as 'Srate'";
            //    RATEEQRY = " TB.srate ";
            //}

            //if (SelRate == "Prate")
            //{
            //    RATEEQRY = " TB.costone ";
            //    InclQuey = " TB.prate ";
            //    head = " as 'prate'";
            //}

            Where = InclQuey + Where;
            if (UseWieghtMechine == true)
            {
                Ds = _Dbtask.ExecuteQuery("SELECT     IM.plu, TB.Bcode, 0 AS Expr1, TB.srate, 0 AS Expr2, 0 AS Expr3, 0 AS Expr4, 0 AS Expr5, 0 AS Expr6, 0 AS Expr7, 1 AS Expr8, 0 AS Expr9, 0 AS Expr10, "+
                     " IM.Itemcode, IM.ItemName FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid "+
                     "GROUP BY IM.ItemId, TB.Bcode, TB.srate, IM.ItemName, IM.Itemcode,IM.itemclass, IM.plu HAVING      (IM.plu <> '') ORDER BY IM.ItemId");
            }
            else
            {
                //Ds = _Dbtask.ExecuteQuery("select TB.Bcode," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps+dnr)- " +
                //  " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) as Qty, " +
                //  "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps+dnr) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode)* " + InclQuey + " - " +
                //  " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) * " + InclQuey + "  as TotalValue " +
                //   " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                //   "TblInventory AS inv ON IM.ItemId = inv.PCode " +
                //   "GROUP BY IM.ItemId, IM.Itemcode, IM.ItemName,TB.Bcode,inv.dcode,inv.pcode,IM.itemclass,  " + Where + " ");

                //Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.Itemcode order by IM.Itemcode ) = 1 " +
                // " THEN  IM.Itemcode ELSE NULL END AS 'Itemcode'," +
                // " CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.ItemName order by IM.ItemName ) = 1 " +
                // " THEN  IM.ItemName ELSE NULL END AS 'ItemName'" +
                // " , TB.Bcode," + InclQuey + "/TB.unconv as 'Rate',(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)- " +
                // " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) as Qty, " +
                // "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode)* (" + InclQuey + "/TB.unconv) - " +
                // " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode) * (" + InclQuey + "/TB.unconv)  as TotalValue " +
                //  " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                //  "TblInventory AS inv ON IM.ItemId = inv.PCode " +
                //  "GROUP BY IM.ItemId, IM.Itemcode, IM.ItemName,TB.Bcode,inv.dcode,inv.pcode,IM.itemclass,TB.unconv,  " + Where + " ");
                //Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.Itemcode order by IM.Itemcode ) = 1 " +
                //    " THEN  IM.Itemcode ELSE NULL END AS 'Itemcode'," +
                //    " CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.ItemName order by IM.ItemName ) = 1 " +
                //    " THEN  IM.ItemName ELSE NULL END AS 'ItemName'" +
                //    " , TB.Bcode," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)- " +
                //    " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode "+
                //    "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                //    " ) as Qty, " +
                //    "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode "+
                //     "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                //    " )* " + InclQuey + " - " +
                //    " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode "+
                //    "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                //    " ) * " + InclQuey + "  as TotalValue " +
                //     " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                //     "TblInventory AS inv ON IM.ItemId = inv.PCode and inv.invdate between "+
                //   "   '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'   " +
                //     "GROUP BY IM.ItemId, IM.Itemcode, IM.ItemName,TB.Bcode,inv.dcode,inv.pcode,IM.itemclass,  " + Where + " ");


                if (allgodwn == false)
                {

                    Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, IM.llang as'Second Language', IM.ItemName as 'Item Name'" +
                       " , TB.Bcode as 'Barcode'," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)- " +
                       " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId  " + FrmReport.Decodee + " and  ( batchcode=(select distinct TB.Bcode )) " +
                       "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " ) as Qty, " +
                       "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                        "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " )* " + InclQuey + " - " +
                       " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                       "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " ) * " + InclQuey + "  as 'Amount' " +
                        " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                        "TblInventory AS inv ON IM.ItemId = inv.PCode and inv.invdate between " +
                      "   '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'   " +
                        "GROUP BY IM.ItemId, IM.llang, IM.ItemName,TB.Bcode,inv.dcode,inv.pcode,IM.itemclass,inv.batchcode,  " + Where + " ");
                }
                else
                {
                    Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, IM.llang as'Second Language', IM.ItemName as 'Item Name'" +
                       " , TB.Bcode as 'Barcode'," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)- " +
                       " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                       "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " ) as Qty, " +
                       "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                        "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " )* " + InclQuey + " - " +
                       " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                       "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                       " ) * " + InclQuey + "  as 'Amount' " +
                        " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                        "TblInventory AS inv ON IM.ItemId = inv.PCode and inv.invdate between " +
                      "   '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'   " +
                        "GROUP BY IM.ItemId, IM.llang, IM.ItemName,TB.Bcode,inv.pcode,IM.itemclass,inv.batchcode,  " + Where + " ");
                }

                allgodwn = false;




            }
            return Ds;
        }
        public void TrailBalanceFillingOpeningBalance(DataGridView GridMain, string Mode, string GroupName1, string Purticulars, string GroupName,double Amount)
        {
            TCashAmount = Amount;
            Temp = Amount.ToString();
            if (Mode == "DR")
            {
                
                if (_Dbtask.znullDouble(Temp) > 0)
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = GroupName1;
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                    GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                    MTDrAmount = MTDrAmount + TCashAmount;
                }
                else if (_Dbtask.znullDouble(Temp) < 0)
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = GroupName1;
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                    GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                    MTCrAmount = MTCrAmount + TCashAmount;
                }
            }
            else
            {
                if (_Dbtask.znullDouble(Temp) < 0)
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = GroupName1;
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                    TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount);
                    GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                    MTCrAmount = MTCrAmount + TCashAmount;
                }
                else if (_Dbtask.znullDouble(Temp) > 0)
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Tag = GroupName1;
                    GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                    GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                    MTDrAmount = MTDrAmount + TCashAmount;
                }
            }
            if (_Dbtask.znullDouble(Temp) > 0 || _Dbtask.znullDouble(Temp) < 0)
            {
                GridMain.Rows[Count].Cells["clnpurticulars"].Tag = GroupName;
            }
        }

        public void ProfitAndLossGroupBalance(string AccountType, double amt)
        {
            if (AccountType == "13")
            {
                TDirectIncome = TDirectIncome + amt;
                TIncome = TIncome + amt;
            }
            else if (AccountType == "12")
            {
                TDirectExpence = TDirectExpence + amt;
                TExpence = TExpence + amt;
            }
            else if (AccountType == "16")
            {
                TIndirectIncome = TIndirectIncome + amt;
                TIncome = TIncome + amt;
            }
            else if (AccountType == "15")
            {
                TIndirectExpence = TIndirectExpence + amt;
                TExpence = TAsset + amt;
            }
           
        }

        public void BalancsheetGroupBalance(string Ledname,double amt)
        {
            if (Ledname == "Current Liability")
            {
                TCLability = TCLability + amt;
                TLability = TLability + amt;
            }
            else if (Ledname == "Long Term Liability")
            {
                TLLability = TLLability + amt;
                TLability = TLability + amt;
            }
            else if (Ledname == "Current Assets"||Ledname=="ClosingStock")
            {
                TCAsset = TCAsset + amt;
                TAsset = TAsset + amt;
            }
            else if (Ledname == "Fixed Assets")
            {
                TFAsset = TFAsset + amt;
                TAsset = TAsset + amt;
            }
        }

        public void ProfitandLossAccountFilling(string GroupId, DataGridView GridMain, string Mode, DateTime Dtfrom, DateTime Dtto,string GroupType)
        {
            string Lid;
            string Gid;
            string Gname;
            string Purticulars;

          
             

            if (GroupId == "P&LCLOSING")
            {

                /******************For Using P&L Closing***************************/
                TCashAmount = NetProfit(Dtfrom, Dtto);
                RowCountingLiabilty = GridMain.Rows.Add(1);
                GridMain.Rows[RowCountingLiabilty].Tag = "P&L";
                GridMain.Rows[RowCountingLiabilty].Cells["clnlaibilities"].Value = "Profit Balance";
                GridMain.Rows[RowCountingLiabilty].Cells["clnlamount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                BalancsheetGroupBalance("Long Term laibility", TCashAmount);
            }

            else
            {
                Ds = _Dbtask.ExecuteQuery("select * from tblaccountgroup  where aunder in (" + GroupId + ") or agroupid in (" + GroupId + ")");
                Gname = _Dbtask.ExecuteScalar("select agroupname from tblaccountgroup  where agroupid in (" + GroupId + ")");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Gid = Ds.Tables[0].Rows[i]["agroupid"].ToString();
                    Purticulars = Ds.Tables[0].Rows[i]["agroupname"].ToString();
                    Lid = _ComEvent.DatasetToString("select lid from tblaccountledger where agroupid in(" + Gid + ")", "lid");
                    if (Lid != "")
                    {

                        if (Generalfunction.BlShowEst == true || Generalfunction.BlShowEst == false)
                        {
                            Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + Lid + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59'");
                        }
                        else
                        {
                            string Estlid = CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate", "lid");
                            if (Estlid != "")
                            {
                                Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + Lid + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='"+Estlid+"'");
                            }
                        }
                        TCashAmount = _Dbtask.znullDouble(Temp);
                        TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount);
                        if (TCashAmount > 0)
                        {
                            if (Mode == "EXPENCE")
                            {
                                RowCountingLiabilty = GridMain.Rows.Add(1);
                                GridMain.Rows[RowCountingLiabilty].Tag = Gid;
                                GridMain.Rows[RowCountingLiabilty].Cells["ClncPurticulars"].Value = Purticulars;
                                GridMain.Rows[RowCountingLiabilty].Cells["ClncAmount"].Tag = GroupType;
                                GridMain.Rows[RowCountingLiabilty].Cells["ClncAmount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                                ProfitAndLossGroupBalance(GroupType, TCashAmount);
                            }
                            else if (Mode == "INCOME")
                            {

                               // if (RowCountingAsset > RowCountingLiabilty)
                                    RowCountingAsset = GridMain.Rows.Add(1);
                                GridMain.Rows[RowCountingAsset].Tag = Gid;
                                GridMain.Rows[RowCountingAsset].Cells["ClnDPurticulars"].Value = Purticulars;
                                GridMain.Rows[RowCountingAsset].Cells["ClnDbAmount"].Tag = GroupType;
                                GridMain.Rows[RowCountingAsset].Cells["ClnDbAmount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                                ProfitAndLossGroupBalance(GroupType, TCashAmount);
                                RowCountingAsset++;
                            }
                        }
                    }
                }
            }
        }

        public void BalancesheetFilling(string GroupId, DataGridView GridMain,string Mode, DateTime Dtfrom, DateTime Dtto)
        {
            string Lid;
            string Gid;
            string Gname;
            string Purticulars;
             if (GroupId == "P&LCLOSING")
            {

                /******************For Using P&L Closing***************************/
                //NetProfit(Dtfrom, Dtto);
                //TCashAmount = NetProfit(Dtfrom, Dtto);
                TCashAmount = CommonClass._report.Nettprofit(Dtfrom,Dtto);
                RowCountingLiabilty = GridMain.Rows.Add(1);
               
                

                if (TCashAmount > 0)
                {
                    GridMain.Rows[RowCountingLiabilty].Tag = "P&L";
                    GridMain.Rows[RowCountingLiabilty].Cells["clnlaibilities"].Value = "Nett Profit";
                    GridMain.Rows[RowCountingLiabilty].Cells["clnlamount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                    BalancsheetGroupBalance("Long Term Liability", TCashAmount);

                }
                else
                {
                    GridMain.Rows[RowCountingLiabilty].Tag = "P&L";
                    TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount);
                    GridMain.Rows[RowCountingLiabilty].Cells["clnassets"].Value = "Nett Loss";
                    GridMain.Rows[RowCountingLiabilty].Cells["clnaamount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                  
                    BalancsheetGroupBalance("Current Assets", TCashAmount);
                }    
            }
             else if (GroupId == "ClosingStock")
             {
                 if (RowCountingAsset > RowCountingLiabilty)
                     RowCountingAsset = GridMain.Rows.Add(1);
                 GridMain.Rows[RowCountingAsset].Tag = "ClosingStock";
                 GridMain.Rows[RowCountingAsset].Cells["clnassets"].Value = "Closing stock";
                 GridMain.Rows[RowCountingAsset].Cells["clnAamount"].Value = CommonClass._Inventory.DbStockvalue("", "Prate", Dtfrom.AddYears(-50), Dtto);
                 TCashAmount = CommonClass._Inventory.DbStockvalue("", "Prate", Dtfrom.AddYears(-50), Dtto);
                 BalancsheetGroupBalance("ClosingStock", TCashAmount);
                 RowCountingAsset++;
             }

             else
             {
                 Ds = _Dbtask.ExecuteQuery("select * from tblaccountgroup  where aunder in (" + GroupId + ") or agroupid ='" + GroupId + "'");
                 Gname = _Dbtask.ExecuteScalar("select agroupname from tblaccountgroup  where agroupid in (" + GroupId + ")");
                 for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                 {
                     Gid = Ds.Tables[0].Rows[i]["agroupid"].ToString();
                     Purticulars = Ds.Tables[0].Rows[i]["agroupname"].ToString();
                     Lid = _ComEvent.DatasetToString("select lid from tblaccountledger where agroupid in(" + Gid + ")", "lid");
                     if (Lid != "")
                     {
                         if (Generalfunction.BlShowEst == true || Generalfunction.BlShowEst == false)
                         {
                           if(Mode=="LIABILITY")
                               Temp = _Dbtask.ExecuteScalar("select sum(cramt-dbamt) from tblgeneralledger where ledcode in(" + Lid + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59'");
                           else
                             Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + Lid + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59'");
                         }
                         else
                         {
                             string Estlid = CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate", "lid");
                             if (Estlid != "")
                             {
                                 Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + Lid + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='" + Estlid + "'");
                             }
                         }

                         TCashAmount = _Dbtask.znullDouble(Temp);
                      //  TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount);
                         if (TCashAmount != 0)
                         {
                             if (Mode == "LIABILITY")
                             {
                                 RowCountingLiabilty = GridMain.Rows.Add(1);
                                 GridMain.Rows[RowCountingLiabilty].Tag = Gid;
                                 GridMain.Rows[RowCountingLiabilty].Cells["clnlaibilities"].Value = Purticulars;
                                 GridMain.Rows[RowCountingLiabilty].Cells["clnlamount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                                 BalancsheetGroupBalance(Gname, TCashAmount);
                             }
                             else if (Mode == "ASSET")
                             {

                                 if (RowCountingAsset > RowCountingLiabilty)
                                     RowCountingAsset = GridMain.Rows.Add(1);
                                 GridMain.Rows[RowCountingAsset].Tag = Gid;
                                 GridMain.Rows[RowCountingAsset].Cells["clnassets"].Value = Purticulars;
                                 GridMain.Rows[RowCountingAsset].Cells["clnAamount"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                                 BalancsheetGroupBalance(Gname, TCashAmount);
                                 RowCountingAsset++;
                             }
                         }
                     }
                 }
             }
        }

        public double TraidingAccountFilling(string GroupName, DateTime DateFrom, DateTime DateTo,string Field)
        {
             string   GroupName1 = _SelectReport.Showindataset("select agroupid from tblaccountgroup where aunder='"+GroupName+"'");
             GroupName1 = _ComEvent.DatasetToString("select lid from tblaccountledger where agroupid in(" + GroupName + ")", "lid");
             if (GroupName1 != "")
             {
                 Temp = _Dbtask.ExecuteScalar("select sum("+Field+") from tblgeneralledger where ledcode in(" + GroupName1 + ") and vdate between '" + DateFrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DateTo.ToString("MM/dd/yyyy") + " 23:59:59'");
                 TCashAmount = _Dbtask.znullDouble(Temp);
                 TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount); 
              }
             return TCashAmount;  
        }
        

        public void TrailBalanceFilling(string GroupName, DataGridView GridMain, double TDrAmount, double TCrAmount,string Purticulars,string Mode,string Where,DateTime Dtfrom,DateTime Dtto)
        {

         string   GroupName1 = _SelectReport.Showindataset("select agroupid from tblaccountgroup where aunder in ("+GroupName+")");
         GroupName1 = _ComEvent.DatasetToString("select lid from tblaccountledger where agroupid in(" + GroupName + ") " + Where + "", "lid");
            if (GroupName1 != "")
         {
             if (Generalfunction.BlShowEst == true || Generalfunction.BlShowEst == false)
                {
                    Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + GroupName1 + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59'");
                }
                else
                {
                     string Estlid=CommonClass._Ledger.GetSpecificfieldBaseonName("Estimate","lid");
                     if (Estlid != "")
                     {
                         Temp = _Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where ledcode in(" + GroupName1 + ") and vdate between '" + Dtfrom.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.ToString("MM/dd/yyyy") + " 23:59:59' and refno !='"+Estlid+"'");
                     }
                }

             TCashAmount = _Dbtask.znullDouble(Temp);
             TCashAmount = _ComEvent.RemoveMInesinAmount(TCashAmount);
             if (Mode == "DR")
             {
                 if (_Dbtask.znullDouble(Temp) > 0)
                 {
                     Count = GridMain.Rows.Add(1);
                     GridMain.Rows[Count].Tag = GroupName1;
                     GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                     GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                     MTDrAmount = MTDrAmount + TCashAmount;
                 }
                 else if (_Dbtask.znullDouble(Temp) < 0)
                 {
                     Count = GridMain.Rows.Add(1);
                     GridMain.Rows[Count].Tag = GroupName1;
                     GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                     GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                     MTCrAmount = MTCrAmount + TCashAmount;
                 }
             }
             else
             {
                 if (_Dbtask.znullDouble(Temp) < 0)
                 {
                     Count = GridMain.Rows.Add(1);
                     GridMain.Rows[Count].Tag = GroupName1;
                     GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                     GridMain.Rows[Count].Cells["clncredit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                     MTCrAmount = MTCrAmount + TCashAmount;
                 }
                 else if (_Dbtask.znullDouble(Temp) > 0)
                 {
                     Count = GridMain.Rows.Add(1);
                     GridMain.Rows[Count].Tag = GroupName1;
                     GridMain.Rows[Count].Cells["clnpurticulars"].Value = Purticulars;
                     GridMain.Rows[Count].Cells["clndebit"].Value = _Dbtask.SetintoDecimalpoint(TCashAmount);
                     MTDrAmount = MTDrAmount + TCashAmount;
                 }
             }
             if (_Dbtask.znullDouble(Temp) > 0 || _Dbtask.znullDouble(Temp) < 0)
             {
                 GridMain.Rows[Count].Cells["clnpurticulars"].Tag = GroupName;
             }
         }
            
        }
    }
}
