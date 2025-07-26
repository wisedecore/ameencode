using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class Clsbatch
    {
        public string Bcode;
        public string Itemid;
        public long Sid;
        public string Costcenter;
        public string Depo;
        public string Bid;
        public string Ledcode;
        public string Recptcode;
        public double Mrp;
        public double Srate;
        public double Prate;
        public double Lastrate = 0;
        public string MaxBatchcode;
        public string Batchstring;
        public string Batchstring2;
        public string Batchstringfull;
        public string Temp;
        public string baseU = "";
        public double Unconv = 0;
        public double prateper = 0;
        public string ontable = "No";

        public DateTime ManDate=Convert.ToDateTime("01-01-1900");
        public DateTime ExDate = Convert.ToDateTime("01-01-1900");
        DataSet Ds=new DataSet();
        DBTask _Dbtask = new DBTask();
        Clssettings _Settings = new Clssettings();
        ClsParamlist _Paramlist = new ClsParamlist();

        public void InsertbcodePara(string BcodeF,
       string ItemidF, string CostcenterF, string DepoF, string BidF, string LedcodeF,
       string RecptcodeF, double MrpF, double SrateF, double PrateF, double LastrateF,
         string baseUF, double UnconvF, DateTime ManDateF, DateTime ExDateF)
        {
            {

                Bcode = BcodeF;
                Itemid = ItemidF;
                Costcenter = CostcenterF;
                Depo = DepoF;
                Bid = BidF;
                Ledcode = LedcodeF;
                Recptcode = RecptcodeF;
                Mrp = MrpF;
                Srate = SrateF;
                ManDate = ManDateF;
                ExDate = ExDateF;
                Prate = PrateF;
                Unconv = UnconvF;
                Lastrate = LastrateF;
                baseU = baseUF;

                InsertBatch();
            }
        }



        public void InsertBatch()
        {
            object[,] ObjArg = new object[17, 2]
            {
            {"@Bcode",Bcode},
            {"@Itemid",Itemid},
            {"@Costcenter",Costcenter},  
            {"@Depo",Depo},
            {"@Bid",Bid},
            {"@Ledcode",Ledcode},
            {"@Recptcode",Recptcode},
            {"@mrp",Mrp},
            {"@srate",Srate},
            {"@mandate",ManDate},
            {"@exdate",ExDate},
            {"@prate",Prate},
            {"@unconv",Unconv},
            {"@Lastrate",Lastrate},
            {"@baseU",baseU },
            {"@prateperc",prateper},
            {"@ONtable",ontable}
            
        };
            _Dbtask.ExecuteNonQuery_SP("InsertBatch", ObjArg);
            return;
        }

        public void InsertBatchAzure()
        {
            object[,] ObjArg = new object[17, 2]
            {
            {"@Bcode",Bcode},
            {"@Itemid",Itemid},
            {"@Costcenter",Costcenter},
            {"@Depo",Depo},
            {"@Bid",Bid},
            {"@Ledcode",Ledcode},
            {"@Recptcode",Recptcode},
            {"@mrp",Mrp},
            {"@srate",Srate},
            {"@mandate",ManDate},
            {"@exdate",ExDate},
            {"@prate",Prate},
            {"@unconv",Unconv},
            {"@Lastrate",Lastrate},
            {"@baseU",baseU },
            {"@prateperc",prateper},
            {"@ONtable",ontable}

        };
            _Dbtask.ExecuteNonQueryAzureServer_SP("InsertBatch", ObjArg);
            return;
        }


        public bool SameNamealreadyexist(string Bcode)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Bcode + "'");
            if (Ds.Tables[0].Rows.Count > 0 )
            {
                return true;
            }
           
            return false;
        }
        public bool usingmachineexist(string Bcode)
        {
            Ds = _Dbtask.ExecuteQuery("SELECT tblbatch.bcode,tblbatch.itemid " +
                        "from Tblitemmaster " +
                        "INNER JOIN tblbatch ON Tblitemmaster.itemid = tblbatch.itemid " +
                        "WHERE     (Tblitemmaster.Usingmechine ='1' and tblbatch.bcode='" + Bcode + "') ");

            if (Ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public string Howmanyitems(string id)
        {
            string getsingle = "";

            Ds = _Dbtask.ExecuteQuery("select * from tblbatch where itemid='" + id + "'");
            if (Ds.Tables[0].Rows.Count > 1 || Ds.Tables[0].Rows.Count <1)
            {
                getsingle = "NO";
            }
            else
            {
                if (Ds.Tables[0].Rows.Count == 1)
                {
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {


                        getsingle = _Dbtask.znllString(Ds.Tables[0].Rows[i]["bcode"]);
                    }
                }
            }

            return getsingle;
        }


        public bool SameNamealreadyexistNew(string Bcode)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Bcode + "'");
            if (Ds.Tables[0].Rows.Count > 0 )
            {
                return true;
            }

            return false;
        }
        //public bool SameNamealreadyexistMECHINE(string Bcode)
        //{
        //    Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + Bcode + "' AND ");
        //    if (Ds.Tables[0].Rows.Count > 0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
        public string GeUpdateBcodecreatePrefix()
        {
            string A = "";
            if (_Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("BCodeCreatePRFX")) == "")
            {
                A = "";
            }
            else
            {
                A = _Dbtask.znllString(CommonClass._Paramlist.GetParamvalue("BCodeCreatePRFX"));
            }




            return A;
        }

        public double GeUpdateBarcode()
        {
            double A = 0;
            if (_Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("MaxBcode")) == 0)
            {
                A = 100;
            }
            else
            {
            A=_Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("MaxBcode"));
            }

             

          for (int i = 0; i <= 100000; i++)
          {

              if (SameNamealreadyexistNew("00"+A.ToString()) == true)
              {
                  A++;
              }
              else
              {
                  return A;
                 
              }
          }
          return A;
        }

        public void FuupdateStartingBarcode(string PmaxBarcode)
        {
            CommonClass._Paramlist.UpdateParamlist("MaxBcode", "1", PmaxBarcode);
        }

        public string BatchMax()
        {
            //int Year = DateTime.Now.Year - 2010;
            //int Month = DateTime.Now.Month;
            //int Day = DateTime.Now.Day;
            //Batchstring=Year.ToString()+Month.ToString()+Day.ToString();
            // Batchstring = "00";
            Batchstring = _Paramlist.GetParamvalue("Prebarcode");

            CommonClass.Ds3 = _Dbtask.ExecuteQuery("select * from tblbatch where bcode like '" + Batchstring + "%'");

            if (CommonClass.Ds3.Tables[0].Rows.Count == 0)
                CommonClass._Paramlist.UpdateParamlist("MaxBcode", "1", "0");

            CommonClass.temp = CommonClass._Paramlist.GetParamvalue("MaxBcode");
            if (CommonClass.temp == "")
            {
                MaxBatchcode = Generalfunction.getnextid("bid", "tblbatch");
                CommonClass._Paramlist.UpdateParamlist("MaxBcode", "1", MaxBatchcode);
            }
            string str = "SELECT isnull(max(cast(paramvalue as int)),0)+1     AS Expr1 " +
                " FROM         tblparamlist where paramname='MaxBcode'";
            CommonClass.temp = _Dbtask.ExecuteScalar(str);



            MaxBatchcode = CommonClass.temp;
            // Batchstring2 = Generalfunction.getnextid("bcode", "tblbatch");
            MaxBatchcode = BatchcodeSpecified(MaxBatchcode);

            Batchstringfull = Batchstring + MaxBatchcode;
            //Batchstringfull =  MaxBatchcode;
            return Batchstringfull;
        }

       

        public void  CheckbarcodeandreturnMax(DataGridView gridmain,int Rowindex)
        {
            string Bcode = gridmain.Rows[Rowindex].Cells["clnbatch"].Value.ToString();
            string Itemid = gridmain.Rows[Rowindex].Cells["clnitemname"].Tag.ToString();

            //Ds=_Dbtask.ExecuteQuery("select * from tblbatch where itemid !='"+Itemid+"' and bcode='"+Bcode+"'");
            //if (Ds.Tables[0].Rows.Count > 0)
            //{
            //    gridmain.Rows[Rowindex].Cells["clnbatch"].Value = BatchMax();
            //}

        }
        public string GetSpecificFieldofBatchBaseonitemid(string Bcode)
        {

            Ds = _Dbtask.ExecuteQuery("select itemid from tblbatch where bcode='" + Bcode + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                Temp = Ds.Tables[0].Rows[0][0].ToString();
            }
            return Temp;
        }

        public string GetSpecificFieldofBatchWithItemid(string Bcode, string Speciffiled,string Itemid)
        {

            Ds = _Dbtask.ExecuteQuery("select " + Speciffiled + " from tblbatch where bcode='" + Bcode + "' and itemid ='" + Itemid + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                int Tcount = Ds.Tables[0].Rows.Count;
                Temp = Ds.Tables[0].Rows[Tcount - 1][0].ToString();
            }
            return Temp;
        }

        public string GetSpecificFieldofBatch(string Bcode,string Speciffiled)
        {
            
            Ds = _Dbtask.ExecuteQuery("select " + Speciffiled + " from tblbatch where bcode='" + Bcode + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                int Tcount = Ds.Tables[0].Rows.Count;
                Temp = Ds.Tables[0].Rows[Tcount - 1][0].ToString();
            }
            else
            {
                Temp = "1";
            }
            return Temp;
         }

        public string GetSpecificFieldofBatchAzure(string Bcode, string Speciffiled)
        {

            Ds = _Dbtask.ExecuteQueryAzureServer("select " + Speciffiled + " from tblbatch where bcode='" + Bcode + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                int Tcount = Ds.Tables[0].Rows.Count;
                Temp = Ds.Tables[0].Rows[Tcount - 1][0].ToString();
            }
            else
            {
                Temp = "1";
            }
            return Temp;
        }
        public void UpdateFieldbybatch(string batch,string feild,double value)
        {
            _Dbtask.ExecuteNonQuery("Update tblbatch set " + feild + " =" + value + "  where   bcode='" + batch + "' ");
        }

        public void UpdateField(string ItemId, double Rate, string Field,string Bcode,string PExdate)
        {
            _Dbtask.ExecuteNonQuery("Update tblbatch set " + Field + " =" + Rate + "  where ItemId='" + ItemId + "' and bcode='"+Bcode+"'and exdate='"+PExdate+"' ");
        }

        public string BatchcodeSpecified(string Batchcode)
        {
            string Temp = Batchcode;

            if (Batchcode == "1")
            {
                if (CommonClass._Paramlist.GetParamvalue("StrBarcode") != "")
                {
                    Temp = CommonClass._Paramlist.GetParamvalue("StrBarcode");
                    Batchcode = CommonClass._Paramlist.GetParamvalue("StrBarcode");
                }
            }

            if (Batchcode.Length < 3)
            {
                //if (Batchcode.Length == 1)
                //{
                //    Temp = Batchstring + "0" + Batchcode.Substring(1, Batchcode.Length - 1);
                //}
                //if (Batchcode.Length == 2)
                //{
                //    Temp =Batchstring+ "0" + Batchcode.Substring(1,Batchcode.Length-1);
                //}

                if (Batchcode.Length == 1)
                {
                    Temp = "00" + Batchcode;
                }
                if (Batchcode.Length == 2)
                {
                    Temp = "0" + Batchcode;
                }
            }
            return Temp;
        }
        public DataSet DtBarcodeShow(string Itemid)
        {
            Ds = _Dbtask.ExecuteQuery("select bcode from tblbatch where itemid in("+Itemid+")");
            return Ds;
        }

        public string BarcodeShowSingle(string Itemid)
        {
           return  _Dbtask.ExecuteScalar("select bcode from tblbatch where itemid in(" + Itemid + ")");
        }


        public void Batchlistshow(string txt,DataGridView Gridname)
        {
            Ds=_Dbtask.ExecuteQuery("select bcode from tblbatch where bcode like '%"+txt+"%'");
            Gridname.DataSource = Ds.Tables[0];
            //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            //{
            //    Gridname.Rows.Add(1);
            //    Gridname.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["bcode"].ToString();
            //  //  Gridname.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["itemid"].ToString();
            //}
            Gridname.Visible = true;    
        }
        public void BatchlistshowBaseonItem(string Itemid, DataGridView Gridname, string Bcode)
        {
            Ds = _Dbtask.ExecuteQuery("select bcode from tblbatch where itemid='" + Itemid + "' and bcode like '%" + Bcode + "%'");
            Gridname.Rows.Clear();
            Gridname.Columns.Clear();
            Gridname.Columns.Add("cln1", "");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Gridname.Rows.Add(1);
                Bcode = Ds.Tables[0].Rows[i][0].ToString();
                Gridname.Rows[i].Cells[0].Value = Bcode;
            }
            Gridname.Rows.Add(1);
            Gridname.Rows[Gridname.Rows.Count - 2].Cells[0].Value = "(Auto Batch)";
            Gridname.Visible = true;
        }
        public string ProductNameshow(string batchname)
        {
            string Pname = _Dbtask.ExecuteScalar("select * from tblbatch where bcode='" + batchname + "'");
        Pname = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Pname + "'");
        return Pname;
        }
        public string GetSpecificFieldByItemId(string ItemId, string Field)
        {
            string Sql = "Select " + Field + " From TblBatch Where ItemId = '" + ItemId + "'";
            return _Dbtask.ExecuteScalar(Sql);
        }
        public string GetSpecificFieldByBarcode(string filed, string Barcode)
        {
            string Sql = "Select " + filed + " From TblBatch Where bcode = '" + Barcode + "'";
            return _Dbtask.ExecuteScalar(Sql);
        }


        public void updatelastesalerateratezeroitemsFN()
        {
            DataSet Db; DataSet Dd;
            Db = _Dbtask.ExecuteQuery("SELECT BCODE,ITEMID FROM TBLBATCH WHERE SRATE=0");

            if (Db.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < Db.Tables[0].Rows.Count; i++)
                {


                    string bcode = ""; string pcode = "";
                    bcode = _Dbtask.znllString(Db.Tables[0].Rows[i]["BCODE"]);
                    pcode = _Dbtask.znllString(Db.Tables[0].Rows[i]["itemid"]); 

                    Dd = _Dbtask.ExecuteQuery("SELECT RATE,PCODE,BATCHID FROM  "+  
                    "  (TBLISSUEDETAILS  INNER JOIN  TBLBUSINESSISSUE ON    "+ 
                    "   TBLISSUEDETAILS.ISSUECODE =TBLBUSINESSISSUE.VNO )     "+
                    "       WHERE TBLISSUEDETAILS.batchid ='" + bcode + "'and TBLISSUEDETAILS.VTYPE='SI'    " + 
                    "   ORDER BY TBLISSUEDETAILS.ISSUECODE DESC");

                    if (Dd.Tables[0].Rows.Count > 0)
                    {

                        for (int j = 0; j < Dd.Tables[0].Rows.Count; j++)
                        {
                            double ratee = 0;
                            ratee = _Dbtask.znlldoubletoobject(Dd.Tables[0].Rows[j]["RATE"]);
                            UpdateFieldbybatch(bcode, "srate", ratee);
                            CommonClass._Item.UpdateField(pcode, ratee, "srate");

                            j = j + Dd.Tables[0].Rows.Count;
                        
                        }
                    }
                
                
                
                
                
                
                
                
                
                
                }
            }


            MessageBox.Show("sales rate updated");


        }


        public DataSet Batchtableitem()
        {
            Ds = _Dbtask.ExecuteQuery("select bcode from tblbatch where ontable='Yes'");
             return Ds;
        }



        //public DataSet batchwithid()
        //{
        //    Ds = _Dbtask.ExecuteQuery();
        //    return Ds;
        //}

    }
}
