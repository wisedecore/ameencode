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
    public partial class frmzatsearch : Form
    {
        public frmzatsearch()
        {
            InitializeComponent();
        }
        int RowCounting;
        public string LedgerName;
       // public string Vno;
        public string Slno;
       public  string Where;
         public string Sql;
              string DecimalValue;

              public string Vtype;
              public string selmasters;
        int RowIndex;
        int Columnindex;
        string ColumnName;
        string DDay;
        string Month;
        string Year;
        public string temp;
        string MainAccount;
        string Vcode;
        string Vno;
        public string SelectedVtypeStr;
        bool NotExit = true;
        public int flag = 0;
        public int flag1 = 0;

        public int Retrivemode = 0;
        bool IsEnter;
        string Type;
       
        bool Isinotherwindow;
        int selectedrow;
        public int SearchDebtors = 0;
        public int SearchCreditor = 0;
        public bool txtsearch = true;
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        DataSet Ds1 = new DataSet();
        DataSet Ds2 = new DataSet();
        DataSet Ds3 = new DataSet();
        public string SelectedNode;
        ClsAccountGroup _AccountGroup = new ClsAccountGroup();
        ClsAccountLedger _AccountLedger = new ClsAccountLedger();
        frmcreateledger _CreateLedger = new frmcreateledger();
        string Id;
        string Lid;
        public void vtypeadd()
        {
            

            Ds = CommonClass._Ledger.VtypeinSales();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Lid = Ds.Tables[0].Rows[i]["lid"].ToString();
                Name = Ds.Tables[0].Rows[i]["lname"].ToString();
                comvtype.Items.Add(Name);



            }
            Ds = CommonClass._Ledger.VtypeinPurchase();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Id = Ds.Tables[0].Rows[i]["lid"].ToString();
                Name = Ds.Tables[0].Rows[i]["lname"].ToString();

                comvtype.Items.Add(Name);

            }

        }
        public void clear()
        {
            vtypeadd();
        }

      
        public void Selectvtype()
        {
            try
            {
                //  GridMain.Columns.Clear();
                string SelectedNode = comvtype.Text;
                selmasters = commasters.Text;
                string type = commode.Text;


                LedgerName = txttename.Text;
                Vno = txtvno.Text;

                if (type == "Masters")
                {
                    button2.Enabled = true;
                    grptransaction.Enabled = false;
                    grpmasters.Enabled = true;

                    if (selmasters == "Items")
                    {
                        grpitems.Enabled = true;
                        grppatry.Enabled = false;
                        items();

                    }
                    if (selmasters == "Item Category")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = false;
                       
                        categoery();
                    }
                    if (selmasters == "Customer")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = true;

                        customer();

                    }
                    if (selmasters == "Supplier")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = true;

                      
                        supplier();
                    }
                    if (selmasters == "Employee")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = true;

                        Employee();
                    }
                    if (selmasters == "Agent")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = true;

                       
                        Agent();
                    }
                    if (selmasters == "Ledger")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled =false;

                        ledger();

                    }
                    if (selmasters == "Ledger Group")
                    {
                        grpitems.Enabled = false;
                        grppatry.Enabled = false;

                        ledgergroup();
                    }
                }

                    if (type == "Transactions")
                    {
                        grptransaction.Enabled = true;
                        button2.Enabled = false;
                        grpmasters.Enabled = false;
                        string Groupid;
                        Groupid = _AccountLedger.GetSpecificfieldBaseonName(SelectedNode, "agroupid");

                        if (Groupid == "21")
                        {

                            Salesinmain("", "SI", _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + comvtype.Text + "'"), "Sales");

                        }

                        if (SelectedNode == "SalesReturn")
                        {

                            Salesreturnmain("", "SR", "2", "Sales Return");
                        }
                        if (Groupid == "26")
                        {
                            Frmpurchase _Purchase = new Frmpurchase();

                            _Purchase.Vtype = "PI";
                            // _Purchase.Heading = CommonClass._Ledger.GetspecifField("", MainAccount) + " Invoice";
                            Purchaseinmain("", "PI", _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + comvtype.Text + "'"), "Purchase");
                        }
                        if (SelectedNode == "PurchaseReturn")
                        {
                            string Vtype = "PR";
                            Purchasereturninmain("", "PI", "3", "Purchase Return");
                        }
                        if (SelectedNode == "SalesOrder")
                        {
                            string Vtype = "SO";
                            SalesOrder("SO");

                        }
                        if (SelectedNode == "PurchaseOrder")
                        {
                            Frmpurchase _Purchase = new Frmpurchase();
                            _Purchase.Vtype = "PO";
                            //   TransactionReceiptinmain("", "PO", "3", "Purchase");
                            //  Lblheading.Text = "Purchase order";
                            PurchaseOrder("PO");
                        }
                        if (SelectedNode == "Receipt")
                        {

                            string Vtype = "R";
                            Receiptshow("R");
                        }
                        if (SelectedNode == "Payment")
                        {
                            string Vtype = "P";
                            Payment("P");
                        }

                        if (SelectedNode == "Journal Receipt")
                        {
                            string Vtype = "JNR";
                            Receiptshow("JNR");

                        }
                        //  if (selectedNode=="")
                        if (SelectedNode == "Journal Payment")
                        {
                            String Vtype = "JNP";
                            Payment("JNP");
                        }
                        if (SelectedNode == "DebitNote")
                        {
                            string Vtype = "DBN";
                            // Lblheading.Text = "DebitNote ";

                            Receiptshow("DBN");
                        }

                        if (SelectedNode == "CreditNote")
                        {
                            string Vtype = "CRN";
                            Payment("CRN");
                        }

                    }
                
        }
            catch
            {
            }
        }
       
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
       

        //public void Allshow()
        //{

        //    GridMain.Columns.Clear();
            
        //        Salesinmain("");
        //        SalesOrder("");
        //        Salesreturnmain("SR");
        //        Purchaseinmain("");
        //        PurchaseOrder("");
        //        Purchasereturninmain("PR");
       
        //}
        //************************************sales  content view  in grid*********************************
        public void items()
        {
            GridMain.Columns.Clear();
                    
            Sql= "SELECT        TblItemCategory.Category as Category, TblItemMaster.ItemId , TblItemMaster.Itemcode as ItemCode, TblItemMaster.ItemName as ItemName, TblItemMaster.MRP, TblItemMaster.SRate,  "+
                  " TblItemMaster.PRate FROM            TblItemMaster INNER JOIN  TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId  " ;
            Where = Sql;
            if (txtitemname.textBox1.Text != "")
            {
                Where = Where + "and itemname like'%" + txtitemname.textBox1.Text + "%'"; 
            }
            if(txtsrate.textBox1.Text!="")
            {
                Where = Where + "and srate ='" + txtsrate.textBox1.Text + "'";
            }
            if (txtprate.textBox1.Text != "")
            {
                Where = Where + "and prate like '" + txtprate.textBox1.Text+ "'";
            }
            if(txtitemcode.textBox1.Text!= "")
            {
                Where=Where+="and itemcode like '%"+txtitemcode.textBox1.Text+"%'"; 
            }
            if (txtcategory.textBox1.Text != "")
            {
                Where = Where + " and  Category like '%" + txtcategory.textBox1.Text + "%'"; 
            }
            if (txtmrp.textBox1.Text != "")
            {
                Where = Where + "and mrp like '" + txtmrp.textBox1.Text + "'";
            }
            Ds = _Dbtask.ExecuteQuery(Where);

            GridMain.DataSource=Ds.Tables[0];
              for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "ItemId")
                {
                    GridMain.Columns[i].Visible = false;
                    GridMain.Columns["Category"].Width = 250;
                    GridMain.Columns["ItemCode"].Width = 250;
                    GridMain.Columns["ItemName"].Width = 250;

                }
              }
        }
        public void  categoery()
        {
            Sql = "SELECT        TblItemCategory.categoryid, TblItemCategory.Category as Category, tblitemcategory .remarks as Remarks from  TblItemCategory";
           Where = Sql;
           if (txtitemname.textBox1.Text != "")
           {
               Where = Where + " where Category like '%" + txtitemname.textBox1.Text + "%'";
           }
            Ds = _Dbtask.ExecuteQuery(Where);

                 
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "categoryid")
                {
                    GridMain.Columns[i].Visible = false;
                    GridMain.Columns["Category"].Width = 250;
                    GridMain.Columns["Remarks"].Width = 250;
                }
            }
        }
        public void customer()
        {
            GridMain.Columns.Clear();
            Sql = "select   tblaccountledger.lid , tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.email as Email,tblaccountledger.phone as Phone,tblaccountledger.mobile as Mobile from tblaccountledger";
            Where = Sql + " where  agroupid=18";
            if (txtitemname.textBox1.Text != "")
            {
                Where=Where+"and  lname like '%"+txtitemname.textBox1.Text+"%'";
            }
            if (txtmobile.textBox1.Text != "")
            {
                Where=Where+"and mobile like'%"+txtmobile.textBox1.Text+ "%'";
            }
            if (txtemail.textBox1.Text != "")
            {
                Where=Where+"and email like'%"+txtemail.textBox1.Text+"%'";
            }
               if (txtphoneno.textBox1.Text != "")
            {
                Where=Where+"and phone like '%"+txtphoneno.textBox1.Text +"%'";
            }
               if (txtaddress.textBox1.Text != "")
               {
                   Where = Where + "and address like  '%"+ txtaddress.textBox1.Text +"%'";

               }
            Ds = _Dbtask.ExecuteQuery(Where);
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                {
                    GridMain.Columns[i].Visible = false;
                    GridMain.Columns["Name"].Width = 250;
                    GridMain.Columns["Address"].Width = 250;

                    GridMain.Columns["Phone"].Width = 250;
                    GridMain.Columns["Mobile"].Width = 250;
                }
            }
        }
        public void supplier()
        {
            GridMain.Columns.Clear();
            Sql = "select   tblaccountledger.lid , tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.email as Email,tblaccountledger.phone as Phone,tblaccountledger.mobile as Mobile from tblaccountledger";
            Where = Sql + " where  agroupid=19";
            if (txtitemname.textBox1.Text != "")
            {
                Where = Where + "and  lname like '%" + txtitemname.textBox1.Text + "%'";
            }
            if (txtmobile.textBox1.Text != "")
            {
                Where = Where + "and mobile like'%" + txtmobile.textBox1.Text + "%'";
            }
            if (txtemail.textBox1.Text != "")
            {
                Where = Where + "and email like '%" + txtemail.textBox1.Text + "%'";
            }
            if (txtphoneno.textBox1.Text != "")
            {
                Where = Where + "and phone like '%" + txtphoneno.textBox1.Text + "%'";
            }
            if (txtaddress.textBox1.Text != "")
            {
                Where = Where + "and address like' %" + txtaddress.textBox1.Text + "%'";

            }
            Ds = _Dbtask.ExecuteQuery(Where);
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                    GridMain.Columns[i].Visible = false;
                GridMain.Columns["Name"].Width = 250;
                GridMain.Columns["Address"].Width = 250;

                GridMain.Columns["Phone"].Width = 250;
                GridMain.Columns["Mobile"].Width = 250;
            }
 
        }
        public void Employee()
        {
            GridMain.Columns.Clear();



            Sql = "select   tblemployeemaster.Empid ,tblemployeemaster.Empname as Name,tblemployeemaster.Address as Address,tblemployeemaster.email as Email ,tblemployeemaster.phone as Phone,tblemployeemaster.mobile as Mobile from tblemployeemaster";
    Where = Sql + " where empid !=''";
    if (txtitemname.textBox1.Text != "")
    {
        Where = Where + "and  empname like '%" + txtitemname.textBox1.Text + "%'";
    }
    if (txtmobile.textBox1.Text != "")
    {
        Where = Where + "and mobile = '%" + txtmobile.textBox1.Text + "%'";
    }
    if (txtemail.textBox1.Text != "")
    {
        Where = Where + "and email like'%" + txtemail.textBox1.Text + "%'";
    }
    if (txtphoneno.textBox1.Text != "")
    {
        Where = Where + "and phone like'%" + txtphoneno.textBox1.Text + "%'";
    }
    if (txtaddress.textBox1.Text != "")
    {
        Where = Where + "and address like '%" + txtaddress.textBox1.Text + "%'";

    }
    Ds = _Dbtask.ExecuteQuery(Where);
    GridMain.DataSource = Ds.Tables[0];
         
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Empid")
                {
                    //GridMain.Columns["Empcode"].Visible = false;
                    GridMain.Columns[i].Visible = false;
                    GridMain.Columns["Name"].Width = 250;
                    GridMain.Columns["Address"].Width = 250;
                    GridMain.Columns["Phone"].Width = 200;
                    GridMain.Columns["Mobile"].Width = 200;
                }

            }
        

        }
        public void Agent()
        {
            GridMain.Columns.Clear();


            Sql = "select   tblaccountledger.lid , tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.email as Email,tblaccountledger.phone as Phone,tblaccountledger.mobile  as Mobile from tblaccountledger ";
            Where = Sql + " where  agroupid=29";
            if (txtitemname.textBox1.Text != "")
            {
                Where = Where + "and  lname like '%" + txtitemname.textBox1.Text + "%'";
            }
            if (txtmobile.textBox1.Text != "")
            {
                Where = Where + "and mobile like'%" + txtmobile.textBox1.Text + "%'";
            }
            if (txtemail.textBox1.Text != "")
            {
                Where = Where + "and email like '%" + txtemail.textBox1.Text + "%'";
            }
            if (txtphoneno.textBox1.Text != "")
            {
                Where = Where + "and phone like '%" + txtphoneno.textBox1.Text + "%'";
            }
            if (txtaddress.textBox1.Text != "")
            {
                Where = Where + "and address like' %" + txtaddress.textBox1.Text + "%'";

            }
            Ds = _Dbtask.ExecuteQuery(Where);
            GridMain.DataSource = Ds.Tables[0];
            
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                {
                    GridMain.Columns[i].Visible = false;
                    GridMain.Columns["Name"].Width = 250;
                    GridMain.Columns["Address"].Width = 250;
                    GridMain.Columns["Phone"].Width = 200;
                    GridMain.Columns["Mobile"].Width = 200;
                }
            }
        }
        public void ledger()
        {
            GridMain.Columns.Clear();



            Sql = "select   tblaccountledger.lid , tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.email as Email,tblaccountledger.phone as Phone ,tblaccountledger.mobile as Mobile from tblaccountledger";
           Where =Sql;

           if (txtitemname.textBox1.Text != "")
           {
               Where = Where + " where lname like '%" + txtitemname.textBox1.Text + "%'";
           }
           
           Ds = _Dbtask.ExecuteQuery(Where);
      
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                    GridMain.Columns[i].Visible = false;
                GridMain.Columns["Name"].Width = 250;
                GridMain.Columns["Address"].Width = 250;
                GridMain.Columns["Phone"].Width = 200;
                GridMain.Columns["Mobile"].Width = 200;
            }
 
        }
        public void ledgergroup()
        {
            GridMain.Columns.Clear();
          

            Sql="select   tblaccountledger.lid , tblaccountledger.lname as LedgerGroup,tblaccountledger.lname as UNDER from tblaccountledger ";
            Where = Sql;
            if (txtitemname.textBox1.Text != "")
            {
                Where = Where + " where lname like '%" + txtitemname.textBox1.Text + "%'";
            }
            Ds = _Dbtask.ExecuteQuery(Where);
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                    GridMain.Columns[i].Visible = false;
                GridMain.Columns["LedgerGroup"].Width = 250;
                GridMain.Columns["UNDER"].Width = 250;

            }
        }
        public void Salesinmain(string Vnno, string Vtype, string Lid, string Text)
        {

            GridMain.Columns.Clear();
            // Lblheading.Text = "Sales List";
            Sql = "SELECT    TblBusinessIssue.vno as Vno,TblBusinessIssue.issuecode as IssueCode ,TblBusinessIssue.issuetype as Vtype,TblBusinessIssue.ledcodecr  as LedcodeCr," +
                     " TblBusinessIssue.issuedate as Date ,  " +
                     " TblBusinessIssue.amt  as  BillAmount, " +
                     " TblBusinessIssue.tename as Party from  TblBusinessIssue ";
            Where = Sql + " where issuetype='SI' and issuedate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "' and TblBusinessIssue.ledcodecr="+Lid+"";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by issuecode asc ";


            Ds = _Dbtask.ExecuteQuery(Where);


            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["LedcodeCr"].Visible = false;
                    GridMain.Columns["IssueCode"].Visible = false;


                    //  GridMain.Columns[i].Visible = false; 
                    GridMain.Columns["BillAmount"].Width = 300;
                    GridMain.Columns["Date"].Width = 250;
                    GridMain.Columns["Party"].Width = 250;

                  
                }
            }
        }

        public void Salesreturnmain(string Vnno, string Vtype, string Lid, string Text)
        {

            GridMain.Columns.Clear();
            //Lblheading.Text = "Sales Return List";
           Sql="SELECT      tbltransactionreceipt .vno as Vno, tbltransactionreceipt.recpttype as Vtype, tbltransactionreceipt.reptcode as reptcode, tbltransactionreceipt.ledcodedr  as ledcodedr," +
                    " tbltransactionreceipt .recptdate as Date , " +
                    " tbltransactionreceipt.amt as BillAmount ," +
                    " tbltransactionreceipt .tename as Party from  tbltransactionreceipt";

           Where = Sql + " where recpttype='SR' and recptdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
          " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by reptcode asc ";


            Ds = _Dbtask.ExecuteQuery(Where);

            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                    GridMain.Columns["ledcodedr"].Visible = false;
                GridMain.Columns["reptcode"].Visible = false;
                //GridMain.Columns[i].Visible = false;
                GridMain.Columns["BillAmount"].Width = 300;
                GridMain.Columns["Date"].Width = 250;
                GridMain.Columns["Party"].Width = 250;



            }
        }
        public void SalesOrder(string Vtype)
        {
          
            GridMain.Columns.Clear();
         
            Sql="SELECT    TblBusinessIssue.vno as Vno,TblBusinessIssue.issuecode as IssueCode ,TblBusinessIssue.issuetype as Vtype,TblBusinessIssue.ledcodecr  as LedcodeCr,"+
             " TblBusinessIssue.issuedate as Date ,  "+
             " TblBusinessIssue.amt  as  BillAmount, " +
             " TblBusinessIssue.tename as Party from  TblBusinessIssue";
    
            Where = Sql + " where issuetype='SO'  and issuedate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by issuecode asc ";


            Ds = _Dbtask.ExecuteQuery(Where);

            
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["LedcodeCr"].Visible = false;
                    GridMain.Columns["IssueCode"].Visible = false;


                    //  GridMain.Columns[i].Visible = false; 
                    GridMain.Columns["BillAmount"].Width = 300;
                    GridMain.Columns["Date"].Width = 250;
                    GridMain.Columns["Party"].Width = 250;
                }

               
            }
        }

        public void Purchaseinmain(string Vnno, string Vtype, string Lid, string Text)
        {

            GridMain.Columns.Clear();
            // Lblheading.Text = "Purchase List";
            Sql = "SELECT      tbltransactionreceipt .vno as Vno, tbltransactionreceipt.recpttype as Vtype, tbltransactionreceipt.reptcode as reptcode, tbltransactionreceipt.ledcodedr  as ledcodedr," +
           " tbltransactionreceipt .recptdate as Date , " +
           " tbltransactionreceipt.amt as BillAmount ," +
           " tbltransactionreceipt .tename as Party from  tbltransactionreceipt";

            Where = Sql + " where recpttype='PI' and recptdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'and tbltransactionreceipt.ledcodedr="+Lid+"";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by reptcode asc ";

            Ds = _Dbtask.ExecuteQuery(Where);

            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                    GridMain.Columns["ledcodedr"].Visible = false;
                GridMain.Columns["reptcode"].Visible = false;
                //GridMain.Columns[i].Visible = false;
                GridMain.Columns["BillAmount"].Width = 300;
                GridMain.Columns["Date"].Width = 250;
                GridMain.Columns["Party"].Width = 250;

            }
        }

        public void Purchasereturninmain(string Vnno, string Vtype, string Lid, string Text)
        {

            GridMain.Columns.Clear();
            // Lblheading.Text = "Purchase List";

            Sql = "SELECT    TblBusinessIssue.vno as Vno,TblBusinessIssue.issuecode as IssueCode ,TblBusinessIssue.issuetype as Vtype,TblBusinessIssue.ledcodecr  as LedcodeCr," +
             " TblBusinessIssue.issuedate as Date ,  " +
             " TblBusinessIssue.amt as  BillAmount, " +
             " TblBusinessIssue.tename as Party from  TblBusinessIssue ";

            Where = Sql + " where issuetype='PR'  and issuedate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by issuecode asc ";

            Ds = _Dbtask.ExecuteQuery(Where);
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["LedcodeCr"].Visible = false;
                    GridMain.Columns["IssueCode"].Visible = false;


                    //  GridMain.Columns[i].Visible = false; 
                    GridMain.Columns["BillAmount"].Width = 300;
                    GridMain.Columns["Date"].Width = 250;
                    GridMain.Columns["Party"].Width = 250;
                }

            }
        }
        public void PurchaseOrder(string Vtype)
        {
            Sql = "SELECT      tbltransactionreceipt .vno as Vno, tbltransactionreceipt.recpttype as Vtype, tbltransactionreceipt.reptcode as reptcode, tbltransactionreceipt.ledcodedr  as ledcodedr," +
          " tbltransactionreceipt .recptdate as Date , " +
          " tbltransactionreceipt.amt as BillAmount ," +
          " tbltransactionreceipt .tename as Party from  tbltransactionreceipt";

            Where = Sql + " where recpttype='PO'and recptdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }

            Where = Where + " order by reptcode asc ";


            Ds = _Dbtask.ExecuteQuery(Where);


            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                    GridMain.Columns["ledcodedr"].Visible = false;
                GridMain.Columns["reptcode"].Visible = false;
                //GridMain.Columns[i].Visible = false;
                GridMain.Columns["BillAmount"].Width = 300;
                GridMain.Columns["Date"].Width = 250;
                GridMain.Columns["Party"].Width = 250;

            }}

        public void Receiptshow(string Vtype)
            {
                 
           // GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            //Lblheading.Text = Text +" List";


            Sql = "select   tblgeneralledger.vno as Vno ,tblgeneralledger.Vtype, tblgeneralledger.ledcode, tblgeneralledger.vdate as Vdate,tblgeneralledger. dbamt as Amount from tblgeneralledger  ";
            Where = Sql + " where vtype='" + Vtype + "' and     dbamt !=0 and Vdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'";

            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }


            Ds = _Dbtask.ExecuteQuery(Where);


            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["Vdate"].Width = 250;
                    GridMain.Columns["Amount"].Width = 250;
                }
                    GridMain.Columns["ledcode"].Visible = false;
            }
            
        
            }
        public void Payment(string Vtype)
        {
            //  GridMain.Rows.Clear();
            GridMain.Columns.Clear();
          //  Lblheading.Text = Text + " List";

            Sql = "select   tblgeneralledger.vno as Vno , tblgeneralledger.VType,tblgeneralledger.vdate as Vdate,tblgeneralledger.cramt  as Amount from tblgeneralledger  ";
            Where = Sql + " where vtype='" + Vtype + "' and dbamt =0 and Vdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'"; 
            if (txtvno.Text != "")
            {
                Where = Where + " and vno='" + txtvno.Text + "'";
            }
            if (txttename.Text != "")
            {
                Where = Where + " and tename like '%" + LedgerName + "%'";
            }


            Ds = _Dbtask.ExecuteQuery(Where);


            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["Vdate"].Width = 250;
                    GridMain.Columns["Amount"].Width = 250;
                }

            }




        }

   

        public void EditFu()
        {
            try
            {
                string selmasters;
                // if (GridMain.SelectedRows[0].Cells[0].Tag != null && GridMain.SelectedRows.Count > 0)
                if (GridMain.SelectedRows.Count > 0)
                {

                     SelectedNode = GridMain.SelectedRows[0].Cells["Vtype"].Value.ToString();

              
                        if (SelectedNode.ToString() == "SI")/*For Sales*/
                        {
                            frmsalesinvoice _Sales = new frmsalesinvoice();
                            Vcode = GridMain.SelectedRows[0].Cells["issuecode"].Value.ToString();

                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodecr"].Value.ToString();
                            _Sales.Vtype = "SI";
                            
                            _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";




                            FrmReport.ClickCode = Vcode;
                            _Sales.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;


                            _Sales.Isinotherwindow = true;

                            _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Sales.Location = new Point(0, 0);
                            _Sales.MdiParent = this.ParentForm;
                            _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Sales.Show();
                        }


                        if (SelectedNode.ToString() == "PI")/*For Sales*/
                        {
                            Frmpurchase _Purchase = new Frmpurchase();

                            Vcode = GridMain.SelectedRows[0].Cells["reptcode"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();


                            FrmReport.ClickCode = Vcode;
                            _Purchase.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;





                            _Purchase.Isinotherwindow = true;
                            _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Purchase.Location = new Point(0, 0);
                            _Purchase.MdiParent = this.ParentForm;
                            _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Purchase.Show();

                        }
                        if (SelectedNode.ToString() == "SR")/*For Sales*/
                        {
                            Vcode = GridMain.SelectedRows[0].Cells["reptcode"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();
                            frmsalesinvoice _Sales = new frmsalesinvoice();
                            _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";


                            _Sales.Vtype = "SR";
                            FrmReport.ClickCode = Vcode;
                            _Sales.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;

                            _Sales.Isinotherwindow = true;
                            _Sales.Heading = "Sales return";
                            _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Sales.Location = new Point(0, 0);
                            _Sales.MdiParent = this.ParentForm;
                            _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Sales.Show();
                        }
                        if (SelectedNode.ToString() == "SO")
                        {
                            frmsalesinvoice _Sales = new frmsalesinvoice();
                            _Sales.Vtype = "SO";
                            Vcode = GridMain.SelectedRows[0].Cells["issuecode"].Value.ToString();

                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodecr"].Value.ToString();
                            _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
                            FrmReport.ClickCode = Vcode;
                            _Sales.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;


                            _Sales.Isinotherwindow = true;

                            _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Sales.Location = new Point(0, 0);
                            _Sales.MdiParent = this.ParentForm;
                            _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Sales.Show();
                        }


                        if (SelectedNode.ToString() == "PO")
                        {


                            Frmpurchase _Purchase = new Frmpurchase();

                            Vcode = GridMain.SelectedRows[0].Cells["reptcode"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();
                            _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";

                            FrmReport.ClickCode = Vcode;
                            _Purchase.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;



                            _Purchase.Isinotherwindow = true;
                            _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Purchase.Location = new Point(0, 0);
                            _Purchase.MdiParent = this.ParentForm;
                            _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Purchase.Show();


                        }


                        if (SelectedNode.ToString() == "PR")/*For Sales*/
                        {
                            Frmpurchase _Purchase = new Frmpurchase();

                            Vcode = GridMain.SelectedRows[0].Cells["issuecode"].Value.ToString();

                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodecr"].Value.ToString();
                            _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
                            _Purchase.Vtype = "PR";
                            _Purchase.Heading = "Purchase return";
                            FrmReport.ClickCode = Vcode;
                            _Purchase.txtvno.Text = Vno;
                            FrmReport.MainAccount = MainAccount;

                            _Purchase.Isinotherwindow = true;
                            _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                            _Purchase.Location = new Point(0, 0);
                            _Purchase.MdiParent = this.ParentForm;
                            _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                            _Purchase.Show();
                        }
                        /*Receipt*/

                        if (SelectedNode.ToString() == "R" || SelectedNode.ToString() == "DBN" || SelectedNode.ToString() == "JNR")/*For Sales*/
                        {
                            Frmcash _Cash = new Frmcash();
                            // Vtype = SelectedNode.ToString();
                            Vtype = GridMain.SelectedRows[0].Cells["VType"].Value.ToString();
                            if (Vtype == "R")
                                _Cash.mode = 0;
                            else if (Vtype == "DBN")
                                _Cash.mode = 2;
                            else if (Vtype == "JNR")
                                _Cash.mode = 4;

                            _Cash.Vtype = Vtype;
                            _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();

                            // _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells["Vno"].Tag.ToString();
                            Frmcash.Isinotherwindow = true;
                            _Cash.ShowDialog();
                        }
                        if (SelectedNode.ToString() == "P" || SelectedNode.ToString() == "CRN" || SelectedNode.ToString() == "JNP")/*For Sale*/
                        {
                            Frmcash _Cash = new Frmcash();
                            Vtype = GridMain.SelectedRows[0].Cells["VType"].Value.ToString();
                            if (Vtype == "P")
                                _Cash.mode = 1;
                            else if (Vtype == "CRN")
                                _Cash.mode = 3;
                            else if (Vtype == "JNP")
                                _Cash.mode = 5;
                            _Cash.Vtype = Vtype;
                            _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            // _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells[0].Tag.ToString();
                            Frmcash.Isinotherwindow = true;
                            _Cash.ShowDialog();
                        }


                    }
                }
            

            catch
            {
            }
        
        }
        public void editmaster()
        {
            string node;
            try
            {
                if (GridMain.SelectedRows.Count > 0)
                {
                    node = commasters.Text;
                 
                    if (node == "Items")
                    {
                        Frmitems _items = new Frmitems();
                        Frmitems.Itemid = GridMain.SelectedRows[0].Cells["ItemId"].Value.ToString();
                        Frmitems.Isinotherwindow = true;
                        Frmitems.EditMode = true;
                        _items.ShowDialog();
                    }



                    if (node == "Item Category")
                    {
                        Frmitemgroup _ItemGroup = new Frmitemgroup();

                        _ItemGroup.Id = GridMain.SelectedRows[0].Cells["categoryid"].Value.ToString();

                        _ItemGroup.Isinotherwindow = true;
                        _ItemGroup.EditMode = true;
                     
                        _ItemGroup.ShowDialog();
                    }


                     /*for customer*/
                    else if (node == "Customer")
                    {
                        frmcreateledger _CreateLedger = new frmcreateledger();
                        _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
                        Generalfunction.Comeform = "MDICUSTOMER";
                        _CreateLedger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["lid"].Value.ToString());


                        _CreateLedger.Isinotherwindow = true;
                        _CreateLedger.EditMode = true;
                        _CreateLedger.Show();
                    }

                    /*for Supplier*/
                    else if (node == "Supplier")
                    {
                        frmcreateledger _CreateLedger = new frmcreateledger();
                        _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=19 or AGroupId=19";
                        Generalfunction.Comeform = "MDISUPPLIER";
                        _CreateLedger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["lid"].Value.ToString());
                        _CreateLedger.Isinotherwindow = true;
                        _CreateLedger.EditMode = true;
                        _CreateLedger.Show();
                    }

                    /*for Staff*/
                    else if (node == "Employee")
                    {
                        Frmemployees _Employeemaster = new Frmemployees();
                        _Employeemaster.Empid = Convert.ToInt16(GridMain.SelectedRows[0].Cells["Empid"].Value.ToString());
                        _Employeemaster.Isinotherwindow = true;
                        _Employeemaster.EditMode = true;
                        _Employeemaster.Show();
                    }

                     /*For Agent*/
                    else if (node == "Agent")
                    {
                        frmcreateledger _Agent = new frmcreateledger();
                        _Agent.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
                        Generalfunction.Comeform = "MDIAGENT";
                        _Agent.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["lid"].Value.ToString());
                        _Agent.Isinotherwindow = true;
                        _Agent.EditMode = true;
                        _Agent.Show();
                    }

                     /*For Ledger*/
                    else if (node == "Ledger")
                    {
                        frmcreateledger _ledger = new frmcreateledger();
                        _ledger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["lid"].Value.ToString());
                        _ledger.Isinotherwindow = true;
                        _ledger.EditMode = true;
                        _ledger.Show();
                    }

                     /*For LedgerGroup*/
                    else if (node == "Ledger Group")
                    {
                        frmaccountGroup _Accountgroup = new frmaccountGroup();
                        _Accountgroup.TxtId.Text = GridMain.SelectedRows[0].Cells["lid"].Value.ToString();
                        _Accountgroup.Isinotherwindow = true;
                        _Accountgroup.EditMode = true;
                        _Accountgroup.Show();
                    }
                }

            }
            catch
            { 
            }
        }

          public void DeleteFu()
        {

            try
            {
                DialogResult Result = MessageBox.Show("DELETE SELECTED " + commasters.Text + "", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "Yes")
                {
                    if ( GridMain.SelectedRows.Count > 0)
                    {
                        /*for Itemgroup*/

                      //  string id = GridMain.SelectedRows[0].Cells[0].Tag.ToString();
                        string SelectedNodeName = commasters.Text;
                        //string selectedvtype = GridMain.SelectedRows[0].Cells["Vtype"].Value.ToString();
                   string     selectedvtype = comvtype.Text;


                        bool Isexting;
                        if (SelectedNodeName == "Item Category")
                        {
                            string id = GridMain.SelectedRows[0].Cells["categoryid"].Value.ToString();
                            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where categoryid='" + id + "'");
                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("Its Con't Delete Used already exist");
                            }
                            else
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblitemcategory where categoryid='" + id + "'");
                            }
                        }

                        /*for Item*/
                        if (SelectedNodeName == "Items")
                        {
                            string id = GridMain.SelectedRows[0].Cells["Itemid"].Value.ToString();
                            Ds = _Dbtask.ExecuteQuery("select * from tblreceiptdetails where pcode =" + id + "");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblitemmaster where itemid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
        



           }
                        if (SelectedNodeName == "Customer" || SelectedNodeName == "Supplier" || SelectedNodeName == "Agent" || SelectedNodeName == "Ledger")
                        {
                            string id = GridMain.SelectedRows[0].Cells["lid"].Value.ToString();
                            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode ='" + id + "'");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("Delete from tblaccountledger where lid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        /*for Staff*/
                        if (SelectedNodeName == "Employee")
                        {
                            string id = GridMain.SelectedRows[0].Cells["empid"].Value.ToString();
                            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode ='" + id + "'");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("Delete from tblaccountledger where lid='" + id + "'");
                                _Dbtask.ExecuteNonQuery("Delete from tblemployeemaster where empid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        /*For LedgerGroup*/
                        if (SelectedNodeName == "Ledger Group ")
                        {
                            string id = GridMain.SelectedRows[0].Cells["lid"].Value.ToString();
                            Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger agroupid ='" + id + "'");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("Delete from tblaccountgroup where agroupid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't Delete,already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                        if (selectedvtype == "Sales" || selectedvtype == "PurchaseReturn")
                        {
                            //string Vno;
                            // string Salesaccount;
                            //string Issuecode;

                            // string Vtype = "SI";
                            if (selectedvtype == "Sales")
                                Type = "SI";
                            else if (selectedvtype == "PurchaseReturn")
                                Type = "PR";

                            string Issuecode;
                            string Pvno;
                            string RealVno;

                            string id = GridMain.SelectedRows[0].Cells["issuecode"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["LedcodeCr"].Value.ToString();
                            //RealVno = GridMain.SelectedRows[0].Cells[2].Tag.ToString();
                            //Pvno = _Dbtask.ExecuteScalar("select Pvno from  tblbusinessissue where issuecode='" + Issuecode + "'  and issuetype='" + Vtype + "' and Ledcodecr='" + MainAccount + "'");

                            if(Type == "SI")
                                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + id + "' and sales !=0 and ledcode='" + MainAccount + "'");
                            else if(Type=="PR")
                                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + id + "' and pr !=0 and ledcode='" + MainAccount + "'");


                            _Dbtask.ExecuteNonQuery("delete from tblissuedetails where issuecode='" + id + "' and Ledcode='" + MainAccount + "' and vtype='" + Type + "'");
                            _Dbtask.ExecuteNonQuery("delete from tblbusinessissue where issuecode='" + id + "' and vno='" + Vno + "' and issuetype='" + Type + "' and Ledcodecr='" + MainAccount + "'");

                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Refno='" + MainAccount + "'");
                            /*For Agent*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "'  and Refno='" + MainAccount + "'");
                            /*For Employee*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "'  and Refno='" + MainAccount + "'");

                            /*For Other Expense*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='26' and Refno='" + MainAccount + "'");
                            /*For Discount*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='7' and Refno='" + MainAccount + "'");
                            /*For Tax*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='9' and Refno='" + MainAccount + "'");
                            /*For CST*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='24' and Refno='" + MainAccount + "'");
                        }
                        if (selectedvtype == "Purchase" || selectedvtype == "SalesReturn")
                        {
                            //string Vno;
                    // string Salesaccount;
                            //string Issuecode;


                            if (selectedvtype == "Purchase")
                                Type = "PI";
                            else if (selectedvtype == "SalesReturn")
                                Type = "SR";

                            string Issuecode;
                            string Pvno;
                            string RealVno;

                            Vno = GridMain.SelectedRows[0].Cells["vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();
                           string id = GridMain.SelectedRows[0].Cells["reptcode"].Value.ToString();

                            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where RecptCode='" + id + "' and Ledcode='" + MainAccount + "' and vtype='" + Type + "'");
                            _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where Reptcode='" + id + "' and vno='" + Vno + "' and Recpttype='" + Type + "' and LedcodeDr='" + MainAccount + "' ");

                            if (Type == "PI")
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + id + "' and Ledcode='" + MainAccount + "' and Purchase !=0");
                            }
                            else if (Type == "SR")
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + id + "' and Ledcode='" + MainAccount + "' and Sr !=0");
                            }


                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and refno='" + MainAccount + "'");
                            /*For Batch */
                            //_Dbtask.ExecuteNonQuery("delete from tblbatch where Ledcode='" + PurchaseAccount + "' and recptcode='" + txtvno.Tag + "'");
                            /*For Agent*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "'  and Refno='" + MainAccount + "'");


                            /*For Discount*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='6' and Refno='" + MainAccount + "'");
                            /*For VAT*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='8' and Refno='" + MainAccount + "'");
                            /*For CST*/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='25' and Refno='" + MainAccount + "'");

                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Type + "' and vno='" + Vno + "' and Ledcode='10' and Refno='" + MainAccount + "'");

                        }

                        if (selectedvtype == "Payment" || selectedvtype == "CreditNote" || selectedvtype == "Journal Payment")
                        {
                            string Vtype;
                            if (selectedvtype == "Payment")
                                Vtype = "P";
                            else if (selectedvtype == "CreditNote")
                                Vtype = "CN";
                            else
                                Vtype = "JP";

                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + Vno + "' ");
                        }

                        if (selectedvtype == "Receipt" || selectedvtype == "DebitNote" || selectedvtype == "Journal Receipt")
                        {
                            string Vtype;

                            if (selectedvtype == "Receipt")
                                Vtype = "R";
                            else if (selectedvtype == "DebitNote")
                                Vtype = "DN";
                            else
                                Vtype = "JR";

                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            _Dbtask.ExecuteNonQuery("Delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + Vno + "'");
                        }
                    }

                }
            }

            catch 
            {
            }
          }


        //**************************************supplier and customer list view in grid *********************************

          public void NewWindowFu()
          {
              try
              {


                  /*for Itemgroup*/
                 
                  string SelectedNodeName = commasters.Text;
                  if (SelectedNodeName == "Item Category")
                  {
                      Frmitemgroup _itemgroup = new Frmitemgroup();
                      _itemgroup.ShowDialog();
                  }

                  /*for Item*/
                  if (SelectedNodeName == "Items")
                  {
                      Frmitems _Items = new Frmitems();
                      Frmitems.Isinotherwindow = false;
                      _Items.ShowDialog();
                  }

                  /*for customer*/
                  /*For Supplier*/
                  /*For Ledger*/
                  if (SelectedNodeName == "Customer")
                  {
                      frmcreateledger _CreateLedger = new frmcreateledger();
                      _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
                      Generalfunction.Comeform = "MDICUSTOMER";
                      _CreateLedger.ShowDialog();
                  }

                  if (SelectedNodeName == "Supplier")
                  {
                      frmcreateledger _CreteLedger = new frmcreateledger();
                      _CreteLedger.WheregroupeQuerye = " WHERE AUnder=19 or AGroupId=19";
                      Generalfunction.Comeform = "MDISUPPLIER";

                      _CreteLedger.ShowDialog();
                  }
                  if (SelectedNodeName == "Agent")
                  {
                      frmcreateledger _Agent = new frmcreateledger();
                      _Agent.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
                      Generalfunction.Comeform = "MDIAGENT";
                      _Agent.ShowDialog();
                  }
                  if (SelectedNodeName == "Ledger")
                  {
                      frmcreateledger _Ledger = new frmcreateledger();
                      _Ledger.ShowDialog();
                  }
                  /*for Staff*/
                  if (SelectedNodeName == "Employee")
                  {
                      Frmemployees _Employeemaster = new Frmemployees();
                      _Employeemaster.ShowDialog();
                  }

                  /*For LedgerGroup*/
                  if (SelectedNodeName == "Ledger Group")
                  {
                      frmaccountGroup _LedgerGroup = new frmaccountGroup();
                      _LedgerGroup.ShowDialog();
                  }

                 
              }
              catch
              {
              }
          }
        public void TxtaccountTextchangeworking()
        {
           
        }
       
        // ****************************************Windows maximize***************************************************
        private void frmzatsearch_Load(object sender, EventArgs e)
        {
            clear();

        }
        public void MaxforSett(Form Frm)
        {
            Frm.Size = new System.Drawing.Size(this.Width - 20, this.Size.Height - 90);
        }

        //       ********************************** gridlist content is enter to text box********************************
      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uscGridshow1_Load(object sender, EventArgs e)
        {

        }

        private void GridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void GridMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblsuppiler_Click(object sender, EventArgs e)
        {

        }



        private void lblvtype_Click(object sender, EventArgs e)
        {

        }

        private void cmdsave_Click(object sender, EventArgs e)
        {

        }

        private void cmdclear_Click(object sender, EventArgs e)
        {

        }

        private void cmdclose_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void comvtype_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmdsearch_Click(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txttename_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        

        private void txttename_TextChanged_1(object sender, EventArgs e)
        {
            Selectvtype();

        }

        private void uscGridshow1_Load_1(object sender, EventArgs e)
        {

        }

        private void GridMain_DoubleClick(object sender, EventArgs e)
        {

        }

      
        private void GridMain_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            EditFu();
        }

        private void GridMain_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EditFu();
            editmaster();
        }

    
        private void cmdclear_Click_1(object sender, EventArgs e)
        {
            commasters.Text = "";
            txtitemcode.textBox1.Text = "";
            txtaddress.textBox1.Text = "";
            txtemail.textBox1.Text = "";
            txtmobile.textBox1.Text = "";
            txtcategory.textBox1.Text = "";
            txtitemname.textBox1.Text = "";
            txtmrp.textBox1.Text = "";
            txtprate.textBox1.Text = "";
            txtsrate.textBox1.Text = "";
            comvtype.Text = "";
            comvtype.Enabled = true;
            txttename.Enabled = true;
            txtvno.Enabled = true;
            txtvno.Text = "";
            txttename.Text = "";
        
            GridMain.Columns.Clear();
        }

        private void Gridcustomerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtvno_TextChanged(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void comvtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void cmdsearch_Enter(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void frmzatsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void commasters_TextChanged(object sender, EventArgs e)
        {
            Selectvtype();
           
        }

        private void txtsrate_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtsrate_Enter(object sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtitemname_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();

        }

        private void txtmobile_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtprate_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void commode_Click(object sender, EventArgs e)
        { }

        private void commode_Enter(object sender, EventArgs e)
        {
        }

        private void commode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void commode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selectvtype();

        }

        private void uscnormaltextbox4_Load(object sender, EventArgs e)
        {

        }

        private void txtprate_Load(object sender, EventArgs e)
        {

        }

        private void txtitemcode_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtcategory_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtmrp_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtmobile_TextChanged_1(object Sender, EventArgs e)
        {
            Selectvtype();
        }

     
        private void txtemail_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtphoneno_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtaddress_TextChanged(object Sender, EventArgs e)
        {
            Selectvtype();
        }

        private void txtitemname_TextChanged_1(object Sender, EventArgs e)
        {

            Selectvtype();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeleteFu();
        }

        private void To_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewWindowFu();
        }

        private void grptransaction_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selectvtype();

        }
    }
}