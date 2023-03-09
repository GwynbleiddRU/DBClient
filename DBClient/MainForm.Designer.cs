namespace DBClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.slidingMenu = new System.Windows.Forms.Panel();
            this.MenuStatsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuSettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuQueriesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuOperationsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logOutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuAuthorizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hamburgerMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.appName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.authorizationPanel = new DBClient.panelAuthorization();
            this.simpleOperationsPanel = new DBClient.panelOperationsSimple();
            this.queriesPanel = new DBClient.panelQueries();
            this.operationsPanel = new DBClient.panelOperations();
            this.statsPanel = new DBClient.panelStats();
            this.settingsPanel = new DBClient.panelSettings();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.WorkSpaceAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.slidingMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelWorkspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidingMenu
            // 
            this.slidingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.slidingMenu.Controls.Add(this.MenuStatsButton);
            this.slidingMenu.Controls.Add(this.MenuSettingsButton);
            this.slidingMenu.Controls.Add(this.MenuQueriesButton);
            this.slidingMenu.Controls.Add(this.MenuOperationsButton);
            this.slidingMenu.Controls.Add(this.logOutButton);
            this.slidingMenu.Controls.Add(this.MenuAuthorizeButton);
            this.slidingMenu.Controls.Add(this.hamburgerMenu);
            this.PanelAnimator.SetDecoration(this.slidingMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.slidingMenu, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.slidingMenu, BunifuAnimatorNS.DecorationType.None);
            this.slidingMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingMenu.Location = new System.Drawing.Point(0, 57);
            this.slidingMenu.Name = "slidingMenu";
            this.slidingMenu.Size = new System.Drawing.Size(330, 677);
            this.slidingMenu.TabIndex = 0;
            // 
            // MenuStatsButton
            // 
            this.MenuStatsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuStatsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuStatsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStatsButton.BorderRadius = 0;
            this.MenuStatsButton.ButtonText = "Статистика";
            this.MenuStatsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.MenuStatsButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.MenuStatsButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MenuStatsButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuStatsButton.DisabledColor = System.Drawing.Color.Gray;
            this.MenuStatsButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStatsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MenuStatsButton.Iconimage = global::DBClient.Properties.Resources.statsIcon;
            this.MenuStatsButton.Iconimage_right = null;
            this.MenuStatsButton.Iconimage_right_Selected = null;
            this.MenuStatsButton.Iconimage_Selected = null;
            this.MenuStatsButton.IconMarginLeft = 0;
            this.MenuStatsButton.IconMarginRight = 0;
            this.MenuStatsButton.IconRightVisible = true;
            this.MenuStatsButton.IconRightZoom = 0D;
            this.MenuStatsButton.IconVisible = true;
            this.MenuStatsButton.IconZoom = 90D;
            this.MenuStatsButton.IsTab = false;
            this.MenuStatsButton.Location = new System.Drawing.Point(0, 344);
            this.MenuStatsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuStatsButton.Name = "MenuStatsButton";
            this.MenuStatsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuStatsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuStatsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuStatsButton.selected = false;
            this.MenuStatsButton.Size = new System.Drawing.Size(330, 66);
            this.MenuStatsButton.TabIndex = 11;
            this.MenuStatsButton.Text = "Статистика";
            this.MenuStatsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuStatsButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.MenuStatsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStatsButton.Click += new System.EventHandler(this.MenuStatsButton_Click);
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuSettingsButton.BorderRadius = 0;
            this.MenuSettingsButton.ButtonText = "Настройки";
            this.MenuSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.MenuSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.MenuSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MenuSettingsButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuSettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.MenuSettingsButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuSettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MenuSettingsButton.Iconimage = global::DBClient.Properties.Resources.settingsButton;
            this.MenuSettingsButton.Iconimage_right = null;
            this.MenuSettingsButton.Iconimage_right_Selected = null;
            this.MenuSettingsButton.Iconimage_Selected = null;
            this.MenuSettingsButton.IconMarginLeft = 0;
            this.MenuSettingsButton.IconMarginRight = 0;
            this.MenuSettingsButton.IconRightVisible = true;
            this.MenuSettingsButton.IconRightZoom = 0D;
            this.MenuSettingsButton.IconVisible = true;
            this.MenuSettingsButton.IconZoom = 90D;
            this.MenuSettingsButton.IsTab = false;
            this.MenuSettingsButton.Location = new System.Drawing.Point(0, 410);
            this.MenuSettingsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuSettingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuSettingsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuSettingsButton.selected = false;
            this.MenuSettingsButton.Size = new System.Drawing.Size(330, 66);
            this.MenuSettingsButton.TabIndex = 10;
            this.MenuSettingsButton.Text = "Настройки";
            this.MenuSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuSettingsButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.MenuSettingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuQueriesButton
            // 
            this.MenuQueriesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuQueriesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuQueriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuQueriesButton.BorderRadius = 0;
            this.MenuQueriesButton.ButtonText = "Запросы";
            this.MenuQueriesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.MenuQueriesButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.MenuQueriesButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MenuQueriesButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuQueriesButton.DisabledColor = System.Drawing.Color.Gray;
            this.MenuQueriesButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuQueriesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MenuQueriesButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("MenuQueriesButton.Iconimage")));
            this.MenuQueriesButton.Iconimage_right = null;
            this.MenuQueriesButton.Iconimage_right_Selected = null;
            this.MenuQueriesButton.Iconimage_Selected = null;
            this.MenuQueriesButton.IconMarginLeft = 0;
            this.MenuQueriesButton.IconMarginRight = 0;
            this.MenuQueriesButton.IconRightVisible = true;
            this.MenuQueriesButton.IconRightZoom = 0D;
            this.MenuQueriesButton.IconVisible = true;
            this.MenuQueriesButton.IconZoom = 90D;
            this.MenuQueriesButton.IsTab = false;
            this.MenuQueriesButton.Location = new System.Drawing.Point(0, 278);
            this.MenuQueriesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuQueriesButton.Name = "MenuQueriesButton";
            this.MenuQueriesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuQueriesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuQueriesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuQueriesButton.selected = false;
            this.MenuQueriesButton.Size = new System.Drawing.Size(330, 66);
            this.MenuQueriesButton.TabIndex = 9;
            this.MenuQueriesButton.Text = "Запросы";
            this.MenuQueriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuQueriesButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.MenuQueriesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQueriesButton.Click += new System.EventHandler(this.MenuQueriesButton_Click);
            // 
            // MenuOperationsButton
            // 
            this.MenuOperationsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuOperationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuOperationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuOperationsButton.BorderRadius = 0;
            this.MenuOperationsButton.ButtonText = "Операции";
            this.MenuOperationsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.MenuOperationsButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.MenuOperationsButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MenuOperationsButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuOperationsButton.DisabledColor = System.Drawing.Color.Gray;
            this.MenuOperationsButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuOperationsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MenuOperationsButton.Iconimage = global::DBClient.Properties.Resources.operationsIcon;
            this.MenuOperationsButton.Iconimage_right = null;
            this.MenuOperationsButton.Iconimage_right_Selected = null;
            this.MenuOperationsButton.Iconimage_Selected = null;
            this.MenuOperationsButton.IconMarginLeft = 0;
            this.MenuOperationsButton.IconMarginRight = 0;
            this.MenuOperationsButton.IconRightVisible = true;
            this.MenuOperationsButton.IconRightZoom = 0D;
            this.MenuOperationsButton.IconVisible = true;
            this.MenuOperationsButton.IconZoom = 90D;
            this.MenuOperationsButton.IsTab = false;
            this.MenuOperationsButton.Location = new System.Drawing.Point(0, 212);
            this.MenuOperationsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuOperationsButton.Name = "MenuOperationsButton";
            this.MenuOperationsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuOperationsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuOperationsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuOperationsButton.selected = false;
            this.MenuOperationsButton.Size = new System.Drawing.Size(330, 66);
            this.MenuOperationsButton.TabIndex = 8;
            this.MenuOperationsButton.Text = "Операции";
            this.MenuOperationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuOperationsButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.MenuOperationsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuOperationsButton.Click += new System.EventHandler(this.MenuOperationsButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutButton.BorderRadius = 0;
            this.logOutButton.ButtonText = "Выйти из аккаунта";
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.logOutButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logOutButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logOutButton, BunifuAnimatorNS.DecorationType.None);
            this.logOutButton.DisabledColor = System.Drawing.Color.Gainsboro;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logOutButton.Iconimage = global::DBClient.Properties.Resources.logOutIcon;
            this.logOutButton.Iconimage_right = null;
            this.logOutButton.Iconimage_right_Selected = null;
            this.logOutButton.Iconimage_Selected = null;
            this.logOutButton.IconMarginLeft = 0;
            this.logOutButton.IconMarginRight = 0;
            this.logOutButton.IconRightVisible = true;
            this.logOutButton.IconRightZoom = 0D;
            this.logOutButton.IconVisible = true;
            this.logOutButton.IconZoom = 90D;
            this.logOutButton.IsTab = false;
            this.logOutButton.Location = new System.Drawing.Point(0, 596);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logOutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logOutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.logOutButton.selected = false;
            this.logOutButton.Size = new System.Drawing.Size(330, 66);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.logOutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MenuAuthorizeButton
            // 
            this.MenuAuthorizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuAuthorizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuAuthorizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuAuthorizeButton.BorderRadius = 0;
            this.MenuAuthorizeButton.ButtonText = "Авторизация";
            this.MenuAuthorizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WorkSpaceAnimator.SetDecoration(this.MenuAuthorizeButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.MenuAuthorizeButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MenuAuthorizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuAuthorizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.MenuAuthorizeButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuAuthorizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MenuAuthorizeButton.Iconimage = global::DBClient.Properties.Resources.authorizationIcon;
            this.MenuAuthorizeButton.Iconimage_right = null;
            this.MenuAuthorizeButton.Iconimage_right_Selected = null;
            this.MenuAuthorizeButton.Iconimage_Selected = null;
            this.MenuAuthorizeButton.IconMarginLeft = 0;
            this.MenuAuthorizeButton.IconMarginRight = 0;
            this.MenuAuthorizeButton.IconRightVisible = true;
            this.MenuAuthorizeButton.IconRightZoom = 0D;
            this.MenuAuthorizeButton.IconVisible = true;
            this.MenuAuthorizeButton.IconZoom = 90D;
            this.MenuAuthorizeButton.IsTab = false;
            this.MenuAuthorizeButton.Location = new System.Drawing.Point(0, 146);
            this.MenuAuthorizeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MenuAuthorizeButton.Name = "MenuAuthorizeButton";
            this.MenuAuthorizeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuAuthorizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuAuthorizeButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.MenuAuthorizeButton.selected = true;
            this.MenuAuthorizeButton.Size = new System.Drawing.Size(330, 66);
            this.MenuAuthorizeButton.TabIndex = 3;
            this.MenuAuthorizeButton.Text = "Авторизация";
            this.MenuAuthorizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuAuthorizeButton.Textcolor = System.Drawing.Color.Gainsboro;
            this.MenuAuthorizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAuthorizeButton.Click += new System.EventHandler(this.MenuAuthorizeButton_Click);
            // 
            // hamburgerMenu
            // 
            this.hamburgerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.hamburgerMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.hamburgerMenu, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.hamburgerMenu, BunifuAnimatorNS.DecorationType.None);
            this.hamburgerMenu.Image = global::DBClient.Properties.Resources.hamburgerMenu;
            this.hamburgerMenu.ImageActive = null;
            this.hamburgerMenu.Location = new System.Drawing.Point(16, 36);
            this.hamburgerMenu.Name = "hamburgerMenu";
            this.hamburgerMenu.Size = new System.Drawing.Size(35, 35);
            this.hamburgerMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerMenu.TabIndex = 2;
            this.hamburgerMenu.TabStop = false;
            this.hamburgerMenu.Zoom = 10;
            this.hamburgerMenu.Click += new System.EventHandler(this.hamburgerMenu_Click);
            // 
            // appLogo
            // 
            this.WorkSpaceAnimator.SetDecoration(this.appLogo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.appLogo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.appLogo, BunifuAnimatorNS.DecorationType.None);
            this.appLogo.Image = global::DBClient.Properties.Resources.promekzAppLogo;
            this.appLogo.Location = new System.Drawing.Point(13, 9);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(40, 40);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.appName);
            this.panelHeader.Controls.Add(this.appLogo);
            this.PanelAnimator.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1146, 57);
            this.panelHeader.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.Image = global::DBClient.Properties.Resources.minimizeIcon;
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(1049, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 41);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.exitButton.Image = global::DBClient.Properties.Resources.closeIcon;
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(1095, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 20;
            this.exitButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.WorkSpaceAnimator.SetDecoration(this.appName, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.appName, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.appName, BunifuAnimatorNS.DecorationType.None);
            this.appName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(69, 17);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(206, 32);
            this.appName.TabIndex = 0;
            this.appName.Text = "СУБД - ПРОМЭКЗ";
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation3;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.authorizationPanel);
            this.panelWorkspace.Controls.Add(this.simpleOperationsPanel);
            this.panelWorkspace.Controls.Add(this.queriesPanel);
            this.panelWorkspace.Controls.Add(this.operationsPanel);
            this.panelWorkspace.Controls.Add(this.statsPanel);
            this.panelWorkspace.Controls.Add(this.settingsPanel);
            this.PanelAnimator.SetDecoration(this.panelWorkspace, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelWorkspace, BunifuAnimatorNS.DecorationType.None);
            this.WorkSpaceAnimator.SetDecoration(this.panelWorkspace, BunifuAnimatorNS.DecorationType.None);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(330, 57);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(816, 677);
            this.panelWorkspace.TabIndex = 2;
            // 
            // authorizationPanel
            // 
            this.authorizationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.authorizationPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.authorizationPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.authorizationPanel, BunifuAnimatorNS.DecorationType.None);
            this.authorizationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorizationPanel.Location = new System.Drawing.Point(0, 0);
            this.authorizationPanel.Name = "authorizationPanel";
            this.authorizationPanel.Size = new System.Drawing.Size(816, 677);
            this.authorizationPanel.TabIndex = 6;
            // 
            // simpleOperationsPanel
            // 
            this.simpleOperationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.simpleOperationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.simpleOperationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.simpleOperationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.simpleOperationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOperationsPanel.Location = new System.Drawing.Point(0, 0);
            this.simpleOperationsPanel.Name = "simpleOperationsPanel";
            this.simpleOperationsPanel.Size = new System.Drawing.Size(816, 677);
            this.simpleOperationsPanel.TabIndex = 5;
            // 
            // queriesPanel
            // 
            this.queriesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.queriesPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.queriesPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.queriesPanel, BunifuAnimatorNS.DecorationType.None);
            this.queriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queriesPanel.Location = new System.Drawing.Point(0, 0);
            this.queriesPanel.Name = "queriesPanel";
            this.queriesPanel.Size = new System.Drawing.Size(816, 677);
            this.queriesPanel.TabIndex = 4;
            // 
            // operationsPanel
            // 
            this.operationsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.operationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.operationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.operationsPanel, BunifuAnimatorNS.DecorationType.None);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsPanel.Location = new System.Drawing.Point(0, 0);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(816, 677);
            this.operationsPanel.TabIndex = 3;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.statsPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.statsPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.statsPanel, BunifuAnimatorNS.DecorationType.None);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(0, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(816, 677);
            this.statsPanel.TabIndex = 2;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WorkSpaceAnimator.SetDecoration(this.settingsPanel, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.settingsPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.settingsPanel, BunifuAnimatorNS.DecorationType.None);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(816, 677);
            this.settingsPanel.TabIndex = 1;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.LogoAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation2;
            // 
            // WorkSpaceAnimator
            // 
            this.WorkSpaceAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.WorkSpaceAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.WorkSpaceAnimator.DefaultAnimation = animation1;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panelHeader;
            this.DragControl.Vertical = true;
            // 
            // DragControl1
            // 
            this.DragControl1.Fixed = true;
            this.DragControl1.Horizontal = true;
            this.DragControl1.TargetControl = this.appName;
            this.DragControl1.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1146, 734);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.slidingMenu);
            this.Controls.Add(this.panelHeader);
            this.WorkSpaceAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDBMS - Promekz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBClient_FormClosing);
            this.Load += new System.EventHandler(this.DBClient_Load);
            this.slidingMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelWorkspace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel slidingMenu;
        private System.Windows.Forms.PictureBox appLogo;
        private Bunifu.Framework.UI.BunifuImageButton hamburgerMenu;
        private Bunifu.Framework.UI.BunifuFlatButton MenuAuthorizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel appName;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition WorkSpaceAnimator;
        public Bunifu.Framework.UI.BunifuFlatButton logOutButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        public Bunifu.Framework.UI.BunifuFlatButton MenuSettingsButton;
        public Bunifu.Framework.UI.BunifuFlatButton MenuQueriesButton;
        public Bunifu.Framework.UI.BunifuFlatButton MenuOperationsButton;
        public Bunifu.Framework.UI.BunifuFlatButton MenuStatsButton;
        private System.Windows.Forms.Panel panelWorkspace;
        private panelSettings settingsPanel;
        private panelOperationsSimple simpleOperationsPanel;
        private panelQueries queriesPanel;
        private panelOperations operationsPanel;
        public panelStats statsPanel;
        private panelAuthorization authorizationPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl1;
    }
}

