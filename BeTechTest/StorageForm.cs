using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeTechTest
{
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            List<string> cbGoodsContent = RequestSQL.cbFill("Название","Товары");
            for (int i = 0; i < cbGoodsContent.Count; i++)
            {
                goodsCB.Items.Add(cbGoodsContent[i]);
                newGoodsCB.Items.Add(cbGoodsContent[i]);
            }

            List<string> cbCurrencyContent = RequestSQL.cbFill("Название", "Валюты");
            for (int i = 0; i < cbCurrencyContent.Count; i++)
            {
                currencyTypeCB.Items.Add(cbCurrencyContent[i]);
            }
        }

        private bool checker() {
            if (nameTB.Text == "" || addressTB.Text == "" || goodsCB.Text == "" || amountTB.Text == "")
                return false;

            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && goodsCB.Text != "" && amountTB.Text != "")
            {  
                try
                {
                    Convert.ToDouble(amountTB.Text);

                    string[] param = new string[6] { nameTB.Text, addressTB.Text, goodsCB.Text, amountTB.Text, "", "" };
                    string values = "@param1, @param2, @param3, @param4";
                    string fields = "Название, Адрес, Товары_на_складе, Количество_товара_на_складе";

                    bool check = RequestSQL.addRequest("Склады", param, fields, values);
                    if (check)
                        MessageBox.Show("Добавлено");
                    else
                        MessageBox.Show("Возможно, этот товар уже есть на этом складе", "Что-то пошло не так");
                }
                catch
                {
                    MessageBox.Show("Возможно, неверно введено количество (прим. Количество = 10,0)", "Что-то пошло не так");
                }
            }
            else
            {
                MessageBox.Show("Поля для заполнения: Название, Адрес, Товары на складе, Количество", "Не все поля запонлены");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && addressTB.Text != "" && goodsCB.Text != "")
            {
                string[] param = new string[6] { nameTB.Text, addressTB.Text, goodsCB.Text, "", "", "" };
                List<string> values = new List<string>() { "@param1", "@param2", "@param3" };
                List<string> fields = new List<string>() { "Название", "Адрес", "Товары_на_складе" };

                bool check = RequestSQL.delRequest("Склады", param, fields, values);
                if (check)
                    MessageBox.Show("Удалено");
                else
                    MessageBox.Show("Возможно, этого товара нет в таблице", "Что-то пошло не так");
            }
            else
            {
                MessageBox.Show("Поля для заполнения: Название, Адрес, Товары на складе", "Не все поля запонлены");

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && goodsCB.Text != "" &&
                newNameTB.Text != "" && newAddressTB.Text != "" && newGoodsCB.Text != "" && newAmountTB.Text != "")
            {
                string[] param = new string[6] { newNameTB.Text, newAddressTB.Text, newGoodsCB.Text, newAmountTB.Text, "", "" };
                List<string> values = new List<string>() { "@param1", "@param2", "@param3", "@param4" };
                List<string> fields = new List<string>() { "Название", "Адрес", "Товары_на_складе", "Количество_товара_на_складе" };
                string where = "Название = '" + nameTB.Text + "' AND Товары_на_складе = '" + goodsCB.Text + "'";

                bool check = RequestSQL.updRequest("Склады", param, fields, values, where);
                if (check)
                    MessageBox.Show("Изменено");
                else
                    MessageBox.Show("Возможно, этого товара нет в таблице", "Что-то пошло не так");
            }
            else
            {
                MessageBox.Show("Поля для заполнения: Название, Товары на складе, Новое название, Новый адрес, Товары на складе, Новое количество", "Не все поля запонлены");

            }
        }

        private void showTableButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            dbDataGridView.Rows.Clear();
            List<string> fields = new List<string>() { "Название", "Адрес", "Товары_на_складе", "Количество_товара_на_складе" };
            List<string> table = RequestSQL.showRequest("Склады", fields);

            string[] gridRows = new string[fields.Count];
            for (int i = 0; i < table.Count/fields.Count; i++)
            {
                for (int j = fields.Count * i; j < fields.Count * i + fields.Count; j++)
                {
                    gridRows[counter] = table[j];
                    counter++;
                }
                counter = 0;

                dbDataGridView.Rows.Add(gridRows);
            }            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "" && currencyTypeCB.Text != "")
            {                
                totalValueTB.Text = RequestSQL.calcRequest(currencyTypeCB.Text, nameTB.Text); 
            }
            else
            {
                MessageBox.Show("Поля для заполнения: Название, Валюта", "Не все поля запонлены");
            }
        }
    }
}
