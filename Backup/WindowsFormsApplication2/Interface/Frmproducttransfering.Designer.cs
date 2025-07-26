namespace WindowsFormsApplication2
{
    partial class Frmproducttransfering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmproducttransfering));
            this.label11 = new System.Windows.Forms.Label();
            this.comfromdb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comtodb = new System.Windows.Forms.ComboBox();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.Cmdtransfering = new System.Windows.Forms.Button();
            this.chkproductmaster = new System.Windows.Forms.CheckBox();
            this.chkopeningstock = new System.Windows.Forms.CheckBox();
            this.chkclosingstock = new System.Windows.Forms.CheckBox();
            this.chkwithbatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(24, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "From DB";
            // 
            // comfromdb
            // 
            this.comfromdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comfromdb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comfromdb.FormattingEnabled = true;
            this.comfromdb.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.comfromdb.Location = new System.Drawing.Point(93, 27);
            this.comfromdb.Name = "comfromdb";
            this.comfromdb.Size = new System.Drawing.Size(204, 21);
            this.comfromdb.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "To DB";
            // 
            // comtodb
            // 
            this.comtodb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtodb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comtodb.FormattingEnabled = true;
            this.comtodb.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.comtodb.Location = new System.Drawing.Point(93, 60);
            this.comtodb.Name = "comtodb";
            this.comtodb.Size = new System.Drawing.Size(204, 21);
            this.comtodb.TabIndex = 30;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(3, 197);
            this.pnlleft.TabIndex = 33;
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(392, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(3, 197);
            this.pnlright.TabIndex = 34;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(3, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(389, 3);
            this.pnltop.TabIndex = 3;
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(3, 194);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(389, 3);
            this.pnlbottom.TabIndex = 35;
            // 
            // Cmdtransfering
            // 
            this.Cmdtransfering.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdtransfering.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdtransfering.Location = new System.Drawing.Point(93, 148);
            this.Cmdtransfering.Name = "Cmdtransfering";
            this.Cmdtransfering.Size = new System.Drawing.Size(184, 32);
            this.Cmdtransfering.TabIndex = 37;
            this.Cmdtransfering.Text = "Transfering Process";
            this.Cmdtransfering.UseVisualStyleBackColor = true;
            this.Cmdtransfering.Click += new System.EventHandler(this.Cmdtransfering_Click);
            // 
            // chkproductmaster
            // 
            this.chkproductmaster.AutoSize = true;
            this.chkproductmaster.Location = new System.Drawing.Point(97, 97);
            this.chkproductmaster.Name = "chkproductmaster";
            this.chkproductmaster.Size = new System.Drawing.Size(98, 17);
            this.chkproductmaster.TabIndex = 38;
            this.chkproductmaster.Text = "Product Master";
            this.chkproductmaster.UseVisualStyleBackColor = true;
            // 
            // chkopeningstock
            // 
            this.chkopeningstock.AutoSize = true;
            this.chkopeningstock.Location = new System.Drawing.Point(96, 125);
            this.chkopeningstock.Name = "chkopeningstock";
            this.chkopeningstock.Size = new System.Drawing.Size(97, 17);
            this.chkopeningstock.TabIndex = 39;
            this.chkopeningstock.Text = "Opening Stock";
            this.chkopeningstock.UseVisualStyleBackColor = true;
            // 
            // chkclosingstock
            // 
            this.chkclosingstock.AutoSize = true;
            this.chkclosingstock.Location = new System.Drawing.Point(224, 97);
            this.chkclosingstock.Name = "chkclosingstock";
            this.chkclosingstock.Size = new System.Drawing.Size(91, 17);
            this.chkclosingstock.TabIndex = 40;
            this.chkclosingstock.Text = "Closing Stock";
            this.chkclosingstock.UseVisualStyleBackColor = true;
            // 
            // chkwithbatch
            // 
            this.chkwithbatch.AutoSize = true;
            this.chkwithbatch.Location = new System.Drawing.Point(224, 120);
            this.chkwithbatch.Name = "chkwithbatch";
            this.chkwithbatch.Size = new System.Drawing.Size(90, 17);
            this.chkwithbatch.TabIndex = 41;
            this.chkwithbatch.Text = "With Batches";
            this.chkwithbatch.UseVisualStyleBackColor = true;
            // 
            // Frmproducttransfering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(395, 197);
            this.Controls.Add(this.chkwithbatch);
            this.Controls.Add(this.chkclosingstock);
            this.Controls.Add(this.chkopeningstock);
            this.Controls.Add(this.chkproductmaster);
            this.Controls.Add(this.Cmdtransfering);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comtodb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comfromdb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmproducttransfering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfering";
            this.Load += new System.EventHandler(this.Frmproducttransfering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comfromdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtodb;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Button Cmdtransfering;
        private System.Windows.Forms.CheckBox chkproductmaster;
        private System.Windows.Forms.CheckBox chkopeningstock;
        private System.Windows.Forms.CheckBox chkclosingstock;
        private System.Windows.Forms.CheckBox chkwithbatch;

    }
}