namespace WindowsFormsApplication2
{
    partial class FrmMultiRate
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
            this.lblheading = new System.Windows.Forms.Label();
            this.TxtRateName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.RadAmount = new System.Windows.Forms.RadioButton();
            this.RadPercentage = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.ChkStatus = new System.Windows.Forms.CheckBox();
            this.TxtRateId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.BackColor = System.Drawing.Color.Transparent;
            this.lblheading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Black;
            this.lblheading.Location = new System.Drawing.Point(171, 144);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(111, 17);
            this.lblheading.TabIndex = 90;
            this.lblheading.Text = "Create MultiRates";
            // 
            // TxtRateName
            // 
            this.TxtRateName.Location = new System.Drawing.Point(97, 51);
            this.TxtRateName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRateName.Name = "TxtRateName";
            this.TxtRateName.Size = new System.Drawing.Size(194, 20);
            this.TxtRateName.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 92;
            this.label10.Text = "Rate Name";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(97, 91);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(194, 20);
            this.TxtDescription.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "Description";
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.Transparent;
            this.CmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClear.FlatAppearance.BorderSize = 0;
            this.CmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClear.ForeColor = System.Drawing.Color.Black;
            this.CmdClear.Location = new System.Drawing.Point(168, 179);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 101;
            this.CmdClear.Text = "&Clear";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.Transparent;
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(97, 179);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 100;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // RadAmount
            // 
            this.RadAmount.AutoSize = true;
            this.RadAmount.BackColor = System.Drawing.Color.Transparent;
            this.RadAmount.Checked = true;
            this.RadAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadAmount.ForeColor = System.Drawing.Color.Black;
            this.RadAmount.Location = new System.Drawing.Point(98, 118);
            this.RadAmount.Name = "RadAmount";
            this.RadAmount.Size = new System.Drawing.Size(79, 17);
            this.RadAmount.TabIndex = 96;
            this.RadAmount.TabStop = true;
            this.RadAmount.Text = "In Amount";
            this.RadAmount.UseVisualStyleBackColor = false;
            this.RadAmount.CheckedChanged += new System.EventHandler(this.RadAmount_CheckedChanged);
            // 
            // RadPercentage
            // 
            this.RadPercentage.AutoSize = true;
            this.RadPercentage.BackColor = System.Drawing.Color.Transparent;
            this.RadPercentage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadPercentage.ForeColor = System.Drawing.Color.Black;
            this.RadPercentage.Location = new System.Drawing.Point(179, 118);
            this.RadPercentage.Name = "RadPercentage";
            this.RadPercentage.Size = new System.Drawing.Size(95, 17);
            this.RadPercentage.TabIndex = 97;
            this.RadPercentage.Text = "In Percentage";
            this.RadPercentage.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(17, 139);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 17);
            this.label15.TabIndex = 98;
            this.label15.Text = "For";
            // 
            // ChkStatus
            // 
            this.ChkStatus.AutoSize = true;
            this.ChkStatus.BackColor = System.Drawing.Color.Transparent;
            this.ChkStatus.Checked = true;
            this.ChkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkStatus.ForeColor = System.Drawing.Color.Black;
            this.ChkStatus.Location = new System.Drawing.Point(98, 144);
            this.ChkStatus.Name = "ChkStatus";
            this.ChkStatus.Size = new System.Drawing.Size(61, 21);
            this.ChkStatus.TabIndex = 102;
            this.ChkStatus.Text = "Active";
            this.ChkStatus.UseVisualStyleBackColor = false;
            // 
            // TxtRateId
            // 
            this.TxtRateId.Location = new System.Drawing.Point(18, 12);
            this.TxtRateId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRateId.Name = "TxtRateId";
            this.TxtRateId.ReadOnly = true;
            this.TxtRateId.Size = new System.Drawing.Size(39, 20);
            this.TxtRateId.TabIndex = 103;
            // 
            // FrmMultiRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 239);
            this.Controls.Add(this.TxtRateId);
            this.Controls.Add(this.ChkStatus);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.RadPercentage);
            this.Controls.Add(this.RadAmount);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRateName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblheading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMultiRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multirate Create";
            this.Load += new System.EventHandler(this.FrmMultiRate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMultiRate_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.TextBox TxtRateName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.RadioButton RadAmount;
        private System.Windows.Forms.RadioButton RadPercentage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ChkStatus;
        private System.Windows.Forms.TextBox TxtRateId;
    }
}