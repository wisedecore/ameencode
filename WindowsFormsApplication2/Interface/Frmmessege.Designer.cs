namespace WindowsFormsApplication2
{
    partial class Frmmessege
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richsubject = new System.Windows.Forms.RichTextBox();
            this.cmdsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnledname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radbulksms = new System.Windows.Forms.RadioButton();
            this.radsinglesms = new System.Windows.Forms.RadioButton();
            this.txtsinglesmsmobile = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grpsubjuctoption = new System.Windows.Forms.GroupBox();
            this.radsubject = new System.Windows.Forms.RadioButton();
            this.radaccountbalance = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prg = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblsmspending = new System.Windows.Forms.Label();
            this.Gridarea = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chksearcharea = new System.Windows.Forms.CheckBox();
            this.GridAccountgroup = new System.Windows.Forms.DataGridView();
            this.clnselgroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdfillarea = new System.Windows.Forms.Button();
            this.Grpfillingoption = new System.Windows.Forms.GroupBox();
            this.radfillledgers = new System.Windows.Forms.RadioButton();
            this.radfillcontacts = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.Grpsubjuctoption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccountgroup)).BeginInit();
            this.Grpfillingoption.SuspendLayout();
            this.SuspendLayout();
            // 
            // richsubject
            // 
            this.richsubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.richsubject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.richsubject.Location = new System.Drawing.Point(91, 310);
            this.richsubject.Name = "richsubject";
            this.richsubject.Size = new System.Drawing.Size(511, 83);
            this.richsubject.TabIndex = 2;
            this.richsubject.Text = "";
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.Transparent;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(185, 461);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 36);
            this.cmdsave.TabIndex = 30;
            this.cmdsave.Text = "&Send";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(266, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Select Ledger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Subject";
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
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
            this.gridmain.ColumnHeadersHeight = 31;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselect,
            this.clnledname,
            this.clnmobile,
            this.clnbalance});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(91, 34);
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
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(511, 240);
            this.gridmain.TabIndex = 62;
            // 
            // clnselect
            // 
            this.clnselect.FillWeight = 38.07107F;
            this.clnselect.HeaderText = "Select";
            this.clnselect.Name = "clnselect";
            // 
            // clnledname
            // 
            this.clnledname.FillWeight = 127.5681F;
            this.clnledname.HeaderText = "Name";
            this.clnledname.Name = "clnledname";
            // 
            // clnmobile
            // 
            this.clnmobile.FillWeight = 134.3608F;
            this.clnmobile.HeaderText = "Mobile";
            this.clnmobile.Name = "clnmobile";
            // 
            // clnbalance
            // 
            this.clnbalance.HeaderText = "balance";
            this.clnbalance.Name = "clnbalance";
            // 
            // radbulksms
            // 
            this.radbulksms.AutoSize = true;
            this.radbulksms.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radbulksms.Location = new System.Drawing.Point(6, 30);
            this.radbulksms.Name = "radbulksms";
            this.radbulksms.Size = new System.Drawing.Size(79, 21);
            this.radbulksms.TabIndex = 63;
            this.radbulksms.Text = "Bulk SMS";
            this.radbulksms.UseVisualStyleBackColor = true;
            this.radbulksms.CheckedChanged += new System.EventHandler(this.radbulksms_CheckedChanged);
            // 
            // radsinglesms
            // 
            this.radsinglesms.AutoSize = true;
            this.radsinglesms.Checked = true;
            this.radsinglesms.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radsinglesms.Location = new System.Drawing.Point(4, 280);
            this.radsinglesms.Name = "radsinglesms";
            this.radsinglesms.Size = new System.Drawing.Size(91, 21);
            this.radsinglesms.TabIndex = 64;
            this.radsinglesms.TabStop = true;
            this.radsinglesms.Text = "Single SMS";
            this.radsinglesms.UseVisualStyleBackColor = true;
            this.radsinglesms.CheckedChanged += new System.EventHandler(this.radsinglesms_CheckedChanged);
            // 
            // txtsinglesmsmobile
            // 
            this.txtsinglesmsmobile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtsinglesmsmobile.Location = new System.Drawing.Point(91, 281);
            this.txtsinglesmsmobile.Name = "txtsinglesmsmobile";
            this.txtsinglesmsmobile.Size = new System.Drawing.Size(511, 25);
            this.txtsinglesmsmobile.TabIndex = 65;
            // 
            // txtsearch
            // 
            this.txtsearch.Enabled = false;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtsearch.Location = new System.Drawing.Point(89, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(253, 25);
            this.txtsearch.TabIndex = 66;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Search";
            // 
            // Grpsubjuctoption
            // 
            this.Grpsubjuctoption.Controls.Add(this.radsubject);
            this.Grpsubjuctoption.Controls.Add(this.radaccountbalance);
            this.Grpsubjuctoption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Grpsubjuctoption.Location = new System.Drawing.Point(775, 327);
            this.Grpsubjuctoption.Name = "Grpsubjuctoption";
            this.Grpsubjuctoption.Size = new System.Drawing.Size(139, 73);
            this.Grpsubjuctoption.TabIndex = 68;
            this.Grpsubjuctoption.TabStop = false;
            this.Grpsubjuctoption.Text = "Subject Option";
            // 
            // radsubject
            // 
            this.radsubject.AutoSize = true;
            this.radsubject.Checked = true;
            this.radsubject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radsubject.Location = new System.Drawing.Point(14, 18);
            this.radsubject.Name = "radsubject";
            this.radsubject.Size = new System.Drawing.Size(68, 21);
            this.radsubject.TabIndex = 66;
            this.radsubject.TabStop = true;
            this.radsubject.Text = "Subject";
            this.radsubject.UseVisualStyleBackColor = true;
            this.radsubject.CheckedChanged += new System.EventHandler(this.radsubject_CheckedChanged);
            // 
            // radaccountbalance
            // 
            this.radaccountbalance.AutoSize = true;
            this.radaccountbalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radaccountbalance.Location = new System.Drawing.Point(14, 45);
            this.radaccountbalance.Name = "radaccountbalance";
            this.radaccountbalance.Size = new System.Drawing.Size(116, 21);
            this.radaccountbalance.TabIndex = 65;
            this.radaccountbalance.Text = "AccountBalance";
            this.radaccountbalance.UseVisualStyleBackColor = true;
            this.radaccountbalance.CheckedChanged += new System.EventHandler(this.radaccountbalance_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(7, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Max Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "(450)";
            // 
            // prg
            // 
            this.prg.Location = new System.Drawing.Point(347, 454);
            this.prg.Name = "prg";
            this.prg.Size = new System.Drawing.Size(398, 23);
            this.prg.TabIndex = 72;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(777, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(139, 309);
            this.webBrowser1.TabIndex = 67;
            // 
            // lblsmspending
            // 
            this.lblsmspending.AutoSize = true;
            this.lblsmspending.BackColor = System.Drawing.Color.Transparent;
            this.lblsmspending.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmspending.ForeColor = System.Drawing.Color.Red;
            this.lblsmspending.Location = new System.Drawing.Point(9, 460);
            this.lblsmspending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsmspending.Name = "lblsmspending";
            this.lblsmspending.Size = new System.Drawing.Size(99, 20);
            this.lblsmspending.TabIndex = 73;
            this.lblsmspending.Text = "SMS Pending:";
            // 
            // Gridarea
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Gridarea.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridarea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Gridarea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Gridarea.ColumnHeadersHeight = 31;
            this.Gridarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridarea.DefaultCellStyle = dataGridViewCellStyle7;
            this.Gridarea.Enabled = false;
            this.Gridarea.EnableHeadersVisualStyles = false;
            this.Gridarea.Location = new System.Drawing.Point(610, 35);
            this.Gridarea.MultiSelect = false;
            this.Gridarea.Name = "Gridarea";
            this.Gridarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Gridarea.RowHeadersVisible = false;
            this.Gridarea.RowHeadersWidth = 100;
            this.Gridarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Gridarea.Size = new System.Drawing.Size(161, 199);
            this.Gridarea.TabIndex = 76;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.FillWeight = 38.07107F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Se";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 127.5681F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Area";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // chksearcharea
            // 
            this.chksearcharea.AutoSize = true;
            this.chksearcharea.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chksearcharea.Location = new System.Drawing.Point(608, 12);
            this.chksearcharea.Name = "chksearcharea";
            this.chksearcharea.Size = new System.Drawing.Size(97, 21);
            this.chksearcharea.TabIndex = 77;
            this.chksearcharea.Text = "Search Area";
            this.chksearcharea.UseVisualStyleBackColor = true;
            this.chksearcharea.CheckedChanged += new System.EventHandler(this.chksearcharea_CheckedChanged);
            // 
            // GridAccountgroup
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.GridAccountgroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.GridAccountgroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAccountgroup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridAccountgroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridAccountgroup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridAccountgroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAccountgroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridAccountgroup.ColumnHeadersHeight = 31;
            this.GridAccountgroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnselgroup,
            this.clnGroup});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridAccountgroup.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridAccountgroup.EnableHeadersVisualStyles = false;
            this.GridAccountgroup.Location = new System.Drawing.Point(610, 256);
            this.GridAccountgroup.MultiSelect = false;
            this.GridAccountgroup.Name = "GridAccountgroup";
            this.GridAccountgroup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAccountgroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridAccountgroup.RowHeadersVisible = false;
            this.GridAccountgroup.RowHeadersWidth = 100;
            this.GridAccountgroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridAccountgroup.Size = new System.Drawing.Size(161, 192);
            this.GridAccountgroup.TabIndex = 78;
            // 
            // clnselgroup
            // 
            this.clnselgroup.FalseValue = "0";
            this.clnselgroup.FillWeight = 38.07107F;
            this.clnselgroup.HeaderText = "Se";
            this.clnselgroup.Name = "clnselgroup";
            this.clnselgroup.TrueValue = "1";
            // 
            // clnGroup
            // 
            this.clnGroup.FillWeight = 127.5681F;
            this.clnGroup.HeaderText = "Group";
            this.clnGroup.Name = "clnGroup";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(348, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 79;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdfillarea
            // 
            this.cmdfillarea.BackColor = System.Drawing.Color.Transparent;
            this.cmdfillarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdfillarea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdfillarea.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdfillarea.ForeColor = System.Drawing.Color.Black;
            this.cmdfillarea.Location = new System.Drawing.Point(698, 6);
            this.cmdfillarea.Name = "cmdfillarea";
            this.cmdfillarea.Size = new System.Drawing.Size(75, 27);
            this.cmdfillarea.TabIndex = 81;
            this.cmdfillarea.Text = "Fill Area";
            this.cmdfillarea.UseVisualStyleBackColor = false;
            this.cmdfillarea.Click += new System.EventHandler(this.cmdfillarea_Click);
            // 
            // Grpfillingoption
            // 
            this.Grpfillingoption.Controls.Add(this.radfillledgers);
            this.Grpfillingoption.Controls.Add(this.radfillcontacts);
            this.Grpfillingoption.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Grpfillingoption.Location = new System.Drawing.Point(775, 402);
            this.Grpfillingoption.Name = "Grpfillingoption";
            this.Grpfillingoption.Size = new System.Drawing.Size(139, 76);
            this.Grpfillingoption.TabIndex = 82;
            this.Grpfillingoption.TabStop = false;
            this.Grpfillingoption.Text = "Filling Option";
            // 
            // radfillledgers
            // 
            this.radfillledgers.AutoSize = true;
            this.radfillledgers.Checked = true;
            this.radfillledgers.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radfillledgers.Location = new System.Drawing.Point(9, 24);
            this.radfillledgers.Name = "radfillledgers";
            this.radfillledgers.Size = new System.Drawing.Size(92, 21);
            this.radfillledgers.TabIndex = 66;
            this.radfillledgers.TabStop = true;
            this.radfillledgers.Text = "Fill Ledgers";
            this.radfillledgers.UseVisualStyleBackColor = true;
            this.radfillledgers.CheckedChanged += new System.EventHandler(this.radfillledgers_CheckedChanged);
            // 
            // radfillcontacts
            // 
            this.radfillcontacts.AutoSize = true;
            this.radfillcontacts.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radfillcontacts.Location = new System.Drawing.Point(9, 46);
            this.radfillcontacts.Name = "radfillcontacts";
            this.radfillcontacts.Size = new System.Drawing.Size(95, 21);
            this.radfillcontacts.TabIndex = 65;
            this.radfillcontacts.Text = "Fill Contacts";
            this.radfillcontacts.UseVisualStyleBackColor = true;
            this.radfillcontacts.CheckedChanged += new System.EventHandler(this.radfillcontacts_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(4, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 36);
            this.button3.TabIndex = 83;
            this.button3.Text = "Clossing of Day Cash";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(156, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 36);
            this.button4.TabIndex = 84;
            this.button4.Text = "Clossing of Day profit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Frmmessege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(920, 509);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Grpfillingoption);
            this.Controls.Add(this.cmdfillarea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridAccountgroup);
            this.Controls.Add(this.chksearcharea);
            this.Controls.Add(this.Gridarea);
            this.Controls.Add(this.lblsmspending);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.prg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grpsubjuctoption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtsinglesmsmobile);
            this.Controls.Add(this.radsinglesms);
            this.Controls.Add(this.radbulksms);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.richsubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmmessege";
            this.Text = "SMS Sending";
            this.Load += new System.EventHandler(this.Frmmessege_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.Grpsubjuctoption.ResumeLayout(false);
            this.Grpsubjuctoption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccountgroup)).EndInit();
            this.Grpfillingoption.ResumeLayout(false);
            this.Grpfillingoption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richsubject;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.RadioButton radbulksms;
        private System.Windows.Forms.RadioButton radsinglesms;
        private System.Windows.Forms.TextBox txtsinglesmsmobile;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Grpsubjuctoption;
        private System.Windows.Forms.RadioButton radsubject;
        private System.Windows.Forms.RadioButton radaccountbalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prg;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblsmspending;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnledname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbalance;
        public System.Windows.Forms.DataGridView Gridarea;
        private System.Windows.Forms.CheckBox chksearcharea;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridView GridAccountgroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnselgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdfillarea;
        private System.Windows.Forms.GroupBox Grpfillingoption;
        private System.Windows.Forms.RadioButton radfillledgers;
        private System.Windows.Forms.RadioButton radfillcontacts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}