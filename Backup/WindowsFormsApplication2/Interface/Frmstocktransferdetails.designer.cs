namespace WindowsFormsApplication2
{
    partial class Frmstocktransferdetails
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
            this.dtFROMdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTodate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comtoarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdshow = new System.Windows.Forms.Button();
            this.Chkall = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtFROMdate
            // 
            this.dtFROMdate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFROMdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFROMdate.Location = new System.Drawing.Point(87, 8);
            this.dtFROMdate.Name = "dtFROMdate";
            this.dtFROMdate.Size = new System.Drawing.Size(108, 23);
            this.dtFROMdate.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "From Date";
            // 
            // dtTodate
            // 
            this.dtTodate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtTodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTodate.Location = new System.Drawing.Point(283, 7);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(108, 23);
            this.dtTodate.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(222, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "TO Date";
            // 
            // comtoarea
            // 
            this.comtoarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtoarea.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comtoarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comtoarea.FormattingEnabled = true;
            this.comtoarea.Location = new System.Drawing.Point(87, 53);
            this.comtoarea.Name = "comtoarea";
            this.comtoarea.Size = new System.Drawing.Size(261, 23);
            this.comtoarea.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Stock Area";
            // 
            // cmdshow
            // 
            this.cmdshow.BackColor = System.Drawing.Color.Transparent;
            this.cmdshow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdshow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdshow.ForeColor = System.Drawing.Color.Black;
            this.cmdshow.Location = new System.Drawing.Point(283, 94);
            this.cmdshow.Name = "cmdshow";
            this.cmdshow.Size = new System.Drawing.Size(108, 36);
            this.cmdshow.TabIndex = 94;
            this.cmdshow.Text = "Show";
            this.cmdshow.UseVisualStyleBackColor = false;
            this.cmdshow.Click += new System.EventHandler(this.cmdshow_Click);
            // 
            // Chkall
            // 
            this.Chkall.AutoSize = true;
            this.Chkall.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Chkall.ForeColor = System.Drawing.Color.Fuchsia;
            this.Chkall.Location = new System.Drawing.Point(354, 55);
            this.Chkall.Name = "Chkall";
            this.Chkall.Size = new System.Drawing.Size(41, 21);
            this.Chkall.TabIndex = 95;
            this.Chkall.Text = "All";
            this.Chkall.UseVisualStyleBackColor = true;
            this.Chkall.CheckedChanged += new System.EventHandler(this.Chkall_CheckedChanged);
            // 
            // Frmstocktransferdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(405, 137);
            this.Controls.Add(this.Chkall);
            this.Controls.Add(this.cmdshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comtoarea);
            this.Controls.Add(this.dtTodate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFROMdate);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "Frmstocktransferdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock transfer details";
            this.Load += new System.EventHandler(this.Frmstocktransferdetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFROMdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtoarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdshow;
        private System.Windows.Forms.CheckBox Chkall;

    }
}