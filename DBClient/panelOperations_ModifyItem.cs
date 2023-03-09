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
    public partial class panelOperations_ModifyItem : Form
    {
        string item_type;
        string item_material;

        public panelOperations_ModifyItem()
        {
            InitializeComponent();
        }

        private void panelOperations_ModifyItem_Load(object sender, EventArgs e)
        {
            UpdateItemList();
            UpdateStorageList();

            itemList.SelectedItem = itemList.Items[0];
            storageList.SelectedItem = storageList.Items[0];
        }


        #region ComboBox
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
                    storageList.Items.Add(reader.GetValue(0).ToString());
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
            //MessageBox.Show("Тип:_" + item_type + ".\nМатериал:_" + item_material + ".");

            SqlConnections.cmd.CommandText = "SELECT item_price FROM Товар where item_material = '" + item_material + "' AND item_type = '" + item_type + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id клиента по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    nameTextBox.Text = item_type;
                    materialTextBox.Text = item_material;
                    priceTextBox.Text = reader.GetValue(0).ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

        }

        #endregion ComboBox

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
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyValue == 38)
            {
                materialTextBox.Focus();
            }
        }
        #endregion KeyUp

        #endregion KeyPress

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

        private void panelOperations_ModifyItem_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || materialTextBox.Text == "" || priceTextBox.Text == "" || storageList.SelectedItem == null || itemList.SelectedItem == null)
            {
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;

                int count = Queries.SearchObject("Взаиморасчеты.dbo.Товар", "item_type", nameTextBox.Text, "item_material", materialTextBox.Text);
                if (count != 0 && nameTextBox.Text + " - " + materialTextBox.Text != itemList.SelectedItem.ToString())
                {
                    MessageBox.Show("Товар \"" + nameTextBox.Text + " - " + materialTextBox.Text + "\" уже существует в базе данных");
                    return;
                }

                int item_id = Queries.GetItemID(item_type, item_material);

                Queries.ModifyItem(item_id, nameTextBox.Text, materialTextBox.Text, Convert.ToInt32(priceTextBox.Text));
                MessageBox.Show("Данные товара обновлены");

                UpdateItemList();
                itemList.SelectedItem = nameTextBox.Text + " - " + materialTextBox.Text;
            }
        }
    }
}
