namespace WindowsFormsApplication2
{
    partial class FrmCashDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashDesk));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtcashreceived = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.Txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Commodeofpayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.chktwotypepaymnt = new System.Windows.Forms.CheckBox();
            this.combotwotypemode = new System.Windows.Forms.ComboBox();
            this.txtsecndmodeamt = new System.Windows.Forms.TextBox();
            this.lbltwotypemode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Balance";
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtamount.Location = new System.Drawing.Point(148, 27);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(216, 43);
            this.txtamount.TabIndex = 0;
            this.txtamount.Text = "0.00";
            // 
            // txtcashreceived
            // 
            this.txtcashreceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcashreceived.Location = new System.Drawing.Point(148, 125);
            this.txtcashreceived.Multiline = true;
            this.txtcashreceived.Name = "txtcashreceived";
            this.txtcashreceived.Size = new System.Drawing.Size(216, 43);
            this.txtcashreceived.TabIndex = 2;
            this.txtcashreceived.Text = "0.00";
            this.txtcashreceived.TextChanged += new System.EventHandler(this.txtcashreceived_TextChanged);
            this.txtcashreceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcashreceived_KeyPress);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txttotal.Location = new System.Drawing.Point(148, 175);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(216, 43);
            this.txttotal.TabIndex = 3;
            this.txttotal.Text = "0.00";
            // 
            // txtbalance
            // 
            this.txtbalance.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtbalance.Location = new System.Drawing.Point(148, 227);
            this.txtbalance.Multiline = true;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(216, 43);
            this.txtbalance.TabIndex = 4;
            this.txtbalance.Text = "0.00";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(265, 375);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(99, 49);
            this.cmdclose.TabIndex = 6;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsave.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(148, 375);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(97, 49);
            this.cmdsave.TabIndex = 5;
            this.cmdsave.Text = "Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // Txtdiscount
            // 
            this.Txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdiscount.Location = new System.Drawing.Point(148, 76);
            this.Txtdiscount.Multiline = true;
            this.Txtdiscount.Name = "Txtdiscount";
            this.Txtdiscount.Size = new System.Drawing.Size(216, 43);
            this.Txtdiscount.TabIndex = 1;
            this.Txtdiscount.Text = "0.00";
            this.Txtdiscount.TextChanged += new System.EventHandler(this.Txtdiscount_TextChanged);
            this.Txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdiscount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Discount";
            // 
            // Commodeofpayment
            // 
            this.Commodeofpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Commodeofpayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Commodeofpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commodeofpayment.FormattingEnabled = true;
            this.Commodeofpayment.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.Commodeofpayment.Location = new System.Drawing.Point(149, 291);
            this.Commodeofpayment.Name = "Commodeofpayment";
            this.Commodeofpayment.Size = new System.Drawing.Size(215, 33);
            this.Commodeofpayment.TabIndex = 13;
            this.Commodeofpayment.SelectedIndexChanged += new System.EventHandler(this.Commodeofpayment_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mode of payment";
            // 
            // TxtAccount
            // 
            this.TxtAccount.Enabled = false;
            this.TxtAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtAccount.ForeColor = System.Drawing.Color.Black;
            this.TxtAccount.Location = new System.Drawing.Point(148, 330);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(216, 29);
            this.TxtAccount.TabIndex = 14;
            // 
            // chktwotypepaymnt
            // 
            this.chktwotypepaymnt.AutoSize = true;
            this.chktwotypepaymnt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktwotypepaymnt.Location = new System.Drawing.Point(397, 29);
            this.chktwotypepaymnt.Name = "chktwotypepaymnt";
            this.chktwotypepaymnt.Size = new System.Drawing.Size(176, 27);
            this.chktwotypepaymnt.TabIndex = 17;
            this.chktwotypepaymnt.Text = "2Type Payment";
            this.chktwotypepaymnt.UseVisualStyleBackColor = true;
            this.chktwotypepaymnt.CheckedChanged += new System.EventHandler(this.chktwotypepaymnt_CheckedChanged);
            // 
            // combotwotypemode
            // 
            this.combotwotypemode.AutoCompleteCustomSource.AddRange(new string[] {
            "CARD",
            "CASH"});
            this.combotwotypemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotwotypemode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combotwotypemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotwotypemode.ForeColor = System.Drawing.Color.Fuchsia;
            this.combotwotypemode.FormattingEnabled = true;
            this.combotwotypemode.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.combotwotypemode.Location = new System.Drawing.Point(397, 59);
            this.combotwotypemode.Name = "combotwotypemode";
            this.combotwotypemode.Size = new System.Drawing.Size(173, 33);
            this.combotwotypemode.TabIndex = 16;
            this.combotwotypemode.Visible = false;
            // 
            // txtsecndmodeamt
            // 
            this.txtsecndmodeamt.BackColor = System.Drawing.Color.White;
            this.txtsecndmodeamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecndmodeamt.Location = new System.Drawing.Point(387, 125);
            this.txtsecndmodeamt.Multiline = true;
            this.txtsecndmodeamt.Name = "txtsecndmodeamt";
            this.txtsecndmodeamt.Size = new System.Drawing.Size(192, 43);
            this.txtsecndmodeamt.TabIndex = 3;
            this.txtsecndmodeamt.Text = "0.00";
            this.txtsecndmodeamt.Visible = false;
            this.txtsecndmodeamt.TextChanged += new System.EventHandler(this.txtsecndmodeamt_TextChanged);
            // 
            // lbltwotypemode
            // 
            this.lbltwotypemode.AutoSize = true;
            this.lbltwotypemode.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltwotypemode.ForeColor = System.Drawing.Color.Black;
            this.lbltwotypemode.Location = new System.Drawing.Point(382, 93);
            this.lbltwotypemode.Name = "lbltwotypemode";
            this.lbltwotypemode.Size = new System.Drawing.Size(92, 28);
            this.lbltwotypemode.TabIndex = 15;
            this.lbltwotypemode.Text = "Received";
            this.lbltwotypemode.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 10);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 10);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 438);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(585, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 438);
            this.panel2.TabIndex = 21;
            // 
            // FrmCashDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(593, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltwotypemode);
            this.Controls.Add(this.txtsecndmodeamt);
            this.Controls.Add(this.combotwotypemode);
            this.Controls.Add(this.chktwotypepaymnt);
            this.Controls.Add(this.TxtAccount);
            this.Controls.Add(this.Commodeofpayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtdiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtcashreceived);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCashDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Desk";
            this.Load += new System.EventHandler(this.FrmCashDesk_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCashDesk_KeyUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCashDesk_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCashDesk_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtcashreceived;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.TextBox Txtdiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Commodeofpayment;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.CheckBox chktwotypepaymnt;
        private System.Windows.Forms.TextBox txtsecndmodeamt;
        private System.Windows.Forms.Label lbltwotypemode;
        public System.Windows.Forms.ComboBox combotwotypemode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}