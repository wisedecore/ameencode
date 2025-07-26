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
    public partial class frmreorderreport : Form
    {
        public frmreorderreport()
        {
            InitializeComponent();
        }
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        ClsInventory _Inventory = new ClsInventory();
        public string temp;
        public string temp2;
        public string Where;
        public string Sql;
        public string CusId = "";
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)//TxtProduct,Txtqty,TxtAmt,panel2/*
            {


                //if (this.ActiveControl.Name != "Gridbatchlist" || this.ActiveControl.Name != "pnlbill")
                //{
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                    return true;
                }
                if (GridMain.Visible == true)
                {
                    if (msg.WParam.ToInt32() == (int)Keys.Down)
                    {
                        // SendKeys.Send("{Tab}");
                        return true;
                    }
                    if (msg.WParam.ToInt32() == (int)Keys.Up)
                    {
                        //SendKeys.Send("{Tab}");
                        return true;

                    }
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        public string  FnSupplierwise(bool batch )
        {
            if (batch == true)
            {
                Where = "SELECT " +
                 " tblTRANSACTIONRECEIPT.vno, " +
                 " tblreceiptdetails.pcode," +
                 " tblitemmaster.itemid," +
                 " tblitemmaster.itemcode," +
                 " tblitemmaster.itemname, tblitemmaster.prate," +
                 " tblitemmaster.srate, tblitemmaster.reorder,tblitemmaster.categoryid," +
                 " tblbatch.bcode" +
                 "  FROM  tblTRANSACTIONRECEIPT" +
                 " JOIN  tblreceiptdetails" +
                 " ON tblTRANSACTIONRECEIPT.vno = tblreceiptdetails.recptcode" +
                 " JOIN tblitemmaster" +
                 " ON tblitemmaster.itemid = tblreceiptdetails.pcode" +
                 " JOIN tblbatch" +
                 " ON tblbatch.itemid = tblitemmaster.itemid" +
                 " where  tblTRANSACTIONRECEIPT.ledcodecr='" + CusId + "' and tblitemmaster.reorder!=0";

            }
            else
            {
                Where = "SELECT " +
                 " tblTRANSACTIONRECEIPT.vno, " +
                  " tblreceiptdetails.pcode," +
                  " tblitemmaster.itemid," +
                 " tblitemmaster.itemcode," +
                 " tblitemmaster.itemname, tblitemmaster.prate," +
                 " tblitemmaster.srate, tblitemmaster.reorder,tblitemmaster.categoryid " +
                                 
                 "  FROM  tblTRANSACTIONRECEIPT" +
                 " JOIN  tblreceiptdetails" +
                 " ON tblTRANSACTIONRECEIPT.vno = tblreceiptdetails.recptcode" +
                 " JOIN tblitemmaster" +
                 " ON tblitemmaster.itemid = tblreceiptdetails.pcode" +
                                 
                  " where  tblTRANSACTIONRECEIPT.ledcodecr='" + CusId + "' and tblitemmaster.reorder!=0";

            }
    
    return Where;
        }


        public void reordershow()
        {
            GridMain.Rows.Clear();
          GridMain.Columns.Clear();
            temp=txtitemname.Text;

           temp2= txtsupplier.Text;
           bool batch = false;
           if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
           {
               GridMain.Columns.Add("Clnbcode", "Barcode");
               GridMain.Columns["Clnbcode"].Width = 150;
               batch = true;

           }
            GridMain.Columns.Add("Clnitemcode", "Itemcode");
            GridMain.Columns["Clnitemcode"].Width = 300;

            GridMain.Columns.Add("Clnitemname", "Item Name");
            GridMain.Columns["Clnitemname"].Width = 300;

            GridMain.Columns.Add("clnreorder", "Reorder");
            GridMain.Columns["clnreorder"].Width = 200;


            //GridMain.Columns.Add("clnsupplier", "Supplier");
            //GridMain.Columns["clnsupplier"].Width = 150;

            GridMain.Columns.Add("Clncategory", "Category");
            GridMain.Columns["Clncategory"].Width = 150;
            GridMain.Columns.Add("clnstock", "Stock");
            GridMain.Columns["clnstock"].Width = 150;
            GridMain.Columns.Add("Clnsrate", "SRate");
            GridMain.Columns["Clnsrate"].Width = 100;

            GridMain.Columns.Add("Clnprate", "PRate");
            GridMain.Columns["Clnprate"].Width = 100;
            
            if(batch==false)
            {
            Sql = "select * from tblitemmaster";
            Where = Sql + " where  Reorder!=0";
            }
            if(batch==true)
            {
                Where = " SELECT tblitemmaster.itemcode,tblitemmaster.itemname, " +
                        " tblitemmaster.Reorder,tblitemmaster.categoryid, " +
                        " tblitemmaster.srate,tblitemmaster.prate, " +
                        " tblitemmaster.itemid, " +
                        " tblbatch.bcode " +
                        " FROM tblitemmaster " +
                        " INNER JOIN tblbatch ON tblitemmaster.itemid=tblbatch.itemid " +
                        " where tblitemmaster.reorder !=0 ";
            }

            if (txtitemname.textBox1.Text != "")
            {
                temp = _Dbtask.znllString(txtitemname.textBox1.Text);
                if (batch == false)
                {
                    Where = Where + " and  itemname Like N'%" + temp + "%' or itemcode N'%" + temp + "%' ";
                }
                else
                {
           Where = "Select Tblbatch.Bcode , TblItemMaster.CategoryId,"+
          " TblItemMaster.ItemId , TblItemMaster.Itemcode"+
            " , TblItemMaster.ItemName,TblItemMaster.reorder," +
         " Tblbatch.SRate,Tblbatch.prate "+
         " FROM  TblItemMaster INNER JOIN Tblbatch "+
         " ON TblItemMaster.ItemId = Tblbatch.itemid " +
        " where  TblItemMaster.itemcode like N'%" + temp + "%' or " +
         " TblItemMaster.itemname like N'%" + temp + "%' or" +
        " Tblbatch.Bcode Like N'%" + temp + "%' ";
                }
                
                }
            if (txtsupplier.textBox1.Text != "")
            {
                if (batch == true)
                {
                    Where = FnSupplierwise(true);
                }
                else
                {
                    Where = Where = FnSupplierwise(false);
                }
                }

           // Where = Where + " order by reptcode asc ";


            Ds = _Dbtask.ExecuteQuery(Where);




           // Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where  Reorder!=0 and itemname Like '%" + temp + "%'or supplier like '%" + temp2 + "%'");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                GridMain.Rows.Add(1);
                string bcode = "";
                string ItemId = Ds.Tables[0].Rows[i]["itemid"].ToString();
               // string Batchcode=Ds.Tables[0].Rows[i][""]
                if(batch==true)
                {
                   
                  bcode=_Dbtask.znllString(Ds.Tables[0].Rows[i]["bcode"]);
                GridMain.Rows[i].Cells["Clnbcode"].Value =_Dbtask.znllString( Ds.Tables[0].Rows[i]["bcode"]);
                }
                GridMain.Rows[i].Cells["Clnitemcode"].Value = Ds.Tables[0].Rows[i]["itemcode"];
                GridMain.Rows[i].Cells["Clnitemcode"].Tag = ItemId;
                GridMain.Rows[i].Cells["Clnitemname"].Value = Ds.Tables[0].Rows[i]["itemname"];
                GridMain.Rows[i].Cells["clnreorder"].Value = Ds.Tables[0].Rows[i]["Reorder"];
                //GridMain.Rows[i].Cells["clnsupplier"].Value = Ds.Tables[0].Rows[i]["supplier"];

                GridMain.Rows[i].Cells["Clncategory"].Value = _Dbtask.ExecuteScalar("select category from tblitemcategory where categoryid='" + Ds.Tables[0].Rows[i]["categoryid"] + "'");

                if (batch == false)
                {
                    GridMain.Rows[i].Cells["clnstock"].Value = _Inventory.GetStock("where pcode='" + ItemId + "' ");
                }
                else
                {
                    GridMain.Rows[i].Cells["clnstock"].Value = _Inventory.GetStock("where pcode='" + ItemId + "' and batchcode='" + bcode + "' ");
                }
                GridMain.Rows[i].Cells["Clnsrate"].Value = Ds.Tables[0].Rows[i]["srate"];
                GridMain.Rows[i].Cells["Clnprate"].Value = Ds.Tables[0].Rows[i]["prate"];


            }
        }
        public void MaxforSett(Form Frm)
        {
            Frm.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - 90);
        }

      
      

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            reordershow();
        }

        private void cmdsave_Enter(object sender, EventArgs e)
        {
            reordershow();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            reordershow();
        }

        private void txtitemname_TextChanged(object Sender, EventArgs e)
        {
            
            reordershow();
        }

        private void txtsupplier_TextChanged(object Sender, EventArgs e)
        {
            CommonClass._Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtsupplier.textBox1.Text, uscitemshowsimple2, 0);
            //reordershow();
        }

        private void frmreorderreport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            reordershow();
        }

        private void frmreorderreport_Load(object sender, EventArgs e)
        {
            reordershow();
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.GridHeaderConversion(GridMain);
                CommonClass._Language.PanelBasedConversion(panel2);
                //CommonClass._Language.PanelBasedConversion(Pnlbottom);
            }
        }

        private void txtsupplier_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            CommonClass._Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtsupplier.textBox1);

            uscitemshowsimple2.Location = new System.Drawing.Point(460, 60);
            if (e.KeyValue == 13)
            {
                CusId = txtsupplier.textBox1.Tag.ToString();
                reordershow();

            }
        }

        private void cmdclear_Click_1(object sender, EventArgs e)
        {
            txtitemname.textBox1.Text = "";
            txtsupplier.textBox1.Text = "";
            CusId = "";
            GridMain.Rows.Clear();
            GridMain.Columns.Clear();

        }
       

        
    }
}
