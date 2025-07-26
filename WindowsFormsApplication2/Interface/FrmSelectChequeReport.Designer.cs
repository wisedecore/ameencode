namespace WindowsFormsApplication2
{
    partial class FrmSelectChequeReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.ComChequeMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.PnlBottum = new System.Windows.Forms.Panel();
            this.CmdShow = new System.Windows.Forms.Button();
            this.ComDates = new System.Windows.Forms.ComboBox();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkAccountAll = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComBank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComStatus = new System.Windows.Forms.ComboBox();
            this.GridAccount = new System.Windows.Forms.DataGridView();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkAllStatus = new System.Windows.Forms.CheckBox();
            this.PnlTop.SuspendLayout();
            this.PnlBottum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.PnlTop.Controls.Add(this.ComChequeMode);
            this.PnlTop.Controls.Add(this.label1);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(675, 62);
            this.PnlTop.TabIndex = 0;
            // 
            // ComChequeMode
            // 
            this.ComChequeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComChequeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComChequeMode.FormattingEnabled = true;
            this.ComChequeMode.Items.AddRange(new object[] {
            "Cheque Receipt",
            "Cheque Payment"});
            this.ComChequeMode.Location = new System.Drawing.Point(513, 33);
            this.ComChequeMode.Name = "ComChequeMode";
            this.ComChequeMode.Size = new System.Drawing.Size(158, 25);
            this.ComChequeMode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(399, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Report Of : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // DtFrom
            // 
            this.DtFrom.Location = new System.Drawing.Point(43, 2);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(121, 25);
            this.DtFrom.TabIndex = 3;
            // 
            // PnlBottum
            // 
            this.PnlBottum.Controls.Add(this.CmdShow);
            this.PnlBottum.Controls.Add(this.ComDates);
            this.PnlBottum.Controls.Add(this.DtTo);
            this.PnlBottum.Controls.Add(this.label3);
            this.PnlBottum.Controls.Add(this.DtFrom);
            this.PnlBottum.Controls.Add(this.label4);
            this.PnlBottum.Controls.Add(this.label2);
            this.PnlBottum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottum.Location = new System.Drawing.Point(0, 273);
            this.PnlBottum.Name = "PnlBottum";
            this.PnlBottum.Size = new System.Drawing.Size(675, 84);
            this.PnlBottum.TabIndex = 4;
            // 
            // CmdShow
            // 
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Location = new System.Drawing.Point(595, 48);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 30);
            this.CmdShow.TabIndex = 5;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // ComDates
            // 
            this.ComDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComDates.FormattingEnabled = true;
            this.ComDates.Items.AddRange(new object[] {
            "Paid Date",
            "Cheque Date",
            "Collected Date"});
            this.ComDates.Location = new System.Drawing.Point(44, 55);
            this.ComDates.Name = "ComDates";
            this.ComDates.Size = new System.Drawing.Size(120, 25);
            this.ComDates.TabIndex = 4;
            // 
            // DtTo
            // 
            this.DtTo.Location = new System.Drawing.Point(43, 28);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(121, 25);
            this.DtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "For";
            // 
            // TxtAccount
            // 
            this.TxtAccount.Location = new System.Drawing.Point(62, 70);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(306, 25);
            this.TxtAccount.TabIndex = 5;
            this.TxtAccount.TextChanged += new System.EventHandler(this.TxtAccount_TextChanged);
            this.TxtAccount.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtAccount_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account";
            // 
            // ChkAccountAll
            // 
            this.ChkAccountAll.AutoSize = true;
            this.ChkAccountAll.Location = new System.Drawing.Point(373, 73);
            this.ChkAccountAll.Name = "ChkAccountAll";
            this.ChkAccountAll.Size = new System.Drawing.Size(41, 21);
            this.ChkAccountAll.TabIndex = 6;
            this.ChkAccountAll.Text = "All";
            this.ChkAccountAll.UseVisualStyleBackColor = true;
            this.ChkAccountAll.CheckedChanged += new System.EventHandler(this.ChkAccountAll_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bank";
            // 
            // ComBank
            // 
            this.ComBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBank.FormattingEnabled = true;
            this.ComBank.Location = new System.Drawing.Point(62, 99);
            this.ComBank.Name = "ComBank";
            this.ComBank.Size = new System.Drawing.Size(306, 25);
            this.ComBank.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status";
            // 
            // ComStatus
            // 
            this.ComStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComStatus.FormattingEnabled = true;
            this.ComStatus.Items.AddRange(new object[] {
            "Holding",
            "Collected",
            "Bounced",
            "Re Submitted"});
            this.ComStatus.Location = new System.Drawing.Point(62, 130);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.Size = new System.Drawing.Size(306, 25);
            this.ComStatus.TabIndex = 8;
            // 
            // GridAccount
            // 
            this.GridAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAccount.ColumnHeadersVisible = false;
            this.GridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnName});
            this.GridAccount.EnableHeadersVisualStyles = false;
            this.GridAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(191)))));
            this.GridAccount.Location = new System.Drawing.Point(62, 97);
            this.GridAccount.Name = "GridAccount";
            this.GridAccount.ReadOnly = true;
            this.GridAccount.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAccount.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAccount.Size = new System.Drawing.Size(306, 162);
            this.GridAccount.TabIndex = 26;
            this.GridAccount.Visible = false;
            this.GridAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAccount_CellDoubleClick);
            // 
            // ClnName
            // 
            this.ClnName.HeaderText = "Name";
            this.ClnName.Name = "ClnName";
            this.ClnName.ReadOnly = true;
            // 
            // ChkAllStatus
            // 
            this.ChkAllStatus.AutoSize = true;
            this.ChkAllStatus.Location = new System.Drawing.Point(375, 134);
            this.ChkAllStatus.Name = "ChkAllStatus";
            this.ChkAllStatus.Size = new System.Drawing.Size(41, 21);
            this.ChkAllStatus.TabIndex = 27;
            this.ChkAllStatus.Text = "All";
            this.ChkAllStatus.UseVisualStyleBackColor = true;
            this.ChkAllStatus.CheckedChanged += new System.EventHandler(this.ChkAllStatus_CheckedChanged);
            // 
            // FrmSelectChequeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(675, 357);
            this.Controls.Add(this.ChkAllStatus);
            this.Controls.Add(this.GridAccount);
            this.Controls.Add(this.ComStatus);
            this.Controls.Add(this.ComBank);
            this.Controls.Add(this.ChkAccountAll);
            this.Controls.Add(this.TxtAccount);
            this.Controls.Add(this.PnlBottum);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSelectChequeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Report";
            this.Load += new System.EventHandler(this.FrmSelectChequeReport_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.PnlBottum.ResumeLayout(false);
            this.PnlBottum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.ComboBox ComChequeMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Panel PnlBottum;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComDates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkAccountAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComStatus;
        private System.Windows.Forms.Button CmdShow;
        public System.Windows.Forms.DataGridView GridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnName;
        private System.Windows.Forms.CheckBox ChkAllStatus;
    }
}