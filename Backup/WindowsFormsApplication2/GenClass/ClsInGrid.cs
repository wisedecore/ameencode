using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClsInGrid
    {
        string temp;
        public  double NetTottal;
        public  double NetQty;
        public  string cateGoryId;
        int Slno;
        public bool opbatch = false;
        int selectedRow;
        string TempItemid;
        int TSelectedRow;

        public static string WGmitemcode = "";

        public static string WGmitemname = "";
        public static string WGmsrate = "";
        public static string WGmrack = "";
        public static string WGmmrp = "";
        public static string WGmbcode = "";
        public static string WGmprate = "";

        public static string stocksetting = "-1'";
        Clscolor _color = new Clscolor();
        clsitemCategory _category = new clsitemCategory();
        DBTask _Dbtask = new DBTask();
        ClsItemMaster _ItemMaster = new ClsItemMaster();
        Clsbatch _Batch = new Clsbatch();
        DataSet Ds;
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsInventory _Inventory = new ClsInventory();
        NextGFuntion _Nextg = new NextGFuntion();
        UscGridshow _Uscgridshow = new UscGridshow();
        public double Stock;
        public void ControleSettEnter(Control Cnt, DataGridView gridmain)
        {
            Rectangle tempRect = gridmain.GetCellDisplayRectangle(gridmain.CurrentCell.ColumnIndex, gridmain.CurrentCell.RowIndex, false);
            Cnt.Height = tempRect.Height;
            Cnt.Width = tempRect.Width;
            Cnt.Location = tempRect.Location;
            Cnt.Visible = true;
            Cnt.Focus();
        }
        public void  FocusStartingRow(DataGridView Gridmain,string FRow)
        {
           // int temp = Gridmain.Rows.Count - 2;
           //Gridmain.Rows[temp].Cells[FRow].Selected=true;  
           // Gridmain.CurrentCell = Gridmain.Rows[temp].Cells[FRow];  
        }
        public double CellEnterCalculationPart(double Qty, double Rate)
        {
                NetTottal = Qty * Rate; /* For Cell Net Amount*/
                return NetTottal;
            
        }
        public void TottalAmountCalculate(DataGridView gridmain, int Slno, TextBox txttnetamount, TextBox txttqty)
        {
            Slno = Slno + 1; /* For SlNo*/
            NetTottal = 0;
            NetQty = 0;
            for (int i = 0; i < gridmain.Rows.Count; i++)  /* For Row NetAmount*/
            {
                if (gridmain.Rows[i].Cells["clnnettamount"].Value != null)
                {
                    NetTottal = NetTottal + Convert.ToDouble(gridmain.Rows[i].Cells["clnnettamount"].Value);
                    NetQty = NetQty + Convert.ToDouble(gridmain.Rows[i].Cells["clnqty"].Value);
                }
            }
            txttnetamount.Text = Convert.ToString(NetTottal);
            txttqty.Text = Convert.ToString(NetQty);

        }
        public void RowUpDownSelectDress(int KeyValue, DataGridView SubGridview, int selectedRow, UserControl Usercontrol, DataGridView Gridmain)
        {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    selectedRow = SubGridview.SelectedRows[0].Index;
                    int gridmainSelect = Gridmain.CurrentCell.RowIndex;
                    if (Usercontrol.Visible == true)
                    {
                        if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                SubGridview.Rows[selectedRow + 1].Selected = true;
                                SubGridview.Rows[selectedRow].Selected = false;

                                SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[1];
                            }
                        }
                        if (KeyValue == 38 && selectedRow != 0)
                        {
                            Gridmain.Rows[gridmainSelect + 1].Selected = true;
                            SubGridview.Rows[selectedRow - 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[1];
                        }
                        //if (SubGridview.Columns.Contains("ItemId"))
                        //    GetstockinGrid(SubGridview, "0");
                    }
                }
            }
            catch
            {
            }
        }
        public void drssmodel(UserControl Usc, string WhereCondition, DataGridView GridProductShow)
        {

            WhereCondition = WhereCondition;
            Ds = _category.showcategoryy(WhereCondition);
            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];

            GridProductShow.Columns["model"].Width = 200;


            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                //GridProductShow.Columns["alias name"].Width = 200;
                if (ColumnName == "model")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }

            }

            Usc.Visible = true;
        }

        public void showcolor(UserControl Usc, string WhereCondition, DataGridView GridProductShow)
        {

            WhereCondition = WhereCondition;
            Ds = _color.showcolorss(WhereCondition);
            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];

            GridProductShow.Columns["Color"].Width = 200;


            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                //GridProductShow.Columns["alias name"].Width = 200;
                if (ColumnName == "color")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }

            }

            Usc.Visible = true;
        }
        public void DRESSshow(UserControl Usc, string WhereCondition, DataGridView GridProductShow)
        {

            WhereCondition = WhereCondition;
            Ds = _ItemMaster.dresss(WhereCondition);
            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];
            /////*Size Defined*/
            GridProductShow.Columns["material"].Width = 200;
            //GridProductShow.Columns["alias name"].Width = 200;
            /////*Visible*/

            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                //GridProductShow.Columns["alias name"].Width = 200;
                if (ColumnName == "material")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }

            }

            /////***********************For Stock Calculation*************************/
            ////GetstockinGrid(GridProductShow, Dcode);

            Usc.Visible = true;
        }
        public void RowValidation(DataGridView gridmain, int rowindex)
        {
            try
            {
                if (gridmain.Rows[rowindex].Cells["clnitemname"].Tag == null || Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnnettamount"].Value) == Convert.ToDouble(0))
                {
                    gridmain.Rows[rowindex].Tag = -1;
                }
                else
                {
                    gridmain.Rows[rowindex].Tag = 1;
                    gridmain.Rows[rowindex].DefaultCellStyle.BackColor = default(Color);
                }
            }
            catch
            {
            }
        }
        public void LedgerGridShow(UserControl Usc, string WhereCondition, DataGridView GridProductShow, string Dcode,int CategoryMode)
        {
            if (CategoryMode == 0)/*For All Ledger*/
                WhereCondition = WhereCondition;
            else if (CategoryMode == 1)/*For All Customer and Supplier*/
                WhereCondition = WhereCondition + " and agroupid in ( "+ CommonClass._AccountGroup.ShowSupplierAndCustomerAccount("") +" )";
           else if (CategoryMode == 0)/*For All Customer*/
                WhereCondition = WhereCondition+ "  and agroupid in ("+CommonClass._AccountGroup.ShowCustomerAccount("")+")";
           else if (CategoryMode == 0)/*For All Supplier*/
                WhereCondition = WhereCondition + " and agroupid in (" + CommonClass._AccountGroup.ShowSupplierAccount("") + ")";
            else if (CategoryMode == 3)/*For All Cash and Bank*/
                WhereCondition = WhereCondition + " and agroupid in (" + CommonClass._AccountGroup.ShowCashandBank("") + ")";

          

           Ds = _AccountLedger.ShowLedgerInGrid(WhereCondition);
           GridProductShow.Columns.Clear();
           GridProductShow.DataSource = Ds.Tables[0];
            /////*Size Defined*/
            GridProductShow.Columns["name"].Width = 200;
            GridProductShow.Columns["alias name"].Width = 200;
            /////*Visible*/

            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                GridProductShow.Columns["alias name"].Width = 200;
                if (ColumnName == "name" || ColumnName == "alias name")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }

            }

            /////***********************For Stock Calculation*************************/
            ////GetstockinGrid(GridProductShow, Dcode);

            Usc.Visible = true;
        }


        public void BatchGridShow(UserControl Usc, string WhereCondition, DataGridView GridProductShow, string Dcode,bool InclPrate,bool IsinPurchase,string ItemCategoryid)
         
        {
            if(IsinPurchase==true)
            Ds = _ItemMaster.ShowItemsProductNameBaseonBarcode(WhereCondition,"Left",ItemCategoryid);
            else
                Ds = _ItemMaster.ShowItemsProductNameBaseonBarcode(WhereCondition, "Inner", ItemCategoryid);

            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];
            /*Size Defined*/
            GridProductShow.Columns["itemcode"].Width = Convert.ToInt16(WGmitemcode);
            GridProductShow.Columns["itemname"].Width = Convert.ToInt16(WGmitemname);
            GridProductShow.Columns["llang"].Width = Convert.ToInt16(WGmitemname);
            if( GridProductShow.Columns["srate"].Visible==true)
                GridProductShow.Columns["srate"].Width = Convert.ToInt16(WGmsrate);

            if (GridProductShow.Columns["mrp"].Visible == true)
                GridProductShow.Columns["mrp"].Width = Convert.ToInt16(WGmmrp);

            if (GridProductShow.Columns["bcode"].Visible == true)
            {
                GridProductShow.Columns["bcode"].Width = Convert.ToInt16(WGmbcode);
                GridProductShow.Columns["ex Date"].Width = Convert.ToInt16(WGmbcode);
            }
            if (GridProductShow.Columns["rack"].Visible == true)
                GridProductShow.Columns["rack"].Width = Convert.ToInt16(WGmrack);

           // if (GridProductShow.Columns["prate"].Visible == true)

            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("207")) == "1")
            {
                GridProductShow.Columns["prate"].Width = Convert.ToInt16(WGmprate);

            }
                /*Visible*/

            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();

                if (InclPrate == true)
                {
                    if (ColumnName == "itemcode" || ColumnName == "llang" || ColumnName == "itemname" || ColumnName == "srate" || ColumnName == "bcode" || ColumnName == "prate")
                    {
                        GridProductShow.Columns[ColumnName].Visible = true;
                    }
                    else
                    {
                        GridProductShow.Columns[ColumnName].Visible = false;
                    }
                }
                else
                {
                    if ( ColumnName == "llang" || ColumnName == "itemcode" || ColumnName == "itemname" || ColumnName == "srate" || ColumnName == "bcode" || ColumnName == "prate")
                    {
                        GridProductShow.Columns[ColumnName].Visible = true;
                    }
                    else
                    {
                        GridProductShow.Columns[ColumnName].Visible = false;
                    }
                }

            }

            /***********************For Stock Calculation*************************/
            //GetstockinGrid(GridProductShow, Dcode);

            Usc.Visible = true;
        }
        public void RowValidationOP(DataGridView gridmain)
        {
            try
            {
                int rowindex;
                for (int i = 0; i < gridmain.Rows.Count; i++)
                {
                    rowindex = i;
                    if (gridmain.Rows[rowindex].Cells["clnitems"].Tag == null || Convert.ToDouble(gridmain.Rows[rowindex].Cells["clnamount"].Value) == Convert.ToDouble(0))
                    {
                        gridmain.Rows[rowindex].Tag = -1;
                    }
                    else
                    {
                        gridmain.Rows[rowindex].Tag = 1;
                        gridmain.Rows[rowindex].DefaultCellStyle.BackColor = default(Color);
                    }
                }
            }
            catch
            {
            }
        }
        public void AccountsGridShow(DataGridView GridProductShow, string Text, UserControl Usc,int Mode)
        {
            if (Mode == 0)/*For Customer and Supplier*/
            {
                temp = CommonClass._AccountGroup.ShowSupplierAndCustomerAccount("");
                Ds = CommonClass._Ledger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + Text + "%'  and Agroupid in(" + temp + ") ");
            }
            else if (Mode == 1)/*For Customer Only*/
            {
                temp = CommonClass._AccountGroup.ShowCustomerAccount("");
                Ds = CommonClass._Ledger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + Text + "%'  and Agroupid in(" + temp + ") ");
            }
            else/*For Supplier Only*/
            {
                temp = CommonClass._AccountGroup.ShowSupplierAccount("");
                Ds = CommonClass._Ledger.ShowLedgerNoteincludeDeactive(" where lname like N'%" + Text + "%'  and Agroupid in(" + temp + ") ");
            }

            GridProductShow.DataSource = Ds.Tables[0];
            Usc.Visible = true;
            /*Visible*/
            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                if (ColumnName == "lname")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                    GridProductShow.Columns[ColumnName].Width = 360;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }
            }
        }

        public void GridupandDowninLedger(UserControl Usc, DataGridView GridProductShow, int KeyValue, TextBox txtsupplier)
        {
            string Itemid;
            if (Usc.Visible == true&&GridProductShow.SelectedRows.Count >0)
            {
                selectedRow = GridProductShow.SelectedRows[0].Index;
                if (KeyValue == 40 && GridProductShow.Rows[selectedRow].Cells[0].Value != null)
                {

                    if (GridProductShow.Rows[selectedRow + 1].Cells[0].Value != null)
                    {
                        GridProductShow.Rows[selectedRow + 1].Selected = true;
                        GridProductShow.Rows[selectedRow].Selected = false;
                        GridProductShow.CurrentCell = GridProductShow.SelectedRows[0].Cells["lname"];
                    }
                }

                if (KeyValue == 38 && selectedRow != 0)
                {
                    GridProductShow.Rows[selectedRow - 1].Selected = true;
                    GridProductShow.Rows[selectedRow].Selected = false;
                    GridProductShow.CurrentCell = GridProductShow.SelectedRows[0].Cells["lname"];

                }
                if (KeyValue == 13)
                {
                    if (GridProductShow.Rows[selectedRow].Cells["lid"].Value != null)
                    {
                        Itemid = GridProductShow.Rows[selectedRow].Cells["lid"].Value.ToString();
                        string ItemName;
                        ItemName = GridProductShow.Rows[selectedRow].Cells["lname"].Value.ToString();
                        txtsupplier.Tag = Itemid;
                        txtsupplier.Text = ItemName;
                        Usc.Visible = false;
                    }
                }
            }
        }

        public void ProductGridShowFixed(UserControl Usc, string PassingString, DataGridView GridProductShow,string Dcode)
        {
            if (_Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {
                Ds = _ItemMaster.ShowItemsProductName(PassingString, 1);
            }
            else
            {
                Ds = _ItemMaster.ShowItemsProductName(PassingString,0);
            }
            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];
            /*Size Defined*/
            /*Size Defined*/
            GridProductShow.Columns["itemcode"].Width = Convert.ToInt16(WGmitemcode);
            GridProductShow.Columns["itemname"].Width = Convert.ToInt16(WGmitemname);
            //if (GridProductShow.Columns[0].Name.ToString().ToLower() == "srate")
            //{
            GridProductShow.Columns["srate"].Width = Convert.ToInt16(WGmsrate);
             //}

            //if (GridProductShow.Columns[0].Name.ToString().ToLower() == "salerate")
            //{
                //GridProductShow.Columns["salerate"].Width = Convert.ToInt16(WGmsrate);
            //}
            GridProductShow.Columns["mrp"].Width = Convert.ToInt16(WGmmrp);
            GridProductShow.Columns["rack"].Width = Convert.ToInt16(WGmrack);
            /*Visible*/
            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                if (ColumnName == "itemcode" || ColumnName == "itemname" || ColumnName == "llang" || ColumnName == "srate" || ColumnName == "mrp" || ColumnName == "crate" || ColumnName == "bcode" || ColumnName == "salerate" || ColumnName == "Barcode")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }
            }

            /***********************For Stock Calculation*************************/
            if (GridProductShow.Rows.Count > 0)
                GridProductShow.CurrentCell = GridProductShow.Rows[0].Cells[2];
            GetstockinGrid(GridProductShow,Dcode);
            Usc.Visible = true;
           }

        public void ProductGridShowFixedSecondary(UserControl Usc, string PassingString, DataGridView GridProductShow, string Dcode)
        {
            Ds = _ItemMaster.ShowItemsProductName(PassingString, 2);
            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];
            /*Size Defined*/
            GridProductShow.Columns["itemcode"].Width = 200;
            GridProductShow.Columns["itemname"].Width = 200;
            /*Visible*/
            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();
                if (ColumnName == "itemcode" || ColumnName == "itemname" || ColumnName == "srate" || ColumnName == "mrp" || ColumnName == "rack")
                {
                    GridProductShow.Columns[ColumnName].Visible = true;
                }
                else
                {
                    GridProductShow.Columns[ColumnName].Visible = false;
                }
            }

            /***********************For Stock Calculation*************************/
            GetstockinGrid(GridProductShow, Dcode);
            Usc.Visible = true;
        }
        public void AccontGridShow(string WhereCondition, DataGridView GridProductShow)
        {
            Ds = _AccountLedger.ShowLedgerNoteincludeDeactive(WhereCondition);

            GridProductShow.Rows.Clear();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                GridProductShow.Rows.Add(1);
                string Lid = Ds.Tables[0].Rows[i]["Lid"].ToString();
                GridProductShow.Rows[i].Cells["clnlname"].Tag = Lid;
                GridProductShow.Rows[i].Cells["clnlname"].Value = Ds.Tables[0].Rows[i]["lname"];
                GridProductShow.Rows[i].Cells["clnalias"].Value = Ds.Tables[0].Rows[i]["laliasname"];             
                GridProductShow.Rows[i].Cells["Clnaddress"].Value = Ds.Tables[0].Rows[i]["address"];
                GridProductShow.Rows[i].Cells["Clnmobile"].Value = Ds.Tables[0].Rows[i]["mobile"];
               
            }
            GridProductShow.Visible = true;
        }

       

        public void PreviewKeyDownInGrid(int KeyValue, UserControl UserControl, DataGridView SubGridview, DataGridView Gridmain, bool IsEnter,  string TempText, long Itemid, int Rowindex, int Columnindex,string Clnprateorsrate,string clnsubwindowcolumn,string Stockarea)
        {
            if (KeyValue == 27)
            {
                if (UserControl.Visible == true)
                {
                    UserControl.Visible = false;
                }

            }

            if (KeyValue == 13)
            {
                try
                {
                    if (SubGridview.SelectedRows.Count == 0)
                    {
                        //FrmItemMasterSimple _ItemSimple = new FrmItemMasterSimple();
                        //_ItemSimple.ItemNameTemp = TempText;
                        //_ItemSimple.ShowDialog();
                    }
                    else
                    {

                        if (SubGridview.SelectedRows.Count != 0)
                        {
                            if (IsEnter == true)
                            {
                                selectedRow = SubGridview.SelectedRows[0].Index;
                               
                                if(opbatch==false)
                                {
                                ProductIntoMainGrid(Gridmain, SubGridview, selectedRow, Rowindex, Clnprateorsrate, clnsubwindowcolumn);
                                }
                                if (opbatch == true)
                                {
                                    ProductIntoMainGridbatch(Gridmain, SubGridview, selectedRow, Rowindex, Clnprateorsrate, clnsubwindowcolumn);
                                    opbatch = false;
                                
                                }
                                UserControl.Visible = false;
                            }
                            IsEnter = false;
                        }
                    }
                }
                catch
                {
                }
            }
            try
            {
                RowUpDownSelect(KeyValue, SubGridview, selectedRow, UserControl, Gridmain);

            }
            catch
            {
            }
        }

        public void RowUpDownSelectWithoutUser(int KeyValue, DataGridView SubGridview)
        {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    selectedRow = SubGridview.SelectedRows[0].Index;
                    
                        if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                SubGridview.Rows[selectedRow + 1].Selected = true;
                                SubGridview.Rows[selectedRow].Selected = false;
                                SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];
                            }
                        }
                        if (KeyValue == 38 && selectedRow != 0)
                        {
                            SubGridview.Rows[selectedRow - 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];
                        }
                        if (SubGridview.Columns.Contains("ItemId"))
                        {
                            if (stocksetting == "1")
                            {
                                GetstockinGrid(SubGridview, "0");
                            }
                        }
                    
                }
            }
            catch
            {
            }
        }

        public void RowUpDownSelect(int KeyValue, DataGridView SubGridview, int selectedRow,UserControl Usercontrol,DataGridView Gridmain)
            {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    selectedRow = SubGridview.SelectedRows[0].Index;
                    int gridmainSelect = Gridmain.CurrentCell.RowIndex;
                    if (Usercontrol.Visible == true)
                    {
                        if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                SubGridview.Rows[selectedRow + 1].Selected = true;
                                SubGridview.Rows[selectedRow].Selected = false;

                                SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];
                            }
                        }
                        if (KeyValue == 38 && selectedRow != 0)
                        {
                            Gridmain.Rows[gridmainSelect + 1].Selected = true;
                            SubGridview.Rows[selectedRow - 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];
                        }
                        if (SubGridview.Columns.Contains("ItemId"))
                        {
                            if (stocksetting=="1" )
                            {
                            GetstockinGrid(SubGridview, "0");
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public void RowUpDownSelectWithoutusercontrole(int KeyValue, DataGridView SubGridview, int selectedRow, DataGridView Gridmain)
        {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    selectedRow = SubGridview.SelectedRows[0].Index;
                    int gridmainSelect = Gridmain.CurrentCell.RowIndex;
                    if (SubGridview.Visible == true)
                    {
                        if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                SubGridview.Rows[selectedRow + 1].Selected = true;
                                SubGridview.Rows[selectedRow].Selected = false;
                                SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[0];
                            }
                        }
                        if (KeyValue == 38 && selectedRow != 0)
                        {
                            Gridmain.Rows[gridmainSelect + 1].Selected = true;
                            SubGridview.Rows[selectedRow - 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[0];
                        }
                        if (SubGridview.Columns.Contains("ItemId"))
                            GetstockinGrid(SubGridview, "0");
                    }
                }
            }
            catch
            {
            }
        }

        public void KeyMoveinTextbox(DataGridView Gridlist, TextBox Txtitems, int KeyValue, bool IsEnter)
        {
            try
            {
                if (Gridlist.SelectedRows.Count > 0)
                {
                    selectedRow = Gridlist.SelectedRows[0].Index;

                    if (Gridlist.Visible == true)
                    {
                        if (KeyValue == 13 && Gridlist.Rows[selectedRow].Cells[0].Value != null)
                        {
                            IsEnter = true;
                            Txtitems.Text = Gridlist.Rows[selectedRow].Cells[0].Value.ToString();
                            Txtitems.Tag = Gridlist.Rows[selectedRow].Cells[0].Tag.ToString();
                            Gridlist.Visible = false;
                        }
                        if (KeyValue == 40 && Gridlist.Rows[selectedRow].Cells[0].Value != null)
                        {
                            if (Gridlist.Rows[selectedRow + 1].Cells[0].Value != null)
                            {
                                Gridlist.Rows[selectedRow + 1].Selected = true;
                                Gridlist.Rows[selectedRow].Selected = false;
                                Gridlist.CurrentCell = Gridlist.SelectedRows[0].Cells[0];
                            }
                        }

                        if (KeyValue == 38 && selectedRow != 0)
                        {
                            Gridlist.Rows[selectedRow - 1].Selected = true;
                            Gridlist.Rows[selectedRow].Selected = false;
                            Gridlist.CurrentCell = Gridlist.SelectedRows[0].Cells[0];
                        }
                    }
                }
            }
            catch
            {
            }
        }
        public void RowUpDownSelectinTexttbox(int KeyValue, DataGridView SubGridview, int selectedRow, UserControl Usercontrol)
        {
            if (SubGridview.SelectedRows.Count > 0)
            {
                selectedRow = SubGridview.SelectedRows[0].Index;
               // int gridmainSelect = Gridmain.CurrentCell.RowIndex;
                if (Usercontrol.Visible == true)
                {
                    if (KeyValue == 40 && SubGridview.Rows[selectedRow].Cells[0].Value != null)
                    {

                        if (SubGridview.Rows[selectedRow + 1].Cells[0].Value != null)
                        {
                            SubGridview.Rows[selectedRow + 1].Selected = true;
                            SubGridview.Rows[selectedRow].Selected = false;
                            SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];
                        }
                    }

                    if (KeyValue == 38 && selectedRow != 0)
                    {

                       // Gridmain.Rows[gridmainSelect + 1].Selected = true;
                        SubGridview.Rows[selectedRow - 1].Selected = true;
                        SubGridview.Rows[selectedRow].Selected = false;
                        SubGridview.CurrentCell = SubGridview.SelectedRows[0].Cells[2];

                    }

                }
            }
        }
        public void FocusinControl(Control Cntr)
        {
            Cntr.Focus();
            Cntr.Select();
        }
        public void GetstockinGrid(DataGridView SubGridview, string Stockarea)
        {
            try
            {
                if (SubGridview.SelectedRows.Count > 0)
                {
                    if (Clssettings.Sbatch == true)
                    {
                        if (SubGridview.Rows.Count >= TSelectedRow)
                        {
                            TSelectedRow = SubGridview.SelectedRows[0].Index;
                            
                            if (_Dbtask.znllString(SubGridview.Rows[TSelectedRow].Cells["itemid"].Value) != "" )
                            {
                                TSelectedRow = SubGridview.SelectedRows[0].Index;
                                TempItemid = SubGridview.Rows[TSelectedRow].Cells["itemid"].Value.ToString();
                                if (SubGridview.Columns["bcode"] != null)
                                {
                                    string Bcode = SubGridview.Rows[TSelectedRow].Cells["bcode"].Value.ToString();
                                    //DateTime Exdate = _Dbtask.ZnullDatetime(SubGridview.Rows[TSelectedRow].Cells["Exdate"].Value);
                                    
                                    if(stocksetting=="1")
                                    {
                                    
                                    Stock = Convert.ToDouble(_Inventory.GetStock(" where pcode='" + TempItemid + "'  and batchcode='" + Bcode + "' "));
                                    }
                                
                                
                                }
                                else
                                {


                                    if (stocksetting == "1")
                                    {
                                        Stock = Convert.ToDouble(_Inventory.GetStock(" where pcode='" + TempItemid + "' "));
                                    }
                                
                                }
                            }
                        }
                    }
                    else
                    {
                        if (SubGridview.Rows.Count >= TSelectedRow)
                        {
                            if (SubGridview.Rows[TSelectedRow].Cells["itemid"].Value != null)
                            {
                              TSelectedRow = SubGridview.SelectedRows[0].Index;
                                TempItemid = SubGridview.Rows[TSelectedRow].Cells["itemid"].Value.ToString();

                                if (stocksetting == "1")
                                {

                                    Stock = Convert.ToDouble(_Inventory.GetStock(" where pcode='" + TempItemid + "' and  dcode='" + Stockarea + "'"));

                                }
                                
                                }
                          }
                    }
                }
                else
                {
                    Stock = 0;
                }
            }
            catch
            {
            }
        }
        public void ProductGridShowLocationSett(UserControl UserControleName, int Left, int Top)
        {
            UserControleName.Left = Left;

            UserControleName.Top = Top + 10;
        }
        public void ProductGridShowLocationSettGrid(DataGridView GridProductShow, int Left, int Top)
        {
            GridProductShow.Left = Left;

            GridProductShow.Top = Top + 10;
        }


        public void ProductIntoMainGridTemp()
        {
            
        }
        public void BatchGridShowPURCHASE(UserControl Usc, string WhereCondition, DataGridView GridProductShow, string Dcode, bool InclPrate, bool IsinPurchase, string ItemCategoryid)
        {
            if (IsinPurchase == true)
                Ds = _ItemMaster.ShowItemsProductNameBaseonBarcode(WhereCondition, "Left", ItemCategoryid);
            else
                Ds = _ItemMaster.ShowItemsProductNameBaseonBarcodepurchase(WhereCondition, "Inner", ItemCategoryid);
            //Ds = _ItemMaster.ShowItemsProductNameBaseonBarcode(WhereCondition, "Inner", ItemCategoryid);

            GridProductShow.Columns.Clear();
            GridProductShow.DataSource = Ds.Tables[0];
            /*Size Defined*/
            GridProductShow.Columns["itemcode"].Width = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Gmitemcode"));
            GridProductShow.Columns["itemname"].Width = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Gmitemname"));


            GridProductShow.Columns["second"].Width = 200;
            //if (ClsItemMaster.PI == false)
            //{
            //   // GridProductShow.Columns["Unit"].Width = 100;
            //    GridProductShow.Columns["wrate"].Width = 80;

            //    //GridProductShow.Columns["second"].Visible = true;
            //   // GridProductShow.Columns["Unit"].Visible = true;
            //    GridProductShow.Columns["wrate"].Visible = true;
            //}

            if (GridProductShow.Columns["srate"].Visible == true)
                GridProductShow.Columns["srate"].Width = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Gmsrate"));

            //if (GridProductShow.Columns["Srate"].Visible == true)
            //  GridProductShow.Columns["Srate"].Width = Convert.ToInt32(CommonClass._Paramlist.GetParamvalue("Gmsrate"));


            if (GridProductShow.Columns["barcode"].Visible == true)
            {
                GridProductShow.Columns["barcode"].Width = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Gmbcode"));
            }

            if (GridProductShow.Columns["prate"].Visible == true)
                GridProductShow.Columns["prate"].Width = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Gmprate"));
            /*Visible*/

            for (int i = 0; i < GridProductShow.Columns.Count; i++)
            {
                string ColumnName = GridProductShow.Columns[i].Name.ToString().ToLower();

                if (InclPrate == true)
                {
                    if (ColumnName == "itemcode" || ColumnName == "itemname" || ColumnName == "Second" || ColumnName == "srate" || ColumnName == "mrp" || ColumnName == "bcode" || ColumnName == "rack" || ColumnName == "prate" || ColumnName == "Unit" || ColumnName == "Wrate")
                    {
                        GridProductShow.Columns[ColumnName].Visible = true;
                    }
                    else
                    {
                        GridProductShow.Columns[ColumnName].Visible = false;
                    }
                }
                else
                {
                    if (ColumnName == "itemcode" || ColumnName == "costrate" || ColumnName == "salerate" || ColumnName == "barcode" || ColumnName == "itemname" || ColumnName == "second" || ColumnName == "srate" || ColumnName == "mrp" || ColumnName == "bcode" || ColumnName == "rack" || ColumnName == "ex date" || ColumnName == "unit" || ColumnName == "wrate")
                    {
                        GridProductShow.Columns[ColumnName].Visible = true;
                    }
                    else
                    {
                        GridProductShow.Columns[ColumnName].Visible = false;
                    }
                }

            }

            /***********************For Stock Calculation*************************/
            GetstockinGrid(GridProductShow, Dcode);

            Usc.Visible = true;
        }
        public void ProductIntoMainGrid(DataGridView gridmain, DataGridView GridProductShow, int selectedRow, int rowindex, string ClnpRateOrSrate, string ClnPrateSOrSrateS)
            {
            if (GridProductShow.Rows[selectedRow].Cells[0].Value != null && GridProductShow.Visible == true)
            {
                string Itemid; string TempBathcode;
                Itemid = GridProductShow.Rows[selectedRow].Cells["itemid"].Value.ToString();

                TextBox Txt1 = new TextBox();
                Txt1.Font = new System.Drawing.Font("Kerala", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Txt1.Text = CommonClass._Itemmaster.SpecificField(Itemid, "llang");
                //MOUSE
               // int NowselectedRow = new int();
               // ;
               // if (GridProductShow.Visible == true && GridProductShow.SelectedRows.Count > 0)
               // {
               //     NowselectedRow = GridProductShow.SelectedRows[0].Index;
               //     TempBathcode = GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
               // }
               //// rowindex = gridmain.CurrentCell.RowIndex;
               // string ClnItemCode = "";
               // string ClnItemName="";
               // ClnItemCode = CommonClass._Itemmaster.SpecificField(Itemid, "ITEMNAME").ToString();
               // gridmain.Rows[rowindex].Cells["clnbatch"].Value = GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                //MOUSE


                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = GridProductShow.Rows[selectedRow].Cells["itemname"].Value;

                if (gridmain.Columns.Contains("clnloc"))
                {
                    gridmain.Rows[rowindex].Cells["clnloc"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "llang");
                }
                gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = GridProductShow.Rows[selectedRow].Cells["itemcode"].Value;
                gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = Itemid;
                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = GridProductShow.Rows[selectedRow].Cells["itemname"].Value;
                

                if ( CommonClass._settings.ReturnStatus("103")=="1")
                {
                    gridmain.Rows[rowindex].Cells["Clnbatch"].Value = GridProductShow.Rows[selectedRow].Cells["barcode"].Value;

                }
              //gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Value = GridProductShow.Rows[selectedRow].Cells["salerate"].Value;
              gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Value = GridProductShow.Rows[selectedRow].Cells[ClnPrateSOrSrateS].Value;
               if (gridmain.Columns.Contains("ClnMRP") && gridmain.Rows[rowindex].Cells["ClnMRP"].Visible==true) 
                gridmain.Rows[rowindex].Cells["ClnMRP"].Value = GridProductShow.Rows[selectedRow].Cells["mrp"].Value;

               //if (ClnpRateOrSrate == "Clnsrate")
               // {
               // gridmain.Rows[rowindex].Cells["Clnsrate"].Value = GridProductShow.Rows[selectedRow].Cells["srate"].Value;
               // }
                if (ClnpRateOrSrate == "Clnsrate")
                {
                    gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Value = GridProductShow.Rows[selectedRow].Cells["srate"].Value;

                    if (gridmain.Columns["clncost"] != null)
                    {
                        gridmain.Rows[rowindex].Cells["clncost"].Value = GridProductShow.Rows[selectedRow].Cells["Crate"].Value;
                    }

                    gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Tag = GridProductShow.Rows[selectedRow].Cells["incs"].Value;
                }
                if (ClnpRateOrSrate == "Clnprate")
                {
                    gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Value = GridProductShow.Rows[selectedRow].Cells["prate"].Value;
                    if (gridmain.Columns.Contains("clnsrate"))
                        gridmain.Rows[rowindex].Cells["clnsrate"].Value = GridProductShow.Rows[selectedRow].Cells["srate"].Value;
                    gridmain.Rows[rowindex].Cells[ClnpRateOrSrate].Tag = GridProductShow.Rows[selectedRow].Cells["incs"].Value;
                }
                if (gridmain.Columns.Contains("ClnMRP") && gridmain.Rows[rowindex].Cells["ClnMRP"].Visible == true) 
                gridmain.Rows[rowindex].Cells["ClnMRP"].Tag = GridProductShow.Rows[selectedRow].Cells["incp"].Value;
            }
        }
        public void ProductIntoMainGridbatch(DataGridView gridmain, DataGridView GridProductShow, int selectedRow, int rowindex, string ClnpRateOrSrate, string ClnPrateSOrSrateS)
        {
            if (GridProductShow.Rows[selectedRow].Cells[0].Value != null && GridProductShow.Visible == true)
            {
                string Itemid; string TempBathcode;
                Itemid = GridProductShow.Rows[selectedRow].Cells["itemid"].Value.ToString();

                TextBox Txt1 = new TextBox();
                Txt1.Font = new System.Drawing.Font("Kerala", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Txt1.Text = CommonClass._Itemmaster.SpecificField(Itemid, "llang");
                //MOUSE
                // int NowselectedRow = new int();
                // ;
                // if (GridProductShow.Visible == true && GridProductShow.SelectedRows.Count > 0)
                // {
                //     NowselectedRow = GridProductShow.SelectedRows[0].Index;
                //     TempBathcode = GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                // }
                //// rowindex = gridmain.CurrentCell.RowIndex;
                // string ClnItemCode = "";
                // string ClnItemName="";
                // ClnItemCode = CommonClass._Itemmaster.SpecificField(Itemid, "ITEMNAME").ToString();
                // gridmain.Rows[rowindex].Cells["clnbatch"].Value = GridProductShow.Rows[NowselectedRow].Cells["bcode"].Value.ToString();
                //MOUSE


                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = GridProductShow.Rows[selectedRow].Cells["itemname"].Value;

                if (gridmain.Columns.Contains("clnloc"))
                {
                    gridmain.Rows[rowindex].Cells["clnloc"].Value = CommonClass._Itemmaster.SpecificField(Itemid, "llang");
                }
                gridmain.Rows[rowindex].Cells["ClnItemCode"].Value = GridProductShow.Rows[selectedRow].Cells["itemcode"].Value;
                gridmain.Rows[rowindex].Cells["ClnItemName"].Tag = Itemid;
                gridmain.Rows[rowindex].Cells["ClnItemName"].Value = GridProductShow.Rows[selectedRow].Cells["itemname"].Value;

                gridmain.Rows[rowindex].Cells["Clnsrate"].Value = GridProductShow.Rows[selectedRow].Cells["srate"].Value;

                gridmain.Rows[rowindex].Cells["Clnrate"].Value =_Dbtask.znlldoubletoobject(  GridProductShow.Rows[selectedRow].Cells["prate"].Value);
                gridmain.Rows[rowindex].Cells["Clnbatch"].Value =_Dbtask.znllString( GridProductShow.Rows[selectedRow].Cells["barcode"].Value);
                if (gridmain.Columns.Contains("ClnMRP") && gridmain.Rows[rowindex].Cells["ClnMRP"].Visible == true)
                    gridmain.Rows[rowindex].Cells["ClnMRP"].Value = GridProductShow.Rows[selectedRow].Cells["mrp"].Value;
               
               
            }
        }

        public void CelleneterBackcolor(DataGridView gridmain, int Rowindex, int Columnindex)
        {
            gridmain.Rows[Rowindex].Cells[Columnindex].Style.BackColor = System.Drawing.Color. FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(87)))));
            gridmain.Rows[Rowindex].Cells[Columnindex].Style.ForeColor = System.Drawing.Color.White;
        }

        public void CellLeaveBackcolor(DataGridView gridmain, int Rowindex, int Columnindex)
        {
            gridmain.Rows[Rowindex].Cells[Columnindex].Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            gridmain.Rows[Rowindex].Cells[Columnindex].Style.ForeColor = System.Drawing.Color.Black;
        }

        public void TextBoxEnterBackcolor(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.Red;

            txt.Select(0, txt.Text.Length);
            txt.ForeColor = System.Drawing.Color.White;
        }

        public void TextBoxLeaveBackcolor(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.White;
        }

    }
}
