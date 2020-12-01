
namespace RentOfMall
{
    partial class InterfaceEmployee
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
            this.ChangeNamelb = new System.Windows.Forms.Label();
            this.surmaneLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.middleNameLb = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.genderLb = new System.Windows.Forms.Label();
            this.roleLb = new System.Windows.Forms.Label();
            this.phonelb = new System.Windows.Forms.Label();
            this.photoLb = new System.Windows.Forms.Label();
            this.roleCmb = new System.Windows.Forms.ComboBox();
            this.photoPcb = new System.Windows.Forms.PictureBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.middleNameTb = new System.Windows.Forms.TextBox();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.attachButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.phoneMaskTb = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPcb)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(213, 21);
            this.NameFormlb.Size = new System.Drawing.Size(282, 22);
            this.NameFormlb.Text = "Интерфейс Администратора";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 594);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 18);
            // 
            // ChangeNamelb
            // 
            this.ChangeNamelb.AutoSize = true;
            this.ChangeNamelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.ChangeNamelb.Location = new System.Drawing.Point(221, 54);
            this.ChangeNamelb.Name = "ChangeNamelb";
            this.ChangeNamelb.Size = new System.Drawing.Size(220, 18);
            this.ChangeNamelb.TabIndex = 3;
            this.ChangeNamelb.Text = "Добавление/редактирование";
            // 
            // surmaneLb
            // 
            this.surmaneLb.AutoSize = true;
            this.surmaneLb.Location = new System.Drawing.Point(182, 104);
            this.surmaneLb.Name = "surmaneLb";
            this.surmaneLb.Size = new System.Drawing.Size(76, 18);
            this.surmaneLb.TabIndex = 4;
            this.surmaneLb.Text = "Фамилия:";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(214, 147);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(44, 18);
            this.nameLb.TabIndex = 5;
            this.nameLb.Text = "Имя:";
            // 
            // middleNameLb
            // 
            this.middleNameLb.AutoSize = true;
            this.middleNameLb.Location = new System.Drawing.Point(177, 191);
            this.middleNameLb.Name = "middleNameLb";
            this.middleNameLb.Size = new System.Drawing.Size(81, 18);
            this.middleNameLb.TabIndex = 6;
            this.middleNameLb.Text = "Отчество:";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(204, 229);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(54, 18);
            this.loginLb.TabIndex = 7;
            this.loginLb.Text = "Логин:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(191, 274);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(67, 18);
            this.passwordLb.TabIndex = 8;
            this.passwordLb.Text = "Пароль:";
            // 
            // genderLb
            // 
            this.genderLb.AutoSize = true;
            this.genderLb.Location = new System.Drawing.Point(218, 321);
            this.genderLb.Name = "genderLb";
            this.genderLb.Size = new System.Drawing.Size(40, 18);
            this.genderLb.TabIndex = 9;
            this.genderLb.Text = "Пол:";
            // 
            // roleLb
            // 
            this.roleLb.AutoSize = true;
            this.roleLb.Location = new System.Drawing.Point(210, 364);
            this.roleLb.Name = "roleLb";
            this.roleLb.Size = new System.Drawing.Size(48, 18);
            this.roleLb.TabIndex = 10;
            this.roleLb.Text = "Роль:";
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.Location = new System.Drawing.Point(122, 412);
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(136, 18);
            this.phonelb.TabIndex = 11;
            this.phonelb.Text = "Номер телефона:";
            // 
            // photoLb
            // 
            this.photoLb.AutoSize = true;
            this.photoLb.Location = new System.Drawing.Point(146, 487);
            this.photoLb.Name = "photoLb";
            this.photoLb.Size = new System.Drawing.Size(112, 36);
            this.photoLb.TabIndex = 12;
            this.photoLb.Text = "        Фото\r\nпользователя:";
            // 
            // roleCmb
            // 
            this.roleCmb.FormattingEnabled = true;
            this.roleCmb.Location = new System.Drawing.Point(280, 361);
            this.roleCmb.Name = "roleCmb";
            this.roleCmb.Size = new System.Drawing.Size(215, 26);
            this.roleCmb.TabIndex = 13;
            // 
            // photoPcb
            // 
            this.photoPcb.Location = new System.Drawing.Point(318, 441);
            this.photoPcb.Name = "photoPcb";
            this.photoPcb.Size = new System.Drawing.Size(123, 95);
            this.photoPcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPcb.TabIndex = 14;
            this.photoPcb.TabStop = false;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(280, 104);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(215, 26);
            this.surnameTb.TabIndex = 15;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(280, 139);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(215, 26);
            this.nameTb.TabIndex = 16;
            // 
            // middleNameTb
            // 
            this.middleNameTb.Location = new System.Drawing.Point(280, 183);
            this.middleNameTb.Name = "middleNameTb";
            this.middleNameTb.Size = new System.Drawing.Size(215, 26);
            this.middleNameTb.TabIndex = 17;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(280, 226);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(215, 26);
            this.loginTb.TabIndex = 18;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(280, 271);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(215, 26);
            this.passwordTb.TabIndex = 19;
            // 
            // genderTb
            // 
            this.genderTb.Location = new System.Drawing.Point(280, 317);
            this.genderTb.Name = "genderTb";
            this.genderTb.Size = new System.Drawing.Size(215, 26);
            this.genderTb.TabIndex = 20;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(326, 542);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(106, 30);
            this.attachButton.TabIndex = 22;
            this.attachButton.Text = "Прикрепить";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(578, 594);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 34);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phoneMaskTb
            // 
            this.phoneMaskTb.Location = new System.Drawing.Point(280, 404);
            this.phoneMaskTb.Mask = "+7(999) 000-0000";
            this.phoneMaskTb.Name = "phoneMaskTb";
            this.phoneMaskTb.Size = new System.Drawing.Size(215, 26);
            this.phoneMaskTb.TabIndex = 24;
            // 
            // InterfaceEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 640);
            this.Controls.Add(this.phoneMaskTb);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.genderTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.middleNameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.photoPcb);
            this.Controls.Add(this.roleCmb);
            this.Controls.Add(this.photoLb);
            this.Controls.Add(this.phonelb);
            this.Controls.Add(this.roleLb);
            this.Controls.Add(this.genderLb);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.middleNameLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.surmaneLb);
            this.Controls.Add(this.ChangeNamelb);
            this.Name = "InterfaceEmployee";
            this.Text = "Добавление/редактирование пользователя";
            this.Load += new System.EventHandler(this.InterfaceEmployee_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.ChangeNamelb, 0);
            this.Controls.SetChildIndex(this.surmaneLb, 0);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.middleNameLb, 0);
            this.Controls.SetChildIndex(this.loginLb, 0);
            this.Controls.SetChildIndex(this.passwordLb, 0);
            this.Controls.SetChildIndex(this.genderLb, 0);
            this.Controls.SetChildIndex(this.roleLb, 0);
            this.Controls.SetChildIndex(this.phonelb, 0);
            this.Controls.SetChildIndex(this.photoLb, 0);
            this.Controls.SetChildIndex(this.roleCmb, 0);
            this.Controls.SetChildIndex(this.photoPcb, 0);
            this.Controls.SetChildIndex(this.surnameTb, 0);
            this.Controls.SetChildIndex(this.nameTb, 0);
            this.Controls.SetChildIndex(this.middleNameTb, 0);
            this.Controls.SetChildIndex(this.loginTb, 0);
            this.Controls.SetChildIndex(this.passwordTb, 0);
            this.Controls.SetChildIndex(this.genderTb, 0);
            this.Controls.SetChildIndex(this.attachButton, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.phoneMaskTb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeNamelb;
        private System.Windows.Forms.Label surmaneLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label middleNameLb;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label genderLb;
        private System.Windows.Forms.Label roleLb;
        private System.Windows.Forms.Label phonelb;
        private System.Windows.Forms.Label photoLb;
        private System.Windows.Forms.ComboBox roleCmb;
        private System.Windows.Forms.PictureBox photoPcb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox middleNameTb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox phoneMaskTb;
    }
}