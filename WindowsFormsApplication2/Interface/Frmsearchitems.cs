using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Frmsearchitems : Form
    {
        public Frmsearchitems()
        {
            InitializeComponent();
        }

        string Stockarea;
        DataSet Ds;
        string Temp;

        bool Sbatch;

        public void Menusettings()
        {
            if (CommonClass._settings.ReturnStatus("103") == "1")
            {
                Sbatch = true;
            }
        }

        private void Frmsearchitems_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Menusettings();
            CommonClass._Nextg.FormIcon(this);

           // pnltop.Focus();
            //txtsearch.textBox1.Focus();
            //txtsearch.textBox1.Select();
                // txtsearch.Focus();
        }
        public void Fillcombo()
        {


            CommonClass._Depot.FillCombo(comstockarea);
        
        
        }

        public void SelectStockarea()
        {
            if (chkallstockarea.Checked == true)
            {
                Stockarea = "";
                Ds = CommonClass._Dbtask.ExecuteQuery("select * from tbldepot");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        Stockarea = Ds.Tables[0].Rows[i]["dcode"].ToString();
                    }
                    else
                    {
                        Stockarea = Stockarea + "," + Ds.Tables[0].Rows[i]["dcode"].ToString();
                    }
                }

            }
            else
            {
                Stockarea = comstockarea.SelectedValue.ToString();
            }
        }

        private void txtsearch_TextChanged(object Sender, EventArgs e)
        {
            try
                {
                SelectStockarea();
                if (chkanykeysearch.Checked == true)
                {
                    Temp = " like N'%" + txtsearch.textBox1.Text + "%'";
                }
                else
                {

                    Temp = " like N'" + txtsearch.textBox1.Text + "%'";
                }

                if (Sbatch == true)
                {
                    Ds = CommonClass._Inventory.ShowsearchinItemwithBarcode(Temp, Stockarea);
                    GridProductShow.DataSource = Ds.Tables[0];

                    if (chkshowprate.Checked == true)
                        GridProductShow.Columns["prate"].Visible = true;
                    else
                        GridProductShow.Columns["prate"].Visible = false;
                    GridProductShow.Columns["itemid"].Visible = false;
                    GridProductShow.Columns["bcode"].Width = 250;
                    GridProductShow.Columns["itemname"].Width = 500;
                }
                else
                {
                    Ds = CommonClass._Inventory.ShowsearchinItem(txtsearch.textBox1.Text, Stockarea);
                    GridProductShow.DataSource = Ds.Tables[0];

                    if (chkshowprate.Checked == true)
                        GridProductShow.Columns["prate"].Visible = true;
                    else
                        // GridProductShow.Columns["prate"].Visible = false;

                       // GridProductShow.Columns["stock"].Visible = false;

                    GridProductShow.Columns["itemname"].Width = 500;
                }
            }
            catch
            {
            }
        }

        private void txtsearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           CommonClass._Ingrid.RowUpDownSelectWithoutUser(e.KeyValue,GridProductShow);

           if (e.KeyValue == 13)
           {
               ClickEdit();
           }
   


        }

        private void Frmsearchitems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void comstockarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stockarea = comstockarea.SelectedValue.ToString();
        }

        private void cmdexcel_Click(object sender, EventArgs e)
        {
            Exporttoexcel(GridProductShow);
        }

        public void Exporttoexcel(DataGridView Grid)
        {
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
                    StreamWriter wr = new StreamWriter(Filepath);

                    //determine the number of columns and write columns to file
                    cols = Grid.Columns.Count;
                   

                    wr.Write("Item List\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(Grid.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (Grid.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (Grid.Rows[i].Cells[j].Value != null)
                            {
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                Grid.Rows[i].Cells[j].Value = Grid.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(Grid.Rows[i].Cells[j].Value + "\t");
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

        private void Cmdshowallitem_Click(object sender, EventArgs e)
        {
            Ds = CommonClass._Dbtask.ExecuteQuery("SELECT     TblItemMaster.itemid,TblItemMaster.ItemName, Tblbatch.Bcode FROM Tblbatch  " +
           " INNER JOIN TblItemMaster ON Tblbatch.itemid = TblItemMaster.ItemId ORDER BY Tblbatch.itemid");
            GridProductShow.DataSource = Ds.Tables[0];
            //GridProductShow.Columns["itemid"].Visible = false;
        }

        public void ClickEdit()
        {
            try
            {
                if (GridProductShow.SelectedRows.Count > 0)
                {

                    Frmquickadditems _ItemWindow = new Frmquickadditems();
                    _ItemWindow.Isinotherwindow = true;
                    _ItemWindow.EditMode = true;
                    _ItemWindow.Barcode = GridProductShow.SelectedRows[0].Cells["bcode"].Value.ToString();
                    _ItemWindow.Id = GridProductShow.SelectedRows[0].Cells["itemid"].Value.ToString();
                    _ItemWindow.ShowDialog();
                }
            }
            catch
            {
            }
        }

        private void GridProductShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickEdit();
        }

        private void Frmsearchitems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            ClickEdit();
        }


        

    }
}
