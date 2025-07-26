namespace WindowsFormsApplication2
{
    partial class Frmselectaccountreport
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ledger Wise");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Group Wise");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ledger Report", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Supplier Wise");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Group Wise");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Outstanding Report", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Bill WiseProfit");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bill wise settlement");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Payment and Receipt");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmselectaccountreport));
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.TreeMain = new System.Windows.Forms.TreeView();
            this.Grpgroupselect = new System.Windows.Forms.GroupBox();
            this.txtgroup = new System.Windows.Forms.TextBox();
            this.chkallitemgroup = new System.Windows.Forms.CheckBox();
            this.GridGroup = new System.Windows.Forms.DataGridView();
            this.clnselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clngroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblselectgroup = new System.Windows.Forms.Label();
            this.GrpSingleSelect = new System.Windows.Forms.GroupBox();
            this.Txtaccount = new System.Windows.Forms.TextBox();
            this.Lblledger = new System.Windows.Forms.Label();
            this.grpselection = new System.Windows.Forms.GroupBox();
            this.raddetail = new System.Windows.Forms.RadioButton();
            this.radsummery = new System.Windows.Forms.RadioButton();
            this.pnlpartyproject = new System.Windows.Forms.Panel();
            this.chkallproject = new System.Windows.Forms.CheckBox();
            this.Gridprojecttype = new System.Windows.Forms.DataGridView();
            this.clnselect1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnaration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comarea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkallarea = new System.Windows.Forms.CheckBox();
            this.cmreceiptonly = new System.Windows.Forms.Button();
            this.cmdpaymentonly = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Chkduedays = new System.Windows.Forms.CheckBox();
            this.chktaxrp = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdays = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtamount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.uscitemshowsimple1 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.Grpgroupselect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGroup)).BeginInit();
            this.GrpSingleSelect.SuspendLayout();
            this.grpselection.SuspendLayout();
            this.pnlpartyproject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridprojecttype)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(466, 546);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(82, 36);
            this.cmdclose.TabIndex = 3;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(388, 546);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(82, 36);
            this.CmdShow.TabIndex = 2;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(416, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 118;
            this.label5.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.CalendarFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTo.CalendarForeColor = System.Drawing.Color.Black;
            this.DtTo.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DtTo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold);
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(440, 476);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(110, 23);
            this.DtTo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(263, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "From";
            // 
            // Dtfrom
            // 
            this.Dtfrom.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtfrom.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(303, 476);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(110, 23);
            this.Dtfrom.TabIndex = 0;
            // 
            // TreeMain
            // 
            this.TreeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.TreeMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMain.ForeColor = System.Drawing.Color.Indigo;
            this.TreeMain.ItemHeight = 30;
            this.TreeMain.Location = new System.Drawing.Point(0, 0);
            this.TreeMain.Name = "TreeMain";
            treeNode1.Name = "Ndledledgerwise";
            treeNode1.Text = "Ledger Wise";
            treeNode2.Name = "Ndledgroupwise";
            treeNode2.Text = "Group Wise";
            treeNode3.Name = "Ndledgerreport";
            treeNode3.Text = "Ledger Report";
            treeNode4.Name = "Ndoutledgerwise";
            treeNode4.Text = "Supplier Wise";
            treeNode5.Name = "Ndoutgroupwise";
            treeNode5.Text = "Group Wise";
            treeNode6.Name = "Ndoutstanding";
            treeNode6.Text = "Outstanding Report";
            treeNode7.Name = "NdBillwiseprofit";
            treeNode7.Text = "Bill WiseProfit";
            treeNode8.Name = "Ndbillwisesett";
            treeNode8.Text = "Bill wise settlement";
            treeNode9.Name = "Ndpandr";
            treeNode9.Text = "Payment and Receipt";
            this.TreeMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.TreeMain.Size = new System.Drawing.Size(181, 588);
            this.TreeMain.TabIndex = 98;
            this.TreeMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMain_AfterSelect);
            this.TreeMain.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeMain_BeforeSelect);
            // 
            // Grpgroupselect
            // 
            this.Grpgroupselect.Controls.Add(this.txtgroup);
            this.Grpgroupselect.Controls.Add(this.chkallitemgroup);
            this.Grpgroupselect.Controls.Add(this.GridGroup);
            this.Grpgroupselect.Controls.Add(this.lblselectgroup);
            this.Grpgroupselect.Location = new System.Drawing.Point(194, 9);
            this.Grpgroupselect.Name = "Grpgroupselect";
            this.Grpgroupselect.Size = new System.Drawing.Size(605, 282);
            this.Grpgroupselect.TabIndex = 180;
            this.Grpgroupselect.TabStop = false;
            this.Grpgroupselect.Visible = false;
            // 
            // txtgroup
            // 
            this.txtgroup.Location = new System.Drawing.Point(126, 14);
            this.txtgroup.Name = "txtgroup";
            this.txtgroup.Size = new System.Drawing.Size(451, 20);
            this.txtgroup.TabIndex = 185;
            this.txtgroup.TextChanged += new System.EventHandler(this.txtgroup_TextChanged);
            // 
            // chkallitemgroup
            // 
            this.chkallitemgroup.AutoSize = true;
            this.chkallitemgroup.Checked = true;
            this.chkallitemgroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallitemgroup.Location = new System.Drawing.Point(92, 15);
            this.chkallitemgroup.Name = "chkallitemgroup";
            this.chkallitemgroup.Size = new System.Drawing.Size(37, 17);
            this.chkallitemgroup.TabIndex = 183;
            this.chkallitemgroup.Text = "All";
            this.chkallitemgroup.UseVisualStyleBackColor = true;
            this.chkallitemgroup.CheckedChanged += new System.EventHandler(this.chkallitemgroup_CheckedChanged);
            // 
            // GridGroup
            // 
            this.GridGroup.AllowUserToAddRows = false;
            this.GridGroup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselect,
            this.clngroupname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridGroup.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridGroup.EnableHeadersVisualStyles = false;
            this.GridGroup.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridGroup.Location = new System.Drawing.Point(89, 40);
            this.GridGroup.Name = "GridGroup";
            this.GridGroup.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridGroup.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridGroup.Size = new System.Drawing.Size(488, 236);
            this.GridGroup.TabIndex = 182;
            this.GridGroup.Visible = false;
            this.GridGroup.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGroup_CellValueChanged);
            this.GridGroup.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridGroup_CellMouseClick);
            // 
            // clnselect
            // 
            this.clnselect.FalseValue = "0";
            this.clnselect.FillWeight = 25F;
            this.clnselect.HeaderText = "";
            this.clnselect.IndeterminateValue = "-1";
            this.clnselect.Name = "clnselect";
            this.clnselect.TrueValue = "1";
            this.clnselect.Width = 25;
            // 
            // clngroupname
            // 
            this.clngroupname.FillWeight = 200F;
            this.clngroupname.HeaderText = "Group Name";
            this.clngroupname.Name = "clngroupname";
            this.clngroupname.ReadOnly = true;
            this.clngroupname.Width = 400;
            // 
            // lblselectgroup
            // 
            this.lblselectgroup.AutoSize = true;
            this.lblselectgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectgroup.ForeColor = System.Drawing.Color.Black;
            this.lblselectgroup.Location = new System.Drawing.Point(4, 14);
            this.lblselectgroup.Name = "lblselectgroup";
            this.lblselectgroup.Size = new System.Drawing.Size(83, 17);
            this.lblselectgroup.TabIndex = 180;
            this.lblselectgroup.Text = "Select Group";
            this.lblselectgroup.Visible = false;
            // 
            // GrpSingleSelect
            // 
            this.GrpSingleSelect.Controls.Add(this.uscitemshowsimple1);
            this.GrpSingleSelect.Controls.Add(this.Txtaccount);
            this.GrpSingleSelect.Controls.Add(this.Lblledger);
            this.GrpSingleSelect.Location = new System.Drawing.Point(187, 23);
            this.GrpSingleSelect.Name = "GrpSingleSelect";
            this.GrpSingleSelect.Size = new System.Drawing.Size(612, 286);
            this.GrpSingleSelect.TabIndex = 184;
            this.GrpSingleSelect.TabStop = false;
            // 
            // Txtaccount
            // 
            this.Txtaccount.Location = new System.Drawing.Point(103, 13);
            this.Txtaccount.Name = "Txtaccount";
            this.Txtaccount.Size = new System.Drawing.Size(449, 20);
            this.Txtaccount.TabIndex = 179;
            this.Txtaccount.TextChanged += new System.EventHandler(this.Txtaccount_TextChanged);
            this.Txtaccount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txtaccount_PreviewKeyDown);
            // 
            // Lblledger
            // 
            this.Lblledger.AutoSize = true;
            this.Lblledger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblledger.ForeColor = System.Drawing.Color.Black;
            this.Lblledger.Location = new System.Drawing.Point(3, 11);
            this.Lblledger.Name = "Lblledger";
            this.Lblledger.Size = new System.Drawing.Size(87, 17);
            this.Lblledger.TabIndex = 181;
            this.Lblledger.Text = "Select Ledger";
            // 
            // grpselection
            // 
            this.grpselection.Controls.Add(this.raddetail);
            this.grpselection.Controls.Add(this.radsummery);
            this.grpselection.Location = new System.Drawing.Point(301, 497);
            this.grpselection.Name = "grpselection";
            this.grpselection.Size = new System.Drawing.Size(247, 40);
            this.grpselection.TabIndex = 181;
            this.grpselection.TabStop = false;
            // 
            // raddetail
            // 
            this.raddetail.AutoSize = true;
            this.raddetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddetail.ForeColor = System.Drawing.Color.Black;
            this.raddetail.Location = new System.Drawing.Point(136, 12);
            this.raddetail.Name = "raddetail";
            this.raddetail.Size = new System.Drawing.Size(59, 21);
            this.raddetail.TabIndex = 127;
            this.raddetail.Text = "Detail";
            this.raddetail.UseVisualStyleBackColor = true;
            // 
            // radsummery
            // 
            this.radsummery.AutoSize = true;
            this.radsummery.Checked = true;
            this.radsummery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radsummery.ForeColor = System.Drawing.Color.Black;
            this.radsummery.Location = new System.Drawing.Point(7, 10);
            this.radsummery.Name = "radsummery";
            this.radsummery.Size = new System.Drawing.Size(80, 21);
            this.radsummery.TabIndex = 126;
            this.radsummery.TabStop = true;
            this.radsummery.Text = "Summary";
            this.radsummery.UseVisualStyleBackColor = true;
            // 
            // pnlpartyproject
            // 
            this.pnlpartyproject.Controls.Add(this.chkallproject);
            this.pnlpartyproject.Controls.Add(this.Gridprojecttype);
            this.pnlpartyproject.Location = new System.Drawing.Point(187, 316);
            this.pnlpartyproject.Name = "pnlpartyproject";
            this.pnlpartyproject.Size = new System.Drawing.Size(469, 144);
            this.pnlpartyproject.TabIndex = 185;
            this.pnlpartyproject.Visible = false;
            // 
            // chkallproject
            // 
            this.chkallproject.AutoSize = true;
            this.chkallproject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallproject.Location = new System.Drawing.Point(381, 3);
            this.chkallproject.Name = "chkallproject";
            this.chkallproject.Size = new System.Drawing.Size(85, 21);
            this.chkallproject.TabIndex = 188;
            this.chkallproject.Text = "All Project";
            this.chkallproject.UseVisualStyleBackColor = true;
            this.chkallproject.CheckedChanged += new System.EventHandler(this.chkallproject_CheckedChanged);
            // 
            // Gridprojecttype
            // 
            this.Gridprojecttype.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprojecttype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridprojecttype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridprojecttype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselect1,
            this.clnvtype});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridprojecttype.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gridprojecttype.Enabled = false;
            this.Gridprojecttype.EnableHeadersVisualStyles = false;
            this.Gridprojecttype.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridprojecttype.Location = new System.Drawing.Point(0, 3);
            this.Gridprojecttype.Name = "Gridprojecttype";
            this.Gridprojecttype.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gridprojecttype.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Gridprojecttype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridprojecttype.ShowCellErrors = false;
            this.Gridprojecttype.Size = new System.Drawing.Size(375, 138);
            this.Gridprojecttype.TabIndex = 187;
            this.Gridprojecttype.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridprojecttype_RowLeave);
            // 
            // clnselect1
            // 
            this.clnselect1.FalseValue = "0";
            this.clnselect1.FillWeight = 25F;
            this.clnselect1.HeaderText = "";
            this.clnselect1.Name = "clnselect1";
            this.clnselect1.TrueValue = "1";
            this.clnselect1.Width = 25;
            // 
            // clnvtype
            // 
            this.clnvtype.FillWeight = 200F;
            this.clnvtype.HeaderText = "Project Name";
            this.clnvtype.Name = "clnvtype";
            this.clnvtype.ReadOnly = true;
            this.clnvtype.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 187;
            this.label1.Text = "Amount Greater";
            // 
            // txtnaration
            // 
            this.txtnaration.Location = new System.Drawing.Point(590, 60);
            this.txtnaration.Name = "txtnaration";
            this.txtnaration.Size = new System.Drawing.Size(199, 20);
            this.txtnaration.TabIndex = 188;
            this.txtnaration.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(590, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 189;
            this.label2.Text = "Naration";
            this.label2.Visible = false;
            // 
            // Comarea
            // 
            this.Comarea.Enabled = false;
            this.Comarea.FormattingEnabled = true;
            this.Comarea.Items.AddRange(new object[] {
            "All",
            "cash",
            "Credit"});
            this.Comarea.Location = new System.Drawing.Point(744, 319);
            this.Comarea.Name = "Comarea";
            this.Comarea.Size = new System.Drawing.Size(182, 21);
            this.Comarea.TabIndex = 195;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(669, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 196;
            this.label4.Text = "Area";
            // 
            // chkallarea
            // 
            this.chkallarea.AutoSize = true;
            this.chkallarea.Checked = true;
            this.chkallarea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallarea.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallarea.Location = new System.Drawing.Point(932, 319);
            this.chkallarea.Name = "chkallarea";
            this.chkallarea.Size = new System.Drawing.Size(41, 21);
            this.chkallarea.TabIndex = 197;
            this.chkallarea.Text = "All";
            this.chkallarea.UseVisualStyleBackColor = true;
            this.chkallarea.CheckedChanged += new System.EventHandler(this.chkallarea_CheckedChanged);
            // 
            // cmreceiptonly
            // 
            this.cmreceiptonly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmreceiptonly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmreceiptonly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmreceiptonly.Location = new System.Drawing.Point(3, 8);
            this.cmreceiptonly.Name = "cmreceiptonly";
            this.cmreceiptonly.Size = new System.Drawing.Size(182, 31);
            this.cmreceiptonly.TabIndex = 198;
            this.cmreceiptonly.Text = "Receipt Report";
            this.cmreceiptonly.UseVisualStyleBackColor = false;
            this.cmreceiptonly.Click += new System.EventHandler(this.cmreceiptonly_Click);
            // 
            // cmdpaymentonly
            // 
            this.cmdpaymentonly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdpaymentonly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdpaymentonly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdpaymentonly.Location = new System.Drawing.Point(3, 43);
            this.cmdpaymentonly.Name = "cmdpaymentonly";
            this.cmdpaymentonly.Size = new System.Drawing.Size(182, 31);
            this.cmdpaymentonly.TabIndex = 199;
            this.cmdpaymentonly.Text = "Payment Report";
            this.cmdpaymentonly.UseVisualStyleBackColor = false;
            this.cmdpaymentonly.Click += new System.EventHandler(this.cmdpaymentonly_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(754, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 201;
            this.label6.Text = "Days";
            // 
            // Chkduedays
            // 
            this.Chkduedays.AutoSize = true;
            this.Chkduedays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkduedays.Location = new System.Drawing.Point(842, 455);
            this.Chkduedays.Name = "Chkduedays";
            this.Chkduedays.Size = new System.Drawing.Size(53, 17);
            this.Chkduedays.TabIndex = 202;
            this.Chkduedays.Text = "Due ";
            this.Chkduedays.UseVisualStyleBackColor = true;
            // 
            // chktaxrp
            // 
            this.chktaxrp.AutoSize = true;
            this.chktaxrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktaxrp.Location = new System.Drawing.Point(195, 34);
            this.chktaxrp.Name = "chktaxrp";
            this.chktaxrp.Size = new System.Drawing.Size(75, 17);
            this.chktaxrp.TabIndex = 203;
            this.chktaxrp.Text = "R_P Tax";
            this.chktaxrp.UseVisualStyleBackColor = true;
            this.chktaxrp.CheckedChanged += new System.EventHandler(this.chktaxrp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmreceiptonly);
            this.panel1.Controls.Add(this.chktaxrp);
            this.panel1.Controls.Add(this.cmdpaymentonly);
            this.panel1.Location = new System.Drawing.Point(695, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 81);
            this.panel1.TabIndex = 204;
            // 
            // txtdays
            // 
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdays.Location = new System.Drawing.Point(799, 445);
            this.txtdays.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(36, 37);
            this.txtdays.TabIndex = 200;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(190, 515);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(97, 22);
            this.txtamount.TabIndex = 186;
            // 
            // uscitemshowsimple1
            // 
            this.uscitemshowsimple1.Location = new System.Drawing.Point(13, 37);
            this.uscitemshowsimple1.Name = "uscitemshowsimple1";
            this.uscitemshowsimple1.Size = new System.Drawing.Size(539, 117);
            this.uscitemshowsimple1.TabIndex = 182;
            this.uscitemshowsimple1.Visible = false;
            // 
            // Frmselectaccountreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(976, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chkduedays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.chkallarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comarea);
            this.Controls.Add(this.Grpgroupselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.pnlpartyproject);
            this.Controls.Add(this.GrpSingleSelect);
            this.Controls.Add(this.TreeMain);
            this.Controls.Add(this.grpselection);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnaration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmselectaccountreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Frmselectaccountreport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmselectaccountreport_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frmselectaccountreport_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmselectaccountreport_PreviewKeyDown);
            this.Grpgroupselect.ResumeLayout(false);
            this.Grpgroupselect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGroup)).EndInit();
            this.GrpSingleSelect.ResumeLayout(false);
            this.GrpSingleSelect.PerformLayout();
            this.grpselection.ResumeLayout(false);
            this.grpselection.PerformLayout();
            this.pnlpartyproject.ResumeLayout(false);
            this.pnlpartyproject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridprojecttype)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.GroupBox Grpgroupselect;
        public System.Windows.Forms.DataGridView GridGroup;
        private System.Windows.Forms.Label Lblledger;
        private System.Windows.Forms.Label lblselectgroup;
        private System.Windows.Forms.TextBox Txtaccount;
        private System.Windows.Forms.GroupBox grpselection;
        private System.Windows.Forms.RadioButton raddetail;
        private System.Windows.Forms.RadioButton radsummery;
        protected System.Windows.Forms.TreeView TreeMain;
        private System.Windows.Forms.GroupBox GrpSingleSelect;
        private Uscitemshowsimple uscitemshowsimple1;
        private System.Windows.Forms.CheckBox chkallitemgroup;
        private System.Windows.Forms.TextBox txtgroup;
        private System.Windows.Forms.Panel pnlpartyproject;
        private System.Windows.Forms.CheckBox chkallproject;
        private Uscnuemerictextbox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Gridprojecttype;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselect1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvtype;
        private System.Windows.Forms.TextBox txtnaration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Comarea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkallarea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngroupname;
        private System.Windows.Forms.Button cmreceiptonly;
        private System.Windows.Forms.Button cmdpaymentonly;
        private Uscnuemerictextbox txtdays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Chkduedays;
        private System.Windows.Forms.CheckBox chktaxrp;
        private System.Windows.Forms.Panel panel1;
    }
}