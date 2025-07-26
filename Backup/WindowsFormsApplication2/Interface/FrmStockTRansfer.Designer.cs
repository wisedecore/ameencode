namespace WindowsFormsApplication2
{
    partial class FrmStockTRansfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.ComFromDepot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComToDepot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.TxtVno = new System.Windows.Forms.TextBox();
            this.CmdBack = new System.Windows.Forms.Button();
            this.Cmdforward = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttqty = new System.Windows.Forms.TextBox();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnettamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComMultiRate = new System.Windows.Forms.ComboBox();
            this.ComMultiUnit = new System.Windows.Forms.ComboBox();
            this.TxtProduct = new System.Windows.Forms.TextBox();
            this.Gridbatchlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbatchlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.panel4.Controls.Add(this.label21);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(972, 29);
            this.panel4.TabIndex = 60;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(364, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 21);
            this.label21.TabIndex = 68;
            this.label21.Text = "Stock Transfer";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // ComFromDepot
            // 
            this.ComFromDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComFromDepot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComFromDepot.FormattingEnabled = true;
            this.ComFromDepot.Location = new System.Drawing.Point(258, 3);
            this.ComFromDepot.Name = "ComFromDepot";
            this.ComFromDepot.Size = new System.Drawing.Size(149, 25);
            this.ComFromDepot.TabIndex = 0;
            this.ComFromDepot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComFromDepot_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "VNo";
            // 
            // ComToDepot
            // 
            this.ComToDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComToDepot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComToDepot.FormattingEnabled = true;
            this.ComToDepot.Location = new System.Drawing.Point(447, 3);
            this.ComToDepot.Name = "ComToDepot";
            this.ComToDepot.Size = new System.Drawing.Size(149, 25);
            this.ComToDepot.TabIndex = 1;
            this.ComToDepot.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ComToDepot_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(192, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Remark";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtRemark
            // 
            this.TxtRemark.Location = new System.Drawing.Point(280, 7);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(290, 20);
            this.TxtRemark.TabIndex = 3;
            this.TxtRemark.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtRemark_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(693, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel6.Controls.Add(this.dtdate);
            this.panel6.Controls.Add(this.TxtVno);
            this.panel6.Controls.Add(this.CmdBack);
            this.panel6.Controls.Add(this.Cmdforward);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.ComFromDepot);
            this.panel6.Controls.Add(this.ComToDepot);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(972, 38);
            this.panel6.TabIndex = 86;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // dtdate
            // 
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(737, 5);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 20);
            this.dtdate.TabIndex = 87;
            this.dtdate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtdate_PreviewKeyDown_1);
            // 
            // TxtVno
            // 
            this.TxtVno.Location = new System.Drawing.Point(65, 5);
            this.TxtVno.Name = "TxtVno";
            this.TxtVno.Size = new System.Drawing.Size(46, 20);
            this.TxtVno.TabIndex = 0;
            this.TxtVno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVno_KeyPress);
            // 
            // CmdBack
            // 
            this.CmdBack.Location = new System.Drawing.Point(42, 3);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(23, 24);
            this.CmdBack.TabIndex = 86;
            this.CmdBack.Text = "<";
            this.CmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdBack.UseVisualStyleBackColor = true;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // Cmdforward
            // 
            this.Cmdforward.Location = new System.Drawing.Point(111, 4);
            this.Cmdforward.Name = "Cmdforward";
            this.Cmdforward.Size = new System.Drawing.Size(23, 23);
            this.Cmdforward.TabIndex = 85;
            this.Cmdforward.Text = ">";
            this.Cmdforward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cmdforward.UseVisualStyleBackColor = true;
            this.Cmdforward.Click += new System.EventHandler(this.Cmdforward_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel5.Controls.Add(this.PnlBottom);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txttqty);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.TxtRemark);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 463);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(972, 76);
            this.panel5.TabIndex = 87;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.PnlBottom.Controls.Add(this.txtbillamount);
            this.PnlBottom.Controls.Add(this.cmdclose);
            this.PnlBottom.Controls.Add(this.cmdclear);
            this.PnlBottom.Controls.Add(this.cmdcancel);
            this.PnlBottom.Controls.Add(this.cmdprint);
            this.PnlBottom.Controls.Add(this.cmdsave);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 35);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(972, 41);
            this.PnlBottom.TabIndex = 83;
            // 
            // txtbillamount
            // 
            this.txtbillamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtbillamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbillamount.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtbillamount.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtbillamount.Location = new System.Drawing.Point(655, 0);
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
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(315, 3);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 33;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.Transparent;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(237, 3);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 36);
            this.cmdclear.TabIndex = 32;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdcancel
            // 
            this.cmdcancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdcancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcancel.ForeColor = System.Drawing.Color.Black;
            this.cmdcancel.Location = new System.Drawing.Point(159, 3);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 36);
            this.cmdcancel.TabIndex = 31;
            this.cmdcancel.Text = "Delete";
            this.cmdcancel.UseVisualStyleBackColor = false;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.Transparent;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(81, 3);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(75, 36);
            this.cmdprint.TabIndex = 30;
            this.cmdprint.Text = "&Print";
            this.cmdprint.UseVisualStyleBackColor = false;
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.Transparent;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(3, 3);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 36);
            this.cmdsave.TabIndex = 29;
            this.cmdsave.Text = "&Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "T.Qty";
            // 
            // txttqty
            // 
            this.txttqty.Location = new System.Drawing.Point(100, 7);
            this.txttqty.Name = "txttqty";
            this.txttqty.Size = new System.Drawing.Size(73, 20);
            this.txttqty.TabIndex = 8;
            this.txttqty.Tag = "2";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.clnnettamount,
            this.clnmrp});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 67);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.Size = new System.Drawing.Size(972, 396);
            this.gridmain.TabIndex = 4;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellValidated);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            this.gridmain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridmain_KeyPress);
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
            this.clnbatch.HeaderText = "Bcode";
            this.clnbatch.Name = "clnbatch";
            this.clnbatch.ReadOnly = true;
            this.clnbatch.Visible = false;
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
            this.clnrate.HeaderText = "Rate";
            this.clnrate.Name = "clnrate";
            // 
            // clnnettamount
            // 
            dataGridViewCellStyle5.NullValue = "0.00";
            this.clnnettamount.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.ComMultiRate.Location = new System.Drawing.Point(537, 175);
            this.ComMultiRate.Name = "ComMultiRate";
            this.ComMultiRate.Size = new System.Drawing.Size(121, 21);
            this.ComMultiRate.TabIndex = 92;
            this.ComMultiRate.Visible = false;
            this.ComMultiRate.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ComMultiRate_PreviewKeyDown);
            this.ComMultiRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComMultiRate_KeyPress);
            // 
            // ComMultiUnit
            // 
            this.ComMultiUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComMultiUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComMultiUnit.FormattingEnabled = true;
            this.ComMultiUnit.Location = new System.Drawing.Point(383, 158);
            this.ComMultiUnit.Name = "ComMultiUnit";
            this.ComMultiUnit.Size = new System.Drawing.Size(121, 21);
            this.ComMultiUnit.TabIndex = 91;
            this.ComMultiUnit.Visible = false;
            this.ComMultiUnit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ComMultiUnit_PreviewKeyDown);
            this.ComMultiUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComMultiUnit_KeyPress);
            // 
            // TxtProduct
            // 
            this.TxtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProduct.Location = new System.Drawing.Point(383, 225);
            this.TxtProduct.Multiline = true;
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.Size = new System.Drawing.Size(100, 21);
            this.TxtProduct.TabIndex = 94;
            this.TxtProduct.Visible = false;
            this.TxtProduct.TextChanged += new System.EventHandler(this.TxtProduct_TextChanged);
            this.TxtProduct.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtProduct_PreviewKeyDown_1);
            this.TxtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProduct_KeyPress);
            // 
            // Gridbatchlist
            // 
            this.Gridbatchlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridbatchlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Gridbatchlist.ColumnHeadersVisible = false;
            this.Gridbatchlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridbatchlist.DefaultCellStyle = dataGridViewCellStyle8;
            this.Gridbatchlist.Location = new System.Drawing.Point(521, 94);
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
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow2.Location = new System.Drawing.Point(42, 94);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(792, 363);
            this.uscGridshow2.TabIndex = 95;
            this.uscGridshow2.Visible = false;
            // 
            // FrmStockTRansfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(972, 539);
            this.Controls.Add(this.Gridbatchlist);
            this.Controls.Add(this.uscGridshow2);
            this.Controls.Add(this.TxtProduct);
            this.Controls.Add(this.ComMultiRate);
            this.Controls.Add(this.ComMultiUnit);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockTRansfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transfer";
            this.Load += new System.EventHandler(this.FrmStockTRansfer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmStockTRansfer_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStockTRansfer_KeyDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbatchlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox ComFromDepot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComToDepot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttqty;
        private System.Windows.Forms.Button Cmdforward;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.TextBox TxtVno;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.ComboBox ComMultiRate;
        private System.Windows.Forms.ComboBox ComMultiUnit;
        private System.Windows.Forms.TextBox TxtProduct;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.TextBox txtbillamount;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdcancel;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.DateTimePicker dtdate;
        private WindowsFormsApplication2.UscGridshow uscGridshow2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnettamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmrp;
    }
}