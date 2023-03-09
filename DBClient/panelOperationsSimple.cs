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
    public partial class panelOperationsSimple : UserControl
    {
        MainForm mainForm;
        string changingCell = "";
        static string curTable = "Склады";
        List<int> rowsToSave = new List<int>();
        List<string> columnsToSave = new List<string>();

        public panelOperationsSimple()
        {
            InitializeComponent();
        }

        public panelOperationsSimple(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            SqlConnections.sql = Properties.Resources.SimpleTable_Storages;
            SqlConnections.OpenConnection();
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);

            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
            SqlConnections.ds = new DataSet();
            SqlConnections.bs = new BindingSource();

            SqlConnections.da.Fill(SqlConnections.ds, curTable);

            tableOutput.AllowUserToAddRows = false;
            tableOutput.DefaultCellStyle.SelectionBackColor = MainForm.appColor;

            UpdateTableList();

            ShowData();
            tableList.SelectedItem = "Склады";
        }

        private void ShowData()
        {
            if (SqlConnections.ds.Tables[curTable] != null)
            {
                SqlConnections.ds.Tables[curTable].Clear();
            }

            if (curTable == "Клиенты")
                SqlConnections.sql = Properties.Resources.SimpleTable_Clients;
            else if (curTable == "Платежи")
                SqlConnections.sql = Properties.Resources.SimpleTable_Payment;
            else if (curTable == "Склады")
                SqlConnections.sql = Properties.Resources.SimpleTable_Storages;

            SqlConnections.cmd.CommandText = SqlConnections.sql;
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            SqlConnections.da.Fill(SqlConnections.ds, curTable);
           
            tableOutput.DataSource = SqlConnections.ds.Tables[curTable];                                                                                 //Выводим таблицу в dataGrid

            //columns width
            tableOutput.Columns[0].Width = 30;
            for (int i = 1; i < tableOutput.Columns.Count - 1; i++)
            {
                tableOutput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            tableOutput.Columns[tableOutput.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 1; i < tableOutput.Columns.Count; i++)
            {
                int colw = tableOutput.Columns[i].Width;
                tableOutput.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                tableOutput.Columns[i].Width = colw;
            }

            //set readonly
            tableOutput.Columns["ID"].ReadOnly = true;
            if (curTable == "Платежи")
            {
                tableOutput.Sort(tableOutput.Columns["ID"], ListSortDirection.Ascending);
                tableOutput.Columns["Долг"].ReadOnly = true;
            }
            if (curTable == "Склады")
                tableOutput.Columns["Сумма (руб)"].ReadOnly = true;

            foreach (DataGridViewColumn column in tableOutput.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            timeLabel.Text = DateTime.Now.ToString();
            accessTimeLabel.Visible = true;
            timeLabel.Visible = true;
        }

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
                if (item is BunifuMetroTextbox)
                {
                    var temp = item as BunifuMetroTextbox;
                    temp.ForeColor = MainForm.appColor;
                    temp.BorderColorIdle = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(6, 181, 126))
                    { temp.ForeColor = Color.FromArgb(89, 205, 169); temp.BorderColorFocused = Color.FromArgb(89, 205, 169); temp.BorderColorMouseHover = Color.FromArgb(20, 248, 173); }
                    else if (MainForm.appColor == Color.FromArgb(228, 231, 235))
                    { temp.ForeColor = Color.Gainsboro; temp.BorderColorFocused = Color.White; temp.BorderColorMouseHover = Color.FromArgb(152, 154, 156); }
                    else { temp.ForeColor = Color.FromArgb(85, 153, 221); temp.BorderColorFocused = Color.FromArgb(85, 153, 221); temp.BorderColorMouseHover = Color.FromArgb(85, 153, 221); }
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
                if (item is BunifuDatepicker)
                {
                    var temp = item as BunifuDatepicker;
                    temp.BackColor = MainForm.appColor;
                }
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }
        private void Operations_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
            ShowData();
        }

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

        private void tableList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
        private void ClientNameList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
        #endregion ComboBox.DrawItem

        #endregion Style

        #region ComboBox

        #region Select Table
        private void UpdateTableList()                                                                                                                   //Получаем список таблиц базы данных
        {
            tableList.Items.Clear();
            tableList.Items.Add("Клиенты");
            tableList.Items.Add("Платежи");
            tableList.Items.Add("Склады");
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            curTable = tableList.SelectedItem.ToString();
            //tableOutput.DataSource = SqlConnections.ds.Tables[curTable];                                                                                 //Выводим таблицу в dataGrid
            rowsToSave.Clear();
            columnsToSave.Clear();
            ShowData();

            if (curTable == "Клиенты")
            {
                addStorageButton.Visible = false;
                removeStorageButton.Visible = false;
                addClientButton.Visible = true;
                removeClientButton.Visible = true;
                debtorsButton.Visible = true;
                allClientsButton.Visible = true;
            }
            else if (curTable == "Склады")
            {
                addClientButton.Visible = false;
                removeClientButton.Visible = false;
                addStorageButton.Visible = true;
                removeStorageButton.Visible = true;
                debtorsButton.Visible = false;
                allClientsButton.Visible = false;
            }
            else
            {
                addClientButton.Visible = false;
                removeClientButton.Visible = false;
                addStorageButton.Visible = false;
                removeStorageButton.Visible = false;
                debtorsButton.Visible = false;
                allClientsButton.Visible = false;
            }
        }

        #endregion Select Table

        #endregion ComboBox

        #region Table Manage

        #region Buttons
        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //добавляем клиента (через отделную форму) и все, что с ним связано
            panelOperations_AddClient newClient = new panelOperations_AddClient();
            newClient.ShowDialog();
            ShowData();
        }
        private void reduceButton_Click(object sender, EventArgs e)
        {
            //удаляем клиента (через отделную форму) и все, что с ним связано
            panelOperations_RemoveClient remClient = new panelOperations_RemoveClient();
            remClient.ShowDialog();
            ShowData();
        }
        private void saveIcon_Click(object sender, EventArgs e)                          //Save datagrid as db table
        {
            try
            {
                UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //saveWarningLabel.Visible = true;
        }

        private void debtorsButton_Click(object sender, EventArgs e)
        {
            tableOutput.CurrentCell = null;
            int creditColumn_id = 4;
            int balanceColumn_id = 5;

            foreach (DataGridViewRow row in tableOutput.Rows)
            {
                int curCredit = Convert.ToInt32(row.Cells[creditColumn_id].Value.ToString());
                int curBalance = Convert.ToInt32(row.Cells[balanceColumn_id].Value.ToString());
                if ((curBalance + curCredit) < 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void allClientsButton_Click(object sender, EventArgs e)
        {
            tableOutput.CurrentCell = null;
            foreach (DataGridViewRow row in tableOutput.Rows)
            {
                row.Visible = true;
            }
        }

        #endregion Buttons

        public void UpdateTable()
        {
            if (curTable == "Клиенты")
                UpdateClientsTable();
            if (curTable == "Платежи")
                UpdateFinanceTable();
            if (curTable == "Склады")
                UpdateStorageTable();

            void UpdateClientsTable()
            {
                int id;
                for (int i = 0; i < rowsToSave.Count; i++)
                {
                    switch (columnsToSave[i])
                    {
                        case "Имя клиента":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            string newName = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Имя клиента"].Index].Value.ToString();
                            Queries.ChangeClientName(id, newName);
                            break;
                        case "Телефон":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            string newPhone = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Телефон"].Index].Value.ToString();
                            Queries.ChangeClientPhone(id, newPhone);
                            break;
                        case "Эл. адрес":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            string newMail = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Эл. адрес"].Index].Value.ToString();
                            Queries.ChangeClientEmail(id, newMail);
                            break;
                        case "Кредит":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            int newCredit = Convert.ToInt32(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Кредит"].Index].Value);
                            Queries.ChangeClientCredit(id, newCredit);
                            break;
                        case "Баланс":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            int newBalance = Convert.ToInt32(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Баланс"].Index].Value);
                            Queries.ChangeClientBalance(id, newBalance);
                            break;

                    }
                }
            }
            void UpdateFinanceTable()
            {
                int id;
                for (int i = 0; i < rowsToSave.Count; i++)
                {
                    switch (columnsToSave[i])
                    {
                        case "Дата":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            DateTime newDate = Convert.ToDateTime(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Дата"].Index].Value);
                            int payment = Convert.ToInt32(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Оплата"].Index].Value);
                            Queries.ChangeFinanceDate(newDate, id, payment);
                            break;
                        case "Имя клиента":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            string newName = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Имя клиента"].Index].Value.ToString();
                            Queries.ChangeFinanceName(id, newName);
                            break;
                        case "Оплата":
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            int newPayment = Convert.ToInt32(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Оплата"].Index].Value);
                            DateTime date = Convert.ToDateTime(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Дата"].Index].Value);
                            Queries.ChangeFinancePayment(date, id, newPayment);
                            break;

                    }
                }
            }
            void UpdateStorageTable()
            {
                int id, item_price, item_amount;
                string item_type, item_material;
                for (int i = 0; i < rowsToSave.Count; i++)
                {
                    switch (columnsToSave[i])
                    {
                        case "Адрес/Имя":

                            break;
                        case "Вместимость":

                            break;
                        case "Тип товара":
                            //id = tableOutput.Rows[rowsToSave[i]].Index;
                            item_price = 100; //значение по умолчанию, можно предложить задать
                            item_type = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Тип товара"].Index].Value.ToString();
                            item_material = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Материал"].Index].Value.ToString();
                            item_amount = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Количество"].Index].Value.ToString());
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            Queries.CheckItemExists(item_type, item_material, item_price); //проверяем, есть ли такое сочетание тип-материал в таблице items; если нет, добавляем

                            //теперь insert созданное/найденное значение в dbo.Содержимое_склада
                            Queries.ChangeStorageItemMaterialAndType(item_type, item_material, id, item_amount);
                            break;
                        case "Материал":
                            //id = tableOutput.Rows[rowsToSave[i]].Index;
                            item_price = 100; //значение по умолчанию, можно предложить задать
                            item_type = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Тип товара"].Index].Value.ToString();
                            item_material = tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Материал"].Index].Value.ToString();
                            item_amount = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["Количество"].Index].Value.ToString());
                            id = int.Parse(tableOutput.Rows[rowsToSave[i]].Cells[tableOutput.Columns["ID"].Index].Value.ToString());
                            Queries.CheckItemExists(item_type, item_material, item_price); //проверяем, есть ли такое сочетание тип-материал в таблице items; если нет, добавляем

                            //теперь insert созданное/найденное значение в dbo.Содержимое_склада
                            Queries.ChangeStorageItemMaterialAndType(item_type, item_material, id, item_amount);
                            break;
                        case "Количество":

                            break;

                    }
                }
            }
        }

        #endregion Table Manage

        #region Dynamic Table Reaction
        private void tableOutput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //saveWarningLabel.Visible = false;1
        }

        private void tableOutput_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            changingCell = tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void tableOutput_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaveTable(e);
            }
            catch
            {
                tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                MessageBox.Show("Недопустимое значение [Неправильный формат]");
            }
        }

        public void SaveTable(DataGridViewCellEventArgs e)
        {
            int check;
            char[] forbidden = { '\\', '/', ':', '*', '?', '<', '>', '|' };
            if (curTable == "Клиенты")
                SaveClientsTable();
            if (curTable == "Платежи")
                SaveFinanceTable();
            if (curTable == "Склады")
                SaveStorageTable();

            void SaveClientsTable()
            {
                if (tableOutput.Rows[e.RowIndex].Cells["Имя клиента"].Value.ToString() == "" || tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Имя клиента]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (!tableOutput.Rows[e.RowIndex].Cells["Телефон"].Value.ToString().All(char.IsDigit) || tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Телефон]\nНеправильно задан номер");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (!tableOutput.Rows[e.RowIndex].Cells["Эл. адрес"].Value.ToString().Contains('@') || tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Эл. адрес]\nНеправильно указан электронный адрес");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (!tableOutput.Rows[e.RowIndex].Cells["Кредит"].Value.ToString().All(char.IsDigit) || tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Кредит]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (!int.TryParse(tableOutput.Rows[e.RowIndex].Cells["Баланс"].Value.ToString(), out check) || tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Баланс]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }

                if (tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != changingCell)
                {
                    if (!(rowsToSave.Contains(e.RowIndex) && columnsToSave.Contains(tableOutput.Columns[e.ColumnIndex].Name)))
                    {
                        rowsToSave.Add(e.RowIndex);
                        columnsToSave.Add(tableOutput.Columns[e.ColumnIndex].Name);
                    }
                }
            }
            void SaveFinanceTable()
            {
                if (tableOutput.Columns[e.ColumnIndex].Name == "Дата" && !CheckDate(tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    MessageBox.Show("Ошибка [Дата]\nНедопустимое значение\nДопустимый интервал с 1800г по наши дни");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (tableOutput.Rows[e.RowIndex].Cells["Имя клиента"].Value.ToString() == "" || tableOutput.Rows[e.RowIndex].Cells["Имя клиента"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Имя клиента]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (!tableOutput.Rows[e.RowIndex].Cells["Оплата"].Value.ToString().All(char.IsDigit) || tableOutput.Rows[e.RowIndex].Cells["Оплата"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Оплата]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                //if (tableOutput.Columns[e.ColumnIndex].Name == "Долг")
                //{
                //    MessageBox.Show("Это поле нельзя изменить вручную");
                //    if (changingCell == "")
                //        tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                //    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                //    return;
                //}

                if (tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != changingCell)
                {
                    if (!(rowsToSave.Contains(e.RowIndex) && columnsToSave.Contains(tableOutput.Columns[e.ColumnIndex].Name)))
                    {
                        rowsToSave.Add(e.RowIndex);
                        columnsToSave.Add(tableOutput.Columns[e.ColumnIndex].Name);
                    }
                }
            }
            void SaveStorageTable()
            {
                if (tableOutput.Rows[e.RowIndex].Cells["Вместимость"].Value.ToString() == "" || !tableOutput.Rows[e.RowIndex].Cells["Вместимость"].Value.ToString().All(char.IsDigit) || tableOutput.Rows[e.RowIndex].Cells["Вместимость"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Вместимость]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (tableOutput.Rows[e.RowIndex].Cells["Тип товара"].Value.ToString() == "" || !tableOutput.Rows[e.RowIndex].Cells["Тип товара"].Value.ToString().All(char.IsLetter) || tableOutput.Rows[e.RowIndex].Cells["Тип товара"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Тип товара]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (tableOutput.Rows[e.RowIndex].Cells["Материал"].Value.ToString() == "" || !tableOutput.Rows[e.RowIndex].Cells["Материал"].Value.ToString().All(char.IsLetter) || tableOutput.Rows[e.RowIndex].Cells["Материал"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Материал]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }
                if (tableOutput.Rows[e.RowIndex].Cells["Количество"].Value.ToString() == "" || !tableOutput.Rows[e.RowIndex].Cells["Количество"].Value.ToString().All(char.IsDigit) || tableOutput.Rows[e.RowIndex].Cells["Количество"].Value.ToString().IndexOfAny(forbidden) != -1)
                {
                    MessageBox.Show("Ошибка [Количество]\nНедопустимое значение");
                    tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
                    return;
                }

                if (tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != changingCell)
                {
                    if (!(rowsToSave.Contains(e.RowIndex) && columnsToSave.Contains(tableOutput.Columns[e.ColumnIndex].Name)))
                    {
                        rowsToSave.Add(e.RowIndex);
                        columnsToSave.Add(tableOutput.Columns[e.ColumnIndex].Name);
                    }
                }
            }

            bool CheckDate(string value)
            {
                int year;
                string yearStr = value.Remove(0, value.LastIndexOf('.') + 1).Remove(4); //год в формате 20XX
                bool result = int.TryParse(yearStr, out year);

                if (year < 1800 || year > DateTime.Now.Year)
                {
                    result = false;
                }
                return result;
            }
        }

        private void tableOutput_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Недопустимое значение \n[Неправильный формат]");
            e.ThrowException = false;
            e.Cancel = false;
            tableOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = changingCell;
        }

        #endregion Dynamic Table Reaction

        #region Operations
        private void paymentButton_Click(object sender, EventArgs e)
        {
            panelOperations_AddPayment newPayment = new panelOperations_AddPayment();
            newPayment.ShowDialog();
            ShowData();
        }

        private void shipmentButton_Click(object sender, EventArgs e)
        {
            panelOperations_AddShipment newShipment = new panelOperations_AddShipment();
            newShipment.ShowDialog();
            ShowData();
        }
        #endregion Operations

        #region Search
        public void Search()
        {
            tableOutput.CurrentCell = null;
            if (curTable == "Клиенты")
                SearchThruClients();
            if (curTable == "Платежи")
                SearchThruFinances();
            if (curTable == "Склады")
                SearchThruStorages();

            void SearchThruClients()
            {
                int nameIndex = tableOutput.Columns["Имя клиента"].Index;
                int phoneIndex = tableOutput.Columns["Телефон"].Index;
                int emailIndex = tableOutput.Columns["Эл. адрес"].Index;
                foreach (DataGridViewRow row in tableOutput.Rows)
                {

                    if (!row.Cells[nameIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower())
                        && !row.Cells[phoneIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower())
                        && !row.Cells[emailIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            void SearchThruFinances()
            {
                int dateIndex = tableOutput.Columns["Дата"].Index;
                int nameIndex = tableOutput.Columns["Имя клиента"].Index;
                foreach (DataGridViewRow row in tableOutput.Rows)
                {

                    if (!row.Cells[dateIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower())
                        && !row.Cells[nameIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            void SearchThruStorages()
            {
                int nameIndex = tableOutput.Columns["Адрес/Имя"].Index;
                int typeIndex = tableOutput.Columns["Тип товара"].Index;
                int materialIndex = tableOutput.Columns["Материал"].Index;
                foreach (DataGridViewRow row in tableOutput.Rows)
                {

                    if (!row.Cells[nameIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower())
                        && !row.Cells[typeIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower())
                        && !row.Cells[materialIndex].Value.ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                    {
                        row.Visible = false;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        #endregion Search

        #region Additional Buttons
        private void NewClientButton_Click(object sender, EventArgs e)
        {
            //добавляем клиента (через отделную форму) и все, что с ним связано
            panelOperations_AddClient newClient = new panelOperations_AddClient();
            newClient.ShowDialog();
            ShowData();
        }

        private void NewStorageButton_Click(object sender, EventArgs e)
        {
            panelOperations_AddStorage newStorage = new panelOperations_AddStorage();
            newStorage.ShowDialog();
            ShowData();
        }

        private void NewItemButton_Click(object sender, EventArgs e)
        {
            panelOperations_AddItem newItem = new panelOperations_AddItem();
            newItem.ShowDialog();
            ShowData();
        }

        private void ModifyClientButton_Click(object sender, EventArgs e)
        {
            panelOperations_ModifyClient modifyClient = new panelOperations_ModifyClient();
            modifyClient.ShowDialog();
            ShowData();
        }

        private void ModifyStorageButton_Click(object sender, EventArgs e)
        {
            panelOperations_ModifyStorage modifyStorage = new panelOperations_ModifyStorage();
            modifyStorage.ShowDialog();
            ShowData();
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            panelOperations_ModifyItem modifyItem = new panelOperations_ModifyItem();
            modifyItem.ShowDialog();
            ShowData();
        }

        private void MinusClientButton_Click(object sender, EventArgs e)
        {
            panelOperations_RemoveClient removeClient = new panelOperations_RemoveClient();
            removeClient.ShowDialog();
            ShowData();
        }

        private void MinusStorageButton_Click(object sender, EventArgs e)
        {
            panelOperations_RemoveStorage removeStorage = new panelOperations_RemoveStorage();
            removeStorage.ShowDialog();
            ShowData();
        }

        private void MinusItemButton_Click(object sender, EventArgs e)
        {
            panelOperations_RemoveItem removeItem = new panelOperations_RemoveItem();
            removeItem.ShowDialog();
            ShowData();
        }
        #endregion Additional Buttons

    }
}

