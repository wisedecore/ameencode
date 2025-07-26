namespace WindowsFormsApplication2
{
    partial class Frmprintmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprintmain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("h Tin No");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("h CST No");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("h Invoice Header");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("h Cash Bill");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Header Tag", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("P Page No");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("P Party Name");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("P Party Address");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("P Party Address1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("P Party Address2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("P Party Address3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("P Party Phone");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("P Party Mobile");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("P Party Tax No");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("P PCD(Party Credit Days)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("P Delivery Note No");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("P Order Details");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("P Dispacth Details");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("P InvDate");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("P InvNo");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("P InvTime");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("P Term of Delivery");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("P Agent");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("P Ref No");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("PageHeader Tag", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("I SlNo");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("I ShedueleNo");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("I Item Name");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("I Item Code");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("I Batch Code");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("I Serial Number");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("I Description");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("I MRP");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("I Unit");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("I TPer");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("I Tax");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("I Rate");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("I Rate Inc(Rate Inclusive)");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("I Qty");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("I Free");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("I Gross(Rate*Qty)");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("I IDiscP(Item DiscPercentage)");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("I Item Dis(Amt)");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("I Txble");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("I Tax Amt(Tax Amount)");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("I CessP");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("I Cess Amt");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("I Totta(Tottal Without)");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("I Tottalc(Toottal Without cess)");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("I Tottal Without Bill");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("I ISaving(Saving Item Wise)");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Item Details", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("F Qty Tot");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("F FQtyTot");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("F Gramt(Gross Amt)");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("F Item Disc");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("F Txblt(Taxable Total)");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("F Nontxblt(Non Taxable total)");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("F TTa(Tax Total)");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("F TotAmt(Total Amount)");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("F Total Amtw(Total Amount Without)");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("F Cessontax");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("F Discper");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("F Discount");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("F Cash Discount");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("F ServiceTax");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("F Service Amt");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("F TotAmtB");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("F TotalAmount");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("F Roundoff");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("F OtherExpense");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("F Accounts");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("F BillAmount");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("F Inwords");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("F Savings");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("F Salesman");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("F OutstandingAmt");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("F Narration");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("F CashDesk");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("F MRPvalue");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("F TaxSplit");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("F AccountDet");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Report Footer", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82});
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("A Big");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("A Small");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("A Italic");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("A Lines");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Formating Tags", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87});
            this.pnltoppanel = new System.Windows.Forms.Panel();
            this.pnlsettings = new System.Windows.Forms.Panel();
            this.cmdsavesettings = new System.Windows.Forms.Button();
            this.Picprinter = new System.Windows.Forms.PictureBox();
            this.cmdpreview = new System.Windows.Forms.Button();
            this.cmdprintdesign = new System.Windows.Forms.Button();
            this.pnlleftpanel = new System.Windows.Forms.Panel();
            this.tabmain = new System.Windows.Forms.TabControl();
            this.tabTags = new System.Windows.Forms.TabPage();
            this.trvmain = new System.Windows.Forms.TreeView();
            this.tabsettings = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsfooter = new System.Windows.Forms.TextBox();
            this.txtsforward = new System.Windows.Forms.TextBox();
            this.txtsreverse = new System.Windows.Forms.TextBox();
            this.txtsitemlines = new System.Windows.Forms.TextBox();
            this.txtswidth = new System.Windows.Forms.TextBox();
            this.txtsleft = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Richmain = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hrulerControl = new Lyquidity.UtilityLibrary.Controls.RulerControl();
            this.pnltoppanel.SuspendLayout();
            this.pnlsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picprinter)).BeginInit();
            this.pnlleftpanel.SuspendLayout();
            this.tabmain.SuspendLayout();
            this.tabTags.SuspendLayout();
            this.tabsettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltoppanel
            // 
            this.pnltoppanel.Controls.Add(this.pnlsettings);
            this.pnltoppanel.Controls.Add(this.Picprinter);
            this.pnltoppanel.Controls.Add(this.cmdpreview);
            this.pnltoppanel.Controls.Add(this.cmdprintdesign);
            this.pnltoppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltoppanel.Location = new System.Drawing.Point(0, 0);
            this.pnltoppanel.Name = "pnltoppanel";
            this.pnltoppanel.Size = new System.Drawing.Size(837, 57);
            this.pnltoppanel.TabIndex = 1;
            // 
            // pnlsettings
            // 
            this.pnlsettings.Controls.Add(this.cmdsavesettings);
            this.pnlsettings.Location = new System.Drawing.Point(202, 6);
            this.pnlsettings.Name = "pnlsettings";
            this.pnlsettings.Size = new System.Drawing.Size(425, 40);
            this.pnlsettings.TabIndex = 54;
            this.pnlsettings.Visible = false;
            // 
            // cmdsavesettings
            // 
            this.cmdsavesettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdsavesettings.Location = new System.Drawing.Point(3, 2);
            this.cmdsavesettings.Name = "cmdsavesettings";
            this.cmdsavesettings.Size = new System.Drawing.Size(75, 34);
            this.cmdsavesettings.TabIndex = 0;
            this.cmdsavesettings.Text = "Save";
            this.cmdsavesettings.UseVisualStyleBackColor = true;
            this.cmdsavesettings.Click += new System.EventHandler(this.cmdsavesettings_Click);
            // 
            // Picprinter
            // 
            this.Picprinter.BackColor = System.Drawing.Color.Transparent;
            this.Picprinter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picprinter.BackgroundImage")));
            this.Picprinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picprinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picprinter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Picprinter.Location = new System.Drawing.Point(774, 0);
            this.Picprinter.Name = "Picprinter";
            this.Picprinter.Size = new System.Drawing.Size(63, 57);
            this.Picprinter.TabIndex = 53;
            this.Picprinter.TabStop = false;
            this.toolTip1.SetToolTip(this.Picprinter, "Print");
            this.Picprinter.Click += new System.EventHandler(this.Picprinter_Click);
            // 
            // cmdpreview
            // 
            this.cmdpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdpreview.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdpreview.Location = new System.Drawing.Point(107, 11);
            this.cmdpreview.Name = "cmdpreview";
            this.cmdpreview.Size = new System.Drawing.Size(89, 33);
            this.cmdpreview.TabIndex = 1;
            this.cmdpreview.Text = "Preview";
            this.cmdpreview.UseVisualStyleBackColor = true;
            this.cmdpreview.Click += new System.EventHandler(this.cmdpreview_Click);
            // 
            // cmdprintdesign
            // 
            this.cmdprintdesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdprintdesign.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdprintdesign.Location = new System.Drawing.Point(12, 11);
            this.cmdprintdesign.Name = "cmdprintdesign";
            this.cmdprintdesign.Size = new System.Drawing.Size(89, 33);
            this.cmdprintdesign.TabIndex = 0;
            this.cmdprintdesign.Text = "Design";
            this.cmdprintdesign.UseVisualStyleBackColor = true;
            this.cmdprintdesign.Click += new System.EventHandler(this.cmdprintdesign_Click);
            // 
            // pnlleftpanel
            // 
            this.pnlleftpanel.Controls.Add(this.tabmain);
            this.pnlleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleftpanel.Location = new System.Drawing.Point(0, 57);
            this.pnlleftpanel.Name = "pnlleftpanel";
            this.pnlleftpanel.Size = new System.Drawing.Size(200, 437);
            this.pnlleftpanel.TabIndex = 2;
            // 
            // tabmain
            // 
            this.tabmain.Controls.Add(this.tabTags);
            this.tabmain.Controls.Add(this.tabsettings);
            this.tabmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabmain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabmain.Location = new System.Drawing.Point(0, 0);
            this.tabmain.Name = "tabmain";
            this.tabmain.SelectedIndex = 0;
            this.tabmain.Size = new System.Drawing.Size(200, 437);
            this.tabmain.TabIndex = 0;
            // 
            // tabTags
            // 
            this.tabTags.Controls.Add(this.trvmain);
            this.tabTags.Location = new System.Drawing.Point(4, 26);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(192, 407);
            this.tabTags.TabIndex = 0;
            this.tabTags.Text = "Tags";
            this.tabTags.UseVisualStyleBackColor = true;
            // 
            // trvmain
            // 
            this.trvmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvmain.Location = new System.Drawing.Point(3, 3);
            this.trvmain.Name = "trvmain";
            treeNode1.Name = "Ndshtinno";
            treeNode1.Text = "h Tin No";
            treeNode2.Name = "Ndshcstno";
            treeNode2.Text = "h CST No";
            treeNode3.Name = "Ndshinvoiceheader";
            treeNode3.Text = "h Invoice Header";
            treeNode4.Name = "Ndshcashbill";
            treeNode4.Text = "h Cash Bill";
            treeNode5.Name = "NdMheader";
            treeNode5.Text = "Header Tag";
            treeNode6.Name = "Ndsppageno";
            treeNode6.Text = "P Page No";
            treeNode7.Name = "Ndsppartyname";
            treeNode7.Text = "P Party Name";
            treeNode8.Name = "Ndsppartyaddress";
            treeNode8.Text = "P Party Address";
            treeNode9.Name = "Ndsppartyaddress1";
            treeNode9.Text = "P Party Address1";
            treeNode10.Name = "Ndsppartyaddress2";
            treeNode10.Text = "P Party Address2";
            treeNode11.Name = "Ndsppartyaddress3";
            treeNode11.Text = "P Party Address3";
            treeNode12.Name = "Ndsppartyphone";
            treeNode12.Text = "P Party Phone";
            treeNode13.Name = "Ndsppartymobile";
            treeNode13.Text = "P Party Mobile";
            treeNode14.Name = "Ndsppartytaxno";
            treeNode14.Text = "P Party Tax No";
            treeNode15.Name = "Ndsppartypcd";
            treeNode15.Text = "P PCD(Party Credit Days)";
            treeNode16.Name = "Ndspdeliverynoteno";
            treeNode16.Text = "P Delivery Note No";
            treeNode17.Name = "Ndsporderdetails";
            treeNode17.Text = "P Order Details";
            treeNode18.Name = "Ndspdispatchdetail";
            treeNode18.Text = "P Dispacth Details";
            treeNode19.Name = "Ndspinvdate";
            treeNode19.Text = "P InvDate";
            treeNode20.Name = "Ndspinvno";
            treeNode20.Text = "P InvNo";
            treeNode21.Name = "Ndspinvtime";
            treeNode21.Text = "P InvTime";
            treeNode22.Name = "Ndsptermofdelivery";
            treeNode22.Text = "P Term of Delivery";
            treeNode23.Name = "Ndspagent";
            treeNode23.Text = "P Agent";
            treeNode24.Name = "Ndsprefno";
            treeNode24.Text = "P Ref No";
            treeNode25.Name = "Ndmpageheader";
            treeNode25.Text = "PageHeader Tag";
            treeNode26.Name = "Ndsislno";
            treeNode26.Text = "I SlNo";
            treeNode27.Name = "Ndsisheduleno";
            treeNode27.Text = "I ShedueleNo";
            treeNode28.Name = "Ndsiitemname";
            treeNode28.Text = "I Item Name";
            treeNode29.Name = "Ndsiitemcode";
            treeNode29.Text = "I Item Code";
            treeNode30.Name = "Ndsibatchcode";
            treeNode30.Text = "I Batch Code";
            treeNode31.Name = "NdsiSerialnumber";
            treeNode31.Text = "I Serial Number";
            treeNode32.Name = "Ndsidescription";
            treeNode32.Text = "I Description";
            treeNode33.Name = "Ndsimrp";
            treeNode33.Text = "I MRP";
            treeNode34.Name = "Ndsiunit";
            treeNode34.Text = "I Unit";
            treeNode35.Name = "Ndsitperc";
            treeNode35.Text = "I TPer";
            treeNode36.Name = "Ndsitax";
            treeNode36.Text = "I Tax";
            treeNode37.Name = "Ndsirate";
            treeNode37.Text = "I Rate";
            treeNode38.Name = "Ndsirateinc";
            treeNode38.Text = "I Rate Inc(Rate Inclusive)";
            treeNode39.Name = "Ndsiqty";
            treeNode39.Text = "I Qty";
            treeNode40.Name = "Ndsifree";
            treeNode40.Text = "I Free";
            treeNode41.Name = "Ndsigross";
            treeNode41.Text = "I Gross(Rate*Qty)";
            treeNode42.Name = "Ndsiidiscp";
            treeNode42.Text = "I IDiscP(Item DiscPercentage)";
            treeNode43.Name = "Ndsiidisc";
            treeNode43.Text = "I Item Dis(Amt)";
            treeNode44.Name = "Ndsitaxable";
            treeNode44.Text = "I Txble";
            treeNode45.Name = "Ndsitaxamt";
            treeNode45.Text = "I Tax Amt(Tax Amount)";
            treeNode46.Name = "Ndsicessp";
            treeNode46.Text = "I CessP";
            treeNode47.Name = "Ndsicessamt";
            treeNode47.Text = "I Cess Amt";
            treeNode48.Name = "Ndsitottalwithout";
            treeNode48.Text = "I Totta(Tottal Without)";
            treeNode49.Name = "Ndsitottalc";
            treeNode49.Text = "I Tottalc(Toottal Without cess)";
            treeNode50.Name = "Ndsitottalbillc";
            treeNode50.Text = "I Tottal Without Bill";
            treeNode51.Name = "Ndsiisaving";
            treeNode51.Text = "I ISaving(Saving Item Wise)";
            treeNode52.Name = "Ndhitemdetails";
            treeNode52.Text = "Item Details";
            treeNode53.Name = "ndsfqtytot";
            treeNode53.Text = "F Qty Tot";
            treeNode54.Name = "Ndsifqtytot";
            treeNode54.Text = "F FQtyTot";
            treeNode55.Name = "Ndsigramt";
            treeNode55.Text = "F Gramt(Gross Amt)";
            treeNode56.Name = "Ndsiitemdisc";
            treeNode56.Text = "F Item Disc";
            treeNode57.Name = "Ndsitxblt";
            treeNode57.Text = "F Txblt(Taxable Total)";
            treeNode58.Name = "Ndsinontxblt";
            treeNode58.Text = "F Nontxblt(Non Taxable total)";
            treeNode59.Name = "Ndsitta";
            treeNode59.Text = "F TTa(Tax Total)";
            treeNode60.Name = "Ndsitotamt";
            treeNode60.Text = "F TotAmt(Total Amount)";
            treeNode61.Name = "Ndsitotamtw";
            treeNode61.Text = "F Total Amtw(Total Amount Without)";
            treeNode62.Name = "Ndsicessontax";
            treeNode62.Text = "F Cessontax";
            treeNode63.Name = "Ndsidiscper";
            treeNode63.Text = "F Discper";
            treeNode64.Name = "Ndsiddiscount";
            treeNode64.Text = "F Discount";
            treeNode65.Name = "Ndsicashdiscount";
            treeNode65.Text = "F Cash Discount";
            treeNode66.Name = "Ndsiservicetax";
            treeNode66.Text = "F ServiceTax";
            treeNode67.Name = "Ndsiserviceamt";
            treeNode67.Text = "F Service Amt";
            treeNode68.Name = "Ndsitotamtb";
            treeNode68.Text = "F TotAmtB";
            treeNode69.Name = "Ndsitotalamount";
            treeNode69.Text = "F TotalAmount";
            treeNode70.Name = "Ndsiroundof";
            treeNode70.Text = "F Roundoff";
            treeNode71.Name = "Ndsiotherexpense";
            treeNode71.Text = "F OtherExpense";
            treeNode72.Name = "Ndsiaccounts";
            treeNode72.Text = "F Accounts";
            treeNode73.Name = "Ndsibillamount";
            treeNode73.Text = "F BillAmount";
            treeNode74.Name = "Ndsiinwords";
            treeNode74.Text = "F Inwords";
            treeNode75.Name = "Ndsisavings";
            treeNode75.Text = "F Savings";
            treeNode76.Name = "Ndsisalesman";
            treeNode76.Text = "F Salesman";
            treeNode77.Name = "Ndsioutstandingamt";
            treeNode77.Text = "F OutstandingAmt";
            treeNode78.Name = "Ndsinarration";
            treeNode78.Text = "F Narration";
            treeNode79.Name = "Ndsicashdesk";
            treeNode79.Text = "F CashDesk";
            treeNode80.Name = "Ndsimrpvalue";
            treeNode80.Text = "F MRPvalue";
            treeNode81.Name = "Ndsitaxsplit";
            treeNode81.Text = "F TaxSplit";
            treeNode82.Name = "Ndsiaccountdet";
            treeNode82.Text = "F AccountDet";
            treeNode83.Name = "Ndhreportfooter";
            treeNode83.Text = "Report Footer";
            treeNode84.Name = "Ndsabig";
            treeNode84.Text = "A Big";
            treeNode85.Name = "Ndsasmall";
            treeNode85.Text = "A Small";
            treeNode86.Name = "Ndsaitalic";
            treeNode86.Text = "A Italic";
            treeNode87.Name = "Ndsalines";
            treeNode87.Text = "A Lines";
            treeNode88.Name = "Ndhformatingtags";
            treeNode88.Text = "Formating Tags";
            this.trvmain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode25,
            treeNode52,
            treeNode83,
            treeNode88});
            this.trvmain.Size = new System.Drawing.Size(186, 401);
            this.trvmain.TabIndex = 0;
            this.trvmain.DoubleClick += new System.EventHandler(this.trvmain_DoubleClick);
            // 
            // tabsettings
            // 
            this.tabsettings.Controls.Add(this.label4);
            this.tabsettings.Controls.Add(this.label5);
            this.tabsettings.Controls.Add(this.label6);
            this.tabsettings.Controls.Add(this.label3);
            this.tabsettings.Controls.Add(this.label2);
            this.tabsettings.Controls.Add(this.label1);
            this.tabsettings.Controls.Add(this.txtsfooter);
            this.tabsettings.Controls.Add(this.txtsforward);
            this.tabsettings.Controls.Add(this.txtsreverse);
            this.tabsettings.Controls.Add(this.txtsitemlines);
            this.tabsettings.Controls.Add(this.txtswidth);
            this.tabsettings.Controls.Add(this.txtsleft);
            this.tabsettings.Location = new System.Drawing.Point(4, 26);
            this.tabsettings.Name = "tabsettings";
            this.tabsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabsettings.Size = new System.Drawing.Size(192, 407);
            this.tabsettings.TabIndex = 1;
            this.tabsettings.Text = "Print Settings";
            this.tabsettings.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Footer:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Forward:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reverse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Left";
            // 
            // txtsfooter
            // 
            this.txtsfooter.Location = new System.Drawing.Point(130, 84);
            this.txtsfooter.Name = "txtsfooter";
            this.txtsfooter.Size = new System.Drawing.Size(55, 25);
            this.txtsfooter.TabIndex = 5;
            this.txtsfooter.Visible = false;
            this.txtsfooter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsfooter_KeyPress);
            // 
            // txtsforward
            // 
            this.txtsforward.Location = new System.Drawing.Point(69, 84);
            this.txtsforward.Name = "txtsforward";
            this.txtsforward.Size = new System.Drawing.Size(55, 25);
            this.txtsforward.TabIndex = 4;
            this.txtsforward.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsforward_KeyPress);
            // 
            // txtsreverse
            // 
            this.txtsreverse.Location = new System.Drawing.Point(8, 84);
            this.txtsreverse.Name = "txtsreverse";
            this.txtsreverse.Size = new System.Drawing.Size(55, 25);
            this.txtsreverse.TabIndex = 3;
            this.txtsreverse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsreverse_KeyPress);
            // 
            // txtsitemlines
            // 
            this.txtsitemlines.Location = new System.Drawing.Point(130, 30);
            this.txtsitemlines.Name = "txtsitemlines";
            this.txtsitemlines.Size = new System.Drawing.Size(55, 25);
            this.txtsitemlines.TabIndex = 2;
            this.txtsitemlines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsitemlines_KeyPress);
            // 
            // txtswidth
            // 
            this.txtswidth.Location = new System.Drawing.Point(69, 30);
            this.txtswidth.Name = "txtswidth";
            this.txtswidth.Size = new System.Drawing.Size(55, 25);
            this.txtswidth.TabIndex = 1;
            this.txtswidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtswidth_KeyPress);
            // 
            // txtsleft
            // 
            this.txtsleft.Location = new System.Drawing.Point(8, 30);
            this.txtsleft.Name = "txtsleft";
            this.txtsleft.Size = new System.Drawing.Size(55, 25);
            this.txtsleft.TabIndex = 0;
            this.txtsleft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsleft_KeyPress);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Richmain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 437);
            this.panel1.TabIndex = 3;
            // 
            // Richmain
            // 
            this.Richmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Richmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Richmain.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Richmain.Location = new System.Drawing.Point(0, 21);
            this.Richmain.Name = "Richmain";
            this.Richmain.Size = new System.Drawing.Size(637, 416);
            this.Richmain.TabIndex = 8;
            this.Richmain.Text = "````";
            this.Richmain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Richmain_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hrulerControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 21);
            this.panel2.TabIndex = 7;
            // 
            // hrulerControl
            // 
            this.hrulerControl.ActualSize = true;
            this.hrulerControl.DivisionMarkFactor = 5;
            this.hrulerControl.Divisions = 10;
            this.hrulerControl.ForeColor = System.Drawing.Color.Black;
            this.hrulerControl.Location = new System.Drawing.Point(0, 0);
            this.hrulerControl.MajorInterval = 100;
            this.hrulerControl.MiddleMarkFactor = 3;
            this.hrulerControl.MouseTrackingOn = false;
            this.hrulerControl.Name = "hrulerControl";
            this.hrulerControl.Orientation = Lyquidity.UtilityLibrary.Controls.enumOrientation.orHorizontal;
            this.hrulerControl.RulerAlignment = Lyquidity.UtilityLibrary.Controls.enumRulerAlignment.raBottomOrRight;
            this.hrulerControl.ScaleMode = Lyquidity.UtilityLibrary.Controls.enumScaleMode.smPoints;
            this.hrulerControl.Size = new System.Drawing.Size(0, 0);
            this.hrulerControl.StartValue = 0;
            this.hrulerControl.TabIndex = 0;
            this.hrulerControl.VerticalNumbers = true;
            this.hrulerControl.ZoomFactor = 1;
            // 
            // Frmprintmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlleftpanel);
            this.Controls.Add(this.pnltoppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmprintmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmprintmain_Load);
            this.pnltoppanel.ResumeLayout(false);
            this.pnlsettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picprinter)).EndInit();
            this.pnlleftpanel.ResumeLayout(false);
            this.tabmain.ResumeLayout(false);
            this.tabTags.ResumeLayout(false);
            this.tabsettings.ResumeLayout(false);
            this.tabsettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltoppanel;
        private System.Windows.Forms.Panel pnlleftpanel;
        private System.Windows.Forms.Button cmdpreview;
        private System.Windows.Forms.Button cmdprintdesign;
        private System.Windows.Forms.PictureBox Picprinter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Lyquidity.UtilityLibrary.Controls.RulerControl hrulerControl;
        private System.Windows.Forms.TabControl tabmain;
        private System.Windows.Forms.TabPage tabTags;
        private System.Windows.Forms.TabPage tabsettings;
        private System.Windows.Forms.TreeView trvmain;
        private System.Windows.Forms.TextBox txtsfooter;
        private System.Windows.Forms.TextBox txtsforward;
        private System.Windows.Forms.TextBox txtsreverse;
        private System.Windows.Forms.TextBox txtsitemlines;
        private System.Windows.Forms.TextBox txtswidth;
        private System.Windows.Forms.TextBox txtsleft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlsettings;
        private System.Windows.Forms.Button cmdsavesettings;
        public System.Windows.Forms.RichTextBox Richmain;
    }
}