namespace AirportDamage_S
{
    partial class ForgottenPassword
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
            this.MailS = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.Label();
            this.SendPassword = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MailS
            // 
            this.MailS.Location = new System.Drawing.Point(175, 93);
            this.MailS.Name = "MailS";
            this.MailS.Size = new System.Drawing.Size(228, 20);
            this.MailS.TabIndex = 0;
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(112, 96);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(32, 13);
            this.Mail.TabIndex = 1;
            this.Mail.Text = "MAIL";
            this.Mail.Click += new System.EventHandler(this.label1_Click);
            // 
            // SendPassword
            // 
            this.SendPassword.Location = new System.Drawing.Point(238, 159);
            this.SendPassword.Name = "SendPassword";
            this.SendPassword.Size = new System.Drawing.Size(75, 23);
            this.SendPassword.TabIndex = 2;
            this.SendPassword.Text = "Send";
            this.SendPassword.UseVisualStyleBackColor = true;
            this.SendPassword.Click += new System.EventHandler(this.SendPassword_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(175, 120);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(228, 20);
            this.UserName.TabIndex = 3;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // ForgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SendPassword);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.MailS);
            this.Name = "ForgottenPassword";
            this.Text = "ForgottenPassword";
            this.Load += new System.EventHandler(this.ForgottenPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailS;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Button SendPassword;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
    }
}