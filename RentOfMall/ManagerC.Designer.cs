
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
            ((System.ComponentModel.ISupportInitialize)(this.malldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameFormlb
            // 
            this.NameFormlb.Location = new System.Drawing.Point(351, 34);
            this.NameFormlb.Size = new System.Drawing.Size(264, 22);
            this.NameFormlb.Text = "Список Торговых центров";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 517);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.malldataGridView.Location = new System.Drawing.Point(23, 159);
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
            this.sortSityButton.Location = new System.Drawing.Point(23, 84);
            this.sortSityButton.Name = "sortSityButton";
            this.sortSityButton.Size = new System.Drawing.Size(228, 27);
            this.sortSityButton.TabIndex = 3;
            this.sortSityButton.Text = "Сортировать по городу";
            this.sortSityButton.UseVisualStyleBackColor = true;
            this.sortSityButton.Click += new System.EventHandler(this.sortSityButton_Click);
            // 
            // sortStatusButton
            // 
            this.sortStatusButton.Location = new System.Drawing.Point(23, 117);
            this.sortStatusButton.Name = "sortStatusButton";
            this.sortStatusButton.Size = new System.Drawing.Size(228, 27);
            this.sortStatusButton.TabIndex = 4;
            this.sortStatusButton.Text = "Сортировать по статусу";
            this.sortStatusButton.UseVisualStyleBackColor = true;
            this.sortStatusButton.Click += new System.EventHandler(this.sortStatusButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(800, 99);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(173, 24);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Показать исходное";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ManagerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 563);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.sortStatusButton);
            this.Controls.Add(this.sortSityButton);
            this.Controls.Add(this.malldataGridView);
            this.Name = "ManagerC";
            this.Text = "ManagerC";
            this.Load += new System.EventHandler(this.ManagerC_Load);
            this.Controls.SetChildIndex(this.NameFormlb, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.malldataGridView, 0);
            this.Controls.SetChildIndex(this.sortSityButton, 0);
            this.Controls.SetChildIndex(this.sortStatusButton, 0);
            this.Controls.SetChildIndex(this.returnButton, 0);
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
    }
}