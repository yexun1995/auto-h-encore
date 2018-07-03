namespace auto_h_encore {
    partial class FormFiles {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiles));
            this.txtHencore = new System.Windows.Forms.TextBox();
            this.btnBrowseHencore = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblHencoreName = new System.Windows.Forms.Label();
            this.lblHencoreStatus = new System.Windows.Forms.Label();
            this.lblPkg2zipStatus = new System.Windows.Forms.Label();
            this.lblPkg2zipName = new System.Windows.Forms.Label();
            this.btnBrowsePkg2zip = new System.Windows.Forms.Button();
            this.txtPkg2zip = new System.Windows.Forms.TextBox();
            this.lblPsvimgtoolsStatus = new System.Windows.Forms.Label();
            this.lblPsvimgtoolsName = new System.Windows.Forms.Label();
            this.btnBrowsePsvimgtools = new System.Windows.Forms.Button();
            this.txtPsvimgtools = new System.Windows.Forms.TextBox();
            this.lblBittersmileStatus = new System.Windows.Forms.Label();
            this.lblBittersmileName = new System.Windows.Forms.Label();
            this.btnBrowseBittersmile = new System.Windows.Forms.Button();
            this.txtBittersmile = new System.Windows.Forms.TextBox();
            this.cbxIgnoreHashes = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHencore
            // 
            this.txtHencore.Location = new System.Drawing.Point(12, 71);
            this.txtHencore.Name = "txtHencore";
            this.txtHencore.Size = new System.Drawing.Size(467, 21);
            this.txtHencore.TabIndex = 0;
            this.txtHencore.TextChanged += new System.EventHandler(this.txtHencore_TextChanged);
            // 
            // btnBrowseHencore
            // 
            this.btnBrowseHencore.Location = new System.Drawing.Point(485, 69);
            this.btnBrowseHencore.Name = "btnBrowseHencore";
            this.btnBrowseHencore.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseHencore.TabIndex = 1;
            this.btnBrowseHencore.Text = "浏览";
            this.btnBrowseHencore.UseVisualStyleBackColor = true;
            this.btnBrowseHencore.Click += new System.EventHandler(this.btnBrowseHencore_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(9, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(551, 31);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "如果您已经下载了部分或全部必需文件，并且不希望应用程序重新下载它们，则可以在此处选择要导入程序的文件。";
            // 
            // lblHencoreName
            // 
            this.lblHencoreName.AutoSize = true;
            this.lblHencoreName.Location = new System.Drawing.Point(9, 56);
            this.lblHencoreName.Name = "lblHencoreName";
            this.lblHencoreName.Size = new System.Drawing.Size(131, 12);
            this.lblHencoreName.TabIndex = 3;
            this.lblHencoreName.Text = "h-encore.zip (v1.0.0)";
            // 
            // lblHencoreStatus
            // 
            this.lblHencoreStatus.AutoSize = true;
            this.lblHencoreStatus.Location = new System.Drawing.Point(9, 92);
            this.lblHencoreStatus.Name = "lblHencoreStatus";
            this.lblHencoreStatus.Size = new System.Drawing.Size(167, 12);
            this.lblHencoreStatus.TabIndex = 4;
            this.lblHencoreStatus.Text = "未选择文件，稍后将开始下载.";
            // 
            // lblPkg2zipStatus
            // 
            this.lblPkg2zipStatus.AutoSize = true;
            this.lblPkg2zipStatus.Location = new System.Drawing.Point(9, 156);
            this.lblPkg2zipStatus.Name = "lblPkg2zipStatus";
            this.lblPkg2zipStatus.Size = new System.Drawing.Size(167, 12);
            this.lblPkg2zipStatus.TabIndex = 8;
            this.lblPkg2zipStatus.Text = "未选择文件，稍后将开始下载.";
            // 
            // lblPkg2zipName
            // 
            this.lblPkg2zipName.AutoSize = true;
            this.lblPkg2zipName.Location = new System.Drawing.Point(9, 120);
            this.lblPkg2zipName.Name = "lblPkg2zipName";
            this.lblPkg2zipName.Size = new System.Drawing.Size(149, 12);
            this.lblPkg2zipName.TabIndex = 7;
            this.lblPkg2zipName.Text = "pkg2zip_32bit.zip (v1.8)";
            // 
            // btnBrowsePkg2zip
            // 
            this.btnBrowsePkg2zip.Location = new System.Drawing.Point(485, 133);
            this.btnBrowsePkg2zip.Name = "btnBrowsePkg2zip";
            this.btnBrowsePkg2zip.Size = new System.Drawing.Size(75, 21);
            this.btnBrowsePkg2zip.TabIndex = 6;
            this.btnBrowsePkg2zip.Text = "浏览";
            this.btnBrowsePkg2zip.UseVisualStyleBackColor = true;
            this.btnBrowsePkg2zip.Click += new System.EventHandler(this.btnBrowsePkg2zip_Click);
            // 
            // txtPkg2zip
            // 
            this.txtPkg2zip.Location = new System.Drawing.Point(12, 135);
            this.txtPkg2zip.Name = "txtPkg2zip";
            this.txtPkg2zip.Size = new System.Drawing.Size(467, 21);
            this.txtPkg2zip.TabIndex = 5;
            this.txtPkg2zip.TextChanged += new System.EventHandler(this.txtPkg2zip_TextChanged);
            // 
            // lblPsvimgtoolsStatus
            // 
            this.lblPsvimgtoolsStatus.AutoSize = true;
            this.lblPsvimgtoolsStatus.Location = new System.Drawing.Point(9, 217);
            this.lblPsvimgtoolsStatus.Name = "lblPsvimgtoolsStatus";
            this.lblPsvimgtoolsStatus.Size = new System.Drawing.Size(167, 12);
            this.lblPsvimgtoolsStatus.TabIndex = 12;
            this.lblPsvimgtoolsStatus.Text = "未选择文件，稍后将开始下载.";
            // 
            // lblPsvimgtoolsName
            // 
            this.lblPsvimgtoolsName.AutoSize = true;
            this.lblPsvimgtoolsName.Location = new System.Drawing.Point(9, 181);
            this.lblPsvimgtoolsName.Name = "lblPsvimgtoolsName";
            this.lblPsvimgtoolsName.Size = new System.Drawing.Size(197, 12);
            this.lblPsvimgtoolsName.TabIndex = 11;
            this.lblPsvimgtoolsName.Text = "psvimgtools-0.1-win32.zip (v0.1)";
            // 
            // btnBrowsePsvimgtools
            // 
            this.btnBrowsePsvimgtools.Location = new System.Drawing.Point(485, 194);
            this.btnBrowsePsvimgtools.Name = "btnBrowsePsvimgtools";
            this.btnBrowsePsvimgtools.Size = new System.Drawing.Size(75, 21);
            this.btnBrowsePsvimgtools.TabIndex = 10;
            this.btnBrowsePsvimgtools.Text = "浏览";
            this.btnBrowsePsvimgtools.UseVisualStyleBackColor = true;
            this.btnBrowsePsvimgtools.Click += new System.EventHandler(this.btnBrowsePsvimgtools_Click);
            // 
            // txtPsvimgtools
            // 
            this.txtPsvimgtools.Location = new System.Drawing.Point(12, 196);
            this.txtPsvimgtools.Name = "txtPsvimgtools";
            this.txtPsvimgtools.Size = new System.Drawing.Size(467, 21);
            this.txtPsvimgtools.TabIndex = 9;
            this.txtPsvimgtools.TextChanged += new System.EventHandler(this.txtPsvimgtools_TextChanged);
            // 
            // lblBittersmileStatus
            // 
            this.lblBittersmileStatus.AutoSize = true;
            this.lblBittersmileStatus.Location = new System.Drawing.Point(9, 282);
            this.lblBittersmileStatus.Name = "lblBittersmileStatus";
            this.lblBittersmileStatus.Size = new System.Drawing.Size(167, 12);
            this.lblBittersmileStatus.TabIndex = 16;
            this.lblBittersmileStatus.Text = "未选择文件，稍后将开始下载.";
            // 
            // lblBittersmileName
            // 
            this.lblBittersmileName.AutoSize = true;
            this.lblBittersmileName.Location = new System.Drawing.Point(9, 246);
            this.lblBittersmileName.Name = "lblBittersmileName";
            this.lblBittersmileName.Size = new System.Drawing.Size(131, 12);
            this.lblBittersmileName.TabIndex = 15;
            this.lblBittersmileName.Text = "bitter smile demo pkg";
            // 
            // btnBrowseBittersmile
            // 
            this.btnBrowseBittersmile.Location = new System.Drawing.Point(485, 258);
            this.btnBrowseBittersmile.Name = "btnBrowseBittersmile";
            this.btnBrowseBittersmile.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseBittersmile.TabIndex = 14;
            this.btnBrowseBittersmile.Text = "浏览";
            this.btnBrowseBittersmile.UseVisualStyleBackColor = true;
            this.btnBrowseBittersmile.Click += new System.EventHandler(this.btnBrowseBittersmile_Click);
            // 
            // txtBittersmile
            // 
            this.txtBittersmile.Location = new System.Drawing.Point(12, 260);
            this.txtBittersmile.Name = "txtBittersmile";
            this.txtBittersmile.Size = new System.Drawing.Size(467, 21);
            this.txtBittersmile.TabIndex = 13;
            this.txtBittersmile.TextChanged += new System.EventHandler(this.txtBittersmile_TextChanged);
            // 
            // cbxIgnoreHashes
            // 
            this.cbxIgnoreHashes.AutoSize = true;
            this.cbxIgnoreHashes.Location = new System.Drawing.Point(12, 316);
            this.cbxIgnoreHashes.Name = "cbxIgnoreHashes";
            this.cbxIgnoreHashes.Size = new System.Drawing.Size(168, 16);
            this.cbxIgnoreHashes.TabIndex = 17;
            this.cbxIgnoreHashes.Text = "忽略不匹配的文件校验信息";
            this.cbxIgnoreHashes.UseVisualStyleBackColor = true;
            this.cbxIgnoreHashes.CheckedChanged += new System.EventHandler(this.cbxIgnoreHashes_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(548, 21);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "完成";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 419);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxIgnoreHashes);
            this.Controls.Add(this.lblBittersmileStatus);
            this.Controls.Add(this.lblBittersmileName);
            this.Controls.Add(this.btnBrowseBittersmile);
            this.Controls.Add(this.txtBittersmile);
            this.Controls.Add(this.lblPsvimgtoolsStatus);
            this.Controls.Add(this.lblPsvimgtoolsName);
            this.Controls.Add(this.btnBrowsePsvimgtools);
            this.Controls.Add(this.txtPsvimgtools);
            this.Controls.Add(this.lblPkg2zipStatus);
            this.Controls.Add(this.lblPkg2zipName);
            this.Controls.Add(this.btnBrowsePkg2zip);
            this.Controls.Add(this.txtPkg2zip);
            this.Controls.Add(this.lblHencoreStatus);
            this.Controls.Add(this.lblHencoreName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBrowseHencore);
            this.Controls.Add(this.txtHencore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFiles";
            this.Text = "选择 已下载 的文件";
            this.Load += new System.EventHandler(this.FormFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHencore;
        private System.Windows.Forms.Button btnBrowseHencore;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblHencoreName;
        private System.Windows.Forms.Label lblHencoreStatus;
        private System.Windows.Forms.Label lblPkg2zipStatus;
        private System.Windows.Forms.Label lblPkg2zipName;
        private System.Windows.Forms.Button btnBrowsePkg2zip;
        private System.Windows.Forms.TextBox txtPkg2zip;
        private System.Windows.Forms.Label lblPsvimgtoolsStatus;
        private System.Windows.Forms.Label lblPsvimgtoolsName;
        private System.Windows.Forms.Button btnBrowsePsvimgtools;
        private System.Windows.Forms.TextBox txtPsvimgtools;
        private System.Windows.Forms.Label lblBittersmileStatus;
        private System.Windows.Forms.Label lblBittersmileName;
        private System.Windows.Forms.Button btnBrowseBittersmile;
        private System.Windows.Forms.TextBox txtBittersmile;
        private System.Windows.Forms.CheckBox cbxIgnoreHashes;
        private System.Windows.Forms.Button btnOk;
    }
}