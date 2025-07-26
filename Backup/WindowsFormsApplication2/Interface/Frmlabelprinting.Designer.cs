namespace WindowsFormsApplication2
{
    partial class Frmlabelprinting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlabelprinting));
            this.comvno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlprintsettings = new System.Windows.Forms.Panel();
            this.cmdpnlsettingsclose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdadprint = new System.Windows.Forms.Button();
            this.comprint = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemnote1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemnote2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStartingRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdprint = new System.Windows.Forms.Button();
            this.txtstartingColumn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barCodeCtrl1 = new DSBarCode.BarCodeCtrl();
            this.Picrupee = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlprintsettings.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picrupee)).BeginInit();
            this.SuspendLayout();
            // 
            // comvno
            // 
            this.comvno.FormattingEnabled = true;
            this.comvno.Location = new System.Drawing.Point(97, 14);
            this.comvno.Name = "comvno";
            this.comvno.Size = new System.Drawing.Size(121, 21);
            this.comvno.TabIndex = 0;
            this.comvno.SelectedIndexChanged += new System.EventHandler(this.comvno_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Vno";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlprintsettings);
            this.panel1.Controls.Add(this.gridmain);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 314);
            this.panel1.TabIndex = 30;
            // 
            // pnlprintsettings
            // 
            this.pnlprintsettings.Controls.Add(this.cmdpnlsettingsclose);
            this.pnlprintsettings.Controls.Add(this.panel2);
            this.pnlprintsettings.Controls.Add(this.label26);
            this.pnlprintsettings.Location = new System.Drawing.Point(227, 46);
            this.pnlprintsettings.Name = "pnlprintsettings";
            this.pnlprintsettings.Size = new System.Drawing.Size(355, 222);
            this.pnlprintsettings.TabIndex = 164;
            this.pnlprintsettings.Visible = false;
            // 
            // cmdpnlsettingsclose
            // 
            this.cmdpnlsettingsclose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdpnlsettingsclose.ForeColor = System.Drawing.Color.Black;
            this.cmdpnlsettingsclose.Location = new System.Drawing.Point(296, 7);
            this.cmdpnlsettingsclose.Name = "cmdpnlsettingsclose";
            this.cmdpnlsettingsclose.Size = new System.Drawing.Size(56, 23);
            this.cmdpnlsettingsclose.TabIndex = 146;
            this.cmdpnlsettingsclose.Text = "Close";
            this.cmdpnlsettingsclose.UseVisualStyleBackColor = true;
            this.cmdpnlsettingsclose.Click += new System.EventHandler(this.cmdpnlsettingsclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.cmdadprint);
            this.panel2.Controls.Add(this.comprint);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(27, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 149);
            this.panel2.TabIndex = 45;
            // 
            // cmdadprint
            // 
            this.cmdadprint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdadprint.ForeColor = System.Drawing.Color.Black;
            this.cmdadprint.Location = new System.Drawing.Point(90, 62);
            this.cmdadprint.Name = "cmdadprint";
            this.cmdadprint.Size = new System.Drawing.Size(80, 35);
            this.cmdadprint.TabIndex = 145;
            this.cmdadprint.Text = "Print";
            this.cmdadprint.UseVisualStyleBackColor = true;
            this.cmdadprint.Click += new System.EventHandler(this.cmdadprint_Click);
            // 
            // comprint
            // 
            this.comprint.FormattingEnabled = true;
            this.comprint.Location = new System.Drawing.Point(26, 35);
            this.comprint.Name = "comprint";
            this.comprint.Size = new System.Drawing.Size(214, 21);
            this.comprint.TabIndex = 140;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(128, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Print Settings";
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
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnbatch,
            this.clnitemcode,
            this.clnitemname,
            this.clnno,
            this.clnqty,
            this.ClnMRP,
            this.clnsrate,
            this.clnitemnote,
            this.clnitemnote1,
            this.clnitemnote2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(6, 37);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(800, 243);
            this.gridmain.TabIndex = 2;
            // 
            // clnbatch
            // 
            this.clnbatch.HeaderText = "BatchCode";
            this.clnbatch.Name = "clnbatch";
            // 
            // clnitemcode
            // 
            this.clnitemcode.FillWeight = 140.1275F;
            this.clnitemcode.HeaderText = "Itemcode";
            this.clnitemcode.Name = "clnitemcode";
            this.clnitemcode.ReadOnly = true;
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 140.1275F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.ReadOnly = true;
            this.clnitemname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clnno
            // 
            this.clnno.HeaderText = "No";
            this.clnno.Name = "clnno";
            // 
            // clnqty
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.clnqty.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnqty.FillWeight = 65.39285F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // ClnMRP
            // 
            dataGridViewCellStyle4.NullValue = "0.00";
            this.ClnMRP.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClnMRP.FillWeight = 65.39285F;
            this.ClnMRP.HeaderText = "MRP";
            this.ClnMRP.Name = "ClnMRP";
            this.ClnMRP.ReadOnly = true;
            // 
            // clnsrate
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "0.00";
            this.clnsrate.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnsrate.FillWeight = 93.41834F;
            this.clnsrate.HeaderText = "S.Rate";
            this.clnsrate.Name = "clnsrate";
            // 
            // clnitemnote
            // 
            this.clnitemnote.HeaderText = "Column1";
            this.clnitemnote.Name = "clnitemnote";
            // 
            // clnitemnote1
            // 
            this.clnitemnote1.HeaderText = "Column1";
            this.clnitemnote1.Name = "clnitemnote1";
            // 
            // clnitemnote2
            // 
            this.clnitemnote2.HeaderText = "Column1";
            this.clnitemnote2.Name = "clnitemnote2";
            this.clnitemnote2.Visible = false;
            // 
            // txtStartingRow
            // 
            this.txtStartingRow.Location = new System.Drawing.Point(827, 118);
            this.txtStartingRow.Name = "txtStartingRow";
            this.txtStartingRow.Size = new System.Drawing.Size(100, 20);
            this.txtStartingRow.TabIndex = 31;
            this.txtStartingRow.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(827, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Starting Row";
            // 
            // cmdprint
            // 
            this.cmdprint.Location = new System.Drawing.Point(827, 200);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(100, 23);
            this.cmdprint.TabIndex = 34;
            this.cmdprint.Text = "Print";
            this.cmdprint.UseVisualStyleBackColor = true;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click);
            // 
            // txtstartingColumn
            // 
            this.txtstartingColumn.Location = new System.Drawing.Point(827, 158);
            this.txtstartingColumn.Name = "txtstartingColumn";
            this.txtstartingColumn.Size = new System.Drawing.Size(100, 20);
            this.txtstartingColumn.TabIndex = 35;
            this.txtstartingColumn.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(828, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Starting Column";
            // 
            // barCodeCtrl1
            // 
            this.barCodeCtrl1.BarCode = "1234567890";
            this.barCodeCtrl1.BarCodeHeight = 50;
            this.barCodeCtrl1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barCodeCtrl1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barCodeCtrl1.HeaderText = "BarCode Demo";
            this.barCodeCtrl1.LeftMargin = 10;
            this.barCodeCtrl1.Location = new System.Drawing.Point(890, 39);
            this.barCodeCtrl1.Name = "barCodeCtrl1";
            this.barCodeCtrl1.ShowFooter = false;
            this.barCodeCtrl1.ShowHeader = false;
            this.barCodeCtrl1.Size = new System.Drawing.Size(10, 14);
            this.barCodeCtrl1.TabIndex = 37;
            this.barCodeCtrl1.TopMargin = 10;
            this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
            this.barCodeCtrl1.Visible = false;
            this.barCodeCtrl1.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // Picrupee
            // 
            this.Picrupee.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Rupee;
            this.Picrupee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picrupee.Location = new System.Drawing.Point(889, 21);
            this.Picrupee.Name = "Picrupee";
            this.Picrupee.Size = new System.Drawing.Size(11, 11);
            this.Picrupee.TabIndex = 135;
            this.Picrupee.TabStop = false;
            this.Picrupee.Visible = false;
            // 
            // Frmlabelprinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 404);
            this.Controls.Add(this.Picrupee);
            this.Controls.Add(this.barCodeCtrl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstartingColumn);
            this.Controls.Add(this.cmdprint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartingRow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comvno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmlabelprinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Sheet Printing";
            this.Load += new System.EventHandler(this.Frmlabelprinting_Load);
            this.panel1.ResumeLayout(false);
            this.pnlprintsettings.ResumeLayout(false);
            this.pnlprintsettings.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picrupee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comvno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.TextBox txtStartingRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.TextBox txtstartingColumn;
        private System.Windows.Forms.Label label3;
        private DSBarCode.BarCodeCtrl barCodeCtrl1;
        private System.Windows.Forms.PictureBox Picrupee;
        private System.Windows.Forms.Panel pnlprintsettings;
        private System.Windows.Forms.Button cmdpnlsettingsclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdadprint;
        private System.Windows.Forms.ComboBox comprint;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnMRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemnote1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemnote2;
    }
}