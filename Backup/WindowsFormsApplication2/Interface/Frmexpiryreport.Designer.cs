namespace WindowsFormsApplication2
{
    partial class Frmexpiryreport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmexpiryreport));
            this.pnltop = new System.Windows.Forms.Panel();
            this.cmdsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dttodate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtfromdate = new System.Windows.Forms.DateTimePicker();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnexpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmandate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.cmdsearch);
            this.pnltop.Controls.Add(this.label3);
            this.pnltop.Controls.Add(this.txtsupplier);
            this.pnltop.Controls.Add(this.label1);
            this.pnltop.Controls.Add(this.Dttodate);
            this.pnltop.Controls.Add(this.label2);
            this.pnltop.Controls.Add(this.Dtfromdate);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(940, 58);
            this.pnltop.TabIndex = 0;
            // 
            // cmdsearch
            // 
            this.cmdsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsearch.FlatAppearance.BorderSize = 0;
            this.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsearch.ForeColor = System.Drawing.Color.Black;
            this.cmdsearch.Location = new System.Drawing.Point(850, 13);
            this.cmdsearch.Name = "cmdsearch";
            this.cmdsearch.Size = new System.Drawing.Size(78, 33);
            this.cmdsearch.TabIndex = 31;
            this.cmdsearch.Text = "Search";
            this.cmdsearch.UseVisualStyleBackColor = false;
            this.cmdsearch.Click += new System.EventHandler(this.cmdsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(424, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Supplier";
            // 
            // txtsupplier
            // 
            this.txtsupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtsupplier.Location = new System.Drawing.Point(527, 15);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(290, 29);
            this.txtsupplier.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "To Date";
            // 
            // Dttodate
            // 
            this.Dttodate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.Dttodate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dttodate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dttodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dttodate.Location = new System.Drawing.Point(297, 13);
            this.Dttodate.Name = "Dttodate";
            this.Dttodate.Size = new System.Drawing.Size(121, 25);
            this.Dttodate.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "From Date";
            // 
            // Dtfromdate
            // 
            this.Dtfromdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.Dtfromdate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dtfromdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfromdate.Location = new System.Drawing.Point(80, 12);
            this.Dtfromdate.Name = "Dtfromdate";
            this.Dtfromdate.Size = new System.Drawing.Size(121, 25);
            this.Dtfromdate.TabIndex = 9;
            // 
            // gridmain
            // 
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
            this.clnitemname,
            this.clnbatch,
            this.clnexpiry,
            this.clnmandate,
            this.clnrack,
            this.clnstock});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 58);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.ReadOnly = true;
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(940, 405);
            this.gridmain.TabIndex = 2;
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 52.23298F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.ReadOnly = true;
            this.clnitemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnitemname.Width = 300;
            // 
            // clnbatch
            // 
            this.clnbatch.FillWeight = 34.82199F;
            this.clnbatch.HeaderText = "Batch Code";
            this.clnbatch.Name = "clnbatch";
            this.clnbatch.ReadOnly = true;
            this.clnbatch.Width = 200;
            // 
            // clnexpiry
            // 
            this.clnexpiry.FillWeight = 83.4272F;
            this.clnexpiry.HeaderText = "Ex.Date";
            this.clnexpiry.Name = "clnexpiry";
            this.clnexpiry.ReadOnly = true;
            this.clnexpiry.Width = 120;
            // 
            // clnmandate
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.clnmandate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnmandate.FillWeight = 109.2893F;
            this.clnmandate.HeaderText = "Man.Date";
            this.clnmandate.Name = "clnmandate";
            this.clnmandate.ReadOnly = true;
            this.clnmandate.Width = 120;
            // 
            // clnrack
            // 
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clnrack.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnrack.FillWeight = 41.78639F;
            this.clnrack.HeaderText = "Rack";
            this.clnrack.Name = "clnrack";
            this.clnrack.ReadOnly = true;
            // 
            // clnstock
            // 
            this.clnstock.FillWeight = 37.27533F;
            this.clnstock.HeaderText = "Stock";
            this.clnstock.Name = "clnstock";
            this.clnstock.ReadOnly = true;
            this.clnstock.Width = 90;
            // 
            // Frmexpiryreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 463);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.pnltop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmexpiryreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expiry Stock Report";
            this.Load += new System.EventHandler(this.Frmexpiryreport_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dttodate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtfromdate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.Button cmdsearch;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnexpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmandate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnstock;
    }
}