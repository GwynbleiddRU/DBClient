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
    public partial class panelOperations_AddStorage : Form
    {
        public panelOperations_AddStorage()
        {
            InitializeComponent();
        }

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

        private void registerButton_Click(object sender, EventArgs e)
        {         
            if (nameTextBox.Text != "" && capacityTextBox.Text != "")
            {
                errorLabel.Visible = false;
                string storage_name = nameTextBox.Text;
                int count = Queries.SearchObject("Взаиморасчеты.dbo.Склад", "storage_name", nameTextBox.Text);
                if (count != 0)
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

                    if (MessageBox.Show("Склад с названием \"" + storage_name + "\"\nуже существует в базе данных\nВы хотите добавить новый\nсклад с названием \"" + new_storage_name + "\" ?", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        nameTextBox.Text = new_storage_name;
                    }
                }

                SqlConnections.cmd = new SqlCommand("INSERT INTO Взаиморасчеты.dbo.Склад VALUES ('" + nameTextBox.Text + "', " + capacityTextBox.Text + ");", SqlConnections.connection);
                SqlConnections.cmd.ExecuteNonQuery();
                MessageBox.Show("Зарегистрирован склад " + nameTextBox.Text + "\nВместимость: " + capacityTextBox.Text);
            }
            else
                errorLabel.Visible = true;
        }

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
    }
}
