namespace WindowsFormsApplication2
{
    partial class frmreorderreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreorderreport));
            this.Pnltop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GridMain = new System.Windows.Forms.DataGridView();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.txtsupplier = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtitemname = new WindowsFormsApplication2.Uscnormaltextbox();
            this.cmdclear = new System.Windows.Forms.Button();
            this.Pnltop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnltop
            // 
            this.Pnltop.Controls.Add(this.panel2);
            this.Pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnltop.Location = new System.Drawing.Point(0, 0);
            this.Pnltop.Name = "Pnltop";
            this.Pnltop.Size = new System.Drawing.Size(818, 60);
            this.Pnltop.TabIndex = 151;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdclear);
            this.panel2.Controls.Add(this.cmdclose);
            this.panel2.Controls.Add(this.cmdsave);
            this.panel2.Controls.Add(this.txtsupplier);
            this.panel2.Controls.Add(this.txtitemname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(-189, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 60);
            this.panel2.TabIndex = 156;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatAppearance.BorderSize = 0;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(781, 13);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 41);
            this.cmdclose.TabIndex = 151;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatAppearance.BorderSize = 0;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(595, 12);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 41);
            this.cmdsave.TabIndex = 150;
            this.cmdsave.Text = "Show";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Item Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Supplier";
            // 
            // GridMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMain.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMain.EnableHeadersVisualStyles = false;
            this.GridMain.Location = new System.Drawing.Point(0, 60);
            this.GridMain.MultiSelect = false;
            this.GridMain.Name = "GridMain";
            this.GridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMain.RowHeadersVisible = false;
            this.GridMain.RowHeadersWidth = 100;
            this.GridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridMain.Size = new System.Drawing.Size(818, 633);
            this.GridMain.TabIndex = 152;
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.BackColor = System.Drawing.Color.LavenderBlush;
            this.uscitemshowsimple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(406, 83);
            this.uscitemshowsimple2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(289, 180);
            this.uscitemshowsimple2.TabIndex = 199;
            this.uscitemshowsimple2.Visible = false;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(201, 35);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(356, 22);
            this.txtsupplier.TabIndex = 153;
            this.txtsupplier.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtsupplier_TextChanged);
            this.txtsupplier.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtsupplier_PreviewKeyDown);
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(201, 12);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(356, 22);
            this.txtitemname.TabIndex = 152;
            this.txtitemname.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtitemname_TextChanged);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatAppearance.BorderSize = 0;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(688, 13);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 41);
            this.cmdclear.TabIndex = 154;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click_1);
            // 
            // frmreorderreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 693);
            this.Controls.Add(this.uscitemshowsimple2);
            this.Controls.Add(this.GridMain);
            this.Controls.Add(this.Pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmreorderreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reorder Report";
            this.Load += new System.EventHandler(this.frmreorderreport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmreorderreport_KeyPress);
            this.Pnltop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnltop;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Uscnormaltextbox txtsupplier;
        private Uscnormaltextbox txtitemname;
        public System.Windows.Forms.DataGridView GridMain;
        public Uscitemshowsimple uscitemshowsimple2;
        private System.Windows.Forms.Button cmdclear;




    }
}