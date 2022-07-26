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
            this.SuspendLayout();
            // 
            // btnCrawl
            // 
            this.btnCrawl.Location = new System.Drawing.Point(43, 151);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(75, 23);
            this.btnCrawl.TabIndex = 0;
            this.btnCrawl.Text = "Crawl";
            this.btnCrawl.UseVisualStyleBackColor = true;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(43, 45);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(425, 23);
            this.txtLink.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 211);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnCrawl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrawl;
        private TextBox txtLink;
    }
}