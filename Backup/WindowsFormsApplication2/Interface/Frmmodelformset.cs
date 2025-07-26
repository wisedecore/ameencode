using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmmodelformset : Form
    {
        public Frmmodelformset()
        {
            InitializeComponent();
        }


        public double netamt = 0;
        public double nettax = 0;
        public double netgros = 0;
        public int Count = 0;
        DataSet Ds;
        public static int slnoo = Generalfunction.slno;
        int selectedRow;
        public bool edit = false;
        DBTask _dbtask = new DBTask();
        private void Frmmodelformset_Load(object sender, EventArgs e)
        {
            clear();  
        }
        public double  taxcalc(string itemid)
        {
            double vat = 0;  double VATAMT = 0;

            double srate = 0; double qtty = 0;
            srate = _dbtask.znlldoubletoobject(txtrate.textBox1.Text);


            qtty = _dbtask.znlldoubletoobject(txtqty.textBox1.Text);

                 
          vat =_dbtask.znlldoubletoobject( CommonClass._Itemmaster.SpecificField(itemid,"vat"));
        

           if(vat>0)
            {

                VATAMT = (srate * vat) / 115;
                VATAMT = VATAMT * qtty;
                 


            }
           return VATAMT;
                 


        }
        public void calculationpart()
        {
            double qtty = 0; double rate = 0; string taxtype = "";
            qtty = _dbtask.znlldoubletoobject(txtqty.textBox1.Text);
            rate = _dbtask.znlldoubletoobject(txtrate.textBox1.Text);

            txttax.textBox1.Text = _dbtask.znllString(_dbtask.SetintoDecimalpoint(taxcalc(_dbtask.znllString(txtitem.Tag))));
           taxtype = CommonClass._Itemmaster.SpecificField(_dbtask.znllString(txtitem.Tag), "incs");


           if (taxtype == "1")
           {
               netgros = (qtty * rate) - _dbtask.znlldoubletoobject(txttax.textBox1.Text);
               netamt = (qtty * rate);
           }
           else
           {
               netgros = (qtty * rate);
               netamt = (qtty * rate) + _dbtask.znlldoubletoobject(txttax.textBox1.Text);
           }

           txtgross.textBox1.Text = _dbtask.znllString(_dbtask.SetintoDecimalpoint(netgros));
           txtnetamt.textBox1.Text = _dbtask.znllString(_dbtask.SetintoDecimalpoint( netamt));


        }




        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {

            Ds = CommonClass._Itemmaster.getproductnormal(_dbtask.znllString(txtbarcode.Text));


            GidmainP.Columns.Clear();
            GidmainP.DataSource = null;
            GidmainP.Visible = true;
            //***table********//
            GidmainP.DataSource = Ds.Tables[0];

            for (int i = 0; i < GidmainP.Columns.Count; i++)
            {
                if (GidmainP.Columns[i].Name.ToString() == "ITEMID")
                    GidmainP.Columns[i].Visible = false;




            }
            GidmainP.Columns["bcode"].Width = 180;
            GidmainP.Columns["itemname"].Width = 190;

            this.GidmainP.Location = new System.Drawing.Point(79, 24);
        }

        private void txtbarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {

                if (GidmainP.SelectedRows.Count > 0)
                {
                    selectedRow = GidmainP.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && GidmainP.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (GidmainP.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            GidmainP.Rows[selectedRow + 1].Selected = true;
                            GidmainP.Rows[selectedRow].Selected = false;
                            GidmainP.CurrentCell = GidmainP.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        GidmainP.Rows[selectedRow - 1].Selected = true;
                        GidmainP.Rows[selectedRow].Selected = false;
                        GidmainP.CurrentCell = GidmainP.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (GidmainP.SelectedRows.Count > 0 && GidmainP.Visible == true)
                    {
                        string ITEMNAME = "";
                        ITEMNAME = GidmainP.SelectedRows[0].Cells["itemname"].Value.ToString();
                        if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                        {

                            txtbarcode.Text = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["bcode"].Value);
                            txtitem.Tag = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["itemid"].Value);
                            txtitem.Text = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["itemname"].Value);
                            txtitemcode.Text = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["itemcode"].Value);
                            
                            GidmainP.Visible = false;

                        }
                        else
                        {
                            txtitem.Tag = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["itemid"].Value);
                            txtitem.Text = _dbtask.znllString(GidmainP.SelectedRows[0].Cells["itemname"].Value);
                            GidmainP.Visible = false;


                        }




                    }



                }
                if (e.KeyValue == 27)
                {
                    GidmainP.Visible = false;

                }

            }


            catch
            {
            }
        }

        private void txtqty_TextChanged(object Sender, EventArgs e)
        {
            calculationpart();
        }

        private void txtrate_TextChanged(object Sender, EventArgs e)
        {
            calculationpart();
        }

        public void additems()
        {


            if (edit == true)
            {
                if (GridMain.SelectedCells.Count > 0)
                {
                    selectedRow = GridMain.SelectedCells[0].RowIndex;
                    if (_dbtask.znllString(GridMain.Rows[selectedRow].Cells["ClnSlno"].Value) == _dbtask.znllString(txtslno.Text))
                    {
                        
                            
                            GridMain.Rows.RemoveAt(GridMain.SelectedRows[0].Index);
                            
                        
                    }

                }

                edit = false;
            }



            if (edit == false)
            {
                Count = GridMain.Rows.Add(1);

                GridMain.Rows[Count].Cells["ClnSlno"].Value = _dbtask.znllString(txtslno.Text);
                GridMain.Rows[Count].Cells["ClnBatch"].Value = _dbtask.znllString(txtbarcode.Text);

                GridMain.Rows[Count].Cells["Clnitem"].Value = _dbtask.znllString(txtitem.Text);
                GridMain.Rows[Count].Cells["Clnitem"].Tag = _dbtask.znllString(txtitem.Tag);
                GridMain.Rows[Count].Cells["Clnitemcode"].Value = _dbtask.znllString(txtitemcode.Text);

                GridMain.Rows[Count].Cells["Clnqty"].Value = _dbtask.znlldoubletoobject(txtqty.textBox1.Text);

                GridMain.Rows[Count].Cells["ClnRate"].Value = _dbtask.znlldoubletoobject(txtrate.textBox1.Text);
                GridMain.Rows[Count].Cells["Clntax"].Value = _dbtask.znlldoubletoobject(txttax.textBox1.Text);

                GridMain.Rows[Count].Cells["Clngross"].Value = _dbtask.znlldoubletoobject(txtgross.textBox1.Text);
                GridMain.Rows[Count].Cells["ClnNetamount"].Value = _dbtask.znlldoubletoobject(txtnetamt.textBox1.Text);

            }
            //else
            //{
               
            //}
            
            }

        public void clear()
        {
            if(edit==false)
            {
            Generalfunction.slno = Generalfunction.slno + 1;
            }
            //Generalfunction.slno = 1;
            txtbarcode.Text = "";
            txtitem.Text = "";
            txtitem.Tag = "";
            txtitemcode.Text = "";
            txtqty.textBox1.Text = "";
            txtrate.textBox1.Text = "";
            txtgross.textBox1.Text = "";
            txttax.textBox1.Text = "";
            txtnetamt.textBox1.Text = "";
            edit = false;
            txtslno.Text = _dbtask.znllString(Generalfunction.slno);

            GidmainP.Visible = false;

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            additems();

            clear();
        }

        public void retreive(string slno)
        {

        }


        public void drilldown()
        {
            if (GridMain.SelectedCells.Count > 0)
            {
                selectedRow = GridMain.SelectedCells[0].RowIndex;
                
                if (_dbtask.znlldoubletoobject( GridMain.Rows[selectedRow].Cells["clnNetamount"].Value) >0)
                {
                    string select = "";
                    edit = true;
              txtbarcode.Text = "";
            txtitem.Text = "";
            txtitem.Tag = "";
            txtitemcode.Text = "";
            txtqty.textBox1.Text = "";
            txtrate.textBox1.Text = "";
            txtgross.textBox1.Text = "";
            txttax.textBox1.Text = "";
            txtnetamt.textBox1.Text = "";
             txtslno.Text ="";
             txtslno.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["ClnSlno"].Value);
             txtbarcode.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["ClnBatch"].Value);
             txtitem.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clnitem"].Value);
             txtitem.Tag = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clnitem"].Tag);
             txtitemcode.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clnitemcode"].Value);
             txtqty.textBox1.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clnqty"].Value);
             txtrate.textBox1.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["ClnRate"].Value);
             txttax.textBox1.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clntax"].Value);
             txtgross.textBox1.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["Clngross"].Value);
             txtnetamt.textBox1.Text = _dbtask.znllString(GridMain.Rows[selectedRow].Cells["ClnNetamount"].Value);
             GidmainP.Visible = false;

                }
            }
        }

        private void cmdrefresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void GridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            drilldown();
        }

        private void TxtAccount_TextChanged(object sender, EventArgs e)
        {

            Ds = CommonClass._Ledger.getcustomeronly(_dbtask.znllString(TxtAccount.Text));


            gridcustomer.Columns.Clear();
            gridcustomer.DataSource = null;
            gridcustomer.Visible = true;
            //***table********//
            gridcustomer.DataSource = Ds.Tables[0];

            for (int i = 0; i < gridcustomer.Columns.Count; i++)
            {
                if (gridcustomer.Columns[i].Name.ToString() == "lid")
                    gridcustomer.Columns[i].Visible = false;




            }
            gridcustomer.Columns["lname"].Width = 180;
           

            this.gridcustomer.Location = new System.Drawing.Point(586, 27);
        }

        private void TxtAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {

                if (gridcustomer.SelectedRows.Count > 0)
                {
                    selectedRow = gridcustomer.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && gridcustomer.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (gridcustomer.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            gridcustomer.Rows[selectedRow + 1].Selected = true;
                            gridcustomer.Rows[selectedRow].Selected = false;
                            gridcustomer.CurrentCell = gridcustomer.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        gridcustomer.Rows[selectedRow - 1].Selected = true;
                        gridcustomer.Rows[selectedRow].Selected = false;
                        gridcustomer.CurrentCell = gridcustomer.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (gridcustomer.SelectedRows.Count > 0 && gridcustomer.Visible == true)
                    {
                        string name= "";
                        name = gridcustomer.SelectedRows[0].Cells["lname"].Value.ToString();
                        
                           TxtAccount.Text = _dbtask.znllString(gridcustomer.SelectedRows[0].Cells["lname"].Value);
                           TxtAccount .Tag= _dbtask.znllString(gridcustomer.SelectedRows[0].Cells["lid"].Value);
   

                            gridcustomer.Visible = false;

                       
                        




                    }



                }
                if (e.KeyValue == 27)
                {
                    gridcustomer.Visible = false;

                }

            }


            catch
            {
            }
        }



    }
}
