namespace WindowsFormsApplication2
{
    partial class Frmstockadjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txttnetamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttqty = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lblstockarea = new System.Windows.Forms.Label();
            this.ComDepot = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblheading = new System.Windows.Forms.Label();
            this.cmdcreategroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdForward = new System.Windows.Forms.Button();
            this.CmdBack = new System.Windows.Forms.Button();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnettamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComMultiRate = new System.Windows.Forms.ComboBox();
            this.ComMultiUnit = new System.Windows.Forms.ComboBox();
            this.TxtProduct = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txttnetamount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txttqty);
            this.panel3.Controls.Add(this.cmdclose);
            this.panel3.Controls.Add(this.cmdclear);
            this.panel3.Controls.Add(this.cmddelete);
            this.panel3.Controls.Add(this.cmdprint);
            this.panel3.Controls.Add(this.cmdsave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 100);
            this.panel3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(196, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "T.Net Amount(Gross)";
            // 
            // txttnetamount
            // 
            this.txttnetamount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttnetamount.Location = new System.Drawing.Point(350, 6);
            this.txttnetamount.Name = "txttnetamount";
            this.txttnetamount.Size = new System.Drawing.Size(121, 25);
            this.txttnetamount.TabIndex = 10;
            this.txttnetamount.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "T.Qty";
            // 
            // txttqty
            // 
            this.txttqty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttqty.Location = new System.Drawing.Point(72, 6);
            this.txttqty.Name = "txttqty";
            this.txttqty.Size = new System.Drawing.Size(73, 25);
            this.txttqty.TabIndex = 8;
            this.txttqty.Tag = "2";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Silver;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(317, 61);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 4;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.Silver;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(239, 61);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 36);
            this.cmdclear.TabIndex = 3;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.BackColor = System.Drawing.Color.Silver;
            this.cmddelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmddelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmddelete.ForeColor = System.Drawing.Color.Black;
            this.cmddelete.Location = new System.Drawing.Point(161, 61);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(75, 36);
            this.cmddelete.TabIndex = 2;
            this.cmddelete.Text = "&Delete";
            this.cmddelete.UseVisualStyleBackColor = false;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.Silver;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(83, 61);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(75, 36);
            this.cmdprint.TabIndex = 1;
            this.cmdprint.Text = "&Print";
            this.cmdprint.UseVisualStyleBackColor = false;
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.Silver;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(3, 61);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(77, 36);
            this.cmdsave.TabIndex = 0;
            this.cmdsave.Text = "&Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Lblstockarea);
            this.panel2.Controls.Add(this.ComDepot);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblheading);
            this.panel2.Controls.Add(this.cmdcreategroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtRemark);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CmdForward);
            this.panel2.Controls.Add(this.CmdBack);
            this.panel2.Controls.Add(this.txtvno);
            this.panel2.Controls.Add(this.dtdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 68);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Lblstockarea
            // 
            this.Lblstockarea.AutoSize = true;
            this.Lblstockarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lblstockarea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Lblstockarea.ForeColor = System.Drawing.Color.White;
            this.Lblstockarea.Location = new System.Drawing.Point(158, 41);
            this.Lblstockarea.Name = "Lblstockarea";
            this.Lblstockarea.Size = new System.Drawing.Size(74, 19);
            this.Lblstockarea.TabIndex = 83;
            this.Lblstockarea.Text = "Stock Area";
            // 
            // ComDepot
            // 
            this.ComDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComDepot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComDepot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComDepot.FormattingEnabled = true;
            this.ComDepot.Location = new System.Drawing.Point(237, 38);
            this.ComDepot.Name = "ComDepot";
            this.ComDepot.Size = new System.Drawing.Size(121, 25);
            this.ComDepot.TabIndex = 1;
            this.ComDepot.SelectedIndexChanged += new System.EventHandler(this.ComDepot_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(249, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(238, 13);
            this.label20.TabIndex = 81;
            this.label20.Text = "-----------------------------------------------------------------------------";
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblheading.ForeColor = System.Drawing.Color.White;
            this.lblheading.Location = new System.Drawing.Point(304, 1);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(115, 19);
            this.lblheading.TabIndex = 80;
            this.lblheading.Text = "Stock adjustment";
            // 
            // cmdcreategroup
            // 
            this.cmdcreategroup.BackColor = System.Drawing.Color.Silver;
            this.cmdcreategroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdcreategroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcreategroup.Location = new System.Drawing.Point(518, 6);
            this.cmdcreategroup.Name = "cmdcreategroup";
            this.cmdcreategroup.Size = new System.Drawing.Size(23, 23);
            this.cmdcreategroup.TabIndex = 75;
            this.cmdcreategroup.UseVisualStyleBackColor = false;
            this.cmdcreategroup.Visible = false;
            this.cmdcreategroup.Click += new System.EventHandler(this.cmdcreategroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(605, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Remark";
            // 
            // TxtRemark
            // 
            this.TxtRemark.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtRemark.Location = new System.Drawing.Point(666, 38);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(110, 25);
            this.TxtRemark.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(694, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vno";
            // 
            // CmdForward
            // 
            this.CmdForward.Location = new System.Drawing.Point(106, 37);
            this.CmdForward.Name = "CmdForward";
            this.CmdForward.Size = new System.Drawing.Size(23, 27);
            this.CmdForward.TabIndex = 6;
            this.CmdForward.Text = ">";
            this.CmdForward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdForward.UseVisualStyleBackColor = true;
            this.CmdForward.Click += new System.EventHandler(this.CmdForward_Click);
            // 
            // CmdBack
            // 
            this.CmdBack.Location = new System.Drawing.Point(36, 37);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(23, 27);
            this.CmdBack.TabIndex = 5;
            this.CmdBack.Text = "<";
            this.CmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdBack.UseVisualStyleBackColor = true;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // txtvno
            // 
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtvno.Location = new System.Drawing.Point(62, 38);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(42, 25);
            this.txtvno.TabIndex = 0;
            // 
            // dtdate
            // 
            this.dtdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(732, 0);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 25);
            this.dtdate.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uscGridshow2);
            this.panel1.Controls.Add(this.gridmain);
            this.panel1.Controls.Add(this.ComMultiRate);
            this.panel1.Controls.Add(this.ComMultiUnit);
            this.panel1.Controls.Add(this.TxtProduct);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 503);
            this.panel1.TabIndex = 82;
            // 
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow2.Location = new System.Drawing.Point(13, 133);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow2.TabIndex = 96;
            this.uscGridshow2.Visible = false;
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.ColumnHeadersHeight = 30;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnitemcode,
            this.clnitemname,
            this.clnbatch,
            this.clnqty,
            this.ClnUnit,
            this.ClnMRate,
            this.clnrate,
            this.clnsrate,
            this.clnnettamount,
            this.clnmrp});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 68);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(840, 335);
            this.gridmain.TabIndex = 95;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 33.7457F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            // 
            // clnitemcode
            // 
            this.clnitemcode.FillWeight = 91.59553F;
            this.clnitemcode.HeaderText = "Itemcode";
            this.clnitemcode.Name = "clnitemcode";
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 198.4076F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.ReadOnly = true;
            this.clnitemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clnbatch
            // 
            this.clnbatch.HeaderText = "Batch code";
            this.clnbatch.Name = "clnbatch";
            // 
            // clnqty
            // 
            dataGridViewCellStyle3.NullValue = "0.00";
            this.clnqty.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnqty.FillWeight = 91.59553F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // ClnUnit
            // 
            this.ClnUnit.FillWeight = 91.59553F;
            this.ClnUnit.HeaderText = "Unit";
            this.ClnUnit.Name = "ClnUnit";
            this.ClnUnit.Visible = false;
            // 
            // ClnMRate
            // 
            this.ClnMRate.FillWeight = 91.59553F;
            this.ClnMRate.HeaderText = "Multi Rate";
            this.ClnMRate.Name = "ClnMRate";
            this.ClnMRate.Visible = false;
            // 
            // clnrate
            // 
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clnrate.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnrate.FillWeight = 91.59553F;
            this.clnrate.HeaderText = "P.Rate";
            this.clnrate.Name = "clnrate";
            // 
            // clnsrate
            // 
            dataGridViewCellStyle5.NullValue = "0.00";
            this.clnsrate.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnsrate.HeaderText = "S.Rate";
            this.clnsrate.Name = "clnsrate";
            // 
            // clnnettamount
            // 
            dataGridViewCellStyle6.NullValue = "0.00";
            this.clnnettamount.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnnettamount.FillWeight = 91.59553F;
            this.clnnettamount.HeaderText = "Net Amount";
            this.clnnettamount.Name = "clnnettamount";
            this.clnnettamount.ReadOnly = true;
            // 
            // clnmrp
            // 
            this.clnmrp.HeaderText = "Column1";
            this.clnmrp.Name = "clnmrp";
            this.clnmrp.Visible = false;
            // 
            // ComMultiRate
            // 
            this.ComMultiRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComMultiRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComMultiRate.FormattingEnabled = true;
            this.ComMultiRate.Location = new System.Drawing.Point(405, 239);
            this.ComMultiRate.Name = "ComMultiRate";
            this.ComMultiRate.Size = new System.Drawing.Size(121, 21);
            this.ComMultiRate.TabIndex = 94;
            this.ComMultiRate.Visible = false;
            // 
            // ComMultiUnit
            // 
            this.ComMultiUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComMultiUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComMultiUnit.FormattingEnabled = true;
            this.ComMultiUnit.Location = new System.Drawing.Point(251, 222);
            this.ComMultiUnit.Name = "ComMultiUnit";
            this.ComMultiUnit.Size = new System.Drawing.Size(121, 21);
            this.ComMultiUnit.TabIndex = 93;
            this.ComMultiUnit.Visible = false;
            // 
            // TxtProduct
            // 
            this.TxtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProduct.Location = new System.Drawing.Point(15, 211);
            this.TxtProduct.Multiline = true;
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.Size = new System.Drawing.Size(100, 21);
            this.TxtProduct.TabIndex = 21;
            this.TxtProduct.Visible = false;
            this.TxtProduct.TextChanged += new System.EventHandler(this.TxtProduct_TextChanged);
            this.TxtProduct.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtProduct_PreviewKeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Frmstockadjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 503);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmstockadjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Adjustment";
            this.Load += new System.EventHandler(this.Frmstockadjustment_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmstockadjustment_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmstockadjustment_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttnetamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttqty;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lblstockarea;
        private System.Windows.Forms.ComboBox ComDepot;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button cmdcreategroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdForward;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApplication2.UscGridshow uscGridshow2;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.ComboBox ComMultiRate;
        private System.Windows.Forms.ComboBox ComMultiUnit;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnettamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmrp;


    }
}