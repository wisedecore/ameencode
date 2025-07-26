namespace WindowsFormsApplication2
{
    partial class Frmpriceupdater
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
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdupdatesarebaseonsize = new System.Windows.Forms.Button();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(3, 553);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(872, 3);
            this.pnlbottom.TabIndex = 147;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(3, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(872, 3);
            this.pnltop.TabIndex = 146;
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(875, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(3, 556);
            this.pnlright.TabIndex = 145;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(3, 556);
            this.pnlleft.TabIndex = 144;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 39);
            this.panel1.TabIndex = 149;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(127, 8);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(238, 25);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(109, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 111;
            this.label12.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 110;
            this.label10.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.cmdupdatesarebaseonsize);
            this.panel2.Controls.Add(this.cmdupdate);
            this.panel2.Controls.Add(this.cmdprint);
            this.panel2.Controls.Add(this.cmdclose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 46);
            this.panel2.TabIndex = 150;
            // 
            // cmdupdatesarebaseonsize
            // 
            this.cmdupdatesarebaseonsize.Location = new System.Drawing.Point(3, 20);
            this.cmdupdatesarebaseonsize.Name = "cmdupdatesarebaseonsize";
            this.cmdupdatesarebaseonsize.Size = new System.Drawing.Size(108, 23);
            this.cmdupdatesarebaseonsize.TabIndex = 113;
            this.cmdupdatesarebaseonsize.Text = "Update Srate Base on Size";
            this.cmdupdatesarebaseonsize.UseVisualStyleBackColor = true;
            this.cmdupdatesarebaseonsize.Click += new System.EventHandler(this.cmdupdatesarebaseonsize_Click);
            // 
            // cmdupdate
            // 
            this.cmdupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdupdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdupdate.FlatAppearance.BorderSize = 0;
            this.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdate.ForeColor = System.Drawing.Color.Black;
            this.cmdupdate.Location = new System.Drawing.Point(647, 0);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(75, 46);
            this.cmdupdate.TabIndex = 34;
            this.cmdupdate.Text = "Update";
            this.cmdupdate.UseVisualStyleBackColor = false;
            this.cmdupdate.Click += new System.EventHandler(this.cmdupdate_Click);
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdprint.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatAppearance.BorderSize = 0;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(722, 0);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(75, 46);
            this.cmdprint.TabIndex = 33;
            this.cmdprint.Text = "Clear";
            this.cmdprint.UseVisualStyleBackColor = false;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatAppearance.BorderSize = 0;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(797, 0);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 46);
            this.cmdclose.TabIndex = 32;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(3, 42);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
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
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(872, 465);
            this.gridmain.TabIndex = 2;
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // Frmpriceupdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 556);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmpriceupdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price updater";
            this.Load += new System.EventHandler(this.Frmpriceupdater_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmpriceupdater_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdclose;
        public System.Windows.Forms.DataGridView gridmain;
        public System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button cmdupdatesarebaseonsize;
    }
}