namespace WindowsFormsApplication2
{
    partial class Frmiconset
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
            this.panel1H = new System.Windows.Forms.Panel();
            this.lBLHeadder = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.combHY = new System.Windows.Forms.ComboBox();
            this.combHX = new System.Windows.Forms.ComboBox();
            this.CmdHset = new System.Windows.Forms.Button();
            this.panelF = new System.Windows.Forms.Panel();
            this.labLFootr = new System.Windows.Forms.Label();
            this.CmdF = new System.Windows.Forms.Button();
            this.combFx = new System.Windows.Forms.ComboBox();
            this.combFY = new System.Windows.Forms.ComboBox();
            this.lablFy = new System.Windows.Forms.Label();
            this.lablFx = new System.Windows.Forms.Label();
            this.cmdHreset = new System.Windows.Forms.Button();
            this.cmdFreset = new System.Windows.Forms.Button();
            this.panel1H.SuspendLayout();
            this.panelF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1H
            // 
            this.panel1H.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1H.Controls.Add(this.lBLHeadder);
            this.panel1H.Location = new System.Drawing.Point(0, 0);
            this.panel1H.Name = "panel1H";
            this.panel1H.Size = new System.Drawing.Size(361, 29);
            this.panel1H.TabIndex = 0;
            // 
            // lBLHeadder
            // 
            this.lBLHeadder.AutoSize = true;
            this.lBLHeadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLHeadder.ForeColor = System.Drawing.Color.Black;
            this.lBLHeadder.Location = new System.Drawing.Point(31, 6);
            this.lBLHeadder.Name = "lBLHeadder";
            this.lBLHeadder.Size = new System.Drawing.Size(62, 18);
            this.lBLHeadder.TabIndex = 1;
            this.lBLHeadder.Text = "Header";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(12, 44);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(108, 44);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // combHY
            // 
            this.combHY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combHY.FormattingEnabled = true;
            this.combHY.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "67",
            "80",
            "85",
            "88",
            "90",
            "95",
            "97",
            "100",
            "105",
            "108"});
            this.combHY.Location = new System.Drawing.Point(128, 41);
            this.combHY.Name = "combHY";
            this.combHY.Size = new System.Drawing.Size(64, 23);
            this.combHY.TabIndex = 3;
            // 
            // combHX
            // 
            this.combHX.BackColor = System.Drawing.Color.White;
            this.combHX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combHX.FormattingEnabled = true;
            this.combHX.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "67",
            "80",
            "85",
            "88",
            "90",
            "95",
            "97",
            "100",
            "105",
            "108",
            "200"});
            this.combHX.Location = new System.Drawing.Point(38, 41);
            this.combHX.Name = "combHX";
            this.combHX.Size = new System.Drawing.Size(64, 23);
            this.combHX.TabIndex = 4;
            // 
            // CmdHset
            // 
            this.CmdHset.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CmdHset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdHset.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdHset.ForeColor = System.Drawing.Color.Black;
            this.CmdHset.Location = new System.Drawing.Point(216, 35);
            this.CmdHset.Name = "CmdHset";
            this.CmdHset.Size = new System.Drawing.Size(65, 35);
            this.CmdHset.TabIndex = 5;
            this.CmdHset.Text = "Set";
            this.CmdHset.UseVisualStyleBackColor = false;
            this.CmdHset.MouseLeave += new System.EventHandler(this.CmdHset_MouseLeave);
            this.CmdHset.Click += new System.EventHandler(this.CmdHset_Click);
            this.CmdHset.MouseHover += new System.EventHandler(this.CmdHset_MouseHover);
            // 
            // panelF
            // 
            this.panelF.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panelF.Controls.Add(this.labLFootr);
            this.panelF.Location = new System.Drawing.Point(0, 82);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(361, 30);
            this.panelF.TabIndex = 6;
            // 
            // labLFootr
            // 
            this.labLFootr.AutoSize = true;
            this.labLFootr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLFootr.Location = new System.Drawing.Point(31, 9);
            this.labLFootr.Name = "labLFootr";
            this.labLFootr.Size = new System.Drawing.Size(58, 18);
            this.labLFootr.TabIndex = 7;
            this.labLFootr.Text = "Footer";
            // 
            // CmdF
            // 
            this.CmdF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdF.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdF.Location = new System.Drawing.Point(209, 130);
            this.CmdF.Name = "CmdF";
            this.CmdF.Size = new System.Drawing.Size(72, 35);
            this.CmdF.TabIndex = 11;
            this.CmdF.Text = "Set";
            this.CmdF.UseVisualStyleBackColor = true;
            this.CmdF.MouseLeave += new System.EventHandler(this.CmdF_MouseLeave);
            this.CmdF.Click += new System.EventHandler(this.CmdF_Click);
            this.CmdF.MouseHover += new System.EventHandler(this.CmdF_MouseHover);
            // 
            // combFx
            // 
            this.combFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFx.FormattingEnabled = true;
            this.combFx.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "67",
            "80",
            "85",
            "88",
            "90",
            "95",
            "97",
            "100",
            "105",
            "108"});
            this.combFx.Location = new System.Drawing.Point(38, 136);
            this.combFx.Name = "combFx";
            this.combFx.Size = new System.Drawing.Size(64, 23);
            this.combFx.TabIndex = 10;
            // 
            // combFY
            // 
            this.combFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combFY.FormattingEnabled = true;
            this.combFY.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "67",
            "80",
            "85",
            "88",
            "90",
            "95",
            "97",
            "100",
            "105",
            "108"});
            this.combFY.Location = new System.Drawing.Point(132, 136);
            this.combFY.Name = "combFY";
            this.combFY.Size = new System.Drawing.Size(64, 23);
            this.combFY.TabIndex = 9;
            // 
            // lablFy
            // 
            this.lablFy.AutoSize = true;
            this.lablFy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablFy.Location = new System.Drawing.Point(108, 139);
            this.lablFy.Name = "lablFy";
            this.lablFy.Size = new System.Drawing.Size(15, 13);
            this.lablFy.TabIndex = 8;
            this.lablFy.Text = "Y";
            // 
            // lablFx
            // 
            this.lablFx.AutoSize = true;
            this.lablFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablFx.Location = new System.Drawing.Point(12, 139);
            this.lablFx.Name = "lablFx";
            this.lablFx.Size = new System.Drawing.Size(15, 13);
            this.lablFx.TabIndex = 7;
            this.lablFx.Text = "X";
            // 
            // cmdHreset
            // 
            this.cmdHreset.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmdHreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHreset.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHreset.ForeColor = System.Drawing.Color.Black;
            this.cmdHreset.Location = new System.Drawing.Point(290, 35);
            this.cmdHreset.Name = "cmdHreset";
            this.cmdHreset.Size = new System.Drawing.Size(72, 35);
            this.cmdHreset.TabIndex = 12;
            this.cmdHreset.Text = "Clear";
            this.cmdHreset.UseVisualStyleBackColor = false;
            this.cmdHreset.MouseLeave += new System.EventHandler(this.cmdHreset_MouseLeave);
            this.cmdHreset.Click += new System.EventHandler(this.cmdHreset_Click);
            this.cmdHreset.MouseHover += new System.EventHandler(this.cmdHreset_MouseHover);
            // 
            // cmdFreset
            // 
            this.cmdFreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFreset.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFreset.Location = new System.Drawing.Point(290, 130);
            this.cmdFreset.Name = "cmdFreset";
            this.cmdFreset.Size = new System.Drawing.Size(72, 33);
            this.cmdFreset.TabIndex = 13;
            this.cmdFreset.Text = "Clear";
            this.cmdFreset.UseVisualStyleBackColor = true;
            this.cmdFreset.MouseLeave += new System.EventHandler(this.cmdFreset_MouseLeave);
            this.cmdFreset.Click += new System.EventHandler(this.cmdFreset_Click);
            this.cmdFreset.MouseHover += new System.EventHandler(this.cmdFreset_MouseHover);
            // 
            // Frmiconset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(362, 185);
            this.Controls.Add(this.cmdFreset);
            this.Controls.Add(this.cmdHreset);
            this.Controls.Add(this.CmdF);
            this.Controls.Add(this.combFx);
            this.Controls.Add(this.combFY);
            this.Controls.Add(this.lablFy);
            this.Controls.Add(this.lablFx);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.CmdHset);
            this.Controls.Add(this.combHX);
            this.Controls.Add(this.combHY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel1H);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmiconset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmiconset";
            this.Load += new System.EventHandler(this.Frmiconset_Load);
            this.panel1H.ResumeLayout(false);
            this.panel1H.PerformLayout();
            this.panelF.ResumeLayout(false);
            this.panelF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1H;
        private System.Windows.Forms.Label lBLHeadder;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ComboBox combHY;
        private System.Windows.Forms.ComboBox combHX;
        private System.Windows.Forms.Button CmdHset;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.Label labLFootr;
        private System.Windows.Forms.Button CmdF;
        private System.Windows.Forms.ComboBox combFx;
        private System.Windows.Forms.ComboBox combFY;
        private System.Windows.Forms.Label lablFy;
        private System.Windows.Forms.Label lablFx;
        private System.Windows.Forms.Button cmdHreset;
        private System.Windows.Forms.Button cmdFreset;
    }
}