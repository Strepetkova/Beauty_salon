
namespace RentOfMall
{
    partial class ListOfPavilion
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
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPavilionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSquareMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavilionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusMallTb = new System.Windows.Forms.TextBox();
            this.NameMallTb = new System.Windows.Forms.TextBox();
            this.statusMallLb = new System.Windows.Forms.Label();
            this.NameMallLb = new System.Windows.Forms.Label();
            this.ZeroLb = new System.Windows.Forms.Label();
            this.FilterFoorCmb = new System.Windows.Forms.ComboBox();
            this.filterStatusCmb = new System.Windows.Forms.ComboBox();
            this.filterFloorLb = new System.Windows.Forms.Label();
            this.filterStatusLb = new System.Windows.Forms.Label();
            this.filterZero = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(420, 26);
            this.NameFormlb.Size = new System.Drawing.Size(202, 22);
            this.NameFormlb.Text = "Список павильонов";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(32, 600);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.floorDataGridViewTextBoxColumn,
            this.numberPavilionDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.сoefficientDataGridViewTextBoxColumn,
            this.costSquareMeterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pavilionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 302);
            this.dataGridView1.TabIndex = 3;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Номер этажа";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // numberPavilionDataGridViewTextBoxColumn
            // 
            this.numberPavilionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberPavilionDataGridViewTextBoxColumn.DataPropertyName = "NumberPavilion";
            this.numberPavilionDataGridViewTextBoxColumn.HeaderText = "Номер павильона";
            this.numberPavilionDataGridViewTextBoxColumn.Name = "numberPavilionDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // сoefficientDataGridViewTextBoxColumn
            // 
            this.сoefficientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сoefficientDataGridViewTextBoxColumn.DataPropertyName = "Сoefficient";
            this.сoefficientDataGridViewTextBoxColumn.HeaderText = "КДС павильона";
            this.сoefficientDataGridViewTextBoxColumn.Name = "сoefficientDataGridViewTextBoxColumn";
            // 
            // costSquareMeterDataGridViewTextBoxColumn
            // 
            this.costSquareMeterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costSquareMeterDataGridViewTextBoxColumn.DataPropertyName = "CostSquareMeter";
            this.costSquareMeterDataGridViewTextBoxColumn.HeaderText = "Стоимость кв.м";
            this.costSquareMeterDataGridViewTextBoxColumn.Name = "costSquareMeterDataGridViewTextBoxColumn";
            // 
            // pavilionBindingSource
            // 
            this.pavilionBindingSource.DataSource = typeof(RentOfMall.Pavilion);
            // 
            // statusMallTb
            // 
            this.statusMallTb.Location = new System.Drawing.Point(144, 147);
            this.statusMallTb.Name = "statusMallTb";
            this.statusMallTb.Size = new System.Drawing.Size(162, 26);
            this.statusMallTb.TabIndex = 4;
            // 
            // NameMallTb
            // 
            this.NameMallTb.Location = new System.Drawing.Point(143, 179);
            this.NameMallTb.Name = "NameMallTb";
            this.NameMallTb.Size = new System.Drawing.Size(162, 26);
            this.NameMallTb.TabIndex = 5;
            // 
            // statusMallLb
            // 
            this.statusMallLb.AutoSize = true;
            this.statusMallLb.Location = new System.Drawing.Point(34, 152);
            this.statusMallLb.Name = "statusMallLb";
            this.statusMallLb.Size = new System.Drawing.Size(87, 18);
            this.statusMallLb.TabIndex = 6;
            this.statusMallLb.Text = "Статус ТЦ:";
            // 
            // NameMallLb
            // 
            this.NameMallLb.AutoSize = true;
            this.NameMallLb.Location = new System.Drawing.Point(34, 183);
            this.NameMallLb.Name = "NameMallLb";
            this.NameMallLb.Size = new System.Drawing.Size(107, 18);
            this.NameMallLb.TabIndex = 7;
            this.NameMallLb.Text = "Название ТЦ:";
            // 
            // ZeroLb
            // 
            this.ZeroLb.AutoSize = true;
            this.ZeroLb.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroLb.Location = new System.Drawing.Point(190, 315);
            this.ZeroLb.Name = "ZeroLb";
            this.ZeroLb.Size = new System.Drawing.Size(656, 40);
            this.ZeroLb.TabIndex = 8;
            this.ZeroLb.Text = "Павильонов нет, или они не добавлены!";
            this.ZeroLb.Visible = false;
            // 
            // FilterFoorCmb
            // 
            this.FilterFoorCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterFoorCmb.FormattingEnabled = true;
            this.FilterFoorCmb.Location = new System.Drawing.Point(224, 75);
            this.FilterFoorCmb.Name = "FilterFoorCmb";
            this.FilterFoorCmb.Size = new System.Drawing.Size(218, 26);
            this.FilterFoorCmb.TabIndex = 9;
            this.FilterFoorCmb.SelectionChangeCommitted += new System.EventHandler(this.FilterFoorCmb_SelectionChangeCommitted);
            // 
            // filterStatusCmb
            // 
            this.filterStatusCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterStatusCmb.FormattingEnabled = true;
            this.filterStatusCmb.Location = new System.Drawing.Point(224, 106);
            this.filterStatusCmb.Name = "filterStatusCmb";
            this.filterStatusCmb.Size = new System.Drawing.Size(218, 26);
            this.filterStatusCmb.TabIndex = 10;
            this.filterStatusCmb.SelectionChangeCommitted += new System.EventHandler(this.filterStatusCmb_SelectionChangeCommitted);
            // 
            // filterFloorLb
            // 
            this.filterFloorLb.AutoSize = true;
            this.filterFloorLb.Location = new System.Drawing.Point(34, 79);
            this.filterFloorLb.Name = "filterFloorLb";
            this.filterFloorLb.Size = new System.Drawing.Size(177, 18);
            this.filterFloorLb.TabIndex = 11;
            this.filterFloorLb.Text = "Фильтрация по этажам:";
            // 
            // filterStatusLb
            // 
            this.filterStatusLb.AutoSize = true;
            this.filterStatusLb.Location = new System.Drawing.Point(35, 111);
            this.filterStatusLb.Name = "filterStatusLb";
            this.filterStatusLb.Size = new System.Drawing.Size(176, 18);
            this.filterStatusLb.TabIndex = 12;
            this.filterStatusLb.Text = "Фильтрация по статусу:";
            // 
            // filterZero
            // 
            this.filterZero.AutoSize = true;
            this.filterZero.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterZero.Location = new System.Drawing.Point(245, 368);
            this.filterZero.Name = "filterZero";
            this.filterZero.Size = new System.Drawing.Size(561, 40);
            this.filterZero.TabIndex = 13;
            this.filterZero.Text = "Результат фильтрации не найден!";
            this.filterZero.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(32, 542);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(109, 35);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Удалить ТЦ";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(406, 542);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(142, 35);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить ТЦ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(791, 542);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(165, 35);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Редактировать ТЦ";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ListOfPavilion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 646);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.filterZero);
            this.Controls.Add(this.filterStatusLb);
            this.Controls.Add(this.filterFloorLb);
            this.Controls.Add(this.filterStatusCmb);
            this.Controls.Add(this.FilterFoorCmb);
            this.Controls.Add(this.ZeroLb);
            this.Controls.Add(this.NameMallLb);
            this.Controls.Add(this.statusMallLb);
            this.Controls.Add(this.NameMallTb);
            this.Controls.Add(this.statusMallTb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfPavilion";
            this.Text = "ListOfPavilion";
            this.Load += new System.EventHandler(this.ListOfPavilion_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.statusMallTb, 0);
            this.Controls.SetChildIndex(this.NameMallTb, 0);
            this.Controls.SetChildIndex(this.statusMallLb, 0);
            this.Controls.SetChildIndex(this.NameMallLb, 0);
            this.Controls.SetChildIndex(this.ZeroLb, 0);
            this.Controls.SetChildIndex(this.FilterFoorCmb, 0);
            this.Controls.SetChildIndex(this.filterStatusCmb, 0);
            this.Controls.SetChildIndex(this.filterFloorLb, 0);
            this.Controls.SetChildIndex(this.filterStatusLb, 0);
            this.Controls.SetChildIndex(this.filterZero, 0);
            this.Controls.SetChildIndex(this.removeButton, 0);
            this.Controls.SetChildIndex(this.addButton, 0);
            this.Controls.SetChildIndex(this.changeButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavilionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPavilionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSquareMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pavilionBindingSource;
        private System.Windows.Forms.TextBox statusMallTb;
        private System.Windows.Forms.TextBox NameMallTb;
        private System.Windows.Forms.Label statusMallLb;
        private System.Windows.Forms.Label NameMallLb;
        private System.Windows.Forms.Label ZeroLb;
        private System.Windows.Forms.ComboBox FilterFoorCmb;
        private System.Windows.Forms.ComboBox filterStatusCmb;
        private System.Windows.Forms.Label filterFloorLb;
        private System.Windows.Forms.Label filterStatusLb;
        private System.Windows.Forms.Label filterZero;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
    }
}