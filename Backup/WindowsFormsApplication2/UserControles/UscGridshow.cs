using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UscGridshow : UserControl
    {
        public UscGridshow()
        {
            InitializeComponent();
        }
        //frmsalesinvoice _Sale = new frmsalesinvoice();

        public static TextBox ActiveControle;
        public static Form ActiveForm;
        public static DataGridView Grid;
        public static int SelRow; public bool opbatch = false;
        public static int SelColu;
        public static int Selectedrow;
        public static string PassingColumn;
        public static string PassingColumn2;
        public static UserControl Usc ;
        public string batchcode = "";
        public static bool IncludeBatch;
        DBTask _dbtask = new DBTask();
        public static double Stock;
        string Itemid; public int selected = 0;
        public bool mclik = false;
        public static int Rowindex;
        string Temp;
        DataSet Ds;
        DBTask _Dbtask = new DBTask();
        public void GetStock(double Amount)
        {
            lblstock.Text = _dbtask.SetintoDecimalpointStock(Amount);
        }
        public void GetWrate(double Amount)
        {
            lblstock.Text = _dbtask.SetintoDecimalpointStock(Amount);
        }

        private void GridProductShow_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           // lblstock.Text = _dbtask.SetintoDecimalpointStock(Stock);
        }

        private void GridProductShow_DoubleClick(object sender, EventArgs e)
        {
            //string AName = Generalfunction.ActiveForm;
            //if (AName == "frmsalesinvoice")
            //{
           
            //}

        }

        private void UscGridshow_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmdnew_Click(object sender, EventArgs e)
        {
            Frmitems.CloseAfterSave = true;
            Frmitems.Isinotherwindow = false;
            CommonClass._Forms.ShowItemcreate();
            
        }


        private void cmdedit_Click(object sender, EventArgs e)
        {
            try
            {
                Selectedrow = GridProductShow.SelectedRows[0].Index;
                if (GridProductShow.Rows[Selectedrow].Cells["itemid"].Value != null)
                {
                    Frmquickadditems _Form = new Frmquickadditems();
                    _Form.EditMode = true;


                    if (CommonClass._Menusettings.GetMnustatus("103")=="1")
                    {
                        _Form.Barcode = _dbtask.znllString(GridProductShow.Rows[Selectedrow].Cells["bcode"].Value);
                    }

                    _Form.Id = _dbtask.znllString(GridProductShow.Rows[Selectedrow].Cells["itemid"].Value);
                    _Form.ShowDialog();
                }
            }
            catch
            {
            }
        }

        public void Passingusercontrole(DataGridView PGrid, string PCln, string PCln2, int TsRow, int TsCol,UserControl PUsc,bool IsinBatch)
        {
            Grid = PGrid;
            PassingColumn = PCln;
            PassingColumn2 = PCln2;
            SelColu = TsCol;
            Rowindex = TsRow;
            Usc = PUsc;
            IncludeBatch = IsinBatch;
        }

        public void FillinBarcode(DataGridView gridmain, string TempBathcode)
        {
           Ds = _Dbtask.ExecuteQuery("select * from tblbatch where bcode='" + TempBathcode + "'");
           if (Ds.Tables[0].Rows.Count > 0)
           {
               string Tempitemid = _Dbtask.ExecuteScalar("select itemid from tblbatch where bcode='" + TempBathcode + "'");
               gridmain.Rows[Rowindex].Cells["clnbatch"].Value = TempBathcode;

               gridmain.Rows[Rowindex].Cells["ClnItemCode"].Value = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Tempitemid + "'");
               gridmain.Rows[Rowindex].Cells["ClnItemName"].Tag = Tempitemid;

               gridmain.Rows[Rowindex].Cells["ClnItemName"].Value = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Tempitemid + "'");
               double TempSrate = Convert.ToDouble(CommonClass. _Batch.GetSpecificFieldofBatch(TempBathcode, "srate"));
               double TempMrp = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "mrp"));

               gridmain.Rows[Rowindex].Cells["ClnMRP"].Value = _Dbtask.SetintoDecimalpoint(TempMrp);
               gridmain.Rows[Rowindex].Cells["clnsrate"].Tag = _Dbtask.ExecuteScalar("select incs from tblitemmaster where itemid='" + Tempitemid + "'");

               gridmain.Rows[Rowindex].Cells["clnsrate"].Value = _Dbtask.SetintoDecimalpoint(TempSrate);

               
               if (PassingColumn == "clnprate")
               {
                   gridmain.Rows[Rowindex].Cells["clnprate"].Value = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "PRATE"));
               }

               if (PassingColumn == "clnrate")
               {
                   gridmain.Rows[Rowindex].Cells["clnrate"].Value = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "PRATE"));
               }
               if (PassingColumn == "Clnprate")
               {
                   gridmain.Rows[Rowindex].Cells["clnprate"].Value = Convert.ToDouble(CommonClass._Batch.GetSpecificFieldofBatch(TempBathcode, "PRATE"));
               }

               
               gridmain.Rows[Rowindex].Cells["ClnMRP"].Value = _Dbtask.SetintoDecimalpoint(TempMrp);
           }
        }

        public void IntoGrid()
            {

            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {

                IncludeBatch = true;
            }
            else
            {
                IncludeBatch = false;
            }

            try
            {
                Selectedrow = GridProductShow.SelectedRows[0].Index;

                if(IncludeBatch==false)
                {
                CommonClass._Ingrid.ProductIntoMainGrid(Grid, GridProductShow, Selectedrow, Rowindex, PassingColumn, PassingColumn2);
                }
                    else
                {
                    Temp = GridProductShow.Rows[Selectedrow].Cells["barcode"].Value.ToString();
                    FillinBarcode(Grid, Temp);
                 }
                Temp = Grid.Rows[Rowindex].Cells["clnitemcode"].Value.ToString();
                Grid.CurrentCell = Grid.Rows[Rowindex].Cells["clnqty"];
                //SendKeys.Send("{Tab}");
                GridProductShow.Visible = true;
              

            }
            catch
            {
            }
        }
        private void GridProductShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {

           
                 
                   //CommonClass._Sales.gridmain.CurrentCell = CommonClass._Sales.gridmain.Rows(selectedIndex).Cells(1);
                 
                   //CommonClass._Sales.RowClick(TempBathcode, 13);
                    
           
         IntoGrid();
        }

        private void GridProductShow_KeyPress(object sender, KeyPressEventArgs e)
        {
           // IntoGrid();
        }

        private void GridProductShow_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GridProductShow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void GridProductShow_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void UscGridshow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void cmdsett_Click(object sender, EventArgs e)
        {
            /*Update Field*///////////////////
            string ItemCodeLen="0";
            string ItemNameLen="0";
            string BcodeLen="0";
            string SrateLen="0";
            string PrateLen="0";
            string RackLen="0";
            string MrpLen="0";

            if(GridProductShow.Columns["itemcode"].Visible==true)
            {
                ItemCodeLen=GridProductShow.Columns["itemcode"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmitemcode", "0", ItemCodeLen);
            }

            if (GridProductShow.Columns["itemname"].Visible == true)
            {
                ItemNameLen = GridProductShow.Columns["itemname"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmitemname", "0", ItemNameLen);
            }

            //if (GridProductShow.Columns["Bcode"].Visible == true)
            //{
            //    BcodeLen = GridProductShow.Columns["Bcode"].Width.ToString();
            //    CommonClass._Paramlist.UpdateParamlist("Gmbcode", "0", BcodeLen);
            //}

            if (GridProductShow.Columns["srate"].Visible == true)
            {
                SrateLen = GridProductShow.Columns["srate"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmsrate", "0", SrateLen);
            }
            if (GridProductShow.Columns["prate"].Visible == true)
            {
                PrateLen = GridProductShow.Columns["prate"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmprate", "0", PrateLen);
            }
            if (GridProductShow.Columns["rack"].Visible == true)
            {
                RackLen = GridProductShow.Columns["rack"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmrack", "0", RackLen);
            }
            if (GridProductShow.Columns["mrp"].Visible == true)
            {
                MrpLen = GridProductShow.Columns["mrp"].Width.ToString();
                CommonClass._Paramlist.UpdateParamlist("Gmmrp", "0", MrpLen);
            }

        }
    }
}
