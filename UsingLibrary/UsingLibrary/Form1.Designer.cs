namespace UsingLibrary
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_http = new System.Windows.Forms.Button();
            this.btn_nettcp = new System.Windows.Forms.Button();
            this.btn_wshttp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_http
            // 
            this.btn_http.Location = new System.Drawing.Point(24, 154);
            this.btn_http.Name = "btn_http";
            this.btn_http.Size = new System.Drawing.Size(75, 23);
            this.btn_http.TabIndex = 1;
            this.btn_http.Text = "HTTP";
            this.btn_http.UseVisualStyleBackColor = true;
            this.btn_http.Click += new System.EventHandler(this.btn_http_Click);
            // 
            // btn_nettcp
            // 
            this.btn_nettcp.Location = new System.Drawing.Point(105, 154);
            this.btn_nettcp.Name = "btn_nettcp";
            this.btn_nettcp.Size = new System.Drawing.Size(75, 23);
            this.btn_nettcp.TabIndex = 2;
            this.btn_nettcp.Text = "NETTCP";
            this.btn_nettcp.UseVisualStyleBackColor = true;
            this.btn_nettcp.Click += new System.EventHandler(this.btn_nettcp_Click);
            // 
            // btn_wshttp
            // 
            this.btn_wshttp.Location = new System.Drawing.Point(195, 154);
            this.btn_wshttp.Name = "btn_wshttp";
            this.btn_wshttp.Size = new System.Drawing.Size(75, 23);
            this.btn_wshttp.TabIndex = 3;
            this.btn_wshttp.Text = "WSHTTP";
            this.btn_wshttp.UseVisualStyleBackColor = true;
            this.btn_wshttp.Click += new System.EventHandler(this.btn_wshttp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btn_wshttp);
            this.Controls.Add(this.btn_nettcp);
            this.Controls.Add(this.btn_http);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_http;
        private System.Windows.Forms.Button btn_nettcp;
        private System.Windows.Forms.Button btn_wshttp;
    }
}

