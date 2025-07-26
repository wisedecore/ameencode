namespace WindowsFormsApplication2
{
    partial class Frmtaillorreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtaillorreport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdshow = new System.Windows.Forms.Button();
            this.txtsuppluer = new System.Windows.Forms.TextBox();
            this.dtarrivd = new System.Windows.Forms.DateTimePicker();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.chkcuist = new System.Windows.Forms.CheckBox();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer";
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(190, 246);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 45);
            this.cmdclear.TabIndex = 7;
            this.cmdclear.Text = "&Clear (واضح)";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdshow
            // 
            this.cmdshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdshow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdshow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdshow.ForeColor = System.Drawing.Color.Black;
            this.cmdshow.Location = new System.Drawing.Point(282, 246);
            this.cmdshow.Name = "cmdshow";
            this.cmdshow.Size = new System.Drawing.Size(75, 45);
            this.cmdshow.TabIndex = 8;
            this.cmdshow.Text = "Show";
            this.cmdshow.UseVisualStyleBackColor = false;
            this.cmdshow.Click += new System.EventHandler(this.cmdshow_Click);
            // 
            // txtsuppluer
            // 
            this.txtsuppluer.BackColor = System.Drawing.Color.LightCyan;
            this.txtsuppluer.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppluer.ForeColor = System.Drawing.Color.Black;
            this.txtsuppluer.Location = new System.Drawing.Point(68, 85);
            this.txtsuppluer.Name = "txtsuppluer";
            this.txtsuppluer.Size = new System.Drawing.Size(289, 25);
            this.txtsuppluer.TabIndex = 195;
            this.txtsuppluer.TextChanged += new System.EventHandler(this.txtsuppluer_TextChanged);
            this.txtsuppluer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtsuppluer_PreviewKeyDown);
            // 
            // dtarrivd
            // 
            this.dtarrivd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.dtarrivd.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtarrivd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtarrivd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtarrivd.Location = new System.Drawing.Point(62, 35);
            this.dtarrivd.Name = "dtarrivd";
            this.dtarrivd.Size = new System.Drawing.Size(131, 25);
            this.dtarrivd.TabIndex = 196;
            // 
            // dtto
            // 
            this.dtto.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.dtto.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtto.Location = new System.Drawing.Point(233, 33);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(124, 25);
            this.dtto.TabIndex = 197;
            // 
            // chkcuist
            // 
            this.chkcuist.AutoSize = true;
            this.chkcuist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chkcuist.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkcuist.Location = new System.Drawing.Point(12, 126);
            this.chkcuist.Name = "chkcuist";
            this.chkcuist.Size = new System.Drawing.Size(112, 20);
            this.chkcuist.TabIndex = 199;
            this.chkcuist.Text = "Customer wise ";
            this.chkcuist.UseVisualStyleBackColor = false;
            this.chkcuist.CheckedChanged += new System.EventHandler(this.chkcuist_CheckedChanged);
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.BackColor = System.Drawing.Color.LavenderBlush;
            this.uscitemshowsimple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(68, 111);
            this.uscitemshowsimple2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(289, 180);
            this.uscitemshowsimple2.TabIndex = 198;
            this.uscitemshowsimple2.Visible = false;
            this.uscitemshowsimple2.Load += new System.EventHandler(this.uscitemshowsimple2_Load);
            // 
            // Frmtaillorreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(381, 314);
            this.Controls.Add(this.uscitemshowsimple2);
            this.Controls.Add(this.dtto);
            this.Controls.Add(this.dtarrivd);
            this.Controls.Add(this.txtsuppluer);
            this.Controls.Add(this.cmdshow);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkcuist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmtaillorreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Report";
            this.Load += new System.EventHandler(this.Frmtaillorreport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdshow;
        private System.Windows.Forms.TextBox txtsuppluer;
        private System.Windows.Forms.DateTimePicker dtarrivd;
        private System.Windows.Forms.DateTimePicker dtto;
        public Uscitemshowsimple uscitemshowsimple2;
        public System.Windows.Forms.CheckBox chkcuist;
    }
}