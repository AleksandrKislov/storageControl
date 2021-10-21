namespace BeTechTest
{
    partial class StorageForm
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
            this.showTableButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.managementL = new System.Windows.Forms.Label();
            this.goodsL = new System.Windows.Forms.Label();
            this.amountL = new System.Windows.Forms.Label();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.addressL = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.goodsCB = new System.Windows.Forms.ComboBox();
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newGoodsCB = new System.Windows.Forms.ComboBox();
            this.newGoodsL = new System.Windows.Forms.Label();
            this.newAmountL = new System.Windows.Forms.Label();
            this.newAmountTB = new System.Windows.Forms.TextBox();
            this.newAddressL = new System.Windows.Forms.Label();
            this.newAddressTB = new System.Windows.Forms.TextBox();
            this.newNameL = new System.Windows.Forms.Label();
            this.newNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currencyTypeCB = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalValueTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTableButton
            // 
            this.showTableButton.Location = new System.Drawing.Point(275, 42);
            this.showTableButton.Name = "showTableButton";
            this.showTableButton.Size = new System.Drawing.Size(193, 23);
            this.showTableButton.TabIndex = 15;
            this.showTableButton.Text = "Вывести записи на экран";
            this.showTableButton.UseVisualStyleBackColor = true;
            this.showTableButton.Click += new System.EventHandler(this.showTableButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(275, 86);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(193, 23);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Изменить запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(37, 86);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(193, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(37, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(193, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // managementL
            // 
            this.managementL.AutoSize = true;
            this.managementL.Location = new System.Drawing.Point(211, 9);
            this.managementL.Name = "managementL";
            this.managementL.Size = new System.Drawing.Size(88, 17);
            this.managementL.TabIndex = 11;
            this.managementL.Text = "Управнение";
            // 
            // goodsL
            // 
            this.goodsL.AutoSize = true;
            this.goodsL.Location = new System.Drawing.Point(6, 192);
            this.goodsL.Name = "goodsL";
            this.goodsL.Size = new System.Drawing.Size(128, 17);
            this.goodsL.TabIndex = 31;
            this.goodsL.Text = "Товары на складе";
            // 
            // amountL
            // 
            this.amountL.AutoSize = true;
            this.amountL.Location = new System.Drawing.Point(6, 264);
            this.amountL.Name = "amountL";
            this.amountL.Size = new System.Drawing.Size(86, 17);
            this.amountL.TabIndex = 30;
            this.amountL.Text = "Количество";
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(6, 239);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(193, 22);
            this.amountTB.TabIndex = 29;
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Location = new System.Drawing.Point(6, 125);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(48, 17);
            this.addressL.TabIndex = 28;
            this.addressL.Text = "Адрес";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(6, 100);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(193, 22);
            this.addressTB.TabIndex = 27;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(6, 57);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(72, 17);
            this.nameL.TabIndex = 26;
            this.nameL.Text = "Название";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(6, 32);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(193, 22);
            this.nameTB.TabIndex = 25;
            // 
            // goodsCB
            // 
            this.goodsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCB.FormattingEnabled = true;
            this.goodsCB.Location = new System.Drawing.Point(6, 165);
            this.goodsCB.Name = "goodsCB";
            this.goodsCB.Size = new System.Drawing.Size(193, 24);
            this.goodsCB.TabIndex = 36;
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.AllowUserToAddRows = false;
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.goods,
            this.amount});
            this.dbDataGridView.Location = new System.Drawing.Point(502, 42);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.RowTemplate.Height = 24;
            this.dbDataGridView.Size = new System.Drawing.Size(526, 656);
            this.dbDataGridView.TabIndex = 37;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            // 
            // goods
            // 
            this.goods.HeaderText = "Товары на складе";
            this.goods.Name = "goods";
            // 
            // amount
            // 
            this.amount.HeaderText = "Количество товара на складе";
            this.amount.Name = "amount";
            // 
            // newGoodsCB
            // 
            this.newGoodsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newGoodsCB.FormattingEnabled = true;
            this.newGoodsCB.Location = new System.Drawing.Point(263, 196);
            this.newGoodsCB.Name = "newGoodsCB";
            this.newGoodsCB.Size = new System.Drawing.Size(193, 24);
            this.newGoodsCB.TabIndex = 45;
            // 
            // newGoodsL
            // 
            this.newGoodsL.AutoSize = true;
            this.newGoodsL.Location = new System.Drawing.Point(263, 223);
            this.newGoodsL.Name = "newGoodsL";
            this.newGoodsL.Size = new System.Drawing.Size(128, 17);
            this.newGoodsL.TabIndex = 44;
            this.newGoodsL.Text = "Товары на складе";
            // 
            // newAmountL
            // 
            this.newAmountL.AutoSize = true;
            this.newAmountL.Location = new System.Drawing.Point(263, 295);
            this.newAmountL.Name = "newAmountL";
            this.newAmountL.Size = new System.Drawing.Size(129, 17);
            this.newAmountL.TabIndex = 43;
            this.newAmountL.Text = "Новое количество";
            // 
            // newAmountTB
            // 
            this.newAmountTB.Location = new System.Drawing.Point(263, 270);
            this.newAmountTB.Name = "newAmountTB";
            this.newAmountTB.Size = new System.Drawing.Size(193, 22);
            this.newAmountTB.TabIndex = 42;
            // 
            // newAddressL
            // 
            this.newAddressL.AutoSize = true;
            this.newAddressL.Location = new System.Drawing.Point(263, 156);
            this.newAddressL.Name = "newAddressL";
            this.newAddressL.Size = new System.Drawing.Size(94, 17);
            this.newAddressL.TabIndex = 41;
            this.newAddressL.Text = "Новый адрес";
            // 
            // newAddressTB
            // 
            this.newAddressTB.Location = new System.Drawing.Point(263, 131);
            this.newAddressTB.Name = "newAddressTB";
            this.newAddressTB.Size = new System.Drawing.Size(193, 22);
            this.newAddressTB.TabIndex = 40;
            // 
            // newNameL
            // 
            this.newNameL.AutoSize = true;
            this.newNameL.Location = new System.Drawing.Point(263, 88);
            this.newNameL.Name = "newNameL";
            this.newNameL.Size = new System.Drawing.Size(115, 17);
            this.newNameL.TabIndex = 39;
            this.newNameL.Text = "Новое название";
            // 
            // newNameTB
            // 
            this.newNameTB.Location = new System.Drawing.Point(263, 63);
            this.newNameTB.Name = "newNameTB";
            this.newNameTB.Size = new System.Drawing.Size(193, 22);
            this.newNameTB.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.nameL);
            this.groupBox1.Controls.Add(this.addressTB);
            this.groupBox1.Controls.Add(this.addressL);
            this.groupBox1.Controls.Add(this.amountTB);
            this.groupBox1.Controls.Add(this.amountL);
            this.groupBox1.Controls.Add(this.goodsL);
            this.groupBox1.Controls.Add(this.goodsCB);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 323);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить/Удалить запись";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newNameTB);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.newNameL);
            this.groupBox2.Controls.Add(this.newGoodsCB);
            this.groupBox2.Controls.Add(this.newAddressTB);
            this.groupBox2.Controls.Add(this.newGoodsL);
            this.groupBox2.Controls.Add(this.newAddressL);
            this.groupBox2.Controls.Add(this.newAmountL);
            this.groupBox2.Controls.Add(this.newAmountTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(471, 375);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменить запись";
            // 
            // currencyTypeCB
            // 
            this.currencyTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyTypeCB.FormattingEnabled = true;
            this.currencyTypeCB.Location = new System.Drawing.Point(19, 50);
            this.currencyTypeCB.Name = "currencyTypeCB";
            this.currencyTypeCB.Size = new System.Drawing.Size(193, 24);
            this.currencyTypeCB.TabIndex = 48;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CalculateButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.currencyTypeCB);
            this.groupBox3.Controls.Add(this.totalValueTB);
            this.groupBox3.Location = new System.Drawing.Point(12, 530);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 168);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расчет ценности склада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ценность";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(142, 123);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(193, 23);
            this.CalculateButton.TabIndex = 50;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Валюта";
            // 
            // totalValueTB
            // 
            this.totalValueTB.Location = new System.Drawing.Point(263, 52);
            this.totalValueTB.Name = "totalValueTB";
            this.totalValueTB.ReadOnly = true;
            this.totalValueTB.Size = new System.Drawing.Size(193, 22);
            this.totalValueTB.TabIndex = 47;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 710);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dbDataGridView);
            this.Controls.Add(this.showTableButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.managementL);
            this.Name = "StorageForm";
            this.Text = "Склады";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showTableButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label managementL;
        private System.Windows.Forms.Label goodsL;
        private System.Windows.Forms.Label amountL;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ComboBox goodsCB;
        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.ComboBox newGoodsCB;
        private System.Windows.Forms.Label newGoodsL;
        private System.Windows.Forms.Label newAmountL;
        private System.Windows.Forms.TextBox newAmountTB;
        private System.Windows.Forms.Label newAddressL;
        private System.Windows.Forms.TextBox newAddressTB;
        private System.Windows.Forms.Label newNameL;
        private System.Windows.Forms.TextBox newNameTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox currencyTypeCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalValueTB;
    }
}