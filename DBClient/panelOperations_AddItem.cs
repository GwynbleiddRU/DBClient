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
    public partial class panelOperations_AddItem : Form
    {
        string item_type;
        string item_material;

        public panelOperations_AddItem()
        {
            InitializeComponent();
        }

        private void panelOperations_AddItem_Load(object sender, EventArgs e)
        {
            UpdateStorageList();
            UpdateItemList();

            storageList.SelectedItem = storageList.Items[0];
            existingStorageList.SelectedItem = existingStorageList.Items[0];
        }

        #region ComboBox
        public void UpdateStorageList()
        {
            storageList.Items.Clear();
            SqlConnections.cmd.CommandText = "SELECT storage_name FROM Склад;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    existingStorageList.Items.Add(reader.GetValue(0).ToString());
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
            existingItemList.Items.Clear();
            SqlConnections.cmd.CommandText = "SELECT item_type, item_material FROM Товар;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    existingItemList.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        private void existingStorageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void existingItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_material = existingItemList.SelectedItem.ToString().Remove(0, existingItemList.SelectedItem.ToString().IndexOf(" - ") + 3);
            item_type = existingItemList.SelectedItem.ToString().Remove(existingItemList.SelectedItem.ToString().IndexOf(" - "));
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

        private void newItemButton_Click(object sender, EventArgs e)
        {
            existingItemPanel.Visible = false;
            newItemPanel.Visible = true;

            appName.Text = "СУБД - ПРОМЭКЗ - Новый товар";
            registerButton.Text = "Зарегистрировать товар";
        }

        private void existingItemButton_Click(object sender, EventArgs e)
        {
            newItemPanel.Visible = false;
            existingItemPanel.Visible = true;

            appName.Text = "СУБД - ПРОМЭКЗ - Добавить товар";
            registerButton.Text = "Добавить на склад";
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
                if (item is Panel && !item.Name.Contains("Item"))
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
            }
            foreach (Control item in newItemPanel.Controls)
            {
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
            }
            foreach (Control item in existingItemPanel.Controls)
            {
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
            }
        }
        #endregion Style


        private void panelOperations_AddItem_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (newItemPanel.Visible)
            {
                //Добавляем новый предмет на склад
                if (nameTextBox.Text == "" || materialTextBox.Text == "" || priceTextBox.Text == "" || storageList.SelectedItem == null)
                {
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                    int count = Queries.SearchObject("Взаиморасчеты.dbo.Товар", "item_type", nameTextBox.Text, "item_material", materialTextBox.Text);
                    if (count != 0)
                    {
                        MessageBox.Show("Товар \"" + nameTextBox.Text + " - " + materialTextBox.Text + "\" уже существует в базе данных");
                        return;
                    }

                    int storage_id = Queries.GetStorageID(storageList.SelectedItem.ToString());

                    if (Queries.CheckItemFitsStorage(storage_id, Convert.ToInt32(amountTextBox.Text)))
                    {
                        //Добавляем предмет на склад
                        Queries.AddNewItem(storage_id, nameTextBox.Text, materialTextBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(amountTextBox.Text));
                        MessageBox.Show("Добавлен новый товар: " + nameTextBox.Text + " - " + materialTextBox.Text + "\nСтоимость: " + priceTextBox.Text + "\nКоличество: " + amountTextBox.Text + "\nСклад: " + storageList.SelectedItem);
                        UpdateItemList();
                    }
                    else
                        MessageBox.Show("На складе недостаточно места");
                }
            }
            else
            {
                //Добавляем существующий предмет на склад
                if (existingItemList.SelectedItem == null || existingStorageList.SelectedItem == null || existingItemAmount.Text == "")
                {
                    errorLabel.Visible = true;
                }
                else
                {
                    int storage_id = Queries.GetStorageID(existingStorageList.SelectedItem.ToString());
                    int item_id = Queries.GetItemID(item_type, item_material);
                    errorLabel.Visible = false;

                    if (Queries.CheckItemFitsStorage(storage_id, Convert.ToInt32(existingItemAmount.Text)))
                    {
                        Queries.AddExistingItem(storage_id, item_id, Convert.ToInt32(existingItemAmount.Text));
                        MessageBox.Show("Товар \"" + item_type + " - " + item_material + "\" добавлен на склад \"" + existingStorageList.SelectedItem + "\"\nКоличество: " + existingItemAmount.Text);
                        UpdateItemList();
                    }
                    else
                        MessageBox.Show("На складе недостаточно места");
                }
            }

        }

        #region KeyPress
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void existingItemAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        #region KeyUp
        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                materialTextBox.Focus();
            }
        }

        private void materialTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                priceTextBox.Focus();
            }
            if (e.KeyValue == 38)
            {
                nameTextBox.Focus();
            }
        }

        private void priceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                amountTextBox.Focus();
            }
            if (e.KeyValue == 38)
            {
                materialTextBox.Focus();
            }
        }

        private void amountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                priceTextBox.Focus();
            }
        }



        #endregion KeyUp

        #endregion KeyPress
    }
}
