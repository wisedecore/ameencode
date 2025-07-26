using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class Clssales
    {
       /*For Settings*/

        DBTask _Dbtask = new DBTask();
        ClsParamlist _param = new ClsParamlist();
        public string Temp;
        public  static bool Focusfirstrow;
        public string Bcode;
        public double NQty;
        public double Nrate; public bool Nounit = false;
        public static string PassExpiryDate;
        public static string PassExpiryRate;
        public void FuFocusfirstRow()
        {
            try
            {
                Temp=_Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='126'");
                if (Temp == "1")
                {
                    Focusfirstrow = true;
                }
                else
                {
                    Focusfirstrow = false;
                }
            }
            catch
            {
            }
        }

        public void BarcodeRefillingBYSETTING(string Barcode)
                                                                    {
            try
            {
                string existt = ""; string PREFX = "";
                bool seperate = false; string XX = "";
                PREFX = frmsalesinvoice.Stgbcodeprefx;//_Dbtask.znllString(_param.GetParamvalue("bcodeprefix"));

                string digg = "";
                digg = frmsalesinvoice.stgweigndigit; //_Dbtask.znllString(_param.GetParamvalue("bcodedigit"));

                if (digg != "")
                            {
                                if (Barcode != "" && Barcode.Length == Convert.ToInt32(frmsalesinvoice.stgweigndigit))
                    {
                        if (PREFX != "")
                        {
                           
                            XX = Barcode.Substring(0, PREFX.Length);

                            XX = Barcode.Substring(0, PREFX.Length);
                            if (PREFX == Barcode.Substring(0, PREFX.Length))
                            {
                                seperate = true;
                                int Bst = 0; int Bend = 0;

                                Bst = Convert.ToInt32(frmsalesinvoice.stgweignbcodeSrt);
                                Bend = Convert.ToInt32(frmsalesinvoice.stgweignbcodeEnd);

                                
                                //Bst = Convert.ToInt32(_param.GetParamvalue("weignbcodestrt"));
                                //Bend = Convert.ToInt32(_param.GetParamvalue("weignbcodeend"));




                                Bcode = Barcode.Substring(Bst, Bend);
                            }
                          }

                        if (CommonClass._Batch.usingmachineexist(Bcode) == true)
                        {



                            if (_Dbtask.znllString(frmsalesinvoice.stgweignqtyMNU) == "1")
                            {
                                int QTst = 0; int QTend = 0; int divinum = 0;
                                XX = "";
                                //QTst = Convert.ToInt32(_param.GetParamvalue("weignQtystrt"));
                                //QTend = Convert.ToInt32(_param.GetParamvalue("weignQtyend"));
                                //divinum = Convert.ToInt32(_param.GetParamvalue("weignQtyDIVI"));

                                QTst = Convert.ToInt32(frmsalesinvoice.stgweignqtySrt);
                                QTend = Convert.ToInt32(frmsalesinvoice.stgweignqtyEnd);
                                divinum = Convert.ToInt32(frmsalesinvoice.stgweignqtyDiv);


                                if (divinum == 0)
                                {
                                    divinum = 1;
                                }

                                XX = Barcode.Substring(QTst, QTend);

                                NQty = _Dbtask.znlldoubletoobject(XX) / divinum;

                            }
                            if (_Dbtask.znllString(frmsalesinvoice.stgweignqtyMNU) == "-1")
                            {

                                NQty = 1;
                            }

                            if (_Dbtask.znllString(frmsalesinvoice.stgweignrateMNU) == "1")
                            {
                                int RTst = 0; int divinumrte = 0;
                                int RTend = 0;
                                XX = "";
                                //RTst = Convert.ToInt32(_param.GetParamvalue("weignratestrt"));
                                //RTend = Convert.ToInt32(_param.GetParamvalue("weignrateend"));

                                //divinumrte = Convert.ToInt32(_param.GetParamvalue("weignRateDIVI"));


                                RTst = Convert.ToInt32(frmsalesinvoice.stgweignrateSrt);
                                RTend = Convert.ToInt32(frmsalesinvoice.stgweignrateEnd);

                                divinumrte = Convert.ToInt32(frmsalesinvoice.stgweignrateDiv);







                                if (divinumrte == 0)
                                {
                                    divinumrte = 1;
                                }
                                XX = Barcode.Substring(RTst, RTend);

                                Nrate = _Dbtask.znlldoubletoobject(XX) / divinumrte;
                                if (_Dbtask.znllString(frmsalesinvoice.stgweignrateRound) == "1")
                                {

                                 int LENG = Convert.ToInt32( _Dbtask.znllString(Nrate).Length);

                                 if (LENG<=4)
                                 {

                                     Nrate = _Dbtask.znlldoubletoobject(_Dbtask.znllString(Nrate).Substring(0, (LENG)));

                                 }
                                 else
                                 {
                                     Nrate = _Dbtask.znlldoubletoobject(_Dbtask.znllString(Nrate).Substring(0, (LENG-1)));

                                 }
                                }
                            
                            
                            }


                        }



                        else
                        {
                        }
                        
                    }
                }




                if (seperate == false)
                {
                    Bcode = Barcode;


                    NQty = 1;
                    Nrate = 0;
                }

                seperate = false;
            }
            catch
            {
            }
        }




        public void BarcodeRefilling(string Barcode)
                                {
            try
            {
                string existt = "";
                bool seperate = false;

                //if (Barcode != "" && Barcode.Length == 16)
                //{
                //    if (Barcode.Substring(0, 2) == "10")
                //    {
                //        Bcode = Barcode.Substring(2, 3);
                //        NQty = Convert.ToDouble(Barcode.Substring(5, 5)) / 1000;
                //        Nrate = Convert.ToDouble(Barcode.Substring(10, 6)) / 100;
                //        Nrate = Nrate / NQty;
                //    }
                //    else
                //    {
                //        Bcode = Barcode;
                //        NQty = 1;
                //        Nrate = 0;
                //    }
                //}
                
                string digg = "";
                digg = _Dbtask.znllString(_param.GetParamvalue("bcodedigit"));

                if (digg!="")
                {
                    if (Convert.ToInt32(_param.GetParamvalue("bcodedigit")) == 16)
                    {
                        if (Barcode != "" && Barcode.Length == Convert.ToInt32(_param.GetParamvalue("bcodedigit")))
                        {

                            if (_Dbtask.znllString(_param.GetParamvalue("bcodeprefix")) == Barcode.Substring(0, 2))
                            {
                                if (CommonClass._Batch.usingmachineexist(Barcode.Substring(2, 3)) == true)
                                {

                                    seperate = true;
                                    Bcode = Barcode.Substring(2, 3);
                                    NQty = Convert.ToDouble(Barcode.Substring(5, 5)) / 1000;
                                    Nrate = Convert.ToDouble(Barcode.Substring(10, 6)) / 1000;
                                }


                            }

                        }
                    }

                    if (Convert.ToInt32(_param.GetParamvalue("bcodedigit")) == 13)
                    {
                        if (Barcode != "" && Barcode.Length == Convert.ToInt32(_param.GetParamvalue("bcodedigit")))
                        {

                            if (_Dbtask.znllString(_param.GetParamvalue("bcodeprefix")) == Barcode.Substring(0, 2))
                            {

                                //string PP = Barcode.Substring(2, 5);
                                if (CommonClass._Batch.usingmachineexist(Barcode.Substring(2,6)) == true)
                                {

                                    Nounit = true;
                                    seperate = true;
                                    Bcode = Barcode.Substring(2, 6);
                                    NQty = 1;//Convert.ToDouble(Barcode.Substring(5, 5)) / 1000;
                                    Nrate = Convert.ToDouble(Barcode.Substring(8, 5)) / 100;
                                    Nrate = Nrate / NQty;

                                }
                            }
                        }

                    }
                }
                
                if (seperate == false)
                {
                Bcode = Barcode;
                 NQty = 1;
                Nrate = 0;
               }

                seperate = false;
            }
        
            catch
            {
            }
        }

        public void GridCellenter(DataGridView grid, int Rowindex, int Cellindex)
        {
           // grid.Rows[Rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        public DataSet ShowSalesReport(string Where,string PVtype)
        {
            double LessAmt;
            LessAmt =_Dbtask.znullDouble(CommonClass._Paramlist.GetParamvalue("LessAmount"));
            CommonClass.Ds1 = _Dbtask.ExecuteQuery("SELECT     TblBusinessIssue.VNo, TblBusinessIssue.uid as 'User', TblBusinessIssue.IssueDate as Date, TblBusinessIssue.Tename as Party, TblBusinessIssue.IssueCode" +
                ",(select sum(Qty) from TblIssuedetails where vtype='"+PVtype+"' and  ledcode=TblBusinessIssue.ledcodecr and issuecode= TblBusinessIssue.IssueCode)AS 'Qty', SUM(TblIssuedetails.FreeQty) AS FreeQty," +
           "TblBusinessIssue.taxamt*" + LessAmt + "/100 as 'Taxamt',((TblBusinessIssue.amt*(" + LessAmt + "/100)+TblBusinessIssue.discamt)-TblBusinessIssue.TAXAMT)  as Amount,TblBusinessIssue.discamt as Discount, " +
            " TblBusinessIssue.amt*" + LessAmt + "/100  as NetAmount,TblBusinessIssue.Adamount  as Cash " +
           "  ,tblbusinessissue.ledcodecr  as 'MainAccount' FROM         TblBusinessIssue INNER JOIN " +
         " TblIssuedetails ON TblBusinessIssue.IssueCode = TblIssuedetails.IssueCode " +
         " and   TblBusinessIssue.LedcodeCr = TblIssuedetails.Ledcode " +
         " and   TblBusinessIssue.issuetype = TblIssuedetails.vtype  "+
         " GROUP BY TblBusinessIssue.mpayment,TblBusinessIssue.Adamount,TblBusinessIssue.taxid,TblBusinessIssue.sr,TblBusinessIssue.IssueCode,TblBusinessIssue.VNo,TblBusinessIssue.Uid,TblBusinessIssue.IssueDate, TblBusinessIssue.Tename,TblBusinessIssue.IssueType " +
         ",TblBusinessIssue.amt,TblBusinessIssue.discamt,TblBusinessIssue.taxamt,TblBusinessIssue.ledcodeCr,TblBusinessIssue.ledcodedr,TblBusinessIssue.empid,TblBusinessIssue.agent,tblissuedetails.vtype     " +
         " " + Where + " order by TblBusinessIssue.IssueDate asc ");

            //CommonClass.Ds1 = _Dbtask.ExecuteQuery("SELECT     TblBusinessIssue.VNo, TblBusinessIssue.IssueDate as Date, TblBusinessIssue.Tename as Party, TblBusinessIssue.IssueCode" +
            //        ",(select sum(Qty) from TblIssuedetails where vtype='SI' and  ledcode=TblBusinessIssue.ledcodecr and issuecode= TblBusinessIssue.IssueCode)AS 'Qty', SUM(TblIssuedetails.FreeQty) AS FreeQty," +
            //   "TblBusinessIssue.discamt as Discount,TblBusinessIssue.taxamt, " +
            //   " (select amt from tbltransactionreceipt " +
            //    " where recpttype='SR' and vno=TblBusinessIssue.sr) as 'SR(-)', " +
            //    " TblBusinessIssue.amt 'Amount',TblBusinessIssue.amt- " +
            //    "(select isnull (sum(amt),0) from tbltransactionreceipt " +
            //    " where recpttype='SR' and vno=TblBusinessIssue.sr) as NetAmount " +
            //   "  ,tblbusinessissue.ledcodecr  as 'MainAccount' FROM         TblBusinessIssue INNER JOIN " +
            // " TblIssuedetails ON TblBusinessIssue.IssueCode = TblIssuedetails.IssueCode " +
            // " GROUP BY TblBusinessIssue.sr,TblBusinessIssue.IssueCode,TblBusinessIssue.VNo,TblBusinessIssue.IssueDate, TblBusinessIssue.Tename,TblBusinessIssue.IssueType " +
            // ",TblBusinessIssue.amt,TblBusinessIssue.discamt,TblBusinessIssue.taxamt,TblBusinessIssue.ledcodeCr,TblBusinessIssue.ledcodedr,TblBusinessIssue.empid,TblBusinessIssue.agent,tblissuedetails.vtype     " +
            // " " + Where + " order by TblBusinessIssue.IssueDate asc ");


            return CommonClass.Ds1;
        }
    }
}
