using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClient
{
    public partial class panelOperations_AddShipment : Form
    {
        public string item_type;
        public string item_material;

        public panelOperations_AddShipment()
        {
            InitializeComponent();
            //AcceptButton = registerButton as IButtonControl;
            //this.Focus();
        }

        private void panelOperations_AddShipment_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            datePicker.Format = DateTimePickerFormat.Short;
            UpdateClientList();
            UpdateItemList();
            UpdateStoragetList();
        }

        #region ComboBox
        public void UpdateStoragetList()
        {
            SqlConnections.cmd.CommandText = "SELECT storage_name FROM Склад;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    storageList.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        public void UpdateItemList()
        {
            itemList.Items.Clear();
            SqlConnections.cmd.CommandText = "SELECT item_type, item_material FROM Товар;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    itemList.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        public void UpdateClientList()
        {
            SqlConnections.cmd.CommandText = "SELECT client_name FROM Клиенты;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    clientList.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_material = itemList.SelectedItem.ToString().Remove(0, itemList.SelectedItem.ToString().IndexOf(" - ") + 3);
            item_type = itemList.SelectedItem.ToString().Remove(itemList.SelectedItem.ToString().IndexOf(" - "));
        }
        #endregion ComboBox

        #region Form Buttons
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion Form Buttons

        #region Style
        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is Panel && item.Name.Contains("Header"))
                {
                    item.BackColor = MainForm.appColor;
                    if (MainForm.appColor == Color.FromArgb(228, 231, 235)) { minimizeButton.Image = Properties.Resources.darkMinimizeIcon; exitButton.Image = Properties.Resources.darkCloseIcon; appName.ForeColor = Color.FromArgb(37, 46, 59); appLogo.Image = Properties.Resources.promekzLogoGray; }
                    else { minimizeButton.Image = Properties.Resources.minimizeIcon; exitButton.Image = Properties.Resources.closeIcon; appName.ForeColor = Color.White; appLogo.Image = Properties.Resources.promekzAppLogo; }
                }
                if (item is Panel)
                    item.BackColor = MainForm.appColor;
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
                if (item is BunifuDatepicker)
                {
                    var temp = item as BunifuDatepicker;
                    temp.BackColor = MainForm.appColor;
                }
            }
        }
        #endregion Style

        #region KeyPress
        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        #endregion KeyPress

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (clientList.SelectedItem != null && datePicker.Value != null && itemList.SelectedItem != null && amountTextBox.Text != "" && storageList.SelectedItem != null)
            {
                errorLabel.Visible = false;
                int client_id = Queries.GetClientID(clientList.SelectedItem.ToString()), item_id = Queries.GetItemID(item_type, item_material), storage_id = Queries.GetStorageID(storageList.SelectedItem.ToString());
                
                if (StorageContains(Convert.ToInt32(amountTextBox.Text)))
                {
                    int debt = GetClientDebt(client_id);
                    if (debt > 0)
                    {
                        if (MessageBox.Show("Долг клиента " + clientList.SelectedItem + ": " + debt + " рублей\nВы уверены, что хотите продолжить операцию?", "Вниание", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            return;
                    }

                    try
                    {
                        Queries.AddShipment(datePicker.Value, client_id, storage_id, item_id, Convert.ToInt32(amountTextBox.Text));
                        MessageBox.Show("Время выполнения: " + datePicker.Value + "\nЗарегистрирована отгрузка клиенту: " + clientList.SelectedItem + "\nОтгружено: " + itemList.SelectedItem + " в объеме " + amountTextBox.Text + "шт.\nИсточник: склад \"" + storageList.SelectedItem + "\"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Данные введены некорректно\n" + ex.ToString());
                    }
                }

                int GetClientDebt(int checkClient_id) //проверяем клиента на наличие долгов
                {
                    int debt = 0;
                    SqlConnections.cmd.CommandText = @"(SELECT ABS(Взаиморасчеты.dbo.Счет_клиента.client_balance + Взаиморасчеты.dbo.Счет_клиента.client_credit) 
                                                    FROM Взаиморасчеты.dbo.Счет_клиента 
                                                    WHERE Взаиморасчеты.dbo.Счет_клиента.client_id = " + checkClient_id + " AND (Взаиморасчеты.dbo.Счет_клиента.client_balance + Взаиморасчеты.dbo.Счет_клиента.client_credit) < 0)";
                    SqlConnections.da.SelectCommand = SqlConnections.cmd;
                    try
                    {
                        SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader.GetValue(0)) > 0)
                            {
                                debt = Convert.ToInt32(reader.GetValue(0));
                            }
                        }
                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка\n" + ex);
                    }
                    return debt;
                }

                bool StorageContains(int requestedAmount) //проверяем, есть ли на складе n количество товара
                {
                    int contains = 0;

                    SqlConnections.cmd.CommandText = "SELECT item_amount FROM Содержимое_склада where item_id = " + item_id + " AND storage_id = " + storage_id + ";";
                    SqlConnections.da.SelectCommand = SqlConnections.cmd;
                    try
                    {
                        SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            contains = Convert.ToInt32(reader.GetValue(0));
                        }
                        reader.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка" + ex);
                    }

                    if (contains < Convert.ToInt32(requestedAmount))
                    {
                        //MessageBox.Show(contains.ToString());
                        MessageBox.Show("Товар в указанном объеме отсутствует на складе \nСейчас на складе \"" + storageList.SelectedItem + "\" имеется " + contains + "\nединиц данного товара");
                        return false;
                    }
                    else
                        return true;


                }
            }
            else
                errorLabel.Visible = true;
        }

        private void panelOperations_AddPayment_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }
    }
}
