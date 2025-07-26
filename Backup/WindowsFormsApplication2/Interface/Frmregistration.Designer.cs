namespace WindowsFormsApplication2
{
    partial class Frmregistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmregistration));
            this.pnlregistration = new System.Windows.Forms.Panel();
            this.txtproductidHdd = new System.Windows.Forms.TextBox();
            this.txtproductidCPU = new System.Windows.Forms.TextBox();
            this.txtproductidMB = new System.Windows.Forms.TextBox();
            this.txtproductidfirmware = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdregister = new System.Windows.Forms.Button();
            this.txtregistrationno = new System.Windows.Forms.TextBox();
            this.txtcdkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltop = new System.Windows.Forms.Panel();
            this.panltrue = new System.Windows.Forms.Panel();
            this.lblreg = new System.Windows.Forms.Label();
            this.pnlregistration.SuspendLayout();
            this.panltrue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlregistration
            // 
            this.pnlregistration.Controls.Add(this.txtproductidHdd);
            this.pnlregistration.Controls.Add(this.txtproductidCPU);
            this.pnlregistration.Controls.Add(this.txtproductidMB);
            this.pnlregistration.Controls.Add(this.txtproductidfirmware);
            this.pnlregistration.Controls.Add(this.cmdclose);
            this.pnlregistration.Controls.Add(this.cmdregister);
            this.pnlregistration.Controls.Add(this.txtregistrationno);
            this.pnlregistration.Controls.Add(this.txtcdkey);
            this.pnlregistration.Controls.Add(this.label4);
            this.pnlregistration.Controls.Add(this.linkLabel1);
            this.pnlregistration.Controls.Add(this.label3);
            this.pnlregistration.Controls.Add(this.label2);
            this.pnlregistration.Controls.Add(this.label1);
            this.pnlregistration.Location = new System.Drawing.Point(54, 147);
            this.pnlregistration.Name = "pnlregistration";
            this.pnlregistration.Size = new System.Drawing.Size(481, 240);
            this.pnlregistration.TabIndex = 1;
            // 
            // txtproductidHdd
            // 
            this.txtproductidHdd.Enabled = false;
            this.txtproductidHdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductidHdd.Location = new System.Drawing.Point(124, 72);
            this.txtproductidHdd.Multiline = true;
            this.txtproductidHdd.Name = "txtproductidHdd";
            this.txtproductidHdd.Size = new System.Drawing.Size(66, 22);
            this.txtproductidHdd.TabIndex = 10;
            this.txtproductidHdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtproductidHdd.Enter += new System.EventHandler(this.txtproductid_Enter);
            // 
            // txtproductidCPU
            // 
            this.txtproductidCPU.Enabled = false;
            this.txtproductidCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductidCPU.Location = new System.Drawing.Point(362, 73);
            this.txtproductidCPU.Multiline = true;
            this.txtproductidCPU.Name = "txtproductidCPU";
            this.txtproductidCPU.Size = new System.Drawing.Size(66, 22);
            this.txtproductidCPU.TabIndex = 17;
            this.txtproductidCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproductidMB
            // 
            this.txtproductidMB.Enabled = false;
            this.txtproductidMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductidMB.Location = new System.Drawing.Point(283, 73);
            this.txtproductidMB.Multiline = true;
            this.txtproductidMB.Name = "txtproductidMB";
            this.txtproductidMB.Size = new System.Drawing.Size(66, 22);
            this.txtproductidMB.TabIndex = 16;
            this.txtproductidMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproductidfirmware
            // 
            this.txtproductidfirmware.Enabled = false;
            this.txtproductidfirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductidfirmware.Location = new System.Drawing.Point(203, 73);
            this.txtproductidfirmware.Multiline = true;
            this.txtproductidfirmware.Name = "txtproductidfirmware";
            this.txtproductidfirmware.Size = new System.Drawing.Size(66, 22);
            this.txtproductidfirmware.TabIndex = 15;
            this.txtproductidfirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdclose
            // 
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.Location = new System.Drawing.Point(272, 186);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 35);
            this.cmdclose.TabIndex = 14;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = true;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdregister
            // 
            this.cmdregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdregister.Location = new System.Drawing.Point(353, 186);
            this.cmdregister.Name = "cmdregister";
            this.cmdregister.Size = new System.Drawing.Size(75, 35);
            this.cmdregister.TabIndex = 13;
            this.cmdregister.Text = "Register";
            this.cmdregister.UseVisualStyleBackColor = true;
            this.cmdregister.Click += new System.EventHandler(this.cmdregister_Click);
            // 
            // txtregistrationno
            // 
            this.txtregistrationno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistrationno.Location = new System.Drawing.Point(124, 158);
            this.txtregistrationno.Multiline = true;
            this.txtregistrationno.Name = "txtregistrationno";
            this.txtregistrationno.Size = new System.Drawing.Size(304, 22);
            this.txtregistrationno.TabIndex = 12;
            this.txtregistrationno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcdkey
            // 
            this.txtcdkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdkey.Location = new System.Drawing.Point(124, 22);
            this.txtcdkey.Multiline = true;
            this.txtcdkey.Name = "txtcdkey";
            this.txtcdkey.Size = new System.Drawing.Size(304, 22);
            this.txtcdkey.TabIndex = 11;
            this.txtcdkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcdkey.Leave += new System.EventHandler(this.txtcdkey_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter the Registration Number";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(249, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "For Online Registratio ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Cd Key";
            // 
            // pnltop
            // 
            this.pnltop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnltop.BackgroundImage")));
            this.pnltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(575, 141);
            this.pnltop.TabIndex = 14;
            // 
            // panltrue
            // 
            this.panltrue.BackColor = System.Drawing.Color.White;
            this.panltrue.Controls.Add(this.lblreg);
            this.panltrue.Location = new System.Drawing.Point(12, 220);
            this.panltrue.Name = "panltrue";
            this.panltrue.Size = new System.Drawing.Size(297, 95);
            this.panltrue.TabIndex = 18;
            this.panltrue.Visible = false;
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.BackColor = System.Drawing.Color.Green;
            this.lblreg.Font = new System.Drawing.Font("Palace Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.White;
            this.lblreg.Location = new System.Drawing.Point(0, 0);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(294, 89);
            this.lblreg.TabIndex = 0;
            this.lblreg.Text = "Registered";
            this.lblreg.Visible = false;
            // 
            // Frmregistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 399);
            this.Controls.Add(this.panltrue);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlregistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmregistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nesma POS Registration";
            this.Load += new System.EventHandler(this.Frmregistration_Load);
            this.pnlregistration.ResumeLayout(false);
            this.pnlregistration.PerformLayout();
            this.panltrue.ResumeLayout(false);
            this.panltrue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlregistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtregistrationno;
        private System.Windows.Forms.TextBox txtcdkey;
        private System.Windows.Forms.TextBox txtproductidHdd;
        private System.Windows.Forms.Button cmdregister;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.TextBox txtproductidCPU;
        private System.Windows.Forms.TextBox txtproductidMB;
        private System.Windows.Forms.TextBox txtproductidfirmware;
        private System.Windows.Forms.Panel panltrue;
        private System.Windows.Forms.Label lblreg;
    }
}