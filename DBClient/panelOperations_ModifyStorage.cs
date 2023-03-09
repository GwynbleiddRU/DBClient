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
    public partial class panelOperations_ModifyStorage : Form
    {
        int item_amount;
        string item_type, item_material;

        public panelOperations_ModifyStorage()
        {
            InitializeComponent();
            UpdateStoragetList();

            storageList.SelectedItem = storageList.Items[0];
        }

        #region ComboBox
        public void UpdateStoragetList()
        {
            storageList.Items.Clear();
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

        public void UpdateStorageItemsListBox()
        {
            storageItemsListBox.Items.Clear();
            int storage_id = Queries.GetStorageID(storageList.SelectedItem.ToString());

            SqlConnections.cmd.CommandText = "SELECT item_type, item_material, item_amount FROM Товар INNER JOIN Содержимое_склада ON Товар.item_id = Содержимое_склада.item_id WHERE storage_id = " + storage_id + ";";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    storageItemsListBox.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " - " + reader.GetValue(2).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }
        private void storageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Fill Data
            SqlConnections.cmd.CommandText = "SELECT storage_capacity FROM Склад where storage_name = '" + storageList.SelectedItem.ToString() + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id клиента по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    nameTextBox.Text = storageList.SelectedItem.ToString();
                    capacityTextBox.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
            #endregion Fill Data

            UpdateStorageItemsListBox();
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
            }
        }
        #endregion Style

        #region KeyPress
        private void capacityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        #region KeyDown
        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                capacityTextBox.Focus();
            }
        }

        private void capacityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                nameTextBox.Focus();
            }
        }
        #endregion KeyDown

        #endregion KeyPress 

        private void panelOperations_AddStorage_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (storageList.SelectedItem != null && nameTextBox.Text != "" && capacityTextBox.Text != "")
            {
                errorLabel.Visible = false;

                string storage_name = nameTextBox.Text;
                int count = Queries.SearchObject("Взаиморасчеты.dbo.Склад", "storage_name", nameTextBox.Text);
                if (count != 0 && storage_name != storageList.SelectedItem.ToString())
                {
                    int i = 0;
                    string new_storage_name = storage_name;
                    do
                    {
                        i++;
                        new_storage_name = storage_name + " (" + i + ")";
                        count = Queries.SearchObject("Взаиморасчеты.dbo.Склад", "storage_name", new_storage_name);
                    }
                    while (count != 0);

                    if (MessageBox.Show("Склад с названием \"" + storage_name + "\"\nуже существует в базе данных\nИзменить название на \"" + new_storage_name + "\" ?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        nameTextBox.Text = new_storage_name;
                    }
                }

                int storage_id = Queries.GetStorageID(storageList.SelectedItem.ToString());

                Queries.ModifyStorage(storage_id, nameTextBox.Text, Convert.ToInt32(capacityTextBox.Text));
                MessageBox.Show("Данные склада \"" + storageList.SelectedItem.ToString() + "\" обновлены\n\nНовые данные:\nНазвание: \"" + nameTextBox.Text + "\"\nВместимость: " + capacityTextBox.Text);
                UpdateStoragetList();
            }
            else
                errorLabel.Visible = true;
        }

        #region ContextMenu
        private void storageItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && storageItemsListBox.SelectedIndex >= 0)
            {
                if (storageItemsListBox.GetItemRectangle(storageItemsListBox.SelectedIndex).Contains(e.Location))
                {
                    storageItemsListBox.SelectedIndex = storageItemsListBox.IndexFromPoint(e.X, e.Y);

                    contextMenuStrip.Show(storageItemsListBox, new Point(e.X, e.Y));

                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item_type = storageItemsListBox.SelectedItem.ToString().Remove(storageItemsListBox.SelectedItem.ToString().IndexOf(" - "));
            string item_material_amount = storageItemsListBox.SelectedItem.ToString().Remove(0, storageItemsListBox.SelectedItem.ToString().IndexOf(" - ") + 3);
            item_material = item_material_amount.Remove(item_material_amount.IndexOf(" - "));
            item_amount = Convert.ToInt32(item_material_amount.Remove(0, item_material_amount.IndexOf(" - ") + 3));

            int storage_id = Queries.GetStorageID(storageList.SelectedItem.ToString());
            int item_id = Queries.GetItemID(item_type, item_material);

            Queries.RemoveItemFromStorage(storage_id, item_id, item_amount);

            UpdateStorageItemsListBox();
            MessageBox.Show("Товар \"" + item_type + " - " + item_material + "\"\nв объеме " + item_amount + " шт.\nудален со склада \"" + storageList.SelectedItem.ToString() + "\"");
        }
        #endregion ContextMenu

    }
}
