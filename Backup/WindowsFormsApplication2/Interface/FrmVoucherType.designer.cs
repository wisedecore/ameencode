namespace WindowsFormsApplication2
{
    partial class FrmVoucherType
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
            this.lblVname = new System.Windows.Forms.Label();
            this.lblcoln = new System.Windows.Forms.Label();
            this.lblunderVoucher = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblPrinter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comUnderVucr = new System.Windows.Forms.ComboBox();
            this.cmdBrows = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.GridItem = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtLedId = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtPrinter = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtItemClass = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtItemCategry = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtVname = new WindowsFormsApplication2.Uscnormaltextbox();
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVname
            // 
            this.lblVname.AutoSize = true;
            this.lblVname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVname.Location = new System.Drawing.Point(12, 43);
            this.lblVname.Name = "lblVname";
            this.lblVname.Size = new System.Drawing.Size(98, 16);
            this.lblVname.TabIndex = 0;
            this.lblVname.Text = "Voucher Name";
            // 
            // lblcoln
            // 
            this.lblcoln.AutoSize = true;
            this.lblcoln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoln.Location = new System.Drawing.Point(115, 43);
            this.lblcoln.Name = "lblcoln";
            this.lblcoln.Size = new System.Drawing.Size(11, 16);
            this.lblcoln.TabIndex = 1;
            this.lblcoln.Text = ":";
            // 
            // lblunderVoucher
            // 
            this.lblunderVoucher.AutoSize = true;
            this.lblunderVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunderVoucher.Location = new System.Drawing.Point(12, 83);
            this.lblunderVoucher.Name = "lblunderVoucher";
            this.lblunderVoucher.Size = new System.Drawing.Size(98, 16);
            this.lblunderVoucher.TabIndex = 2;
            this.lblunderVoucher.Text = "Under Voucher";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCategory.Location = new System.Drawing.Point(13, 119);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(91, 16);
            this.lblItemCategory.TabIndex = 3;
            this.lblItemCategory.Text = "Item Category";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(13, 155);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(70, 16);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Item Class";
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.Location = new System.Drawing.Point(13, 187);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(46, 16);
            this.lblPrinter.TabIndex = 5;
            this.lblPrinter.Text = "Printer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // comUnderVucr
            // 
            this.comUnderVucr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comUnderVucr.FormattingEnabled = true;
            this.comUnderVucr.Items.AddRange(new object[] {
            "PURCHASE",
            "SALES",
            ""});
            this.comUnderVucr.Location = new System.Drawing.Point(138, 83);
            this.comUnderVucr.Name = "comUnderVucr";
            this.comUnderVucr.Size = new System.Drawing.Size(212, 24);
            this.comUnderVucr.TabIndex = 2;
            // 
            // cmdBrows
            // 
            this.cmdBrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrows.Location = new System.Drawing.Point(343, 183);
            this.cmdBrows.Name = "cmdBrows";
            this.cmdBrows.Size = new System.Drawing.Size(64, 24);
            this.cmdBrows.TabIndex = 6;
            this.cmdBrows.Text = "Browse";
            this.cmdBrows.UseVisualStyleBackColor = true;
            this.cmdBrows.Click += new System.EventHandler(this.cmdBrows_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(138, 226);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(68, 28);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // GridItem
            // 
            this.GridItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItem.ColumnHeadersVisible = false;
            this.GridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn});
            this.GridItem.EnableHeadersVisualStyles = false;
            this.GridItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(191)))));
            this.GridItem.Location = new System.Drawing.Point(138, 178);
            this.GridItem.Name = "GridItem";
            this.GridItem.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.GridItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridItem.Size = new System.Drawing.Size(212, 129);
            this.GridItem.TabIndex = 19;
            this.GridItem.Visible = false;
            this.GridItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItem_CellContentClick);
            // 
            // DataGridViewTextBoxColumn
            // 
            this.DataGridViewTextBoxColumn.HeaderText = "Name";
            this.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn";
            this.DataGridViewTextBoxColumn.Width = 208;
            // 
            // TxtLedId
            // 
            this.TxtLedId.Location = new System.Drawing.Point(138, 5);
            this.TxtLedId.Name = "TxtLedId";
            this.TxtLedId.Size = new System.Drawing.Size(87, 31);
            this.TxtLedId.TabIndex = 20;
            this.TxtLedId.Visible = false;
            // 
            // txtPrinter
            // 
            this.txtPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinter.Location = new System.Drawing.Point(138, 187);
            this.txtPrinter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrinter.Name = "txtPrinter";
            this.txtPrinter.Size = new System.Drawing.Size(199, 20);
            this.txtPrinter.TabIndex = 5;
            this.txtPrinter.Leave += new System.EventHandler(this.txtPrinter_Leave);
            // 
            // txtItemClass
            // 
            this.txtItemClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemClass.Location = new System.Drawing.Point(138, 155);
            this.txtItemClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemClass.Name = "txtItemClass";
            this.txtItemClass.Size = new System.Drawing.Size(212, 20);
            this.txtItemClass.TabIndex = 4;
            this.txtItemClass.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtItemClass_TextChanged);
            this.txtItemClass.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtItemClass_PreviewKeyDown);
            this.txtItemClass.Leave += new System.EventHandler(this.txtItemClass_Leave);
            // 
            // txtItemCategry
            // 
            this.txtItemCategry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCategry.Location = new System.Drawing.Point(138, 119);
            this.txtItemCategry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemCategry.Name = "txtItemCategry";
            this.txtItemCategry.Size = new System.Drawing.Size(212, 20);
            this.txtItemCategry.TabIndex = 3;
            this.txtItemCategry.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtItemCategry_TextChanged);
            this.txtItemCategry.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtItemCategry_PreviewKeyDown);
            this.txtItemCategry.Leave += new System.EventHandler(this.txtItemCategry_Leave);
            // 
            // txtVname
            // 
            this.txtVname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVname.Location = new System.Drawing.Point(138, 43);
            this.txtVname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVname.Name = "txtVname";
            this.txtVname.Size = new System.Drawing.Size(212, 25);
            this.txtVname.TabIndex = 1;
            this.txtVname.Leave += new System.EventHandler(this.txtVname_Leave);
            // 
            // FrmVoucherType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 316);
            this.Controls.Add(this.TxtLedId);
            this.Controls.Add(this.GridItem);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdBrows);
            this.Controls.Add(this.comUnderVucr);
            this.Controls.Add(this.txtPrinter);
            this.Controls.Add(this.txtItemClass);
            this.Controls.Add(this.txtItemCategry);
            this.Controls.Add(this.txtVname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrinter);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.lblunderVoucher);
            this.Controls.Add(this.lblcoln);
            this.Controls.Add(this.lblVname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVoucherType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoucherType";
            this.Load += new System.EventHandler(this.FrmVoucherType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVname;
        private System.Windows.Forms.Label lblcoln;
        private System.Windows.Forms.Label lblunderVoucher;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApplication2.Uscnormaltextbox txtVname;
        private WindowsFormsApplication2.Uscnormaltextbox txtItemCategry;
        private WindowsFormsApplication2.Uscnormaltextbox txtItemClass;
        private WindowsFormsApplication2.Uscnormaltextbox txtPrinter;
        private System.Windows.Forms.ComboBox comUnderVucr;
        private System.Windows.Forms.Button cmdBrows;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.DataGridView GridItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn;
        private WindowsFormsApplication2.Uscnormaltextbox TxtLedId;

    }
}