using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace DBClient
{
    public partial class MainForm : Form
    {
        public static string workMode = "simple";                            //Application work mode
        public static string journalFormat = ".log";
        public static Color appColor = Color.FromArgb(0, 102, 204);         //Application main color
        static readonly SplashScreen load = new SplashScreen();

        public MainForm()
        {
            load.Show();
            SqlConnections.OpenConnection();

            InitializeComponent();

            this.Load += mainFormStyle;
            settingsPanel.greenColorCheckBox.Click += mainFormStyle;
            settingsPanel.promekzColorCheckBox.Click += mainFormStyle;
            settingsPanel.blueColorCheckBox.Click += mainFormStyle;

            authorizationPanel.currentSessionLabel.VisibleChanged += Authorize;
            authorizationPanel.ActiveControl = authorizationPanel.loginTextBox;
            Visible = false; //close form while it loads
        }

        private void DBClient_Load(object sender, EventArgs e)
        {
            load.Hide();
            MenuOperationsButton.Visible = false;
            MenuQueriesButton.Visible = false;
            MenuStatsButton.Visible = false;
            MenuSettingsButton.Visible = false;
            logOutButton.Visible = false;
            Visible = true;
        }

        public void Refresh(Control currentObj)                              //Close previous form elements
        {
            authorizationPanel.Visible = false;
            operationsPanel.Visible = false;
            queriesPanel.Visible = false;
            settingsPanel.Visible = false;
            statsPanel.Visible = false;
            simpleOperationsPanel.Visible = false;
            ChangeStyle();
            currentObj.Visible = true;
        }

        public void Authorize(object sender, EventArgs e)
        {
            MenuOperationsButton.Visible = true;
            MenuQueriesButton.Visible = true;
            MenuStatsButton.Visible = true;
            MenuSettingsButton.Visible = true;
            logOutButton.Visible = true;
        }

        #region Style
        void mainFormStyle(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = appColor;
            //Change icons to dark
            if (appColor == Color.FromArgb(228, 231, 235)) { minimizeButton.Image = Properties.Resources.darkMinimizeIcon; exitButton.Image = Properties.Resources.darkCloseIcon; appName.ForeColor = Color.FromArgb(37, 46, 59); appLogo.Image = Properties.Resources.promekzLogoGray; }
            else { minimizeButton.Image = Properties.Resources.minimizeIcon; exitButton.Image = Properties.Resources.closeIcon; appName.ForeColor = Color.White; appLogo.Image = Properties.Resources.promekzAppLogo; }

            #region Menu Buttons Color
            void menuButtonsStyle(BunifuFlatButton button)
            {
                button.OnHoverTextColor = appColor;
                button.Activecolor = appColor;
                if (appColor == Color.FromArgb(228, 231, 235)) button.OnHoverTextColor = Color.FromArgb(37, 46, 59);
                else button.OnHoverTextColor = appColor;
            }
            menuButtonsStyle(MenuAuthorizeButton);
            menuButtonsStyle(MenuOperationsButton);
            menuButtonsStyle(MenuQueriesButton);
            menuButtonsStyle(MenuStatsButton);
            menuButtonsStyle(MenuSettingsButton);
            menuButtonsStyle(logOutButton);
            #endregion Menu Buttons Color
        }
        void menuSelectButton(BunifuFlatButton button)
        {
            if (appColor == Color.FromArgb(228, 231, 235)) { button.colselected = Color.FromArgb(37, 46, 59); }
            else { button.colselected = appColor; button.Textcolor = Color.Gainsboro; }
        }
        public void ChangeStyle()
        {
            foreach (Control item in Controls)
            {
                if (item is BunifuFlatButton)
                {
                    var temp = item as BunifuFlatButton;
                    temp.OnHoverTextColor = Color.Crimson;
                    temp.Activecolor = appColor;
                }
                if (item is PictureBox && !item.Name.Contains("Avatar"))
                    item.BackColor = appColor;
            }
            BackColor = Color.FromArgb(37, 46, 59);
        }
        #endregion Style

        #region Form Control Buttons
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion Form Control Buttons

        #region Menu
        public void hamburgerMenu_Click(object sender, EventArgs e)          //Slide Menu Animation
        {
            if (slidingMenu.Width == 70)
            {
                slidingMenu.Visible = false;
                slidingMenu.Width = 330;
                PanelAnimator.ShowSync(slidingMenu);
                LogoAnimator.ShowSync(appLogo);
            }
            else
            {
                LogoAnimator.Hide(appLogo);
                slidingMenu.Visible = false;
                slidingMenu.Width = 70;
                PanelAnimator.ShowSync(slidingMenu);
            }
        }

        #region Authorization

        private void MenuAuthorizeButton_Click(object sender, EventArgs e)   //Menu authorization button
        {
            menuSelectButton(MenuAuthorizeButton);
            Refresh(authorizationPanel);
            //if (currentSession == active) - выход из текущего аккаунта
        }

        #endregion Authorization

        #region Operations

        private void MenuOperationsButton_Click(object sender, EventArgs e)  //Menu operations button
        {
            menuSelectButton(MenuOperationsButton);
            if (workMode == "complex") Refresh(operationsPanel); else Refresh(simpleOperationsPanel);
        }

        #endregion Operations

        #region Queries

        private void MenuQueriesButton_Click(object sender, EventArgs e)     //Menu queries button
        {
            menuSelectButton(MenuQueriesButton);
            Refresh(queriesPanel);
        }

        #endregion Queries

        #region Stats
        private void MenuStatsButton_Click(object sender, EventArgs e)
        {
            menuSelectButton(MenuStatsButton);
            Refresh(statsPanel);
        }
        #endregion Stats

        #region Settings

        private void MenuSettingsButton_Click(object sender, EventArgs e)    //Menu settings button
        {
            menuSelectButton(MenuSettingsButton);
            Refresh(settingsPanel);
        }

        #endregion Settings

        #region LogOut
        private void logOutButton_Click(object sender, EventArgs e)          //Menu logOut button
        {
            SqlConnections.user = "";
            SqlConnections.journal.Clear();
            authorizationPanel.tableEditAccessLevelLabel.Visible = false;
            authorizationPanel.DBEditAccessLevelLabel.Visible = false;
            authorizationPanel.infoTextLabel4.Visible = false;
            authorizationPanel.infoTextLabel5.Visible = false;
            authorizationPanel.currentSessionLabel.Visible = false;
            menuSelectButton(logOutButton);
            MenuOperationsButton.Visible = false;
            MenuQueriesButton.Visible = false;
            MenuStatsButton.Visible = false;
            MenuSettingsButton.Visible = false;
            logOutButton.Visible = false;

            Refresh(authorizationPanel);

            //authorizationPanel.Invalidate();
            //settingsPanel.Invalidate();
            //statsPanel.Invalidate();
            //queriesPanel.Invalidate();
            //if (workMode == "complex")
            //{
            //    operationsPanel.Invalidate();
            //}
            //else
            //{
            //    simpleOperationsPanel.Invalidate();
            //}
        }
        #endregion LogOut

        #endregion Menu

        private void DBClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnections.CloseConnection();
        }

        private void workspacePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
