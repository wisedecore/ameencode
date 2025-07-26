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
    public partial class Frmprodutionreport : Form
    {
        public Frmprodutionreport()
        {
            InitializeComponent();
        }
        DBTask _dbtask = new DBTask();
        DataSet Ds; int selectedRow;
        private void Frmprodutionreport_Load(object sender, EventArgs e)
        {
            Gridmain.Visible = false;
            visible();
            TXTvno.Enabled = false;
            chkpkddate.Checked = false;
        }
        public void visible()
        {
            CHKvnowise.Checked = false;

            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "-1")
            {
                TXTBATCH.Enabled = false;
                chkbcodewise.Enabled = false;
            }
            else
            {
                chkbcodewise.Checked = true;
            }


        }

        private void Txtbarcode_TextChanged(object Sender, EventArgs e)
        {
            Ds = CommonClass._Itemmaster.getbatchwiseprodctionitem(_dbtask.znllString(Txtbarcode.textBox1.Text));

               
                Gridmain.Columns.Clear();
                Gridmain.DataSource = null;
                Gridmain.Visible = true;
                //***table********//
                Gridmain.DataSource = Ds.Tables[0];

                for (int i = 0; i < Gridmain.Columns.Count; i++)
                {
                    if (Gridmain.Columns[i].Name.ToString() == "itemid")
                        Gridmain.Columns[i].Visible = false;


                    

                }
                Gridmain.Columns["bcode"].Width = 180;
                Gridmain.Columns["itemname"].Width = 190;

                this.Gridmain.Location = new System.Drawing.Point(9, 120);





        }

        private void Gridmain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //try
            //{

            //    if (Gridmain.SelectedRows.Count > 0)
            //    {
            //        selectedRow = Gridmain.SelectedRows[0].Index;
            //        if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
            //        {

            //            if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
            //            {
            //                Gridmain.Rows[selectedRow + 1].Selected = true;
            //                Gridmain.Rows[selectedRow].Selected = false;
            //                Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
            //            }
            //        }

            //        if (e.KeyValue == 38 && selectedRow != 0)
            //        {
            //            Gridmain.Rows[selectedRow - 1].Selected = true;
            //            Gridmain.Rows[selectedRow].Selected = false;
            //            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
            //        }
            //    }

            //    if (e.KeyValue == 13)
            //    {
            //        if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
            //        {
            //            string ITEMNAME = "";
            //            ITEMNAME = Gridmain.SelectedRows[0].Cells["itemname"].Value.ToString();
            //            if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            //            {

            //                Txtbarcode.textBox1.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["bcode"].Value);
            //            }
            //            else
            //            {
            //                txtitemwise.Tag= _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
            //                txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                        
            //            }


                        
                        
            //        }
                    
            //        Gridmain.Visible = false;
                    
            //    }
            //    if (e.KeyValue == 27)
            //    {
            //        Gridmain.Visible = false;
                    
            //    }


            //}


            //catch

            //{ 
            //}
        }

        private void Txtbarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {

                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                    {
                        string ITEMNAME = "";
                        ITEMNAME = Gridmain.SelectedRows[0].Cells["itemname"].Value.ToString();
                        if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                        {

                            Txtbarcode.textBox1.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["bcode"].Value);
                            txtitemwise.Tag = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
                            txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                            Gridmain.Visible = false;
                        
                        }
                        else
                        {
                            txtitemwise.Tag = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
                            txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                            Gridmain.Visible = false;
                        
                        
                        }

                      


                    }

                    

                }
                if (e.KeyValue == 27)
                {
                    Gridmain.Visible = false;

                }

            }


            catch
            {
            }
        }

        private void cmdshow_Click(object sender, EventArgs e)
        {
            string condtn = "";
           if(txtitemwise.Text==""&&chkbcodewise.Checked==false&&TXTBATCH.Text=="")
           {
               condtn = "";
           }
           if (chkbcodewise.Checked == true && TXTBATCH.Text != "" && txtitemwise.Text != "")
            {
                condtn = " AND  batchcode='" + _dbtask.znllString(TXTBATCH.Text) + "' and itemid='" + _dbtask.znllString(txtitemwise.Tag) + "' ";
            }

           if (chkbcodewise.Checked == false && TXTBATCH.Text == "" && txtitemwise.Text != "")
           {
               condtn = "  and itemid='" + _dbtask.znllString(txtitemwise.Tag) + "' ";
           }


            if(_dbtask.znllString(TXTvno.textBox1.Text)!=""&&CHKvnowise.Checked==true)
            {
                condtn = " and vno = '"+_dbtask.znllString(TXTvno.textBox1.Text)+"' ";
            }

            Clsselectreport.RType = "Productionanddetails";
            Clsselectreport.RQuery = condtn;
           
            Clsselectreport.RQueryDetail = "";

            if(chkpkddate.Checked==false)
            {
            Clsselectreport.RDtfrom = dtdatefrom.Value;
            Clsselectreport.Rdtto = dtdateTo.Value;
            Clsselectreport.RQueryTemp = " vdate ";
            }
            if (chkpkddate.Checked == true)
            {
                Clsselectreport.RDtfrom = dtpkdfrom.Value ;
                Clsselectreport.Rdtto = dtpkdto.Value;
                Clsselectreport.RQueryTemp = " packdate ";
            }

            CommonClass._Clreport.ShowReport(this, true);





        }

        private void TXTBATCH_TextChanged(object sender, EventArgs e)
        {
            Ds = CommonClass._Itemmaster.getbatchwiseprodctionitem(_dbtask.znllString(TXTBATCH.Text));


            Gridmain.Columns.Clear();
            Gridmain.DataSource = null;
            Gridmain.Visible = true;
            //***table********//
            Gridmain.DataSource = Ds.Tables[0];

            for (int i = 0; i < Gridmain.Columns.Count; i++)
            {
                if (Gridmain.Columns[i].Name.ToString() == "ITEMID")
                    Gridmain.Columns[i].Visible = false;




            }
            Gridmain.Columns["bcode"].Width = 180;
            Gridmain.Columns["itemname"].Width = 190;

            this.Gridmain.Location = new System.Drawing.Point(1, 190);
        }

        private void TXTBATCH_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {

                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                    {
                        string ITEMNAME = "";
                        ITEMNAME = Gridmain.SelectedRows[0].Cells["itemname"].Value.ToString();
                        if (_dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
                        {

                          TXTBATCH.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["bcode"].Value);
                            txtitemwise.Tag = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
                            txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                            Gridmain.Visible = false;

                        }
                        else
                        {
                            txtitemwise.Tag = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
                            txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                            Gridmain.Visible = false;


                        }




                    }



                }
                if (e.KeyValue == 27)
                {
                    Gridmain.Visible = false;

                }

            }


            catch
            {
            }
        }

        private void chkbcodewise_CheckedChanged(object sender, EventArgs e)
        {
           if( chkbcodewise.Checked==true)

           {
               txtitemwise.Enabled = false;
               txtitemwise.Text = "";
           }
            else
           {
               if (CommonClass._Menusettings.GetMnustatus("103") == "1")
               {
                   txtitemwise.Enabled = true;
                   //TXTBATCH.Enabled = false;
                   TXTBATCH.Text = "";
               }
               if (CommonClass._Menusettings.GetMnustatus("103") == "-1")
               {
                   txtitemwise.Enabled = true;
                   TXTBATCH.Enabled = false;
                   TXTBATCH.Text = "";
               }

              
           }


           Gridmain.Visible = false;
        }

        private void txtitemwise_TextChanged(object sender, EventArgs e)
        {
            //12, 163

            Ds = CommonClass._Itemmaster.getITEMwiseprodctionitem(_dbtask.znllString(txtitemwise.Text));


            Gridmain.Columns.Clear();
            Gridmain.DataSource = null;
            Gridmain.Visible = true;
            //***table********//
            Gridmain.DataSource = Ds.Tables[0];

            for (int i = 0; i < Gridmain.Columns.Count; i++)
            {
                if (Gridmain.Columns[i].Name.ToString() == "ITEMID")
                    Gridmain.Columns[i].Visible = false;




            }
            
            Gridmain.Columns["itemname"].Width = 230;

            this.Gridmain.Location = new System.Drawing.Point(12, 240);

        }

        private void txtitemwise_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            try
            {

                if (Gridmain.SelectedRows.Count > 0)
                {
                    selectedRow = Gridmain.SelectedRows[0].Index;
                    if (e.KeyValue == 40 && Gridmain.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (Gridmain.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            Gridmain.Rows[selectedRow + 1].Selected = true;
                            Gridmain.Rows[selectedRow].Selected = false;
                            Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                        }
                    }

                    if (e.KeyValue == 38 && selectedRow != 0)
                    {
                        Gridmain.Rows[selectedRow - 1].Selected = true;
                        Gridmain.Rows[selectedRow].Selected = false;
                        Gridmain.CurrentCell = Gridmain.SelectedRows[0].Cells[0];
                    }
                }

                if (e.KeyValue == 13)
                {
                    if (Gridmain.SelectedRows.Count > 0 && Gridmain.Visible == true)
                    {
                        string ITEMNAME = "";
                        ITEMNAME = Gridmain.SelectedRows[0].Cells["itemname"].Value.ToString();
                       
                            txtitemwise.Tag = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemid"].Value);
                            txtitemwise.Text = _dbtask.znllString(Gridmain.SelectedRows[0].Cells["itemname"].Value);
                            Gridmain.Visible = false;


                        




                    }



                }
                if (e.KeyValue == 27)
                {
                    Gridmain.Visible = false;

                }

            }


            catch
            {
            }


        }

        private void CHKvnowise_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKvnowise.Checked == true)
            {
                txtitemwise.Enabled = false;
                TXTBATCH.Enabled = false;
                TXTvno.Enabled = true;
            }
            else
            {
                chkbcodewise.Checked = true;
                //TXTBATCH.Enabled = true;
                TXTvno.Enabled = false;
                TXTBATCH.Enabled = true;
                
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtitemwise.Text = "";
            txtitemwise.Tag = "";
            TXTBATCH.Text = "";
            TXTvno.textBox1.Text = "";
            CHKvnowise.Checked = false;
            chkbcodewise.Checked = true;
        }
    }
}
