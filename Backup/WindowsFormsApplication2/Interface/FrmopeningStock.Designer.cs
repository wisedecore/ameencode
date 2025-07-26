namespace WindowsFormsApplication2
{
    partial class FrmopeningStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmopeningStock));
            this.lblenetervno = new System.Windows.Forms.Label();
            this.txtnterprevno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gridbatchlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Linkimportfromtool = new System.Windows.Forms.LinkLabel();
            this.lblprateautofilling = new System.Windows.Forms.LinkLabel();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.TxtProduct = new System.Windows.Forms.TextBox();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txttqty = new System.Windows.Forms.TextBox();
            this.GridBatch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.lbldepot = new System.Windows.Forms.Label();
            this.ComDepot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmdforward = new System.Windows.Forms.Button();
            this.CmdBack = new System.Windows.Forms.Button();
            this.TxtVno = new System.Windows.Forms.TextBox();
            this.CHKbatchwise = new System.Windows.Forms.CheckBox();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.panel2.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBatch)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblenetervno
            // 
            this.lblenetervno.AutoSize = true;
            this.lblenetervno.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblenetervno.ForeColor = System.Drawing.Color.Black;
            this.lblenetervno.Location = new System.Drawing.Point(160, 9);
            this.lblenetervno.Name = "lblenetervno";
            this.lblenetervno.Size = new System.Drawing.Size(58, 13);
            this.lblenetervno.TabIndex = 76;
            this.lblenetervno.Text = "Enter Vno";
            this.lblenetervno.Visible = false;
            // 
            // txtnterprevno
            // 
            this.txtnterprevno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnterprevno.Location = new System.Drawing.Point(236, 5);
            this.txtnterprevno.Name = "txtnterprevno";
            this.txtnterprevno.Size = new System.Drawing.Size(76, 25);
            this.txtnterprevno.TabIndex = 1;
            this.txtnterprevno.Visible = false;
            this.txtnterprevno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtnterprevno_PreviewKeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Gridbatchlist);
            this.panel1.Controls.Add(this.uscGridshow2);
            this.panel1.Controls.Add(this.gridmain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GridBatch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 547);
            this.panel1.TabIndex = 62;
            // 
            // Gridbatchlist
            // 
            this.Gridbatchlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridbatchlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gridbatchlist.ColumnHeadersVisible = false;
            this.Gridbatchlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridbatchlist.DefaultCellStyle = dataGridViewCellStyle1;
            this.Gridbatchlist.Location = new System.Drawing.Point(579, 76);
            this.Gridbatchlist.Name = "Gridbatchlist";
            this.Gridbatchlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Gridbatchlist.RowHeadersVisible = false;
            this.Gridbatchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridbatchlist.Size = new System.Drawing.Size(155, 105);
            this.Gridbatchlist.TabIndex = 121;
            this.Gridbatchlist.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // gridmain
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 32);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(925, 434);
            this.gridmain.TabIndex = 0;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 28.44338F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            // 
            // clnitemcode
            // 
            this.clnitemcode.FillWeight = 202.674F;
            this.clnitemcode.HeaderText = "Itemcode";
            this.clnitemcode.Name = "clnitemcode";
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 167.2327F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.ReadOnly = true;
            this.clnitemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clnbatch
            // 
            this.clnbatch.FillWeight = 84.28744F;
            this.clnbatch.HeaderText = "Batch code";
            this.clnbatch.Name = "clnbatch";
            // 
            // clnqty
            // 
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clnqty.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnqty.FillWeight = 77.20352F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // ClnUnit
            // 
            this.ClnUnit.FillWeight = 91.59553F;
            this.ClnUnit.HeaderText = "Unit";
            this.ClnUnit.Name = "ClnUnit";
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
            dataGridViewCellStyle5.NullValue = "0.00";
            this.clnrate.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnrate.FillWeight = 77.20352F;
            this.clnrate.HeaderText = "P.Rate";
            this.clnrate.Name = "clnrate";
            // 
            // clnsrate
            // 
            dataGridViewCellStyle6.NullValue = "0.00";
            this.clnsrate.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnsrate.FillWeight = 84.28744F;
            this.clnsrate.HeaderText = "S.Rate";
            this.clnsrate.Name = "clnsrate";
            // 
            // clnnettamount
            // 
            dataGridViewCellStyle7.NullValue = "0.00";
            this.clnnettamount.DefaultCellStyle = dataGridViewCellStyle7;
            this.clnnettamount.FillWeight = 77.20352F;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.lblenetervno);
            this.panel2.Controls.Add(this.Linkimportfromtool);
            this.panel2.Controls.Add(this.txtnterprevno);
            this.panel2.Controls.Add(this.lblprateautofilling);
            this.panel2.Controls.Add(this.PnlBottom);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txttqty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 81);
            this.panel2.TabIndex = 14;
            // 
            // Linkimportfromtool
            // 
            this.Linkimportfromtool.AutoSize = true;
            this.Linkimportfromtool.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Linkimportfromtool.LinkColor = System.Drawing.Color.Black;
            this.Linkimportfromtool.Location = new System.Drawing.Point(459, 11);
            this.Linkimportfromtool.Name = "Linkimportfromtool";
            this.Linkimportfromtool.Size = new System.Drawing.Size(95, 13);
            this.Linkimportfromtool.TabIndex = 4;
            this.Linkimportfromtool.TabStop = true;
            this.Linkimportfromtool.Text = "Import from Tool";
            this.Linkimportfromtool.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linkimportfromtool_LinkClicked);
            // 
            // lblprateautofilling
            // 
            this.lblprateautofilling.AutoSize = true;
            this.lblprateautofilling.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblprateautofilling.LinkColor = System.Drawing.Color.Black;
            this.lblprateautofilling.Location = new System.Drawing.Point(820, 8);
            this.lblprateautofilling.Name = "lblprateautofilling";
            this.lblprateautofilling.Size = new System.Drawing.Size(102, 13);
            this.lblprateautofilling.TabIndex = 6;
            this.lblprateautofilling.TabStop = true;
            this.lblprateautofilling.Text = "P.Rate Auto Filling";
            this.lblprateautofilling.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblprateautofilling_LinkClicked);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.PnlBottom.Controls.Add(this.TxtProduct);
            this.PnlBottom.Controls.Add(this.txtbillamount);
            this.PnlBottom.Controls.Add(this.cmdclose);
            this.PnlBottom.Controls.Add(this.cmdclear);
            this.PnlBottom.Controls.Add(this.cmdcancel);
            this.PnlBottom.Controls.Add(this.cmdprint);
            this.PnlBottom.Controls.Add(this.cmdsave);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 40);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(925, 41);
            this.PnlBottom.TabIndex = 85;
            // 
            // TxtProduct
            // 
            this.TxtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtProduct.Location = new System.Drawing.Point(434, 1);
            this.TxtProduct.Multiline = true;
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.Size = new System.Drawing.Size(100, 21);
            this.TxtProduct.TabIndex = 0;
            this.TxtProduct.Visible = false;
            this.TxtProduct.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtProduct_PreviewKeyDown);
            // 
            // txtbillamount
            // 
            this.txtbillamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtbillamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbillamount.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtbillamount.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbillamount.Location = new System.Drawing.Point(608, 0);
            this.txtbillamount.Multiline = true;
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(317, 41);
            this.txtbillamount.TabIndex = 34;
            this.txtbillamount.Tag = "1";
            this.txtbillamount.Text = "0.00";
            this.txtbillamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(315, 3);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 6;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.Transparent;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(237, 3);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 36);
            this.cmdclear.TabIndex = 5;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdcancel
            // 
            this.cmdcancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdcancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdcancel.ForeColor = System.Drawing.Color.Black;
            this.cmdcancel.Location = new System.Drawing.Point(159, 3);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 36);
            this.cmdcancel.TabIndex = 4;
            this.cmdcancel.Text = "Delete";
            this.cmdcancel.UseVisualStyleBackColor = false;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.Transparent;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(81, 3);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(75, 36);
            this.cmdprint.TabIndex = 1;
            this.cmdprint.Text = "&Print";
            this.cmdprint.UseVisualStyleBackColor = false;
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.Transparent;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(3, 3);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 36);
            this.cmdsave.TabIndex = 0;
            this.cmdsave.Text = "&Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            this.cmdsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdsave_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(333, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Import From Excel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "T.Qty";
            // 
            // txttqty
            // 
            this.txttqty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttqty.ForeColor = System.Drawing.Color.Black;
            this.txttqty.Location = new System.Drawing.Point(72, 8);
            this.txttqty.Name = "txttqty";
            this.txttqty.Size = new System.Drawing.Size(73, 25);
            this.txttqty.TabIndex = 0;
            this.txttqty.Tag = "2";
            // 
            // GridBatch
            // 
            this.GridBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBatch.ColumnHeadersVisible = false;
            this.GridBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.GridBatch.EnableHeadersVisualStyles = false;
            this.GridBatch.Location = new System.Drawing.Point(422, 261);
            this.GridBatch.Name = "GridBatch";
            this.GridBatch.ReadOnly = true;
            this.GridBatch.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridBatch.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.GridBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBatch.Size = new System.Drawing.Size(130, 208);
            this.GridBatch.TabIndex = 21;
            this.GridBatch.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.CHKbatchwise);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtdate);
            this.panel3.Controls.Add(this.lbldepot);
            this.panel3.Controls.Add(this.ComDepot);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtRemark);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Cmdforward);
            this.panel3.Controls.Add(this.CmdBack);
            this.panel3.Controls.Add(this.TxtVno);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 32);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(735, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(791, 4);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 25);
            this.dtdate.TabIndex = 3;
            this.dtdate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtdate_PreviewKeyDown);
            // 
            // lbldepot
            // 
            this.lbldepot.AutoSize = true;
            this.lbldepot.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbldepot.ForeColor = System.Drawing.Color.White;
            this.lbldepot.Location = new System.Drawing.Point(173, 7);
            this.lbldepot.Name = "lbldepot";
            this.lbldepot.Size = new System.Drawing.Size(61, 13);
            this.lbldepot.TabIndex = 73;
            this.lbldepot.Text = "Stock Area";
            // 
            // ComDepot
            // 
            this.ComDepot.BackColor = System.Drawing.SystemColors.Window;
            this.ComDepot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComDepot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComDepot.ForeColor = System.Drawing.Color.Black;
            this.ComDepot.FormattingEnabled = true;
            this.ComDepot.Location = new System.Drawing.Point(256, 4);
            this.ComDepot.Name = "ComDepot";
            this.ComDepot.Size = new System.Drawing.Size(121, 25);
            this.ComDepot.TabIndex = 2;
            this.ComDepot.SelectedIndexChanged += new System.EventHandler(this.ComDepot_SelectedIndexChanged);
            this.ComDepot.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ComDepot_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(409, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Remark";
            // 
            // TxtRemark
            // 
            this.TxtRemark.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtRemark.Location = new System.Drawing.Point(480, 4);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(122, 25);
            this.TxtRemark.TabIndex = 2;
            this.TxtRemark.TextChanged += new System.EventHandler(this.TxtRemark_TextChanged);
            this.TxtRemark.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtRemark_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vno";
            // 
            // Cmdforward
            // 
            this.Cmdforward.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmdforward.Location = new System.Drawing.Point(106, 3);
            this.Cmdforward.Name = "Cmdforward";
            this.Cmdforward.Size = new System.Drawing.Size(23, 27);
            this.Cmdforward.TabIndex = 6;
            this.Cmdforward.Text = ">";
            this.Cmdforward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cmdforward.UseVisualStyleBackColor = true;
            this.Cmdforward.Click += new System.EventHandler(this.Cmdforward_Click);
            // 
            // CmdBack
            // 
            this.CmdBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmdBack.Location = new System.Drawing.Point(36, 3);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(23, 27);
            this.CmdBack.TabIndex = 0;
            this.CmdBack.Text = "<";
            this.CmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdBack.UseVisualStyleBackColor = true;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // TxtVno
            // 
            this.TxtVno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtVno.Location = new System.Drawing.Point(62, 4);
            this.TxtVno.Name = "TxtVno";
            this.TxtVno.ReadOnly = true;
            this.TxtVno.Size = new System.Drawing.Size(42, 25);
            this.TxtVno.TabIndex = 0;
            this.TxtVno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtVno_PreviewKeyDown);
            // 
            // CHKbatchwise
            // 
            this.CHKbatchwise.AutoSize = true;
            this.CHKbatchwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKbatchwise.ForeColor = System.Drawing.Color.Gold;
            this.CHKbatchwise.Location = new System.Drawing.Point(614, 8);
            this.CHKbatchwise.Name = "CHKbatchwise";
            this.CHKbatchwise.Size = new System.Drawing.Size(101, 17);
            this.CHKbatchwise.TabIndex = 90;
            this.CHKbatchwise.Text = "BarcodeWise";
            this.CHKbatchwise.UseVisualStyleBackColor = true;
            this.CHKbatchwise.CheckedChanged += new System.EventHandler(this.CHKbatchwise_CheckedChanged);
            // 
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow2.Location = new System.Drawing.Point(123, 85);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow2.TabIndex = 22;
            this.uscGridshow2.Visible = false;
            // 
            // FrmopeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(925, 547);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmopeningStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening Stock";
            this.Load += new System.EventHandler(this.FrmopeningStock_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmopeningStock_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmopeningStock_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmopeningStock_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridbatchlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBatch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttqty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cmdforward;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.TextBox TxtVno;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.Label lbldepot;
        private System.Windows.Forms.ComboBox ComDepot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.TextBox txtbillamount;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdcancel;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.DataGridView GridBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView gridmain;
        private WindowsFormsApplication2.UscGridshow uscGridshow2;
        private System.Windows.Forms.LinkLabel lblprateautofilling;
        private System.Windows.Forms.Label lblenetervno;
        private System.Windows.Forms.TextBox txtnterprevno;
        private System.Windows.Forms.LinkLabel Linkimportfromtool;
        private System.Windows.Forms.DataGridView Gridbatchlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
        private System.Windows.Forms.CheckBox CHKbatchwise;


    }
}