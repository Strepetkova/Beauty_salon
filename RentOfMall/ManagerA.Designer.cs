
namespace RentOfMall
{
    partial class ManagerA
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changeRentButton = new System.Windows.Forms.Button();
            this.addRentButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.SearchLb = new System.Windows.Forms.Label();
            this.ListOfRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(268, 27);
            this.NameFormlb.Size = new System.Drawing.Size(328, 22);
            this.NameFormlb.Text = "Интерфейс менеджера по аренде";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(17, 522);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(203, 12);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.renterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 325);
            this.dataGridView1.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 21;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 21;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 21;
            // 
            // renterBindingSource
            // 
            this.renterBindingSource.DataSource = typeof(RentOfMall.Renter);
            // 
            // changeRentButton
            // 
            this.changeRentButton.Location = new System.Drawing.Point(669, 470);
            this.changeRentButton.Name = "changeRentButton";
            this.changeRentButton.Size = new System.Drawing.Size(153, 33);
            this.changeRentButton.TabIndex = 17;
            this.changeRentButton.Text = "Редактировать";
            this.changeRentButton.UseVisualStyleBackColor = true;
            this.changeRentButton.Click += new System.EventHandler(this.changeRentButton_Click);
            // 
            // addRentButton
            // 
            this.addRentButton.Location = new System.Drawing.Point(345, 469);
            this.addRentButton.Name = "addRentButton";
            this.addRentButton.Size = new System.Drawing.Size(133, 33);
            this.addRentButton.TabIndex = 16;
            this.addRentButton.Text = "Добавить";
            this.addRentButton.UseVisualStyleBackColor = true;
            this.addRentButton.Click += new System.EventHandler(this.addRentButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(17, 469);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(118, 34);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(78, 85);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(250, 26);
            this.SearchTb.TabIndex = 19;
            this.SearchTb.TextChanged += new System.EventHandler(this.SearchTb_TextChanged);
            // 
            // SearchLb
            // 
            this.SearchLb.AutoSize = true;
            this.SearchLb.Location = new System.Drawing.Point(17, 88);
            this.SearchLb.Name = "SearchLb";
            this.SearchLb.Size = new System.Drawing.Size(55, 18);
            this.SearchLb.TabIndex = 18;
            this.SearchLb.Text = "Поиск:";
            // 
            // ListOfRent
            // 
            this.ListOfRent.Location = new System.Drawing.Point(656, 86);
            this.ListOfRent.Name = "ListOfRent";
            this.ListOfRent.Size = new System.Drawing.Size(163, 25);
            this.ListOfRent.TabIndex = 20;
            this.ListOfRent.Text = "Список аренды";
            this.ListOfRent.UseVisualStyleBackColor = true;
            this.ListOfRent.Click += new System.EventHandler(this.ListOfRent_Click);
            // 
            // ManagerA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 567);
            this.Controls.Add(this.ListOfRent);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.SearchLb);
            this.Controls.Add(this.changeRentButton);
            this.Controls.Add(this.addRentButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManagerA";
            this.Text = "Менеджер А/Интерфейс менеджера по аренде";
            this.Load += new System.EventHandler(this.ManagerA_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.removeButton, 0);
            this.Controls.SetChildIndex(this.addRentButton, 0);
            this.Controls.SetChildIndex(this.changeRentButton, 0);
            this.Controls.SetChildIndex(this.SearchLb, 0);
            this.Controls.SetChildIndex(this.SearchTb, 0);
            this.Controls.SetChildIndex(this.ListOfRent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeRentButton;
        private System.Windows.Forms.Button addRentButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Label SearchLb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource renterBindingSource;
        private System.Windows.Forms.Button ListOfRent;
    }
}