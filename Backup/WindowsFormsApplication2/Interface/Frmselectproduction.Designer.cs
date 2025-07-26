namespace WindowsFormsApplication2
{
    partial class Frmselectproduction
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Issue Report");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Received Report");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Item Status");
            this.Lblledger = new System.Windows.Forms.Label();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.TreeMain = new System.Windows.Forms.TreeView();
            this.comemployee = new System.Windows.Forms.ComboBox();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.Chkallemployee = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lblledger
            // 
            this.Lblledger.AutoSize = true;
            this.Lblledger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Lblledger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblledger.ForeColor = System.Drawing.Color.Black;
            this.Lblledger.Location = new System.Drawing.Point(173, 20);
            this.Lblledger.Name = "Lblledger";
            this.Lblledger.Size = new System.Drawing.Size(103, 17);
            this.Lblledger.TabIndex = 136;
            this.Lblledger.Text = "Select Employee";
            this.Lblledger.Visible = false;
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(225, 194);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(103, 20);
            this.Dtfrom.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(331, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 133;
            this.label5.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(362, 194);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(103, 20);
            this.DtTo.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(178, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 131;
            this.label3.Text = "From";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(343, 236);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 130;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(265, 236);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 129;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // TreeMain
            // 
            this.TreeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.TreeMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMain.ForeColor = System.Drawing.Color.Black;
            this.TreeMain.ItemHeight = 30;
            this.TreeMain.Location = new System.Drawing.Point(3, 8);
            this.TreeMain.Name = "TreeMain";
            treeNode4.Name = "Ndissuereport";
            treeNode4.Text = "Issue Report";
            treeNode5.Name = "Ndreceived";
            treeNode5.Text = "Received Report";
            treeNode6.Name = "Nditemstatus";
            treeNode6.Text = "Item Status";
            this.TreeMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.TreeMain.Size = new System.Drawing.Size(163, 278);
            this.TreeMain.TabIndex = 125;
            this.TreeMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeMain_AfterSelect);
            // 
            // comemployee
            // 
            this.comemployee.FormattingEnabled = true;
            this.comemployee.Location = new System.Drawing.Point(280, 18);
            this.comemployee.Name = "comemployee";
            this.comemployee.Size = new System.Drawing.Size(187, 21);
            this.comemployee.TabIndex = 137;
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.chkstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstatus.ForeColor = System.Drawing.Color.Black;
            this.chkstatus.Location = new System.Drawing.Point(278, 72);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(41, 21);
            this.chkstatus.TabIndex = 138;
            this.chkstatus.Text = "All";
            this.chkstatus.UseVisualStyleBackColor = false;
            // 
            // Chkallemployee
            // 
            this.Chkallemployee.AutoSize = true;
            this.Chkallemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Chkallemployee.Checked = true;
            this.Chkallemployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkallemployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkallemployee.ForeColor = System.Drawing.Color.Black;
            this.Chkallemployee.Location = new System.Drawing.Point(278, 49);
            this.Chkallemployee.Name = "Chkallemployee";
            this.Chkallemployee.Size = new System.Drawing.Size(102, 21);
            this.Chkallemployee.TabIndex = 139;
            this.Chkallemployee.Text = "All Employee";
            this.Chkallemployee.UseVisualStyleBackColor = false;
            this.Chkallemployee.CheckedChanged += new System.EventHandler(this.Chkallemployee_CheckedChanged);
            // 
            // Frmselectproduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(479, 288);
            this.Controls.Add(this.Chkallemployee);
            this.Controls.Add(this.chkstatus);
            this.Controls.Add(this.comemployee);
            this.Controls.Add(this.Lblledger);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.TreeMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frmselectproduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Report";
            this.Load += new System.EventHandler(this.Frmselectproduction_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmselectproduction_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmselectproduction_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblledger;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.TreeView TreeMain;
        private System.Windows.Forms.ComboBox comemployee;
        private System.Windows.Forms.CheckBox chkstatus;
        private System.Windows.Forms.CheckBox Chkallemployee;
    }
}