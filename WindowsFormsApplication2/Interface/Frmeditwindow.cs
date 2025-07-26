using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Frmeditwindow : Form
    {
        public Frmeditwindow()
        {
            InitializeComponent();
        }
        int Count;
        RichTextBox RichTextBox1 = new RichTextBox();
        LPrinter MyPrinter = new LPrinter();
        DBTask _Dbtask = new DBTask();
        DataSet Ds = new DataSet();
        NextGFuntion _Nextg = new NextGFuntion();
        DataSet Ds1 = new DataSet();
        ClsItemMaster _Itemmaster = new ClsItemMaster();
       // RichTextBox RichTextBox1 = new RichTextBox();
        string DDay;
        string Month;
        string Year;
        public static string MUserName;
        string Vcode;
        string Vno;
        string MainAccount;

        string Id;
        string Type;
        string DecimalValue;
        string id;

        /*For Audit Log Pass*/
        public string LOldData;
        public string LParty;
        public string Lvtype;
        public DateTime LDate;
        public string LBillamount;
        /*********************************/

        public string Openwindow="";
        private void Frmeditwindow_Load(object sender, EventArgs e)
        {
            _Nextg.FormHeadStyle(pnlHead);
          //  _Nextg.FormImage(pnlImage);
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Clear();
            ChangeLanguage();

            CommonClass._Nextg.FormIcon(this);
        }
        public void ChangeLanguage()
        {
            if (ClsLanguage.IsArabic())
            {
                CommonClass._Language.TreeViewConvertion(TreeMain);
                CommonClass._Language.PanelBasedConversion(panel2);
                CommonClass._Language.PanelBasedConversion(pnlHead);
                CommonClass._Language.PanelBasedConversion(Pnlsearch);
                CommonClass._Language.PanelBasedConversion(pnlsettings);
            }
        }

        public void Vtype()
        {
            /*For Sales */

            Ds = CommonClass._Ledger.VtypeinSales();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Id=Ds.Tables[0].Rows[i]["lid"].ToString();
                Name=Ds.Tables[0].Rows[i]["lname"].ToString();

                TreeMain.Nodes["ndtransaction"].Nodes["ndsales"].Nodes.Add(Id,Name);

                TreeMain.Nodes["ndtransaction"].Nodes["ndsales"].Nodes[Id].Name = "Sales";

                TreeMain.Nodes["ndtransaction"].Nodes["ndsales"].Nodes["Sales"].NodeFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }

            /*For Purchase */
            Ds = CommonClass._Ledger.VtypeinPurchase();
            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Id = Ds.Tables[0].Rows[i]["lid"].ToString();
                Name = Ds.Tables[0].Rows[i]["lname"].ToString();

              TreeMain.Nodes["ndtransaction"].Nodes["ndpurchase"].Nodes.Add(Id,Name);

              TreeMain.Nodes["ndtransaction"].Nodes["ndpurchase"].Nodes[Id].Name = "Purchase";

              TreeMain.Nodes["ndtransaction"].Nodes["ndpurchase"].Nodes["Purchase"].NodeFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void Frmeditwindow_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        

        public void Ledgerinmain(string txt)
        {
           // GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "Ledger List";


            Ds = _Dbtask.ExecuteQuery("select   tblaccountledger.lid AS id, tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.phone as Phone ,tblaccountledger.mobile as Mobile from tblaccountledger  where lname like N'%" + txtsearch.Text + "%' order by tblaccountledger.lid asc");
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

        public void Agentinmain()
        {
           // GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "Agent List";

            Ds = _Dbtask.ExecuteQuery("select   tblaccountledger.lid AS ID, tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.phone as Phone,tblaccountledger.mobile  as Mobile from tblaccountledger WHERE agroupid=29 order by tblaccountledger.lid asc");
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
        public void Staffinmain()
        {
            //GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            Lblheading.Text = "Staff List";

            Ds = _Dbtask.ExecuteQuery("select   tblemployeemaster.Empid as id,tblemployeemaster.Empname as Name,tblemployeemaster.Address as Address,tblemployeemaster.phone as Phone,tblemployeemaster.mobile as Mobile from tblemployeemaster where  Empname like N'%" + txtsearch.Text + "%' order by tblemployeemaster.Empid asc");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
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

        public void Suppliersinmain(string txt)
        {
            //GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "Suppliers List";

            Ds = _Dbtask.ExecuteQuery("select   row_number() over (order by tblaccountledger.lname) as 'Slno' ,tblaccountledger.lid as id, tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.phone as Phone,tblaccountledger.mobile as Mobile from tblaccountledger WHERE agroupid=19 and lname like N'%" + txtsearch.Text + "%' order by tblaccountledger.lname asc");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                    GridMain.Columns[i].Visible = false;
                GridMain.Columns["slno"].Width = 50;
                GridMain.Columns["Name"].Width = 250;
                GridMain.Columns["Address"].Width = 250;
                GridMain.Columns["Phone"].Width = 250;
                GridMain.Columns["Mobile"].Width = 250;
            }
       
 
        }

        public void Customerinmain(string txt)
        {
            Lblheading.Text = "Customers List";

            GridMain.Columns.Clear();
            Ds = _Dbtask.ExecuteQuery("SELECT   row_number() over (order by tblaccountledger.lname) as 'Slno',   TblAccountLedger.Lid AS id, TblAccountLedger.LName AS Name, TblAccountLedger.Address, TblAccountLedger.Phone, TblAccountLedger.Mobile, Tblarea.Aname as 'Area' " +
               " FROM  TblAccountLedger INNER JOIN Tblarea ON TblAccountLedger.Area = Tblarea.Aid "+
               " WHERE     (TblAccountLedger.AGroupId = 18) AND (TblAccountLedger.LName LIKE N'%" + txtsearch.Text + "%' Or Tblarea.Aname LIKE  N'%" + txtsearch.Text + "%')ORDER BY Name ");

           // Ds = _Dbtask.ExecuteQuery("select   row_number() over (order by tblaccountledger.lname) as 'Slno' ,tblaccountledger.lid as id , tblaccountledger.lname as Name,tblaccountledger.address as Address,tblaccountledger.phone as Phone,tblaccountledger.mobile as Mobile from tblaccountledger WHERE agroupid=18 and lname  like '%" + txtsearch.Text + "%' order by tblaccountledger.lname asc ");
            GridMain.DataSource=Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
                    GridMain.Columns[i].Visible = false;
            }
            GridMain.Columns["Slno"].Width = 50;
            GridMain.Columns["Name"].Width = 250;
            GridMain.Columns["Address"].Width = 250;
            GridMain.Columns["Phone"].Width = 150;
            GridMain.Columns["Mobile"].Width = 150;
        }

        public void Partyprojectinmain()
        {
            //  GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "PartyProject List";

            Ds = _Dbtask.ExecuteQuery(" SELECT     Tblpartyproject.pid AS Id,Tblpartyproject.partyid, Tblpartyproject.pname AS [Project Name], Tblpartyproject.Address, Tblpartyproject.Mobile, TblAccountLedger.LName AS Party " +
                " FROM         Tblpartyproject INNER JOIN TblAccountLedger ON Tblpartyproject.partyid = TblAccountLedger.Lid where Tblpartyproject.pname like N'%" + txtsearch.Text + "%' order by Tblpartyproject.pid  asc ");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
                    GridMain.Columns[i].Visible = false;
            }
            GridMain.Columns["Project Name"].Width = 250;
            GridMain.Columns["Party"].Width = 250;
            GridMain.Columns["address"].Width = 250;
            GridMain.Columns["partyid"].Visible = false;
            // GridMain.Columns["UNDER"].Width = 250;

        }

        public void Commisioninmain()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Commision Slab List";
            Ds = CommonClass._commision.Showcommision("");
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["cid"].Width = 50;
            GridMain.Columns["cname"].Width = 200;
            GridMain.Columns["cperc"].Width = 100;
            GridMain.Columns["cfromamount"].Width = 100;
            GridMain.Columns["ctoamount"].Width = 100;
            //GridMain.Columns["cfor"].Width = 100;
        }

        public void Areainmain()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Area List";
            Ds = CommonClass._Area.Showarea("");
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Aid"].Width = 50;
            GridMain.Columns["Aname"].Width = 200;
        }

        public void Unitsinmain()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Units List";
            Ds = CommonClass._Unitcreation.LoadUnit("");
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["id"].Width = 150;
            GridMain.Columns["name"].Width = 200;
            GridMain.Columns["ucount"].Width = 150;
        }
        public void baseunits()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Base Units";
            Ds = CommonClass._base.LoadUnit("");
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["id"].Width = 150;
            GridMain.Columns["name"].Width = 200;

        }

        public void Ledgergroupinmain()
        {
          //  GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "LedgerGroup List";

            Ds = _Dbtask.ExecuteQuery(" select agroupid as id,agroupname from tblaccountgroup where agroupname like N'%" + txtsearch.Text + "%'  ");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
                    GridMain.Columns[i].Visible = false;
            }
            GridMain.Columns["agroupname"].Width = 250;
           // GridMain.Columns["UNDER"].Width = 250;
           
        }

        public void TransactionReceiptinmain(string Vnno, string Vtype, string Id, string Text)
        {
            //GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            Lblheading.Text = Text;
            Ds = _Dbtask.ExecuteQuery("SELECT      tbltransactionreceipt .vno as Vno, tbltransactionreceipt.reptcode as  id, tbltransactionreceipt.ledcodedr  as ledcodedr," +
           " tbltransactionreceipt .recptdate as Date , " +
           " cast(tbltransactionreceipt.amt   as decimal(19," + DecimalValue + "))  as BillAmount ," +
           " tbltransactionreceipt .tename as Party from  tbltransactionreceipt where recpttype='" + Vtype + "' "+
           " and vno like N'%" + txtsearch.Text + "%' and  tbltransactionreceipt.ledcodedr ='"+Id+"'" +
           " and tbltransactionreceipt.recptdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' " +
           " and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "' " +
           " order by cast(tbltransactionreceipt.vno as float) asc ");


            Ds.Tables[0].Rows.Add();
            Count = Ds.Tables[0].Rows.Count - 1;
            DataTable table;
            table = Ds.Tables[0];
            object sumObject;

            sumObject = table.Compute("Sum(BillAmount)", "");
            Ds.Tables[0].Rows[Count]["BillAmount"] = _Dbtask.znlldoubletoobject(sumObject);

            //sumObject = table.Compute("Sum(qty)", "");
            //Ds.Tables[0].Rows[Count]["qty"] = _Dbtask.znlldoubletoobject(sumObject);

            //sumObject = table.Compute("Sum(freeqty)", "");
            //Ds.Tables[0].Rows[Count]["freeqty"] = _Dbtask.znlldoubletoobject(sumObject);

            //sumObject = table.Compute("Sum(taxamt)", "");
            //Ds.Tables[0].Rows[Count]["taxamt"] = _Dbtask.znlldoubletoobject(sumObject);

            GridMain.DataSource = Ds.Tables[0];

            GridMain.Columns["ledcodedr"].Visible = false;
            GridMain.Columns["ID"].Visible = false;
            GridMain.Columns["BillAmount"].Width = 300;
            GridMain.Columns["Date"].Width = 250;
            GridMain.Columns["Party"].Width = 250;
            CommonClass._Clreport.TottalRowStyle(GridMain, Count);

            //GridMain.DataSource = Ds.Tables[0];
            //for (int i = 0; i < GridMain.Columns.Count; i++)
            //{
            //    if (GridMain.Columns[i].Name.ToString() == "id")
            //    {
            //        GridMain.Columns["ledcodedr"].Visible = false;
            //        GridMain.Columns["ID"].Visible = false;



            //        GridMain.Columns["BillAmount"].Width = 300;
            //        GridMain.Columns["Date"].Width = 250;
            //        GridMain.Columns["Party"].Width = 250;
            //        txtsearch.Visible = true;
            //    }
            //}
        }
        public void Receiptinmain(string Text, string Vtype)
        {
            GridMain.Columns.Clear();
            Lblheading.Text = Text +" List";
            txtsearch.Visible = true;

            Ds = _Dbtask.ExecuteQuery("select   tblgeneralledger.vno as Vno , tblgeneralledger.vdate as Vdate,cast(tblgeneralledger.cramt as decimal(19," + DecimalValue + ")) "+
               " as Amount, naration2 as 'Naration' from tblgeneralledger   where vtype='" + Vtype + "' and  dbamt =0 and naration2 "+
            " like N'%" + txtsearch.Text + "%'  and vdate between '"+Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00")+"'"+
            " and  '"+Dtto.Value.ToString("MM/dd/yyyy 23:59:59")+"' "+
            " order by cast( tblgeneralledger.vno as float) asc ");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["Vdate"].Width = 250;
                    GridMain.Columns["Amount"].Width = 250;
                    GridMain.Columns["naration"].Width = 400;
                }
            }
            
        
        }
        public void Paymentinmain(string Text,string Vtype)
        {
          //  GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text =  Text+" List";
            txtsearch.Visible = true;

            Ds = _Dbtask.ExecuteQuery("select   tblgeneralledger.vno as Vno , tblgeneralledger.vdate as Vdate, "+
           " cast(tblgeneralledger.cramt  as decimal(19," + DecimalValue + ")) as Amount,naration2 as 'Naration' from tblgeneralledger   "+
          " where vtype='" + Vtype + "' and  dbamt =0 and  naration2 like N'%"+txtsearch.Text+"%' " +
          " and vdate between '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") +"' and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "' " +
           " order by cast(tblgeneralledger.vno as float) asc ");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "Vno")
                {
                    GridMain.Columns["Vdate"].Width = 250;
                    GridMain.Columns["Amount"].Width = 250;
                    GridMain.Columns["naration"].Width = 400; 
                }
                  
            }
         
          

          
        }
        public void BusinessIssueShow(string Vnno,string Vtype,string Lid,string Text)
        {
           // GridMain.Rows.Clear();
            GridMain.Columns.Clear();

            Lblheading.Text = Text;
            


            Ds = _Dbtask.ExecuteQuery("SELECT    TblBusinessIssue.vno as Vno,TblBusinessIssue.issuecode  as id,TblBusinessIssue.ledcodecr  as LedcodeCr,"+
             " TblBusinessIssue.issuedate as Date ,  "+
             " cast(TblBusinessIssue.amt   as decimal(19," + DecimalValue + ")) as  BillAmount, " +
             " TblBusinessIssue.tename as Party from  TblBusinessIssue    where issuetype='" + Vtype + "' and  (vno like N'%" + txtsearch.Text + "%'  or tename like N'%" + txtsearch.Text + "%')" +
          " and TblBusinessIssue.ledcodecr='" + Lid + "' and TblBusinessIssue.issuedate between " +
          " '" + Dtfrom.Value.ToString("MM/dd/yyyy 00:00:00") + "' and '" + Dtto.Value.ToString("MM/dd/yyyy 23:59:59") + "'" +
           " order by cast(TblBusinessIssue.vno as float) asc");

            Ds.Tables[0].Rows.Add();
            Count = Ds.Tables[0].Rows.Count - 1;
            DataTable table;
            table = Ds.Tables[0];
            object sumObject;

            sumObject = table.Compute("Sum(BillAmount)", "");
            Ds.Tables[0].Rows[Count]["BillAmount"] = _Dbtask.znlldoubletoobject(sumObject);

            GridMain.DataSource = Ds.Tables[0];

            GridMain.Columns["ledcodecr"].Visible = false;
            GridMain.Columns["ID"].Visible = false;
            GridMain.Columns["BillAmount"].Width = 300;
            GridMain.Columns["Date"].Width = 250;
            GridMain.Columns["Party"].Width = 250;
            CommonClass._Clreport.TottalRowStyle(GridMain, Count);
            //GridMain.DataSource = Ds.Tables[0];
            //for (int i = 0; i < GridMain.Columns.Count; i++)
            //{
            //    if (GridMain.Columns[i].Name.ToString() == "Vno")
            //    {
            //        GridMain.Columns["LedcodeCr"].Visible = false;
            //        GridMain.Columns["ID"].Visible = false;


            //      //  GridMain.Columns[i].Visible = false; 
            //        GridMain.Columns["BillAmount"].Width = 300;
            //        GridMain.Columns["Date"].Width = 250;
            //        GridMain.Columns["Party"].Width = 250;
            //    }
                    
            //}

            
            txtsearch.Visible = true;
        }
        public void tailordetails(string txt)
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Dress designing details";
            Ds = _Dbtask.ExecuteQuery("select lid as ID,Vno as Vno,cname as Customer,Ardate as Arrived,Deldate as Delyvery from tbltaillor  " +
                         " where (tbltaillor.cname LIKE N'%" + txtsearch.Text + "%' Or tbltaillor.lid LIKE  N'%" + txtsearch.Text + "%')order by vno asc");
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "lid")
                    GridMain.Columns[i].Visible = false;
            }
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["ID"].Width = 100;
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Vno"].Width = 100;
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Customer"].Width = 200;
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Arrived"].Width = 180;
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Delyvery"].Width = 180;
            txtsearch.Visible = true;

        }
        public void racksshow()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Rack";

            Ds = _Dbtask.ExecuteQuery("SELECT  rid,rack  from tblrack order by rid asc");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                //if (GridMain.Columns[i].Name.ToString() == "cid")
                //    GridMain.Columns[i].Visible = false;
            }
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["rack"].Width = 250;
            GridMain.Columns["rid"].Width = 100;
        }
        public void colorsshow()
        {
            GridMain.Columns.Clear();
            Lblheading.Text = "Colors";

            Ds = _Dbtask.ExecuteQuery("SELECT  cid,cname as Color from tblcolor order by cname asc");
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "cid")
                    GridMain.Columns[i].Visible = false;
            }
            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Color"].Width = 250;
        }
        public void Categoryinmain()
        {
           // GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "ItemCategory List";

            Ds = _Dbtask.ExecuteQuery("SELECT   TblItemCategory.categoryid as id, TblItemCategory.Category as Category, tblitemcategory .remarks as Remarks from  TblItemCategory order by categoryid asc");
                 
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
                    GridMain.Columns[i].Visible = false;
                GridMain.Columns["Category"].Width = 250;
                GridMain.Columns["Remarks"].Width = 250;
            }
          
        }

        public void Manufacturerinmain()
        {
            // GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            Lblheading.Text = "Manufacturer List";

            Ds = _Dbtask.ExecuteQuery("SELECT  Mid as id ,Mname from tblmanufacturer order by mid asc");

            GridMain.DataSource = Ds.Tables[0];
            GridMain.Columns["Mname"].Width = 250;

        }
        public void Itemsinmain()
        {
            //  GridMain.Rows.Clear();
            GridMain.Columns.Clear();
            string txt = txtsearch.Text;
            GridMain.DataSource = null;

            string which = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='103' and menuname='batch'");
            if (which == "-1")
            {

                Ds = _Dbtask.ExecuteQuery("SELECT        TblItemCategory.Category as Category, TblItemMaster.ItemId  as id, TblItemMaster.Itemcode as ItemCode, TblItemMaster.ItemName as ItemName, TblItemMaster.llang , TblItemMaster.MRP, TblItemMaster.SRate,  " +
                          " TblItemMaster.PRate FROM            TblItemMaster INNER JOIN  TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId  where itemcode like '%" + txtsearch.Text + "%' or itemname like '%" + txtsearch.Text + "%' " +
                  " order by TblItemMaster.itemid asc ");

            }
            else
            {

                Ds = _Dbtask.ExecuteQuery(" Select Tblbatch.Bcode As Batch, TblItemCategory.Category, TblItemMaster.ItemId AS id, TblItemMaster.Itemcode AS ItemCode, TblItemMaster.ItemName,TblItemMaster.llang, Tblbatch.MRP,Tblbatch.SRate as Salerate,Tblbatch.prate as Purchaserate,  " +
                      " TblItemMaster.PRate FROM            TblItemMaster INNER JOIN TblItemCategory ON TblItemMaster.CategoryId = TblItemCategory.CategoryId INNER JOIN Tblbatch ON TblItemMaster.ItemId = Tblbatch.itemid   where itemcode like N'%" + txtsearch.Text + "%' or itemname like N'%" + txtsearch.Text + "%' or Tblbatch.Bcode Like N'%" + txtsearch.Text + "%'" +
              " order by TblItemMaster.itemid asc ");

            }
            GridMain.DataSource = Ds.Tables[0];
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                if (GridMain.Columns[i].Name.ToString() == "id")
                {
                    GridMain.Columns[i].Visible = false;
                }
                if (GridMain.Columns[i].Name.ToString() == "Batch")
                {
                    GridMain.Columns["Batch"].Width = 230;
                }

            }
            GridMain.Columns["Category"].Width = 200;
            GridMain.Columns["ItemCode"].Width = 250;
            GridMain.Columns["ItemName"].Width = 250;
            GridMain.Columns["llang"].Width = 250;
        }
        public void permissionenable(string nodename)
        {
            string enabling = "";
            enabling = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='178' ").ToString();
            if (nodename == "Ndsales" && enabling == "-1")
            {
                cmddelete.Enabled = false;
            }
            else if (nodename == "Ndcashpayment" || nodename == "Ndcashreceipt" || nodename == "Ndsalesreturn" || nodename == "Ndsalesorder" || nodename == "Ndpurchase" || nodename == "Ndpurchasereturn" || nodename == "Ndpurchaseorder" || nodename == "Nddebitnote" || nodename == "Ndcreditnote" || nodename == "Ndjournelreceipt" || nodename == "Ndjournelpayment" || nodename == "Ndsales")
            {
                if (CommonClass._UserDetails.Permitedblock() == false)
                {

                    cmddelete.Enabled = false;
                }


                
            }

            else
            {
                cmddelete.Enabled = true;
            }

        }

        private void TreeMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeviewSelect(TreeMain.SelectedNode.Name.ToString());
        }
        public void TreeviewSelect(string txt)
        {
            GridMain.DataSource = null;
            DecimalValue=CommonClass._Paramlist.GetParamvalue("CurDecc");
            //  TreeMain.SelectedNode.BackColor = System.Drawing.Color.Silver;
            /*Masters*/
            try
            {
                CommonClass._commenevent.WaitCursor(this);

                string SelectedNode = txt;

                permissionenable(SelectedNode);
                if (SelectedNode == "Ndmanufacturer")/*For Item Category*/
                {
                    Manufacturerinmain();
                }

                if (SelectedNode == "Ndcategory")/*For Item Category*/
                {
                    Categoryinmain();
                }
                if (SelectedNode == "Ndcolor")
                {
                    colorsshow();
                }

                if (SelectedNode == "Ndrack")
                {
                    racksshow();
                }

                if (SelectedNode == "NdDesigning")
                {
                    tailordetails("");
                }
                



                else if (SelectedNode == "Nditems")/*For Items*/
                {
                    Itemsinmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

                else if (SelectedNode == "Ndcustomer")/*For Customer*/
                {
                    Customerinmain("");
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

                else   if (SelectedNode == "NdSuppliers")/*For Supplier*/
                {
                    Suppliersinmain("");
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

                else if (SelectedNode == "Ndstaff")/*For Staff*/
                {
                    Staffinmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

                else if (SelectedNode == "NdAgent")/*For Agent*/
                {
                    Agentinmain();
                }

                else if (SelectedNode == "Ndledger")/*For Ledger*/
                {
                    Ledgerinmain("");
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

               else if (SelectedNode == "NdLedgerGroup")/*For LedgerGroup*/
                {
                    Ledgergroupinmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }
                else if (SelectedNode == "Ndpartyproject")/*For Party project*/
                {
                    Partyprojectinmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }
                else if (SelectedNode == "Ndunits")/*For multiunits*/
                {
                    Unitsinmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }
                else if (SelectedNode == "Ndbaseunit")/*For multiunits*/
                {
                    baseunits();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }


                else if (SelectedNode == "Ndcommision")/*For Commision slab*/
                {
                    Commisioninmain();
                    txtsearch.Visible = false;
                    lblsearch.Visible = false;
                }
                else if (SelectedNode == "Ndarea")/*For Area*/
                {
                    Areainmain();
                    txtsearch.Visible = true;
                    lblsearch.Visible = true;
                }

                /*Transaction*/

                else if (SelectedNode == "Ndsales" || SelectedNode == "Sales")/*For Sales*/
                {
                    Type = "SI";

                    BusinessIssueShow("", "SI", _Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + TreeMain.SelectedNode.Tag + "'"), "Sales");
                    Lblheading.Text ="Sales  Invoice";

                }
                else if (SelectedNode == "Ndservices" )/*For Services*/
                {
                    Type = "SV";
                    BusinessIssueShow("", "SV", "14", "Services");
                    Lblheading.Text = "Services";

                }
                else if (SelectedNode == "Ndsalesorder")/*For Sales Order*/
                {
                    Type = "SO";
                    BusinessIssueShow("", "SO", "2", "Sales order");
                    Lblheading.Text = "Sales Order";

                }
                else if (SelectedNode == "Nddeliverynote")/*For Delivery Not*/
                {
                    Type = "DN";
                    BusinessIssueShow("", "DN", "2", "Delivery Note");
                    Lblheading.Text = "Delivery Note";

                }
               else if (SelectedNode == "Ndsalesreturn")/*For Sales return*/
                {
                    Type = "SR";
                    TransactionReceiptinmain("", "SR","2","Sales return");
                    Lblheading.Text = "Sales return";

                }
               else if (SelectedNode == "Ndpurchase" ||SelectedNode=="Purchase")/*For Purchase*/
                {
                    Type = "PI";
                    TransactionReceiptinmain("","PI",_Dbtask.ExecuteScalar("select lid from tblaccountledger where lname='" + TreeMain.SelectedNode.Tag + "'"),"Purchase");
                    Lblheading.Text = "Purchase";

                }
                else if (SelectedNode == "Ndpurchaseorder")/*For Purchase*/
                {
                    Type = "PO";
                    TransactionReceiptinmain("", "PO", "3", "Purchase");
                    Lblheading.Text = "Purchase order";

                }
               else if (SelectedNode == "Ndpurchasereturn")/*For Purchase return*/
                {
                    Type = "PR";
                    BusinessIssueShow("", "PR","3","Purchase return");
                    Lblheading.Text ="Purchase Return";

                }
               else if (SelectedNode == "Ndcashreceipt")/*For Cash receipt*/
                {
                    Type = "R";
                    Receiptinmain("Receipt","R");
                    Lblheading.Text = "Receipt ";
                    txtsearch.Visible = true;
                }
               else if (SelectedNode == "Nddebitnote")/*For Debit Note*/
                {
                    Type = "DBN";
                    Lblheading.Text = "DebitNote ";

                        Receiptinmain("Debit Note","DBN");
                }

                else if (SelectedNode == "Ndcreditnote")/*For Credit Note*/
                {
                    Type = "CRN";
                    Paymentinmain("Credit Note","CRN");
                    Lblheading.Text = "Credit Note ";
                    txtsearch.Visible = true;
                }

                else if (SelectedNode == "Ndjournelreceipt")/*For Journel receipt*/
                {
                    Type = "JNR";
                    Lblheading.Text = "Journel receipt" ;
                    Receiptinmain("Journel Receipt","JNR");
                }

                else if (SelectedNode == "Ndjournelpayment")/*For Journel Payment*/
                {
                    Type = "JNP";
                    Paymentinmain("Journel Payment","JNP");
                    Lblheading.Text = "Journel Payment";
                    txtsearch.Visible = true;
                }

                else if (SelectedNode == "Ndcashpayment")/*For Cash payment*/
                {
                    Type = "P";
                    Lblheading.Text = "Cash Payment";
                    Paymentinmain("Payment","P");
                }
                else if (TreeMain.SelectedNode.Parent.Text == "Sales")
                {
                    Type = "SI";
                    Id = TreeMain.SelectedNode.Name.ToString();
                    Name = CommonClass._Ledger.GetspecifField("lname", Id);
                    BusinessIssueShow("", "SI",Id, Name);
                    Lblheading.Text = Name+"  Invoice";
                }
                else if (TreeMain.SelectedNode.Parent.Text == "Purchase")
                {
                    Type = "PI";
                    Id = TreeMain.SelectedNode.Name.ToString();
                    Name = CommonClass._Ledger.GetspecifField("lname", Id);
                    TransactionReceiptinmain("", "PI", Id, Name);
                    Lblheading.Text = Name + "  Invoice";

                }

                CommonClass._commenevent.NormalCursor(this);
            }
            catch
            {
            }
        }

       
   
        public void EditFu()
        {
            try
            {
                string SelectedNode;

                if ( GridMain.SelectedRows.Count > 0)
                {
                    SelectedNode = TreeMain.SelectedNode.Name.ToString();

                    if (SelectedNode == "Ndmanufacturer")
                    {
                        FrmManufacturer _Manu = new FrmManufacturer();
                        _Manu.Vno = GridMain.SelectedRows[0].Cells["mid"].Value.ToString();
                        FrmManufacturer.Isinotherwindow = true;
                        _Manu.ShowDialog();
                    }
                    if (SelectedNode == "Ndcommision")
                    {
                        Frmcommision _commision = new Frmcommision();
                        _commision.Cid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["cid"].Value.ToString());
                        _commision.Isinotherwindow = true;
                        _commision.ShowDialog();
                    }

                    if (SelectedNode == "Ndrack")
                    {
                        Frmrack _rack = new Frmrack();
                        _rack.rid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["rid"].Value);
                        _rack.EditMode = true;
                        _rack.Isinotherwindow = true;
                        _rack.ShowDialog();

                    }
                    if (SelectedNode == "Ndarea")
                    {
                        Frmareacreate _Area = new Frmareacreate();
                        _Area.Aid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["Aid"].Value.ToString());
                        _Area.Isinotherwindow = true;
                        _Area.ShowDialog();
                    }

                    /*For Units*/
                    if (SelectedNode == "Ndunits")
                    {
                        Frmunitcreation _Unit = new Frmunitcreation();
                        _Unit.Id =Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                        _Unit.Isinotherwindow = true;
                        _Unit.ShowDialog();
                    }

                    if (SelectedNode == "NdDesigning")
                    {
                        FrmDesigning _desgn = new FrmDesigning();
                        _desgn.txtvno.Text = Convert.ToInt64(GridMain.SelectedRows[0].Cells["Vno"].Value).ToString();
                        _desgn.EditMode = true;
                        _desgn.Isinotherwindow = true;
                        _desgn.ShowDialog();

                    }

                    if (SelectedNode == "Ndbaseunit")
                    {
                        FrmBaseunit _frm = new FrmBaseunit();
                        _frm.Id = Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                        _frm.Isinotherwindow = true;
                        _frm.editmode = true;
                        _frm.ShowDialog();
                    }
                    /*for Itemgroup*/
                    if (SelectedNode== "Ndcategory")
                    {
                        Frmitemgroup _ItemGroup = new Frmitemgroup();

                        _ItemGroup.Id = GridMain.SelectedRows[0].Cells["id"].Value.ToString();

                        _ItemGroup.Isinotherwindow = true;
                        _ItemGroup.EditMode = true;
                        //_Items.TxtItemname.Text = GridMain.SelectedRows[0].Cells["Clnitemname"].Value.ToString();
                        //_Items.txtite
                        _ItemGroup.ShowDialog();
                    }

                    /*for Item*/
                  else  if (SelectedNode == "Nditems")
                    {
                        string which1 = _Dbtask.ExecuteScalar("select status from tblmnusettings where menuid='103' and menuname='batch'");

                        if (which1 == "1")
                        {
                            Frmquickadditems _Form = new Frmquickadditems();
                            _Form.EditMode = true;
                            _Form.Id = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                            _Form.Barcode = GridMain.SelectedRows[0].Cells["Batch"].Value.ToString();
                            _Form.Isinotherwindow = true;
                            _Form.ShowDialog();
                        }
                        else
                        {

                            Frmquickadditems _Form = new Frmquickadditems();
                            _Form.EditMode = true;
                            _Form.Id = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                          
                            _Form.Isinotherwindow = true;
                            _Form.ShowDialog();
                        }
                    }

                    /*for customer*/
                    else if (SelectedNode == "Ndcustomer")
                    {
                        frmcreateledger _CreateLedger = new frmcreateledger();
                        _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
                        Generalfunction.Comeform = "MDICUSTOMER";
                        _CreateLedger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                    
                      
                        _CreateLedger.Isinotherwindow = true;
                        _CreateLedger.EditMode = true;
                        _CreateLedger.ShowDialog();
                    }

                    /*for Supplier*/
                  else  if (SelectedNode == "NdSuppliers")
                    {
                        frmcreateledger _CreateLedger = new frmcreateledger();
                        _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=19 or AGroupId=19";
                        Generalfunction.Comeform = "MDISUPPLIER";
                        _CreateLedger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                        _CreateLedger.Isinotherwindow = true;
                        _CreateLedger.EditMode = true;
                        _CreateLedger.ShowDialog();
                    }

                    /*for Staff*/
                  else  if (SelectedNode == "Ndstaff")
                    {
                        Frmemployees _Employeemaster = new Frmemployees();
                        _Employeemaster.Empid = Convert.ToInt16(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                        _Employeemaster.Isinotherwindow = true;
                        _Employeemaster.EditMode = true;
                        _Employeemaster.ShowDialog();
                    }

                    /*For Agent*/
                  else  if (SelectedNode == "NdAgent")
                    {
                        frmcreateledger _Agent = new frmcreateledger();
                        _Agent.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
                        Generalfunction.Comeform = "MDIAGENT";
                        _Agent.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["ID"].Value.ToString());
                        _Agent.Isinotherwindow = true;
                        _Agent.EditMode = true;
                        _Agent.ShowDialog();
                    }

                    /*For Ledger*/
                    else if (SelectedNode == "Ndledger")
                    {
                        frmcreateledger _ledger = new frmcreateledger();
                        _ledger.Ledid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value.ToString());
                        _ledger.Isinotherwindow = true;
                        _ledger.EditMode = true;
                        _ledger.ShowDialog();
                    }

                    /*For LedgerGroup*/
                   else if (SelectedNode == "NdLedgerGroup")
                    {
                        frmaccountGroup _Accountgroup = new frmaccountGroup();
                        _Accountgroup.Id =Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value);
                        _Accountgroup.Isinotherwindow = true;
                        _Accountgroup.EditMode = true;
                        _Accountgroup.ShowDialog();
                    }
                        /*For Party Project*/
                    else if (SelectedNode == "Ndpartyproject")
                    {
                        Frmcustomerprojects _project = new Frmcustomerprojects();
                        _project.Pid = Convert.ToInt64(GridMain.SelectedRows[0].Cells["id"].Value);
                        _project.Isinotherwindow = true;
                        _project.Mobile = GridMain.SelectedRows[0].Cells["mobile"].Value.ToString();
                        _project.Address = GridMain.SelectedRows[0].Cells["address"].Value.ToString();
                        _project.PartyId = Convert.ToInt64(GridMain.SelectedRows[0].Cells["partyid"].Value);
                        _project.ShowDialog();
                    }

                       /*Transaction*/

                    else if (SelectedNode == "Ndsales" || TreeMain.SelectedNode.Parent.Name.ToString() == "Ndsales" || SelectedNode == "Ndsalesorder" || SelectedNode == "Nddeliverynote" || SelectedNode == "Sales" || SelectedNode == "Ndservices")/*For Sales*/
                    {

                        Vcode = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                     
                        Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                        MainAccount = GridMain.SelectedRows[0].Cells["ledcodecr"].Value.ToString();
                        frmsalesinvoice _Sales = new frmsalesinvoice();
                        if(SelectedNode == "Ndsales" || TreeMain.SelectedNode.Parent.Name.ToString() == "Ndsales" )
                        {
                            _Sales.Vtype = "SI";
                        _Sales.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
                        }
                        else if (SelectedNode == "Ndsalesorder")
                        {
                            _Sales.Vtype = "SO";
                            _Sales.Heading = "Sales Order";
                        }
                        else if (SelectedNode == "Nddeliverynote")
                        {
                            _Sales.Vtype = "DN";
                            _Sales.Heading = "Delivery Note";
                        }
                        else if (SelectedNode == "Ndservices")
                        {
                            _Sales.Vtype = "SV";
                            _Sales.Heading = "Services";
                        }

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

                  else  if (SelectedNode == "Ndsalesreturn")/*For Sales*/
                    {
                        Vcode = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                        Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                        MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();
                      

                        frmsalesinvoice _Sales = new frmsalesinvoice();
                        _Sales.Vtype = "SR";
                        FrmReport.ClickCode= Vcode;
                        _Sales.txtvno.Text = Vno;
                        FrmReport.MainAccount = MainAccount;

                        _Sales.Isinotherwindow = true;
                        _Sales.Heading ="Sales return";
                        _Sales.WindowState = System.Windows.Forms.FormWindowState.Normal;
                        _Sales.Location = new Point(0, 0);
                        _Sales.MdiParent = this.ParentForm;
                        _Sales.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                        _Sales.Show();
                    }
                    else if(SelectedNode == "Ndpurchasereturn")
                    {
                        Frmpurchase _Purchase = new Frmpurchase();

                        Vcode = GridMain.SelectedRows[0].Cells["id"].Value.ToString();

                        Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                        MainAccount = GridMain.SelectedRows[0].Cells["ledcodecr"].Value.ToString();
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

                    else if (SelectedNode == "Ndpurchase" || SelectedNode == "Purchase" || SelectedNode == "Ndpurchaseorder" || SelectedNode == "Purchase")/*For Purchase*/
                    {
                            Frmpurchase _Purchase = new Frmpurchase();

                            Vcode = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();

                        if (SelectedNode == "Ndpurchase")
                        {
                            _Purchase.Vtype = "PI";
                            _Purchase.Heading = CommonClass._Ledger.GetspecifField("lname", MainAccount) + " Invoice";
                        }
                      
                        if (SelectedNode == "Ndpurchaseorder")
                        {
                            _Purchase.Vtype = "PO";
                            _Purchase.Heading = "Purchase Order";
                        }

                       
                        FrmReport.ClickCode = Vcode;
                        _Purchase.txtvno.Text = Vno;
                        FrmReport.MainAccount = MainAccount;

                       //_Purchase.PurchaseAccount = MainAccount;


                       //FrmReport.ClickCode = Vcode;
                       //_Purchase.txtvno.Text = Vno;
                       //_Purchase.MainAccount = MainAccount; 
                     


                        _Purchase.Isinotherwindow = true;
                        _Purchase.WindowState = System.Windows.Forms.FormWindowState.Normal;
                        _Purchase.Location = new Point(0, 0);
                        _Purchase.MdiParent = this.ParentForm;
                        _Purchase.Size = new System.Drawing.Size(this.ParentForm.Width - 40, this.ParentForm.Height - 25 - 90);
                        _Purchase.Show();
                    }

                    /*Receipt*/

                    else if (SelectedNode == "Ndcashreceipt" || SelectedNode == "Nddebitnote" || SelectedNode == "Ndjournelreceipt")
                    {
                        Frmcash _Cash = new Frmcash();
                        if(Type=="R")
                        _Cash.mode = 0;
                        else if (Type == "DBN")
                            _Cash.mode = 2;
                        else if (Type == "JNR")
                            _Cash.mode = 4;

                        _Cash.Vtype = Type;
                        _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells["Vno"].Value.ToString();
                      //  _Cash.txtvno.Text = GridMain.SelectedRows[0].Cells[0].Tag.ToString();
                        Frmcash.Isinotherwindow = true;
                        _Cash.ShowDialog();
                    }

                    else if (SelectedNode == "Ndcashpayment" || SelectedNode == "Ndjournelpayment" || SelectedNode == "Ndcreditnote")
                    {
                        Frmcash _Cash = new Frmcash();
                        if (Type == "P")
                            _Cash.mode = 1;
                        else if (Type == "CRN")
                            _Cash.mode = 3;
                        else if (Type == "JNP")
                            _Cash.mode = 5;
                        _Cash.Vtype = Type;
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
        private void GridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditFu();
        }

        private void Frmeditwindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void TreeMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void GridMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeviewSelect(TreeMain.SelectedNode.Name.ToString());
        }
        public void DeleteFu()
        {

            try
            {


                DialogResult Result = MessageBox.Show("DELETE SELECTED " + TreeMain.SelectedNode.Tag + "", CommonClass._GenF.MsgBxValue, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result.ToString() == "Yes")
                {
                    if ( GridMain.SelectedRows.Count > 0)
                    {
                       
                       string SelectedNodeName = TreeMain.SelectedNode.Name.ToString();
                       if (SelectedNodeName == "Ndcashpayment" || SelectedNodeName == "Ndcreditnote" || SelectedNodeName == "Ndjournelpayment" || SelectedNodeName == "Ndcashreceipt" || SelectedNodeName == "Nddebitnote" || SelectedNodeName == "Ndjournelreceipt" )
                       {
                           id = GridMain.SelectedRows[0].Cells["vno"].Value.ToString();
                       }
                       else if(SelectedNodeName == "Ndcommision")
                       {
                           id = GridMain.SelectedRows[0].Cells["cid"].Value.ToString();
                       }
                       else if (SelectedNodeName == "Ndarea")
                       {
                           id = GridMain.SelectedRows[0].Cells["Aid"].Value.ToString();
                       }
                       else 
                       {
                           id = GridMain.SelectedRows[0].Cells["id"].Value.ToString();
                       }
                        /*for Itemgroup*/
                        if (SelectedNodeName == "Ndcategory")
                        {
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
                        if (SelectedNodeName == "Nditems")
                        {
                           
                           Ds=_Dbtask.ExecuteQuery("select * from tblreceiptdetails where pcode ="+id+"");
                            Ds1=_Dbtask.ExecuteQuery("select * from tblissuedetails where pcode="+id+"");
                           if (Ds.Tables[0].Rows.Count == 0&&Ds1.Tables[0].Rows.Count==0)
                           {
                               _Dbtask.ExecuteNonQuery("delete from tblitemmaster where itemid='" + id + "'");
                               string Str;
                               Str =_Dbtask.znllString(GridMain.SelectedRows[0].Cells["Batch"].Value);
                               _Dbtask.ExecuteNonQuery("delete  tblbatch where bcode='" + Str + "'");
                           }
                           else
                           {
                               MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }
                        }


                        if (SelectedNodeName == "Ndbaseunit")
                        {
                        Ds=_Dbtask.ExecuteQuery(" select  tblissuedetails.pcode "+
                                " FROM   tblissuedetails INNER JOIN "+
                           " TblItemMaster ON tblissuedetails.pcode = TblItemMaster.ItemId "+
                             "  WHERE (tblitemmaster.bunit='" + id + "')");

                        if (Ds.Tables[0].Rows.Count == 0)
                        {
                            _Dbtask.ExecuteNonQuery("delete from tblbaseunit where id ='" + id + "'");
                        }
                        else
                        {
                            MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        }

                        /*for customer*/
                        /*For Supplier*/
                        /*For Ledger*/
                        if (SelectedNodeName == "Ndcustomer" || SelectedNodeName == "NdSuppliers" || SelectedNodeName == "NdAgent" || SelectedNodeName == "Ndledger")
                        {
                            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where ledcode ='" + id + "'");
                           if (Ds.Tables[0].Rows.Count == 0)
                           {
                               _Dbtask.ExecuteNonQuery("Delete from tblaccountledger where lid='" + id + "'");
                           
                           MessageBox.Show("deleted");
                           }
                           else
                           {
                               MessageBox.Show("It Can't be Delete,Transaction already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }
                        }

                        /*for Staff*/
                        if (SelectedNodeName== "Ndstaff")
                        {
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
                        if (SelectedNodeName== "NdLedgerGroup")
                        {
                            Ds = _Dbtask.ExecuteQuery("select * from tblaccountledger where agroupid ='" + id + "'");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("Delete from tblaccountgroup where agroupid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't Delete,already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        /*For Party Project*/
                        if (SelectedNodeName == "Ndpartyproject")
                        {
                            Ds = _Dbtask.ExecuteQuery("select * from tblgeneralledger where  pproject ='" + id + "'");
                            if (Ds.Tables[0].Rows.Count == 0)
                            {
                                _Dbtask.ExecuteNonQuery("Delete from Tblpartyproject where pid='" + id + "'");
                            }
                            else
                            {
                                MessageBox.Show("It Can't Delete,already exist", CommonClass._GenF.MsgBxValue, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }



                        if (SelectedNodeName == "Ndsales" || SelectedNodeName == "Ndpurchasereturn" || SelectedNodeName == "Ndsalesorder" || SelectedNodeName == "Sales" || SelectedNodeName == "Ndservices")
                        {
                            //string Vno;
                           // string Salesaccount;
                            //string Issuecode;
                            
                           // string Vtype = "SI";
                            if (SelectedNodeName == "Ndsales")
                            {
                                Type = "SI";
                                Lvtype = "Sales";
                            }
                            else if (SelectedNodeName == "Ndpurchasereturn")
                            {
                                Type = "PR";
                                Lvtype = "Purchase return";
                            }
                            else if (SelectedNodeName == "Ndsalesorder")
                            {
                                Type = "SO";
                                Lvtype = "Sales Order";
                            }
                            else if (SelectedNodeName == "Ndservices")
                            {
                                Type = "SV";
                                Lvtype = "Services";
                            }

                            id = GridMain.SelectedRows[0].Cells["ID"].Value.ToString();
                            Vno = GridMain.SelectedRows[0].Cells["vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["LedcodeCr"].Value.ToString();
                            LParty = GridMain.SelectedRows[0].Cells["party"].Value.ToString();
                            LDate =Convert.ToDateTime(GridMain.SelectedRows[0].Cells["date"].Value);
                            LBillamount = _Dbtask.znllString(GridMain.SelectedRows[0].Cells["billamount"].Value);
                            
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

                            /*For Bill Sett*/
                            _Dbtask.ExecuteNonQuery("delete from tblbillsett where  vno='" + Vno + "' and vtype='" + Type + "' ");

                            /*Bill for Advance*/
                            _Dbtask.ExecuteNonQuery("delete FROM TBLGENERALLEDGER where vtype='R' and slno="+Vno+"  and refno='"+MainAccount+"' ");
                            /*audit Log*/
                            LOldData = "VchNo:" + Vno + ",Party :" + LParty + ",Date:" + LDate.ToString("dd/MM/yyyy") + "Bill Amt :" + LBillamount;
                            CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", Lvtype, LOldData, "");
                        }
                        if (SelectedNodeName == "Ndpurchase" || SelectedNodeName == "Ndpurchaseorder" || SelectedNodeName == "Ndsalesreturn" || SelectedNodeName == "Purchase")
                        {
                            //string Vno;
                            // string Salesaccount;
                            //string Issuecode;


                            if (SelectedNodeName == "Ndpurchase")
                            {
                                Lvtype = "Purchase";
                                Type = "PI";
                            }
                            else if (SelectedNodeName == "Ndsalesreturn")
                            {
                                Lvtype = "Sales return";
                                Type = "SR";
                            }
                            else if (SelectedNodeName == "Ndpurchaseorder")
                            {
                                Lvtype = "Purchase Order";
                                Type = "PO";
                            }

                            Vno = GridMain.SelectedRows[0].Cells["vno"].Value.ToString();
                            MainAccount = GridMain.SelectedRows[0].Cells["ledcodedr"].Value.ToString();
                            id = GridMain.SelectedRows[0].Cells["id"].Value.ToString();

                            _Dbtask.ExecuteNonQuery("delete from tblreceiptdetails where RecptCode='" + id + "' and Ledcode='" + MainAccount + "' and vtype='" + Type + "'");
                            _Dbtask.ExecuteNonQuery("delete from tbltransactionreceipt where Reptcode='" + id + "' and vno='" + Vno + "' and Recpttype='" + Type + "' and LedcodeDr='" + MainAccount + "' ");

                            if (Type == "PI")
                            {
                            _Dbtask.ExecuteNonQuery("delete from tblinventory where vcode='" + id + "' and Ledcode='" + MainAccount + "' and Purchase !=0");
                            }
                            else if(Type=="SR")
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

                            /*Audit Log*/
                                LParty = GridMain.SelectedRows[0].Cells["party"].Value.ToString();
                                LDate = Convert.ToDateTime(GridMain.SelectedRows[0].Cells["date"].Value);
                                LBillamount = _Dbtask.znllString(GridMain.SelectedRows[0].Cells["billamount"].Value);
                                LOldData = "VchNo:" + Vno + ",Party :" + LParty + ",Date:" + LDate.ToString("dd/MM/yyyy") + "Bill Amt :" + LBillamount;
                                CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", Lvtype, LOldData, "");

                            }

                        if (SelectedNodeName == "Ndcashpayment" || SelectedNodeName == "Ndcreditnote" || SelectedNodeName == "Ndjournelpayment")
                        {
                            string Vtype;
                            if (SelectedNodeName == "Ndcashpayment")
                            {
                                Vtype = "P";
                                Lvtype = "Payment";
                            }
                            else if (SelectedNodeName == "Ndcreditnote")
                            {
                                Vtype = "CN";
                                Lvtype = "Receipt";
                            }
                            else
                            {
                                Vtype = "JP";
                                Lvtype = "Journel Payment";
                            }
                            /*Audit Log*/
                            LParty = "";
                            LDate = Convert.ToDateTime(GridMain.SelectedRows[0].Cells["vdate"].Value);
                            LBillamount = _Dbtask.znllString(GridMain.SelectedRows[0].Cells["amount"].Value);
                            LOldData = "VchNo:" + Vno + ",Party :" + LParty + ",Date:" + LDate.ToString("dd/MM/yyyy") + "Bill Amt :" + LBillamount;
                            CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", Lvtype, LOldData, "");
                            /*******************************/
                            _Dbtask.ExecuteNonQuery("delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + id + "' ");
                            _Dbtask.ExecuteNonQuery("Delete from tblbillsett where vtype='" + Vtype + "' and vno='" + id + "'");
                        }

                        if (SelectedNodeName == "Ndcashreceipt" || SelectedNodeName == "Nddebitnote" || SelectedNodeName == "Ndjournelreceipt")
                        {
                            string Vtype;

                            if (SelectedNodeName == "Ndcashreceipt")
                            {
                                Lvtype = "Receipt";
                                Vtype = "R";
                            }
                            else if (SelectedNodeName == "Nddebitnote")
                            {
                                Lvtype = "Debit Note";
                                Vtype = "DN";
                            }
                            else
                            {
                                Lvtype = "Journel Receipt";
                                Vtype = "JR";
                            }
                            /*Audit Log*/
                            LParty = "";
                            LDate = Convert.ToDateTime(GridMain.SelectedRows[0].Cells["vdate"].Value);
                            LBillamount = _Dbtask.znllString(GridMain.SelectedRows[0].Cells["amount"].Value);
                            LOldData = "VchNo:" + Vno + ",Party :" + LParty + ",Date:" + LDate.ToString("dd/MM/yyyy") + "Bill Amt :" + LBillamount;
                            CommonClass._auditlog.PassLoginDetails(DateTime.Now, ClsUserDetails.MUserName, ClsUserDetails.ComputerName, "DELETE", "", Lvtype, LOldData, "");
                            /*******************************/

                            _Dbtask.ExecuteNonQuery("Delete from tblgeneralledger where vtype='" + Vtype + "' and vno='" + id + "'");
                            _Dbtask.ExecuteNonQuery("Delete from tblbillsett where vtype='" + Vtype + "' and vno='" + id + "'");
                        }

                        if (SelectedNodeName == "Ndcommision" )
                        {
                            _Dbtask.ExecuteNonQuery("Delete from tblcommision where cid='" + id + "'");
                        }

                        if (SelectedNodeName == "Ndarea")
                        {
                            _Dbtask.ExecuteNonQuery("Delete from tblarea where Aid='" + id + "'");
                        }

                        if (SelectedNodeName == "Ndunits")
                        {
                            _Dbtask.ExecuteNonQuery("Delete from tblUnitcreation where id='" + id + "'");
                        }
                        if (SelectedNodeName == "Ndmanufacturer")
                        {
                            Ds = _Dbtask.ExecuteQuery("select * from tblitemmaster where manufacturer='" + id + "'");
                            if (Ds.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("Its Con't Delete Used already exist");
                            }
                            else
                            {
                                _Dbtask.ExecuteNonQuery("delete from tblmanufacturer where mid='" + id + "'");
                            }
                        }


                        }

                   
                    }
                }
            
            catch
            {
            }
        }

        private void Cmdedit_Click(object sender, EventArgs e)
        {
            EditFu();
        }
        public void Clear()
        {
            GridMain.Columns.Clear();
            GridMain.Rows.Clear();
            GridMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            GridMain.AllowUserToResizeRows = false;
            
            Vtype();

            TreeMain.ExpandAll();
            Dtfrom.Focus();
            if (Openwindow != "")
            {
                TreeviewSelect(Openwindow);
            }

           // TreeMain.Nodes[0].se
        }

        private void GridMain_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void NewWindowFu()
        {

            try
            {
               
               
                        /*for Itemgroup*/
                       
                        string SelectedNodeName = TreeMain.SelectedNode.Name.ToString();
                        if (SelectedNodeName == "Ndcategory")
                        {
                            Frmitemgroup _itemgroup = new Frmitemgroup();
                            _itemgroup.ShowDialog();
                        }

                        /*for Item*/
                        if (SelectedNodeName == "Nditems")
                        {
                            Frmitems _Items = new Frmitems();
                            Frmitems.Isinotherwindow = false;
                            _Items.ShowDialog();
                        }

                        /*for customer*/
                        /*For Supplier*/
                        /*For Ledger*/
                        if (SelectedNodeName == "Ndcustomer" )
                        {
                            frmcreateledger _CreateLedger = new frmcreateledger();
                            _CreateLedger.WheregroupeQuerye = "  WHERE AUnder=18 or AGroupId=18";
                            Generalfunction.Comeform = "MDICUSTOMER";
                            _CreateLedger.ShowDialog();
                        }
                        
                        if(SelectedNodeName == "NdSuppliers")
                        {
                            frmcreateledger _CreteLedger = new frmcreateledger();
                            _CreteLedger.WheregroupeQuerye = " WHERE AUnder=19 or AGroupId=19";
                            Generalfunction.Comeform = "MDISUPPLIER";

                            _CreteLedger.ShowDialog();
                        }
                        if(SelectedNodeName == "NdAgent")
                        {
                            frmcreateledger _Agent = new frmcreateledger();
                            _Agent.WheregroupeQuerye = "  WHERE AUnder=29 or AGroupId=29";
                            Generalfunction.Comeform = "MDIAGENT";
                            _Agent.ShowDialog();
                        }
                        if(SelectedNodeName == "Ndledger")
                        {
                            frmcreateledger _Ledger = new frmcreateledger();
                            _Ledger.ShowDialog();
                        }
                        /*for Staff*/
                        if (SelectedNodeName == "Ndstaff")
                        {
                            Frmemployees _Employeemaster = new Frmemployees();
                            _Employeemaster.ShowDialog();
                        }

                        /*For LedgerGroup*/
                        if (SelectedNodeName== "NdLedgerGroup")
                        {
                           frmaccountGroup _LedgerGroup=new frmaccountGroup();
                            _LedgerGroup.ShowDialog();
                        }

                        if (SelectedNodeName == "Ndsales")
                        {
                            frmsalesinvoice _Sales = new frmsalesinvoice();
                            _Sales.Show();
                        }

                        if (SelectedNodeName == "Ndpurchase")
                        {
                            Frmpurchase _Purchase = new Frmpurchase();
                            _Purchase.Show();
                        }
                
            }
            catch
            {
            }
        }
        private void GridMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteFu();
                TreeviewSelect(TreeMain.SelectedNode.Name.ToString());
            }
        }

       

        private void Cmdnew_Click(object sender, EventArgs e)
        {
            NewWindowFu();
        }

        private void Frmeditwindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    (this.MdiParent as MDIParent1).panelshowshortcuts.Visible = true;
            //}
            //catch
            //{
            //}
        }

        private void Frmeditwindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void TreeMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                

                if (TreeMain.SelectedNode.Name == "Ndcreatecompany")
                {
                    ShowCreatecompany();
                }
                if (TreeMain.SelectedNode.Name == "Nddeletecompany")
                {
                    frmdeletecomp _Deletecompany = new frmdeletecomp();
                    _Deletecompany.Show();
                }
                if (TreeMain.SelectedNode.Text == "Ndsoftwaresettings")
                {
                    Frmsettings _settings = new Frmsettings();
                    _settings.Show();
                }
            }
            catch
            {
            }
        }
        public void ShowCreatecompany()
        {
            FrmCreateCompany _company=new FrmCreateCompany();
            _company.Isinotherwindow = true;
            _company.EditMode = true;
            _company.Show();
        
        }

        public void FuSearching()
        {
            if (TreeMain.SelectedNode.Name.ToString() == "Nditems")/*For Items*/
            {
                Itemsinmain();
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndpartyproject")/*For Items*/
            {
                Partyprojectinmain();
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndcustomer")/*For Customer*/
            {
                Customerinmain("");

            }

            if (TreeMain.SelectedNode.Name.ToString() == "Ndstaff")
            {
                Staffinmain();
            }
            if (TreeMain.SelectedNode.Name.ToString() == "NdLedgerGroup")
            {
                Ledgergroupinmain();
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndledger")/*For Customer*/
            {
                Ledgerinmain("");
                //Ledgerinmain(txtsearch.Text.Replace("'",""));
            }
            if (TreeMain.SelectedNode.Name.ToString() == "NdSuppliers")/*For Customer*/
            {
                Suppliersinmain("");

            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndsales")/*For Customer*/
            {
                BusinessIssueShow(txtsearch.Text.Replace("'", ""), "SI", "2", "Sales");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndsalesorder")/*For Customer*/
            {
                BusinessIssueShow(txtsearch.Text.Replace("'", ""), "SO", "2", "Sales order");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndsalesreturn")/*For Customer*/
            {
                TransactionReceiptinmain(txtsearch.Text.Replace("'", ""), "SR", "2", "Sales return");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndpurchase")/*For Customer*/
            {
                TransactionReceiptinmain(txtsearch.Text.Replace("'", ""), "PI", "3", "Purchase");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndpurchaseorder")/*For Customer*/
            {
                TransactionReceiptinmain(txtsearch.Text.Replace("'", ""), "PO", "3", "Purchase");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndpurchasereturn")/*For Customer*/
            {
                BusinessIssueShow(txtsearch.Text.Replace("'", ""), "PR", "3", "Purchase return");
            }

            if (TreeMain.SelectedNode.Name.ToString() == "Ndcashreceipt")/*For Customer*/
            {
                Receiptinmain("Receipt", "R");
                //TransactionReceiptinmain(txtsearch.Text.Replace("'", ""), "PR", "3", "Purchase return");
            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndcashpayment")/*For Customer*/
            {

                Paymentinmain("Payment", "P");

            }

            if (TreeMain.SelectedNode.Name.ToString() == "Ndjournelpayment")/*For Customer*/
            {

                Paymentinmain("Journel Payment", "JNP");

            }
            if (TreeMain.SelectedNode.Name.ToString() == "Ndjournelreceipt")/*For Customer*/
            {

                Paymentinmain("Journel Receipt", "JNR");

            }
           
        }
        public void ExporttoexcelImport()
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
                StreamWriter wr = new StreamWriter(Filepath, true, Encoding.Unicode);

                //determine the number of columns and write columns to file
                cols = GridMain.Columns.Count;
                wr.Write("Company Name\n\n\n");


                // wr.Write(LblHeading.Text + "\n\n");

                for (int i = 0; i < cols; i++)
                {
                    wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                }
                wr.WriteLine();
                // write rows to excel file
                for (int i = 0; i < (GridMain.Rows.Count); i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (GridMain.Rows[i].Cells[j].Value != null)
                        {
                            string StrValue;
                            StrValue = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", " ");
                            StrValue = StrValue.Replace("\n", " ");
                            wr.Write(StrValue + "\t");
                        }
                        else
                        {
                            wr.Write("\t");
                        }
                    }
                    wr.WriteLine();
                }
                //close file
                wr.Close();
                System.Diagnostics.Process.Start(Filepath);

                // File.Open(Filepath,FileMode.Open);

            }
        }
       
        public void Exporttoexcel()
        {
            //int cols;
            //SaveFileDialog theDialog = new SaveFileDialog();
            //theDialog.Title = "Save File";
            //theDialog.Filter = "Excel File|*.xls";
            //theDialog.InitialDirectory = @"C:\";
            //if (theDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string Filepath = theDialog.FileName;

            //    //open file
            //    StreamWriter wr = new StreamWriter(Filepath);

            //    //determine the number of columns and write columns to file
            //    cols = GridMain.Columns.Count;
            //    wr.Write("Company Name\n\n\n");


            //   // wr.Write(LblHeading.Text + "\n\n");

            //    for (int i = 0; i < cols; i++)
            //    {
            //        wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
            //    }
            //    wr.WriteLine();
            //    // write rows to excel file
            //    for (int i = 0; i < (GridMain.Rows.Count); i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            if (GridMain.Rows[i].Cells[j].Value != null)
            //                wr.Write(GridMain.Rows[i].Cells[j].Value + "\t");
            //            else
            //            {
            //                wr.Write("\t");
            //            }
            //        }
            //        wr.WriteLine();
            //    }
            //    //close file
            //    wr.Close();
            //    System.Diagnostics.Process.Start(Filepath);

            //    // File.Open(Filepath,FileMode.Open);

            //}

            try
            {
                int cols;
                SaveFileDialog theDialog = new SaveFileDialog();
                theDialog.Title = "Save File";
                //theDialog.Filter = "Excel File|*.xlsx";
                theDialog.Filter = "Excel File|*.xls";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    string Filepath = theDialog.FileName;

                    //open file
                    StreamWriter wr = new StreamWriter(Filepath, true, Encoding.UTF8);

                    //determine the number of columns and write columns to file
                    cols = GridMain.Columns.Count;
                    wr.Write("" + CommonClass._compMaster.GetspecifField("cname") + "\n\n\n");
                   // wr.Write(DTFrom.ToString("dd-MM-yyyy") + "  To " + DTTo.ToString("dd-MM-yyyy") + " \n\n");

                   // wr.Write(LblHeading.Text + "\n\n");

                    for (int i = 0; i < cols; i++)
                    {
                        wr.Write(GridMain.Columns[i].HeaderText.ToString() + "\t");
                    }
                    wr.WriteLine();
                    // write rows to excel file
                    for (int i = 0; i < (GridMain.Rows.Count); i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (GridMain.Rows[i].Cells[j].Value != null)
                            {
                                GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\n", "");
                                GridMain.Rows[i].Cells[j].Value = GridMain.Rows[i].Cells[j].Value.ToString().Replace("\r", "");
                                wr.Write(GridMain.Rows[i].Cells[j].Value + "\t");
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
        private void cmdexportexcel_Click(object sender, EventArgs e)
        {
            Exporttoexcel();
        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            DeleteFu();
            TreeviewSelect(TreeMain.SelectedNode.Name.ToString());
        }

        public void Loadsettingscolumn()
        {
            Gridreportsettings.Rows.Clear();
            for (int i = 0; i < GridMain.Columns.Count; i++)
            {
                Gridreportsettings.Rows.Add(1);
                Gridreportsettings.Rows[0].Cells[0].Value = GridMain.Columns[i].HeaderText;
                Gridreportsettings.Rows[0].Cells[1].Value = GridMain.Columns[i].Width;
            }
        }

       

        private void cmdokpanel_Click(object sender, EventArgs e)
        {
            pnlsettings.Visible = false;
        }

        private void cmdclosepanel_Click(object sender, EventArgs e)
        {
            pnlsettings.Visible = false;
        }

      
        public void Fscroll()
        {
           
                int Fscroll = Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Fscroll"));

                for (int i = 0; i <= Fscroll; i++)
                {
                    RichTextBox1.Text = RichTextBox1.Text + "\n";
                }
            
        }

        public void PrintDotMetrix(bool Isconsole)
        {
            
                MyPrinter.Close();
                
                    if (Isconsole == true)
                    {
                        if (!MyPrinter.Open("Qplex Print")) return;
                        MyPrinter.Print(Convert.ToChar(15).ToString());
                        MyPrinter.Print(RichTextBox1.Text);
                        MyPrinter.Print(Convert.ToChar(18).ToString());
                    }
                    else
                    {
                        if (!MyPrinter.Open("Qplex Print")) return;
                        MyPrinter.Print(RichTextBox1.Text);
                    }
                
                MyPrinter.Close();
       }

        public void PrintRollBack(int Count)
        {
            
                MyPrinter.Close();
                if (!MyPrinter.Open("Qplex Print")) return;

                for (int i = 0; i <= Count; i++)
                {
                    MyPrinter.Print(Convert.ToChar(27).ToString() + Convert.ToChar(106).ToString() + Convert.ToChar('1').ToString());
                }
                MyPrinter.Close();
            
        }
        

        private void cmdprint_Click(object sender, EventArgs e)
        {
            string Pname;
            string Mrp;
            string Srate;
            string Prate;

            Pname = "Product Name".PadRight(40, ' ');
            Mrp = "MRP".PadLeft(15, ' ');
            Srate = "Srate".PadLeft(15, ' ');
            //Mrp = "MRP".PadLeft(7, ' ');
            string LineHeading = "=".PadRight(70, '=');

            RichTextBox1.Text = "\n" + Pname + Mrp + Srate+"\n"+LineHeading;
            for (int i = 0; i < GridMain.Rows.Count; i++)
            {
                if (GridMain.Rows[i].Cells[2].Value != null)
                {
                   
                        Pname = GridMain.Rows[i].Cells[3].Value.ToString();
                        Pname = Pname.PadRight(40, ' ');
                        if (Pname.Length > 40)
                            Pname = Pname.Substring(0, 40);

                        double smrp = Convert.ToDouble(GridMain.Rows[i].Cells[4].Value);
                        Mrp = _Dbtask.SetintoDecimalpointStock(smrp);
                        Mrp = Mrp.PadLeft(15, ' ');

                        double ssrate = Convert.ToDouble(GridMain.Rows[i].Cells[5].Value);
                        Srate = _Dbtask.SetintoDecimalpointStock(ssrate);
                        Srate = Srate.PadLeft(15, ' ');





                        RichTextBox1.Text = RichTextBox1.Text + "\n" + Pname + Mrp + Srate;
                    
                }
            }
            if (!MyPrinter.Open("Qplex Print")) return;
            PrintRollBack(Convert.ToInt16(CommonClass._Paramlist.GetParamvalue("Reverse")));
          
            PrintDotMetrix(true);
            // PrintBold("You Saved   :" + SavedAmount + "                 Total    :" + txtbillamount.Text, true);

            //  RichTextBox1.Text = "\n\nIn Words: " + AmountinWords + "\n                                                     Old Balance   :" + tempoldbalance.PadLeft(11, ' ') + "\n                                                     Current Balance:" + tempcurrentbalance.PadLeft(10, ' ') + "\n\n" + OtherizedSignature;
            //  RichTextBox1.Text = "\n\nCash Received: " + FrmCashDesk.TCash + "\nBalance:" + FrmCashDesk.Balance;

            Fscroll();

            // MyPrinter.Print("===================================\r\n");
            MyPrinter.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            FuSearching();
        }

        private void cmdsettcolumns_Click(object sender, EventArgs e)
        {
            if (pnlsettings.Visible == true)
            {
                pnlsettings.Visible = false;
            }
            else
            {
                Loadsettingscolumn();
                pnlsettings.Visible = true;
            }
        }

        private void GridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridMain_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmdExcelimp_Click(object sender, EventArgs e)
        {
            ExporttoexcelImport();
        }

       
       
    }
}
