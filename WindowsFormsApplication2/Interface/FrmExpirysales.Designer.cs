namespace WindowsFormsApplication2
{
    partial class FrmExpirysales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpirysales));
            this.PnlExpire = new System.Windows.Forms.Panel();
            this.GridExDate = new System.Windows.Forms.DataGridView();
            this.ClnExDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlExpire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridExDate)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlExpire
            // 
            this.PnlExpire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.PnlExpire.Controls.Add(this.GridExDate);
            this.PnlExpire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlExpire.Location = new System.Drawing.Point(0, 0);
            this.PnlExpire.Name = "PnlExpire";
            this.PnlExpire.Size = new System.Drawing.Size(284, 262);
            this.PnlExpire.TabIndex = 123;
            this.PnlExpire.Visible = false;
            // 
            // GridExDate
            // 
            this.GridExDate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridExDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridExDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridExDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridExDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridExDate.ColumnHeadersHeight = 31;
            this.GridExDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnExDate,
            this.Clnrate});
            this.GridExDate.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridExDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridExDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridExDate.EnableHeadersVisualStyles = false;
            this.GridExDate.Location = new System.Drawing.Point(0, 0);
            this.GridExDate.MultiSelect = false;
            this.GridExDate.Name = "GridExDate";
            this.GridExDate.ReadOnly = true;
            this.GridExDate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridExDate.RowHeadersVisible = false;
            this.GridExDate.RowHeadersWidth = 100;
            this.GridExDate.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridExDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridExDate.Size = new System.Drawing.Size(284, 262);
            this.GridExDate.TabIndex = 150;
            this.GridExDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridExDate_MouseDoubleClick);
            // 
            // ClnExDate
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.ClnExDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClnExDate.FillWeight = 120F;
            this.ClnExDate.HeaderText = "Ex.Date";
            this.ClnExDate.Name = "ClnExDate";
            this.ClnExDate.ReadOnly = true;
            this.ClnExDate.Width = 120;
            // 
            // Clnrate
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            this.Clnrate.DefaultCellStyle = dataGridViewCellStyle4;
            this.Clnrate.HeaderText = "Srate";
            this.Clnrate.Name = "Clnrate";
            this.Clnrate.ReadOnly = true;
            // 
            // FrmExpirysales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PnlExpire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExpirysales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expiry List";
            this.Load += new System.EventHandler(this.FrmExpirysales_Load);
            this.PnlExpire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridExDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlExpire;
        public System.Windows.Forms.DataGridView GridExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnExDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clnrate;
    }
}