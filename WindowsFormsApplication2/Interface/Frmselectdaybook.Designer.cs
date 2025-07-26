namespace WindowsFormsApplication2
{
    partial class Frmselectdaybook
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
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.Radsummery = new System.Windows.Forms.RadioButton();
            this.Raddetail = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(55, 25);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(103, 20);
            this.Dtfrom.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(161, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 122;
            this.label5.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(192, 25);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(103, 20);
            this.DtTo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "From";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(220, 86);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 5;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(142, 86);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 4;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // Radsummery
            // 
            this.Radsummery.AutoSize = true;
            this.Radsummery.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Radsummery.Location = new System.Drawing.Point(55, 52);
            this.Radsummery.Name = "Radsummery";
            this.Radsummery.Size = new System.Drawing.Size(85, 23);
            this.Radsummery.TabIndex = 2;
            this.Radsummery.Text = "Summary";
            this.Radsummery.UseVisualStyleBackColor = true;
            this.Radsummery.Visible = false;
            // 
            // Raddetail
            // 
            this.Raddetail.AutoSize = true;
            this.Raddetail.Checked = true;
            this.Raddetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Raddetail.Location = new System.Drawing.Point(164, 52);
            this.Raddetail.Name = "Raddetail";
            this.Raddetail.Size = new System.Drawing.Size(62, 23);
            this.Raddetail.TabIndex = 3;
            this.Raddetail.TabStop = true;
            this.Raddetail.Text = "Detail";
            this.Raddetail.UseVisualStyleBackColor = true;
            // 
            // Frmselectdaybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(317, 137);
            this.Controls.Add(this.Raddetail);
            this.Controls.Add(this.Radsummery);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmselectdaybook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daybook Report";
            this.Load += new System.EventHandler(this.Frmselectdaybook_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmselectdaybook_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frmselectdaybook_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.RadioButton Radsummery;
        private System.Windows.Forms.RadioButton Raddetail;
    }
}