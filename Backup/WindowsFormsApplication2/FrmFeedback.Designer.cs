namespace WindowsFormsApplication2
{
    partial class FrmFeedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdsave = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.txtfeedback = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtCustmrname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // combostatus
            // 
            this.combostatus.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostatus.ForeColor = System.Drawing.Color.DeepPink;
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "URGENT",
            "NOT URGENT",
            "CALLING",
            "SUGGESTION"});
            this.combostatus.Location = new System.Drawing.Point(112, 77);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(297, 28);
            this.combostatus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feedback";
            // 
            // cmdsave
            // 
            this.cmdsave.Location = new System.Drawing.Point(334, 310);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 41);
            this.cmdsave.TabIndex = 6;
            this.cmdsave.Text = "Save";
            this.cmdsave.UseVisualStyleBackColor = true;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(244, 310);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 41);
            this.cmdclear.TabIndex = 7;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // txtvno
            // 
            this.txtvno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtvno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvno.ForeColor = System.Drawing.Color.Red;
            this.txtvno.Location = new System.Drawing.Point(2, 2);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(100, 18);
            this.txtvno.TabIndex = 201;
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.BackColor = System.Drawing.Color.LavenderBlush;
            this.uscitemshowsimple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(114, 59);
            this.uscitemshowsimple2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(295, 180);
            this.uscitemshowsimple2.TabIndex = 200;
            this.uscitemshowsimple2.Visible = false;
            // 
            // txtfeedback
            // 
            this.txtfeedback.Location = new System.Drawing.Point(112, 113);
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(297, 169);
            this.txtfeedback.TabIndex = 5;
            // 
            // txtCustmrname
            // 
            this.txtCustmrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustmrname.Location = new System.Drawing.Point(112, 31);
            this.txtCustmrname.Name = "txtCustmrname";
            this.txtCustmrname.Size = new System.Drawing.Size(297, 22);
            this.txtCustmrname.TabIndex = 202;
            this.txtCustmrname.TextChanged += new System.EventHandler(this.txtCustmrname_TextChanged);
            this.txtCustmrname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCustmrname_PreviewKeyDown);
            // 
            // FrmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(432, 363);
            this.Controls.Add(this.txtCustmrname);
            this.Controls.Add(this.txtvno);
            this.Controls.Add(this.uscitemshowsimple2);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.txtfeedback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combostatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.FrmFeedback_Load);
            this.TextChanged += new System.EventHandler(this.FrmFeedback_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.Label label3;
        private Uscnormaltextbox txtfeedback;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Button cmdclear;
        public Uscitemshowsimple uscitemshowsimple2;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.TextBox txtCustmrname;
    }
}