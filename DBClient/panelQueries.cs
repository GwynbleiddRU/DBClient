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
using System.IO;

namespace DBClient
{
    public partial class panelQueries : UserControl
    {
        MainForm mainForm;
        string query = "";
        List<string> journalsPath = new List<string>();
        static string journalFolderPath = Environment.CurrentDirectory + "\\Журналы\\";
        static string savedJournalsLog = journalFolderPath + "Сохраненные журналы.log";

        public panelQueries()
        {
            InitializeComponent();
        }

        public panelQueries(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Queries_Load(object sender, EventArgs e)
        {
            SqlConnections.OpenConnection();
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);
            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
            //updateIDList();
            ListViewJournalsLog();

            if (savedJournalListView.Items.Count == 0)
            {
                updateButton.Visible = false;
                savedJournalsLabel.Visible = false;
            }

            essenceList.SelectedItem = essenceList.Items[0];

            queryTable.Columns.Add("Queries", "Запросы");
            queryTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        #region Style

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

        private void clientIDList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
        private void storageIDList_DrawItem(object sender, DrawItemEventArgs e) { if (MainForm.appColor == Color.FromArgb(6, 181, 126)) FillColorComboBox(sender, e, Color.FromArgb(6, 181, 126), Color.FromArgb(37, 46, 59)); else if (MainForm.appColor == Color.FromArgb(228, 231, 235)) FillColorComboBox(sender, e, Color.FromArgb(228, 231, 235), Color.FromArgb(37, 46, 59)); else FillColorComboBox(sender, e, Color.FromArgb(0, 102, 204), Color.FromArgb(37, 46, 59)); }
        #endregion ComboBox.DrawItem

        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                {
                    item.BackColor = MainForm.appColor;
                }
                if (item is BunifuImageButton)
                {
                    item.BackColor = Color.Transparent;
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
                if (item.Name.Contains("header"))
                    item.ForeColor = MainForm.appColor;
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }

        #endregion Style

        #region ListViewJournals

        private void journalButton_Click(object sender, EventArgs e)
        {
            string journalPath = journalFolderPath + "Журнал за " + DateTime.Now.ToString("dd.MM-HH.mm") + MainForm.journalFormat;
            if (!Directory.Exists(journalFolderPath))
                Directory.CreateDirectory(journalFolderPath);
            try
            {
                journalsPath.Add(journalPath);
                StreamWriter sw = new StreamWriter(journalPath);
                sw.Write(SqlConnections.journal.ToString());
                sw.Close();

                SaveJournalLog();
                journalsPath.Clear();

                //System.Diagnostics.Process.Start(journalPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void SaveJournalLog()
            {
                if (!File.Exists(savedJournalsLog)) File.Create(savedJournalsLog).Close();

                StreamWriter sw = File.AppendText(savedJournalsLog);
                foreach (string path in journalsPath)
                    sw.WriteLine(path);
                sw.Close();
            }
            ListViewJournalsLog();

            updateButton.Visible = true;
            savedJournalsLabel.Visible = true;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ListViewJournalsLog();
        }

        public void ListViewJournalsLog()
        {
            savedJournalListView.Items.Clear();
            savedJournalListView.SmallImageList = imageListExtensions;

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Журналы\\"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Журналы\\");
            if (!File.Exists(savedJournalsLog))
                File.Create(savedJournalsLog).Close();

            string imageKey = "wordFlatIcon.png";
            foreach (string item in File.ReadAllLines(savedJournalsLog))
            {
                string itemText = item;
                if (itemText.IndexOf('\\') != -1)
                    itemText = itemText.Remove(0, itemText.LastIndexOf('\\') + 1);   //Обрезаем строку директории - получаем имя и формат

                if (item.Contains(".log"))
                    imageKey = "txtIcon.ico";
                else if (item.Contains(".txt"))
                    imageKey = "txtIcon.ico";
                else if (item.Contains(".doc"))
                    imageKey = "wordFlatIcon.png";

                savedJournalListView.Items.Add(item, itemText, imageKey);
            }
        }

        private void savedJournalListView_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure it was a double left click, like the normal DoubleClick event
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 2))
            {
                ListViewItem selectedFile = savedJournalListView.SelectedItems[0];
                string filePath = selectedFile.Name.ToString();
                try
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                catch   //If file wasnt found remove its directory from listbox and log
                {
                    MessageBox.Show("Журнал не найден. \nВозможно, файл был перемещен или удален");

                    var file = File.ReadAllLines(savedJournalsLog).Where(s => !s.Contains(savedJournalListView.SelectedItems[0].Name.ToString()));
                    File.WriteAllLines(savedJournalsLog, file);

                    savedJournalListView.Items.Remove(savedJournalListView.SelectedItems[0]);
                }
            }
        }

        #region ContextMenuStrip

        private void savedJournalListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (savedJournalListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    journalContextMenuStrip.Show(savedJournalListView, new Point(e.X, e.Y));
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedFile = savedJournalListView.SelectedItems[0];
            string filePath = selectedFile.Name.ToString();
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch   //If file wasnt found remove its directory from listbox and log
            {
                MessageBox.Show("Журнал не найден. \nВозможно, файл был перемещен или удален");

                var file = File.ReadAllLines(savedJournalsLog).Where(s => !s.Contains(savedJournalListView.SelectedItems[0].Name.ToString()));
                File.WriteAllLines(savedJournalsLog, file);

                savedJournalListView.Items.Remove(savedJournalListView.SelectedItems[0]);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedFile = savedJournalListView.SelectedItems[0];
            try
            {
                File.Delete(selectedFile.Name);
                var file = File.ReadAllLines(savedJournalsLog).Where(s => !s.Contains(selectedFile.Name.ToString()));
                File.WriteAllLines(savedJournalsLog, file);
            }
            finally
            {
                savedJournalListView.Items.Remove(selectedFile);
            }
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedFile = savedJournalListView.SelectedItems[0];
            string filePath = selectedFile.Name.ToString();
            string folder = filePath.Remove(filePath.LastIndexOf('\\'));

            try
            {
                System.Diagnostics.Process Proc = new System.Diagnostics.Process();
                Proc.StartInfo.FileName = "explorer";
                Proc.StartInfo.Arguments = folder;
                Proc.Start();
                Proc.Close();
            }
            catch
            {

            }
        }

        #region ContextMenuItem RecolorOnHover

        private void deleteToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void deleteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        private void openToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void openToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        private void locationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.FromArgb(37, 46, 59);
        }

        private void locationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = sender as ToolStripMenuItem;
            TSMI.ForeColor = Color.Gainsboro;
        }

        #endregion ContextMenuItem RecolorOnHover

        #endregion ContextMenuStrip

        #endregion ListViewJournals

        #region QueryBuilder
        public void UpdateSelectWhereList()
        {
            whereList.Items.Clear();
            attributeList.Items.Clear();
            attributeList.Items.Add("Все данные");
            if (essenceList.SelectedItem.ToString() == "Клиент")
            {
                attributeList.Items.Add("Имя");                      //SELECT client_name FROM Клиенты WHERE client_name [знак] [значение]
                attributeList.Items.Add("Кредит");
                attributeList.Items.Add("Баланс");
                attributeList.Items.Add("Телефон");
                attributeList.Items.Add("Email");

                whereList.Items.Add("Имя");                      //SELECT client_name FROM Клиенты WHERE client_name [знак] [значение]
                whereList.Items.Add("Кредит");
                whereList.Items.Add("Баланс");
                whereList.Items.Add("Телефон");
                whereList.Items.Add("Email");
            }
            if (essenceList.SelectedItem.ToString() == "Склад")
            {
                attributeList.Items.Add("Название");
                attributeList.Items.Add("Вместимость");

                whereList.Items.Add("Название");
                whereList.Items.Add("Вместимость");
            }
            if (essenceList.SelectedItem.ToString() == "Товар")
            {
                attributeList.Items.Add("Тип");                     //SELECT item_type FROM Содержимое_склада WHERE [знак] [значение]
                attributeList.Items.Add("Материал");
                attributeList.Items.Add("Количество");
                attributeList.Items.Add("Стоимость");

                whereList.Items.Add("Тип");                     //SELECT item_type FROM Содержимое_склада WHERE [знак] [значение]
                whereList.Items.Add("Материал");
                whereList.Items.Add("Количество");
                whereList.Items.Add("Стоимость");
            }
            if (essenceList.SelectedItem.ToString() == "Оплата")
            {
                attributeList.Items.Add("Дата");
                attributeList.Items.Add("Клиент");
                attributeList.Items.Add("Сумма");

                whereList.Items.Add("Дата");
                whereList.Items.Add("Клиент");
                whereList.Items.Add("Сумма");
            }
            if (essenceList.SelectedItem.ToString() == "Отгрузка")
            {
                attributeList.Items.Add("Дата");
                attributeList.Items.Add("Тип");
                attributeList.Items.Add("Материал");
                attributeList.Items.Add("Клиент");
                attributeList.Items.Add("Количество");
                attributeList.Items.Add("Склад");

                whereList.Items.Add("Дата");
                whereList.Items.Add("Тип");
                whereList.Items.Add("Материал");
                whereList.Items.Add("Клиент");
                whereList.Items.Add("Количество");
                whereList.Items.Add("Склад");
            }
        }

        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectWhereList();
        }

        private void clearQueryButton_Click(object sender, EventArgs e)
        {
            queryTable.Rows.Clear();

            //queryResultTable.DataSource = null;
            //queryResultTable.Rows.Clear();
        }

        private void addQueryButton_Click(object sender, EventArgs e)
        {
            query = "";
            if (essenceList.SelectedItem != null && attributeList.SelectedItem != null)
            {
                if (signList.SelectedItem != null && valueTextBox.Text != "" && whereList.SelectedItem != null)
                {
                    string sign = signList.SelectedItem.ToString(), value = valueTextBox.Text;

                    if (queryTable.SelectedRows.Count == 0)
                    {
                        query += ("SELECT " + Select() + " FROM " + From() + " WHERE " + Where() + " " + sign + " '" + value + "'");
                        queryTable.Rows.Add(query);
                    }
                    else
                    {
                        if (andOrList.SelectedItem != null)
                        {
                            query += (andOrList.SelectedItem.ToString() + " " + Where() + " " + sign + " '" + value + "' ");
                            queryTable.Rows.Insert(queryTable.SelectedRows[queryTable.SelectedRows.Count - 1].Index + 1, query);
                        }
                        else
                            MessageBox.Show("Выберите оператор AND или OR");
                    }
                }
                else
                {
                    if (queryTable.SelectedRows.Count == 0)
                    {
                        query += ("SELECT " + Select() + " FROM " + From() + " ");
                        queryTable.Rows.Add(query);
                    }
                    else
                    {
                        if (andOrList.SelectedItem != null)
                        {
                            query += (andOrList.SelectedItem.ToString() + " " + Select() + " ");
                            queryTable.Rows.Insert(queryTable.SelectedRows[queryTable.SelectedRows.Count - 1].Index + 1, query);
                        }
                        else
                            MessageBox.Show("Выберите оператор AND или OR");
                    }
                }
            }
            else
                MessageBox.Show("Укажите сущность и атрибут");

            string Select()
            {
                if (attributeList.SelectedItem.ToString() == "Все данные")
                    return (" * ");
                if (essenceList.SelectedItem.ToString() == "Клиент")
                {
                    if (attributeList.SelectedItem.ToString() == "Имя")
                        return (" client_name ");
                    else if (attributeList.SelectedItem.ToString() == "Кредит")
                        return (" client_credit ");
                    else if (attributeList.SelectedItem.ToString() == "Баланс")
                        return (" client_balance ");
                    else if (attributeList.SelectedItem.ToString() == "Телефон")
                        return (" phone ");
                    else if (attributeList.SelectedItem.ToString() == "Email")
                        return (" email ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Склад")
                {
                    if (attributeList.SelectedItem.ToString() == "Название")
                        return (" storage_name ");
                    else if (attributeList.SelectedItem.ToString() == "Вместимость")
                        return (" storage_capacity ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Товар")
                {
                    if (attributeList.SelectedItem.ToString() == "Тип")
                        return (" item_type ");
                    else if (attributeList.SelectedItem.ToString() == "Материал")
                        return (" item_material ");
                    else if (attributeList.SelectedItem.ToString() == "Количество")
                        return (" item_amount ");
                    else if (attributeList.SelectedItem.ToString() == "Стоимость")
                        return (" item_price ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Оплата")
                {
                    if (attributeList.SelectedItem.ToString() == "Дата")
                        return (" date ");
                    else if (attributeList.SelectedItem.ToString() == "Клиент")
                        return (" client_name ");
                    else if (attributeList.SelectedItem.ToString() == "Сумма")
                        return (" payment ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Отгрузка")
                {
                    if (attributeList.SelectedItem.ToString() == "Дата")
                        return (" date ");
                    else if (attributeList.SelectedItem.ToString() == "Клиент")
                        return (" client_name ");
                    else if (attributeList.SelectedItem.ToString() == "Тип")
                        return (" item_type ");
                    else if (attributeList.SelectedItem.ToString() == "Материал")
                        return (" item_material ");
                    else if (attributeList.SelectedItem.ToString() == "Количество")
                        return (" item_amount ");
                    else if (attributeList.SelectedItem.ToString() == "Склад")
                        return (" storage_name ");
                    else
                        return null;
                }
                else
                    return null;
            }
            string Where()
            {
                if (essenceList.SelectedItem.ToString() == "Клиент")
                {
                    if (whereList.SelectedItem.ToString() == "Имя")
                        return (" client_name ");
                    else if (whereList.SelectedItem.ToString() == "Кредит")
                        return (" client_credit ");
                    else if (whereList.SelectedItem.ToString() == "Баланс")
                        return (" client_balance ");
                    else if (whereList.SelectedItem.ToString() == "Телефон")
                        return (" phone ");
                    else if (whereList.SelectedItem.ToString() == "Email")
                        return (" email ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Склад")
                {
                    if (whereList.SelectedItem.ToString() == "Название")
                        return (" storage_name ");
                    else if (whereList.SelectedItem.ToString() == "Вместимость")
                        return (" storage_capacity ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Товар")
                {
                    if (whereList.SelectedItem.ToString() == "Тип")
                        return (" item_type ");
                    else if (whereList.SelectedItem.ToString() == "Материал")
                        return (" item_material ");
                    else if (whereList.SelectedItem.ToString() == "Количество")
                        return (" item_amount ");
                    else if (whereList.SelectedItem.ToString() == "Стоимость")
                        return (" item_price ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Оплата")
                {
                    if (whereList.SelectedItem.ToString() == "Дата")
                        return (" date ");
                    else if (whereList.SelectedItem.ToString() == "Клиент")
                        return (" client_name ");
                    else if (whereList.SelectedItem.ToString() == "Сумма")
                        return (" payment ");
                    else
                        return null;
                }
                else if (essenceList.SelectedItem.ToString() == "Отгрузка")
                {
                    if (whereList.SelectedItem.ToString() == "Дата")
                        return (" date ");
                    else if (whereList.SelectedItem.ToString() == "Клиент")
                        return (" client_name ");
                    else if (whereList.SelectedItem.ToString() == "Тип")
                        return (" item_type ");
                    else if (whereList.SelectedItem.ToString() == "Материал")
                        return (" item_material ");
                    else if (whereList.SelectedItem.ToString() == "Количество")
                        return (" item_amount ");
                    else if (whereList.SelectedItem.ToString() == "Склад")
                        return (" storage_name ");
                    else
                        return null;
                }
                else
                    return null;
            }
            string From()
            {
                if (essenceList.SelectedItem.ToString() == "Клиент")
                {
                    return (" Взаиморасчеты.dbo.Клиенты INNER JOIN Взаиморасчеты.dbo.Счет_клиента ON Взаиморасчеты.dbo.Клиенты.client_id = Взаиморасчеты.dbo.Счет_клиента.client_id ");
                }
                else if (essenceList.SelectedItem.ToString() == "Склад")
                {
                    return (" Взаиморасчеты.dbo.Склад INNER JOIN Взаиморасчеты.dbo.Содержимое_склада ON Взаиморасчеты.dbo.Склад.storage_id = Взаиморасчеты.dbo.Содержимое_склада.storage_id ");
                }
                else if (essenceList.SelectedItem.ToString() == "Товар")
                {
                    return (" Взаиморасчеты.dbo.Товар INNER JOIN Взаиморасчеты.dbo.Содержимое_склада ON Взаиморасчеты.dbo.Товар.item_id = Взаиморасчеты.dbo.Содержимое_склада.item_id ");
                }
                else if (essenceList.SelectedItem.ToString() == "Оплата")
                {
                    return (" Взаиморасчеты.dbo.Оплата INNER JOIN Взаиморасчеты.dbo.Клиенты ON Взаиморасчеты.dbo.Оплата.client_id = Взаиморасчеты.dbo.Клиенты.client_id");
                }
                else if (essenceList.SelectedItem.ToString() == "Отгрузка")
                {
                    return (" Взаиморасчеты.dbo.Отгрузка INNER JOIN Взаиморасчеты.dbo.Склад ON Взаиморасчеты.dbo.Отгрузка.storage_id = Взаиморасчеты.dbo.Склад.storage_id INNER JOIN Взаиморасчеты.dbo.Товар ON Взаиморасчеты.dbo.Отгрузка.item_id = Взаиморасчеты.dbo.Товар.item_id INNER JOIN Взаиморасчеты.dbo.Клиенты ON Взаиморасчеты.dbo.Отгрузка.client_id = Взаиморасчеты.dbo.Клиенты.client_id ");
                }
                else
                    return null;
            }
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            SqlConnections.ds.Reset();

            if (queryTable.SelectedRows.Count > 0)
            {
                errorLabel.Visible = false;
                string queryToExecute = "";

                for (int i = 0; i < queryTable.Rows.Count; i++)
                {
                    if (queryTable.Rows[i].Selected == true)
                        queryToExecute += queryTable.Rows[i].Cells[0].Value.ToString() + " ";
                }

                queryShowLabel.Text = queryToExecute;

                try
                {
                    if ((!queryToExecute.Contains("insert") && !queryToExecute.Contains("delete") && !queryToExecute.Contains("update")) || SqlConnections.rights == "admin")
                    {
                        SqlConnections.cmd.CommandText = queryToExecute.ToString();
                        SqlConnections.da.SelectCommand = SqlConnections.cmd;
                        SqlConnections.da.Fill(SqlConnections.ds, "Результат_запроса");

                        queryResultTable.DataSource = SqlConnections.ds.Tables["Результат_запроса"];

                        foreach (DataGridViewColumn col in queryResultTable.Columns)
                        {
                            if (col.Name.Contains("id"))
                                col.Visible = false;
                            else if (col.HeaderText == "client_name")
                                col.HeaderText = "Клиент";
                            else if (col.HeaderText == "phone")
                                col.HeaderText = "Телефон";
                            else if (col.HeaderText == "email")
                                col.HeaderText = "Email";
                            else if (col.HeaderText == "client_credit")
                                col.HeaderText = "Кредит";
                            else if (col.HeaderText == "client_balance")
                                col.HeaderText = "Баланс";

                            else if (col.HeaderText == "item_type")
                                col.HeaderText = "Тип";
                            else if (col.HeaderText == "item_material")
                                col.HeaderText = "Материал";
                            else if (col.HeaderText == "item_price")
                                col.HeaderText = "Стоимость";
                            else if (col.HeaderText == "item_amount")
                                col.HeaderText = "Количество";

                            else if (col.HeaderText == "storage_name")
                                col.HeaderText = "Название";
                            else if (col.HeaderText == "storage_capacity")
                                col.HeaderText = "Вместимость";

                            else if (col.HeaderText == "date")
                                col.HeaderText = "Дата";
                            else if (col.HeaderText == "payment")
                                col.HeaderText = "Сумма оплаты";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ваш уровень доступа не позволяет вам редактировать таблицы с помощью конструктора запросов");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Запрос составлен некорректно");
                    return;
                }

                for (int i = 1; i < queryResultTable.Columns.Count - 1; i++)
                {
                    queryResultTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                queryResultTable.Columns[queryResultTable.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 1; i < queryResultTable.Columns.Count; i++)
                {
                    int colw = queryResultTable.Columns[i].Width;
                    queryResultTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    queryResultTable.Columns[i].Width = colw;
                }
            }
            else
                errorLabel.Visible = true;

            queryTable.ClearSelection();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            info_QueryBuilder info = new info_QueryBuilder();
            info.Show();
        }

        #endregion QueryBuilder

        private void Queries_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

    }
}
