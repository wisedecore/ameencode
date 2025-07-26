namespace WindowsFormsApplication2
{
    partial class Frmdailyexpence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdForward = new System.Windows.Forms.Button();
            this.ComLedger = new System.Windows.Forms.ComboBox();
            this.lblledger = new System.Windows.Forms.Label();
            this.CmdBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotaldebit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalcredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.ComStaff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNarration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRefNo = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnledger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clncredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscLedgershow1 = new WindowsFormsApplication2.UserControles.UscLedgershow();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.CmdForward);
            this.panel1.Controls.Add(this.ComLedger);
            this.panel1.Controls.Add(this.lblledger);
            this.panel1.Controls.Add(this.CmdBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtdate);
            this.panel1.Controls.Add(this.txtvno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 63);
            this.panel1.TabIndex = 90;
            // 
            // CmdForward
            // 
            this.CmdForward.Location = new System.Drawing.Point(107, 19);
            this.CmdForward.Name = "CmdForward";
            this.CmdForward.Size = new System.Drawing.Size(23, 25);
            this.CmdForward.TabIndex = 114;
            this.CmdForward.TabStop = false;
            this.CmdForward.Text = ">";
            this.CmdForward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdForward.UseVisualStyleBackColor = true;
            this.CmdForward.Click += new System.EventHandler(this.CmdForward_Click);
            // 
            // ComLedger
            // 
            this.ComLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComLedger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComLedger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComLedger.FormattingEnabled = true;
            this.ComLedger.Location = new System.Drawing.Point(388, 21);
            this.ComLedger.Name = "ComLedger";
            this.ComLedger.Size = new System.Drawing.Size(291, 25);
            this.ComLedger.TabIndex = 0;
            // 
            // lblledger
            // 
            this.lblledger.AutoSize = true;
            this.lblledger.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblledger.ForeColor = System.Drawing.Color.White;
            this.lblledger.Location = new System.Drawing.Point(309, 27);
            this.lblledger.Name = "lblledger";
            this.lblledger.Size = new System.Drawing.Size(73, 13);
            this.lblledger.TabIndex = 117;
            this.lblledger.Text = "Debit Ledger";
            // 
            // CmdBack
            // 
            this.CmdBack.Location = new System.Drawing.Point(37, 19);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(23, 25);
            this.CmdBack.TabIndex = 113;
            this.CmdBack.TabStop = false;
            this.CmdBack.Text = "<";
            this.CmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdBack.UseVisualStyleBackColor = true;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(729, 25);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 20);
            this.dtdate.TabIndex = 1;
            // 
            // txtvno
            // 
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvno.Location = new System.Drawing.Point(63, 19);
            this.txtvno.Name = "txtvno";
            this.txtvno.ReadOnly = true;
            this.txtvno.Size = new System.Drawing.Size(42, 25);
            this.txtvno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Vno";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txttotaldebit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txttotalcredit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbillamount);
            this.panel2.Controls.Add(this.ComStaff);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TxtNarration);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtRefNo);
            this.panel2.Controls.Add(this.cmdclose);
            this.panel2.Controls.Add(this.cmdclear);
            this.panel2.Controls.Add(this.cmdcancel);
            this.panel2.Controls.Add(this.cmdprint);
            this.panel2.Controls.Add(this.cmdsave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 98);
            this.panel2.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(576, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 139;
            this.label8.Text = "Total Debit";
            // 
            // txttotaldebit
            // 
            this.txttotaldebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttotaldebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotaldebit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaldebit.ForeColor = System.Drawing.Color.Red;
            this.txttotaldebit.Location = new System.Drawing.Point(723, -5);
            this.txttotaldebit.Multiline = true;
            this.txttotaldebit.Name = "txttotaldebit";
            this.txttotaldebit.Size = new System.Drawing.Size(135, 35);
            this.txttotaldebit.TabIndex = 138;
            this.txttotaldebit.Text = "0.00";
            this.txttotaldebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(574, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 137;
            this.label3.Text = "Total Credit";
            // 
            // txttotalcredit
            // 
            this.txttotalcredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttotalcredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttotalcredit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcredit.ForeColor = System.Drawing.Color.Teal;
            this.txttotalcredit.Location = new System.Drawing.Point(724, 23);
            this.txttotalcredit.Multiline = true;
            this.txttotalcredit.Name = "txttotalcredit";
            this.txttotalcredit.Size = new System.Drawing.Size(135, 35);
            this.txttotalcredit.TabIndex = 136;
            this.txttotalcredit.Text = "0.00";
            this.txttotalcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(603, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 135;
            this.label7.Text = "Total";
            // 
            // txtbillamount
            // 
            this.txtbillamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtbillamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbillamount.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillamount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtbillamount.Location = new System.Drawing.Point(724, 58);
            this.txtbillamount.Multiline = true;
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(135, 35);
            this.txtbillamount.TabIndex = 134;
            this.txtbillamount.Text = "0.00";
            this.txtbillamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComStaff
            // 
            this.ComStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComStaff.FormattingEnabled = true;
            this.ComStaff.Location = new System.Drawing.Point(258, 4);
            this.ComStaff.Name = "ComStaff";
            this.ComStaff.Size = new System.Drawing.Size(140, 21);
            this.ComStaff.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Narration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(184, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Employee";
            // 
            // TxtNarration
            // 
            this.TxtNarration.Location = new System.Drawing.Point(76, 31);
            this.TxtNarration.Name = "TxtNarration";
            this.TxtNarration.Size = new System.Drawing.Size(322, 20);
            this.TxtNarration.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ref No";
            // 
            // TxtRefNo
            // 
            this.TxtRefNo.Location = new System.Drawing.Point(76, 4);
            this.TxtRefNo.Name = "TxtRefNo";
            this.TxtRefNo.Size = new System.Drawing.Size(92, 20);
            this.TxtRefNo.TabIndex = 0;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(322, 57);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 7;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(244, 57);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 36);
            this.cmdclear.TabIndex = 6;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdcancel
            // 
            this.cmdcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcancel.ForeColor = System.Drawing.Color.Black;
            this.cmdcancel.Location = new System.Drawing.Point(166, 57);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 36);
            this.cmdcancel.TabIndex = 5;
            this.cmdcancel.Text = "Delete";
            this.cmdcancel.UseVisualStyleBackColor = false;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(88, 57);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(75, 36);
            this.cmdprint.TabIndex = 4;
            this.cmdprint.Text = "&Print";
            this.cmdprint.UseVisualStyleBackColor = false;
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(10, 57);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 36);
            this.cmdsave.TabIndex = 3;
            this.cmdsave.Text = "&Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // gridmain
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridmain.ColumnHeadersHeight = 30;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnledger,
            this.clndebit,
            this.Clncredit,
            this.clnnote});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 63);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.Size = new System.Drawing.Size(862, 396);
            this.gridmain.TabIndex = 0;
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 16.45046F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            // 
            // clnledger
            // 
            this.clnledger.FillWeight = 192.292F;
            this.clnledger.HeaderText = "Ledger Name";
            this.clnledger.Name = "clnledger";
            // 
            // clndebit
            // 
            this.clndebit.FillWeight = 75F;
            this.clndebit.HeaderText = "Debit";
            this.clndebit.Name = "clndebit";
            // 
            // Clncredit
            // 
            this.Clncredit.FillWeight = 75F;
            this.Clncredit.HeaderText = "Credit";
            this.Clncredit.Name = "Clncredit";
            // 
            // clnnote
            // 
            this.clnnote.HeaderText = "Note";
            this.clnnote.Name = "clnnote";
            // 
            // uscLedgershow1
            // 
            this.uscLedgershow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscLedgershow1.Location = new System.Drawing.Point(187, 157);
            this.uscLedgershow1.Name = "uscLedgershow1";
            this.uscLedgershow1.Size = new System.Drawing.Size(441, 179);
            this.uscLedgershow1.TabIndex = 133;
            this.uscLedgershow1.Visible = false;
            // 
            // Frmdailyexpence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 557);
            this.Controls.Add(this.uscLedgershow1);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmdailyexpence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily expence";
            this.Load += new System.EventHandler(this.Frmdailyexpence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdForward;
        private System.Windows.Forms.ComboBox ComLedger;
        private System.Windows.Forms.Label lblledger;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdate;
        public System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNarration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRefNo;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdcancel;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbillamount;
        private WindowsFormsApplication2.UserControles.UscLedgershow uscLedgershow1;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clncredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotalcredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotaldebit;
    }
}