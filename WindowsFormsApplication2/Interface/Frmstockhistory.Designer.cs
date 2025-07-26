namespace WindowsFormsApplication2
{
    partial class Frmstockhistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmstockhistory));
            this.pnltop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdexcel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttbalance = new System.Windows.Forms.TextBox();
            this.txttqtyout = new System.Windows.Forms.TextBox();
            this.txttqtyin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkallledger = new System.Windows.Forms.CheckBox();
            this.chkallvouchertype = new System.Windows.Forms.CheckBox();
            this.chkallbarcode = new System.Windows.Forms.CheckBox();
            this.comselectbarcode = new System.Windows.Forms.ComboBox();
            this.lblselectbarcode = new System.Windows.Forms.Label();
            this.cmdexport = new System.Windows.Forms.Button();
            this.cmdshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtto = new System.Windows.Forms.DateTimePicker();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.comledger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comvtype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnvno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqtyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqtyout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnparty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscGridshow1 = new WindowsFormsApplication2.UscGridshow();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnltop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.pnltop.Controls.Add(this.panel2);
            this.pnltop.Controls.Add(this.panel1);
            this.pnltop.Controls.Add(this.chkallledger);
            this.pnltop.Controls.Add(this.chkallvouchertype);
            this.pnltop.Controls.Add(this.chkallbarcode);
            this.pnltop.Controls.Add(this.comselectbarcode);
            this.pnltop.Controls.Add(this.lblselectbarcode);
            this.pnltop.Controls.Add(this.cmdexport);
            this.pnltop.Controls.Add(this.cmdshow);
            this.pnltop.Controls.Add(this.label3);
            this.pnltop.Controls.Add(this.label2);
            this.pnltop.Controls.Add(this.Dtto);
            this.pnltop.Controls.Add(this.Dtfrom);
            this.pnltop.Controls.Add(this.comledger);
            this.pnltop.Controls.Add(this.label1);
            this.pnltop.Controls.Add(this.comvtype);
            this.pnltop.Controls.Add(this.label10);
            this.pnltop.Controls.Add(this.txtitem);
            this.pnltop.Controls.Add(this.label19);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(955, 104);
            this.pnltop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdexcel);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(509, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 171;
            // 
            // cmdexcel
            // 
            this.cmdexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdexcel.Location = new System.Drawing.Point(100, 5);
            this.cmdexcel.Name = "cmdexcel";
            this.cmdexcel.Size = new System.Drawing.Size(81, 33);
            this.cmdexcel.TabIndex = 174;
            this.cmdexcel.Text = "Excel";
            this.cmdexcel.UseVisualStyleBackColor = false;
            this.cmdexcel.Click += new System.EventHandler(this.cmdexcel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(19, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 33);
            this.button2.TabIndex = 173;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttbalance);
            this.panel1.Controls.Add(this.txttqtyout);
            this.panel1.Controls.Add(this.txttqtyin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(715, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 104);
            this.panel1.TabIndex = 170;
            // 
            // txttbalance
            // 
            this.txttbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttbalance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txttbalance.ForeColor = System.Drawing.Color.Red;
            this.txttbalance.Location = new System.Drawing.Point(124, 70);
            this.txttbalance.Multiline = true;
            this.txttbalance.Name = "txttbalance";
            this.txttbalance.ReadOnly = true;
            this.txttbalance.Size = new System.Drawing.Size(114, 31);
            this.txttbalance.TabIndex = 178;
            this.txttbalance.Text = "0";
            // 
            // txttqtyout
            // 
            this.txttqtyout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttqtyout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttqtyout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txttqtyout.ForeColor = System.Drawing.Color.Red;
            this.txttqtyout.Location = new System.Drawing.Point(124, 36);
            this.txttqtyout.Multiline = true;
            this.txttqtyout.Name = "txttqtyout";
            this.txttqtyout.ReadOnly = true;
            this.txttqtyout.Size = new System.Drawing.Size(114, 31);
            this.txttqtyout.TabIndex = 177;
            this.txttqtyout.Text = "0";
            // 
            // txttqtyin
            // 
            this.txttqtyin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttqtyin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttqtyin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txttqtyin.ForeColor = System.Drawing.Color.Red;
            this.txttqtyin.Location = new System.Drawing.Point(124, 3);
            this.txttqtyin.Multiline = true;
            this.txttqtyin.Name = "txttqtyin";
            this.txttqtyin.ReadOnly = true;
            this.txttqtyin.Size = new System.Drawing.Size(114, 31);
            this.txttqtyin.TabIndex = 176;
            this.txttqtyin.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 175;
            this.label7.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 174;
            this.label5.Text = "Total Qty Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 173;
            this.label6.Text = "Total Qty IN";
            // 
            // chkallledger
            // 
            this.chkallledger.AutoSize = true;
            this.chkallledger.Checked = true;
            this.chkallledger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallledger.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallledger.ForeColor = System.Drawing.Color.White;
            this.chkallledger.Location = new System.Drawing.Point(490, 41);
            this.chkallledger.Name = "chkallledger";
            this.chkallledger.Size = new System.Drawing.Size(41, 21);
            this.chkallledger.TabIndex = 169;
            this.chkallledger.Text = "All";
            this.chkallledger.UseVisualStyleBackColor = true;
            this.chkallledger.CheckedChanged += new System.EventHandler(this.chkallledger_CheckedChanged);
            // 
            // chkallvouchertype
            // 
            this.chkallvouchertype.AutoSize = true;
            this.chkallvouchertype.Checked = true;
            this.chkallvouchertype.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallvouchertype.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallvouchertype.ForeColor = System.Drawing.Color.White;
            this.chkallvouchertype.Location = new System.Drawing.Point(490, 14);
            this.chkallvouchertype.Name = "chkallvouchertype";
            this.chkallvouchertype.Size = new System.Drawing.Size(41, 21);
            this.chkallvouchertype.TabIndex = 168;
            this.chkallvouchertype.Text = "All";
            this.chkallvouchertype.UseVisualStyleBackColor = true;
            this.chkallvouchertype.CheckedChanged += new System.EventHandler(this.chkallvouchertype_CheckedChanged);
            // 
            // chkallbarcode
            // 
            this.chkallbarcode.AutoSize = true;
            this.chkallbarcode.Checked = true;
            this.chkallbarcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallbarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallbarcode.ForeColor = System.Drawing.Color.White;
            this.chkallbarcode.Location = new System.Drawing.Point(155, 78);
            this.chkallbarcode.Name = "chkallbarcode";
            this.chkallbarcode.Size = new System.Drawing.Size(41, 21);
            this.chkallbarcode.TabIndex = 167;
            this.chkallbarcode.Text = "All";
            this.chkallbarcode.UseVisualStyleBackColor = true;
            this.chkallbarcode.CheckedChanged += new System.EventHandler(this.chkallbarcode_CheckedChanged);
            // 
            // comselectbarcode
            // 
            this.comselectbarcode.Enabled = false;
            this.comselectbarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comselectbarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comselectbarcode.FormattingEnabled = true;
            this.comselectbarcode.Location = new System.Drawing.Point(18, 75);
            this.comselectbarcode.Name = "comselectbarcode";
            this.comselectbarcode.Size = new System.Drawing.Size(133, 23);
            this.comselectbarcode.TabIndex = 166;
            this.comselectbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comselectbarcode_KeyPress);
            // 
            // lblselectbarcode
            // 
            this.lblselectbarcode.AutoSize = true;
            this.lblselectbarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectbarcode.ForeColor = System.Drawing.Color.White;
            this.lblselectbarcode.Location = new System.Drawing.Point(15, 53);
            this.lblselectbarcode.Name = "lblselectbarcode";
            this.lblselectbarcode.Size = new System.Drawing.Size(94, 17);
            this.lblselectbarcode.TabIndex = 158;
            this.lblselectbarcode.Text = "Select Barcode";
            // 
            // cmdexport
            // 
            this.cmdexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdexport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdexport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexport.ForeColor = System.Drawing.Color.Black;
            this.cmdexport.Location = new System.Drawing.Point(837, 15);
            this.cmdexport.Name = "cmdexport";
            this.cmdexport.Size = new System.Drawing.Size(75, 36);
            this.cmdexport.TabIndex = 157;
            this.cmdexport.Text = "&Export";
            this.cmdexport.UseVisualStyleBackColor = false;
            // 
            // cmdshow
            // 
            this.cmdshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdshow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdshow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdshow.ForeColor = System.Drawing.Color.Black;
            this.cmdshow.Location = new System.Drawing.Point(759, 15);
            this.cmdshow.Name = "cmdshow";
            this.cmdshow.Size = new System.Drawing.Size(75, 36);
            this.cmdshow.TabIndex = 156;
            this.cmdshow.Text = "&Show";
            this.cmdshow.UseVisualStyleBackColor = false;
            this.cmdshow.Click += new System.EventHandler(this.cmdshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 155;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(540, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 154;
            this.label2.Text = "From";
            // 
            // Dtto
            // 
            this.Dtto.Location = new System.Drawing.Point(639, 40);
            this.Dtto.Name = "Dtto";
            this.Dtto.Size = new System.Drawing.Size(114, 20);
            this.Dtto.TabIndex = 153;
            // 
            // Dtfrom
            // 
            this.Dtfrom.Location = new System.Drawing.Point(639, 12);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(114, 20);
            this.Dtfrom.TabIndex = 152;
            // 
            // comledger
            // 
            this.comledger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comledger.Enabled = false;
            this.comledger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comledger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comledger.FormattingEnabled = true;
            this.comledger.Location = new System.Drawing.Point(346, 39);
            this.comledger.Name = "comledger";
            this.comledger.Size = new System.Drawing.Size(140, 23);
            this.comledger.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 151;
            this.label1.Text = "Select Ledger";
            // 
            // comvtype
            // 
            this.comvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comvtype.Enabled = false;
            this.comvtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comvtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comvtype.FormattingEnabled = true;
            this.comvtype.Items.AddRange(new object[] {
            "Sales",
            "Sales Return",
            "Purchase",
            "Purchase Return",
            "Opening Stock",
            "Delivery Note",
            "Internel Issue",
            "Shortage",
            "Damage",
            "Free Receipt",
            "Free Issue",
            "Meterial Receipt",
            "Internel Receipt"});
            this.comvtype.Location = new System.Drawing.Point(346, 12);
            this.comvtype.Name = "comvtype";
            this.comvtype.Size = new System.Drawing.Size(140, 23);
            this.comvtype.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(236, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 149;
            this.label10.Text = "Voucher Type";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(18, 30);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(162, 20);
            this.txtitem.TabIndex = 147;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            this.txtitem.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtitem_PreviewKeyDown);
            this.txtitem.Enter += new System.EventHandler(this.txtitem_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(15, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 146;
            this.label19.Text = "Select Item";
            // 
            // gridmain
            // 
            this.gridmain.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.clnslno,
            this.clnvtype,
            this.clnvno,
            this.clndate,
            this.clnqtyin,
            this.clnqtyout,
            this.clnrate,
            this.clnparty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 104);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.ReadOnly = true;
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
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmain.Size = new System.Drawing.Size(955, 264);
            this.gridmain.TabIndex = 2;
            this.gridmain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridmain_MouseDoubleClick);
            this.gridmain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellContentClick);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 39.2668F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            this.clnslno.Width = 71;
            // 
            // clnvtype
            // 
            this.clnvtype.HeaderText = "Voucher Type";
            this.clnvtype.Name = "clnvtype";
            this.clnvtype.ReadOnly = true;
            this.clnvtype.Width = 181;
            // 
            // clnvno
            // 
            this.clnvno.HeaderText = "VNo";
            this.clnvno.Name = "clnvno";
            this.clnvno.ReadOnly = true;
            this.clnvno.Width = 120;
            // 
            // clndate
            // 
            this.clndate.HeaderText = "Date";
            this.clndate.Name = "clndate";
            this.clndate.ReadOnly = true;
            this.clndate.Width = 181;
            // 
            // clnqtyin
            // 
            this.clnqtyin.FillWeight = 150F;
            this.clnqtyin.HeaderText = "Qty IN";
            this.clnqtyin.Name = "clnqtyin";
            this.clnqtyin.ReadOnly = true;
            this.clnqtyin.Width = 71;
            // 
            // clnqtyout
            // 
            this.clnqtyout.FillWeight = 150F;
            this.clnqtyout.HeaderText = "Qty Out";
            this.clnqtyout.Name = "clnqtyout";
            this.clnqtyout.ReadOnly = true;
            this.clnqtyout.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnqtyout.Width = 71;
            // 
            // clnrate
            // 
            this.clnrate.HeaderText = "Rate";
            this.clnrate.Name = "clnrate";
            this.clnrate.ReadOnly = true;
            this.clnrate.Visible = false;
            // 
            // clnparty
            // 
            this.clnparty.HeaderText = "Party";
            this.clnparty.Name = "clnparty";
            this.clnparty.ReadOnly = true;
            this.clnparty.Width = 200;
            // 
            // uscGridshow1
            // 
            this.uscGridshow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow1.Location = new System.Drawing.Point(28, 110);
            this.uscGridshow1.Name = "uscGridshow1";
            this.uscGridshow1.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow1.TabIndex = 3;
            this.uscGridshow1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // Frmstockhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 368);
            this.Controls.Add(this.uscGridshow1);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmstockhistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmstockhistory_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmstockhistory_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmstockhistory_KeyDown);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.ComboBox comledger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comvtype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtto;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Button cmdexport;
        private System.Windows.Forms.Button cmdshow;
        private System.Windows.Forms.Label lblselectbarcode;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.ComboBox comselectbarcode;
        private WindowsFormsApplication2.UscGridshow uscGridshow1;
        private System.Windows.Forms.CheckBox chkallledger;
        private System.Windows.Forms.CheckBox chkallvouchertype;
        private System.Windows.Forms.CheckBox chkallbarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttbalance;
        private System.Windows.Forms.TextBox txttqtyout;
        private System.Windows.Forms.TextBox txttqtyin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnvno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqtyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqtyout;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnparty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdexcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

    }
}