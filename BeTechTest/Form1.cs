using Microsoft.Data.Sqlite;
using Newtonsoft.Json.Linq;
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
    public partial class MainForm : Form
    {
        private SqliteConnection DB;
        int tablesIdentificator = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();

            SqliteCommand checkData = DB.CreateCommand();
            checkData.CommandText = "SELECT Дата_обновления FROM Валюты WHERE Код = 'USD'";
            string date = checkData.ExecuteScalar().ToString();
            DB.Close();

            string dateNow = DateTime.Now.ToString("dd.MM.yyyy");

            if (date != dateNow)
            {
                DialogResult result = MessageBox.Show(
                    "Обновить курсы валют?",
                    "Курсы валют устарели",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    currencyRateSynchronizer();
                    goodsPriceSynchronizer();
                }
            }
        }

        private void goodsButton_Click(object sender, EventArgs e)
        {
            workAreaGB.Visible = true;
            managementL.Visible = true;
            addButton.Visible = true;
            deleteButton.Visible = true;
            editButton.Visible = true;
            showTableButton.Visible = true;
            barCodeGenerateButton.Visible = true;

            fieldName2TB.Visible = true;
            fieldName3TB.Visible = false;
            fieldName4TB.Visible = false;
            fieldNameCB1.Visible = true;
            fieldNameCB2.Visible = true;
            newFieldName2TB.Visible = true;
            newFieldName3TB.Visible = false;
            newFieldName4TB.Visible = false;
            newFieldNameCB1.Visible = true;
            newFieldNameCB2.Visible = true;
            fieldName1L.Text = "Название";
            fieldName2L.Text = "Цена";
            fieldName3L.Text = "Категория товара";
            fieldName4L.Text = "Валюта";
            newFieldName1L.Text = "Новое название";
            newFieldName2L.Text = "Новая цена";
            newFieldName3L.Text = "Новая категория товара";
            newFieldName4L.Text = "Новая валюта";

            dbDataGridView.Columns.Clear();
            dbDataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn() { HeaderText = "Название" },
                new DataGridViewTextBoxColumn() { HeaderText = "Цена в базовой валюте" },
                new DataGridViewTextBoxColumn() { HeaderText = "Цена" },
                new DataGridViewTextBoxColumn() { HeaderText = "Категория товара" },
                new DataGridViewTextBoxColumn() { HeaderText = "Валюта" },
                new DataGridViewTextBoxColumn() { HeaderText = "Номер штрих кода" });

            fieldNameCB1.Items.Clear();
            newFieldNameCB1.Items.Clear();
            fieldNameCB2.Items.Clear();
            newFieldNameCB2.Items.Clear();

            List<string> cbCategoryContent = RequestSQL.cbFill("Категории_товара", "Категории_товара");
            for (int i = 0; i < cbCategoryContent.Count; i++)
            {
                fieldNameCB1.Items.Add(cbCategoryContent[i]);
                newFieldNameCB1.Items.Add(cbCategoryContent[i]);
            }

            List<string> cbCurrencyContent = RequestSQL.cbFill("Название", "Валюты");
            for (int i = 0; i < cbCurrencyContent.Count; i++)
            {
                fieldNameCB2.Items.Add(cbCurrencyContent[i]);
                newFieldNameCB2.Items.Add(cbCurrencyContent[i]);
            }

            tablesIdentificator = 1;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            workAreaGB.Visible = true;
            managementL.Visible = true;
            addButton.Visible = true;
            deleteButton.Visible = true;
            editButton.Visible = true;
            showTableButton.Visible = true;
            barCodeGenerateButton.Visible = false;

            fieldName2TB.Visible = false;
            fieldName3TB.Visible = false;
            fieldName4TB.Visible = false;
            fieldNameCB1.Visible = false;
            fieldNameCB2.Visible = false;
            newFieldName2TB.Visible = false;
            newFieldName3TB.Visible = false;
            newFieldName4TB.Visible = false;
            newFieldNameCB1.Visible = false;
            newFieldNameCB2.Visible = false;
            fieldName1L.Text = "Категория товара";
            fieldName2L.Text = "";
            fieldName3L.Text = "";
            fieldName4L.Text = "";
            newFieldName1L.Text = "Новая ктегория";
            newFieldName2L.Text = "";
            newFieldName3L.Text = "";
            newFieldName4L.Text = "";

            dbDataGridView.Columns.Clear();
            dbDataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn() { HeaderText = "Категории товара" });

            tablesIdentificator = 2;
        }

        private void storageButton_Click(object sender, EventArgs e)
        {
            StorageForm storageF = new StorageForm();
            storageF.Show();
        }

        private void currencyButton_Click(object sender, EventArgs e)
        {
            workAreaGB.Visible = true;
            managementL.Visible = true;
            addButton.Visible = true;
            deleteButton.Visible = true;
            editButton.Visible = true;
            showTableButton.Visible = true;
            barCodeGenerateButton.Visible = false;

            fieldName2TB.Visible = true;
            fieldName3TB.Visible = true;
            fieldName4TB.Visible = true;
            fieldNameCB1.Visible = false;
            fieldNameCB2.Visible = false;
            newFieldName2TB.Visible = true;
            newFieldName3TB.Visible = true;
            newFieldName4TB.Visible = true;
            newFieldNameCB1.Visible = false;
            newFieldNameCB2.Visible = false;
            fieldName1L.Text = "Название";
            fieldName2L.Text = "Код";
            fieldName3L.Text = "Курс";
            fieldName4L.Text = "Дата обновления";
            newFieldName1L.Text = "Новое название";
            newFieldName2L.Text = "Новый код";
            newFieldName3L.Text = "Новый курс";
            newFieldName4L.Text = "Дата обновления";

            dbDataGridView.Columns.Clear();
            dbDataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn() { HeaderText = "Название" },
                new DataGridViewTextBoxColumn() { HeaderText = "Код" },
                new DataGridViewTextBoxColumn() { HeaderText = "Курс" },
                new DataGridViewTextBoxColumn() { HeaderText = "Дата обновления" });

            tablesIdentificator = 3;
        }

        private void currencyRateSynchronizer() {
            var request = new GetRequest("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew?json");
            request.Run();

            var response = request.Response;

            var jArray = JArray.Parse(response);

            double dollarCurency = 0;

            DB.Open();
            foreach (var token in jArray)
            {
                if (token["cc"].ToString() == "USD")
                {
                    dollarCurency = (double)token["rate"];
                    SqliteCommand synchronizeUAHandUSD = DB.CreateCommand();
                    synchronizeUAHandUSD.CommandText = "UPDATE Валюты SET Курс = @currency, Дата_обновления = @date WHERE Код = 'UAH'";
                    synchronizeUAHandUSD.Parameters.Add("currency", SqliteType.Real).Value = dollarCurency;
                    synchronizeUAHandUSD.Parameters.Add("date", SqliteType.Text).Value = DateTime.Now.ToString("dd.MM.yyyy");
                    synchronizeUAHandUSD.ExecuteNonQuery();

                    synchronizeUAHandUSD.CommandText = "UPDATE Валюты SET Дата_обновления = @date WHERE Код = 'USD'";                   
                    synchronizeUAHandUSD.ExecuteNonQuery();
                }
            }


            SqliteCommand findCodes = DB.CreateCommand();
            findCodes.CommandText = "SELECT Код FROM Валюты";
            SqliteDataReader reader = findCodes.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    foreach (var token in jArray)
                    {
                        if (reader["Код"].ToString() == token["cc"].ToString() && token["cc"].ToString() != "USD"){                            
                            SqliteCommand synchronizeCurrency = DB.CreateCommand();
                            synchronizeCurrency.CommandText = "UPDATE Валюты SET Курс = @currency, Дата_обновления = @date WHERE Код = @code";
                            synchronizeCurrency.Parameters.Add("currency", SqliteType.Real).Value = dollarCurency / (double)token["rate"];
                            synchronizeCurrency.Parameters.Add("date", SqliteType.Text).Value = DateTime.Now.ToString("dd.MM.yyyy");
                            synchronizeCurrency.Parameters.Add("code", SqliteType.Text).Value = reader["Код"];
                            synchronizeCurrency.ExecuteNonQuery();
                        }
                    }
                }
            }
            DB.Close();
        }

        private void goodsPriceSynchronizer() {
            DB.Open();
            SqliteCommand synchronizePrice = DB.CreateCommand();
            synchronizePrice.CommandText = "UPDATE Товары SET Цена_в_базовой_валюте = Цена / (SELECT Курс FROM Валюты WHERE Название = Товары.Валюта)";
            synchronizePrice.ExecuteNonQuery();
            DB.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fields = "";
            string values = "";
            string table = "";
            string[] param = new string[6];
            string strToDouble = "0";

            switch (tablesIdentificator) {
                case 1:

                    if (fieldName1TB.Text != "" && fieldName2TB.Text != "" && fieldNameCB1.Text != "" && fieldNameCB2.Text != "")
                    {
                        DB.Open();
                        string newCode = "";
                        try
                        {
                            
                            SqliteCommand lastCode = DB.CreateCommand();
                            lastCode.CommandText = "SELECT Номер_штрих_кода FROM Товары ORDER BY Номер_штрих_кода DESC LIMIT 1";
                            int lastCodeValue = Int32.Parse(lastCode.ExecuteScalar().ToString()) + 1;
                            newCode = lastCodeValue.ToString();
                            while (newCode.Length < 8)
                            {
                                newCode = newCode.Insert(0, "0");
                            }
                        }
                        catch {
                            newCode = "00000001";
                        }

                        SqliteCommand price = DB.CreateCommand();
                        price.CommandText = "SELECT Курс FROM Валюты WHERE Название = '" + fieldNameCB2.Text + "'";
                        double priceValue = Convert.ToDouble(fieldName2TB.Text) / Convert.ToDouble(price.ExecuteScalar().ToString());

                        table = "Товары";
                        values = "@param1, @param2, @param3, @param4, @param5, @param6";
                        fields = "Название, Цена_в_базовой_валюте, Цена, Категория_товара, Валюта, Номер_штрих_кода";
                        param = new string[6] { fieldName1TB.Text, priceValue.ToString() , fieldName2TB.Text, fieldNameCB1.Text, fieldNameCB2.Text, newCode };
                        strToDouble = fieldName2TB.Text;
                        DB.Close();
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название, Цена, Категория товара, Валюта", "Не все поля запонлены");
                    }

                    break;

                case 2:
                    if (fieldName1TB.Text != "")
                    {
                        table = "Категории_товара";
                        values = "@param1";
                        fields = "Категории_товара";
                        param = new string[6] { fieldName1TB.Text, "", "", "", "", "" };
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Категория товара", "Не все поля запонлены");
                    }
                    break;

                case 3:
                    if (fieldName1TB.Text != "" && fieldName2TB.Text != "" && fieldName3TB.Text != "" && fieldName4TB.Text != "")
                    {
                        table = "Валюты";
                        values = "@param1, @param2, @param3, @param4";
                        fields = "Название, Код, Курс, Дата_обновления";
                        param = new string[6] { fieldName1TB.Text, fieldName2TB.Text, fieldName3TB.Text, fieldName4TB.Text, "", "" };
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название, Код, Курс, Дата обновления", "Не все поля запонлены");
                    }
                    break;
            }

            try
            {
                Convert.ToDouble(strToDouble);

                

                bool check = RequestSQL.addRequest(table, param, fields, values);
                if (check)
                    MessageBox.Show("Добавлено");
                else
                    MessageBox.Show("Возможно, этот товар уже есть на этом складе", "Что-то пошло не так");
            }
            catch
            {
                MessageBox.Show("Возможно, неверно введены цифры (прим. 10,0)", "Что-то пошло не так");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string table = "";
            string[] param = new string[6];
            List<string> values = new List<string>();
            List<string> fields = new List<string>();

            switch (tablesIdentificator)
            {
                case 1:
                    if (fieldName1TB.Text != "")
                    {
                        table = "Товары";
                        param = new string[6] { fieldName1TB.Text, "", "", "", "", "" };
                        values.Add("@param1");
                        fields.Add("Название");
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название", "Не все поля запонлены");

                    }
                    break;

                case 2:
                    if (fieldName1TB.Text != "")
                    {
                        table = "Категории_товара";
                        param = new string[6] { fieldName1TB.Text, "", "", "", "", "" };
                        values.Add("@param1");
                        fields.Add("Категории_товара");
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Категория товара", "Не все поля запонлены");

                    }
                    break;

                case 3:
                    if (fieldName1TB.Text != "")
                    {
                        table = "Валюты";
                        param = new string[6] { fieldName1TB.Text, "", "", "", "", "" };
                        values.Add("@param1");
                        fields.Add("Название");
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название", "Не все поля запонлены");

                    }
                    break;
            }

                bool check = RequestSQL.delRequest(table, param, fields, values);
                if (check)
                    MessageBox.Show("Удалено");
                else
                    MessageBox.Show("Возможно, этого товара нет в таблице", "Что-то пошло не так");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string table = "";
            string where = "";
            string strToDouble = "0";
            string[] param = new string[6];
            List<string> values = new List<string>();
            List<string> fields = new List<string>();

            switch (tablesIdentificator) {
                case 1:
                    if (fieldName1TB.Text != "" &&
                        newFieldName1TB.Text != "" && newFieldName2TB.Text != "" && newFieldNameCB1.Text != "" && newFieldNameCB2.Text != "")
                    {
                        table = "Товары";
                        where = "Название = '" + fieldName1TB.Text + "'";

                        DB.Open();
                        SqliteCommand price = DB.CreateCommand();
                        price.CommandText = "SELECT Курс FROM Валюты WHERE Название = '" + newFieldNameCB2.Text + "'";
                        double priceValue = Convert.ToDouble(newFieldName2TB.Text) / Convert.ToDouble(price.ExecuteScalar().ToString());
                        DB.Close();

                        values.Add("@param1");
                        values.Add("@param2");
                        values.Add("@param3");
                        values.Add("@param4");
                        values.Add("@param5");

                        fields.Add("Название");
                        fields.Add("Цена_в_базовой_валюте");
                        fields.Add("Цена");
                        fields.Add("Категория_товара");
                        fields.Add("Валюта");

                        param[0] = newFieldName1TB.Text;
                        param[1] = priceValue.ToString();
                        param[2] = newFieldName2TB.Text;
                        param[3] = newFieldNameCB1.Text;
                        param[4] = newFieldNameCB2.Text;

                        strToDouble = newFieldName2TB.Text;
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название, Новое название, Новая цена, Новая категория товара, Новая валюта");
                    }
                    break;

                case 2:
                    if (fieldName1TB.Text != "" && newFieldName1TB.Text != "")
                    {
                        table = "Категории_товара";
                        where = "Категории_товара = '" + fieldName1TB.Text + "'";
                        values.Add("@param1");
                        fields.Add("Категории_товара");
                        param = new string[6] { newFieldName1TB.Text, "", "", "", "", "" };
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Категория товара, Новая категория", "Не все поля запонлены");
                    }
                    break;

                case 3:
                    if (fieldName1TB.Text != "" && 
                        newFieldName1TB.Text != "" && newFieldName2TB.Text != "" && newFieldName3TB.Text != "" && newFieldName4TB.Text != "")
                    {
                        table = "Валюты";
                        where = "Название = '" + fieldName1TB.Text + "'";

                        values.Add("@param1");
                        values.Add("@param2");
                        values.Add("@param3");
                        values.Add("@param4");

                        fields.Add("Название");
                        fields.Add("Код");
                        fields.Add("Курс");
                        fields.Add("Дата_обновления");

                        param[0] = newFieldName1TB.Text;
                        param[1] = newFieldName2TB.Text;
                        param[2] = newFieldName3TB.Text;
                        param[3] = newFieldName4TB.Text;

                        strToDouble = newFieldName3TB.Text;
                        param = new string[6] { newFieldName1TB.Text, newFieldName2TB.Text, newFieldName3TB.Text, newFieldName4TB.Text, "", "" };
                    }
                    else
                    {
                        MessageBox.Show("Поля для заполнения: Название, Новое название, Новый код, Новый курс, Дата обновления", "Не все поля запонлены");
                    }
                    break;
            }

            try
            {
                Convert.ToDouble(strToDouble);



                bool check = RequestSQL.updRequest(table, param, fields, values, where);
                if (check)
                    MessageBox.Show("Изменено");
                else
                    MessageBox.Show("Возможно, этого товара нет в таблице", "Что-то пошло не так");
            }
            catch
            {
                MessageBox.Show("Возможно, неверно введены цифры (прим. 10,0)", "Что-то пошло не так");
            }           
        }

        private void showTableButton_Click(object sender, EventArgs e)
        {
            List<string> fields = new List<string>();
            string tableName = "";

            switch (tablesIdentificator)
            {
                case 1:
                    tableName = "Товары";
                    fields.Add("Название");
                    fields.Add("Цена_в_базовой_валюте");
                    fields.Add("Цена");
                    fields.Add("Категория_товара");
                    fields.Add("Валюта");
                    fields.Add("Номер_штрих_кода");
                    break;
                case 2:
                    tableName = "Категории_товара";
                    fields.Add("Категории_товара");
                    break;
                case 3:
                    tableName = "Валюты";
                    fields.Add("Название");
                    fields.Add("Код");
                    fields.Add("Курс");
                    fields.Add("Дата_обновления");
                    break;
            }

            int counter = 0;
            dbDataGridView.Rows.Clear();
            List<string> table = RequestSQL.showRequest(tableName, fields);

            string[] gridRows = new string[fields.Count];
            for (int i = 0; i < table.Count / fields.Count; i++)
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

        private void barCodeGenerateButton_Click(object sender, EventArgs e)
        {
            string barCodeNumber = "";

            if (fieldName1TB.Text != "")
            {
                DB.Open();
                SqliteCommand getBarCodeNumber = DB.CreateCommand();
                getBarCodeNumber.CommandText = "SELECT Номер_штрих_кода FROM Товары WHERE Название = '" + fieldName1TB.Text + "'";
                barCodeNumber = getBarCodeNumber.ExecuteScalar().ToString();
                DB.Close();
            }
            else
            {
                MessageBox.Show("Поля для заполнения: Название", "Не все поля запонлены");
            }

            BarCodeViewerForm f = new BarCodeViewerForm(barCodeNumber);
            f.ShowDialog();
        }
    }
}
