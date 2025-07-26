namespace WindowsFormsApplication2
{
    partial class FrmSelectStockList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Item Type");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Category Type");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Barcode Type");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Supplier Type");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("In and  Out Stock Report", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Item Type");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Category Type");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Barcode Type");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Supplier Type Stock");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Stock value Report", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Stock Level");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectStockList));
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.TreeMain = new System.Windows.Forms.TreeView();
            this.Lblamountmorethan = new System.Windows.Forms.Label();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.ComDepot = new System.Windows.Forms.ComboBox();
            this.chkdepot = new System.Windows.Forms.CheckBox();
            this.Grpgroup = new System.Windows.Forms.GroupBox();
            this.chkcategoryall = new System.Windows.Forms.CheckBox();
            this.datagriditemcategory = new System.Windows.Forms.DataGridView();
            this.clnselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clngroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lblchk = new System.Windows.Forms.Label();
            this.Grpitembase = new System.Windows.Forms.GroupBox();
            this.Chkallbarcode = new System.Windows.Forms.CheckBox();
            this.uscitemshowsimple1 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.combatchcode = new System.Windows.Forms.ComboBox();
            this.Lblledger = new System.Windows.Forms.Label();
            this.Txtitems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpforselect = new System.Windows.Forms.GroupBox();
            this.comfor = new System.Windows.Forms.ComboBox();
            this.lblfor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comitemclass = new System.Windows.Forms.ComboBox();
            this.chkallitemclass = new System.Windows.Forms.CheckBox();
            this.Grpsupplierwise = new System.Windows.Forms.GroupBox();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.chkallmanufacturer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commanufacturer = new System.Windows.Forms.ComboBox();
            this.chkAddTaxRate = new System.Windows.Forms.CheckBox();
            this.GrpStocklevel = new System.Windows.Forms.GroupBox();
            this.RadAllleve = new System.Windows.Forms.RadioButton();
            this.Grpselectstockleve = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttolevelstock = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtfromlevelstock = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.Radselectstocklevel = new System.Windows.Forms.RadioButton();
            this.Radzerostock = new System.Windows.Forms.RadioButton();
            this.Radminus = new System.Windows.Forms.RadioButton();
            this.Dtto = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Comunit = new System.Windows.Forms.ComboBox();
            this.ChkAllunits = new System.Windows.Forms.CheckBox();
            this.Grpgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriditemcategory)).BeginInit();
            this.Grpitembase.SuspendLayout();
            this.grpforselect.SuspendLayout();
            this.Grpsupplierwise.SuspendLayout();
            this.GrpStocklevel.SuspendLayout();
            this.Grpselectstockleve.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(407, 466);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 7;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(329, 466);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 6;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // TreeMain
            // 
            this.TreeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.TreeMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMain.ForeColor = System.Drawing.Color.Purple;
            this.TreeMain.ItemHeight = 30;
            this.TreeMain.Location = new System.Drawing.Point(0, 0);
            this.TreeMain.Name = "TreeMain";
            treeNode1.Name = "Ndconsolidateitem";
            treeNode1.Text = "Item Type";
            treeNode2.Name = "Ndconsolidatedcategory";
            treeNode2.Text = "Category Type";
            treeNode3.Name = "Ndconsolidatebatchwise";
            treeNode3.Text = "Barcode Type";
            treeNode4.Name = "Ndconsolidatedledger";
            treeNode4.Text = "Supplier Type";
            treeNode5.Name = "Ndconsolidated";
            treeNode5.Text = "In and  Out Stock Report";
            treeNode6.Name = "Ndvalueitem";
            treeNode6.Text = "Item Type";
            treeNode7.Name = "Ndvaluecategory";
            treeNode7.Text = "Category Type";
            treeNode8.Name = "ndvaluebatchwise";
            treeNode8.Text = "Barcode Type";
            treeNode9.Name = "Ndstockvalueledger";
            treeNode9.Text = "Supplier Type Stock";
            treeNode10.Name = "NdStockvalue";
            treeNode10.Text = "Stock value Report";
            treeNode11.Name = "NdStocklevel";
            treeNode11.Text = "Stock Level";
            this.TreeMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode11});
            this.TreeMain.Size = new System.Drawing.Size(206, 530);
            this.TreeMain.TabIndex = 131;
            this.TreeMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMain_AfterSelect);
            this.TreeMain.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeMain_BeforeSelect);
            // 
            // Lblamountmorethan
            // 
            this.Lblamountmorethan.AutoSize = true;
            this.Lblamountmorethan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblamountmorethan.ForeColor = System.Drawing.Color.Black;
            this.Lblamountmorethan.Location = new System.Drawing.Point(699, 9);
            this.Lblamountmorethan.Name = "Lblamountmorethan";
            this.Lblamountmorethan.Size = new System.Drawing.Size(118, 17);
            this.Lblamountmorethan.TabIndex = 139;
            this.Lblamountmorethan.Text = "Amount More than";
            this.Lblamountmorethan.Visible = false;
            // 
            // Dtfrom
            // 
            this.Dtfrom.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(328, 309);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(129, 22);
            this.Dtfrom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(239, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "From";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(703, 31);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(95, 20);
            this.TxtAmount.TabIndex = 133;
            this.TxtAmount.Visible = false;
            // 
            // ComDepot
            // 
            this.ComDepot.BackColor = System.Drawing.SystemColors.Window;
            this.ComDepot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComDepot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComDepot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComDepot.FormattingEnabled = true;
            this.ComDepot.Location = new System.Drawing.Point(329, 353);
            this.ComDepot.Name = "ComDepot";
            this.ComDepot.Size = new System.Drawing.Size(195, 23);
            this.ComDepot.TabIndex = 2;
            // 
            // chkdepot
            // 
            this.chkdepot.AutoSize = true;
            this.chkdepot.Checked = true;
            this.chkdepot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdepot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdepot.ForeColor = System.Drawing.Color.Black;
            this.chkdepot.Location = new System.Drawing.Point(530, 360);
            this.chkdepot.Name = "chkdepot";
            this.chkdepot.Size = new System.Drawing.Size(40, 17);
            this.chkdepot.TabIndex = 142;
            this.chkdepot.Text = "All";
            this.chkdepot.UseVisualStyleBackColor = true;
            this.chkdepot.CheckedChanged += new System.EventHandler(this.chkdepot_CheckedChanged);
            // 
            // Grpgroup
            // 
            this.Grpgroup.Controls.Add(this.chkcategoryall);
            this.Grpgroup.Controls.Add(this.datagriditemcategory);
            this.Grpgroup.Controls.Add(this.Lblchk);
            this.Grpgroup.Location = new System.Drawing.Point(242, 12);
            this.Grpgroup.Name = "Grpgroup";
            this.Grpgroup.Size = new System.Drawing.Size(383, 196);
            this.Grpgroup.TabIndex = 186;
            this.Grpgroup.TabStop = false;
            this.Grpgroup.Text = "GroupBase";
            // 
            // chkcategoryall
            // 
            this.chkcategoryall.AutoSize = true;
            this.chkcategoryall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcategoryall.ForeColor = System.Drawing.Color.Black;
            this.chkcategoryall.Location = new System.Drawing.Point(338, 29);
            this.chkcategoryall.Name = "chkcategoryall";
            this.chkcategoryall.Size = new System.Drawing.Size(41, 21);
            this.chkcategoryall.TabIndex = 188;
            this.chkcategoryall.Text = "All";
            this.chkcategoryall.UseVisualStyleBackColor = true;
            this.chkcategoryall.CheckedChanged += new System.EventHandler(this.chkcategoryall_CheckedChanged);
            // 
            // datagriditemcategory
            // 
            this.datagriditemcategory.AllowUserToAddRows = false;
            this.datagriditemcategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagriditemcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagriditemcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriditemcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselect,
            this.clngroupname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagriditemcategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagriditemcategory.EnableHeadersVisualStyles = false;
            this.datagriditemcategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.datagriditemcategory.Location = new System.Drawing.Point(92, 29);
            this.datagriditemcategory.Name = "datagriditemcategory";
            this.datagriditemcategory.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagriditemcategory.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagriditemcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagriditemcategory.Size = new System.Drawing.Size(240, 167);
            this.datagriditemcategory.TabIndex = 187;
            // 
            // clnselect
            // 
            this.clnselect.FalseValue = "0";
            this.clnselect.FillWeight = 25F;
            this.clnselect.HeaderText = "";
            this.clnselect.Name = "clnselect";
            this.clnselect.TrueValue = "1";
            this.clnselect.Width = 25;
            // 
            // clngroupname
            // 
            this.clngroupname.FillWeight = 200F;
            this.clngroupname.HeaderText = "Category Name";
            this.clngroupname.Name = "clngroupname";
            this.clngroupname.ReadOnly = true;
            this.clngroupname.Width = 200;
            // 
            // Lblchk
            // 
            this.Lblchk.AutoSize = true;
            this.Lblchk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblchk.ForeColor = System.Drawing.Color.Black;
            this.Lblchk.Location = new System.Drawing.Point(7, 29);
            this.Lblchk.Name = "Lblchk";
            this.Lblchk.Size = new System.Drawing.Size(45, 17);
            this.Lblchk.TabIndex = 186;
            this.Lblchk.Text = "Group";
            // 
            // Grpitembase
            // 
            this.Grpitembase.BackColor = System.Drawing.Color.Honeydew;
            this.Grpitembase.Controls.Add(this.Chkallbarcode);
            this.Grpitembase.Controls.Add(this.uscitemshowsimple1);
            this.Grpitembase.Controls.Add(this.lblbarcode);
            this.Grpitembase.Controls.Add(this.combatchcode);
            this.Grpitembase.Controls.Add(this.Lblledger);
            this.Grpitembase.Controls.Add(this.Txtitems);
            this.Grpitembase.Location = new System.Drawing.Point(218, 18);
            this.Grpitembase.Name = "Grpitembase";
            this.Grpitembase.Size = new System.Drawing.Size(479, 290);
            this.Grpitembase.TabIndex = 187;
            this.Grpitembase.TabStop = false;
            this.Grpitembase.Text = "Item Base";
            // 
            // Chkallbarcode
            // 
            this.Chkallbarcode.AutoSize = true;
            this.Chkallbarcode.Checked = true;
            this.Chkallbarcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkallbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkallbarcode.Location = new System.Drawing.Point(437, 42);
            this.Chkallbarcode.Name = "Chkallbarcode";
            this.Chkallbarcode.Size = new System.Drawing.Size(40, 17);
            this.Chkallbarcode.TabIndex = 201;
            this.Chkallbarcode.Text = "All";
            this.Chkallbarcode.UseVisualStyleBackColor = true;
            this.Chkallbarcode.CheckedChanged += new System.EventHandler(this.Chkallbarcode_CheckedChanged);
            // 
            // uscitemshowsimple1
            // 
            this.uscitemshowsimple1.Location = new System.Drawing.Point(89, 65);
            this.uscitemshowsimple1.Name = "uscitemshowsimple1";
            this.uscitemshowsimple1.Size = new System.Drawing.Size(367, 209);
            this.uscitemshowsimple1.TabIndex = 144;
            this.uscitemshowsimple1.Visible = false;
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.ForeColor = System.Drawing.Color.Black;
            this.lblbarcode.Location = new System.Drawing.Point(12, 40);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(49, 13);
            this.lblbarcode.TabIndex = 142;
            this.lblbarcode.Text = "Barcode";
            // 
            // combatchcode
            // 
            this.combatchcode.Enabled = false;
            this.combatchcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.combatchcode.FormattingEnabled = true;
            this.combatchcode.Location = new System.Drawing.Point(89, 40);
            this.combatchcode.Name = "combatchcode";
            this.combatchcode.Size = new System.Drawing.Size(342, 23);
            this.combatchcode.TabIndex = 141;
            this.combatchcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combatchcode_KeyPress);
            // 
            // Lblledger
            // 
            this.Lblledger.AutoSize = true;
            this.Lblledger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblledger.ForeColor = System.Drawing.Color.Black;
            this.Lblledger.Location = new System.Drawing.Point(12, 14);
            this.Lblledger.Name = "Lblledger";
            this.Lblledger.Size = new System.Drawing.Size(35, 13);
            this.Lblledger.TabIndex = 140;
            this.Lblledger.Text = "Items";
            // 
            // Txtitems
            // 
            this.Txtitems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtitems.Location = new System.Drawing.Point(89, 14);
            this.Txtitems.Name = "Txtitems";
            this.Txtitems.Size = new System.Drawing.Size(367, 23);
            this.Txtitems.TabIndex = 139;
            this.Txtitems.TextChanged += new System.EventHandler(this.Txtitems_TextChanged);
            this.Txtitems.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txtitems_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 188;
            this.label1.Text = "Stock Area";
            // 
            // grpforselect
            // 
            this.grpforselect.Controls.Add(this.comfor);
            this.grpforselect.Controls.Add(this.lblfor);
            this.grpforselect.Location = new System.Drawing.Point(8, 412);
            this.grpforselect.Name = "grpforselect";
            this.grpforselect.Size = new System.Drawing.Size(190, 72);
            this.grpforselect.TabIndex = 191;
            this.grpforselect.TabStop = false;
            // 
            // comfor
            // 
            this.comfor.BackColor = System.Drawing.SystemColors.Window;
            this.comfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comfor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comfor.FormattingEnabled = true;
            this.comfor.Items.AddRange(new object[] {
            "Purchase Rate",
            "Sales Rate",
            "Crate"});
            this.comfor.Location = new System.Drawing.Point(30, 37);
            this.comfor.Name = "comfor";
            this.comfor.Size = new System.Drawing.Size(121, 21);
            this.comfor.TabIndex = 143;
            // 
            // lblfor
            // 
            this.lblfor.AutoSize = true;
            this.lblfor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfor.ForeColor = System.Drawing.Color.Black;
            this.lblfor.Location = new System.Drawing.Point(27, 17);
            this.lblfor.Name = "lblfor";
            this.lblfor.Size = new System.Drawing.Size(27, 17);
            this.lblfor.TabIndex = 144;
            this.lblfor.Text = "For";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(239, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 194;
            this.label4.Text = "Item Class";
            // 
            // comitemclass
            // 
            this.comitemclass.BackColor = System.Drawing.SystemColors.Window;
            this.comitemclass.Enabled = false;
            this.comitemclass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comitemclass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comitemclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comitemclass.FormattingEnabled = true;
            this.comitemclass.Items.AddRange(new object[] {
            "Stock Item",
            "Services",
            "Finished Product",
            "Finished Product2"});
            this.comitemclass.Location = new System.Drawing.Point(329, 380);
            this.comitemclass.Name = "comitemclass";
            this.comitemclass.Size = new System.Drawing.Size(195, 23);
            this.comitemclass.TabIndex = 3;
            // 
            // chkallitemclass
            // 
            this.chkallitemclass.AutoSize = true;
            this.chkallitemclass.Checked = true;
            this.chkallitemclass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallitemclass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkallitemclass.ForeColor = System.Drawing.Color.Black;
            this.chkallitemclass.Location = new System.Drawing.Point(530, 387);
            this.chkallitemclass.Name = "chkallitemclass";
            this.chkallitemclass.Size = new System.Drawing.Size(40, 17);
            this.chkallitemclass.TabIndex = 195;
            this.chkallitemclass.Text = "All";
            this.chkallitemclass.UseVisualStyleBackColor = true;
            this.chkallitemclass.CheckedChanged += new System.EventHandler(this.chkallitemclass_CheckedChanged);
            // 
            // Grpsupplierwise
            // 
            this.Grpsupplierwise.Controls.Add(this.uscitemshowsimple2);
            this.Grpsupplierwise.Controls.Add(this.label6);
            this.Grpsupplierwise.Controls.Add(this.txtsupplier);
            this.Grpsupplierwise.Location = new System.Drawing.Point(212, 18);
            this.Grpsupplierwise.Name = "Grpsupplierwise";
            this.Grpsupplierwise.Size = new System.Drawing.Size(462, 290);
            this.Grpsupplierwise.TabIndex = 196;
            this.Grpsupplierwise.TabStop = false;
            this.Grpsupplierwise.Text = "Supplier Wise";
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.Location = new System.Drawing.Point(89, 38);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(367, 238);
            this.uscitemshowsimple2.TabIndex = 144;
            this.uscitemshowsimple2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 140;
            this.label6.Text = "Supplier";
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(89, 14);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(367, 20);
            this.txtsupplier.TabIndex = 139;
            this.txtsupplier.TextChanged += new System.EventHandler(this.txtsupplier_TextChanged);
            this.txtsupplier.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtsupplier_PreviewKeyDown);
            // 
            // chkallmanufacturer
            // 
            this.chkallmanufacturer.AutoSize = true;
            this.chkallmanufacturer.Checked = true;
            this.chkallmanufacturer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallmanufacturer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkallmanufacturer.ForeColor = System.Drawing.Color.Black;
            this.chkallmanufacturer.Location = new System.Drawing.Point(530, 414);
            this.chkallmanufacturer.Name = "chkallmanufacturer";
            this.chkallmanufacturer.Size = new System.Drawing.Size(40, 17);
            this.chkallmanufacturer.TabIndex = 199;
            this.chkallmanufacturer.Text = "All";
            this.chkallmanufacturer.UseVisualStyleBackColor = true;
            this.chkallmanufacturer.CheckedChanged += new System.EventHandler(this.chkallmanufacturer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(238, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 198;
            this.label2.Text = "Manufacturer";
            // 
            // commanufacturer
            // 
            this.commanufacturer.BackColor = System.Drawing.SystemColors.Window;
            this.commanufacturer.Enabled = false;
            this.commanufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commanufacturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commanufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.commanufacturer.FormattingEnabled = true;
            this.commanufacturer.Items.AddRange(new object[] {
            "Stock Item",
            "Services",
            "Finished Product",
            "Finished Product2"});
            this.commanufacturer.Location = new System.Drawing.Point(329, 408);
            this.commanufacturer.Name = "commanufacturer";
            this.commanufacturer.Size = new System.Drawing.Size(195, 23);
            this.commanufacturer.TabIndex = 4;
            // 
            // chkAddTaxRate
            // 
            this.chkAddTaxRate.AutoSize = true;
            this.chkAddTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddTaxRate.Location = new System.Drawing.Point(38, 393);
            this.chkAddTaxRate.Name = "chkAddTaxRate";
            this.chkAddTaxRate.Size = new System.Drawing.Size(89, 17);
            this.chkAddTaxRate.TabIndex = 200;
            this.chkAddTaxRate.Text = "checkBox1";
            this.chkAddTaxRate.UseVisualStyleBackColor = true;
            this.chkAddTaxRate.Visible = false;
            // 
            // GrpStocklevel
            // 
            this.GrpStocklevel.Controls.Add(this.RadAllleve);
            this.GrpStocklevel.Controls.Add(this.Grpselectstockleve);
            this.GrpStocklevel.Controls.Add(this.Radselectstocklevel);
            this.GrpStocklevel.Controls.Add(this.Radzerostock);
            this.GrpStocklevel.Controls.Add(this.Radminus);
            this.GrpStocklevel.Location = new System.Drawing.Point(577, 314);
            this.GrpStocklevel.Name = "GrpStocklevel";
            this.GrpStocklevel.Size = new System.Drawing.Size(120, 176);
            this.GrpStocklevel.TabIndex = 201;
            this.GrpStocklevel.TabStop = false;
            this.GrpStocklevel.Text = "Stock Level";
            // 
            // RadAllleve
            // 
            this.RadAllleve.AutoSize = true;
            this.RadAllleve.Checked = true;
            this.RadAllleve.Location = new System.Drawing.Point(17, 17);
            this.RadAllleve.Name = "RadAllleve";
            this.RadAllleve.Size = new System.Drawing.Size(36, 17);
            this.RadAllleve.TabIndex = 4;
            this.RadAllleve.TabStop = true;
            this.RadAllleve.Text = "All";
            this.RadAllleve.UseVisualStyleBackColor = true;
            // 
            // Grpselectstockleve
            // 
            this.Grpselectstockleve.Controls.Add(this.label7);
            this.Grpselectstockleve.Controls.Add(this.label5);
            this.Grpselectstockleve.Controls.Add(this.txttolevelstock);
            this.Grpselectstockleve.Controls.Add(this.txtfromlevelstock);
            this.Grpselectstockleve.Enabled = false;
            this.Grpselectstockleve.Location = new System.Drawing.Point(4, 106);
            this.Grpselectstockleve.Name = "Grpselectstockleve";
            this.Grpselectstockleve.Size = new System.Drawing.Size(114, 58);
            this.Grpselectstockleve.TabIndex = 3;
            this.Grpselectstockleve.TabStop = false;
            this.Grpselectstockleve.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 137;
            this.label7.Text = "Less Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 136;
            this.label5.Text = "From";
            this.label5.Visible = false;
            // 
            // txttolevelstock
            // 
            this.txttolevelstock.Location = new System.Drawing.Point(53, 33);
            this.txttolevelstock.Name = "txttolevelstock";
            this.txttolevelstock.Size = new System.Drawing.Size(55, 22);
            this.txttolevelstock.TabIndex = 7;
            // 
            // txtfromlevelstock
            // 
            this.txtfromlevelstock.Location = new System.Drawing.Point(53, 10);
            this.txtfromlevelstock.Name = "txtfromlevelstock";
            this.txtfromlevelstock.Size = new System.Drawing.Size(55, 22);
            this.txtfromlevelstock.TabIndex = 6;
            this.txtfromlevelstock.Visible = false;
            // 
            // Radselectstocklevel
            // 
            this.Radselectstocklevel.AutoSize = true;
            this.Radselectstocklevel.Location = new System.Drawing.Point(17, 85);
            this.Radselectstocklevel.Name = "Radselectstocklevel";
            this.Radselectstocklevel.Size = new System.Drawing.Size(55, 17);
            this.Radselectstocklevel.TabIndex = 2;
            this.Radselectstocklevel.Text = "Select";
            this.Radselectstocklevel.UseVisualStyleBackColor = true;
            this.Radselectstocklevel.CheckedChanged += new System.EventHandler(this.Radselectstocklevel_CheckedChanged);
            // 
            // Radzerostock
            // 
            this.Radzerostock.AutoSize = true;
            this.Radzerostock.Location = new System.Drawing.Point(17, 62);
            this.Radzerostock.Name = "Radzerostock";
            this.Radzerostock.Size = new System.Drawing.Size(78, 17);
            this.Radzerostock.TabIndex = 1;
            this.Radzerostock.Text = "Zero Stock";
            this.Radzerostock.UseVisualStyleBackColor = true;
            // 
            // Radminus
            // 
            this.Radminus.AutoSize = true;
            this.Radminus.Location = new System.Drawing.Point(17, 39);
            this.Radminus.Name = "Radminus";
            this.Radminus.Size = new System.Drawing.Size(84, 17);
            this.Radminus.TabIndex = 0;
            this.Radminus.Text = "Minus Stock";
            this.Radminus.UseVisualStyleBackColor = true;
            // 
            // Dtto
            // 
            this.Dtto.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtto.Location = new System.Drawing.Point(328, 329);
            this.Dtto.Name = "Dtto";
            this.Dtto.Size = new System.Drawing.Size(129, 22);
            this.Dtto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(239, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 202;
            this.label8.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(237, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 205;
            this.label9.Text = "Unit";
            // 
            // Comunit
            // 
            this.Comunit.BackColor = System.Drawing.SystemColors.Window;
            this.Comunit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comunit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comunit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Comunit.FormattingEnabled = true;
            this.Comunit.Items.AddRange(new object[] {
            "Stock Item",
            "Services",
            "Finished Product",
            "Finished Product2"});
            this.Comunit.Location = new System.Drawing.Point(328, 435);
            this.Comunit.Name = "Comunit";
            this.Comunit.Size = new System.Drawing.Size(195, 23);
            this.Comunit.TabIndex = 5;
            // 
            // ChkAllunits
            // 
            this.ChkAllunits.AutoSize = true;
            this.ChkAllunits.Location = new System.Drawing.Point(608, 501);
            this.ChkAllunits.Name = "ChkAllunits";
            this.ChkAllunits.Size = new System.Drawing.Size(64, 17);
            this.ChkAllunits.TabIndex = 206;
            this.ChkAllunits.Text = "All Units";
            this.ChkAllunits.UseVisualStyleBackColor = true;
            // 
            // FrmSelectStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.Controls.Add(this.ChkAllunits);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Comunit);
            this.Controls.Add(this.Dtto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrpStocklevel);
            this.Controls.Add(this.chkAddTaxRate);
            this.Controls.Add(this.chkallmanufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commanufacturer);
            this.Controls.Add(this.Grpitembase);
            this.Controls.Add(this.Grpgroup);
            this.Controls.Add(this.Grpsupplierwise);
            this.Controls.Add(this.chkallitemclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comitemclass);
            this.Controls.Add(this.grpforselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkdepot);
            this.Controls.Add(this.ComDepot);
            this.Controls.Add(this.Lblamountmorethan);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TreeMain);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectStockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocklist Report";
            this.Load += new System.EventHandler(this.FrmSelectStockList_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmSelectStockList_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSelectStockList_KeyUp);
            this.Grpgroup.ResumeLayout(false);
            this.Grpgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagriditemcategory)).EndInit();
            this.Grpitembase.ResumeLayout(false);
            this.Grpitembase.PerformLayout();
            this.grpforselect.ResumeLayout(false);
            this.grpforselect.PerformLayout();
            this.Grpsupplierwise.ResumeLayout(false);
            this.Grpsupplierwise.PerformLayout();
            this.GrpStocklevel.ResumeLayout(false);
            this.GrpStocklevel.PerformLayout();
            this.Grpselectstockleve.ResumeLayout(false);
            this.Grpselectstockleve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.TreeView TreeMain;
        private System.Windows.Forms.Label Lblamountmorethan;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ComboBox ComDepot;
        private System.Windows.Forms.CheckBox chkdepot;
        private System.Windows.Forms.GroupBox Grpgroup;
        public System.Windows.Forms.DataGridView datagriditemcategory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngroupname;
        private System.Windows.Forms.Label Lblchk;
        private System.Windows.Forms.GroupBox Grpitembase;
        private System.Windows.Forms.Label Lblledger;
        private System.Windows.Forms.TextBox Txtitems;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.ComboBox combatchcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkcategoryall;
        private Uscitemshowsimple uscitemshowsimple1;
        private System.Windows.Forms.GroupBox grpforselect;
        private System.Windows.Forms.ComboBox comfor;
        private System.Windows.Forms.Label lblfor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comitemclass;
        private System.Windows.Forms.CheckBox chkallitemclass;
        private System.Windows.Forms.GroupBox Grpsupplierwise;
        private Uscitemshowsimple uscitemshowsimple2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.CheckBox chkallmanufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox commanufacturer;
        private System.Windows.Forms.CheckBox chkAddTaxRate;
        private System.Windows.Forms.GroupBox GrpStocklevel;
        private System.Windows.Forms.RadioButton Radselectstocklevel;
        private System.Windows.Forms.RadioButton Radzerostock;
        private System.Windows.Forms.RadioButton Radminus;
        private System.Windows.Forms.GroupBox Grpselectstockleve;
        private Uscnuemerictextbox txtfromlevelstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Uscnuemerictextbox txttolevelstock;
        private System.Windows.Forms.RadioButton RadAllleve;
        private System.Windows.Forms.DateTimePicker Dtto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Chkallbarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Comunit;
        private System.Windows.Forms.CheckBox ChkAllunits;
    }
}