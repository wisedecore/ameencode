using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data;

namespace WindowsFormsApplication2
{
    public partial class Frmpriceupdater : Form
    {
        public Frmpriceupdater()
        {
            InitializeComponent();
        }
        NextGFuntion _Nextg = new NextGFuntion();
        DataSet Ds;
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        DBTask _Dbtask = new DBTask();

        public string Itemid;
        public double ItemSrate;
        public string SizeName;
        public int rowindex;
        public int columnindex;
        public string Columnname;

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (this.ActiveControl != null)
            {
                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                   
                        if (this.ActiveControl.Name != "Gridmain")
                        {
                            SendKeys.Send("{Tab}");
                            return true;
                        }
                               
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void Frmpriceupdater_Load(object sender, EventArgs e)
        {
            
            _Nextg.FormStylesett(this);
            //_Nextg.FormImage(pnlImage);
            _Nextg.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
            //_Nextg.FormHeadStyle(pnlHead);
            
            Clear();

            ChangeLanguage();

            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        public void Clear()
        {          
                string txt = txtsearch.Text.Replace("'", "");
                Ds = _Itemmaster.ShowItemsProductName("having tblitemmaster.itemname like N'%" + txt + "%' or tblitemmaster.itemcode like N'%" + txt + "%'", 1);
                gridmain.DataSource = Ds.Tables[0];
                
                //gridmain.Columns["slno"].ReadOnly = true;
                //gridmain.Columns["itemcode"].ReadOnly = true;
                //gridmain.Columns["itemname"].ReadOnly = true;
               
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Main()
        {
            for (int i = 0; i < gridmain.Rows.Count; i++)
            {
                string Itemid = _Dbtask.znllString(gridmain.Rows[i].Cells["itemid"].Value);
                if (Itemid != "")
                {
                    double Prate = _Dbtask.znullDouble(gridmain.Rows[i].Cells["prate"].Value.ToString());
                    double Mrp = _Dbtask.znullDouble(gridmain.Rows[i].Cells["mrp"].Value.ToString());
                    double Srate = _Dbtask.znullDouble(gridmain.Rows[i].Cells["srate"].Value.ToString());
                    double Wrate = _Dbtask.znullDouble(gridmain.Rows[i].Cells["wrate"].Value.ToString());
                    UpdateFiled(Itemid, Prate, Mrp, Srate, Wrate);
                }
            }
            Clear();
        }

        public void UpdateFiled(string ItemId, double Prate, double Mrp, double Srate, double Wrate)
        {
            _Dbtask.ExecuteNonQuery("Update Tblitemmaster set prate=" + Prate + " , mrp=" + Mrp + " , srate="+Srate+" where   itemid='" + ItemId + "'");
            CommonClass.Ds3=_Dbtask.ExecuteQuery("select * from tblproductrate where pcode='"+ItemId+"'");
            if (CommonClass.Ds3.Tables[0].Rows.Count > 0)
            {
                _Dbtask.ExecuteNonQuery("Update TblProductRate set rate=" + Wrate + " where  pcode='" + ItemId + "'");
            }
            else
            {
                CommonClass._ProductRate.PCode = ItemId;
                CommonClass._ProductRate.UnitId = 0;
                CommonClass._ProductRate.RateId = 1;
                CommonClass._ProductRate.Ratedb =Wrate;
                CommonClass._ProductRate.Batchid ="";
                CommonClass._ProductRate.InsertProductRate();
                _Dbtask.ExecuteNonQuery("Update TblProductRate set rate=" + Wrate + " where  pcode='" + ItemId + "'");
            }
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void cmdprint_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void Frmpriceupdater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void gridmain_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columnindex = gridmain.CurrentCell.ColumnIndex;
            rowindex = gridmain.CurrentCell.RowIndex;
            Columnname = gridmain.Columns[columnindex].Name.ToString();

            if (gridmain.Rows[rowindex].Cells[columnindex].ReadOnly == true)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmdupdatesarebaseonsize_Click(object sender, EventArgs e)
        {
            CommonClass.Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where srate=0 order by itemid asc");
            for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
            {
                Itemid = CommonClass.Ds.Tables[0].Rows[i]["itemid"].ToString();
                SizeName = CommonClass.Ds.Tables[0].Rows[i]["sizelessname"].ToString();
                ItemSrate =_Dbtask.znullDouble( _Dbtask.ExecuteScalar("select srate from tblitemmaster where srate!=0 and sizelessname='" + SizeName + "'"));
                _Dbtask.ExecuteNonQuery("update tblitemmaster set srate='" + ItemSrate + "' where itemid='" + Itemid + "'");
            }
            MessageBox.Show("Completed", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
