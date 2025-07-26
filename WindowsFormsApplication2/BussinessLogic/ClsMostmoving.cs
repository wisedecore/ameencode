using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class ClsMostmoving
    {
        public string MMbcode = "";
        public string MMpcode = "";
        public string MMname = "";
        DBTask _Dbtask = new DBTask();
        DataSet Ds;

        public void insertMostMoving()
        {
            object[,] objArg = new object[3, 2]
              {
                {"@MMbcode",MMbcode},
                {"@MMpcode",MMpcode},
                {"@MMname",MMname}
              };
            CommonClass._Dbtask.ExecuteNonQuery_SP("insertMostMoving", objArg);
            return;
        }


        public DataSet getitemsset()
            {
            if (CommonClass._Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("214")) == "1")
            {
                //gridmain.Rows.Clear();
                Ds = _Dbtask.ExecuteQuery("SELECT * FROM TBLMOSTMOVING");

            }
            return Ds;

        }

        public void loaditems(DataGridView gridmain)
        {
            if(CommonClass._Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("214"))=="1")
            {
                //gridmain.Rows.Clear();
                Ds = _Dbtask.ExecuteQuery("SELECT * FROM TBLMOSTMOVING");
                
                if(Ds.Tables[0].Rows.Count>0)
                {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    gridmain.Rows.Add(1);
                                    string bcode="";string pcode="";string itemname="";string itemcode="";
                     double srate = 0; double qty = 1;
                     bcode= _Dbtask.znllString(Ds.Tables[0].Rows[i]["MMbcode"]);
                     pcode = _Dbtask.znllString(Ds.Tables[0].Rows[i]["MMpcode"]);
                    itemname = _Dbtask.znllString(CommonClass._Itemmaster.SpecificField(pcode, "itemname"));

                    itemcode=_Dbtask.znllString(CommonClass._Itemmaster.SpecificField(pcode, "itemcode"));
                    srate =_Dbtask.znlldoubletoobject( CommonClass._Batch.GetSpecificFieldByBarcode("srate", bcode));


                    gridmain.Rows[i].Cells["clnbatch"].Value = bcode;
                    gridmain.Rows[i].Cells["clnitemname"].Value = itemname;
                    gridmain.Rows[i].Cells["clnitemname"].Tag = pcode;
                    gridmain.Rows[i].Cells["clnitemcode"].Value = itemcode;
                    gridmain.Rows[i].Cells["clnqty"].Value = qty;
                    gridmain.Rows[i].Cells["clnsrate"].Value = srate;
                   // CommonClass._Sales.CellEnterCalculationPart();
                    CommonClass._Sales.rowindex = i;
                    CommonClass._Sales.CellEnterCalculationPart();
                
                    CommonClass._Sales.TottalAmountCalculate(true);
                
                
                }
                }
            }

        }





    }
}
