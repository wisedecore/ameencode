using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Frmstockhistory : Form
    {
        public Frmstockhistory()
        {
            InitializeComponent();
        }

        /*For Drill Down Use*/
        int RowIndex;
        int Columnindex;
        string ColumnName;
        /*************************/

        string Sql;
        string SelectedVtypeStr;
        int Count;
        bool SBarcode;
        bool SVtype;
        bool SLedger;
        bool IsEnter;

        string Itemid;
        string Barcode;
        string Vtype;
        string temp;
        string Ledger;
       // DateTime Dtfrom;
        //DateTime Dtto;

        string Slno;
       // string Vtype;
        string Vno;
        DateTime Vdate;
        string Party;
        string PartyCode;
        double QtyIn;
        double Qtyout;

        double TempQty;
        double TQtyIn;
        double TQtyout;
        double TBalanceQty;

        int SeleRow;
        string TCode;
        string MainAccount;
        string Vcode;
        private void cmdshow_Click(object sender, EventArgs e)
        {
            ShowItemHistory();
        }
        public void SelectedVtypeFU()
        {
            if (comvtype.Text == "Sales")
            {
                SelectedVtypeStr = "SI";
            }
            if (comvtype.Text == "Sales Return")
            {
                SelectedVtypeStr = "Sr";
            }
            if (comvtype.Text == "Purchase")
            {
                SelectedVtypeStr = "PI";
            }
            if (comvtype.Text == "Purchase Return")
            {
                SelectedVtypeStr = "Pr";
            }

            if (comvtype.Text == "Opening Stock")
            {
                SelectedVtypeStr = "Os";
            }
            if (comvtype.Text == "Delivery Note")
            {
                SelectedVtypeStr = "DN";
            }
            if (comvtype.Text == "Internel Issue")
            {
                SelectedVtypeStr = "iisue";
            }
            if (comvtype.Text == "Shortage")
            {
                SelectedVtypeStr = "Sh";
            }

            if (comvtype.Text == "Damage")
            {
                SelectedVtypeStr = "Dm";
            }
            //if (comvtype.Text == "Free Receipt")
            //{
            //    SelectedVtype = "DN";
            //}
            //if (comvtype.Text == "Free Issuee")
            //{
            //    SelectedVtype = "iisue";
            //}
            if (comvtype.Text == "Meterial Receipt")
            {
                SelectedVtypeStr = "MR";
            }
            if (comvtype.Text == "Internel Receipt")
            {
                SelectedVtypeStr = "IR";
            }
        }

        public bool SelectedVtype(string Vtype)
        {
            if (Vtype == SelectedVtypeStr|| chkallvouchertype.Checked==true)
            {
                return true;
            }
            return false;
        }

        public bool SelectedLedger(string Ledcode)
        {
            if (Ledcode == comledger.Text || chkallledger.Checked == true)
            {
                return true;
            }
            return false;
        }

        public string CheckVoucherType(DataGridView Grid,int Rowindex)
        {
            if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["os"]) != 0)
            {
            CommonClass.temp="OS";
            TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["os"]);
            }

            if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Purchase"]) != 0)
            {
            CommonClass.temp="PI";
            TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Purchase"]);
            }

            if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Mr"]) != 0)
            {
            CommonClass.temp="MR";
            TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Mr"]);
            }

            if(CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Sr"])!=0)
            {
            CommonClass.temp="SR";
            TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Sr"]);
            }

            if(CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["ireceipt"])!=0)
            {
                CommonClass.temp = "IRECEIPT";
                TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["ireceipt"]);
            }

            if(CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["bmr"])!=0)
            {
            CommonClass.temp="BMR";
            TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["bmr"]);
            }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["sales"]) != 0)
             {
                 CommonClass.temp = "SI";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["sales"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["dn"]) != 0)
             {
                 CommonClass.temp = "DN";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Dn"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["pr"]) != 0)
             {
                 CommonClass.temp = "PR";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["pr"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["iissue"]) != 0)
             {
                 CommonClass.temp = "IISSUE";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["iissue"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["sh"]) != 0)
             {
                 CommonClass.temp = "SH";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["sh"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Dnr"]) != 0)
             {
                 CommonClass.temp = "DNR";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["Dnr"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["dmg"]) != 0)
             {
                 CommonClass.temp = "DMG";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["dmg"]);
             }

             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["bmi"]) != 0)
             {
                 CommonClass.temp = "BMI";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["BMI"]);
             }
             if (CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["freeiss"]) != 0)
             {
                 CommonClass.temp = "FREEISS";
                 TempQty = CommonClass._Dbtask.znlldoubletoobject(CommonClass.Ds.Tables[0].Rows[Rowindex]["freeiss"]);
             }
             return CommonClass.temp;
        }
        public void ShowItemHistory()
        {
            if (txtitem.Tag != null)
            {
                Itemid = txtitem.Tag.ToString();

                Sql = "select * from tblinventory where pcode in(" + Itemid + ") " +
                " and invdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM/dd/yyyy") + " 23:59:59'";

                if (chkallbarcode.Checked == false&&comselectbarcode.Text !="")
                {
                    Sql = Sql + " and batchcode in('" + comselectbarcode.Text + "')";
                }
                Sql = Sql + " order by cast(vcode as float) asc";
                CommonClass.Ds = CommonClass._Dbtask.ExecuteQuery(Sql);

                TQtyIn = 0;
                TQtyout = 0;
                TBalanceQty = 0;
                gridmain.Rows.Clear();
                SelectedVtypeFU();
                for (int i = 0; i < CommonClass.Ds.Tables[0].Rows.Count; i++)
                {
                    Slno = (i + 1).ToString();
                    Vtype = CheckVoucherType(gridmain, i);
                    TCode = CommonClass.Ds.Tables[0].Rows[i]["vcode"].ToString();
                    MainAccount = CommonClass.Ds.Tables[0].Rows[i]["ledcode"].ToString();
                    if (MainAccount == "")
                        MainAccount = "0";
                    if (Vtype == "OS" || Vtype == "PI" || Vtype == "MR" || Vtype == "SR" || Vtype == "IRECEIPT" || Vtype == "BMR" || Vtype == "FREEPRE")
                    {
                        if (SelectedVtype(Vtype))
                        {
                            CommonClass.Ds1 = CommonClass._Dbtask.ExecuteQuery("select * from tbltransactionreceipt where recpttype='" + Vtype + "' and reptcode='" + TCode + "' and ledcodedr='"+MainAccount+"'");
                            for (int k = 0; k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                            {
                                Party = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["tename"]);
                                PartyCode = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["ledcodecr"]);
                                if (SelectedLedger(Party))
                                {
                                    Vdate = Convert.ToDateTime(CommonClass.Ds1.Tables[0].Rows[k]["recptdate"]);
                                  //  Party = CommonClass._Ledger.GetspecifField("lname", PartyCode);
                                    Vno = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["vno"]);
                                    QtyIn = TempQty;
                                    Qtyout = 0;
                                    TQtyIn = TQtyIn + TempQty;
                                    Count = gridmain.Rows.Add(1);
                                    gridmain.Rows[Count].Cells["clnslno"].Value = Slno;
                                    gridmain.Rows[Count].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Vtype);
                                    gridmain.Rows[Count].Cells["clnvtype"].Tag = MainAccount;
                                    gridmain.Rows[Count].Cells["clnvno"].Value = Vno;
                                    gridmain.Rows[Count].Cells["clnvno"].Tag = TCode;
                                    gridmain.Rows[Count].Cells["clndate"].Value = Vdate;
                                    gridmain.Rows[Count].Cells["clnqtyin"].Value = QtyIn;
                                    gridmain.Rows[Count].Cells["clnqtyout"].Value = Qtyout;
                                    gridmain.Rows[Count].Cells["clnparty"].Value = Party;
                                }
                            }
                           
                        }
                    }
                    else if (Vtype == "SI" || Vtype == "DN" || Vtype == "PR" || Vtype == "IISUE" || Vtype == "SH" || Vtype == "DNR" || Vtype == "DMG" || Vtype == "BMI" || Vtype == "FREEISS")
                    {
                        if (SelectedVtype(Vtype))
                        {
                            CommonClass.Ds1 = CommonClass._Dbtask.ExecuteQuery("select * from tblbusinessissue where issuetype='" + Vtype + "' and issuecode='" + TCode + "' and ledcodecr='"+MainAccount+"'");
                            for (int k = 0; k < CommonClass.Ds1.Tables[0].Rows.Count; k++)
                            {
                                Party = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["tename"]);
                                PartyCode = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["ledcodedr"]);
                                if (SelectedLedger(Party))
                                {
                                    Vdate = Convert.ToDateTime(CommonClass.Ds1.Tables[0].Rows[k]["issuedate"]);
                                    Vno = CommonClass._Dbtask.znllString(CommonClass.Ds1.Tables[0].Rows[k]["vno"]);
                                    QtyIn = 0;
                                    Qtyout = TempQty;
                                    TQtyout = TQtyout + TempQty;

                                    Count = gridmain.Rows.Add(1);
                                    gridmain.Rows[Count].Cells["clnslno"].Value = Slno;
                                    gridmain.Rows[Count].Cells["clnvtype"].Value = CommonClass._Nextg.VtypeDescription(Vtype);
                                    gridmain.Rows[Count].Cells["clnvtype"].Tag = MainAccount;
                                    gridmain.Rows[Count].Cells["clnvno"].Value = Vno;
                                    gridmain.Rows[Count].Cells["clnvno"].Tag = TCode;
                                    gridmain.Rows[Count].Cells["clndate"].Value = Vdate;
                                    gridmain.Rows[Count].Cells["clnqtyin"].Value = QtyIn;
                                    gridmain.Rows[Count].Cells["clnqtyout"].Value = Qtyout;
                                    gridmain.Rows[Count].Cells["clnparty"].Value = Party;
                                }
                            }
                        }
                    }
                }
                txttqtyin.Text = TQtyIn.ToString();
                txttqtyout.Text = TQtyout.ToString();
                txttbalance.Text = (TQtyIn - TQtyout).ToString();
            }
        }

        public void Clear()
        {
            Fillcombo();
            txtitem.Text = "";
            comselectbarcode.Items.Clear();
            ChangeLanguage();
        }

        public void Fillcombo()
        {
            CommonClass._Ledger.FillComboSupplierandCustomer(comledger);
            comvtype.SelectedIndex = 0;
           // comvtype.SelectedIndex = 0;
        }

        private void Frmstockhistory_Load(object sender, EventArgs e)
        {
            Clear();
            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.PanelBasedConversion(pnltop);
                CommonClass._Language.PanelBasedConversion(panel1);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.GridHeaderConversion(gridmain);
            }
        }
        public void ListBarcode(string Itemid)
        {
            CommonClass._Dbtask.fillDatainCombowithQuery(comselectbarcode, "bid", "bcode", "tblbatch", "select * from tblbatch where itemid='" + Itemid + "'");
        }

        public void RowClick(string Value, int KeyValue)
        {
            try
            {
               CommonClass._Ingrid.RowUpDownSelectinTexttbox(KeyValue, uscGridshow1.GridProductShow, SeleRow, uscGridshow1);
               uscGridshow1.lblstock.Text = CommonClass._Dbtask.SetintoDecimalpointStock(CommonClass._Ingrid.Stock);
                if (KeyValue == 13)
                {
                    SeleRow = uscGridshow1.GridProductShow.SelectedRows[0].Index;
                    string Itemid = uscGridshow1.GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                    string ItemName = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                    string ItemCode = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
                    txtitem.Text = ItemName;
                    txtitem.Text = ItemCode;
                    txtitem.Tag = Itemid;
                    uscGridshow1.Visible = false;
                    ListBarcode(Itemid);
                }
            }
            catch
            {
            }
        }

        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                if (Clssettings.Sbatch == true)
                {
                    CommonClass._Ingrid.BatchGridShow(uscGridshow1, WhereCondition, uscGridshow1.GridProductShow, "0",true,true,"");
                }
                else
                {

                    CommonClass._Ingrid.ProductGridShowFixed(uscGridshow1, txtitem.Text, uscGridshow1.GridProductShow, "0");
                }


                if (uscGridshow1.Visible == false)
                {
                    uscGridshow1.Visible = true;
                }
            }
            catch
            {
            }
        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            temp = txtitem.Text;
            if (IsEnter == true)
            {
                ProductGridShow(" where itemCode Like N'%" + temp + "%' OR itemName Like N'%" + temp + "%'");
            }
        }

        private void txtitem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            RowClick(txtitem.Text, e.KeyValue);
        }

        private void txtitem_Enter(object sender, EventArgs e)
        {
            IsEnter = true;
        }

        private void gridmain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RowIndex=gridmain.CurrentCell.RowIndex;
            Columnindex=gridmain.CurrentCell.ColumnIndex;
            SelectedVtypeStr=CommonClass._Dbtask.znllString(gridmain.Rows[RowIndex].Cells["clnvtype"].Value);
            
            if(SelectedVtypeStr!="")
            {
                SelectedVtypeStr=SelectedVtypeStr.ToUpper();
                if (SelectedVtypeStr == "SALES")
                {
                    Vcode = gridmain.Rows[RowIndex].Cells["clnvno"].Tag.ToString();
                    Vno = gridmain.Rows[RowIndex].Cells["clnvno"].Value.ToString();
                    MainAccount = gridmain.Rows[RowIndex].Cells["clnvtype"].Tag.ToString();

                   
                    frmsalesinvoice _Sales = new frmsalesinvoice();
                    _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";

                    FrmReport.ClickCode = Vcode;
                    _Sales.txtvno.Text = Vno;
                    FrmReport.MainAccount = MainAccount;


                    _Sales.Isinotherwindow = true;
                    _Sales.Vtype = "SI";
                    _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    _Sales.Location = new Point(0, 0);
                    _Sales.MdiParent = this.ParentForm;
                    _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                    _Sales.Show();
                }

                if (SelectedVtypeStr == "SALES RETURN")
                {
                    Vcode = gridmain.Rows[RowIndex].Cells["clnvno"].Tag.ToString();
                    Vno = gridmain.Rows[RowIndex].Cells["clnvno"].Value.ToString();
                    MainAccount = gridmain.Rows[RowIndex].Cells["clnvtype"].Tag.ToString();


                    frmsalesinvoice _Sales = new frmsalesinvoice();
                    _Sales.Heading = "Sales return";

                    FrmReport.ClickCode = Vcode;
                    _Sales.txtvno.Text = Vno;
                    FrmReport.MainAccount = MainAccount;


                    _Sales.Isinotherwindow = true;
                    _Sales.Vtype = "SR";
                    _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    _Sales.Location = new Point(0, 0);
                    _Sales.MdiParent = this.ParentForm;
                    _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                    _Sales.Show();
                }

                if (SelectedVtypeStr == "DN")
                {
                    Vcode = gridmain.Rows[RowIndex].Cells["clnvno"].Tag.ToString();
                    Vno = gridmain.Rows[RowIndex].Cells["clnvno"].Value.ToString();
                    MainAccount = gridmain.Rows[RowIndex].Cells["clnvtype"].Tag.ToString();


                    frmsalesinvoice _Sales = new frmsalesinvoice();
                    _Sales.Heading = "Delivery Note";

                    FrmReport.ClickCode = Vcode;
                    _Sales.txtvno.Text = Vno;
                    FrmReport.MainAccount = MainAccount;


                    _Sales.Isinotherwindow = true;
                    _Sales.Vtype = "DN";
                    _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    _Sales.Location = new Point(0, 0);
                    _Sales.MdiParent = this.ParentForm;
                    _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                    _Sales.Show();
                }

                if (SelectedVtypeStr == "PURCHASE")
                {
                    Vcode = gridmain.Rows[RowIndex].Cells["clnvno"].Tag.ToString();
                    Vno = gridmain.Rows[RowIndex].Cells["clnvno"].Value.ToString();
                    MainAccount = gridmain.Rows[RowIndex].Cells["clnvtype"].Tag.ToString();

                    Frmpurchase _Purchase = new Frmpurchase();
                    _Purchase.Vtype = "PI";
                    FrmReport.ClickCode = Vcode;
                    FrmReport.MainAccount = MainAccount;

                    _Purchase.Isinotherwindow = true;
                    _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
                    _Purchase.Isinotherwindow = true;
                    _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    _Purchase.Location = new Point(0, 0);
                    _Purchase.MdiParent = this.ParentForm;
                    _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                    _Purchase.Show();
                }

                if (SelectedVtypeStr == "PURCHASE RETURN")
                {
                    Vcode = gridmain.Rows[RowIndex].Cells["clnvno"].Tag.ToString();
                    Vno = gridmain.Rows[RowIndex].Cells["clnvno"].Value.ToString();
                    MainAccount = gridmain.Rows[RowIndex].Cells["clnvtype"].Tag.ToString();

                    Frmpurchase _Purchase = new Frmpurchase();
                    _Purchase.Vtype = "PR";
                    FrmReport.ClickCode = Vcode;
                    FrmReport.MainAccount = MainAccount;

                    _Purchase.Isinotherwindow = true;
                    _Purchase.Heading = "Purchase return";
                    _Purchase.Isinotherwindow = true;
                    _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    _Purchase.Location = new Point(0, 0);
                    _Purchase.MdiParent = this.ParentForm;
                    _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                    _Purchase.Show();
                }
            }
        }

        public void AllClick(Control Cnt, CheckBox Chk)
        {
            if (Chk.Checked == true)
            {
                Cnt.Enabled = false;
            }
            else
            {
                Cnt.Enabled = true;
            }
        }

        private void chkallbarcode_CheckedChanged(object sender, EventArgs e)
        {
            AllClick(comselectbarcode, chkallbarcode);
        }

        private void chkallvouchertype_CheckedChanged(object sender, EventArgs e)
        {
            AllClick(comvtype, chkallvouchertype);
        }

        private void chkallledger_CheckedChanged(object sender, EventArgs e)
        {
            AllClick(comledger,chkallledger);
        }

        private void comselectbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string Bcode = comselectbarcode.Text;
                string Itemid =CommonClass._Batch.GetSpecificFieldofBatchBaseonitemid(Bcode);
                string ItemName = CommonClass._Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                string ItemCode = CommonClass._Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
                IsEnter = false;
                txtitem.Text = ItemCode;
                txtitem.Tag = Itemid;
            }
        }

        private void Frmstockhistory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void gridmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showprinting();
        }
        public void Showprinting()
        {
            printPreviewDialog1.Document = printDocument1;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            //  dlg.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
        public void Exporttoexcel()
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
                    cols = gridmain.Columns.Count;
                    wr.Write("Company Name\n\n\n");


                    wr.Write("Stock Book" + "\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(gridmain.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (gridmain.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (gridmain.Rows[i].Cells[j].Value != null)
                            {
                                gridmain.Rows[i].Cells[j].Value = gridmain.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                gridmain.Rows[i].Cells[j].Value = gridmain.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(gridmain.Rows[i].Cells[j].Value + "\t");
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
        private void cmdexcel_Click(object sender, EventArgs e)
        {
            Exporttoexcel();
            RichTextBox Rch = new RichTextBox();
        }

        private void Frmstockhistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

    }
}
