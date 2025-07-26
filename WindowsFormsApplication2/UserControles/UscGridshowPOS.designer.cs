namespace WindowsFormsApplication2
{
    partial class UscGridshowPOS
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

        #region Component Designer generated code

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
            this.lblstocklabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdedit = new System.Windows.Forms.Button();
            this.cmdnew = new System.Windows.Forms.Button();
            this.GridProductShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstocklabel
            // 
            this.lblstocklabel.AutoSize = true;
            this.lblstocklabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblstocklabel.ForeColor = System.Drawing.Color.White;
            this.lblstocklabel.Location = new System.Drawing.Point(673, 6);
            this.lblstocklabel.Name = "lblstocklabel";
            this.lblstocklabel.Size = new System.Drawing.Size(42, 19);
            this.lblstocklabel.TabIndex = 109;
            this.lblstocklabel.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(719, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 19);
            this.label1.TabIndex = 110;
            this.label1.Text = ":";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblstock.ForeColor = System.Drawing.Color.White;
            this.lblstock.Location = new System.Drawing.Point(737, 6);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(36, 19);
            this.lblstock.TabIndex = 111;
            this.lblstock.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblstock);
            this.panel1.Controls.Add(this.lblstocklabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 28);
            this.panel1.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 10);
            this.panel2.TabIndex = 113;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 290);
            this.panel3.TabIndex = 114;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmdedit);
            this.panel4.Controls.Add(this.cmdnew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(723, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(69, 290);
            this.panel4.TabIndex = 115;
            // 
            // cmdedit
            // 
            this.cmdedit.Location = new System.Drawing.Point(1, 29);
            this.cmdedit.Name = "cmdedit";
            this.cmdedit.Size = new System.Drawing.Size(66, 23);
            this.cmdedit.TabIndex = 1;
            this.cmdedit.Text = "Edit";
            this.cmdedit.UseVisualStyleBackColor = true;
            this.cmdedit.Click += new System.EventHandler(this.cmdedit_Click);
            // 
            // cmdnew
            // 
            this.cmdnew.Location = new System.Drawing.Point(0, 6);
            this.cmdnew.Name = "cmdnew";
            this.cmdnew.Size = new System.Drawing.Size(66, 23);
            this.cmdnew.TabIndex = 0;
            this.cmdnew.Text = "New Item";
            this.cmdnew.UseVisualStyleBackColor = true;
            this.cmdnew.Click += new System.EventHandler(this.cmdnew_Click);
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
            this.GridProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProductShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridProductShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProductShow.EnableHeadersVisualStyles = false;
            this.GridProductShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridProductShow.Location = new System.Drawing.Point(5, 28);
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
            this.GridProductShow.Size = new System.Drawing.Size(718, 290);
            this.GridProductShow.TabIndex = 117;
            this.GridProductShow.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductShow_RowEnter);
            this.GridProductShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductShow_CellDoubleClick);
            this.GridProductShow.DoubleClick += new System.EventHandler(this.GridProductShow_DoubleClick);
            this.GridProductShow.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GridProductShow_PreviewKeyDown);
            this.GridProductShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridProductShow_KeyDown);
            this.GridProductShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridProductShow_KeyPress);
            this.GridProductShow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridProductShow_KeyUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // UscGridshowPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.Controls.Add(this.GridProductShow);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UscGridshowPOS";
            this.Size = new System.Drawing.Size(792, 328);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UscGridshow_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UscGridshow_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProductShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblstocklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView GridProductShow;
        public System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Button cmdnew;
        private System.Windows.Forms.Button cmdedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
