using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data.SqlClient;
using System.Threading;

namespace DBClient
{
    public partial class panelAuthorization : UserControl
    {
        MainForm mainForm;

        public panelAuthorization()
        {
            InitializeComponent();
        }

        public panelAuthorization(Form parent)
        {
            InitializeComponent();
            mainForm = (MainForm)parent;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            SqlConnections.OpenConnection();
            SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);
            SqlConnections.da = new SqlDataAdapter(SqlConnections.cmd);
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == ""))
            {
                authorizeErrorLabel.Visible = true;
                authorizeErrorLabel2.Visible = false;
            }
            else
            {
                authorizeErrorLabel.Visible = false;
                //если пользователь существует
                try
                {
                    SqlConnections.sql = string.Format("SELECT manager_name FROM Менеджеры " +
                                                       "WHERE manager_login = '" + loginTextBox.Text + "' AND manager_password = '" + passwordTextBox.Text + "';");

                    SqlConnections.cmd = new SqlCommand(SqlConnections.sql, SqlConnections.connection);
                    SqlConnections.da.SelectCommand = SqlConnections.cmd;

                    if (SqlConnections.cmd.ExecuteScalar() != null)
                    {
                        //SqlCommand getName = new SqlCommand("Select manager_name from dbo.Менеджеры Where manager_login =\"" + loginTextBox.Text + "\""
                        //+ "AND manager_password =\"" + passwordTextBox.Text + "\"", SqlConnections.connection);
                        SqlDataReader reader = SqlConnections.cmd.ExecuteReader();
                        while (reader.Read()) { MessageBox.Show("Добро пожаловать, " + reader.GetValue(0) + "!"); SqlConnections.user = Convert.ToString(reader.GetValue(0)); currentSessionLabel.Text = "Вы вошли как \n" + reader.GetValue(0).ToString(); }
                        reader.Close();

                        tableEditAccessLevelLabel.Visible = true;
                        DBEditAccessLevelLabel.Visible = true;
                        infoTextLabel4.Visible = true;
                        infoTextLabel5.Visible = true;

                        currentSessionLabel.Visible = true;

                        #region Rights
                        SqlConnections.cmd.CommandText = "SELECT manager_access_level FROM Менеджеры " +
                                                         "WHERE manager_login = '" + loginTextBox.Text + "' AND manager_password = '" + passwordTextBox.Text + "';";
                        SqlConnections.da.SelectCommand = SqlConnections.cmd;
                        try
                        {
                            SqlDataReader readerRights = SqlConnections.cmd.ExecuteReader();
                            while (readerRights.Read())
                            {
                                SqlConnections.rights = readerRights.GetValue(0).ToString();
                            }
                            readerRights.Close();
                        }
                        catch
                        {
                        }
                        #endregion Rights
                       
                        if (SqlConnections.rights == "user")
                            DBEditAccessLevelLabel.Text = "Недоступно";
                        else
                            DBEditAccessLevelLabel.Text = "Доступно";

                        passwordTextBox.Text = "";
                        SqlConnections.journal.AppendLine("Сессия: " + DateTime.Now.ToString("dd.MM.yyyy, HH.mm") + " \tПользователь: " + SqlConnections.user + "\n");
                    }
                    else
                        authorizeErrorLabel2.Visible = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        #region Style

        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox && !item.Name.Contains("Avatar"))
                    item.BackColor = MainForm.appColor;
                if (item is BunifuMaterialTextbox)
                {
                    var temp = item as BunifuMaterialTextbox;
                    temp.LineFocusedColor = MainForm.appColor;
                    temp.LineMouseHoverColor = MainForm.appColor;
                }
                if (item.Name.Contains("header"))
                    item.ForeColor = MainForm.appColor;
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }

        #endregion Style

        private void Authorization_VisibleChanged(object sender, EventArgs e)
        {
            ChangeStyle();
        }

        #region KeyDown

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 40)
            {
                passwordTextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                authorizeButton_Click(sender, e);
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                loginTextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                authorizeButton_Click(sender, e);
            }
        }

        #endregion KeyDown

        private void passwordTextBox_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox.isPassword = true;
        }
    }
}
