namespace WindowsFormsApplication2
{
    partial class Frmreport2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmreport2));
            this.Pnltop = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.comprint = new System.Windows.Forms.ComboBox();
            this.ChkShowPreview = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMDAFOUR = new System.Windows.Forms.Button();
            this.cmdexcelimp = new System.Windows.Forms.Button();
            this.chktotsqty = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmdexporttopdf = new System.Windows.Forms.Button();
            this.Cmdexporttoexcel = new System.Windows.Forms.Button();
            this.cmdrefresh = new System.Windows.Forms.Button();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdprint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridMain = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnltop
            // 
            this.Pnltop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pnltop.Controls.Add(this.label26);
            this.Pnltop.Controls.Add(this.comprint);
            this.Pnltop.Controls.Add(this.ChkShowPreview);
            this.Pnltop.Controls.Add(this.label5);
            this.Pnltop.Controls.Add(this.CMDAFOUR);
            this.Pnltop.Controls.Add(this.cmdexcelimp);
            this.Pnltop.Controls.Add(this.chktotsqty);
            this.Pnltop.Controls.Add(this.label4);
            this.Pnltop.Controls.Add(this.label2);
            this.Pnltop.Controls.Add(this.Cmdexporttopdf);
            this.Pnltop.Controls.Add(this.Cmdexporttoexcel);
            this.Pnltop.Controls.Add(this.cmdrefresh);
            this.Pnltop.Controls.Add(this.DtTo);
            this.Pnltop.Controls.Add(this.label1);
            this.Pnltop.Controls.Add(this.DtFrom);
            this.Pnltop.Controls.Add(this.label3);
            this.Pnltop.Controls.Add(this.cmdprint);
            this.Pnltop.Controls.Add(this.pictureBox1);
            this.Pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnltop.Location = new System.Drawing.Point(0, 0);
            this.Pnltop.Name = "Pnltop";
            this.Pnltop.Size = new System.Drawing.Size(893, 103);
            this.Pnltop.TabIndex = 0;
            this.Pnltop.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnltop_Paint);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(8, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 14);
            this.label26.TabIndex = 179;
            this.label26.Text = "Printer";
            // 
            // comprint
            // 
            this.comprint.BackColor = System.Drawing.Color.White;
            this.comprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprint.Font = new System.Drawing.Font("Eras Medium ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprint.ForeColor = System.Drawing.Color.Blue;
            this.comprint.FormattingEnabled = true;
            this.comprint.Location = new System.Drawing.Point(3, 80);
            this.comprint.Name = "comprint";
            this.comprint.Size = new System.Drawing.Size(187, 22);
            this.comprint.TabIndex = 178;
            // 
            // ChkShowPreview
            // 
            this.ChkShowPreview.AutoSize = true;
            this.ChkShowPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChkShowPreview.Checked = true;
            this.ChkShowPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkShowPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowPreview.ForeColor = System.Drawing.Color.Black;
            this.ChkShowPreview.Location = new System.Drawing.Point(128, 15);
            this.ChkShowPreview.Name = "ChkShowPreview";
            this.ChkShowPreview.Size = new System.Drawing.Size(66, 17);
            this.ChkShowPreview.TabIndex = 177;
            this.ChkShowPreview.Text = "Preview";
            this.ChkShowPreview.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 14);
            this.label5.TabIndex = 176;
            this.label5.Text = "Print     model";
            // 
            // CMDAFOUR
            // 
            this.CMDAFOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CMDAFOUR.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDAFOUR.ForeColor = System.Drawing.Color.Black;
            this.CMDAFOUR.Location = new System.Drawing.Point(11, 39);
            this.CMDAFOUR.Name = "CMDAFOUR";
            this.CMDAFOUR.Size = new System.Drawing.Size(111, 27);
            this.CMDAFOUR.TabIndex = 175;
            this.CMDAFOUR.Text = "A4";
            this.CMDAFOUR.UseVisualStyleBackColor = false;
            this.CMDAFOUR.Click += new System.EventHandler(this.CMDAFOUR_Click);
            // 
            // cmdexcelimp
            // 
            this.cmdexcelimp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdexcelimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexcelimp.Location = new System.Drawing.Point(292, 9);
            this.cmdexcelimp.Name = "cmdexcelimp";
            this.cmdexcelimp.Size = new System.Drawing.Size(61, 51);
            this.cmdexcelimp.TabIndex = 174;
            this.cmdexcelimp.Text = " Excel";
            this.cmdexcelimp.UseVisualStyleBackColor = false;
            this.cmdexcelimp.Click += new System.EventHandler(this.cmdexcelimp_Click);
            // 
            // chktotsqty
            // 
            this.chktotsqty.AutoSize = true;
            this.chktotsqty.BackColor = System.Drawing.Color.White;
            this.chktotsqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktotsqty.Location = new System.Drawing.Point(562, 23);
            this.chktotsqty.Name = "chktotsqty";
            this.chktotsqty.Size = new System.Drawing.Size(15, 14);
            this.chktotsqty.TabIndex = 173;
            this.chktotsqty.UseVisualStyleBackColor = false;
            this.chktotsqty.CheckedChanged += new System.EventHandler(this.chktotsqty_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 172;
            this.label4.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 171;
            this.label2.Text = "Sale.Qty";
            // 
            // Cmdexporttopdf
            // 
            this.Cmdexporttopdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cmdexporttopdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdexporttopdf.Location = new System.Drawing.Point(450, 11);
            this.Cmdexporttopdf.Name = "Cmdexporttopdf";
            this.Cmdexporttopdf.Size = new System.Drawing.Size(102, 48);
            this.Cmdexporttopdf.TabIndex = 168;
            this.Cmdexporttopdf.Text = "Export to PDF";
            this.Cmdexporttopdf.UseVisualStyleBackColor = false;
            this.Cmdexporttopdf.Visible = false;
            this.Cmdexporttopdf.Click += new System.EventHandler(this.Cmdexporttopdf_Click);
            // 
            // Cmdexporttoexcel
            // 
            this.Cmdexporttoexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cmdexporttoexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdexporttoexcel.Location = new System.Drawing.Point(359, 11);
            this.Cmdexporttoexcel.Name = "Cmdexporttoexcel";
            this.Cmdexporttoexcel.Size = new System.Drawing.Size(85, 48);
            this.Cmdexporttoexcel.TabIndex = 167;
            this.Cmdexporttoexcel.Text = " Excel csv";
            this.Cmdexporttoexcel.UseVisualStyleBackColor = false;
            this.Cmdexporttoexcel.Click += new System.EventHandler(this.Cmdexporttoexcel_Click);
            // 
            // cmdrefresh
            // 
            this.cmdrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdrefresh.Location = new System.Drawing.Point(200, 10);
            this.cmdrefresh.Name = "cmdrefresh";
            this.cmdrefresh.Size = new System.Drawing.Size(87, 51);
            this.cmdrefresh.TabIndex = 166;
            this.cmdrefresh.Text = "Refresh";
            this.cmdrefresh.UseVisualStyleBackColor = false;
            this.cmdrefresh.Click += new System.EventHandler(this.cmdrefresh_Click);
            // 
            // DtTo
            // 
            this.DtTo.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtTo.Location = new System.Drawing.Point(717, 35);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(163, 20);
            this.DtTo.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(664, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 164;
            this.label1.Text = "To";
            // 
            // DtFrom
            // 
            this.DtFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFrom.Location = new System.Drawing.Point(717, 9);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(163, 20);
            this.DtFrom.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(664, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 162;
            this.label3.Text = "From";
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdprint.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.Location = new System.Drawing.Point(11, 13);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(111, 25);
            this.cmdprint.TabIndex = 0;
            this.cmdprint.Text = "Thermal";
            this.cmdprint.UseVisualStyleBackColor = false;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(558, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 46);
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GridMain
            // 
            this.GridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumVioletRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMain.EnableHeadersVisualStyles = false;
            this.GridMain.GridColor = System.Drawing.Color.Silver;
            this.GridMain.Location = new System.Drawing.Point(0, 103);
            this.GridMain.Name = "GridMain";
            this.GridMain.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridMain.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DeepPink;
            this.GridMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMain.Size = new System.Drawing.Size(893, 392);
            this.GridMain.TabIndex = 119;
            this.GridMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridMain_MouseDoubleClick);
            this.GridMain.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMain_RowHeaderMouseDoubleClick);
            this.GridMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMain_CellMouseDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // Frmreport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 495);
            this.Controls.Add(this.GridMain);
            this.Controls.Add(this.Pnltop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmreport2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Frmreport2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmreport2_KeyPress);
            this.Pnltop.ResumeLayout(false);
            this.Pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnltop;
        public System.Windows.Forms.DataGridView GridMain;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdrefresh;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cmdexporttoexcel;
        private System.Windows.Forms.Button Cmdexporttopdf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chktotsqty;
        private System.Windows.Forms.Button cmdexcelimp;
        private System.Windows.Forms.Button CMDAFOUR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkShowPreview;
        private System.Windows.Forms.ComboBox comprint;
        private System.Windows.Forms.Label label26;
    }
}