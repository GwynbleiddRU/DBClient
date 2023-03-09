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
    public partial class panelOperations_RemoveItem : Form
    {
        string item_type;
        string item_material;

        public panelOperations_RemoveItem()
        {
            InitializeComponent();
        }

        private void panelOperations_RemoveItem_Load(object sender, EventArgs e)
        {
            UpdateItemList();
            //ItemList.SelectedItem = ItemList.Items[0];
        }

        public void UpdateItemList()
        {
            ItemList.Items.Clear();
            SqlConnections.cmd.CommandText = "SELECT item_type, item_material FROM Товар;";
            SqlConnections.da.SelectCommand = SqlConnections.cmd;
            try
            {
                SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                while (reader.Read())
                {
                    ItemList.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

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

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItem != null)
            {
                errorLabel.Visible = false;

                if (MessageBox.Show("Вы уверены, что хотите удалить товар \"" + ItemList.SelectedItem + "\"?\nЭта операция необратима", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int item_id = Queries.GetItemID(item_type, item_material);

                    Queries.RemoveItem(item_id);
                    MessageBox.Show("Товар " + ItemList.SelectedItem.ToString() + " удален");
                    UpdateItemList();
                }
            }
            else
                errorLabel.Visible = true;
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_material = ItemList.SelectedItem.ToString().Remove(0, ItemList.SelectedItem.ToString().IndexOf(" - ") + 3);
            item_type = ItemList.SelectedItem.ToString().Remove(ItemList.SelectedItem.ToString().IndexOf(" - "));
        }

        private void panelOperations_RemoveItem_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }
    }
}
