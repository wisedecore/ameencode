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
    public partial class UscGridshowPOS : UserControl
    {
        public UscGridshowPOS()
        {
            InitializeComponent();
        }
        //frmsalesinvoice _Sale = new frmsalesinvoice();

        public static TextBox ActiveControle;
        public static Form ActiveForm;
        public static DataGridView Grid;
        public static int SelRow;
        public static int SelColu;
        public static int Selectedrow;
        public static string PassingColumn;
        public static string PassingColumn2;
        public static UserControl Usc ;
        public static bool IncludeBatch;
        DBTask _dbtask = new DBTask();
        public static double Stock;
        string Itemid;
        public static int Rowindex;
        string Temp;
        DataSet Ds;
        DBTask _Dbtask = new DBTask();
        public void GetStock(double Amount)
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
                    Itemid = GridProductShow.Rows[Selectedrow].Cells["itemid"].Value.ToString();
                    Frmitems _items = new Frmitems();
                    Frmitems.Itemid = Itemid;
                    Frmitems.Isinotherwindow = true;
                    Frmitems.EditMode = true;
                    _items.ShowDialog();
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

               gridmain.Rows[Rowindex].Cells["ClnMRP"].Value = _Dbtask.SetintoDecimalpoint(TempMrp);
           }
        }

        public void IntoGrid()
        {
            try
            {
                Selectedrow = GridProductShow.SelectedRows[0].Index;

                if(IncludeBatch==false)
                {
                CommonClass._Ingrid.ProductIntoMainGrid(Grid, GridProductShow, Selectedrow, Rowindex, PassingColumn, PassingColumn2);
                }
                    else
                {
                    Temp = GridProductShow.Rows[Selectedrow].Cells["bcode"].Value.ToString();
                    FillinBarcode(Grid, Temp);
                 }
                Temp = Grid.Rows[Rowindex].Cells["clnitemcode"].Value.ToString();
                Grid.CurrentCell = Grid.Rows[Rowindex].Cells["clnqty"];
                //SendKeys.Send("{Tab}");
                Usc.Visible = false;

            }
            catch
            {
            }
        }
        private void GridProductShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IntoGrid();
        }

        private void GridProductShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntoGrid();
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
    }
}
