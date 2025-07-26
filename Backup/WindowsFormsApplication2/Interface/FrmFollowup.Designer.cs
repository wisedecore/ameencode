namespace WindowsFormsApplication2
{
    partial class FrmFollowup
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
            this.txtCustmrname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustype = new System.Windows.Forms.TextBox();
            this.cmdsave = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.txtcusidentr = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtaddresss = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtmobile = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // txtCustmrname
            // 
            this.txtCustmrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustmrname.Location = new System.Drawing.Point(115, 55);
            this.txtCustmrname.Name = "txtCustmrname";
            this.txtCustmrname.Size = new System.Drawing.Size(280, 22);
            this.txtCustmrname.TabIndex = 3;
            this.txtCustmrname.TextChanged += new System.EventHandler(this.txtCustmrname_TextChanged);
            this.txtCustmrname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCustmrname_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Type";
            // 
            // txtcustype
            // 
            this.txtcustype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustype.Location = new System.Drawing.Point(115, 215);
            this.txtcustype.Name = "txtcustype";
            this.txtcustype.Size = new System.Drawing.Size(280, 22);
            this.txtcustype.TabIndex = 9;
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.Location = new System.Drawing.Point(284, 265);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 38);
            this.cmdsave.TabIndex = 10;
            this.cmdsave.Text = "Save";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.Location = new System.Drawing.Point(176, 265);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 38);
            this.cmdclear.TabIndex = 11;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.BackColor = System.Drawing.Color.LavenderBlush;
            this.uscitemshowsimple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(110, 79);
            this.uscitemshowsimple2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(289, 180);
            this.uscitemshowsimple2.TabIndex = 199;
            this.uscitemshowsimple2.Visible = false;
            // 
            // txtcusidentr
            // 
            this.txtcusidentr.BackColor = System.Drawing.Color.White;
            this.txtcusidentr.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusidentr.ForeColor = System.Drawing.Color.Blue;
            this.txtcusidentr.Location = new System.Drawing.Point(115, 13);
            this.txtcusidentr.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcusidentr.Name = "txtcusidentr";
            this.txtcusidentr.Size = new System.Drawing.Size(128, 35);
            this.txtcusidentr.TabIndex = 12;
            // 
            // txtaddresss
            // 
            this.txtaddresss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddresss.Location = new System.Drawing.Point(115, 130);
            this.txtaddresss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaddresss.Name = "txtaddresss";
            this.txtaddresss.Size = new System.Drawing.Size(280, 79);
            this.txtaddresss.TabIndex = 7;
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(115, 84);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(280, 31);
            this.txtmobile.TabIndex = 5;
            // 
            // FrmFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(425, 330);
            this.Controls.Add(this.uscitemshowsimple2);
            this.Controls.Add(this.txtcusidentr);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.txtcustype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtaddresss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustmrname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFollowup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Followup";
            this.Load += new System.EventHandler(this.FrmFollowup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustmrname;
        private System.Windows.Forms.Label label3;
        private Uscnuemerictextbox txtmobile;
        private System.Windows.Forms.Label label4;
        private Uscnormaltextbox txtaddresss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcustype;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Button cmdclear;
        private Uscnuemerictextbox txtcusidentr;
        public Uscitemshowsimple uscitemshowsimple2;
    }
}