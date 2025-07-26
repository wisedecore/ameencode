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
    public partial class FrmSelectStockList : Form
    {
        public FrmSelectStockList()
        {
            InitializeComponent();
        }

        public string ItemClass;
        public DataSet Ds;
        DBTask _Dbtask=new DBTask();
        clsitemCategory _ItemCategory = new clsitemCategory();
        ClsItemMaster _Itemmaster = new ClsItemMaster();
        ClsDepot _Depot = new ClsDepot();
        ClsInGrid _Ingrid = new ClsInGrid();
        FrmReport _Report = new FrmReport();
        Clsselectreport _SelectReport = new Clsselectreport();
        string Reporttype;
        string ReporttypeSingle;
        string Depoin;
        string Itemid;
        public int selectedRow;
        public bool IsEnter;
        public string Temp;
        public int SeleRow;
        public int Count;
        string temp;
        /*For Settings*/
        public bool Sbatch;
        NextGFuntion _NextgFunction = new NextGFuntion();

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TreeViewConvertion(TreeMain);
                CommonClass._Language.GroupBoxConvertion(grpforselect);
                CommonClass._Language.GroupBoxConvertion(Grpgroup);
                CommonClass._Language.GroupBoxConvertion(Grpitembase);
                CommonClass._Language.GroupBoxConvertion(Grpselectstockleve);
                CommonClass._Language.GroupBoxConvertion(GrpStocklevel);
                CommonClass._Language.GroupBoxConvertion(Grpsupplierwise);
            }
        }
        public void Mnusettings()
        {
            /*Batch*/
          string  temp = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid=103");
            if (temp == "1")
            {
                Sbatch = true;
                TreeMain.Nodes[0].Nodes.Remove(TreeMain.Nodes[0].Nodes["Ndconsolidateitem"]);
                TreeMain.Nodes[0].Nodes.Remove(TreeMain.Nodes[1].Nodes["Ndvalueitem"]);
            }
            if (Sbatch == false)
            { 
                TreeMain.Nodes[0].Nodes.Remove(TreeMain.Nodes[0].Nodes["Ndconsolidatebatchwise"]);
                TreeMain.Nodes[0].Nodes.Remove(TreeMain.Nodes[1].Nodes["ndvaluebatchwise"]);
            }
        }
        public void treeview()
        {
            TreeNode[] tn = TreeMain.Nodes[1].Nodes.Find("ndvaluebatchwise", true);
            for (int i = 0; i < tn.Length; i++)
            {
                TreeMain.SelectedNode = tn[i];
                TreeMain.SelectedNode.BackColor = Color.Yellow;
            }
        }
        public void Clear()
        {
            _NextgFunction.ClearControles(this);
            
            _NextgFunction.SetControlesBehave(this);
            Mnusettings();
            grpforselect.Visible = false;
            ComDepot.Enabled = false;
            FilCombo();
            comfor.SelectedIndex = 0;
            ShowGridItemCategory();
            TreeMain.ExpandAll();
            Dtfrom.Value =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
            //TreeMain.SelectedNode = TreeMain.Nodes[0].FirstNode;
            TreeMain.SelectedNode = TreeMain.Nodes[1]; //this.treeView1.Nodes[0];
            //TreeMain.SelectedNode.Parent.Text == "Sales"
           // treeview();
            CommonClass._Gen.treeview(TreeMain, "ndvaluebatchwise",1);
            chkcategoryall.Checked = true;
            chkcategoryall.Checked = true;
            ChangeLanguage();

        }
        
       

        public void ShowGridItemCategory()
        {
            /*For ItemCategory*/

            datagriditemcategory.Rows.Clear();
            Ds = _ItemCategory.Showitemcategory("");
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Count = datagriditemcategory.Rows.Add(1);
                string AGname = Ds.Tables[0].Rows[i]["category"].ToString();
                string AGid = Ds.Tables[0].Rows[i]["categoryid"].ToString();
                datagriditemcategory.Rows[Count].Cells[1].Value = AGname;
                datagriditemcategory.Rows[Count].Cells[1].Tag = AGid;
            }

        }
        public void FilCombo()
        {
           _Depot.FillCombo(ComDepot);
           ComDepot.Enabled = false;
           CommonClass._Unitcreation.FillUnit(Comunit);
           CommonClass._Manufacturer.FillCombo(commanufacturer);
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            MainFu();
        }
        private bool MainFu()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
                    return true;
                }
                catch (Exception Ex)
                {
                    Ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool ValidationFu()
        {
            return true;
        }

        public void ItemClassFu()
        {
            if (chkallitemclass.Checked == true)
            {
                ItemClass = "'Stock Item','Services','Finished Product','Finished Product2','Direct'";
            }
            else
            {
                ItemClass = "'"+comitemclass.Text+"'";
            }
        }

        public string StockLevelFu()
        {
            if(Radminus.Checked==true)
            {
                if (Sbatch == true)
                {
                    return " and(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                      " TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode   and invdate between " +
                      " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )<0 ";

                }
                else
                {
                    return " and(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                      " TblInventory where pcode=IMS.ItemId    and invdate between " +
                      " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )<0 ";

                }
            }
            else if (Radzerostock.Checked == true)
            {
                if (Sbatch == true)
                {
                    return " and (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                     " TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode   and invdate between " +
                     " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )=0 ";
                }
                else
                {
                    return " and(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                      " TblInventory where pcode=IMS.ItemId    and invdate between " +
                      " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )=0 ";

                }
            }
            else if (Radselectstocklevel.Checked == true)
            {
                if (Sbatch == true)
                {
                    return "and (select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                     " TblInventory where pcode=IM.ItemId and batchcode=TB.Bcode   and invdate between " +
                     " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )<="+txttolevelstock.textBox1.Text+" ";
                }
                else
                {
                    return " and(select SUM(Os+purchase+Mr+Sr+Ireceipt+bmr+freepre+ps)-  SUM(sales+dn+pr+iissue+sh+dmg+bmi+freeiss ) from " +
                      " TblInventory where pcode=IMS.ItemId    and invdate between " +
                      " '" + Dtfrom.Value.ToString("MM-dd-yyyy") + " 00:00:00' and '" + Dtto.Value.ToString("MM-dd-yyyy") + " 23:59:59'   )<=" + txttolevelstock.textBox1.Text + " ";

                }
            }
            return "";
        }
          
        public string ItemManufacturerFu(string P)
        {
            if (chkallmanufacturer.Checked == false)
            {
                //CommonClass.temp = "select itemid from tblitemmaster where manufacturer in (" + commanufacturer.SelectedValue + ")";
                //return " and  "+P+" in(" + CommonClass.temp + ") ";
                CommonClass.temp = " and manufacturer in ("+commanufacturer.SelectedValue+")";
            }
          return  "";
        }

        public string DepoFunconsolidate()
        {
           
            if (chkdepot.Checked == false)
            {
                return " and dcode ='" + ComDepot.SelectedValue + "'";
            }
            return "";
        }


        public void DepoinFu()
            {
        if(chkdepot.Checked==true)
        {

            ClsReports.allgodwn = true;
            Depoin = "";
            Ds=_Dbtask.ExecuteQuery("select * from tbldepot");
            for(int i=0;i<Ds.Tables[0].Rows.Count;i++)
           {
               if (i == 0)
               {
                   Depoin ="'"+ Ds.Tables[0].Rows[i]["dcode"].ToString()+"'";
               }
               else
               {
                   Depoin =Depoin+",'"+ Ds.Tables[0].Rows[i]["dcode"].ToString()+"'";
               }
            }
           
          }
            else
            {
                ClsItemMaster.depotnobatch = "  where tblinventory.DCODE ='" + _Dbtask.znllString(ComDepot.SelectedValue) + "'  ";
                FrmReport.Decodee = "DCODE ='" + _Dbtask.znllString(ComDepot.SelectedValue) + "' ";
                ClsReports.allgodwn = false;
            Depoin = "'"+ComDepot.SelectedValue.ToString()+"'";
            }
        if (_Report.Query == "  ")
        {
            _Report.Query = "   having inv.dcode in(" + Depoin + ") ";
        }
        else
        {

            if (_Dbtask.znllString(CommonClass._Menusettings.GetMnustatus("103")) == "1")
            {

                if (chkdepot.Checked == false)
                {
                    FrmReport.Decodee = "AND Dcode='" + _Dbtask.znllString( ComDepot.SelectedValue) + "' ";
                    _Report.Query = _Report.Query + " and ( Tb.bcode= ( select distinct inv.batchcode) )    and  inv.dcode in(" + Depoin + ") ";
                    //_Report.Query = _Report.Query + "and Tb.bcode=(inv.batchcode )   and  inv.dcode in(" + Depoin + ") ";
                }


                else
                {
                    FrmReport.Decodee = " ";
                    _Report.Query = _Report.Query + "  and  Tb.bcode=( select distinct inv.batchcode ) ";
                }
                
                }
            else
            {
                ClsItemMaster.depotnobatch = "  where tblinventory.DCODE in(" + Depoin + ")  ";
                FrmReport.Decodee = " dcode in(" + Depoin + ") ";
                _Report.Query = _Report.Query + "   and  inv.dcode in(" + Depoin + ") ";
                Reporttype = "Stock Value";
            }

        
        
        
        }
        }
        public void NextgInitialize()
        {
            try
            {
                _Report.QueryTemp = "";
                if (comfor.SelectedIndex == 0)
                {
                    FrmReport.Secondcondition = "Prate";
                }
                if (comfor.SelectedIndex == 1)
                {
                    FrmReport.Secondcondition = "Srate";
                }
                if (comfor.SelectedIndex == 2)
                {
                    FrmReport.Secondcondition = "Crate";
                }

                ItemClassFu();
                /***********************Consolidated*****************************/
                if (ReporttypeSingle == "Stockconsolidateditem")/*For Item Consolidate*/
                {
                    if (Txtitems.Text != "")
                    {
                        _Report.Query = " select itemid from tblitemmaster where ItemId ='" + Txtitems.Tag + "' and Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";
                        //_Report.Query = " where ItemId ='" + Txtitems.Tag + "' and  Itemclass in ("+ItemClass+") "+ItemManufacturerFu(" manufacturer")+"";
                        _Report.QueryTemp = DepoFunconsolidate();
                    }

                    else
                    {
                        
                        _Report.Query = " select itemid from tblitemmaster where  Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";
                        _Report.QueryTemp =DepoFunconsolidate();
                    }
                    Reporttype = "Stockconsolidated";
                }
                else if (ReporttypeSingle == "Ndconsolidatedcategory")/*For ItemGroup Consolidate*/
                {
                    datagriditemcategory.EndEdit();
                    CommonClass.temp = CommonClass._SelectReport.ShowSelectedinGrid(datagriditemcategory, false);
                    CommonClass.temp = "select itemid from tblitemmaster where categoryid in (" + CommonClass.temp + ")";
                    //_Report.Query = " having IMS.ItemId in(" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") and manufacturer in (" + ItemManufacturerFu(" manufacturer") + ")";
                    _Report.Query = CommonClass.temp + " and  Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";

                    _Report.QueryTemp = DepoFunconsolidate();
                    Reporttype = "Stockconsolidated";
                }
                else if (ReporttypeSingle == "Ndconsolidatedledger")/*For Ledger Consolidate*/
                {
                    CommonClass.temp = "select itemid from tblitemmaster  where itemid in( select pcode from tblreceiptdetails where recptcode in (select reptcode from tbltransactionreceipt where ledcodecr in (" + txtsupplier.Tag + ")))";
                    //_Report.Query = " having IMS.ItemId in(" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") and manufacturer in (" + ItemManufacturerFu(" manufacturer") + ")";
                    _Report.Query = CommonClass.temp +" and Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";

                    _Report.QueryTemp = DepoFunconsolidate();
                    Reporttype = "Stockconsolidated";
                }
                else if (ReporttypeSingle == "Stockconsolidatedwithbatch")/*For Ledger Consolidate*/
                {
                    if (Txtitems.Text != "")
                    {
                        _Report.Query = " select itemid from tblitemmaster where ItemId ='" + Txtitems.Tag + "' and Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";
                        //_Report.Query = " where ItemId ='" + Txtitems.Tag + "' and  Itemclass in ("+ItemClass+") "+ItemManufacturerFu(" manufacturer")+"";
                        _Report.QueryTemp = DepoFunconsolidate();
                    }

                    else
                    {

                        _Report.Query = " select itemid from tblitemmaster where  Itemclass in (" + ItemClass + ") " + ItemManufacturerFu(" manufacturer") + " ";
                        _Report.QueryTemp = DepoFunconsolidate();
                    }
                    //if (Txtitems.Text != "")
                    //{
                    //    _Report.Query = " having IMS.ItemId ='" + Txtitems.Tag + "' and  IMS.Itemclass in (" + ItemClass + ")";
                    //}

                    //else
                    //{
                    //    CommonClass.temp = "select itemid from tblitemmaster ";
                    //    _Report.Query = " having IMS.ItemId in(" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") ";
                    //}
                    Reporttype = "Stockconsolidatedwithbatch";
                }
           
                /*************************************************************************/


                /************************Stock Value*************************/
               // string AddStockValue = " AND SUM(INV.Os+INV.purchase+INV.Mr+INV.Sr+INV.Ireceipt+INV.bmr+INV.freepre)-SUM(INV.sales+INV.dn+INV.pr+INV.iissue+INV.sh+INV.dmg+INV.bmi+INV.freeiss )  !=0 ";
                string AddStockValue = " ";



                if(_Dbtask.znllString( CommonClass._Menusettings.GetMnustatus("103"))=="-1")
                {
                    Reporttype = "Stock Value"; 
                }


                if (ReporttypeSingle == "Stock ValueItemwise")
                {
                    if (Txtitems.Text != "")
                    {
                        _Report.Query = " having IMS.ItemId ='" + Txtitems.Tag + "' and  IMS.Itemclass in (" + ItemClass + ") "+AddStockValue+"";

                        if(ChkAllunits.Checked==true)
                            _Report.QueryTemp = " where tblitemmaster.itemid='" + Txtitems.Tag + "'";
                        else
                        _Report.QueryTemp = " where pcode='" + Txtitems.Tag + "'";

                        Reporttype = "Stock Value"; 
                    }
                    else
                    {
                        CommonClass.temp = "select itemid from tblitemmaster ";
                        _Report.Query = " having IMS.ItemId in(" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") "+AddStockValue+" ";
                        Reporttype = "Stock Value"; 
                    }
                }



                else if (ReporttypeSingle == "Stock ValueCategorywise")
                {
                    datagriditemcategory.EndEdit();
                    CommonClass.temp = CommonClass._SelectReport.ShowSelectedinGrid(datagriditemcategory, false);
                   // CommonClass.temp = CommonClass._SelectReport.ShowSelectedinGrid(datagriditemcategory, false);
                    CommonClass.temp = "select itemid from tblitemmaster where categoryid in (" + CommonClass.temp + ")";

                    if (Sbatch == true)
                    {
                        _Report.Query = " having IM.ItemId in (" + CommonClass.temp + ") and  IM.Itemclass in (" + ItemClass + ") ";
                        Reporttype = "Stock ValueBatchwise";
                    }
                    else
                    {
                        _Report.Query = " having IMS.ItemId in (" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") " + AddStockValue + "";
                        _Report.QueryTemp = " where pcode in (" + CommonClass.temp + ") ";
                        Reporttype = "Stock Value";
                    }
                }
                else if (ReporttypeSingle == "Ndstockvalueledger")/*For Ledger Consolidate*/
                {
                    CommonClass.temp = "select pcode from tblreceiptdetails where recptcode in (select reptcode from tbltransactionreceipt where ledcodecr in (" + txtsupplier.Tag + "))";
                    _Report.Query = " having IMS.ItemId in (" + CommonClass.temp + ") and  IMS.Itemclass in (" + ItemClass + ") ";
                    _Report.QueryTemp = " where pcode in (" + CommonClass.temp + ") ";
                    Reporttype = "Stock Value"; 
                }
                /****************************************************************************************/


                if (ReporttypeSingle == "Stock ValueBatchwise")
                {
                    if (Txtitems.Text != "")
                    {
                        _Report.Query = " having IM.ItemId in(" + Txtitems.Tag + ")  and  IM.Itemclass in (" + ItemClass + ") ";

                        if(Chkallbarcode.Checked==false)
                            _Report.Query = _Report.Query +" and Tb.bcode='"+combatchcode.Text+"'";
                        //_Report.Query = " having IM.ItemId ='" + Txtitems.Tag + " ' and  IM.Itemclass in (" + ItemClass + ") ";
                        //_Report.QueryTemp = " where pcode='" + Txtitems.Tag + "'";
                        Reporttype = "Stock ValueBatchwise";
                    }
                    else
                    {
                        CommonClass.temp ="select itemid from tblitemmaster ";
                        _Report.Query = " having IM.ItemId in(" + CommonClass.temp + ")  and  IM.Itemclass in (" + ItemClass + ") ";
                        Reporttype = "Stock ValueBatchwise";
                    }
                }
                _Report.Query = _Report.Query + StockLevelFu();
                _Report.Query =_Report.Query+ ItemManufacturerFu(" Im.manufacturer");

                //FrmReport.Thirdcondition = CommonClass._Unitcreation.Getspesificfield("ucount", Comunit.SelectedValue.ToString());
                FrmReport.SelUnit = Comunit.Text;

                if(Reporttype!="Stockconsolidated"&&Reporttype!="Stockconsolidatedwithbatch")
                DepoinFu();

                if (ChkAllunits.Checked == true)
                {
                    _Report.ReportTypeSecond = "All Units";
                }
                else
                {
                    _Report.ReportTypeSecond = "";
                }
                    /********************************************/
                Clsselectreport.RType = Reporttype;
                Clsselectreport.SCoundition = FrmReport.Secondcondition;
                Clsselectreport.RQuery = _Report.Query;
                Clsselectreport.RQueryTemp = _Report.QueryTemp;
                Clsselectreport.RDtfrom = Convert.ToDateTime(Dtfrom.Value.ToString("dd/MMM/yyyy"));
                Clsselectreport.Rdtto= Convert.ToDateTime(Dtto.Value.ToString("dd/MMM/yyyy"));
                Clsselectreport.RTypeSecond = _Report.ReportTypeSecond;
                CommonClass._Clreport.ShowReport(this,true);
            }
            catch
            {
            }
          //  this.Enabled = false;
        }
        public void ShowReport()
        {

          
        }

        private void FrmSelectStockList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (uscitemshowsimple1.Visible == true)
                {
                    uscitemshowsimple1.Visible = false;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void FrmSelectStockList_Load(object sender, EventArgs e)
        {
           
            _NextgFunction.FormStylesett(this);
            //this.Controls.Add(uscitemshowsimple1);
          //  _NextgFunction.FormBorderStyle(pnltop, pnlleft, pnlright, pnlbottom);
          //  _NextgFunction.FormHeadStyle(pnlHead);
           // _NextgFunction.FormImage(pnlImage);
            TreeMain.ExpandAll();
            Clear();
            CommonClass._Nextg.FormIcon(this);

        }

        

        public void BatchList()
        {
            if (ClsMenusettings.EBatch == true)
            {
                if (Txtitems.Tag != null)
                {
                    Itemid = Txtitems.Tag.ToString();
                    combatchcode.DataSource = null;
                    _Dbtask.fillDatainCombowithQuery(combatchcode, "bid", "bcode", "tblbatch", "select * from tblbatch where itemid='" + Itemid + "'");
                }
            }
        }

        public void ItemList()
        {
            string Bcode = combatchcode.Text;
            string Itemid =CommonClass._Batch.GetSpecificFieldofBatchBaseonitemid(Bcode);
            string ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
            string ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
            IsEnter = false;
            Txtitems.Text = ItemName;
            Txtitems.Text = ItemCode;
            Txtitems.Tag = Itemid;
        }
        public void ItemBaseSelect(bool Bcode)
        {
            Grpgroup.Visible = false;
            Grpsupplierwise.Visible = false;
            Grpitembase.Visible = true;
            if (Bcode == false)
            {
                lblbarcode.Visible = false;
                combatchcode.Visible = false;
            }
            else
            {
                lblbarcode.Visible = true;
                combatchcode.Visible = true;
                BatchList();
            }

        }

        public void GroupBaseSelect()
        {
            Grpgroup.Visible = true;
            Grpitembase.Visible = false;
            Grpsupplierwise.Visible = false;
        }

        public void LedgerBaseSelect()
        {
            Grpgroup.Visible = false;
            Grpitembase.Visible = false;
            Grpsupplierwise.Visible = true;
        }

        public void ConlidateSelect()
        {
            grpforselect.Visible = false;
        }
        public void ItemValueSelect()
        {
            grpforselect.Visible = true;
        }

        private void TreeMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            grpforselect.Visible = false;
            if (TreeMain.SelectedNode.Name == "Ndconsolidateitem")
            {
                ReporttypeSingle = "Stockconsolidateditem";
                ItemBaseSelect(false);
            }
            if (TreeMain.SelectedNode.Name == "Ndconsolidatedcategory")
            {
                ReporttypeSingle = "Ndconsolidatedcategory";
                GroupBaseSelect();
                ConlidateSelect();
            }

            if (TreeMain.SelectedNode.Name == "Ndconsolidatebatchwise")
            {
                ReporttypeSingle = "Stockconsolidatedwithbatch";
                ItemBaseSelect(false);
            }


            if (TreeMain.SelectedNode.Name == "Ndvalueitem")
            {
                ReporttypeSingle = "Stock ValueItemwise";
                ItemBaseSelect(false);
                ItemValueSelect();
            }
            if (TreeMain.SelectedNode.Name == "Ndvaluecategory")
            {
                ReporttypeSingle = "Stock ValueCategorywise";
                GroupBaseSelect();
                ItemValueSelect();
            }
            if (TreeMain.SelectedNode.Name == "ndvaluebatchwise")
            {
                Reporttype = "Stock ValueBatchwise";
                ReporttypeSingle = "Stock ValueBatchwise";
                ItemBaseSelect(true);
                ItemValueSelect();
            }
            if (TreeMain.SelectedNode.Name == "Ndconsolidatedledger" || TreeMain.SelectedNode.Name == "Ndstockvalueledger")
            {
                ReporttypeSingle = TreeMain.SelectedNode.Name;
                LedgerBaseSelect();
            }

            if (TreeMain.SelectedNode.Name == "NdStocklevel")
            {
                if (Sbatch == true)
                {
                    GrpStocklevel.Visible = true;
                    Reporttype = "Stock ValueBatchwise";
                    ReporttypeSingle = "Stock ValueBatchwise";
                }
                else
                {
                    GrpStocklevel.Visible = true;
                    ReporttypeSingle = "Stock ValueItemwise";
                }
            }
            else
            {
                GrpStocklevel.Visible = false;
            }

            //if (TreeMain.SelectedNode.Name == "NdStockvalue")
            //{
            //    grpforselect.Visible = true;
                
            //}
            _SelectReport.TreeviewAfterSelect(TreeMain);
        }
        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkdepot_CheckedChanged(object sender, EventArgs e)
        {
            EnableControle(chkdepot, ComDepot);
        }
        public void Shoitems(string txt)
        {
           // if(IsEnter==false)
           // {
           // Gridlist.Rows.Clear();
           // Ds= _Itemmaster.ShowItemsProductName(" where itemname like '%" + txt + "%' or itemcode like '%"+txt+"%'",false);
           //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
           //{
           //    Gridlist.Rows.Add(1);
           //    Gridlist.Rows[i].Cells[0].Value = Ds.Tables[0].Rows[i]["itemname"].ToString();
           //    Gridlist.Rows[i].Cells[0].Tag = Ds.Tables[0].Rows[i]["itemid"].ToString();
           //}
           //Gridlist.Visible = true;
           // }
        }
        public void ProductGridShow(string WhereCondition)
        {
            try
            {
                _Ingrid.ProductGridShowFixed(uscitemshowsimple1, WhereCondition, uscitemshowsimple1.GridProductShow, "0");
                if (uscitemshowsimple1.Visible == false)
                {
                    uscitemshowsimple1.Visible = true;
                }
                    
            }
            catch
            {
            }
        }
       
        private void Txtitems_Enter(object sender, EventArgs e)
        {
            IsEnter = false;
        }
        public void RowClick(string Value, int KeyValue)
        {
            try
            {
                // gridmain.Rows[rowindex].Cells["clnitemcode"].Value = Value;

               _Ingrid.RowUpDownSelectinTexttbox(KeyValue, uscitemshowsimple1.GridProductShow, SeleRow, uscitemshowsimple1);
               // uscitemshowsimple1.lblstock.Text = _Dbtask.SetintoDecimalpointStock(_Ingrid.Stock);
                if (KeyValue == 13)
                {
                    SeleRow = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                    string Itemid = uscitemshowsimple1.GridProductShow.Rows[SeleRow].Cells["itemid"].Value.ToString();
                    string ItemName = _Dbtask.ExecuteScalar("select itemname from tblitemmaster where itemid='" + Itemid + "'");
                    string ItemCode = _Dbtask.ExecuteScalar("select itemcode from tblitemmaster where itemid='" + Itemid + "'");
                    Txtitems.Text = ItemName;
                   // txtitemcode.Text = ItemCode;
                    Txtitems.Tag = Itemid;
                    uscitemshowsimple1.Visible = false;
                    BatchList();
                }
            }
            catch
            {
            }
        }

        private void TreeMain_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            _SelectReport.TreeviewBeforeSelect(TreeMain);
        }

        private void Txtitems_TextChanged(object sender, EventArgs e)
        {
            Temp = Txtitems.Text;
           Uscitemshowsimple.ActiveControle = Txtitems;
           Uscitemshowsimple.Vtype = "Item";
           string WHERE = " WHERE  TblItemMaster.itemCode Like N'%" + Temp + "%' OR  TblItemMaster.ItemName Like N'%" + Temp + "%' OR  TblItemMaster.llang Like N'%" + Temp + "%' or Tblbatch.bcode like N'%" + Temp + "%' ";
           ProductGridShow(WHERE);
        }

        private void chkcategoryall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcategoryall.Checked == true)
            {
                for (int i = 0; i < datagriditemcategory.Rows.Count; i++)
                {
                    if (datagriditemcategory.Rows[i].Cells[1].Value != null)
                    {
                        datagriditemcategory.Rows[i].Cells[0].Value = 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < datagriditemcategory.Rows.Count; i++)
                {
                    if (datagriditemcategory.Rows[i].Cells[1].Value != null)
                    {
                        datagriditemcategory.Rows[i].Cells[0].Value = 0;
                    }
                }
            }
        }

        private void Txtitems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            RowClick(Txtitems.Text, e.KeyValue);
        }

        private void combatchcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ItemList();
        }
        public void EnableControle(CheckBox Chk, ComboBox Cmb)
        {
            if (Chk.Checked == true)
            {
                Cmb.Enabled = false;
            }
            else
            {
                Cmb.Enabled = true;
            }
        }

        private void chkallitemclass_CheckedChanged(object sender, EventArgs e)
        {
            EnableControle(chkallitemclass, comitemclass);
        }

        private void txtsupplier_TextChanged(object sender, EventArgs e)
        {
            _Ingrid.AccountsGridShow(uscitemshowsimple2.GridProductShow, txtsupplier.Text, uscitemshowsimple2,0);
        }

        private void txtsupplier_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            _Ingrid.GridupandDowninLedger(uscitemshowsimple2, uscitemshowsimple2.GridProductShow, e.KeyValue, txtsupplier);
        }

        private void FrmSelectStockList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                MainFu();
            }
        }

        private void chkallmanufacturer_CheckedChanged(object sender, EventArgs e)
        {
            EnableControle(chkallmanufacturer, commanufacturer);
        }

        private void Radselectstocklevel_CheckedChanged(object sender, EventArgs e)
        {
            if (Radselectstocklevel.Checked == true)
                Grpselectstockleve.Enabled = true;
            else
                Grpselectstockleve.Enabled = false;
        }

        private void Chkallbarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkallbarcode.Checked == true)
            {
                combatchcode.Enabled = false;
                uscitemshowsimple1.Visible = false;
            }



            else
            {
                combatchcode.Enabled = true;
                uscitemshowsimple1.Visible = false;
            }
        }

       

        
  
           }
        }

 

    

