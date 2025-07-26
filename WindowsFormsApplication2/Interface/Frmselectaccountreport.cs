using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.DataSetExtensions;


namespace WindowsFormsApplication2
{
    public partial class Frmselectaccountreport : Form
    {
        int SeleRow;
        int Count;
        string AgeingQuery;
        string GroupQuery;
        string Temp;
        string SelectedNode;

       
          string  Name ;
          string  Id ;
        /*For Settings*/
        bool Spartyproject;

        DataSet Ds = new DataSet();
        DBTask _Dbtask = new DBTask();
        FrmReport _Report = new FrmReport();
        NextGFuntion _Nextg = new NextGFuntion();

        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        ClsAccountGroup _Accountgroup = new ClsAccountGroup();
        Clsselectreport _SelectReport = new Clsselectreport();
        int selectedRow;
        bool Notexit=true;
        public Frmselectaccountreport()
        {
            InitializeComponent();
        }

        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.FormBasedConversion(this);
                CommonClass._Language.TreeViewConvertion(TreeMain);
                CommonClass._Language.GroupBoxConvertion(Grpgroupselect);
                CommonClass._Language.GroupBoxConvertion(grpselection);
                CommonClass._Language.GroupBoxConvertion(GrpSingleSelect);
                
            }
        }

        public void ReportSelectingMode(bool IsGroupBase)
        {
            try
            {
                if (IsGroupBase == true)
                {
                    Grpgroupselect.Visible = true;
                    GrpSingleSelect.Visible = false;
                    GroupBoxSizesett(Grpgroupselect);
                }
                else
                {
                    Grpgroupselect.Visible = false;
                    GrpSingleSelect.Visible = true;
                    GroupBoxSizesett(GrpSingleSelect);
                }
            }
            catch
            {
            }
        }
        public void ShowAccountGroup()
        {
            try
            {
                Temp = txtgroup.Text;
                if (SelectedNode == "Ndoutgroupwise")
                {
                    ShowGridLoadGroupName(" and agroupname like N'%" + Temp + "%' and Agroupid in(select agroupid from tblaccountgroup where aunder in(18,19,22,29) or agroupid in(18,19,22,29) )");
                }
                else
                {
                    ShowGridLoadGroupName(" and agroupname like N'%" + Temp + "%' ");
                }

                CommonClass._report.ReportType = "AccountReport";
                ReportSelectingMode(true);
            }
            catch
            {
            }
        }

        public void TreeviewSelect()
        {
            try
            {
                SelectedNode = TreeMain.SelectedNode.Name.ToString();

                /*For Summury and Detail*/
                //if (SelectedNode == "Ndoutledgerwise" || SelectedNode == "Ndoutgroupwise")
                //{
                //    ReportSelectingMode(true);
                //}
                //else
                //{
                //    ReportSelectingMode(false);
                //}
                /**********************************/
                if (SelectedNode == "Ndledledgerwise" || SelectedNode == "Ndoutledgerwise")
                {
                    CommonClass._report.ReportType = "AccountReport";
                    ReportSelectingMode(false);
                }
                if (SelectedNode == "Ndledgroupwise" || SelectedNode == "Ndoutgroupwise")
                {
                    ShowAccountGroup();
                }
                if (SelectedNode == "Ndoutledgerwise" || SelectedNode == "Ndoutgroupwise")
                {
                    if (radsummery.Checked == true)
                    {
                        CommonClass._report.ReportType = "OutstandingReportsummery";
                    }
                    if (raddetail.Checked == true)
                    {
                        CommonClass._report.ReportType = "OutstandingReport";
                    }
                }
                if (SelectedNode == "NdBillwiseprofit")
                {
                    CommonClass._report.ReportType = "Billwiseprofitstatement";
                    Grpgroupselect.Visible = false;
                    GrpSingleSelect.Visible = false;
                }

                if (SelectedNode == "Ndoutstanding")
                {
                    TreeMain.SelectedNode = TreeMain.Nodes[1].Nodes[0];
                }
                if (SelectedNode == "Ndledgerreport")
                {
                    TreeMain.SelectedNode = TreeMain.Nodes[0].Nodes[0];
                }

                if (SelectedNode == "Ndoutledgerwise" || SelectedNode == "Ndoutgroupwise")
                {
                    grpselection.Visible = true;
                }
                else
                {
                    grpselection.Visible = false;
                }

                _SelectReport.TreeviewAfterSelect(TreeMain);
            }
            catch
            {
            }  
        }
        public void CheckedList()
        {
            //CheckedListBox cbGenreList = new CheckedListBox();
            //cbGenreList.Location = new Point(8, 20);
            //cbGenreList.Size = new Size(130, 180);
            //this.grpGenres.Controls.Add(cbGenreList);

            //// Let's bind it to data from a Database
            //var GenreList = from c in databasebObjectContext.Genres orderby c.gnDescription select c;
            //cbGenreList.DataSource = GenreList.ToArray();
            //cbGenreList.DisplayMember = "gnDescription";
            //cbGenreList.ValueMember = "gnNumber";
        }
        public void Ledgerinmain()
        {
           // ChkMain.Visible = false;
           // TxtAmount.Visible = false;
            //Lblamountmorethan.Visible = false;
            lblselectgroup.Visible = false;
            Txtaccount.Visible = true;
            Lblledger.Visible = true;

        }
        private void CmdShow_Click(object sender, EventArgs e)
        {
            Main();
        }
        public void ShowReport()
        {
            CommonClass._Clreport.ShowReport(this,true);
            
        }
        private bool Main()
        {
            if (ValidationFu())
            {
                try
                {
                    NextgInitialize();
                    ShowReport();
                    
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
        public void NextgInitialize()
        {
            try
            {
                Dtfrom.Select();
                Clsselectreport.RDtfrom = Convert.ToDateTime(Dtfrom.Value);
                Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value);
                CommonClass._SelectReport.DbTemp = _Dbtask.znullDouble(txtamount.textBox1.Text);
                SelectedNode = TreeMain.SelectedNode.Name.ToString();

                if (SelectedNode == "Ndledledgerwise" || SelectedNode == "Ndoutledgerwise")
                {
                    Clsselectreport.RQuery = "select * from tblgeneralledger   where ledcode='" + Txtaccount.Tag + "' ";

                    Clsselectreport.RQueryTemp = "select * from tblaccountledger where lid='" + Txtaccount.Tag + "'  ";

                    if (txtnaration.Text != "")
                    {
                        Clsselectreport.RQuery = "select * from tblgeneralledger   where naration = '" + txtnaration.Text + "' ";
                        Clsselectreport.RQueryTemp = "select * from tblaccountledger ";
                    }

                    Clsselectreport.RType = "AccountReport";
                    FrmReport.Lbl2 = Txtaccount.Text;
                }

                else if (SelectedNode == "Ndledgroupwise" || SelectedNode == "Ndoutgroupwise")
                {
                    Temp = _SelectReport.ShowSelectedinGrid(GridGroup, false);
                    Clsselectreport.RQueryTemp = "select * from tblaccountledger where agroupid in(" + Temp + ") or agroupid in (select agroupid from tblaccountgroup where aunder='" + Temp + "' ) order by lname asc";
                    if (SelectedNode == "Ndledgroupwise")
                    {
                        Clsselectreport.RType = "GroupReportSummury";
                        Clsselectreport.RQuery = "where TblAccountLedger.AGroupId in (select agroupid from tblaccountgroup where agroupid in (" + Temp + ") or aunder in (" + Temp + "))";

                        if (chkallarea.Checked == false)
                        {
                         Clsselectreport.RQuery = Clsselectreport.RQuery +" and TblAccountLedger.area in ("+Comarea.SelectedValue+")";
                        }

                        FrmReport.Lbl2 = "";
                    }
                }

                if (SelectedNode == "Ndoutledgerwise" || SelectedNode == "Ndoutgroupwise")
                {
                    if (radsummery.Checked == true)
                        Clsselectreport.RType = "OutstandingReportsummery";
                    else
                        Clsselectreport.RType = "OutstandingReport";

                    //if (SelectedNode == "Ndoutgroupwise")
                    //{
                    //    Clsselectreport.RQuery = Clsselectreport.RQuery + " and TblAccountLedger.area in (" + Comarea.SelectedValue + ")";
                    //}

                }

                if (SelectedNode == "NdBillwiseprofit")
                {

                    Clsselectreport.RType = "Billwiseprofitstatement";
                    Clsselectreport.RQuery = "select * from tblbusinessissue where issuetype='SI'";
                }

                if (SelectedNode == "Ndbillwisesett")
                {
                    Temp = _SelectReport.ShowSelectedinGrid(GridGroup, false);
                    Clsselectreport.RType = "Billwisesettlement";
                    Clsselectreport.RQueryTemp = "select * from tblaccountledger where agroupid in(" + Temp + ") or agroupid in (select agroupid from tblaccountgroup where aunder='" + Temp + "') ";
                   // Clsselectreport.RQuery = "select * from tblbusinessissue where issuetype='SI'";
                }


                if(Chkduedays.Checked==true)
                {

                    int numday = 0;
                    numday = Convert.ToInt32(txtdays.textBox1.Text);
                     numday= numday*(-1);
                    DateTime ddt;
                    ddt = Dtfrom.Value.AddDays(numday);

                    Clsselectreport.RQuery = " select distinct (ledcodedr) from tblbusinessissue  " +
                  "  INNER JOIN tblaccountledger ON tblbusinessissue.ledcodedr  " +
                  "  =(select lid  tblaccountledger where agroupid='18') ";
                  //"  where tblbusinessissue.issuedate >='" + ddt.ToString("MM-dd-yyyy hh:mm tt") + "' ";
                    Clsselectreport.RType = "Due date bill Report";
                   FrmReport.ddlimitdate = ddt;
                   FrmReport.datenum = Convert.ToInt32(txtdays.textBox1.Text);

                
                }

                if (SelectedNode == "Ndpandr")
                {
                    Clsselectreport.RType = "Payment and Receipt Report";
                }

                if (Spartyproject == true && chkallproject.Checked == false)
                {

                    Clsselectreport.RQuery = Clsselectreport.RQuery + " and  pproject  IN( " + CommonClass._SelectReport.ShowSelectedinGrid(Gridprojecttype, false) + ")";
                }
            }
            catch
            {
            }
        }
       
        private void Frmselectaccountreport_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27&&Notexit==true)
            {
                this.Close();                                                                                             
            }
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
            //checkedListBox1.da
            //foreach (var item in checkedListBox1.CheckedItems)
            //{
            //    var row = (item as DataRowView).Row;
            //    MessageBox.Show(row["ID"] + ": " + row["CompanyName"]);
            //}

        }

      

        private void Frmselectaccountreport_KeyPress(object sender, KeyPressEventArgs e)
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

        public void Fillcombo()
        {
            CommonClass._Area.FillArea(Comarea);
        }
        public void visiblefalse()
        {
            if (CommonClass._Menusettings.GetMnustatus("302011").ToString()=="1")
            {
             //TreeMain.Nodes["Ndledledgerwise"] 
            }
        }
        public void Clear()
        {
            Fillcombo();
            txtamount.textBox1.Text = "0";
            Menusettings();
            TreeMain.ExpandAll();
            //ShowGridLoadGroupName("");
            TreeMain.SelectedNode = TreeMain.Nodes["Ndledledgerwise"];
            chkallitemgroup.Checked = false;
            //_SelectReport.SelectAllCheckinGrid(GridGroup);
            Dtfrom.Value =Convert.ToDateTime(CommonClass._Paramlist.GetFromfinacial());
            chkallproject.Checked = true;
            ChangeLanguage();
            Dtfrom.Value = CommonClass._Gen.FuFromdateReportdef();
            DtTo.Value = CommonClass._Gen.FuTodateReportdef();
            CommonClass._Nextg.FormIcon(this);

            ClsRPSeperatereport.rptax = false;
            FrmReport.PRTAX = false;
            chktaxrp.Checked = false;
        }
        public void GroupBoxSizesett(GroupBox Grp)
        {
            Grp.Location = new System.Drawing.Point(194, 9);
        }
        public void ShowGridLoadGroupName(string AreaName)
        {
            try
            {
                ///*For GroupName*/
                ///
                lblselectgroup.Visible = true;
                GridGroup.Visible = true;
                GridGroup.Rows.Clear();
                Ds = _Accountgroup.ShowAccountGroup(AreaName);
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Count = GridGroup.Rows.Add(1);
                    string AGname = Ds.Tables[0].Rows[i]["agroupname"].ToString();
                    string AGid = Ds.Tables[0].Rows[i]["agroupid"].ToString();
                    GridGroup.Rows[Count].Cells[1].Value = AGname;
                    GridGroup.Rows[Count].Cells[1].Tag = AGid;
                }
            }
            catch
            {
            }
        }
        public void ShowGrid(string AreaName)
        {
            ///*For Area*/
            //datagridArea.Rows.Clear();
            //Ds = _AccountLedger.ShowSpecifcFiled("area", " where  area like'%" + AreaName + "%'");
            //for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            //{
            //    Count = datagridArea.Rows.Add(1);
            //    string AName = Ds.Tables[0].Rows[i]["area"].ToString();
            //    datagridArea.Rows[Count].Cells["clnarea"].Value = AName;
            //}
        }
       
        public void Menusettings()
        {
            try
            {
                if (CommonClass._Menusettings.GetMnustatus("156") == "1")
                {
                    Spartyproject = true;
                    pnlpartyproject.Visible = true;
                }
            }
            catch
            {
            }
        }

        private void Frmselectaccountreport_Load(object sender, EventArgs e)
        {
            try
            {
                _Nextg.FormStylesett(this);
                Clear();
                CommonClass._Gen.treeview(TreeMain, "Ndledledgerwise", 0);
                //Ndledledgerwise
                CommonClass._Nextg.FormIcon(this);
            }
            catch
            {
            }
        }

        private void TreeMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeviewSelect();
        }

        private void TreeMain_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            _SelectReport.TreeviewBeforeSelect(TreeMain);
        }

        private void Txtaccount_TextChanged(object sender, EventArgs e)
        {
            Temp = Txtaccount.Text;
            Uscitemshowsimple.ActiveControle = Txtaccount;
            Uscitemshowsimple.Vtype = "Ledger";
            AccountGridShow(Temp);
        }
        public void AccountGridShow(string WhereCondition)
        {
            try
            {
                CommonClass.temp = WhereCondition;
                
                CommonClass._Ingrid.LedgerGridShow(uscitemshowsimple1, " where lname like N'%" + CommonClass.temp + "%'  ", uscitemshowsimple1.GridProductShow, "0",0);
                if (uscitemshowsimple1.Visible == false)
                {
                    uscitemshowsimple1.Visible = true;
                }

            }
            catch
            {
            }
        }
        private void Txtaccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            RowClick(Txtaccount.Text, e.KeyValue);
        }

        public void RowClick(string Value, int KeyValue)
        {
            try
            {
               CommonClass._Ingrid.RowUpDownSelectinTexttbox(KeyValue, uscitemshowsimple1.GridProductShow, SeleRow, uscitemshowsimple1);
                if (KeyValue == 13)
                {
                  SeleRow = uscitemshowsimple1.GridProductShow.SelectedRows[0].Index;
                  string Id = uscitemshowsimple1.GridProductShow.Rows[SeleRow].Cells["lid"].Value.ToString();
                  string Name = CommonClass._Dbtask.ExecuteScalar("select lname from tblaccountledger where lid='" + Id + "'");
                  string Code = CommonClass._Dbtask.ExecuteScalar("select laliasname from tblaccountledger where lid='" + Id + "'");
                  Txtaccount.Text = Name;
                    Txtaccount.Tag = Id;
                    uscitemshowsimple1.Visible = false;
                    if (Spartyproject == true)
                    {
                        Ds =CommonClass._Dbtask.ExecuteQuery("select * from tblpartyproject where partyid='"+Id+"'");
                        Gridprojecttype.Rows.Clear();
                  //      Gridprojecttype.DataSource = Ds.Tables[0];
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Count = Gridprojecttype.Rows.Add(1);
                            Name = Ds.Tables[0].Rows[i]["pname"].ToString();
                            Id = Ds.Tables[0].Rows[i]["pid"].ToString();
                            Gridprojecttype.Rows[Count].Cells[1].Value = Name;
                            Gridprojecttype.Rows[Count].Cells[1].Tag = Id;
                        }
                        Gridprojecttype.PerformLayout();
                    }
                }
            }
            catch
            {
            }
        }


        private void chkallitemgroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkallitemgroup.Checked == true)
            {
                _SelectReport.SelectAllCheckinGrid(GridGroup);
            }
        }

        private void Frmselectaccountreport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 117)
            {
                Main();
            }
        }

        private void txtgroup_TextChanged(object sender, EventArgs e)
        {
            ShowAccountGroup();
        }

        private void chkallproject_CheckedChanged(object sender, EventArgs e)
        {
            if (chkallproject.Checked == true)
            {
                Gridprojecttype.Enabled = false;
                CommonClass._SelectReport.SelectAllCheckinGrid(Gridprojecttype);
            }
            else
            {
                Gridprojecttype.Enabled = true;
            }
        }

        private void Gridprojecttype_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            }
            catch
            {
             //   Gridprojecttype.PerformLayout();
            }
        }

        private void chkallarea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkallarea.Checked == true)
                Comarea.Enabled = false;
            else
                Comarea.Enabled = true;
        }

        private void GridGroup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void GridGroup_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmreceiptonly_Click(object sender, EventArgs e)
        {
            Clsselectreport.RDtfrom = Convert.ToDateTime(Dtfrom.Value);
            Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value);
            Clsselectreport.RType = "Receipt Report only";
            CommonClass._Clreport.ShowReport(this, true);
        }

        private void cmdpaymentonly_Click(object sender, EventArgs e)
        {
            Clsselectreport.RDtfrom = Convert.ToDateTime(Dtfrom.Value);
            Clsselectreport.Rdtto = Convert.ToDateTime(DtTo.Value);
            Clsselectreport.RType = "Payment Report only";
            CommonClass._Clreport.ShowReport(this, true);
        }

        private void chktaxrp_CheckedChanged(object sender, EventArgs e)
        {
            if(chktaxrp.Checked==true)
            {
            FrmReport.PRTAX = true;
            ClsRPSeperatereport.rptax = true;
            }
            else
            {
                ClsRPSeperatereport.rptax = false;
                FrmReport.PRTAX = false;
            }
        }
    }
}
