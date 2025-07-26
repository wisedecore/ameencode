using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.UserControles
{
    public partial class UscLedgershow : UserControl
    {
        public UscLedgershow()
        {
            InitializeComponent();
        }
        int Rowindex;
        int ColumnIndex;
        public static int RowindexX;
        string Temp; 
        public static DataGridView Grid;
        DataSet Ds; 
        public int selected = 0;
        DBTask _Dbtask = new DBTask();
        string ColumnName;
        public static int Rowindxrow;
        public static int SelRow;
        public static int SelColu;
       
        public static string PassingColumn;
        public static string PassingColumn2;
        public static UserControl Usc;
        string Lid; public static int Selectedrow;
        private void GridProductShow_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                GetAccountBalance();
            }
            catch
            {
            }
        }

        public void GetAccountBalance()
        {
            try
            {
                if (GridProductShow.SelectedRows.Count > 0)
                {
                    Rowindex = GridProductShow.SelectedRows[0].Index;
                    if (GridProductShow.Rows[Rowindex].Cells["lid"].Value != null)
                    {

                        Lid = CommonClass._Dbtask.znllString(GridProductShow.Rows[Rowindex].Cells["lid"].Value);
                        lblstock.Text = (CommonClass._Ledger.Balanceofledger(Lid)).ToString();
                    }
                }
            }
            catch
            {
            }
        }

        public void FilliN(DataGridView gridmain, string LEDCODE)
        {
            Ds = _Dbtask.ExecuteQuery("select * from tblACCOUNTLEDGER where LID='" + LEDCODE + "'");
            if (Ds.Tables[0].Rows.Count > 0)
            {

                gridmain.Rows[Rowindxrow].Cells["clnledger"].Value = _Dbtask.znllString(CommonClass._Ledger.GetspecifField("LNAME", LEDCODE));

                gridmain.Rows[Rowindxrow].Cells["clnledger"].Tag = LEDCODE;
                

                
            }
        }

        public void IntoGrid()
        {

           

            try
            {
                Selectedrow = GridProductShow.SelectedRows[0].Index;


                //Temp =_Dbtask.znllString( GridProductShow.Rows[Selectedrow].Cells["name"].Value);
                Temp =_Dbtask.znllString( GridProductShow.Rows[Selectedrow].Cells["lid"].Value);
                    //Temp = GridProductShow.Rows[Selectedrow].Cells["barcode"].Value.ToString();
                FilliN(Grid, Temp);
               // Temp = Grid.Rows[Rowindex].Cells["clnitemcode"].Value.ToString();
               Grid.CurrentCell = Grid.Rows[Rowindxrow].Cells["clnamount"];
               
            }
            catch
            {
            }
        }
        public void Passingusercontrole(DataGridView PGrid, string PCln, int TsRow, int TsCol, UserControl PUsc)
        {
            Grid = PGrid;
            PassingColumn = PCln;
           
            SelColu = TsCol;
            Rowindxrow = TsRow;
            Usc = PUsc;
            
        }
        private void GridProductShow_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IntoGrid();
            //GridProductShow.Visible = false;
            //panel1.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;
            //panel4.Visible = false;
            //UscLedgershow
        }
    }
}
