namespace WindowsFormsApplication2
{
    partial class Frmitemgroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmitemgroup));
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Chkshowinsummery = new System.Windows.Forms.CheckBox();
            this.chkontable = new System.Windows.Forms.CheckBox();
            this.TxtRemark = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtGroupname = new WindowsFormsApplication2.Uscnormaltextbox();
            this.SuspendLayout();
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClear.FlatAppearance.BorderSize = 0;
            this.CmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClear.ForeColor = System.Drawing.Color.Black;
            this.CmdClear.Location = new System.Drawing.Point(247, 151);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(103, 40);
            this.CmdClear.TabIndex = 3;
            this.CmdClear.Text = "&Clear(واضح)";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(126, 151);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(115, 40);
            this.CmdSave.TabIndex = 2;
            this.CmdSave.Text = "&Save(F5) حفظ";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(23, 12);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(35, 20);
            this.TxtId.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 19);
            this.label9.TabIndex = 67;
            this.label9.Text = "Group Name (الفئة)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Code (الشفرة)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.Text = "الشعلة 12";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // Chkshowinsummery
            // 
            this.Chkshowinsummery.AutoSize = true;
            this.Chkshowinsummery.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkshowinsummery.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Chkshowinsummery.Location = new System.Drawing.Point(159, 95);
            this.Chkshowinsummery.Name = "Chkshowinsummery";
            this.Chkshowinsummery.Size = new System.Drawing.Size(120, 17);
            this.Chkshowinsummery.TabIndex = 70;
            this.Chkshowinsummery.Text = "Show in Summery";
            this.Chkshowinsummery.UseVisualStyleBackColor = true;
            this.Chkshowinsummery.CheckedChanged += new System.EventHandler(this.Chkshowinsummery_CheckedChanged);
            // 
            // chkontable
            // 
            this.chkontable.AutoSize = true;
            this.chkontable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkontable.ForeColor = System.Drawing.Color.MediumOrchid;
            this.chkontable.Location = new System.Drawing.Point(158, 118);
            this.chkontable.Name = "chkontable";
            this.chkontable.Size = new System.Drawing.Size(84, 17);
            this.chkontable.TabIndex = 71;
            this.chkontable.Text = "Table Items";
            this.chkontable.UseVisualStyleBackColor = true;
            this.chkontable.Visible = false;
            this.chkontable.CheckedChanged += new System.EventHandler(this.chkontable_CheckedChanged);
            // 
            // TxtRemark
            // 
            this.TxtRemark.Location = new System.Drawing.Point(158, 67);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(190, 20);
            this.TxtRemark.TabIndex = 1;
            this.TxtRemark.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TxtRemark_PreviewKeyDown);
            this.TxtRemark.Leave += new System.EventHandler(this.TxtRemark_Leave);
            // 
            // TxtGroupname
            // 
            this.TxtGroupname.Location = new System.Drawing.Point(158, 38);
            this.TxtGroupname.Name = "TxtGroupname";
            this.TxtGroupname.Size = new System.Drawing.Size(190, 20);
            this.TxtGroupname.TabIndex = 0;
            this.TxtGroupname.Leave += new System.EventHandler(this.TxtGroupname_Leave);
            // 
            // Frmitemgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(373, 203);
            this.Controls.Add(this.chkontable);
            this.Controls.Add(this.Chkshowinsummery);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtRemark);
            this.Controls.Add(this.TxtGroupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmitemgroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Category";
            this.Load += new System.EventHandler(this.Frmitemgroup_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmitemgroup_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmitemgroup_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmitemgroup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        public System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Uscnormaltextbox TxtGroupname;
        private Uscnormaltextbox TxtRemark;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Chkshowinsummery;
        private System.Windows.Forms.CheckBox chkontable;
    }
}