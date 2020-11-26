
namespace RentOfMall
{
    partial class Authorization
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
            this.loginlb = new System.Windows.Forms.Label();
            this.passwordlb = new System.Windows.Forms.Label();
            this.logintb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(365, 21);
            this.NameFormlb.Size = new System.Drawing.Size(135, 22);
            this.NameFormlb.Text = "Авторизация";
            // 
            // exitButton
            // 
            this.exitButton.Size = new System.Drawing.Size(95, 30);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Location = new System.Drawing.Point(260, 135);
            this.loginlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(54, 18);
            this.loginlb.TabIndex = 1;
            this.loginlb.Text = "Логин:";
            // 
            // passwordlb
            // 
            this.passwordlb.AutoSize = true;
            this.passwordlb.Location = new System.Drawing.Point(260, 195);
            this.passwordlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlb.Name = "passwordlb";
            this.passwordlb.Size = new System.Drawing.Size(67, 18);
            this.passwordlb.TabIndex = 2;
            this.passwordlb.Text = "Пароль:";
            // 
            // logintb
            // 
            this.logintb.Location = new System.Drawing.Point(361, 132);
            this.logintb.Margin = new System.Windows.Forms.Padding(4);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(256, 26);
            this.logintb.TabIndex = 3;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(361, 192);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(256, 26);
            this.passwordtb.TabIndex = 4;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(341, 295);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(189, 32);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Авторизоваться";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.logintb);
            this.Controls.Add(this.passwordlb);
            this.Controls.Add(this.loginlb);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.loginlb, 0);
            this.Controls.SetChildIndex(this.passwordlb, 0);
            this.Controls.SetChildIndex(this.logintb, 0);
            this.Controls.SetChildIndex(this.passwordtb, 0);
            this.Controls.SetChildIndex(this.signInButton, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.Label passwordlb;
        private System.Windows.Forms.TextBox logintb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button button1;
    }
}