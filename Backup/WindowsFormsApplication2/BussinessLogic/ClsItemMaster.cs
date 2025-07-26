using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Win32;
using System.Drawing.Imaging;

namespace WindowsFormsApplication2
{
    class ClsItemMaster
    {
        public int StatusInt;
        public long SidLng;
        public long ItemIdLng;
        public string ItemCodeStr = "";
        public string ItemNameStr = "";
        public string ItemnoteStr = "";
        public long CategoryIdLng;
        public string DescriptionStr = "";
        public double MRPDb=0;
        public double SRateDb=0;
   public static  string depotnobatch="";
        public double PRateDb=0;
        public long ManufacturerLng=0;
        public double AgentCommisionDb=0;
        public double CoolyDb=0;
        public double MinStockDb=0;
        public double ReorderStockDb=0;
        public double MaximumDb=0;
        public long TaxSlabIdLng=0;
        public double Balance=0;
        public string Unit="Pc";
        public double VAT=0;
        public double CST=0;
        public double Purtax=0;
        public int Incs=0;
        public int Incp=0;
        public string Rack = "";
        public string ItemClass = "";
        public string Sizelessname = "";
        public string PLU = "";
        public string SecndUnit = "";
        public double UnitAmunt1 = 0;
        public double UnitAmunt2 = 0;
        public string Localaungage = "";
        public string Bunit = "";
        public float Ledid = 0;
        public int Usingmechine;
        public string rackname = "";


        public DataSet Ds;
        DBTask _Dbtask = new DBTask();
        Clscommenevent _Comevent = new Clscommenevent();

        public void InsertItemsPara(long IItemidF,string IItemcodeF,string IItemnameF,long ICategoryIdF,string IDescriptionF,
            double IMrpF,double ISrateF,double IPrateF,long ImanfacturerF,int IStatusF,double IAgentCommisionF,
           double ICoolyF,double IMinstockF,string IRackF,double IReorderF,double IMaximumF,
            long ITaxidF,double IBalanceF,string IUnitF,double IVatF,double ICstF,double IPurtaxF,
            int IIncsF,int IIncpF,string IItemclassF,string ISizelessnameF,string IPlusF,
            string IUnit2F,double IUnitAmnt1F,double IUnitAmnt2F,float ILedidF, string LocalaungageF,
     string BunitF, int UsingmechineF, string ItemnoteStrF)
        {
            
            {

              SecndUnit = IUnit2F;
              UnitAmunt1 = IUnitAmnt1F;
              UnitAmunt2 = IUnitAmnt2F;
              ItemIdLng=IItemidF;
              ItemCodeStr=IItemcodeF;
              ItemNameStr=IItemnameF;
              CategoryIdLng=ICategoryIdF;
              DescriptionStr=IDescriptionF;
              MRPDb=IMrpF;
              SRateDb=ISrateF;
              PRateDb=IPrateF;
              ManufacturerLng=ImanfacturerF;
              StatusInt=IStatusF;
              AgentCommisionDb=IAgentCommisionF;
              CoolyDb=ICoolyF;
              MinStockDb=IMinstockF;
              Rack=IRackF;
              ReorderStockDb=IReorderF;
              MaximumDb=IMaximumF;
              TaxSlabIdLng=ITaxidF;
              Balance=IBalanceF;
              Unit=IUnitF;
              VAT=IVatF;
              CST=ICstF;
              Purtax = IPurtaxF;
              Incs=IIncsF;
              Incp=IIncpF;
              ItemClass=IItemclassF;
              Sizelessname=ISizelessnameF;
              PLU = IPlusF;
              Ledid = ILedidF;
               Localaungage=LocalaungageF;
               Bunit=BunitF;
               Usingmechine = UsingmechineF;
               ItemnoteStr = ItemnoteStrF;
              InsertItems();
            }
 
        }
        public DataSet ShowSupplierwiseitem(string Lid)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where ledid='" + Lid + "'");
            return Ds;
            //SqlDbType.Image;
        }
        public void InsertItems()
        {
            object[,] objArg = new object[36, 2]
            {

              {"@Unit2",SecndUnit},
              {"@UnitAmount1",UnitAmunt1},
              {"@UnitAmount2",UnitAmunt2},
               
              {"@ItemId",ItemIdLng},
              {"@ItemCode",ItemCodeStr},  
              {"@ItemName",ItemNameStr},
              {"@Itemnote",ItemnoteStr}, 
              {"@CategoryId",CategoryIdLng},
              {"@Description",DescriptionStr},
              {"@MRP",MRPDb},
              {"@SRate",SRateDb},
              {"@Prate",PRateDb},
              {"@Manufacturer",ManufacturerLng},
              {"@Status",StatusInt},
              {"@AgentCommision",AgentCommisionDb},
              {"@cooly",CoolyDb},
              {"@Minstock",MinStockDb},
              {"@rack",Rack},
              {"@reorder",ReorderStockDb},
              {"@maximum",MaximumDb},
              {"@taxslabid",TaxSlabIdLng},
              {"@Balance",Balance},
              {"@Unit",Unit},
              {"@VAT",VAT},
              {"@CST",CST},
              {"@Purtax",Purtax},
              {"@incs",Incs},
              {"@incp",Incp},
              {"@itemclass",ItemClass},
              {"@Sizelessname",Sizelessname},
              {"@plu",PLU},
               {"@Ledid",Ledid},
               {"@llang",Localaungage},
                 {"@Bunit",Bunit},
                 {"@Usingmechine",Usingmechine},
                 {"@rackname",rackname}

            };
            _Dbtask.ExecuteNonQuery_SP("InsertItemMaster", objArg);
            return;
        }
        public void UpdateBalance(string Argiment,string ItemId,double SBalance)
        {
            _Dbtask.ExecuteNonQuery("Update Tblitemmaster set balance=balance" + Argiment + "" + SBalance + " where ItemId='"+ItemId+"'");

        }
        public void UpdateField(string ItemId, double Rate,string Field)
        {
            _Dbtask.ExecuteNonQuery("Update Tblitemmaster set "+Field+" ="+Rate+"  where ItemId='" + ItemId + "'");

        }

        public DataSet getfinishedproduct(string what)
        {



            //Ds = _Dbtask.ExecuteQuery("select itemname,tblbatch.BCODE,tblbatch.itemid from tblitemmaster "+
            //" INNER JOIN tblbatch ON TblItemMaster.ItemId =tblbatch.itemid  "+
            //" where itemclass='Finished Product' or  itemclass='Finished Product2'   "+
            //" and  bcode like N'%" + what + "%' or itemname like N'%" + what + "%'");
            //return Ds;


            Ds = _Dbtask.ExecuteQuery("select TblItemMaster.itemname,tblbatch.BCODE,TblItemMaster.itemid " +
                  "  from tblbatch INNER JOIN TblItemMaster ON   " +
               "  tblbatch.itemid =TblItemMaster.ItemId     " +
               "  where  (tblbatch.BCODE like N'%" + what + "%' or TblItemMaster.itemname like N'%" + what + "%' )  and " +
              " TblItemMaster.itemclass in ('Finished Product2','Finished Product') ");
            return Ds;
        
        
        }

        public DataSet getbatchwiseprodctionitem(string what)
        {
          Ds =  _Dbtask.ExecuteQuery("select BCODE,ITEMID,tblitemmaster.itemname from tblitemmaster  "+
              " INNER JOIN tblproductsett ON TblItemMaster.ItemId =tblproductsett.item    "+
              " where bcode like N'%" + what + "%' or  tblitemmaster.itemname like N'%" + what + "%'   ");
          return Ds;
        }

        public DataSet getITEMwiseprodctionitem(string what)
        {
            Ds = _Dbtask.ExecuteQuery("select ITEMID,tblitemmaster.itemname from tblitemmaster  " +
                " INNER JOIN tblproductsett ON TblItemMaster.ItemId =tblproductsett.item    " +
                " where  tblitemmaster.itemname like N'%" + what + "%'   ");
            return Ds;
        }

        public DataSet getproductnormal(string what)
        {
            Ds = _Dbtask.ExecuteQuery("select tblbatch.BCODE,tblbatch.ITEMID,ITEMcode,itemname from tblitemmaster  " +
                " INNER JOIN tblbatch ON TblItemMaster.ItemId =tblbatch.itemid   " +
                " where tblbatch.bcode like N'%" + what + "%' or  itemname like N'%" + what + "%'   ");
            return Ds;
        }

        public double getcostrate(string bcodes, string id)
        {
            double costofitem = 0;

            if (_Dbtask.znllString(CommonClass._Itemmaster.SpecificField(id, "incp")) == "-1")
            {
            
            costofitem = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select  CONVERT(DECIMAL(10,2), (((tblitemmaster.vat* tblbatch.prate)/100 ) + tblbatch.prate))  " +
           " as costrate from tblbatch " +
           "  INNER JOIN TblItemMaster  " +
            "  ON Tblbatch.itemid= TblItemMaster.ItemId where tblbatch.bcode='" + bcodes + "'"));
            }
            else
            {
                costofitem = _Dbtask.znlldoubletoobject(_Dbtask.ExecuteScalar("select prate from tblbatch where bcode='" + bcodes + "'"));
            }



            return costofitem;
        }
        public void UpdateFieldSp(string ItemId, string Rate, string Field)
        {
            _Dbtask.ExecuteNonQuery("Update Tblitemmaster set " + Field + " ='" + Rate + "'  where ItemId='" + ItemId + "'");

        }
        public DataSet dresss(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select itemid,itemname as material,categoryid from tblitemmaster  " + Where + "");
            return Ds;
        }
        public bool SameCodealreadyexist(string Itemcode)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where Itemcode=N'" + Itemcode + "' and status=1");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void IdItemName()
        {
            ItemIdLng =Convert.ToInt64(Generalfunction.getnextid("itemid","TblitemMaster"));
        }
        public void FillCombo(ComboBox Cmb)
        {
            Generalfunction.fillDatainCombowithQuery(Cmb, "itemid", "itemName", "TblItemmaster", "SELECT * FROM TblItemmaster ");
        }

        public DataSet ShowItemsProductName(string Where, int Join)
        {
            string LikeEvent = _Comevent.ItemSearch(Where);

            if (Join == 0)
            {
                Ds = _Dbtask.ExecuteQuery("select * from TblItemmaster where status =1 and (itemCode like N'%" + Where + "%'  OR itemName like N'%" + Where + "%'  OR llang like N'%" + Where + "%' )");
            }
            else if(Join==1)
            {





                Ds = _Dbtask.ExecuteQuery("  SELECT     Tblbatch.Bcode as Barcode,TblItemMaster.ItemId, " +
 "  TblItemMaster.Itemcode, TblItemMaster.ItemName,  " +
 "  TblItemMaster.llang,convert(varchar,Tblbatch.exdate,103) as 'Ex Date',   " +
   "  Tblbatch.prate as prate, Tblbatch.srate as srate, Tblbatch.mrp as mrp,  " +
  "  TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  " +
  "  TblItemMaster Inner JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid   " +
  "  " + Where + "  ");












//                Ds = _Dbtask.ExecuteQuery(" SELECT     Tblunitsrates.Barcode, Tblunitsrates.Uid, tblUnitcreation.name AS Unit,TblItemMaster.Itemcode,TblItemMaster.Itemid, TblItemMaster.ItemName, Tblunitsrates.Prate,Tblunitsrates.wrate, Tblunitsrates.Srate, " +
// " TblItemMaster.CategoryId, TblItemCategory.Category " +
//"FROM         Tblunitsrates INNER JOIN " +
//                     "TblItemMaster ON Tblunitsrates.Itemid = TblItemMaster.ItemId INNER JOIN  " +
//                  "  tblUnitcreation ON Tblunitsrates.Uid = tblUnitcreation.id   INNER JOIN " +
//                    " TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId" +
//           " where   ( " + Where + ")  " +
//               " order by TblItemMaster.itemname asc ");


                //Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, Tblbatch.prate, Tblbatch.srate,Tblbatch.mrp," +
                //"TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + " " +
                //" AND (TblItemMaster.CategoryId = '" + Itemcategoryid + "')");

                //Ds = _Dbtask.ExecuteQuery("SELECT     TblItemMaster.itemid as itemid, TblItemMaster.Itemcode as itemcode" +
                //",TblItemMaster.itemname as Itemname ,TblItemMaster.mrp as Mrp" +
                //",TblItemMaster.prate as Prate,TblItemMaster.srate as Srate,TblProductRate.rate as WRate" +
                //" FROM         TblItemMaster left JOIN" +
                //" TblProductRate ON TblItemMaster.ItemId = TblProductRate.Pcode" +
                //" GROUP BY TblItemMaster.itemid,TblItemMaster.Itemcode,TblItemMaster.itemname,TblItemMaster.mrp,tblitemmaster.status" +
                //",TblItemMaster.prate,TblItemMaster.srate,TblProductRate.rate " + Where + " and tblitemmaster.status=1 ");
            }
            else if (Join == 2)
            {
                Ds = _Dbtask.ExecuteQuery("select * from TblItemmaster "+Where+" and status=1");
            }
            return Ds;

        }
        public DataSet ShowItemsBaseonCategory(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("SELECT     TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, TblItemMaster.MRP, TblItemMaster.SRate, TblItemMaster.PRate, " +
                          "TblItemCategory.Category FROM         TblItemMaster INNER JOIN " +
                          "TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId   INNER JOIN  tblinventory ON  TblItemMaster.ITEMID = tblinventory.PCODE    "+depotnobatch+"  "+
                          " and status=1  "+Where+"  " );
                         
            return Ds;

        }
        public DataSet ShowItemsProductNameBaseonBarcodepurchase(string Where, string Joint, string Itemcategoryid)
        {


            Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode as barcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName,TblItemMaster.ItemName,TblItemMaster.llang as 'Second', Tblbatch.prate, Tblbatch.srate,Tblbatch.mrp," +
                "TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + " ");
            //Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName,convert(varchar,Tblbatch.exdate,103) as 'Ex Date', Tblbatch.prate, Tblbatch.srate,Tblbatch.mrp," +
            // "TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + " ");AND (TblItemMaster.CategoryId = '" + Itemcategoryid + "')"
            return Ds;
        }

        public DataSet ShowItemsProductNameBaseonBarcode(string Where,string Joint,string Itemcategoryid)
        {
            if (Itemcategoryid == "" || Itemcategoryid=="0")
            {
                if(_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("207") )=="1")
                {

                Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, TblItemMaster.llang,convert(varchar,Tblbatch.exdate,103) as 'Ex Date', "+
              "   Tblbatch.prate as prate, Tblbatch.srate as srate, Tblbatch.mrp as mrp, "+
              " TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + "   AND  "+
             "  TblItemMaster.ITEMCLASS!='Row Material'     order by TblItemMaster.itemname asc ");

                }
                else
                {
                
                Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, TblItemMaster.llang,convert(varchar,Tblbatch.exdate,103) as 'Ex Date', " +
                 "   Tblbatch.srate as srate, Tblbatch.mrp as mrp, " +
                 "TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + " order by TblItemMaster.itemname asc ");
                }
            }
            else
            {
                Ds = _Dbtask.ExecuteQuery("SELECT     Tblbatch.Bcode,TblItemMaster.ItemId, TblItemMaster.Itemcode, TblItemMaster.ItemName, Tblbatch.prate, Tblbatch.srate,Tblbatch.mrp," +
                "TblItemMaster.rack, TblItemMaster.Incs, TblItemMaster.IncP FROM  TblItemMaster " + Joint + " JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid " + Where + " " +
                " AND (TblItemMaster.CategoryId = '" + Itemcategoryid + "')");
            }

            return Ds;
        }
        public string Getitemid(string Itemcode)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select itemid from TblItemmaster where itemcode=N'" + Itemcode + "' and Status=1");
            return Specific;
        }
        public string SpecificField(string Itemid,string FiledName)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select " + FiledName + " from TblItemmaster where itemid='" + Itemid + "' and Status=1");
            return Specific;
        }
        public double StockQty(string Wherewithand)
        {
            double Add = Convert.ToDouble(_Dbtask.ExecuteScalar("select  isnull(  Sum(qty),0) from TblInventory where vtype='1' " + Wherewithand + ""));
            double Less = Convert.ToDouble(_Dbtask.ExecuteScalar("select  isnull(  Sum(qty),0) from TblInventory where vtype='-1' " + Wherewithand + ""));
            double Stock = Add - Less;
            return Stock;
        }

        public void ExNonQuery(string Str)
        {
          _Dbtask.ExecuteNonQuery(Str);
        }
        public void Shoitems(string txt,DataGridView Gridname)
        {

            //Gridname.Rows.Clear();
            Ds =_Dbtask.ExecuteQuery("select itemname,itemid from TblItemmaster where itemname like N'%"+txt+"%' and Status=1");
                Gridname.DataSource = Ds.Tables[0];
                Gridname.Columns[1].Visible = false;
                Gridname.Columns[0].Width = 200;
                //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                //{
                //    Gridname.Rows.Add(1);
                //    Gridname.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["itemname"].ToString();
                //    Gridname.Rows[i].Cells[].Tag = Ds.Tables[0].Rows[i]["itemid"].ToString();
                //}
                Gridname.Visible = true;
        }

    }

     
       
}
