namespace WindowsFormsApplication2
{
    partial class Frmselectpurchasereportnew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmselectpurchasereportnew));
            this.Pnlbottom = new System.Windows.Forms.Panel();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabmain = new System.Windows.Forms.TabControl();
            this.tabmainpurchase = new System.Windows.Forms.TabPage();
            this.Tabpurchase = new System.Windows.Forms.TabControl();
            this.Tabnormal = new System.Windows.Forms.TabPage();
            this.radnone = new System.Windows.Forms.RadioButton();
            this.radmonthwisesummury = new System.Windows.Forms.RadioButton();
            this.Raddatewisesummury = new System.Windows.Forms.RadioButton();
            this.Raddatewisedetail = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comvtype = new System.Windows.Forms.ComboBox();
            this.lblmodeofpayment = new System.Windows.Forms.Label();
            this.commodeofpayment = new System.Windows.Forms.ComboBox();
            this.GridVtype = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkvtype = new System.Windows.Forms.CheckBox();
            this.tabsupplierwise = new System.Windows.Forms.TabPage();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.txtsuppluer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabitemwise = new System.Windows.Forms.TabPage();
            this.Chkitemwisesumofqty = new System.Windows.Forms.CheckBox();
            this.chkallitem = new System.Windows.Forms.CheckBox();
            this.Txtitems = new System.Windows.Forms.TextBox();
            this.lblitemname = new System.Windows.Forms.Label();
            this.uscitemshowsimple1 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.Tabitemcategorywise = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.comcategory = new System.Windows.Forms.ComboBox();
            this.Tabmanufacturerwise = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Commanufacturer = new System.Windows.Forms.ComboBox();
            this.Tabarea = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Comarea = new System.Windows.Forms.ComboBox();
            this.tabpurchasetax = new System.Windows.Forms.TabPage();
            this.radpurchasetaxsumode3 = new System.Windows.Forms.RadioButton();
            this.radpurchasetaxsumode2 = new System.Windows.Forms.RadioButton();
            this.radpurchasetaxsumode1 = new System.Windows.Forms.RadioButton();
            this.Pnlbottom.SuspendLayout();
            this.Tabmain.SuspendLayout();
            this.tabmainpurchase.SuspendLayout();
            this.Tabpurchase.SuspendLayout();
            this.Tabnormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVtype)).BeginInit();
            this.tabsupplierwise.SuspendLayout();
            this.Tabitemwise.SuspendLayout();
            this.Tabitemcategorywise.SuspendLayout();
            this.Tabmanufacturerwise.SuspendLayout();
            this.Tabarea.SuspendLayout();
            this.tabpurchasetax.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlbottom
            // 
            this.Pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Pnlbottom.Controls.Add(this.DtTo);
            this.Pnlbottom.Controls.Add(this.label1);
            this.Pnlbottom.Controls.Add(this.cmdclose);
            this.Pnlbottom.Controls.Add(this.CmdShow);
            this.Pnlbottom.Controls.Add(this.DtFrom);
            this.Pnlbottom.Controls.Add(this.label3);
            this.Pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnlbottom.Location = new System.Drawing.Point(0, 416);
            this.Pnlbottom.Name = "Pnlbottom";
            this.Pnlbottom.Size = new System.Drawing.Size(671, 100);
            this.Pnlbottom.TabIndex = 0;
            // 
            // DtTo
            // 
            this.DtTo.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtTo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtTo.Location = new System.Drawing.Point(339, 72);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(148, 22);
            this.DtTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 166;
            this.label1.Text = "To";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(583, 56);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
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
            this.CmdShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(505, 56);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 2;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // DtFrom
            // 
            this.DtFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtFrom.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFrom.Location = new System.Drawing.Point(339, 46);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(148, 22);
            this.DtFrom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(279, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 162;
            this.label3.Text = "From";
            // 
            // Tabmain
            // 
            this.Tabmain.Controls.Add(this.tabmainpurchase);
            this.Tabmain.Controls.Add(this.tabpurchasetax);
            this.Tabmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabmain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabmain.Location = new System.Drawing.Point(0, 0);
            this.Tabmain.Name = "Tabmain";
            this.Tabmain.SelectedIndex = 0;
            this.Tabmain.Size = new System.Drawing.Size(671, 416);
            this.Tabmain.TabIndex = 194;
            this.Tabmain.SelectedIndexChanged += new System.EventHandler(this.Tabmain_SelectedIndexChanged);
            // 
            // tabmainpurchase
            // 
            this.tabmainpurchase.Controls.Add(this.Tabpurchase);
            this.tabmainpurchase.ForeColor = System.Drawing.Color.Black;
            this.tabmainpurchase.Location = new System.Drawing.Point(4, 22);
            this.tabmainpurchase.Name = "tabmainpurchase";
            this.tabmainpurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabmainpurchase.Size = new System.Drawing.Size(663, 390);
            this.tabmainpurchase.TabIndex = 0;
            this.tabmainpurchase.Text = "Purchase";
            this.tabmainpurchase.UseVisualStyleBackColor = true;
            // 
            // Tabpurchase
            // 
            this.Tabpurchase.Controls.Add(this.Tabnormal);
            this.Tabpurchase.Controls.Add(this.tabsupplierwise);
            this.Tabpurchase.Controls.Add(this.Tabitemwise);
            this.Tabpurchase.Controls.Add(this.Tabitemcategorywise);
            this.Tabpurchase.Controls.Add(this.Tabmanufacturerwise);
            this.Tabpurchase.Controls.Add(this.Tabarea);
            this.Tabpurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabpurchase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabpurchase.Location = new System.Drawing.Point(3, 3);
            this.Tabpurchase.Name = "Tabpurchase";
            this.Tabpurchase.SelectedIndex = 0;
            this.Tabpurchase.Size = new System.Drawing.Size(657, 384);
            this.Tabpurchase.TabIndex = 0;
            this.Tabpurchase.SelectedIndexChanged += new System.EventHandler(this.Tabpurchase_SelectedIndexChanged);
            // 
            // Tabnormal
            // 
            this.Tabnormal.Controls.Add(this.radnone);
            this.Tabnormal.Controls.Add(this.radmonthwisesummury);
            this.Tabnormal.Controls.Add(this.Raddatewisesummury);
            this.Tabnormal.Controls.Add(this.Raddatewisedetail);
            this.Tabnormal.Controls.Add(this.label4);
            this.Tabnormal.Controls.Add(this.comvtype);
            this.Tabnormal.Controls.Add(this.lblmodeofpayment);
            this.Tabnormal.Controls.Add(this.commodeofpayment);
            this.Tabnormal.Controls.Add(this.GridVtype);
            this.Tabnormal.Controls.Add(this.chkvtype);
            this.Tabnormal.Location = new System.Drawing.Point(4, 22);
            this.Tabnormal.Name = "Tabnormal";
            this.Tabnormal.Padding = new System.Windows.Forms.Padding(3);
            this.Tabnormal.Size = new System.Drawing.Size(649, 358);
            this.Tabnormal.TabIndex = 0;
            this.Tabnormal.Text = "Normal";
            this.Tabnormal.UseVisualStyleBackColor = true;
            // 
            // radnone
            // 
            this.radnone.AutoSize = true;
            this.radnone.Location = new System.Drawing.Point(518, 335);
            this.radnone.Name = "radnone";
            this.radnone.Size = new System.Drawing.Size(54, 17);
            this.radnone.TabIndex = 200;
            this.radnone.Text = "None";
            this.radnone.UseVisualStyleBackColor = true;
            // 
            // radmonthwisesummury
            // 
            this.radmonthwisesummury.AutoSize = true;
            this.radmonthwisesummury.Location = new System.Drawing.Point(517, 312);
            this.radmonthwisesummury.Name = "radmonthwisesummury";
            this.radmonthwisesummury.Size = new System.Drawing.Size(147, 17);
            this.radmonthwisesummury.TabIndex = 199;
            this.radmonthwisesummury.Text = "Month wise (summury)";
            this.radmonthwisesummury.UseVisualStyleBackColor = true;
            // 
            // Raddatewisesummury
            // 
            this.Raddatewisesummury.AutoSize = true;
            this.Raddatewisesummury.Location = new System.Drawing.Point(517, 290);
            this.Raddatewisesummury.Name = "Raddatewisesummury";
            this.Raddatewisesummury.Size = new System.Drawing.Size(132, 17);
            this.Raddatewisesummury.TabIndex = 198;
            this.Raddatewisesummury.Text = "Date wise(summury)";
            this.Raddatewisesummury.UseVisualStyleBackColor = true;
            // 
            // Raddatewisedetail
            // 
            this.Raddatewisedetail.AutoSize = true;
            this.Raddatewisedetail.Checked = true;
            this.Raddatewisedetail.Location = new System.Drawing.Point(516, 267);
            this.Raddatewisedetail.Name = "Raddatewisedetail";
            this.Raddatewisedetail.Size = new System.Drawing.Size(113, 17);
            this.Raddatewisedetail.TabIndex = 197;
            this.Raddatewisedetail.TabStop = true;
            this.Raddatewisedetail.Text = "Date wise(Detail)";
            this.Raddatewisedetail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(325, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 190;
            this.label4.Text = "Vtype";
            // 
            // comvtype
            // 
            this.comvtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comvtype.FormattingEnabled = true;
            this.comvtype.Items.AddRange(new object[] {
            "Purchase",
            "Purchase Return",
            "Purchase Order"});
            this.comvtype.Location = new System.Drawing.Point(439, 54);
            this.comvtype.Name = "comvtype";
            this.comvtype.Size = new System.Drawing.Size(182, 21);
            this.comvtype.TabIndex = 189;
            // 
            // lblmodeofpayment
            // 
            this.lblmodeofpayment.AutoSize = true;
            this.lblmodeofpayment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodeofpayment.ForeColor = System.Drawing.Color.Black;
            this.lblmodeofpayment.Location = new System.Drawing.Point(325, 27);
            this.lblmodeofpayment.Name = "lblmodeofpayment";
            this.lblmodeofpayment.Size = new System.Drawing.Size(101, 13);
            this.lblmodeofpayment.TabIndex = 188;
            this.lblmodeofpayment.Text = "Mode of Payment";
            // 
            // commodeofpayment
            // 
            this.commodeofpayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.commodeofpayment.FormattingEnabled = true;
            this.commodeofpayment.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Credit"});
            this.commodeofpayment.Location = new System.Drawing.Point(439, 27);
            this.commodeofpayment.Name = "commodeofpayment";
            this.commodeofpayment.Size = new System.Drawing.Size(182, 21);
            this.commodeofpayment.TabIndex = 187;
            // 
            // GridVtype
            // 
            this.GridVtype.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVtype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn3,
            this.clnvtype});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVtype.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridVtype.Enabled = false;
            this.GridVtype.EnableHeadersVisualStyles = false;
            this.GridVtype.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridVtype.Location = new System.Drawing.Point(33, 27);
            this.GridVtype.Name = "GridVtype";
            this.GridVtype.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridVtype.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridVtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridVtype.Size = new System.Drawing.Size(240, 285);
            this.GridVtype.TabIndex = 186;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.FalseValue = "0";
            this.dataGridViewCheckBoxColumn3.FillWeight = 25F;
            this.dataGridViewCheckBoxColumn3.HeaderText = "";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.TrueValue = "1";
            this.dataGridViewCheckBoxColumn3.Width = 25;
            // 
            // clnvtype
            // 
            this.clnvtype.FillWeight = 200F;
            this.clnvtype.HeaderText = "Voucher Name";
            this.clnvtype.Name = "clnvtype";
            this.clnvtype.ReadOnly = true;
            this.clnvtype.Width = 200;
            // 
            // chkvtype
            // 
            this.chkvtype.AutoSize = true;
            this.chkvtype.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkvtype.Location = new System.Drawing.Point(33, 6);
            this.chkvtype.Name = "chkvtype";
            this.chkvtype.Size = new System.Drawing.Size(121, 21);
            this.chkvtype.TabIndex = 185;
            this.chkvtype.Text = "All Voucher type";
            this.chkvtype.UseVisualStyleBackColor = true;
            this.chkvtype.CheckedChanged += new System.EventHandler(this.chkvtype_CheckedChanged);
            // 
            // tabsupplierwise
            // 
            this.tabsupplierwise.Controls.Add(this.uscitemshowsimple2);
            this.tabsupplierwise.Controls.Add(this.txtsuppluer);
            this.tabsupplierwise.Controls.Add(this.label2);
            this.tabsupplierwise.ForeColor = System.Drawing.Color.Red;
            this.tabsupplierwise.Location = new System.Drawing.Point(4, 22);
            this.tabsupplierwise.Name = "tabsupplierwise";
            this.tabsupplierwise.Padding = new System.Windows.Forms.Padding(3);
            this.tabsupplierwise.Size = new System.Drawing.Size(649, 358);
            this.tabsupplierwise.TabIndex = 1;
            this.tabsupplierwise.Text = "Supplier Wise";
            this.tabsupplierwise.UseVisualStyleBackColor = true;
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(82, 46);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(367, 253);
            this.uscitemshowsimple2.TabIndex = 192;
            this.uscitemshowsimple2.Visible = false;
            // 
            // txtsuppluer
            // 
            this.txtsuppluer.Location = new System.Drawing.Point(82, 22);
            this.txtsuppluer.Name = "txtsuppluer";
            this.txtsuppluer.Size = new System.Drawing.Size(367, 22);
            this.txtsuppluer.TabIndex = 191;
            this.txtsuppluer.TextChanged += new System.EventHandler(this.txtsuppluer_TextChanged);
            this.txtsuppluer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtsuppluer_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 190;
            this.label2.Text = "Supplier";
            // 
            // Tabitemwise
            // 
            this.Tabitemwise.Controls.Add(this.Chkitemwisesumofqty);
            this.Tabitemwise.Controls.Add(this.chkallitem);
            this.Tabitemwise.Controls.Add(this.Txtitems);
            this.Tabitemwise.Controls.Add(this.lblitemname);
            this.Tabitemwise.Controls.Add(this.uscitemshowsimple1);
            this.Tabitemwise.Location = new System.Drawing.Point(4, 22);
            this.Tabitemwise.Name = "Tabitemwise";
            this.Tabitemwise.Padding = new System.Windows.Forms.Padding(3);
            this.Tabitemwise.Size = new System.Drawing.Size(649, 358);
            this.Tabitemwise.TabIndex = 2;
            this.Tabitemwise.Text = "Item Wise";
            this.Tabitemwise.UseVisualStyleBackColor = true;
            // 
            // Chkitemwisesumofqty
            // 
            this.Chkitemwisesumofqty.AutoSize = true;
            this.Chkitemwisesumofqty.Location = new System.Drawing.Point(572, 22);
            this.Chkitemwisesumofqty.Name = "Chkitemwisesumofqty";
            this.Chkitemwisesumofqty.Size = new System.Drawing.Size(70, 17);
            this.Chkitemwisesumofqty.TabIndex = 199;
            this.Chkitemwisesumofqty.Text = "Sum Qty";
            this.Chkitemwisesumofqty.UseVisualStyleBackColor = true;
            // 
            // chkallitem
            // 
            this.chkallitem.AutoSize = true;
            this.chkallitem.Location = new System.Drawing.Point(6, 335);
            this.chkallitem.Name = "chkallitem";
            this.chkallitem.Size = new System.Drawing.Size(66, 17);
            this.chkallitem.TabIndex = 198;
            this.chkallitem.Text = "All Item";
            this.chkallitem.UseVisualStyleBackColor = true;
            this.chkallitem.Visible = false;
            // 
            // Txtitems
            // 
            this.Txtitems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtitems.Location = new System.Drawing.Point(6, 22);
            this.Txtitems.Name = "Txtitems";
            this.Txtitems.Size = new System.Drawing.Size(367, 22);
            this.Txtitems.TabIndex = 193;
            this.Txtitems.TextChanged += new System.EventHandler(this.Txtitems_TextChanged);
            this.Txtitems.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txtitems_PreviewKeyDown);
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.ForeColor = System.Drawing.Color.Black;
            this.lblitemname.Location = new System.Drawing.Point(6, 2);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(70, 15);
            this.lblitemname.TabIndex = 194;
            this.lblitemname.Text = "Item Name";
            // 
            // uscitemshowsimple1
            // 
            this.uscitemshowsimple1.Location = new System.Drawing.Point(9, 45);
            this.uscitemshowsimple1.Name = "uscitemshowsimple1";
            this.uscitemshowsimple1.Size = new System.Drawing.Size(632, 209);
            this.uscitemshowsimple1.TabIndex = 196;
            this.uscitemshowsimple1.Visible = false;
            // 
            // Tabitemcategorywise
            // 
            this.Tabitemcategorywise.Controls.Add(this.label5);
            this.Tabitemcategorywise.Controls.Add(this.comcategory);
            this.Tabitemcategorywise.Location = new System.Drawing.Point(4, 22);
            this.Tabitemcategorywise.Name = "Tabitemcategorywise";
            this.Tabitemcategorywise.Padding = new System.Windows.Forms.Padding(3);
            this.Tabitemcategorywise.Size = new System.Drawing.Size(649, 358);
            this.Tabitemcategorywise.TabIndex = 3;
            this.Tabitemcategorywise.Text = "Item Category Wise";
            this.Tabitemcategorywise.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 194;
            this.label5.Text = "Category";
            // 
            // comcategory
            // 
            this.comcategory.FormattingEnabled = true;
            this.comcategory.Items.AddRange(new object[] {
            "All",
            "cash",
            "Credit"});
            this.comcategory.Location = new System.Drawing.Point(91, 22);
            this.comcategory.Name = "comcategory";
            this.comcategory.Size = new System.Drawing.Size(182, 21);
            this.comcategory.TabIndex = 193;
            // 
            // Tabmanufacturerwise
            // 
            this.Tabmanufacturerwise.Controls.Add(this.label6);
            this.Tabmanufacturerwise.Controls.Add(this.Commanufacturer);
            this.Tabmanufacturerwise.Location = new System.Drawing.Point(4, 22);
            this.Tabmanufacturerwise.Name = "Tabmanufacturerwise";
            this.Tabmanufacturerwise.Padding = new System.Windows.Forms.Padding(3);
            this.Tabmanufacturerwise.Size = new System.Drawing.Size(649, 358);
            this.Tabmanufacturerwise.TabIndex = 4;
            this.Tabmanufacturerwise.Text = "Manfacturer Wise";
            this.Tabmanufacturerwise.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 196;
            this.label6.Text = "Manufacturer";
            // 
            // Commanufacturer
            // 
            this.Commanufacturer.FormattingEnabled = true;
            this.Commanufacturer.Items.AddRange(new object[] {
            "All",
            "cash",
            "Credit"});
            this.Commanufacturer.Location = new System.Drawing.Point(110, 21);
            this.Commanufacturer.Name = "Commanufacturer";
            this.Commanufacturer.Size = new System.Drawing.Size(182, 21);
            this.Commanufacturer.TabIndex = 195;
            // 
            // Tabarea
            // 
            this.Tabarea.Controls.Add(this.label9);
            this.Tabarea.Controls.Add(this.Comarea);
            this.Tabarea.Location = new System.Drawing.Point(4, 22);
            this.Tabarea.Name = "Tabarea";
            this.Tabarea.Padding = new System.Windows.Forms.Padding(3);
            this.Tabarea.Size = new System.Drawing.Size(649, 358);
            this.Tabarea.TabIndex = 5;
            this.Tabarea.Text = "Area";
            this.Tabarea.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 204;
            this.label9.Text = "Area";
            // 
            // Comarea
            // 
            this.Comarea.FormattingEnabled = true;
            this.Comarea.Items.AddRange(new object[] {
            "All",
            "cash",
            "Credit"});
            this.Comarea.Location = new System.Drawing.Point(111, 22);
            this.Comarea.Name = "Comarea";
            this.Comarea.Size = new System.Drawing.Size(182, 21);
            this.Comarea.TabIndex = 203;
            // 
            // tabpurchasetax
            // 
            this.tabpurchasetax.Controls.Add(this.radpurchasetaxsumode3);
            this.tabpurchasetax.Controls.Add(this.radpurchasetaxsumode2);
            this.tabpurchasetax.Controls.Add(this.radpurchasetaxsumode1);
            this.tabpurchasetax.ForeColor = System.Drawing.Color.Red;
            this.tabpurchasetax.Location = new System.Drawing.Point(4, 22);
            this.tabpurchasetax.Name = "tabpurchasetax";
            this.tabpurchasetax.Padding = new System.Windows.Forms.Padding(3);
            this.tabpurchasetax.Size = new System.Drawing.Size(663, 390);
            this.tabpurchasetax.TabIndex = 1;
            this.tabpurchasetax.Text = "Purchase Tax";
            this.tabpurchasetax.UseVisualStyleBackColor = true;
            // 
            // radpurchasetaxsumode3
            // 
            this.radpurchasetaxsumode3.AutoSize = true;
            this.radpurchasetaxsumode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radpurchasetaxsumode3.Location = new System.Drawing.Point(196, 19);
            this.radpurchasetaxsumode3.Name = "radpurchasetaxsumode3";
            this.radpurchasetaxsumode3.Size = new System.Drawing.Size(65, 17);
            this.radpurchasetaxsumode3.TabIndex = 8;
            this.radpurchasetaxsumode3.TabStop = true;
            this.radpurchasetaxsumode3.Text = "Mode 3";
            this.radpurchasetaxsumode3.UseVisualStyleBackColor = true;
            this.radpurchasetaxsumode3.Visible = false;
            // 
            // radpurchasetaxsumode2
            // 
            this.radpurchasetaxsumode2.AutoSize = true;
            this.radpurchasetaxsumode2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radpurchasetaxsumode2.Location = new System.Drawing.Point(105, 19);
            this.radpurchasetaxsumode2.Name = "radpurchasetaxsumode2";
            this.radpurchasetaxsumode2.Size = new System.Drawing.Size(65, 17);
            this.radpurchasetaxsumode2.TabIndex = 7;
            this.radpurchasetaxsumode2.TabStop = true;
            this.radpurchasetaxsumode2.Text = "Mode 2";
            this.radpurchasetaxsumode2.UseVisualStyleBackColor = true;
            // 
            // radpurchasetaxsumode1
            // 
            this.radpurchasetaxsumode1.AutoSize = true;
            this.radpurchasetaxsumode1.Checked = true;
            this.radpurchasetaxsumode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radpurchasetaxsumode1.Location = new System.Drawing.Point(21, 19);
            this.radpurchasetaxsumode1.Name = "radpurchasetaxsumode1";
            this.radpurchasetaxsumode1.Size = new System.Drawing.Size(65, 17);
            this.radpurchasetaxsumode1.TabIndex = 6;
            this.radpurchasetaxsumode1.TabStop = true;
            this.radpurchasetaxsumode1.Text = "Mode 1";
            this.radpurchasetaxsumode1.UseVisualStyleBackColor = true;
            // 
            // Frmselectpurchasereportnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 516);
            this.Controls.Add(this.Tabmain);
            this.Controls.Add(this.Pnlbottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frmselectpurchasereportnew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.Frmselectpurchasereportnew_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmselectpurchasereportnew_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frmselectpurchasereportnew_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmselectpurchasereportnew_PreviewKeyDown);
            this.Pnlbottom.ResumeLayout(false);
            this.Pnlbottom.PerformLayout();
            this.Tabmain.ResumeLayout(false);
            this.tabmainpurchase.ResumeLayout(false);
            this.Tabpurchase.ResumeLayout(false);
            this.Tabnormal.ResumeLayout(false);
            this.Tabnormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVtype)).EndInit();
            this.tabsupplierwise.ResumeLayout(false);
            this.tabsupplierwise.PerformLayout();
            this.Tabitemwise.ResumeLayout(false);
            this.Tabitemwise.PerformLayout();
            this.Tabitemcategorywise.ResumeLayout(false);
            this.Tabitemcategorywise.PerformLayout();
            this.Tabmanufacturerwise.ResumeLayout(false);
            this.Tabmanufacturerwise.PerformLayout();
            this.Tabarea.ResumeLayout(false);
            this.Tabarea.PerformLayout();
            this.tabpurchasetax.ResumeLayout(false);
            this.tabpurchasetax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlbottom;
        private System.Windows.Forms.TabControl Tabmain;
        private System.Windows.Forms.TabPage tabmainpurchase;
        private System.Windows.Forms.TabPage tabpurchasetax;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radpurchasetaxsumode3;
        private System.Windows.Forms.RadioButton radpurchasetaxsumode2;
        private System.Windows.Forms.RadioButton radpurchasetaxsumode1;
        private System.Windows.Forms.TabControl Tabpurchase;
        private System.Windows.Forms.TabPage Tabnormal;
        private System.Windows.Forms.RadioButton radnone;
        private System.Windows.Forms.RadioButton radmonthwisesummury;
        private System.Windows.Forms.RadioButton Raddatewisesummury;
        private System.Windows.Forms.RadioButton Raddatewisedetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comvtype;
        private System.Windows.Forms.Label lblmodeofpayment;
        private System.Windows.Forms.ComboBox commodeofpayment;
        public System.Windows.Forms.DataGridView GridVtype;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvtype;
        private System.Windows.Forms.CheckBox chkvtype;
        private System.Windows.Forms.TabPage tabsupplierwise;
        private Uscitemshowsimple uscitemshowsimple2;
        private System.Windows.Forms.TextBox txtsuppluer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Tabitemwise;
        private System.Windows.Forms.CheckBox Chkitemwisesumofqty;
        private System.Windows.Forms.CheckBox chkallitem;
        private System.Windows.Forms.TextBox Txtitems;
        private System.Windows.Forms.Label lblitemname;
        private Uscitemshowsimple uscitemshowsimple1;
        private System.Windows.Forms.TabPage Tabitemcategorywise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comcategory;
        private System.Windows.Forms.TabPage Tabmanufacturerwise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Commanufacturer;
        private System.Windows.Forms.TabPage Tabarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Comarea;

    }
}