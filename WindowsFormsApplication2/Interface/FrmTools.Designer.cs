namespace WindowsFormsApplication2
{
    partial class FrmTools
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTools));
            this.grpreindexing = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdreindex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstartingindex = new System.Windows.Forms.TextBox();
            this.CmdClose = new System.Windows.Forms.Button();
            this.GrpTaxsettings = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtupdateptax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtupdatecst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtupdatevat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtexstingptax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexstingcst = new System.Windows.Forms.TextBox();
            this.Cmdupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtexstingvat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.cmdupdatenew = new System.Windows.Forms.Button();
            this.txtupdatebarcode = new System.Windows.Forms.TextBox();
            this.cmdremovenottax = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChkdeleteMultibarcode = new System.Windows.Forms.CheckBox();
            this.Txtupdatesalerateperc = new System.Windows.Forms.TextBox();
            this.Cmdupdatesrateperc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comcategory = new System.Windows.Forms.ComboBox();
            this.Chkallcategory = new System.Windows.Forms.CheckBox();
            this.CMDdeletetable = new System.Windows.Forms.Button();
            this.CMDdoubleentry = new System.Windows.Forms.Button();
            this.grpreindexing.SuspendLayout();
            this.GrpTaxsettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // grpreindexing
            // 
            this.grpreindexing.Controls.Add(this.label2);
            this.grpreindexing.Controls.Add(this.comboBox1);
            this.grpreindexing.Controls.Add(this.cmdreindex);
            this.grpreindexing.Controls.Add(this.label1);
            this.grpreindexing.Controls.Add(this.txtstartingindex);
            this.grpreindexing.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpreindexing.Location = new System.Drawing.Point(14, 37);
            this.grpreindexing.Name = "grpreindexing";
            this.grpreindexing.Size = new System.Drawing.Size(247, 152);
            this.grpreindexing.TabIndex = 0;
            this.grpreindexing.TabStop = false;
            this.grpreindexing.Text = "Reindexing";
            this.grpreindexing.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Starting";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 25);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Visible = false;
            // 
            // cmdreindex
            // 
            this.cmdreindex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdreindex.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdreindex.FlatAppearance.BorderSize = 0;
            this.cmdreindex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdreindex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdreindex.ForeColor = System.Drawing.Color.Black;
            this.cmdreindex.Location = new System.Drawing.Point(83, 97);
            this.cmdreindex.Name = "cmdreindex";
            this.cmdreindex.Size = new System.Drawing.Size(142, 30);
            this.cmdreindex.TabIndex = 30;
            this.cmdreindex.Text = "Reindexing";
            this.cmdreindex.UseVisualStyleBackColor = false;
            this.cmdreindex.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting";
            // 
            // txtstartingindex
            // 
            this.txtstartingindex.Location = new System.Drawing.Point(83, 49);
            this.txtstartingindex.Name = "txtstartingindex";
            this.txtstartingindex.Size = new System.Drawing.Size(142, 25);
            this.txtstartingindex.TabIndex = 0;
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Location = new System.Drawing.Point(619, 289);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(69, 34);
            this.CmdClose.TabIndex = 146;
            this.CmdClose.Text = "C&lose";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // GrpTaxsettings
            // 
            this.GrpTaxsettings.Controls.Add(this.button1);
            this.GrpTaxsettings.Controls.Add(this.label7);
            this.GrpTaxsettings.Controls.Add(this.txtupdateptax);
            this.GrpTaxsettings.Controls.Add(this.label8);
            this.GrpTaxsettings.Controls.Add(this.txtupdatecst);
            this.GrpTaxsettings.Controls.Add(this.label9);
            this.GrpTaxsettings.Controls.Add(this.txtupdatevat);
            this.GrpTaxsettings.Controls.Add(this.label6);
            this.GrpTaxsettings.Controls.Add(this.txtexstingptax);
            this.GrpTaxsettings.Controls.Add(this.label4);
            this.GrpTaxsettings.Controls.Add(this.txtexstingcst);
            this.GrpTaxsettings.Controls.Add(this.Cmdupdate);
            this.GrpTaxsettings.Controls.Add(this.label5);
            this.GrpTaxsettings.Controls.Add(this.txtexstingvat);
            this.GrpTaxsettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GrpTaxsettings.Location = new System.Drawing.Point(304, 41);
            this.GrpTaxsettings.Name = "GrpTaxsettings";
            this.GrpTaxsettings.Size = new System.Drawing.Size(384, 235);
            this.GrpTaxsettings.TabIndex = 147;
            this.GrpTaxsettings.TabStop = false;
            this.GrpTaxsettings.Text = "TaxSettings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 30);
            this.button1.TabIndex = 41;
            this.button1.Text = "Change Repeated Itemcode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Update P.TAX";
            // 
            // txtupdateptax
            // 
            this.txtupdateptax.Location = new System.Drawing.Point(204, 149);
            this.txtupdateptax.Name = "txtupdateptax";
            this.txtupdateptax.Size = new System.Drawing.Size(142, 25);
            this.txtupdateptax.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Update CST";
            // 
            // txtupdatecst
            // 
            this.txtupdatecst.Location = new System.Drawing.Point(204, 101);
            this.txtupdatecst.Name = "txtupdatecst";
            this.txtupdatecst.Size = new System.Drawing.Size(142, 25);
            this.txtupdatecst.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "Update VAT";
            // 
            // txtupdatevat
            // 
            this.txtupdatevat.Location = new System.Drawing.Point(204, 49);
            this.txtupdatevat.Name = "txtupdatevat";
            this.txtupdatevat.Size = new System.Drawing.Size(142, 25);
            this.txtupdatevat.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Esting P.TAX";
            // 
            // txtexstingptax
            // 
            this.txtexstingptax.Location = new System.Drawing.Point(6, 149);
            this.txtexstingptax.Name = "txtexstingptax";
            this.txtexstingptax.Size = new System.Drawing.Size(142, 25);
            this.txtexstingptax.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Esting CST";
            // 
            // txtexstingcst
            // 
            this.txtexstingcst.Location = new System.Drawing.Point(6, 101);
            this.txtexstingcst.Name = "txtexstingcst";
            this.txtexstingcst.Size = new System.Drawing.Size(142, 25);
            this.txtexstingcst.TabIndex = 31;
            // 
            // Cmdupdate
            // 
            this.Cmdupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Cmdupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cmdupdate.FlatAppearance.BorderSize = 0;
            this.Cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdupdate.ForeColor = System.Drawing.Color.Black;
            this.Cmdupdate.Location = new System.Drawing.Point(204, 189);
            this.Cmdupdate.Name = "Cmdupdate";
            this.Cmdupdate.Size = new System.Drawing.Size(142, 30);
            this.Cmdupdate.TabIndex = 30;
            this.Cmdupdate.Text = "Update";
            this.Cmdupdate.UseVisualStyleBackColor = false;
            this.Cmdupdate.Click += new System.EventHandler(this.Cmdupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Esting VAT";
            // 
            // txtexstingvat
            // 
            this.txtexstingvat.Location = new System.Drawing.Point(6, 49);
            this.txtexstingvat.Name = "txtexstingvat";
            this.txtexstingvat.Size = new System.Drawing.Size(142, 25);
            this.txtexstingvat.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridmain);
            this.panel1.Controls.Add(this.cmdupdatenew);
            this.panel1.Controls.Add(this.txtupdatebarcode);
            this.panel1.Location = new System.Drawing.Point(14, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 140);
            this.panel1.TabIndex = 148;
            // 
            // gridmain
            // 
            this.gridmain.AllowUserToResizeColumns = false;
            this.gridmain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 0);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 50;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(674, 140);
            this.gridmain.TabIndex = 13;
            // 
            // cmdupdatenew
            // 
            this.cmdupdatenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdupdatenew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdupdatenew.FlatAppearance.BorderSize = 0;
            this.cmdupdatenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdatenew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdatenew.ForeColor = System.Drawing.Color.Black;
            this.cmdupdatenew.Location = new System.Drawing.Point(95, 38);
            this.cmdupdatenew.Name = "cmdupdatenew";
            this.cmdupdatenew.Size = new System.Drawing.Size(142, 30);
            this.cmdupdatenew.TabIndex = 151;
            this.cmdupdatenew.Text = "Update.Maxbcode";
            this.cmdupdatenew.UseVisualStyleBackColor = false;
            this.cmdupdatenew.Visible = false;
            this.cmdupdatenew.Click += new System.EventHandler(this.cmdupdatenew_Click);
            // 
            // txtupdatebarcode
            // 
            this.txtupdatebarcode.Location = new System.Drawing.Point(2, 45);
            this.txtupdatebarcode.Name = "txtupdatebarcode";
            this.txtupdatebarcode.Size = new System.Drawing.Size(87, 20);
            this.txtupdatebarcode.TabIndex = 150;
            this.txtupdatebarcode.Visible = false;
            // 
            // cmdremovenottax
            // 
            this.cmdremovenottax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdremovenottax.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdremovenottax.FlatAppearance.BorderSize = 0;
            this.cmdremovenottax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdremovenottax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdremovenottax.ForeColor = System.Drawing.Color.Black;
            this.cmdremovenottax.Location = new System.Drawing.Point(424, 289);
            this.cmdremovenottax.Name = "cmdremovenottax";
            this.cmdremovenottax.Size = new System.Drawing.Size(180, 30);
            this.cmdremovenottax.TabIndex = 42;
            this.cmdremovenottax.Text = "Remove invoice";
            this.cmdremovenottax.UseVisualStyleBackColor = false;
            this.cmdremovenottax.Visible = false;
            this.cmdremovenottax.Click += new System.EventHandler(this.cmdremovenottax_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(14, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 30);
            this.button2.TabIndex = 149;
            this.button2.Text = "Check multi barcode";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChkdeleteMultibarcode
            // 
            this.ChkdeleteMultibarcode.AutoSize = true;
            this.ChkdeleteMultibarcode.Location = new System.Drawing.Point(162, 298);
            this.ChkdeleteMultibarcode.Name = "ChkdeleteMultibarcode";
            this.ChkdeleteMultibarcode.Size = new System.Drawing.Size(125, 17);
            this.ChkdeleteMultibarcode.TabIndex = 152;
            this.ChkdeleteMultibarcode.Text = "Delete Multi Barcode";
            this.ChkdeleteMultibarcode.UseVisualStyleBackColor = true;
            // 
            // Txtupdatesalerateperc
            // 
            this.Txtupdatesalerateperc.Location = new System.Drawing.Point(4, 260);
            this.Txtupdatesalerateperc.Name = "Txtupdatesalerateperc";
            this.Txtupdatesalerateperc.Size = new System.Drawing.Size(142, 20);
            this.Txtupdatesalerateperc.TabIndex = 153;
            // 
            // Cmdupdatesrateperc
            // 
            this.Cmdupdatesrateperc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Cmdupdatesrateperc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cmdupdatesrateperc.FlatAppearance.BorderSize = 0;
            this.Cmdupdatesrateperc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdupdatesrateperc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdupdatesrateperc.ForeColor = System.Drawing.Color.Black;
            this.Cmdupdatesrateperc.Location = new System.Drawing.Point(152, 257);
            this.Cmdupdatesrateperc.Name = "Cmdupdatesrateperc";
            this.Cmdupdatesrateperc.Size = new System.Drawing.Size(99, 30);
            this.Cmdupdatesrateperc.TabIndex = 154;
            this.Cmdupdatesrateperc.Text = "Sett Profit";
            this.Cmdupdatesrateperc.UseVisualStyleBackColor = false;
            this.Cmdupdatesrateperc.Click += new System.EventHandler(this.Cmdupdatesrateperc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 196;
            this.label3.Text = "Category";
            // 
            // comcategory
            // 
            this.comcategory.FormattingEnabled = true;
            this.comcategory.Items.AddRange(new object[] {
            "All",
            "cash",
            "Credit"});
            this.comcategory.Location = new System.Drawing.Point(79, 230);
            this.comcategory.Name = "comcategory";
            this.comcategory.Size = new System.Drawing.Size(172, 21);
            this.comcategory.TabIndex = 195;
            // 
            // Chkallcategory
            // 
            this.Chkallcategory.AutoSize = true;
            this.Chkallcategory.Location = new System.Drawing.Point(79, 201);
            this.Chkallcategory.Name = "Chkallcategory";
            this.Chkallcategory.Size = new System.Drawing.Size(82, 17);
            this.Chkallcategory.TabIndex = 33;
            this.Chkallcategory.Text = "All Category";
            this.Chkallcategory.UseVisualStyleBackColor = true;
            this.Chkallcategory.CheckedChanged += new System.EventHandler(this.Chkallcategory_CheckedChanged);
            // 
            // CMDdeletetable
            // 
            this.CMDdeletetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMDdeletetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDdeletetable.ForeColor = System.Drawing.Color.Fuchsia;
            this.CMDdeletetable.Location = new System.Drawing.Point(16, 325);
            this.CMDdeletetable.Name = "CMDdeletetable";
            this.CMDdeletetable.Size = new System.Drawing.Size(130, 23);
            this.CMDdeletetable.TabIndex = 197;
            this.CMDdeletetable.Text = "alter transfer table";
            this.CMDdeletetable.UseVisualStyleBackColor = true;
            this.CMDdeletetable.Click += new System.EventHandler(this.CMDdeletetable_Click);
            // 
            // CMDdoubleentry
            // 
            this.CMDdoubleentry.Location = new System.Drawing.Point(164, 325);
            this.CMDdoubleentry.Name = "CMDdoubleentry";
            this.CMDdoubleentry.Size = new System.Drawing.Size(137, 23);
            this.CMDdoubleentry.TabIndex = 198;
            this.CMDdoubleentry.Text = "Double entry alter sale";
            this.CMDdoubleentry.UseVisualStyleBackColor = true;
            this.CMDdoubleentry.Click += new System.EventHandler(this.CMDdoubleentry_Click);
            // 
            // FrmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(695, 507);
            this.Controls.Add(this.CMDdoubleentry);
            this.Controls.Add(this.CMDdeletetable);
            this.Controls.Add(this.Chkallcategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comcategory);
            this.Controls.Add(this.Cmdupdatesrateperc);
            this.Controls.Add(this.Txtupdatesalerateperc);
            this.Controls.Add(this.ChkdeleteMultibarcode);
            this.Controls.Add(this.cmdremovenottax);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpTaxsettings);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.grpreindexing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Tools";
            this.Load += new System.EventHandler(this.FrmTools_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTools_KeyDown);
            this.grpreindexing.ResumeLayout(false);
            this.grpreindexing.PerformLayout();
            this.GrpTaxsettings.ResumeLayout(false);
            this.GrpTaxsettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpreindexing;
        private System.Windows.Forms.TextBox txtstartingindex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdreindex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.GroupBox GrpTaxsettings;
        private System.Windows.Forms.Button Cmdupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtexstingvat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtexstingptax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtexstingcst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtupdateptax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtupdatecst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtupdatevat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.TextBox txtupdatebarcode;
        private System.Windows.Forms.Button cmdupdatenew;
        private System.Windows.Forms.Button cmdremovenottax;
        private System.Windows.Forms.CheckBox ChkdeleteMultibarcode;
        private System.Windows.Forms.TextBox Txtupdatesalerateperc;
        private System.Windows.Forms.Button Cmdupdatesrateperc;
        private System.Windows.Forms.CheckBox Chkallcategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comcategory;
        private System.Windows.Forms.Button CMDdeletetable;
        private System.Windows.Forms.Button CMDdoubleentry;

    }
}