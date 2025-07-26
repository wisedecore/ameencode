using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApplication2
{
    class clsitemCategory
    {
        public long CategoryIdLng;
        public string CategoryNameStr = "";
        public string RemarkStr = "";
        public string showinsummery = "No";
        public string ontable = "No";
        DBTask _Dbtask=new DBTask();
        DataSet ds = new DataSet(); public DataSet Ds;
        DataSet DB = new DataSet();

        public void InsertcatPara(long CategoryIdLngF, string CategoryNameStrF, string RemarkStrF)
        {
            

                CategoryIdLng = CategoryIdLngF;
                CategoryNameStr = CategoryNameStrF;
                RemarkStr = RemarkStrF;
                CommonClass._category.InsertItemCategory();
            

        }



        public void InsertItemCategory()
        {
            object[,] objArg = new object[4, 2]
            {
              {"@CategoryId",CategoryIdLng},
              {"@Category",CategoryNameStr},  
              {"@Remarks",RemarkStr},
              {"@showinsummery",showinsummery}
              

            };
            _Dbtask.ExecuteNonQuery_SP("InsertItemCategory", objArg);
            return;
        }

        public void InsertItemCategoryAzure()
        {
            object[,] objArg = new object[4, 2]
            {
              {"@CategoryId",CategoryIdLng},
              {"@Category",CategoryNameStr},
              {"@Remarks",RemarkStr},
              {"@showinsummery",showinsummery}


            };
            _Dbtask.ExecuteNonQueryAzureServer_SP("InsertItemCategory", objArg);
            return;
        }








        public void FillCombo(ComboBox Cmb,bool AddAll)
        {
            if (AddAll == true)
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "CategoryId", "Category", "TblItemCategory", "select 0 as 'categoryid','All' as 'Category' union all SELECT categoryid,category FROM TblItemCategory ");
            }
            else
            {
                Generalfunction.fillDatainCombowithQuery(Cmb, "CategoryId", "Category", "TblItemCategory", "SELECT * FROM TblItemCategory ");
            }
        }

        public bool SameNamealreadyexist(string category)
        {
            Ds = _Dbtask.ExecuteQuery("select * from TblItemCategory where Category='" + category + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }


        public DataSet showcategoryy(string Where)
        {
            Ds = _Dbtask.ExecuteQuery("select categoryid,category as model from tblitemcategory  " + Where + "");
            return Ds;
        }

        public DataSet Showitemcategory(string Where)
        {
            ds = _Dbtask.ExecuteQuery("select * from TblItemCategory " + Where + "");
            return ds;
        }

        public void IdCategory()
        {
            CategoryIdLng = Convert.ToInt64(Generalfunction.getnextid("CategoryId", "TblItemCategory"));
        }
        public DataSet ListItemidBaseonCategory(string Field, string Categoryid)
        {
            return _Dbtask.ExecuteQuery("select " + Field + " from tblitemmaster where categoryid in (" + Categoryid + ") order by itemname asc");
        }

        public DataSet onlycatgry(string date)
        {
            DB = _Dbtask.ExecuteQuery("SELECT DISTINCT TblItemCategory.categoryid,    "+
             "       TblItemCategory.showinsummery    "+

 "      from(( tblissuedetails    "+

"      INNER JOIN tblitemmaster ON tblissuedetails.pcode = tblitemmaster.itemid)    "+
"      INNER JOIN TblItemCategory ON tblitemmaster.categoryID     "+
"      = (select TblItemCategory.categoryid where TblItemCategory.showinsummery='yes')    "+
"      INNER JOIN tblbusinessissue ON tblissuedetails.issuecode=    "+
 "      tblbusinessissue.issuecode) where "+date+"    "+

"      ORDER BY TblItemCategory.categoryid ASC");
            return DB;

        }
        public DataSet onlycatgryAzure(string date)
        {
            DB = _Dbtask.ExecuteQueryAzureServer("SELECT DISTINCT TblItemCategory.categoryid,    " +
             "       TblItemCategory.showinsummery    " +

 "      from(( tblissuedetails    " +

"      INNER JOIN tblitemmaster ON tblissuedetails.pcode = tblitemmaster.itemid)    " +
"      INNER JOIN TblItemCategory ON tblitemmaster.categoryID     " +
"      = (select TblItemCategory.categoryid where TblItemCategory.showinsummery='yes')    " +
"      INNER JOIN tblbusinessissue ON tblissuedetails.issuecode=    " +
 "      tblbusinessissue.issuecode) where " + date + "    " +

"      ORDER BY TblItemCategory.categoryid ASC");
            return DB;

        }





        public DataSet getcategorywisereportsummery(string date)
        {
            ds = _Dbtask.ExecuteQuery("SELECT  tblissuedetails.netamt,tblissuedetails.pcode,    "+
        "   tblitemmaster.itemid,    " +
 "   tblitemmaster.categoryid,TblItemCategory.showinsummery,    "+
 "   TblItemCategory.category,TblItemCategory.categoryid    "+
  "   from(( tblissuedetails    "+

 "   INNER JOIN tblitemmaster ON tblissuedetails.pcode = tblitemmaster.itemid)    "+
 "   INNER JOIN TblItemCategory ON tblitemmaster.categoryID     "+
 "   = (select TblItemCategory.categoryid where TblItemCategory.showinsummery='yes')    "+
 "   INNER JOIN tblbusinessissue ON tblissuedetails.issuecode=    "+
  "   tblbusinessissue.issuecode) where " + date + "     " +

 "   ORDER BY TblItemCategory.categoryid ASC");

            return ds;
        }


        public DataSet getcategorywisereportsummeryAzure(string date)
        {
            ds = _Dbtask.ExecuteQueryAzureServer("SELECT  tblissuedetails.netamt,tblissuedetails.pcode,    " +
        "   tblitemmaster.itemid,    " +
 "   tblitemmaster.categoryid,TblItemCategory.showinsummery,    " +
 "   TblItemCategory.category,TblItemCategory.categoryid    " +
  "   from(( tblissuedetails    " +

 "   INNER JOIN tblitemmaster ON tblissuedetails.pcode = tblitemmaster.itemid)    " +
 "   INNER JOIN TblItemCategory ON tblitemmaster.categoryID     " +
 "   = (select TblItemCategory.categoryid where TblItemCategory.showinsummery='yes')    " +
 "   INNER JOIN tblbusinessissue ON tblissuedetails.issuecode=    " +
  "   tblbusinessissue.issuecode) where " + date + "     " +

 "   ORDER BY TblItemCategory.categoryid ASC");

            return ds;
        }
        public string SpecificField(string CategoryId, string FiledName)
        {
            string Specific;
            Specific = _Dbtask.ExecuteScalar("select " + FiledName + " from tblitemcategory where categoryid='" + CategoryId + "' ");
            return Specific;
        }

        public string Getid(string CategoryName)
        {
            string Specific;
            if (CategoryName == "None")
            {
                Specific = "0";
            }
            else
            {
                Specific = _Dbtask.ExecuteScalar("select categoryid from tblitemcategory where category='" + CategoryName + "'");
            }
            return Specific;
        }
    }
}
