using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeTechTest
{
    public class RequestSQL
    {
        static private SqliteConnection DB;

        static public bool addRequest(string table, string[] param, string fields, string values) {
            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();
            try
            {
                SqliteCommand add = DB.CreateCommand();
                add.CommandText = "INSERT INTO " + table + "(" + fields + ") VALUES(" + values + ")";
                add.Parameters.Add("param1", SqliteType.Text).Value = param[0];
                add.Parameters.Add("param2", SqliteType.Text).Value = param[1];
                add.Parameters.Add("param3", SqliteType.Text).Value = param[2];
                add.Parameters.Add("param4", SqliteType.Text).Value = param[3];
                add.Parameters.Add("param5", SqliteType.Text).Value = param[4];
                add.Parameters.Add("param6", SqliteType.Text).Value = param[5];
                add.ExecuteNonQuery();
            }
            catch (Exception)
            {
                DB.Close();
                return false;
            }
            DB.Close();
            return true;
        }

        static public bool delRequest(string table, string[] param, List<string> fields, List<string> values) {
            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();
            try
            {
                string where = "";

                for (int i = 0; i < fields.Count; i++)
                {
                    where += fields[i] + " = " + values[i];
                    if (i < fields.Count - 1)
                        where += " AND ";
                }

                SqliteCommand del = DB.CreateCommand();
                del.CommandText = "DELETE FROM " + table + " WHERE " + where;
                del.Parameters.Add("param1", SqliteType.Text).Value = param[0];
                del.Parameters.Add("param2", SqliteType.Text).Value = param[1];
                del.Parameters.Add("param3", SqliteType.Text).Value = param[2];
                del.Parameters.Add("param4", SqliteType.Text).Value = param[3];
                del.Parameters.Add("param5", SqliteType.Text).Value = param[4];
                del.Parameters.Add("param6", SqliteType.Text).Value = param[5];
                del.ExecuteNonQuery();
            }
            catch (Exception) {
                DB.Close();
                return false;
            }
            DB.Close();
            return true;
        }

        static public bool updRequest(string table, string[] param, List<string> fields, List<string> values, string where)
        {
            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();
            try
            {
                string setString = "";

                for (int i = 0; i < fields.Count; i++)
                {
                    setString += fields[i] + " = " + values[i];
                    if (i < fields.Count - 1)
                        setString += ", ";
                }

                SqliteCommand upd = DB.CreateCommand();
                upd.CommandText = "UPDATE " + table + " SET " + setString + " WHERE " + where;
                upd.Parameters.Add("param1", SqliteType.Text).Value = param[0];
                upd.Parameters.Add("param2", SqliteType.Text).Value = param[1];
                upd.Parameters.Add("param3", SqliteType.Text).Value = param[2];
                upd.Parameters.Add("param4", SqliteType.Text).Value = param[3];
                upd.Parameters.Add("param5", SqliteType.Text).Value = param[4];
                upd.Parameters.Add("param6", SqliteType.Text).Value = param[5];
                upd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                DB.Close();
                return false;
            }
            DB.Close();
            return true;
        }

        static public List<string> showRequest(string table, List<string> fields)
        {
            List<string> result = new List<string>();
            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();

            SqliteCommand findGoods = DB.CreateCommand();
            findGoods.CommandText = "SELECT * FROM " + table;
            SqliteDataReader reader = findGoods.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < fields.Count; i++)
                    {
                        result.Add(reader[fields[i]].ToString());
                    }
                }
            }
            DB.Close();

            return result;
        }

        static public List<string> cbFill(string field, string table) {
            List<string> cbContent = new List<string>();

            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();

            SqliteCommand findContent = DB.CreateCommand();
            findContent.CommandText = "SELECT " + field + " FROM " + table;
            SqliteDataReader reader = findContent.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbContent.Add(reader[field].ToString());
                }
            }
            DB.Close();

            return cbContent;
        }

        static public string calcRequest(string currencyType, string storageName) {
            string res = "";

            DB = new SqliteConnection("Data Source = store.db3");
            DB.Open();

            SqliteCommand calculate = DB.CreateCommand();
            calculate.CommandText = "SELECT Курс *(SELECT sum(Цена_в_базовой_валюте * Количество_товара_на_складе) FROM (SELECT Цена_в_базовой_валюте, Количество_товара_на_складе FROM (SELECT Товары_на_складе, Количество_товара_на_складе FROM Склады WHERE Название = '" + storageName + "'), Товары WHERE Товары.Название = Товары_на_складе)) FROM Валюты WHERE Название = '" + currencyType + "'";
            res = calculate.ExecuteScalar().ToString();
            
            DB.Close();

            return res;
        }
        
    }
}
