namespace WindowsFormsApplication2
{
    partial class Frmsearchitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsearchitems));
            this.pnltop = new System.Windows.Forms.Panel();
            this.Cmdshowallitem = new System.Windows.Forms.Button();
            this.cmdexcel = new System.Windows.Forms.Button();
            this.Chkitemnamelist = new System.Windows.Forms.CheckBox();
            this.chkallstockarea = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comstockarea = new System.Windows.Forms.ComboBox();
            this.chkshowprate = new System.Windows.Forms.CheckBox();
            this.txtsearch = new WindowsFormsApplication2.Uscnormaltextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkanykeysearch = new System.Windows.Forms.CheckBox();
            this.GridProductShow = new System.Windows.Forms.DataGridView();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.Cmdshowallitem);
            this.pnltop.Controls.Add(this.cmdexcel);
            this.pnltop.Controls.Add(this.Chkitemnamelist);
            this.pnltop.Controls.Add(this.chkallstockarea);
            this.pnltop.Controls.Add(this.label2);
            this.pnltop.Controls.Add(this.comstockarea);
            this.pnltop.Controls.Add(this.chkshowprate);
            this.pnltop.Controls.Add(this.txtsearch);
            this.pnltop.Controls.Add(this.label1);
            this.pnltop.Controls.Add(this.chkanykeysearch);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1098, 63);
            this.pnltop.TabIndex = 0;
            // 
            // Cmdshowallitem
            // 
            this.Cmdshowallitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.Cmdshowallitem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmdshowallitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmdshowallitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdshowallitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cmdshowallitem.Location = new System.Drawing.Point(864, 32);
            this.Cmdshowallitem.Name = "Cmdshowallitem";
            this.Cmdshowallitem.Size = new System.Drawing.Size(191, 25);
            this.Cmdshowallitem.TabIndex = 127;
            this.Cmdshowallitem.Text = "Show All item(إظهار جميع العناصر)";
            this.Cmdshowallitem.UseVisualStyleBackColor = false;
            this.Cmdshowallitem.Click += new System.EventHandler(this.Cmdshowallitem_Click);
            // 
            // cmdexcel
            // 
            this.cmdexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.cmdexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdexcel.Location = new System.Drawing.Point(519, 11);
            this.cmdexcel.Name = "cmdexcel";
            this.cmdexcel.Size = new System.Drawing.Size(151, 33);
            this.cmdexcel.TabIndex = 126;
            this.cmdexcel.Text = "Excel (تفوق)";
            this.cmdexcel.UseVisualStyleBackColor = false;
            this.cmdexcel.Click += new System.EventHandler(this.cmdexcel_Click);
            // 
            // Chkitemnamelist
            // 
            this.Chkitemnamelist.AutoSize = true;
            this.Chkitemnamelist.Location = new System.Drawing.Point(676, 12);
            this.Chkitemnamelist.Name = "Chkitemnamelist";
            this.Chkitemnamelist.Size = new System.Drawing.Size(120, 17);
            this.Chkitemnamelist.TabIndex = 125;
            this.Chkitemnamelist.Text = "Item List (قائمة البند)";
            this.Chkitemnamelist.UseVisualStyleBackColor = true;
            // 
            // chkallstockarea
            // 
            this.chkallstockarea.AutoSize = true;
            this.chkallstockarea.Location = new System.Drawing.Point(420, 11);
            this.chkallstockarea.Name = "chkallstockarea";
            this.chkallstockarea.Size = new System.Drawing.Size(66, 17);
            this.chkallstockarea.TabIndex = 124;
            this.chkallstockarea.Text = "All (الكل)";
            this.chkallstockarea.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 123;
            this.label2.Text = "Stock Area (انزل)";
            // 
            // comstockarea
            // 
            this.comstockarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comstockarea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comstockarea.FormattingEnabled = true;
            this.comstockarea.Location = new System.Drawing.Point(163, 7);
            this.comstockarea.Name = "comstockarea";
            this.comstockarea.Size = new System.Drawing.Size(250, 25);
            this.comstockarea.TabIndex = 122;
            this.comstockarea.SelectedIndexChanged += new System.EventHandler(this.comstockarea_SelectedIndexChanged);
            // 
            // chkshowprate
            // 
            this.chkshowprate.AutoSize = true;
            this.chkshowprate.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkshowprate.Location = new System.Drawing.Point(1083, 0);
            this.chkshowprate.Name = "chkshowprate";
            this.chkshowprate.Size = new System.Drawing.Size(15, 63);
            this.chkshowprate.TabIndex = 121;
            this.chkshowprate.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(163, 35);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(322, 22);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtsearch_TextChanged);
            this.txtsearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtsearch_PreviewKeyDown);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search (بحث)";
            // 
            // chkanykeysearch
            // 
            this.chkanykeysearch.AutoSize = true;
            this.chkanykeysearch.Checked = true;
            this.chkanykeysearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkanykeysearch.Location = new System.Drawing.Point(676, 35);
            this.chkanykeysearch.Name = "chkanykeysearch";
            this.chkanykeysearch.Size = new System.Drawing.Size(182, 17);
            this.chkanykeysearch.TabIndex = 0;
            this.chkanykeysearch.Text = "Any key Search (أي بحث رئيسي)";
            this.chkanykeysearch.UseVisualStyleBackColor = true;
            // 
            // GridProductShow
            // 
            this.GridProductShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProductShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProductShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridProductShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProductShow.EnableHeadersVisualStyles = false;
            this.GridProductShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridProductShow.Location = new System.Drawing.Point(0, 63);
            this.GridProductShow.Name = "GridProductShow";
            this.GridProductShow.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProductShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridProductShow.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridProductShow.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProductShow.Size = new System.Drawing.Size(1098, 464);
            this.GridProductShow.TabIndex = 118;
            this.GridProductShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductShow_CellDoubleClick);
            // 
            // Frmsearchitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 527);
            this.Controls.Add(this.GridProductShow);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frmsearchitems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsearchitems_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmsearchitems_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmsearchitems_PreviewKeyDown);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.CheckBox chkanykeysearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView GridProductShow;
        private Uscnormaltextbox txtsearch;
        private System.Windows.Forms.CheckBox chkshowprate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comstockarea;
        private System.Windows.Forms.CheckBox chkallstockarea;
        private System.Windows.Forms.CheckBox Chkitemnamelist;
        private System.Windows.Forms.Button cmdexcel;
        private System.Windows.Forms.Button Cmdshowallitem;
    }
}