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
    public partial class panelOperations_ModifyClient : Form
    {
        public panelOperations_ModifyClient()
        {
            InitializeComponent();
        }

        private void panelOperations_AddClient_Load(object sender, EventArgs e)
        {
            ChangeStyle();
            UpdateManagerList();
            UpdateClientList();

            clientList.SelectedItem = clientList.Items[0];
            managerList.SelectedItem = managerList.Items[0];
        }

        public void GetClientData()
        {
            int client_id = 1;
            //получаем id клиента по имени
            SqlConnections.cmd.CommandText = "SELECT client_id FROM Клиенты where client_name = '" + clientList.SelectedItem + "';";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                //получаем id клиента по имени
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();

                //получаем данные клиента
                int manager_id = 0;
                SqlConnections.cmd = new SqlCommand(Properties.Resources.GetClientData, SqlConnections.connection);
                SqlConnections.cmd.Parameters.AddWithValue("@client_id", client_id);

                reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    nameTextBox.Text = reader.GetValue(0).ToString();
                    phoneTextBox.Text = reader.GetValue(1).ToString();
                    emailTextBox.Text = reader.GetValue(2).ToString();
                    creditTextBox.Text = reader.GetValue(3).ToString();
                    balanceTextBox.Text = reader.GetValue(4).ToString();
                    manager_id = Convert.ToInt32(reader.GetValue(5));
                }
                reader.Close();

                managerList.SelectedItem = Queries.GetManagerName(manager_id);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        #region ComboBox
        public void UpdateClientList()
        {
            clientList.Items.Clear();
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
            clientList.Sorted = true;
        }
        public void UpdateManagerList()
        {
            managerList.Items.Clear();
            SqlConnections.cmd.CommandText = "SELECT manager_name FROM Менеджеры;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    managerList.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
            managerList.Sorted = true;
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetClientData();
        }

        #endregion ComboBox

        #region Window Buttons
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Window Buttons

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
        private void creditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(45))
            {
                e.Handled = true;
            }
        }

        #region KeyDown
        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                phoneTextBox.Focus();
            }
        }

        private void phoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                emailTextBox.Focus();
            }
            if (e.KeyValue == 38)
            {
                nameTextBox.Focus();
            }
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                creditTextBox.Focus();
            }
            if (e.KeyValue == 38)
            {
                phoneTextBox.Focus();
            }
        }

        private void creditTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                balanceTextBox.Focus();
            }
            if (e.KeyValue == 38)
            {
                emailTextBox.Focus();
            }
        }

        private void balanceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                creditTextBox.Focus();
            }
        }
        #endregion KeyDown

        #endregion KeyPress

        private void panelOperations_AddClient_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            string client_name = nameTextBox.Text;

            if (clientList.SelectedItem != null && nameTextBox.Text != "" && creditTextBox.Text != "" && balanceTextBox.Text != "" && managerList.SelectedItem != null)
            {
                int count = Queries.SearchObject("Взаиморасчеты.dbo.Клиенты", "client_name", client_name);
                if (count != 0 && client_name != clientList.SelectedItem.ToString())
                {
                    int i = 0;
                    string new_client_name = client_name;
                    do
                    {
                        i++;
                        new_client_name = client_name + " (" + i + ")";
                        count = Queries.SearchObject("Взаиморасчеты.dbo.Клиенты", "client_name", new_client_name);
                    }
                    while (count != 0);

                    if (MessageBox.Show("Клиент с именем \"" + client_name + "\"\nуже существует в базе данных\nИзменить имя на \"" + new_client_name + "\" ?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        nameTextBox.Text = new_client_name;
                    }
                }

                int client_id = Queries.GetClientID(clientList.SelectedItem.ToString());
                int manager_id = Queries.GetManagerID(managerList.SelectedItem.ToString());

                Queries.ModifyClient(client_id, nameTextBox.Text, manager_id, phoneTextBox.Text, emailTextBox.Text, Convert.ToInt32(creditTextBox.Text), Convert.ToInt32(balanceTextBox.Text));
                MessageBox.Show("Данные клиента обновлены");
                UpdateClientList();
                clientList.SelectedItem = nameTextBox.Text;
            }
            else
                errorLabel.Visible = true;
        }
    }
}
