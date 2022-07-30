namespace HttpRq
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrawl = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnSampleLink = new System.Windows.Forms.Button();
            this.btnChangeIP = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnUpFile = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrawl
            // 
            this.btnCrawl.Location = new System.Drawing.Point(13, 114);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(75, 23);
            this.btnCrawl.TabIndex = 0;
            this.btnCrawl.Text = "Crawl";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(13, 14);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(245, 23);
            this.txtLink.TabIndex = 1;
            // 
            // btnSampleLink
            // 
            this.btnSampleLink.Location = new System.Drawing.Point(264, 13);
            this.btnSampleLink.Name = "btnSampleLink";
            this.btnSampleLink.Size = new System.Drawing.Size(108, 23);
            this.btnSampleLink.TabIndex = 2;
            this.btnSampleLink.Text = "Sample Link";
            this.btnSampleLink.UseVisualStyleBackColor = true;
            this.btnSampleLink.Click += new System.EventHandler(this.btnSampleLink_Click);
            // 
            // btnChangeIP
            // 
            this.btnChangeIP.Location = new System.Drawing.Point(264, 42);
            this.btnChangeIP.Name = "btnChangeIP";
            this.btnChangeIP.Size = new System.Drawing.Size(108, 23);
            this.btnChangeIP.TabIndex = 3;
            this.btnChangeIP.Text = "Change IP";
            this.btnChangeIP.UseVisualStyleBackColor = true;
            this.btnChangeIP.Click += new System.EventHandler(this.btnChangeIP_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(13, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(245, 23);
            this.txtIP.TabIndex = 4;
            // 
            // btnUpFile
            // 
            this.btnUpFile.Location = new System.Drawing.Point(94, 114);
            this.btnUpFile.Name = "btnUpFile";
            this.btnUpFile.Size = new System.Drawing.Size(75, 23);
            this.btnUpFile.TabIndex = 5;
            this.btnUpFile.Text = "Up File";
            this.btnUpFile.UseVisualStyleBackColor = true;
            this.btnUpFile.Click += new System.EventHandler(this.btnUpFile_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(175, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(13, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 7;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(158, 72);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(100, 23);
            this.txtPasswd.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 149);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUpFile);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnChangeIP);
            this.Controls.Add(this.btnSampleLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnCrawl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrawl;
        private TextBox txtLink;
        private Button btnSampleLink;
        private Button btnChangeIP;
        private TextBox txtIP;
        private Button btnUpFile;
        private Button btnLogin;
        private TextBox txtUser;
        private TextBox txtPasswd;
    }
}