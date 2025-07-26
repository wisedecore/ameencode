using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;


namespace WindowsFormsApplication2
{
    public partial class Frmreport2 : Form
    {
       
        public Frmreport2()
        {
            InitializeComponent();
        }
        public static DateTime DTFrom;
        public static DateTime Dtto;
        public static DateTime frstdto;
        public string Pymntvno = "";
        public string mode = "";
        string wheredate2; public string Dquery = "";
        ClsOtherprintset _print = new ClsOtherprintset();
        string wheredate3;
        string Category; double Coresponding;
        public double Tsqty = -1;
        public bool totSqty = false;
        public static string Userid;
        RichTextBox RichTextBox1 = new RichTextBox();
        DBTask _dbtask = new DBTask();
        ClsInvThermal _Thermal = new ClsInvThermal();
      
        ClsInvThermalSummury _ThermalThermal = new ClsInvThermalSummury();
        public string Reporttype;
        public DataSet Ds1;
        public DataSet Ds;


        public bool suumerybool = false;
        public int RowsCount;
        public double Qty;
        public static bool onlinecheck = true;
        public void Exporttoexcel()
        {
            //try
            //{
            //    int cols;
            //    SaveFileDialog theDialog = new SaveFileDialog();
            //    theDialog.Title = "Save File";
            //    theDialog.Filter = "Excel File|*.xls";
            //    theDialog.InitialDirectory = @"C:\";
            //    if (theDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string Filepath = theDialog.FileName;

            //        //open file
            //        StreamWriter wr = new StreamWriter(Filepath);

            //        //determine the number of columns and write columns to file
            //        cols = GridMain.Columns.Count;
            //        wr.Write("Company Name\n\n\n");


            //       // wr.Write(LblHeading.Text + "\n\n");

            //        for (int i = 0; i < cols; i++)
            //        {
            //            wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
            //        }
            //        wr.WriteLine();
            //        // write rows to excel file
            //        for (int i = 0; i < (GridMain.Rows.Count); i++)
            //        {
            //            for (int j = 0; j < cols; j++)
            //            {
            //                if (GridMain.Rows[i].Cells[j].Value != null)
            //                {
            //                    GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
            //                    GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
            //                    wr.Write(GridMain.Rows[i].Cells[j].Value + "\t");
            //                }
            //                else
            //                {
            //                    wr.Write("\t");
            //                }
            //            }
            //            wr.WriteLine();
            //        }
            //        wr.Close();
            //    }
            //}
            //catch
            //{
            //}

            try
            {
                int cols;
                SaveFileDialog theDialog = new SaveFileDialog();
                theDialog.Title = "Save File";
                theDialog.Filter = "Excel File|*.xls";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    string Filepath = theDialog.FileName;

                    //open file
                    StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                    //determine the number of columns and write columns to file
                    cols = GridMain.Columns.Count;
                    wr.Write("" + CommonClass._compMaster.GetspecifField("cname") + "\n\n\n");
                    wr.Write(DtFrom.Value.ToString("dd-MM-yyyy") + "  To " + DtTo.Value.ToString("dd-MM-yyyy") + " \n\n");

                    //wr.Write(LblHeading.Text + "\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (GridMain.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (GridMain.Rows[i].Cells[j].Value != null)
                            {
                                GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(GridMain.Rows[i].Cells[j].Value + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
                }
            }
            catch
            {
            }
        }
        public void StocktransferReporty()
        {

            GridMain.BackgroundColor = Color.White;
            Pnltop.BackColor = Color.LavenderBlush;
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            GridMain.Columns.Add("clndate", "Date");
            GridMain.Columns["clndate"].Width = 150;

            GridMain.Columns.Add("clnvno", "Vno");
            GridMain.Columns["clnvno"].Width = 130;
            GridMain.Columns.Add("clnfrom", "From Area");
            GridMain.Columns["clnfrom"].Width = 250;
            GridMain.Columns.Add("clnitem", "Item");
            GridMain.Columns["clnitem"].Width = 280;

            GridMain.Columns.Add("clnbcode", "Batch");
            GridMain.Columns["clnbcode"].Width = 280;

            GridMain.Columns.Add("clnqty", "Qty");
            GridMain.Columns["clnqty"].Width = 100;
            GridMain.Columns.Add("clnrate", "Rate");
            GridMain.Columns["clnrate"].Width = 100;

            GridMain.Columns.Add("clnTO", "To Area");
            GridMain.Columns["clnTO"].Width = 250;
            int Count = 0;
            Ds = _dbtask.ExecuteQuery(Dquery);

            string pcode = "";
            string Fareaid = ""; string Tareaid = "";

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    pcode = "";
                    Fareaid = ""; Tareaid = "";
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.NavajoWhite;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);


                    pcode = _dbtask.znllString(Ds.Tables[0].Rows[i]["pcode"]);
                    Fareaid = _dbtask.znllString(Ds.Tables[0].Rows[i]["dcodefrom"]);
                    Tareaid = _dbtask.znllString(Ds.Tables[0].Rows[i]["dcodeto"]);
                    GridMain.Rows[Count].Cells["clndate"].Value = _dbtask.znllString(Ds.Tables[0].Rows[i]["TDATE"]);
                    GridMain.Rows[Count].Cells["clnvno"].Value = _dbtask.znllString(Ds.Tables[0].Rows[i]["Tcode"]);
                    GridMain.Rows[Count].Cells["clnfrom"].Value = CommonClass._Depot.NameDepot(Fareaid);
                    GridMain.Rows[Count].Cells["clnitem"].Value = CommonClass._Itemmaster.SpecificField(pcode, "itemname");
                    GridMain.Rows[Count].Cells["clnbcode"].Value = _dbtask.znllString(Ds.Tables[0].Rows[i]["batchid"]);
                    GridMain.Rows[Count].Cells["clnqty"].Value = _dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["qty"]);
                    GridMain.Rows[Count].Cells["clnrate"].Value = _dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["rate"]);
                    GridMain.Rows[Count].Cells["clnTO"].Value = CommonClass._Depot.NameDepot(Tareaid);

                }
            }



        }

        //stocktransfer
        public void modeofpaymntnewreport(string wise)
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            GridMain.Columns.Add("clndate", "Date");
            GridMain.Columns["clndate"].Width = 190;

            GridMain.Columns.Add("clnvno", "vno");
            GridMain.Columns["clnvno"].Width = 80;

            GridMain.Columns.Add("clnTax", "Tot.VAT");
            GridMain.Columns["clnTax"].Width = 120;

            GridMain.Columns.Add("clnBillAMT", "BillAMT");
            GridMain.Columns["clnBillAMT"].Width = 150;

            GridMain.Columns.Add("clnmethode1", "Paymethode");
            GridMain.Columns["clnmethode1"].Width = 100;

            GridMain.Columns.Add("clnmethodeAmt", "PaymethodeAmt");
            GridMain.Columns["clnmethodeAmt"].Width = 150;

             GridMain.Columns.Add("clnmethode2", "2ND Paymethode");
            GridMain.Columns["clnmethode2"].Width = 100;


            GridMain.Columns.Add("clnmethode2amt", "2ND PayAmt");
            GridMain.Columns["clnmethode2amt"].Width = 220;

         string   Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
         if (wise == "Cash")
            {
                Ds = _dbtask.ExecuteQuery("SELECT ISSUEDATE,VNO,AMT,TAXAMT,TWOPAYMENT,TWOPAYAMT,CashReceived FROM TBLBUSINESSISSUE WHERE MPAYMENT='0'  and " + Wheredate + " ");
            }
            if (wise == "Card")
            {
                Ds = _dbtask.ExecuteQuery("SELECT ISSUEDATE,VNO,AMT,TAXAMT,TWOPAYMENT,TWOPAYAMT,CashReceived FROM TBLBUSINESSISSUE WHERE MPAYMENT='2' and " + Wheredate + " ");
            }

            if (Ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string methode = ""; string m2 = ""; string cashrvd = "";
                    int lnth = 0;
                    
                    int  RowsCount = GridMain.Rows.Add(1);
                  GridMain.Rows[RowsCount].Cells["clndate"].Value =_dbtask.znllString( Ds.Tables[0].Rows[i]["ISSUEDATE"]);
                  GridMain.Rows[RowsCount].Cells["clnvno"].Value =_dbtask.znllString( Ds.Tables[0].Rows[i]["VNO"]);
                  GridMain.Rows[RowsCount].Cells["clnTax"].Value =_dbtask.SetintoDecimalpoint( _dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["TAXAMT"]));
                  GridMain.Rows[RowsCount].Cells["clnBillAMT"].Value =_dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject( Ds.Tables[0].Rows[i]["AMT"]));
               
                  cashrvd =_dbtask.znllString( Ds.Tables[0].Rows[i]["CashReceived"] );
                  lnth = cashrvd.Length;
                  int index = cashrvd.IndexOf(',');
                  if (lnth>15)
                    {

                    cashrvd =_dbtask.znllString( cashrvd.Substring(15, (index-15)));
                    }
                   // cashrvd = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(cashrvd));
                    if (_dbtask.znlldoubletoobject(cashrvd) <= 0 && _dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["TWOPAYAMT"]) <= 0)
                    {
                        cashrvd = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(Ds.Tables[0].Rows[i]["AMT"]));
                    }

                    GridMain.Rows[RowsCount].Cells["clnmethode1"].Value =_dbtask.znllString( wise);
                    GridMain.Rows[RowsCount].Cells["clnmethodeAmt"].Value=_dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(cashrvd));

            m2 =_dbtask.znllString( Ds.Tables[0].Rows[i]["TWOPAYMENT"]);
                    if(m2=="0")
                    {
                        methode = "Cash";
                    }
                    if (m2 == "1")
                    {
                        methode = "Credit";
                    }
                    if (m2 == "2")
                    {
                        methode = "Card";
                    }
                    if (m2 == "")
                    {
                        methode = " --- ";
                    }
                    GridMain.Rows[RowsCount].Cells["clnmethode2"].Value =_dbtask.znllString( methode);
                    GridMain.Rows[RowsCount].Cells["clnmethode2amt"].Value = _dbtask.znllString(Ds.Tables[0].Rows[i]["TWOPAYAMT"]);
           



                }
            }


          int  Rowtwo = GridMain.Rows.Add(1);
          GridMain.Rows[Rowtwo].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            //GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

          int Row3 = GridMain.Rows.Add(1);
            GridMain.Rows[Row3].DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            GridMain.Rows[Row3].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Row3].DefaultCellStyle.ForeColor=Color.Yellow;
            
          int Row4 = GridMain.Rows.Add(1);
          if (wise == "Cash")
            {
                Ds1 = _dbtask.ExecuteQuery("SELECT ISSUEDATE,VNO,AMT,TAXAMT,TWOPAYMENT,TWOPAYAMT FROM TBLBUSINESSISSUE WHERE TWOPAYMENT='0' and TWOPAYAMT>0  and " + Wheredate + " ");
            GridMain.Rows[Row3].Cells["clnBillAMT"].Value = "2ND Payment cash";
             }
             if (wise == "Card")
            {
                Ds1 = _dbtask.ExecuteQuery("SELECT ISSUEDATE,VNO,AMT,TAXAMT,TWOPAYMENT,TWOPAYAMT FROM TBLBUSINESSISSUE WHERE TWOPAYMENT='2' and TWOPAYAMT>0   and " + Wheredate + " ");
            GridMain.Rows[Row3].Cells["clnBillAMT"].Value = "2ND Payment card";
            }

            if ( Ds1.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j <  Ds1.Tables[0].Rows.Count; j++)
                {
                 int  Count = GridMain.Rows.Add(1);
                  GridMain.Rows[Count].Cells["clndate"].Value =_dbtask.znllString( Ds1.Tables[0].Rows[j]["ISSUEDATE"]);
                  GridMain.Rows[Count].Cells["clnvno"].Value =_dbtask.znllString( Ds1.Tables[0].Rows[j]["VNO"]);
                  GridMain.Rows[Count].Cells["clnTax"].Value = _dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[j]["TAXAMT"]);
                  GridMain.Rows[Count].Cells["clnBillAMT"].Value = _dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(Ds1.Tables[0].Rows[j]["AMT"]));
                  GridMain.Rows[Count].Cells["clnmethode2"].Value = _dbtask.znllString(wise);
                  GridMain.Rows[Count].Cells["clnmethode2amt"].Value = _dbtask.znllString(Ds1.Tables[0].Rows[j]["TWOPAYAMT"]);
           
                }
            }

        
        }

        public void ItemList()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            GridMain.Columns.Add("clnslno", "Sl");
            GridMain.Columns["clnslno"].Width = 25;

            GridMain.Columns.Add("clnitemname", "Item Name");
            GridMain.Columns["clnitemname"].Width = 200;


            GridMain.Columns.Add("clnrate", "Rate");
            GridMain.Columns["clnrate"].Width = 100;

            double Rate;
            Ds = CommonClass._Itemmaster.ShowItemsProductName("", 0);
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                RowsCount = GridMain.Rows.Add(1);
                string Itemid = Ds.Tables[0].Rows[i]["itemid"].ToString();
                string Itemname = Ds.Tables[0].Rows[i]["itemname"].ToString();
                Rate =CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "srate"));
                GridMain.Rows[RowsCount].Cells["clnslno"].Value = (i+1).ToString();
                GridMain.Rows[RowsCount].Cells["clnitemname"].Value = Itemname;
                GridMain.Rows[RowsCount].Cells["clnrate"].Value = Rate;
            }
  
        }

        public void TaxsummeryTWOreport()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            GridMain.Columns.Add("clnmain", " ");
            GridMain.Columns["clnmain"].Width = 180;
            GridMain.Columns.Add("clnreturn", "  ");
            GridMain.Columns["clnreturn"].Width = 180;
            GridMain.Columns.Add("clnadd", "  ");
            GridMain.Columns["clnadd"].Width = 300;
            GridMain.Columns.Add("clnsettle", "  ");
            GridMain.Columns["clnsettle"].Width = 180;
            GridMain.Columns.Add("clndue", "  ");
            GridMain.Columns["clndue"].Width = 180;
            GridMain.RowTemplate.Height = 36;


            string Wheredate; int Count;
            string TaxstrSales = "";
            string isuecode; string Wheredate2 = "";
            //string TaxstrSales;
            //get
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='SI'";
            TaxstrSales = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='SI'");

            double PRtax = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='PR'";
            PRtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='PR'"));

            //rtax
            Wheredate2 = "  vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            double Recpttax = 0;
            Recpttax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(RPTAXAMT) from tblgeneralledger where vtype='R' And " + Wheredate2 + " "));
            double totR = 0;
            totR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(dbamt) from tblgeneralledger where vtype='R' And " + Wheredate2 + " "));
            double Recptgrss = 0;
            Recptgrss = totR - Recpttax;



            //ptax

            double Paymntttax = 0;
            Paymntttax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(RPTAXAMT) from tblgeneralledger where vtype='P' And " + Wheredate2 + " "));
            double totP = 0;
            totP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(cramt) from tblgeneralledger where vtype='P' And " + Wheredate2 + " "));
            double Paymntgrss = 0;
            Paymntgrss = totP - Paymntttax;





            //paid
            string TaxstrPurchase;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='PI'";
            TaxstrPurchase = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where Recptcode in (" + isuecode + ") and vtype='PI'");
            double srtax = 0;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='SR'";
            srtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where recptcode in (" + isuecode + ") and vtype='SR'"));

            double totget = 0;
            totget = Recpttax + PRtax + Convert.ToDouble(TaxstrSales);
            double totpaid = 0;
            totpaid = Paymntttax + srtax + Convert.ToDouble(TaxstrPurchase);
            double diffrnce = 0;
            diffrnce = totget - totpaid;

            //grss
            double Tgrosssales = 0;
            double TgrossPurchase = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            double TOSALES = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='SI'  and issuetype!='sv' and " + Wheredate + ""));
            Tgrosssales = TOSALES - CommonClass._Dbtask.znullDouble(TaxstrSales);

            double totpramt = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='PR'  and issuetype!='sv' and " + Wheredate + ""));
            double GRSSPurretnchse = 0;
            GRSSPurretnchse = totpramt - PRtax;

            //paid
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            double totsretrn = 0;
            totsretrn = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='SR'   and " + Wheredate + ""));
            double Totretrngrss = 0;
            Totretrngrss = totsretrn - srtax;





            double TOTpurchase = 0;
            TOTpurchase = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='PI'   and " + Wheredate + ""));
            double totgrss = 0;
            totgrss = TOTpurchase - Convert.ToDouble(TaxstrPurchase);






            //getgrss
            double getgrs = 0;
            getgrs = Convert.ToDouble(Tgrosssales + GRSSPurretnchse + Recptgrss);
            double paidgrss = 0;
            paidgrss = Convert.ToDouble(Totretrngrss + totgrss + Paymntgrss);

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnadd"].Value = "Value Added tax on sales";
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "The sales ";
            GridMain.Rows[Count].Cells["clnreturn"].Value = "Returns";
            GridMain.Rows[Count].Cells["clnadd"].Value = "Tax added value ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "Tax settlement";
            GridMain.Rows[Count].Cells["clndue"].Value = "Tax is due";

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "المبيعات ";
            GridMain.Rows[Count].Cells["clnreturn"].Value = "المردودات ";
            GridMain.Rows[Count].Cells["clnadd"].Value = "ضريبة القيمة المضافة ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "التسوية الضريبة ";
            GridMain.Rows[Count].Cells["clndue"].Value = "الضريبة المستحقة";
            //val
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = CommonClass._Dbtask.znlldoubletoobject(TOSALES); //CommonClass._Dbtask.znlldoubletoobject(TaxstrSales);

            GridMain.Rows[Count].Cells["clnreturn"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totsretrn);  //CommonClass._Dbtask.SetintoDecimalpoint(srtax);
            GridMain.Rows[Count].Cells["clnadd"].Value = CommonClass._Dbtask.znlldoubletoobject(TaxstrSales) + CommonClass._Dbtask.znlldoubletoobject(srtax);
            GridMain.Rows[Count].Cells["clnsettle"].Value = CommonClass._Dbtask.SetintoDecimalpoint(PRtax);
            GridMain.Rows[Count].Cells["clndue"].Value = CommonClass._Dbtask.znlldoubletoobject(TaxstrSales) - CommonClass._Dbtask.znlldoubletoobject(srtax);
            //purch
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnadd"].Value = "Vat on Purchase";

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "Purchases ";
            GridMain.Rows[Count].Cells["clnreturn"].Value = "Returns";
            GridMain.Rows[Count].Cells["clnadd"].Value = "Tax added value ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "Tax settlement";
            GridMain.Rows[Count].Cells["clndue"].Value = "Tax is due";


            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "المشترايات  ";
            GridMain.Rows[Count].Cells["clnreturn"].Value = "المردودات ";
            GridMain.Rows[Count].Cells["clnadd"].Value = "ضريبة القيمة المضافة ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "التسوية الضريبة ";
            GridMain.Rows[Count].Cells["clndue"].Value = "الضريبة المستحقة";


            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value =CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject( TOTpurchase));//CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase));
            GridMain.Rows[Count].Cells["clnreturn"].Value =CommonClass._Dbtask.SetintoDecimalpoint( totpramt); //CommonClass._Dbtask.SetintoDecimalpoint(PRtax);
            GridMain.Rows[Count].Cells["clnadd"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase) + PRtax);
            GridMain.Rows[Count].Cells["clnsettle"].Value = CommonClass._Dbtask.SetintoDecimalpoint(srtax);
            GridMain.Rows[Count].Cells["clndue"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase) - PRtax);


            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnadd"].Value = "Tax Details";


            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "Sale tax ";
         
            GridMain.Rows[Count].Cells["clnadd"].Value = "Purchase tax  ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "Total tax ";

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = "ضريبة مبيعات  ";

            GridMain.Rows[Count].Cells["clnadd"].Value = "ضريبة المشترايات ";
            GridMain.Rows[Count].Cells["clnsettle"].Value = "اجمالي ضريبة  ";

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnmain"].Value = CommonClass._Dbtask.SetintoDecimalpoint(PRtax + CommonClass._Dbtask.znlldoubletoobject(TaxstrSales));

            GridMain.Rows[Count].Cells["clnadd"].Value = CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase) + CommonClass._Dbtask.SetintoDecimalpoint(srtax);

            double S1 = 0;
            S1 = CommonClass._Dbtask.znlldoubletoobject(PRtax) + CommonClass._Dbtask.znlldoubletoobject(TaxstrSales);
            double P1 = 0;
            P1 = CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase) + CommonClass._Dbtask.znlldoubletoobject(srtax);
            double tot = 0;
                tot = S1-P1;
                GridMain.Rows[Count].Cells["clnsettle"].Value =CommonClass._Dbtask.SetintoDecimalpoint( tot);
            




        }

        public void taxsummeryreport()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            GridMain.Columns.Add("clnnote1", " IN ");
            GridMain.Columns["clnnote1"].Width = 300;

            GridMain.Columns.Add("clnnval1", " GET TAX ");
            GridMain.Columns["clnnval1"].Width = 150;
            GridMain.Columns.Add("clnngrss1", " GROSS ");
            GridMain.Columns["clnngrss1"].Width = 150;


            GridMain.Columns.Add("clnnote2", " OUT ");
            GridMain.Columns["clnnote2"].Width = 300;

            GridMain.Columns.Add("clnnval2", " PAID TAX ");
            GridMain.Columns["clnnval2"].Width = 150;
            GridMain.Columns.Add("clnngrss2", " GROSS ");
            GridMain.Columns["clnngrss2"].Width = 150;

            GridMain.RowTemplate.Height = 34;
            string Wheredate; int Count;
            string   TaxstrSales="";
            string isuecode; string Wheredate2 = "";
            //string TaxstrSales;
            //get
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='SI'";
            TaxstrSales = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='SI'");

            double PRtax = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='PR'";
            PRtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='PR'"));
            
            //rtax
            Wheredate2 = "  vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            double Recpttax = 0;
            Recpttax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(RPTAXAMT) from tblgeneralledger where vtype='R' And " + Wheredate2 + " "));
            double totR = 0;
            totR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(dbamt) from tblgeneralledger where vtype='R' And " + Wheredate2 + " "));
            double Recptgrss = 0;
            Recptgrss = totR - Recpttax;



            //ptax
           
            double Paymntttax = 0;
            Paymntttax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(RPTAXAMT) from tblgeneralledger where vtype='P' And " + Wheredate2 + " "));
            double totP = 0;
            totP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select SUM(cramt) from tblgeneralledger where vtype='P' And " + Wheredate2 + " "));
            double Paymntgrss = 0;
            Paymntgrss = totP- Paymntttax;





            //paid
            string TaxstrPurchase;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='PI'";
            TaxstrPurchase = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where Recptcode in (" + isuecode + ") and vtype='PI'");
            double srtax = 0;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='SR'";
            srtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where recptcode in (" + isuecode + ") and vtype='SR'"));

            double totget = 0;
            totget =Recpttax+ PRtax + Convert.ToDouble(TaxstrSales);
            double totpaid = 0;
            totpaid =Paymntttax+ srtax + Convert.ToDouble(TaxstrPurchase);
            double diffrnce = 0;
            diffrnce = totget - totpaid;

            //grss
            double Tgrosssales = 0;
            double TgrossPurchase = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            double  TOSALES =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='SI'  and issuetype!='sv' and " + Wheredate + ""));
            Tgrosssales = TOSALES - CommonClass._Dbtask.znullDouble(TaxstrSales);
            
            double totpramt =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='PR'  and issuetype!='sv' and " + Wheredate + ""));
            double GRSSPurretnchse = 0;
            GRSSPurretnchse = totpramt - PRtax;

            //paid
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            double totsretrn = 0;
            totsretrn =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='SR'   and " + Wheredate + ""));
            double Totretrngrss = 0;
            Totretrngrss = totsretrn - srtax;





            double TOTpurchase = 0;
            TOTpurchase =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='PI'   and " + Wheredate + ""));
            double totgrss = 0;
            totgrss = TOTpurchase -Convert.ToDouble( TaxstrPurchase);






            //getgrss
            double getgrs = 0;
            getgrs =Convert.ToDouble( Tgrosssales + GRSSPurretnchse +Recptgrss);
            double paidgrss = 0;
            paidgrss =Convert.ToDouble( Totretrngrss + totgrss+Paymntgrss);



            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            GridMain.Rows[Count].Cells["clnnote1"].Value = "Sales Tot.Tax";
            GridMain.Rows[Count].Cells["clnnval1"].Value =CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject( TaxstrSales));
            GridMain.Rows[Count].Cells["clnngrss1"].Value =CommonClass._Dbtask.SetintoDecimalpoint( Tgrosssales); 

            GridMain.Rows[Count].Cells["clnnote2"].Value = "Purchse Tot.Tax";
            GridMain.Rows[Count].Cells["clnnval2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TaxstrPurchase));
            GridMain.Rows[Count].Cells["clnngrss2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totgrss); 
            
            GridMain.Rows[Count].Cells["clnnote1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnnval1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnngrss1"].Style.BackColor = Color.GreenYellow;

            GridMain.Rows[Count].Cells["clnnote2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnnval2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnngrss2"].Style.BackColor = Color.LightSalmon;
            
            
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnnote1"].Value = "PurchaseReturn Tot.Tax";
            GridMain.Rows[Count].Cells["clnnval1"].Value =CommonClass._Dbtask.SetintoDecimalpoint(PRtax);
            GridMain.Rows[Count].Cells["clnnote2"].Value = "SalesReturn Tot.Tax";
            GridMain.Rows[Count].Cells["clnnval2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(srtax);
            GridMain.Rows[Count].Cells["clnngrss1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(GRSSPurretnchse);
            GridMain.Rows[Count].Cells["clnngrss2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Totretrngrss);
            
            GridMain.Rows[Count].Cells["clnnote2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnnval2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnngrss2"].Style.BackColor = Color.LightSalmon;

            GridMain.Rows[Count].Cells["clnnote1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnnval1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnngrss1"].Style.BackColor = Color.GreenYellow;



            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnnote1"].Value = "Receipt Tax";
            GridMain.Rows[Count].Cells["clnnval1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Recpttax);
            GridMain.Rows[Count].Cells["clnnote2"].Value = "Payment Tax";
            GridMain.Rows[Count].Cells["clnnval2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Paymntttax);
            GridMain.Rows[Count].Cells["clnngrss1"].Value =  CommonClass._Dbtask.SetintoDecimalpoint(Recptgrss);
            GridMain.Rows[Count].Cells["clnngrss2"].Value =  CommonClass._Dbtask.SetintoDecimalpoint(Paymntgrss);

            GridMain.Rows[Count].Cells["clnnote2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnnval2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnngrss2"].Style.BackColor = Color.LightSalmon;

            GridMain.Rows[Count].Cells["clnnote1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnnval1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnngrss1"].Style.BackColor = Color.GreenYellow;








            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            GridMain.Rows[Count].Cells["clnnote1"].Value = "Total Get TAX Amount";
            GridMain.Rows[Count].Cells["clnnval1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totget);
            GridMain.Rows[Count].Cells["clnnote2"].Value = "Total Paid Tax Amount";
            GridMain.Rows[Count].Cells["clnnval2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totpaid);
            GridMain.Rows[Count].Cells["clnngrss1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(getgrs);
            GridMain.Rows[Count].Cells["clnngrss2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(paidgrss);


            GridMain.Rows[Count].Cells["clnnote2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnnval2"].Style.BackColor = Color.LightSalmon;
            GridMain.Rows[Count].Cells["clnngrss2"].Style.BackColor = Color.LightSalmon;

            GridMain.Rows[Count].Cells["clnnote1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnnval1"].Style.BackColor = Color.GreenYellow;
            GridMain.Rows[Count].Cells["clnngrss1"].Style.BackColor = Color.GreenYellow;
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote1"].Value = "Tax Difference ";
            GridMain.Rows[Count].Cells["clnnval1"].Value = CommonClass._Dbtask.SetintoDecimalpoint(diffrnce);


            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

           
        }
        //Sumary Report from Azure

        public void SummuryReportAzure()
        {

            GridMain.BackgroundColor = Color.White;
            Pnltop.BackColor = Color.LightPink;
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            GridMain.Columns.Add("clnnoteE", "Details");
            GridMain.Columns["clnnoteE"].Width = 600;

            GridMain.Columns.Add("clnnote", "NOTE");
            GridMain.Columns["clnnote"].Width = 300;
            GridMain.RowTemplate.Height = 27;


            GridMain.Columns.Add("clnamount2", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount2", 200);

            double TQty = 0;
            double TRate = 0;
            double Ttax = 0;
            double TAmount = 0;


            suumerybool = true;
            //string Bcode;
            double Qty;
            double Rate;
            double Amount;
            double TaxAmount = new double();

            string TotalCardSaleTax;
            string TotalCashSaleTax;
            string TaxPerc;
            string TotalCardSale;
            string Totalmada;
            string TotalvisaMstr;
            string TotalCashSale;
            string TotalCreditSale;
            string totmadavias = "";
            double totcashSR = 0;
            double crtSR = 0;
            double CARDsr = 0;
            double RealSR = 0;
            double trnsale = 0;
            double trnssr = 0;
            double trnspurch = 0;
            string totcasbalance = "";
            string transppr = "";

            string OpeningCash;
            string OpeningBank;
            string TotalPurchase;
            string TotaSale;
            string TotPurreturn;
            string TotSalereturn;
            string TotalPayment;
            string TotalReceipt;

            double SRcashonly = 0;
            double SRcardonly = 0;
            double SRcreditonly = 0;

            double CashClosing;
            string totsalesqty = "";
            string bank = "";
            string NetDBamt;
            string NetCramt;
            string NetBalance;
            string totBank = "";
            double totpr = 0;
            string cashpurch = "";
            string crdtpurch = "";
            string cardpurch = "";
            //DtFrom.Value = CommonClass._Gen.GetFyearFrom();
            //DtFrom.Value.TimeOfDay = DateTime.Now.TimeOfDay;
            string Wheredate;

            Wheredate = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "    ";

            int Count;

            /*OPening Cash*/
            OpeningCash = (CommonClass._GenLedger.getopeningbalanceAzure("1")).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("Opencash")) == "1")
            {


                Count = GridMain.Rows.Add(1);

                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Opening Cash");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Opening Cash";


                GridMain.Rows[Count].Cells["clnamount2"].Value = OpeningCash;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
            /*Opening Bank*/
            OpeningBank = (CommonClass._GenLedger.getopeningbalanceAzure("28")).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("OpeningBank")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Opening Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Opening Bank";

                GridMain.Rows[Count].Cells["clnamount2"].Value = OpeningBank;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }


            /*Total Purchase*/
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfTypeAzure("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("Tot.purchase")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Purchase";


                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            /*Total Cash Purchase*/
            CashClosing = CommonClass._Dbtask.znullDouble(OpeningCash) - CommonClass._Dbtask.znullDouble(TotalPurchase);
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfTypeAzure("Amt", "PI", " and ledcodecr =1  and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("cash.purchase")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash Purchase";

                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;


                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
            }




            /*Total Credit Purchase*/

            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfTypeAzure("Amt", "PI", " and ledcodecr !=1 and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("credit")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Credit");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Credit";

                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            //cardpurch = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr='2' and recpttype!='sv' and " + Wheredate + "");
            crdtpurch = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr!='1' and recpttype!='sv' and " + Wheredate + "");
            cashpurch = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr='1' and recpttype!='sv' and " + Wheredate + "");
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfTypeAzure("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;





            /*purchase Return*/
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '  " + Userid + "   ";
            TotPurreturn = (CommonClass._Businessissue.TottalAmountOfTypeAzure("Amt", "PR", " and " + Wheredate)).ToString("0.00");

            if (_dbtask.znllString(_print.getstatusprinting("Pr")) == "1")
            {
                Count = GridMain.Rows.Add(1);

                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Purchase Return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Purchase Return";

                GridMain.Rows[Count].Cells["clnamount2"].Value = TotPurreturn;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                /****************/
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            wheredate2 = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";
            wheredate3 = " Vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";
            string query = "";
            query = " And ledcodecr='1' AND MPAYMENT='0'  and " + wheredate2;
            SRcashonly = CommonClass._Transactionreceipt.TottalAmountOfTypewherequeryAzure("AMT", "SR", query);
            query = " And ledcodecr not in('1','28') AND MPAYMENT='1' and " + wheredate2;
            SRcreditonly = CommonClass._Transactionreceipt.TottalAmountOfTypewherequeryAzure("AMT", "SR", query);

            query = "  AND MPAYMENT='2'  and " + wheredate2;
            SRcardonly = CommonClass._Transactionreceipt.TottalAmountOfTypewherequeryAzure("AMT", "SR", query);




            totcasbalance = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='1' and  " + wheredate3 + " ");
            string Wheredateqty = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";

            double totcashBySALE = 0;
            totcashBySALE = CommonClass._Businessissue.totcashamtbysaleeeAzure("AND  " + Wheredate);
            double totcaRDBySALE = 0;
            totcaRDBySALE = CommonClass._Businessissue.totcrdamtbysaleAzure("AND  " + Wheredate);


            //****=====


            double salediscount = 0;
            salediscount = _dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( discamt) from tblbusinessissue  where issuetype='si' and mpayment in('2','0','1') and issuetype!='sv' and " + Wheredate + ""));
            TotalCardSale = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment in('2') and issuetype!='sv' and " + Wheredate + "");
            //Totalmada
            totmadavias = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype IN('si','POS') and mpayment not in('2','0','1') and issuetype!='sv' and " + Wheredate + "");
            TotalvisaMstr = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype IN('si','POS') and mpayment='3' and issuetype!='sv' and " + Wheredate + "");

            totsalesqty = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(qty) from tblissuedetails where issuecode in(select issuecode from tblbusinessissue where " + Wheredateqty + " and issuetype  IN('si','POS')) ").ToString();

            TotalCashSale = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment='0' and issuetype!='sv' and " + Wheredate + "");

            string TOTCRDTSALES = CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment ='1' and issuetype!='sv' and " + Wheredate + "");


            CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotalCashSale);

            double realtotsale = CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) + CommonClass._Dbtask.znlldoubletoobject(TOTCRDTSALES);
            //trns
            trnsale = CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) + CommonClass._Dbtask.znlldoubletoobject(totmadavias);// + ; +CommonClass._Dbtask.znlldoubletoobject(TOTCRDTSALES);
            string prTrnsctn = "";
            prTrnsctn = (CommonClass._Businessissue.TottalAmountOfTypewithotCRDTAzure("Amt", "PR", " and " + Wheredate)).ToString("0.00");
            double trpurrtn = 0;
            trpurrtn = CommonClass._Dbtask.znlldoubletoobject(prTrnsctn);
            string purwthoutcr = "";
            string WheredatePP = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";

            double salesretTrns = 0;
            purwthoutcr = (CommonClass._Transactionreceipt.TottalAmountOfTypewthoutcrAzure("Amt", "PI", " and " + WheredatePP)).ToString("0.00");
            trnspurch = CommonClass._Dbtask.znlldoubletoobject(purwthoutcr);
            salesretTrns = CARDsr + totcashSR;

            //trns


            //( TotalCardSale+TotalCashSale+TOTCRDTSALES)
            //SR
            totcashSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tbltransactionreceipt  where recpttype='sr'  and recpttype!='sv' and " + wheredate2 + ""));
            //crtSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='1' and recpttype!='sv' and " + wheredate2 + ""));
            //CARDsr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='2' and recpttype!='sv' and " + wheredate2 + ""));
            RealSR = CARDsr + totcashSR + crtSR;
            //pr
            totpr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum ( amt) from tblbusinessissue  where issuetype='pr'  and issuetype!='sv' and " + Wheredate + ""));

            totBank = CommonClass._Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where  " +
            " ledcode in(select lid  from tblaccountledger where agroupid  in(24))    and vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt").ToString() + "'");


            // totBank = CommonClass._Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where "+
            //"  ledcode in('28') and vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") +"' and '"+ DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt").ToString()+"'");
            //bank = (CommonClass._Dbtask.znlldoubletoobject(totBank) + CommonClass._Dbtask.znlldoubletoobject(OpeningBank)).ToString();



            /****Tax Amount**************/
            TaxPerc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select Vat from tblitemmaster")).ToString();

            double serviceamt = 0;
            double srvcsdisc = 0;
            serviceamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(amt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));
            srvcsdisc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(discamt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));


            double discc = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("  select sum(discamt) from tblbusinessissue where " + Wheredate + ""));

            TotaSale = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");

            //sales

            /*Total Sales */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.Sale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(realtotsale).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }

            if (_dbtask.znllString(_print.getstatusprinting("Category")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Category Details");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Category Details";
                GridMain.Rows[Count].Cells["clnamount2"].Value = " Net Amount";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                string datee = "  tblbusinessissue.issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '  " + Userid + "   ";

                //cat
                DataSet Di;
                Di = CommonClass._category.onlycatgryAzure(datee);
                DataSet dcat;
                dcat = CommonClass._category.getcategorywisereportsummeryAzure(datee);

                double netamtcat = 0; string frstcat = "";

                if (Di.Tables[0].Rows.Count > 0)
                {
                    for (int N = 0; N < Di.Tables[0].Rows.Count; N++)
                    {
                        netamtcat = 0; frstcat = "";
                        frstcat = _dbtask.znllString(Di.Tables[0].Rows[N]["categoryid"]);

                        if (dcat.Tables[0].Rows.Count > 0)
                        {
                            string catid = ""; string catname = ""; double catamt = 0;

                            for (int k = 0; k < dcat.Tables[0].Rows.Count; k++)
                            {

                                catid = _dbtask.znllString(dcat.Tables[0].Rows[k]["categoryid"]);
                                if (frstcat == catid)
                                {

                                    catname = _dbtask.znllString(dcat.Tables[0].Rows[k]["category"]);
                                    catamt = _dbtask.znlldoubletoobject(dcat.Tables[0].Rows[k]["netamt"]);
                                    netamtcat = netamtcat + catamt;
                                }


                            }



                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnnote"].Value = catname;
                            GridMain.Rows[Count].Cells["clnnoteE"].Value = "Category";
                            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(netamtcat).ToString();
                            GridMain.Rows[Count].Cells["clnnote"].Tag = frstcat;
                            GridMain.Rows[Count].Cells["clnamount2"].Tag = "Cat";
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);

                        }

                    }
                }

                //cat


            }







            if (_dbtask.znllString(_print.getstatusprinting("Tot.cardamtbysale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total CardAMT (by sale)");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total CardAMT (by sale)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totcaRDBySALE).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            if (_dbtask.znllString(_print.getstatusprinting("Tot.cashamtbysale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total CashAMT (by sale)");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total CashAMT (by sale)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totcashBySALE).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            if (_dbtask.znllString(_print.getstatusprinting("Totservice")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Service");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Service ";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(serviceamt).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }


            string Witemid;

            string Witemamt;
            string Wtaxamt;
            string Wgrossamt;

            double WitemamtTotal = 0;
            double WtaxamtTotal = 0;
            double WgrossamtTotal = 0;
            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("202")) == "1")
            {
                /*weight Mechine Items*/
                Ds1 = CommonClass._Itemmaster.ShowItemsBaseonCategoryAzure(" where Usingmechine=1");


                if (_dbtask.znllString(_print.getstatusprinting("Tot.mechine")) == "1")
                {

                    for (int i = 0; i < Ds1.Tables[0].Rows.Count; i++)
                    {
                        Count = GridMain.Rows.Add(1);

                        Witemid = CommonClass._Dbtask.znllString(Ds1.Tables[0].Rows[i]["itemid"]);

                        Witemamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(qty*rate) from tblissuedetails where pcode in(" + Witemid + ") and issuecode in( " +
                        " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");
                        Wtaxamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(Taxrate) from tblissuedetails where pcode in(" + Witemid + ") and issuecode in( " +
                        " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");
                        Wgrossamt = (CommonClass._Dbtask.znullDouble(Witemamt) - CommonClass._Dbtask.znullDouble(Wtaxamt)).ToString("0.00");

                        GridMain.Rows[Count].Cells["clnnoteE"].Value = "      " + CommonClass._Itemmaster.SpecificFieldAzure(Witemid, "itemname") +
                            "( Tax Amount:" + Wtaxamt + "  Gross Amount:" + Wgrossamt + ")";
                        GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Itemmaster.SpecificFieldAzure(Witemid, "llang");
                        GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(Witemamt);
                        GridMain.Rows[Count].Cells["clnnote"].Tag = "Wieghtmechine";
                        GridMain.Rows[Count].Cells["clnamount2"].Tag = Witemid;
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

                        WitemamtTotal = WitemamtTotal + CommonClass._Dbtask.znullDouble(Witemamt);
                        WtaxamtTotal = WtaxamtTotal + CommonClass._Dbtask.znullDouble(Wtaxamt);
                        WgrossamtTotal = WgrossamtTotal + CommonClass._Dbtask.znullDouble(Wgrossamt);
                    }
                }
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Mechine Amount:" + WitemamtTotal +
                    "( Tax Amount:" + WtaxamtTotal + "  Gross Amount:" + WgrossamtTotal + ")";
                GridMain.Rows[Count].Cells["clnnote"].Tag = "Wieghtmechine";
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

            }


            /******************************/

            if (_dbtask.znllString(_print.getstatusprinting("Tot.card")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total card sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Card";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }



            if (_dbtask.znllString(_print.getstatusprinting("Tot.visa/mada/master")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Visa/Master ,Mada ";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totmadavias);
                // CommonClass._Dbtask.znullDouble(Totalmada) + CommonClass._Dbtask.znullDouble(TotalvisaMstr);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            /*Total Cash Sale*/

            if (_dbtask.znllString(_print.getstatusprinting("Tot.cashSale")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Cash Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            /*Total Credit Sale*/

            if (_dbtask.znllString(_print.getstatusprinting("Salecredit")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Credit");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Credit";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TOTCRDTSALES);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            //totsaleqty
            if (Tsqty == 1)
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total.sales Qty");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total.sales Qty";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totsalesqty);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Violet;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            /*sales Return*/

            if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return";
                GridMain.Rows[Count].Cells["clnamount2"].Value = RealSR;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            }
            if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Cash)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = SRcashonly;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
            }

            if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Credit)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = SRcreditonly;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
            }

            if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Card)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = SRcardonly;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
            }






            /*Payment Tax*/
            string PaymentTax;
            PaymentTax = CommonClass._Dbtask.ExecuteScalarAzureServer("select SUM(RPTAXAMT) from tblgeneralledger where vtype='P' And vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' ");
            if (_dbtask.znllString(_print.getstatusprinting("paymenttax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Payment Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Payment Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;


                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(PaymentTax)));
            }
            /*Total Sales Tax*/
            string isuecode;
            string TaxstrSales;
            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype  IN('si','POS')";
            TaxstrSales = CommonClass._Dbtask.ExecuteScalarAzureServer("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype  IN('si','POS')");
            if (_dbtask.znllString(_print.getstatusprinting("Tot.saletax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sales Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sales Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;



                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(TaxstrSales)));

            }


            double taxsalessss = CommonClass._Dbtask.znullDouble(CommonClass._Businessissue.TottalAmountOfType("Taxamt", "SI", " and" + Wheredate).ToString()); ;

            //srtax
            double srtax = 0;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='SR'";
            srtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select isnull(sum(taxrate),0) from tblreceiptdetails   where recptcode in (" + isuecode + ") and vtype='SR'"));
            if (_dbtask.znllString(_print.getstatusprinting("Tot.SRtax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total SalesReturn Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total SalesReturn Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(srtax);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;

            }
            /*Total Purchase Tax*/
            string TaxstrPurchase;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='PI'";
            TaxstrPurchase = CommonClass._Dbtask.ExecuteScalarAzureServer("select isnull(sum(taxrate),0) from tblreceiptdetails   where Recptcode in (" + isuecode + ") and vtype='PI'");

            if (_dbtask.znllString(_print.getstatusprinting("Tot.purchasetax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Purchase Tax";


                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(TaxstrPurchase)));
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            //prtax
            double PRtax = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";

            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='PR'";
            PRtax = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='PR'"));


            if (_dbtask.znllString(_print.getstatusprinting("Tot.PRtax")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total PurchaseReturn Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total PurchaseReturn Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(PRtax);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;

            }


            /*Sales Tax -Purchase Tax*/
            if (_dbtask.znllString(_print.getstatusprinting("SalesTax-PurchaseTax")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Tax-Purchase Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Tax-Purchase Tax";
                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.znullDouble(TaxstrSales) - CommonClass._Dbtask.znullDouble(TaxstrPurchase)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            double TttotaSale = Convert.ToDouble(TotaSale) - discc;
            //GridMain.Rows[10].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Discount");
            //GridMain.Rows[10].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalDiscount);

            //gettax-paidtax
            double netgetpaidtax = 0;
            double gettax = 0; double paidtax = 0;
            gettax = Convert.ToDouble(TaxstrSales) + PRtax + CommonClass._Dbtask.znullDouble(PaymentTax);
            paidtax = srtax + Convert.ToDouble(TaxstrPurchase);
            netgetpaidtax = (gettax - paidtax);

            if (_dbtask.znllString(_print.getstatusprinting("Tax(get - paid)")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Tax( Get - Paid )");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Tax( Get - Paid )";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(netgetpaidtax);
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;
            }



            /*************/
            double Tgrosssales;
            double TgrossPurchase;
            /*Total Gross Sales */

            Tgrosssales = (realtotsale - CommonClass._Dbtask.znullDouble(TaxstrSales)) + salediscount;
            TgrossPurchase = CommonClass._Dbtask.znullDouble(TotalPurchase) - CommonClass._Dbtask.znullDouble(TaxstrPurchase);

            if (_dbtask.znllString(_print.getstatusprinting("Tot.grsssale")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Tgrosssales).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
            /*Total Gross Purchase */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.grsspurchase")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Purchase";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TgrossPurchase).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }


            /*Total Gross Purchase-Gross Saless */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.(pur-sale)")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Purchase-sales");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Purchase-sales";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TgrossPurchase - Tgrosssales).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }
            // /*Total Sales */
            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sale");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sale";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(realtotsale).ToString();
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // /*Total Card Sale*/
            // //Count = GridMain.Rows.Add(1);
            // //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Card Sale");
            // //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale);
            // //GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Mada");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Mada";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalvisaMstr);
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Visa/Master");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Visa/Master";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(Totalmada);
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            // /*Total Cash Sale*/
            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Cash Sale";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale);
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            // /*Total Credit Sale*/

            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Credit");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Credit";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TOTCRDTSALES);
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            // /*sales Return*/
            // Count = GridMain.Rows.Add(1);
            // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
            // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return";
            // GridMain.Rows[Count].Cells["clnamount2"].Value = RealSR;
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            //// TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;

            TotalPayment = (CommonClass._GenLedger.TottalAmountOfTypeAzure("cramt", "P", " and " + wheredate3)).ToString("0.00");
            TotalReceipt = (CommonClass._GenLedger.TottalAmountOfTypeAzure("dbamt", "R", "AND PURTICULARS!='Two type paymentSales' and " + wheredate3)).ToString("0.00");
            NetDBamt = (CommonClass._Dbtask.znullDouble(TotalReceipt) + CommonClass._Dbtask.znullDouble(TotalCashSale) + serviceamt).ToString("0.00");
            NetDBamt = (CommonClass._Dbtask.znullDouble(NetDBamt) + CommonClass._Dbtask.znullDouble(OpeningCash) + CommonClass._Dbtask.znullDouble(OpeningBank)).ToString("0.00");
            NetCramt = (CommonClass._Dbtask.znullDouble(TotalPayment) + CommonClass._Dbtask.znullDouble(cashpurch)).ToString("0.00");
            //NetCramt = Convert.ToString(CommonClass._Dbtask.znullDouble(NetCramt) + RealSR).ToString(); ;
            NetBalance = (CommonClass._Dbtask.znullDouble(NetDBamt) - CommonClass._Dbtask.znullDouble(NetCramt)).ToString("0.00");

            if (_dbtask.znllString(_print.getstatusprinting("payment")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Payment");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Payment";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPayment;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);



                CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotalReceipt);
                CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotPurreturn);
                CashClosing = CashClosing - CommonClass._Dbtask.znullDouble(TotalPayment);
                CashClosing = CashClosing - totcashSR;



                if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("211")) == "1")
                {

                    Ds = CommonClass._Dbtask.ExecuteQueryAzureServer("select DISTINCT LEDCODE from tblgeneralledger  where vtype in ('P') and cramt=0 and vdate " +
                            " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'");

                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                        string StrPurticulars = CommonClass._Ledger.GetspecifFieldAzure("lname", AccountID);
                        //string Pymntvno = Ds.Tables[0].Rows[i]["vno"].ToString();  
                        double DbAmount = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(dbamt) from tblgeneralledger  where vtype in ('P') and cramt=0  and ledcode='" + AccountID + "'and vdate " +
                            " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'"));



                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
                        GridMain.Rows[Count].Cells[0].Tag = AccountID;
                        GridMain.Rows[Count].Cells[1].Tag = AccountID;
                        GridMain.Rows[Count].Cells[2].Value = DbAmount;
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                    }
                }

            }


            //RECIPT


            if (_dbtask.znllString(_print.getstatusprinting("receipt")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Receipt");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Receipt";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalReceipt;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("211")) == "1")
                {

                    Ds = CommonClass._Dbtask.ExecuteQueryAzureServer("select DISTINCT LEDCODE from tblgeneralledger  where vtype in ('R') and DBamt=0 and vdate " +
                           " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'");


                    // " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

                    for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                        string StrPurticulars = CommonClass._Ledger.GetspecifFieldAzure("lname", AccountID);
                        //string Pymntvno = Ds.Tables[0].Rows[i]["vno"].ToString();  
                        double DbAmount = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(CRamt) from tblgeneralledger  where vtype in ('R') and DBamt=0  and ledcode='" + AccountID + "'and vdate " +
                            " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'"));



                        Count = GridMain.Rows.Add(1);

                        GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
                        GridMain.Rows[Count].Cells[0].Tag = AccountID;
                        GridMain.Rows[Count].Cells[1].Tag = AccountID;
                        GridMain.Rows[Count].Cells[2].Value = DbAmount;
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                    }
                }


            }

            // realtotsale=
            //serviceamt = serviceamt - srvcsdisc; 
            //Count = GridMain.Rows.Add(1);
            //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Services");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(serviceamt).ToString(); //+ CommonClass._Dbtask.znullDouble(TotalCashSale);
            double frst = CommonClass._Dbtask.znullDouble(TotalCashSale) + CommonClass._Dbtask.znullDouble(TotalReceipt) + CommonClass._Dbtask.znullDouble(TotPurreturn) + CommonClass._Dbtask.znullDouble(OpeningCash);
            double secnd = CommonClass._Dbtask.znullDouble(cashpurch) + CommonClass._Dbtask.znullDouble(TotalPayment) + RealSR;


            NetBalance = (CommonClass._Dbtask.znullDouble(NetBalance) + CommonClass._Dbtask.znullDouble(TotPurreturn)).ToString("0.00");
            NetBalance = (CommonClass._Dbtask.znullDouble(NetBalance) + totpr - RealSR).ToString("0.00");
            NetBalance = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(frst - secnd)).ToString();


            double custdb = 0;
            double custcr = 0;
            double cusRemaing = 0;
            custdb = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum( tblgeneralledger. dbamt )  from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='18' and " + wheredate3));
            custcr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select  sum(tblgeneralledger.cramt ) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='18' and " + wheredate3));
            cusRemaing = custdb - custcr;

            double suppDB = 0;
            double suppCr = 0;
            double supRemaing = 0;

            suppDB = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(tblgeneralledger.dbamt) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='19' and " + wheredate3));
            suppCr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalarAzureServer("select sum(tblgeneralledger.cramt) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='19' and " + wheredate3));
            supRemaing = suppCr - suppDB;

            double bank2cash = 0;
            //bank2cash = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(cramt) from tblgeneralledger where  vtype in('p','r') and ledcode='28' and " + wheredate3));
            double cash2bank = 0;
            //cash2bank = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(dbamt) from tblgeneralledger where  vtype in('p','r') and ledcode='28' and " + wheredate3));
            double Totbnktocash = 0; double TotcashtoBank = 0;
            cash2bank = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtReceiptAzure(wheredate3, "C2B"));

            bank2cash = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtReceiptAzure(wheredate3, "B2C"));

            double cash2bankP = 0; double bank2cashP = 0;

            cash2bankP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtPaymentAzure(wheredate3, "C2B"));

            bank2cashP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtPaymentAzure(wheredate3, "B2C"));

            Totbnktocash = bank2cash - bank2cashP;
            if (Totbnktocash < 0)
            {
                Totbnktocash = Totbnktocash * (-1);
            }
            TotcashtoBank = cash2bank - cash2bankP;
            if (TotcashtoBank < 0)
            {
                TotcashtoBank = TotcashtoBank * (-1);
            }


            if (_dbtask.znllString(_print.getstatusprinting("bankblnce")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank Balance");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Bank Balance";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totBank);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }


            double PlusAmount;
            double LessAmount;
            double TransactionBalance = 0;
            /******temparary***********/
            PlusAmount = CommonClass._Dbtask.znullDouble(TotalReceipt) + trpurrtn + CommonClass._Dbtask.znullDouble(OpeningCash) + trnsale;
            LessAmount = CommonClass._Dbtask.znullDouble(TotalPayment) + salesretTrns + trnspurch;
            TransactionBalance = PlusAmount - LessAmount;
            //TransactionBalance = TransactionBalance - cusRemaing;

            /****************************/

            if (_dbtask.znllString(_print.getstatusprinting("tot.cashBalnce")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total cash balance");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total cash balance";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(totcasbalance));
                //CashClosing);
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            if (_dbtask.znllString(_print.getstatusprinting("TransactnBalnce")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Transaction Balance");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Transaction Balance";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TransactionBalance;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            //CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotPurreturn);
            //CashClosing = CashClosing - RealSR;


            //cashbnk
            if (_dbtask.znllString(_print.getstatusprinting("Bank-cash")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank to Cash");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Bank to Cash";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(Totbnktocash);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            if (_dbtask.znllString(_print.getstatusprinting("cash-bank")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash to Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash to Bank";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(TotcashtoBank);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            if (_dbtask.znllString(_print.getstatusprinting("Customer reamins")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Customers remaining Amount");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Customers remaining Amount";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(cusRemaing);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }


            if (_dbtask.znllString(_print.getstatusprinting("Supplier reamins")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Supplier remaining Amount");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Supplier remaining Amount";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(supRemaing);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            if (_dbtask.znllString(_print.getstatusprinting("cash&bankAMT")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash + Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash + Bank";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(totBank) + CommonClass._Dbtask.znlldoubletoobject(totcasbalance);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }


            // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._GenLedger.
        }

 
        


        public void SummuryReport()
            {

            GridMain.BackgroundColor = Color.White;
            Pnltop.BackColor = Color.LightPink;
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            GridMain.Columns.Add("clnnoteE", "Details");
            GridMain.Columns["clnnoteE"].Width = 600;
            
            GridMain.Columns.Add("clnnote", "NOTE");
            GridMain.Columns["clnnote"].Width = 300;
            GridMain.RowTemplate.Height = 27;
           

            GridMain.Columns.Add("clnamount2", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount2", 200);

            double TQty = 0;
            double TRate = 0;
            double Ttax = 0;
            double TAmount = 0;


            suumerybool = true;
            //string Bcode;
            double Qty;
            double Rate;
            double Amount;
            double TaxAmount = new double();

            string TotalCardSaleTax;
            string TotalCashSaleTax;
            string TaxPerc;
            string TotalCardSale;
            string Totalmada;
            string TotalvisaMstr;
            string TotalCashSale;
            string TotalCreditSale;
            string totmadavias = "";
            double totcashSR = 0;
            double crtSR = 0;
            double CARDsr = 0;
            double RealSR = 0;
            double trnsale = 0;
            double  trnssr = 0;
            double trnspurch = 0;
            string totcasbalance = "";
             string transppr="";

            string OpeningCash;
            string OpeningBank;
            string TotalPurchase;
            string TotaSale;
            string TotPurreturn;
            string TotSalereturn ;
            string TotalPayment;
            string TotalReceipt;

            double SRcashonly = 0;
            double SRcardonly = 0;
            double SRcreditonly = 0;

            double CashClosing;
           string totsalesqty ="";
            string bank = "";
            string NetDBamt;
            string NetCramt;
            string NetBalance;
            string totBank = "";
            double totpr = 0;
            string cashpurch = "";
            string crdtpurch = "";
            string cardpurch = "";
            //DtFrom.Value = CommonClass._Gen.GetFyearFrom();
            //DtFrom.Value.TimeOfDay = DateTime.Now.TimeOfDay;
            string Wheredate;
            
            Wheredate = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' "+Userid+"    ";

            int Count;

            /*OPening Cash*/
            OpeningCash = (CommonClass._GenLedger.getopeningbalance("1")).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("Opencash")) == "1")
            {


            Count = GridMain.Rows.Add(1);
            
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Opening Cash");
            GridMain.Rows[Count].Cells["clnnoteE"].Value = "Opening Cash";
            
           
            GridMain.Rows[Count].Cells["clnamount2"].Value = OpeningCash;
            GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
            /*Opening Bank*/
            OpeningBank = (CommonClass._GenLedger.getopeningbalance("28")).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("OpeningBank")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Opening Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Opening Bank";
                
                GridMain.Rows[Count].Cells["clnamount2"].Value = OpeningBank;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
                 
                 
                 /*Total Purchase*/
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("Tot.purchase")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Purchase";
                

                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
                
                /*Total Cash Purchase*/
            CashClosing = CommonClass._Dbtask.znullDouble(OpeningCash) - CommonClass._Dbtask.znullDouble(TotalPurchase);
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and ledcodecr =1  and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("cash.purchase")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash Purchase";
                
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;

                
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
            }




            /*Total Credit Purchase*/

            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and ledcodecr !=1 and " + Wheredate)).ToString("0.00");
            if (_dbtask.znllString(_print.getstatusprinting("credit")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Credit");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Credit";
                
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            //cardpurch = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr='2' and recpttype!='sv' and " + Wheredate + "");
            crdtpurch = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr!='1' and recpttype!='sv' and " + Wheredate + "");
            cashpurch = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from  tbltransactionreceipt  where recpttype='pi'  and ledcodecr='1' and recpttype!='sv' and " + Wheredate + "");
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;



            

            /*purchase Return*/
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '  " + Userid + "   ";
            TotPurreturn = (CommonClass._Businessissue.TottalAmountOfType("Amt", "PR", " and " + Wheredate)).ToString("0.00");

            if (_dbtask.znllString(_print.getstatusprinting("Pr")) == "1")
            {
                Count = GridMain.Rows.Add(1);

                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Purchase Return");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Purchase Return";

                GridMain.Rows[Count].Cells["clnamount2"].Value = TotPurreturn;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                /****************/
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            wheredate2 = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";
            wheredate3 = " Vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";
            string query = "";
            query = " And ledcodecr='1' AND MPAYMENT='0'  and " + wheredate2;
            SRcashonly = CommonClass._Transactionreceipt.TottalAmountOfTypewherequery("AMT", "SR", query);
            query = " And ledcodecr not in('1','28') AND MPAYMENT='1' and " + wheredate2;
            SRcreditonly= CommonClass._Transactionreceipt.TottalAmountOfTypewherequery("AMT", "SR", query);

            query = "  AND MPAYMENT='2'  and " + wheredate2;
           SRcardonly = CommonClass._Transactionreceipt.TottalAmountOfTypewherequery("AMT", "SR", query);




                totcasbalance = CommonClass._Dbtask.ExecuteScalar("select sum(dbamt)-sum(cramt) from tblgeneralledger where ledcode='1' and  " + wheredate3 + " ");
            string Wheredateqty = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + " ";

            double totcashBySALE = 0;
            totcashBySALE = CommonClass._Businessissue.totcashamtbysaleee("AND  " + Wheredate);
            double totcaRDBySALE = 0;
            totcaRDBySALE = CommonClass._Businessissue.totcrdamtbysale("AND  " + Wheredate);
            
            
            //****=====


            double salediscount = 0;
            salediscount =_dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select sum ( discamt) from tblbusinessissue  where issuetype='si' and mpayment in('2','0','1') and issuetype!='sv' and " + Wheredate + ""));
            TotalCardSale = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment in('2') and issuetype!='sv' and " + Wheredate + "");
            //Totalmada
            totmadavias = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype IN('si','POS') and mpayment not in('2','0','1') and issuetype!='sv' and " + Wheredate + "");
            TotalvisaMstr = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype IN('si','POS') and mpayment='3' and issuetype!='sv' and " + Wheredate + "");

            totsalesqty = CommonClass._Dbtask.ExecuteScalar("select sum(qty) from tblissuedetails where issuecode in(select issuecode from tblbusinessissue where " + Wheredateqty + " and issuetype  IN('si','POS')) ").ToString();

            TotalCashSale = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment='0' and issuetype!='sv' and " + Wheredate + "");

            string TOTCRDTSALES = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype  IN('si','POS') and mpayment ='1' and issuetype!='sv' and " + Wheredate + "");
            
            
            CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotalCashSale);

            double realtotsale = CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) + CommonClass._Dbtask.znlldoubletoobject(TOTCRDTSALES);
            //trns
            trnsale = CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) + CommonClass._Dbtask.znlldoubletoobject(totmadavias);// + ; +CommonClass._Dbtask.znlldoubletoobject(TOTCRDTSALES);
           string prTrnsctn="";
           prTrnsctn = (CommonClass._Businessissue.TottalAmountOfTypewithotCRDT("Amt", "PR", " and " + Wheredate)).ToString("0.00");
           double trpurrtn = 0;
           trpurrtn = CommonClass._Dbtask.znlldoubletoobject(prTrnsctn);
           string purwthoutcr="";
           string WheredatePP = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";
            
            double salesretTrns = 0;
            purwthoutcr = (CommonClass._Transactionreceipt.TottalAmountOfTypewthoutcr("Amt", "PI", " and " + WheredatePP)).ToString("0.00");
           trnspurch = CommonClass._Dbtask.znlldoubletoobject(purwthoutcr);
           salesretTrns = CARDsr + totcashSR;
            
            //trns
            
            
            //( TotalCardSale+TotalCashSale+TOTCRDTSALES)
            //SR
            totcashSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr'  and recpttype!='sv' and " + wheredate2 + ""));
            //crtSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='1' and recpttype!='sv' and " + wheredate2 + ""));
            //CARDsr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='2' and recpttype!='sv' and " + wheredate2 + ""));
            RealSR = CARDsr + totcashSR + crtSR;
            //pr
            totpr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='pr'  and issuetype!='sv' and " + Wheredate + ""));

             totBank = CommonClass._Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where  "+
             " ledcode in(select lid  from tblaccountledger where agroupid  in(24))    and vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt").ToString() + "'");


           // totBank = CommonClass._Dbtask.ExecuteScalar("select sum(dbamt-cramt) from tblgeneralledger where "+
           //"  ledcode in('28') and vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") +"' and '"+ DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt").ToString()+"'");
         //bank = (CommonClass._Dbtask.znlldoubletoobject(totBank) + CommonClass._Dbtask.znlldoubletoobject(OpeningBank)).ToString();



            /****Tax Amount**************/
            TaxPerc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select Vat from tblitemmaster")).ToString();
      
            double serviceamt = 0;
            double srvcsdisc = 0;
            serviceamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(amt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));
            srvcsdisc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(discamt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));


            double discc = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("  select sum(discamt) from tblbusinessissue where " + Wheredate + ""));

            TotaSale = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");

            //sales

            /*Total Sales */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.Sale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(realtotsale).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }

            if (_dbtask.znllString(_print.getstatusprinting("Category")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Category Details");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Category Details";
                GridMain.Rows[Count].Cells["clnamount2"].Value = " Net Amount";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                string datee = "  tblbusinessissue.issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '  " + Userid + "   ";

                //cat
                DataSet Di;
                Di = CommonClass._category.onlycatgry(datee);
                DataSet dcat;
                dcat = CommonClass._category.getcategorywisereportsummery(datee);

                double netamtcat = 0; string frstcat = "";

                if (Di.Tables[0].Rows.Count > 0)
                {
                    for (int N = 0; N < Di.Tables[0].Rows.Count; N++)
                    {
                        netamtcat = 0; frstcat = "";
                        frstcat = _dbtask.znllString(Di.Tables[0].Rows[N]["categoryid"]);

                        if (dcat.Tables[0].Rows.Count > 0)
                        {
                            string catid = ""; string catname = ""; double catamt = 0;

                            for (int k = 0; k < dcat.Tables[0].Rows.Count; k++)
                            {

                                catid = _dbtask.znllString(dcat.Tables[0].Rows[k]["categoryid"]);
                                if (frstcat == catid)
                                {

                                    catname = _dbtask.znllString(dcat.Tables[0].Rows[k]["category"]);
                                    catamt = _dbtask.znlldoubletoobject(dcat.Tables[0].Rows[k]["netamt"]);
                                    netamtcat = netamtcat + catamt;
                                }


                            }



                            Count = GridMain.Rows.Add(1);
                            GridMain.Rows[Count].Cells["clnnote"].Value = catname;
                            GridMain.Rows[Count].Cells["clnnoteE"].Value = "Category";
                            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(netamtcat).ToString();
                            GridMain.Rows[Count].Cells["clnnote"].Tag = frstcat;
                            GridMain.Rows[Count].Cells["clnamount2"].Tag = "Cat";
                            GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;
                            GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);

                        }

                    }
                }

                //cat


            }







            if (_dbtask.znllString(_print.getstatusprinting("Tot.cardamtbysale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total CardAMT (by sale)");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total CardAMT (by sale)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totcaRDBySALE).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            if (_dbtask.znllString(_print.getstatusprinting("Tot.cashamtbysale")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total CashAMT (by sale)");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total CashAMT (by sale)";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(totcashBySALE).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }

            if (_dbtask.znllString(_print.getstatusprinting("Totservice")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Service");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Service ";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(serviceamt).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
                
                
                string Witemid;

            string Witemamt;
            string Wtaxamt;
            string Wgrossamt;

            double WitemamtTotal = 0;
            double WtaxamtTotal = 0;
            double WgrossamtTotal = 0;
            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("202")) == "1")
            {
                /*weight Mechine Items*/
                Ds1 = CommonClass._Itemmaster.ShowItemsBaseonCategory(" where Usingmechine=1");


                if (_dbtask.znllString(_print.getstatusprinting("Tot.mechine")) == "1")
                {

                    for (int i = 0; i < Ds1.Tables[0].Rows.Count; i++)
                    {
                        Count = GridMain.Rows.Add(1);

                        Witemid = CommonClass._Dbtask.znllString(Ds1.Tables[0].Rows[i]["itemid"]);

                        Witemamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where pcode in(" + Witemid + ") and issuecode in( " +
                        " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");
                        Wtaxamt = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(Taxrate) from tblissuedetails where pcode in(" + Witemid + ") and issuecode in( " +
                        " select issuecode from tblbusinessissue where" + Wheredate + " )")).ToString("0.00");
                        Wgrossamt = (CommonClass._Dbtask.znullDouble(Witemamt) - CommonClass._Dbtask.znullDouble(Wtaxamt)).ToString("0.00");

                        GridMain.Rows[Count].Cells["clnnoteE"].Value = "      " + CommonClass._Itemmaster.SpecificField(Witemid, "itemname") +
                            "( Tax Amount:" + Wtaxamt + "  Gross Amount:" + Wgrossamt + ")";
                        GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Itemmaster.SpecificField(Witemid, "llang");
                        GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(Witemamt);
                        GridMain.Rows[Count].Cells["clnnote"].Tag = "Wieghtmechine";
                        GridMain.Rows[Count].Cells["clnamount2"].Tag = Witemid;
                        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Italic);
                        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

                        WitemamtTotal = WitemamtTotal + CommonClass._Dbtask.znullDouble(Witemamt);
                        WtaxamtTotal = WtaxamtTotal + CommonClass._Dbtask.znullDouble(Wtaxamt);
                        WgrossamtTotal = WgrossamtTotal + CommonClass._Dbtask.znullDouble(Wgrossamt);
                    }
                }
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Mechine Amount:" + WitemamtTotal +
                    "( Tax Amount:" + WtaxamtTotal + "  Gross Amount:" + WgrossamtTotal + ")";
                GridMain.Rows[Count].Cells["clnnote"].Tag = "Wieghtmechine";
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

            }
            
            
            /******************************/

            if (_dbtask.znllString(_print.getstatusprinting("Tot.card")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total card sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Card";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }



            if (_dbtask.znllString(_print.getstatusprinting("Tot.visa/mada/master")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Visa/Master ,Mada ";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totmadavias);
                // CommonClass._Dbtask.znullDouble(Totalmada) + CommonClass._Dbtask.znullDouble(TotalvisaMstr);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            /*Total Cash Sale*/

            if (_dbtask.znllString(_print.getstatusprinting("Tot.cashSale")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Cash Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            /*Total Credit Sale*/

            if (_dbtask.znllString(_print.getstatusprinting("Salecredit")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Credit");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Credit";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TOTCRDTSALES);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
                 
                 //totsaleqty
                if(Tsqty==1)
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total.sales Qty");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total.sales Qty";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totsalesqty);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Violet;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            /*sales Return*/

                if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                    GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return";
                    GridMain.Rows[Count].Cells["clnamount2"].Value = RealSR;
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                    GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Cash)";
                    GridMain.Rows[Count].Cells["clnamount2"].Value = SRcashonly;
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
                }

                if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                    GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Credit)";
                    GridMain.Rows[Count].Cells["clnamount2"].Value = SRcreditonly;
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
                }

                if (_dbtask.znllString(_print.getstatusprinting("SR")) == "1")
                {
                    Count = GridMain.Rows.Add(1);
                    GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
                    GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return(Card)";
                    GridMain.Rows[Count].Cells["clnamount2"].Value = SRcardonly;
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    // TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
                    GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DarkKhaki;
                }






            /*Payment Tax*/
            string PaymentTax;
            PaymentTax = CommonClass._Dbtask.ExecuteScalar("select SUM(RPTAXAMT) from tblgeneralledger where vtype='P' And vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' ");
            if (_dbtask.znllString(_print.getstatusprinting("paymenttax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Payment Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Payment Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

                
                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(PaymentTax)));
            }
            /*Total Sales Tax*/
            string isuecode;
            string TaxstrSales;
            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype  IN('si','POS')";
            TaxstrSales = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype  IN('si','POS')");
            if (_dbtask.znllString(_print.getstatusprinting("Tot.saletax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sales Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sales Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                
                

                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(TaxstrSales)));

            }
            
            
            double taxsalessss = CommonClass._Dbtask.znullDouble(CommonClass._Businessissue.TottalAmountOfType("Taxamt", "SI", " and" + Wheredate).ToString()); ;

            //srtax
            double srtax = 0;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='SR'";
            srtax =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where recptcode in (" + isuecode + ") and vtype='SR'"));
            if (_dbtask.znllString(_print.getstatusprinting("Tot.SRtax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total SalesReturn Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total SalesReturn Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(srtax);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;

            }
            /*Total Purchase Tax*/
            string TaxstrPurchase;
            Wheredate = " Recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";
            isuecode = "select Reptcode from tbltransactionreceipt where " + Wheredate + " and Recpttype='PI'";
            TaxstrPurchase = CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblreceiptdetails   where Recptcode in (" + isuecode + ") and vtype='PI'");

            if (_dbtask.znllString(_print.getstatusprinting("Tot.purchasetax")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Purchase Tax";
                
                
                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znullDouble(TaxstrPurchase)));
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
                
                //prtax
            double PRtax = 0;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " ' " + Userid + "";

            isuecode = "select issuecode from tblbusinessissue where " + Wheredate + " and issuetype='PR'";
            PRtax =CommonClass._Dbtask.znlldoubletoobject( CommonClass._Dbtask.ExecuteScalar("select isnull(sum(taxrate),0) from tblissuedetails   where issuecode in (" + isuecode + ") and vtype='PR'"));


            if (_dbtask.znllString(_print.getstatusprinting("Tot.PRtax")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total PurchaseReturn Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total PurchaseReturn Tax";
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(PRtax);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;

            }


            /*Sales Tax -Purchase Tax*/
            if (_dbtask.znllString(_print.getstatusprinting("SalesTax-PurchaseTax")) == "1")
            {
            
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Tax-Purchase Tax");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Tax-Purchase Tax";
                GridMain.Rows[Count].Cells["clnamount2"].Value = (CommonClass._Dbtask.znullDouble(TaxstrSales) - CommonClass._Dbtask.znullDouble(TaxstrPurchase)).ToString("0.00");
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
                
                double TttotaSale = Convert.ToDouble(TotaSale) - discc;
            //GridMain.Rows[10].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Discount");
            //GridMain.Rows[10].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalDiscount);

            //gettax-paidtax
            double netgetpaidtax = 0;
            double gettax =0;double paidtax=0;
            gettax =Convert.ToDouble( TaxstrSales)  +  PRtax+CommonClass._Dbtask.znullDouble(PaymentTax);
            paidtax = srtax+Convert.ToDouble( TaxstrPurchase);
            netgetpaidtax =( gettax - paidtax);

            if (_dbtask.znllString(_print.getstatusprinting("Tax(get - paid)")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Tax( Get - Paid )");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Tax( Get - Paid )";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(netgetpaidtax);
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.ForeColor = Color.Blue;
            }



            /*************/
            double Tgrosssales;
            double TgrossPurchase;
            /*Total Gross Sales */

            Tgrosssales = (realtotsale - CommonClass._Dbtask.znullDouble(TaxstrSales)) + salediscount   ;
            TgrossPurchase =CommonClass._Dbtask.znullDouble( TotalPurchase) -CommonClass._Dbtask.znullDouble( TaxstrPurchase);

            if (_dbtask.znllString(_print.getstatusprinting("Tot.grsssale")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Sale");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Sale";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Tgrosssales).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            }
            /*Total Gross Purchase */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.grsspurchase")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Purchase");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Purchase";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TgrossPurchase).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }


            /*Total Gross Purchase-Gross Saless */

            if (_dbtask.znllString(_print.getstatusprinting("Tot.(pur-sale)")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Gross Purchase-sales");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Gross Purchase-sales";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TgrossPurchase - Tgrosssales).ToString();
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            }
           // /*Total Sales */
           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sale");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Sale";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(realtotsale).ToString();
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // /*Total Card Sale*/
           // //Count = GridMain.Rows.Add(1);
           // //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Card Sale");
           // //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale);
           // //GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // //GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;

           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Mada");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Mada";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalvisaMstr);
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Visa/Master");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Visa/Master";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(Totalmada);
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
           
           // /*Total Cash Sale*/
           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total Cash Sale";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale);
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

           // /*Total Credit Sale*/
           
           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales Credit");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales Credit";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TOTCRDTSALES);
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

           // /*sales Return*/
           // Count = GridMain.Rows.Add(1);
           // GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales return");
           // GridMain.Rows[Count].Cells["clnnoteE"].Value = "Sales return";
           // GridMain.Rows[Count].Cells["clnamount2"].Value = RealSR;
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
           //// TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
           // GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
           // GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           // GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;

            TotalPayment = (CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + wheredate3)).ToString("0.00");
            TotalReceipt = (CommonClass._GenLedger.TottalAmountOfType("dbamt", "R", "AND PURTICULARS!='Two type paymentSales' and " + wheredate3)).ToString("0.00");
            NetDBamt = (CommonClass._Dbtask.znullDouble(TotalReceipt) +CommonClass._Dbtask.znullDouble( TotalCashSale )+ serviceamt).ToString("0.00");
            NetDBamt =(CommonClass._Dbtask.znullDouble( NetDBamt) + CommonClass._Dbtask.znullDouble(OpeningCash) + CommonClass._Dbtask.znullDouble(OpeningBank)).ToString("0.00");
            NetCramt = (CommonClass._Dbtask.znullDouble(TotalPayment) + CommonClass._Dbtask.znullDouble(cashpurch)).ToString("0.00");
            //NetCramt = Convert.ToString(CommonClass._Dbtask.znullDouble(NetCramt) + RealSR).ToString(); ;
            NetBalance = (CommonClass._Dbtask.znullDouble(NetDBamt) - CommonClass._Dbtask.znullDouble(NetCramt)).ToString("0.00");

            if (_dbtask.znllString(_print.getstatusprinting("payment")) == "1")
            {
                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Payment");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Payment";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPayment;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            
          
           
            CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotalReceipt);
            CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotPurreturn);
            CashClosing = CashClosing - CommonClass._Dbtask.znullDouble(TotalPayment);
            CashClosing = CashClosing - totcashSR;



            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("211")) == "1")
            {

                Ds = CommonClass._Dbtask.ExecuteQuery("select DISTINCT LEDCODE from tblgeneralledger  where vtype in ('P') and cramt=0 and vdate " +
                        " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'");

                for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                    string StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                    //string Pymntvno = Ds.Tables[0].Rows[i]["vno"].ToString();  
                    double DbAmount = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(dbamt) from tblgeneralledger  where vtype in ('P') and cramt=0  and ledcode='" + AccountID + "'and vdate " +
                        " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'"));



                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
                    GridMain.Rows[Count].Cells[0].Tag = AccountID;
                    GridMain.Rows[Count].Cells[1].Tag = AccountID;
                    GridMain.Rows[Count].Cells[2].Value = DbAmount;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                }
            }
                
            }
                
                
                //RECIPT


            if (_dbtask.znllString(_print.getstatusprinting("receipt")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Receipt");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Receipt";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TotalReceipt;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

                if(_dbtask.znllString( CommonClass._Menusettings.GetMnustatus("211"))=="1")
                {

                Ds = CommonClass._Dbtask.ExecuteQuery("select DISTINCT LEDCODE from tblgeneralledger  where vtype in ('R') and DBamt=0 and vdate " +
                       " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'");


                // " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

                for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                    string StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                    //string Pymntvno = Ds.Tables[0].Rows[i]["vno"].ToString();  
                    double DbAmount = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(CRamt) from tblgeneralledger  where vtype in ('R') and DBamt=0  and ledcode='" + AccountID + "'and vdate " +
                        " between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy  hh:mm tt") + "'"));



                    Count = GridMain.Rows.Add(1);

                    GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
                    GridMain.Rows[Count].Cells[0].Tag = AccountID;
                    GridMain.Rows[Count].Cells[1].Tag = AccountID;
                    GridMain.Rows[Count].Cells[2].Value = DbAmount;
                    GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                    GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                }
                }


            }
           
           // realtotsale=
            //serviceamt = serviceamt - srvcsdisc; 
            //Count = GridMain.Rows.Add(1);
            //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Services");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(serviceamt).ToString(); //+ CommonClass._Dbtask.znullDouble(TotalCashSale);
            double frst =CommonClass._Dbtask.znullDouble( TotalCashSale) + CommonClass._Dbtask.znullDouble(TotalReceipt) + CommonClass._Dbtask.znullDouble(TotPurreturn) + CommonClass._Dbtask.znullDouble(OpeningCash);
            double secnd = CommonClass._Dbtask.znullDouble(cashpurch) + CommonClass._Dbtask.znullDouble(TotalPayment) + RealSR;


            NetBalance =(CommonClass._Dbtask.znullDouble(NetBalance) +CommonClass._Dbtask.znullDouble( TotPurreturn)).ToString("0.00");
            NetBalance =(CommonClass._Dbtask.znullDouble(NetBalance) + totpr - RealSR).ToString("0.00");
            NetBalance =CommonClass._Dbtask.SetintoDecimalpoint( CommonClass._Dbtask.znlldoubletoobject(frst - secnd)).ToString();


            double custdb = 0;
            double custcr = 0;
            double cusRemaing = 0;
            custdb = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum( tblgeneralledger. dbamt )  from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='18' and "+wheredate3));
            custcr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select  sum(tblgeneralledger.cramt ) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='18' and " + wheredate3));
            cusRemaing = custdb - custcr;

                double suppDB = 0;
            double suppCr = 0;
            double supRemaing = 0;

            suppDB = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(tblgeneralledger.dbamt) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='19' and " + wheredate3));
            suppCr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(tblgeneralledger.cramt) from tblgeneralledger inner join tblaccountledger on tblgeneralledger.ledcode=tblaccountledger.lid and tblaccountledger.agroupid='19' and " + wheredate3));
            supRemaing = suppCr - suppDB;

            double bank2cash = 0;
            //bank2cash = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(cramt) from tblgeneralledger where  vtype in('p','r') and ledcode='28' and " + wheredate3));
            double cash2bank = 0;
            //cash2bank = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum(dbamt) from tblgeneralledger where  vtype in('p','r') and ledcode='28' and " + wheredate3));
            double Totbnktocash = 0; double TotcashtoBank = 0;
          cash2bank = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtReceipt(wheredate3,"C2B"));

          bank2cash = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtReceipt(wheredate3, "B2C"));

       double cash2bankP = 0; double bank2cashP = 0;

       cash2bankP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtPayment(wheredate3, "C2B"));

       bank2cashP = CommonClass._Dbtask.znlldoubletoobject(CommonClass._GenLedger.cashtobankamtPayment(wheredate3, "B2C"));

       Totbnktocash = bank2cash - bank2cashP;
       if (Totbnktocash<0)
            {
                Totbnktocash = Totbnktocash * (-1);
            }
       TotcashtoBank = cash2bank - cash2bankP;
       if (TotcashtoBank < 0)
       {
           TotcashtoBank = TotcashtoBank * (-1);
       }


       if (_dbtask.znllString(_print.getstatusprinting("bankblnce")) == "1")
       {

           Count = GridMain.Rows.Add(1);
           GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank Balance");
           GridMain.Rows[Count].Cells["clnnoteE"].Value = "Bank Balance";
           GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(totBank);
           GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
           GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
           GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
       }


            double PlusAmount;
            double LessAmount;
            double TransactionBalance=0;
            /******temparary***********/
            PlusAmount = CommonClass._Dbtask.znullDouble(TotalReceipt) +trpurrtn + CommonClass._Dbtask.znullDouble(OpeningCash) + trnsale;
            LessAmount = CommonClass._Dbtask.znullDouble(TotalPayment) + salesretTrns + trnspurch;
            TransactionBalance = PlusAmount - LessAmount;
            //TransactionBalance = TransactionBalance - cusRemaing;
            
            /****************************/

            if (_dbtask.znllString(_print.getstatusprinting("tot.cashBalnce")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total cash balance");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Total cash balance";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(_dbtask.znlldoubletoobject(totcasbalance));
                //CashClosing);
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }

            if (_dbtask.znllString(_print.getstatusprinting("TransactnBalnce")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Transaction Balance");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Transaction Balance";
                GridMain.Rows[Count].Cells["clnamount2"].Value = TransactionBalance;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            //CashClosing = CashClosing + CommonClass._Dbtask.znullDouble(TotPurreturn);
            //CashClosing = CashClosing - RealSR;

           
            //cashbnk
            if (_dbtask.znllString(_print.getstatusprinting("Bank-cash")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Bank to Cash");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Bank to Cash";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(Totbnktocash);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            if (_dbtask.znllString(_print.getstatusprinting("cash-bank")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash to Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash to Bank";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(TotcashtoBank);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }

            if (_dbtask.znllString(_print.getstatusprinting("Customer reamins")) == "1")
            {


                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Customers remaining Amount");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Customers remaining Amount";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(cusRemaing);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;

            }


            if (_dbtask.znllString(_print.getstatusprinting("Supplier reamins")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Supplier remaining Amount");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Supplier remaining Amount";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(supRemaing);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }
            if (_dbtask.znllString(_print.getstatusprinting("cash&bankAMT")) == "1")
            {

                Count = GridMain.Rows.Add(1);
                GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Cash + Bank");
                GridMain.Rows[Count].Cells["clnnoteE"].Value = "Cash + Bank";
                GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znlldoubletoobject(totBank) + CommonClass._Dbtask.znlldoubletoobject(totcasbalance);
                GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                GridMain.Rows[Count].Cells["clnnote"].Tag = 0;
            }


           // GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._GenLedger.
        }
        
        public void Salescount()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            //GridMain.Columns.Add("clnitemname", "Name");
            //GridMain.Columns["clnitemname"].Width = 200;

            //GridMain.Columns.Add("clnqty", "Amount");
            //CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 80);

            //GridMain.Columns.Add("clnrate", "Rate");
            //CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnrate", 100);

            //GridMain.Columns.Add("clntax", "Tax");
            //CommonClass._Clreport.Qtycolumnsettings(GridMain, "clntax", 100);

            //GridMain.Columns.Add("clnamount", "Amount");
            //CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 100);

            //GridMain.Columns.Add("clnspace", "");
            //GridMain.Columns["clnspace"].Width = 50;
            
            GridMain.Columns.Add("clnnote", "NOTE");
            GridMain.Columns["clnnote"].Width = 250;

            GridMain.Columns.Add("clnamount2", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount2", 100);

            double TQty = 0;
            double TRate = 0;
            double Ttax = 0;
            double TAmount = 0;

            //string Bcode;
            double Qty;
            double Rate;
            double Amount;
            double TaxAmount = new double();

            string TotalCardSaleTax;
            string TotalCashSaleTax;
            string TaxPerc;
            string TotalCardSale;
            string TotalCashSale;
            string TotalCreditSale;

            double totcashSR = 0;
            double crtSR = 0;
            double CARDsr = 0;
            double RealSR = 0;


            string TotalPurchase;
            string TotalPurchaseReturn;
            string TotaSale;
            string TotalPayment;
            string TotalReceipt;

            string NetDBamt;
            string NetCramt;
            string NetBalance;

          // DtFrom.Value= Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 07:00:00"));
          //DtTo.Value= Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 02:00:00"));
          //  DtTo.Value=  DtTo.Value.AddDays(1);
            //  GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            //GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnqty"].Value =CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            //GridMain.Rows[GridMain.Rows.Count - 1].Cells["clntax"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Ttax);

            //GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnamount"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);
            //frstdto =Convert.ToDateTime( CommonClass._slctsalerprt.DtTo.ToString());
            //Dtto = CommonClass._slctsalerprt.DtTo.ToString();
            //Dtto = Dtto.AddDays(-1);
            string Wheredate;
            Wheredate = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            int Count;
            Count = GridMain.Rows.Add(1);
            
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase");
            TotalPurchase = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate)).ToString("0.00");
            
            GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchase;

           

            //GridMain.Rows[2].Cells["clnnote"].Value = "Total Sales";
            //GridMain.Rows[2].Cells["clnamount2"].Value = TAmount.ToString("0.00");


            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

            wheredate2 = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";
            wheredate3 = " Vdate  between '" + DtFrom.Value.ToString("MM/dd/yyyy  hh:mm tt") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy hh:mm tt") + " '";

          
            //****=====
            TotalCardSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
           " select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=2 and issuetype!='sv' and ISSUETYPE='SI')");

            TotalPurchaseReturn = (CommonClass._Businessissue.TottalAmountOfType("Amt", "PR", " and " + Wheredate)).ToString("0.00");

            /*********Purchase return**********/
            Count = GridMain.Rows.Add(1);

            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Return");

            GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPurchaseReturn;
            /**********************/

            //TotalCashSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            //" select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=0)");

            TotalCashSale = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='si' and mpayment='0' and issuetype!='sv' and " + Wheredate + "");
            string TOTCRDTSALES = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='si' and mpayment='1' and issuetype!='sv' and " + Wheredate + "");

            double realtotsale = CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) +CommonClass._Dbtask.znlldoubletoobject( TOTCRDTSALES) ;

            //SR
            totcashSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='0' and recpttype!='sv' and " + wheredate2 + ""));
            crtSR = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='1' and recpttype!='sv' and " + wheredate2 + ""));
            CARDsr = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tbltransactionreceipt  where recpttype='sr' and mpayment='2' and recpttype!='sv' and " + wheredate2 + ""));
            RealSR = CARDsr + totcashSR;


           


            /****Tax Amount**************/
            TaxPerc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select Vat from tblitemmaster")).ToString();


            double serviceamt = 0;
            double srvcsdisc = 0;
           serviceamt = CommonClass._Dbtask.znullDouble( CommonClass._Dbtask.ExecuteScalar("select sum(amt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));
           srvcsdisc = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar("select sum(discamt) from tblbusinessissue where issuetype='sv' and " + Wheredate + ""));


            double discc = CommonClass._Dbtask.znlldoubletoobject(CommonClass._Dbtask.ExecuteScalar("  select sum(discamt) from tblbusinessissue where " + Wheredate + ""));

            TotaSale = CommonClass._Dbtask.ExecuteScalar("select sum ( amt) from tblbusinessissue  where issuetype='si' and issuetype!='sv' and " + Wheredate + "");
            
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sales Tax");

            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Businessissue.TottalAmountOfType("Taxamt", "SI"," and"+ Wheredate ).ToString(); ;
            double taxsalessss = CommonClass._Dbtask.znullDouble(CommonClass._Businessissue.TottalAmountOfType("Taxamt", "SI", " and" + Wheredate).ToString()); ;


            //GridMain.Rows[1].Cells["clnamount2"].Value = taxsalessss.ToString("0.00"); ;
      
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Purchase Tax");
            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + wheredate2).ToString("0.00"); ;

         
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("(Sales Tax-Purchase Tax)");
            GridMain.Rows[Count].Cells["clnamount2"].Value = (taxsalessss - CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + wheredate2)).ToString("0.00"); ;

           double TttotaSale = CommonClass._Dbtask.znullDouble(TotaSale) - discc;
            //GridMain.Rows[10].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Discount");
            //GridMain.Rows[10].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalDiscount);

           Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sale");
            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(realtotsale).ToString();
            
            /*******Sales return************/
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Return");
            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(RealSR).ToString();
            /****************************************/

            TotalPayment = (CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + wheredate3)).ToString("0.00");
            TotalReceipt =( CommonClass._GenLedger.TottalAmountOfType("dbamt", "R", " and " + wheredate3)).ToString("0.00");
            NetDBamt = (CommonClass._Dbtask.znullDouble(TotalPurchaseReturn)+CommonClass._Dbtask.znullDouble(TotalReceipt) + realtotsale + serviceamt).ToString("0.00");
            NetCramt = (CommonClass._Dbtask.znullDouble(TotalPayment) + RealSR + CommonClass._Dbtask.znullDouble(TotalPurchase)).ToString("0.00");
            //NetCramt = Convert.ToString(CommonClass._Dbtask.znullDouble(NetCramt) + RealSR).ToString(); ;
            NetBalance = (CommonClass._Dbtask.znullDouble(NetDBamt) - CommonClass._Dbtask.znullDouble(NetCramt)).ToString("0.00");

            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Payment");
            GridMain.Rows[Count].Cells["clnamount2"].Value = TotalPayment;

          
           // Count = GridMain.Rows.Add(1);
            //Ds = CommonClass._Clreport.LedgerSummuryBaseOnGroup(" where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where agroupid in (15) or aunder in (25)) " + " and  tblgeneralledger.vDate between  '" + DtFrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy 23:59:59") + "'");
            //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            //{
            //    string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
            //    string StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
            //    double DbAmount = CommonClass._Dbtask.znullDouble(Ds.Tables[0].Rows[i]["amount"].ToString());

            //    if (DbAmount != 0)
            //    {
            //        Count = GridMain.Rows.Add(1);

            //        GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
            //        GridMain.Rows[Count].Cells[1].Value = DbAmount;
            //        GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            //        GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
            //    }
            //}
              Ds = CommonClass._Dbtask.ExecuteQuery("select * from tblgeneralledger  where vtype in ('P') and cramt=0 and vdate " +
                        " between '" + DtFrom.Value.ToString("MM/dd/yyyy") + " 00:00:00' and '" + DtTo.Value.ToString("MM/dd/yyyy") + " 23:59:59'" +
                    " and ledcode in(select lid  from tblaccountledger where agroupid not in(24,25))");

              for (int i = -0; i < Ds.Tables[0].Rows.Count; i++)
              {
                  string AccountID = Ds.Tables[0].Rows[i]["ledcode"].ToString();
                  string StrPurticulars = CommonClass._Ledger.GetspecifField("lname", AccountID);
                  double DbAmount = CommonClass._Dbtask.znullDouble(Ds.Tables[0].Rows[i]["dbamt"].ToString());


                  Count = GridMain.Rows.Add(1);

                  GridMain.Rows[Count].Cells[0].Value = StrPurticulars;
                  GridMain.Rows[Count].Cells[1].Value = DbAmount;
                  GridMain.Rows[Count].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
                  GridMain.Rows[Count].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
              }
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Receipt");
            GridMain.Rows[Count].Cells["clnamount2"].Value = TotalReceipt;

            //GridMain.Rows[7].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Net Balance");
            //GridMain.Rows[7].Cells["clnamount2"].Value = NetBalance;
            //Count = GridMain.Rows.Add(1);

            //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Card Sale");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale); //+ CommonClass._Dbtask.znullDouble(TotalCardSale);
            //Count = GridMain.Rows.Add(1);

            //GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
            //GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale); //+ CommonClass._Dbtask.znullDouble(TotalCashSale);

            
           //serviceamt = serviceamt - srvcsdisc; 
            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Services");
            GridMain.Rows[Count].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(serviceamt).ToString(); //+ CommonClass._Dbtask.znullDouble(TotalCashSale);



            Count = GridMain.Rows.Add(1);
            GridMain.Rows[Count].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Balance");
            GridMain.Rows[Count].Cells["clnamount2"].Value = NetBalance;
            

        }


        public void SalescountCategoryWise()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            GridMain.Columns.Add("clnitemname", "Category Name");
            GridMain.Columns["clnitemname"].Width = 200;

            GridMain.Columns.Add("clnqty", "Qty");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 50);



            GridMain.Columns.Add("clntax", "Tax");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clntax", 100);

            GridMain.Columns.Add("clnamount", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 100);

            GridMain.Columns.Add("clnspace", "");
            GridMain.Columns["clnspace"].Width = 50;


            GridMain.Columns.Add("clnnote", "NOTE");
            GridMain.Columns["clnnote"].Width = 150;

            GridMain.Columns.Add("clnamount2", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount2", 100);

            double TQty = 0;
            double TRate = 0;
            double Ttax = 0;
            double TAmount = 0;

            //string Bcode;
            double Qty;
            double CateQty;
            double Rate;
            double Amount;
            double TaxAmount = new double();

            string CatId;
            string CatName;


            Ds = CommonClass._ItemCategory.Showitemcategory("");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                CatId = Ds.Tables[0].Rows[i]["Categoryid"].ToString();
                CatName = Ds.Tables[0].Rows[i]["Category"].ToString();

                string Itemid;
                string Itemname ;
                Ds1 = CommonClass._ItemCategory.ListItemidBaseonCategory("itemid", CatId);
                Amount = 0;
                Qty = 0;
                CateQty = 0;
                TaxAmount = 0;
                for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                {
                    Itemid=Ds1.Tables[0].Rows[k]["itemid"].ToString();

                    Qty = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar(" select isnull(sum(qty),0)  from tblissuedetails where issuecode in(  select issuecode from tblbusinessissue where issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " ' and issuetype in ('SI','POs')) " +
                    " and pcode in ("+Itemid+") and vtype in ('SI','POS')"));


                    if (Qty > 0)
                    {

                        CateQty = CateQty + Qty;
                        Rate = CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "srate"));
                        double Amt;
                        Amt = Qty * Rate;
                        Amount = Amount + (Qty * Rate);

                        if (CommonClass._Itemmaster.SpecificField(Itemid, "incs") == "1")
                        {
                            double tempTaxPerc = 100 + CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT"));
                            double Txt;
                            Txt = Amt * CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")) / tempTaxPerc;
                            TaxAmount = TaxAmount + Txt;
                        }
                        else
                        {
                            double tempTaxPerc = 100;
                            double Txt;
                            Txt = Amt * CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")) / tempTaxPerc;
                            TaxAmount = TaxAmount + Txt;
                        }
                    }
                }
                
                GridMain.Rows.Add();
                GridMain.Rows[i].Cells["clnitemname"].Value = CatName;
                GridMain.Rows[i].Cells["clnqty"].Value = CateQty;
                GridMain.Rows[i].Cells["clntax"].Value = TaxAmount;
                GridMain.Rows[i].Cells["clnamount"].Value = Amount;
                TQty = TQty + CateQty;
                Ttax = Ttax + TaxAmount;
                TAmount = TAmount + Amount;
            }
            GridMain.Rows.Add(1);
           // GridMain.Rows[GridMain.Rows.Count - 1].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnqty"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clntax"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Ttax);

            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnamount"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);

            string Wheredate;
            Wheredate = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";
            string WhereDate2 = " IssueDate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";
            if (GridMain.Rows.Count < 2)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[1].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Purchase");
            GridMain.Rows[1].Cells["clnamount2"].Value = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI+taxamt", " and " + Wheredate)).ToString("0.00");

            if (GridMain.Rows.Count < 3)
            {
                GridMain.Rows.Add(1);
            }
            ////GridMain.Rows[2].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Sales");
            ////GridMain.Rows[2].Cells["clnamount2"].Value = TAmount.ToString("0.00");

            if (GridMain.Rows.Count < 4)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[3].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Sales Tax");
            GridMain.Rows[3].Cells["clnamount2"].Value = Ttax.ToString("0.00"); ;

            if (GridMain.Rows.Count < 5)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[4].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Purchase Tax");
            GridMain.Rows[4].Cells["clnamount2"].Value = CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + Wheredate).ToString("0.00"); ;

            if (GridMain.Rows.Count < 6)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[5].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("(Sales Tax-Purchase Tax)"); ;
            GridMain.Rows[5].Cells["clnamount2"].Value = (Ttax - CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + Wheredate)).ToString("0.00"); ;

            if (GridMain.Rows.Count < 8)
            {
                GridMain.Rows.Add(1);
                GridMain.Rows.Add(1);
                GridMain.Rows.Add(1);
            }
           
            //GridMain.Rows[7].Cells["clnnote"].Value = "Total Purchase";
            //GridMain.Rows[7].Cells["clnamount2"].Value = CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI", " and " + Wheredate);

            string TotalCardSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + WhereDate2 + " and Mpayment=2)");
            if (GridMain.Rows.Count < 9)
            {
                GridMain.Rows.Add(1);
            }

            GridMain.Rows[8].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Card Sales");
            GridMain.Rows[8].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TotalCardSale));

           string TotalCashSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + WhereDate2 + " and Mpayment=0)");

            if (GridMain.Rows.Count < 10)
            {
                GridMain.Rows.Add(1);
            }

            GridMain.Rows[9].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Cash Sale");
            GridMain.Rows[9].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TotalCashSale));


            string TotalDiscount = CommonClass._Dbtask.ExecuteScalar("select sum(DiscAmt) from TblBusinessIssue where " + WhereDate2);

           if (GridMain.Rows.Count < 12)
           {
               GridMain.Rows.Add(1);
           }

           GridMain.Rows[10].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Discount");
           GridMain.Rows[10].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TotalDiscount));

           if (GridMain.Rows.Count < 13)
           {
               GridMain.Rows.Add(1);
           }
            GridMain.Rows[11].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Sales");
            //GridMain.Rows[8].Cells["clnamount2"].Value = TAmount.ToString("0.00");
            GridMain.Rows[11].Cells["clnamount2"].Value = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TotalCashSale) + CommonClass._Dbtask.znlldoubletoobject(TotalCardSale) - CommonClass._Dbtask.znlldoubletoobject(TotalDiscount));

            Wheredate = " vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";

            if (GridMain.Rows.Count < 14)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[12].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Payment");
            GridMain.Rows[12].Cells["clnamount2"].Value = (CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + Wheredate)).ToString("0.00");

            if (GridMain.Rows.Count < 15)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[13].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Sales-Payment");
            GridMain.Rows[13].Cells["clnamount2"].Value = (TAmount - CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + Wheredate)).ToString("0.00"); ;

        }

        public void SalescountCategory()
        {
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            GridMain.Columns.Add("clncategory", "Category Name");
            GridMain.Columns["clncategory"].Width = 200;

            GridMain.Columns.Add("clnitemname", "Item Name");
            GridMain.Columns["clnitemname"].Width = 200;

            GridMain.Columns.Add("clnqty", "Qty");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnqty", 50);

            GridMain.Columns.Add("clnrate", "Rate");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "Clnrate", 80);

            GridMain.Columns.Add("clntax", "Tax");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clntax", 100);

            GridMain.Columns.Add("clnamount", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount", 100);

            GridMain.Columns.Add("clnspace", "");
            GridMain.Columns["clnspace"].Width = 50;


            GridMain.Columns.Add("clnnote", "NOTE");
            GridMain.Columns["clnnote"].Width = 150;

            GridMain.Columns.Add("clnamount2", "Amount");
            CommonClass._Clreport.Qtycolumnsettings(GridMain, "clnamount2", 100);

            double TQty = 0;
            double TRate = 0;
            double Ttax = 0;
            double TAmount = 0;

            //string Bcode;
            double Qty;
            double CateQty;
            double Rate;
            double Amount;
            double TaxAmount = new double();

            string CatId;
            string CatName;


            Ds = CommonClass._ItemCategory.Showitemcategory("");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                CatId = Ds.Tables[0].Rows[i]["Categoryid"].ToString();
                CatName = Ds.Tables[0].Rows[i]["Category"].ToString();

                string Itemid;
                string Itemname;
                Ds1 = CommonClass._ItemCategory.ListItemidBaseonCategory("itemid", CatId);
                Amount = 0;
                Qty = 0;
                CateQty = 0;
                TaxAmount = 0;

                RowsCount= GridMain.Rows.Add();
                GridMain.Rows[RowsCount].Cells["clncategory"].Value = CatName;
                for (int k = 0; k < Ds1.Tables[0].Rows.Count; k++)
                {
                    Itemid = Ds1.Tables[0].Rows[k]["itemid"].ToString();

                    Qty = CommonClass._Dbtask.znullDouble(CommonClass._Dbtask.ExecuteScalar(" select isnull(sum(qty),0)  from tblissuedetails where issuecode in(  select issuecode from tblbusinessissue where issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " ' and issuetype in ('SI','POs')) " +
                    " and pcode in (" + Itemid + ") and vtype in ('SI','POS')"));


                    if (Qty > 0)
                    {

                        CateQty = CateQty + Qty;
                        Rate = CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "srate"));
                        double Amt;
                        Amt = Qty * Rate;
                        double Txt;
                        Amount = Amount + (Qty * Rate);

                        if (CommonClass._Itemmaster.SpecificField(Itemid, "incs") == "1")
                        {
                            double tempTaxPerc = 100 + CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT"));
                           
                            Txt = Amt * CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")) / tempTaxPerc;
                            TaxAmount = TaxAmount + Txt;
                        }
                        else
                        {
                            double tempTaxPerc = 100;
                           
                            Txt = Amt * CommonClass._Dbtask.znullDouble(CommonClass._Itemmaster.SpecificField(Itemid, "VAT")) / tempTaxPerc;
                            TaxAmount = TaxAmount + Txt;
                            Amt = Amt + Txt;
                            Amount = Amount + Txt;
                        }

                       RowsCount= GridMain.Rows.Add();
                       GridMain.Rows[RowsCount].Cells["clncategory"].Tag = CatName;
                       GridMain.Rows[RowsCount].Cells["clnitemname"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "itemname");
                       GridMain.Rows[RowsCount].Cells["clnqty"].Value = Qty;
                       GridMain.Rows[RowsCount].Cells["clnrate"].Value = Rate;
                       GridMain.Rows[RowsCount].Cells["clntax"].Value = Txt;
                       GridMain.Rows[RowsCount].Cells["clnamount"].Value = Amt;
                    }
                }

                RowsCount = GridMain.Rows.Add();
                GridMain.Rows[RowsCount].Cells["clnqty"].Value = CateQty;
                GridMain.Rows[RowsCount].Cells["clntax"].Value = TaxAmount;
                GridMain.Rows[RowsCount].Cells["clnamount"].Value = Amount;
               // GridMain.Rows[RowsCount].DefaultCellStyle.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
             
                TQty = TQty + CateQty;
                Ttax = Ttax + TaxAmount;
                TAmount = TAmount + Amount;
            }
            GridMain.Rows.Add(1);
            CommonClass._Clreport.TottalRowStyle(GridMain, GridMain.Rows.Count - 1);
            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnqty"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clntax"].Value = CommonClass._Dbtask.SetintoDecimalpoint(Ttax);

            GridMain.Rows[GridMain.Rows.Count - 1].Cells["clnamount"].Value = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);

            string Wheredate;
            Wheredate = " recptdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";

            if (GridMain.Rows.Count < 2)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[1].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Purchase");
            GridMain.Rows[1].Cells["clnamount2"].Value = (CommonClass._Transactionreceipt.TottalAmountOfType("Amt", "PI+taxamt", " and " + Wheredate)).ToString("0.00");

            if (GridMain.Rows.Count < 3)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[2].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Sales");
            GridMain.Rows[2].Cells["clnamount2"].Value = TAmount.ToString("0.00");

            if (GridMain.Rows.Count < 4)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[3].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Sales Tax");
            GridMain.Rows[3].Cells["clnamount2"].Value = Ttax.ToString("0.00"); ;

            if (GridMain.Rows.Count < 5)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[4].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Purchase Tax");
            GridMain.Rows[4].Cells["clnamount2"].Value = CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + Wheredate).ToString("0.00"); ;

            if (GridMain.Rows.Count < 6)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[5].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "(Sales Tax-Purchase Tax)");
            GridMain.Rows[5].Cells["clnamount2"].Value = (Ttax - CommonClass._Transactionreceipt.TottalAmountOfType("Taxamt", "PI", " and " + Wheredate)).ToString("0.00"); ;

            if (GridMain.Rows.Count < 9)
            {
                GridMain.Rows.Add(1);
                GridMain.Rows.Add(1);
                GridMain.Rows.Add(1);
            }

            /*************************************************************/

            string TotalCardSaleTax;
            string TotalCashSaleTax;
            string TaxPerc;


            string TotalCardSale;
            string TotalCashSale;
            string TotalDiscount;
            string TotaSale;
            Wheredate = "  issuedate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";


            TotalCardSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=2)");


            TotalCashSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=0)");

            /****Tax Amount**************/
            TaxPerc =CommonClass._Dbtask.znullDouble( CommonClass._Dbtask.ExecuteScalar("select Vat from tblitemmaster")).ToString();
            TotalCardSaleTax = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate)*" + TaxPerc + "/100 from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=2)");


            TotalCashSaleTax = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate)*" + TaxPerc + "/100 from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " and Mpayment=0)");
            /****************************/

            TotalDiscount = TotalDiscount = CommonClass._Dbtask.ExecuteScalar("select sum(DiscAmt) from TblBusinessIssue where " + Wheredate);

            TotaSale = CommonClass._Dbtask.ExecuteScalar("select sum(qty*rate) from tblissuedetails where issuecode in( " +
            " select issuecode from tblbusinessissue where" + Wheredate + " )");

            TotaSale = CommonClass._Dbtask.SetintoDecimalpoint(CommonClass._Dbtask.znlldoubletoobject(TotaSale) - CommonClass._Dbtask.znlldoubletoobject(TotalDiscount));
            /***************************************************/
           
            


            GridMain.Rows[8].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Card Sales");
            GridMain.Rows[8].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCardSale) + CommonClass._Dbtask.znullDouble(TotalCardSaleTax);

            Wheredate = " vdate between '" + DtFrom.Value.ToString("MM/dd/yyyy  HH:mm:ss") + "' and '" + DtTo.Value.ToString("MM/dd/yyyy HH:mm:ss") + " '";


            if (GridMain.Rows.Count < 10)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[9].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Cash Sale");
            GridMain.Rows[9].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalCashSale) + CommonClass._Dbtask.znullDouble(TotalCashSaleTax);


            if (GridMain.Rows.Count < 11)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[10].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Discount");
            GridMain.Rows[10].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotalDiscount);

            if (GridMain.Rows.Count < 12)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[11].Cells["clnnote"].Value = CommonClass._Language.GetArabicString( "Total Sale");
            GridMain.Rows[11].Cells["clnamount2"].Value = CommonClass._Dbtask.znullDouble(TotaSale) + Ttax;

            if (GridMain.Rows.Count < 14)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[12].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Total Payment");
            GridMain.Rows[12].Cells["clnamount2"].Value = (CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + Wheredate)).ToString("0.00");

            if (GridMain.Rows.Count < 15)
            {
                GridMain.Rows.Add(1);
            }
            GridMain.Rows[13].Cells["clnnote"].Value = CommonClass._Language.GetArabicString("Sales-Payment");
            GridMain.Rows[13].Cells["clnamount2"].Value = (TAmount - CommonClass._GenLedger.TottalAmountOfType("cramt", "P", " and " + Wheredate)).ToString("0.00"); ;

        }

        public void Printsalecount()
        {

//thermal

            string Strheading = "" + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
           
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");
           
            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;

            Slno = CommonClass._Language.GetArabicString("Sl");
            Pname = CommonClass._Language.GetArabicString("Product Name");
            TsQty = CommonClass._Language.GetArabicString("Qty");
            TsRate = CommonClass._Language.GetArabicString("Amount");
            TAmountstr = CommonClass._Language.GetArabicString("Amount");

            
              //  RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + TAmountstr + TsRate + TsQty + "  "+Pname + "\n" + LineHeading + "";
                RichTextBox1.Text = "\n\n" + LineHeading + "";

           
            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
          //  RowValidationsale();
            
            

           
          
            

            


            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   "\n" + LineFooter+"\n\n";

            RichTextBox1.Text = RichTextBox1.Text + "\n\n"  + CommonClass._Dbtask.znllString(GridMain.Rows[0].Cells["clnamount2"].Value) +": " +"Total Purchase\n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[1].Cells["clnamount2"].Value) + ": " + "Total Sales Tax  \n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[2].Cells["clnamount2"].Value) + ": " + "Total purchase Tax  \n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[3].Cells["clnamount2"].Value) + ": " + "Tax Net  ";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[4].Cells["clnamount2"].Value) + ": " + "Total Sales  ";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[5].Cells["clnamount2"].Value) + ": " + "Total Payment";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[6].Cells["clnamount2"].Value) + ": " + "Total Receipt";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[7].Cells["clnamount2"].Value) + ": " + "Nett";
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;

            //thermal


            _ThermalThermal.FormType = "Salesdaybookcount";
            _ThermalThermal.DateStr = DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
            _ThermalThermal.TimeStr = "Time: " + DtFrom.Value.ToString("hh:mm:ss") + " To " + DtTo.Value.ToString("hh:mm:ss");
            _ThermalThermal.PrintInvoice(GridMain);




            //_Sales.SelectedPrinter = comPrint.Text;
            //_Sales.ReportPrint = "Report";
            //_Sales.vouchertypewholesalesother2();
            
        }

        public void PrintsaleCategory()
        {


           
            string Strheading = "" + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");

            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Name".PadRight(15, ' ');
            
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;

            Slno = CommonClass._Language.GetArabicString("Sl");
            Pname = CommonClass._Language.GetArabicString("Name");
            //TsQty = CommonClass._Language.GetArabicString("Qty");
            TsRate = CommonClass._Language.GetArabicString("Amount");
            TAmountstr = CommonClass._Language.GetArabicString("Amount");


            RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + Slno + TAmountstr + TsRate + "  " + Pname + "\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;

            double TQtyCate = 0;
            double TAmountCate = 0;

            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidationsale();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {


                       
                        Pname = CommonClass._Dbtask.znllString(GridMain.Rows[i].Cells["clnitemname"].Value);
                        Pname = Pname.PadRight(19, ' ');
                        if (Pname.Length > 19)
                            Pname = Pname.Substring(0, 19);


                        double sQty = Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
                        TsQty = CommonClass._Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value);
                        TsRate = CommonClass._Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');

                        double sAmount = Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value);
                        TsAmount = CommonClass._Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(8, ' ');

                        TQtyCate = TQtyCate + sQty;
                        TAmountCate = TAmountCate + sAmount;

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" +
                             Pname + TsQty + TsRate + TsAmount;

                    }
                    else if (CommonClass._Dbtask.znllString(GridMain.Rows[i].Cells[0].Value) != "" || TQtyCate>0)
                    {

                        if (TQtyCate > 0 && TAmountCate > 0)
                        {
                            RichTextBox1.Text = RichTextBox1.Text + "\n" + LineAbowAmount +
                            "\n" + TQtyCate.ToString("0.00").PadLeft(24, ' ') + TAmountCate.ToString("0.00").PadLeft(16, ' ') + "\n" + LineFooter;
                        }
                        else
                        {

                            Category = CommonClass._Dbtask.znllString(GridMain.Rows[i].Cells["clncategory"].Value);
                            RichTextBox1.Text = RichTextBox1.Text + "\n\n" + Category + "\n"
                               + "________________________" + "\n";
                        }
                        TQtyCate = 0;
                        TAmountCate = 0;
                    }
                }
            }
            TTQty = CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(24, ' ');

            TTAmount = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(16, ' ');


            string StrBillClerck = "Customer Sign               BILL CLERCK";
            // currentbalance = 0;
            //OldBalance = 0;
            string Visitagain;

            //string totsaletaxx = CommonClass._Language.GetArabicString("Total Sales Tax ");
            string totcardsale = CommonClass._Language.GetArabicString("Total Card Sale");
            string totcashasale = CommonClass._Language.GetArabicString("Total Cash Sale");
            string totdiscnt = CommonClass._Language.GetArabicString("Total Discount");
            string totsaleamt = CommonClass._Language.GetArabicString("Total Sales Amount");
            string totPayment = CommonClass._Language.GetArabicString("Total Payment");
            string totsalepayment = CommonClass._Language.GetArabicString("Sales-Payment");  

            RichTextBox1.Text = RichTextBox1.Text + "\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter +

                  "\n" +
                  //"\n  "+     totsaletaxx    + CommonClass._Dbtask.znllString(GridMain.Rows[3].Cells["clnamount2"].Value) +
                  "\n  "+      totcardsale    +"   "+ CommonClass._Dbtask.znllString(GridMain.Rows[8].Cells["clnamount2"].Value) +
                  "\n  " + totcashasale + "   " + CommonClass._Dbtask.znllString(GridMain.Rows[9].Cells["clnamount2"].Value) +
                  "\n  " + totdiscnt + "   " + CommonClass._Dbtask.znllString(GridMain.Rows[10].Cells["clnamount2"].Value) +
                  "\n   " + totsaleamt + "   " + CommonClass._Dbtask.znllString(GridMain.Rows[11].Cells["clnamount2"].Value)+
                             "\n  " + totPayment + "   " + CommonClass._Dbtask.znllString(GridMain.Rows[12].Cells["clnamount2"].Value) +
                  "\n   " + totsalepayment + "   " + CommonClass._Dbtask.znllString(GridMain.Rows[13].Cells["clnamount2"].Value);


            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;
            //_Sales.SelectedPrinter = comPrint.Text;
            _Sales.ReportPrint = "Report";
            _Sales.vouchertypewholesalesother2();

        }
        
        public void PrintsalecountCategory()
        {



            string Strheading = "" + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");

            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;



            RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + Slno + Pname + TsQty + TsRate + TAmountstr + "\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidationsale();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = (i + 1).ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = GridMain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(15, ' ');
                        if (Pname.Length > 15)
                            Pname = Pname.Substring(0, 15);
                        double sQty = Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
                        TsQty = CommonClass._Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadLeft(5, ' ');

                        double sRate = Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value);
                        TsRate = CommonClass._Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');

                        double sAmount = Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value);
                        TsAmount = CommonClass._Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadLeft(8, ' ');

                        TQty = TQty + sQty;
                        TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsQty + TsRate + TsAmount;

                    }
                }
            }
            TTQty = CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadLeft(24, ' ');

            TTAmount = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadLeft(16, ' ');


            string StrBillClerck = "Customer Sign               BILL CLERCK";
            // currentbalance = 0;
            //OldBalance = 0;
            string Visitagain;



            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter;


            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;
            //_Sales.SelectedPrinter = comPrint.Text;
            _Sales.ReportPrint = "Report";
            _Sales.vouchertypewholesalesother2();

        }


        public void Printsalecountcategory()
        {



            string Strheading = "" + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");

            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Category Name".PadRight(19, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Qty".PadLeft(2, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(10, ' ');
            string TTQty;
            string TTAmount;

            Slno = CommonClass._Language.GetArabicString("Sl");
            Pname = CommonClass._Language.GetArabicString("Category Name");
            TsRate = CommonClass._Language.GetArabicString("Qty");
            TAmountstr = CommonClass._Language.GetArabicString("Amount");




            RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + TAmountstr +"   " +TsQty + "        " + Pname + "\n" + LineHeading + "";
           // RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + Pname + TsRate + TAmountstr + "  " + Slno + "\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidationsale();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = (i + 1).ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = GridMain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(20, ' ');
                        //if (Pname.Length > 20)
                        //    Pname = Pname.Substring(0, 20);
                        double sQty = Convert.ToDouble(GridMain.Rows[i].Cells["clnqty"].Value);
                        TsQty = CommonClass._Dbtask.SetintoDecimalpointStock(sQty);
                        TsQty = TsQty.PadRight(5, ' ');

                       

                        double sAmount = Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value);
                        TsAmount = CommonClass._Dbtask.SetintoDecimalpoint(sAmount);
                        TsAmount = TsAmount.PadRight(9, ' ');

                        TQty = TQty + sQty;
                        //TRate = TRate + sRate;
                        TAmount = TAmount + sAmount;

                        string TSamount = TAmount.ToString();

                        RichTextBox1.Text = RichTextBox1.Text + "\n"   ;
                        RichTextBox1.Text = RichTextBox1.Text + TsAmount + TsQty + Pname;

                    }
                }
            }
            TTQty = CommonClass._Dbtask.SetintoDecimalpoint(TQty);
            TTQty = TTQty.PadRight(14, ' ');

            TTAmount = CommonClass._Dbtask.SetintoDecimalpoint(TAmount);
            TTAmount = TTAmount.PadRight(9, ' ');


            string StrBillClerck = "Customer Sign               BILL CLERCK";
            // currentbalance = 0;
            //OldBalance = 0;
            string Visitagain;

            string totsaletaxx = CommonClass._Language.GetArabicString("Total Sales Tax ");
            string totcardsale = CommonClass._Language.GetArabicString("Total Card Sale");
            string totcashasale = CommonClass._Language.GetArabicString("Total Cash Sale");
            string totdiscnt = CommonClass._Language.GetArabicString("Total Discount");
            string totsaleamt = CommonClass._Language.GetArabicString("Total Sales Amount");  

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" + TTQty + TTAmount + "\n" + LineFooter +


                   "\n" +
                 "\n  " + totsaletaxx + CommonClass._Dbtask.znllString(GridMain.Rows[3].Cells["clnamount2"].Value) +
                 "\n  " + totcardsale + CommonClass._Dbtask.znllString(GridMain.Rows[8].Cells["clnamount2"].Value) +
                 "\n  " + totcashasale + CommonClass._Dbtask.znllString(GridMain.Rows[9].Cells["clnamount2"].Value) +
                 "\n  " + totdiscnt + CommonClass._Dbtask.znllString(GridMain.Rows[10].Cells["clnamount2"].Value) +
                 "\n   " + totsaleamt + CommonClass._Dbtask.znllString(GridMain.Rows[11].Cells["clnamount2"].Value);



            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;
            //_Sales.SelectedPrinter = comPrint.Text;
            _Sales.ReportPrint = "Report";
            _Sales.vouchertypewholesalesother2();

        }

        public void Printitemlist()
        {



            string Strheading = "Item List";
            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;



            RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + Slno + Pname + TsRate + "\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            RowValidationitemlist();
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Tag != null)
                {
                    if (GridMain.Rows[i].Tag.ToString() == "1")
                    {

                        Slno = (i + 1).ToString();
                        Slno = Slno.PadRight(4, ' ');

                        Pname = GridMain.Rows[i].Cells["clnitemname"].Value.ToString();
                        Pname = Pname.PadRight(15, ' ');
                        if (Pname.Length > 20)
                            Pname = Pname.Substring(0, 20);
                      

                        double sRate = Convert.ToDouble(GridMain.Rows[i].Cells["clnrate"].Value);
                        TsRate = CommonClass._Dbtask.SetintoDecimalpoint(sRate);
                        TsRate = TsRate.PadLeft(8, ' ');


                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Slno + Pname + TsRate ;

                    }
                }
            }
           


            string StrBillClerck = "Customer Sign               BILL CLERCK";
            // currentbalance = 0;
            //OldBalance = 0;
            string Visitagain;



            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   LineAbowAmount +
                  "\n" +  "\n" + LineFooter;


            frmsalesinvoice _Sales = new frmsalesinvoice();


            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;
            _Sales.XX = 6;
            //_Sales.SelectedPrinter = comPrint.Text;
            _Sales.vouchertypewholesalesother();

        }


        public void RowValidationsale()
        {
            try
            {
                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    if (GridMain.Rows[i].Cells["clnitemname"].Value == null || Convert.ToDouble(GridMain.Rows[i].Cells["clnamount"].Value) == Convert.ToDouble(0))
                    {
                        GridMain.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridMain.Rows[i].Tag = 1;
                        GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }

        public void RowValidationitemlist()
        {
            try
            {
                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    if (GridMain.Rows[i].Cells["clnitemname"].Value == null)
                    {
                        GridMain.Rows[i].Tag = -1;
                        // gridmain.Rows[rowindex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    }
                    else
                    {
                        GridMain.Rows[i].Tag = 1;
                        GridMain.Rows[i].DefaultCellStyle.BackColor = default(Color);
                    }
                }

            }
            catch
            {
            }
        }
        public void Clear()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.PanelBasedConversion(Pnltop);
            }
        }
        public void GridHeaderConverter()
        {
            CommonClass._Language.GridHeaderConversion(GridMain);
        }
        public void ExporttoexcelImport()
        {
            int cols;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save File";
            theDialog.Filter = "Excel File|*.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string Filepath = theDialog.FileName;

                //open file
                StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                //determine the number of columns and write columns to file
                cols = GridMain.Columns.Count;
                wr.Write("Company Name\n\n\n");


                // wr.Write(LblHeading.Text + "\n\n");

                for (int i = 0; i < cols; i++)
                {
                    wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                }
                wr.WriteLine();
                // write rows to excel file
                for (int i = 0; i < (GridMain.Rows.Count); i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (GridMain.Rows[i].Cells[j].Value != null)
                        {
                            string StrValue;
                            StrValue = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", " ");
                            StrValue = StrValue.Replace("\n", " ");
                            wr.Write(StrValue + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                //close file
                wr.Close();
                System.Diagnostics.Process.Start(Filepath);

                // File.Open(Filepath,FileMode.Open);

            }
        }

        //public void PrintInvoicepreview()
        //{
        //    try
        //    {

        //        if (ChkShowPreview.Checked == true)
        //        {
        //            Frmprintmain _Print = new Frmprintmain();
        //            if (Printerselect == "1")
        //                _Print.Pselect = "1";
        //            _Print.Richtext = RichTextBox2.Text;
        //            _Print.ShowDialog();
        //        }

        //    }
        //    catch
        //    {
        //    }

        //}


        private void Frmreport2_Load(object sender, EventArgs e)
        {

            DtFrom.Value = CommonClass._Gen.FuFromdateReportdef();
            DtTo.Value = CommonClass._Gen.FuTodateReportdef();
            //DtFrom.Value = DTFrom;
            //DtTo.Value = Dtto;
            RefreshFu();
            Clear();
            CommonClass._Nextg.FormIcon(this);
            CommonClass._Gen.FillActivePrinter(comprint);
            //DtFrom.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 07:00:00"));
            //DtTo.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy 02:00:00"));
            //DtTo.Value = DtTo.Value.AddDays(1);
        }

        public void RefreshFu()
         {
            if (Reporttype == "Salesdaybookcount")
                Salescount();

            if (Reporttype == "Summury Report")
                if (onlinecheck == true)
                {
                    SummuryReportAzure();
                }
                else
                {
                    SummuryReport();
                }


            if (Reporttype == "TaxSummery")
                taxsummeryreport();

            if (Reporttype == "TaxSummeryTWO")
                TaxsummeryTWOreport();

            if (Reporttype == "Salesdaybookcount Category")
                SalescountCategory();


            if (Reporttype == "Itemlist")
                ItemList();


            if (Reporttype == "stocktranferdetailsall")
                StocktransferReporty();


            GridHeaderConverter();
        }
        public void PrintToPdf()
        {


            //PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            ////pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            //PrintDialog Pdialog = new PrintDialog();

            //if (Pdialog.ShowDialog() == DialogResult.OK)
            //{
            //    pd.PrinterSettings.PrinterName = Pdialog.PrinterSettings.PrinterName;
            //    pd.Print();
            //}




            _ThermalThermal.FormType = "Summury ReportA4";
            _ThermalThermal.DateStr = "Date: " + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
            _ThermalThermal.TimeStr = "Time: " + DtFrom.Value.ToString("hh:mm:ss") + " To " + DtTo.Value.ToString("hh:mm:ss");
            _ThermalThermal.PSelect = comprint.Text;
            
                _ThermalThermal.Preview = false;
          


            _ThermalThermal.PrintInvoice(GridMain);
           
            //}
        }public int LinePerPage = 39;
        public int TempCount = 0;

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int TopMargine = 15;
            int LeftMargine = 30;
            int RightMargine = 15;
            int CurrentY = TopMargine;
            int lineCount = 0;
            int PaperWidth = ev.PageSettings.PaperSize.Width;
            Font Arialnormal = new Font("Arial", 10, FontStyle.Regular);
            Font ArialBold = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);



            Font HeaderFont = new Font(GridMain.RowHeadersDefaultCellStyle.Font.Name, 10, FontStyle.Bold);


            int CurrentX = LeftMargine;

            ev.Graphics.DrawLine(new Pen(BlackBrush), LeftMargine, CurrentY, PaperWidth - LeftMargine, CurrentY);

            CurrentY = CurrentY + 5;

            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                string Field = GridMain.Columns[i].HeaderText.ToString();

                ev.Graphics.DrawString(Field, HeaderFont, BlackBrush, CurrentX, CurrentY);
                CurrentX = CurrentX + GridMain.Columns[i].Width;
            }
            CurrentY = CurrentY + 15;
            ev.Graphics.DrawLine(new Pen(BlackBrush), LeftMargine, CurrentY, PaperWidth - LeftMargine, CurrentY);

            for (int j = TempCount; j < GridMain.Rows.Count; j++)
            {
                CurrentY = CurrentY + 25;
                CurrentX = LeftMargine;

                for (int i = 0; i < GridMain.Columns.Count; i++)
                {
                    string Field = CommonClass._Dbtask.znllString(GridMain.Rows[j].Cells[i].Value);

                    ev.Graphics.DrawString(Field, GridMain.DefaultCellStyle.Font, BlackBrush, CurrentX, CurrentY);
                    CurrentX = CurrentX + GridMain.Columns[i].Width;
                }
                lineCount = lineCount + 1;
                if (lineCount == LinePerPage)
                {
                    ev.HasMorePages = true;
                    TempCount = j + 1;

                }
                if (ev.HasMorePages == false)
                {
                    TempCount = 0;
                }

                if (ev.HasMorePages == true || j == GridMain.Rows.Count - 1)
                {
                    CurrentY = CurrentY + 25;

                    ev.Graphics.DrawLine(new Pen(BlackBrush), LeftMargine, TopMargine, LeftMargine, CurrentY);
                    ev.Graphics.DrawLine(new Pen(BlackBrush), PaperWidth - LeftMargine, TopMargine, PaperWidth - LeftMargine, CurrentY);

                    ev.Graphics.DrawLine(new Pen(BlackBrush), LeftMargine, CurrentY, PaperWidth - LeftMargine, CurrentY);
                    break;
                }

            }
        }
        public void printsummery()
        {
            string Strheading = "" + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");

            string StrTime = "Time : " + DateTime.Now.ToString("hh:mm:ss");

            string LineHeading = "=".PadRight(40, '=');
            string LineAbowAmount = "-".PadRight(40, '-');
            string LineFooter = "=".PadRight(40, '=');
            string Slno = "Sl ".PadRight(4, ' ');
            string Pname = "Product Name".PadRight(15, ' ');
            string TsQty = "Qty".PadLeft(5, ' ');
            string TsRate = "Rate".PadLeft(8, ' ');
            string TsAmount = "Amount".PadLeft(8, ' ');
            string TAmountstr = "Amount".PadLeft(8, ' ');
            string TTQty;
            string TTAmount;

            Slno = CommonClass._Language.GetArabicString("Sl");
            Pname = CommonClass._Language.GetArabicString("Product Name");
            TsQty = CommonClass._Language.GetArabicString("Qty");
            TsRate = CommonClass._Language.GetArabicString("Amount");
            TAmountstr = CommonClass._Language.GetArabicString("Amount");


            //  RichTextBox1.Text = "\n\n" + Strheading + "\n\n" + TAmountstr + TsRate + TsQty + "  "+Pname + "\n" + LineHeading + "";
            RichTextBox1.Text = "\n\n" + LineHeading + "";


            double TRate = 0;
            double TQty = 0;
            double TAmount = 0;
            double Qty = 0;
            double Rate = 0;
            double Amount = 0;
            //  RowValidationsale();

            RichTextBox1.Text = RichTextBox1.Text + "\n\n\n\n" +
                   "\n" + LineFooter + "\n\n";

            RichTextBox1.Text = RichTextBox1.Text + "\n\n" + CommonClass._Dbtask.znllString(GridMain.Rows[0].Cells["clnamount2"].Value) + ": " + "Total Purchase\n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[1].Cells["clnamount2"].Value) + ": " + "Total Sales Tax  \n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[2].Cells["clnamount2"].Value) + ": " + "Total purchase Tax  \n\n";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[3].Cells["clnamount2"].Value) + ": " + "Tax Net  ";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[4].Cells["clnamount2"].Value) + ": " + "Total Sales  ";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[5].Cells["clnamount2"].Value) + ": " + "Total Payment";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[6].Cells["clnamount2"].Value) + ": " + "Total Receipt";
            RichTextBox1.Text = RichTextBox1.Text + CommonClass._Dbtask.znllString(GridMain.Rows[7].Cells["clnamount2"].Value) + ": " + "Nett";
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;

            //thermal
            _ThermalThermal.FormType = "Summury Report";
            _ThermalThermal.DateStr = DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
            _ThermalThermal.TimeStr = "Time: " + DtFrom.Value.ToString("hh:mm:ss") + " To " + DtTo.Value.ToString("hh:mm:ss");
            _ThermalThermal.PrintInvoice(GridMain);


        }
        private void cmdrefresh_Click(object sender, EventArgs e)
        {
            RefreshFu();
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            if (Reporttype == "Salesdaybookcount")
                Printsalecount();
            if (Reporttype == "Itemlist")
                Printitemlist();
            if (Reporttype == "Salesdaybookcount Category Wise")
                Printsalecountcategory();
            if (Reporttype == "Salesdaybookcount Category")
                PrintsaleCategory();

            if (Reporttype == "Summury Report")
                printsummery();
        }

        private void Cmdexporttoexcel_Click(object sender, EventArgs e)
        {
            Exporttoexcel();
        }

        private void Frmreport2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public void Showprinting()
        {
            int DGVOriginalHeight = GridMain.Height;
            GridMain.Height = (GridMain.RowCount * GridMain.RowTemplate.Height) +
                                    GridMain.ColumnHeadersHeight;

            using (Bitmap bitmap = new Bitmap(this.GridMain.Width, this.GridMain.Height))
            {
                GridMain.DrawToBitmap(bitmap, new Rectangle(Point.Empty, this.GridMain.Size));
                string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                bitmap.Save(Path.Combine(DesktopFolder, "datagridview1.png"), ImageFormat.Png);
            }
            GridMain.Height = DGVOriginalHeight;
        }
        private void Cmdexporttopdf_Click(object sender, EventArgs e)
        {
            PrintToPdf();
            //Showprinting();
        }

        public void ExportPdf()
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void GridMain_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void GridMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        public void purchasesalessectn(string heading,string which,string query,string Details)
        {
            Clsselectreport.RType = which;
            Clsselectreport.RQuery = query;
            Clsselectreport.RQueryDetail = Details;
            CommonClass.SRmode = mode;
            Clsselectreport.RDtfrom = Convert.ToDateTime(DtFrom.Value.ToString());
            Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value.ToString());

            CommonClass._Clreport.ShowReport(this, true);  
        }
        public void RandPsectn(string vtypee,string vnoo)
        {


            string ledID = vnoo;
            Clsselectreport.RType = "AccountReport";
            Clsselectreport.RQuery ="select * from tblgeneralledger where ledcode='"+ledID+"'";
            Clsselectreport.RQueryTemp = "select * from tblaccountledger where lid='" + ledID + "'";
            CommonClass.SRmode = mode;
            Clsselectreport.RDtfrom = Convert.ToDateTime(DtFrom.Value.ToString());
            Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value.ToString());


            CommonClass._Clreport.ShowReport(this, true);



           
            
            
            //OLD
            //if (vtypee == "P")
            //{
            //    _Cash.mode = 1;
            //}
            //else
            //{
            //OLD

            //Frmcash _Cash = new Frmcash();
            //   _Cash.Vtype = vtypee;
            //   _Cash.mode = 1;
          
            //_Cash.txtvno.Text = vnoo;

            //Frmcash.Isinotherwindow = true;
            //_Cash.ShowDialog();
        }
        public void ledgersectn(string heading)
        {
            string ledcodeid = "";
            if (heading == "Opening Cash")
            {
                ledcodeid = "1";

            }
            else if (heading == "Opening Bank")
            {
                ledcodeid = "28";
            }
            frmcreateledger _ledger = new frmcreateledger();
            _ledger.Ledid = Convert.ToInt64(ledcodeid);
                        _ledger.Isinotherwindow = true;
                        _ledger.EditMode = true;
                        _ledger.ShowDialog();

        }
        public void celldetailsshows(string heading)
        {
            string which = ""; string Query = ""; string QueryDetail;
           
            if (heading == "Category")
            {
                 string cat = "";
               cat = GridMain.SelectedRows[0].Cells["clnnote"].Tag.ToString();
               which = "Salesdaybook";

               Query = "select * from tblbusinessissue where issuetype='SI'and  TblBusinessIssue. ledcodecr  IN( 2)";
               CommonClass.temp = CommonClass._SelectReport.ShowindatasetForString("select itemid from tblitemmaster where categoryid in (" + cat + ")");
               string Detail = " and pcode in (" + CommonClass.temp + ") and vtype='SI'";




               purchasesalessectn(heading, which, Query, Detail);
            
            
            }

            else if (heading == "Opening Cash" || heading == "Opening Bank")
            {
                ledgersectn(heading);
            }
            else if (heading == "Total Purchase")
            {
                which = "Purchase";
                Query = " having TR.recpttype='PI' and TR.ledcodedr in(3) ";
                purchasesalessectn(heading, which, Query,"");
            }
            else if (heading == "Cash Purchase")
            {
                which = "Purchase";
                Query = " having TR.recpttype='PI' and TR.ledcodedr in(3)  and TR.ledcodecr in(1)";
                purchasesalessectn(heading, which, Query,"");

            }
            else if (heading == "Credit")
            {
                which = "Purchase";
                Query = " having TR.recpttype='PI' and TR.ledcodedr in(3)  and TR.ledcodecr not in(1)";
                purchasesalessectn(heading, which, Query,"");
            }
            else if (heading == "Purchase Return")
            {
                which = "Purchase Return";
                Query = " having tblbusinessissue.issuetype='PR'  and tblissuedetails.vtype='PR' and tblbusinessissue.ledcodecr in(3) ";
                purchasesalessectn(heading, which, Query,"");

            }
            else if (heading == "Total Sales Tax")
            {
                which = "Salestaxsummery";
                mode = "Mode2";
                Query = "select * from tblbusinessissue   where issuetype='SI' and  ledcodecr  IN( 2)";
                purchasesalessectn(heading, which, Query,"");
                
            }
            else if (heading == "Total Purchase Tax")
            {
                which = "Purchasetaxsummery";
               
                purchasesalessectn(heading, which, Query,"");
            }

            else if (heading == "")
            {
                which = "Purchasetaxsummery";

                purchasesalessectn(heading, which, Query, "");
            }

            else if(heading =="Total Sale")
            {

                which = "Sales";
                Query = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2)";
                purchasesalessectn(heading, which, Query,"");
                
            }
            else if (heading == "Wieghtmechine")
            {
                if(CommonClass._Dbtask.znllString(GridMain.SelectedRows[0].Cells["clnamount2"].Tag) !="")
                {
                    which = "Salesdaybook";
                    Query = "select * from tblbusinessissue where issuetype='SI'  and  TblBusinessIssue. ledcodecr  IN( 2)";
                    QueryDetail = " and pcode ='" +CommonClass._Dbtask.znllString( GridMain.SelectedRows[0].Cells["clnamount2"].Tag) + "' and vtype='SI'";
                    purchasesalessectn(heading, which, Query, QueryDetail);
                }

            }
            else if(heading =="Total Mada")
            {
                which = "Sales";
                Query = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.MPayment in(3)";
                purchasesalessectn(heading, which, Query,"");
            }
            else if(heading =="Total Visa/Master")
            {
                which = "Sales";
                Query = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.MPayment in(2)"; 
                purchasesalessectn(heading, which, Query,"");
            }
            else if (heading == "Total Cash Sale")
            {
                which = "Sales";
                Query = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.MPayment in(0)";
                purchasesalessectn(heading, which, Query, "");
            }
            else if (heading == "Sales Credit")
            {
                which = "Sales";
                Query = "  having  TblBusinessIssue.issuetype='SI' and  TblBusinessIssue. ledcodecr  IN( 2) and TblBusinessIssue.MPayment in(1)";
                purchasesalessectn(heading, which, Query, "");
            }
            else if (heading == "Sales return")
            {
                which = "Sales return";
                Query = " having TR.recpttype='SR' and TR.ledcodedr in(2)";
                purchasesalessectn(heading, which, Query, "");
            }
            else if (heading == "Payment" || heading == "Receipt")
            {
                string vttype = "";
                if (heading == "Payment")
                {
                    vttype = "P";
                }
                else
                {
                     vttype = "R";
                }

                RandPsectn(vttype,Pymntvno);
            }

            else if (heading == "Customers remaining Amount")
            {
               Clsselectreport.RDtfrom = Convert.ToDateTime(DtFrom.Value);
               Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value);
               Clsselectreport.RQueryTemp = "select * from tblaccountledger where agroupid in(18) or agroupid in (select agroupid from tblaccountgroup where aunder='18' ) order by lname asc ";
               Clsselectreport.RType = "OutstandingReportsummery";
               CommonClass._Clreport.ShowReport(this,true);
            }
            else if (heading == "Supplier remaining Amount")
            {
                Clsselectreport.RDtfrom = Convert.ToDateTime(DtFrom.Value);
                Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value);
                Clsselectreport.RQueryTemp = "select * from tblaccountledger where agroupid in(19) or agroupid in (select agroupid from tblaccountgroup where aunder='18' ) order by lname asc ";
                Clsselectreport.RType = "OutstandingReportsummery";
                CommonClass._Clreport.ShowReport(this, true);
            }

         
           
        }



        private void GridMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string notehead = "";
           Pymntvno="";
           bool ys = false;


           

           if (CommonClass._Dbtask.znllString(GridMain.SelectedRows[0].Cells["clnnote"].Tag) != "0" && CommonClass._Dbtask.znllString(GridMain.SelectedRows[0].Cells["clnnote"].Tag) != "")
           {

               if (GridMain.SelectedRows[0].Cells["clnnoteE"].Value != "Category")
               {
                   notehead = GridMain.SelectedRows[0].Cells["clnnote"].Tag.ToString();
               }
               else
               {
                   notehead = GridMain.SelectedRows[0].Cells["clnnoteE"].Value.ToString();
               }
           
           }
           else
           {
               notehead = GridMain.SelectedRows[0].Cells["clnnoteE"].Value.ToString();
           }


           if (notehead == "Total SalesReturn Tax" || notehead == "Total PurchaseReturn Tax" )
            {
                ys = true;

                MessageBox.Show("Result not Found");
            }
           if (notehead == "Category" )
           {
              
               celldetailsshows(notehead);
           
           
           }
           if (notehead == "Tax( Get - Paid )" || notehead == "Payment Tax")
            {
                 taxsummeryreport();
            }

            if (notehead == "(Sales Tax-Purchase Tax)" || notehead == "Receipt" || notehead == "Bank Amount" || notehead == "Balance" || notehead == "total cash balance" || notehead == "Bank to Cash" || notehead == "Cash to Bank" || notehead == "Payment")
            {
                ys = true;

                MessageBox.Show("Result not Found");
            }
            if (ys == false && notehead != "Tax( Get - Paid )" && notehead != "Payment Tax" && notehead != "Category")
            {
            Pymntvno = GridMain.SelectedRows[0].Cells["clnnote"].Tag.ToString();
            if (Pymntvno!=null&&Pymntvno!="0"&&Pymntvno!="Wieghtmechine" )
            {
                notehead = "Payment";
            }

            if (notehead != "Tax( Get - Paid )" && notehead != "Total CardAMT (by sale)" && notehead != "Total CashAMT (by sale)")
            {
                celldetailsshows(notehead);
            }
            if (notehead == "Total CardAMT (by sale)")
            {
                modeofpaymntnewreport("Card");
            }
            else
            {
                if (notehead == "Total CashAMT (by sale)")
                {
                    modeofpaymntnewreport("Cash");
                }
            }

            
            }

            


        }

        private void Pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ControleChecked(CheckBox Chk, double CCoresponding)
        {
            if (Chk.Checked == true)
            {
                CCoresponding = 1;
            }
            else
            {
                CCoresponding = -1;
            }
            Coresponding = CCoresponding;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chktotsqty_CheckedChanged(object sender, EventArgs e)
        {
            ControleChecked(chktotsqty, Tsqty);
             Tsqty = Coresponding;
             if (Tsqty==1)
            {
                chktotsqty.BackColor = Color.Yellow;
            }
            else
            {
                chktotsqty.BackColor=Color.White;
            }

        }

        private void cmdexcelimp_Click(object sender, EventArgs e)
        {
            ExporttoexcelImport();
        }

        private void CMDAFOUR_Click(object sender, EventArgs e)
        {
            frmsalesinvoice _Sales = new frmsalesinvoice();
            _Sales.RichTextBox1.Text = RichTextBox1.Text;
            // _Sales.SelectedPrinter = comPrint.Text;
            _Sales.IfPrintPreview = false;
            if (Reporttype == "Summury Report")
            {
                //thermal
                _ThermalThermal.FormType = "Summury ReportA4";
                _ThermalThermal.DateStr = "Date: " + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
                _ThermalThermal.TimeStr = "Time: " + DtFrom.Value.ToString("dd/MM/yyyy hh:mm:ss") + " To " + DtTo.Value.ToString("dd/MM/yyyy hh:mm:ss");

                if (ChkShowPreview.Checked == true)
                {
                    _ThermalThermal.Preview = true;

                }
                else
                {
                    _ThermalThermal.Preview = false;
                }


                _ThermalThermal.PrintInvoice(GridMain);

            }


            if (Reporttype == "TaxSummeryTWO")
            {
                ClsInvTAXtworeport _taxrep = new ClsInvTAXtworeport();
                _taxrep.FormType = "TaxSummeryTWO";
                _taxrep.DateStr = "Date: " + DtFrom.Value.ToString("dd/MM/yyyy") + " To " + DtTo.Value.ToString(" dd/MM/yyyy");
                _taxrep.TimeStr = "Time: " + DtFrom.Value.ToString("hh:mm:ss") + " To " + DtTo.Value.ToString("hh:mm:ss");

                if (ChkShowPreview.Checked == true)
                {
                    _taxrep.Preview = true;

                }
                else
                {
                    _taxrep.Preview = false;
                }


                _taxrep.PrintInvoice(GridMain);
            }




        }
       

    }
}
