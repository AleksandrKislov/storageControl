namespace BeTechTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.goodsButton = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.storageButton = new System.Windows.Forms.Button();
            this.currencyButton = new System.Windows.Forms.Button();
            this.managementL = new System.Windows.Forms.Label();
            this.fieldName1TB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.showTableButton = new System.Windows.Forms.Button();
            this.tableChooseL = new System.Windows.Forms.Label();
            this.fieldName1L = new System.Windows.Forms.Label();
            this.fieldName2L = new System.Windows.Forms.Label();
            this.fieldName2TB = new System.Windows.Forms.TextBox();
            this.fieldName3L = new System.Windows.Forms.Label();
            this.fieldName3TB = new System.Windows.Forms.TextBox();
            this.fieldName4L = new System.Windows.Forms.Label();
            this.fieldNameCB1 = new System.Windows.Forms.ComboBox();
            this.fieldNameCB2 = new System.Windows.Forms.ComboBox();
            this.fieldName4TB = new System.Windows.Forms.TextBox();
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.newFieldName4TB = new System.Windows.Forms.TextBox();
            this.newFieldNameCB2 = new System.Windows.Forms.ComboBox();
            this.newFieldNameCB1 = new System.Windows.Forms.ComboBox();
            this.newFieldName4L = new System.Windows.Forms.Label();
            this.newFieldName3L = new System.Windows.Forms.Label();
            this.newFieldName3TB = new System.Windows.Forms.TextBox();
            this.newFieldName2L = new System.Windows.Forms.Label();
            this.newFieldName2TB = new System.Windows.Forms.TextBox();
            this.newFieldName1L = new System.Windows.Forms.Label();
            this.newFieldName1TB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workAreaGB = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barCodeGenerateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.workAreaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsButton
            // 
            this.goodsButton.Location = new System.Drawing.Point(317, 32);
            this.goodsButton.Name = "goodsButton";
            this.goodsButton.Size = new System.Drawing.Size(145, 23);
            this.goodsButton.TabIndex = 1;
            this.goodsButton.Text = "Товары";
            this.goodsButton.UseVisualStyleBackColor = true;
            this.goodsButton.Click += new System.EventHandler(this.goodsButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.Location = new System.Drawing.Point(317, 61);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(145, 23);
            this.CategoryButton.TabIndex = 2;
            this.CategoryButton.Text = "Категории товара";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // storageButton
            // 
            this.storageButton.Location = new System.Drawing.Point(317, 90);
            this.storageButton.Name = "storageButton";
            this.storageButton.Size = new System.Drawing.Size(145, 23);
            this.storageButton.TabIndex = 3;
            this.storageButton.Text = "Склады";
            this.storageButton.UseVisualStyleBackColor = true;
            this.storageButton.Click += new System.EventHandler(this.storageButton_Click);
            // 
            // currencyButton
            // 
            this.currencyButton.Location = new System.Drawing.Point(317, 119);
            this.currencyButton.Name = "currencyButton";
            this.currencyButton.Size = new System.Drawing.Size(145, 23);
            this.currencyButton.TabIndex = 4;
            this.currencyButton.Text = "Валюты";
            this.currencyButton.UseVisualStyleBackColor = true;
            this.currencyButton.Click += new System.EventHandler(this.currencyButton_Click);
            // 
            // managementL
            // 
            this.managementL.AutoSize = true;
            this.managementL.Location = new System.Drawing.Point(94, 12);
            this.managementL.Name = "managementL";
            this.managementL.Size = new System.Drawing.Size(88, 17);
            this.managementL.TabIndex = 5;
            this.managementL.Text = "Управнение";
            this.managementL.Visible = false;
            // 
            // fieldName1TB
            // 
            this.fieldName1TB.Location = new System.Drawing.Point(6, 48);
            this.fieldName1TB.Name = "fieldName1TB";
            this.fieldName1TB.Size = new System.Drawing.Size(193, 22);
            this.fieldName1TB.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(43, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(193, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(43, 61);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(193, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(43, 90);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(193, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Изменить запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // showTableButton
            // 
            this.showTableButton.Location = new System.Drawing.Point(43, 119);
            this.showTableButton.Name = "showTableButton";
            this.showTableButton.Size = new System.Drawing.Size(193, 23);
            this.showTableButton.TabIndex = 10;
            this.showTableButton.Text = "Вывести записи на экран";
            this.showTableButton.UseVisualStyleBackColor = true;
            this.showTableButton.Visible = false;
            this.showTableButton.Click += new System.EventHandler(this.showTableButton_Click);
            // 
            // tableChooseL
            // 
            this.tableChooseL.AutoSize = true;
            this.tableChooseL.Location = new System.Drawing.Point(337, 12);
            this.tableChooseL.Name = "tableChooseL";
            this.tableChooseL.Size = new System.Drawing.Size(104, 17);
            this.tableChooseL.TabIndex = 11;
            this.tableChooseL.Text = "Выбор талицы";
            // 
            // fieldName1L
            // 
            this.fieldName1L.AutoSize = true;
            this.fieldName1L.Location = new System.Drawing.Point(6, 73);
            this.fieldName1L.Name = "fieldName1L";
            this.fieldName1L.Size = new System.Drawing.Size(72, 17);
            this.fieldName1L.TabIndex = 12;
            this.fieldName1L.Text = "Название";
            // 
            // fieldName2L
            // 
            this.fieldName2L.AutoSize = true;
            this.fieldName2L.Location = new System.Drawing.Point(6, 142);
            this.fieldName2L.Name = "fieldName2L";
            this.fieldName2L.Size = new System.Drawing.Size(43, 17);
            this.fieldName2L.TabIndex = 14;
            this.fieldName2L.Text = "Цена";
            // 
            // fieldName2TB
            // 
            this.fieldName2TB.Location = new System.Drawing.Point(6, 117);
            this.fieldName2TB.Name = "fieldName2TB";
            this.fieldName2TB.Size = new System.Drawing.Size(193, 22);
            this.fieldName2TB.TabIndex = 13;
            // 
            // fieldName3L
            // 
            this.fieldName3L.AutoSize = true;
            this.fieldName3L.Location = new System.Drawing.Point(6, 211);
            this.fieldName3L.Name = "fieldName3L";
            this.fieldName3L.Size = new System.Drawing.Size(127, 17);
            this.fieldName3L.TabIndex = 16;
            this.fieldName3L.Text = "Категория товара";
            // 
            // fieldName3TB
            // 
            this.fieldName3TB.Location = new System.Drawing.Point(6, 184);
            this.fieldName3TB.Name = "fieldName3TB";
            this.fieldName3TB.Size = new System.Drawing.Size(193, 22);
            this.fieldName3TB.TabIndex = 15;
            // 
            // fieldName4L
            // 
            this.fieldName4L.AutoSize = true;
            this.fieldName4L.Location = new System.Drawing.Point(6, 267);
            this.fieldName4L.Name = "fieldName4L";
            this.fieldName4L.Size = new System.Drawing.Size(58, 17);
            this.fieldName4L.TabIndex = 18;
            this.fieldName4L.Text = "Валюта";
            // 
            // fieldNameCB1
            // 
            this.fieldNameCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldNameCB1.FormattingEnabled = true;
            this.fieldNameCB1.Location = new System.Drawing.Point(6, 184);
            this.fieldNameCB1.Name = "fieldNameCB1";
            this.fieldNameCB1.Size = new System.Drawing.Size(193, 24);
            this.fieldNameCB1.TabIndex = 21;
            // 
            // fieldNameCB2
            // 
            this.fieldNameCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldNameCB2.FormattingEnabled = true;
            this.fieldNameCB2.Location = new System.Drawing.Point(6, 238);
            this.fieldNameCB2.Name = "fieldNameCB2";
            this.fieldNameCB2.Size = new System.Drawing.Size(193, 24);
            this.fieldNameCB2.TabIndex = 22;
            // 
            // fieldName4TB
            // 
            this.fieldName4TB.Location = new System.Drawing.Point(6, 240);
            this.fieldName4TB.Name = "fieldName4TB";
            this.fieldName4TB.Size = new System.Drawing.Size(193, 22);
            this.fieldName4TB.TabIndex = 24;
            this.fieldName4TB.Visible = false;
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.AllowUserToAddRows = false;
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.priceBase,
            this.price,
            this.category,
            this.currency,
            this.codeNumber});
            this.dbDataGridView.Location = new System.Drawing.Point(534, 12);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.RowTemplate.Height = 24;
            this.dbDataGridView.Size = new System.Drawing.Size(472, 505);
            this.dbDataGridView.TabIndex = 38;
            // 
            // newFieldName4TB
            // 
            this.newFieldName4TB.Location = new System.Drawing.Point(287, 267);
            this.newFieldName4TB.Name = "newFieldName4TB";
            this.newFieldName4TB.Size = new System.Drawing.Size(193, 22);
            this.newFieldName4TB.TabIndex = 49;
            this.newFieldName4TB.Visible = false;
            // 
            // newFieldNameCB2
            // 
            this.newFieldNameCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newFieldNameCB2.FormattingEnabled = true;
            this.newFieldNameCB2.Location = new System.Drawing.Point(287, 267);
            this.newFieldNameCB2.Name = "newFieldNameCB2";
            this.newFieldNameCB2.Size = new System.Drawing.Size(193, 24);
            this.newFieldNameCB2.TabIndex = 48;
            // 
            // newFieldNameCB1
            // 
            this.newFieldNameCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newFieldNameCB1.FormattingEnabled = true;
            this.newFieldNameCB1.Location = new System.Drawing.Point(287, 211);
            this.newFieldNameCB1.Name = "newFieldNameCB1";
            this.newFieldNameCB1.Size = new System.Drawing.Size(193, 24);
            this.newFieldNameCB1.TabIndex = 47;
            // 
            // newFieldName4L
            // 
            this.newFieldName4L.AutoSize = true;
            this.newFieldName4L.Location = new System.Drawing.Point(287, 296);
            this.newFieldName4L.Name = "newFieldName4L";
            this.newFieldName4L.Size = new System.Drawing.Size(101, 17);
            this.newFieldName4L.TabIndex = 45;
            this.newFieldName4L.Text = "Новая валюта";
            // 
            // newFieldName3L
            // 
            this.newFieldName3L.AutoSize = true;
            this.newFieldName3L.Location = new System.Drawing.Point(287, 238);
            this.newFieldName3L.Name = "newFieldName3L";
            this.newFieldName3L.Size = new System.Drawing.Size(170, 17);
            this.newFieldName3L.TabIndex = 44;
            this.newFieldName3L.Text = "Новая категория товара";
            // 
            // newFieldName3TB
            // 
            this.newFieldName3TB.Location = new System.Drawing.Point(287, 211);
            this.newFieldName3TB.Name = "newFieldName3TB";
            this.newFieldName3TB.Size = new System.Drawing.Size(193, 22);
            this.newFieldName3TB.TabIndex = 43;
            // 
            // newFieldName2L
            // 
            this.newFieldName2L.AutoSize = true;
            this.newFieldName2L.Location = new System.Drawing.Point(287, 171);
            this.newFieldName2L.Name = "newFieldName2L";
            this.newFieldName2L.Size = new System.Drawing.Size(85, 17);
            this.newFieldName2L.TabIndex = 42;
            this.newFieldName2L.Text = "Новая цена";
            // 
            // newFieldName2TB
            // 
            this.newFieldName2TB.Location = new System.Drawing.Point(287, 146);
            this.newFieldName2TB.Name = "newFieldName2TB";
            this.newFieldName2TB.Size = new System.Drawing.Size(193, 22);
            this.newFieldName2TB.TabIndex = 41;
            // 
            // newFieldName1L
            // 
            this.newFieldName1L.AutoSize = true;
            this.newFieldName1L.Location = new System.Drawing.Point(287, 102);
            this.newFieldName1L.Name = "newFieldName1L";
            this.newFieldName1L.Size = new System.Drawing.Size(115, 17);
            this.newFieldName1L.TabIndex = 40;
            this.newFieldName1L.Text = "Новое название";
            // 
            // newFieldName1TB
            // 
            this.newFieldName1TB.Location = new System.Drawing.Point(287, 77);
            this.newFieldName1TB.Name = "newFieldName1TB";
            this.newFieldName1TB.Size = new System.Drawing.Size(193, 22);
            this.newFieldName1TB.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fieldName2TB);
            this.groupBox1.Controls.Add(this.fieldName1TB);
            this.groupBox1.Controls.Add(this.fieldName1L);
            this.groupBox1.Controls.Add(this.fieldName2L);
            this.groupBox1.Controls.Add(this.fieldName3TB);
            this.groupBox1.Controls.Add(this.fieldName3L);
            this.groupBox1.Controls.Add(this.fieldName4L);
            this.groupBox1.Controls.Add(this.fieldNameCB1);
            this.groupBox1.Controls.Add(this.fieldNameCB2);
            this.groupBox1.Controls.Add(this.fieldName4TB);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 300);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить/Удалить запись";
            // 
            // workAreaGB
            // 
            this.workAreaGB.Controls.Add(this.newFieldName1TB);
            this.workAreaGB.Controls.Add(this.groupBox1);
            this.workAreaGB.Controls.Add(this.newFieldName1L);
            this.workAreaGB.Controls.Add(this.newFieldName2TB);
            this.workAreaGB.Controls.Add(this.newFieldName4TB);
            this.workAreaGB.Controls.Add(this.newFieldName2L);
            this.workAreaGB.Controls.Add(this.newFieldNameCB2);
            this.workAreaGB.Controls.Add(this.newFieldName3TB);
            this.workAreaGB.Controls.Add(this.newFieldNameCB1);
            this.workAreaGB.Controls.Add(this.newFieldName3L);
            this.workAreaGB.Controls.Add(this.newFieldName4L);
            this.workAreaGB.Location = new System.Drawing.Point(12, 173);
            this.workAreaGB.Name = "workAreaGB";
            this.workAreaGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.workAreaGB.Size = new System.Drawing.Size(516, 344);
            this.workAreaGB.TabIndex = 53;
            this.workAreaGB.TabStop = false;
            this.workAreaGB.Text = "Изменить запись";
            this.workAreaGB.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // priceBase
            // 
            this.priceBase.HeaderText = "Цена в базовой валюте";
            this.priceBase.Name = "priceBase";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // category
            // 
            this.category.HeaderText = "Категория товара";
            this.category.Name = "category";
            // 
            // currency
            // 
            this.currency.HeaderText = "Валюта";
            this.currency.Name = "currency";
            // 
            // codeNumber
            // 
            this.codeNumber.HeaderText = "Номер штрих кода";
            this.codeNumber.Name = "codeNumber";
            // 
            // barCodeGenerateButton
            // 
            this.barCodeGenerateButton.Location = new System.Drawing.Point(44, 148);
            this.barCodeGenerateButton.Name = "barCodeGenerateButton";
            this.barCodeGenerateButton.Size = new System.Drawing.Size(418, 23);
            this.barCodeGenerateButton.TabIndex = 54;
            this.barCodeGenerateButton.Text = "Показать штрих код товара";
            this.barCodeGenerateButton.UseVisualStyleBackColor = true;
            this.barCodeGenerateButton.Visible = false;
            this.barCodeGenerateButton.Click += new System.EventHandler(this.barCodeGenerateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 532);
            this.Controls.Add(this.barCodeGenerateButton);
            this.Controls.Add(this.workAreaGB);
            this.Controls.Add(this.dbDataGridView);
            this.Controls.Add(this.tableChooseL);
            this.Controls.Add(this.showTableButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.managementL);
            this.Controls.Add(this.currencyButton);
            this.Controls.Add(this.storageButton);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.goodsButton);
            this.Name = "MainForm";
            this.Text = "Складской учет";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.workAreaGB.ResumeLayout(false);
            this.workAreaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goodsButton;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button storageButton;
        private System.Windows.Forms.Button currencyButton;
        private System.Windows.Forms.Label managementL;
        private System.Windows.Forms.TextBox fieldName1TB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button showTableButton;
        private System.Windows.Forms.Label tableChooseL;
        private System.Windows.Forms.Label fieldName1L;
        private System.Windows.Forms.Label fieldName2L;
        private System.Windows.Forms.TextBox fieldName2TB;
        private System.Windows.Forms.Label fieldName3L;
        private System.Windows.Forms.TextBox fieldName3TB;
        private System.Windows.Forms.Label fieldName4L;
        private System.Windows.Forms.ComboBox fieldNameCB1;
        private System.Windows.Forms.ComboBox fieldNameCB2;
        private System.Windows.Forms.TextBox fieldName4TB;
        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.TextBox newFieldName4TB;
        private System.Windows.Forms.ComboBox newFieldNameCB2;
        private System.Windows.Forms.ComboBox newFieldNameCB1;
        private System.Windows.Forms.Label newFieldName4L;
        private System.Windows.Forms.Label newFieldName3L;
        private System.Windows.Forms.TextBox newFieldName3TB;
        private System.Windows.Forms.Label newFieldName2L;
        private System.Windows.Forms.TextBox newFieldName2TB;
        private System.Windows.Forms.Label newFieldName1L;
        private System.Windows.Forms.TextBox newFieldName1TB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox workAreaGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeNumber;
        private System.Windows.Forms.Button barCodeGenerateButton;
    }
}

