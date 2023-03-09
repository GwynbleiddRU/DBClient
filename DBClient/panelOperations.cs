using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace DBClient
{
    public partial class panelOperations : UserControl
    {
        MainForm mainForm;
        static string curTable = "dbo.Клиенты";
        public List<string> ColumnNames = new List<string>();
        public List<string> ColumnTypes = new List<string>();

        public panelOperations()
        {
            InitializeComponent();
        }

        public panelOperations(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            SqlConnections.sql = "SELECT * FROM " + curTable;
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);

            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
            SqlConnections.ds = new DataSet();
            SqlConnections.bs = new BindingSource();

            SqlConnections.da.Fill(SqlConnections.ds, curTable);

            tableOutput.AllowUserToAddRows = false;
            tableOutput.DefaultCellStyle.SelectionBackColor = MainForm.appColor;

            updateTableList();
            UpdateClientList();

            ShowData();
        }

        private void ShowData()
        {
            if (SqlConnections.ds.Tables[curTable] != null)
            {
                SqlConnections.ds.Tables[curTable].Clear();
            }

            SqlConnections.sql = "SELECT * FROM ";
            SqlConnections.sql += curTable;
            //SqlConnections.sql += " WHERE Дата = ";
            //SqlConnections.sql += "'" + dateManage.Text + "'";

            SqlConnections.cmd.CommandText = SqlConnections.sql;
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            SqlConnections.da.Fill(SqlConnections.ds, curTable);

            tableOutput.DataSource = SqlConnections.ds.Tables[curTable];                                                                                 //Выводим таблицу в dataGrid

            int curWidth = tableOutput.Width - 50;
            foreach (DataGridViewTextBoxColumn column in tableOutput.Columns)
            {
                column.Width = curWidth / tableOutput.Columns.Count;
            }

            timeLabel.Text = DateTime.Now.ToString();
            accessTimeLabel.Visible = true;
            timeLabel.Visible = true;
        }

        #region ComboBox

        #region ID

        //объединить combobox'ы материал и предмет, передав в них список items (товары) (прим. material = олово, type = трубка -> в комбобокс "олово трубка")
        public void UpdateClientList()
        {
            SqlConnections.cmd.CommandText = "SELECT client_name FROM Клиенты;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    shipmentClientIDList.Items.Add(reader.GetValue(0).ToString());
                    paymentClientIDList.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        #endregion ID

        #region Select Table
        private void updateTableList()                                                                                                                   //Получаем список таблиц базы данных
        {

            SqlConnections.cmd.CommandText = "SELECT * FROM sys.objects WHERE type='U';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) != "Менеджеры" && reader.GetString(0) != "sysdiagrams")
                    {
                        tableList.Items.Add("dbo." + reader.GetString(0));
                        tableResetList.Items.Add("dbo." + reader.GetString(0));
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            curTable = tableList.SelectedItem.ToString();
            //tableOutput.DataSource = SqlConnections.ds.Tables[curTable];                                                                                 //Выводим таблицу в dataGrid

            ShowData();
        }

        #endregion Select Table

        #endregion ComboBox

        #region Table Manage Buttons
        private void addButton_Click(object sender, EventArgs e)                          //Add table row
        {
            DataRow row = SqlConnections.ds.Tables[curTable].NewRow();
            SqlConnections.ds.Tables[curTable].Rows.Add(row);
            //tableOutput.Rows[tableOutput.Rows.Count - 1].Cells[0].Value = DateTime.Today;
        }

        private void reduceButton_Click(object sender, EventArgs e)                       //Remove selected table rows
        {
            foreach (DataGridViewRow r in tableOutput.SelectedRows)
            {
                //int i = r.Index;
                //DataRow rowToDelete = SqlConnections.ds.Tables[curTable].Rows[i];
                //string sql = String.Format("DELETE FROM " + curTable + " WHERE " +);  использовать row_number()


                tableOutput.Rows.Remove(r);
            }
        }

        private void saveIcon_Click(object sender, EventArgs e)                          //Save datagrid as db table
        {
            //SqlConnections.da.Update(SqlConnections.ds, curTable);
            try
            {
                SaveTable(SqlConnections.ds.Tables[curTable]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            saveWarningLabel.Visible = true;
        }

        #endregion Table Manage Buttons

        #region Style
        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                {
                    item.BackColor = MainForm.appColor;
                }
                if (item is BunifuFlatButton)
                {
                    var temp = item as BunifuFlatButton;
                    temp.BackColor = MainForm.appColor;
                    temp.colselected = MainForm.appColor;
                    temp.colhover = MainForm.appColor;
                    temp.colbackground = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(6, 181, 126))
                    { temp.ForeColor = Color.FromArgb(89, 205, 169); temp.OnHovercolor = Color.FromArgb(89, 205, 169); temp.Textcolor = Color.White; temp.OnHoverTextColor = Color.White; }
                    else if (MainForm.appColor == Color.FromArgb(228, 231, 235))
                    { temp.ForeColor = Color.FromArgb(152, 154, 156); temp.OnHovercolor = Color.FromArgb(152, 154, 156); temp.Textcolor = Color.FromArgb(37, 46, 59); temp.OnHoverTextColor = Color.FromArgb(37, 46, 59); }
                    else { temp.ForeColor = Color.FromArgb(85, 153, 221); temp.OnHovercolor = Color.FromArgb(85, 153, 221); temp.Textcolor = Color.White; temp.OnHoverTextColor = Color.White; }
                }
                if (item.Name.Contains("header"))
                    item.ForeColor = MainForm.appColor;
                if (item is BunifuImageButton)
                {
                    item.BackColor = Color.Transparent;
                }
                if (item is BunifuCustomDataGrid)
                {
                    var temp = item as BunifuCustomDataGrid;
                    temp.HeaderBgColor = MainForm.appColor;
                    temp.DefaultCellStyle.SelectionBackColor = MainForm.appColor;

                    //temp.AlternatingRowsDefaultCellStyle.SelectionBackColor = DBClient.appColor;
                    //temp.RowsDefaultCellStyle.SelectionBackColor = DBClient.appColor;

                    if (MainForm.appColor == Color.FromArgb(228, 231, 235)) { temp.HeaderForeColor = Color.FromArgb(37, 46, 59); temp.DefaultCellStyle.SelectionForeColor = Color.FromArgb(37, 46, 59); }
                    else { temp.HeaderForeColor = Color.Gainsboro; temp.DefaultCellStyle.SelectionForeColor = Color.Gainsboro; }
                }
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }

        //Selected Item Color ComboBox
        #region ComboBox.DrawItem
        private void FillColorComboBox(object sender, DrawItemEventArgs e, Color selectColor, Color font)
        {
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(selectColor), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(font),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

#pragma warning disable IDE1006 // Стили именования
        private void tableList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
#pragma warning disable IDE1006 // Стили именования
        private void shipmentClientIDList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
#pragma warning disable IDE1006 // Стили именования
        private void shipmentItemTypeList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
#pragma warning disable IDE1006 // Стили именования
        private void shipmentItemMaterialList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
#pragma warning disable IDE1006 // Стили именования
        private void paymentClientIDList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
#pragma warning disable IDE1006 // Стили именования
        private void tableResetList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
#pragma warning restore IDE1006 // Стили именования
        #endregion ComboBox.DrawItem

        private void Operations_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        #endregion Style

        //получаем имена и типы колонок
        public void GetColumnsNamesAndTypes()
        {
            ColumnNames.Clear();
            ColumnTypes.Clear();

            SqlConnections.cmd = new SqlCommand(@"SELECT column_name, data_type
            FROM information_schema.columns
            WHERE table_schema = 'dbo'
            AND table_name = '" + curTable + "';", SqlConnections.connection);

            using (var reader = SqlConnections.cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ColumnNames.Add(reader.GetValue(0).ToString());
                    ColumnTypes.Add(reader.GetValue(1).ToString());
                }
            }
        }

        //public void SaveTable()
        //{
        //    try
        //    {
        //        SqlCommandBuilder MyCommandBuilder = new SqlCommandBuilder(SqlConnections.da);
        //        SqlConnections.da.UpdateCommand = MyCommandBuilder.GetUpdateCommand(true);
        //        SqlConnections.da.DeleteCommand = MyCommandBuilder.GetDeleteCommand(true);
        //        SqlConnections.da.InsertCommand = MyCommandBuilder.GetInsertCommand(true);
        //        //тут код
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        //}

        public void SaveTable(DataTable data)   //update table in db (doesnt insert new rows added during app works)
        {
            string identity = getIdentityField();
            foreach (DataRow row in data.Rows)
            {
                string sql = "UPDATE " + curTable + " SET ";
                foreach (DataColumn column in data.Columns)
                {
                    if (!column.ColumnName.Equals(identity))
                    {
                        if (column.DataType == Type.GetType("System.Int16") || column.DataType == System.Type.GetType("System.Int32") || column.DataType == System.Type.GetType("System.Int64") || column.DataType == System.Type.GetType("System.Decimal"))
                            sql += column.ColumnName + " = " + row[column];
                        else
                            sql += column.ColumnName + " = '" + row[column] + "'";
                        if (data.Columns.IndexOf(column) < data.Columns.Count - 1)
                            sql += ", ";
                    }
                }
                sql += " WHERE " + identity + " = " + row[identity];
                SqlCommand command = new SqlCommand(sql, SqlConnections.connection);
                //SqlConnections.connection.Open();
                command.ExecuteNonQuery();
                //SqlConnections.connection.Close();
            }
        }
        private String getIdentityField() //get identity field of table
        {
            //========================
            string query = "SELECT all_columns.name " +
                                 "FROM sys.tables " +
                                 "INNER JOIN sys.all_columns " +
                                 "ON tables.object_id = all_columns.object_id " +
                                 "WHERE tables.name = '" + curTable + "' AND " +
                                 "all_columns.is_identity = 1";
            SqlCommand command = new SqlCommand(query, SqlConnections.connection);
            SqlConnections.da.SelectCommand = command;

            //command.Connection.Open();
            //GET DATA FROM DATABASE
            DataTable trickleFeedData = new DataTable();
            SqlConnections.da.Fill(trickleFeedData);
            //command.Connection.Close();
            //=========================
            if (trickleFeedData.Rows.Count > 0)
                return trickleFeedData.Rows[0].ItemArray[0].ToString();
            else
                return null;

        }

        public void AddClientsTable()
        {
            //GetColumnsNamesAndTypes();

            //MydataAdapter.Update((DataTable)MyBindingSorce.DataSource); // или так
            //////clear previous data
            ////SqlConnections.cmd = new SqlCommand("delete from " + curTable, SqlConnections.connection);

            //SqlConnections.cmd = new SqlCommand("insert into Клиенты(manager_id, client_id, client_name, phone, email) " +
            //    "values(@manager_id, @client_id, @client_name, @phone, @email)", SqlConnections.connection);

            //SqlConnections.cmd.Parameters.Add(new SqlParameter("@manager_id", SqlDbType.VarChar));
            //SqlConnections.cmd.Parameters.Add(new SqlParameter("@client_id", SqlDbType.VarChar));
            //SqlConnections.cmd.Parameters.Add(new SqlParameter("@client_name", SqlDbType.VarChar));
            //SqlConnections.cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar));
            //SqlConnections.cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));

            ////SqlConnections.OpenConnection();
            //foreach (DataGridViewRow row in tableOutput.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {
            //        SqlConnections.cmd.Parameters["@manager_id"].Value = row.Cells[0].Value;
            //        SqlConnections.cmd.Parameters["@client_id"].Value = row.Cells[1].Value;
            //        SqlConnections.cmd.Parameters["@client_name"].Value = row.Cells[2].Value;
            //        SqlConnections.cmd.Parameters["@phone"].Value = row.Cells[3].Value;
            //        SqlConnections.cmd.Parameters["@email"].Value = row.Cells[4].Value;

            //        SqlConnections.cmd.ExecuteNonQuery();
            //    }
            //}
        }

        private void tableOutput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            saveWarningLabel.Visible = false;
        }
    }
}

