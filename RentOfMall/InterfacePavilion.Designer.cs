
namespace RentOfMall
{
    partial class InterfacePavilion
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
            this.floorLb = new System.Windows.Forms.Label();
            this.PavilionLb = new System.Windows.Forms.Label();
            this.AreaLb = new System.Windows.Forms.Label();
            this.StatusLb = new System.Windows.Forms.Label();
            this.CoeficentLb = new System.Windows.Forms.Label();
            this.CostMeterLb = new System.Windows.Forms.Label();
            this.floorTb = new System.Windows.Forms.TextBox();
            this.pavilionTb = new System.Windows.Forms.TextBox();
            this.areaTb = new System.Windows.Forms.TextBox();
            this.CoeficentTb = new System.Windows.Forms.TextBox();
            this.CostMeterTb = new System.Windows.Forms.TextBox();
            this.statusCmb = new System.Windows.Forms.ComboBox();
            this.addChangeLb = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(206, 23);
            this.NameFormlb.Size = new System.Drawing.Size(226, 22);
            this.NameFormlb.Text = "Интерфейс павильона";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 502);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::RentOfMall.Properties.Resources.Эмблема;
            this.pictureBox1.InitialImage = global::RentOfMall.Properties.Resources.Эмблема;
            this.pictureBox1.Location = new System.Drawing.Point(118, 23);
            // 
            // floorLb
            // 
            this.floorLb.AutoSize = true;
            this.floorLb.Location = new System.Drawing.Point(113, 139);
            this.floorLb.Name = "floorLb";
            this.floorLb.Size = new System.Drawing.Size(108, 18);
            this.floorLb.TabIndex = 3;
            this.floorLb.Text = "Номер этажа:";
            // 
            // PavilionLb
            // 
            this.PavilionLb.AutoSize = true;
            this.PavilionLb.Location = new System.Drawing.Point(113, 192);
            this.PavilionLb.Name = "PavilionLb";
            this.PavilionLb.Size = new System.Drawing.Size(142, 18);
            this.PavilionLb.TabIndex = 4;
            this.PavilionLb.Text = "Номер павильона:";
            // 
            // AreaLb
            // 
            this.AreaLb.AutoSize = true;
            this.AreaLb.Location = new System.Drawing.Point(116, 245);
            this.AreaLb.Name = "AreaLb";
            this.AreaLb.Size = new System.Drawing.Size(78, 18);
            this.AreaLb.TabIndex = 5;
            this.AreaLb.Text = "Площадь:";
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(112, 301);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(143, 18);
            this.StatusLb.TabIndex = 6;
            this.StatusLb.Text = "Статус павильона:";
            // 
            // CoeficentLb
            // 
            this.CoeficentLb.AutoSize = true;
            this.CoeficentLb.Location = new System.Drawing.Point(116, 357);
            this.CoeficentLb.Name = "CoeficentLb";
            this.CoeficentLb.Size = new System.Drawing.Size(125, 18);
            this.CoeficentLb.TabIndex = 7;
            this.CoeficentLb.Text = "КДС павильона:";
            // 
            // CostMeterLb
            // 
            this.CostMeterLb.AutoSize = true;
            this.CostMeterLb.Location = new System.Drawing.Point(116, 409);
            this.CostMeterLb.Name = "CostMeterLb";
            this.CostMeterLb.Size = new System.Drawing.Size(127, 18);
            this.CostMeterLb.TabIndex = 8;
            this.CostMeterLb.Text = "Стоимость кв.м:";
            // 
            // floorTb
            // 
            this.floorTb.Location = new System.Drawing.Point(265, 136);
            this.floorTb.Name = "floorTb";
            this.floorTb.Size = new System.Drawing.Size(212, 26);
            this.floorTb.TabIndex = 9;
            // 
            // pavilionTb
            // 
            this.pavilionTb.Location = new System.Drawing.Point(265, 189);
            this.pavilionTb.Name = "pavilionTb";
            this.pavilionTb.Size = new System.Drawing.Size(212, 26);
            this.pavilionTb.TabIndex = 10;
            // 
            // areaTb
            // 
            this.areaTb.Location = new System.Drawing.Point(265, 245);
            this.areaTb.Name = "areaTb";
            this.areaTb.Size = new System.Drawing.Size(212, 26);
            this.areaTb.TabIndex = 11;
            // 
            // CoeficentTb
            // 
            this.CoeficentTb.Location = new System.Drawing.Point(265, 349);
            this.CoeficentTb.Name = "CoeficentTb";
            this.CoeficentTb.Size = new System.Drawing.Size(212, 26);
            this.CoeficentTb.TabIndex = 13;
            // 
            // CostMeterTb
            // 
            this.CostMeterTb.Location = new System.Drawing.Point(265, 401);
            this.CostMeterTb.Name = "CostMeterTb";
            this.CostMeterTb.Size = new System.Drawing.Size(212, 26);
            this.CostMeterTb.TabIndex = 14;
            // 
            // statusCmb
            // 
            this.statusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmb.FormattingEnabled = true;
            this.statusCmb.Location = new System.Drawing.Point(265, 297);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(212, 26);
            this.statusCmb.TabIndex = 15;
            // 
            // addChangeLb
            // 
            this.addChangeLb.AutoSize = true;
            this.addChangeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.addChangeLb.Location = new System.Drawing.Point(182, 55);
            this.addChangeLb.Name = "addChangeLb";
            this.addChangeLb.Size = new System.Drawing.Size(301, 18);
            this.addChangeLb.TabIndex = 16;
            this.addChangeLb.Text = "Добавление/редактирование павильона";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(484, 504);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 34);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InterfacePavilion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 550);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addChangeLb);
            this.Controls.Add(this.statusCmb);
            this.Controls.Add(this.CostMeterTb);
            this.Controls.Add(this.CoeficentTb);
            this.Controls.Add(this.areaTb);
            this.Controls.Add(this.pavilionTb);
            this.Controls.Add(this.floorTb);
            this.Controls.Add(this.CostMeterLb);
            this.Controls.Add(this.CoeficentLb);
            this.Controls.Add(this.StatusLb);
            this.Controls.Add(this.AreaLb);
            this.Controls.Add(this.PavilionLb);
            this.Controls.Add(this.floorLb);
            this.Name = "InterfacePavilion";
            this.Text = "Добавление/редактирование павильона";
            this.Load += new System.EventHandler(this.InterfacePavilion_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.floorLb, 0);
            this.Controls.SetChildIndex(this.PavilionLb, 0);
            this.Controls.SetChildIndex(this.AreaLb, 0);
            this.Controls.SetChildIndex(this.StatusLb, 0);
            this.Controls.SetChildIndex(this.CoeficentLb, 0);
            this.Controls.SetChildIndex(this.CostMeterLb, 0);
            this.Controls.SetChildIndex(this.floorTb, 0);
            this.Controls.SetChildIndex(this.pavilionTb, 0);
            this.Controls.SetChildIndex(this.areaTb, 0);
            this.Controls.SetChildIndex(this.CoeficentTb, 0);
            this.Controls.SetChildIndex(this.CostMeterTb, 0);
            this.Controls.SetChildIndex(this.statusCmb, 0);
            this.Controls.SetChildIndex(this.addChangeLb, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label floorLb;
        private System.Windows.Forms.Label PavilionLb;
        private System.Windows.Forms.Label AreaLb;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.Label CoeficentLb;
        private System.Windows.Forms.Label CostMeterLb;
        private System.Windows.Forms.TextBox floorTb;
        private System.Windows.Forms.TextBox pavilionTb;
        private System.Windows.Forms.TextBox areaTb;
        private System.Windows.Forms.TextBox CoeficentTb;
        private System.Windows.Forms.TextBox CostMeterTb;
        private System.Windows.Forms.ComboBox statusCmb;
        private System.Windows.Forms.Label addChangeLb;
        private System.Windows.Forms.Button saveButton;
    }
}