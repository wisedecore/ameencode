namespace WindowsFormsApplication2
{
    partial class Frmselectanalysisreport
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Purchase and Sales");
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TreeMain = new System.Windows.Forms.TreeView();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(221, 184);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(103, 20);
            this.Dtfrom.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(358, 184);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(103, 20);
            this.DtTo.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(174, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 120;
            this.label3.Text = "From";
            // 
            // TreeMain
            // 
            this.TreeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.TreeMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeMain.ForeColor = System.Drawing.Color.Black;
            this.TreeMain.ItemHeight = 30;
            this.TreeMain.Location = new System.Drawing.Point(0, 28);
            this.TreeMain.Name = "TreeMain";
            treeNode1.Name = "pandsaleprofit";
            treeNode1.Text = "Purchase and Sales";
            this.TreeMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TreeMain.Size = new System.Drawing.Size(163, 234);
            this.TreeMain.TabIndex = 124;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(326, 210);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 126;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(248, 210);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 125;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(480, 3);
            this.pnltop.TabIndex = 127;
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 259);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(480, 3);
            this.pnlbottom.TabIndex = 127;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 3);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(3, 256);
            this.pnlleft.TabIndex = 127;
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(477, 3);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(3, 256);
            this.pnlright.TabIndex = 127;
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.pnlImage);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(3, 3);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(474, 25);
            this.pnlHead.TabIndex = 128;
            this.pnlHead.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHead_Paint);
            // 
            // pnlImage
            // 
            this.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(25, 25);
            this.pnlImage.TabIndex = 129;
            // 
            // Frmselectanalysisreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(480, 262);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.TreeMain);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frmselectanalysisreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis Report";
            this.Load += new System.EventHandler(this.Frmselectanalysisreport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmselectanalysisreport_KeyDown);
            this.pnlHead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView TreeMain;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlImage;
    }
}