using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsInventory
    {
        string InclQuey;

        public string Vcode = "";
        public string Ledcode = "";
        public string DCodeStr = "";
        public DateTime InvDateDt;
        public string PcodeStr = "";
        public double Os = 0;
        public double Purchase = 0;
        public double Mr = 0;
        public double Sr = 0;
        public double Ireceipt = 0;
        public double Bmr = 0;

        public double Sales = 0;
        public double ps = 0;
        public double Dn = 0;
        public double Pr = 0;
        public double Dnr;

        public double Iissue = 0;
        public double Sh = 0;
        public double Dmg = 0;
        public double freepre = 0;
        public double freeiss = 0;

        public double Bmi = 0;
        public double UC = 0;
        public string Stock;
        public DataSet Ds;
        public string Sql = "";

        public string Vtype = "";
        public string Costcenter="0";
        public string Batchcode="0";
        public string Slno = "0";
        public DateTime Exdate = Convert.ToDateTime("01-01-1900 00:00:00");
        DBTask _Dbtask = new DBTask();

        

        public void InsertInventory()
        {
            object[,] objArg = new object[28, 2]
        {
            {"@Dcode",DCodeStr},
            {"@InvDate",InvDateDt},  
            {"@pcode",PcodeStr},
            {"@Os",Os},
            {"@Purchase",Purchase},
            {"@Mr",Mr},
            {"@Sr",Sr},
            {"@Ireceipt",Ireceipt},  
            {"@bmr",Bmr},
            {"@Sales",Sales},
            {"@dn",Dn},
            {"@dnr",Dnr},
            {"@Pr",Pr},
            {"@Ps",ps},
            {"@freepre",freepre},
            {"@freeiss",freeiss},
            {"@Iissue",Iissue},
            {"@sh",Sh},  
            {"@Dmg",Dmg},
            {"@bmi",Bmi},
            {"@vcode",Vcode},
            {"@ledcode",Ledcode},
            {"@costcenter",Costcenter},
            {"@batchcode",Batchcode},
            {"@Slno",Slno},
            {"@uc",UC},
            {"@Exdate",Exdate},
            {"@Vtype",Vtype}
        };
            _Dbtask.ExecuteNonQuery_SP("InsertInventory", objArg);
            return;
        }

        public double GetStock(string BCode, DateTime ExprDate)
        {
            double Stock = CommonClass._Inventory.GetStock(" where batchcode='" + BCode + "' and exdate ='" + ExprDate.ToString("MM/dd/yyyy") + "'");
            return Stock;
        }
        public double GETSTOCKBYUNIT(string BATCH)
        {
            double stk = 0;
            stk = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT     (select  { fn IFNULL(  SUM((Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)/ (1)),0) }  " +
              "  -   { fn IFNULL(    SUM((sales+dn+pr+iissue+sh+dmg+bmi+freeiss )/(1) ),0) } )from TblInventory where  batchcode='" + BATCH + "' "));
            return stk;

        }
        public double GETSTOCKBYBARCODE(string BATCH)
        {
            double stk = 0;
            stk = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("SELECT     (select   SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)  " +
              "  -      SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) )from TblInventory where  batchcode='" + BATCH + "' "));
            return stk;

        }
        public double DbStockvalue(string Where, string SelRate, DateTime Pdtfrom, DateTime Pdtto)
        {
          
            if(CommonClass._settings.ReturnStatus("103")=="1")
            {
                 CommonClass._Dbtask.ExecuteNonQuery("update tblinventory set sr=0 where sr=null");

                 if (SelRate == "Srate")
                 {
                     InclQuey = " TB.srate ";
                 }

                 if (SelRate == "Prate")
                 {
                     InclQuey = " TB.prate ";
                 }
                 Where = InclQuey + Where;

                 Ds = _Dbtask.ExecuteQuery("SELECT     IM.ItemId, CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.Itemcode order by IM.Itemcode ) = 1 " +
                     " THEN  IM.Itemcode ELSE NULL END AS 'Itemcode'," +
                     " CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IM.ItemName order by IM.ItemName ) = 1 " +
                     " THEN  IM.ItemName ELSE NULL END AS 'ItemName'" +
                     " , TB.Bcode," + InclQuey + ",(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)- " +
                     " SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                     "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                     " ) as Qty, " +
                     "(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                      "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                     " )* " + InclQuey + " - " +
                     " (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode " +
                     "  and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
                     " ) * " + InclQuey + "  as TotalValue " +
                      " FROM         TblItemMaster AS IM INNER JOIN Tblbatch AS TB ON IM.ItemId = TB.itemid INNER JOIN " +
                      "TblInventory AS inv ON IM.ItemId = inv.PCode and inv.invdate between " +
                    "   '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'   " +
                      "GROUP BY IM.ItemId, IM.Itemcode, IM.ItemName,TB.Bcode,inv.dcode,inv.pcode,IM.itemclass,  " + Where + " ");
                
            }
            else
            {
                if (SelRate == "Srate")
                {
                    InclQuey = " IMS.srate ";
                }
                if (SelRate == "Prate")
                {
                    InclQuey = " IMS.prate ";
                }
                Where = InclQuey + Where;

            Ds = _Dbtask.ExecuteQuery("SELECT CASE WHEN ROW_NUMBER() OVER(PARTITION BY  IMS.CategoryId order by IMS.CategoryId ) = 1  " +
            " THEN ( select category from tblitemcategory where categoryid= IMS.CategoryId)" +
            " ELSE ' ' END AS 'Group', " +
            "  IMS.Itemcode, IMS.ItemName, IMS.ItemId, IMS.PRate AS rate,(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  " +
            "          SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from TblInventory  where pcode=IMS.ItemId  " +
            "          and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59' " +
            "        ) as Qty, " +
            "          (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps) from TblInventory where pcode=IMS.ItemId  " +
            "        and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'  " +
            "     )* IMS.PRate - " +
            "    (select SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss) from TblInventory where pcode=IMS.ItemId  " +
            "    and invdate between '" + Pdtfrom.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Pdtto.ToString("MM-dd-yyyy") + " 23:59:59'    " +
            "  ) * IMS.PRate  as TotalValue   " +
            " FROM         TblItemMaster AS IMS INNER JOIN " +
            "                   TblInventory AS INV ON IMS.ItemId = INV.PCode " +
            " GROUP BY IMS.Itemcode, IMS.ItemName, IMS.CategoryId, IMS.ItemId, INV.DCode, IMS.Itemclass ," + Where + "");
           }
            object sumObject;
            sumObject = Ds.Tables[0].Compute("Sum(Totalvalue)", "");
            // Stock= 
            return _Dbtask.znullDouble(sumObject.ToString());
        }



      
        public void InsertInventoryPara(string IDCodeStr,DateTime IInvDateDt,string IPcodeStr,double  IOs,double  IPurchase,double IMr,
            double ISr,double IIreceipt,double IBmr,double ISales,double IDn,double IDnr,double IPs,double IPr,double Ifreepre
,double Ifreeiss,double IIIissue,double ISh,double IDmg,double IBmi,string  IVcode,string ILedcode,string ICostcenter,string IBatchcode,string ISlno)
        {
            DCodeStr=IDCodeStr;
            InvDateDt=IInvDateDt;
            PcodeStr=IPcodeStr;
            Os=IOs;
            Purchase=IPurchase;
            Mr=IMr;
            Sr=ISr;
            Ireceipt=Ireceipt;
            Bmr=IBmr;
            Sales=ISales;
            Dn=IDn;
            Dnr=IDnr;
            ps = IPs;
            Pr=IPr;
            freepre=Ifreepre;
            freeiss=Ifreeiss;
        }

        public void DeleteInventory()
        {

            object[,] objArg = new object[16, 2]
        {
             {"@Dcode",DCodeStr},
            {"@InvDate",InvDateDt},  
            {"@pcode",PcodeStr},
            {"@Os",Os},
            {"@Purchase",Purchase},
            {"@Mr",Mr},

            {"@Sr",Sr},
            {"@Ireceipt",Ireceipt},  
            {"@bmr",Bmr},
            {"@Sales",Sales},
            {"@dn",Dn},
            {"@Pr",Pr},
            {"@Iissue",Iissue},
            {"@sh",Sh},  
            {"@Dmg",Dmg},
            {"@bim",Bmi}
        };
            _Dbtask.ExecuteNonQuery_SP("DeleteInventory", objArg);
            return;
        }

        public DataSet ShowsearchinItem(string str, string StockArea)
        {
            Sql = "SELECT    (select dname from tbldepot where dcode= TblInventory.dcode )as 'Stock Area',  TblItemMaster.ItemName, " +
                  "  { fn IFNULL(SUM(TblInventory.Os + TblInventory.Purchase + TblInventory.Mr + TblInventory.Sr + TblInventory.Ireceipt + TblInventory.bmr + TblInventory.freepre + TblInventory.ps "+
                  "  + TblInventory.Dnr)- SUM(TblInventory.Sales + TblInventory.dn + TblInventory.pr + TblInventory.iissue + TblInventory.sh + TblInventory.dmg + TblInventory.bmi + TblInventory.freeiss), 0)  "+
                  "  } AS Stock FROM         TblItemMaster INNER JOIN "+
                  "  TblInventory ON TblItemMaster.ItemId = TblInventory.PCode "+
                  " GROUP BY TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, TblItemMaster.rack, TblItemMaster.Incs, "+
                  " TblItemMaster.IncP, TblInventory.DCode HAVING (TblItemMaster.Itemcode LIKE '"+str+"%') OR "+
                  " (TblItemMaster.ItemName LIKE '"+str+"%') OR (TblInventory.DCode in ("+StockArea+"))";

            Sql = "SELECT     TblItemMaster.ItemName, Tblunitsrates.Srate, Tblunitsrates.Mrp, Tblunitsrates.Wrate " +
                   " FROM         TblItemMaster INNER JOIN Tblunitsrates ON TblItemMaster.ItemId = Tblunitsrates.Itemid" +
                   " WHERE     (TblItemMaster.ItemName LIKE '%"+str+"%')";
            Ds = _Dbtask.ExecuteQuery(Sql);
            return Ds;
        }

        public DataSet ShowsearchinItemwithBarcode(string str,string StockArea)
        {
            Sql = "SELECT    TblItemMaster.ItemId, Tblbatch.Bcode , " +
 " TblItemMaster.ItemName,  Tblbatch.srate , Tblbatch.prate,Tblbatch.mrp     FROM         TblItemMaster  " +
" INNER JOIN                     Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid group by " +
" TblItemMaster.ItemId,TblItemMaster.Itemcode, TblItemMaster.ItemName, Tblbatch.mrp, Tblbatch.srate, Tblbatch.prate," +
 " Tblbatch.Bcode, TblItemMaster.rack, TblItemMaster.Incs" +
", TblItemMaster.IncP" +
            " having     (TblItemMaster.Itemcode " + str + ") OR " +
            "                   (TblItemMaster.ItemName " + str + ") OR " +
            "                  (Tblbatch.Bcode  " + str + ") ";
            Ds = _Dbtask.ExecuteQuery(Sql);
            return Ds;
        }

        public double GetStock(string Where)
        {
            Stock = _Dbtask.ExecuteScalar("select { fn IFNULL(sum(os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps+dnr)-sum(sales+dn+pr+iissue+sh+dmg+bmi+freeiss),0)} from tblinventory "+Where+"");
         double DbStock=_Dbtask.znullDouble( Stock);
         return DbStock;
        }

        public double SumofField(string Field,string Where)
        {
            Stock = _Dbtask.ExecuteScalar("select { fn IFNULL(sum("+Field+"),0)} from tblinventory " + Where + "");
            double DbStock = _Dbtask.znullDouble(Stock);

            return DbStock;

        }

        public DataSet ShowStockList(string Where)
        {
            Sql = "SELECT        SUM(TblInventory.Os + TblInventory.Purchase + TblInventory.Mr + TblInventory.Sr + TblInventory.Ireceipt + TblInventory.bmr+ TblInventory.dnr+ TblInventory.freepre+ TblInventory.ps) " +
           "  - SUM(TblInventory.Sales + TblInventory.dn + TblInventory.pr + TblInventory.iissue + TblInventory.sh + TblInventory.dmg + TblInventory.bmi+TblInventory.freeiss) AS stock, " +
          "   TblInventory.PCode, TblItemMaster.ItemName, TblItemMaster.Itemcode, TblItemCategory.Category , TblItemMaster.PRate" +
" FROM  TblInventory INNER JOIN      TblItemMaster ON TblInventory.PCode = TblItemMaster.ItemId CROSS JOIN " +
" TblItemCategory GROUP BY TblInventory.PCode, TblItemMaster.ItemName, TblItemMaster.Itemcode, TblItemCategory.Category,TblItemMaster.PRate";
            Ds = _Dbtask.ExecuteQuery(Sql);
            return Ds;

        }


    }
}
