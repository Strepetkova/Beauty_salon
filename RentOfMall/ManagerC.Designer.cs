
namespace RentOfMall
{
    partial class ManagerC
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
            this.malldataGridView = new System.Windows.Forms.DataGridView();
            this.nameMallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPavilionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сoefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortSityButton = new System.Windows.Forms.Button();
            this.sortStatusButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.filtersitylb = new System.Windows.Forms.Label();
            this.filtersitycmb = new System.Windows.Forms.ComboBox();
            this.filterstatuslb = new System.Windows.Forms.Label();
            this.filterstatuscmb = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addMallButton = new System.Windows.Forms.Button();
            this.changeMallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(347, 26);
            this.NameFormlb.Size = new System.Drawing.Size(264, 22);
            this.NameFormlb.Text = "Список Торговых центров";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(21, 535);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 12);
            // 
            // malldataGridView
            // 
            this.malldataGridView.AutoGenerateColumns = false;
            this.malldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.malldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameMallDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.quantityPavilionDataGridViewTextBoxColumn,
            this.sityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.сoefficientDataGridViewTextBoxColumn});
            this.malldataGridView.DataSource = this.mallBindingSource;
            this.malldataGridView.Location = new System.Drawing.Point(21, 160);
            this.malldataGridView.Name = "malldataGridView";
            this.malldataGridView.Size = new System.Drawing.Size(950, 295);
            this.malldataGridView.TabIndex = 2;
            // 
            // nameMallDataGridViewTextBoxColumn
            // 
            this.nameMallDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameMallDataGridViewTextBoxColumn.DataPropertyName = "NameMall";
            this.nameMallDataGridViewTextBoxColumn.HeaderText = "Название ТЦ";
            this.nameMallDataGridViewTextBoxColumn.Name = "nameMallDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // quantityPavilionDataGridViewTextBoxColumn
            // 
            this.quantityPavilionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityPavilionDataGridViewTextBoxColumn.DataPropertyName = "QuantityPavilion";
            this.quantityPavilionDataGridViewTextBoxColumn.HeaderText = "Кол-ство павильонов";
            this.quantityPavilionDataGridViewTextBoxColumn.Name = "quantityPavilionDataGridViewTextBoxColumn";
            // 
            // sityDataGridViewTextBoxColumn
            // 
            this.sityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sityDataGridViewTextBoxColumn.DataPropertyName = "Sity";
            this.sityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.sityDataGridViewTextBoxColumn.Name = "sityDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость постройки ТЦ";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Этажность";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // сoefficientDataGridViewTextBoxColumn
            // 
            this.сoefficientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сoefficientDataGridViewTextBoxColumn.DataPropertyName = "Сoefficient";
            this.сoefficientDataGridViewTextBoxColumn.HeaderText = "КДС ТЦ";
            this.сoefficientDataGridViewTextBoxColumn.Name = "сoefficientDataGridViewTextBoxColumn";
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(RentOfMall.Mall);
            // 
            // sortSityButton
            // 
            this.sortSityButton.Location = new System.Drawing.Point(23, 77);
            this.sortSityButton.Name = "sortSityButton";
            this.sortSityButton.Size = new System.Drawing.Size(228, 27);
            this.sortSityButton.TabIndex = 3;
            this.sortSityButton.Text = "Сортировать по городу";
            this.sortSityButton.UseVisualStyleBackColor = true;
            this.sortSityButton.Click += new System.EventHandler(this.sortSityButton_Click);
            // 
            // sortStatusButton
            // 
            this.sortStatusButton.Location = new System.Drawing.Point(23, 110);
            this.sortStatusButton.Name = "sortStatusButton";
            this.sortStatusButton.Size = new System.Drawing.Size(228, 27);
            this.sortStatusButton.TabIndex = 4;
            this.sortStatusButton.Text = "Сортировать по статусу";
            this.sortStatusButton.UseVisualStyleBackColor = true;
            this.sortStatusButton.Click += new System.EventHandler(this.sortStatusButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(800, 91);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(173, 24);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Показать исходное";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // filtersitylb
            // 
            this.filtersitylb.AutoSize = true;
            this.filtersitylb.Location = new System.Drawing.Point(352, 77);
            this.filtersitylb.Name = "filtersitylb";
            this.filtersitylb.Size = new System.Drawing.Size(176, 18);
            this.filtersitylb.TabIndex = 6;
            this.filtersitylb.Text = "Фильтровать по городу";
            // 
            // filtersitycmb
            // 
            this.filtersitycmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtersitycmb.FormattingEnabled = true;
            this.filtersitycmb.Location = new System.Drawing.Point(550, 73);
            this.filtersitycmb.Name = "filtersitycmb";
            this.filtersitycmb.Size = new System.Drawing.Size(192, 26);
            this.filtersitycmb.TabIndex = 7;
            this.filtersitycmb.SelectedIndexChanged += new System.EventHandler(this.filtersitycmb_SelectedIndexChanged);
            // 
            // filterstatuslb
            // 
            this.filterstatuslb.AutoSize = true;
            this.filterstatuslb.Location = new System.Drawing.Point(352, 118);
            this.filterstatuslb.Name = "filterstatuslb";
            this.filterstatuslb.Size = new System.Drawing.Size(180, 18);
            this.filterstatuslb.TabIndex = 8;
            this.filterstatuslb.Text = "Фильтровать по статусу";
            // 
            // filterstatuscmb
            // 
            this.filterstatuscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterstatuscmb.FormattingEnabled = true;
            this.filterstatuscmb.Location = new System.Drawing.Point(550, 115);
            this.filterstatuscmb.Name = "filterstatuscmb";
            this.filterstatuscmb.Size = new System.Drawing.Size(192, 26);
            this.filterstatuscmb.TabIndex = 9;
            this.filterstatuscmb.SelectedIndexChanged += new System.EventHandler(this.filterstatuscmb_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(21, 474);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(118, 34);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Удалить ТЦ";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addMallButton
            // 
            this.addMallButton.Location = new System.Drawing.Point(415, 475);
            this.addMallButton.Name = "addMallButton";
            this.addMallButton.Size = new System.Drawing.Size(133, 33);
            this.addMallButton.TabIndex = 11;
            this.addMallButton.Text = "Добавить ТЦ";
            this.addMallButton.UseVisualStyleBackColor = true;
            this.addMallButton.Click += new System.EventHandler(this.addMallButton_Click);
            // 
            // changeMallButton
            // 
            this.changeMallButton.Location = new System.Drawing.Point(800, 474);
            this.changeMallButton.Name = "changeMallButton";
            this.changeMallButton.Size = new System.Drawing.Size(153, 33);
            this.changeMallButton.TabIndex = 12;
            this.changeMallButton.Text = "Редактировать ТЦ";
            this.changeMallButton.UseVisualStyleBackColor = true;
            this.changeMallButton.Click += new System.EventHandler(this.changeMallButton_Click);
            // 
            // ManagerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 581);
            this.Controls.Add(this.changeMallButton);
            this.Controls.Add(this.addMallButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.filterstatuscmb);
            this.Controls.Add(this.filterstatuslb);
            this.Controls.Add(this.filtersitycmb);
            this.Controls.Add(this.filtersitylb);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.sortStatusButton);
            this.Controls.Add(this.sortSityButton);
            this.Controls.Add(this.malldataGridView);
            this.Name = "ManagerC";
            this.Text = "Менеджер С/Список ТЦ";
            this.Load += new System.EventHandler(this.ManagerC_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.malldataGridView, 0);
            this.Controls.SetChildIndex(this.sortSityButton, 0);
            this.Controls.SetChildIndex(this.sortStatusButton, 0);
            this.Controls.SetChildIndex(this.returnButton, 0);
            this.Controls.SetChildIndex(this.filtersitylb, 0);
            this.Controls.SetChildIndex(this.filtersitycmb, 0);
            this.Controls.SetChildIndex(this.filterstatuslb, 0);
            this.Controls.SetChildIndex(this.filterstatuscmb, 0);
            this.Controls.SetChildIndex(this.removeButton, 0);
            this.Controls.SetChildIndex(this.addMallButton, 0);
            this.Controls.SetChildIndex(this.changeMallButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView malldataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPavilionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сoefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mallBindingSource;
        private System.Windows.Forms.Button sortSityButton;
        private System.Windows.Forms.Button sortStatusButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label filtersitylb;
        private System.Windows.Forms.ComboBox filtersitycmb;
        private System.Windows.Forms.Label filterstatuslb;
        private System.Windows.Forms.ComboBox filterstatuscmb;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addMallButton;
        private System.Windows.Forms.Button changeMallButton;
    }
}