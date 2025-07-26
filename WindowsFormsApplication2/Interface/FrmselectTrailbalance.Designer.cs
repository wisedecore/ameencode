namespace WindowsFormsApplication2
{
    partial class FrmselectTrailbalance
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
            this.lblitemname = new System.Windows.Forms.Label();
            this.Dtto = new System.Windows.Forms.DateTimePicker();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.ForeColor = System.Drawing.Color.Black;
            this.lblitemname.Location = new System.Drawing.Point(19, 39);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(117, 17);
            this.lblitemname.TabIndex = 173;
            this.lblitemname.Text = "Trail Balance as on";
            // 
            // Dtto
            // 
            this.Dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtto.Location = new System.Drawing.Point(160, 38);
            this.Dtto.Name = "Dtto";
            this.Dtto.Size = new System.Drawing.Size(103, 20);
            this.Dtto.TabIndex = 174;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(238, 77);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 176;
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
            this.CmdShow.Location = new System.Drawing.Point(160, 77);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 175;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(160, 15);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(103, 20);
            this.Dtfrom.TabIndex = 177;
            this.Dtfrom.Visible = false;
            // 
            // FrmselectTrailbalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(337, 133);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.Dtto);
            this.Controls.Add(this.lblitemname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmselectTrailbalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trailbalance Report";
            this.Load += new System.EventHandler(this.FrmselectTrailbalance_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmselectTrailbalance_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmselectTrailbalance_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.DateTimePicker Dtto;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.DateTimePicker Dtfrom;
    }
}