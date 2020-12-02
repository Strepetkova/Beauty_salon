
namespace RentOfMall
{
    partial class InterfaceOfRenter
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
            this.saveButton = new System.Windows.Forms.Button();
            this.ChangeNamelb = new System.Windows.Forms.Label();
            this.nameCompanyLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.phoneLb = new System.Windows.Forms.Label();
            this.nameCompanyTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.phoneMaskTb = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(145, 19);
            this.NameFormlb.Size = new System.Drawing.Size(328, 22);
            this.NameFormlb.Text = "Интерфейс менеджера по аренде";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 379);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 18);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(451, 379);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 34);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChangeNamelb
            // 
            this.ChangeNamelb.AutoSize = true;
            this.ChangeNamelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.ChangeNamelb.Location = new System.Drawing.Point(158, 52);
            this.ChangeNamelb.Name = "ChangeNamelb";
            this.ChangeNamelb.Size = new System.Drawing.Size(220, 18);
            this.ChangeNamelb.TabIndex = 25;
            this.ChangeNamelb.Text = "Добавление/редактирование";
            // 
            // nameCompanyLb
            // 
            this.nameCompanyLb.AutoSize = true;
            this.nameCompanyLb.Location = new System.Drawing.Point(60, 144);
            this.nameCompanyLb.Name = "nameCompanyLb";
            this.nameCompanyLb.Size = new System.Drawing.Size(154, 18);
            this.nameCompanyLb.TabIndex = 26;
            this.nameCompanyLb.Text = "Название компании:";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Location = new System.Drawing.Point(146, 209);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(58, 18);
            this.addressLb.TabIndex = 27;
            this.addressLb.Text = "Адрес:";
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(73, 270);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(136, 18);
            this.phoneLb.TabIndex = 28;
            this.phoneLb.Text = "Номер телефона:";
            // 
            // nameCompanyTb
            // 
            this.nameCompanyTb.Location = new System.Drawing.Point(237, 141);
            this.nameCompanyTb.Name = "nameCompanyTb";
            this.nameCompanyTb.Size = new System.Drawing.Size(191, 26);
            this.nameCompanyTb.TabIndex = 29;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(237, 204);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(191, 26);
            this.addressTb.TabIndex = 30;
            // 
            // phoneMaskTb
            // 
            this.phoneMaskTb.Location = new System.Drawing.Point(237, 267);
            this.phoneMaskTb.Mask = "+7(999) 000-0000";
            this.phoneMaskTb.Name = "phoneMaskTb";
            this.phoneMaskTb.Size = new System.Drawing.Size(191, 26);
            this.phoneMaskTb.TabIndex = 31;
            // 
            // InterfaceOfRenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 427);
            this.Controls.Add(this.phoneMaskTb);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.nameCompanyTb);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.nameCompanyLb);
            this.Controls.Add(this.ChangeNamelb);
            this.Controls.Add(this.saveButton);
            this.Name = "InterfaceOfRenter";
            this.Text = "Добавление/редактирование арендатора";
            this.Load += new System.EventHandler(this.InterfaceOfRenter_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.ChangeNamelb, 0);
            this.Controls.SetChildIndex(this.nameCompanyLb, 0);
            this.Controls.SetChildIndex(this.addressLb, 0);
            this.Controls.SetChildIndex(this.phoneLb, 0);
            this.Controls.SetChildIndex(this.nameCompanyTb, 0);
            this.Controls.SetChildIndex(this.addressTb, 0);
            this.Controls.SetChildIndex(this.phoneMaskTb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label ChangeNamelb;
        private System.Windows.Forms.Label nameCompanyLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.TextBox nameCompanyTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.MaskedTextBox phoneMaskTb;
    }
}