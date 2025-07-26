namespace WindowsFormsApplication2
{
    partial class FrmSelectBillWiseSettlementReport
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
            this.PnlTop = new System.Windows.Forms.Panel();
            this.ComSelectReport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkAllAccount = new System.Windows.Forms.CheckBox();
            this.CmdShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComArea = new System.Windows.Forms.ComboBox();
            this.ChkAllArea = new System.Windows.Forms.CheckBox();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.GridAccount = new System.Windows.Forms.DataGridView();
            this.ClnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PnlTop.Controls.Add(this.ComSelectReport);
            this.PnlTop.Controls.Add(this.label1);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(669, 49);
            this.PnlTop.TabIndex = 0;
            // 
            // ComSelectReport
            // 
            this.ComSelectReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSelectReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComSelectReport.FormattingEnabled = true;
            this.ComSelectReport.Items.AddRange(new object[] {
            "Sales Bill Wise Report"});
            this.ComSelectReport.Location = new System.Drawing.Point(208, 16);
            this.ComSelectReport.Name = "ComSelectReport";
            this.ComSelectReport.Size = new System.Drawing.Size(198, 25);
            this.ComSelectReport.TabIndex = 1;
            this.ComSelectReport.SelectedIndexChanged += new System.EventHandler(this.ComSelectReport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Report Of ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // ChkAllAccount
            // 
            this.ChkAllAccount.AutoSize = true;
            this.ChkAllAccount.Location = new System.Drawing.Point(390, 68);
            this.ChkAllAccount.Name = "ChkAllAccount";
            this.ChkAllAccount.Size = new System.Drawing.Size(41, 21);
            this.ChkAllAccount.TabIndex = 3;
            this.ChkAllAccount.Text = "All";
            this.ChkAllAccount.UseVisualStyleBackColor = true;
            this.ChkAllAccount.CheckedChanged += new System.EventHandler(this.ChkAllAccount_CheckedChanged);
            // 
            // CmdShow
            // 
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Location = new System.Drawing.Point(312, 129);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 32);
            this.CmdShow.TabIndex = 4;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area";
            // 
            // ComArea
            // 
            this.ComArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ComArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComArea.FormattingEnabled = true;
            this.ComArea.Location = new System.Drawing.Point(95, 98);
            this.ComArea.Name = "ComArea";
            this.ComArea.Size = new System.Drawing.Size(292, 25);
            this.ComArea.TabIndex = 6;
            // 
            // ChkAllArea
            // 
            this.ChkAllArea.AutoSize = true;
            this.ChkAllArea.Location = new System.Drawing.Point(390, 101);
            this.ChkAllArea.Name = "ChkAllArea";
            this.ChkAllArea.Size = new System.Drawing.Size(41, 21);
            this.ChkAllArea.TabIndex = 7;
            this.ChkAllArea.Text = "All";
            this.ChkAllArea.UseVisualStyleBackColor = true;
            this.ChkAllArea.CheckedChanged += new System.EventHandler(this.ChkAllArea_CheckedChanged);
            // 
            // TxtAccount
            // 
            this.TxtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtAccount.Location = new System.Drawing.Point(94, 64);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(293, 25);
            this.TxtAccount.TabIndex = 8;
            this.TxtAccount.TextChanged += new System.EventHandler(this.TxtAccount_TextChanged);
            this.TxtAccount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtAccount_PreviewKeyDown);
            this.TxtAccount.Leave += new System.EventHandler(this.TxtAccount_Leave);
            // 
            // GridAccount
            // 
            this.GridAccount.BackgroundColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAccount.ColumnHeadersVisible = false;
            this.GridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnAccount});
            this.GridAccount.EnableHeadersVisualStyles = false;
            this.GridAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.GridAccount.Location = new System.Drawing.Point(234, 156);
            this.GridAccount.Name = "GridAccount";
            this.GridAccount.ReadOnly = true;
            this.GridAccount.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAccount.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAccount.Size = new System.Drawing.Size(292, 220);
            this.GridAccount.TabIndex = 9;
            this.GridAccount.Visible = false;
            // 
            // ClnAccount
            // 
            this.ClnAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClnAccount.HeaderText = "Account";
            this.ClnAccount.Name = "ClnAccount";
            this.ClnAccount.ReadOnly = true;
            this.ClnAccount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmSelectBillWiseSettlementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(669, 376);
            this.Controls.Add(this.GridAccount);
            this.Controls.Add(this.TxtAccount);
            this.Controls.Add(this.ChkAllArea);
            this.Controls.Add(this.ComArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.ChkAllAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlTop);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSelectBillWiseSettlementReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Bill Wise Report";
            this.Load += new System.EventHandler(this.FrmSelectBillWiseSettlementReport_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.ComboBox ComSelectReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkAllAccount;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComArea;
        private System.Windows.Forms.CheckBox ChkAllArea;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.DataGridView GridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnAccount;
    }
}