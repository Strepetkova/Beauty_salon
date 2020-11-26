
namespace RentOfMall
{
    partial class Captcha
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
            this.captchapb = new System.Windows.Forms.PictureBox();
            this.captchatb = new System.Windows.Forms.TextBox();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.Namelb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captchapb)).BeginInit();
            this.SuspendLayout();
            // 
            // captchapb
            // 
            this.captchapb.Location = new System.Drawing.Point(47, 53);
            this.captchapb.Margin = new System.Windows.Forms.Padding(4);
            this.captchapb.Name = "captchapb";
            this.captchapb.Size = new System.Drawing.Size(280, 147);
            this.captchapb.TabIndex = 0;
            this.captchapb.TabStop = false;
            // 
            // captchatb
            // 
            this.captchatb.Location = new System.Drawing.Point(42, 220);
            this.captchatb.Margin = new System.Windows.Forms.Padding(4);
            this.captchatb.Name = "captchatb";
            this.captchatb.Size = new System.Drawing.Size(280, 26);
            this.captchatb.TabIndex = 1;
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(23, 275);
            this.upgradeButton.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(89, 29);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Обновить";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(240, 275);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 29);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Location = new System.Drawing.Point(20, 21);
            this.Namelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(348, 18);
            this.Namelb.TabIndex = 4;
            this.Namelb.Text = "Введите последовательность с рисунка в поле";
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 327);
            this.Controls.Add(this.Namelb);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.captchatb);
            this.Controls.Add(this.captchapb);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.Captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchapb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captchapb;
        private System.Windows.Forms.TextBox captchatb;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label Namelb;
    }
}