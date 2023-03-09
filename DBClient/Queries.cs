using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClient
{
    class Queries
    {
        #region Dynamic TableChange

        #region Клиенты
        public static void ChangeClientName(int client_id, string client_name)
        {
            SqlConnections.journal.AppendLine("[TABLE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - ");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeClientName, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@client_name", client_name);
            SqlConnections.cmd.ExecuteNonQuery();

            SqlConnections.journal.Append("имя изменено на \"" + client_name + "\"\n");
        }
        public static void ChangeClientPhone(int client_id, string phone)
        {
            SqlConnections.journal.AppendLine("[TABLE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - ");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeClientPhone, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@phone", phone);
            SqlConnections.cmd.ExecuteNonQuery();

            SqlConnections.journal.Append("телефон изменен на \"" + phone + "\"\n");
        }
        public static void ChangeClientEmail(int client_id, string email)
        {
            SqlConnections.journal.AppendLine("[TABLE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - ");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeClientEmail, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@email", email);
            SqlConnections.cmd.ExecuteNonQuery();

            SqlConnections.journal.Append("email изменен на \"" + email + "\"\n");
        }
        public static void ChangeClientCredit(int client_id, int client_credit)
        {
            SqlConnections.journal.AppendLine("[TABLE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - ");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeClientCredit, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@client_credit", client_credit);
            SqlConnections.cmd.ExecuteNonQuery();

            SqlConnections.journal.Append("кредит изменен на \"" + client_credit + "\"\n");
        }
        public static void ChangeClientBalance(int client_id, int client_balance)
        {
            SqlConnections.journal.AppendLine("[TABLE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - ");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeClientBalance, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@client_balance", client_balance);
            SqlConnections.cmd.ExecuteNonQuery();

            SqlConnections.journal.Append("баланс изменен на \"" + client_balance + "\"\n");
        }
        #endregion Клиенты

        #region Финансы

        public static void ChangeFinanceDate(DateTime date, int client_id, int payment)
        {
            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeFinanceDate, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@date", date);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@payment", payment);

            SqlConnections.cmd.ExecuteNonQuery();
        }

        public static void ChangeFinanceName(int client_id, string client_name)
        {
            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeFinanceName, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@client_name", client_name);
            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void ChangeFinancePayment(DateTime date, int client_id, int payment)
        {
            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeFinancePayment, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@payment", payment);
            SqlConnections.cmd.Parameters.AddWithValue("@date", date);
            SqlConnections.cmd.ExecuteNonQuery();
        }
        #endregion Финансы

        #endregion Dynamic TableChange

        #region HandChangeItems
        public static void CheckItemExists(string item_type, string item_material, int item_price)
        {
            SqlConnections.cmd = new SqlCommand(Properties.Resources.CheckItemExists, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@item_type", item_type);
            SqlConnections.cmd.Parameters.AddWithValue("@item_material", item_material);
            SqlConnections.cmd.Parameters.AddWithValue("@item_price", item_price);
            SqlConnections.cmd.ExecuteNonQuery();
        }

        public static void ChangeStorageItemMaterialAndType(string item_type, string item_material, int storage_id, int item_amount)
        {
            SqlConnections.cmd = new SqlCommand(Properties.Resources.ChangeStorageItemMaterialAndType, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@item_type", item_type);
            SqlConnections.cmd.Parameters.AddWithValue("@item_material", item_material);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_amount", item_amount);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        #endregion HandChangeItems

        #region Добавление
        public static void AddClient(string client_name, int manager_id, string phone, string email, int client_credit, int client_balance)
        {
            SqlConnections.journal.AppendLine("[ADD [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + client_name + "\" - добавление объекта с параметрами: [Менеджер] " + GetManagerName(manager_id) + ", [Телефон] " + phone + ", [Email] " + email + ", [Кредит] " + client_credit + ", [Баланс] " + client_balance);

            //добавляем в таблицу Клиенты
            SqlConnections.cmd = new SqlCommand(Properties.Resources.AddClient, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_name", client_name);
            SqlConnections.cmd.Parameters.AddWithValue("@manager_id", manager_id);
            SqlConnections.cmd.Parameters.AddWithValue("@phone", phone);
            SqlConnections.cmd.Parameters.AddWithValue("@email", email);

            SqlConnections.cmd.ExecuteNonQuery();

            //добавляем в таблицу Счет_клиента
            SqlConnections.cmd = new SqlCommand(Properties.Resources.SetClientWallet, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_credit", client_credit);
            SqlConnections.cmd.Parameters.AddWithValue("@client_balance", client_balance);
            SqlConnections.cmd.Parameters.AddWithValue("@client_name", client_name);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void AddPayment(DateTime date, int client_id, int payment)
        {
            SqlConnections.journal.AppendLine("[PAYMENT [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - оплата: " + payment + " рублей, \tвремя: " + date.ToString());
            //добавляем в таблицу Оплата
            SqlConnections.cmd = new SqlCommand(Properties.Resources.AddPayment, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@date", date);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@payment", payment);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void AddShipment(DateTime date, int client_id, int storage_id, int item_id, int item_amount)
        {
            SqlConnections.journal.AppendLine("[SHIPMENT [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - товар: \"" + GetItemName(item_id) + "\", количество: " + item_amount + ", cклад: " + GetStorageName(storage_id) + "\tвремя: " + date.ToString());

            SqlConnections.cmd = new SqlCommand(Properties.Resources.AddShipment, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@date", date);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_id", item_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_amount", item_amount);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void AddNewItem(int storage_id, string item_type, string item_material, int item_price, int item_amount)
        {
            SqlConnections.journal.AppendLine("[ADD [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tТовар \"" + item_type + " - " + item_material + "\" - добавление нового объекта с параметрами: [Цена] " + item_price + ", [Количество] " + item_amount + ", [Склад] " + GetStorageName(storage_id));

            SqlConnections.cmd = new SqlCommand(Properties.Resources.AddNewItem, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_type", item_type);
            SqlConnections.cmd.Parameters.AddWithValue("@item_material", item_material);
            SqlConnections.cmd.Parameters.AddWithValue("@item_price", item_price);
            SqlConnections.cmd.Parameters.AddWithValue("@item_amount", item_amount);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void AddExistingItem(int storage_id, int item_id, int item_amount)
        {
            SqlConnections.journal.AppendLine("[ADD [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tТовар \"" + GetItemName(item_id) + "\" - добавление объекта с параметрами: [Количество] " + item_amount + ", [Склад] " + GetStorageName(storage_id));

            SqlConnections.cmd = new SqlCommand(Properties.Resources.AddExistingItem, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_id", item_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_amount", item_amount);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        #endregion Добавление

        #region Изменение

        public static void ModifyClient(int client_id, string client_name, int manager_id, string phone, string email, int client_credit, int client_balance)
        {
            SqlConnections.journal.AppendLine("[MODIFY [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" - новые параметры: [Имя] " + client_name + " [Менеджер] " + GetManagerName(manager_id) + ", [Телефон] " + phone + ", [Email] " + email + ", [Кредит] " + client_credit + ", [Баланс] " + client_balance);

            //Обновляем данные о клиенте
            SqlConnections.cmd = new SqlCommand(Properties.Resources.UpdateClient, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);
            SqlConnections.cmd.Parameters.AddWithValue("@client_name", client_name);
            SqlConnections.cmd.Parameters.AddWithValue("@manager_id", manager_id);
            SqlConnections.cmd.Parameters.AddWithValue("@phone", phone);
            SqlConnections.cmd.Parameters.AddWithValue("@email", email);
            SqlConnections.cmd.Parameters.AddWithValue("@client_credit", client_credit);
            SqlConnections.cmd.Parameters.AddWithValue("@client_balance", client_balance);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void ModifyItem(int item_id, string item_type, string item_material, int item_price)
        {
            SqlConnections.journal.AppendLine("[MODIFY [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tТовар \"" + GetItemName(item_id) + "\" - новые параметры: [Тип] " + item_type + " [Материал] " + item_material + ", [Цена] " + item_price);

            //Обновляем данные о товаре
            SqlConnections.cmd = new SqlCommand(Properties.Resources.UpdateItem, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@item_id", item_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_type", item_type);
            SqlConnections.cmd.Parameters.AddWithValue("@item_material", item_material);
            SqlConnections.cmd.Parameters.AddWithValue("@item_price", item_price);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void ModifyStorage(int storage_id, string storage_name, int storage_capacity)
        {
            SqlConnections.journal.AppendLine("[MODIFY [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tСклад \"" + GetStorageName(storage_id) + "\" - новые параметры: [Название] " + storage_name + " [Вместимость] " + storage_capacity);

            //Обновляем данные о товаре
            SqlConnections.cmd = new SqlCommand(Properties.Resources.UpdateStorage, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_name", storage_name);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_capacity", storage_capacity);

            SqlConnections.cmd.ExecuteNonQuery();
        }

        #endregion Изменение

        #region Удаление

        public static void RemoveClient(int client_id)
        {
            SqlConnections.journal.AppendLine("[DELETE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tКлиент \"" + GetClientName(client_id) + "\" удален");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.RemoveClient, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void RemoveItem(int item_id)
        {
            SqlConnections.journal.AppendLine("[DELETE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tТовар \"" + GetItemName(item_id) + "\" удален");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.RemoveItem, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@item_id", item_id);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void RemoveStorage(int storage_id)
        {
            SqlConnections.journal.AppendLine("[DELETE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tСклад \"" + GetStorageName(storage_id) + "\" удален");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.RemoveStorage, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);

            SqlConnections.cmd.ExecuteNonQuery();
        }
        public static void RemoveItemFromStorage(int storage_id, int item_id, int item_amount)
        {
            SqlConnections.journal.AppendLine("[UPDATE [" + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + "]]\tОбновлены данные о складе \"" + GetStorageName(storage_id) + "\" [Товар] " + GetItemName(item_id) + " удален");

            SqlConnections.cmd = new SqlCommand(Properties.Resources.RemoveItemFromStorage, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_id", item_id);
            SqlConnections.cmd.Parameters.AddWithValue("@item_amount", item_amount);

            SqlConnections.cmd.ExecuteNonQuery();
        }

        #endregion Удаление

        #region GetValue
        public static int GetStorageID(string storage_name)
        {
            int id = 1;
            //получаем id склада по имени
            SqlConnections.cmd.CommandText = "SELECT storage_id FROM Склад where storage_name = '" + storage_name + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id склада по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return id;
        }
        public static int GetItemID(string item_type, string item_material)
        {
            int id = 1;
            //получаем id товара по имени
            SqlConnections.cmd.CommandText = "SELECT item_id FROM Товар where item_type = '" + item_type + "' AND item_material = '" + item_material + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id товара по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return id;
        }
        public static int GetClientID(string client_name)
        {
            int id = 1;
            //получаем id клиента по имени
            SqlConnections.cmd.CommandText = "SELECT client_id FROM Клиенты where client_name = '" + client_name + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id клиента по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return id;
        }
        public static int GetManagerID(string manager_name)
        {
            int id = 1;
            //получаем id менеджера по имени
            SqlConnections.cmd.CommandText = "SELECT manager_id FROM Менеджеры where manager_name = '" + manager_name + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id менеджера по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return id;
        }

        public static string GetStorageName(int storage_id)
        {
            string name = "";
            SqlConnections.cmd.CommandText = "SELECT storage_name FROM Склад where storage_id = " + storage_id + ";";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return name;
        }
        public static string GetItemName(int item_id)
        {
            string item_name = "";
            SqlConnections.cmd.CommandText = "SELECT item_type, item_material FROM Товар where item_id = " + item_id;
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    item_name = Convert.ToString(reader.GetValue(0)) + " - " + Convert.ToString(reader.GetValue(1));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return item_name;
        }
        public static string GetClientName(int client_id)
        {
            string name = "";
            SqlConnections.cmd.CommandText = "SELECT client_name FROM Клиенты where client_id = " + client_id + ";";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return name;
        }
        public static string GetManagerName(int manager_id)
        {
            string name = "";
            SqlConnections.cmd.CommandText = "SELECT manager_name FROM Менеджеры where manager_id = " + manager_id + ";";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return name;
        }

        #endregion GetValue

        public static bool CheckItemFitsStorage(int storage_id, int addAmount)
        {
            bool check = false;
            int capacity = 0;
            int amount = 0;
            SqlConnections.cmd = new SqlCommand(Properties.Resources.CheckItemFitsStorage, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@storage_id", storage_id);
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    capacity = Convert.ToInt32(reader.GetValue(0));
                    amount = Convert.ToInt32(reader.GetValue(1));
                }
                reader.Close();

                if (capacity >= amount + addAmount)
                    check = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return check;
        }

        #region Поиск идентичных значений
        public static int SearchObject(string table_name, string column_name, string value)
        {
            int count = 0;
            SqlConnections.cmd = new SqlCommand(Properties.Resources.SearchObject, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@table_name", table_name);
            SqlConnections.cmd.Parameters.AddWithValue("@column_name", column_name);
            SqlConnections.cmd.Parameters.AddWithValue("@value", value);

            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return count;
        }

        public static int SearchObject(string table_name, string column_name, string value, string column_name2, string value2)
        {
            int count = 0;
            SqlConnections.cmd = new SqlCommand(Properties.Resources.SearchItem, SqlConnections.connection);
            SqlConnections.cmd.Parameters.AddWithValue("@table_name", table_name);
            SqlConnections.cmd.Parameters.AddWithValue("@column_name", column_name);
            SqlConnections.cmd.Parameters.AddWithValue("@value", value);
            SqlConnections.cmd.Parameters.AddWithValue("@column_name2", column_name2);
            SqlConnections.cmd.Parameters.AddWithValue("@value2", value2);

            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка\n" + ex);
            }
            return count;
        }
        #endregion Поиск идентичных значений

    }
}
