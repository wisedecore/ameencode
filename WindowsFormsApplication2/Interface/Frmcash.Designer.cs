namespace WindowsFormsApplication2
{
    partial class Frmcash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcash));
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
            this.chkReceiptbalance = new System.Windows.Forms.CheckBox();
            this.lblprinttype = new System.Windows.Forms.Label();
            this.combptype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiscount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.ComPrintSheme = new System.Windows.Forms.ComboBox();
            this.ChkPrintWileSaving = new System.Windows.Forms.CheckBox();
            this.Lblpartybalance = new System.Windows.Forms.Label();
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
            this.TxtLedger = new System.Windows.Forms.TextBox();
            this.Txt = new System.Windows.Forms.TextBox();
            this.pnlbill = new System.Windows.Forms.Panel();
            this.Gridbillwisesettlement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label68 = new System.Windows.Forms.Label();
            this.txtentervno = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Gridpartyproject = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscLedgershow1 = new WindowsFormsApplication2.UserControles.UscLedgershow();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnledger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnpartyproject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTaxperc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTaxamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbillwisesettlement)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridpartyproject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
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
            this.panel1.Size = new System.Drawing.Size(893, 63);
            this.panel1.TabIndex = 89;
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
            this.ComLedger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComLedger.FormattingEnabled = true;
            this.ComLedger.Location = new System.Drawing.Point(388, 21);
            this.ComLedger.Name = "ComLedger";
            this.ComLedger.Size = new System.Drawing.Size(291, 25);
            this.ComLedger.TabIndex = 1;
            this.ComLedger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComLedger_KeyPress);
            // 
            // lblledger
            // 
            this.lblledger.AutoSize = true;
            this.lblledger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblledger.ForeColor = System.Drawing.Color.Black;
            this.lblledger.Location = new System.Drawing.Point(309, 27);
            this.lblledger.Name = "lblledger";
            this.lblledger.Size = new System.Drawing.Size(74, 13);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(685, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(729, 25);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 20);
            this.dtdate.TabIndex = 2;
            this.dtdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtdate_KeyPress);
            // 
            // txtvno
            // 
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvno.Location = new System.Drawing.Point(63, 19);
            this.txtvno.Name = "txtvno";
            this.txtvno.ReadOnly = true;
            this.txtvno.Size = new System.Drawing.Size(42, 25);
            this.txtvno.TabIndex = 0;
            this.txtvno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.panel2.Controls.Add(this.chkReceiptbalance);
            this.panel2.Controls.Add(this.lblprinttype);
            this.panel2.Controls.Add(this.combptype);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtdiscount);
            this.panel2.Controls.Add(this.ComPrintSheme);
            this.panel2.Controls.Add(this.ChkPrintWileSaving);
            this.panel2.Controls.Add(this.Lblpartybalance);
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
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 104);
            this.panel2.TabIndex = 97;
            // 
            // chkReceiptbalance
            // 
            this.chkReceiptbalance.AutoSize = true;
            this.chkReceiptbalance.BackColor = System.Drawing.Color.White;
            this.chkReceiptbalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkReceiptbalance.Location = new System.Drawing.Point(423, 81);
            this.chkReceiptbalance.Name = "chkReceiptbalance";
            this.chkReceiptbalance.Size = new System.Drawing.Size(75, 19);
            this.chkReceiptbalance.TabIndex = 183;
            this.chkReceiptbalance.Text = " Balance ";
            this.chkReceiptbalance.UseVisualStyleBackColor = false;
            this.chkReceiptbalance.CheckedChanged += new System.EventHandler(this.chkReceiptbalance_CheckedChanged);
            // 
            // lblprinttype
            // 
            this.lblprinttype.AutoSize = true;
            this.lblprinttype.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblprinttype.ForeColor = System.Drawing.Color.Black;
            this.lblprinttype.Location = new System.Drawing.Point(420, 52);
            this.lblprinttype.Name = "lblprinttype";
            this.lblprinttype.Size = new System.Drawing.Size(57, 13);
            this.lblprinttype.TabIndex = 134;
            this.lblprinttype.Text = "PrintType";
            // 
            // combptype
            // 
            this.combptype.BackColor = System.Drawing.Color.White;
            this.combptype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combptype.ForeColor = System.Drawing.Color.Red;
            this.combptype.FormattingEnabled = true;
            this.combptype.Items.AddRange(new object[] {
            "A4 ",
            "Thermal"});
            this.combptype.Location = new System.Drawing.Point(483, 52);
            this.combptype.Name = "combptype";
            this.combptype.Size = new System.Drawing.Size(85, 24);
            this.combptype.TabIndex = 122;
            this.combptype.SelectedIndexChanged += new System.EventHandler(this.combptype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(607, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(607, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(700, 36);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(135, 22);
            this.txtdiscount.TabIndex = 131;
            this.txtdiscount.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtdiscount_TextChanged);
            // 
            // ComPrintSheme
            // 
            this.ComPrintSheme.BackColor = System.Drawing.Color.White;
            this.ComPrintSheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPrintSheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComPrintSheme.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPrintSheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComPrintSheme.FormattingEnabled = true;
            this.ComPrintSheme.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.ComPrintSheme.Location = new System.Drawing.Point(476, 2);
            this.ComPrintSheme.Name = "ComPrintSheme";
            this.ComPrintSheme.Size = new System.Drawing.Size(210, 25);
            this.ComPrintSheme.TabIndex = 129;
            // 
            // ChkPrintWileSaving
            // 
            this.ChkPrintWileSaving.AutoSize = true;
            this.ChkPrintWileSaving.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.ChkPrintWileSaving.ForeColor = System.Drawing.Color.Black;
            this.ChkPrintWileSaving.Location = new System.Drawing.Point(476, 32);
            this.ChkPrintWileSaving.Name = "ChkPrintWileSaving";
            this.ChkPrintWileSaving.Size = new System.Drawing.Size(120, 17);
            this.ChkPrintWileSaving.TabIndex = 130;
            this.ChkPrintWileSaving.Text = "Print while Saving";
            this.ChkPrintWileSaving.UseVisualStyleBackColor = true;
            this.ChkPrintWileSaving.CheckedChanged += new System.EventHandler(this.ChkPrintWileSaving_CheckedChanged);
            // 
            // Lblpartybalance
            // 
            this.Lblpartybalance.AutoSize = true;
            this.Lblpartybalance.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Lblpartybalance.ForeColor = System.Drawing.Color.Black;
            this.Lblpartybalance.Location = new System.Drawing.Point(444, 7);
            this.Lblpartybalance.Name = "Lblpartybalance";
            this.Lblpartybalance.Size = new System.Drawing.Size(28, 13);
            this.Lblpartybalance.TabIndex = 128;
            this.Lblpartybalance.Text = "0.00";
            this.Lblpartybalance.Visible = false;
            // 
            // txtbillamount
            // 
            this.txtbillamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtbillamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbillamount.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillamount.ForeColor = System.Drawing.Color.Black;
            this.txtbillamount.Location = new System.Drawing.Point(700, 64);
            this.txtbillamount.Multiline = true;
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(135, 35);
            this.txtbillamount.TabIndex = 22;
            this.txtbillamount.Text = "0.00";
            this.txtbillamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComStaff
            // 
            this.ComStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComStaff.FormattingEnabled = true;
            this.ComStaff.Location = new System.Drawing.Point(286, 2);
            this.ComStaff.Name = "ComStaff";
            this.ComStaff.Size = new System.Drawing.Size(140, 21);
            this.ComStaff.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Narration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(212, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee";
            // 
            // TxtNarration
            // 
            this.TxtNarration.Location = new System.Drawing.Point(88, 26);
            this.TxtNarration.Name = "TxtNarration";
            this.TxtNarration.Size = new System.Drawing.Size(338, 20);
            this.TxtNarration.TabIndex = 2;
            this.TxtNarration.Leave += new System.EventHandler(this.TxtNarration_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ref No";
            // 
            // TxtRefNo
            // 
            this.TxtRefNo.Location = new System.Drawing.Point(88, 1);
            this.TxtRefNo.Name = "TxtRefNo";
            this.TxtRefNo.Size = new System.Drawing.Size(92, 20);
            this.TxtRefNo.TabIndex = 0;
            this.TxtRefNo.Leave += new System.EventHandler(this.TxtRefNo_Leave);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(334, 55);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 45);
            this.cmdclose.TabIndex = 7;
            this.cmdclose.Text = "C&lose (قريب)";
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
            this.cmdclear.Location = new System.Drawing.Point(256, 55);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 45);
            this.cmdclear.TabIndex = 6;
            this.cmdclear.Text = "&Clear (واضح)";
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
            this.cmdcancel.Location = new System.Drawing.Point(178, 55);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 45);
            this.cmdcancel.TabIndex = 5;
            this.cmdcancel.Text = "Delete (حذف)";
            this.cmdcancel.UseVisualStyleBackColor = false;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdprint.Enabled = false;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(94, 55);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(81, 45);
            this.cmdprint.TabIndex = 4;
            this.cmdprint.Text = "&Print (طباعة)";
            this.cmdprint.UseVisualStyleBackColor = false;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.LightGreen;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(1, 47);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(87, 53);
            this.cmdsave.TabIndex = 3;
            this.cmdsave.Text = "&Save(F5) (حفظ)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // TxtLedger
            // 
            this.TxtLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLedger.Location = new System.Drawing.Point(374, 136);
            this.TxtLedger.Multiline = true;
            this.TxtLedger.Name = "TxtLedger";
            this.TxtLedger.Size = new System.Drawing.Size(100, 21);
            this.TxtLedger.TabIndex = 119;
            this.TxtLedger.TabStop = false;
            this.TxtLedger.Visible = false;
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(73, 251);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(100, 20);
            this.Txt.TabIndex = 121;
            this.Txt.Visible = false;
            // 
            // pnlbill
            // 
            this.pnlbill.BackColor = System.Drawing.Color.LightCoral;
            this.pnlbill.Controls.Add(this.Gridbillwisesettlement);
            this.pnlbill.Controls.Add(this.label68);
            this.pnlbill.Controls.Add(this.txtentervno);
            this.pnlbill.Location = new System.Drawing.Point(335, 123);
            this.pnlbill.Name = "pnlbill";
            this.pnlbill.Size = new System.Drawing.Size(433, 263);
            this.pnlbill.TabIndex = 128;
            this.pnlbill.Visible = false;
            // 
            // Gridbillwisesettlement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Gridbillwisesettlement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridbillwisesettlement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridbillwisesettlement.BackgroundColor = System.Drawing.Color.White;
            this.Gridbillwisesettlement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridbillwisesettlement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridbillwisesettlement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Gridbillwisesettlement.ColumnHeadersHeight = 30;
            this.Gridbillwisesettlement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridbillwisesettlement.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gridbillwisesettlement.EnableHeadersVisualStyles = false;
            this.Gridbillwisesettlement.GridColor = System.Drawing.Color.PaleVioletRed;
            this.Gridbillwisesettlement.Location = new System.Drawing.Point(3, 63);
            this.Gridbillwisesettlement.Name = "Gridbillwisesettlement";
            this.Gridbillwisesettlement.ReadOnly = true;
            this.Gridbillwisesettlement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridbillwisesettlement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridbillwisesettlement.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Gridbillwisesettlement.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridbillwisesettlement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridbillwisesettlement.Size = new System.Drawing.Size(427, 197);
            this.Gridbillwisesettlement.TabIndex = 133;
            this.Gridbillwisesettlement.Visible = false;
            this.Gridbillwisesettlement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridbillwisesettlement_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 192.292F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ledger Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(85, 8);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(84, 19);
            this.label68.TabIndex = 26;
            this.label68.Text = "Enter Bill No";
            // 
            // txtentervno
            // 
            this.txtentervno.Location = new System.Drawing.Point(77, 35);
            this.txtentervno.Name = "txtentervno";
            this.txtentervno.Size = new System.Drawing.Size(166, 20);
            this.txtentervno.TabIndex = 0;
            this.txtentervno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtentervno_PreviewKeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlbill);
            this.panel4.Controls.Add(this.Gridpartyproject);
            this.panel4.Controls.Add(this.uscLedgershow1);
            this.panel4.Controls.Add(this.gridmain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(893, 407);
            this.panel4.TabIndex = 90;
            // 
            // Gridpartyproject
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Gridpartyproject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Gridpartyproject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridpartyproject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridpartyproject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridpartyproject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridpartyproject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Gridpartyproject.ColumnHeadersHeight = 30;
            this.Gridpartyproject.ColumnHeadersVisible = false;
            this.Gridpartyproject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridpartyproject.DefaultCellStyle = dataGridViewCellStyle8;
            this.Gridpartyproject.EnableHeadersVisualStyles = false;
            this.Gridpartyproject.Location = new System.Drawing.Point(322, 73);
            this.Gridpartyproject.Name = "Gridpartyproject";
            this.Gridpartyproject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridpartyproject.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Gridpartyproject.RowHeadersVisible = false;
            this.Gridpartyproject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridpartyproject.Size = new System.Drawing.Size(273, 237);
            this.Gridpartyproject.TabIndex = 132;
            this.Gridpartyproject.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 192.292F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ledger Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // uscLedgershow1
            // 
            this.uscLedgershow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscLedgershow1.Location = new System.Drawing.Point(107, 85);
            this.uscLedgershow1.Name = "uscLedgershow1";
            this.uscLedgershow1.Size = new System.Drawing.Size(441, 179);
            this.uscLedgershow1.TabIndex = 131;
            // 
            // gridmain
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LavenderBlush;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridmain.ColumnHeadersHeight = 30;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnledger,
            this.clnpartyproject,
            this.clnnote,
            this.ClnTaxperc,
            this.ClnTaxamt,
            this.clnamount});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridmain.Location = new System.Drawing.Point(0, 0);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.Size = new System.Drawing.Size(893, 407);
            this.gridmain.TabIndex = 0;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 17.15045F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            // 
            // clnledger
            // 
            this.clnledger.FillWeight = 200.4742F;
            this.clnledger.HeaderText = "Ledger Name";
            this.clnledger.Name = "clnledger";
            // 
            // clnpartyproject
            // 
            this.clnpartyproject.HeaderText = "Party project";
            this.clnpartyproject.Name = "clnpartyproject";
            this.clnpartyproject.Visible = false;
            // 
            // clnnote
            // 
            this.clnnote.FillWeight = 276.0239F;
            this.clnnote.HeaderText = "Note";
            this.clnnote.Name = "clnnote";
            // 
            // ClnTaxperc
            // 
            this.ClnTaxperc.FillWeight = 89.89904F;
            this.ClnTaxperc.HeaderText = "Tax%";
            this.ClnTaxperc.Name = "ClnTaxperc";
            // 
            // ClnTaxamt
            // 
            this.ClnTaxamt.FillWeight = 87.90745F;
            this.ClnTaxamt.HeaderText = "TaxAmt";
            this.ClnTaxamt.Name = "ClnTaxamt";
            this.ClnTaxamt.ReadOnly = true;
            // 
            // clnamount
            // 
            this.clnamount.FillWeight = 50.11855F;
            this.clnamount.HeaderText = "Amount";
            this.clnamount.Name = "clnamount";
            // 
            // Frmcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 574);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.TxtLedger);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmcash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Transaction";
            this.Load += new System.EventHandler(this.Frmcash_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmcash_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmcash_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlbill.ResumeLayout(false);
            this.pnlbill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbillwisesettlement)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridpartyproject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbillamount;
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
        private System.Windows.Forms.ComboBox ComLedger;
        private System.Windows.Forms.Label lblledger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdForward;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.TextBox TxtLedger;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Label Lblpartybalance;
        public System.Windows.Forms.TextBox txtvno;
        public System.Windows.Forms.Panel pnlbill;
        private System.Windows.Forms.Label label68;
        public System.Windows.Forms.TextBox txtentervno;
        private System.Windows.Forms.Panel panel4;
        private WindowsFormsApplication2.UserControles.UscLedgershow uscLedgershow1;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.ComboBox ComPrintSheme;
        private System.Windows.Forms.CheckBox ChkPrintWileSaving;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Uscnuemerictextbox txtdiscount;
        private System.Windows.Forms.DataGridView Gridpartyproject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView Gridbillwisesettlement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnledger;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnpartyproject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTaxperc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTaxamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnamount;
        private System.Windows.Forms.Label lblprinttype;
        private System.Windows.Forms.ComboBox combptype;
        private System.Windows.Forms.CheckBox chkReceiptbalance;


    }
}