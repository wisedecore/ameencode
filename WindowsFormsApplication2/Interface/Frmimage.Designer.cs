namespace WindowsFormsApplication2
{
    partial class Frmimage
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
            this.btnLoadAndSave = new System.Windows.Forms.Button();
            this.btnDisplayImage = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbImageID = new System.Windows.Forms.ComboBox();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlfill = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlleft.SuspendLayout();
            this.pnlfill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadAndSave
            // 
            this.btnLoadAndSave.Location = new System.Drawing.Point(4, 4);
            this.btnLoadAndSave.Name = "btnLoadAndSave";
            this.btnLoadAndSave.Size = new System.Drawing.Size(10, 23);
            this.btnLoadAndSave.TabIndex = 8;
            this.btnLoadAndSave.Text = "<<--Load and Save Image-->>";
            this.btnLoadAndSave.UseVisualStyleBackColor = true;
            this.btnLoadAndSave.Click += new System.EventHandler(this.btnLoadAndSave_Click);
            // 
            // btnDisplayImage
            // 
            this.btnDisplayImage.Location = new System.Drawing.Point(4, 39);
            this.btnDisplayImage.Name = "btnDisplayImage";
            this.btnDisplayImage.Size = new System.Drawing.Size(10, 23);
            this.btnDisplayImage.TabIndex = 9;
            this.btnDisplayImage.Text = "Display Image";
            this.btnDisplayImage.UseVisualStyleBackColor = true;
            this.btnDisplayImage.Click += new System.EventHandler(this.btnDisplayImage_Click);
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(493, 262);
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 97);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(10, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbImageID
            // 
            this.cmbImageID.FormattingEnabled = true;
            this.cmbImageID.Location = new System.Drawing.Point(3, 70);
            this.cmbImageID.Name = "cmbImageID";
            this.cmbImageID.Size = new System.Drawing.Size(10, 21);
            this.cmbImageID.TabIndex = 10;
            // 
            // pnlleft
            // 
            this.pnlleft.Controls.Add(this.btnRefresh);
            this.pnlleft.Controls.Add(this.btnLoadAndSave);
            this.pnlleft.Controls.Add(this.cmbImageID);
            this.pnlleft.Controls.Add(this.btnDisplayImage);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(21, 262);
            this.pnlleft.TabIndex = 12;
            // 
            // pnlfill
            // 
            this.pnlfill.Controls.Add(this.picImage);
            this.pnlfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfill.Location = new System.Drawing.Point(21, 0);
            this.pnlfill.Name = "pnlfill";
            this.pnlfill.Size = new System.Drawing.Size(493, 262);
            this.pnlfill.TabIndex = 13;
            // 
            // Frmimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.pnlfill);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmimage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmimage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlleft.ResumeLayout(false);
            this.pnlfill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadAndSave;
        private System.Windows.Forms.Button btnDisplayImage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbImageID;
        public System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlfill;
    }
}