namespace WindowsFormsApplication2
{
    partial class frmTransferwindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.lblemployee = new System.Windows.Forms.Label();
            this.comtocompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comtaxtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comsourcevoucher = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comitemtype = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdsave = new System.Windows.Forms.Button();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtdiscounttransfer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdtransferopeningbalance = new System.Windows.Forms.Button();
            this.chkdeleteinvoice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.dtdate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(84, 12);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(121, 25);
            this.dtdate.TabIndex = 9;
            // 
            // lblemployee
            // 
            this.lblemployee.AutoSize = true;
            this.lblemployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployee.ForeColor = System.Drawing.Color.Black;
            this.lblemployee.Location = new System.Drawing.Point(362, 16);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(81, 17);
            this.lblemployee.TabIndex = 27;
            this.lblemployee.Text = "To Company";
            // 
            // comtocompany
            // 
            this.comtocompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.comtocompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtocompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comtocompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comtocompany.ForeColor = System.Drawing.Color.Black;
            this.comtocompany.FormattingEnabled = true;
            this.comtocompany.Location = new System.Drawing.Point(463, 12);
            this.comtocompany.Name = "comtocompany";
            this.comtocompany.Size = new System.Drawing.Size(190, 25);
            this.comtocompany.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "To TaxMode";
            // 
            // comtaxtype
            // 
            this.comtaxtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.comtaxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtaxtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comtaxtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comtaxtype.ForeColor = System.Drawing.Color.Black;
            this.comtaxtype.FormattingEnabled = true;
            this.comtaxtype.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.comtaxtype.Location = new System.Drawing.Point(463, 43);
            this.comtaxtype.Name = "comtaxtype";
            this.comtaxtype.Size = new System.Drawing.Size(105, 25);
            this.comtaxtype.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Select Voucher";
            // 
            // comsourcevoucher
            // 
            this.comsourcevoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.comsourcevoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comsourcevoucher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comsourcevoucher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comsourcevoucher.ForeColor = System.Drawing.Color.Black;
            this.comsourcevoucher.FormattingEnabled = true;
            this.comsourcevoucher.Items.AddRange(new object[] {
            "Sales",
            "Purchase",
            "Item with Batch"});
            this.comsourcevoucher.Location = new System.Drawing.Point(8, 115);
            this.comsourcevoucher.Name = "comsourcevoucher";
            this.comsourcevoucher.Size = new System.Drawing.Size(157, 25);
            this.comsourcevoucher.TabIndex = 31;
            this.comsourcevoucher.SelectedIndexChanged += new System.EventHandler(this.comsourcevoucher_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(384, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 325);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(421, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(363, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Item Type";
            this.label5.Visible = false;
            // 
            // comitemtype
            // 
            this.comitemtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.comitemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comitemtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comitemtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comitemtype.ForeColor = System.Drawing.Color.Black;
            this.comitemtype.FormattingEnabled = true;
            this.comitemtype.Location = new System.Drawing.Point(463, 74);
            this.comitemtype.Name = "comitemtype";
            this.comitemtype.Size = new System.Drawing.Size(190, 25);
            this.comitemtype.TabIndex = 35;
            this.comitemtype.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(491, 477);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 37);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(344, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total Amount";
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(301, 269);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(77, 45);
            this.cmdsave.TabIndex = 39;
            this.cmdsave.Text = ">>>";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // gridmain
            // 
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmain.ColumnHeadersVisible = false;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.Location = new System.Drawing.Point(22, 147);
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.Size = new System.Drawing.Size(273, 324);
            this.gridmain.TabIndex = 40;
            // 
            // Column2
            // 
            this.Column2.FalseValue = "0";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.TrueValue = "1";
            this.Column2.Width = 25;
            // 
            // txtdiscounttransfer
            // 
            this.txtdiscounttransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscounttransfer.Location = new System.Drawing.Point(151, 477);
            this.txtdiscounttransfer.Name = "txtdiscounttransfer";
            this.txtdiscounttransfer.Size = new System.Drawing.Size(144, 26);
            this.txtdiscounttransfer.TabIndex = 41;
            this.txtdiscounttransfer.Text = "0.00";
            this.txtdiscounttransfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscounttransfer_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Discount to Transfer";
            // 
            // cmdtransferopeningbalance
            // 
            this.cmdtransferopeningbalance.Location = new System.Drawing.Point(104, 70);
            this.cmdtransferopeningbalance.Name = "cmdtransferopeningbalance";
            this.cmdtransferopeningbalance.Size = new System.Drawing.Size(145, 23);
            this.cmdtransferopeningbalance.TabIndex = 43;
            this.cmdtransferopeningbalance.Text = "Transfer opening Balance";
            this.cmdtransferopeningbalance.UseVisualStyleBackColor = true;
            this.cmdtransferopeningbalance.Click += new System.EventHandler(this.cmdtransferopeningbalance_Click);
            // 
            // chkdeleteinvoice
            // 
            this.chkdeleteinvoice.AutoSize = true;
            this.chkdeleteinvoice.BackColor = System.Drawing.Color.White;
            this.chkdeleteinvoice.ForeColor = System.Drawing.Color.Red;
            this.chkdeleteinvoice.Location = new System.Drawing.Point(171, 120);
            this.chkdeleteinvoice.Name = "chkdeleteinvoice";
            this.chkdeleteinvoice.Size = new System.Drawing.Size(137, 17);
            this.chkdeleteinvoice.TabIndex = 44;
            this.chkdeleteinvoice.Text = "Delete transfer voucher";
            this.chkdeleteinvoice.UseVisualStyleBackColor = false;
            // 
            // frmTransferwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(665, 526);
            this.Controls.Add(this.chkdeleteinvoice);
            this.Controls.Add(this.cmdtransferopeningbalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiscounttransfer);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comitemtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comsourcevoucher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comtaxtype);
            this.Controls.Add(this.lblemployee);
            this.Controls.Add(this.comtocompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransferwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Transfer";
            this.Load += new System.EventHandler(this.Transferwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.ComboBox comtocompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtaxtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comsourcevoucher;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comitemtype;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.TextBox txtdiscounttransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdtransferopeningbalance;
        private System.Windows.Forms.CheckBox chkdeleteinvoice;

    }
}