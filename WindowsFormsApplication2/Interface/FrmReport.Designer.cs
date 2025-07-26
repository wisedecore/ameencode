namespace WindowsFormsApplication2
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblHeading = new System.Windows.Forms.Label();
            this.LblDateBetween = new System.Windows.Forms.Label();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.cmdexportpdf = new System.Windows.Forms.Button();
            this.CMD_THERMAL = new System.Windows.Forms.Button();
            this.comprint = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdexcelimp = new System.Windows.Forms.Button();
            this.Cmdrefresh = new System.Windows.Forms.Button();
            this.chkconsole = new System.Windows.Forms.CheckBox();
            this.lblheading2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkremoveborder = new System.Windows.Forms.CheckBox();
            this.dateTimePickerto = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerfrom = new System.Windows.Forms.DateTimePicker();
            this.cmdexcel = new System.Windows.Forms.Button();
            this.cmdsettcolumns = new System.Windows.Forms.Button();
            this.LblHeadingArbic = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlsettings = new System.Windows.Forms.Panel();
            this.cmdclosepanel = new System.Windows.Forms.Button();
            this.cmdokpanel = new System.Windows.Forms.Button();
            this.pnlcolumnsett = new System.Windows.Forms.Panel();
            this.Gridreportsettings = new System.Windows.Forms.DataGridView();
            this.clnfield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clnnettamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnfree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMain = new System.Windows.Forms.DataGridView();
            this.pnlmain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlsettings.SuspendLayout();
            this.pnlcolumnsett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridreportsettings)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeading
            // 
            this.LblHeading.AutoSize = true;
            this.LblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeading.ForeColor = System.Drawing.Color.White;
            this.LblHeading.Location = new System.Drawing.Point(349, 45);
            this.LblHeading.Name = "LblHeading";
            this.LblHeading.Size = new System.Drawing.Size(51, 20);
            this.LblHeading.TabIndex = 2;
            this.LblHeading.Text = "label1";
            // 
            // LblDateBetween
            // 
            this.LblDateBetween.AutoSize = true;
            this.LblDateBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateBetween.ForeColor = System.Drawing.Color.White;
            this.LblDateBetween.Location = new System.Drawing.Point(349, 68);
            this.LblDateBetween.Name = "LblDateBetween";
            this.LblDateBetween.Size = new System.Drawing.Size(45, 16);
            this.LblDateBetween.TabIndex = 3;
            this.LblDateBetween.Text = "label2";
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.pnlmain.Controls.Add(this.cmdexportpdf);
            this.pnlmain.Controls.Add(this.CMD_THERMAL);
            this.pnlmain.Controls.Add(this.comprint);
            this.pnlmain.Controls.Add(this.label26);
            this.pnlmain.Controls.Add(this.panel3);
            this.pnlmain.Controls.Add(this.LblDateBetween);
            this.pnlmain.Controls.Add(this.LblHeadingArbic);
            this.pnlmain.Controls.Add(this.LblHeading);
            this.pnlmain.Controls.Add(this.button2);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(994, 120);
            this.pnlmain.TabIndex = 6;
            this.pnlmain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmain_Paint);
            // 
            // cmdexportpdf
            // 
            this.cmdexportpdf.BackColor = System.Drawing.Color.Moccasin;
            this.cmdexportpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexportpdf.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexportpdf.ForeColor = System.Drawing.Color.Blue;
            this.cmdexportpdf.Location = new System.Drawing.Point(178, 47);
            this.cmdexportpdf.Name = "cmdexportpdf";
            this.cmdexportpdf.Size = new System.Drawing.Size(90, 31);
            this.cmdexportpdf.TabIndex = 147;
            this.cmdexportpdf.Text = "PDF";
            this.cmdexportpdf.UseVisualStyleBackColor = false;
            this.cmdexportpdf.Visible = false;
            // 
            // CMD_THERMAL
            // 
            this.CMD_THERMAL.BackColor = System.Drawing.Color.Moccasin;
            this.CMD_THERMAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMD_THERMAL.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_THERMAL.ForeColor = System.Drawing.Color.Blue;
            this.CMD_THERMAL.Location = new System.Drawing.Point(82, 48);
            this.CMD_THERMAL.Name = "CMD_THERMAL";
            this.CMD_THERMAL.Size = new System.Drawing.Size(90, 31);
            this.CMD_THERMAL.TabIndex = 70;
            this.CMD_THERMAL.Text = "THERMAL";
            this.CMD_THERMAL.UseVisualStyleBackColor = false;
            this.CMD_THERMAL.Click += new System.EventHandler(this.CMD_THERMAL_Click);
            // 
            // comprint
            // 
            this.comprint.BackColor = System.Drawing.Color.White;
            this.comprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprint.Font = new System.Drawing.Font("Eras Medium ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprint.ForeColor = System.Drawing.Color.Red;
            this.comprint.FormattingEnabled = true;
            this.comprint.Location = new System.Drawing.Point(12, 94);
            this.comprint.Name = "comprint";
            this.comprint.Size = new System.Drawing.Size(187, 22);
            this.comprint.TabIndex = 146;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Fuchsia;
            this.label26.Location = new System.Drawing.Point(12, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 16);
            this.label26.TabIndex = 145;
            this.label26.Text = "Printer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.cmdexcelimp);
            this.panel3.Controls.Add(this.Cmdrefresh);
            this.panel3.Controls.Add(this.chkconsole);
            this.panel3.Controls.Add(this.lblheading2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkremoveborder);
            this.panel3.Controls.Add(this.dateTimePickerto);
            this.panel3.Controls.Add(this.dateTimePickerfrom);
            this.panel3.Controls.Add(this.cmdexcel);
            this.panel3.Controls.Add(this.cmdsettcolumns);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 42);
            this.panel3.TabIndex = 66;
            // 
            // cmdexcelimp
            // 
            this.cmdexcelimp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdexcelimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexcelimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexcelimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexcelimp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdexcelimp.Location = new System.Drawing.Point(91, 7);
            this.cmdexcelimp.Name = "cmdexcelimp";
            this.cmdexcelimp.Size = new System.Drawing.Size(81, 33);
            this.cmdexcelimp.TabIndex = 70;
            this.cmdexcelimp.Text = "Excel";
            this.cmdexcelimp.UseVisualStyleBackColor = false;
            this.cmdexcelimp.Click += new System.EventHandler(this.cmdexcelimp_Click);
            // 
            // Cmdrefresh
            // 
            this.Cmdrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.Cmdrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmdrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmdrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cmdrefresh.Location = new System.Drawing.Point(259, 8);
            this.Cmdrefresh.Name = "Cmdrefresh";
            this.Cmdrefresh.Size = new System.Drawing.Size(81, 33);
            this.Cmdrefresh.TabIndex = 6;
            this.Cmdrefresh.Text = "Refresh";
            this.Cmdrefresh.UseVisualStyleBackColor = false;
            this.Cmdrefresh.Click += new System.EventHandler(this.Cmdrefresh_Click);
            // 
            // chkconsole
            // 
            this.chkconsole.AutoSize = true;
            this.chkconsole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkconsole.Location = new System.Drawing.Point(812, 8);
            this.chkconsole.Name = "chkconsole";
            this.chkconsole.Size = new System.Drawing.Size(64, 17);
            this.chkconsole.TabIndex = 69;
            this.chkconsole.Text = "Console";
            this.chkconsole.UseVisualStyleBackColor = true;
            // 
            // lblheading2
            // 
            this.lblheading2.AutoSize = true;
            this.lblheading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading2.ForeColor = System.Drawing.Color.White;
            this.lblheading2.Location = new System.Drawing.Point(742, 7);
            this.lblheading2.Name = "lblheading2";
            this.lblheading2.Size = new System.Drawing.Size(51, 20);
            this.lblheading2.TabIndex = 67;
            this.lblheading2.Text = "label1";
            this.lblheading2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(535, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "From";
            // 
            // chkremoveborder
            // 
            this.chkremoveborder.AutoSize = true;
            this.chkremoveborder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkremoveborder.Location = new System.Drawing.Point(882, 7);
            this.chkremoveborder.Name = "chkremoveborder";
            this.chkremoveborder.Size = new System.Drawing.Size(100, 17);
            this.chkremoveborder.TabIndex = 68;
            this.chkremoveborder.Text = "Remove Border";
            this.chkremoveborder.UseVisualStyleBackColor = true;
            this.chkremoveborder.CheckedChanged += new System.EventHandler(this.chkremoveborder_CheckedChanged);
            // 
            // dateTimePickerto
            // 
            this.dateTimePickerto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerto.Location = new System.Drawing.Point(582, 12);
            this.dateTimePickerto.Name = "dateTimePickerto";
            this.dateTimePickerto.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerto.TabIndex = 2;
            this.dateTimePickerto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dateTimePickerto_PreviewKeyDown);
            // 
            // dateTimePickerfrom
            // 
            this.dateTimePickerfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerfrom.Location = new System.Drawing.Point(412, 11);
            this.dateTimePickerfrom.Name = "dateTimePickerfrom";
            this.dateTimePickerfrom.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerfrom.TabIndex = 1;
            this.dateTimePickerfrom.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dateTimePickerfrom_PreviewKeyDown);
            // 
            // cmdexcel
            // 
            this.cmdexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdexcel.Location = new System.Drawing.Point(175, 8);
            this.cmdexcel.Name = "cmdexcel";
            this.cmdexcel.Size = new System.Drawing.Size(81, 33);
            this.cmdexcel.TabIndex = 5;
            this.cmdexcel.Text = "Excel csv";
            this.cmdexcel.UseVisualStyleBackColor = false;
            this.cmdexcel.Click += new System.EventHandler(this.cmdexcel_Click);
            // 
            // cmdsettcolumns
            // 
            this.cmdsettcolumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdsettcolumns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdsettcolumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsettcolumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsettcolumns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdsettcolumns.Location = new System.Drawing.Point(13, 8);
            this.cmdsettcolumns.Name = "cmdsettcolumns";
            this.cmdsettcolumns.Size = new System.Drawing.Size(75, 33);
            this.cmdsettcolumns.TabIndex = 3;
            this.cmdsettcolumns.Text = "Settings";
            this.cmdsettcolumns.UseVisualStyleBackColor = false;
            this.cmdsettcolumns.Click += new System.EventHandler(this.cmdsettcolumns_Click);
            // 
            // LblHeadingArbic
            // 
            this.LblHeadingArbic.AutoSize = true;
            this.LblHeadingArbic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeadingArbic.ForeColor = System.Drawing.Color.White;
            this.LblHeadingArbic.Location = new System.Drawing.Point(348, 93);
            this.LblHeadingArbic.Name = "LblHeadingArbic";
            this.LblHeadingArbic.Size = new System.Drawing.Size(51, 20);
            this.LblHeadingArbic.TabIndex = 2;
            this.LblHeadingArbic.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(13, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "A4";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            // 
            // pnlsettings
            // 
            this.pnlsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.pnlsettings.Controls.Add(this.cmdclosepanel);
            this.pnlsettings.Controls.Add(this.cmdokpanel);
            this.pnlsettings.Controls.Add(this.pnlcolumnsett);
            this.pnlsettings.Controls.Add(this.panel8);
            this.pnlsettings.Location = new System.Drawing.Point(3, 126);
            this.pnlsettings.Name = "pnlsettings";
            this.pnlsettings.Size = new System.Drawing.Size(510, 375);
            this.pnlsettings.TabIndex = 66;
            this.pnlsettings.Visible = false;
            // 
            // cmdclosepanel
            // 
            this.cmdclosepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdclosepanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdclosepanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclosepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclosepanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdclosepanel.Location = new System.Drawing.Point(432, 349);
            this.cmdclosepanel.Name = "cmdclosepanel";
            this.cmdclosepanel.Size = new System.Drawing.Size(75, 23);
            this.cmdclosepanel.TabIndex = 67;
            this.cmdclosepanel.Text = "Close";
            this.cmdclosepanel.UseVisualStyleBackColor = false;
            this.cmdclosepanel.Click += new System.EventHandler(this.cmdclosepanel_Click);
            // 
            // cmdokpanel
            // 
            this.cmdokpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdokpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdokpanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdokpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdokpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdokpanel.Location = new System.Drawing.Point(353, 349);
            this.cmdokpanel.Name = "cmdokpanel";
            this.cmdokpanel.Size = new System.Drawing.Size(75, 23);
            this.cmdokpanel.TabIndex = 66;
            this.cmdokpanel.Text = "OK";
            this.cmdokpanel.UseVisualStyleBackColor = false;
            // 
            // pnlcolumnsett
            // 
            this.pnlcolumnsett.Controls.Add(this.Gridreportsettings);
            this.pnlcolumnsett.Location = new System.Drawing.Point(61, 27);
            this.pnlcolumnsett.Name = "pnlcolumnsett";
            this.pnlcolumnsett.Size = new System.Drawing.Size(382, 306);
            this.pnlcolumnsett.TabIndex = 65;
            // 
            // Gridreportsettings
            // 
            this.Gridreportsettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridreportsettings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridreportsettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridreportsettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnfield,
            this.clnwidth});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridreportsettings.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gridreportsettings.Location = new System.Drawing.Point(3, 3);
            this.Gridreportsettings.Name = "Gridreportsettings";
            this.Gridreportsettings.Size = new System.Drawing.Size(376, 300);
            this.Gridreportsettings.TabIndex = 0;
            // 
            // clnfield
            // 
            this.clnfield.HeaderText = "Fields";
            this.clnfield.Name = "clnfield";
            this.clnfield.Width = 200;
            // 
            // clnwidth
            // 
            this.clnwidth.HeaderText = "Width";
            this.clnwidth.Name = "clnwidth";
            this.clnwidth.Width = 130;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(510, 21);
            this.panel8.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Report Settings";
            // 
            // clnnettamount
            // 
            this.clnnettamount.FillWeight = 106.0914F;
            this.clnnettamount.HeaderText = "Net Amount";
            this.clnnettamount.Name = "clnnettamount";
            this.clnnettamount.Width = 118;
            // 
            // clntax
            // 
            this.clntax.FillWeight = 106.0914F;
            this.clntax.HeaderText = "Tax";
            this.clntax.Name = "clntax";
            this.clntax.Width = 58;
            // 
            // clndiscount
            // 
            this.clndiscount.FillWeight = 106.0914F;
            this.clndiscount.HeaderText = "Discount";
            this.clndiscount.Name = "clndiscount";
            this.clndiscount.Width = 96;
            // 
            // clnfree
            // 
            this.clnfree.FillWeight = 106.0914F;
            this.clnfree.HeaderText = "Free";
            this.clnfree.Name = "clnfree";
            this.clnfree.Width = 66;
            // 
            // clnsrate
            // 
            this.clnsrate.FillWeight = 106.0914F;
            this.clnsrate.HeaderText = "S.Rate";
            this.clnsrate.Name = "clnsrate";
            this.clnsrate.Width = 83;
            // 
            // ClnMRate
            // 
            this.ClnMRate.FillWeight = 106.0914F;
            this.ClnMRate.HeaderText = "Multi Rate";
            this.ClnMRate.Name = "ClnMRate";
            this.ClnMRate.Width = 105;
            // 
            // ClnUnit
            // 
            this.ClnUnit.FillWeight = 106.0914F;
            this.ClnUnit.HeaderText = "Unit";
            this.ClnUnit.Name = "ClnUnit";
            this.ClnUnit.Width = 62;
            // 
            // clnqty
            // 
            this.clnqty.FillWeight = 106.0914F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            this.clnqty.Width = 57;
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 106.0914F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnitemname.Width = 111;
            // 
            // clnitemcode
            // 
            this.clnitemcode.FillWeight = 106.0914F;
            this.clnitemcode.HeaderText = "Itemcode";
            this.clnitemcode.Name = "clnitemcode";
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 39.08629F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.Width = 65;
            // 
            // GridMain
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMain.ColumnHeadersHeight = 30;
            this.GridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnitemcode,
            this.clnitemname,
            this.clnqty,
            this.ClnUnit,
            this.ClnMRate,
            this.clnsrate,
            this.clnfree,
            this.clndiscount,
            this.clntax,
            this.clnnettamount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMain.EnableHeadersVisualStyles = false;
            this.GridMain.Location = new System.Drawing.Point(0, 120);
            this.GridMain.Name = "GridMain";
            this.GridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridMain.RowHeadersVisible = false;
            this.GridMain.ShowRowErrors = false;
            this.GridMain.Size = new System.Drawing.Size(994, 510);
            this.GridMain.TabIndex = 65;
            this.GridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellDoubleClick);
            this.GridMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GridMain_DataError);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(994, 630);
            this.Controls.Add(this.pnlsettings);
            this.Controls.Add(this.GridMain);
            this.Controls.Add(this.pnlmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmReport_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReport_FormClosing);
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlsettings.ResumeLayout(false);
            this.pnlcolumnsett.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridreportsettings)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDateBetween;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnlsettings;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlcolumnsett;
        private System.Windows.Forms.DataGridView Gridreportsettings;
        private System.Windows.Forms.Button cmdclosepanel;
        private System.Windows.Forms.Button cmdokpanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfield;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnettamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnfree;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridView GridMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cmdrefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerto;
        public System.Windows.Forms.DateTimePicker dateTimePickerfrom;
        private System.Windows.Forms.Button cmdexcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdsettcolumns;
        private System.Windows.Forms.Label lblheading2;
        private System.Windows.Forms.CheckBox chkremoveborder;
        public System.Windows.Forms.Label LblHeading;
        private System.Windows.Forms.CheckBox chkconsole;
        public System.Windows.Forms.Label LblHeadingArbic;
        private System.Windows.Forms.Button cmdexcelimp;
        private System.Windows.Forms.ComboBox comprint;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button CMD_THERMAL;
        private System.Windows.Forms.Button cmdexportpdf;
    }
}